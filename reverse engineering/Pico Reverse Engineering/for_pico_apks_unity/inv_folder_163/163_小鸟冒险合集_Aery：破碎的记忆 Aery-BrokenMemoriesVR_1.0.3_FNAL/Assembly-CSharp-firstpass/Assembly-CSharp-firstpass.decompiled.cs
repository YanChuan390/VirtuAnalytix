using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using DarkTonic.MasterAudio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x5212EC", Offset = "0x5212EC")]
public class ListenerFollower : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform _transToFollow;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x17000001")]
	public GameObject GameObj
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x6F4130", Offset = "0x6F4130", VA = "0x6F4130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public Transform Trans
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x6F3CEC", Offset = "0x6F3CEC", VA = "0x6F3CEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x6F3A88", Offset = "0x6F3A88", VA = "0x6F3A88")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x6F3A8C", Offset = "0x6F3A8C", VA = "0x6F3A8C")]
	public void StartFollowing(Transform transToFollow, float trigRadius)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x6F3AD4", Offset = "0x6F3AD4", VA = "0x6F3AD4")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x6F3B98", Offset = "0x6F3B98", VA = "0x6F3B98")]
	private void BatchOcclusionRaycasts()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x6F41D0", Offset = "0x6F41D0", VA = "0x6F41D0")]
	public ListenerFollower()
	{
	}
}
[Token(Token = "0x2000003")]
public static class OculusAudioHelper
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0xE183B8", Offset = "0xE183B8", VA = "0xE183B8")]
	public static bool DarkTonicOculusAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE183C0", Offset = "0xE183C0", VA = "0xE183C0")]
	public static void AddOculusAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xE183C4", Offset = "0xE183C4", VA = "0xE183C4")]
	public static void AddOculusAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xE183C8", Offset = "0xE183C8", VA = "0xE183C8")]
	public static void RemoveOculusAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xE183CC", Offset = "0xE183CC", VA = "0xE183CC")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xE183D0", Offset = "0xE183D0", VA = "0xE183D0")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xE183D4", Offset = "0xE183D4", VA = "0xE183D4")]
	public static void CopyOculusAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x2000004")]
public static class ResonanceAudioHelper
{
	[Token(Token = "0x17000003")]
	public static bool ResonanceAudioOptionExists
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0xE23760", Offset = "0xE23760", VA = "0xE23760")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xE23768", Offset = "0xE23768", VA = "0xE23768")]
	public static bool DarkTonicResonanceAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xE23770", Offset = "0xE23770", VA = "0xE23770")]
	public static void AddResonanceAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xE23774", Offset = "0xE23774", VA = "0xE23774")]
	public static void AddResonanceAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xE23778", Offset = "0xE23778", VA = "0xE23778")]
	public static void RemoveResonanceAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xE2377C", Offset = "0xE2377C", VA = "0xE2377C")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xE23780", Offset = "0xE23780", VA = "0xE23780")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xE23784", Offset = "0xE23784", VA = "0xE23784")]
	public static void CopyResonanceAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x2000005")]
public class TransformFollower : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x521BFC", Offset = "0x521BFC")]
	public Transform RuntimeFollowingTransform;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string _soundType;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _variationName;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool _willFollowSource;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool _isInsideTrigger;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	private bool _hasPlayedSound;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float _playVolume;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _positionAtClosestColliderPoint;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private MasterAudio.AmbientSoundExitMode _exitMode;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float _exitFadeTime;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private MasterAudio.AmbientSoundReEnterMode _reEnterMode;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float _reEnterFadeTime;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 _lastListenerPos;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private PlaySoundResult playingVariation;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private PlaySoundResult fadingVariation;

	[Token(Token = "0x17000004")]
	public GameObject GameObj
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0xDA49FC", Offset = "0xDA49FC", VA = "0xDA49FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	public Transform Trans
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0xDA5004", Offset = "0xDA5004", VA = "0xDA5004")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xDA4408", Offset = "0xDA4408", VA = "0xDA4408")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xDA4454", Offset = "0xDA4454", VA = "0xDA4454")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xDA4638", Offset = "0xDA4638", VA = "0xDA4638")]
	public void StartFollowing(Transform transToFollow, string soundType, string variationName, float volume, float trigRadius, bool willFollowSource, bool positionAtClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xDA4978", Offset = "0xDA4978", VA = "0xDA4978")]
	private void StopFollowing()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xDA4A9C", Offset = "0xDA4A9C", VA = "0xDA4A9C")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xDA4F14", Offset = "0xDA4F14", VA = "0xDA4F14")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xDA48D0", Offset = "0xDA48D0", VA = "0xDA48D0")]
	public bool RecalcClosestColliderPosition(bool forceRecalc = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xDA44C0", Offset = "0xDA44C0", VA = "0xDA44C0")]
	private void PerformTriggerExit()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xDA50A4", Offset = "0xDA50A4", VA = "0xDA50A4")]
	public TransformFollower()
	{
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x521300", Offset = "0x521300")]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x9855D8", Offset = "0x9855D8", VA = "0x9855D8")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x521314", Offset = "0x521314")]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0xE23750", Offset = "0xE23750", VA = "0xE23750")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x521328", Offset = "0x521328")]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0xE23758", Offset = "0xE23758", VA = "0xE23758")]
		public RelatingAttribute()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.ThirdParty.LibTessDotNet
{
	[Token(Token = "0x2000009")]
	internal class Dict<TValue> where TValue : class
	{
		[Token(Token = "0x200000A")]
		public class Node
		{
			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _prev;

			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _next;

			[Token(Token = "0x17000006")]
			public TValue Key
			{
				[Token(Token = "0x600002B")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000007")]
			public Node Prev
			{
				[Token(Token = "0x600002C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000008")]
			public Node Next
			{
				[Token(Token = "0x600002D")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600002E")]
			public Node()
			{
			}
		}

		[Token(Token = "0x200000B")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Node _head;

		[Token(Token = "0x6000025")]
		public Dict(LessOrEqual leq)
		{
		}

		[Token(Token = "0x6000026")]
		public Node Insert(TValue key)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		public Node InsertBefore(Node node, TValue key)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		public Node Find(TValue key)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		public Node Min()
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		public void Remove(Node node)
		{
		}
	}
	[Token(Token = "0x200000C")]
	internal static class Geom
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x6F1AAC", Offset = "0x6F1AAC", VA = "0x6F1AAC")]
		public static bool IsWindingInside(WindingRule rule, int n)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x6F1B58", Offset = "0x6F1B58", VA = "0x6F1B58")]
		public static bool VertCCW(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x6F1BAC", Offset = "0x6F1BAC", VA = "0x6F1BAC")]
		public static bool VertEq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x6F1BF0", Offset = "0x6F1BF0", VA = "0x6F1BF0")]
		public static bool VertLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x6F1C40", Offset = "0x6F1C40", VA = "0x6F1C40")]
		public static float EdgeEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x6F1CB4", Offset = "0x6F1CB4", VA = "0x6F1CB4")]
		public static float EdgeSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x6F1D18", Offset = "0x6F1D18", VA = "0x6F1D18")]
		public static bool TransLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x6F1D68", Offset = "0x6F1D68", VA = "0x6F1D68")]
		public static float TransEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x6F1DDC", Offset = "0x6F1DDC", VA = "0x6F1DDC")]
		public static float TransSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x6F1E40", Offset = "0x6F1E40", VA = "0x6F1E40")]
		public static bool EdgeGoesLeft(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x6F1E70", Offset = "0x6F1E70", VA = "0x6F1E70")]
		public static bool EdgeGoesRight(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x6F1EA4", Offset = "0x6F1EA4", VA = "0x6F1EA4")]
		public static float VertL1dist(MeshUtils.Vertex u, MeshUtils.Vertex v)
		{
			return default(float);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x6F1F3C", Offset = "0x6F1F3C", VA = "0x6F1F3C")]
		public static void AddWinding(MeshUtils.Edge eDst, MeshUtils.Edge eSrc)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x6F1F88", Offset = "0x6F1F88", VA = "0x6F1F88")]
		public static float Interpolate(float a, float x, float b, float y)
		{
			return default(float);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x6F1FE4", Offset = "0x6F1FE4", VA = "0x6F1FE4")]
		private static void Swap(ref MeshUtils.Vertex a, ref MeshUtils.Vertex b)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x6F201C", Offset = "0x6F201C", VA = "0x6F201C")]
		public static void EdgeIntersect(MeshUtils.Vertex o1, MeshUtils.Vertex d1, MeshUtils.Vertex o2, MeshUtils.Vertex d2, MeshUtils.Vertex v)
		{
		}
	}
	[Token(Token = "0x200000D")]
	internal class LTMesh : MeshUtils.Pooled<LTMesh>
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal MeshUtils.Vertex _vHead;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal MeshUtils.Face _fHead;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal MeshUtils.Edge _eHead;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal MeshUtils.Edge _eHeadSym;

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x6F2D3C", Offset = "0x6F2D3C", VA = "0x6F2D3C")]
		public LTMesh()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x6F2F98", Offset = "0x6F2F98", VA = "0x6F2F98", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x6F2FEC", Offset = "0x6F2FEC", VA = "0x6F2FEC", Slot = "5")]
		public override void OnFree()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x6F3100", Offset = "0x6F3100", VA = "0x6F3100")]
		public MeshUtils.Edge MakeEdge()
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x6F3164", Offset = "0x6F3164", VA = "0x6F3164")]
		public void Splice(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x6F3254", Offset = "0x6F3254", VA = "0x6F3254")]
		public void Delete(MeshUtils.Edge eDel)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x6F33F0", Offset = "0x6F33F0", VA = "0x6F33F0")]
		public MeshUtils.Edge AddEdgeVertex(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x6F3498", Offset = "0x6F3498", VA = "0x6F3498")]
		public MeshUtils.Edge SplitEdge(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x6F3574", Offset = "0x6F3574", VA = "0x6F3574")]
		public MeshUtils.Edge Connect(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x6F3690", Offset = "0x6F3690", VA = "0x6F3690")]
		public void ZapFace(MeshUtils.Face fZap)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x6F3808", Offset = "0x6F3808", VA = "0x6F3808")]
		public void MergeConvexFaces(int maxVertsPerFace)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x6F396C", Offset = "0x6F396C", VA = "0x6F396C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x522B48", Offset = "0x522B48")]
		public void Check()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x52133C", Offset = "0x52133C")]
	public struct Vec3
	{
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vec3 Zero;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float X;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Y;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Z;

		[Token(Token = "0x17000009")]
		public float Item
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0xDA242C", Offset = "0xDA242C", VA = "0xDA242C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0xDA1FA0", Offset = "0xDA1FA0", VA = "0xDA1FA0")]
			set
			{
			}
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xDA1E68", Offset = "0xDA1E68", VA = "0xDA1E68")]
		public static void Sub(ref Vec3 lhs, ref Vec3 rhs, out Vec3 result)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xDA211C", Offset = "0xDA211C", VA = "0xDA211C")]
		public static void Neg(ref Vec3 v)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xDA2494", Offset = "0xDA2494", VA = "0xDA2494")]
		public static void Dot(ref Vec3 u, ref Vec3 v, out float dot)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xDA6C4C", Offset = "0xDA6C4C", VA = "0xDA6C4C")]
		public static void Normalize(ref Vec3 v)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xDA1E9C", Offset = "0xDA1E9C", VA = "0xDA1E9C")]
		public static int LongAxis(ref Vec3 v)
		{
			return default(int);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xDA6D00", Offset = "0xDA6D00", VA = "0xDA6D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200000F")]
	internal static class MeshUtils
	{
		[Token(Token = "0x2000010")]
		public abstract class Pooled<T> where T : Pooled<T>, new()
		{
			[Token(Token = "0x4000025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Stack<T> _stack;

			[Token(Token = "0x6000060")]
			public abstract void Reset();

			[Token(Token = "0x6000061")]
			public virtual void OnFree()
			{
			}

			[Token(Token = "0x6000062")]
			public static T Create()
			{
				return null;
			}

			[Token(Token = "0x6000063")]
			public void Free()
			{
			}

			[Token(Token = "0x6000064")]
			protected Pooled()
			{
			}
		}

		[Token(Token = "0x2000011")]
		public class Vertex : Pooled<Vertex>
		{
			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Vertex _prev;

			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Vertex _next;

			[Token(Token = "0x4000028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Vec3 _coords;

			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal float _s;

			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal float _t;

			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal PQHandle _pqHandle;

			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int _n;

			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal object _data;

			[Token(Token = "0x6000065")]
			[Address(RVA = "0xDA9D54", Offset = "0xDA9D54", VA = "0xDA9D54", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000066")]
			[Address(RVA = "0xDA9E0C", Offset = "0xDA9E0C", VA = "0xDA9E0C")]
			public Vertex()
			{
			}
		}

		[Token(Token = "0x2000012")]
		public class Face : Pooled<Face>
		{
			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Face _prev;

			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Face _next;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Face _trail;

			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal int _n;

			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal bool _marked;

			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
			internal bool _inside;

			[Token(Token = "0x1700000A")]
			internal int VertsCount
			{
				[Token(Token = "0x6000067")]
				[Address(RVA = "0xDA9C74", Offset = "0xDA9C74", VA = "0xDA9C74")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000068")]
			[Address(RVA = "0xDA9CA8", Offset = "0xDA9CA8", VA = "0xDA9CA8", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000069")]
			[Address(RVA = "0xDA9D08", Offset = "0xDA9D08", VA = "0xDA9D08")]
			public Face()
			{
			}
		}

		[Token(Token = "0x2000013")]
		public struct EdgePair
		{
			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Edge _e;

			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Edge _eSym;

			[Token(Token = "0x600006A")]
			[Address(RVA = "0xDA9BAC", Offset = "0xDA9BAC", VA = "0xDA9BAC")]
			public static EdgePair Create()
			{
				return default(EdgePair);
			}

			[Token(Token = "0x600006B")]
			[Address(RVA = "0xDA9B2C", Offset = "0xDA9B2C", VA = "0xDA9B2C")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000014")]
		public class Edge : Pooled<Edge>
		{
			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal EdgePair _pair;

			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _next;

			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Edge _Sym;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Edge _Onext;

			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Edge _Lnext;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Vertex _Org;

			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Face _Lface;

			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Tess.ActiveRegion _activeRegion;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal int _winding;

			[Token(Token = "0x1700000B")]
			internal Face _Rface
			{
				[Token(Token = "0x600006C")]
				[Address(RVA = "0xDA00C4", Offset = "0xDA00C4", VA = "0xDA00C4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600006D")]
				[Address(RVA = "0xDA9914", Offset = "0xDA9914", VA = "0xDA9914")]
				set
				{
				}
			}

			[Token(Token = "0x1700000C")]
			internal Vertex _Dst
			{
				[Token(Token = "0x600006E")]
				[Address(RVA = "0xD9F024", Offset = "0xD9F024", VA = "0xD9F024")]
				get
				{
					return null;
				}
				[Token(Token = "0x600006F")]
				[Address(RVA = "0xDA9930", Offset = "0xDA9930", VA = "0xDA9930")]
				set
				{
				}
			}

			[Token(Token = "0x1700000D")]
			internal Edge _Oprev
			{
				[Token(Token = "0x6000070")]
				[Address(RVA = "0xD9F540", Offset = "0xD9F540", VA = "0xD9F540")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000071")]
				[Address(RVA = "0xDA994C", Offset = "0xDA994C", VA = "0xDA994C")]
				set
				{
				}
			}

			[Token(Token = "0x1700000E")]
			internal Edge _Lprev
			{
				[Token(Token = "0x6000072")]
				[Address(RVA = "0xD9F524", Offset = "0xD9F524", VA = "0xD9F524")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000073")]
				[Address(RVA = "0xDA9968", Offset = "0xDA9968", VA = "0xDA9968")]
				set
				{
				}
			}

			[Token(Token = "0x1700000F")]
			internal Edge _Dprev
			{
				[Token(Token = "0x6000074")]
				[Address(RVA = "0xDA9984", Offset = "0xDA9984", VA = "0xDA9984")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000075")]
				[Address(RVA = "0xDA99A0", Offset = "0xDA99A0", VA = "0xDA99A0")]
				set
				{
				}
			}

			[Token(Token = "0x17000010")]
			internal Edge _Rprev
			{
				[Token(Token = "0x6000076")]
				[Address(RVA = "0xD9F730", Offset = "0xD9F730", VA = "0xD9F730")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000077")]
				[Address(RVA = "0xDA99BC", Offset = "0xDA99BC", VA = "0xDA99BC")]
				set
				{
				}
			}

			[Token(Token = "0x17000011")]
			internal Edge _Dnext
			{
				[Token(Token = "0x6000078")]
				[Address(RVA = "0xDA0DE8", Offset = "0xDA0DE8", VA = "0xDA0DE8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000079")]
				[Address(RVA = "0xDA99D8", Offset = "0xDA99D8", VA = "0xDA99D8")]
				set
				{
				}
			}

			[Token(Token = "0x17000012")]
			internal Edge _Rnext
			{
				[Token(Token = "0x600007A")]
				[Address(RVA = "0xDA9A00", Offset = "0xDA9A00", VA = "0xDA9A00")]
				get
				{
					return null;
				}
				[Token(Token = "0x600007B")]
				[Address(RVA = "0xDA9A28", Offset = "0xDA9A28", VA = "0xDA9A28")]
				set
				{
				}
			}

			[Token(Token = "0x600007C")]
			[Address(RVA = "0xDA9A50", Offset = "0xDA9A50", VA = "0xDA9A50")]
			internal static void EnsureFirst(ref Edge e)
			{
			}

			[Token(Token = "0x600007D")]
			[Address(RVA = "0xDA9A80", Offset = "0xDA9A80", VA = "0xDA9A80", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x600007E")]
			[Address(RVA = "0xDA9B60", Offset = "0xDA9B60", VA = "0xDA9B60")]
			public Edge()
			{
			}
		}

		[Token(Token = "0x4000024")]
		public const int Undef = -1;

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xE16F60", Offset = "0xE16F60", VA = "0xE16F60")]
		public static Edge MakeEdge(Edge eNext)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xE170E0", Offset = "0xE170E0", VA = "0xE170E0")]
		public static void Splice(Edge a, Edge b)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xE17170", Offset = "0xE17170", VA = "0xE17170")]
		public static void MakeVertex(Edge eOrig, Vertex vNext)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xE17260", Offset = "0xE17260", VA = "0xE17260")]
		public static void MakeFace(Edge eOrig, Face fNext)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xE17370", Offset = "0xE17370", VA = "0xE17370")]
		public static void KillEdge(Edge eDel)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xE17424", Offset = "0xE17424", VA = "0xE17424")]
		public static void KillVertex(Vertex vDel, Vertex newOrg)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xE174DC", Offset = "0xE174DC", VA = "0xE174DC")]
		public static void KillFace(Face fDel, Face newLFace)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xE17594", Offset = "0xE17594", VA = "0xE17594")]
		public static float FaceArea(Face f)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000015")]
	internal struct PQHandle
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int Invalid;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int _handle;
	}
	[Token(Token = "0x2000016")]
	internal class PriorityHeap<TValue> where TValue : class
	{
		[Token(Token = "0x2000017")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x2000018")]
		protected class HandleElem
		{
			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int _node;

			[Token(Token = "0x600008D")]
			public HandleElem()
			{
			}
		}

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _nodes;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HandleElem[] _handles;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _freeList;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x17000013")]
		public bool Empty
		{
			[Token(Token = "0x6000080")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000081")]
		public PriorityHeap(int initialSize, LessOrEqual leq)
		{
		}

		[Token(Token = "0x6000082")]
		private void FloatDown(int curr)
		{
		}

		[Token(Token = "0x6000083")]
		private void FloatUp(int curr)
		{
		}

		[Token(Token = "0x6000084")]
		public void Init()
		{
		}

		[Token(Token = "0x6000085")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x6000086")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x2000019")]
	internal class PriorityQueue<TValue> where TValue : class
	{
		[Token(Token = "0x200001A")]
		private class StackItem
		{
			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int p;

			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int r;

			[Token(Token = "0x6000096")]
			public StackItem()
			{
			}
		}

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue>.LessOrEqual _leq;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue> _heap;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TValue[] _keys;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _order;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x17000014")]
		public bool Empty
		{
			[Token(Token = "0x600008E")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600008F")]
		public PriorityQueue(int initialSize, PriorityHeap<TValue>.LessOrEqual leq)
		{
		}

		[Token(Token = "0x6000090")]
		private static void Swap(ref int a, ref int b)
		{
		}

		[Token(Token = "0x6000091")]
		public void Init()
		{
		}

		[Token(Token = "0x6000092")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x6000093")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class Tess
	{
		[Token(Token = "0x200001C")]
		internal class ActiveRegion
		{
			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal MeshUtils.Edge _eUp;

			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Dict<ActiveRegion>.Node _nodeUp;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int _windingNumber;

			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal bool _inside;

			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			internal bool _sentinel;

			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
			internal bool _dirty;

			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
			internal bool _fixUpperEdge;

			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xD9F330", Offset = "0xD9F330", VA = "0xD9F330")]
			public ActiveRegion()
			{
			}
		}

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LTMesh _mesh;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vec3 _normal;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vec3 _sUnit;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vec3 _tUnit;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _bminX;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _bminY;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _bmaxX;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _bmaxY;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private WindingRule _windingRule;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dict<ActiveRegion> _dict;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PriorityQueue<MeshUtils.Vertex> _pq;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshUtils.Vertex _event;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CombineCallback _combineCallback;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ContourVertex[] _vertices;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _vertexCount;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int[] _elements;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _elementCount;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float SUnitX;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float SUnitY;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float SentinelCoord;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool NoEmptyPolygons;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool UsePooling;

		[Token(Token = "0x17000015")]
		public Vec3 Normal
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0xDA1638", Offset = "0xDA1638", VA = "0xDA1638")]
			get
			{
				return default(Vec3);
			}
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0xDA1644", Offset = "0xDA1644", VA = "0xDA1644")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public ContourVertex[] Vertices
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xDA1650", Offset = "0xDA1650", VA = "0xDA1650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public int VertexCount
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0xDA1658", Offset = "0xDA1658", VA = "0xDA1658")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000018")]
		public int[] Elements
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xDA1660", Offset = "0xDA1660", VA = "0xDA1660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public int ElementCount
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0xDA1668", Offset = "0xDA1668", VA = "0xDA1668")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xD9EEA4", Offset = "0xD9EEA4", VA = "0xD9EEA4")]
		private ActiveRegion RegionBelow(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xD9EED0", Offset = "0xD9EED0", VA = "0xD9EED0")]
		private ActiveRegion RegionAbove(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xD9EEFC", Offset = "0xD9EEFC", VA = "0xD9EEFC")]
		private bool EdgeLeq(ActiveRegion reg1, ActiveRegion reg2)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xD9F040", Offset = "0xD9F040", VA = "0xD9F040")]
		private void DeleteRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xD9F0BC", Offset = "0xD9F0BC", VA = "0xD9F0BC")]
		private void FixUpperEdge(ActiveRegion reg, MeshUtils.Edge newEdge)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xD9F128", Offset = "0xD9F128", VA = "0xD9F128")]
		private ActiveRegion TopLeftRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xD9F1F0", Offset = "0xD9F1F0", VA = "0xD9F1F0")]
		private ActiveRegion TopRightRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xD9F250", Offset = "0xD9F250", VA = "0xD9F250")]
		private ActiveRegion AddRegionBelow(ActiveRegion regAbove, MeshUtils.Edge eNewUp)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xD9F338", Offset = "0xD9F338", VA = "0xD9F338")]
		private void ComputeWinding(ActiveRegion reg)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xD9F394", Offset = "0xD9F394", VA = "0xD9F394")]
		private void FinishRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xD9F3E4", Offset = "0xD9F3E4", VA = "0xD9F3E4")]
		private MeshUtils.Edge FinishLeftRegions(ActiveRegion regFirst, ActiveRegion regLast)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xD9F55C", Offset = "0xD9F55C", VA = "0xD9F55C")]
		private void AddRightEdges(ActiveRegion regUp, MeshUtils.Edge eFirst, MeshUtils.Edge eLast, MeshUtils.Edge eTopLeft, bool cleanUp)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xD9FB44", Offset = "0xD9FB44", VA = "0xD9FB44")]
		private void SpliceMergeVertices(MeshUtils.Edge e1, MeshUtils.Edge e2)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xD9FB60", Offset = "0xD9FB60", VA = "0xD9FB60")]
		private void VertexWeights(MeshUtils.Vertex isect, MeshUtils.Vertex org, MeshUtils.Vertex dst, out float w0, out float w1)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xD9FC64", Offset = "0xD9FC64", VA = "0xD9FC64")]
		private void GetIntersectData(MeshUtils.Vertex isect, MeshUtils.Vertex orgUp, MeshUtils.Vertex dstUp, MeshUtils.Vertex orgLo, MeshUtils.Vertex dstLo)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xD9F74C", Offset = "0xD9F74C", VA = "0xD9F74C")]
		private bool CheckForRightSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xD9FF30", Offset = "0xD9FF30", VA = "0xD9FF30")]
		private bool CheckForLeftSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xDA00E0", Offset = "0xDA00E0", VA = "0xDA00E0")]
		private bool CheckForIntersect(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xD9F904", Offset = "0xD9F904", VA = "0xD9F904")]
		private void WalkDirtyRegions(ActiveRegion regUp)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xDA0790", Offset = "0xDA0790", VA = "0xDA0790")]
		private void ConnectRightVertex(ActiveRegion regUp, MeshUtils.Edge eBottomLeft)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xDA09A8", Offset = "0xDA09A8", VA = "0xDA09A8")]
		private void ConnectLeftDegenerate(ActiveRegion regUp, MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xDA0B94", Offset = "0xDA0B94", VA = "0xDA0B94")]
		private void ConnectLeftVertex(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xDA0AB4", Offset = "0xDA0AB4", VA = "0xDA0AB4")]
		private void SweepEvent(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xDA0E10", Offset = "0xDA0E10", VA = "0xDA0E10")]
		private void AddSentinel(float smin, float smax, float t)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xDA0F54", Offset = "0xDA0F54", VA = "0xDA0F54")]
		private void InitEdgeDict()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xDA1058", Offset = "0xDA1058", VA = "0xDA1058")]
		private void DoneEdgeDict()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xDA10EC", Offset = "0xDA10EC", VA = "0xDA10EC")]
		private void RemoveDegenerateEdges()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xDA1244", Offset = "0xDA1244", VA = "0xDA1244")]
		private void InitPriorityQ()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xDA145C", Offset = "0xDA145C", VA = "0xDA145C")]
		private void DonePriorityQ()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xDA1468", Offset = "0xDA1468", VA = "0xDA1468")]
		private void RemoveDegenerateFaces()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xDA1508", Offset = "0xDA1508", VA = "0xDA1508")]
		protected void ComputeInterior()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xDA1670", Offset = "0xDA1670", VA = "0xDA1670")]
		public Tess()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xDA1748", Offset = "0xDA1748", VA = "0xDA1748")]
		private void ComputeNormal(ref Vec3 norm)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xDA2008", Offset = "0xDA2008", VA = "0xDA2008")]
		private void CheckOrientation()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xDA2138", Offset = "0xDA2138", VA = "0xDA2138")]
		private void ProjectPolygon()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xDA24C0", Offset = "0xDA24C0", VA = "0xDA24C0")]
		private void TessellateMonoRegion(MeshUtils.Face face)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xDA26D8", Offset = "0xDA26D8", VA = "0xDA26D8")]
		private void TessellateInterior()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xDA2744", Offset = "0xDA2744", VA = "0xDA2744")]
		private void DiscardExterior()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xDA27B0", Offset = "0xDA27B0", VA = "0xDA27B0")]
		private void SetWindingNumber(int value, bool keepOnlyBoundary)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xDA2884", Offset = "0xDA2884", VA = "0xDA2884")]
		private int GetNeighbourFace(MeshUtils.Edge edge)
		{
			return default(int);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xDA28C0", Offset = "0xDA28C0", VA = "0xDA28C0")]
		private void OutputPolymesh(ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xDA2D38", Offset = "0xDA2D38", VA = "0xDA2D38")]
		private void OutputContours()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xDA2FAC", Offset = "0xDA2FAC", VA = "0xDA2FAC")]
		private float SignedArea(ContourVertex[] vertices)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xDA304C", Offset = "0xDA304C", VA = "0xDA304C")]
		public void AddContour(ContourVertex[] vertices)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xDA3054", Offset = "0xDA3054", VA = "0xDA3054")]
		public void AddContour(ContourVertex[] vertices, ContourOrientation forceOrientation)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xDA3240", Offset = "0xDA3240", VA = "0xDA3240")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xDA3248", Offset = "0xDA3248", VA = "0xDA3248")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize, CombineCallback combineCallback)
		{
		}
	}
	[Token(Token = "0x200001D")]
	public enum WindingRule
	{
		[Token(Token = "0x4000073")]
		EvenOdd,
		[Token(Token = "0x4000074")]
		NonZero,
		[Token(Token = "0x4000075")]
		Positive,
		[Token(Token = "0x4000076")]
		Negative,
		[Token(Token = "0x4000077")]
		AbsGeqTwo
	}
	[Token(Token = "0x200001E")]
	public enum ElementType
	{
		[Token(Token = "0x4000079")]
		Polygons,
		[Token(Token = "0x400007A")]
		ConnectedPolygons,
		[Token(Token = "0x400007B")]
		BoundaryContours
	}
	[Token(Token = "0x200001F")]
	public enum ContourOrientation
	{
		[Token(Token = "0x400007D")]
		Original,
		[Token(Token = "0x400007E")]
		Clockwise,
		[Token(Token = "0x400007F")]
		CounterClockwise
	}
	[Token(Token = "0x2000020")]
	public struct ContourVertex
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vec3 Position;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public object Data;

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x9893D0", Offset = "0x9893D0", VA = "0x9893D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000021")]
	public delegate object CombineCallback(Vec3 position, object[] data, float[] weights);
	[Token(Token = "0x2000022")]
	public static class LibTessVector3Extension
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x6F3A70", Offset = "0x6F3A70", VA = "0x6F3A70")]
		public static Vec3 Vec3(this Vector3 v)
		{
			return default(Vec3);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x6F3A74", Offset = "0x6F3A74", VA = "0x6F3A74")]
		public static ContourVertex ContourVertex(this Vector3 v)
		{
			return default(ContourVertex);
		}
	}
	[Token(Token = "0x2000023")]
	public static class LibTessV3Extension
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x6F3A6C", Offset = "0x6F3A6C", VA = "0x6F3A6C")]
		public static Vector3 Vector3(this Vec3 v)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000024")]
	public static class UnityLibTessUtility
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xDA66EC", Offset = "0xDA66EC", VA = "0xDA66EC")]
		public static ContourVertex[] ToContourVertex(Vector3[] v, bool zeroZ = false)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xDA67DC", Offset = "0xDA67DC", VA = "0xDA67DC")]
		public static Vector3[] FromContourVertex(ContourVertex[] v)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xDA6858", Offset = "0xDA6858", VA = "0xDA6858")]
		public static void SetFromContourVertex(ref Vector3[] v3Array, ref ContourVertex[] cvArray)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xDA69A0", Offset = "0xDA69A0", VA = "0xDA69A0")]
		public static void SetToContourVertex(ref ContourVertex[] cvArray, ref Vector3[] v3Array)
		{
		}
	}
}
namespace FluffyUnderware.DevTools
{
	[Token(Token = "0x2000025")]
	public interface IDTGroupParsingAttribute
	{
		[Token(Token = "0x1700001A")]
		string Path
		{
			[Token(Token = "0x60000D9")]
			get;
		}
	}
	[Token(Token = "0x2000026")]
	public interface IDTFieldParsingAttribute
	{
	}
	[Token(Token = "0x2000027")]
	public interface IDTGroupRenderAttribute
	{
	}
	[Token(Token = "0x2000028")]
	public interface IDTFieldRenderAttribute
	{
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x521394", Offset = "0x521394")]
	public class DTVersionAttribute : Attribute
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Version;

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x98DB28", Offset = "0x98DB28", VA = "0x98DB28")]
		public DTVersionAttribute(string version)
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x5213C8", Offset = "0x5213C8")]
	public class DTAttribute : Attribute, IComparable
	{
		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521C34", Offset = "0x521C34")]
		private int <TypeSort>k__BackingField;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Sort;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ShowBelowProperty;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Space;

		[Token(Token = "0x1700001B")]
		public int TypeSort
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x9895F8", Offset = "0x9895F8", VA = "0x9895F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522BB0", Offset = "0x522BB0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x989600", Offset = "0x989600", VA = "0x989600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522BC0", Offset = "0x522BC0")]
			protected set
			{
			}
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x989608", Offset = "0x989608", VA = "0x989608", Slot = "5")]
		public virtual int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x97FF30", Offset = "0x97FF30", VA = "0x97FF30")]
		public DTAttribute(int sortOrder, bool showBelow = false)
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class GroupAttribute : DTAttribute, IDTGroupParsingAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521C44", Offset = "0x521C44")]
		private bool <PathIsAbsolute>k__BackingField;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Expanded;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool Invisible;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Label;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Tooltip;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string HelpURL;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mPath;

		[Token(Token = "0x1700001C")]
		public string Path
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x6F24BC", Offset = "0x6F24BC", VA = "0x6F24BC", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x6F24C4", Offset = "0x6F24C4", VA = "0x6F24C4")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public bool PathIsAbsolute
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x6F25B8", Offset = "0x6F25B8", VA = "0x6F25B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522BD0", Offset = "0x522BD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x6F25C0", Offset = "0x6F25C0", VA = "0x6F25C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522BE0", Offset = "0x522BE0")]
			private set
			{
			}
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x6F25CC", Offset = "0x6F25CC", VA = "0x6F25CC")]
		public GroupAttribute(string pathAndName)
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class ActionAttribute : DTAttribute
	{
		[Token(Token = "0x200002D")]
		public enum ActionEnum
		{
			[Token(Token = "0x4000093")]
			Show,
			[Token(Token = "0x4000094")]
			Hide,
			[Token(Token = "0x4000095")]
			Enable,
			[Token(Token = "0x4000096")]
			Disable,
			[Token(Token = "0x4000097")]
			ShowInfo,
			[Token(Token = "0x4000098")]
			ShowWarning,
			[Token(Token = "0x4000099")]
			ShowError,
			[Token(Token = "0x400009A")]
			Callback
		}

		[Token(Token = "0x200002E")]
		public enum ActionPositionEnum
		{
			[Token(Token = "0x400009C")]
			Above,
			[Token(Token = "0x400009D")]
			Below
		}

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ActionEnum Action;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ActionPositionEnum Position;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public object ActionData;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MethodInfo mCallback;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x97FEC8", Offset = "0x97FEC8", VA = "0x97FEC8")]
		protected ActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x97FF78", Offset = "0x97FF78", VA = "0x97FF78")]
		public void Callback(object classInstance)
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class ConditionalAttribute : ActionAttribute
	{
		[Token(Token = "0x2000030")]
		public enum OperatorEnum
		{
			[Token(Token = "0x40000A0")]
			AND,
			[Token(Token = "0x40000A1")]
			OR
		}

		[Token(Token = "0x2000031")]
		public class Condition
		{
			[Token(Token = "0x40000A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string FieldName;

			[Token(Token = "0x40000A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FieldInfo FieldInfo;

			[Token(Token = "0x40000A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropertyInfo PropertyInfo;

			[Token(Token = "0x40000A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object CompareTo;

			[Token(Token = "0x40000A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool CompareFalse;

			[Token(Token = "0x40000A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public OperatorEnum Operator;

			[Token(Token = "0x40000A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MethodInfo MethodInfo;

			[Token(Token = "0x40000A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string MethodName;

			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xDA7F94", Offset = "0xDA7F94", VA = "0xDA7F94")]
			public Condition()
			{
			}
		}

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Condition[] Conditions;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x988814", Offset = "0x988814", VA = "0x988814")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x988984", Offset = "0x988984", VA = "0x988984")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x988B94", Offset = "0x988B94", VA = "0x988B94")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x988E34", Offset = "0x988E34", VA = "0x988E34")]
		protected ConditionalAttribute(string methodToQuery)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x988F88", Offset = "0x988F88", VA = "0x988F88", Slot = "6")]
		public virtual bool ConditionMet(object classInstance)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x989054", Offset = "0x989054", VA = "0x989054")]
		private bool evaluate(Condition cond, object classInstance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000032")]
	public class SortOrderAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xE23808", Offset = "0xE23808", VA = "0xE23808")]
		public SortOrderAttribute(int sort = 100)
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class AsGroupAttribute : GroupAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x9821F0", Offset = "0x9821F0", VA = "0x9821F0")]
		public AsGroupAttribute([Optional] string pathAndName)
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class TabAttribute : GroupAttribute
	{
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly string TabName;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly string TabBarName;

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xD9EC30", Offset = "0xD9EC30", VA = "0xD9EC30")]
		public TabAttribute(string pathAndName)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xD9ECC0", Offset = "0xD9ECC0", VA = "0xD9ECC0")]
		private static bool split(string pathAndName, out string path, out string tabBar, out string tabname)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000035")]
	public class SectionAttribute : GroupAttribute
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool Fixed;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xE18278", Offset = "0xE18278", VA = "0xE18278")]
		public SectionAttribute(string name, bool expanded = true, bool fix = false, int sort = 100)
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class NoSectionAttribute : SectionAttribute
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xE1820C", Offset = "0xE1820C", VA = "0xE1820C")]
		public NoSectionAttribute()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class Hide : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x6F28F0", Offset = "0x6F28F0", VA = "0x6F28F0")]
		public Hide()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class Inline : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x6F2900", Offset = "0x6F2900", VA = "0x6F2900")]
		public Inline()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class ArrayExAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Draggable;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool ShowHeader;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool ShowAdd;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool ShowDelete;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool DropTarget;

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x981FF8", Offset = "0x981FF8", VA = "0x981FF8")]
		public ArrayExAttribute()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class FieldActionAttribute : ActionAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x6EE2E4", Offset = "0x6EE2E4", VA = "0x6EE2E4")]
		public FieldActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class GroupActionAttribute : ActionAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x6F24B4", Offset = "0x6F24B4", VA = "0x6F24B4")]
		public GroupActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class FieldConditionAttribute : ConditionalAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x6EE2EC", Offset = "0x6EE2EC", VA = "0x6EE2EC")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false, ActionEnum action = ActionEnum.Show, [Optional] object actionData, ActionPositionEnum position = ActionPositionEnum.Below)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x6EE340", Offset = "0x6EE340", VA = "0x6EE340")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x6EE350", Offset = "0x6EE350", VA = "0x6EE350")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x6EE374", Offset = "0x6EE374", VA = "0x6EE374")]
		public FieldConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class GroupConditionAttribute : ConditionalAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x6F2888", Offset = "0x6F2888", VA = "0x6F2888")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x6F2894", Offset = "0x6F2894", VA = "0x6F2894")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x6F28A4", Offset = "0x6F28A4", VA = "0x6F28A4")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x6F28C8", Offset = "0x6F28C8", VA = "0x6F28C8")]
		public GroupConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class Couple<T1, T2>
	{
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521C54", Offset = "0x521C54")]
		private T1 <First>k__BackingField;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521C64", Offset = "0x521C64")]
		private T2 <Second>k__BackingField;

		[Token(Token = "0x1700001E")]
		public T1 First
		{
			[Token(Token = "0x6000100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522BF0", Offset = "0x522BF0")]
			get
			{
				return (T1)null;
			}
			[Token(Token = "0x6000101")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522C00", Offset = "0x522C00")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public T2 Second
		{
			[Token(Token = "0x6000102")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522C10", Offset = "0x522C10")]
			get
			{
				return (T2)null;
			}
			[Token(Token = "0x6000103")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522C20", Offset = "0x522C20")]
			set
			{
			}
		}

		[Token(Token = "0x6000104")]
		public Couple(T1 first, T2 second)
		{
		}
	}
	[Token(Token = "0x200003F")]
	public static class DTTween
	{
		[Token(Token = "0x2000040")]
		public enum EasingMethod
		{
			[Token(Token = "0x40000B5")]
			Linear,
			[Token(Token = "0x40000B6")]
			ExponentialIn,
			[Token(Token = "0x40000B7")]
			ExponentialOut,
			[Token(Token = "0x40000B8")]
			ExponentialInOut,
			[Token(Token = "0x40000B9")]
			ExponentialOutIn,
			[Token(Token = "0x40000BA")]
			CircularIn,
			[Token(Token = "0x40000BB")]
			CircularOut,
			[Token(Token = "0x40000BC")]
			CircularInOut,
			[Token(Token = "0x40000BD")]
			CircularOutIn,
			[Token(Token = "0x40000BE")]
			QuadraticIn,
			[Token(Token = "0x40000BF")]
			QuadraticOut,
			[Token(Token = "0x40000C0")]
			QuadraticInOut,
			[Token(Token = "0x40000C1")]
			QuadraticOutIn,
			[Token(Token = "0x40000C2")]
			SinusIn,
			[Token(Token = "0x40000C3")]
			SinusOut,
			[Token(Token = "0x40000C4")]
			SinusInOut,
			[Token(Token = "0x40000C5")]
			SinusOutIn,
			[Token(Token = "0x40000C6")]
			CubicIn,
			[Token(Token = "0x40000C7")]
			CubicOut,
			[Token(Token = "0x40000C8")]
			CubicInOut,
			[Token(Token = "0x40000C9")]
			CubicOutIn,
			[Token(Token = "0x40000CA")]
			QuarticIn,
			[Token(Token = "0x40000CB")]
			QuarticOut,
			[Token(Token = "0x40000CC")]
			QuarticInOut,
			[Token(Token = "0x40000CD")]
			QuarticOutIn,
			[Token(Token = "0x40000CE")]
			QuinticIn,
			[Token(Token = "0x40000CF")]
			QuinticOut,
			[Token(Token = "0x40000D0")]
			QuinticInOut,
			[Token(Token = "0x40000D1")]
			QuinticOutIn
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x98B7FC", Offset = "0x98B7FC", VA = "0x98B7FC")]
		public static float Ease(EasingMethod method, float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x98C7A0", Offset = "0x98C7A0", VA = "0x98C7A0")]
		public static float Ease(EasingMethod method, float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x98C770", Offset = "0x98C770", VA = "0x98C770")]
		public static float Linear(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x98D5F4", Offset = "0x98D5F4", VA = "0x98D5F4")]
		public static float Linear(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x98BBD0", Offset = "0x98BBD0", VA = "0x98BBD0")]
		public static float ExpoOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x98CCF0", Offset = "0x98CCF0", VA = "0x98CCF0")]
		public static float ExpoOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x98BB80", Offset = "0x98BB80", VA = "0x98BB80")]
		public static float ExpoIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x98CCA4", Offset = "0x98CCA4", VA = "0x98CCA4")]
		public static float ExpoIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x98BC24", Offset = "0x98BC24", VA = "0x98BC24")]
		public static float ExpoInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x98CD38", Offset = "0x98CD38", VA = "0x98CD38")]
		public static float ExpoInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x98BCBC", Offset = "0x98BCBC", VA = "0x98BCBC")]
		public static float ExpoOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x98CDD0", Offset = "0x98CDD0", VA = "0x98CDD0")]
		public static float ExpoOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x98BDC4", Offset = "0x98BDC4", VA = "0x98BDC4")]
		public static float CircOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x98CEBC", Offset = "0x98CEBC", VA = "0x98CEBC")]
		public static float CircOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x98BD6C", Offset = "0x98BD6C", VA = "0x98BD6C")]
		public static float CircIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x98CE68", Offset = "0x98CE68", VA = "0x98CE68")]
		public static float CircIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x98BE1C", Offset = "0x98BE1C", VA = "0x98BE1C")]
		public static float CircInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x98CF10", Offset = "0x98CF10", VA = "0x98CF10")]
		public static float CircInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x98BEA8", Offset = "0x98BEA8", VA = "0x98BEA8")]
		public static float CircOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x98CF98", Offset = "0x98CF98", VA = "0x98CF98")]
		public static float CircOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x98BFA0", Offset = "0x98BFA0", VA = "0x98BFA0")]
		public static float QuadOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x98D058", Offset = "0x98D058", VA = "0x98D058")]
		public static float QuadOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x98BF6C", Offset = "0x98BF6C", VA = "0x98BF6C")]
		public static float QuadIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x98D044", Offset = "0x98D044", VA = "0x98D044")]
		public static float QuadIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x98BFDC", Offset = "0x98BFDC", VA = "0x98BFDC")]
		public static float QuadInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x98D074", Offset = "0x98D074", VA = "0x98D074")]
		public static float QuadInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x98C068", Offset = "0x98C068", VA = "0x98C068")]
		public static float QuadOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x98D0FC", Offset = "0x98D0FC", VA = "0x98D0FC")]
		public static float QuadOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x98C12C", Offset = "0x98C12C", VA = "0x98C12C")]
		public static float SineOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x98D190", Offset = "0x98D190", VA = "0x98D190")]
		public static float SineOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x98C0E8", Offset = "0x98C0E8", VA = "0x98C0E8")]
		public static float SineIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x98D150", Offset = "0x98D150", VA = "0x98D150")]
		public static float SineIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x98C16C", Offset = "0x98C16C", VA = "0x98C16C")]
		public static float SineInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x98D1CC", Offset = "0x98D1CC", VA = "0x98D1CC")]
		public static float SineInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x98C200", Offset = "0x98C200", VA = "0x98C200")]
		public static float SineOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x98D254", Offset = "0x98D254", VA = "0x98D254")]
		public static float SineOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x98C2CC", Offset = "0x98C2CC", VA = "0x98C2CC")]
		public static float CubicOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x98D2EC", Offset = "0x98D2EC", VA = "0x98D2EC")]
		public static float CubicOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x98C294", Offset = "0x98C294", VA = "0x98C294")]
		public static float CubicIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x98D2D4", Offset = "0x98D2D4", VA = "0x98D2D4")]
		public static float CubicIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x98C314", Offset = "0x98C314", VA = "0x98C314")]
		public static float CubicInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x98D314", Offset = "0x98D314", VA = "0x98D314")]
		public static float CubicInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x98C38C", Offset = "0x98C38C", VA = "0x98C38C")]
		public static float CubicOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x98D368", Offset = "0x98D368", VA = "0x98D368")]
		public static float CubicOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x98C45C", Offset = "0x98C45C", VA = "0x98C45C")]
		public static float QuartOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x98D3E4", Offset = "0x98D3E4", VA = "0x98D3E4")]
		public static float QuartOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x98C420", Offset = "0x98C420", VA = "0x98C420")]
		public static float QuartIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x98D3C8", Offset = "0x98D3C8", VA = "0x98D3C8")]
		public static float QuartIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x98C4A4", Offset = "0x98C4A4", VA = "0x98C4A4")]
		public static float QuartInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x98D40C", Offset = "0x98D40C", VA = "0x98D40C")]
		public static float QuartInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x98C520", Offset = "0x98C520", VA = "0x98C520")]
		public static float QuartOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x98D468", Offset = "0x98D468", VA = "0x98D468")]
		public static float QuartOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x98C5F4", Offset = "0x98C5F4", VA = "0x98C5F4")]
		public static float QuintOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x98D4F0", Offset = "0x98D4F0", VA = "0x98D4F0")]
		public static float QuintOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x98C5B4", Offset = "0x98C5B4", VA = "0x98C5B4")]
		public static float QuintIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x98D4D0", Offset = "0x98D4D0", VA = "0x98D4D0")]
		public static float QuintIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x98C644", Offset = "0x98C644", VA = "0x98C644")]
		public static float QuintInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x98D520", Offset = "0x98D520", VA = "0x98D520")]
		public static float QuintInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x98C6CC", Offset = "0x98C6CC", VA = "0x98C6CC")]
		public static float QuintOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x98D584", Offset = "0x98D584", VA = "0x98D584")]
		public static float QuintOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000041")]
	public class DTObjectDump
	{
		[Token(Token = "0x40000D2")]
		private const int INDENTSPACES = 5;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string mIndent;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StringBuilder mSB;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object mObject;

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x98A8C4", Offset = "0x98A8C4", VA = "0x98A8C4")]
		public DTObjectDump(object o, int indent = 0)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x98B654", Offset = "0x98B654", VA = "0x98B654", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x98AAA4", Offset = "0x98AAA4", VA = "0x98AAA4")]
		private void AppendHeader(string name)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x98AB34", Offset = "0x98AB34", VA = "0x98AB34")]
		private void AppendMember(MemberInfo info)
		{
		}
	}
	[Token(Token = "0x2000042")]
	public static class DTUtility
	{
		[Token(Token = "0x40000D6")]
		public const string HelpUrlBase = "https://curvyeditor.com/doclink/";

		[Token(Token = "0x17000020")]
		public static bool IsEditorStateChange
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x98D60C", Offset = "0x98D60C", VA = "0x98D60C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x98D604", Offset = "0x98D604", VA = "0x98D604")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x98D614", Offset = "0x98D614", VA = "0x98D614")]
		public static float GetHandleSize(Vector3 position)
		{
			return default(float);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x98D780", Offset = "0x98D780", VA = "0x98D780")]
		public static float GetHandleSize(Vector3 position, Camera camera, Vector3 cameraPosition, Vector3 cameraZDirection, Transform cameraTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000149")]
		public static void SetPlayerPrefs<T>(string key, T value)
		{
		}

		[Token(Token = "0x600014A")]
		public static T GetPlayerPrefs<T>(string key, T defaultValue)
		{
			return (T)null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x98D8D4", Offset = "0x98D8D4", VA = "0x98D8D4")]
		public static float RandomSign()
		{
			return default(float);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x98D900", Offset = "0x98D900", VA = "0x98D900")]
		public static string GetHelpUrl(object forClass)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x98D96C", Offset = "0x98D96C", VA = "0x98D96C")]
		public static string GetHelpUrl(Type classType)
		{
			return null;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x98DAAC", Offset = "0x98DAAC", VA = "0x98DAAC")]
		public static Vector3 GetCenterPosition(Vector3 fallback, params Vector3[] vectors)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014F")]
		public static T CreateGameObject<T>(Transform parent, string name) where T : MonoBehaviour
		{
			return null;
		}
	}
	[Token(Token = "0x2000043")]
	public static class DTTime
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float _EditorDeltaTime;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float _EditorLastTime;

		[Token(Token = "0x17000021")]
		public static double TimeSinceStartup
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x987320", Offset = "0x987320", VA = "0x987320")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000022")]
		public static float deltaTime
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x98B6CC", Offset = "0x98B6CC", VA = "0x98B6CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x98B734", Offset = "0x98B734", VA = "0x98B734")]
		public static void InitializeEditorTime()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x98B794", Offset = "0x98B794", VA = "0x98B794")]
		public static void UpdateEditorTime()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class TimeMeasure : Ring<long>
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Stopwatch mWatch;

		[Token(Token = "0x17000023")]
		public double LastTicks
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0xDA3D5C", Offset = "0xDA3D5C", VA = "0xDA3D5C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000024")]
		public double LastMS
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0xDA3DD4", Offset = "0xDA3DD4", VA = "0xDA3DD4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000025")]
		public double AverageMS
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0xDA3DF4", Offset = "0xDA3DF4", VA = "0xDA3DF4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000026")]
		public double MinimumMS
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0xDA3EDC", Offset = "0xDA3EDC", VA = "0xDA3EDC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000027")]
		public double MaximumMS
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0xDA3FF8", Offset = "0xDA3FF8", VA = "0xDA3FF8")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000028")]
		public double AverageTicks
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0xDA4114", Offset = "0xDA4114", VA = "0xDA4114")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000029")]
		public double MinimumTicks
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0xDA41EC", Offset = "0xDA41EC", VA = "0xDA41EC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700002A")]
		public double MaximumTicks
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0xDA42F8", Offset = "0xDA42F8", VA = "0xDA42F8")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xDA3C0C", Offset = "0xDA3C0C", VA = "0xDA3C0C")]
		public TimeMeasure(int size)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xDA3CA0", Offset = "0xDA3CA0", VA = "0xDA3CA0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xDA3CBC", Offset = "0xDA3CBC", VA = "0xDA3CBC")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xDA3D40", Offset = "0xDA3D40", VA = "0xDA3D40")]
		public void Pause()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public static class DTMath
	{
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x989C40", Offset = "0x989C40", VA = "0x989C40")]
		public static Vector3 ParallelTransportFrame(Vector3 up, Vector3 tan0, Vector3 tan1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x989DA0", Offset = "0x989DA0", VA = "0x989DA0")]
		public static Vector3 LeftTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x989DB8", Offset = "0x989DB8", VA = "0x989DB8")]
		public static Vector3 RightTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x989DD0", Offset = "0x989DD0", VA = "0x989DD0")]
		public static float Repeat(float t, float length)
		{
			return default(float);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x989DEC", Offset = "0x989DEC", VA = "0x989DEC")]
		public static double FixNaN(double v)
		{
			return default(double);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x989E68", Offset = "0x989E68", VA = "0x989E68")]
		public static float FixNaN(float v)
		{
			return default(float);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x989E98", Offset = "0x989E98", VA = "0x989E98")]
		public static Vector2 FixNaN(Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x989EEC", Offset = "0x989EEC", VA = "0x989EEC")]
		public static Vector3 FixNaN(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x989F5C", Offset = "0x989F5C", VA = "0x989F5C")]
		public static float MapValue(float min, float max, float value, float vMin = -1f, float vMax = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x989F78", Offset = "0x989F78", VA = "0x989F78")]
		public static float SnapPrecision(float value, int decimals)
		{
			return default(float);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x989FFC", Offset = "0x989FFC", VA = "0x989FFC")]
		public static Vector2 SnapPrecision(Vector2 value, int decimals)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x98A050", Offset = "0x98A050", VA = "0x98A050")]
		public static Vector3 SnapPrecision(Vector3 value, int decimals)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x98A0C4", Offset = "0x98A0C4", VA = "0x98A0C4")]
		public static float LinePointDistanceSqr(Vector3 l1, Vector3 l2, Vector3 p, out float frag)
		{
			return default(float);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x98A19C", Offset = "0x98A19C", VA = "0x98A19C")]
		public static bool RayLineSegmentIntersection(Vector2 r0, Vector2 dir, Vector2 l1, Vector2 l2, out Vector2 hit, out float frag)
		{
			return default(bool);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x98A23C", Offset = "0x98A23C", VA = "0x98A23C")]
		public static bool ShortestIntersectionLine(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 resultSegmentA, out Vector3 resultSegmentB)
		{
			return default(bool);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x98A52C", Offset = "0x98A52C", VA = "0x98A52C")]
		public static bool LineLineIntersection(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 hitPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x98A658", Offset = "0x98A658", VA = "0x98A658")]
		public static bool LineLineIntersect(Vector2 line1A, Vector2 line1B, Vector2 line2A, Vector2 line2B, out Vector2 hitPoint, bool segmentOnly = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x98A780", Offset = "0x98A780", VA = "0x98A780")]
		public static bool PointInsideTriangle(Vector3 A, Vector3 B, Vector3 C, Vector3 p, out float ac, out float ab, bool edgesAllowed)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000046")]
	public class UnityEventEx<T0> : UnityEvent<T0>
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object mCallerList;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private MethodInfo mCallsCount;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mCount;

		[Token(Token = "0x6000172")]
		public void AddListenerOnce(UnityAction<T0> call)
		{
		}

		[Token(Token = "0x6000173")]
		public bool HasListeners()
		{
			return default(bool);
		}

		[Token(Token = "0x6000174")]
		public void CheckForListeners()
		{
		}

		[Token(Token = "0x6000175")]
		public UnityEventEx()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public static class DTLog
	{
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x9896D8", Offset = "0x9896D8", VA = "0x9896D8")]
		public static void Log(object message)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x98973C", Offset = "0x98973C", VA = "0x98973C")]
		public static void Log(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x9883CC", Offset = "0x9883CC", VA = "0x9883CC")]
		public static void LogError(object message)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x9897B0", Offset = "0x9897B0", VA = "0x9897B0")]
		public static void LogError(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x989824", Offset = "0x989824", VA = "0x989824")]
		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x989898", Offset = "0x989898", VA = "0x989898")]
		public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x989914", Offset = "0x989914", VA = "0x989914")]
		public static void LogException(Exception exception)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x989978", Offset = "0x989978", VA = "0x989978")]
		public static void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x9899EC", Offset = "0x9899EC", VA = "0x9899EC")]
		public static void LogFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x989A60", Offset = "0x989A60", VA = "0x989A60")]
		public static void LogFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x9871A4", Offset = "0x9871A4", VA = "0x9871A4")]
		public static void LogWarning(object message)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x989ADC", Offset = "0x989ADC", VA = "0x989ADC")]
		public static void LogWarning(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x989B50", Offset = "0x989B50", VA = "0x989B50")]
		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x989BC4", Offset = "0x989BC4", VA = "0x989BC4")]
		public static void LogWarningFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public struct FloatRegion : IEquatable<FloatRegion>
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float From;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float To;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SimpleValue;

		[Token(Token = "0x1700002B")]
		public static FloatRegion ZeroOne
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x6F057C", Offset = "0x6F057C", VA = "0x6F057C")]
			get
			{
				return default(FloatRegion);
			}
		}

		[Token(Token = "0x1700002C")]
		public bool Positive
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x6F0674", Offset = "0x6F0674", VA = "0x6F0674")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002D")]
		public float Low
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x6F0628", Offset = "0x6F0628", VA = "0x6F0628")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x6F0638", Offset = "0x6F0638", VA = "0x6F0638")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public float High
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x6F064C", Offset = "0x6F064C", VA = "0x6F064C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x6F065C", Offset = "0x6F065C", VA = "0x6F065C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public float Random
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x6F0684", Offset = "0x6F0684", VA = "0x6F0684")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000030")]
		public float Next
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x6F0690", Offset = "0x6F0690", VA = "0x6F0690")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000031")]
		public float Length
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x6F06AC", Offset = "0x6F06AC", VA = "0x6F06AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000032")]
		public float LengthPositive
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x6F06B8", Offset = "0x6F06B8", VA = "0x6F06B8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x6F0560", Offset = "0x6F0560", VA = "0x6F0560")]
		public FloatRegion(float value)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x6F0570", Offset = "0x6F0570", VA = "0x6F0570")]
		public FloatRegion(float A, float B)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x6F0588", Offset = "0x6F0588", VA = "0x6F0588")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x6F059C", Offset = "0x6F059C", VA = "0x6F059C")]
		public void Clamp(float low, float high)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x6F06D0", Offset = "0x6F06D0", VA = "0x6F06D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x6F0774", Offset = "0x6F0774", VA = "0x6F0774", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x6F07AC", Offset = "0x6F07AC", VA = "0x6F07AC", Slot = "4")]
		public bool Equals(FloatRegion other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x6F07FC", Offset = "0x6F07FC", VA = "0x6F07FC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x6F08A8", Offset = "0x6F08A8", VA = "0x6F08A8")]
		public static FloatRegion operator +(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x6F08DC", Offset = "0x6F08DC", VA = "0x6F08DC")]
		public static FloatRegion operator -(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x6F0910", Offset = "0x6F0910", VA = "0x6F0910")]
		public static FloatRegion operator -(FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x6F0928", Offset = "0x6F0928", VA = "0x6F0928")]
		public static FloatRegion operator *(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x6F0950", Offset = "0x6F0950", VA = "0x6F0950")]
		public static FloatRegion operator *(float v, FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x6F0978", Offset = "0x6F0978", VA = "0x6F0978")]
		public static FloatRegion operator /(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x6F09A0", Offset = "0x6F09A0", VA = "0x6F09A0")]
		public static bool operator ==(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x6F0A10", Offset = "0x6F0A10", VA = "0x6F0A10")]
		public static bool operator !=(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public struct IntRegion : IEquatable<IntRegion>
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int From;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int To;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SimpleValue;

		[Token(Token = "0x17000033")]
		public static IntRegion ZeroOne
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x6F2934", Offset = "0x6F2934", VA = "0x6F2934")]
			get
			{
				return default(IntRegion);
			}
		}

		[Token(Token = "0x17000034")]
		public bool Positive
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x6F2A24", Offset = "0x6F2A24", VA = "0x6F2A24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public int Low
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x6F29D8", Offset = "0x6F29D8", VA = "0x6F29D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x6F29E8", Offset = "0x6F29E8", VA = "0x6F29E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public int High
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x6F29FC", Offset = "0x6F29FC", VA = "0x6F29FC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x6F2A0C", Offset = "0x6F2A0C", VA = "0x6F2A0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public int Random
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x6F2A34", Offset = "0x6F2A34", VA = "0x6F2A34")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000038")]
		public int Length
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x6F2A44", Offset = "0x6F2A44", VA = "0x6F2A44")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000039")]
		public int LengthPositive
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x6F2A50", Offset = "0x6F2A50", VA = "0x6F2A50")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x6F2918", Offset = "0x6F2918", VA = "0x6F2918")]
		public IntRegion(int value)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x6F2928", Offset = "0x6F2928", VA = "0x6F2928")]
		public IntRegion(int A, int B)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x6F2940", Offset = "0x6F2940", VA = "0x6F2940")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x6F2954", Offset = "0x6F2954", VA = "0x6F2954")]
		public void Clamp(int low, int high)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x6F2A64", Offset = "0x6F2A64", VA = "0x6F2A64", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x6F2B08", Offset = "0x6F2B08", VA = "0x6F2B08", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x6F2B40", Offset = "0x6F2B40", VA = "0x6F2B40", Slot = "4")]
		public bool Equals(IntRegion other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x6F2B88", Offset = "0x6F2B88", VA = "0x6F2B88", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x6F2C28", Offset = "0x6F2C28", VA = "0x6F2C28")]
		public static IntRegion operator +(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x6F2C44", Offset = "0x6F2C44", VA = "0x6F2C44")]
		public static IntRegion operator -(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x6F2C60", Offset = "0x6F2C60", VA = "0x6F2C60")]
		public static IntRegion operator -(IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x6F2C78", Offset = "0x6F2C78", VA = "0x6F2C78")]
		public static IntRegion operator *(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x6F2C90", Offset = "0x6F2C90", VA = "0x6F2C90")]
		public static IntRegion operator *(int v, IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x6F2CAC", Offset = "0x6F2CAC", VA = "0x6F2CAC")]
		public static IntRegion operator /(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x6F2CC4", Offset = "0x6F2CC4", VA = "0x6F2CC4")]
		public static bool operator ==(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x6F2CFC", Offset = "0x6F2CFC", VA = "0x6F2CFC")]
		public static bool operator !=(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004A")]
	public class WeightedRandom<T>
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mData;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mCurrentPosition;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T mCurrentItem;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521C74", Offset = "0x521C74")]
		private int <Seed>k__BackingField;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521C84", Offset = "0x521C84")]
		private bool <RandomizeSeed>k__BackingField;

		[Token(Token = "0x1700003A")]
		public int Seed
		{
			[Token(Token = "0x60001B7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522C30", Offset = "0x522C30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522C40", Offset = "0x522C40")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x60001B9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522C50", Offset = "0x522C50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BA")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522C60", Offset = "0x522C60")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		private int Capacity
		{
			[Token(Token = "0x60001BB")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003D")]
		public int Size
		{
			[Token(Token = "0x60001BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001BD")]
		public WeightedRandom(int initCapacity = 0)
		{
		}

		[Token(Token = "0x60001BE")]
		public WeightedRandom(int initCapacity, int seed)
		{
		}

		[Token(Token = "0x60001BF")]
		public void Add(T item, int amount)
		{
		}

		[Token(Token = "0x60001C0")]
		public T Next()
		{
			return (T)null;
		}

		[Token(Token = "0x60001C1")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C2")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x521400", Offset = "0x521400")]
	public class Ring<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mList;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521C94", Offset = "0x521C94")]
		private int <Size>k__BackingField;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mIndex;

		[Token(Token = "0x1700003E")]
		public int Size
		{
			[Token(Token = "0x60001C3")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522C70", Offset = "0x522C70")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522C80", Offset = "0x522C80")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public T Item
		{
			[Token(Token = "0x60001CB")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x60001CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public int Count
		{
			[Token(Token = "0x60001D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000041")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60001D1")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C5")]
		public Ring(int size)
		{
		}

		[Token(Token = "0x60001C6")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x60001C7")]
		public void Clear()
		{
		}

		[Token(Token = "0x60001C8")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x60001C9")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x60001CA")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x60001CD")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60001D2")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D3")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x200004C")]
	public class Pool<T> : IPool
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mObjects;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521CA4", Offset = "0x521CA4")]
		private string <Identifier>k__BackingField;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521CB4", Offset = "0x521CB4")]
		private PoolSettings <Settings>k__BackingField;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double mLastTime;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double mDeltaTime;

		[Token(Token = "0x17000042")]
		public string Identifier
		{
			[Token(Token = "0x60001D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522C90", Offset = "0x522C90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522CA0", Offset = "0x522CA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public PoolSettings Settings
		{
			[Token(Token = "0x60001D6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522CB0", Offset = "0x522CB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522CC0", Offset = "0x522CC0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public Type Type
		{
			[Token(Token = "0x60001D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public int Count
		{
			[Token(Token = "0x60001DD")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001D9")]
		public Pool([Optional] PoolSettings settings)
		{
		}

		[Token(Token = "0x60001DA")]
		public void Update()
		{
		}

		[Token(Token = "0x60001DB")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001DC")]
		public void Clear()
		{
		}

		[Token(Token = "0x60001DE")]
		public virtual T Pop([Optional] Transform parent)
		{
			return (T)null;
		}

		[Token(Token = "0x60001DF")]
		public virtual void Push(T item)
		{
		}

		[Token(Token = "0x60001E0")]
		protected virtual void sendBeforePush(T item)
		{
		}

		[Token(Token = "0x60001E1")]
		protected virtual void sendAfterPop(T item)
		{
		}

		[Token(Token = "0x60001E2")]
		protected virtual void setParent(T item, Transform parent)
		{
		}

		[Token(Token = "0x60001E3")]
		protected virtual T create()
		{
			return (T)null;
		}

		[Token(Token = "0x60001E4")]
		protected virtual void destroy(T item)
		{
		}

		[Token(Token = "0x60001E5")]
		private void log(string msg)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class PoolSettings
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_Prewarm;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool m_AutoCreate;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		[SerializeField]
		private bool m_AutoEnableDisable;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Positive]
		private int m_MinItems;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Positive]
		private int m_Threshold;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Positive]
		private float m_Speed;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Debug;

		[Token(Token = "0x17000046")]
		public bool Prewarm
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xE21F30", Offset = "0xE21F30", VA = "0xE21F30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xE21E44", Offset = "0xE21E44", VA = "0xE21E44")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public bool AutoCreate
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xE21F38", Offset = "0xE21F38", VA = "0xE21F38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xE21E64", Offset = "0xE21E64", VA = "0xE21E64")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public bool AutoEnableDisable
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xE21F40", Offset = "0xE21F40", VA = "0xE21F40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xE21F48", Offset = "0xE21F48", VA = "0xE21F48")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public int MinItems
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xE21F68", Offset = "0xE21F68", VA = "0xE21F68")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xE21E84", Offset = "0xE21E84", VA = "0xE21E84")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public int Threshold
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xE21F70", Offset = "0xE21F70", VA = "0xE21F70")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xE21EBC", Offset = "0xE21EBC", VA = "0xE21EBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public float Speed
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xE21F78", Offset = "0xE21F78", VA = "0xE21F78")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xE21EF4", Offset = "0xE21EF4", VA = "0xE21EF4")]
			set
			{
			}
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xE21E2C", Offset = "0xE21E2C", VA = "0xE21E2C")]
		public PoolSettings()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xE21654", Offset = "0xE21654", VA = "0xE21654")]
		public PoolSettings(PoolSettings src)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xE20BA0", Offset = "0xE20BA0", VA = "0xE20BA0")]
		public void OnValidate()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public interface IPool
	{
		[Token(Token = "0x1700004C")]
		string Identifier
		{
			[Token(Token = "0x60001F5")]
			get;
			[Token(Token = "0x60001F6")]
			set;
		}

		[Token(Token = "0x1700004D")]
		PoolSettings Settings
		{
			[Token(Token = "0x60001F7")]
			get;
		}

		[Token(Token = "0x1700004E")]
		int Count
		{
			[Token(Token = "0x60001FB")]
			get;
		}

		[Token(Token = "0x60001F8")]
		void Clear();

		[Token(Token = "0x60001F9")]
		void Reset();

		[Token(Token = "0x60001FA")]
		void Update();
	}
	[Token(Token = "0x200004F")]
	public interface IPoolable
	{
		[Token(Token = "0x60001FC")]
		void OnBeforePush();

		[Token(Token = "0x60001FD")]
		void OnAfterPop();
	}
	[Token(Token = "0x2000050")]
	public enum DTMessageType
	{
		[Token(Token = "0x40000F8")]
		None,
		[Token(Token = "0x40000F9")]
		Info,
		[Token(Token = "0x40000FA")]
		Warning,
		[Token(Token = "0x40000FB")]
		Error
	}
	[Token(Token = "0x2000051")]
	public enum AttributeOptionsFlags
	{
		[Token(Token = "0x40000FD")]
		None = 0,
		[Token(Token = "0x40000FE")]
		Compact = 1,
		[Token(Token = "0x40000FF")]
		Clipboard = 128,
		[Token(Token = "0x4000100")]
		Zero = 256,
		[Token(Token = "0x4000101")]
		One = 512,
		[Token(Token = "0x4000102")]
		Negate = 1024,
		[Token(Token = "0x4000103")]
		Full = 1920,
		[Token(Token = "0x4000104")]
		FullCompact = 1921
	}
	[Token(Token = "0x2000052")]
	public class DTPropertyAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Label;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Tooltip;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Color;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AttributeOptionsFlags Options;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int Precision;

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x981FA0", Offset = "0x981FA0", VA = "0x981FA0")]
		public DTPropertyAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class LabelAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x6F3A08", Offset = "0x6F3A08", VA = "0x6F3A08")]
		public LabelAttribute()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x6F3A5C", Offset = "0x6F3A5C", VA = "0x6F3A5C")]
		public LabelAttribute(string label, string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class ToggleButtonAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000201")]
		[Address(RVA = "0xDA4400", Offset = "0xDA4400", VA = "0xDA4400")]
		public ToggleButtonAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class LayerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x6F3A64", Offset = "0x6F3A64", VA = "0x6F3A64")]
		public LayerAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class TagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000203")]
		[Address(RVA = "0xD9EE9C", Offset = "0xD9EE9C", VA = "0xD9EE9C")]
		public TagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class VectorExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000204")]
		[Address(RVA = "0xDA7170", Offset = "0xDA7170", VA = "0xDA7170")]
		public VectorExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class AnimationCurveExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x981F78", Offset = "0x981F78", VA = "0x981F78")]
		public AnimationCurveExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class MinAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MinValue;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xE17638", Offset = "0xE17638", VA = "0xE17638")]
		public MinAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE1766C", Offset = "0xE1766C", VA = "0xE1766C")]
		public MinAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class PositiveAttribute : MinAttribute
	{
		[Token(Token = "0x6000208")]
		[Address(RVA = "0xE21F80", Offset = "0xE21F80", VA = "0xE21F80")]
		public PositiveAttribute()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class MaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MaxValue;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xE153C0", Offset = "0xE153C0", VA = "0xE153C0")]
		public MaxAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xE153F4", Offset = "0xE153F4", VA = "0xE153F4")]
		public MaxAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class RangeExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MinValue;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MaxValue;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool Slider;

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xE2312C", Offset = "0xE2312C", VA = "0xE2312C")]
		public RangeExAttribute(float minValue, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xE23170", Offset = "0xE23170", VA = "0xE23170")]
		public RangeExAttribute(string minFieldOrProperty, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xE231C8", Offset = "0xE231C8", VA = "0xE231C8")]
		public RangeExAttribute(float minValue, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xE2321C", Offset = "0xE2321C", VA = "0xE2321C")]
		public RangeExAttribute(string minFieldOrProperty, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class MinMaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string MaxValueField;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Min;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string MinBoundFieldOrPropertyName;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float Max;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string MaxBoundFieldOrPropertyName;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xE176A8", Offset = "0xE176A8", VA = "0xE176A8")]
		public MinMaxAttribute(string maxValueField, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class EnumFlagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x990A34", Offset = "0x990A34", VA = "0x990A34")]
		public EnumFlagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class ObjectSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000211")]
		[Address(RVA = "0xE183A0", Offset = "0xE183A0", VA = "0xE183A0")]
		public ObjectSelectorAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class PathSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x2000061")]
		public enum DialogMode
		{
			[Token(Token = "0x400011E")]
			OpenFile,
			[Token(Token = "0x400011F")]
			OpenFolder,
			[Token(Token = "0x4000120")]
			CreateFile
		}

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly DialogMode Mode;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Title;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Directory;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Extension;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string DefaultName;

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xE18428", Offset = "0xE18428", VA = "0xE18428")]
		public PathSelectorAttribute(DialogMode mode = DialogMode.OpenFile)
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class EnumSelectionGridAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x990A38", Offset = "0x990A38", VA = "0x990A38")]
		public EnumSelectionGridAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class DTRegionAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool RegionIsOptional;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string RegionOptionsPropertyName;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool UseSlider;

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x98B674", Offset = "0x98B674", VA = "0x98B674")]
		public DTRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class FloatRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x6F0A84", Offset = "0x6F0A84", VA = "0x6F0A84")]
		public FloatRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class IntRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x6F2D34", Offset = "0x6F2D34", VA = "0x6F2D34")]
		public IntRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public struct RegionOptions<T>
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LabelFrom;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LabelTo;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string OptionalTooltip;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DTValueClamping ClampFrom;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DTValueClamping ClampTo;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T FromMin;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T FromMax;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T ToMin;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T ToMax;

		[Token(Token = "0x1700004F")]
		public static RegionOptions<T> Default
		{
			[Token(Token = "0x6000217")]
			get
			{
				return default(RegionOptions<T>);
			}
		}

		[Token(Token = "0x6000218")]
		public static RegionOptions<T> MinMax(T min, T max)
		{
			return default(RegionOptions<T>);
		}
	}
	[Token(Token = "0x2000067")]
	public enum DTValueClamping
	{
		[Token(Token = "0x400012E")]
		None,
		[Token(Token = "0x400012F")]
		Min,
		[Token(Token = "0x4000130")]
		Max,
		[Token(Token = "0x4000131")]
		Range
	}
	[Token(Token = "0x2000068")]
	public class ThreadPoolWorker<T> : IDisposable
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimplePool<QueuedCallback> queuedCallbackPool;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimplePool<LoopState<T>> loopStatePool;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _remainingWorkItems;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ManualResetEvent _done;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaitCallback handleWorkItemCallBack;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaitCallback handleLoopCallBack;

		[Token(Token = "0x6000219")]
		public ThreadPoolWorker()
		{
		}

		[Token(Token = "0x600021A")]
		public void ParralelFor(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x600021B")]
		private bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x600021C")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x600021D")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x600021E")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600021F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522CD0", Offset = "0x522CD0")]
		private void <.ctor>b__6_0(object o)
		{
		}

		[Token(Token = "0x6000220")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522CE0", Offset = "0x522CE0")]
		private void <.ctor>b__6_1(object state)
		{
		}
	}
	[Token(Token = "0x2000069")]
	internal class SimplePool<T> where T : new()
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<T> freeItemsBackfield;

		[Token(Token = "0x6000221")]
		public SimplePool(int preCreatedElementsCount)
		{
		}

		[Token(Token = "0x6000222")]
		public T GetItem()
		{
			return (T)null;
		}

		[Token(Token = "0x6000223")]
		public void ReleaseItem(T item)
		{
		}
	}
	[Token(Token = "0x200006A")]
	internal class QueuedCallback
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WaitCallback Callback;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object State;

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xE23124", Offset = "0xE23124", VA = "0xE23124")]
		public QueuedCallback()
		{
		}
	}
	[Token(Token = "0x200006B")]
	internal class LoopState<T>
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short StartIndex;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short EndIndex;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<T> Items;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> Action;

		[Token(Token = "0x6000225")]
		public LoopState()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class ThreadPoolWorker : IDisposable
	{
		[Serializable]
		[Token(Token = "0x200006D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521438", Offset = "0x521438")]
		private sealed class <>c__4<T>
		{
			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__4<T> <>9;

			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static WaitCallback <>9__4_0;

			[Token(Token = "0x6000235")]
			public <>c__4()
			{
			}

			[Token(Token = "0x6000236")]
			internal void <ParralelFor>b__4_0(object state)
			{
			}
		}

		[Token(Token = "0x200006E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521448", Offset = "0x521448")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action act;

			[Token(Token = "0x6000237")]
			[Address(RVA = "0xDA3738", Offset = "0xDA3738", VA = "0xDA3738")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000238")]
			[Address(RVA = "0xDAB6A0", Offset = "0xDAB6A0", VA = "0xDAB6A0")]
			internal void <QueueWorkItem>b__0(object x)
			{
			}
		}

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _remainingWorkItems;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ManualResetEvent _done;

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xDA33B8", Offset = "0xDA33B8", VA = "0xDA33B8")]
		public void QueueWorkItem(WaitCallback callback)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xDA3458", Offset = "0xDA3458", VA = "0xDA3458")]
		public void QueueWorkItem(Action act)
		{
		}

		[Token(Token = "0x6000228")]
		public void ParralelFor<T>(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xDA3580", Offset = "0xDA3580", VA = "0xDA3580")]
		private void QueueWorkItem(QueuedCallback callback)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xDA33C0", Offset = "0xDA33C0", VA = "0xDA33C0")]
		public void QueueWorkItem(WaitCallback callback, object state)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xDA3460", Offset = "0xDA3460", VA = "0xDA3460")]
		public void QueueWorkItem(Action act, object state)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xDA3740", Offset = "0xDA3740", VA = "0xDA3740")]
		public bool WaitAll()
		{
			return default(bool);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xDA3898", Offset = "0xDA3898", VA = "0xDA3898")]
		public bool WaitAll(TimeSpan timeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xDA374C", Offset = "0xDA374C", VA = "0xDA374C")]
		public bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xDA39E0", Offset = "0xDA39E0", VA = "0xDA39E0")]
		private void HandleWorkItem(object state)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xDA38F8", Offset = "0xDA38F8", VA = "0xDA38F8")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xDA36C4", Offset = "0xDA36C4", VA = "0xDA36C4")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xDA3ACC", Offset = "0xDA3ACC", VA = "0xDA3ACC", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xDA3B90", Offset = "0xDA3B90", VA = "0xDA3B90")]
		public ThreadPoolWorker()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x521458", Offset = "0x521458")]
	public class ComponentPool : MonoBehaviour, IPool, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000070")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521490", Offset = "0x521490")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string typeName;

			[Token(Token = "0x6000254")]
			[Address(RVA = "0xDA7F48", Offset = "0xDA7F48", VA = "0xDA7F48")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000255")]
			[Address(RVA = "0xDA7F50", Offset = "0xDA7F50", VA = "0xDA7F50")]
			internal bool <OnAfterDeserialize>b__0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private string m_Identifier;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Inline]
		private PoolSettings m_Settings;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PoolManager mManager;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Component> mObjects;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private double mLastTime;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double mDeltaTime;

		[Token(Token = "0x17000050")]
		public PoolSettings Settings
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x986F3C", Offset = "0x986F3C", VA = "0x986F3C", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x986F44", Offset = "0x986F44", VA = "0x986F44")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public PoolManager Manager
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x986F94", Offset = "0x986F94", VA = "0x986F94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public string Identifier
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x987048", Offset = "0x987048", VA = "0x987048", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x987050", Offset = "0x987050", VA = "0x987050", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public Type Type
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x9870A4", Offset = "0x9870A4", VA = "0x9870A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public int Count
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x987208", Offset = "0x987208", VA = "0x987208", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x987254", Offset = "0x987254", VA = "0x987254")]
		public void Initialize(Type type, PoolSettings settings)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x9874A0", Offset = "0x9874A0", VA = "0x9874A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x9874C4", Offset = "0x9874C4", VA = "0x9874C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x987580", Offset = "0x987580", VA = "0x987580")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x987584", Offset = "0x987584", VA = "0x987584", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x98733C", Offset = "0x98733C", VA = "0x98733C", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x987AE0", Offset = "0x987AE0", VA = "0x987AE0")]
		public void OnSceneLoaded(Scene scn, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x987BF4", Offset = "0x987BF4", VA = "0x987BF4", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x987CDC", Offset = "0x987CDC", VA = "0x987CDC")]
		public void Push(Component item)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x987FF8", Offset = "0x987FF8", VA = "0x987FF8")]
		public Component Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		public T Pop<T>(Transform parent) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x987978", Offset = "0x987978", VA = "0x987978")]
		private Component create()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x9878C0", Offset = "0x9878C0", VA = "0x9878C0")]
		private void destroy(Component item)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x988430", Offset = "0x988430", VA = "0x988430")]
		private void setParent(Component item, Transform parent)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x988204", Offset = "0x988204", VA = "0x988204")]
		private void sendAfterPop(Component item)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x987E34", Offset = "0x987E34", VA = "0x987E34")]
		private void sendBeforePush(Component item)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x9877E0", Offset = "0x9877E0", VA = "0x9877E0")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x9884DC", Offset = "0x9884DC", VA = "0x9884DC", Slot = "11")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x9884E0", Offset = "0x9884E0", VA = "0x9884E0", Slot = "12")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x988790", Offset = "0x988790", VA = "0x988790")]
		public ComponentPool()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class DTSingleton<T> : MonoBehaviour, IDTSingleton where T : MonoBehaviour, IDTSingleton
	{
		[Serializable]
		[Token(Token = "0x2000072")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5214A0", Offset = "0x5214A0")]
		private sealed class <>c
		{
			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<UnityEngine.Object, bool> <>9__7_0;

			[Token(Token = "0x600025F")]
			public <>c()
			{
			}

			[Token(Token = "0x6000260")]
			internal bool <get_Instance>b__7_0(UnityEngine.Object o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool applicationIsQuitting;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool isDuplicateInstance;

		[Token(Token = "0x17000055")]
		public static bool HasInstance
		{
			[Token(Token = "0x6000256")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		public static T Instance
		{
			[Token(Token = "0x6000257")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000258")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x6000259")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600025A")]
		public virtual void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}

		[Token(Token = "0x600025B")]
		private void DestroySelf()
		{
		}

		[Token(Token = "0x600025C")]
		public DTSingleton()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public interface IDTSingleton
	{
		[Token(Token = "0x6000261")]
		void MergeDoubleLoaded(IDTSingleton newInstance);
	}
	[Token(Token = "0x2000074")]
	public abstract class DTVersionedMonoBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private string m_Version;

		[Token(Token = "0x17000057")]
		public string Version
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x98DB5C", Offset = "0x98DB5C", VA = "0x98DB5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x98DB64", Offset = "0x98DB64", VA = "0x98DB64")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x98DB6C", Offset = "0x98DB6C", VA = "0x98DB6C")]
		public void Destroy()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x98DC1C", Offset = "0x98DC1C", VA = "0x98DC1C")]
		protected DTVersionedMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5214B0", Offset = "0x5214B0")]
	public abstract class DuplicateEditorMesh : MonoBehaviour
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MeshFilter mFilter;

		[Token(Token = "0x17000058")]
		public MeshFilter Filter
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x98DEF4", Offset = "0x98DEF4", VA = "0x98DEF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x98DFA8", Offset = "0x98DFA8", VA = "0x98DFA8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x98E234", Offset = "0x98E234", VA = "0x98E234")]
		protected DuplicateEditorMesh()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x521520", Offset = "0x521520")]
	public class InspectorNote : MonoBehaviour
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x521E44", Offset = "0x521E44")]
		private string m_Note;

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x6F2910", Offset = "0x6F2910", VA = "0x6F2910")]
		public InspectorNote()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x521558", Offset = "0x521558")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class PoolManager : MonoBehaviour
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x521E84", Offset = "0x521E84")]
		private bool m_AutoCreatePools;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "AsGroupAttribute", RVA = "0x521EDC", Offset = "0x521EDC")]
		private PoolSettings m_DefaultSettings;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521F24", Offset = "0x521F24")]
		private bool <IsInitialized>k__BackingField;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, IPool> Pools;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<Type, IPool> TypePools;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IPool[] mPools;

		[Token(Token = "0x17000059")]
		public bool AutoCreatePools
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0xE20B24", Offset = "0xE20B24", VA = "0xE20B24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0xE20B2C", Offset = "0xE20B2C", VA = "0xE20B2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public PoolSettings DefaultSettings
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0xE20B4C", Offset = "0xE20B4C", VA = "0xE20B4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026D")]
			[Address(RVA = "0xE20B54", Offset = "0xE20B54", VA = "0xE20B54")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public bool IsInitialized
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0xE20C18", Offset = "0xE20C18", VA = "0xE20C18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522CF0", Offset = "0x522CF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xE20C20", Offset = "0xE20C20", VA = "0xE20C20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522D00", Offset = "0x522D00")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public int Count
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0xE20C2C", Offset = "0xE20C2C", VA = "0xE20C2C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xE20CB4", Offset = "0xE20CB4", VA = "0xE20CB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xE20CBC", Offset = "0xE20CBC", VA = "0xE20CBC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xE20E7C", Offset = "0xE20E7C", VA = "0xE20E7C")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xE21308", Offset = "0xE21308", VA = "0xE21308")]
		public string GetUniqueIdentifier(string ident)
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		public Pool<T> GetTypePool<T>()
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		public ComponentPool GetComponentPool<T>() where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xE213BC", Offset = "0xE213BC", VA = "0xE213BC")]
		public PrefabPool GetPrefabPool(string identifier, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		public Pool<T> CreateTypePool<T>([Optional] PoolSettings settings)
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		public ComponentPool CreateComponentPool<T>([Optional] PoolSettings settings) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xE214C0", Offset = "0xE214C0", VA = "0xE214C0")]
		public PrefabPool CreatePrefabPool(string name, [Optional] PoolSettings settings, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xE21870", Offset = "0xE21870", VA = "0xE21870")]
		public List<IPool> FindPools(string identifierStartsWith)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xE21A3C", Offset = "0xE21A3C", VA = "0xE21A3C")]
		public void DeletePools(string startsWith)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xE21AF4", Offset = "0xE21AF4", VA = "0xE21AF4")]
		public void DeletePool(IPool pool)
		{
		}

		[Token(Token = "0x600027E")]
		public void DeletePool<T>()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xE21CDC", Offset = "0xE21CDC", VA = "0xE21CDC")]
		public PoolManager()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5215B4", Offset = "0x5215B4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5215B4", Offset = "0x5215B4")]
	public class PrefabPool : MonoBehaviour, IPool
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x521F34", Offset = "0x521F34")]
		[SerializeField]
		private string m_Identifier;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> m_Prefabs;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Inline]
		private PoolSettings m_Settings;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PoolManager mManager;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<GameObject> mObjects;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double mLastTime;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private double mDeltaTime;

		[Token(Token = "0x1700005D")]
		public string Identifier
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0xE21FDC", Offset = "0xE21FDC", VA = "0xE21FDC", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000281")]
			[Address(RVA = "0xE21FE4", Offset = "0xE21FE4", VA = "0xE21FE4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public List<GameObject> Prefabs
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0xE22118", Offset = "0xE22118", VA = "0xE22118")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000283")]
			[Address(RVA = "0xE22120", Offset = "0xE22120", VA = "0xE22120")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public PoolSettings Settings
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0xE22138", Offset = "0xE22138", VA = "0xE22138", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000285")]
			[Address(RVA = "0xE22140", Offset = "0xE22140", VA = "0xE22140")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public PoolManager Manager
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0xE22064", Offset = "0xE22064", VA = "0xE22064")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public int Count
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0xE2256C", Offset = "0xE2256C", VA = "0xE2256C", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xE2218C", Offset = "0xE2218C", VA = "0xE2218C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xE22190", Offset = "0xE22190", VA = "0xE22190")]
		private void Start()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xE21740", Offset = "0xE21740", VA = "0xE21740")]
		public void Initialize(string ident, PoolSettings settings, params GameObject[] prefabs)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xE22318", Offset = "0xE22318", VA = "0xE22318", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xE221B4", Offset = "0xE221B4", VA = "0xE221B4", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xE228D8", Offset = "0xE228D8", VA = "0xE228D8", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xE229C0", Offset = "0xE229C0", VA = "0xE229C0")]
		public GameObject Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xE22C1C", Offset = "0xE22C1C", VA = "0xE22C1C", Slot = "11")]
		public virtual void Push(GameObject item)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xE226FC", Offset = "0xE226FC", VA = "0xE226FC")]
		private GameObject create()
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xE22698", Offset = "0xE22698", VA = "0xE22698")]
		private void destroy(GameObject go)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xE225B8", Offset = "0xE225B8", VA = "0xE225B8")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xE22E1C", Offset = "0xE22E1C", VA = "0xE22E1C")]
		private void setParent(Transform item, Transform parent)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xE22BC0", Offset = "0xE22BC0", VA = "0xE22BC0")]
		private void sendAfterPop(GameObject item)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xE22DC0", Offset = "0xE22DC0", VA = "0xE22DC0")]
		private void sendBeforePush(GameObject item)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xE22EBC", Offset = "0xE22EBC", VA = "0xE22EBC")]
		public PrefabPool()
		{
		}
	}
}
namespace FluffyUnderware.DevTools.Extensions
{
	[Token(Token = "0x2000079")]
	public static class ObjectExt
	{
		[Token(Token = "0x6000297")]
		[Address(RVA = "0xE182C8", Offset = "0xE182C8", VA = "0xE182C8")]
		public static void Destroy(this UnityEngine.Object c)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xE1832C", Offset = "0xE1832C", VA = "0xE1832C")]
		public static string ToDumpString(this object o)
		{
			return null;
		}
	}
	[Token(Token = "0x200007A")]
	public static class Vector2Ext
	{
		[Token(Token = "0x6000299")]
		[Address(RVA = "0xDA6DCC", Offset = "0xDA6DCC", VA = "0xDA6DCC")]
		public static Vector2 Snap(this Vector2 v, float snapX, float snapY = -1f)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xDA6E24", Offset = "0xDA6E24", VA = "0xDA6E24")]
		public static float AngleSigned(this Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xDA6F78", Offset = "0xDA6F78", VA = "0xDA6F78")]
		public static Vector2 LeftNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xDA6F8C", Offset = "0xDA6F8C", VA = "0xDA6F8C")]
		public static Vector2 RightNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xDA6F9C", Offset = "0xDA6F9C", VA = "0xDA6F9C")]
		public static Vector2 Rotate(this Vector2 v, float degree)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xDA6FFC", Offset = "0xDA6FFC", VA = "0xDA6FFC")]
		public static Vector2 ToVector3(this Vector2 v)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x200007B")]
	public static class Vector3Ext
	{
		[Token(Token = "0x600029F")]
		[Address(RVA = "0xDA7000", Offset = "0xDA7000", VA = "0xDA7000")]
		public static float AngleSigned(this Vector3 a, Vector3 b, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xDA70A4", Offset = "0xDA70A4", VA = "0xDA70A4")]
		public static Vector3 RotateAround(this Vector3 point, Vector3 origin, Quaternion rotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xDA7104", Offset = "0xDA7104", VA = "0xDA7104")]
		public static Vector2 ToVector2(this Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xDA7108", Offset = "0xDA7108", VA = "0xDA7108")]
		public static bool Approximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xDA713C", Offset = "0xDA713C", VA = "0xDA713C")]
		public static bool NotApproximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007C")]
	public static class QuaternionExt
	{
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xE22F6C", Offset = "0xE22F6C", VA = "0xE22F6C")]
		public static bool SameOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xE23048", Offset = "0xE23048", VA = "0xE23048")]
		public static bool DifferentOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007D")]
	public static class CameraExt
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Plane[] camPlanes;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Vector3 camPos;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static Vector3 camForward;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float fov;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static float screenW;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static float screenH;

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x985EFC", Offset = "0x985EFC", VA = "0x985EFC")]
		public static bool BoundsInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x9861F0", Offset = "0x9861F0", VA = "0x9861F0")]
		public static bool BoundsPartiallyInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007E")]
	public static class GameObjectExt
	{
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x6F1764", Offset = "0x6F1764", VA = "0x6F1764")]
		public static GameObject DuplicateGameObject(this GameObject source, Transform newParent, bool keepPrefabReference = false)
		{
			return null;
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x6F1868", Offset = "0x6F1868", VA = "0x6F1868")]
		public static void StripComponents(this GameObject go, params Type[] toKeep)
		{
		}
	}
	[Token(Token = "0x200007F")]
	public static class ComponentExt
	{
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x986B4C", Offset = "0x986B4C", VA = "0x986B4C")]
		public static void StripComponents(this Component c, params Type[] toKeep)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x986C38", Offset = "0x986C38", VA = "0x986C38")]
		public static GameObject AddChildGameObject(this Component c, string name)
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		public static T AddChildGameObject<T>(this Component c, string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		public static T DuplicateGameObject<T>(this Component source, Transform newParent, bool keepPrefabConnection = false) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x986CE0", Offset = "0x986CE0", VA = "0x986CE0")]
		public static Component DuplicateGameObject(this Component source, Transform newParent, bool keepPrefabConnection = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000080")]
	public static class ColorExt
	{
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x9865A8", Offset = "0x9865A8", VA = "0x9865A8")]
		public static string ToHtml(this Color c)
		{
			return null;
		}
	}
	[Token(Token = "0x2000081")]
	public static class EnumExt
	{
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x990808", Offset = "0x990808", VA = "0x990808")]
		public static bool HasFlag(this Enum variable, params Enum[] flags)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B2")]
		public static bool HasFlag<T>(this T value, T flag) where T : struct
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		public static T Set<T>(this Enum value, T append)
		{
			return (T)null;
		}

		[Token(Token = "0x60002B4")]
		public static T Set<T>(this Enum value, T append, bool OnOff)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000082")]
	public static class RectExt
	{
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xE2327C", Offset = "0xE2327C", VA = "0xE2327C")]
		public static Rect Set(this Rect rect, Vector2 pos, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xE232D8", Offset = "0xE232D8", VA = "0xE232D8")]
		public static Rect SetBetween(this Rect rect, Vector2 pos, Vector2 pos2)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xE23334", Offset = "0xE23334", VA = "0xE23334")]
		public static Rect SetPosition(this Rect rect, Vector2 pos)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xE233A0", Offset = "0xE233A0", VA = "0xE233A0")]
		public static Rect SetPosition(this Rect rect, float x, float y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xE2340C", Offset = "0xE2340C", VA = "0xE2340C")]
		public static Vector2 GetSize(this Rect rect)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xE23458", Offset = "0xE23458", VA = "0xE23458")]
		public static Rect SetSize(this Rect rect, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xE234C4", Offset = "0xE234C4", VA = "0xE234C4")]
		public static Rect ScaleBy(this Rect rect, int pixel)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xE234CC", Offset = "0xE234CC", VA = "0xE234CC")]
		public static Rect ScaleBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xE235A4", Offset = "0xE235A4", VA = "0xE235A4")]
		public static Rect ShiftBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xE23634", Offset = "0xE23634", VA = "0xE23634")]
		public static Rect Include(this Rect rect, Rect other)
		{
			return default(Rect);
		}
	}
	[Token(Token = "0x2000083")]
	public static class StringExt
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xD9E890", Offset = "0xD9E890", VA = "0xD9E890")]
		public static Color ColorFromHtml(this string hexString)
		{
			return default(Color);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xD9EB7C", Offset = "0xD9EB7C", VA = "0xD9EB7C")]
		public static string TrimStart(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xD9EBD0", Offset = "0xD9EBD0", VA = "0xD9EBD0")]
		public static string TrimEnd(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}
	}
	[Token(Token = "0x2000084")]
	public static class IEnumerableExt
	{
		[Token(Token = "0x60002C2")]
		public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
		{
		}
	}
	[Token(Token = "0x2000085")]
	public static class ArrayExt
	{
		[Token(Token = "0x60002C3")]
		public static T[] SubArray<T>(this T[] data, int index, int length)
		{
			return null;
		}

		[Token(Token = "0x60002C4")]
		public static T[] RemoveAt<T>(this T[] source, int index)
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		public static T[] InsertAt<T>(this T[] source, int index)
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		public static T[] Swap<T>(this T[] source, int index, int with)
		{
			return null;
		}

		[Token(Token = "0x60002C7")]
		public static T[] Add<T>(this T[] source, T item)
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		public static T[] AddRange<T>(this T[] source, T[] items)
		{
			return null;
		}

		[Token(Token = "0x60002C9")]
		public static T[] RemoveDuplicates<T>(this T[] source)
		{
			return null;
		}

		[Token(Token = "0x60002CA")]
		public static int IndexOf<T>(this T[] source, T item)
		{
			return default(int);
		}

		[Token(Token = "0x60002CB")]
		public static T[] Remove<T>(this T[] source, T item)
		{
			return null;
		}
	}
	[Token(Token = "0x2000086")]
	public static class MeshFilterExt
	{
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xE167A0", Offset = "0xE167A0", VA = "0xE167A0")]
		public static Mesh PrepareNewShared(this MeshFilter m, string name = "Mesh")
		{
			return null;
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xE1692C", Offset = "0xE1692C", VA = "0xE1692C")]
		public static void CalculateTangents(this MeshFilter m)
		{
		}
	}
	[Token(Token = "0x2000087")]
	public static class TypeExt
	{
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xDA50BC", Offset = "0xDA50BC", VA = "0xDA50BC")]
		public static Type[] GetLoadedTypes()
		{
			return null;
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xDA5600", Offset = "0xDA5600", VA = "0xDA5600")]
		public static IEnumerable<Assembly> GetLoadedAssemblies()
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		public static Dictionary<U, Type> GetAllTypesWithAttribute<U>(this Type type)
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		public static List<FieldInfo> GetFieldsWithAttribute<T>(this Type type, bool includeInherited = false, bool includePrivate = false) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		public static T GetCustomAttribute<T>(this Type type) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xDA5624", Offset = "0xDA5624", VA = "0xDA5624")]
		public static MethodInfo MethodByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xDA57D4", Offset = "0xDA57D4", VA = "0xDA57D4")]
		public static FieldInfo FieldByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xDA599C", Offset = "0xDA599C", VA = "0xDA599C")]
		public static PropertyInfo PropertyByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xDA5B4C", Offset = "0xDA5B4C", VA = "0xDA5B4C")]
		public static FieldInfo[] GetAllFields(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xDA5D04", Offset = "0xDA5D04", VA = "0xDA5D04")]
		public static PropertyInfo[] GetAllProperties(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xDA5EBC", Offset = "0xDA5EBC", VA = "0xDA5EBC")]
		public static bool IsFrameworkType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xDA5FDC", Offset = "0xDA5FDC", VA = "0xDA5FDC")]
		public static bool IsArrayOrList(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xDA60CC", Offset = "0xDA60CC", VA = "0xDA60CC")]
		public static Type GetEnumerableType(this Type t)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xDA6188", Offset = "0xDA6188", VA = "0xDA6188")]
		private static Type FindIEnumerable(Type seqType)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xDA5658", Offset = "0xDA5658", VA = "0xDA5658")]
		private static MethodInfo GetMethodIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xDA5810", Offset = "0xDA5810", VA = "0xDA5810")]
		private static FieldInfo GetFieldIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xDA59D0", Offset = "0xDA59D0", VA = "0xDA59D0")]
		private static PropertyInfo GetPropertyIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xDA65F4", Offset = "0xDA65F4", VA = "0xDA65F4")]
		public static bool Matches(this Type type, params Type[] types)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000088")]
	public static class FieldInfoExt
	{
		[Token(Token = "0x60002E0")]
		public static T GetCustomAttribute<T>(this FieldInfo field) where T : Attribute
		{
			return null;
		}
	}
}
namespace DarkTonic.MasterAudio
{
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x521738", Offset = "0x521738")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x521738", Offset = "0x521738")]
	public class AmbientSound : MonoBehaviour
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SoundGroup]
		public string AmbientSoundGroup;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string variationName;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float playVolume;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public MasterAudio.AmbientSoundExitMode exitMode;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float exitFadeTime;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AmbientSoundReEnterMode reEnterMode;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float reEnterFadeTime;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x522014", Offset = "0x522014")]
		public bool FollowCaller;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52204C", Offset = "0x52204C")]
		public bool UseClosestColliderPosition;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		public bool UseTopCollider;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		public bool IncludeChildColliders;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x522084", Offset = "0x522084")]
		public Transform RuntimeFollower;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _trans;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float colliderMaxDistance;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public long lastTimeMaxDistanceCalced;

		[Token(Token = "0x17000062")]
		public bool IsValidSoundGroup
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x98035C", Offset = "0x98035C", VA = "0x98035C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000063")]
		public Transform Trans
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x980558", Offset = "0x980558", VA = "0x980558")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x9801A0", Offset = "0x9801A0", VA = "0x9801A0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x980204", Offset = "0x980204", VA = "0x980204")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x9803F0", Offset = "0x9803F0", VA = "0x9803F0")]
		private void StopTrackers()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x9805F8", Offset = "0x9805F8", VA = "0x9805F8")]
		public void CalculateRadius()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x9806EC", Offset = "0x9806EC", VA = "0x9806EC")]
		public AudioSource GetNamedOrFirstAudioSource()
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x9808D4", Offset = "0x9808D4", VA = "0x9808D4")]
		public List<AudioSource> GetAllVariationAudioSources()
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x980B04", Offset = "0x980B04", VA = "0x980B04")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x980D84", Offset = "0x980D84", VA = "0x980D84")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x981004", Offset = "0x981004", VA = "0x981004")]
		public void StartTrackers()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x981228", Offset = "0x981228", VA = "0x981228")]
		public AmbientSound()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x521788", Offset = "0x521788")]
	public class ButtonClicker : MonoBehaviour
	{
		[Token(Token = "0x4000177")]
		public const float SmallSizeMultiplier = 0.9f;

		[Token(Token = "0x4000178")]
		public const float LargeSizeMultiplier = 1.1f;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool resizeOnClick;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool resizeClickAllSiblings;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool resizeOnHover;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool resizeHoverAllSiblings;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mouseDownSound;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string mouseUpSound;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mouseClickSound;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mouseOverSound;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mouseOutSound;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _originalSize;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _smallerSize;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _largerSize;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _trans;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Dictionary<Transform, Vector3> _siblingClickScaleByTransform;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<Transform, Vector3> _siblingHoverScaleByTransform;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x985600", Offset = "0x985600", VA = "0x985600")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x985874", Offset = "0x985874", VA = "0x985874")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x985AC8", Offset = "0x985AC8", VA = "0x985AC8")]
		private void OnClick()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x985B64", Offset = "0x985B64", VA = "0x985B64")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x985DB8", Offset = "0x985DB8", VA = "0x985DB8")]
		public ButtonClicker()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5217C0", Offset = "0x5217C0")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x5217C0", Offset = "0x5217C0")]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x200008C")]
		public enum UnityUIVersion
		{
			[Token(Token = "0x40001FC")]
			Legacy,
			[Token(Token = "0x40001FD")]
			uGUI
		}

		[Token(Token = "0x200008D")]
		public enum EventType
		{
			[Token(Token = "0x40001FF")]
			OnStart,
			[Token(Token = "0x4000200")]
			OnVisible,
			[Token(Token = "0x4000201")]
			OnInvisible,
			[Token(Token = "0x4000202")]
			OnCollision,
			[Token(Token = "0x4000203")]
			OnTriggerEnter,
			[Token(Token = "0x4000204")]
			OnTriggerExit,
			[Token(Token = "0x4000205")]
			OnMouseEnter,
			[Token(Token = "0x4000206")]
			OnMouseClick,
			[Token(Token = "0x4000207")]
			OnSpawned,
			[Token(Token = "0x4000208")]
			OnDespawned,
			[Token(Token = "0x4000209")]
			OnEnable,
			[Token(Token = "0x400020A")]
			OnDisable,
			[Token(Token = "0x400020B")]
			OnCollision2D,
			[Token(Token = "0x400020C")]
			OnTriggerEnter2D,
			[Token(Token = "0x400020D")]
			OnTriggerExit2D,
			[Token(Token = "0x400020E")]
			OnParticleCollision,
			[Token(Token = "0x400020F")]
			UserDefinedEvent,
			[Token(Token = "0x4000210")]
			OnCollisionExit,
			[Token(Token = "0x4000211")]
			OnCollisionExit2D,
			[Token(Token = "0x4000212")]
			OnMouseUp,
			[Token(Token = "0x4000213")]
			OnMouseExit,
			[Token(Token = "0x4000214")]
			OnMouseDrag,
			[Token(Token = "0x4000215")]
			NGUIOnClick,
			[Token(Token = "0x4000216")]
			NGUIMouseDown,
			[Token(Token = "0x4000217")]
			NGUIMouseUp,
			[Token(Token = "0x4000218")]
			NGUIMouseEnter,
			[Token(Token = "0x4000219")]
			NGUIMouseExit,
			[Token(Token = "0x400021A")]
			MechanimStateChanged,
			[Token(Token = "0x400021B")]
			UnitySliderChanged,
			[Token(Token = "0x400021C")]
			UnityButtonClicked,
			[Token(Token = "0x400021D")]
			UnityPointerDown,
			[Token(Token = "0x400021E")]
			UnityPointerUp,
			[Token(Token = "0x400021F")]
			UnityPointerEnter,
			[Token(Token = "0x4000220")]
			UnityPointerExit,
			[Token(Token = "0x4000221")]
			UnityDrag,
			[Token(Token = "0x4000222")]
			UnityDrop,
			[Token(Token = "0x4000223")]
			UnityScroll,
			[Token(Token = "0x4000224")]
			UnityUpdateSelected,
			[Token(Token = "0x4000225")]
			UnitySelect,
			[Token(Token = "0x4000226")]
			UnityDeselect,
			[Token(Token = "0x4000227")]
			UnityMove,
			[Token(Token = "0x4000228")]
			UnityInitializePotentialDrag,
			[Token(Token = "0x4000229")]
			UnityBeginDrag,
			[Token(Token = "0x400022A")]
			UnityEndDrag,
			[Token(Token = "0x400022B")]
			UnitySubmit,
			[Token(Token = "0x400022C")]
			UnityCancel,
			[Token(Token = "0x400022D")]
			UnityToggle,
			[Token(Token = "0x400022E")]
			OnTriggerStay,
			[Token(Token = "0x400022F")]
			OnTriggerStay2D
		}

		[Token(Token = "0x200008E")]
		public enum GlidePitchType
		{
			[Token(Token = "0x4000231")]
			None,
			[Token(Token = "0x4000232")]
			RaisePitch,
			[Token(Token = "0x4000233")]
			LowerPitch
		}

		[Token(Token = "0x200008F")]
		public enum VariationType
		{
			[Token(Token = "0x4000235")]
			PlaySpecific,
			[Token(Token = "0x4000236")]
			PlayRandom
		}

		[Token(Token = "0x2000090")]
		public enum PreviousSoundStopMode
		{
			[Token(Token = "0x4000238")]
			None,
			[Token(Token = "0x4000239")]
			Stop,
			[Token(Token = "0x400023A")]
			FadeOut
		}

		[Token(Token = "0x2000091")]
		public enum RetriggerLimMode
		{
			[Token(Token = "0x400023C")]
			None,
			[Token(Token = "0x400023D")]
			FrameBased,
			[Token(Token = "0x400023E")]
			TimeBased
		}

		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521810", Offset = "0x521810")]
		private sealed class <CoUpdate>d__123 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EventSounds <>4__this;

			[Token(Token = "0x17000066")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000330")]
				[Address(RVA = "0xDA850C", Offset = "0xDA850C", VA = "0xDA850C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000332")]
				[Address(RVA = "0xDA8554", Offset = "0xDA8554", VA = "0xDA8554", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0xDA8340", Offset = "0xDA8340", VA = "0xDA8340")]
			[DebuggerHidden]
			public <CoUpdate>d__123(int <>1__state)
			{
			}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0xDA836C", Offset = "0xDA836C", VA = "0xDA836C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0xDA8370", Offset = "0xDA8370", VA = "0xDA8370", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0xDA8514", Offset = "0xDA8514", VA = "0xDA8514", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521820", Offset = "0x521820")]
		private sealed class <>c__DisplayClass165_0
		{
			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string stateName;

			[Token(Token = "0x6000333")]
			[Address(RVA = "0xDA8314", Offset = "0xDA8314", VA = "0xDA8314")]
			public <>c__DisplayClass165_0()
			{
			}

			[Token(Token = "0x6000334")]
			[Address(RVA = "0xDA831C", Offset = "0xDA831C", VA = "0xDA831C")]
			internal bool <GetMechanimAudioEventGroup>b__0(AudioEventGroup grp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disableSounds;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool showPoolManager;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool showNGUI;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioEvent eventToGizmo;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityUIVersion unityUIMode;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool logMissingEvents;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> LayerTagFilterEvents;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<MasterAudio.PlaylistCommand> PlaylistCommandsWithAll;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEventGroup startSound;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioEventGroup visibleSound;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioEventGroup invisibleSound;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioEventGroup collisionSound;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioEventGroup collisionExitSound;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioEventGroup triggerSound;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioEventGroup triggerExitSound;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioEventGroup triggerStaySound;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioEventGroup mouseEnterSound;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioEventGroup mouseExitSound;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AudioEventGroup mouseClickSound;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AudioEventGroup mouseUpSound;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AudioEventGroup mouseDragSound;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioEventGroup spawnedSound;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AudioEventGroup despawnedSound;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AudioEventGroup enableSound;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AudioEventGroup disableSound;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AudioEventGroup collision2dSound;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AudioEventGroup collisionExit2dSound;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public AudioEventGroup triggerEnter2dSound;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AudioEventGroup triggerStay2dSound;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AudioEventGroup triggerExit2dSound;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AudioEventGroup particleCollisionSound;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioEventGroup nguiOnClickSound;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AudioEventGroup nguiMouseDownSound;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public AudioEventGroup nguiMouseUpSound;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public AudioEventGroup nguiMouseEnterSound;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public AudioEventGroup nguiMouseExitSound;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public AudioEventGroup unitySliderChangedSound;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AudioEventGroup unityButtonClickedSound;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public AudioEventGroup unityPointerDownSound;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public AudioEventGroup unityDragSound;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AudioEventGroup unityPointerUpSound;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioEventGroup unityPointerEnterSound;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioEventGroup unityPointerExitSound;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public AudioEventGroup unityDropSound;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public AudioEventGroup unityScrollSound;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public AudioEventGroup unityUpdateSelectedSound;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public AudioEventGroup unitySelectSound;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public AudioEventGroup unityDeselectSound;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public AudioEventGroup unityMoveSound;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public AudioEventGroup unityInitializePotentialDragSound;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public AudioEventGroup unityBeginDragSound;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public AudioEventGroup unityEndDragSound;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public AudioEventGroup unitySubmitSound;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AudioEventGroup unityCancelSound;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public AudioEventGroup unityToggleSound;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public List<AudioEventGroup> userDefinedSounds;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public List<AudioEventGroup> mechanimStateChangedSounds;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public bool useStartSound;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		public bool useVisibleSound;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		public bool useInvisibleSound;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BB")]
		public bool useCollisionSound;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public bool useCollisionExitSound;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
		public bool useTriggerEnterSound;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BE")]
		public bool useTriggerExitSound;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BF")]
		public bool useTriggerStaySound;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public bool useMouseEnterSound;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C1")]
		public bool useMouseExitSound;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C2")]
		public bool useMouseClickSound;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C3")]
		public bool useMouseUpSound;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public bool useMouseDragSound;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C5")]
		public bool useSpawnedSound;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C6")]
		public bool useDespawnedSound;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C7")]
		public bool useEnableSound;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public bool useDisableSound;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		public bool useCollision2dSound;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		public bool useCollisionExit2dSound;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CB")]
		public bool useTriggerEnter2dSound;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool useTriggerStay2dSound;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CD")]
		public bool useTriggerExit2dSound;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CE")]
		public bool useParticleCollisionSound;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CF")]
		public bool useNguiOnClickSound;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool useNguiMouseDownSound;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		public bool useNguiMouseUpSound;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		public bool useNguiMouseEnterSound;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		public bool useNguiMouseExitSound;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool useUnitySliderChangedSound;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
		public bool useUnityButtonClickedSound;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D6")]
		public bool useUnityPointerDownSound;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D7")]
		public bool useUnityDragSound;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public bool useUnityPointerUpSound;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
		public bool useUnityPointerEnterSound;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DA")]
		public bool useUnityPointerExitSound;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DB")]
		public bool useUnityDropSound;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public bool useUnityScrollSound;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DD")]
		public bool useUnityUpdateSelectedSound;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DE")]
		public bool useUnitySelectSound;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DF")]
		public bool useUnityDeselectSound;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public bool useUnityMoveSound;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		public bool useUnityInitializePotentialDragSound;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		public bool useUnityBeginDragSound;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		public bool useUnityEndDragSound;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public bool useUnitySubmitSound;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		public bool useUnityCancelSound;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E6")]
		public bool useUnityToggleSound;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Slider _slider;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Toggle _toggle;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Button _button;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private bool _isVisible;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x201")]
		private bool _needsCoroutine;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private float? _triggerEnterTime;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private float? _triggerEnter2dTime;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Transform _trans;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<AudioEventGroup> _validMechanimStateChangedSounds;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Animator _anim;

		[Token(Token = "0x17000064")]
		private bool IsSetToUGUI
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x990B64", Offset = "0x990B64", VA = "0x990B64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		private bool IsSetToLegacyUI
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x9924D4", Offset = "0x9924D4", VA = "0x9924D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x990A3C", Offset = "0x990A3C", VA = "0x990A3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x990DE0", Offset = "0x990DE0", VA = "0x990DE0", Slot = "10")]
		protected virtual void SpawnedOrAwake()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x990F40", Offset = "0x990F40", VA = "0x990F40")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x523170", Offset = "0x523170")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x990FB8", Offset = "0x990FB8", VA = "0x990FB8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x991670", Offset = "0x991670", VA = "0x991670")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x991698", Offset = "0x991698", VA = "0x991698")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x9916B4", Offset = "0x9916B4", VA = "0x9916B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x991970", Offset = "0x991970", VA = "0x991970")]
		private void RestorePersistentSliders()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x991D00", Offset = "0x991D00", VA = "0x991D00")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x99214C", Offset = "0x99214C", VA = "0x99214C")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x992268", Offset = "0x992268", VA = "0x992268")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x992288", Offset = "0x992288", VA = "0x992288")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x9922A8", Offset = "0x9922A8", VA = "0x9922A8")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x9922C8", Offset = "0x9922C8", VA = "0x9922C8")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x9922E8", Offset = "0x9922E8", VA = "0x9922E8")]
		private void OnDrag(Vector2 delta)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x9922EC", Offset = "0x9922EC", VA = "0x9922EC")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x99230C", Offset = "0x99230C", VA = "0x99230C")]
		private void OnDrop(GameObject go)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x992310", Offset = "0x992310", VA = "0x992310")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x992330", Offset = "0x992330", VA = "0x992330")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x992350", Offset = "0x992350", VA = "0x992350")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x992370", Offset = "0x992370", VA = "0x992370")]
		private void OnSelect(bool isSelected)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x992374", Offset = "0x992374", VA = "0x992374")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x992394", Offset = "0x992394", VA = "0x992394")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x9923B4", Offset = "0x9923B4", VA = "0x9923B4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x9923D4", Offset = "0x9923D4", VA = "0x9923D4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x9923F4", Offset = "0x9923F4", VA = "0x9923F4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x992414", Offset = "0x992414", VA = "0x992414")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x992434", Offset = "0x992434", VA = "0x992434")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x992454", Offset = "0x992454", VA = "0x992454")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x992474", Offset = "0x992474", VA = "0x992474")]
		private void SliderChanged(float newValue)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x9924A4", Offset = "0x9924A4", VA = "0x9924A4")]
		private void ToggleChanged(bool newValue)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x9924BC", Offset = "0x9924BC", VA = "0x9924BC")]
		private void ButtonClicked()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x9924E4", Offset = "0x9924E4", VA = "0x9924E4")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x99251C", Offset = "0x99251C", VA = "0x99251C")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x99253C", Offset = "0x99253C", VA = "0x99253C")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x992574", Offset = "0x992574", VA = "0x992574")]
		private void OnSpawned()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x9925C4", Offset = "0x9925C4", VA = "0x9925C4")]
		private void OnDespawned()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x9925E4", Offset = "0x9925E4", VA = "0x9925E4")]
		public void CalculateRadius(AudioEvent anEvent)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x99268C", Offset = "0x99268C", VA = "0x99268C")]
		public AudioSource GetNamedOrFirstAudioSource(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x992878", Offset = "0x992878", VA = "0x992878")]
		public List<AudioSource> GetAllVariationAudioSources(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x992AAC", Offset = "0x992AAC", VA = "0x992AAC")]
		public AudioEventGroup GetMechanimAudioEventGroup(string stateName)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x991408", Offset = "0x991408", VA = "0x991408")]
		public bool PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
			return default(bool);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x995218", Offset = "0x995218", VA = "0x995218")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x995410", Offset = "0x995410", VA = "0x995410")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x992BA8", Offset = "0x992BA8", VA = "0x992BA8")]
		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x992C40", Offset = "0x992C40", VA = "0x992C40")]
		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x995608", Offset = "0x995608", VA = "0x995608")]
		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x990FF8", Offset = "0x990FF8", VA = "0x990FF8", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x995910", Offset = "0x995910", VA = "0x995910", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x9959EC", Offset = "0x9959EC", VA = "0x9959EC", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x991C64", Offset = "0x991C64", VA = "0x991C64", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x9920B8", Offset = "0x9920B8", VA = "0x9920B8", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x995AC4", Offset = "0x995AC4", VA = "0x995AC4", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x990B74", Offset = "0x990B74", VA = "0x990B74")]
		private void AddUGUIComponents()
		{
		}

		[Token(Token = "0x600032A")]
		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x995B18", Offset = "0x995B18", VA = "0x995B18")]
		public EventSounds()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5220BC", Offset = "0x5220BC")]
		private EventSounds <eventSounds>k__BackingField;

		[Token(Token = "0x17000068")]
		public EventSounds eventSounds
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x6EE228", Offset = "0x6EE228", VA = "0x6EE228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523220", Offset = "0x523220")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x6EE230", Offset = "0x6EE230", VA = "0x6EE230")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523230", Offset = "0x523230")]
			set
			{
			}
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x6ED8B8", Offset = "0x6ED8B8", VA = "0x6ED8B8")]
		public EventSoundsUGUIHandler()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x6EDE20", Offset = "0x6EDE20", VA = "0x6EDE20", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x6EDEC4", Offset = "0x6EDEC4", VA = "0x6EDEC4")]
		public EventSoundsPointerEnterHandler()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x6EDECC", Offset = "0x6EDECC", VA = "0x6EDECC", Slot = "4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x6EDF70", Offset = "0x6EDF70", VA = "0x6EDF70")]
		public EventSoundsPointerExitHandler()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x6EDD74", Offset = "0x6EDD74", VA = "0x6EDD74", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x6EDE18", Offset = "0x6EDE18", VA = "0x6EDE18")]
		public EventSoundsPointerDownHandler()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x6EDF78", Offset = "0x6EDF78", VA = "0x6EDF78", Slot = "4")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x6EE01C", Offset = "0x6EE01C", VA = "0x6EE01C")]
		public EventSoundsPointerUpHandler()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x6EDA18", Offset = "0x6EDA18", VA = "0x6EDA18", Slot = "4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x6EDABC", Offset = "0x6EDABC", VA = "0x6EDABC")]
		public EventSoundsDragHandler()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x6EDAC4", Offset = "0x6EDAC4", VA = "0x6EDAC4", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x6EDB68", Offset = "0x6EDB68", VA = "0x6EDB68")]
		public EventSoundsDropHandler()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x6EE024", Offset = "0x6EE024", VA = "0x6EE024", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x6EE0C8", Offset = "0x6EE0C8", VA = "0x6EE0C8")]
		public EventSoundsScrollHandler()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x6EE238", Offset = "0x6EE238", VA = "0x6EE238", Slot = "4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x6EE2DC", Offset = "0x6EE2DC", VA = "0x6EE2DC")]
		public EventSoundsUpdateSelectedHandler()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x6EE0D0", Offset = "0x6EE0D0", VA = "0x6EE0D0", Slot = "4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x6EE174", Offset = "0x6EE174", VA = "0x6EE174")]
		public EventSoundsSelectHandler()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x6ED96C", Offset = "0x6ED96C", VA = "0x6ED96C", Slot = "4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x6EDA10", Offset = "0x6EDA10", VA = "0x6EDA10")]
		public EventSoundsDeselectHandler()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x6EDCC8", Offset = "0x6EDCC8", VA = "0x6EDCC8", Slot = "4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x6EDD6C", Offset = "0x6EDD6C", VA = "0x6EDD6C")]
		public EventSoundsMoveHandler()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x6EDC1C", Offset = "0x6EDC1C", VA = "0x6EDC1C", Slot = "4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x6EDCC0", Offset = "0x6EDCC0", VA = "0x6EDCC0")]
		public EventSoundsInitializePotentialDragHandler()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x6ED80C", Offset = "0x6ED80C", VA = "0x6ED80C", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x6ED8B0", Offset = "0x6ED8B0", VA = "0x6ED8B0")]
		public EventSoundsBeginDragHandler()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x6EDB70", Offset = "0x6EDB70", VA = "0x6EDB70", Slot = "4")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x6EDC14", Offset = "0x6EDC14", VA = "0x6EDC14")]
		public EventSoundsEndDragHandler()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x6EE17C", Offset = "0x6EE17C", VA = "0x6EE17C", Slot = "4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x6EE220", Offset = "0x6EE220", VA = "0x6EE220")]
		public EventSoundsSubmitHandler()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x6ED8C0", Offset = "0x6ED8C0", VA = "0x6ED8C0", Slot = "4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x6ED964", Offset = "0x6ED964", VA = "0x6ED964")]
		public EventSoundsCancelHandler()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x521830", Offset = "0x521830")]
	public class FootstepSounds : MonoBehaviour
	{
		[Token(Token = "0x20000A6")]
		public enum FootstepTriggerMode
		{
			[Token(Token = "0x400024E")]
			None,
			[Token(Token = "0x400024F")]
			OnCollision,
			[Token(Token = "0x4000250")]
			OnTriggerEnter,
			[Token(Token = "0x4000251")]
			OnCollision2D,
			[Token(Token = "0x4000252")]
			OnTriggerEnter2D
		}

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public FootstepTriggerMode footstepEvent;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FootstepGroup> footstepGroups;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int limitPerXFrm;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float limitPerXSec;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int triggeredLastFrame;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float triggeredLastTime;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _trans;

		[Token(Token = "0x17000069")]
		private Transform Trans
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x6F0FEC", Offset = "0x6F0FEC", VA = "0x6F0FEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x6F0C30", Offset = "0x6F0C30", VA = "0x6F0C30")]
		private bool CheckForRetriggerLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x6F0CC0", Offset = "0x6F0CC0", VA = "0x6F0CC0")]
		private void PlaySoundsIfMatch(GameObject go)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x6F16C8", Offset = "0x6F16C8", VA = "0x6F16C8")]
		public FootstepSounds()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5220CC", Offset = "0x5220CC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5220CC", Offset = "0x5220CC")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52212C", Offset = "0x52212C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52212C", Offset = "0x52212C")]
		public bool fireEnterEvent;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MasterCustomEvent]
		public string enterCustomEvent;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52219C", Offset = "0x52219C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52219C", Offset = "0x52219C")]
		public bool fireExitEvent;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[MasterCustomEvent]
		public string exitCustomEvent;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52220C", Offset = "0x52220C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52220C", Offset = "0x52220C")]
		public bool fireAnimTimeEvent;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52226C", Offset = "0x52226C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52226C", Offset = "0x52226C")]
		public float whenToFireEvent;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[MasterCustomEvent]
		public string timedCustomEvent;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5222D0", Offset = "0x5222D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5222D0", Offset = "0x5222D0")]
		public bool fireMultiAnimTimeEvent;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x522330", Offset = "0x522330")]
		public int numOfMultiEventsToFire;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x522348", Offset = "0x522348")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x522348", Offset = "0x522348")]
		public float whenToFireMultiEvent1;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52239C", Offset = "0x52239C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52239C", Offset = "0x52239C")]
		public float whenToFireMultiEvent2;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5223F0", Offset = "0x5223F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5223F0", Offset = "0x5223F0")]
		public float whenToFireMultiEvent3;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x522444", Offset = "0x522444")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x522444", Offset = "0x522444")]
		public float whenToFireMultiEvent4;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[MasterCustomEvent]
		public string MultiTimedEvent;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _playMultiEvent1;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _playMultiEvent2;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _playMultiEvent3;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool _playMultiEvent4;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fireTimedEvent;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _actorTrans;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _lastRepetition;

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xE15430", Offset = "0xE15430", VA = "0xE15430", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xE155C8", Offset = "0xE155C8", VA = "0xE155C8", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xE158F0", Offset = "0xE158F0", VA = "0xE158F0", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xE15520", Offset = "0xE15520", VA = "0xE15520")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xE159D0", Offset = "0xE159D0", VA = "0xE159D0")]
		public MechanimStateCustomEvents()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5224A8", Offset = "0x5224A8")]
		public bool SoundFollowsObject;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5224E0", Offset = "0x5224E0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5224E0", Offset = "0x5224E0")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x522540", Offset = "0x522540")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x522540", Offset = "0x522540")]
		public bool playEnterSound;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool stopEnterSoundOnExit;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SoundGroup]
		public string enterSoundGroup;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5225B0", Offset = "0x5225B0")]
		public string enterVariationName;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool wasEnterSoundPlayed;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5225E8", Offset = "0x5225E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5225E8", Offset = "0x5225E8")]
		public bool playExitSound;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SoundGroup]
		public string exitSoundGroup;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x522658", Offset = "0x522658")]
		public string exitVariationName;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x522690", Offset = "0x522690")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x522690", Offset = "0x522690")]
		public bool playAnimTimeSound;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool stopAnimTimeSoundOnExit;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5226F0", Offset = "0x5226F0")]
		public bool useStopTime;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x522728", Offset = "0x522728")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x522728", Offset = "0x522728")]
		public float whenToStartSound;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52277C", Offset = "0x52277C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52277C", Offset = "0x52277C")]
		public float whenToStopSound;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SoundGroup]
		public string TimedSoundGroup;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5227E0", Offset = "0x5227E0")]
		public string timedVariationName;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool playSoundStart;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool playSoundStop;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x522818", Offset = "0x522818")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x522818", Offset = "0x522818")]
		public bool playMultiAnimTimeSounds;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool StopMultiAnimTimeSoundsOnExit;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x522878", Offset = "0x522878")]
		public int numOfMultiSoundsToPlay;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x522890", Offset = "0x522890")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x522890", Offset = "0x522890")]
		public float whenToStartMultiSound1;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5228E4", Offset = "0x5228E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5228E4", Offset = "0x5228E4")]
		public float whenToStartMultiSound2;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x522938", Offset = "0x522938")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x522938", Offset = "0x522938")]
		public float whenToStartMultiSound3;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52298C", Offset = "0x52298C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52298C", Offset = "0x52298C")]
		public float whenToStartMultiSound4;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SoundGroup]
		public string MultiSoundsTimedGroup;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5229F0", Offset = "0x5229F0")]
		public string multiTimedVariationName;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool playMultiSound1;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool playMultiSound2;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool playMultiSound3;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		private bool playMultiSound4;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _actorTrans;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastRepetition;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xE15A74", Offset = "0xE15A74", VA = "0xE15A74", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xE15CFC", Offset = "0xE15CFC", VA = "0xE15CFC", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xE164B4", Offset = "0xE164B4", VA = "0xE164B4", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xE15BFC", Offset = "0xE15BFC", VA = "0xE15BFC")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xE15CA4", Offset = "0xE15CA4", VA = "0xE15CA4")]
		private static string GetVariationName(string varName)
		{
			return null;
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xE166FC", Offset = "0xE166FC", VA = "0xE166FC")]
		public MechanimStateSounds()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[SerializeField]
	public class PlaySoundResult
	{
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522A28", Offset = "0x522A28")]
		private bool <SoundPlayed>k__BackingField;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522A38", Offset = "0x522A38")]
		private bool <SoundScheduled>k__BackingField;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522A48", Offset = "0x522A48")]
		private SoundGroupVariation <ActingVariation>k__BackingField;

		[Token(Token = "0x1700006A")]
		public bool SoundPlayed
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0xE19548", Offset = "0xE19548", VA = "0xE19548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523240", Offset = "0x523240")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000369")]
			[Address(RVA = "0xE19550", Offset = "0xE19550", VA = "0xE19550")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523250", Offset = "0x523250")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public bool SoundScheduled
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0xE1955C", Offset = "0xE1955C", VA = "0xE1955C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523260", Offset = "0x523260")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600036B")]
			[Address(RVA = "0xE19564", Offset = "0xE19564", VA = "0xE19564")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523270", Offset = "0x523270")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public SoundGroupVariation ActingVariation
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0xE19570", Offset = "0xE19570", VA = "0xE19570")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523280", Offset = "0x523280")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036D")]
			[Address(RVA = "0xE19578", Offset = "0xE19578", VA = "0xE19578")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523290", Offset = "0x523290")]
			set
			{
			}
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xE19514", Offset = "0xE19514", VA = "0xE19514")]
		public PlaySoundResult()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	public class AmbientSoundToTriggerInfo
	{
		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int frameToTrigger;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AmbientSound ambient;

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x9812D0", Offset = "0x9812D0", VA = "0x9812D0")]
		public AmbientSoundToTriggerInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class AudioEvent
	{
		[Token(Token = "0x20000AC")]
		public enum TargetVolumeMode
		{
			[Token(Token = "0x40002B9")]
			UseSliderValue,
			[Token(Token = "0x40002BA")]
			UseSpecificValue
		}

		[Serializable]
		[Token(Token = "0x20000AD")]
		public class MA_SnapshotInfo
		{
			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixerSnapshot snapshot;

			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x6000371")]
			[Address(RVA = "0xDA719C", Offset = "0xDA719C", VA = "0xDA719C")]
			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
			}
		}

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actionName;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isExpanded;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string soundType;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allPlaylistControllersForGroupCmd;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool allSoundTypesForGroupCmd;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool allSoundTypesForBusCmd;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float volume;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useFixedPitch;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float pitch;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EventSounds.GlidePitchType glidePitchType;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float targetGlidePitch;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitchGlideTime;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float delaySound;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MasterAudio.BusCommand currentBusCommand;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public MasterAudio.GlobalCommand currentGlobalCommand;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MasterAudio.UnityMixerCommand currentMixerCommand;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioMixerSnapshot snapshotToTransitionTo;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float snapshotTransitionTime;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<MA_SnapshotInfo> snapshotsToBlend;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string playlistName;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string playlistControllerName;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool startPlaylist;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float fadeVolume;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float fadeTime;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float minAge;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool stopAfterFade;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool restoreVolumeAfterFade;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetVolumeMode targetVolMode;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string clipName;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string variationName;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float colliderMaxDistance;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public bool showSphereGizmo;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string theCustomEventName;

		[Token(Token = "0x1700006D")]
		public bool IsFadeCommand
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x98221C", Offset = "0x98221C", VA = "0x98221C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x982284", Offset = "0x982284", VA = "0x982284")]
		public AudioEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public class AudioEventGroup
	{
		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool allPlayersShouldHear;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useLayerFilter;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool useTagFilter;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool customSoundActive;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isCustomEvent;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string customEventName;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool mechanimEventActive;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isMechanimStateCheckEvent;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mechanimStateName;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mechEventPlayedForState;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<AudioEvent> SoundEvents;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float mouseDragFadeOutTime;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int limitPerXFrm;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float limitPerXSec;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int triggeredLastFrame;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float triggeredLastTime;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float triggerStayForTime;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool doesTriggerStayRepeat;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float sliderValue;

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x982490", Offset = "0x982490", VA = "0x982490")]
		public AudioEventGroup()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class AudioScriptOrder : Attribute
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Order;

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x984624", Offset = "0x984624", VA = "0x984624")]
		public AudioScriptOrder(int order)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class BusFadeInfo
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GroupBus ActingBus;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x9855E0", Offset = "0x9855E0", VA = "0x9855E0")]
		public BusFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class BusPitchGlideInfo
	{
		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float CompletionTime;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool IsActive;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action completionAction;

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x9855F0", Offset = "0x9855F0", VA = "0x9855F0")]
		public BusPitchGlideInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public class CustomEvent
	{
		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ProspectiveName;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsEditing;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool eventExpanded;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float distanceThreshold;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudio.EventReceiveFilter eventRcvFilterMode;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int filterModeQty;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isTemporary;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int frameLastFired;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string categoryName;

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x9894D8", Offset = "0x9894D8", VA = "0x9894D8")]
		public CustomEvent(string eventName)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public class CustomEventCategory
	{
		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string CatName;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsExpanded;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool IsEditing;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool IsTemporary;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x98957C", Offset = "0x98957C", VA = "0x98957C")]
		public CustomEventCategory()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public class CustomEventToFireInfo
	{
		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string eventName;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform eventOrigin;

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x9895F0", Offset = "0x9895F0", VA = "0x9895F0")]
		public CustomEventToFireInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	public class DuckGroupInfo
	{
		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundType;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float riseVolStart;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unduckTime;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duckedVolumeCut;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isTemporary;

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x98DE84", Offset = "0x98DE84", VA = "0x98DE84")]
		public DuckGroupInfo()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x522A58", Offset = "0x522A58")]
		public int probabilityToPlay;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool useLocalization;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool useRandomPitch;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float randomPitchMin;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMax;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool useRandomVolume;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float randomVolumeMin;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMax;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int weight;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isExpanded;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool isChecked;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool useFades;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float fadeInTime;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float fadeOutTime;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool useCustomLooping;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int minCustomLoops;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxCustomLoops;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useIntroSilence;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float introSilenceMin;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float introSilenceMax;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool useRandomStartTime;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float randomStartMinPercent;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float randomStartMaxPercent;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float randomEndPercent;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private DynamicSoundGroup _parentGroupScript;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioSource _aud;

		[Token(Token = "0x1700006E")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x98E23C", Offset = "0x98E23C", VA = "0x98E23C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x98E2F0", Offset = "0x98E2F0", VA = "0x98E2F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x98E3A4", Offset = "0x98E3A4", VA = "0x98E3A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x98E458", Offset = "0x98E458", VA = "0x98E458")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x98E50C", Offset = "0x98E50C", VA = "0x98E50C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x98E5C0", Offset = "0x98E5C0", VA = "0x98E5C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public DynamicSoundGroup ParentGroup
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x98E674", Offset = "0x98E674", VA = "0x98E674")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public Transform Trans
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x98E7FC", Offset = "0x98E7FC", VA = "0x98E7FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x98E89C", Offset = "0x98E89C", VA = "0x98E89C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x98EAF0", Offset = "0x98EAF0", VA = "0x98EAF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x98EBA4", Offset = "0x98EBA4", VA = "0x98EBA4")]
		public DynamicGroupVariation()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class DynamicSoundGroup : MonoBehaviour
	{
		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject variationTemplate;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float groupMasterVolume;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int retriggerPercentage;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudioGroup.VariationSequence curVariationSequence;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudioGroup.VariationMode curVariationMode;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float chainLoopDelayMin;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMax;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chainLoopNumLoops;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useDialogFadeOut;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dialogFadeOutTime;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string comments;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool logSound;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int busIndex;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float spatialBlend;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string busName;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool isExistingBus;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool isCopiedFromDGSC;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public MasterAudioGroup.LimitMode limitMode;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int limitPerXFrames;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float minimumTimeBetween;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool limitPolyphony;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int voiceLimitCount;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float despawnFadeTime;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool isUsingOcclusion;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool copySettingsExpanded;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool expandLinkedGroups;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<string> childSoundGroups;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public List<DynamicGroupVariation> groupVariations;

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x98EBDC", Offset = "0x98EBDC", VA = "0x98EBDC")]
		public DynamicSoundGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B8")]
	public class FootstepGroup
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundType;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string variationName;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float volume;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useFixedPitch;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitch;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float delaySound;

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x6F0A8C", Offset = "0x6F0A8C", VA = "0x6F0A8C")]
		public FootstepGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public class GroupBus
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string busName;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isSoloed;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool isMuted;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int voiceLimit;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool stopOldest;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExisting;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isTemporary;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool isUsingOcclusion;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color busColor;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool forceTo2D;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<int> _activeAudioSourcesIds;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _originalVolume;

		[Token(Token = "0x17000078")]
		public int ActiveVoices
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x6F2710", Offset = "0x6F2710", VA = "0x6F2710")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000079")]
		public bool BusVoiceLimitReached
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x6F275C", Offset = "0x6F275C", VA = "0x6F275C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007A")]
		public float OriginalVolume
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x6F27C4", Offset = "0x6F27C4", VA = "0x6F27C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x6F27CC", Offset = "0x6F27CC", VA = "0x6F27CC")]
			set
			{
			}
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x6F260C", Offset = "0x6F260C", VA = "0x6F260C")]
		public void AddActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x6F26AC", Offset = "0x6F26AC", VA = "0x6F26AC")]
		public void RemoveActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x6F27D4", Offset = "0x6F27D4", VA = "0x6F27D4")]
		public GroupBus()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BA")]
	public class GroupFadeInfo
	{
		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x6F28D0", Offset = "0x6F28D0", VA = "0x6F28D0")]
		public GroupFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BB")]
	public class GroupPitchGlideInfo
	{
		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CompletionTime;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool IsActive;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action completionAction;

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x6F28E0", Offset = "0x6F28E0", VA = "0x6F28E0")]
		public GroupPitchGlideInfo()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public interface ICustomEventReceiver
	{
		[Token(Token = "0x6000390")]
		void CheckForIllegalCustomEvents();

		[Token(Token = "0x6000391")]
		void ReceiveEvent(string customEventName, Vector3 originPoint);

		[Token(Token = "0x6000392")]
		bool SubscribesToEvent(string customEventName);

		[Token(Token = "0x6000393")]
		void RegisterReceiver();

		[Token(Token = "0x6000394")]
		void UnregisterReceiver();

		[Token(Token = "0x6000395")]
		IList<AudioEventGroup> GetAllEvents();
	}
	[Token(Token = "0x20000BD")]
	public class MasterAudioGroup : MonoBehaviour
	{
		[Token(Token = "0x20000BE")]
		public enum TargetDespawnedBehavior
		{
			[Token(Token = "0x40003B4")]
			None,
			[Token(Token = "0x40003B5")]
			Stop,
			[Token(Token = "0x40003B6")]
			FadeOut
		}

		[Token(Token = "0x20000BF")]
		public enum VariationSequence
		{
			[Token(Token = "0x40003B8")]
			Randomized,
			[Token(Token = "0x40003B9")]
			TopToBottom
		}

		[Token(Token = "0x20000C0")]
		public enum VariationMode
		{
			[Token(Token = "0x40003BB")]
			Normal,
			[Token(Token = "0x40003BC")]
			LoopedChain,
			[Token(Token = "0x40003BD")]
			Dialog
		}

		[Token(Token = "0x20000C1")]
		public enum ChainedLoopLoopMode
		{
			[Token(Token = "0x40003BF")]
			Endless,
			[Token(Token = "0x40003C0")]
			NumberOfLoops
		}

		[Token(Token = "0x20000C2")]
		public enum LimitMode
		{
			[Token(Token = "0x40003C2")]
			None,
			[Token(Token = "0x40003C3")]
			FrameBased,
			[Token(Token = "0x40003C4")]
			TimeBased
		}

		[Token(Token = "0x4000379")]
		public const float UseCurveSpatialBlend = -99f;

		[Token(Token = "0x400037A")]
		public const string NoBus = "[NO BUS]";

		[Token(Token = "0x400037B")]
		public const int MinNoRepeatVariations = 3;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int busIndex;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spatialBlend;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isSelected;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExpanded;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float groupMasterVolume;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int retriggerPercentage;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VariationMode curVariationMode;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float chainLoopDelayMin;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float chainLoopDelayMax;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int chainLoopNumLoops;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool useDialogFadeOut;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float dialogFadeOutTime;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public VariationSequence curVariationSequence;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupVariation> groupVariations;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string comments;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool logSound;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool copySettingsExpanded;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		public bool expandLinkedGroups;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<string> childSoundGroups;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public LimitMode limitMode;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int limitPerXFrames;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float minimumTimeBetween;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool useClipAgePriority;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool limitPolyphony;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int voiceLimitCount;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float despawnFadeTime;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool isSoloed;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		public bool isMuted;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool willCleanUpDelegatesAfterStop;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public int frames;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<int> _activeAudioSourcesIds;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string _objectName;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Transform _trans;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float _originalVolume;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522A80", Offset = "0x522A80")]
		private int <ChainLoopCount>k__BackingField;

		[Token(Token = "0x1700007B")]
		public float SpatialBlendForGroup
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0xE14EE0", Offset = "0xE14EE0", VA = "0xE14EE0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700007C")]
		public int ActiveVoices
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0xE14FCC", Offset = "0xE14FCC", VA = "0xE14FCC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007D")]
		public int TotalVoices
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0xE1501C", Offset = "0xE1501C", VA = "0xE1501C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007E")]
		public bool WillCleanUpDelegatesAfterStop
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0xE15040", Offset = "0xE15040", VA = "0xE15040")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public GroupBus BusForGroup
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0xE14D64", Offset = "0xE14D64", VA = "0xE14D64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public float OriginalVolume
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0xE1504C", Offset = "0xE1504C", VA = "0xE1504C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0xE15054", Offset = "0xE15054", VA = "0xE15054")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public bool LoggingEnabledForGroup
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0xE1505C", Offset = "0xE1505C", VA = "0xE1505C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000082")]
		public int ChainLoopCount
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0xE15128", Offset = "0xE15128", VA = "0xE15128")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5232C0", Offset = "0x5232C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0xE15130", Offset = "0xE15130", VA = "0xE15130")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5232D0", Offset = "0x5232D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public string GameObjectName
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xE15138", Offset = "0xE15138", VA = "0xE15138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public bool UsesNoRepeat
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xE15188", Offset = "0xE15188", VA = "0xE15188")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		private Transform Trans
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xE14C04", Offset = "0xE14C04", VA = "0xE14C04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		private List<int> ActiveAudioSourceIds
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0xE14B4C", Offset = "0xE14B4C", VA = "0xE14B4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action LastVariationFinishedPlay
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0xE148F0", Offset = "0xE148F0", VA = "0xE148F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5232A0", Offset = "0x5232A0")]
			add
			{
			}
			[Token(Token = "0x6000397")]
			[Address(RVA = "0xE14990", Offset = "0xE14990", VA = "0xE14990")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5232B0", Offset = "0x5232B0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xE14A30", Offset = "0xE14A30", VA = "0xE14A30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xE14CA4", Offset = "0xE14CA4", VA = "0xE14CA4")]
		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xE14E50", Offset = "0xE14E50", VA = "0xE14E50")]
		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xE150D4", Offset = "0xE150D4", VA = "0xE150D4")]
		public void FireLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xE150E8", Offset = "0xE150E8", VA = "0xE150E8")]
		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xE1511C", Offset = "0xE1511C", VA = "0xE1511C")]
		public void UnsubscribeFromLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xE151F8", Offset = "0xE151F8", VA = "0xE151F8")]
		public MasterAudioGroup()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class MasterCustomEventAttribute : PropertyAttribute
	{
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xE153B8", Offset = "0xE153B8", VA = "0xE153B8")]
		public MasterCustomEventAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C4")]
	public class MusicSetting
	{
		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521878", Offset = "0x521878")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataStringValue valToClone;

			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xDA9E58", Offset = "0xDA9E58", VA = "0xDA9E58")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xDA9E60", Offset = "0xDA9E60", VA = "0xDA9E60")]
			internal bool <Clone>b__0(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521888", Offset = "0x521888")]
		private sealed class <>c__DisplayClass32_1
		{
			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataFloatValue valToClone;

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0xDA9E8C", Offset = "0xDA9E8C", VA = "0xDA9E8C")]
			public <>c__DisplayClass32_1()
			{
			}

			[Token(Token = "0x60003B6")]
			[Address(RVA = "0xDA9E94", Offset = "0xDA9E94", VA = "0xDA9E94")]
			internal bool <Clone>b__1(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521898", Offset = "0x521898")]
		private sealed class <>c__DisplayClass32_2
		{
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataBoolValue valToClone;

			[Token(Token = "0x60003B7")]
			[Address(RVA = "0xDA9EC0", Offset = "0xDA9EC0", VA = "0xDA9EC0")]
			public <>c__DisplayClass32_2()
			{
			}

			[Token(Token = "0x60003B8")]
			[Address(RVA = "0xDA9EC8", Offset = "0xDA9EC8", VA = "0xDA9EC8")]
			internal bool <Clone>b__2(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5218A8", Offset = "0x5218A8")]
		private sealed class <>c__DisplayClass32_3
		{
			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataIntValue valToClone;

			[Token(Token = "0x60003B9")]
			[Address(RVA = "0xDA9EF4", Offset = "0xDA9EF4", VA = "0xDA9EF4")]
			public <>c__DisplayClass32_3()
			{
			}

			[Token(Token = "0x60003BA")]
			[Address(RVA = "0xDA9EFC", Offset = "0xDA9EFC", VA = "0xDA9EFC")]
			internal bool <Clone>b__3(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string alias;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string songName;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string resourceFileName;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pitch;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isExpanded;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isLoop;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool isChecked;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<SongMetadataStringValue> metadataStringValues;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<SongMetadataBoolValue> metadataBoolValues;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SongMetadataIntValue> metadataIntValues;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SongMetadataFloatValue> metadataFloatValues;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool metadataExpanded;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public MasterAudio.CustomSongStartTimeMode songStartTimeMode;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float customStartTime;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float customStartTimeMax;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int lastKnownTimePoint;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool wasLastKnownTimePointSet;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int songIndex;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool songStartedEventExpanded;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string songStartedCustomEvent;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string songChangedCustomEvent;

		[Token(Token = "0x17000087")]
		public bool HasMetadataProperties
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0xE17910", Offset = "0xE17910", VA = "0xE17910")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000088")]
		public int MetadataPropertyCount
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xE1792C", Offset = "0xE1792C", VA = "0xE1792C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000089")]
		public float SongStartTime
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xE179CC", Offset = "0xE179CC", VA = "0xE179CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xE176F4", Offset = "0xE176F4", VA = "0xE176F4")]
		public MusicSetting()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xE179F8", Offset = "0xE179F8", VA = "0xE179F8")]
		public static MusicSetting Clone(MusicSetting mus, MasterAudio.Playlist aList)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000C9")]
	public class OcclusionFreqChangeInfo
	{
		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundGroupVariation ActingVariation;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float StartFrequency;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float TargetFrequency;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartTime;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float CompletionTime;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xE183A8", Offset = "0xE183A8", VA = "0xE183A8")]
		public OcclusionFreqChangeInfo()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class PlaylistAttribute : PropertyAttribute
	{
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xE19580", Offset = "0xE19580", VA = "0xE19580")]
		public PlaylistAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CB")]
	public class SongMetadataBoolValue
	{
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Value;

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xE18184", Offset = "0xE18184", VA = "0xE18184")]
		public SongMetadataBoolValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CC")]
	public class SongMetadataFloatValue
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xE18140", Offset = "0xE18140", VA = "0xE18140")]
		public SongMetadataFloatValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CD")]
	public class SongMetadataIntValue
	{
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Value;

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xE181C8", Offset = "0xE181C8", VA = "0xE181C8")]
		public SongMetadataIntValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CE")]
	public class SongMetadataProperty
	{
		[Token(Token = "0x20000CF")]
		public enum MetadataPropertyType
		{
			[Token(Token = "0x40003F6")]
			Boolean,
			[Token(Token = "0x40003F7")]
			String,
			[Token(Token = "0x40003F8")]
			Integer,
			[Token(Token = "0x40003F9")]
			Float
		}

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MetadataPropertyType PropertyType;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string PropertyName;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsEditing;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool PropertyExpanded;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool AllSongsMustContain;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool CanSongHaveMultiple;

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xE23788", Offset = "0xE23788", VA = "0xE23788")]
		public SongMetadataProperty(string propertyName, MetadataPropertyType propertyType, bool allSongsMustContain, bool canSongHaveMultiple)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D0")]
	public class SongMetadataStringValue
	{
		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Value;

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xE180FC", Offset = "0xE180FC", VA = "0xE180FC")]
		public SongMetadataStringValue(SongMetadataProperty prop)
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class SoundGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xE2383C", Offset = "0xE2383C", VA = "0xE2383C")]
		public SoundGroupAttribute()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x5218B8", Offset = "0x5218B8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5218B8", Offset = "0x5218B8")]
	public class SoundGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x20000D3")]
		public delegate void SoundFinishedEventHandler();

		[Token(Token = "0x20000D4")]
		public delegate void SoundLoopedEventHandler(int loopNumberStarted);

		[Token(Token = "0x20000D5")]
		public class PlaySoundParams
		{
			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string SoundType;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VolumePercentage;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float? Pitch;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double? TimeToSchedulePlay;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform SourceTrans;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool AttachToSource;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float DelaySoundTime;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool IsChainLoop;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool IsSingleSubscribedPlay;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float GroupCalcVolume;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool IsPlaying;

			[Token(Token = "0x600041A")]
			[Address(RVA = "0xDAB0B8", Offset = "0xDAB0B8", VA = "0xDAB0B8")]
			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, double? timeToSchedulePlay, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		[Token(Token = "0x20000D6")]
		public enum PitchMode
		{
			[Token(Token = "0x400044C")]
			None,
			[Token(Token = "0x400044D")]
			Gliding
		}

		[Token(Token = "0x20000D7")]
		public enum FadeMode
		{
			[Token(Token = "0x400044F")]
			None,
			[Token(Token = "0x4000450")]
			FadeInOut,
			[Token(Token = "0x4000451")]
			FadeOutEarly,
			[Token(Token = "0x4000452")]
			GradualFade
		}

		[Token(Token = "0x20000D8")]
		public enum RandomPitchMode
		{
			[Token(Token = "0x4000454")]
			AddToClipPitch,
			[Token(Token = "0x4000455")]
			IgnoreClipPitch
		}

		[Token(Token = "0x20000D9")]
		public enum RandomVolumeMode
		{
			[Token(Token = "0x4000457")]
			AddToClipVolume,
			[Token(Token = "0x4000458")]
			IgnoreClipVolume
		}

		[Token(Token = "0x20000DA")]
		public enum DetectEndMode
		{
			[Token(Token = "0x400045A")]
			None,
			[Token(Token = "0x400045B")]
			DetectEnd
		}

		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52192C", Offset = "0x52192C")]
		private sealed class <WaitForLoadToUnloadClipAndDeactivate>d__106 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundGroupVariation <>4__this;

			[Token(Token = "0x170000AA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600041E")]
				[Address(RVA = "0xDAB068", Offset = "0xDAB068", VA = "0xDAB068", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000420")]
				[Address(RVA = "0xDAB0B0", Offset = "0xDAB0B0", VA = "0xDAB0B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0xDAAF60", Offset = "0xDAAF60", VA = "0xDAAF60")]
			[DebuggerHidden]
			public <WaitForLoadToUnloadClipAndDeactivate>d__106(int <>1__state)
			{
			}

			[Token(Token = "0x600041C")]
			[Address(RVA = "0xDAAF8C", Offset = "0xDAAF8C", VA = "0xDAAF8C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0xDAAF90", Offset = "0xDAAF90", VA = "0xDAAF90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0xDAB070", Offset = "0xDAB070", VA = "0xDAB070", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int weight;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x522A90", Offset = "0x522A90")]
		public int probabilityToPlay;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useLocalization;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool useRandomPitch;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public RandomPitchMode randomPitchMode;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMin;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMax;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useRandomVolume;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMin;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMax;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float original_pitch;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float original_volume;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool isExpanded;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool isChecked;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool useFades;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float fadeInTime;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float fadeOutTime;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool useCustomLooping;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int minCustomLoops;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int maxCustomLoops;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useRandomStartTime;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float randomStartMinPercent;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float randomStartMaxPercent;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float randomEndPercent;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool useIntroSilence;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float introSilenceMin;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float introSilenceMax;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float fadeMaxVolume;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public FadeMode curFadeMode;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public PitchMode curPitchMode;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public DetectEndMode curDetectEndMode;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int frames;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioSource _audioSource;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly PlaySoundParams _playSndParam;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _maxVol;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int _instanceId;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool? _audioLoops;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private int _maxLoops;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private SoundGroupVariationUpdater _varUpdater;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _previousSoundFinishedFrame;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private string _soundGroupName;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private MasterAudio.VariationLoadStatus _loadStatus;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool _isStopRequested;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
		private bool _isPaused;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
		private bool _isWarmingPlay;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Transform _trans;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private GameObject _go;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Transform _objectToFollow;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform _objectToTriggerFrom;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private MasterAudioGroup _parentGroupScript;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool _attachToSource;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private string _resFileName;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool _hasStartedEndLinkedGroups;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Coroutine _loadResourceFileCoroutine;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Coroutine _loadAddressableCoroutine;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _isUnloadAddressableCoroutineRunning;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522AC8", Offset = "0x522AC8")]
		private float <LastTimePlayed>k__BackingField;

		[Token(Token = "0x1700008A")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0xE26F8C", Offset = "0xE26F8C", VA = "0xE26F8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xE27040", Offset = "0xE27040", VA = "0xE27040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xE270F4", Offset = "0xE270F4", VA = "0xE270F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0xE271A8", Offset = "0xE271A8", VA = "0xE271A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0xE2725C", Offset = "0xE2725C", VA = "0xE2725C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0xE27264", Offset = "0xE27264", VA = "0xE27264")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0xE2726C", Offset = "0xE2726C", VA = "0xE2726C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public Transform ObjectToFollow
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0xE27320", Offset = "0xE27320", VA = "0xE27320")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0xE27328", Offset = "0xE27328", VA = "0xE27328")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public Transform ObjectToTriggerFrom
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0xE2749C", Offset = "0xE2749C", VA = "0xE2749C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0xE274A4", Offset = "0xE274A4", VA = "0xE274A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0xE274D4", Offset = "0xE274D4", VA = "0xE274D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000093")]
		public MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xE242E8", Offset = "0xE242E8", VA = "0xE242E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public float OriginalPitch
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xE25430", Offset = "0xE25430", VA = "0xE25430")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000095")]
		public float OriginalVolume
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0xE27718", Offset = "0xE27718", VA = "0xE27718")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000096")]
		public string SoundGroupName
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0xE27758", Offset = "0xE27758", VA = "0xE27758")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public bool IsAvailableToPlay
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0xE277A8", Offset = "0xE277A8", VA = "0xE277A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000098")]
		public float LastTimePlayed
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0xE27850", Offset = "0xE27850", VA = "0xE27850")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523380", Offset = "0x523380")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0xE27858", Offset = "0xE27858", VA = "0xE27858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523390", Offset = "0x523390")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public bool ClipIsLoaded
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xE27860", Offset = "0xE27860", VA = "0xE27860")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009A")]
		public bool IsPlaying
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0xE26090", Offset = "0xE26090", VA = "0xE26090")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009B")]
		public MasterAudio.VariationLoadStatus LoadStatus
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0xE27870", Offset = "0xE27870", VA = "0xE27870")]
			get
			{
				return default(MasterAudio.VariationLoadStatus);
			}
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0xE25290", Offset = "0xE25290", VA = "0xE25290")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public int InstanceId
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0xE25A44", Offset = "0xE25A44", VA = "0xE25A44")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009D")]
		public bool IsStopRequested
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0xE27878", Offset = "0xE27878", VA = "0xE27878")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009E")]
		public Transform Trans
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0xE2674C", Offset = "0xE2674C", VA = "0xE2674C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xE24080", Offset = "0xE24080", VA = "0xE24080")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0xE23FCC", Offset = "0xE23FCC", VA = "0xE23FCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		public bool AudioLoops
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xE25988", Offset = "0xE25988", VA = "0xE25988")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A2")]
		public string ResFileName
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xE257A8", Offset = "0xE257A8", VA = "0xE257A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		public SoundGroupVariationUpdater VariationUpdater
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0xE24830", Offset = "0xE24830", VA = "0xE24830")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		public PlaySoundParams PlaySoundParm
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0xE27880", Offset = "0xE27880", VA = "0xE27880")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public float SetGroupVolume
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0xE27888", Offset = "0xE27888", VA = "0xE27888")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600040A")]
			[Address(RVA = "0xE278A4", Offset = "0xE278A4", VA = "0xE278A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public int MaxLoops
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0xE278C0", Offset = "0xE278C0", VA = "0xE278C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A7")]
		private bool Is2D
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0xE278C8", Offset = "0xE278C8", VA = "0xE278C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A8")]
		public bool UsesOcclusion
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0xE248E4", Offset = "0xE248E4", VA = "0xE248E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A9")]
		public bool IsPaused
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0xE278F4", Offset = "0xE278F4", VA = "0xE278F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000002")]
		public event SoundFinishedEventHandler SoundFinished
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0xE23B50", Offset = "0xE23B50", VA = "0xE23B50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5232E0", Offset = "0x5232E0")]
			add
			{
			}
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xE23BF4", Offset = "0xE23BF4", VA = "0xE23BF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5232F0", Offset = "0x5232F0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event SoundLoopedEventHandler SoundLooped
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0xE23C98", Offset = "0xE23C98", VA = "0xE23C98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523300", Offset = "0x523300")]
			add
			{
			}
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0xE23D3C", Offset = "0xE23D3C", VA = "0xE23D3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523310", Offset = "0x523310")]
			remove
			{
			}
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xE23DE0", Offset = "0xE23DE0", VA = "0xE23DE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xE24120", Offset = "0xE24120", VA = "0xE24120")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xE244C0", Offset = "0xE244C0", VA = "0xE244C0")]
		public void SetMixerGroup()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xE24514", Offset = "0xE24514", VA = "0xE24514")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xE246BC", Offset = "0xE246BC", VA = "0xE246BC")]
		private void SetOcclusion()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xE24610", Offset = "0xE24610", VA = "0xE24610")]
		private void SetPriority()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xE24A70", Offset = "0xE24A70", VA = "0xE24A70")]
		public void DisableUpdater()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xE24B14", Offset = "0xE24B14", VA = "0xE24B14")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xE24BE0", Offset = "0xE24BE0", VA = "0xE24BE0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xE24B18", Offset = "0xE24B18", VA = "0xE24B18")]
		private void StopSoundEarly()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xE24F40", Offset = "0xE24F40", VA = "0xE24F40")]
		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xE252FC", Offset = "0xE252FC", VA = "0xE252FC")]
		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xE252A4", Offset = "0xE252A4", VA = "0xE252A4")]
		private void MaybeCleanupFinishedDelegate()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xE25888", Offset = "0xE25888", VA = "0xE25888")]
		private void ResourceFailedToLoad()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xE25470", Offset = "0xE25470", VA = "0xE25470")]
		private void FinishSetupToPlay()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xE25A78", Offset = "0xE25A78", VA = "0xE25A78")]
		public void JumpToTime(float timeToJumpTo)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xE25AC4", Offset = "0xE25AC4", VA = "0xE25AC4")]
		public void GlideByPitch(float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xE25D10", Offset = "0xE25D10", VA = "0xE25D10")]
		public void AdjustVolume(float volumePercentage)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xE25E9C", Offset = "0xE25E9C", VA = "0xE25E9C")]
		public void Pause()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xE25FA8", Offset = "0xE25FA8", VA = "0xE25FA8")]
		public void Unpause()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xE260AC", Offset = "0xE260AC", VA = "0xE260AC")]
		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xE26164", Offset = "0xE26164", VA = "0xE26164")]
		public void PlayEndLinkedGroups([Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xE258A8", Offset = "0xE258A8", VA = "0xE258A8")]
		private void EnableUpdater(bool waitForSoundFinish = true)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xE26660", Offset = "0xE26660", VA = "0xE26660")]
		private void MaybeUnloadClip()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xE26400", Offset = "0xE26400", VA = "0xE26400")]
		private void PlayEndLinkedGroup(string sType, [Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xE24BE4", Offset = "0xE24BE4", VA = "0xE24BE4")]
		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xE267EC", Offset = "0xE267EC", VA = "0xE267EC")]
		private void StopEndCleanup()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xE26830", Offset = "0xE26830", VA = "0xE26830")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x523320", Offset = "0x523320")]
		private IEnumerator WaitForLoadToUnloadClipAndDeactivate()
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xE268A8", Offset = "0xE268A8", VA = "0xE268A8")]
		public void FadeToVolume(float newVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xE26B44", Offset = "0xE26B44", VA = "0xE26B44")]
		public void FadeOutNow()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xE26C80", Offset = "0xE26C80", VA = "0xE26C80")]
		public void FadeOutNow(float fadeTime)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xE26DC4", Offset = "0xE26DC4", VA = "0xE26DC4")]
		public bool WasTriggeredFromTransform(Transform trans)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xE26E80", Offset = "0xE26E80", VA = "0xE26E80")]
		public bool WasTriggeredFromAnyOfTransformMap(HashSet<Transform> transMap)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xE27358", Offset = "0xE27358", VA = "0xE27358")]
		public void UpdateTransformTracker(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xE278FC", Offset = "0xE278FC", VA = "0xE278FC")]
		public void SoundLoopStarted(int numberOfLoops)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xE25850", Offset = "0xE25850", VA = "0xE25850")]
		public void ClearSubscribers()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xE27910", Offset = "0xE27910", VA = "0xE27910")]
		public SoundGroupVariation()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x52193C", Offset = "0x52193C")]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		[Token(Token = "0x20000DD")]
		private enum WaitForSoundFinishMode
		{
			[Token(Token = "0x4000494")]
			None,
			[Token(Token = "0x4000495")]
			Play,
			[Token(Token = "0x4000496")]
			WaitForEnd,
			[Token(Token = "0x4000497")]
			StopOrRepeat
		}

		[Token(Token = "0x400045F")]
		private const float TimeEarlyToScheduleNextClip = 0.1f;

		[Token(Token = "0x4000460")]
		private const float FakeNegativeFloatValue = -10f;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _objectToFollow;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _objectToFollowGo;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isFollowing;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SoundGroupVariation _variation;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _priorityLastUpdated;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _useClipAgePriority;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSoundFinishMode _waitMode;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource _varAudio;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MasterAudioGroup _parentGrp;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _trans;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _frameNum;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _inited;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _fadeOutStartTime;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fadeInOutWillFadeOut;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool _hasFadeInOutSetMaxVolume;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _fadeInOutInFactor;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _fadeInOutOutFactor;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _fadeOutEarlyTotalFrames;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _fadeOutEarlyFrameVolChange;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _fadeOutEarlyFrameNumber;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _fadeOutEarlyOrigVol;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _fadeToTargetFrameVolChange;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _fadeToTargetFrameNumber;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _fadeToTargetOrigVol;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _fadeToTargetTotalFrames;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _fadeToTargetVolume;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool _fadeOutStarted;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastFrameClipTime;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isPlayingBackward;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _pitchGlideToTargetTotalFrames;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _pitchGlideToTargetFramePitchChange;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int _pitchGlideToTargetFrameNumber;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _glideToTargetPitch;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _glideToTargetOrigPitch;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Action _glideToPitchCompletionCallback;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool _hasStartedNextInChain;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		private bool _isWaitingForQueuedOcclusionRay;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _framesPlayed;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float? _clipStartPosition;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float? _clipEndPosition;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private double? _clipSchedEndTime;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool _hasScheduledNextClip;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool _hasScheduledEndLinkedGroups;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _lastFrameClipPosition;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _timesLooped;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool _isPaused;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private double _pauseTime;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _maCachedFromFrame;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MasterAudio _maThisFrame;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _listenerThisFrame;

		[Token(Token = "0x170000AC")]
		public float ClipStartPosition
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0xD9D290", Offset = "0xD9D290", VA = "0xD9D290")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000AD")]
		public float ClipEndPosition
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0xD9BBBC", Offset = "0xD9BBBC", VA = "0xD9BBBC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000AE")]
		public int FramesPlayed
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0xD9E3A8", Offset = "0xD9E3A8", VA = "0xD9E3A8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000AF")]
		public MasterAudio MAThisFrame
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0xD9E3B0", Offset = "0xD9E3B0", VA = "0xD9E3B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		public float MaxOcclusionFreq
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0xD9E414", Offset = "0xD9E414", VA = "0xD9E414")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B1")]
		public float MinOcclusionFreq
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0xD9E4CC", Offset = "0xD9E4CC", VA = "0xD9E4CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B2")]
		private Transform Trans
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0xD9C8E8", Offset = "0xD9C8E8", VA = "0xD9C8E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		private AudioSource VarAudio
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0xD9B988", Offset = "0xD9B988", VA = "0xD9B988")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0xD9C994", Offset = "0xD9C994", VA = "0xD9C994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		private SoundGroupVariation GrpVariation
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0xD9B8D4", Offset = "0xD9B8D4", VA = "0xD9B8D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		private float RayCastOriginOffset
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0xD9D1D8", Offset = "0xD9D1D8", VA = "0xD9D1D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B7")]
		private bool IsOcclusionMeasuringPaused
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0xD9CC54", Offset = "0xD9CC54", VA = "0xD9CC54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B8")]
		private bool HasEndLinkedGroups
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0xD9E33C", Offset = "0xD9E33C", VA = "0xD9E33C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xD9B80C", Offset = "0xD9B80C", VA = "0xD9B80C")]
		public void GlidePitch(float targetPitch, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xD9BA34", Offset = "0xD9BA34", VA = "0xD9BA34")]
		public void FadeOverTimeToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xD9BD00", Offset = "0xD9BD00", VA = "0xD9BD00")]
		public void FadeOutEarly(float fadeTime)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xD9BE98", Offset = "0xD9BE98", VA = "0xD9BE98")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xD9BED0", Offset = "0xD9BED0", VA = "0xD9BED0")]
		public void FadeInOut()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xD9BFFC", Offset = "0xD9BFFC", VA = "0xD9BFFC")]
		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xD9C390", Offset = "0xD9C390", VA = "0xD9C390")]
		public void WaitForSoundFinish()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xD9C770", Offset = "0xD9C770", VA = "0xD9C770")]
		public void StopPitchGliding()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xD9C840", Offset = "0xD9C840", VA = "0xD9C840")]
		public void StopFading()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xD9C870", Offset = "0xD9C870", VA = "0xD9C870")]
		public void StopWaitingForFinish()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xD9C8A4", Offset = "0xD9C8A4", VA = "0xD9C8A4")]
		public void StopFollowing()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xD9C7C4", Offset = "0xD9C7C4", VA = "0xD9C7C4")]
		private void DisableIfFinished()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xD9C200", Offset = "0xD9C200", VA = "0xD9C200")]
		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xD9CA40", Offset = "0xD9CA40", VA = "0xD9CA40")]
		private void ResetToNonOcclusionSetting()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xD9CAE8", Offset = "0xD9CAE8", VA = "0xD9CAE8")]
		private void UpdateOcclusion()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xD9CCE0", Offset = "0xD9CCE0", VA = "0xD9CCE0")]
		private void DoneWithOcclusion()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xD9CD58", Offset = "0xD9CD58", VA = "0xD9CD58")]
		public bool RayCastForOcclusion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xD9C410", Offset = "0xD9C410", VA = "0xD9C410")]
		private void PlaySoundAndWait()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xD9D3E0", Offset = "0xD9D3E0", VA = "0xD9D3E0")]
		private void DuckIfNotSilent()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xD9D564", Offset = "0xD9D564", VA = "0xD9D564")]
		private void StopOrChain()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xD9D924", Offset = "0xD9D924", VA = "0xD9D924")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xD9D954", Offset = "0xD9D954", VA = "0xD9D954")]
		public void Unpause()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xD9D604", Offset = "0xD9D604", VA = "0xD9D604")]
		public void MaybeChain()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xD9DA50", Offset = "0xD9DA50", VA = "0xD9DA50")]
		private void UpdatePitch()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xD9DB14", Offset = "0xD9DB14", VA = "0xD9DB14")]
		private void PerformFading()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xD9DDD8", Offset = "0xD9DDD8", VA = "0xD9DDD8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xD9DE60", Offset = "0xD9DE60", VA = "0xD9DE60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xD9C0DC", Offset = "0xD9C0DC", VA = "0xD9C0DC")]
		public void UpdateCachedObjects()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xD9DF48", Offset = "0xD9DF48", VA = "0xD9DF48")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xD9E584", Offset = "0xD9E584", VA = "0xD9E584")]
		public SoundGroupVariationUpdater()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public static class AudioLoaderOptimizer
	{
		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<GameObject>> PlayingGameObjectsByClipName;

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x982680", Offset = "0x982680", VA = "0x982680")]
		public static void AddNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x9828D0", Offset = "0x9828D0", VA = "0x9828D0")]
		public static void RemoveNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x982AA0", Offset = "0x982AA0", VA = "0x982AA0")]
		public static bool IsAnyOfNonPreloadedClipPlaying(AudioClip clip)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000DF")]
	public static class AudioPrioritizer
	{
		[Token(Token = "0x4000499")]
		private const int MaxPriority = 0;

		[Token(Token = "0x400049A")]
		private const int HighestPriority = 16;

		[Token(Token = "0x400049B")]
		private const int LowestPriority = 128;

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x982C90", Offset = "0x982C90", VA = "0x982C90")]
		public static void Set2DSoundPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x982CAC", Offset = "0x982CAC", VA = "0x982CAC")]
		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x982CC8", Offset = "0x982CC8", VA = "0x982CC8")]
		public static void SetPreviewPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x982CE4", Offset = "0x982CE4", VA = "0x982CE4")]
		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public static class AudioResourceOptimizer
	{
		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521950", Offset = "0x521950")]
		private sealed class <PopulateResourceSongToPlaylistControllerAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string songResourceName;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string playlistName;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PlaylistController controller;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MusicSetting songSetting;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public PlaylistController.AudioPlayType playType;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000465")]
				[Address(RVA = "0xDA77F0", Offset = "0xDA77F0", VA = "0xDA77F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000467")]
				[Address(RVA = "0xDA7838", Offset = "0xDA7838", VA = "0xDA7838", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0xDA71E4", Offset = "0xDA71E4", VA = "0xDA71E4")]
			[DebuggerHidden]
			public <PopulateResourceSongToPlaylistControllerAsync>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0xDA7210", Offset = "0xDA7210", VA = "0xDA7210", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0xDA7214", Offset = "0xDA7214", VA = "0xDA7214", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0xDA77F8", Offset = "0xDA77F8", VA = "0xDA77F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521960", Offset = "0x521960")]
		private sealed class <PopulateSourcesWithResourceClipAsync>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action failureAction;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public SoundGroupVariation variation;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x170000BB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600046B")]
				[Address(RVA = "0xDA7EF8", Offset = "0xDA7EF8", VA = "0xDA7EF8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600046D")]
				[Address(RVA = "0xDA7F40", Offset = "0xDA7F40", VA = "0xDA7F40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0xDA7840", Offset = "0xDA7840", VA = "0xDA7840")]
			[DebuggerHidden]
			public <PopulateSourcesWithResourceClipAsync>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0xDA786C", Offset = "0xDA786C", VA = "0xDA786C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0xDA7870", Offset = "0xDA7870", VA = "0xDA7870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0xDA7F00", Offset = "0xDA7F00", VA = "0xDA7F00", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, AudioClip> AudioClipsByName;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string _supportedLanguageFolder;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x9830C0", Offset = "0x9830C0", VA = "0x9830C0")]
		public static void ClearAudioClips()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x983170", Offset = "0x983170", VA = "0x983170")]
		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x9832F0", Offset = "0x9832F0", VA = "0x9832F0")]
		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x983694", Offset = "0x983694", VA = "0x983694")]
		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x983394", Offset = "0x983394", VA = "0x983394")]
		private static string SupportedLanguageFolder()
		{
			return null;
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x983958", Offset = "0x983958", VA = "0x983958")]
		public static void ClearSupportLanguageFolder()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x9839E0", Offset = "0x9839E0", VA = "0x9839E0")]
		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x983B84", Offset = "0x983B84", VA = "0x983B84")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5233F0", Offset = "0x5233F0")]
		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(MusicSetting songSetting, string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x983C50", Offset = "0x983C50", VA = "0x983C50")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x523450", Offset = "0x523450")]
		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x983D14", Offset = "0x983D14", VA = "0x983D14")]
		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x983EB8", Offset = "0x983EB8", VA = "0x983EB8")]
		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x9840B8", Offset = "0x9840B8", VA = "0x9840B8")]
		public static void UnloadClipIfUnused(string clipName)
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x521970", Offset = "0x521970")]
	public class MasterAudio : MonoBehaviour
	{
		[Token(Token = "0x20000E4")]
		public enum AmbientSoundExitMode
		{
			[Token(Token = "0x4000560")]
			StopSound,
			[Token(Token = "0x4000561")]
			FadeSound
		}

		[Token(Token = "0x20000E5")]
		public enum AmbientSoundReEnterMode
		{
			[Token(Token = "0x4000563")]
			StopExistingSound,
			[Token(Token = "0x4000564")]
			FadeInSameSound
		}

		[Token(Token = "0x20000E6")]
		public enum VariationFollowerType
		{
			[Token(Token = "0x4000566")]
			LateUpdate,
			[Token(Token = "0x4000567")]
			FixedUpdate
		}

		[Token(Token = "0x20000E7")]
		public enum LinkedGroupSelectionType
		{
			[Token(Token = "0x4000569")]
			All,
			[Token(Token = "0x400056A")]
			OneAtRandom
		}

		[Token(Token = "0x20000E8")]
		public enum OcclusionSelectionType
		{
			[Token(Token = "0x400056C")]
			AllGroups,
			[Token(Token = "0x400056D")]
			TurnOnPerBusOrGroup
		}

		[Token(Token = "0x20000E9")]
		public enum RaycastMode
		{
			[Token(Token = "0x400056F")]
			Physics3D,
			[Token(Token = "0x4000570")]
			Physics2D
		}

		[Token(Token = "0x20000EA")]
		public enum AllMusicSpatialBlendType
		{
			[Token(Token = "0x4000572")]
			ForceAllTo2D,
			[Token(Token = "0x4000573")]
			ForceAllTo3D,
			[Token(Token = "0x4000574")]
			ForceAllToCustom,
			[Token(Token = "0x4000575")]
			AllowDifferentPerController
		}

		[Token(Token = "0x20000EB")]
		public enum AllMixerSpatialBlendType
		{
			[Token(Token = "0x4000577")]
			ForceAllTo2D,
			[Token(Token = "0x4000578")]
			ForceAllTo3D,
			[Token(Token = "0x4000579")]
			ForceAllToCustom,
			[Token(Token = "0x400057A")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x20000EC")]
		public enum ItemSpatialBlendType
		{
			[Token(Token = "0x400057C")]
			ForceTo2D,
			[Token(Token = "0x400057D")]
			ForceTo3D,
			[Token(Token = "0x400057E")]
			ForceToCustom,
			[Token(Token = "0x400057F")]
			UseCurveFromAudioSource
		}

		[Token(Token = "0x20000ED")]
		public enum MixerWidthMode
		{
			[Token(Token = "0x4000581")]
			Narrow,
			[Token(Token = "0x4000582")]
			Normal,
			[Token(Token = "0x4000583")]
			Wide
		}

		[Token(Token = "0x20000EE")]
		public enum CustomEventReceiveMode
		{
			[Token(Token = "0x4000585")]
			Always,
			[Token(Token = "0x4000586")]
			WhenDistanceLessThan,
			[Token(Token = "0x4000587")]
			WhenDistanceMoreThan,
			[Token(Token = "0x4000588")]
			Never,
			[Token(Token = "0x4000589")]
			OnSameGameObject,
			[Token(Token = "0x400058A")]
			OnChildGameObject,
			[Token(Token = "0x400058B")]
			OnParentGameObject,
			[Token(Token = "0x400058C")]
			OnSameOrChildGameObject,
			[Token(Token = "0x400058D")]
			OnSameOrParentGameObject
		}

		[Token(Token = "0x20000EF")]
		public enum EventReceiveFilter
		{
			[Token(Token = "0x400058F")]
			All,
			[Token(Token = "0x4000590")]
			Closest,
			[Token(Token = "0x4000591")]
			Random
		}

		[Token(Token = "0x20000F0")]
		public enum VariationLoadStatus
		{
			[Token(Token = "0x4000593")]
			None,
			[Token(Token = "0x4000594")]
			Loading,
			[Token(Token = "0x4000595")]
			Loaded,
			[Token(Token = "0x4000596")]
			LoadFailed
		}

		[Token(Token = "0x20000F1")]
		public enum AudioLocation
		{
			[Token(Token = "0x4000598")]
			Clip,
			[Token(Token = "0x4000599")]
			ResourceFile
		}

		[Token(Token = "0x20000F2")]
		public enum CustomSongStartTimeMode
		{
			[Token(Token = "0x400059B")]
			Beginning,
			[Token(Token = "0x400059C")]
			SpecificTime,
			[Token(Token = "0x400059D")]
			RandomTime
		}

		[Token(Token = "0x20000F3")]
		public enum BusCommand
		{
			[Token(Token = "0x400059F")]
			None,
			[Token(Token = "0x40005A0")]
			FadeToVolume,
			[Token(Token = "0x40005A1")]
			Mute,
			[Token(Token = "0x40005A2")]
			Pause,
			[Token(Token = "0x40005A3")]
			Solo,
			[Token(Token = "0x40005A4")]
			Unmute,
			[Token(Token = "0x40005A5")]
			Unpause,
			[Token(Token = "0x40005A6")]
			Unsolo,
			[Token(Token = "0x40005A7")]
			Stop,
			[Token(Token = "0x40005A8")]
			ChangePitch,
			[Token(Token = "0x40005A9")]
			ToggleMute,
			[Token(Token = "0x40005AA")]
			StopBusOfTransform,
			[Token(Token = "0x40005AB")]
			PauseBusOfTransform,
			[Token(Token = "0x40005AC")]
			UnpauseBusOfTransform,
			[Token(Token = "0x40005AD")]
			GlideByPitch,
			[Token(Token = "0x40005AE")]
			StopOldBusVoices,
			[Token(Token = "0x40005AF")]
			FadeOutOldBusVoices
		}

		[Token(Token = "0x20000F4")]
		public enum DragGroupMode
		{
			[Token(Token = "0x40005B1")]
			OneGroupPerClip,
			[Token(Token = "0x40005B2")]
			OneGroupWithVariations
		}

		[Token(Token = "0x20000F5")]
		public enum EventSoundFunctionType
		{
			[Token(Token = "0x40005B4")]
			PlaySound,
			[Token(Token = "0x40005B5")]
			GroupControl,
			[Token(Token = "0x40005B6")]
			BusControl,
			[Token(Token = "0x40005B7")]
			PlaylistControl,
			[Token(Token = "0x40005B8")]
			CustomEventControl,
			[Token(Token = "0x40005B9")]
			GlobalControl,
			[Token(Token = "0x40005BA")]
			UnityMixerControl,
			[Token(Token = "0x40005BB")]
			PersistentSettingsControl
		}

		[Token(Token = "0x20000F6")]
		public enum LanguageMode
		{
			[Token(Token = "0x40005BD")]
			UseDeviceSetting,
			[Token(Token = "0x40005BE")]
			SpecificLanguage,
			[Token(Token = "0x40005BF")]
			DynamicallySet
		}

		[Token(Token = "0x20000F7")]
		public enum UnityMixerCommand
		{
			[Token(Token = "0x40005C1")]
			None,
			[Token(Token = "0x40005C2")]
			TransitionToSnapshot,
			[Token(Token = "0x40005C3")]
			TransitionToSnapshotBlend
		}

		[Token(Token = "0x20000F8")]
		public enum PlaylistCommand
		{
			[Token(Token = "0x40005C5")]
			None,
			[Token(Token = "0x40005C6")]
			ChangePlaylist,
			[Token(Token = "0x40005C7")]
			FadeToVolume,
			[Token(Token = "0x40005C8")]
			PlaySong,
			[Token(Token = "0x40005C9")]
			PlayRandomSong,
			[Token(Token = "0x40005CA")]
			PlayNextSong,
			[Token(Token = "0x40005CB")]
			Pause,
			[Token(Token = "0x40005CC")]
			Resume,
			[Token(Token = "0x40005CD")]
			Stop,
			[Token(Token = "0x40005CE")]
			Mute,
			[Token(Token = "0x40005CF")]
			Unmute,
			[Token(Token = "0x40005D0")]
			ToggleMute,
			[Token(Token = "0x40005D1")]
			Restart,
			[Token(Token = "0x40005D2")]
			Start,
			[Token(Token = "0x40005D3")]
			StopLoopingCurrentSong,
			[Token(Token = "0x40005D4")]
			StopPlaylistAfterCurrentSong,
			[Token(Token = "0x40005D5")]
			AddSongToQueue
		}

		[Token(Token = "0x20000F9")]
		public enum CustomEventCommand
		{
			[Token(Token = "0x40005D7")]
			None,
			[Token(Token = "0x40005D8")]
			FireEvent
		}

		[Token(Token = "0x20000FA")]
		public enum GlobalCommand
		{
			[Token(Token = "0x40005DA")]
			None,
			[Token(Token = "0x40005DB")]
			PauseMixer,
			[Token(Token = "0x40005DC")]
			UnpauseMixer,
			[Token(Token = "0x40005DD")]
			StopMixer,
			[Token(Token = "0x40005DE")]
			StopEverything,
			[Token(Token = "0x40005DF")]
			PauseEverything,
			[Token(Token = "0x40005E0")]
			UnpauseEverything,
			[Token(Token = "0x40005E1")]
			MuteEverything,
			[Token(Token = "0x40005E2")]
			UnmuteEverything,
			[Token(Token = "0x40005E3")]
			SetMasterMixerVolume,
			[Token(Token = "0x40005E4")]
			SetMasterPlaylistVolume
		}

		[Token(Token = "0x20000FB")]
		public enum SoundGroupCommand
		{
			[Token(Token = "0x40005E6")]
			None,
			[Token(Token = "0x40005E7")]
			FadeToVolume,
			[Token(Token = "0x40005E8")]
			FadeOutAllOfSound,
			[Token(Token = "0x40005E9")]
			Mute,
			[Token(Token = "0x40005EA")]
			Pause,
			[Token(Token = "0x40005EB")]
			Solo,
			[Token(Token = "0x40005EC")]
			StopAllOfSound,
			[Token(Token = "0x40005ED")]
			Unmute,
			[Token(Token = "0x40005EE")]
			Unpause,
			[Token(Token = "0x40005EF")]
			Unsolo,
			[Token(Token = "0x40005F0")]
			StopAllSoundsOfTransform,
			[Token(Token = "0x40005F1")]
			PauseAllSoundsOfTransform,
			[Token(Token = "0x40005F2")]
			UnpauseAllSoundsOfTransform,
			[Token(Token = "0x40005F3")]
			StopSoundGroupOfTransform,
			[Token(Token = "0x40005F4")]
			PauseSoundGroupOfTransform,
			[Token(Token = "0x40005F5")]
			UnpauseSoundGroupOfTransform,
			[Token(Token = "0x40005F6")]
			FadeOutSoundGroupOfTransform,
			[Token(Token = "0x40005F7")]
			RefillSoundGroupPool,
			[Token(Token = "0x40005F8")]
			RouteToBus,
			[Token(Token = "0x40005F9")]
			GlideByPitch,
			[Token(Token = "0x40005FA")]
			ToggleSoundGroup,
			[Token(Token = "0x40005FB")]
			ToggleSoundGroupOfTransform,
			[Token(Token = "0x40005FC")]
			FadeOutAllSoundsOfTransform,
			[Token(Token = "0x40005FD")]
			StopOldSoundGroupVoices,
			[Token(Token = "0x40005FE")]
			FadeOutOldSoundGroupVoices
		}

		[Token(Token = "0x20000FC")]
		public enum PersistentSettingsCommand
		{
			[Token(Token = "0x4000600")]
			None,
			[Token(Token = "0x4000601")]
			SetBusVolume,
			[Token(Token = "0x4000602")]
			SetGroupVolume,
			[Token(Token = "0x4000603")]
			SetMixerVolume,
			[Token(Token = "0x4000604")]
			SetMusicVolume,
			[Token(Token = "0x4000605")]
			MixerMuteToggle,
			[Token(Token = "0x4000606")]
			MusicMuteToggle
		}

		[Token(Token = "0x20000FD")]
		public enum SongFadeInPosition
		{
			[Token(Token = "0x4000608")]
			NewClipFromBeginning = 1,
			[Token(Token = "0x4000609")]
			NewClipFromLastKnownPosition = 3,
			[Token(Token = "0x400060A")]
			SynchronizeClips = 5
		}

		[Token(Token = "0x20000FE")]
		public enum SoundSpawnLocationMode
		{
			[Token(Token = "0x400060C")]
			MasterAudioLocation,
			[Token(Token = "0x400060D")]
			CallerLocation,
			[Token(Token = "0x400060E")]
			AttachToCaller
		}

		[Token(Token = "0x20000FF")]
		public enum VariationCommand
		{
			[Token(Token = "0x4000610")]
			None,
			[Token(Token = "0x4000611")]
			Stop,
			[Token(Token = "0x4000612")]
			Pause,
			[Token(Token = "0x4000613")]
			Unpause
		}

		[Serializable]
		[Token(Token = "0x2000100")]
		public struct CustomEventCandidate
		{
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float DistanceAway;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ICustomEventReceiver Receiver;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Trans;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RandomId;

			[Token(Token = "0x6000598")]
			[Address(RVA = "0xDA9754", Offset = "0xDA9754", VA = "0xDA9754")]
			public CustomEventCandidate(float distance, ICustomEventReceiver rec, Transform trans, int randomId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000101")]
		public class AudioGroupInfo
		{
			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<AudioInfo> Sources;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastFramePlayed;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastTimePlayed;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MasterAudioGroup Group;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool PlayedForWarming;

			[Token(Token = "0x6000599")]
			[Address(RVA = "0xDA967C", Offset = "0xDA967C", VA = "0xDA967C")]
			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000102")]
		public class AudioInfo
		{
			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource Source;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float OriginalVolume;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastPercentageVolume;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float LastRandomVolume;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation Variation;

			[Token(Token = "0x600059A")]
			[Address(RVA = "0xDA96E4", Offset = "0xDA96E4", VA = "0xDA96E4")]
			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000103")]
		public class Playlist
		{
			[Token(Token = "0x2000104")]
			public enum CrossfadeTimeMode
			{
				[Token(Token = "0x4000634")]
				UseMasterSetting,
				[Token(Token = "0x4000635")]
				Override
			}

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isExpanded;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string playlistName;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SongFadeInPosition songTransitionType;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MusicSetting> MusicSettings;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioLocation bulkLocationMode;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CrossfadeTimeMode crossfadeMode;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float crossFadeTime;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool fadeInFirstSong;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool fadeOutLastSong;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			public bool bulkEditMode;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
			public bool isTemporary;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool showMetadata;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<SongMetadataProperty> songMetadataProps;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string newMetadataPropName;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public SongMetadataProperty.MetadataPropertyType newMetadataPropType;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public bool newMetadataPropRequired;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
			public bool newMetadataPropCanHaveMult;

			[Token(Token = "0x600059B")]
			[Address(RVA = "0xDA97A0", Offset = "0xDA97A0", VA = "0xDA97A0")]
			public Playlist()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000105")]
		public class SoundGroupRefillInfo
		{
			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float LastTimePlayed;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float InactivePeriodSeconds;

			[Token(Token = "0x600059C")]
			[Address(RVA = "0xDA98DC", Offset = "0xDA98DC", VA = "0xDA98DC")]
			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521984", Offset = "0x521984")]
		private sealed class <>c
		{
			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<OcclusionFreqChangeInfo> <>9__224_0;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<BusFadeInfo> <>9__225_0;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<GroupFadeInfo> <>9__226_0;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Predicate<AmbientSoundToTriggerInfo> <>9__227_0;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Predicate<GroupPitchGlideInfo> <>9__228_0;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Predicate<BusPitchGlideInfo> <>9__229_0;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Comparison<CustomEventCandidate> <>9__427_0;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Comparison<CustomEventCandidate> <>9__427_1;

			[Token(Token = "0x600059E")]
			[Address(RVA = "0xDA85C0", Offset = "0xDA85C0", VA = "0xDA85C0")]
			public <>c()
			{
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0xDA85C8", Offset = "0xDA85C8", VA = "0xDA85C8")]
			internal bool <PerformOcclusionFrequencyChanges>b__224_0(OcclusionFreqChangeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0xDA85E8", Offset = "0xDA85E8", VA = "0xDA85E8")]
			internal bool <PerformBusFades>b__225_0(BusFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0xDA8608", Offset = "0xDA8608", VA = "0xDA8608")]
			internal bool <PerformGroupFades>b__226_0(GroupFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xDA8628", Offset = "0xDA8628", VA = "0xDA8628")]
			internal bool <PerformDelayedAmbientTriggers>b__227_0(AmbientSoundToTriggerInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0xDA8660", Offset = "0xDA8660", VA = "0xDA8660")]
			internal bool <PerformGroupPitchGlides>b__228_0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0xDA8680", Offset = "0xDA8680", VA = "0xDA8680")]
			internal bool <PerformBusPitchGlides>b__229_0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0xDA86A0", Offset = "0xDA86A0", VA = "0xDA86A0")]
			internal int <FireCustomEvent>b__427_0(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xDA86B0", Offset = "0xDA86B0", VA = "0xDA86B0")]
			internal int <FireCustomEvent>b__427_1(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000107")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521994", Offset = "0x521994")]
		private sealed class <>c__DisplayClass239_0
		{
			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xDA86C4", Offset = "0xDA86C4", VA = "0xDA86C4")]
			public <>c__DisplayClass239_0()
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xDA86CC", Offset = "0xDA86CC", VA = "0xDA86CC")]
			internal void <PlaySoundAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5219A4", Offset = "0x5219A4")]
		private sealed class <PlaySoundAndWaitUntilFinished>d__239 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float volumePercentage;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float? pitch;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delaySoundTime;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string variationName;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass239_0 <>8__1;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action completedAction;

			[Token(Token = "0x170000E1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005AC")]
				[Address(RVA = "0xDA962C", Offset = "0xDA962C", VA = "0xDA962C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005AE")]
				[Address(RVA = "0xDA9674", Offset = "0xDA9674", VA = "0xDA9674", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xDA9304", Offset = "0xDA9304", VA = "0xDA9304")]
			[DebuggerHidden]
			public <PlaySoundAndWaitUntilFinished>d__239(int <>1__state)
			{
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xDA9330", Offset = "0xDA9330", VA = "0xDA9330", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xDA9334", Offset = "0xDA9334", VA = "0xDA9334", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xDA9634", Offset = "0xDA9634", VA = "0xDA9634", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5219B4", Offset = "0x5219B4")]
		private sealed class <>c__DisplayClass240_0
		{
			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xDA86D8", Offset = "0xDA86D8", VA = "0xDA86D8")]
			public <>c__DisplayClass240_0()
			{
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0xDA86E0", Offset = "0xDA86E0", VA = "0xDA86E0")]
			internal void <PlaySound3DAtTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5219C4", Offset = "0x5219C4")]
		private sealed class <PlaySound3DAtTransformAndWaitUntilFinished>d__240 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass240_0 <>8__1;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x170000E3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005B4")]
				[Address(RVA = "0xDA8F20", Offset = "0xDA8F20", VA = "0xDA8F20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005B6")]
				[Address(RVA = "0xDA8F68", Offset = "0xDA8F68", VA = "0xDA8F68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xDA8BC8", Offset = "0xDA8BC8", VA = "0xDA8BC8")]
			[DebuggerHidden]
			public <PlaySound3DAtTransformAndWaitUntilFinished>d__240(int <>1__state)
			{
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0xDA8BF4", Offset = "0xDA8BF4", VA = "0xDA8BF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xDA8BF8", Offset = "0xDA8BF8", VA = "0xDA8BF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xDA8F28", Offset = "0xDA8F28", VA = "0xDA8F28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5219D4", Offset = "0x5219D4")]
		private sealed class <>c__DisplayClass241_0
		{
			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xDA86EC", Offset = "0xDA86EC", VA = "0xDA86EC")]
			public <>c__DisplayClass241_0()
			{
			}

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xDA86F4", Offset = "0xDA86F4", VA = "0xDA86F4")]
			internal void <PlaySound3DFollowTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5219E4", Offset = "0x5219E4")]
		private sealed class <PlaySound3DFollowTransformAndWaitUntilFinished>d__241 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass241_0 <>8__1;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x170000E5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0xDA92B4", Offset = "0xDA92B4", VA = "0xDA92B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005BE")]
				[Address(RVA = "0xDA92FC", Offset = "0xDA92FC", VA = "0xDA92FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xDA8F70", Offset = "0xDA8F70", VA = "0xDA8F70")]
			[DebuggerHidden]
			public <PlaySound3DFollowTransformAndWaitUntilFinished>d__241(int <>1__state)
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xDA8F9C", Offset = "0xDA8F9C", VA = "0xDA8F9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xDA8FA0", Offset = "0xDA8FA0", VA = "0xDA8FA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xDA92BC", Offset = "0xDA92BC", VA = "0xDA92BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5219F4", Offset = "0x5219F4")]
		private sealed class <>c__DisplayClass274_0
		{
			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xDA8700", Offset = "0xDA8700", VA = "0xDA8700")]
			public <>c__DisplayClass274_0()
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xDA8708", Offset = "0xDA8708", VA = "0xDA8708")]
			internal bool <RouteGroupToBus>b__1(GroupBus x)
			{
				return default(bool);
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xDA872C", Offset = "0xDA872C", VA = "0xDA872C")]
			internal bool <RouteGroupToBus>b__0(GroupBus x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521A04", Offset = "0x521A04")]
		private sealed class <>c__DisplayClass282_0
		{
			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xDA8750", Offset = "0xDA8750", VA = "0xDA8750")]
			public <>c__DisplayClass282_0()
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xDA8758", Offset = "0xDA8758", VA = "0xDA8758")]
			internal bool <FadeSoundGroupToVolume>b__0(GroupFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521A14", Offset = "0x521A14")]
		private sealed class <>c__DisplayClass285_0
		{
			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xDA877C", Offset = "0xDA877C", VA = "0xDA877C")]
			public <>c__DisplayClass285_0()
			{
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xDA8784", Offset = "0xDA8784", VA = "0xDA8784")]
			internal bool <GlideSoundGroupByPitch>b__0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521A24", Offset = "0x521A24")]
		private sealed class <>c__DisplayClass337_0
		{
			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xDA87A8", Offset = "0xDA87A8", VA = "0xDA87A8")]
			public <>c__DisplayClass337_0()
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xDA87B0", Offset = "0xDA87B0", VA = "0xDA87B0")]
			internal bool <CreateBus>b__0(GroupBus obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521A34", Offset = "0x521A34")]
		private sealed class <>c__DisplayClass341_0
		{
			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xDA87D4", Offset = "0xDA87D4", VA = "0xDA87D4")]
			public <>c__DisplayClass341_0()
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xDA87DC", Offset = "0xDA87DC", VA = "0xDA87DC")]
			internal bool <FadeBusToVolume>b__0(BusFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521A44", Offset = "0x521A44")]
		private sealed class <>c__DisplayClass344_0
		{
			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0xDA8800", Offset = "0xDA8800", VA = "0xDA8800")]
			public <>c__DisplayClass344_0()
			{
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xDA8808", Offset = "0xDA8808", VA = "0xDA8808")]
			internal bool <GlideBusByPitch>b__0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000113")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521A54", Offset = "0x521A54")]
		private sealed class <>c__DisplayClass423_0
		{
			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string categoryName;

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0xDA882C", Offset = "0xDA882C", VA = "0xDA882C")]
			public <>c__DisplayClass423_0()
			{
			}

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xDA8834", Offset = "0xDA8834", VA = "0xDA8834")]
			internal bool <CreateCustomEventCategoryIfNotThere>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521A64", Offset = "0x521A64")]
		private sealed class <>c__DisplayClass424_0
		{
			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xDA8858", Offset = "0xDA8858", VA = "0xDA8858")]
			public <>c__DisplayClass424_0()
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xDA8860", Offset = "0xDA8860", VA = "0xDA8860")]
			internal bool <CreateCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521A74", Offset = "0x521A74")]
		private sealed class <>c__DisplayClass425_0
		{
			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xDA8884", Offset = "0xDA8884", VA = "0xDA8884")]
			public <>c__DisplayClass425_0()
			{
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xDA888C", Offset = "0xDA888C", VA = "0xDA888C")]
			internal bool <DeleteCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521A84", Offset = "0x521A84")]
		private sealed class <>c__DisplayClass426_0
		{
			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0xDA88B0", Offset = "0xDA88B0", VA = "0xDA88B0")]
			public <>c__DisplayClass426_0()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0xDA88B8", Offset = "0xDA88B8", VA = "0xDA88B8")]
			internal bool <GetCustomEventByName>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521A94", Offset = "0x521A94")]
		private sealed class <>c__DisplayClass428_0
		{
			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xDA88DC", Offset = "0xDA88DC", VA = "0xDA88DC")]
			public <>c__DisplayClass428_0()
			{
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xDA88E4", Offset = "0xDA88E4", VA = "0xDA88E4")]
			internal bool <CustomEventExists>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521AA4", Offset = "0x521AA4")]
		private sealed class <>c__DisplayClass429_0
		{
			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0xDA8908", Offset = "0xDA8908", VA = "0xDA8908")]
			public <>c__DisplayClass429_0()
			{
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xDA8910", Offset = "0xDA8910", VA = "0xDA8910")]
			internal bool <GetChildReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521AB4", Offset = "0x521AB4")]
		private sealed class <>c__DisplayClass430_0
		{
			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0xDA89DC", Offset = "0xDA89DC", VA = "0xDA89DC")]
			public <>c__DisplayClass430_0()
			{
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xDA89E4", Offset = "0xDA89E4", VA = "0xDA89E4")]
			internal bool <GetParentReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200011A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521AC4", Offset = "0x521AC4")]
		private sealed class <>c__DisplayClass445_0
		{
			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AmbientSound ambient;

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0xDA8AB0", Offset = "0xDA8AB0", VA = "0xDA8AB0")]
			public <>c__DisplayClass445_0()
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0xDA8AB8", Offset = "0xDA8AB8", VA = "0xDA8AB8")]
			internal bool <SetupAmbientNextFrame>b__0(AmbientSoundToTriggerInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200011B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521AD4", Offset = "0x521AD4")]
		private sealed class <>c__DisplayClass446_0
		{
			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AmbientSound ambient;

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0xDA8B3C", Offset = "0xDA8B3C", VA = "0xDA8B3C")]
			public <>c__DisplayClass446_0()
			{
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0xDA8B44", Offset = "0xDA8B44", VA = "0xDA8B44")]
			internal bool <RemoveDelayedAmbient>b__0(AmbientSoundToTriggerInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40004AF")]
		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		[Token(Token = "0x40004B0")]
		public const string PreviewText = "Random delay, custom fading & start/end position settings are ignored by preview in edit mode.";

		[Token(Token = "0x40004B1")]
		public const string LoopDisabledLoopedChain = "Loop Clip is always OFF for Looped Chain Groups";

		[Token(Token = "0x40004B2")]
		public const string LoopDisabledCustomEnd = "Loop Clip is always OFF when using Custom End Position";

		[Token(Token = "0x40004B3")]
		public const string DragAudioTip = "Drag Audio clips or a folder containing some here";

		[Token(Token = "0x40004B4")]
		public const string NoCategory = "[Uncategorized]";

		[Token(Token = "0x40004B5")]
		public const float SemiTonePitchFactor = 1.05946f;

		[Token(Token = "0x40004B6")]
		public const float SpatialBlend_2DValue = 0f;

		[Token(Token = "0x40004B7")]
		public const float SpatialBlend_3DValue = 1f;

		[Token(Token = "0x40004B8")]
		public const float MaxCrossFadeTimeSeconds = 120f;

		[Token(Token = "0x40004B9")]
		public const float DefaultDuckVolCut = -6f;

		[Token(Token = "0x40004BA")]
		public const int ERROR_MA_LAYER_COLLISIONS_DISABLED = 1;

		[Token(Token = "0x40004BB")]
		public const int PHYSICS_DISABLED = 2;

		[Token(Token = "0x40004BC")]
		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly YieldInstruction EndOfFrameDelay;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly List<string> ExemptChildNames;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly HashSet<int> ErrorNumbersLogged;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action NumberOfAudioSourcesChanged;

		[Token(Token = "0x40004C1")]
		public const int HardCodedBusOptions = 2;

		[Token(Token = "0x40004C2")]
		public const string AllBusesName = "[All]";

		[Token(Token = "0x40004C3")]
		public const string NoGroupName = "[None]";

		[Token(Token = "0x40004C4")]
		public const string DynamicGroupName = "[Type In]";

		[Token(Token = "0x40004C5")]
		public const string NoPlaylistName = "[No Playlist]";

		[Token(Token = "0x40004C6")]
		public const string NoVoiceLimitName = "[NO LMT]";

		[Token(Token = "0x40004C7")]
		public const string OnlyPlaylistControllerName = "~only~";

		[Token(Token = "0x40004C8")]
		public const float InnerLoopCheckInterval = 0.1f;

		[Token(Token = "0x40004C9")]
		private const int MaxComponents = 20;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioLocation bulkLocationMode;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupTemplateName;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string audioSourceTemplateName;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showGroupCreation;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useGroupTemplates;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DragGroupMode curDragGroupMode;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> groupTemplates;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mixerMuted;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool playlistsMuted;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LanguageMode langMode;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SystemLanguage testLanguage;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SystemLanguage defaultLanguage;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SystemLanguage> supportedLanguages;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string busFilter;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useTextGroupFilter;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string textGroupFilter;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool resourceClipsPauseDoNotUnload;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform playlistControllerPrefab;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool persistBetweenScenes;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool shouldLogDestroys;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool showBusColors;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		public bool areGroupsExpanded;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform soundGroupTemplate;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform soundGroupVariationTemplate;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool groupByBus;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool sortAlpha;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool showRangeSoundGizmos;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
		public bool showSelectedRangeSoundGizmos;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Color rangeGizmoColor;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Color selectedRangeGizmoColor;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool showAdvancedSettings;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		public bool showLocalization;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		public bool playListExpanded;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCF")]
		public bool playlistsExpanded;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AllMusicSpatialBlendType musicSpatialBlendType;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float musicSpatialBlend;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AllMixerSpatialBlendType mixerSpatialBlendType;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float mixerSpatialBlend;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public ItemSpatialBlendType newGroupSpatialType;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float newGroupSpatialBlend;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public List<Playlist> musicPlaylists;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float _masterAudioVolume;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool vrSettingsExpanded;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		public bool useSpatializer;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF6")]
		public bool useSpatializerPostFX;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF7")]
		public bool addOculusAudioSources;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool addResonanceAudioSources;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		public bool ignoreTimeScale;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		public bool useGaplessPlaylists;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		public bool saveRuntimeChanges;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public bool prioritizeOnDistance;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public int rePrioritizeEverySecIndex;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public bool useOcclusion;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float occlusionFreqChangeSeconds;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public OcclusionSelectionType occlusionSelectType;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int occlusionMaxRayCastsPerFrame;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public bool occlusionUseLayerMask;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public LayerMask occlusionLayerMask;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public bool occlusionShowRaycasts;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		public bool occlusionShowCategories;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public RaycastMode occlusionRaycastMode;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public bool occlusionIncludeStartRaycast2DCollider;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		public bool occlusionRaycastsHitTriggers;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
		public bool ambientAdvancedExpanded;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public int ambientMaxRecalcsPerFrame;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool visualAdvancedExpanded;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
		public bool logAdvancedExpanded;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
		public bool listenerAdvancedExpanded;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13B")]
		public bool listenerFollowerHasRigidBody;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public VariationFollowerType variationFollowerType;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool showFadingSettings;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		public bool stopZeroVolumeGroups;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x142")]
		public bool stopZeroVolumeBuses;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x143")]
		public bool stopZeroVolumePlaylists;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public float stopOldestBusFadeTime;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool resourceAdvancedExpanded;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		public bool useClipAgePriority;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		public bool logOutOfVoices;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14B")]
		public bool LogSounds;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public bool logCustomEvents;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14D")]
		public bool disableLogging;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14E")]
		public bool showMusicDucking;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14F")]
		public bool enableMusicDucking;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public float defaultRiseVolStart;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public float defaultUnduckTime;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public float defaultDuckedVolumeCut;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public float crossFadeTime;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public float _masterPlaylistVolume;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public bool showGroupSelect;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
		public bool hideGroupsWithNoActiveVars;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16E")]
		public bool logPerfExpanded;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16F")]
		public bool willWarm;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public string newEventName;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public bool showCustomEvents;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public Dictionary<string, DuckGroupInfo> duckingBySoundType;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public int frames;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly PlaySoundResult AndForgetSuccessResult;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly PlaySoundResult failedResultDuringInit;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Dictionary<string, List<int>> _randomizer;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Dictionary<string, List<int>> _randomizerOrigin;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Dictionary<string, List<int>> _randomizerLeftovers;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly List<SoundGroupVariationUpdater> ActiveVariationUpdaters;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly List<SoundGroupVariationUpdater> ActiveUpdatersToRemove;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly List<CustomEventCandidate> ValidReceivers;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly List<MasterAudioGroup> SoloedGroups;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly List<AmbientSoundToTriggerInfo> AmbientsToDelayedTrigger;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly Queue<CustomEventToFireInfo> CustomEventsToFire;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly Queue<TransformFollower> TransFollowerColliderPositionRecalcs;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly List<TransformFollower> ProcessedColliderPositionRecalcs;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly List<BusFadeInfo> BusFades;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<GroupFadeInfo> GroupFades;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly List<GroupPitchGlideInfo> GroupPitchGlides;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly List<BusPitchGlideInfo> BusPitchGlides;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<OcclusionFreqChangeInfo> VariationOcclusionFreqChanges;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly List<AudioSource> AllAudioSources;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly Dictionary<string, PlaylistController> PlaylistControllersByName;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly List<GameObject> OcclusionSourcesInRange;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private readonly List<GameObject> OcclusionSourcesOutOfRange;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private readonly List<GameObject> OcclusionSourcesBlocked;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private readonly Queue<SoundGroupVariationUpdater> QueuedOcclusionRays;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private readonly List<SoundGroupVariation> VariationsStartedDuringMultiStop;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private bool _isStoppingMultiple;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private float _repriTime;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private List<string> _groupsToRemove;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private bool _mustRescanGroups;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private Transform _trans;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private bool _soundsLoaded;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A9")]
		private bool _warming;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static MasterAudio _instance;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static string _prospectiveMAFolder;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Transform _listenerTrans;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522AD8", Offset = "0x522AD8")]
		private static bool <AppIsShuttingDown>k__BackingField;

		[Token(Token = "0x170000BD")]
		public static float PlaylistMasterVolume
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x712EE4", Offset = "0x712EE4", VA = "0x712EE4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x712F4C", Offset = "0x712F4C", VA = "0x712F4C")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public static bool LogSoundsEnabled
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x7146E8", Offset = "0x7146E8", VA = "0x7146E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x714750", Offset = "0x714750", VA = "0x714750")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public static bool LogOutOfVoices
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x6FF75C", Offset = "0x6FF75C", VA = "0x6FF75C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x7147C0", Offset = "0x7147C0", VA = "0x7147C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public static List<AudioSource> MasterAudioSources
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x715E4C", Offset = "0x715E4C", VA = "0x715E4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public static Transform ListenerTrans
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x6F8F64", Offset = "0x6F8F64", VA = "0x6F8F64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		public static PlaylistController OnlyPlaylistController
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x715FAC", Offset = "0x715FAC", VA = "0x715FAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		public static bool IsWarming
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x6FF644", Offset = "0x6FF644", VA = "0x6FF644")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C4")]
		public static bool MixerMuted
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x716064", Offset = "0x716064", VA = "0x716064")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x70BBE0", Offset = "0x70BBE0", VA = "0x70BBE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public static bool PlaylistsMuted
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x7160CC", Offset = "0x7160CC", VA = "0x7160CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x70FB2C", Offset = "0x70FB2C", VA = "0x70FB2C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public bool EnableMusicDucking
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x716134", Offset = "0x716134", VA = "0x716134")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x71613C", Offset = "0x71613C", VA = "0x71613C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public float MasterCrossFadeTime
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x716148", Offset = "0x716148", VA = "0x716148")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C8")]
		public static List<Playlist> MusicPlaylists
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x70F564", Offset = "0x70F564", VA = "0x70F564")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		public static List<GroupBus> GroupBuses
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x705EF8", Offset = "0x705EF8", VA = "0x705EF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		public static List<string> RuntimeSoundGroupNames
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x716150", Offset = "0x716150", VA = "0x716150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		public static List<string> RuntimeBusNames
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x716264", Offset = "0x716264", VA = "0x716264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		public static MasterAudio SafeInstance
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x6F6128", Offset = "0x6F6128", VA = "0x6F6128")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		public static MasterAudio Instance
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x6F3D8C", Offset = "0x6F3D8C", VA = "0x6F3D8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x7163D8", Offset = "0x7163D8", VA = "0x7163D8")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public static bool SoundsReady
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x6FCDF0", Offset = "0x6FCDF0", VA = "0x6FCDF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		public static bool AppIsShuttingDown
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x716440", Offset = "0x716440", VA = "0x716440")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523684", Offset = "0x523684")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x7164A4", Offset = "0x7164A4", VA = "0x7164A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523694", Offset = "0x523694")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public List<string> GroupNames
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x716510", Offset = "0x716510", VA = "0x716510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		public static List<string> SoundGroupHardCodedNames
		{
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x7168D0", Offset = "0x7168D0", VA = "0x7168D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D2")]
		public List<string> BusNames
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x7169A0", Offset = "0x7169A0", VA = "0x7169A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x716AF0", Offset = "0x716AF0", VA = "0x716AF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		public List<string> PlaylistNamesOnly
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x716C40", Offset = "0x716C40", VA = "0x716C40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		public Transform Trans
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x6F9178", Offset = "0x6F9178", VA = "0x6F9178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x716D58", Offset = "0x716D58", VA = "0x716D58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D7")]
		public List<string> CustomEventNames
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x716D60", Offset = "0x716D60", VA = "0x716D60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		public List<string> CustomEventNamesOnly
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x716F30", Offset = "0x716F30", VA = "0x716F30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		public static List<string> CustomEventHardCodedNames
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x716E60", Offset = "0x716E60", VA = "0x716E60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DA")]
		public static float MasterVolumeLevel
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x717078", Offset = "0x717078", VA = "0x717078")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x7170E0", Offset = "0x7170E0", VA = "0x7170E0")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		private static bool SceneHasMasterAudio
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x6FCD54", Offset = "0x6FCD54", VA = "0x6FCD54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DC")]
		public static bool IgnoreTimeScale
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x717254", Offset = "0x717254", VA = "0x717254")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DD")]
		public static SystemLanguage DynamicLanguage
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x7172BC", Offset = "0x7172BC", VA = "0x7172BC")]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x71746C", Offset = "0x71746C", VA = "0x71746C")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public static float ReprioritizeTime
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x717548", Offset = "0x717548", VA = "0x717548")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000DF")]
		public static bool ShouldRescanGroups
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x71768C", Offset = "0x71768C", VA = "0x71768C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E0")]
		public static string ProspectiveMAPath
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x717768", Offset = "0x717768", VA = "0x717768")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x7177CC", Offset = "0x7177CC", VA = "0x7177CC")]
			set
			{
			}
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x6F7304", Offset = "0x6F7304", VA = "0x6F7304")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x523550", Offset = "0x523550")]
		private static void Init()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x6F73A0", Offset = "0x6F73A0", VA = "0x6F73A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x6F9800", Offset = "0x6F9800", VA = "0x6F9800")]
		private void Start()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x6F99A8", Offset = "0x6F99A8", VA = "0x6F99A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x6F9C94", Offset = "0x6F9C94", VA = "0x6F9C94")]
		private void Update()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x6FB3B0", Offset = "0x6FB3B0", VA = "0x6FB3B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x6FB458", Offset = "0x6FB458", VA = "0x6FB458")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x6FB3C0", Offset = "0x6FB3C0", VA = "0x6FB3C0")]
		private void ManualUpdate()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x6F94F0", Offset = "0x6F94F0", VA = "0x6F94F0")]
		public string SoundGroupForWarming()
		{
			return null;
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x6FB960", Offset = "0x6FB960", VA = "0x6FB960")]
		public static void RegisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x6FBA44", Offset = "0x6FBA44", VA = "0x6FBA44")]
		public static void UnregisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x6FB7A0", Offset = "0x6FB7A0", VA = "0x6FB7A0")]
		private void UpdateActiveVariations()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x6FBAD0", Offset = "0x6FBAD0", VA = "0x6FBAD0")]
		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x6FB46C", Offset = "0x6FB46C", VA = "0x6FB46C")]
		private static void RecalcClosestColliderPositions()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x6FB2D0", Offset = "0x6FB2D0", VA = "0x6FB2D0")]
		private static void FireCustomEventsWaiting()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x6FAFA0", Offset = "0x6FAFA0", VA = "0x6FAFA0")]
		private static void RefillInactiveGroupPools()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x6F9D28", Offset = "0x6F9D28", VA = "0x6F9D28")]
		private static void PerformOcclusionFrequencyChanges()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x6FA094", Offset = "0x6FA094", VA = "0x6FA094")]
		private void PerformBusFades()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x6FA608", Offset = "0x6FA608", VA = "0x6FA608")]
		private void PerformGroupFades()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x6FABE0", Offset = "0x6FABE0", VA = "0x6FABE0")]
		public static void PerformDelayedAmbientTriggers()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x6FA9CC", Offset = "0x6FA9CC", VA = "0x6FA9CC")]
		private void PerformGroupPitchGlides()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x6FA3F8", Offset = "0x6FA3F8", VA = "0x6FA3F8")]
		private void PerformBusPitchGlides()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x6FCAE8", Offset = "0x6FCAE8", VA = "0x6FCAE8")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x6FCB88", Offset = "0x6FCB88", VA = "0x6FCB88")]
		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x6F14BC", Offset = "0x6F14BC", VA = "0x6F14BC")]
		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x6FE944", Offset = "0x6FE944", VA = "0x6FE944")]
		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x6FEB08", Offset = "0x6FEB08", VA = "0x6FEB08")]
		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return null;
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x6FECF4", Offset = "0x6FECF4", VA = "0x6FECF4")]
		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x6F108C", Offset = "0x6F108C", VA = "0x6F108C")]
		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x6FEECC", Offset = "0x6FEECC", VA = "0x6FEECC")]
		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x6F12A4", Offset = "0x6F12A4", VA = "0x6F12A4")]
		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x6FF0A4", Offset = "0x6FF0A4", VA = "0x6FF0A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x523564", Offset = "0x523564")]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x6FF174", Offset = "0x6FF174", VA = "0x6FF174")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5235C4", Offset = "0x5235C4")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x6FF26C", Offset = "0x6FF26C", VA = "0x6FF26C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x523624", Offset = "0x523624")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x6FE920", Offset = "0x6FE920", VA = "0x6FE920")]
		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x6FCECC", Offset = "0x6FCECC", VA = "0x6FCECC")]
		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, [Optional] float? pitch, [Optional] Transform sourceTrans, [Optional] string variationName, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x6FFD00", Offset = "0x6FFD00", VA = "0x6FFD00")]
		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x6FF720", Offset = "0x6FF720", VA = "0x6FF720")]
		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x6FFAA8", Offset = "0x6FFAA8", VA = "0x6FFAA8")]
		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x6FFFB8", Offset = "0x6FFFB8", VA = "0x6FFFB8")]
		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, ref bool forgetSoundPlayed, [Optional] float? pitch, [Optional] AudioGroupInfo audioGroup, [Optional] Transform sourceTrans, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x7006EC", Offset = "0x7006EC", VA = "0x7006EC")]
		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x7008D4", Offset = "0x7008D4", VA = "0x7008D4")]
		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x700D74", Offset = "0x700D74", VA = "0x700D74")]
		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x70102C", Offset = "0x70102C", VA = "0x70102C")]
		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x70121C", Offset = "0x70121C", VA = "0x70121C")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x701474", Offset = "0x701474", VA = "0x701474")]
		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x701664", Offset = "0x701664", VA = "0x701664")]
		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x7018BC", Offset = "0x7018BC", VA = "0x7018BC")]
		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x701AAC", Offset = "0x701AAC", VA = "0x701AAC")]
		public static void FadeOutAllSoundsOfTransform(Transform sourceTrans, float fadeTime)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x702030", Offset = "0x702030", VA = "0x702030")]
		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x6FC5D4", Offset = "0x6FC5D4", VA = "0x6FC5D4")]
		public static void StopAllOfSound(string sType)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x6FFD34", Offset = "0x6FFD34", VA = "0x6FFD34")]
		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x702364", Offset = "0x702364", VA = "0x702364")]
		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x701CC8", Offset = "0x701CC8", VA = "0x701CC8")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x70265C", Offset = "0x70265C", VA = "0x70265C")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransformList(List<Transform> sourceTransList)
		{
			return null;
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x702A3C", Offset = "0x702A3C", VA = "0x702A3C")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x702C74", Offset = "0x702C74", VA = "0x702C74")]
		public static void DeleteGroupVariation(string sType, string variationName)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x703AFC", Offset = "0x703AFC", VA = "0x703AFC")]
		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x7041C4", Offset = "0x7041C4", VA = "0x7041C4")]
		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x704588", Offset = "0x704588", VA = "0x704588")]
		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x7048D8", Offset = "0x7048D8", VA = "0x7048D8")]
		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x704ACC", Offset = "0x704ACC", VA = "0x704ACC")]
		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x704DA0", Offset = "0x704DA0", VA = "0x704DA0")]
		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x7050B4", Offset = "0x7050B4", VA = "0x7050B4")]
		public static AudioSource GetNextVariationForSoundGroup(string sType)
		{
			return null;
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x70540C", Offset = "0x70540C", VA = "0x70540C")]
		public static bool IsSoundGroupPlaying(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x705548", Offset = "0x705548", VA = "0x705548")]
		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x705758", Offset = "0x705758", VA = "0x705758")]
		public static void RouteGroupToBus(string sType, string busName)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x706408", Offset = "0x706408", VA = "0x706408")]
		public static float GetVariationLength(string sType, string variationName)
		{
			return default(float);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x6FBC70", Offset = "0x6FBC70", VA = "0x6FBC70")]
		public static void RefillSoundGroupPool(string sType)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x706C04", Offset = "0x706C04", VA = "0x706C04")]
		public static bool SoundGroupExists(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x706CAC", Offset = "0x706CAC", VA = "0x706CAC")]
		public static void PauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x706E24", Offset = "0x706E24", VA = "0x706E24")]
		public static void SetGroupSpatialBlend(string sType)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x706F9C", Offset = "0x706F9C", VA = "0x706F9C")]
		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x707134", Offset = "0x707134", VA = "0x707134")]
		public static void UnpauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x7072AC", Offset = "0x7072AC", VA = "0x7072AC")]
		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x7076D4", Offset = "0x7076D4", VA = "0x7076D4")]
		public static void FadeOutOldSoundGroupVoices(string sType, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x7078B0", Offset = "0x7078B0", VA = "0x7078B0")]
		public static void StopOldSoundGroupVoices(string sType, float minimumPlayTime)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x707A70", Offset = "0x707A70", VA = "0x707A70")]
		public static void GlideSoundGroupByPitch(string sType, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x70802C", Offset = "0x70802C", VA = "0x70802C")]
		public static void DeleteSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x7086A4", Offset = "0x7086A4", VA = "0x7086A4")]
		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, string creatorObjectName, bool errorOnExisting = true)
		{
			return null;
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x7098C0", Offset = "0x7098C0", VA = "0x7098C0")]
		public static float GetGroupVolume(string sType)
		{
			return default(float);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x6FC300", Offset = "0x6FC300", VA = "0x6FC300")]
		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x6F96B4", Offset = "0x6F96B4", VA = "0x6F96B4")]
		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x709AA4", Offset = "0x709AA4", VA = "0x709AA4")]
		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x6F922C", Offset = "0x6F922C", VA = "0x6F922C")]
		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x709D3C", Offset = "0x709D3C", VA = "0x709D3C")]
		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x709BB4", Offset = "0x709BB4", VA = "0x709BB4")]
		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x6F9A4C", Offset = "0x6F9A4C", VA = "0x6F9A4C")]
		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x708428", Offset = "0x708428", VA = "0x708428")]
		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x709DE0", Offset = "0x709DE0", VA = "0x709DE0")]
		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x709980", Offset = "0x709980", VA = "0x709980")]
		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x706008", Offset = "0x706008", VA = "0x706008")]
		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x706350", Offset = "0x706350", VA = "0x706350")]
		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x70A17C", Offset = "0x70A17C", VA = "0x70A17C")]
		private static void UnsilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x70A32C", Offset = "0x70A32C", VA = "0x70A32C")]
		private static void UnsilenceGroup(string sType)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x709FC4", Offset = "0x709FC4", VA = "0x709FC4")]
		private static void SilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x70A488", Offset = "0x70A488", VA = "0x70A488")]
		private static void SilenceGroup(string sType)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x70A5E4", Offset = "0x70A5E4", VA = "0x70A5E4")]
		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x700ACC", Offset = "0x700ACC", VA = "0x700ACC")]
		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x70A720", Offset = "0x70A720", VA = "0x70A720")]
		public static int VoicesForGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x70A820", Offset = "0x70A820", VA = "0x70A820")]
		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x70AA38", Offset = "0x70AA38", VA = "0x70AA38")]
		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x70ABB0", Offset = "0x70ABB0", VA = "0x70ABB0")]
		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x70AC94", Offset = "0x70AC94", VA = "0x70AC94")]
		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x70AE18", Offset = "0x70AE18", VA = "0x70AE18")]
		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x70AF10", Offset = "0x70AF10", VA = "0x70AF10")]
		public void SetSpatialBlendForMixer()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x70B070", Offset = "0x70B070", VA = "0x70B070")]
		public static void PauseMixer()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x70B268", Offset = "0x70B268", VA = "0x70B268")]
		public static void UnpauseMixer()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x70B460", Offset = "0x70B460", VA = "0x70B460")]
		public static void StopMixer()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x70B6B8", Offset = "0x70B6B8", VA = "0x70B6B8")]
		public static void UnsubscribeFromAllVariations()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x70B928", Offset = "0x70B928", VA = "0x70B928")]
		public static void StopEverything()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x70B9F0", Offset = "0x70B9F0", VA = "0x70B9F0")]
		public static void PauseEverything()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x70BAB8", Offset = "0x70BAB8", VA = "0x70BAB8")]
		public static void UnpauseEverything()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x70BB80", Offset = "0x70BB80", VA = "0x70BB80")]
		public static void MuteEverything()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x70C038", Offset = "0x70C038", VA = "0x70C038")]
		public static void UnmuteEverything()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x70C104", Offset = "0x70C104", VA = "0x70C104")]
		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x6FC94C", Offset = "0x6FC94C", VA = "0x6FC94C")]
		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return default(int);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x705F60", Offset = "0x705F60", VA = "0x705F60")]
		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x70C3D0", Offset = "0x70C3D0", VA = "0x70C3D0")]
		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x70C584", Offset = "0x70C584", VA = "0x70C584")]
		public static void MuteBus(string busName)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x70CA1C", Offset = "0x70CA1C", VA = "0x70CA1C")]
		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x70CBC4", Offset = "0x70CBC4", VA = "0x70CBC4")]
		public static void ToggleMuteBus(string busName)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x70CCB0", Offset = "0x70CCB0", VA = "0x70CCB0")]
		public static void PauseBus(string busName)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x70CE38", Offset = "0x70CE38", VA = "0x70CE38")]
		public static void SoloBus(string busName)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x70C874", Offset = "0x70C874", VA = "0x70C874")]
		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x70D024", Offset = "0x70D024", VA = "0x70D024")]
		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x6FF7C4", Offset = "0x6FF7C4", VA = "0x6FF7C4")]
		private static void StopOldestSoundOnBus(GroupBus bus)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x6FC138", Offset = "0x6FC138", VA = "0x6FC138")]
		public static void StopBus(string busName)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x70D1A8", Offset = "0x70D1A8", VA = "0x70D1A8")]
		public static void UnpauseBus(string busName)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x70D310", Offset = "0x70D310", VA = "0x70D310")]
		public static bool CreateBus(string busName, bool errorOnExisting = true, bool isTemporary = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x70D5FC", Offset = "0x70D5FC", VA = "0x70D5FC")]
		public static void DeleteBusByName(string busName)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x70D698", Offset = "0x70D698", VA = "0x70D698")]
		public static void DeleteBusByIndex(int busIndex)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x70062C", Offset = "0x70062C", VA = "0x70062C")]
		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return default(float);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x70DB88", Offset = "0x70DB88", VA = "0x70DB88")]
		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x70DFD4", Offset = "0x70DFD4", VA = "0x70DFD4")]
		public static void FadeOutOldBusVoices(string busName, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x70E200", Offset = "0x70E200", VA = "0x70E200")]
		public static void StopOldBusVoices(string busName, float minimumPlayTime)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x70E410", Offset = "0x70E410", VA = "0x70E410")]
		public static void GlideBusByPitch(string busName, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x6F93C4", Offset = "0x6F93C4", VA = "0x6F93C4")]
		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x70D9B0", Offset = "0x70D9B0", VA = "0x70D9B0")]
		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x706158", Offset = "0x706158", VA = "0x706158")]
		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x70C770", Offset = "0x70C770", VA = "0x70C770")]
		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x70EB20", Offset = "0x70EB20", VA = "0x70EB20")]
		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x70ECF8", Offset = "0x70ECF8", VA = "0x70ECF8")]
		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x70EED0", Offset = "0x70EED0", VA = "0x70EED0")]
		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x70F108", Offset = "0x70F108", VA = "0x70F108")]
		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime, bool isTemporary = false)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x70F28C", Offset = "0x70F28C", VA = "0x70F28C")]
		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x70F3A8", Offset = "0x70F3A8", VA = "0x70F3A8")]
		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x70F5CC", Offset = "0x70F5CC", VA = "0x70F5CC")]
		public static void ChangePlaylistPitch(string playlistName, float pitch, [Optional] string songName)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x70F6FC", Offset = "0x70F6FC", VA = "0x70F6FC")]
		public static void MutePlaylist()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x70F76C", Offset = "0x70F76C", VA = "0x70F76C")]
		public static void MutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x70BFCC", Offset = "0x70BFCC", VA = "0x70BFCC")]
		public static void MuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x70FA44", Offset = "0x70FA44", VA = "0x70FA44")]
		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x70FC20", Offset = "0x70FC20", VA = "0x70FC20")]
		public static void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x70FC90", Offset = "0x70FC90", VA = "0x70FC90")]
		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x70C098", Offset = "0x70C098", VA = "0x70C098")]
		public static void UnmuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x70FE84", Offset = "0x70FE84", VA = "0x70FE84")]
		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x70FF6C", Offset = "0x70FF6C", VA = "0x70FF6C")]
		public static void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x70FFDC", Offset = "0x70FFDC", VA = "0x70FFDC")]
		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x710268", Offset = "0x710268", VA = "0x710268")]
		public static void ToggleMuteAllPlaylists()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x7101D0", Offset = "0x7101D0", VA = "0x7101D0")]
		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x7102D4", Offset = "0x7102D4", VA = "0x7102D4")]
		public static void PausePlaylist()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x710344", Offset = "0x710344", VA = "0x710344")]
		public static void PausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x70BA4C", Offset = "0x70BA4C", VA = "0x70BA4C")]
		public static void PauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x710538", Offset = "0x710538", VA = "0x710538")]
		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x7105D0", Offset = "0x7105D0", VA = "0x7105D0")]
		public static void UnpausePlaylist()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x710640", Offset = "0x710640", VA = "0x710640")]
		public static void UnpausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x70BB14", Offset = "0x70BB14", VA = "0x70BB14")]
		public static void UnpauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x710834", Offset = "0x710834", VA = "0x710834")]
		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x7108CC", Offset = "0x7108CC", VA = "0x7108CC")]
		public static void StopPlaylist()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x71093C", Offset = "0x71093C", VA = "0x71093C")]
		public static void StopPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x70B984", Offset = "0x70B984", VA = "0x70B984")]
		public static void StopAllPlaylists()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x710B30", Offset = "0x710B30", VA = "0x710B30")]
		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x710BCC", Offset = "0x710BCC", VA = "0x710BCC")]
		public static void TriggerNextPlaylistClip()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x710C3C", Offset = "0x710C3C", VA = "0x710C3C")]
		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x710EC8", Offset = "0x710EC8", VA = "0x710EC8")]
		public static void TriggerNextClipAllPlaylists()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x710E30", Offset = "0x710E30", VA = "0x710E30")]
		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x710F34", Offset = "0x710F34", VA = "0x710F34")]
		public static void TriggerRandomPlaylistClip()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x710FA4", Offset = "0x710FA4", VA = "0x710FA4")]
		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x711230", Offset = "0x711230", VA = "0x711230")]
		public static void TriggerRandomClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x711198", Offset = "0x711198", VA = "0x711198")]
		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x71129C", Offset = "0x71129C", VA = "0x71129C")]
		public static void RestartPlaylist()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x71130C", Offset = "0x71130C", VA = "0x71130C")]
		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x7115A8", Offset = "0x7115A8", VA = "0x7115A8")]
		public static void RestartAllPlaylists()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x711510", Offset = "0x711510", VA = "0x711510")]
		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x711614", Offset = "0x711614", VA = "0x711614")]
		public static void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x71168C", Offset = "0x71168C", VA = "0x71168C")]
		public static void StartPlaylist(string playlistControllerName, string playlistName)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x7118B0", Offset = "0x7118B0", VA = "0x7118B0")]
		public static void StopLoopingAllCurrentSongs()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x7119B4", Offset = "0x7119B4", VA = "0x7119B4")]
		public static void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x711A24", Offset = "0x711A24", VA = "0x711A24")]
		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x71191C", Offset = "0x71191C", VA = "0x71191C")]
		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x711C28", Offset = "0x711C28", VA = "0x711C28")]
		public static void StopAllPlaylistsAfterCurrentSongs()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x711D2C", Offset = "0x711D2C", VA = "0x711D2C")]
		public static void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x711D9C", Offset = "0x711D9C", VA = "0x711D9C")]
		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x711C94", Offset = "0x711C94", VA = "0x711C94")]
		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x711FA0", Offset = "0x711FA0", VA = "0x711FA0")]
		public static void QueuePlaylistClip(string clipName)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x712018", Offset = "0x712018", VA = "0x712018")]
		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x7121B8", Offset = "0x7121B8", VA = "0x7121B8")]
		public static bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x712230", Offset = "0x712230", VA = "0x712230")]
		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x7123D0", Offset = "0x7123D0", VA = "0x7123D0")]
		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x712458", Offset = "0x712458", VA = "0x712458")]
		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x7125FC", Offset = "0x7125FC", VA = "0x7125FC")]
		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x712684", Offset = "0x712684", VA = "0x712684")]
		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x7129F8", Offset = "0x7129F8", VA = "0x7129F8")]
		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x712894", Offset = "0x712894", VA = "0x712894")]
		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x712A7C", Offset = "0x712A7C", VA = "0x712A7C")]
		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x712BD8", Offset = "0x712BD8", VA = "0x712BD8")]
		public static void DeletePlaylist(string playlistName)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x712DB8", Offset = "0x712DB8", VA = "0x712DB8")]
		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x713030", Offset = "0x713030", VA = "0x713030")]
		public static void AudioListenerChanged(AudioListener listener)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x713184", Offset = "0x713184", VA = "0x713184")]
		public static void FireCustomEventNextFrame(string customEventName, Transform eventOrigin)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x6F66C8", Offset = "0x6F66C8", VA = "0x6F66C8")]
		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x6F6B5C", Offset = "0x6F6B5C", VA = "0x6F6B5C")]
		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x7133E0", Offset = "0x7133E0", VA = "0x7133E0")]
		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x7136F8", Offset = "0x7136F8", VA = "0x7136F8")]
		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName, bool isTemporary)
		{
			return null;
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x71395C", Offset = "0x71395C", VA = "0x71395C")]
		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, string categoryName = "", bool isTemporary = false, bool errorOnDuplicate = true)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x713D24", Offset = "0x713D24", VA = "0x713D24")]
		public static void DeleteCustomEvent(string customEventName)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x713F20", Offset = "0x713F20", VA = "0x713F20")]
		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x6F4E9C", Offset = "0x6F4E9C", VA = "0x6F4E9C")]
		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x6F6344", Offset = "0x6F6344", VA = "0x6F6344")]
		public static bool CustomEventExists(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x714088", Offset = "0x714088", VA = "0x714088")]
		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x714228", Offset = "0x714228", VA = "0x714228")]
		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x7143C8", Offset = "0x7143C8", VA = "0x7143C8")]
		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			return null;
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x6FF414", Offset = "0x6FF414", VA = "0x6FF414")]
		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x6FF52C", Offset = "0x6FF52C", VA = "0x6FF52C")]
		private static void LogMessage(string message)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x6FF364", Offset = "0x6FF364", VA = "0x6FF364")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x714830", Offset = "0x714830", VA = "0x714830")]
		public static void LogWarningIfNeverLogged(string msg, int errorNumber)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x705E48", Offset = "0x705E48", VA = "0x705E48")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x71495C", Offset = "0x71495C", VA = "0x71495C")]
		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x70F960", Offset = "0x70F960", VA = "0x70F960")]
		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x714B74", Offset = "0x714B74", VA = "0x714B74")]
		public static void SetupAmbientNextFrame(AmbientSound ambient)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x714E00", Offset = "0x714E00", VA = "0x714E00")]
		public static void RemoveDelayedAmbient(AmbientSound ambient)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x714FE4", Offset = "0x714FE4", VA = "0x714FE4")]
		public static void QueueTransformFollowerForColliderPositionRecalc(TransformFollower follower)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x715240", Offset = "0x715240", VA = "0x715240")]
		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x71549C", Offset = "0x71549C", VA = "0x71549C")]
		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x7156A4", Offset = "0x7156A4", VA = "0x7156A4")]
		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x715A54", Offset = "0x715A54", VA = "0x715A54")]
		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x6F3FB8", Offset = "0x6F3FB8", VA = "0x6F3FB8")]
		public static bool HasQueuedOcclusionRays()
		{
			return default(bool);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x6F403C", Offset = "0x6F403C", VA = "0x6F403C")]
		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x704F6C", Offset = "0x704F6C", VA = "0x704F6C")]
		public static bool IsOcclusionFreqencyTransitioning(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x703964", Offset = "0x703964", VA = "0x703964")]
		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x7158CC", Offset = "0x7158CC", VA = "0x7158CC")]
		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x715BDC", Offset = "0x715BDC", VA = "0x715BDC")]
		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x7022A0", Offset = "0x7022A0", VA = "0x7022A0")]
		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x715EB4", Offset = "0x715EB4", VA = "0x715EB4")]
		public static int RemainingClipsInGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x708638", Offset = "0x708638", VA = "0x708638")]
		public static void RescanGroupsNow()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x717624", Offset = "0x717624", VA = "0x717624")]
		public static void DoneRescanningGroups()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x717838", Offset = "0x717838", VA = "0x717838")]
		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x7179F4", Offset = "0x7179F4", VA = "0x7179F4")]
		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x717BB0", Offset = "0x717BB0", VA = "0x717BB0")]
		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x717D6C", Offset = "0x717D6C", VA = "0x717D6C")]
		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x717F28", Offset = "0x717F28", VA = "0x717F28")]
		public MasterAudio()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public static class PersistentAudioSettings
	{
		[Token(Token = "0x4000672")]
		public const string SfxVolKey = "MA_sfxVolume";

		[Token(Token = "0x4000673")]
		public const string MusicVolKey = "MA_musicVolume";

		[Token(Token = "0x4000674")]
		public const string SfxMuteKey = "MA_sfxMute";

		[Token(Token = "0x4000675")]
		public const string MusicMuteKey = "MA_musicMute";

		[Token(Token = "0x4000676")]
		public const string BusVolKey = "MA_BusVolume_";

		[Token(Token = "0x4000677")]
		public const string GroupVolKey = "MA_GroupVolume_";

		[Token(Token = "0x4000678")]
		public const string BusKeysKey = "MA_BusKeys";

		[Token(Token = "0x4000679")]
		public const string GroupKeysKey = "MA_GroupsKeys";

		[Token(Token = "0x400067A")]
		public const string Separator = ";";

		[Token(Token = "0x170000E7")]
		public static string BusesUpdatedKeys
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0xE1868C", Offset = "0xE1868C", VA = "0xE1868C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0xE18708", Offset = "0xE18708", VA = "0xE18708")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public static string GroupsUpdatedKeys
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0xE18838", Offset = "0xE18838", VA = "0xE18838")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xE188B4", Offset = "0xE188B4", VA = "0xE188B4")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public static bool? MixerMuted
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0xE18B60", Offset = "0xE18B60", VA = "0xE18B60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xE18BF8", Offset = "0xE18BF8", VA = "0xE18BF8")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public static float? MixerVolume
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xE18D58", Offset = "0xE18D58", VA = "0xE18D58")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xE18DE8", Offset = "0xE18DE8", VA = "0xE18DE8")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public static bool? MusicMuted
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xE18F3C", Offset = "0xE18F3C", VA = "0xE18F3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xE18FD4", Offset = "0xE18FD4", VA = "0xE18FD4")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public static float? MusicVolume
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0xE19134", Offset = "0xE19134", VA = "0xE19134")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xE191C4", Offset = "0xE191C4", VA = "0xE191C4")]
			set
			{
			}
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xE184A4", Offset = "0xE184A4", VA = "0xE184A4")]
		public static void SetBusVolume(string busName, float vol)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xE1863C", Offset = "0xE1863C", VA = "0xE1863C")]
		public static string MakeBusKey(string busName)
		{
			return null;
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xE18758", Offset = "0xE18758", VA = "0xE18758")]
		public static float? GetBusVolume(string busName)
		{
			return null;
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xE187E8", Offset = "0xE187E8", VA = "0xE187E8")]
		public static string GetGroupKey(string groupName)
		{
			return null;
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xE18904", Offset = "0xE18904", VA = "0xE18904")]
		public static void SetGroupVolume(string grpName, float vol)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xE18AD0", Offset = "0xE18AD0", VA = "0xE18AD0")]
		public static float? GetGroupVolume(string grpName)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xE19318", Offset = "0xE19318", VA = "0xE19318")]
		public static void RestoreMasterSettings()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class SoundGroupOrganizer : MonoBehaviour
	{
		[Token(Token = "0x200011E")]
		public class CustomEventSelection
		{
			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEvent Event;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xDAAEC8", Offset = "0xDAAEC8", VA = "0xDAAEC8")]
			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
			}
		}

		[Token(Token = "0x200011F")]
		public class SoundGroupSelection
		{
			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject Go;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xDAAF14", Offset = "0xDAAF14", VA = "0xDAAF14")]
			public SoundGroupSelection(GameObject go, bool isSelected)
			{
			}
		}

		[Token(Token = "0x2000120")]
		public enum MAItemType
		{
			[Token(Token = "0x4000696")]
			SoundGroups,
			[Token(Token = "0x4000697")]
			CustomEvents
		}

		[Token(Token = "0x2000121")]
		public enum TransferMode
		{
			[Token(Token = "0x4000699")]
			None,
			[Token(Token = "0x400069A")]
			Import,
			[Token(Token = "0x400069B")]
			Export
		}

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject dynGroupTemplate;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject dynVariationTemplate;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject maGroupTemplate;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject maVariationTemplate;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useTextGroupFilter;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string textGroupFilter;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TransferMode transMode;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject sourceObject;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupSelection> selectedSourceSoundGroups;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject destObject;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<SoundGroupSelection> selectedDestSoundGroups;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public MAItemType itemType;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<CustomEventSelection> selectedSourceCustomEvents;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<CustomEventSelection> selectedDestCustomEvents;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string newEventName;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xE23844", Offset = "0xE23844", VA = "0xE23844")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xE238B8", Offset = "0xE238B8", VA = "0xE238B8")]
		public SoundGroupOrganizer()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public static class AmbientUtil
	{
		[Token(Token = "0x400069C")]
		public const string FollowerHolderName = "_Followers";

		[Token(Token = "0x400069D")]
		public const string ListenerFollowerName = "~ListenerFollower~";

		[Token(Token = "0x400069E")]
		public const float ListenerFollowerTrigRadius = 0.01f;

		[Token(Token = "0x400069F")]
		public const int IgnoreRaycastLayerNumber = 2;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform _followerHolder;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ListenerFollower _listenerFollower;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<TransformFollower> _transformFollowers;

		[Token(Token = "0x170000ED")]
		public static ListenerFollower ListenerFollower
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x9818E4", Offset = "0x9818E4", VA = "0x9818E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EE")]
		public static Transform FollowerHolder
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x98138C", Offset = "0x98138C", VA = "0x98138C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EF")]
		public static bool HasListenerFollower
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x981E4C", Offset = "0x981E4C", VA = "0x981E4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F0")]
		public static bool HasListenerFolowerRigidBody
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x981218", Offset = "0x981218", VA = "0x981218")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x9812D8", Offset = "0x9812D8", VA = "0x9812D8")]
		public static void InitFollowerHolder()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x981170", Offset = "0x981170", VA = "0x981170")]
		public static bool InitListenerFollower()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x981858", Offset = "0x981858", VA = "0x981858")]
		public static void RemoveTransformFollower(TransformFollower follower)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x981220", Offset = "0x981220", VA = "0x981220")]
		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, string variationName, float volume, bool willFollowSource, bool willPositionOnClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x981C58", Offset = "0x981C58", VA = "0x981C58")]
		public static void ManualUpdate()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x981D68", Offset = "0x981D68", VA = "0x981D68")]
		private static void UpdateListenerFollower()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public static class ArrayListUtil
	{
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x982040", Offset = "0x982040", VA = "0x982040")]
		public static void SortIntArray(ref List<int> list)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x982164", Offset = "0x982164", VA = "0x982164")]
		public static bool IsExcludedChildName(string name)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000124")]
	public static class AudioTransformExtensions
	{
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x984650", Offset = "0x984650", VA = "0x984650")]
		public static void FadeOutSoundGroupOfTransform(this Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x9846D4", Offset = "0x9846D4", VA = "0x9846D4")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(this Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x984738", Offset = "0x984738", VA = "0x984738")]
		public static bool PlaySound3DAtTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x9847E4", Offset = "0x9847E4", VA = "0x9847E4")]
		public static PlaySoundResult PlaySound3DAtTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x9848A4", Offset = "0x9848A4", VA = "0x9848A4")]
		public static bool PlaySound3DFollowTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x984950", Offset = "0x984950", VA = "0x984950")]
		public static PlaySoundResult PlaySound3DFollowTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x984A10", Offset = "0x984A10", VA = "0x984A10")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x984AD4", Offset = "0x984AD4", VA = "0x984AD4")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x984B98", Offset = "0x984B98", VA = "0x984B98")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x984BFC", Offset = "0x984BFC", VA = "0x984BFC")]
		public static void PauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x984C70", Offset = "0x984C70", VA = "0x984C70")]
		public static void PauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x984CE4", Offset = "0x984CE4", VA = "0x984CE4")]
		public static void StopAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x984D48", Offset = "0x984D48", VA = "0x984D48")]
		public static void StopBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x984DBC", Offset = "0x984DBC", VA = "0x984DBC")]
		public static void StopSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x984E30", Offset = "0x984E30", VA = "0x984E30")]
		public static void UnpauseAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x984E94", Offset = "0x984E94", VA = "0x984E94")]
		public static void UnpauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x984F08", Offset = "0x984F08", VA = "0x984F08")]
		public static void UnpauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x984F7C", Offset = "0x984F7C", VA = "0x984F7C")]
		public static bool IsTransformPlayingSoundGroup(this Transform sourceTrans, string sType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000125")]
	public class AudioTransformTracker : MonoBehaviour
	{
		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int _frames;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x170000F1")]
		public Transform Trans
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x984FF0", Offset = "0x984FF0", VA = "0x984FF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x985090", Offset = "0x985090", VA = "0x985090")]
		private void Update()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x9850A0", Offset = "0x9850A0", VA = "0x9850A0")]
		public AudioTransformTracker()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public static class AudioUtil
	{
		[Token(Token = "0x40006A5")]
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		[Token(Token = "0x40006A6")]
		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		[Token(Token = "0x40006A7")]
		private const float SemitonePitchChangeAmt = 1.0594635f;

		[Token(Token = "0x170000F2")]
		public static float FixedDeltaTime
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x985120", Offset = "0x985120", VA = "0x985120")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F3")]
		public static float FrameTime
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x985128", Offset = "0x985128", VA = "0x985128")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F4")]
		public static float Time
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x985130", Offset = "0x985130", VA = "0x985130")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F5")]
		public static int FrameCount
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x985138", Offset = "0x985138", VA = "0x985138")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x9850A8", Offset = "0x9850A8", VA = "0x9850A8")]
		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x9850F0", Offset = "0x9850F0", VA = "0x9850F0")]
		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x985108", Offset = "0x985108", VA = "0x985108")]
		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x985140", Offset = "0x985140", VA = "0x985140")]
		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x98518C", Offset = "0x98518C", VA = "0x98518C")]
		public static float GetSemitonesFromPitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x9851D8", Offset = "0x9851D8", VA = "0x9851D8")]
		public static float GetPitchFromSemitones(float semitones)
		{
			return default(float);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x985218", Offset = "0x985218", VA = "0x985218")]
		public static float GetDbFromFloatVolume(float vol)
		{
			return default(float);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x985234", Offset = "0x985234", VA = "0x985234")]
		public static float GetFloatVolumeFromDb(float db)
		{
			return default(float);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x982FD8", Offset = "0x982FD8", VA = "0x982FD8")]
		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x985244", Offset = "0x985244", VA = "0x985244")]
		public static bool IsClipPaused(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x98528C", Offset = "0x98528C", VA = "0x98528C")]
		public static void ClipPlayed(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x9853A8", Offset = "0x9853A8", VA = "0x9853A8")]
		public static void UnloadNonPreloadedAudioData(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x985318", Offset = "0x985318", VA = "0x985318")]
		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x985494", Offset = "0x985494", VA = "0x985494")]
		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x985528", Offset = "0x985528", VA = "0x985528")]
		private static float GetPositiveUsablePitch(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x985554", Offset = "0x985554", VA = "0x985554")]
		private static float GetPositiveUsablePitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x985564", Offset = "0x985564", VA = "0x985564")]
		public static float AdjustAudioClipDurationForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x9855A0", Offset = "0x9855A0", VA = "0x9855A0")]
		public static float AdjustAudioClipDurationForPitch(float duration, float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x9855B4", Offset = "0x9855B4", VA = "0x9855B4")]
		public static float AdjustEndLeadTimeForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000127")]
	public static class CoroutineHelper
	{
		[Token(Token = "0x2000128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521B04", Offset = "0x521B04")]
		private sealed class <WaitForActualSeconds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <start>5__2;

			[Token(Token = "0x170000F6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000632")]
				[Address(RVA = "0xDA8098", Offset = "0xDA8098", VA = "0xDA8098", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000634")]
				[Address(RVA = "0xDA80E0", Offset = "0xDA80E0", VA = "0xDA80E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0xDA7F9C", Offset = "0xDA7F9C", VA = "0xDA7F9C")]
			[DebuggerHidden]
			public <WaitForActualSeconds>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0xDA7FC8", Offset = "0xDA7FC8", VA = "0xDA7FC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0xDA7FCC", Offset = "0xDA7FCC", VA = "0xDA7FCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0xDA80A0", Offset = "0xDA80A0", VA = "0xDA80A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x989464", Offset = "0x989464", VA = "0x989464")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5238B4", Offset = "0x5238B4")]
		public static IEnumerator WaitForActualSeconds(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x2000129")]
	public static class DTMonoHelper
	{
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x981C40", Offset = "0x981C40", VA = "0x981C40")]
		public static Transform GetChildTransform(this Transform transParent, string childName)
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x98A890", Offset = "0x98A890", VA = "0x98A890")]
		public static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x98A8A8", Offset = "0x98A8A8", VA = "0x98A8A8")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x981690", Offset = "0x981690", VA = "0x981690")]
		public static void DestroyAllChildren(this Transform tran)
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class DelayBetweenSongs : MonoBehaviour
	{
		[Token(Token = "0x200012B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521B24", Offset = "0x521B24")]
		private sealed class <PlaySongWithDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayBetweenSongs <>4__this;

			[Token(Token = "0x170000F8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000641")]
				[Address(RVA = "0xDA8268", Offset = "0xDA8268", VA = "0xDA8268", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000643")]
				[Address(RVA = "0xDA82B0", Offset = "0xDA82B0", VA = "0xDA82B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0xDA80E8", Offset = "0xDA80E8", VA = "0xDA80E8")]
			[DebuggerHidden]
			public <PlaySongWithDelay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0xDA8114", Offset = "0xDA8114", VA = "0xDA8114", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0xDA8118", Offset = "0xDA8118", VA = "0xDA8118", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0xDA8270", Offset = "0xDA8270", VA = "0xDA8270", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minTimeToWait;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxTimeToWait;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playlistControllerName;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlaylistController _controller;

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x98DC24", Offset = "0x98DC24", VA = "0x98DC24")]
		private void Start()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x98DCD8", Offset = "0x98DCD8", VA = "0x98DCD8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x98DD6C", Offset = "0x98DD6C", VA = "0x98DD6C")]
		private void SongEnded(string songName)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x98DDA4", Offset = "0x98DDA4", VA = "0x98DDA4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x523984", Offset = "0x523984")]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x98DE1C", Offset = "0x98DE1C", VA = "0x98DE1C")]
		public DelayBetweenSongs()
		{
		}
	}
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x521B34", Offset = "0x521B34")]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		[Token(Token = "0x200012D")]
		public enum CreateItemsWhen
		{
			[Token(Token = "0x40006D5")]
			FirstEnableOnly,
			[Token(Token = "0x40006D6")]
			EveryEnable
		}

		[Token(Token = "0x200012E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521B48", Offset = "0x521B48")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEventCategory aCat;

			[Token(Token = "0x6000651")]
			[Address(RVA = "0xDA82B8", Offset = "0xDA82B8", VA = "0xDA82B8")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0xDA82C0", Offset = "0xDA82C0", VA = "0xDA82C0")]
			internal bool <RemoveItems>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40006B3")]
		public const int ExtraHardCodedBusOptions = 1;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject groupTemplate;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject variationTemplate;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool errorOnDuplicates;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool createOnAwake;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool soundGroupsAreExpanded;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool removeGroupsOnSceneChange;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CreateItemsWhen reUseMode;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool showCustomEvents;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CustomEvent> customEventsToCreate;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string newEventName;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool showMusicDucking;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool playListExpanded;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool playlistEditorExp;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MasterAudio.Playlist> musicPlaylists;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string audioSourceTemplateName;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool groupByBus;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool itemsCreatedEventExpanded;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string itemsCreatedCustomEvent;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool _hasCreated;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<Transform> _groupsToRemove;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<DynamicSoundGroup> _groupsToCreate;

		[Token(Token = "0x170000FA")]
		public static int HardCodedBusOptions
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x9903BC", Offset = "0x9903BC", VA = "0x9903BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000FB")]
		public List<DynamicSoundGroup> GroupsToCreate
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x990434", Offset = "0x990434", VA = "0x990434")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x99043C", Offset = "0x99043C", VA = "0x99043C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x98ED88", Offset = "0x98ED88", VA = "0x98ED88")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x98EE6C", Offset = "0x98EE6C", VA = "0x98EE6C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x98EF6C", Offset = "0x98EF6C", VA = "0x98EF6C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x98EF70", Offset = "0x98EF70", VA = "0x98EF70")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x98EE70", Offset = "0x98EE70", VA = "0x98EE70")]
		private void CreateItemsIfReady()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x98F09C", Offset = "0x98F09C", VA = "0x98F09C")]
		public void RemoveItems()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x98F4D4", Offset = "0x98F4D4", VA = "0x98F4D4")]
		public void CreateItems()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x9903C4", Offset = "0x9903C4", VA = "0x9903C4")]
		private void FireEvents()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x99012C", Offset = "0x99012C", VA = "0x99012C")]
		public void PopulateGroupData()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x990444", Offset = "0x990444", VA = "0x990444")]
		public DynamicSoundGroupCreator()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public static class FilePlayerPrefs
	{
		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Hashtable PlayerPrefsHashtable;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _hashTableChanged;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _serializedOutput;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string SerializedInput;

		[Token(Token = "0x40006DC")]
		private const string ParametersSeperator = ";";

		[Token(Token = "0x40006DD")]
		private const string KeyValueSeperator = ":";

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string FileName;

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x6EE37C", Offset = "0x6EE37C", VA = "0x6EE37C")]
		static FilePlayerPrefs()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x6EE828", Offset = "0x6EE828", VA = "0x6EE828")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x6EE8A8", Offset = "0x6EE8A8", VA = "0x6EE8A8")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x6EE9DC", Offset = "0x6EE9DC", VA = "0x6EE9DC")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x6EEB5C", Offset = "0x6EEB5C", VA = "0x6EEB5C")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x6EECE4", Offset = "0x6EECE4", VA = "0x6EECE4")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x6EEE68", Offset = "0x6EEE68", VA = "0x6EEE68")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x6EEF48", Offset = "0x6EEF48", VA = "0x6EEF48")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x6EF088", Offset = "0x6EF088", VA = "0x6EF088")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x6EF230", Offset = "0x6EF230", VA = "0x6EF230")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x6EF3B8", Offset = "0x6EF3B8", VA = "0x6EF3B8")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x6EF560", Offset = "0x6EF560", VA = "0x6EF560")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x6EF6F0", Offset = "0x6EF6F0", VA = "0x6EF6F0")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x6EF800", Offset = "0x6EF800", VA = "0x6EF800")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x6EF994", Offset = "0x6EF994", VA = "0x6EF994")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x6EFA14", Offset = "0x6EFA14", VA = "0x6EFA14")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x6EFA8C", Offset = "0x6EFA8C", VA = "0x6EFA8C")]
		public static void Flush()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x6EFC38", Offset = "0x6EFC38", VA = "0x6EFC38")]
		private static void Serialize()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x6EE520", Offset = "0x6EE520", VA = "0x6EE520")]
		private static void Deserialize()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x6F01AC", Offset = "0x6F01AC", VA = "0x6F01AC")]
		private static string EscapeNonSeperators(string inputToEscape)
		{
			return null;
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x6F0258", Offset = "0x6F0258", VA = "0x6F0258")]
		private static string DeEscapeNonSeperators(string inputToDeEscape)
		{
			return null;
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x6F0304", Offset = "0x6F0304", VA = "0x6F0304")]
		public static object GetTypeValue(string typeName, string value)
		{
			return null;
		}
	}
	[Token(Token = "0x2000130")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x521B58", Offset = "0x521B58")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x521B58", Offset = "0x521B58")]
	public class PlaylistController : MonoBehaviour
	{
		[Token(Token = "0x2000131")]
		public enum AudioPlayType
		{
			[Token(Token = "0x4000738")]
			PlayNow,
			[Token(Token = "0x4000739")]
			Schedule,
			[Token(Token = "0x400073A")]
			AlreadyScheduled
		}

		[Token(Token = "0x2000132")]
		public enum PlaylistStates
		{
			[Token(Token = "0x400073C")]
			NotInScene,
			[Token(Token = "0x400073D")]
			Stopped,
			[Token(Token = "0x400073E")]
			Playing,
			[Token(Token = "0x400073F")]
			Paused,
			[Token(Token = "0x4000740")]
			Crossfading
		}

		[Token(Token = "0x2000133")]
		public enum FadeMode
		{
			[Token(Token = "0x4000742")]
			None,
			[Token(Token = "0x4000743")]
			GradualFade
		}

		[Token(Token = "0x2000134")]
		public enum AudioDuckingMode
		{
			[Token(Token = "0x4000745")]
			NotDucking,
			[Token(Token = "0x4000746")]
			SetToDuck,
			[Token(Token = "0x4000747")]
			Ducked
		}

		[Token(Token = "0x2000135")]
		public delegate void SongChangedEventHandler(string newSongName, MusicSetting song);

		[Token(Token = "0x2000136")]
		public delegate void SongEndedEventHandler(string songName);

		[Token(Token = "0x2000137")]
		public delegate void SongLoopedEventHandler(string songName);

		[Token(Token = "0x2000138")]
		public delegate void PlaylistEndedEventHandler();

		[Token(Token = "0x2000139")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521BCC", Offset = "0x521BCC")]
		private sealed class <>c__DisplayClass104_0
		{
			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string clipName;

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0xDA9F28", Offset = "0xDA9F28", VA = "0xDA9F28")]
			public <>c__DisplayClass104_0()
			{
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0xDA9F30", Offset = "0xDA9F30", VA = "0xDA9F30")]
			internal bool <FindSongByAliasOrName>b__0(MusicSetting obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0xDA9F54", Offset = "0xDA9F54", VA = "0xDA9F54")]
			internal bool <FindSongByAliasOrName>b__1(MusicSetting obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200013A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521BDC", Offset = "0x521BDC")]
		private sealed class <>c__DisplayClass114_0
		{
			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string playlistControllerName;

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0xDAA020", Offset = "0xDAA020", VA = "0xDAA020")]
			public <>c__DisplayClass114_0()
			{
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0xDAA028", Offset = "0xDAA028", VA = "0xDAA028")]
			internal bool <InstanceByName>b__0(PlaylistController obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200013B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x521BEC", Offset = "0x521BEC")]
		private sealed class <>c__DisplayClass144_0
		{
			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlaylistController <>4__this;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volumeBeforeFade;

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0xDAA0D4", Offset = "0xDAA0D4", VA = "0xDAA0D4")]
			public <>c__DisplayClass144_0()
			{
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0xDAA0DC", Offset = "0xDAA0DC", VA = "0xDAA0DC")]
			internal void <FadeOutPlaylist>b__0()
			{
			}
		}

		[Token(Token = "0x40006DF")]
		public const float ScheduledSongMinBadOffset = 0.5f;

		[Token(Token = "0x40006E0")]
		public const int FramesEarlyToTrigger = 2;

		[Token(Token = "0x40006E1")]
		public const int FramesEarlyToBeSyncable = 10;

		[Token(Token = "0x40006E2")]
		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		[Token(Token = "0x40006E3")]
		private const float MinSongLength = 0.5f;

		[Token(Token = "0x40006E4")]
		private const float SlowestFrameTimeForCalc = 0.3f;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool startPlaylistOnAwake;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isShuffle;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isAutoAdvance;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool loopPlaylist;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float _playlistVolume;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isMuted;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string startPlaylistName;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int syncGroupNum;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float spatialBlend;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool initializedEventExpanded;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string initializedCustomEvent;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool crossfadeStartedExpanded;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string crossfadeStartedCustomEvent;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string songChangedCustomEvent;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool songEndedEventExpanded;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string songEndedCustomEvent;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool songLoopedEventExpanded;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string songLoopedCustomEvent;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool playlistStartedEventExpanded;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string playlistStartedCustomEvent;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool playlistEndedEventExpanded;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string playlistEndedCustomEvent;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioSource _activeAudio;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioSource _transitioningAudio;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _activeAudioEndVolume;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _transitioningAudioStartVolume;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _crossFadeStartTime;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<int> _clipsRemaining;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _currentSequentialClipIndex;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private AudioDuckingMode _duckingMode;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _timeToStartUnducking;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _timeToFinishUnducking;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _originalMusicVolume;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _initialDuckVolume;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _duckRange;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private MusicSetting _currentSong;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject _go;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string _name;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private FadeMode _curFadeMode;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float _slowFadeStartTime;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float _slowFadeCompletionTime;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float _slowFadeStartVolume;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float _slowFadeTargetVolume;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private MasterAudio.Playlist _currentPlaylist;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _lastTimeMissingPlaylistLogged;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Action _fadeCompleteCallback;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private readonly List<MusicSetting> _queuedSongs;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool _lostFocus;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
		private bool _autoStartedPlaylist;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private AudioSource _audioClip;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private AudioSource _transClip;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private MusicSetting _newSongSetting;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _nextSongRequested;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x171")]
		private bool _nextSongScheduled;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private int _lastRandomClipIndex;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float _lastTimeSongRequested;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float _currentDuckVolCut;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private int? _lastSongPosition;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private double? _currentSchedSongDspStartTime;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private double? _currentSchedSongDspEndTime;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private int _lastFrameSongPosition;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<AudioSource, double> _scheduledSongOffsetByAudioSource;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public int _frames;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<PlaylistController> _instances;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Coroutine _resourceCoroutine;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private int _songsPlayedFromPlaylist;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private AudioSource _audio1;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private AudioSource _audio2;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private string _activeSongAlias;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Transform _trans;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private bool _willPersist;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private double? _songPauseTime;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private int framesOfSongPlayed;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522B28", Offset = "0x522B28")]
		private bool <ControllerIsReady>k__BackingField;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x231")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x522B38", Offset = "0x522B38")]
		private bool <IsCrossFading>k__BackingField;

		[Token(Token = "0x170000FD")]
		private bool SongIsNonAdvancible
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0xE20480", Offset = "0xE20480", VA = "0xE20480")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FE")]
		public bool ControllerIsReady
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0xE204D8", Offset = "0xE204D8", VA = "0xE204D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523AB4", Offset = "0x523AB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xE204E0", Offset = "0xE204E0", VA = "0xE204E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523AC4", Offset = "0x523AC4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public PlaylistStates PlaylistState
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xE1BF6C", Offset = "0xE1BF6C", VA = "0xE1BF6C")]
			get
			{
				return default(PlaylistStates);
			}
		}

		[Token(Token = "0x17000100")]
		public AudioSource ActiveAudioSource
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0xE1B190", Offset = "0xE1B190", VA = "0xE1B190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000101")]
		public static List<PlaylistController> Instances
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0xE1C454", Offset = "0xE1C454", VA = "0xE1C454")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0xE204EC", Offset = "0xE204EC", VA = "0xE204EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public GameObject PlaylistControllerGameObject
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0xE20540", Offset = "0xE20540", VA = "0xE20540")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000103")]
		public AudioSource CurrentPlaylistSource
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xE20548", Offset = "0xE20548", VA = "0xE20548")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000104")]
		public AudioClip CurrentPlaylistClip
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xE20550", Offset = "0xE20550", VA = "0xE20550")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000105")]
		public AudioClip FadingPlaylistClip
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0xE205E4", Offset = "0xE205E4", VA = "0xE205E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		public AudioSource FadingSource
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0xE20680", Offset = "0xE20680", VA = "0xE20680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000107")]
		public bool IsCrossFading
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0xE20698", Offset = "0xE20698", VA = "0xE20698")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523AD4", Offset = "0x523AD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0xE206A0", Offset = "0xE206A0", VA = "0xE206A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523AE4", Offset = "0x523AE4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public bool IsFading
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xE206AC", Offset = "0xE206AC", VA = "0xE206AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000109")]
		public float PlaylistVolume
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0xE1EF54", Offset = "0xE1EF54", VA = "0xE1EF54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xE206CC", Offset = "0xE206CC", VA = "0xE206CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public MasterAudio.Playlist CurrentPlaylist
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0xE1F4F8", Offset = "0xE1F4F8", VA = "0xE1F4F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010B")]
		public bool HasPlaylist
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0xE1C784", Offset = "0xE1C784", VA = "0xE1C784")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010C")]
		public string PlaylistName
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0xE20718", Offset = "0xE20718", VA = "0xE20718")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010D")]
		private bool IsMuted
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0xE2078C", Offset = "0xE2078C", VA = "0xE2078C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010E")]
		private bool PlaylistIsMuted
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0xE1C900", Offset = "0xE1C900", VA = "0xE1C900")]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		private float CrossFadeTime
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0xE1BD80", Offset = "0xE1BD80", VA = "0xE1BD80")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000110")]
		private bool IsAutoAdvance
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0xE1BE0C", Offset = "0xE1BE0C", VA = "0xE1BE0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000111")]
		public GameObject GameObj
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0xE1D134", Offset = "0xE1D134", VA = "0xE1D134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000112")]
		public string ControllerName
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0xE1A08C", Offset = "0xE1A08C", VA = "0xE1A08C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000113")]
		public bool CanSchedule
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0xE1BC0C", Offset = "0xE1BC0C", VA = "0xE1BC0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000114")]
		private bool IsFrameFastEnough
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0xE1A868", Offset = "0xE1A868", VA = "0xE1A868")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000115")]
		private bool ShouldNotSwitchEarly
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0xE1BF30", Offset = "0xE1BF30", VA = "0xE1BF30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000116")]
		private Transform Trans
		{
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0xE1A760", Offset = "0xE1A760", VA = "0xE1A760")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000117")]
		public int ClipsRemainingInCurrentPlaylist
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0xE20794", Offset = "0xE20794", VA = "0xE20794")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000004")]
		public event SongChangedEventHandler SongChanged
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0xE19588", Offset = "0xE19588", VA = "0xE19588")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523A34", Offset = "0x523A34")]
			add
			{
			}
			[Token(Token = "0x600066A")]
			[Address(RVA = "0xE1962C", Offset = "0xE1962C", VA = "0xE1962C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523A44", Offset = "0x523A44")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event SongEndedEventHandler SongEnded
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0xE196D0", Offset = "0xE196D0", VA = "0xE196D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523A54", Offset = "0x523A54")]
			add
			{
			}
			[Token(Token = "0x600066C")]
			[Address(RVA = "0xE19774", Offset = "0xE19774", VA = "0xE19774")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523A64", Offset = "0x523A64")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event SongLoopedEventHandler SongLooped
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0xE19818", Offset = "0xE19818", VA = "0xE19818")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523A74", Offset = "0x523A74")]
			add
			{
			}
			[Token(Token = "0x600066E")]
			[Address(RVA = "0xE198BC", Offset = "0xE198BC", VA = "0xE198BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523A84", Offset = "0x523A84")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event PlaylistEndedEventHandler PlaylistEnded
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0xE19960", Offset = "0xE19960", VA = "0xE19960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523A94", Offset = "0x523A94")]
			add
			{
			}
			[Token(Token = "0x6000670")]
			[Address(RVA = "0xE19A04", Offset = "0xE19A04", VA = "0xE19A04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523AA4", Offset = "0x523AA4")]
			remove
			{
			}
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xE19AA8", Offset = "0xE19AA8", VA = "0xE19AA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xE1A0E0", Offset = "0xE1A0E0", VA = "0xE1A0E0")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xE1A2FC", Offset = "0xE1A2FC", VA = "0xE1A2FC")]
		private MusicSetting FindSongByAliasOrName(string clipName)
		{
			return null;
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xE1A47C", Offset = "0xE1A47C", VA = "0xE1A47C")]
		private void SetAudiosIfEmpty()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xE1A24C", Offset = "0xE1A24C", VA = "0xE1A24C")]
		private void SetAudioSpatialBlend(float blend)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xE1A514", Offset = "0xE1A514", VA = "0xE1A514")]
		private void Start()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xE1A800", Offset = "0xE1A800", VA = "0xE1A800")]
		private void AutoStartPlaylist()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xE1A938", Offset = "0xE1A938", VA = "0xE1A938")]
		private void CoUpdate()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xE1AE08", Offset = "0xE1AE08", VA = "0xE1AE08")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xE1AF14", Offset = "0xE1AF14", VA = "0xE1AF14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xE1B264", Offset = "0xE1B264", VA = "0xE1B264")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xE1B270", Offset = "0xE1B270", VA = "0xE1B270")]
		private void Update()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xE1C268", Offset = "0xE1C268", VA = "0xE1C268")]
		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xE1C64C", Offset = "0xE1C64C", VA = "0xE1C64C")]
		public bool IsSongPlaying(string songName)
		{
			return default(bool);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xE1C794", Offset = "0xE1C794", VA = "0xE1C794")]
		public void ClearQueue()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xE1C844", Offset = "0xE1C844", VA = "0xE1C844")]
		public void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xE1A860", Offset = "0xE1A860", VA = "0xE1A860")]
		public void MutePlaylist()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xE1C8F8", Offset = "0xE1C8F8", VA = "0xE1C8F8")]
		public void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xE1CA70", Offset = "0xE1CA70", VA = "0xE1CA70")]
		public void PausePlaylist()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xE1CC80", Offset = "0xE1CC80", VA = "0xE1CC80")]
		public bool UnpausePlaylist()
		{
			return default(bool);
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xE1ACC8", Offset = "0xE1ACC8", VA = "0xE1ACC8")]
		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xE1D308", Offset = "0xE1D308", VA = "0xE1D308")]
		public void FadeToVolume(float targetVolume, float fadeTime, [Optional] Action callback)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xE1D44C", Offset = "0xE1D44C", VA = "0xE1D44C")]
		public void PlayRandomSong()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xE1D4E0", Offset = "0xE1D4E0", VA = "0xE1D4E0")]
		public void PlayARandomSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xE1D6DC", Offset = "0xE1D6DC", VA = "0xE1D6DC")]
		private void RemoveRandomClip(int randIndex)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xE1DF3C", Offset = "0xE1DF3C", VA = "0xE1DF3C")]
		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xE1E078", Offset = "0xE1E078", VA = "0xE1E078")]
		public void PlayNextSong()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xE1E10C", Offset = "0xE1E10C", VA = "0xE1E10C")]
		public void PlayTheNextSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xE1E2B8", Offset = "0xE1E2B8", VA = "0xE1E2B8")]
		private void AdvanceSongCounter()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xE1E32C", Offset = "0xE1E32C", VA = "0xE1E32C")]
		public void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xE1E528", Offset = "0xE1E528", VA = "0xE1E528")]
		public void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xE1E6DC", Offset = "0xE1E6DC", VA = "0xE1E6DC")]
		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xE1EA84", Offset = "0xE1EA84", VA = "0xE1EA84")]
		public bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xE1EDA0", Offset = "0xE1EDA0", VA = "0xE1EDA0")]
		public void DuckMusicForTime(float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xE1EF24", Offset = "0xE1EF24", VA = "0xE1EF24")]
		private void InitControllerIfNot()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xE1AB98", Offset = "0xE1AB98", VA = "0xE1AB98")]
		public void UpdateMasterVolume()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xE1EFC0", Offset = "0xE1EFC0", VA = "0xE1EFC0")]
		public void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xE1F12C", Offset = "0xE1F12C", VA = "0xE1F12C")]
		public void ChangePlaylist(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xE1D078", Offset = "0xE1D078", VA = "0xE1D078")]
		private void FinishPlaylistInit(bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xE1F098", Offset = "0xE1F098", VA = "0xE1F098")]
		public void RestartPlaylist()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xE1F284", Offset = "0xE1F284", VA = "0xE1F284")]
		private void CheckIfPlaylistStarted()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xE1F37C", Offset = "0xE1F37C", VA = "0xE1F37C")]
		private PlaylistController FindOtherControllerInSameSyncGroup()
		{
			return null;
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xE1C074", Offset = "0xE1C074", VA = "0xE1C074")]
		private void FadeOutPlaylist()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xE1A72C", Offset = "0xE1A72C", VA = "0xE1A72C")]
		private void InitializePlaylist()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xE1A890", Offset = "0xE1A890", VA = "0xE1A890")]
		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xE1BE44", Offset = "0xE1BE44", VA = "0xE1BE44")]
		private void FirePlaylistEndedEventIfAny()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xE1DD60", Offset = "0xE1DD60", VA = "0xE1DD60")]
		private void FillClips()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xE1D77C", Offset = "0xE1D77C", VA = "0xE1D77C")]
		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xE2008C", Offset = "0xE2008C", VA = "0xE2008C")]
		public double? ScheduledGaplessNextSongStartTime()
		{
			return null;
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xE1F5A8", Offset = "0xE1F5A8", VA = "0xE1F5A8")]
		public void FinishLoadingNewSong(MusicSetting songSetting, AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xE2035C", Offset = "0xE2035C", VA = "0xE2035C")]
		private void RemoveScheduledClip()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xE1E6D4", Offset = "0xE1E6D4", VA = "0xE1E6D4")]
		private void ScheduleNextSong()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xE1C17C", Offset = "0xE1C17C", VA = "0xE1C17C")]
		private void FadeInScheduledSong()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xE2014C", Offset = "0xE2014C", VA = "0xE2014C")]
		private double CalculateNextTrackStartTimeOffset()
		{
			return default(double);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xE20404", Offset = "0xE20404", VA = "0xE20404")]
		private double GetClipDuration(AudioSource src)
		{
			return default(double);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xE1D1D4", Offset = "0xE1D1D4", VA = "0xE1D1D4")]
		private void ScheduleClipPlay(double scheduledPlayTimeOffset, AudioSource source, bool calledAfterPause)
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xE20230", Offset = "0xE20230", VA = "0xE20230")]
		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xE1B900", Offset = "0xE1B900", VA = "0xE1B900")]
		private void CeaseAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xE1BCA0", Offset = "0xE1BCA0", VA = "0xE1BCA0")]
		private void SetDuckProperties()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xE1C184", Offset = "0xE1C184", VA = "0xE1C184")]
		private void AudioDucking()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xE1F46C", Offset = "0xE1F46C", VA = "0xE1F46C")]
		private bool SongShouldLoop(MusicSetting setting)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xE206D4", Offset = "0xE206D4", VA = "0xE206D4")]
		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xE207E0", Offset = "0xE207E0", VA = "0xE207E0")]
		public PlaylistController()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xE20A20", Offset = "0xE20A20", VA = "0xE20A20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523AF4", Offset = "0x523AF4")]
		private bool <FindOtherControllerInSameSyncGroup>b__143_0(PlaylistController obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xE20B14", Offset = "0xE20B14", VA = "0xE20B14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x523B04", Offset = "0x523B04")]
		private bool <FinishLoadingNewSong>b__151_0(MusicSetting obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200013C")]
	public static class SpatializerHelper
	{
		[Token(Token = "0x400074C")]
		private const string OculusSpatializer = "OculusSpatializer";

		[Token(Token = "0x400074D")]
		private const string ResonanceAudioSpatializer = "Resonance Audio";

		[Token(Token = "0x17000118")]
		public static bool IsSupportedSpatializer
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0xD9E600", Offset = "0xD9E600", VA = "0xD9E600")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000119")]
		public static bool IsOculusAudioSpatializer
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0xD9E69C", Offset = "0xD9E69C", VA = "0xD9E69C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011A")]
		public static bool IsResonanceAudioSpatializer
		{
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0xD9E6EC", Offset = "0xD9E6EC", VA = "0xD9E6EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011B")]
		public static string SelectedSpatializer
		{
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0xD9E694", Offset = "0xD9E694", VA = "0xD9E694")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011C")]
		public static bool SpatializerOptionExists
		{
			[Token(Token = "0x60006EC")]
			[Address(RVA = "0xD9E73C", Offset = "0xD9E73C", VA = "0xD9E73C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xD9E744", Offset = "0xD9E744", VA = "0xD9E744")]
		public static void TurnOnSpatializerIfEnabled(AudioSource source)
		{
		}
	}
	[Token(Token = "0x200013D")]
	public static class UtilStrings
	{
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xDA6AE8", Offset = "0xDA6AE8", VA = "0xDA6AE8")]
		public static string TrimSpace(string untrimmed)
		{
			return null;
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xDA6B64", Offset = "0xDA6B64", VA = "0xDA6B64")]
		public static string ReplaceUnsafeChars(string source)
		{
			return null;
		}
	}
}
namespace DarkTonic.MasterAudio.Examples
{
	[Token(Token = "0x200013E")]
	public class MA_Bootstrapper : MonoBehaviour
	{
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x6F41D8", Offset = "0x6F41D8", VA = "0x6F41D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x6F41DC", Offset = "0x6F41DC", VA = "0x6F41DC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x6F431C", Offset = "0x6F431C", VA = "0x6F431C")]
		public MA_Bootstrapper()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class MA_DestroyFinishedParticle : MonoBehaviour
	{
		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ParticleSystem particles;

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x6F4324", Offset = "0x6F4324", VA = "0x6F4324")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x6F4390", Offset = "0x6F4390", VA = "0x6F4390")]
		private void Update()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x6F442C", Offset = "0x6F442C", VA = "0x6F442C")]
		public MA_DestroyFinishedParticle()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class MA_EnemyOne : MonoBehaviour
	{
		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ExplosionParticlePrefab;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _speed;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _horizSpeed;

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x6F4434", Offset = "0x6F4434", VA = "0x6F4434")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x6F4528", Offset = "0x6F4528", VA = "0x6F4528")]
		private void Update()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x6F4664", Offset = "0x6F4664", VA = "0x6F4664")]
		public MA_EnemyOne()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class MA_EnemySpawner : MonoBehaviour
	{
		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Enemy;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool spawnerEnabled;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float nextSpawnTime;

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x6F466C", Offset = "0x6F466C", VA = "0x6F466C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x6F46E4", Offset = "0x6F46E4", VA = "0x6F46E4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x6F488C", Offset = "0x6F488C", VA = "0x6F488C")]
		public MA_EnemySpawner()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class MA_GameScene : MonoBehaviour
	{
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x6F4894", Offset = "0x6F4894", VA = "0x6F4894")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x6F4948", Offset = "0x6F4948", VA = "0x6F4948")]
		public MA_GameScene()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class MA_Laser : MonoBehaviour
	{
		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _trans;

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x6F4950", Offset = "0x6F4950", VA = "0x6F4950")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x6F49F4", Offset = "0x6F49F4", VA = "0x6F49F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x6F4ADC", Offset = "0x6F4ADC", VA = "0x6F4ADC")]
		public MA_Laser()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class MA_LocalizationUI : MonoBehaviour
	{
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x6F4AE4", Offset = "0x6F4AE4", VA = "0x6F4AE4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x6F4B98", Offset = "0x6F4B98", VA = "0x6F4B98")]
		public MA_LocalizationUI()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class MA_PlayerControl : MonoBehaviour
	{
		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ProjectilePrefab;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool canShoot;

		[Token(Token = "0x400075A")]
		private const float MoveSpeed = 10f;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _trans;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _lastMoveAmt;

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x6F4BA0", Offset = "0x6F4BA0", VA = "0x6F4BA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x6F4C44", Offset = "0x6F4C44", VA = "0x6F4C44")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x6F4C48", Offset = "0x6F4C48", VA = "0x6F4C48")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x6F4C4C", Offset = "0x6F4C4C", VA = "0x6F4C4C")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x6F4C50", Offset = "0x6F4C50", VA = "0x6F4C50")]
		private void Update()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x6F5D2C", Offset = "0x6F5D2C", VA = "0x6F5D2C")]
		public MA_PlayerControl()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public class MA_PlayerSpawnerControl : MonoBehaviour
	{
		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Player;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float nextSpawnTime;

		[Token(Token = "0x1700011D")]
		private bool PlayerActive
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x6F5D6C", Offset = "0x6F5D6C", VA = "0x6F5D6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x6F5D3C", Offset = "0x6F5D3C", VA = "0x6F5D3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x6F5D88", Offset = "0x6F5D88", VA = "0x6F5D88")]
		private void Update()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x6F5E0C", Offset = "0x6F5E0C", VA = "0x6F5E0C")]
		public MA_PlayerSpawnerControl()
		{
		}
	}
	[Token(Token = "0x2000147")]
	public class MA_SampleICustomEventReceiver : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<string> _eventsSubscribedTo;

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x6F5E14", Offset = "0x6F5E14", VA = "0x6F5E14")]
		private void Awake()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x6F5E18", Offset = "0x6F5E18", VA = "0x6F5E18")]
		private void Start()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x6F5F88", Offset = "0x6F5F88", VA = "0x6F5F88")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x6F6004", Offset = "0x6F6004", VA = "0x6F6004")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x6F5E1C", Offset = "0x6F5E1C", VA = "0x6F5E1C", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x6F64F4", Offset = "0x6F64F4", VA = "0x6F64F4", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x6F6640", Offset = "0x6F6640", VA = "0x6F6640", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x6F5F8C", Offset = "0x6F5F8C", VA = "0x6F5F8C", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x6F62E4", Offset = "0x6F62E4", VA = "0x6F62E4", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x6F7008", Offset = "0x6F7008", VA = "0x6F7008", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x6F7158", Offset = "0x6F7158", VA = "0x6F7158")]
		public MA_SampleICustomEventReceiver()
		{
		}
	}
	[Token(Token = "0x2000148")]
	public class MA_TestUI : MonoBehaviour
	{
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x6F7248", Offset = "0x6F7248", VA = "0x6F7248")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x6F72FC", Offset = "0x6F72FC", VA = "0x6F72FC")]
		public MA_TestUI()
		{
		}
	}
}
