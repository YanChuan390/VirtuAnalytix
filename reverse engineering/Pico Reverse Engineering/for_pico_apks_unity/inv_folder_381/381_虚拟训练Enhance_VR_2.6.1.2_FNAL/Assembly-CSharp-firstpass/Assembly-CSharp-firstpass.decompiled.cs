using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Array2DEditor;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using Photon.Chat;
using Photon.Realtime;
using SRDebugger.Internal;
using SRDebugger.Scripts;
using SRDebugger.Services;
using SRDebugger.UI;
using SRDebugger.UI.Controls;
using SRDebugger.UI.Controls.Data;
using SRDebugger.UI.Other;
using SRF;
using SRF.Components;
using SRF.Helpers;
using SRF.Service;
using SRF.UI;
using SRF.UI.Layout;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class ExampleScript : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Array2DBool array2DBool;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject prefabToInstantiate;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1245058", Offset = "0x1245058", VA = "0x1245058")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x12454C8", Offset = "0x12454C8", VA = "0x12454C8")]
	public ExampleScript()
	{
	}
}
[Token(Token = "0x2000003")]
public class DynamicBoneDemo1 : MonoBehaviour
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject m_Player;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_weight;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1242D94", Offset = "0x1242D94", VA = "0x1242D94")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1242F3C", Offset = "0x1242F3C", VA = "0x1242F3C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x12432C4", Offset = "0x12432C4", VA = "0x12432C4")]
	public DynamicBoneDemo1()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD512B8", Offset = "0xD512B8")]
public class DynamicBone : MonoBehaviour
{
	[Token(Token = "0x2000147")]
	public enum UpdateMode
	{
		[Token(Token = "0x4000664")]
		Normal,
		[Token(Token = "0x4000665")]
		AnimatePhysics,
		[Token(Token = "0x4000666")]
		UnscaledTime,
		[Token(Token = "0x4000667")]
		Default
	}

	[Token(Token = "0x2000148")]
	public enum FreezeAxis
	{
		[Token(Token = "0x4000669")]
		None,
		[Token(Token = "0x400066A")]
		X,
		[Token(Token = "0x400066B")]
		Y,
		[Token(Token = "0x400066C")]
		Z
	}

	[Token(Token = "0x2000149")]
	private class Particle
	{
		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform m_Transform;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_ParentIndex;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_ChildCount;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m_Damping;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m_Elasticity;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_Stiffness;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_Inert;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_Friction;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float m_Radius;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m_BoneLength;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool m_isCollide;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool m_TransformNotNull;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 m_Position;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 m_PrevPosition;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 m_EndOffset;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 m_InitLocalPosition;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Quaternion m_InitLocalRotation;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 m_TransformPosition;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Vector3 m_TransformLocalPosition;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Matrix4x4 m_TransformLocalToWorldMatrix;

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x123F48C", Offset = "0x123F48C", VA = "0x123F48C")]
		public Particle()
		{
		}
	}

	[Token(Token = "0x200014A")]
	private class ParticleTree
	{
		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform m_Root;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 m_LocalGravity;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Matrix4x4 m_RootWorldToLocalMatrix;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float m_BoneTotalLength;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<Particle> m_Particles;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 m_RestGravity;

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x123F41C", Offset = "0x123F41C", VA = "0x123F41C")]
		public ParticleTree()
		{
		}
	}

	[Token(Token = "0x200014B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5376C", Offset = "0xD5376C")]
	private sealed class <>c__DisplayClass69_0
	{
		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x123ED3C", Offset = "0x123ED3C", VA = "0x123ED3C")]
		public <>c__DisplayClass69_0()
		{
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x12411D0", Offset = "0x12411D0", VA = "0x12411D0")]
		internal bool <SetupParticles>b__0(ParticleTree x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53B0C", Offset = "0xD53B0C")]
	public Transform m_Root;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Transform> m_Roots;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53B44", Offset = "0xD53B44")]
	public float m_UpdateRate;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UpdateMode m_UpdateMode;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53B7C", Offset = "0xD53B7C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD53B7C", Offset = "0xD53B7C")]
	public float m_Damping;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AnimationCurve m_DampingDistrib;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53BD0", Offset = "0xD53BD0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD53BD0", Offset = "0xD53BD0")]
	public float m_Elasticity;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AnimationCurve m_ElasticityDistrib;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53C24", Offset = "0xD53C24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD53C24", Offset = "0xD53C24")]
	public float m_Stiffness;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AnimationCurve m_StiffnessDistrib;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53C78", Offset = "0xD53C78")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD53C78", Offset = "0xD53C78")]
	public float m_Inert;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AnimationCurve m_InertDistrib;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53CCC", Offset = "0xD53CCC")]
	public float m_Friction;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AnimationCurve m_FrictionDistrib;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53D04", Offset = "0xD53D04")]
	public float m_Radius;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public AnimationCurve m_RadiusDistrib;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53D3C", Offset = "0xD53D3C")]
	public float m_EndLength;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53D74", Offset = "0xD53D74")]
	public Vector3 m_EndOffset;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53DAC", Offset = "0xD53DAC")]
	public Vector3 m_Gravity;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53DE4", Offset = "0xD53DE4")]
	public Vector3 m_Force;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53E1C", Offset = "0xD53E1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD53E1C", Offset = "0xD53E1C")]
	public float m_BlendWeight;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53E70", Offset = "0xD53E70")]
	public List<DynamicBoneColliderBase> m_Colliders;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53EA8", Offset = "0xD53EA8")]
	public List<Transform> m_Exclusions;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53EE0", Offset = "0xD53EE0")]
	public FreezeAxis m_FreezeAxis;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53F18", Offset = "0xD53F18")]
	public bool m_DistantDisable;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform m_ReferenceObject;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public float m_DistanceToObject;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	[HideInInspector]
	public bool m_Multithread;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Vector3 m_ObjectMove;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private Vector3 m_ObjectPrevPosition;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private float m_ObjectScale;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private float m_Time;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float m_Weight;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private bool m_DistantDisabled;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private int m_PreUpdateCount;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private List<ParticleTree> m_ParticleTrees;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private float m_DeltaTime;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private List<DynamicBoneColliderBase> m_EffectiveColliders;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private bool m_WorkAdded;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<DynamicBone> s_PendingWorks;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<DynamicBone> s_EffectiveWorks;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static AutoResetEvent s_AllWorksDoneEvent;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int s_RemainWorkCount;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Semaphore s_WorkQueueSemaphore;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int s_WorkQueueIndex;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static int s_UpdateCount;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int s_PrepareFrame;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x123D044", Offset = "0x123D044", VA = "0x123D044")]
	private void Start()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x123D304", Offset = "0x123D304", VA = "0x123D304")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x123D364", Offset = "0x123D364", VA = "0x123D364")]
	private void Update()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x123D4B4", Offset = "0x123D4B4", VA = "0x123D4B4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x123DC38", Offset = "0x123DC38", VA = "0x123DC38")]
	private void Prepare()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x123DC04", Offset = "0x123DC04", VA = "0x123DC04")]
	private bool IsNeedUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x123D318", Offset = "0x123D318", VA = "0x123D318")]
	private void PreUpdate()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x123D9F8", Offset = "0x123D9F8", VA = "0x123D9F8")]
	private void CheckDistance()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x123E394", Offset = "0x123E394", VA = "0x123E394")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x123E398", Offset = "0x123E398", VA = "0x123E398")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x123E39C", Offset = "0x123E39C", VA = "0x123E39C")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x123E4EC", Offset = "0x123E4EC", VA = "0x123E4EC")]
	private bool IsRootChanged()
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x123E848", Offset = "0x123E848", VA = "0x123E848")]
	private void OnDidApplyAnimationProperties()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x123E84C", Offset = "0x123E84C", VA = "0x123E84C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x123E940", Offset = "0x123E940", VA = "0x123E940")]
	private void DrawGizmos(ParticleTree pt)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x123D5E0", Offset = "0x123D5E0", VA = "0x123D5E0")]
	public void SetWeight(float w)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x123EA50", Offset = "0x123EA50", VA = "0x123EA50")]
	public float GetWeight()
	{
		return default(float);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x123E04C", Offset = "0x123E04C", VA = "0x123E04C")]
	private void UpdateParticles()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x123D048", Offset = "0x123D048", VA = "0x123D048")]
	public void SetupParticles()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x123EC48", Offset = "0x123EC48", VA = "0x123EC48")]
	private void AppendParticleTree(Transform root)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x123ED44", Offset = "0x123ED44", VA = "0x123ED44")]
	private void AppendParticles(ParticleTree pt, Transform b, int parentIndex, float boneLength)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x123E7A4", Offset = "0x123E7A4", VA = "0x123E7A4")]
	public void UpdateParameters()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x123F494", Offset = "0x123F494", VA = "0x123F494")]
	private void UpdateParameters(ParticleTree pt)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x123E24C", Offset = "0x123E24C", VA = "0x123E24C")]
	private void InitTransforms()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x123F824", Offset = "0x123F824", VA = "0x123F824")]
	private void InitTransforms(ParticleTree pt)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x123E2E0", Offset = "0x123E2E0", VA = "0x123E2E0")]
	private void ResetParticlesPosition()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x123F8F0", Offset = "0x123F8F0", VA = "0x123F8F0")]
	private void ResetParticlesPosition(ParticleTree pt)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x123EA58", Offset = "0x123EA58", VA = "0x123EA58")]
	private void UpdateParticles1(float timeVar, int loopIndex)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x123FA00", Offset = "0x123FA00", VA = "0x123FA00")]
	private void UpdateParticles1(ParticleTree pt, float timeVar, int loopIndex)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x123EB08", Offset = "0x123EB08", VA = "0x123EB08")]
	private void UpdateParticles2(float timeVar)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x123FD7C", Offset = "0x123FD7C", VA = "0x123FD7C")]
	private void UpdateParticles2(ParticleTree pt, float timeVar)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x123EBB0", Offset = "0x123EBB0", VA = "0x123EBB0")]
	private void SkipUpdateParticles()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x124048C", Offset = "0x124048C", VA = "0x124048C")]
	private void SkipUpdateParticles(ParticleTree pt)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x12409B4", Offset = "0x12409B4", VA = "0x12409B4")]
	private static Vector3 MirrorVector(Vector3 v, Vector3 axis)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x123E16C", Offset = "0x123E16C", VA = "0x123E16C")]
	private void ApplyParticlesToTransforms()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1240A94", Offset = "0x1240A94", VA = "0x1240A94")]
	private void ApplyParticlesToTransforms(ParticleTree pt, Vector3 ax, Vector3 ay, Vector3 az, bool nx, bool ny, bool nz)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x123D430", Offset = "0x123D430", VA = "0x123D430")]
	private static void AddPendingWork(DynamicBone db)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1240CEC", Offset = "0x1240CEC", VA = "0x1240CEC")]
	private static void AddWorkToQueue(DynamicBone db)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1240D60", Offset = "0x1240D60", VA = "0x1240D60")]
	private static DynamicBone GetWorkFromQueue()
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1240E08", Offset = "0x1240E08", VA = "0x1240E08")]
	private static void ThreadProc()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1240ED4", Offset = "0x1240ED4", VA = "0x1240ED4")]
	private static void InitThreadPool()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x123D640", Offset = "0x123D640", VA = "0x123D640")]
	private static void ExecuteWorks()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1241038", Offset = "0x1241038", VA = "0x1241038")]
	public DynamicBone()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD512F0", Offset = "0xD512F0")]
public class DynamicBoneCollider : DynamicBoneColliderBase
{
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53F60", Offset = "0xD53F60")]
	public float m_Radius;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53F98", Offset = "0xD53F98")]
	public float m_Height;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD53FD0", Offset = "0xD53FD0")]
	public float m_Radius2;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float m_ScaledRadius;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float m_ScaledRadius2;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 m_C0;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 m_C1;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float m_C01Distance;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int m_CollideType;

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1241258", Offset = "0x1241258", VA = "0x1241258")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1241308", Offset = "0x1241308", VA = "0x1241308", Slot = "5")]
	public override void Prepare()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x124172C", Offset = "0x124172C", VA = "0x124172C", Slot = "6")]
	public override bool Collide(ref Vector3 particlePosition, float particleRadius)
	{
		return default(bool);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x124183C", Offset = "0x124183C", VA = "0x124183C")]
	private static bool OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
		return default(bool);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x12419D8", Offset = "0x12419D8", VA = "0x12419D8")]
	private static bool InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
		return default(bool);
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1241B88", Offset = "0x1241B88", VA = "0x1241B88")]
	private static bool OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius, float dirlen)
	{
		return default(bool);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1241F34", Offset = "0x1241F34", VA = "0x1241F34")]
	private static bool InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius, float dirlen)
	{
		return default(bool);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x12422EC", Offset = "0x12422EC", VA = "0x12422EC")]
	private static bool OutsideCapsule2(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius0, float capsuleRadius1, float dirlen)
	{
		return default(bool);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1242748", Offset = "0x1242748", VA = "0x1242748")]
	private static bool InsideCapsule2(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius0, float capsuleRadius1, float dirlen)
	{
		return default(bool);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1242B94", Offset = "0x1242B94", VA = "0x1242B94")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1242C64", Offset = "0x1242C64", VA = "0x1242C64")]
	private static void DrawCapsule(Vector3 c0, Vector3 c1, float radius0, float radius1)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1242CE8", Offset = "0x1242CE8", VA = "0x1242CE8")]
	public DynamicBoneCollider()
	{
	}
}
[Token(Token = "0x2000006")]
public class DynamicBoneColliderBase : MonoBehaviour
{
	[Token(Token = "0x200014C")]
	public enum Direction
	{
		[Token(Token = "0x4000689")]
		X,
		[Token(Token = "0x400068A")]
		Y,
		[Token(Token = "0x400068B")]
		Z
	}

	[Token(Token = "0x200014D")]
	public enum Bound
	{
		[Token(Token = "0x400068D")]
		Outside,
		[Token(Token = "0x400068E")]
		Inside
	}

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD54008", Offset = "0xD54008")]
	public Direction m_Direction;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD54040", Offset = "0xD54040")]
	public Vector3 m_Center;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD54078", Offset = "0xD54078")]
	public Bound m_Bound;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD540B0", Offset = "0xD540B0")]
	private int <PrepareFrame>k__BackingField;

	[Token(Token = "0x17000001")]
	public int PrepareFrame
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1242D7C", Offset = "0x1242D7C", VA = "0x1242D7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD56A6C", Offset = "0xD56A6C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1242D74", Offset = "0x1242D74", VA = "0x1242D74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD56A5C", Offset = "0xD56A5C")]
		set
		{
		}
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1242D84", Offset = "0x1242D84", VA = "0x1242D84", Slot = "4")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1242D88", Offset = "0x1242D88", VA = "0x1242D88", Slot = "5")]
	public virtual void Prepare()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1242D8C", Offset = "0x1242D8C", VA = "0x1242D8C", Slot = "6")]
	public virtual bool Collide(ref Vector3 particlePosition, float particleRadius)
	{
		return default(bool);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1242CF4", Offset = "0x1242CF4", VA = "0x1242CF4")]
	public DynamicBoneColliderBase()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51328", Offset = "0xD51328")]
public class DynamicBonePlaneCollider : DynamicBoneColliderBase
{
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Plane m_Plane;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x12432D4", Offset = "0x12432D4", VA = "0x12432D4")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x12432D8", Offset = "0x12432D8", VA = "0x12432D8", Slot = "5")]
	public override void Prepare()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1243408", Offset = "0x1243408", VA = "0x1243408", Slot = "6")]
	public override bool Collide(ref Vector3 particlePosition, float particleRadius)
	{
		return default(bool);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1243530", Offset = "0x1243530", VA = "0x1243530")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1243688", Offset = "0x1243688", VA = "0x1243688")]
	public DynamicBonePlaneCollider()
	{
	}
}
[Token(Token = "0x2000008")]
public static class AppSettingsExtensions
{
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1239188", Offset = "0x1239188", VA = "0x1239188")]
	public static ChatAppSettings GetChatSettings(this AppSettings appSettings)
	{
		return null;
	}
}
[Token(Token = "0x2000009")]
public class ChannelSelector : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string Channel;

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1239728", Offset = "0x1239728", VA = "0x1239728")]
	public void SetChannel(string channel)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x12397A4", Offset = "0x12397A4", VA = "0x12397A4", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1239A48", Offset = "0x1239A48", VA = "0x1239A48")]
	public ChannelSelector()
	{
	}
}
[Token(Token = "0x200000A")]
[ExecuteInEditMode]
public class ChatAppIdCheckerUI : MonoBehaviour
{
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text Description;

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1239A50", Offset = "0x1239A50", VA = "0x1239A50")]
	public void Update()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1239B94", Offset = "0x1239B94", VA = "0x1239B94")]
	public ChatAppIdCheckerUI()
	{
	}
}
[Token(Token = "0x200000B")]
public class ChatGui : MonoBehaviour, IChatClientListener
{
	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string[] ChannelsToJoinOnConnect;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] FriendsList;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int HistoryLengthToFetch;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD540C0", Offset = "0xD540C0")]
	private string <UserName>k__BackingField;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string selectedChannelName;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ChatClient chatClient;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected internal ChatAppSettings chatAppSettings;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject missingAppIdErrorPanel;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject ConnectingLabel;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RectTransform ChatPanel;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject UserIdFormPanel;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public InputField InputFieldChat;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Text CurrentChannelText;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Toggle ChannelToggleToInstantiate;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject FriendListUiItemtoInstantiate;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly Dictionary<string, Toggle> channelToggles;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly Dictionary<string, FriendItem> friendListItemLUT;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool ShowState;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject Title;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Text StateText;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Text UserIdText;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string HelpText;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public int TestLength;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private byte[] testBytes;

	[Token(Token = "0x17000002")]
	public string UserName
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1239B9C", Offset = "0x1239B9C", VA = "0x1239B9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD56A8C", Offset = "0xD56A8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1239BA4", Offset = "0x1239BA4", VA = "0x1239BA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD56A9C", Offset = "0xD56A9C")]
		set
		{
		}
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1239BAC", Offset = "0x1239BAC", VA = "0x1239BAC")]
	public void Start()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1239E38", Offset = "0x1239E38", VA = "0x1239E38")]
	public void Connect()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1239F98", Offset = "0x1239F98", VA = "0x1239F98")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1239FB0", Offset = "0x1239FB0", VA = "0x1239FB0")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1239FC8", Offset = "0x1239FC8", VA = "0x1239FC8")]
	public void Update()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x123A0BC", Offset = "0x123A0BC", VA = "0x123A0BC")]
	public void OnEnterSend()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x123AA14", Offset = "0x123AA14", VA = "0x123AA14")]
	public void OnClickSend()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x123A158", Offset = "0x123A158", VA = "0x123A158")]
	private void SendChatMessage(string inputLine)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x123AAC8", Offset = "0x123AAC8", VA = "0x123AAC8")]
	public void PostHelpToCurrentChannel()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x123AB84", Offset = "0x123AB84", VA = "0x123AB84", Slot = "4")]
	public void DebugReturn(DebugLevel level, string message)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x123AC6C", Offset = "0x123AC6C", VA = "0x123AC6C", Slot = "6")]
	public void OnConnected()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x123AFB8", Offset = "0x123AFB8", VA = "0x123AFB8", Slot = "5")]
	public void OnDisconnected()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x123AFD8", Offset = "0x123AFD8", VA = "0x123AFD8", Slot = "7")]
	public void OnChatStateChange(ChatState state)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x123B084", Offset = "0x123B084", VA = "0x123B084", Slot = "10")]
	public void OnSubscribed(string[] channels, bool[] results)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x123B394", Offset = "0x123B394", VA = "0x123B394")]
	public void OnSubscribed(string channel, string[] users, Dictionary<object, object> properties)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x123B208", Offset = "0x123B208", VA = "0x123B208")]
	private void InstantiateChannelButton(string channelName)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x123AE74", Offset = "0x123AE74", VA = "0x123AE74")]
	private void InstantiateFriendButton(string friendId)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x123B548", Offset = "0x123B548", VA = "0x123B548", Slot = "11")]
	public void OnUnsubscribed(string[] channels)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x123B918", Offset = "0x123B918", VA = "0x123B918", Slot = "8")]
	public void OnGetMessages(string channelName, string[] senders, object[] messages)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x123B968", Offset = "0x123B968", VA = "0x123B968", Slot = "9")]
	public void OnPrivateMessage(string sender, object message, string channelName)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x123BA78", Offset = "0x123BA78", VA = "0x123BA78", Slot = "12")]
	public void OnStatusUpdate(string user, int status, bool gotMessage, object message)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x123BD28", Offset = "0x123BD28", VA = "0x123BD28", Slot = "13")]
	public void OnUserSubscribed(string channel, string user)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x123BE2C", Offset = "0x123BE2C", VA = "0x123BE2C", Slot = "14")]
	public void OnUserUnsubscribed(string channel, string user)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x123BF30", Offset = "0x123BF30", VA = "0x123BF30")]
	public void OnChannelPropertiesChanged(string channel, string userId, Dictionary<object, object> properties)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x123C090", Offset = "0x123C090", VA = "0x123C090")]
	public void OnUserPropertiesChanged(string channel, string targetUserId, string senderUserId, Dictionary<object, object> properties)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x123C224", Offset = "0x123C224", VA = "0x123C224")]
	public void OnErrorInfo(string channel, string error, object data)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x123C354", Offset = "0x123C354", VA = "0x123C354")]
	public void AddMessageToSelectedChannel(string msg)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1239820", Offset = "0x1239820", VA = "0x1239820")]
	public void ShowChannel(string channelName)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x123C438", Offset = "0x123C438", VA = "0x123C438")]
	public void OpenDashboard()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x123C484", Offset = "0x123C484", VA = "0x123C484")]
	public ChatGui()
	{
	}
}
[Token(Token = "0x200000C")]
public class FriendItem : MonoBehaviour
{
	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text NameLabel;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text StatusLabel;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text Health;

	[Token(Token = "0x17000003")]
	[HideInInspector]
	public string FriendId
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1245594", Offset = "0x1245594", VA = "0x1245594")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x123B524", Offset = "0x123B524", VA = "0x123B524")]
		set
		{
		}
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x12455B8", Offset = "0x12455B8", VA = "0x12455B8")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x123BC00", Offset = "0x123BC00", VA = "0x123BC00")]
	public void OnFriendStatusUpdate(int status, bool gotMessage, object message)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1245624", Offset = "0x1245624", VA = "0x1245624")]
	public FriendItem()
	{
	}
}
[Token(Token = "0x200000D")]
public class IgnoreUiRaycastWhenInactive : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x124562C", Offset = "0x124562C", VA = "0x124562C", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1245650", Offset = "0x1245650", VA = "0x1245650")]
	public IgnoreUiRaycastWhenInactive()
	{
	}
}
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD51380", Offset = "0xD51380")]
public class NamePickGui : MonoBehaviour
{
	[Token(Token = "0x400005F")]
	private const string UserNamePlayerPref = "NamePickUserName";

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ChatGui chatNewComponent;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public InputField idInput;

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1245660", Offset = "0x1245660", VA = "0x1245660")]
	public void Start()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1245718", Offset = "0x1245718", VA = "0x1245718")]
	public void EndEditOnEnter()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1245764", Offset = "0x1245764", VA = "0x1245764")]
	public void StartChat()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1245828", Offset = "0x1245828", VA = "0x1245828")]
	public NamePickGui()
	{
	}
}
[Token(Token = "0x200000F")]
public class iTween : MonoBehaviour
{
	[Token(Token = "0x200014E")]
	private delegate float EasingFunction(float start, float end, float Value);

	[Token(Token = "0x200014F")]
	private delegate void ApplyTween();

	[Token(Token = "0x2000150")]
	public enum EaseType
	{
		[Token(Token = "0x4000690")]
		easeInQuad,
		[Token(Token = "0x4000691")]
		easeOutQuad,
		[Token(Token = "0x4000692")]
		easeInOutQuad,
		[Token(Token = "0x4000693")]
		easeInCubic,
		[Token(Token = "0x4000694")]
		easeOutCubic,
		[Token(Token = "0x4000695")]
		easeInOutCubic,
		[Token(Token = "0x4000696")]
		easeInQuart,
		[Token(Token = "0x4000697")]
		easeOutQuart,
		[Token(Token = "0x4000698")]
		easeInOutQuart,
		[Token(Token = "0x4000699")]
		easeInQuint,
		[Token(Token = "0x400069A")]
		easeOutQuint,
		[Token(Token = "0x400069B")]
		easeInOutQuint,
		[Token(Token = "0x400069C")]
		easeInSine,
		[Token(Token = "0x400069D")]
		easeOutSine,
		[Token(Token = "0x400069E")]
		easeInOutSine,
		[Token(Token = "0x400069F")]
		easeInExpo,
		[Token(Token = "0x40006A0")]
		easeOutExpo,
		[Token(Token = "0x40006A1")]
		easeInOutExpo,
		[Token(Token = "0x40006A2")]
		easeInCirc,
		[Token(Token = "0x40006A3")]
		easeOutCirc,
		[Token(Token = "0x40006A4")]
		easeInOutCirc,
		[Token(Token = "0x40006A5")]
		linear,
		[Token(Token = "0x40006A6")]
		spring,
		[Token(Token = "0x40006A7")]
		easeInBounce,
		[Token(Token = "0x40006A8")]
		easeOutBounce,
		[Token(Token = "0x40006A9")]
		easeInOutBounce,
		[Token(Token = "0x40006AA")]
		easeInBack,
		[Token(Token = "0x40006AB")]
		easeOutBack,
		[Token(Token = "0x40006AC")]
		easeInOutBack,
		[Token(Token = "0x40006AD")]
		easeInElastic,
		[Token(Token = "0x40006AE")]
		easeOutElastic,
		[Token(Token = "0x40006AF")]
		easeInOutElastic,
		[Token(Token = "0x40006B0")]
		punch
	}

	[Token(Token = "0x2000151")]
	public enum LoopType
	{
		[Token(Token = "0x40006B2")]
		none,
		[Token(Token = "0x40006B3")]
		loop,
		[Token(Token = "0x40006B4")]
		pingPong
	}

	[Token(Token = "0x2000152")]
	public enum NamedValueColor
	{
		[Token(Token = "0x40006B6")]
		_Color,
		[Token(Token = "0x40006B7")]
		_SpecColor,
		[Token(Token = "0x40006B8")]
		_Emission,
		[Token(Token = "0x40006B9")]
		_ReflectColor
	}

	[Token(Token = "0x2000153")]
	public static class Defaults
	{
		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float time;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float delay;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static LoopType loopType;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static EaseType easeType;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float lookSpeed;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isLocal;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Space space;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool orientToPath;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static Color color;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static float updateTimePercentage;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static float updateTime;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static float lookAhead;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static bool useRealTime;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static Vector3 up;
	}

	[Token(Token = "0x2000154")]
	private class CRSpline
	{
		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] pts;

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x2512848", Offset = "0x2512848", VA = "0x2512848")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x25128D0", Offset = "0x25128D0", VA = "0x25128D0")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000155")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5377C", Offset = "0xD5377C")]
	private sealed class <TweenDelay>d__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x1700020D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x2512408", Offset = "0x2512408", VA = "0x2512408", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B27")]
			[Address(RVA = "0x2512470", Offset = "0x2512470", VA = "0x2512470", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x2512304", Offset = "0x2512304", VA = "0x2512304")]
		[DebuggerHidden]
		public <TweenDelay>d__145(int <>1__state)
		{
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x2512330", Offset = "0x2512330", VA = "0x2512330", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x2512334", Offset = "0x2512334", VA = "0x2512334", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x2512410", Offset = "0x2512410", VA = "0x2512410", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000156")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5378C", Offset = "0xD5378C")]
	private sealed class <TweenRestart>d__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x1700020F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x2512584", Offset = "0x2512584", VA = "0x2512584", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000210")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0x25125EC", Offset = "0x25125EC", VA = "0x25125EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x2512478", Offset = "0x2512478", VA = "0x2512478")]
		[DebuggerHidden]
		public <TweenRestart>d__147(int <>1__state)
		{
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x25124A4", Offset = "0x25124A4", VA = "0x25124A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x25124A8", Offset = "0x25124A8", VA = "0x25124A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x251258C", Offset = "0x251258C", VA = "0x251258C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5379C", Offset = "0xD5379C")]
	private sealed class <Start>d__229 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000211")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B31")]
			[Address(RVA = "0x2512294", Offset = "0x2512294", VA = "0x2512294", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000212")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x25122FC", Offset = "0x25122FC", VA = "0x25122FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x25121B8", Offset = "0x25121B8", VA = "0x25121B8")]
		[DebuggerHidden]
		public <Start>d__229(int <>1__state)
		{
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x25121E4", Offset = "0x25121E4", VA = "0x25121E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x25121E8", Offset = "0x25121E8", VA = "0x25121E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x251229C", Offset = "0x251229C", VA = "0x251229C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<System.Collections.Hashtable> tweens;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string type;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string method;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public EaseType easeType;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float time;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float delay;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public LoopType loopType;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isRunning;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool isPaused;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string _name;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float runningTime;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float percentage;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float delayStarted;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool kinematic;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	private bool isLocal;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
	private bool loop;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
	private bool reverse;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool wasPaused;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool physics;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private System.Collections.Hashtable tweenArguments;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Space space;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private EasingFunction ease;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ApplyTween apply;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AudioSource audioSource;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3[] vector3s;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector2[] vector2s;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Color[,] colors;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float[] floats;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Rect[] rects;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private CRSpline path;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector3 preUpdate;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Vector3 postUpdate;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private NamedValueColor namedcolorvalue;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float lastRealTime;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool useRealTime;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Transform thisTransform;

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2118A64", Offset = "0x2118A64", VA = "0x2118A64")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2118CE8", Offset = "0x2118CE8", VA = "0x2118CE8")]
	public static void ValueTo(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2119CB8", Offset = "0x2119CB8", VA = "0x2119CB8")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x2119F98", Offset = "0x2119F98", VA = "0x2119F98")]
	public static void FadeFrom(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x211A9EC", Offset = "0x211A9EC", VA = "0x211A9EC")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x211AB9C", Offset = "0x211AB9C", VA = "0x211AB9C")]
	public static void FadeTo(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x211B0FC", Offset = "0x211B0FC", VA = "0x211B0FC")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x211A00C", Offset = "0x211A00C", VA = "0x211A00C")]
	public static void ColorFrom(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x211B2D8", Offset = "0x211B2D8", VA = "0x211B2D8")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x211AC10", Offset = "0x211AC10", VA = "0x211AC10")]
	public static void ColorTo(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x211B4B4", Offset = "0x211B4B4", VA = "0x211B4B4")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x211B6E0", Offset = "0x211B6E0", VA = "0x211B6E0")]
	public static void AudioFrom(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x211BAE8", Offset = "0x211BAE8", VA = "0x211BAE8")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x211BD14", Offset = "0x211BD14", VA = "0x211BD14")]
	public static void AudioTo(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x211BE70", Offset = "0x211BE70", VA = "0x211BE70")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x211C004", Offset = "0x211C004", VA = "0x211C004")]
	public static void Stab(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x211C0B4", Offset = "0x211C0B4", VA = "0x211C0B4")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x211C280", Offset = "0x211C280", VA = "0x211C280")]
	public static void LookFrom(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x211C8E0", Offset = "0x211C8E0", VA = "0x211C8E0")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x211CAAC", Offset = "0x211CAAC", VA = "0x211CAAC")]
	public static void LookTo(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x211CDCC", Offset = "0x211CDCC", VA = "0x211CDCC")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x211CF98", Offset = "0x211CF98", VA = "0x211CF98")]
	public static void MoveTo(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x211D338", Offset = "0x211D338", VA = "0x211D338")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x211D504", Offset = "0x211D504", VA = "0x211D504")]
	public static void MoveFrom(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x211DE04", Offset = "0x211DE04", VA = "0x211DE04")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x211DFD0", Offset = "0x211DFD0", VA = "0x211DFD0")]
	public static void MoveAdd(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x2118B1C", Offset = "0x2118B1C", VA = "0x2118B1C")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x211E0AC", Offset = "0x211E0AC", VA = "0x211E0AC")]
	public static void MoveBy(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x211E188", Offset = "0x211E188", VA = "0x211E188")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x211E354", Offset = "0x211E354", VA = "0x211E354")]
	public static void ScaleTo(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x211E6EC", Offset = "0x211E6EC", VA = "0x211E6EC")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x211E8B8", Offset = "0x211E8B8", VA = "0x211E8B8")]
	public static void ScaleFrom(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x211ED64", Offset = "0x211ED64", VA = "0x211ED64")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x211EF30", Offset = "0x211EF30", VA = "0x211EF30")]
	public static void ScaleAdd(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x211F00C", Offset = "0x211F00C", VA = "0x211F00C")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x211F1D8", Offset = "0x211F1D8", VA = "0x211F1D8")]
	public static void ScaleBy(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x211F2B4", Offset = "0x211F2B4", VA = "0x211F2B4")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x211F480", Offset = "0x211F480", VA = "0x211F480")]
	public static void RotateTo(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x211F820", Offset = "0x211F820", VA = "0x211F820")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x211F9EC", Offset = "0x211F9EC", VA = "0x211F9EC")]
	public static void RotateFrom(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x211FF50", Offset = "0x211FF50", VA = "0x211FF50")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x212011C", Offset = "0x212011C", VA = "0x212011C")]
	public static void RotateAdd(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x21201F8", Offset = "0x21201F8", VA = "0x21201F8")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x21203C4", Offset = "0x21203C4", VA = "0x21203C4")]
	public static void RotateBy(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x21204A0", Offset = "0x21204A0", VA = "0x21204A0")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x212066C", Offset = "0x212066C", VA = "0x212066C")]
	public static void ShakePosition(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x2120748", Offset = "0x2120748", VA = "0x2120748")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x2120914", Offset = "0x2120914", VA = "0x2120914")]
	public static void ShakeScale(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x21209F0", Offset = "0x21209F0", VA = "0x21209F0")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x2120BBC", Offset = "0x2120BBC", VA = "0x2120BBC")]
	public static void ShakeRotation(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x2120C98", Offset = "0x2120C98", VA = "0x2120C98")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x2120E64", Offset = "0x2120E64", VA = "0x2120E64")]
	public static void PunchPosition(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x2120F84", Offset = "0x2120F84", VA = "0x2120F84")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x2121150", Offset = "0x2121150", VA = "0x2121150")]
	public static void PunchRotation(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x2121270", Offset = "0x2121270", VA = "0x2121270")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x212143C", Offset = "0x212143C", VA = "0x212143C")]
	public static void PunchScale(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x212155C", Offset = "0x212155C", VA = "0x212155C")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x21225DC", Offset = "0x21225DC", VA = "0x21225DC")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x2122470", Offset = "0x2122470", VA = "0x2122470")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x2122210", Offset = "0x2122210", VA = "0x2122210")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x2121F7C", Offset = "0x2121F7C", VA = "0x2121F7C")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2121D88", Offset = "0x2121D88", VA = "0x2121D88")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x2122718", Offset = "0x2122718", VA = "0x2122718")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x2123070", Offset = "0x2123070", VA = "0x2123070")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x2127E14", Offset = "0x2127E14", VA = "0x2127E14")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x21275E8", Offset = "0x21275E8", VA = "0x21275E8")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x212337C", Offset = "0x212337C", VA = "0x212337C")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x2123AAC", Offset = "0x2123AAC", VA = "0x2123AAC")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x21240F8", Offset = "0x21240F8", VA = "0x21240F8")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x21246F4", Offset = "0x21246F4", VA = "0x21246F4")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x2124C44", Offset = "0x2124C44", VA = "0x2124C44")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x2125098", Offset = "0x2125098", VA = "0x2125098")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x21254E0", Offset = "0x21254E0", VA = "0x21254E0")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x2125B10", Offset = "0x2125B10", VA = "0x2125B10")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x2125F60", Offset = "0x2125F60", VA = "0x2125F60")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x212641C", Offset = "0x212641C", VA = "0x212641C")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x2126710", Offset = "0x2126710", VA = "0x2126710")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x21269D8", Offset = "0x21269D8", VA = "0x21269D8")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x2126CA0", Offset = "0x2126CA0", VA = "0x2126CA0")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x2126FD8", Offset = "0x2126FD8", VA = "0x2126FD8")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x21272E4", Offset = "0x21272E4", VA = "0x21272E4")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x2128518", Offset = "0x2128518", VA = "0x2128518")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x2128818", Offset = "0x2128818", VA = "0x2128818")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x2128A48", Offset = "0x2128A48", VA = "0x2128A48")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x2128C3C", Offset = "0x2128C3C", VA = "0x2128C3C")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x2128DDC", Offset = "0x2128DDC", VA = "0x2128DDC")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x2128F34", Offset = "0x2128F34", VA = "0x2128F34")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x2129494", Offset = "0x2129494", VA = "0x2129494")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x2129600", Offset = "0x2129600", VA = "0x2129600")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x2129604", Offset = "0x2129604", VA = "0x2129604")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x2129964", Offset = "0x2129964", VA = "0x2129964")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x2129B70", Offset = "0x2129B70", VA = "0x2129B70")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x2129EB0", Offset = "0x2129EB0", VA = "0x2129EB0")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x212A018", Offset = "0x212A018", VA = "0x212A018")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x212A1F0", Offset = "0x212A1F0", VA = "0x212A1F0")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x212A520", Offset = "0x212A520", VA = "0x212A520")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x212A7B4", Offset = "0x212A7B4", VA = "0x212A7B4")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x212ABCC", Offset = "0x212ABCC", VA = "0x212ABCC")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x212ADE0", Offset = "0x212ADE0", VA = "0x212ADE0")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x212B050", Offset = "0x212B050", VA = "0x212B050")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x212B504", Offset = "0x212B504", VA = "0x212B504")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x212B84C", Offset = "0x212B84C", VA = "0x212B84C")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x212BAAC", Offset = "0x212BAAC", VA = "0x212BAAC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD56AAC", Offset = "0xD56AAC")]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x212BB1C", Offset = "0x212BB1C", VA = "0x212BB1C")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x212C4B0", Offset = "0x212C4B0", VA = "0x212C4B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD56B10", Offset = "0xD56B10")]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x212C520", Offset = "0x212C520", VA = "0x212C520")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x212C604", Offset = "0x212C604", VA = "0x212C604")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x212C6D4", Offset = "0x212C6D4", VA = "0x212C6D4")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x212C778", Offset = "0x212C778", VA = "0x212C778")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x212C940", Offset = "0x212C940", VA = "0x212C940")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x212CA4C", Offset = "0x212CA4C", VA = "0x212CA4C")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x212C900", Offset = "0x212C900", VA = "0x212C900")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x212CB30", Offset = "0x212CB30", VA = "0x212CB30")]
	public static void FadeUpdate(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x212D5AC", Offset = "0x212D5AC", VA = "0x212D5AC")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x212CBF0", Offset = "0x212CBF0", VA = "0x212CBF0")]
	public static void ColorUpdate(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x212D75C", Offset = "0x212D75C", VA = "0x212D75C")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x212D938", Offset = "0x212D938", VA = "0x212D938")]
	public static void AudioUpdate(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x212DDE8", Offset = "0x212DDE8", VA = "0x212DDE8")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x212E014", Offset = "0x212E014", VA = "0x212E014")]
	public static void RotateUpdate(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x212E63C", Offset = "0x212E63C", VA = "0x212E63C")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x212E808", Offset = "0x212E808", VA = "0x212E808")]
	public static void ScaleUpdate(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x212EDF0", Offset = "0x212EDF0", VA = "0x212EDF0")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x212EFBC", Offset = "0x212EFBC", VA = "0x212EFBC")]
	public static void MoveUpdate(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x213012C", Offset = "0x213012C", VA = "0x213012C")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x212F820", Offset = "0x212F820", VA = "0x212F820")]
	public static void LookUpdate(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x21302F8", Offset = "0x21302F8", VA = "0x21302F8")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x21304C4", Offset = "0x21304C4", VA = "0x21304C4")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x21283A0", Offset = "0x21283A0", VA = "0x21283A0")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x2130DA8", Offset = "0x2130DA8", VA = "0x2130DA8")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x2130E58", Offset = "0x2130E58", VA = "0x2130E58")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x2130EF0", Offset = "0x2130EF0", VA = "0x2130EF0")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x2131028", Offset = "0x2131028", VA = "0x2131028")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x2131148", Offset = "0x2131148", VA = "0x2131148")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x2131254", Offset = "0x2131254", VA = "0x2131254")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x21314B8", Offset = "0x21314B8", VA = "0x21314B8")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x213157C", Offset = "0x213157C", VA = "0x213157C")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x21316F0", Offset = "0x21316F0", VA = "0x21316F0")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x2131844", Offset = "0x2131844", VA = "0x2131844")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x2131928", Offset = "0x2131928", VA = "0x2131928")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x21319EC", Offset = "0x21319EC", VA = "0x21319EC")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x2131B60", Offset = "0x2131B60", VA = "0x2131B60")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x2131CB4", Offset = "0x2131CB4", VA = "0x2131CB4")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x2131D98", Offset = "0x2131D98", VA = "0x2131D98")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x2131E5C", Offset = "0x2131E5C", VA = "0x2131E5C")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x2131FD0", Offset = "0x2131FD0", VA = "0x2131FD0")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x2132124", Offset = "0x2132124", VA = "0x2132124")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x213219C", Offset = "0x213219C", VA = "0x213219C")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x2132474", Offset = "0x2132474", VA = "0x2132474")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x2132538", Offset = "0x2132538", VA = "0x2132538")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x21326AC", Offset = "0x21326AC", VA = "0x21326AC")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x2132800", Offset = "0x2132800", VA = "0x2132800")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x21328E4", Offset = "0x21328E4", VA = "0x21328E4")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x21329A8", Offset = "0x21329A8", VA = "0x21329A8")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x2132B1C", Offset = "0x2132B1C", VA = "0x2132B1C")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x2132C70", Offset = "0x2132C70", VA = "0x2132C70")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x2132D54", Offset = "0x2132D54", VA = "0x2132D54")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x2132E18", Offset = "0x2132E18", VA = "0x2132E18")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x2132F8C", Offset = "0x2132F8C", VA = "0x2132F8C")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x21330E0", Offset = "0x21330E0", VA = "0x21330E0")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x21331D0", Offset = "0x21331D0", VA = "0x21331D0")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x213347C", Offset = "0x213347C", VA = "0x213347C")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x21335D4", Offset = "0x21335D4", VA = "0x21335D4")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x2133970", Offset = "0x2133970", VA = "0x2133970")]
	public static void Resume()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x2133A90", Offset = "0x2133A90", VA = "0x2133A90")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x2133CC0", Offset = "0x2133CC0", VA = "0x2133CC0")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x2133E0C", Offset = "0x2133E0C", VA = "0x2133E0C")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x21340B8", Offset = "0x21340B8", VA = "0x21340B8")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x2134264", Offset = "0x2134264", VA = "0x2134264")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x2134654", Offset = "0x2134654", VA = "0x2134654")]
	public static void Pause()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x2134774", Offset = "0x2134774", VA = "0x2134774")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x21349A4", Offset = "0x21349A4", VA = "0x21349A4")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x2134A18", Offset = "0x2134A18", VA = "0x2134A18")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x2134BF4", Offset = "0x2134BF4", VA = "0x2134BF4")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x2134C58", Offset = "0x2134C58", VA = "0x2134C58")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x2134DB4", Offset = "0x2134DB4", VA = "0x2134DB4")]
	public static void Stop()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x2134FEC", Offset = "0x2134FEC", VA = "0x2134FEC")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x213536C", Offset = "0x213536C", VA = "0x213536C")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x2134F04", Offset = "0x2134F04", VA = "0x2134F04")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x21356AC", Offset = "0x21356AC", VA = "0x21356AC")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x213521C", Offset = "0x213521C", VA = "0x213521C")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x213559C", Offset = "0x213559C", VA = "0x213559C")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x2135958", Offset = "0x2135958", VA = "0x2135958")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x2135CEC", Offset = "0x2135CEC", VA = "0x2135CEC")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x2119E68", Offset = "0x2119E68", VA = "0x2119E68")]
	public static System.Collections.Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x2136040", Offset = "0x2136040", VA = "0x2136040")]
	private iTween(System.Collections.Hashtable h)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x213606C", Offset = "0x213606C", VA = "0x213606C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x21370D8", Offset = "0x21370D8", VA = "0x21370D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD56B74", Offset = "0xD56B74")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x2137148", Offset = "0x2137148", VA = "0x2137148")]
	private void Update()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x2137188", Offset = "0x2137188", VA = "0x2137188")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x21371C8", Offset = "0x21371C8", VA = "0x21371C8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x21372DC", Offset = "0x21372DC", VA = "0x21372DC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x2137358", Offset = "0x2137358", VA = "0x2137358")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x2131338", Offset = "0x2131338", VA = "0x2131338")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x2132280", Offset = "0x2132280", VA = "0x2132280")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x21306B8", Offset = "0x21306B8", VA = "0x21306B8")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x213097C", Offset = "0x213097C", VA = "0x213097C")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x2119B64", Offset = "0x2119B64", VA = "0x2119B64")]
	private static void Launch(GameObject target, System.Collections.Hashtable args)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x21191C4", Offset = "0x21191C4", VA = "0x21191C4")]
	private static System.Collections.Hashtable CleanArgs(System.Collections.Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x213735C", Offset = "0x213735C", VA = "0x213735C")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x21360A8", Offset = "0x21360A8", VA = "0x21360A8")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x21373DC", Offset = "0x21373DC", VA = "0x21373DC")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x212C58C", Offset = "0x212C58C", VA = "0x212C58C")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x212BC94", Offset = "0x212BC94", VA = "0x212BC94")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x2128130", Offset = "0x2128130", VA = "0x2128130")]
	private void Dispose()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x212BF6C", Offset = "0x212BF6C", VA = "0x212BF6C")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x212C4AC", Offset = "0x212C4AC", VA = "0x212C4AC")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x212C774", Offset = "0x212C774", VA = "0x212C774")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x2137304", Offset = "0x2137304", VA = "0x2137304")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x21377D0", Offset = "0x21377D0", VA = "0x21377D0")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x21282CC", Offset = "0x21282CC", VA = "0x21282CC")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x2137858", Offset = "0x2137858", VA = "0x2137858")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x213795C", Offset = "0x213795C", VA = "0x213795C")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x2137970", Offset = "0x2137970", VA = "0x2137970")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x213798C", Offset = "0x213798C", VA = "0x213798C")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x21379E0", Offset = "0x21379E0", VA = "0x21379E0")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x21379F8", Offset = "0x21379F8", VA = "0x21379F8")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x2137A20", Offset = "0x2137A20", VA = "0x2137A20")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x2137A78", Offset = "0x2137A78", VA = "0x2137A78")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x2137A94", Offset = "0x2137A94", VA = "0x2137A94")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x2137ABC", Offset = "0x2137ABC", VA = "0x2137ABC")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x2137B18", Offset = "0x2137B18", VA = "0x2137B18")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x2137B38", Offset = "0x2137B38", VA = "0x2137B38")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x2137B68", Offset = "0x2137B68", VA = "0x2137B68")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x2137BD0", Offset = "0x2137BD0", VA = "0x2137BD0")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x2137C68", Offset = "0x2137C68", VA = "0x2137C68")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x2137CFC", Offset = "0x2137CFC", VA = "0x2137CFC")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x2137DA0", Offset = "0x2137DA0", VA = "0x2137DA0")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x2137E38", Offset = "0x2137E38", VA = "0x2137E38")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x2137ED0", Offset = "0x2137ED0", VA = "0x2137ED0")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x2137FC0", Offset = "0x2137FC0", VA = "0x2137FC0")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x213806C", Offset = "0x213806C", VA = "0x213806C")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x2138118", Offset = "0x2138118", VA = "0x2138118")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x2138210", Offset = "0x2138210", VA = "0x2138210")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x213824C", Offset = "0x213824C", VA = "0x213824C")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x2138318", Offset = "0x2138318", VA = "0x2138318")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x213839C", Offset = "0x213839C", VA = "0x213839C")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x21383CC", Offset = "0x21383CC", VA = "0x21383CC")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x213840C", Offset = "0x213840C", VA = "0x213840C")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x212B444", Offset = "0x212B444", VA = "0x212B444")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x2138490", Offset = "0x2138490", VA = "0x2138490")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x2138578", Offset = "0x2138578", VA = "0x2138578")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x213865C", Offset = "0x213865C", VA = "0x213865C")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
[Token(Token = "0x2000010")]
public static class SRDebug
{
	[Token(Token = "0x4000087")]
	public const string Version = "1.7.1";

	[Token(Token = "0x17000004")]
	public static IDebugService Instance
	{
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x10630CC", Offset = "0x10630CC", VA = "0x10630CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1063134", Offset = "0x1063134", VA = "0x1063134")]
	public static void Init()
	{
	}
}
[Token(Token = "0x2000011")]
public class SROptions
{
	[Token(Token = "0x2000158")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xD537AC", Offset = "0xD537AC")]
	public sealed class NumberRangeAttribute : Attribute
	{
		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly double Max;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly double Min;

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x16B8760", Offset = "0x16B8760", VA = "0x16B8760")]
		public NumberRangeAttribute(double min, double max)
		{
		}
	}

	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xD537C0", Offset = "0xD537C0")]
	public sealed class IncrementAttribute : Attribute
	{
		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly double Increment;

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x16B872C", Offset = "0x16B872C", VA = "0x16B872C")]
		public IncrementAttribute(double increment)
		{
		}
	}

	[Token(Token = "0x200015A")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xD537D4", Offset = "0xD537D4")]
	public sealed class SortAttribute : Attribute
	{
		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int SortPriority;

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x16B8798", Offset = "0x16B8798", VA = "0x16B8798")]
		public SortAttribute(int priority)
		{
		}
	}

	[Token(Token = "0x200015B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xD537E8", Offset = "0xD537E8")]
	public sealed class DisplayNameAttribute : Attribute
	{
		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Name;

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x16B8700", Offset = "0x16B8700", VA = "0x16B8700")]
		public DisplayNameAttribute(string name)
		{
		}
	}

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly SROptions _current;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int _instrumentIDToUnlock;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int _dayToday;

	[Token(Token = "0x17000005")]
	public static SROptions Current
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x16B80D0", Offset = "0x16B80D0", VA = "0x16B80D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000001")]
	public event SROptionsPropertyChanged PropertyChanged
	{
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x16B8138", Offset = "0x16B8138", VA = "0x16B8138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD56BD8", Offset = "0xD56BD8")]
		add
		{
		}
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x16B81DC", Offset = "0x16B81DC", VA = "0x16B81DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD56BE8", Offset = "0xD56BE8")]
		remove
		{
		}
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x16B8280", Offset = "0x16B8280", VA = "0x16B8280")]
	public void OnPropertyChanged(string propertyName)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x16B8684", Offset = "0x16B8684", VA = "0x16B8684")]
	public SROptions()
	{
	}
}
[Token(Token = "0x2000012")]
public delegate void SROptionsPropertyChanged(object sender, string propertyName);
[Token(Token = "0x2000013")]
public static class SRDebugUtil
{
	[Token(Token = "0x400008C")]
	public const int LineBufferCount = 512;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD540E0", Offset = "0xD540E0")]
	private static bool <IsFixedUpdate>k__BackingField;

	[Token(Token = "0x17000006")]
	public static bool IsFixedUpdate
	{
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1063310", Offset = "0x1063310", VA = "0x1063310")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD56BF8", Offset = "0xD56BF8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1063360", Offset = "0x1063360", VA = "0x1063360")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD56C08", Offset = "0xD56C08")]
		set
		{
		}
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x10633B8", Offset = "0x10633B8", VA = "0x10633B8")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void AssertNotNull(object value, [Optional] string message, [Optional] MonoBehaviour instance)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1063568", Offset = "0x1063568", VA = "0x1063568")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void Assert(bool condition, [Optional] string message, [Optional] MonoBehaviour instance)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x10636A8", Offset = "0x10636A8", VA = "0x10636A8")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xD56C88", Offset = "0xD56C88")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void EditorAssertNotNull(object value, [Optional] string message, [Optional] MonoBehaviour instance)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x10636AC", Offset = "0x10636AC", VA = "0x10636AC")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xD56CE4", Offset = "0xD56CE4")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void EditorAssert(bool condition, [Optional] string message, [Optional] MonoBehaviour instance)
	{
	}
}
[Token(Token = "0x2000014")]
public static class SRFileUtil
{
	[Token(Token = "0x6000180")]
	[Address(RVA = "0x16B5B6C", Offset = "0x16B5B6C", VA = "0x16B5B6C")]
	public static void DeleteDirectory(string path)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x16B5C4C", Offset = "0x16B5C4C", VA = "0x16B5C4C")]
	public static string GetBytesReadable(long i)
	{
		return null;
	}
}
[Token(Token = "0x2000015")]
public static class SRInstantiate
{
	[Token(Token = "0x6000182")]
	public static T Instantiate<T>(T prefab) where T : UnityEngine.Component
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x16B5DE8", Offset = "0x16B5DE8", VA = "0x16B5DE8")]
	public static GameObject Instantiate(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	public static T Instantiate<T>(T prefab, Vector3 position, Quaternion rotation) where T : UnityEngine.Component
	{
		return null;
	}
}
[Token(Token = "0x2000016")]
public static class SRMath
{
	[Token(Token = "0x200015C")]
	private static class TweenFunctions
	{
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x16B6588", Offset = "0x16B6588", VA = "0x16B6588")]
		public static float Linear(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x16B6670", Offset = "0x16B6670", VA = "0x16B6670")]
		public static float ExpoEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x16B6714", Offset = "0x16B6714", VA = "0x16B6714")]
		public static float ExpoEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x16B67BC", Offset = "0x16B67BC", VA = "0x16B67BC")]
		public static float ExpoEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x16B68D0", Offset = "0x16B68D0", VA = "0x16B68D0")]
		public static float ExpoEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x16B6C1C", Offset = "0x16B6C1C", VA = "0x16B6C1C")]
		public static float CircEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x16B6CCC", Offset = "0x16B6CCC", VA = "0x16B6CCC")]
		public static float CircEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x16B6D7C", Offset = "0x16B6D7C", VA = "0x16B6D7C")]
		public static float CircEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x16B6E78", Offset = "0x16B6E78", VA = "0x16B6E78")]
		public static float CircEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x16B6598", Offset = "0x16B6598", VA = "0x16B6598")]
		public static float QuadEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x16B65B4", Offset = "0x16B65B4", VA = "0x16B65B4")]
		public static float QuadEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x16B65C8", Offset = "0x16B65C8", VA = "0x16B65C8")]
		public static float QuadEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x16B661C", Offset = "0x16B661C", VA = "0x16B661C")]
		public static float QuadEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x16B6EA4", Offset = "0x16B6EA4", VA = "0x16B6EA4")]
		public static float SineEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x16B6F3C", Offset = "0x16B6F3C", VA = "0x16B6F3C")]
		public static float SineEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x16B6FD8", Offset = "0x16B6FD8", VA = "0x16B6FD8")]
		public static float SineEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x16B70DC", Offset = "0x16B70DC", VA = "0x16B70DC")]
		public static float SineEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x16B68FC", Offset = "0x16B68FC", VA = "0x16B68FC")]
		public static float CubicEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x16B6924", Offset = "0x16B6924", VA = "0x16B6924")]
		public static float CubicEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x16B693C", Offset = "0x16B693C", VA = "0x16B693C")]
		public static float CubicEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x16B6990", Offset = "0x16B6990", VA = "0x16B6990")]
		public static float CubicEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x16B69F0", Offset = "0x16B69F0", VA = "0x16B69F0")]
		public static float QuartEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x16B6A18", Offset = "0x16B6A18", VA = "0x16B6A18")]
		public static float QuartEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x16B6A34", Offset = "0x16B6A34", VA = "0x16B6A34")]
		public static float QuartEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x16B6A90", Offset = "0x16B6A90", VA = "0x16B6A90")]
		public static float QuartEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x16B6AF8", Offset = "0x16B6AF8", VA = "0x16B6AF8")]
		public static float QuintEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x16B6B28", Offset = "0x16B6B28", VA = "0x16B6B28")]
		public static float QuintEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x16B6B48", Offset = "0x16B6B48", VA = "0x16B6B48")]
		public static float QuintEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x16B6BAC", Offset = "0x16B6BAC", VA = "0x16B6BAC")]
		public static float QuintEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x16B7108", Offset = "0x16B7108", VA = "0x16B7108")]
		public static float ElasticEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x16B71FC", Offset = "0x16B71FC", VA = "0x16B71FC")]
		public static float ElasticEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x16B72F4", Offset = "0x16B72F4", VA = "0x16B72F4")]
		public static float ElasticEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x16B745C", Offset = "0x16B745C", VA = "0x16B745C")]
		public static float ElasticEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x16B7488", Offset = "0x16B7488", VA = "0x16B7488")]
		public static float BounceEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x16B7554", Offset = "0x16B7554", VA = "0x16B7554")]
		public static float BounceEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x16B7588", Offset = "0x16B7588", VA = "0x16B7588")]
		public static float BounceEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x16B7608", Offset = "0x16B7608", VA = "0x16B7608")]
		public static float BounceEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x16B7660", Offset = "0x16B7660", VA = "0x16B7660")]
		public static float BackEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x16B76A0", Offset = "0x16B76A0", VA = "0x16B76A0")]
		public static float BackEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x16B76D0", Offset = "0x16B76D0", VA = "0x16B76D0")]
		public static float BackEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x16B7750", Offset = "0x16B7750", VA = "0x16B7750")]
		public static float BackEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}
	}

	[Token(Token = "0x200015D")]
	public enum EaseType
	{
		[Token(Token = "0x40006D9")]
		Linear,
		[Token(Token = "0x40006DA")]
		QuadEaseOut,
		[Token(Token = "0x40006DB")]
		QuadEaseIn,
		[Token(Token = "0x40006DC")]
		QuadEaseInOut,
		[Token(Token = "0x40006DD")]
		QuadEaseOutIn,
		[Token(Token = "0x40006DE")]
		ExpoEaseOut,
		[Token(Token = "0x40006DF")]
		ExpoEaseIn,
		[Token(Token = "0x40006E0")]
		ExpoEaseInOut,
		[Token(Token = "0x40006E1")]
		ExpoEaseOutIn,
		[Token(Token = "0x40006E2")]
		CubicEaseOut,
		[Token(Token = "0x40006E3")]
		CubicEaseIn,
		[Token(Token = "0x40006E4")]
		CubicEaseInOut,
		[Token(Token = "0x40006E5")]
		CubicEaseOutIn,
		[Token(Token = "0x40006E6")]
		QuartEaseOut,
		[Token(Token = "0x40006E7")]
		QuartEaseIn,
		[Token(Token = "0x40006E8")]
		QuartEaseInOut,
		[Token(Token = "0x40006E9")]
		QuartEaseOutIn,
		[Token(Token = "0x40006EA")]
		QuintEaseOut,
		[Token(Token = "0x40006EB")]
		QuintEaseIn,
		[Token(Token = "0x40006EC")]
		QuintEaseInOut,
		[Token(Token = "0x40006ED")]
		QuintEaseOutIn,
		[Token(Token = "0x40006EE")]
		CircEaseOut,
		[Token(Token = "0x40006EF")]
		CircEaseIn,
		[Token(Token = "0x40006F0")]
		CircEaseInOut,
		[Token(Token = "0x40006F1")]
		CircEaseOutIn,
		[Token(Token = "0x40006F2")]
		SineEaseOut,
		[Token(Token = "0x40006F3")]
		SineEaseIn,
		[Token(Token = "0x40006F4")]
		SineEaseInOut,
		[Token(Token = "0x40006F5")]
		SineEaseOutIn,
		[Token(Token = "0x40006F6")]
		ElasticEaseOut,
		[Token(Token = "0x40006F7")]
		ElasticEaseIn,
		[Token(Token = "0x40006F8")]
		ElasticEaseInOut,
		[Token(Token = "0x40006F9")]
		ElasticEaseOutIn,
		[Token(Token = "0x40006FA")]
		BounceEaseOut,
		[Token(Token = "0x40006FB")]
		BounceEaseIn,
		[Token(Token = "0x40006FC")]
		BounceEaseInOut,
		[Token(Token = "0x40006FD")]
		BounceEaseOutIn,
		[Token(Token = "0x40006FE")]
		BackEaseOut,
		[Token(Token = "0x40006FF")]
		BackEaseIn,
		[Token(Token = "0x4000700")]
		BackEaseInOut,
		[Token(Token = "0x4000701")]
		BackEaseOutIn
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x16B5E58", Offset = "0x16B5E58", VA = "0x16B5E58")]
	public static float Ease(float from, float to, float t, EaseType type)
	{
		return default(float);
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x16B77E0", Offset = "0x16B77E0", VA = "0x16B77E0")]
	public static float SpringLerp(float strength, float deltaTime)
	{
		return default(float);
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x16B78CC", Offset = "0x16B78CC", VA = "0x16B78CC")]
	public static float SpringLerp(float from, float to, float strength, float deltaTime)
	{
		return default(float);
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x16B7968", Offset = "0x16B7968", VA = "0x16B7968")]
	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x16B7A34", Offset = "0x16B7A34", VA = "0x16B7A34")]
	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x16B7B08", Offset = "0x16B7B08", VA = "0x16B7B08")]
	public static float SmoothClamp(float value, float min, float max, float scrollMax, EaseType easeType = EaseType.ExpoEaseOut)
	{
		return default(float);
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x16B7C40", Offset = "0x16B7C40", VA = "0x16B7C40")]
	public static float LerpUnclamped(float from, float to, float t)
	{
		return default(float);
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x16B7C58", Offset = "0x16B7C58", VA = "0x16B7C58")]
	public static Vector3 LerpUnclamped(Vector3 from, Vector3 to, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x16B7CB8", Offset = "0x16B7CB8", VA = "0x16B7CB8")]
	public static float FacingNormalized(Vector3 dir1, Vector3 dir2)
	{
		return default(float);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x16B7DC4", Offset = "0x16B7DC4", VA = "0x16B7DC4")]
	public static float WrapAngle(float angle)
	{
		return default(float);
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x16B7E04", Offset = "0x16B7E04", VA = "0x16B7E04")]
	public static float NearestAngle(float to, float angle1, float angle2)
	{
		return default(float);
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x16B7EAC", Offset = "0x16B7EAC", VA = "0x16B7EAC")]
	public static int Wrap(int max, int value)
	{
		return default(int);
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x16B7F64", Offset = "0x16B7F64", VA = "0x16B7F64")]
	public static float Wrap(float max, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x16B7F8C", Offset = "0x16B7F8C", VA = "0x16B7F8C")]
	public static float Average(float v1, float v2)
	{
		return default(float);
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x16B7F9C", Offset = "0x16B7F9C", VA = "0x16B7F9C")]
	public static float Angle(Vector2 direction)
	{
		return default(float);
	}
}
[Token(Token = "0x2000017")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xD513E4", Offset = "0xD513E4")]
public sealed class InjectAttribute : Attribute
{
	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1245658", Offset = "0x1245658", VA = "0x1245658")]
	public InjectAttribute()
	{
	}
}
[Token(Token = "0x2000018")]
public static class DependencyInjector
{
	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly Dictionary<Type, object> components;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly object placeholder;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly Dictionary<Type, FieldInfo[]> cachedFields;

	[Token(Token = "0x4000091")]
	private const BindingFlags FIELD_FLAGS = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly List<FieldInfo> injectFieldsBuffer;

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x123C5A0", Offset = "0x123C5A0", VA = "0x123C5A0")]
	public static void InjectObject(object target)
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x123C6CC", Offset = "0x123C6CC", VA = "0x123C6CC")]
	private static FieldInfo[] GetFields(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x123CB48", Offset = "0x123CB48", VA = "0x123CB48")]
	public static void Inject(this MonoBehaviour target)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x123C958", Offset = "0x123C958", VA = "0x123C958")]
	private static FieldInfo[] GetInjectFields(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x123CBAC", Offset = "0x123CBAC", VA = "0x123CBAC")]
	private static bool HasInjectAttribute(MemberInfo member)
	{
		return default(bool);
	}

	[Token(Token = "0x600019A")]
	public static T Resolve<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x123C7B8", Offset = "0x123C7B8", VA = "0x123C7B8")]
	private static object Resolve(Type type)
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	public static void ReplaceComponent<T>(T newComponent)
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x123CD24", Offset = "0x123CD24", VA = "0x123CD24")]
	public static void ClearCache()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x123CC50", Offset = "0x123CC50", VA = "0x123CC50")]
	private static object CreateComponent(Type type)
	{
		return null;
	}
}
[Token(Token = "0x2000019")]
public class UITest
{
	[Token(Token = "0x200015E")]
	public class MB : MonoBehaviour
	{
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x16BA310", Offset = "0x16BA310", VA = "0x16BA310")]
		public MB()
		{
		}
	}

	[Token(Token = "0x200015F")]
	protected abstract class Condition
	{
		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string param;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string objectName;

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x16B9BB0", Offset = "0x16B9BB0", VA = "0x16B9BB0")]
		public Condition()
		{
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x16B9E44", Offset = "0x16B9E44", VA = "0x16B9E44")]
		public Condition(string param)
		{
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x16B9E70", Offset = "0x16B9E70", VA = "0x16B9E70")]
		public Condition(string objectName, string param)
		{
		}

		[Token(Token = "0x6000B65")]
		public abstract bool Satisfied();

		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x16B9EA8", Offset = "0x16B9EA8", VA = "0x16B9EA8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x2000160")]
	protected class LabelTextAppeared : Condition
	{
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x16B9110", Offset = "0x16B9110", VA = "0x16B9110")]
		public LabelTextAppeared(string objectName, string param)
		{
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x16B9FF8", Offset = "0x16B9FF8", VA = "0x16B9FF8", Slot = "4")]
		public override bool Satisfied()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x16BA014", Offset = "0x16BA014", VA = "0x16BA014")]
		private string GetErrorMessage()
		{
			return null;
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x16BA30C", Offset = "0x16BA30C", VA = "0x16BA30C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x2000161")]
	protected class SceneLoaded : Condition
	{
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x16B92A0", Offset = "0x16B92A0", VA = "0x16B92A0")]
		public SceneLoaded(string param)
		{
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x16BA570", Offset = "0x16BA570", VA = "0x16BA570", Slot = "4")]
		public override bool Satisfied()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000162")]
	protected class ObjectAnimationPlaying : Condition
	{
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x16BA318", Offset = "0x16BA318", VA = "0x16BA318")]
		public ObjectAnimationPlaying(string objectName, string param)
		{
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x16BA350", Offset = "0x16BA350", VA = "0x16BA350", Slot = "4")]
		public override bool Satisfied()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000163")]
	protected class ObjectAppeared<T> : Condition where T : UnityEngine.Component
	{
		[Token(Token = "0x6000B6F")]
		public override bool Satisfied()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B70")]
		public ObjectAppeared()
		{
		}
	}

	[Token(Token = "0x2000164")]
	protected class ObjectDisappeared<T> : Condition where T : UnityEngine.Component
	{
		[Token(Token = "0x6000B71")]
		public override bool Satisfied()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B72")]
		public ObjectDisappeared()
		{
		}
	}

	[Token(Token = "0x2000165")]
	protected class ObjectAppeared : Condition
	{
		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected string path;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject o;

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x16B942C", Offset = "0x16B942C", VA = "0x16B942C")]
		public ObjectAppeared(string path)
		{
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x16BA3C0", Offset = "0x16BA3C0", VA = "0x16BA3C0", Slot = "4")]
		public override bool Satisfied()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x16BA468", Offset = "0x16BA468", VA = "0x16BA468", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x2000166")]
	protected class ObjectDisappeared : ObjectAppeared
	{
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x16BA4C8", Offset = "0x16BA4C8", VA = "0x16BA4C8")]
		public ObjectDisappeared(string path)
		{
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x16BA4F4", Offset = "0x16BA4F4", VA = "0x16BA4F4", Slot = "4")]
		public override bool Satisfied()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x16BA510", Offset = "0x16BA510", VA = "0x16BA510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x2000167")]
	protected class BoolCondition : Condition
	{
		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Func<bool> _getter;

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x16B9B84", Offset = "0x16B9B84", VA = "0x16B9B84")]
		public BoolCondition(Func<bool> getter)
		{
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x16B9BB8", Offset = "0x16B9BB8", VA = "0x16B9BB8", Slot = "4")]
		public override bool Satisfied()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x16B9C18", Offset = "0x16B9C18", VA = "0x16B9C18", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x2000168")]
	protected class ButtonAccessible : Condition
	{
		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject button;

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x16B96C4", Offset = "0x16B96C4", VA = "0x16B96C4")]
		public ButtonAccessible(GameObject button)
		{
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x16B9C78", Offset = "0x16B9C78", VA = "0x16B9C78", Slot = "4")]
		public override bool Satisfied()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x16B9DB4", Offset = "0x16B9DB4", VA = "0x16B9DB4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x16B9C94", Offset = "0x16B9C94", VA = "0x16B9C94")]
		private string GetAccessibilityMessage()
		{
			return null;
		}
	}

	[Token(Token = "0x2000169")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD537FC", Offset = "0xD537FC")]
	private sealed class <LoadSceneInternal>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UITest <>4__this;

		[Token(Token = "0x17000213")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B83")]
			[Address(RVA = "0x16B92CC", Offset = "0x16B92CC", VA = "0x16B92CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000214")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B85")]
			[Address(RVA = "0x16B9334", Offset = "0x16B9334", VA = "0x16B9334", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x16B8B1C", Offset = "0x16B8B1C", VA = "0x16B8B1C")]
		[DebuggerHidden]
		public <LoadSceneInternal>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x16B91B8", Offset = "0x16B91B8", VA = "0x16B91B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x16B91BC", Offset = "0x16B91BC", VA = "0x16B91BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x16B92D4", Offset = "0x16B92D4", VA = "0x16B92D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200016A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5380C", Offset = "0xD5380C")]
	private sealed class <WaitForInternal>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Condition condition;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string stackTrace;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <time>5__2;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <i>5__3;

		[Token(Token = "0x17000215")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B89")]
			[Address(RVA = "0x16B994C", Offset = "0x16B994C", VA = "0x16B994C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000216")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0x16B99B4", Offset = "0x16B99B4", VA = "0x16B99B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x16B8F68", Offset = "0x16B8F68", VA = "0x16B8F68")]
		[DebuggerHidden]
		public <WaitForInternal>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x16B9760", Offset = "0x16B9760", VA = "0x16B9760", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x16B9764", Offset = "0x16B9764", VA = "0x16B9764", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x16B9954", Offset = "0x16B9954", VA = "0x16B9954", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200016B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5381C", Offset = "0xD5381C")]
	private sealed class <PressInternal>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string buttonName;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UITest <>4__this;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ObjectAppeared <buttonAppeared>5__2;

		[Token(Token = "0x17000217")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B8F")]
			[Address(RVA = "0x16B9458", Offset = "0x16B9458", VA = "0x16B9458", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000218")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B91")]
			[Address(RVA = "0x16B94C0", Offset = "0x16B94C0", VA = "0x16B94C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x16B8F94", Offset = "0x16B8F94", VA = "0x16B8F94")]
		[DebuggerHidden]
		public <PressInternal>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x16B933C", Offset = "0x16B933C", VA = "0x16B933C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x16B9340", Offset = "0x16B9340", VA = "0x16B9340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x16B9460", Offset = "0x16B9460", VA = "0x16B9460", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5382C", Offset = "0xD5382C")]
	private sealed class <PressInternal>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UITest <>4__this;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject o;

		[Token(Token = "0x17000219")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B95")]
			[Address(RVA = "0x16B96F0", Offset = "0x16B96F0", VA = "0x16B96F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B97")]
			[Address(RVA = "0x16B9758", Offset = "0x16B9758", VA = "0x16B9758", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x16B8FC0", Offset = "0x16B8FC0", VA = "0x16B8FC0")]
		[DebuggerHidden]
		public <PressInternal>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x16B94C8", Offset = "0x16B94C8", VA = "0x16B94C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x16B94CC", Offset = "0x16B94CC", VA = "0x16B94CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x16B96F8", Offset = "0x16B96F8", VA = "0x16B96F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200016D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5383C", Offset = "0xD5383C")]
	private sealed class <AssertLabelInternal>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UITest <>4__this;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string id;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string text;

		[Token(Token = "0x1700021B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0x16B9148", Offset = "0x16B9148", VA = "0x16B9148", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B9D")]
			[Address(RVA = "0x16B91B0", Offset = "0x16B91B0", VA = "0x16B91B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x16B8FEC", Offset = "0x16B8FEC", VA = "0x16B8FEC")]
		[DebuggerHidden]
		public <AssertLabelInternal>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x16B904C", Offset = "0x16B904C", VA = "0x16B904C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x16B9050", Offset = "0x16B9050", VA = "0x16B9050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x16B9150", Offset = "0x16B9150", VA = "0x16B9150", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200016E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5384C", Offset = "0xD5384C")]
	private sealed class <WriteTextInternal>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string inputName;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UITest <>4__this;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string text;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ObjectAppeared <inputAppeared>5__2;

		[Token(Token = "0x1700021D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000BA1")]
			[Address(RVA = "0x16B9B14", Offset = "0x16B9B14", VA = "0x16B9B14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0x16B9B7C", Offset = "0x16B9B7C", VA = "0x16B9B7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x16B9018", Offset = "0x16B9018", VA = "0x16B9018")]
		[DebuggerHidden]
		public <WriteTextInternal>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x16B99BC", Offset = "0x16B99BC", VA = "0x16B99BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x16B99C0", Offset = "0x16B99C0", VA = "0x16B99C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x16B9B1C", Offset = "0x16B9B1C", VA = "0x16B9B1C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000093")]
	private const float WaitTimeout = 10f;

	[Token(Token = "0x4000094")]
	private const float WaitIntervalFrames = 10f;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MonoBehaviour mb;

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x16B8810", Offset = "0x16B8810", VA = "0x16B8810")]
	protected void CreateMonoBehaviour()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x16B8920", Offset = "0x16B8920", VA = "0x16B8920")]
	protected Coroutine WaitFor(Condition condition)
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x16B8A1C", Offset = "0x16B8A1C", VA = "0x16B8A1C")]
	protected Coroutine LoadScene(string name)
	{
		return null;
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x16B8AA0", Offset = "0x16B8AA0", VA = "0x16B8AA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD56D50", Offset = "0xD56D50")]
	private IEnumerator LoadSceneInternal(string name)
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x16B8B48", Offset = "0x16B8B48", VA = "0x16B8B48")]
	protected Coroutine AssertLabel(string id, string text)
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x16B8C58", Offset = "0x16B8C58", VA = "0x16B8C58")]
	protected Coroutine Press(string buttonName)
	{
		return null;
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x16B8D58", Offset = "0x16B8D58", VA = "0x16B8D58")]
	protected Coroutine Press(GameObject o)
	{
		return null;
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x16B8E58", Offset = "0x16B8E58", VA = "0x16B8E58")]
	protected Coroutine WriteText(string inputName, string inputText)
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x16B89A0", Offset = "0x16B89A0", VA = "0x16B89A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD56DB4", Offset = "0xD56DB4")]
	private IEnumerator WaitForInternal(Condition condition, string stackTrace)
	{
		return null;
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x16B8CDC", Offset = "0x16B8CDC", VA = "0x16B8CDC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD56E18", Offset = "0xD56E18")]
	private IEnumerator PressInternal(string buttonName)
	{
		return null;
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x16B8DDC", Offset = "0x16B8DDC", VA = "0x16B8DDC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD56E7C", Offset = "0xD56E7C")]
	private IEnumerator PressInternal(GameObject o)
	{
		return null;
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x16B8BD4", Offset = "0x16B8BD4", VA = "0x16B8BD4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD56EE0", Offset = "0xD56EE0")]
	private IEnumerator AssertLabelInternal(string id, string text)
	{
		return null;
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x16B8EE4", Offset = "0x16B8EE4", VA = "0x16B8EE4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD56F44", Offset = "0xD56F44")]
	private IEnumerator WriteTextInternal(string inputName, string text)
	{
		return null;
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x16B9044", Offset = "0x16B9044", VA = "0x16B9044")]
	public UITest()
	{
	}
}
[Token(Token = "0x200001A")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x1238CC4", Offset = "0x1238CC4", VA = "0x1238CC4")]
	public void Start()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x1238E74", Offset = "0x1238E74", VA = "0x1238E74", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x1239180", Offset = "0x1239180", VA = "0x1239180")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x200001B")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1244F74", Offset = "0x1244F74", VA = "0x1244F74")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1245050", Offset = "0x1245050", VA = "0x1245050")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD51408", Offset = "0xD51408")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x12454D0", Offset = "0x12454D0", VA = "0x12454D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x124558C", Offset = "0x124558C", VA = "0x124558C")]
	public ForcedReset()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200001D")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x200016F")]
		public enum Mode
		{
			[Token(Token = "0x4000727")]
			Trigger,
			[Token(Token = "0x4000728")]
			Replace,
			[Token(Token = "0x4000729")]
			Activate,
			[Token(Token = "0x400072A")]
			Enable,
			[Token(Token = "0x400072B")]
			Animate,
			[Token(Token = "0x400072C")]
			Deactivate
		}

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object target;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x16C0920", Offset = "0x16C0920", VA = "0x16C0920")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x16C0D88", Offset = "0x16C0D88", VA = "0x16C0D88")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x16C0D8C", Offset = "0x16C0D8C", VA = "0x16C0D8C")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000170")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x6000BA4")]
			[Address(RVA = "0x16C170C", Offset = "0x16C170C", VA = "0x16C170C")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000171")]
		public class ReplacementList
		{
			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x6000BA5")]
			[Address(RVA = "0x16C1714", Offset = "0x16C1714", VA = "0x16C1714")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x16C0DA4", Offset = "0x16C0DA4", VA = "0x16C0DA4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x16C1704", Offset = "0x16C1704", VA = "0x16C1704")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000172")]
		public class Vector3andSpace
		{
			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0x16C18E4", Offset = "0x16C18E4", VA = "0x16C18E4")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x16C1774", Offset = "0x16C1774", VA = "0x16C1774")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x16C179C", Offset = "0x16C179C", VA = "0x16C179C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x16C18DC", Offset = "0x16C18DC", VA = "0x16C18DC")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class CameraRefocus
	{
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x16C18F4", Offset = "0x16C18F4", VA = "0x16C18F4")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x16C1954", Offset = "0x16C1954", VA = "0x16C1954")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x16C195C", Offset = "0x16C195C", VA = "0x16C195C")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x16C1964", Offset = "0x16C1964", VA = "0x16C1964")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x16C1AC4", Offset = "0x16C1AC4", VA = "0x16C1AC4")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000021")]
	public class CurveControlledBob
	{
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x16C1B18", Offset = "0x16C1B18", VA = "0x16C1B18")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x16C1BBC", Offset = "0x16C1BBC", VA = "0x16C1BBC")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x16C1CDC", Offset = "0x16C1CDC", VA = "0x16C1CDC")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x2000173")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5385C", Offset = "0xD5385C")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x1700021F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BAA")]
				[Address(RVA = "0x16C2628", Offset = "0x16C2628", VA = "0x16C2628", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000220")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BAC")]
				[Address(RVA = "0x16C2690", Offset = "0x16C2690", VA = "0x16C2690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BA7")]
			[Address(RVA = "0x16C23B0", Offset = "0x16C23B0", VA = "0x16C23B0")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0x16C23E4", Offset = "0x16C23E4", VA = "0x16C23E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BA9")]
			[Address(RVA = "0x16C23E8", Offset = "0x16C23E8", VA = "0x16C23E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BAB")]
			[Address(RVA = "0x16C2630", Offset = "0x16C2630", VA = "0x16C2630", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000AF")]
		private const float k_Spring = 50f;

		[Token(Token = "0x40000B0")]
		private const float k_Damper = 5f;

		[Token(Token = "0x40000B1")]
		private const float k_Drag = 10f;

		[Token(Token = "0x40000B2")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x40000B3")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x40000B4")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x16C1F1C", Offset = "0x16C1F1C", VA = "0x16C1F1C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x16C2330", Offset = "0x16C2330", VA = "0x16C2330")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD56FA8", Offset = "0xD56FA8")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x16C2280", Offset = "0x16C2280", VA = "0x16C2280")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x16C23DC", Offset = "0x16C23DC", VA = "0x16C23DC")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x16C2698", Offset = "0x16C2698", VA = "0x16C2698")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x16C26CC", Offset = "0x16C26CC", VA = "0x16C26CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x16C2940", Offset = "0x16C2940", VA = "0x16C2940")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	public class FOVKick
	{
		[Token(Token = "0x2000174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5386C", Offset = "0xD5386C")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000221")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BB0")]
				[Address(RVA = "0x16C2F3C", Offset = "0x16C2F3C", VA = "0x16C2F3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000222")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BB2")]
				[Address(RVA = "0x16C2FA4", Offset = "0x16C2FA4", VA = "0x16C2FA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BAD")]
			[Address(RVA = "0x16C2B0C", Offset = "0x16C2B0C", VA = "0x16C2B0C")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0x16C2DD8", Offset = "0x16C2DD8", VA = "0x16C2DD8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BAF")]
			[Address(RVA = "0x16C2DDC", Offset = "0x16C2DDC", VA = "0x16C2DDC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0x16C2F44", Offset = "0x16C2F44", VA = "0x16C2F44", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000175")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5387C", Offset = "0xD5387C")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000223")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BB6")]
				[Address(RVA = "0x16C2D68", Offset = "0x16C2D68", VA = "0x16C2D68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000224")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BB8")]
				[Address(RVA = "0x16C2DD0", Offset = "0x16C2DD0", VA = "0x16C2DD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BB3")]
			[Address(RVA = "0x16C2BA8", Offset = "0x16C2BA8", VA = "0x16C2BA8")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0x16C2BF0", Offset = "0x16C2BF0", VA = "0x16C2BF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0x16C2BF4", Offset = "0x16C2BF4", VA = "0x16C2BF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0x16C2D70", Offset = "0x16C2D70", VA = "0x16C2D70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x16C2974", Offset = "0x16C2974", VA = "0x16C2974")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x16C29B4", Offset = "0x16C29B4", VA = "0x16C29B4")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x16C2A94", Offset = "0x16C2A94", VA = "0x16C2A94")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x16C2A9C", Offset = "0x16C2A9C", VA = "0x16C2A9C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD5700C", Offset = "0xD5700C")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x16C2B38", Offset = "0x16C2B38", VA = "0x16C2B38")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD57070", Offset = "0xD57070")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x16C2BD4", Offset = "0x16C2BD4", VA = "0x16C2BD4")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD5146C", Offset = "0xD5146C")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x40000C7")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x40000CB")]
		private const string display = "{0} FPS";

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x16C2FAC", Offset = "0x16C2FAC", VA = "0x16C2FAC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x16C3018", Offset = "0x16C3018", VA = "0x16C3018")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x16C3114", Offset = "0x16C3114", VA = "0x16C3114")]
		public FPSCounter()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x16C311C", Offset = "0x16C311C", VA = "0x16C311C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x16C31FC", Offset = "0x16C31FC", VA = "0x16C31FC")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000176")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5388C", Offset = "0xD5388C")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000225")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BBC")]
				[Address(RVA = "0x16C34EC", Offset = "0x16C34EC", VA = "0x16C34EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000226")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BBE")]
				[Address(RVA = "0x16C3554", Offset = "0x16C3554", VA = "0x16C3554", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x16C32D4", Offset = "0x16C32D4", VA = "0x16C32D4")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0x16C3308", Offset = "0x16C3308", VA = "0x16C3308", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x16C330C", Offset = "0x16C330C", VA = "0x16C330C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x16C34F4", Offset = "0x16C34F4", VA = "0x16C34F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x16C325C", Offset = "0x16C325C", VA = "0x16C325C")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x16C3264", Offset = "0x16C3264", VA = "0x16C3264")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD570D4", Offset = "0xD570D4")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x16C3300", Offset = "0x16C3300", VA = "0x16C3300")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x2000177")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5389C", Offset = "0xD5389C")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x17000227")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BC2")]
				[Address(RVA = "0x16C3930", Offset = "0x16C3930", VA = "0x16C3930", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000228")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BC4")]
				[Address(RVA = "0x16C3998", Offset = "0x16C3998", VA = "0x16C3998", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x16C36C8", Offset = "0x16C36C8", VA = "0x16C36C8")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x16C36FC", Offset = "0x16C36FC", VA = "0x16C36FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0x16C3700", Offset = "0x16C3700", VA = "0x16C3700", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0x16C3938", Offset = "0x16C3938", VA = "0x16C3938", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x16C355C", Offset = "0x16C355C", VA = "0x16C355C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x16BFCE4", Offset = "0x16BFCE4", VA = "0x16BFCE4")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x16C3648", Offset = "0x16C3648", VA = "0x16C3648")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD57138", Offset = "0xD57138")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x16C36F4", Offset = "0x16C36F4", VA = "0x16C36F4")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x2000178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD538AC", Offset = "0xD538AC")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x17000229")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BC8")]
				[Address(RVA = "0x16C3D94", Offset = "0x16C3D94", VA = "0x16C3D94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700022A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BCA")]
				[Address(RVA = "0x16C3DFC", Offset = "0x16C3DFC", VA = "0x16C3DFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0x16C3A10", Offset = "0x16C3A10", VA = "0x16C3A10")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000BC6")]
			[Address(RVA = "0x16C3A5C", Offset = "0x16C3A5C", VA = "0x16C3A5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0x16C3A60", Offset = "0x16C3A60", VA = "0x16C3A60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x16C3D9C", Offset = "0x16C3D9C", VA = "0x16C3D9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x16C39A0", Offset = "0x16C39A0", VA = "0x16C39A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD5719C", Offset = "0xD5719C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x16C3A3C", Offset = "0x16C3A3C", VA = "0x16C3A3C")]
		public void Stop()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x16C3A48", Offset = "0x16C3A48", VA = "0x16C3A48")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000179")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x400074F")]
			Standalone,
			[Token(Token = "0x4000750")]
			Mobile
		}

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x16C3E04", Offset = "0x16C3E04", VA = "0x16C3E04")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x16C3E08", Offset = "0x16C3E08", VA = "0x16C3E08")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x16C3E24", Offset = "0x16C3E24", VA = "0x16C3E24")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x16C4180", Offset = "0x16C4180", VA = "0x16C4180")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text camSwitchButton;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] objects;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_CurrentActiveObject;

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x16C41F8", Offset = "0x16C41F8", VA = "0x16C41F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x16C4264", Offset = "0x16C4264", VA = "0x16C4264")]
		public void NextCamera()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x16C433C", Offset = "0x16C433C", VA = "0x16C433C")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x16C4344", Offset = "0x16C4344", VA = "0x16C4344")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x16C4380", Offset = "0x16C4380", VA = "0x16C4380")]
		private void Update()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x16C46F8", Offset = "0x16C46F8", VA = "0x16C46F8")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x16C47B8", Offset = "0x16C47B8", VA = "0x16C47B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x16C47BC", Offset = "0x16C47BC", VA = "0x16C47BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x16C4AE8", Offset = "0x16C4AE8", VA = "0x16C4AE8")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x200017A")]
		public enum Action
		{
			[Token(Token = "0x4000752")]
			Activate,
			[Token(Token = "0x4000753")]
			Deactivate,
			[Token(Token = "0x4000754")]
			Destroy,
			[Token(Token = "0x4000755")]
			ReloadLevel,
			[Token(Token = "0x4000756")]
			Call
		}

		[Serializable]
		[Token(Token = "0x200017B")]
		public class Entry
		{
			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x16C5250", Offset = "0x16C5250", VA = "0x16C5250")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200017C")]
		public class Entries
		{
			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x16C4E64", Offset = "0x16C4E64", VA = "0x16C4E64")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x200017D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD538BC", Offset = "0xD538BC")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700022B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BD0")]
				[Address(RVA = "0x16C4F38", Offset = "0x16C4F38", VA = "0x16C4F38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700022C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BD2")]
				[Address(RVA = "0x16C4FA0", Offset = "0x16C4FA0", VA = "0x16C4FA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x16C4D78", Offset = "0x16C4D78", VA = "0x16C4D78")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x16C4E6C", Offset = "0x16C4E6C", VA = "0x16C4E6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x16C4E70", Offset = "0x16C4E70", VA = "0x16C4E70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BD1")]
			[Address(RVA = "0x16C4F40", Offset = "0x16C4F40", VA = "0x16C4F40", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200017E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD538CC", Offset = "0xD538CC")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700022D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BD6")]
				[Address(RVA = "0x16C5074", Offset = "0x16C5074", VA = "0x16C5074", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700022E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BD8")]
				[Address(RVA = "0x16C50DC", Offset = "0x16C50DC", VA = "0x16C50DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0x16C4DA4", Offset = "0x16C4DA4", VA = "0x16C4DA4")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0x16C4FA8", Offset = "0x16C4FA8", VA = "0x16C4FA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0x16C4FAC", Offset = "0x16C4FAC", VA = "0x16C4FAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x16C507C", Offset = "0x16C507C", VA = "0x16C507C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200017F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD538DC", Offset = "0xD538DC")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700022F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BDC")]
				[Address(RVA = "0x16C51E0", Offset = "0x16C51E0", VA = "0x16C51E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000230")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BDE")]
				[Address(RVA = "0x16C5248", Offset = "0x16C5248", VA = "0x16C5248", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x16C4DD0", Offset = "0x16C4DD0", VA = "0x16C4DD0")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x16C50E4", Offset = "0x16C50E4", VA = "0x16C50E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x16C50E8", Offset = "0x16C50E8", VA = "0x16C50E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BDD")]
			[Address(RVA = "0x16C51E8", Offset = "0x16C51E8", VA = "0x16C51E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x16C4AFC", Offset = "0x16C4AFC", VA = "0x16C4AFC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x16C4C28", Offset = "0x16C4C28", VA = "0x16C4C28")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD57200", Offset = "0xD57200")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x16C4C98", Offset = "0x16C4C98", VA = "0x16C4C98")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD57264", Offset = "0xD57264")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x16C4D08", Offset = "0x16C4D08", VA = "0x16C4D08")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD572C8", Offset = "0xD572C8")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x16C4DFC", Offset = "0x16C4DFC", VA = "0x16C4DFC")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x16C5258", Offset = "0x16C5258", VA = "0x16C5258")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x16C52B0", Offset = "0x16C52B0", VA = "0x16C52B0")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x16C5350", Offset = "0x16C5350", VA = "0x16C5350")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000180")]
		public class WaypointList
		{
			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0x16C6190", Offset = "0x16C6190", VA = "0x16C6190")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x2000181")]
		public struct RoutePoint
		{
			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x16C5B1C", Offset = "0x16C5B1C", VA = "0x16C5B1C")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD541D0", Offset = "0xD541D0")]
		private float <Length>k__BackingField;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000007")]
		public float Length
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x16C5360", Offset = "0x16C5360", VA = "0x16C5360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5732C", Offset = "0xD5732C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x16C5368", Offset = "0x16C5368", VA = "0x16C5368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5733C", Offset = "0xD5733C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x16C5370", Offset = "0x16C5370", VA = "0x16C5370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x16C538C", Offset = "0x16C538C", VA = "0x16C538C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x16C56B4", Offset = "0x16C56B4", VA = "0x16C56B4")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x16C57C4", Offset = "0x16C57C4", VA = "0x16C57C4")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x16C5B2C", Offset = "0x16C5B2C", VA = "0x16C5B2C")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x16C53E8", Offset = "0x16C53E8", VA = "0x16C53E8")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x16C5E94", Offset = "0x16C5E94", VA = "0x16C5E94")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x16C6114", Offset = "0x16C6114", VA = "0x16C6114")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x16C5E9C", Offset = "0x16C5E9C", VA = "0x16C5E9C")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x16C611C", Offset = "0x16C611C", VA = "0x16C611C")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x2000182")]
		public enum ProgressStyle
		{
			[Token(Token = "0x4000769")]
			SmoothAlongRoute,
			[Token(Token = "0x400076A")]
			PointToPoint
		}

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD54250", Offset = "0xD54250")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD54260", Offset = "0xD54260")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD54270", Offset = "0xD54270")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000009")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x16C61F0", Offset = "0x16C61F0", VA = "0x16C61F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5734C", Offset = "0xD5734C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x16C6204", Offset = "0x16C6204", VA = "0x16C6204")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5735C", Offset = "0xD5735C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x16C6218", Offset = "0x16C6218", VA = "0x16C6218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5736C", Offset = "0xD5736C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x16C622C", Offset = "0x16C622C", VA = "0x16C622C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5737C", Offset = "0xD5737C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x16C6240", Offset = "0x16C6240", VA = "0x16C6240")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5738C", Offset = "0xD5738C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x16C6254", Offset = "0x16C6254", VA = "0x16C6254")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5739C", Offset = "0xD5739C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x16C6268", Offset = "0x16C6268", VA = "0x16C6268")]
		private void Start()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x16C634C", Offset = "0x16C634C", VA = "0x16C634C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x16C6424", Offset = "0x16C6424", VA = "0x16C6424")]
		private void Update()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x16C698C", Offset = "0x16C698C", VA = "0x16C698C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x16C6B64", Offset = "0x16C6B64", VA = "0x16C6B64")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD514D0", Offset = "0xD514D0")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x16BE178", Offset = "0x16BE178", VA = "0x16BE178")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x16BE210", Offset = "0x16BE210", VA = "0x16BE210")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x16BE6BC", Offset = "0x16BE6BC", VA = "0x16BE6BC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x16BEC00", Offset = "0x16BEC00", VA = "0x16BEC00")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000183")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD538EC", Offset = "0xD538EC")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x17000231")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BE4")]
				[Address(RVA = "0x16BF42C", Offset = "0x16BF42C", VA = "0x16BF42C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000232")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BE6")]
				[Address(RVA = "0x16BF494", Offset = "0x16BF494", VA = "0x16BF494", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x16BEC84", Offset = "0x16BEC84", VA = "0x16BEC84")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x16BEE3C", Offset = "0x16BEE3C", VA = "0x16BEE3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x16BEE40", Offset = "0x16BEE40", VA = "0x16BEE40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BE5")]
			[Address(RVA = "0x16BF434", Offset = "0x16BF434", VA = "0x16BF434", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x16BEC14", Offset = "0x16BEC14", VA = "0x16BEC14")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD573AC", Offset = "0xD573AC")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x16BECB0", Offset = "0x16BECB0", VA = "0x16BECB0")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x16BEE34", Offset = "0x16BEE34", VA = "0x16BEE34")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD538FC", Offset = "0xD538FC")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x17000233")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BEA")]
				[Address(RVA = "0x16BF850", Offset = "0x16BF850", VA = "0x16BF850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000234")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BEC")]
				[Address(RVA = "0x16BF8B8", Offset = "0x16BF8B8", VA = "0x16BF8B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BE7")]
			[Address(RVA = "0x16BF50C", Offset = "0x16BF50C", VA = "0x16BF50C")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0x16BF548", Offset = "0x16BF548", VA = "0x16BF548", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BE9")]
			[Address(RVA = "0x16BF54C", Offset = "0x16BF54C", VA = "0x16BF54C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x16BF858", Offset = "0x16BF858", VA = "0x16BF858", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x16BF49C", Offset = "0x16BF49C", VA = "0x16BF49C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD57410", Offset = "0xD57410")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x16BF538", Offset = "0x16BF538", VA = "0x16BF538")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x2000185")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5390C", Offset = "0xD5390C")]
		private sealed class <OnCollisionEnter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x17000235")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BF0")]
				[Address(RVA = "0x16BFD10", Offset = "0x16BFD10", VA = "0x16BFD10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000236")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BF2")]
				[Address(RVA = "0x16BFD78", Offset = "0x16BFD78", VA = "0x16BFD78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x16BF994", Offset = "0x16BF994", VA = "0x16BF994")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000BEE")]
			[Address(RVA = "0x16BF9EC", Offset = "0x16BF9EC", VA = "0x16BF9EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0x16BF9F0", Offset = "0x16BF9F0", VA = "0x16BF9F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0x16BFD18", Offset = "0x16BFD18", VA = "0x16BFD18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform explosionPrefab;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float detonationImpactVelocity;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool reset;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float resetTimeDelay;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Exploded;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x16BF8C0", Offset = "0x16BF8C0", VA = "0x16BF8C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x16BF918", Offset = "0x16BF918", VA = "0x16BF918")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD57474", Offset = "0xD57474")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x16BF9C0", Offset = "0x16BF9C0", VA = "0x16BF9C0")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x16BF9C8", Offset = "0x16BF9C8", VA = "0x16BF9C8")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x16BFD80", Offset = "0x16BFD80", VA = "0x16BFD80")]
		private void Start()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x16BFDD8", Offset = "0x16BFDD8", VA = "0x16BFDD8")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x16BFE64", Offset = "0x16BFE64", VA = "0x16BFE64")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x16BFE74", Offset = "0x16BFE74", VA = "0x16BFE74")]
		private void Start()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x16BFEE4", Offset = "0x16BFEE4", VA = "0x16BFEE4")]
		private void Update()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x16C0144", Offset = "0x16C0144", VA = "0x16C0144")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x16C016C", Offset = "0x16C016C", VA = "0x16C016C")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x16C017C", Offset = "0x16C017C", VA = "0x16C017C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x16C0340", Offset = "0x16C0340", VA = "0x16C0340")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x16C035C", Offset = "0x16C035C", VA = "0x16C035C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x16C04E8", Offset = "0x16C04E8", VA = "0x16C04E8")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x16C04F8", Offset = "0x16C04F8", VA = "0x16C04F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x16C05B8", Offset = "0x16C05B8", VA = "0x16C05B8")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x16C05C0", Offset = "0x16C05C0", VA = "0x16C05C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x16C0618", Offset = "0x16C0618", VA = "0x16C0618")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x16C08A8", Offset = "0x16C08A8", VA = "0x16C08A8")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200003C")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x16BA604", Offset = "0x16BA604", VA = "0x16BA604")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x16BA894", Offset = "0x16BA894", VA = "0x16BA894")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x16BAA14", Offset = "0x16BAA14", VA = "0x16BAA14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x16BAA94", Offset = "0x16BAA94", VA = "0x16BAA94", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x16BAB7C", Offset = "0x16BAB7C", VA = "0x16BAB7C", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x16BAC24", Offset = "0x16BAC24", VA = "0x16BAC24")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x16BAC90", Offset = "0x16BAC90", VA = "0x16BAC90")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x16BAC94", Offset = "0x16BAC94", VA = "0x16BAC94")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x16BAD7C", Offset = "0x16BAD7C", VA = "0x16BAD7C")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x16BAE64", Offset = "0x16BAE64", VA = "0x16BAE64")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x16BAF4C", Offset = "0x16BAF4C", VA = "0x16BAF4C")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x16BB034", Offset = "0x16BB034", VA = "0x16BB034")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x16BB11C", Offset = "0x16BB11C", VA = "0x16BB11C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x16BB120", Offset = "0x16BB120", VA = "0x16BB120")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x2000186")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x4000777")]
			Hardware,
			[Token(Token = "0x4000778")]
			Touch
		}

		[Token(Token = "0x2000187")]
		public class VirtualAxis
		{
			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5691C", Offset = "0xD5691C")]
			private string <name>k__BackingField;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5692C", Offset = "0xD5692C")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x17000237")]
			public string name
			{
				[Token(Token = "0x6000BF3")]
				[Address(RVA = "0x16BC070", Offset = "0x16BC070", VA = "0x16BC070")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD592DC", Offset = "0xD592DC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000BF4")]
				[Address(RVA = "0x16BC078", Offset = "0x16BC078", VA = "0x16BC078")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD592EC", Offset = "0xD592EC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000238")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000BF5")]
				[Address(RVA = "0x16BC080", Offset = "0x16BC080", VA = "0x16BC080")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD592FC", Offset = "0xD592FC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000BF6")]
				[Address(RVA = "0x16BC088", Offset = "0x16BC088", VA = "0x16BC088")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5930C", Offset = "0xD5930C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000239")]
			public float GetValue
			{
				[Token(Token = "0x6000BFB")]
				[Address(RVA = "0x16BC0DC", Offset = "0x16BC0DC", VA = "0x16BC0DC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700023A")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000BFC")]
				[Address(RVA = "0x16BC0E4", Offset = "0x16BC0E4", VA = "0x16BC0E4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0x16BA770", Offset = "0x16BA770", VA = "0x16BA770")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x16BC094", Offset = "0x16BC094", VA = "0x16BC094")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0x16BAA2C", Offset = "0x16BAA2C", VA = "0x16BAA2C")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0x16BC0D4", Offset = "0x16BC0D4", VA = "0x16BC0D4")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000188")]
		public class VirtualButton
		{
			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5693C", Offset = "0xD5693C")]
			private string <name>k__BackingField;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5694C", Offset = "0xD5694C")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x1700023B")]
			public string name
			{
				[Token(Token = "0x6000BFD")]
				[Address(RVA = "0x16BC0EC", Offset = "0x16BC0EC", VA = "0x16BC0EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5931C", Offset = "0xD5931C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000BFE")]
				[Address(RVA = "0x16BC0F4", Offset = "0x16BC0F4", VA = "0x16BC0F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5932C", Offset = "0xD5932C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700023C")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000BFF")]
				[Address(RVA = "0x16BC0FC", Offset = "0x16BC0FC", VA = "0x16BC0FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5933C", Offset = "0xD5933C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000C00")]
				[Address(RVA = "0x16BC104", Offset = "0x16BC104", VA = "0x16BC104")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5934C", Offset = "0xD5934C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700023D")]
			public bool GetButton
			{
				[Token(Token = "0x6000C06")]
				[Address(RVA = "0x16BC264", Offset = "0x16BC264", VA = "0x16BC264")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700023E")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000C07")]
				[Address(RVA = "0x16BC26C", Offset = "0x16BC26C", VA = "0x16BC26C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700023F")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000C08")]
				[Address(RVA = "0x16BC29C", Offset = "0x16BC29C", VA = "0x16BC29C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000C01")]
			[Address(RVA = "0x16BC110", Offset = "0x16BC110", VA = "0x16BC110")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x6000C02")]
			[Address(RVA = "0x16BC14C", Offset = "0x16BC14C", VA = "0x16BC14C")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000C03")]
			[Address(RVA = "0x16BC194", Offset = "0x16BC194", VA = "0x16BC194")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x16BC1D0", Offset = "0x16BC1D0", VA = "0x16BC1D0")]
			public void Released()
			{
			}

			[Token(Token = "0x6000C05")]
			[Address(RVA = "0x16BC1FC", Offset = "0x16BC1FC", VA = "0x16BC1FC")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x1700000C")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x16BBCF0", Offset = "0x16BBCF0", VA = "0x16BBCF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x16BB128", Offset = "0x16BB128", VA = "0x16BB128")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x16BB1C8", Offset = "0x16BB1C8", VA = "0x16BB1C8")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x16BA6F8", Offset = "0x16BA6F8", VA = "0x16BA6F8")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x16BB2E0", Offset = "0x16BB2E0", VA = "0x16BB2E0")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x16BA7A4", Offset = "0x16BA7A4", VA = "0x16BA7A4")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x16BB4E8", Offset = "0x16BB4E8", VA = "0x16BB4E8")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x16BB688", Offset = "0x16BB688", VA = "0x16BB688")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x16BB7D8", Offset = "0x16BB7D8", VA = "0x16BB7D8")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x16BA81C", Offset = "0x16BA81C", VA = "0x16BA81C")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x16BB97C", Offset = "0x16BB97C", VA = "0x16BB97C")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x16BBA74", Offset = "0x16BBA74", VA = "0x16BBA74")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x16BB9E4", Offset = "0x16BB9E4", VA = "0x16BB9E4")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x16BBADC", Offset = "0x16BBADC", VA = "0x16BBADC")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x16BBB5C", Offset = "0x16BBB5C", VA = "0x16BBB5C")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x16BBBDC", Offset = "0x16BBBDC", VA = "0x16BBBDC")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x16BACFC", Offset = "0x16BACFC", VA = "0x16BACFC")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x16BADE4", Offset = "0x16BADE4", VA = "0x16BADE4")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x16BAECC", Offset = "0x16BAECC", VA = "0x16BAECC")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x16BB09C", Offset = "0x16BB09C", VA = "0x16BB09C")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x16BAFB4", Offset = "0x16BAFB4", VA = "0x16BAFB4")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x16BBC5C", Offset = "0x16BBC5C", VA = "0x16BBC5C")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x16BBD6C", Offset = "0x16BBD6C", VA = "0x16BBD6C")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x16BBE68", Offset = "0x16BBE68", VA = "0x16BBE68")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x16BBF70", Offset = "0x16BBF70", VA = "0x16BBF70")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x16BC2CC", Offset = "0x16BC2CC", VA = "0x16BC2CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x16BC2D0", Offset = "0x16BC2D0", VA = "0x16BC2D0")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x16BC350", Offset = "0x16BC350", VA = "0x16BC350")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000189")]
		public enum AxisOption
		{
			[Token(Token = "0x4000782")]
			Both,
			[Token(Token = "0x4000783")]
			OnlyHorizontal,
			[Token(Token = "0x4000784")]
			OnlyVertical
		}

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x16BC358", Offset = "0x16BC358", VA = "0x16BC358")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x16BC498", Offset = "0x16BC498", VA = "0x16BC498")]
		private void Start()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x16BC4D4", Offset = "0x16BC4D4", VA = "0x16BC4D4")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x16BC35C", Offset = "0x16BC35C", VA = "0x16BC35C")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x16BC5C4", Offset = "0x16BC5C4", VA = "0x16BC5C4", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x16BC7B4", Offset = "0x16BC7B4", VA = "0x16BC7B4", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x16BC7FC", Offset = "0x16BC7FC", VA = "0x16BC7FC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x16BC800", Offset = "0x16BC800", VA = "0x16BC800")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x16BC850", Offset = "0x16BC850", VA = "0x16BC850")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x16BC8C0", Offset = "0x16BC8C0", VA = "0x16BC8C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x16BC8D0", Offset = "0x16BC8D0", VA = "0x16BC8D0")]
		private void Start()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x16BC8C8", Offset = "0x16BC8C8", VA = "0x16BC8C8")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x16BC9AC", Offset = "0x16BC9AC", VA = "0x16BC9AC")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x16BCC18", Offset = "0x16BCC18", VA = "0x16BCC18")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x200018A")]
		public enum AxisOptions
		{
			[Token(Token = "0x4000786")]
			ForwardAxis,
			[Token(Token = "0x4000787")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x200018B")]
		public class AxisMapping
		{
			[Token(Token = "0x20001F5")]
			public enum MappingType
			{
				[Token(Token = "0x40008FB")]
				NamedAxis,
				[Token(Token = "0x40008FC")]
				MousePositionX,
				[Token(Token = "0x40008FD")]
				MousePositionY,
				[Token(Token = "0x40008FE")]
				MousePositionZ
			}

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000C09")]
			[Address(RVA = "0x16BDAC8", Offset = "0x16BDAC8", VA = "0x16BDAC8")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x16BD754", Offset = "0x16BD754", VA = "0x16BD754")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x16BD814", Offset = "0x16BD814", VA = "0x16BD814")]
		private void Update()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x16BDAA0", Offset = "0x16BDAA0", VA = "0x16BDAA0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x16BDAB8", Offset = "0x16BDAB8", VA = "0x16BDAB8")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD51544", Offset = "0xD51544")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x200018C")]
		public enum AxisOption
		{
			[Token(Token = "0x400078B")]
			Both,
			[Token(Token = "0x400078C")]
			OnlyHorizontal,
			[Token(Token = "0x400078D")]
			OnlyVertical
		}

		[Token(Token = "0x200018D")]
		public enum ControlStyle
		{
			[Token(Token = "0x400078F")]
			Absolute,
			[Token(Token = "0x4000790")]
			Relative,
			[Token(Token = "0x4000791")]
			Swipe
		}

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x16BDAD0", Offset = "0x16BDAD0", VA = "0x16BDAD0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x16BDC10", Offset = "0x16BDC10", VA = "0x16BDC10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x16BDAD4", Offset = "0x16BDAD4", VA = "0x16BDAD4")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x16BDC8C", Offset = "0x16BDC8C", VA = "0x16BDC8C")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x16BDCF8", Offset = "0x16BDCF8", VA = "0x16BDCF8", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x16BDDA8", Offset = "0x16BDDA8", VA = "0x16BDDA8")]
		private void Update()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x16BDF7C", Offset = "0x16BDF7C", VA = "0x16BDF7C", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x16BDFF4", Offset = "0x16BDFF4", VA = "0x16BDFF4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x16BE0E8", Offset = "0x16BE0E8", VA = "0x16BE0E8")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD54280", Offset = "0xD54280")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700000D")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x16BE160", Offset = "0x16BE160", VA = "0x16BE160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD574D8", Offset = "0xD574D8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x16BE16C", Offset = "0x16BE16C", VA = "0x16BE16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD574E8", Offset = "0xD574E8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x16BB278", Offset = "0x16BB278", VA = "0x16BB278")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x16BB358", Offset = "0x16BB358", VA = "0x16BB358")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x16BB3C0", Offset = "0x16BB3C0", VA = "0x16BB3C0")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x16BB560", Offset = "0x16BB560", VA = "0x16BB560")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x16BB740", Offset = "0x16BB740", VA = "0x16BB740")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x16BB850", Offset = "0x16BB850", VA = "0x16BB850")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x16BB8E8", Offset = "0x16BB8E8", VA = "0x16BB8E8")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x16BBE1C", Offset = "0x16BBE1C", VA = "0x16BBE1C")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x16BBF1C", Offset = "0x16BBF1C", VA = "0x16BBF1C")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x16BC020", Offset = "0x16BC020", VA = "0x16BC020")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x600027B")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x600027C")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x600027D")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x600027E")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x600027F")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000280")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000281")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000282")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000283")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000284")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000285")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x16BD3CC", Offset = "0x16BD3CC", VA = "0x16BD3CC")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000045")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x16BCC20", Offset = "0x16BCC20", VA = "0x16BCC20")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x16BCCB4", Offset = "0x16BCCB4", VA = "0x16BCCB4")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x16BCD40", Offset = "0x16BCD40", VA = "0x16BCD40", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x16BCDDC", Offset = "0x16BCDDC", VA = "0x16BCDDC", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x16BCE94", Offset = "0x16BCE94", VA = "0x16BCE94", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x16BCF40", Offset = "0x16BCF40", VA = "0x16BCF40", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x16BCFE0", Offset = "0x16BCFE0", VA = "0x16BCFE0", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x16BD080", Offset = "0x16BD080", VA = "0x16BD080", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x16BD11C", Offset = "0x16BD11C", VA = "0x16BD11C", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x16BD1C4", Offset = "0x16BD1C4", VA = "0x16BD1C4", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x16BD274", Offset = "0x16BD274", VA = "0x16BD274", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x16BD324", Offset = "0x16BD324", VA = "0x16BD324", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x16BD3C0", Offset = "0x16BD3C0", VA = "0x16BD3C0", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x16BB1C0", Offset = "0x16BB1C0", VA = "0x16BB1C0")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x16BD48C", Offset = "0x16BD48C", VA = "0x16BD48C", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x16BD4A0", Offset = "0x16BD4A0", VA = "0x16BD4A0", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x16BD4AC", Offset = "0x16BD4AC", VA = "0x16BD4AC", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x16BD4B8", Offset = "0x16BD4B8", VA = "0x16BD4B8", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x16BD4C4", Offset = "0x16BD4C4", VA = "0x16BD4C4", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x16BD530", Offset = "0x16BD530", VA = "0x16BD530", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x16BD59C", Offset = "0x16BD59C", VA = "0x16BD59C", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x16BD608", Offset = "0x16BD608", VA = "0x16BD608", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x16BD674", Offset = "0x16BD674", VA = "0x16BD674", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x16BD6E0", Offset = "0x16BD6E0", VA = "0x16BD6E0", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x16BD74C", Offset = "0x16BD74C", VA = "0x16BD74C", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x16BB1C4", Offset = "0x16BB1C4", VA = "0x16BB1C4")]
		public StandaloneInput()
		{
		}
	}
}
namespace SRF
{
	[Token(Token = "0x2000047")]
	public static class Json
	{
		[Token(Token = "0x200018E")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x20001F6")]
			private enum TOKEN
			{
				[Token(Token = "0x4000900")]
				NONE,
				[Token(Token = "0x4000901")]
				CURLY_OPEN,
				[Token(Token = "0x4000902")]
				CURLY_CLOSE,
				[Token(Token = "0x4000903")]
				SQUARED_OPEN,
				[Token(Token = "0x4000904")]
				SQUARED_CLOSE,
				[Token(Token = "0x4000905")]
				COLON,
				[Token(Token = "0x4000906")]
				COMMA,
				[Token(Token = "0x4000907")]
				STRING,
				[Token(Token = "0x4000908")]
				NUMBER,
				[Token(Token = "0x4000909")]
				TRUE,
				[Token(Token = "0x400090A")]
				FALSE,
				[Token(Token = "0x400090B")]
				NULL
			}

			[Token(Token = "0x4000792")]
			private const string WORD_BREAK = "{}[],:\"";

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x17000240")]
			private char PeekChar
			{
				[Token(Token = "0x6000C0B")]
				[Address(RVA = "0x12A14B4", Offset = "0x12A14B4", VA = "0x12A14B4")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000241")]
			private char NextChar
			{
				[Token(Token = "0x6000C0C")]
				[Address(RVA = "0x12A153C", Offset = "0x12A153C", VA = "0x12A153C")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000242")]
			private string NextWord
			{
				[Token(Token = "0x6000C0D")]
				[Address(RVA = "0x12A15C4", Offset = "0x12A15C4", VA = "0x12A15C4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000243")]
			private TOKEN NextToken
			{
				[Token(Token = "0x6000C0E")]
				[Address(RVA = "0x12A1720", Offset = "0x12A1720", VA = "0x12A1720")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x6000C0A")]
			[Address(RVA = "0x12A1438", Offset = "0x12A1438", VA = "0x12A1438")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x6000C0F")]
			[Address(RVA = "0x12A1984", Offset = "0x12A1984", VA = "0x12A1984", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000C10")]
			[Address(RVA = "0x12A1680", Offset = "0x12A1680", VA = "0x12A1680")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x6000C11")]
			[Address(RVA = "0x12A128C", Offset = "0x12A128C", VA = "0x12A128C")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6000C12")]
			[Address(RVA = "0x12A19E0", Offset = "0x12A19E0", VA = "0x12A19E0")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6000C13")]
			[Address(RVA = "0x12A1D74", Offset = "0x12A1D74", VA = "0x12A1D74")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x12A19B8", Offset = "0x12A19B8", VA = "0x12A19B8")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x12A1E48", Offset = "0x12A1E48", VA = "0x12A1E48")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x6000C16")]
			[Address(RVA = "0x12A1AF4", Offset = "0x12A1AF4", VA = "0x12A1AF4")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x6000C17")]
			[Address(RVA = "0x12A1F24", Offset = "0x12A1F24", VA = "0x12A1F24")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x6000C18")]
			[Address(RVA = "0x12A18D0", Offset = "0x12A18D0", VA = "0x12A18D0")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x200018F")]
		private sealed class Serializer
		{
			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x6000C19")]
			[Address(RVA = "0x12A2000", Offset = "0x12A2000", VA = "0x12A2000")]
			private Serializer()
			{
			}

			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0x12A13BC", Offset = "0x12A13BC", VA = "0x12A13BC")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x6000C1B")]
			[Address(RVA = "0x12A206C", Offset = "0x12A206C", VA = "0x12A206C")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x6000C1C")]
			[Address(RVA = "0x12A2724", Offset = "0x12A2724", VA = "0x12A2724")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000C1D")]
			[Address(RVA = "0x12A2468", Offset = "0x12A2468", VA = "0x12A2468")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6000C1E")]
			[Address(RVA = "0x12A2208", Offset = "0x12A2208", VA = "0x12A2208")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000C1F")]
			[Address(RVA = "0x12A2B0C", Offset = "0x12A2B0C", VA = "0x12A2B0C")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x12A1280", Offset = "0x12A1280", VA = "0x12A1280")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x12A13B8", Offset = "0x12A13B8", VA = "0x12A13B8")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xD515A8", Offset = "0xD515A8")]
	public class SRList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000190")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5391C", Offset = "0xD5391C")]
		private sealed class <GetEnumerator>d__15 : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T <>2__current;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SRList<T> <>4__this;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <i>5__2;

			[Token(Token = "0x17000244")]
			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Token(Token = "0x6000C23")]
				[DebuggerHidden]
				get
				{
					return (T)null;
				}
			}

			[Token(Token = "0x17000245")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C25")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C20")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000C21")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C22")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C24")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T[] _buffer;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int _count;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private EqualityComparer<T> _equalityComparer;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ReadOnlyCollection<T> _readOnlyWrapper;

		[Token(Token = "0x1700000E")]
		public T[] Buffer
		{
			[Token(Token = "0x60002A6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A7")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		private EqualityComparer<T> EqualityComparer
		{
			[Token(Token = "0x60002A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public int Count
		{
			[Token(Token = "0x60002A9")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002AA")]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60002B2")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		public T Item
		{
			[Token(Token = "0x60002B6")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x60002B7")]
			set
			{
			}
		}

		[Token(Token = "0x60002A3")]
		public SRList()
		{
		}

		[Token(Token = "0x60002A4")]
		public SRList(int capacity)
		{
		}

		[Token(Token = "0x60002A5")]
		public SRList(IEnumerable<T> source)
		{
		}

		[Token(Token = "0x60002AB")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD574F8", Offset = "0xD574F8")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x60002AE")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002AF")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B0")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60002B1")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x60002B4")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x60002B5")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x60002B8")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60002B9")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60002BA")]
		public void AddRange(IEnumerable<T> range)
		{
		}

		[Token(Token = "0x60002BB")]
		public void Clear(bool clean)
		{
		}

		[Token(Token = "0x60002BC")]
		public void Clean()
		{
		}

		[Token(Token = "0x60002BD")]
		public ReadOnlyCollection<T> AsReadOnly()
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		private void Expand()
		{
		}

		[Token(Token = "0x60002BF")]
		public void Trim()
		{
		}

		[Token(Token = "0x60002C0")]
		public void Sort(Comparison<T> comparer)
		{
		}
	}
	[Token(Token = "0x2000049")]
	public abstract class SRMonoBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider _collider;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _transform;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody _rigidBody;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject _gameObject;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody2D _rigidbody2D;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Collider2D _collider2D;

		[Token(Token = "0x17000013")]
		public Transform CachedTransform
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x1292054", Offset = "0x1292054", VA = "0x1292054")]
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public Collider CachedCollider
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x12A38CC", Offset = "0x12A38CC", VA = "0x12A38CC")]
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public Collider2D CachedCollider2D
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x12A3964", Offset = "0x12A3964", VA = "0x12A3964")]
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public Rigidbody CachedRigidBody
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x12A39FC", Offset = "0x12A39FC", VA = "0x12A39FC")]
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public Rigidbody2D CachedRigidBody2D
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x12A3A94", Offset = "0x12A3A94", VA = "0x12A3A94")]
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public GameObject CachedGameObject
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x129A974", Offset = "0x129A974", VA = "0x129A974")]
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public new Transform transform
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x129B218", Offset = "0x129B218", VA = "0x129B218")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public Collider collider
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x12A3B2C", Offset = "0x12A3B2C", VA = "0x12A3B2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public Collider2D collider2D
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x12A3B30", Offset = "0x12A3B30", VA = "0x12A3B30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x12A3B34", Offset = "0x12A3B34", VA = "0x12A3B34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public Rigidbody2D rigidbody2D
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x12A3B38", Offset = "0x12A3B38", VA = "0x12A3B38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public new GameObject gameObject
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x129C3FC", Offset = "0x129C3FC", VA = "0x129C3FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x12A3B3C", Offset = "0x12A3B3C", VA = "0x12A3B3C")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void AssertNotNull(object value, [Optional] string fieldName)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x12A3B54", Offset = "0x12A3B54", VA = "0x12A3B54")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void Assert(bool condition, [Optional] string message)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x12A3B70", Offset = "0x12A3B70", VA = "0x12A3B70")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xD5771C", Offset = "0xD5771C")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssertNotNull(object value, [Optional] string fieldName)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x12A3B88", Offset = "0x12A3B88", VA = "0x12A3B88")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xD57778", Offset = "0xD57778")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssert(bool condition, [Optional] string message)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x129A16C", Offset = "0x129A16C", VA = "0x129A16C")]
		protected SRMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xD515E0", Offset = "0xD515E0")]
	public sealed class RequiredFieldAttribute : Attribute
	{
		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _autoCreate;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool _autoSearch;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		private bool _editorOnly;

		[Token(Token = "0x1700001F")]
		public bool AutoSearch
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x12A2DB8", Offset = "0x12A2DB8", VA = "0x12A2DB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x12A2DC0", Offset = "0x12A2DC0", VA = "0x12A2DC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public bool AutoCreate
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x12A2DCC", Offset = "0x12A2DCC", VA = "0x12A2DCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x12A2DD4", Offset = "0x12A2DD4", VA = "0x12A2DD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xD597EC", Offset = "0xD597EC")]
		public bool EditorOnly
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x12A2DE0", Offset = "0x12A2DE0", VA = "0x12A2DE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x12A2DE8", Offset = "0x12A2DE8", VA = "0x12A2DE8")]
			set
			{
			}
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x12A2D70", Offset = "0x12A2D70", VA = "0x12A2D70")]
		public RequiredFieldAttribute(bool autoSearch)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x12A2DA8", Offset = "0x12A2DA8", VA = "0x12A2DA8")]
		public RequiredFieldAttribute()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xD515F4", Offset = "0xD515F4")]
	public class ImportAttribute : Attribute
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Type Service;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x12A124C", Offset = "0x12A124C", VA = "0x12A124C")]
		public ImportAttribute()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x12A1254", Offset = "0x12A1254", VA = "0x12A1254")]
		public ImportAttribute(Type serviceType)
		{
		}
	}
	[Token(Token = "0x200004C")]
	public abstract class SRMonoBehaviourEx : SRMonoBehaviour
	{
		[Token(Token = "0x2000191")]
		private struct FieldInfo
		{
			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool AutoCreate;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool AutoSet;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public System.Reflection.FieldInfo Field;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool Import;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type ImportType;
		}

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, IList<FieldInfo>> _checkedFields;

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x12A3BA4", Offset = "0x12A3BA4", VA = "0x12A3BA4")]
		private static void CheckFields(SRMonoBehaviourEx instance, bool justSet = false)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x12A3F24", Offset = "0x12A3F24", VA = "0x12A3F24")]
		private static void PopulateObject(IList<FieldInfo> cache, SRMonoBehaviourEx instance, bool justSet)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x12A3CDC", Offset = "0x12A3CDC", VA = "0x12A3CDC")]
		private static List<FieldInfo> ScanType(Type t)
		{
			return null;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x129204C", Offset = "0x129204C", VA = "0x129204C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1292368", Offset = "0x1292368", VA = "0x1292368", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1292674", Offset = "0x1292674", VA = "0x1292674", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x12A4570", Offset = "0x12A4570", VA = "0x12A4570", Slot = "7")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x129505C", Offset = "0x129505C", VA = "0x129505C", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1298DB4", Offset = "0x1298DB4", VA = "0x1298DB4", Slot = "9")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x129251C", Offset = "0x129251C", VA = "0x129251C", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x12920EC", Offset = "0x12920EC", VA = "0x12920EC")]
		protected SRMonoBehaviourEx()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public static class Coroutines
	{
		[Token(Token = "0x2000192")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5392C", Offset = "0xD5392C")]
		private sealed class <WaitForSecondsRealTime>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <endTime>5__2;

			[Token(Token = "0x17000246")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C29")]
				[Address(RVA = "0x12A0C34", Offset = "0x12A0C34", VA = "0x12A0C34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000247")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C2B")]
				[Address(RVA = "0x12A0C9C", Offset = "0x12A0C9C", VA = "0x12A0C9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C26")]
			[Address(RVA = "0x12A0B80", Offset = "0x12A0B80", VA = "0x12A0B80")]
			[DebuggerHidden]
			public <WaitForSecondsRealTime>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000C27")]
			[Address(RVA = "0x12A0BAC", Offset = "0x12A0BAC", VA = "0x12A0BAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C28")]
			[Address(RVA = "0x12A0BB0", Offset = "0x12A0BB0", VA = "0x12A0BB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0x12A0C3C", Offset = "0x12A0C3C", VA = "0x12A0C3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x12A0B08", Offset = "0x12A0B08", VA = "0x12A0B08")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD577D4", Offset = "0xD577D4")]
		public static IEnumerator WaitForSecondsRealTime(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x200004E")]
	public static class SRFFloatExtensions
	{
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x12A2DF4", Offset = "0x12A2DF4", VA = "0x12A2DF4")]
		public static float Sqr(this float f)
		{
			return default(float);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x12A2DFC", Offset = "0x12A2DFC", VA = "0x12A2DFC")]
		public static float SqrRt(this float f)
		{
			return default(float);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1292960", Offset = "0x1292960", VA = "0x1292960")]
		public static bool ApproxZero(this float f)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x12A2E84", Offset = "0x12A2E84", VA = "0x12A2E84")]
		public static bool Approx(this float f, float f2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004F")]
	public static class SRFGameObjectExtensions
	{
		[Token(Token = "0x60002EC")]
		public static T GetIComponent<T>(this GameObject t) where T : class
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		public static T GetComponentOrAdd<T>(this GameObject obj) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60002EE")]
		public static void RemoveComponentIfExists<T>(this GameObject obj) where T : UnityEngine.Component
		{
		}

		[Token(Token = "0x60002EF")]
		public static void RemoveComponentsIfExists<T>(this GameObject obj) where T : UnityEngine.Component
		{
		}

		[Token(Token = "0x60002F0")]
		public static bool EnableComponentIfExists<T>(this GameObject obj, bool enable = true) where T : MonoBehaviour
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x129C400", Offset = "0x129C400", VA = "0x129C400")]
		public static void SetLayerRecursive(this GameObject o, int layer)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x12A2EFC", Offset = "0x12A2EFC", VA = "0x12A2EFC")]
		private static void SetLayerInternal(Transform t, int layer)
		{
		}
	}
	[Token(Token = "0x2000050")]
	public static class SRFIListExtensions
	{
		[Token(Token = "0x60002F3")]
		public static T Random<T>(this IList<T> list)
		{
			return (T)null;
		}

		[Token(Token = "0x60002F4")]
		public static T RandomOrDefault<T>(this IList<T> list)
		{
			return (T)null;
		}

		[Token(Token = "0x60002F5")]
		public static T PopLast<T>(this IList<T> list)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000051")]
	public static class SRFStringExtensions
	{
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1290BEC", Offset = "0x1290BEC", VA = "0x1290BEC")]
		public static string Fmt(this string formatString, params object[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x2000052")]
	public static class SRFTransformExtensions
	{
		[Token(Token = "0x2000193")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5393C", Offset = "0xD5393C")]
		private sealed class <GetChildren>d__0 : IEnumerable<Transform>, IEnumerable, IEnumerator<Transform>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Transform <>2__current;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform <>3__t;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <i>5__2;

			[Token(Token = "0x17000248")]
			private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
			{
				[Token(Token = "0x6000C2F")]
				[Address(RVA = "0x12A37AC", Offset = "0x12A37AC", VA = "0x12A37AC", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000249")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C31")]
				[Address(RVA = "0x12A3814", Offset = "0x12A3814", VA = "0x12A3814", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C2C")]
			[Address(RVA = "0x12A31D8", Offset = "0x12A31D8", VA = "0x12A31D8")]
			[DebuggerHidden]
			public <GetChildren>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000C2D")]
			[Address(RVA = "0x12A3710", Offset = "0x12A3710", VA = "0x12A3710", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C2E")]
			[Address(RVA = "0x12A3714", Offset = "0x12A3714", VA = "0x12A3714", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C30")]
			[Address(RVA = "0x12A37B4", Offset = "0x12A37B4", VA = "0x12A37B4", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000C32")]
			[Address(RVA = "0x12A381C", Offset = "0x12A381C", VA = "0x12A381C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Transform> System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000C33")]
			[Address(RVA = "0x12A38C8", Offset = "0x12A38C8", VA = "0x12A38C8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x12A3158", Offset = "0x12A3158", VA = "0x12A3158")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD57918", Offset = "0xD57918")]
		public static IEnumerable<Transform> GetChildren(this Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x12A3210", Offset = "0x12A3210", VA = "0x12A3210")]
		public static void ResetLocal(this Transform t)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x12A32D0", Offset = "0x12A32D0", VA = "0x12A32D0")]
		public static GameObject CreateChild(this Transform t, string name)
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x12A33B4", Offset = "0x12A33B4", VA = "0x12A33B4")]
		public static void SetParentMaintainLocals(this Transform t, Transform parent)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x12A33D0", Offset = "0x12A33D0", VA = "0x12A33D0")]
		public static void SetLocals(this Transform t, Transform from)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x12A3440", Offset = "0x12A3440", VA = "0x12A3440")]
		public static void Match(this Transform t, Transform from)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x12A3498", Offset = "0x12A3498", VA = "0x12A3498")]
		public static void DestroyChildren(this Transform t)
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xD51658", Offset = "0xD51658")]
	public class Hierarchy
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] Seperator;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, Transform> Cache;

		[Token(Token = "0x17000022")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xD597FC", Offset = "0xD597FC")]
		public Transform Item
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x12A0EC0", Offset = "0x12A0EC0", VA = "0x12A0EC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x12A0F24", Offset = "0x12A0F24", VA = "0x12A0F24")]
		public static Transform Get(string key)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x12A118C", Offset = "0x12A118C", VA = "0x12A118C")]
		public Hierarchy()
		{
		}
	}
}
namespace SRF.UI
{
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD51690", Offset = "0xD51690")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51690", Offset = "0xD51690")]
	public class ContentFitText : UIBehaviour, ILayoutElement
	{
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SRText CopySource;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 Padding;

		[Token(Token = "0x17000023")]
		public float minWidth
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x12A634C", Offset = "0x12A634C", VA = "0x12A634C", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000024")]
		public float preferredWidth
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x12A63F0", Offset = "0x12A63F0", VA = "0x12A63F0", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000025")]
		public float flexibleWidth
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x12A6494", Offset = "0x12A6494", VA = "0x12A6494", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000026")]
		public float minHeight
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x12A6534", Offset = "0x12A6534", VA = "0x12A6534", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000027")]
		public float preferredHeight
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x12A65D8", Offset = "0x12A65D8", VA = "0x12A65D8", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000028")]
		public float flexibleHeight
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x12A667C", Offset = "0x12A667C", VA = "0x12A667C", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000029")]
		public int layoutPriority
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x12A671C", Offset = "0x12A671C", VA = "0x12A671C", Slot = "25")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x12A6724", Offset = "0x12A6724", VA = "0x12A6724", Slot = "17")]
		public void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x12A6748", Offset = "0x12A6748", VA = "0x12A6748", Slot = "18")]
		public void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x12A676C", Offset = "0x12A676C", VA = "0x12A676C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x12A68C8", Offset = "0x12A68C8", VA = "0x12A68C8")]
		private void CopySourceOnLayoutDirty(SRText srText)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x12A68CC", Offset = "0x12A68CC", VA = "0x12A68CC", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x12A68D0", Offset = "0x12A68D0", VA = "0x12A68D0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x12A696C", Offset = "0x12A696C", VA = "0x12A696C", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x12A6970", Offset = "0x12A6970", VA = "0x12A6970", Slot = "11")]
		protected override void OnBeforeTransformParentChanged()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x12A6808", Offset = "0x12A6808", VA = "0x12A6808")]
		protected void SetDirty()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x12A6974", Offset = "0x12A6974", VA = "0x12A6974")]
		public ContentFitText()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD51728", Offset = "0xD51728")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51728", Offset = "0xD51728")]
	public class CopyLayoutElement : UIBehaviour, ILayoutElement
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool CopyMinHeight;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool CopyMinWidth;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool CopyPreferredHeight;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool CopyPreferredWidth;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RectTransform CopySource;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float PaddingMinHeight;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float PaddingMinWidth;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float PaddingPreferredHeight;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float PaddingPreferredWidth;

		[Token(Token = "0x1700002A")]
		public float preferredWidth
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x12A697C", Offset = "0x12A697C", VA = "0x12A697C", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002B")]
		public float preferredHeight
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x12A6A34", Offset = "0x12A6A34", VA = "0x12A6A34", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002C")]
		public float minWidth
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x12A6AEC", Offset = "0x12A6AEC", VA = "0x12A6AEC", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public float minHeight
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x12A6BA4", Offset = "0x12A6BA4", VA = "0x12A6BA4", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002E")]
		public int layoutPriority
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x12A6C5C", Offset = "0x12A6C5C", VA = "0x12A6C5C", Slot = "25")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002F")]
		public float flexibleHeight
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x12A6C64", Offset = "0x12A6C64", VA = "0x12A6C64", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000030")]
		public float flexibleWidth
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x12A6C6C", Offset = "0x12A6C6C", VA = "0x12A6C6C", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x12A6C74", Offset = "0x12A6C74", VA = "0x12A6C74", Slot = "17")]
		public void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x12A6C78", Offset = "0x12A6C78", VA = "0x12A6C78", Slot = "18")]
		public void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x12A6C7C", Offset = "0x12A6C7C", VA = "0x12A6C7C")]
		public CopyLayoutElement()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD517C0", Offset = "0xD517C0")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD517C0", Offset = "0xD517C0")]
	public class CopyPreferredSize : LayoutElement
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RectTransform CopySource;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float PaddingHeight;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float PaddingWidth;

		[Token(Token = "0x17000031")]
		public override float preferredWidth
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x12A6C84", Offset = "0x12A6C84", VA = "0x12A6C84", Slot = "35")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000032")]
		public override float preferredHeight
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x12A6D34", Offset = "0x12A6D34", VA = "0x12A6D34", Slot = "37")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000033")]
		public override int layoutPriority
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x12A6DE4", Offset = "0x12A6DE4", VA = "0x12A6DE4", Slot = "43")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x12A6DEC", Offset = "0x12A6DEC", VA = "0x12A6DEC")]
		public CopyPreferredSize()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD51858", Offset = "0xD51858")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51858", Offset = "0xD51858")]
	public class CopySizeIntoLayoutElement : LayoutElement
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RectTransform CopySource;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float PaddingHeight;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float PaddingWidth;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool SetPreferredSize;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool SetMinimumSize;

		[Token(Token = "0x17000034")]
		public override float preferredWidth
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x12A6DF4", Offset = "0x12A6DF4", VA = "0x12A6DF4", Slot = "35")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000035")]
		public override float preferredHeight
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x12A6ED4", Offset = "0x12A6ED4", VA = "0x12A6ED4", Slot = "37")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000036")]
		public override float minWidth
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x12A6FB4", Offset = "0x12A6FB4", VA = "0x12A6FB4", Slot = "31")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000037")]
		public override float minHeight
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x12A7094", Offset = "0x12A7094", VA = "0x12A7094", Slot = "33")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000038")]
		public override int layoutPriority
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x12A7174", Offset = "0x12A7174", VA = "0x12A7174", Slot = "43")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x12A717C", Offset = "0x12A717C", VA = "0x12A717C")]
		public CopySizeIntoLayoutElement()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class DragHandle : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CanvasScaler _canvasScaler;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _delta;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _startValue;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RectTransform.Axis Axis;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool Invert;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MaxSize;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public LayoutElement TargetLayoutElement;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RectTransform TargetRectTransform;

		[Token(Token = "0x17000039")]
		private float Mult
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x12A7184", Offset = "0x12A7184", VA = "0x12A7184")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x12A719C", Offset = "0x12A719C", VA = "0x12A719C", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x12A7410", Offset = "0x12A7410", VA = "0x12A7410", Slot = "6")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x12A77A4", Offset = "0x12A77A4", VA = "0x12A77A4", Slot = "5")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x12A796C", Offset = "0x12A796C", VA = "0x12A796C")]
		private void Start()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x12A71D0", Offset = "0x12A71D0", VA = "0x12A71D0")]
		private bool Verify()
		{
			return default(bool);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x12A72D0", Offset = "0x12A72D0", VA = "0x12A72D0")]
		private float GetCurrentValue()
		{
			return default(float);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x12A7648", Offset = "0x12A7648", VA = "0x12A7648")]
		private void SetCurrentValue(float value)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x12A7864", Offset = "0x12A7864", VA = "0x12A7864")]
		private void CommitCurrentValue()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x12A757C", Offset = "0x12A757C", VA = "0x12A757C")]
		private float GetMinSize()
		{
			return default(float);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x12A7630", Offset = "0x12A7630", VA = "0x12A7630")]
		private float GetMaxSize()
		{
			return default(float);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x12A79CC", Offset = "0x12A79CC", VA = "0x12A79CC")]
		public DragHandle()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD518F0", Offset = "0xD518F0")]
	[ExecuteInEditMode]
	public class FlashGraphic : UIBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float DecayTime;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Color DefaultColor;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color FlashColor;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Graphic Target;

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x12A79DC", Offset = "0x12A79DC", VA = "0x12A79DC", Slot = "17")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x12A7A18", Offset = "0x12A7A18", VA = "0x12A7A18", Slot = "18")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x12A7A54", Offset = "0x12A7A54", VA = "0x12A7A54", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x12A7AA4", Offset = "0x12A7AA4", VA = "0x12A7AA4")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x12A7AA8", Offset = "0x12A7AA8", VA = "0x12A7AA8")]
		public void Flash()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x12A7B1C", Offset = "0x12A7B1C", VA = "0x12A7B1C")]
		public FlashGraphic()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD5193C", Offset = "0xD5193C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD5193C", Offset = "0xD5193C")]
	public class InheritColour : SRMonoBehaviour
	{
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Graphic _graphic;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Graphic From;

		[Token(Token = "0x1700003A")]
		private Graphic Graphic
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x16B075C", Offset = "0x16B075C", VA = "0x16B075C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x16B07F4", Offset = "0x16B07F4", VA = "0x16B07F4")]
		private void Refresh()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x16B08BC", Offset = "0x16B08BC", VA = "0x16B08BC")]
		private void Update()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x16B08C0", Offset = "0x16B08C0", VA = "0x16B08C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x16B08C4", Offset = "0x16B08C4", VA = "0x16B08C4")]
		public InheritColour()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD519D4", Offset = "0xD519D4")]
	public class LongPressButton : Button
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool _handled;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private ButtonClickedEvent _onLongPress;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool _pressed;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float _pressedTime;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public float LongPressDuration;

		[Token(Token = "0x1700003B")]
		public ButtonClickedEvent onLongPress
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x16B339C", Offset = "0x16B339C", VA = "0x16B339C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x16B33A4", Offset = "0x16B33A4", VA = "0x16B33A4")]
			set
			{
			}
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x16B33AC", Offset = "0x16B33AC", VA = "0x16B33AC", Slot = "35")]
		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x16B33D4", Offset = "0x16B33D4", VA = "0x16B33D4", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x16B3424", Offset = "0x16B3424", VA = "0x16B3424", Slot = "33")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x16B3458", Offset = "0x16B3458", VA = "0x16B3458", Slot = "41")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x16B346C", Offset = "0x16B346C", VA = "0x16B346C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x16B34D4", Offset = "0x16B34D4", VA = "0x16B34D4")]
		public LongPressButton()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD51A0C", Offset = "0xD51A0C")]
	public abstract class ResponsiveBase : SRMonoBehaviour
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _queueRefresh;

		[Token(Token = "0x1700003C")]
		protected RectTransform RectTransform
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x16B3548", Offset = "0x16B3548", VA = "0x16B3548")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x16B35B4", Offset = "0x16B35B4", VA = "0x16B35B4")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x16B35C0", Offset = "0x16B35C0", VA = "0x16B35C0")]
		protected void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x16B35CC", Offset = "0x16B35CC", VA = "0x16B35CC")]
		protected void Update()
		{
		}

		[Token(Token = "0x600034A")]
		protected abstract void Refresh();

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x16B3600", Offset = "0x16B3600", VA = "0x16B3600")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD579EC", Offset = "0xD579EC")]
		private void DoRefresh()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x16B360C", Offset = "0x16B360C", VA = "0x16B360C")]
		protected ResponsiveBase()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD51A80", Offset = "0xD51A80")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51A80", Offset = "0xD51A80")]
	public class ResponsiveEnable : ResponsiveBase
	{
		[Token(Token = "0x2000194")]
		public enum Modes
		{
			[Token(Token = "0x40007A9")]
			EnableAbove,
			[Token(Token = "0x40007AA")]
			EnableBelow
		}

		[Serializable]
		[Token(Token = "0x2000195")]
		public struct Entry
		{
			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Behaviour[] Components;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public GameObject[] GameObjects;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Modes Mode;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float ThresholdHeight;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float ThresholdWidth;
		}

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Entry[] Entries;

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x16B3614", Offset = "0x16B3614", VA = "0x16B3614", Slot = "4")]
		protected override void Refresh()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x16B38CC", Offset = "0x16B38CC", VA = "0x16B38CC")]
		public ResponsiveEnable()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD51B18", Offset = "0xD51B18")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51B18", Offset = "0xD51B18")]
	public class ResponsiveResize : ResponsiveBase
	{
		[Serializable]
		[Token(Token = "0x2000196")]
		public struct Element
		{
			[Serializable]
			[Token(Token = "0x20001F7")]
			public struct SizeDefinition
			{
				[Token(Token = "0x400090C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD569EC", Offset = "0xD569EC")]
				public float ElementWidth;

				[Token(Token = "0x400090D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD56A24", Offset = "0xD56A24")]
				public float ThresholdWidth;
			}

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SizeDefinition[] SizeDefinitions;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public RectTransform Target;
		}

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Element[] Elements;

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x16B392C", Offset = "0x16B392C", VA = "0x16B392C", Slot = "4")]
		protected override void Refresh()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x16B3B3C", Offset = "0x16B3B3C", VA = "0x16B3B3C")]
		public ResponsiveResize()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51BB0", Offset = "0xD51BB0")]
	public class SRNumberButton : Button, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
	{
		[Token(Token = "0x400019E")]
		private const float ExtraThreshold = 3f;

		[Token(Token = "0x400019F")]
		public const float Delay = 0.4f;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float _delayTime;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float _downTime;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool _isDown;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public double Amount;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public SRNumberSpinner TargetField;

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x16B3B9C", Offset = "0x16B3B9C", VA = "0x16B3B9C", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x16B3CF4", Offset = "0x16B3CF4", VA = "0x16B3CF4", Slot = "33")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x16B3D1C", Offset = "0x16B3D1C", VA = "0x16B3D1C", Slot = "43")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x16B3BF4", Offset = "0x16B3BF4", VA = "0x16B3BF4")]
		private void Apply()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x16B3DFC", Offset = "0x16B3DFC", VA = "0x16B3DFC")]
		public SRNumberButton()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51BE8", Offset = "0xD51BE8")]
	public class SRNumberSpinner : InputField
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private double _currentValue;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private double _dragStartAmount;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private double _dragStep;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		public float DragSensitivity;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		public double MaxValue;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public double MinValue;

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x16B3E0C", Offset = "0x16B3E0C", VA = "0x16B3E0C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x16B3EB4", Offset = "0x16B3EB4", VA = "0x16B3EB4", Slot = "71")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x16B3FD8", Offset = "0x16B3FD8", VA = "0x16B3FD8", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x16B3FDC", Offset = "0x16B3FDC", VA = "0x16B3FDC", Slot = "33")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x16B3FE0", Offset = "0x16B3FE0", VA = "0x16B3FE0", Slot = "62")]
		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x16B429C", Offset = "0x16B429C", VA = "0x16B429C", Slot = "63")]
		public override void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x16B4474", Offset = "0x16B4474", VA = "0x16B4474", Slot = "64")]
		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x16B44E4", Offset = "0x16B44E4", VA = "0x16B44E4")]
		public SRNumberSpinner()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD51C20", Offset = "0xD51C20")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51C20", Offset = "0xD51C20")]
	public class SRRetinaScaler : SRMonoBehaviour
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _retinaScale;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private int _thresholdDpi;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _disablePixelPerfect;

		[Token(Token = "0x1700003D")]
		public int ThresholdDpi
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x16B4564", Offset = "0x16B4564", VA = "0x16B4564")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003E")]
		public float RetinaScale
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x16B456C", Offset = "0x16B456C", VA = "0x16B456C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x16B4574", Offset = "0x16B4574", VA = "0x16B4574")]
		private void Start()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x16B463C", Offset = "0x16B463C", VA = "0x16B463C")]
		public SRRetinaScaler()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51CA8", Offset = "0xD51CA8")]
	public class SRSpinner : Selectable, IDragHandler, IEventSystemHandler, IBeginDragHandler
	{
		[Serializable]
		[Token(Token = "0x2000197")]
		public class SpinEvent : UnityEvent
		{
			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x16B48F4", Offset = "0x16B48F4", VA = "0x16B48F4")]
			public SpinEvent()
			{
			}
		}

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _dragDelta;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private SpinEvent _onSpinDecrement;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private SpinEvent _onSpinIncrement;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float DragThreshold;

		[Token(Token = "0x1700003F")]
		public SpinEvent OnSpinIncrement
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x16B4650", Offset = "0x16B4650", VA = "0x16B4650")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x16B4658", Offset = "0x16B4658", VA = "0x16B4658")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public SpinEvent OnSpinDecrement
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x16B4660", Offset = "0x16B4660", VA = "0x16B4660")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x16B4668", Offset = "0x16B4668", VA = "0x16B4668")]
			set
			{
			}
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x16B4670", Offset = "0x16B4670", VA = "0x16B4670", Slot = "40")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x16B4678", Offset = "0x16B4678", VA = "0x16B4678", Slot = "39")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x16B479C", Offset = "0x16B479C", VA = "0x16B479C")]
		private void OnIncrement(int amount)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x16B47F0", Offset = "0x16B47F0", VA = "0x16B47F0")]
		private void OnDecrement(int amount)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x16B4844", Offset = "0x16B4844", VA = "0x16B4844")]
		public SRSpinner()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51CE0", Offset = "0xD51CE0")]
	public class SRText : Text
	{
		[Token(Token = "0x14000002")]
		public event Action<SRText> LayoutDirty
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x16B48FC", Offset = "0x16B48FC", VA = "0x16B48FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57A24", Offset = "0xD57A24")]
			add
			{
			}
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x16B49A0", Offset = "0x16B49A0", VA = "0x16B49A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57A34", Offset = "0xD57A34")]
			remove
			{
			}
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x16B4A44", Offset = "0x16B4A44", VA = "0x16B4A44", Slot = "27")]
		public override void SetLayoutDirty()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x16B4AB4", Offset = "0x16B4AB4", VA = "0x16B4AB4")]
		public SRText()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD51D18", Offset = "0xD51D18")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51D18", Offset = "0xD51D18")]
	public class ScrollToBottomBehaviour : MonoBehaviour
	{
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x16B4B1C", Offset = "0x16B4B1C", VA = "0x16B4B1C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x16B4D58", Offset = "0x16B4D58", VA = "0x16B4D58")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x16B4D5C", Offset = "0x16B4D5C", VA = "0x16B4D5C")]
		public void Trigger()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x16B4DA8", Offset = "0x16B4DA8", VA = "0x16B4DA8")]
		private void OnScrollRectValueChanged(Vector2 position)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x16B4C9C", Offset = "0x16B4C9C", VA = "0x16B4C9C")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x16B4DAC", Offset = "0x16B4DAC", VA = "0x16B4DAC")]
		private void SetVisible(bool truth)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x16B4E38", Offset = "0x16B4E38", VA = "0x16B4E38")]
		public ScrollToBottomBehaviour()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51DB0", Offset = "0xD51DB0")]
	public class StyleComponent : SRMonoBehaviour
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Style _activeStyle;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private StyleRoot _cachedRoot;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Graphic _graphic;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _hasStarted;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _image;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Selectable _selectable;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD54340", Offset = "0xD54340")]
		[HideInInspector]
		private string _styleKey;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool IgnoreImage;

		[Token(Token = "0x17000041")]
		public string StyleKey
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x16B4F50", Offset = "0x16B4F50", VA = "0x16B4F50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x16B4F58", Offset = "0x16B4F58", VA = "0x16B4F58")]
			set
			{
			}
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x16B5150", Offset = "0x16B5150", VA = "0x16B5150")]
		private void Start()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x16B517C", Offset = "0x16B517C", VA = "0x16B517C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x16B4F64", Offset = "0x16B4F64", VA = "0x16B4F64")]
		public void Refresh(bool invalidateCache)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x16B5190", Offset = "0x16B5190", VA = "0x16B5190")]
		private StyleRoot GetStyleRoot()
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x16B5404", Offset = "0x16B5404", VA = "0x16B5404")]
		private void ApplyStyle()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x16B56C4", Offset = "0x16B56C4", VA = "0x16B56C4")]
		private void SRStyleDirty()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x16B5714", Offset = "0x16B5714", VA = "0x16B5714")]
		public StyleComponent()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51DFC", Offset = "0xD51DFC")]
	public sealed class StyleRoot : SRMonoBehaviour
	{
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private StyleSheet _activeStyleSheet;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public StyleSheet StyleSheet;

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x16B5320", Offset = "0x16B5320", VA = "0x16B5320")]
		public Style GetStyle(string key)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x16B582C", Offset = "0x16B582C", VA = "0x16B582C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x16B5918", Offset = "0x16B5918", VA = "0x16B5918")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x16B591C", Offset = "0x16B591C", VA = "0x16B591C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x16B58B8", Offset = "0x16B58B8", VA = "0x16B58B8")]
		private void OnStyleSheetChanged()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x16B59B0", Offset = "0x16B59B0", VA = "0x16B59B0")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x16B59B8", Offset = "0x16B59B8", VA = "0x16B59B8")]
		public StyleRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class Style
	{
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color ActiveColor;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color DisabledColor;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color HoverColor;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Sprite Image;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color NormalColor;

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x16B4E40", Offset = "0x16B4E40", VA = "0x16B4E40")]
		public Style Copy()
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x16B4F14", Offset = "0x16B4F14", VA = "0x16B4F14")]
		public void CopyFrom(Style style)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x16B4EB0", Offset = "0x16B4EB0", VA = "0x16B4EB0")]
		public Style()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public class StyleSheet : ScriptableObject
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<string> _keys;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Style> _styles;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public StyleSheet Parent;

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x16B571C", Offset = "0x16B571C", VA = "0x16B571C")]
		public Style GetStyle(string key, bool searchParent = true)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x16B59C0", Offset = "0x16B59C0", VA = "0x16B59C0")]
		public StyleSheet()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51E48", Offset = "0xD51E48")]
	public sealed class Unselectable : SRMonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _suspectedSelected;

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x16B5A58", Offset = "0x16B5A58", VA = "0x16B5A58", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x16B5A64", Offset = "0x16B5A64", VA = "0x16B5A64")]
		private void Update()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x16B5B64", Offset = "0x16B5B64", VA = "0x16B5B64")]
		public Unselectable()
		{
		}
	}
}
namespace SRF.UI.Layout
{
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51E80", Offset = "0xD51E80")]
	public class FlowLayoutGroup : LayoutGroup
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly IList<RectTransform> _rowList;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _layoutHeight;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool ChildForceExpandHeight;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		public bool ChildForceExpandWidth;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float Spacing;

		[Token(Token = "0x17000042")]
		protected bool IsCenterAlign
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x16B08CC", Offset = "0x16B08CC", VA = "0x16B08CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		protected bool IsRightAlign
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x16B08F8", Offset = "0x16B08F8", VA = "0x16B08F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		protected bool IsMiddleAlign
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x16B0924", Offset = "0x16B0924", VA = "0x16B0924")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		protected bool IsLowerAlign
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x16B0948", Offset = "0x16B0948", VA = "0x16B0948")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x16B096C", Offset = "0x16B096C", VA = "0x16B096C", Slot = "28")]
		public override void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x16B0AD4", Offset = "0x16B0AD4", VA = "0x16B0AD4", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x16B10BC", Offset = "0x16B10BC", VA = "0x16B10BC", Slot = "38")]
		public override void SetLayoutVertical()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x16B1120", Offset = "0x16B1120", VA = "0x16B1120", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x16B0B38", Offset = "0x16B0B38", VA = "0x16B0B38")]
		public float SetLayout(float width, int axis, bool layoutInput)
		{
			return default(float);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x16B1188", Offset = "0x16B1188", VA = "0x16B1188")]
		private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight)
		{
			return default(float);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x16B11D0", Offset = "0x16B11D0", VA = "0x16B11D0")]
		protected void LayoutRow(IList<RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x16B09F4", Offset = "0x16B09F4", VA = "0x16B09F4")]
		public float GetGreatestMinimumChildWidth()
		{
			return default(float);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x16B1660", Offset = "0x16B1660", VA = "0x16B1660")]
		public FlowLayoutGroup()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public interface IVirtualView
	{
		[Token(Token = "0x600039B")]
		void SetDataContext(object data);
	}
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51EB8", Offset = "0xD51EB8")]
	public class VirtualVerticalLayoutGroup : LayoutGroup, IPointerClickHandler, IEventSystemHandler
	{
		[Serializable]
		[Token(Token = "0x2000198")]
		public class SelectedItemChangedEvent : UnityEvent<object>
		{
			[Token(Token = "0x6000C35")]
			[Address(RVA = "0x16B334C", Offset = "0x16B334C", VA = "0x16B334C")]
			public SelectedItemChangedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000199")]
		private class Row
		{
			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object Data;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int Index;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RectTransform Rect;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public StyleRoot Root;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IVirtualView View;

			[Token(Token = "0x6000C36")]
			[Address(RVA = "0x16B3248", Offset = "0x16B3248", VA = "0x16B3248")]
			public Row()
			{
			}
		}

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly SRList<object> _itemList;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly SRList<int> _visibleItemList;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _isDirty;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SRList<Row> _rowCache;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ScrollRect _scrollRect;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _selectedIndex;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private object _selectedItem;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SelectedItemChangedEvent _selectedItemChanged;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _visibleItemCount;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private SRList<Row> _visibleRows;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public StyleSheet AltRowStyleSheet;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool EnableSelection;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public RectTransform ItemPrefab;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public int RowPadding;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public StyleSheet RowStyleSheet;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public StyleSheet SelectedRowStyleSheet;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float Spacing;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public bool StickToBottom;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _itemHeight;

		[Token(Token = "0x17000046")]
		public SelectedItemChangedEvent SelectedItemChanged
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x16B16D0", Offset = "0x16B16D0", VA = "0x16B16D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x16B16D8", Offset = "0x16B16D8", VA = "0x16B16D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public object SelectedItem
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x16B16E0", Offset = "0x16B16E0", VA = "0x16B16E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x16B16E8", Offset = "0x16B16E8", VA = "0x16B16E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public override float minHeight
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x16B1998", Offset = "0x16B1998", VA = "0x16B1998", Slot = "33")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000049")]
		private ScrollRect ScrollRect
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x16B1F18", Offset = "0x16B1F18", VA = "0x16B1F18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private bool AlignBottom
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x16B2528", Offset = "0x16B2528", VA = "0x16B2528")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		private bool AlignTop
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x16B254C", Offset = "0x16B254C", VA = "0x16B254C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		private float ItemHeight
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x16B1A60", Offset = "0x16B1A60", VA = "0x16B1A60")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x16B1C10", Offset = "0x16B1C10", VA = "0x16B1C10", Slot = "40")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x16B1D94", Offset = "0x16B1D94", VA = "0x16B1D94", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x16B1FB0", Offset = "0x16B1FB0", VA = "0x16B1FB0")]
		private void OnScrollRectValueChanged(Vector2 d)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x16B207C", Offset = "0x16B207C", VA = "0x16B207C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x16B23E0", Offset = "0x16B23E0", VA = "0x16B23E0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x16B242C", Offset = "0x16B242C", VA = "0x16B242C")]
		protected void Update()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x16B1838", Offset = "0x16B1838", VA = "0x16B1838")]
		protected void InvalidateItem(int itemIndex)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x16B25D4", Offset = "0x16B25D4", VA = "0x16B25D4")]
		protected void RefreshIndexCache()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x16B20A4", Offset = "0x16B20A4", VA = "0x16B20A4")]
		protected void ScrollUpdate()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x16B2840", Offset = "0x16B2840", VA = "0x16B2840", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x16B28A4", Offset = "0x16B28A4", VA = "0x16B28A4", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x16B2A54", Offset = "0x16B2A54", VA = "0x16B2A54", Slot = "38")]
		public override void SetLayoutVertical()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x16B1958", Offset = "0x16B1958", VA = "0x16B1958")]
		private new void SetDirty()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x16B2B70", Offset = "0x16B2B70", VA = "0x16B2B70")]
		public void AddItem(object item)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x16B2CA0", Offset = "0x16B2CA0", VA = "0x16B2CA0")]
		public void RemoveItem(object item)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x16B2D7C", Offset = "0x16B2D7C", VA = "0x16B2D7C")]
		public void ClearItems()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x16B26A8", Offset = "0x16B26A8", VA = "0x16B26A8")]
		private Row GetRow(int forIndex)
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x16B256C", Offset = "0x16B256C", VA = "0x16B256C")]
		private void RecycleRow(Row row)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x16B302C", Offset = "0x16B302C", VA = "0x16B302C")]
		private void PopulateRow(int index, Row row)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x16B2E54", Offset = "0x16B2E54", VA = "0x16B2E54")]
		private Row CreateRow()
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x16B3250", Offset = "0x16B3250", VA = "0x16B3250")]
		public VirtualVerticalLayoutGroup()
		{
		}
	}
}
namespace SRF.Service
{
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xD51EF0", Offset = "0xD51EF0")]
	public sealed class ServiceAttribute : Attribute
	{
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD543DC", Offset = "0xD543DC")]
		private Type <ServiceType>k__BackingField;

		[Token(Token = "0x1700004D")]
		public Type ServiceType
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x12A62C4", Offset = "0x12A62C4", VA = "0x12A62C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57A44", Offset = "0xD57A44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x12A62CC", Offset = "0x12A62CC", VA = "0x12A62CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57A54", Offset = "0xD57A54")]
			private set
			{
			}
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x12A6298", Offset = "0x12A6298", VA = "0x12A6298")]
		public ServiceAttribute(Type serviceType)
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xD51F04", Offset = "0xD51F04")]
	public sealed class ServiceSelectorAttribute : Attribute
	{
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD543EC", Offset = "0xD543EC")]
		private Type <ServiceType>k__BackingField;

		[Token(Token = "0x1700004E")]
		public Type ServiceType
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x12A633C", Offset = "0x12A633C", VA = "0x12A633C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57A64", Offset = "0xD57A64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x12A6344", Offset = "0x12A6344", VA = "0x12A6344")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57A74", Offset = "0xD57A74")]
			private set
			{
			}
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x12A6310", Offset = "0x12A6310", VA = "0x12A6310")]
		public ServiceSelectorAttribute(Type serviceType)
		{
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xD51F18", Offset = "0xD51F18")]
	public sealed class ServiceConstructorAttribute : Attribute
	{
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD543FC", Offset = "0xD543FC")]
		private Type <ServiceType>k__BackingField;

		[Token(Token = "0x1700004F")]
		public Type ServiceType
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x12A6300", Offset = "0x12A6300", VA = "0x12A6300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57A84", Offset = "0xD57A84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x12A6308", Offset = "0x12A6308", VA = "0x12A6308")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57A94", Offset = "0xD57A94")]
			private set
			{
			}
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x12A62D4", Offset = "0x12A62D4", VA = "0x12A62D4")]
		public ServiceConstructorAttribute(Type serviceType)
		{
		}
	}
	[Token(Token = "0x2000070")]
	public interface IAsyncService
	{
		[Token(Token = "0x17000050")]
		bool IsLoaded
		{
			[Token(Token = "0x60003C3")]
			get;
		}
	}
	[Token(Token = "0x2000071")]
	public abstract class SRDependencyServiceBase<T> : SRServiceBase<T>, IAsyncService where T : class
	{
		[Token(Token = "0x200019A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5394C", Offset = "0xD5394C")]
		private sealed class <LoadDependencies>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SRDependencyServiceBase<T> <>4__this;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Type[] <>7__wrap1;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>7__wrap2;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IAsyncService <a>5__4;

			[Token(Token = "0x1700024A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C3A")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700024B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C3C")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C37")]
			[DebuggerHidden]
			public <LoadDependencies>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000C38")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C39")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C3B")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _isLoaded;

		[Token(Token = "0x17000051")]
		protected abstract Type[] Dependencies
		{
			[Token(Token = "0x60003C4")]
			get;
		}

		[Token(Token = "0x17000052")]
		public bool IsLoaded
		{
			[Token(Token = "0x60003C5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C6")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xD57AA4", Offset = "0xD57AA4")]
		private void Log(string msg, UnityEngine.Object target)
		{
		}

		[Token(Token = "0x60003C7")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003C8")]
		protected virtual void OnLoaded()
		{
		}

		[Token(Token = "0x60003C9")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD57ADC", Offset = "0xD57ADC")]
		private IEnumerator LoadDependencies()
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		protected SRDependencyServiceBase()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService where T : class where TImpl : UnityEngine.Component
	{
		[Token(Token = "0x200019B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5395C", Offset = "0xD5395C")]
		private sealed class <LoadCoroutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SRSceneServiceBase<T, TImpl> <>4__this;

			[Token(Token = "0x1700024C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C40")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700024D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C42")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C3D")]
			[DebuggerHidden]
			public <LoadCoroutine>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000C3E")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C3F")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C41")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TImpl _rootObject;

		[Token(Token = "0x17000053")]
		protected abstract string SceneName
		{
			[Token(Token = "0x60003CB")]
			get;
		}

		[Token(Token = "0x17000054")]
		protected TImpl RootObject
		{
			[Token(Token = "0x60003CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public bool IsLoaded
		{
			[Token(Token = "0x60003CD")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003CE")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xD57B40", Offset = "0xD57B40")]
		private void Log(string msg, UnityEngine.Object target)
		{
		}

		[Token(Token = "0x60003CF")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003D0")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60003D1")]
		protected virtual void OnLoaded()
		{
		}

		[Token(Token = "0x60003D2")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD57B78", Offset = "0xD57B78")]
		private IEnumerator LoadCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		protected SRSceneServiceBase()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public abstract class SRServiceBase<T> : SRMonoBehaviourEx where T : class
	{
		[Token(Token = "0x60003D4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003D5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60003D6")]
		protected SRServiceBase()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51F2C", Offset = "0xD51F2C")]
	public class SRServiceManager : SRAutoSingleton<SRServiceManager>
	{
		[Serializable]
		[Token(Token = "0x200019C")]
		private class Service
		{
			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object Object;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type Type;

			[Token(Token = "0x6000C43")]
			[Address(RVA = "0x12A4EF0", Offset = "0x12A4EF0", VA = "0x12A4EF0")]
			public Service()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200019D")]
		private class ServiceStub
		{
			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Func<object> Constructor;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type InterfaceType;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<Type> Selector;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Type Type;

			[Token(Token = "0x6000C44")]
			[Address(RVA = "0x12A6188", Offset = "0x12A6188", VA = "0x12A6188", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6000C45")]
			[Address(RVA = "0x12A55D0", Offset = "0x12A55D0", VA = "0x12A55D0")]
			public ServiceStub()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200019E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5396C", Offset = "0xD5396C")]
		private sealed class <>c
		{
			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ServiceStub, string> <>9__19_0;

			[Token(Token = "0x6000C47")]
			[Address(RVA = "0x12A5F8C", Offset = "0x12A5F8C", VA = "0x12A5F8C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000C48")]
			[Address(RVA = "0x12A5F94", Offset = "0x12A5F94", VA = "0x12A5F94")]
			internal string <UpdateStubs>b__19_0(ServiceStub p)
			{
				return null;
			}
		}

		[Token(Token = "0x200019F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5397C", Offset = "0xD5397C")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ServiceSelectorAttribute attrib;

			[Token(Token = "0x6000C49")]
			[Address(RVA = "0x12A5E9C", Offset = "0x12A5E9C", VA = "0x12A5E9C")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000C4A")]
			[Address(RVA = "0x12A6044", Offset = "0x12A6044", VA = "0x12A6044")]
			internal bool <ScanTypeForSelectors>b__0(ServiceStub p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5398C", Offset = "0xD5398C")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ServiceConstructorAttribute attrib;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MethodInfo m;

			[Token(Token = "0x6000C4B")]
			[Address(RVA = "0x12A5EA4", Offset = "0x12A5EA4", VA = "0x12A5EA4")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000C4C")]
			[Address(RVA = "0x12A60D4", Offset = "0x12A60D4", VA = "0x12A60D4")]
			internal bool <ScanTypeForConstructors>b__0(ServiceStub p)
			{
				return default(bool);
			}

			[Token(Token = "0x6000C4D")]
			[Address(RVA = "0x12A6164", Offset = "0x12A6164", VA = "0x12A6164")]
			internal object <ScanTypeForConstructors>b__1()
			{
				return null;
			}
		}

		[Token(Token = "0x40001E5")]
		public const bool EnableLogging = false;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int LoadingCount;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly SRList<Service> _services;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<ServiceStub> _serviceStubs;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static bool _hasQuit;

		[Token(Token = "0x17000056")]
		public static bool IsLoading
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x12A4574", Offset = "0x12A4574", VA = "0x12A4574")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003D8")]
		public static T GetService<T>() where T : class
		{
			return null;
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x12A439C", Offset = "0x12A439C", VA = "0x12A439C")]
		public static object GetService(Type t)
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x12A45E4", Offset = "0x12A45E4", VA = "0x12A45E4")]
		private static object GetServiceInternal(Type t)
		{
			return null;
		}

		[Token(Token = "0x60003DB")]
		public static bool HasService<T>() where T : class
		{
			return default(bool);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x12A4B3C", Offset = "0x12A4B3C", VA = "0x12A4B3C")]
		public static bool HasService(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DD")]
		public static void RegisterService<T>(object service) where T : class
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x12A4C5C", Offset = "0x12A4C5C", VA = "0x12A4C5C")]
		private static void RegisterService(Type t, object service)
		{
		}

		[Token(Token = "0x60003DF")]
		public static void UnRegisterService<T>() where T : class
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x12A475C", Offset = "0x12A475C", VA = "0x12A475C")]
		private static void UnRegisterService(Type t)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x12A4EF8", Offset = "0x12A4EF8", VA = "0x12A4EF8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x12A4FCC", Offset = "0x12A4FCC", VA = "0x12A4FCC")]
		protected void UpdateStubs()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x12A48C0", Offset = "0x12A48C0", VA = "0x12A48C0")]
		protected object AutoCreateService(Type t)
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x12A5564", Offset = "0x12A5564", VA = "0x12A5564")]
		protected void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x12A53E0", Offset = "0x12A53E0", VA = "0x12A53E0")]
		private static object DefaultServiceConstructor(Type serviceIntType, Type implType)
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x12A52E8", Offset = "0x12A52E8", VA = "0x12A52E8")]
		private void ScanType(Type type)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x12A5A24", Offset = "0x12A5A24", VA = "0x12A5A24")]
		private static void ScanTypeForSelectors(Type t, List<ServiceStub> stubs)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x12A55D8", Offset = "0x12A55D8", VA = "0x12A55D8")]
		private static void ScanTypeForConstructors(Type t, List<ServiceStub> stubs)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x12A5E78", Offset = "0x12A5E78", VA = "0x12A5E78")]
		private static MethodInfo[] GetStaticMethods(Type t)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x12A5EAC", Offset = "0x12A5EAC", VA = "0x12A5EAC")]
		public SRServiceManager()
		{
		}
	}
}
namespace SRF.Helpers
{
	[Token(Token = "0x2000075")]
	public static class AssetUtil
	{
	}
	[Token(Token = "0x2000076")]
	public class MethodReference
	{
		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private MethodInfo _method;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _target;

		[Token(Token = "0x17000057")]
		public string MethodName
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x12A0CF0", Offset = "0x12A0CF0", VA = "0x12A0CF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x12A0CA4", Offset = "0x12A0CA4", VA = "0x12A0CA4")]
		public MethodReference(object target, MethodInfo method)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1292DB8", Offset = "0x1292DB8", VA = "0x1292DB8")]
		public object Invoke(object[] parameters)
		{
			return null;
		}
	}
	[Token(Token = "0x2000077")]
	public class PropertyReference
	{
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly PropertyInfo _property;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly object _target;

		[Token(Token = "0x17000058")]
		public string PropertyName
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x12A0D5C", Offset = "0x12A0D5C", VA = "0x12A0D5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public Type PropertyType
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x12949C4", Offset = "0x12949C4", VA = "0x12949C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public bool CanRead
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x12A0D7C", Offset = "0x12A0D7C", VA = "0x12A0D7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		public bool CanWrite
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x1294998", Offset = "0x1294998", VA = "0x1294998")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x12A0D10", Offset = "0x12A0D10", VA = "0x12A0D10")]
		public PropertyReference(object target, PropertyInfo property)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1294BC8", Offset = "0x1294BC8", VA = "0x1294BC8")]
		public object GetValue()
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x12949E8", Offset = "0x12949E8", VA = "0x12949E8")]
		public void SetValue(object value)
		{
		}

		[Token(Token = "0x60003F6")]
		public T GetAttribute<T>() where T : Attribute
		{
			return null;
		}
	}
	[Token(Token = "0x2000078")]
	public static class SRReflection
	{
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x12A0DE8", Offset = "0x12A0DE8", VA = "0x12A0DE8")]
		public static void SetPropertyValue(object obj, PropertyInfo p, object value)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x12A0DA8", Offset = "0x12A0DA8", VA = "0x12A0DA8")]
		public static object GetPropertyValue(object obj, PropertyInfo p)
		{
			return null;
		}

		[Token(Token = "0x60003F9")]
		public static T GetAttribute<T>(MemberInfo t) where T : Attribute
		{
			return null;
		}
	}
}
namespace SRF.Components
{
	[Token(Token = "0x2000079")]
	public abstract class SRAutoSingleton<T> : SRMonoBehaviour where T : SRAutoSingleton<T>
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x1700005C")]
		public static T Instance
		{
			[Token(Token = "0x60003FA")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public static bool HasInstance
		{
			[Token(Token = "0x60003FB")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003FC")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60003FD")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60003FE")]
		protected SRAutoSingleton()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public abstract class SRSingleton<T> : SRMonoBehaviour where T : SRSingleton<T>
	{
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x1700005E")]
		public static T Instance
		{
			[Token(Token = "0x60003FF")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public static bool HasInstance
		{
			[Token(Token = "0x6000400")]
			[DebuggerStepThrough]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000401")]
		private void Register()
		{
		}

		[Token(Token = "0x6000402")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000403")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000404")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000405")]
		protected SRSingleton()
		{
		}
	}
}
namespace SRF.Internal
{
	[Token(Token = "0x200007B")]
	internal static class ComponentMenuPaths
	{
		[Token(Token = "0x40001F0")]
		public const string PathRoot = "SRF";

		[Token(Token = "0x40001F1")]
		public const string SRServiceManager = "SRF/Service/Service Manager";

		[Token(Token = "0x40001F2")]
		public const string BehavioursRoot = "SRF/Behaviours";

		[Token(Token = "0x40001F3")]
		public const string DestroyOnDisable = "SRF/Behaviours/Destroy On Disable";

		[Token(Token = "0x40001F4")]
		public const string DontDestroyOnLoad = "SRF/Behaviours/Don't Destroy On Load";

		[Token(Token = "0x40001F5")]
		public const string MatchTransform = "SRF/Behaviours/Match Transform";

		[Token(Token = "0x40001F6")]
		public const string LookAt = "SRF/Behaviours/LookAt";

		[Token(Token = "0x40001F7")]
		public const string MatchForwardDirection = "SRF/Behaviours/Match Forward Direction";

		[Token(Token = "0x40001F8")]
		public const string MatchMainCameraForwardDirection = "SRF/Behaviours/Match Forward Direction (Main Camera)";

		[Token(Token = "0x40001F9")]
		public const string RuntimePosition = "SRF/Behaviours/Runtime Position";

		[Token(Token = "0x40001FA")]
		public const string ScrollTexture = "SRF/Behaviours/Scroll Texture";

		[Token(Token = "0x40001FB")]
		public const string SmoothFloatBehaviour = "SRF/Behaviours/Smooth Float";

		[Token(Token = "0x40001FC")]
		public const string SmoothFollow2D = "SRF/Behaviours/Smooth Follow (2D)";

		[Token(Token = "0x40001FD")]
		public const string SpringFollow = "SRF/Behaviours/Spring Follow";

		[Token(Token = "0x40001FE")]
		public const string SmoothMatchTransform = "SRF/Behaviours/Match Transform (Smooth)";

		[Token(Token = "0x40001FF")]
		public const string SpawnPrefab = "SRF/Behaviours/Spawn Prefab";

		[Token(Token = "0x4000200")]
		public const string Velocity = "SRF/Behaviours/Velocity";

		[Token(Token = "0x4000201")]
		public const string SmoothOscillate = "SRF/Behaviours/Smooth Oscillate";

		[Token(Token = "0x4000202")]
		public const string SRDebugCamera = "SRF/Behaviours/Camera/SRDebugCamera";

		[Token(Token = "0x4000203")]
		public const string ComponentsRoot = "SRF/Components";

		[Token(Token = "0x4000204")]
		public const string SRLineRenderer = "SRF/Components/SRLineRenderer";

		[Token(Token = "0x4000205")]
		public const string SelectionRoot = "SRF/Components/Selection Root";

		[Token(Token = "0x4000206")]
		public const string SRSpriteFadeRenderer = "SRF/Components/Fade Renderer (Sprite)";

		[Token(Token = "0x4000207")]
		public const string SRMaterialFadeRenderer = "SRF/Components/Fade Renderer (Material)";

		[Token(Token = "0x4000208")]
		public const string SRCompositeFadeRenderer = "SRF/Components/Fade Renderer (Composite)";

		[Token(Token = "0x4000209")]
		public const string UIRoot = "SRF/UI";

		[Token(Token = "0x400020A")]
		public const string TiltOnTouch = "SRF/UI/Tilt On Touch";

		[Token(Token = "0x400020B")]
		public const string ScaleOnTouch = "SRF/UI/Scale On Touch";

		[Token(Token = "0x400020C")]
		public const string InheritColour = "SRF/UI/Inherit Colour";

		[Token(Token = "0x400020D")]
		public const string FlashGraphic = "SRF/UI/Flash Graphic";

		[Token(Token = "0x400020E")]
		public const string CopyPreferredSize = "SRF/UI/Copy Preferred Size";

		[Token(Token = "0x400020F")]
		public const string CopyLayoutElement = "SRF/UI/Copy Layout Element";

		[Token(Token = "0x4000210")]
		public const string CopySizeIntoLayoutElement = "SRF/UI/Copy Size Into Layout Element";

		[Token(Token = "0x4000211")]
		public const string SRText = "SRF/UI/SRText";

		[Token(Token = "0x4000212")]
		public const string Unselectable = "SRF/UI/Unselectable";

		[Token(Token = "0x4000213")]
		public const string LongPressButton = "SRF/UI/Long Press Button";

		[Token(Token = "0x4000214")]
		public const string ScrollToBottom = "SRF/UI/Scroll To Bottom Behaviour";

		[Token(Token = "0x4000215")]
		public const string FlowLayoutGroup = "SRF/UI/Layout/Flow Layout Group";

		[Token(Token = "0x4000216")]
		public const string VirtualVerticalLayoutGroup = "SRF/UI/Layout/VerticalLayoutGroup (Virtualizing)";

		[Token(Token = "0x4000217")]
		public const string StyleRoot = "SRF/UI/Style Root";

		[Token(Token = "0x4000218")]
		public const string StyleComponent = "SRF/UI/Style Component";

		[Token(Token = "0x4000219")]
		public const string ResponsiveEnable = "SRF/UI/Responsive (Enable)";

		[Token(Token = "0x400021A")]
		public const string ResponsiveResize = "SRF/UI/Responsive (Resize)";

		[Token(Token = "0x400021B")]
		public const string RetinaScaler = "SRF/UI/Retina Scaler";

		[Token(Token = "0x400021C")]
		public const string NumberButton = "SRF/UI/SRNumberButton";

		[Token(Token = "0x400021D")]
		public const string NumberSpinner = "SRF/UI/SRNumberSpinner";

		[Token(Token = "0x400021E")]
		public const string SRSpinner = "SRF/UI/Spinner";

		[Token(Token = "0x400021F")]
		public const string ContentFitText = "SRF/UI/Content Fit Text";
	}
}
namespace SRDebugger
{
	[Token(Token = "0x200007C")]
	public static class AutoInitialize
	{
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x10639D0", Offset = "0x10639D0", VA = "0x10639D0")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xD57C0C", Offset = "0xD57C0C")]
		public static void OnLoad()
		{
		}
	}
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xD51F64", Offset = "0xD51F64")]
	public interface IReadOnlyList<T> : IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x17000060")]
		int Count
		{
			[Token(Token = "0x6000407")]
			get;
		}

		[Token(Token = "0x17000061")]
		T Item
		{
			[Token(Token = "0x6000408")]
			get;
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xD51F9C", Offset = "0xD51F9C")]
	public class CircularBuffer<T> : IEnumerable<T>, IEnumerable, IReadOnlyList<T>
	{
		[Token(Token = "0x20001A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5399C", Offset = "0xD5399C")]
		private sealed class <GetEnumerator>d__18 : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T <>2__current;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CircularBuffer<T> <>4__this;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ArraySegment<T>[] <>7__wrap1;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>7__wrap2;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ArraySegment<T> <segment>5__4;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <i>5__5;

			[Token(Token = "0x1700024E")]
			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Token(Token = "0x6000C51")]
				[DebuggerHidden]
				get
				{
					return (T)null;
				}
			}

			[Token(Token = "0x1700024F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C53")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C4E")]
			[DebuggerHidden]
			public <GetEnumerator>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000C4F")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C50")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C52")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly T[] _buffer;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _end;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _count;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _start;

		[Token(Token = "0x17000062")]
		public int Capacity
		{
			[Token(Token = "0x600040B")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000063")]
		public bool IsFull
		{
			[Token(Token = "0x600040C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		public bool IsEmpty
		{
			[Token(Token = "0x600040D")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		public int Count
		{
			[Token(Token = "0x600040E")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000066")]
		public T Item
		{
			[Token(Token = "0x600040F")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000410")]
			set
			{
			}
		}

		[Token(Token = "0x6000409")]
		public CircularBuffer(int capacity)
		{
		}

		[Token(Token = "0x600040A")]
		public CircularBuffer(int capacity, T[] items)
		{
		}

		[Token(Token = "0x6000411")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000412")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD57C1C", Offset = "0xD57C1C")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000413")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		public T Front()
		{
			return (T)null;
		}

		[Token(Token = "0x6000415")]
		public T Back()
		{
			return (T)null;
		}

		[Token(Token = "0x6000416")]
		public void PushBack(T item)
		{
		}

		[Token(Token = "0x6000417")]
		public void PushFront(T item)
		{
		}

		[Token(Token = "0x6000418")]
		public void PopBack()
		{
		}

		[Token(Token = "0x6000419")]
		public void PopFront()
		{
		}

		[Token(Token = "0x600041A")]
		public T[] ToArray()
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		private void ThrowIfEmpty(string message = "Cannot access an empty buffer.")
		{
		}

		[Token(Token = "0x600041C")]
		private void Increment(ref int index)
		{
		}

		[Token(Token = "0x600041D")]
		private void Decrement(ref int index)
		{
		}

		[Token(Token = "0x600041E")]
		private int InternalIndex(int index)
		{
			return default(int);
		}

		[Token(Token = "0x600041F")]
		private ArraySegment<T> ArrayOne()
		{
			return default(ArraySegment<T>);
		}

		[Token(Token = "0x6000420")]
		private ArraySegment<T> ArrayTwo()
		{
			return default(ArraySegment<T>);
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD51FD4", Offset = "0xD51FD4")]
	public class SRDebuggerInit : SRMonoBehaviourEx
	{
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1067594", Offset = "0x1067594", VA = "0x1067594", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x10675CC", Offset = "0x10675CC", VA = "0x10675CC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1067654", Offset = "0x1067654", VA = "0x1067654")]
		public SRDebuggerInit()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public delegate void VisibilityChangedDelegate(bool isVisible);
	[Token(Token = "0x2000081")]
	public delegate void ActionCompleteCallback(bool success);
	[Token(Token = "0x2000082")]
	public sealed class InfoEntry
	{
		[Token(Token = "0x20001A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD539AC", Offset = "0xD539AC")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object value;

			[Token(Token = "0x6000C54")]
			[Address(RVA = "0x1063D10", Offset = "0x1063D10", VA = "0x1063D10")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000C55")]
			[Address(RVA = "0x1063D18", Offset = "0x1063D18", VA = "0x1063D18")]
			internal object <Create>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5440C", Offset = "0xD5440C")]
		private string <Title>k__BackingField;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5441C", Offset = "0xD5441C")]
		private bool <IsPrivate>k__BackingField;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Func<object> _valueGetter;

		[Token(Token = "0x17000067")]
		public string Title
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x1063A14", Offset = "0x1063A14", VA = "0x1063A14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57C80", Offset = "0xD57C80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x1063A1C", Offset = "0x1063A1C", VA = "0x1063A1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57C90", Offset = "0xD57C90")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public object Value
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x1063A24", Offset = "0x1063A24", VA = "0x1063A24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public bool IsPrivate
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x1063B8C", Offset = "0x1063B8C", VA = "0x1063B8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57CA0", Offset = "0xD57CA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x1063B94", Offset = "0x1063B94", VA = "0x1063B94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57CB0", Offset = "0xD57CB0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1063BA0", Offset = "0x1063BA0", VA = "0x1063BA0")]
		public static InfoEntry Create(string name, Func<object> getter, bool isPrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1063C30", Offset = "0x1063C30", VA = "0x1063C30")]
		public static InfoEntry Create(string name, object value, bool isPrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1063C28", Offset = "0x1063C28", VA = "0x1063C28")]
		public InfoEntry()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public enum DefaultTabs
	{
		[Token(Token = "0x4000228")]
		SystemInformation,
		[Token(Token = "0x4000229")]
		Options,
		[Token(Token = "0x400022A")]
		Console,
		[Token(Token = "0x400022B")]
		Profiler,
		[Token(Token = "0x400022C")]
		BugReporter
	}
	[Token(Token = "0x2000084")]
	public enum PinAlignment
	{
		[Token(Token = "0x400022E")]
		TopLeft,
		[Token(Token = "0x400022F")]
		TopRight,
		[Token(Token = "0x4000230")]
		BottomLeft,
		[Token(Token = "0x4000231")]
		BottomRight,
		[Token(Token = "0x4000232")]
		CenterLeft,
		[Token(Token = "0x4000233")]
		CenterRight,
		[Token(Token = "0x4000234")]
		TopCenter,
		[Token(Token = "0x4000235")]
		BottomCenter
	}
	[Token(Token = "0x2000085")]
	public enum ConsoleAlignment
	{
		[Token(Token = "0x4000237")]
		Top,
		[Token(Token = "0x4000238")]
		Bottom
	}
	[Token(Token = "0x2000086")]
	public class Settings : ScriptableObject
	{
		[Token(Token = "0x20001A3")]
		public enum ShortcutActions
		{
			[Token(Token = "0x40007D4")]
			None,
			[Token(Token = "0x40007D5")]
			OpenSystemInfoTab,
			[Token(Token = "0x40007D6")]
			OpenConsoleTab,
			[Token(Token = "0x40007D7")]
			OpenOptionsTab,
			[Token(Token = "0x40007D8")]
			OpenProfilerTab,
			[Token(Token = "0x40007D9")]
			OpenBugReporterTab,
			[Token(Token = "0x40007DA")]
			ClosePanel,
			[Token(Token = "0x40007DB")]
			OpenPanel,
			[Token(Token = "0x40007DC")]
			TogglePanel,
			[Token(Token = "0x40007DD")]
			ShowBugReportPopover,
			[Token(Token = "0x40007DE")]
			ToggleDockedConsole,
			[Token(Token = "0x40007DF")]
			ToggleDockedProfiler
		}

		[Token(Token = "0x20001A4")]
		public enum TriggerBehaviours
		{
			[Token(Token = "0x40007E1")]
			TripleTap,
			[Token(Token = "0x40007E2")]
			TapAndHold,
			[Token(Token = "0x40007E3")]
			DoubleTap
		}

		[Token(Token = "0x20001A5")]
		public enum TriggerEnableModes
		{
			[Token(Token = "0x40007E5")]
			Enabled,
			[Token(Token = "0x40007E6")]
			MobileOnly,
			[Token(Token = "0x40007E7")]
			Off,
			[Token(Token = "0x40007E8")]
			DevelopmentBuildsOnly
		}

		[Serializable]
		[Token(Token = "0x20001A6")]
		public sealed class KeyboardShortcut
		{
			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public ShortcutActions Action;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			public bool Alt;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[SerializeField]
			public bool Control;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			public KeyCode Key;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			public bool Shift;

			[Token(Token = "0x6000C56")]
			[Address(RVA = "0x12915C0", Offset = "0x12915C0", VA = "0x12915C0")]
			public KeyboardShortcut()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD539BC", Offset = "0xD539BC")]
		private sealed class <>c
		{
			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<int, bool> <>9__38_0;

			[Token(Token = "0x6000C58")]
			[Address(RVA = "0x1291CB4", Offset = "0x1291CB4", VA = "0x1291CB4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000C59")]
			[Address(RVA = "0x1291CBC", Offset = "0x1291CBC", VA = "0x1291CBC")]
			internal bool <set_EntryCode>b__38_0(int p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000239")]
		private const string ResourcesPath = "/usr/Resources/SRDebugger";

		[Token(Token = "0x400023A")]
		private const string ResourcesName = "Settings";

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Settings _instance;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _isEnabled;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _autoLoad;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private DefaultTabs _defaultTab;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TriggerEnableModes _triggerEnableMode;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TriggerBehaviours _triggerBehaviour;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _enableKeyboardShortcuts;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private KeyboardShortcut[] _keyboardShortcuts;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private KeyboardShortcut[] _newKeyboardShortcuts;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _keyboardModifierControl;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _keyboardModifierAlt;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		private bool _keyboardModifierShift;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		[SerializeField]
		private bool _keyboardEscapeClose;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool _enableBackgroundTransparency;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		[SerializeField]
		private bool _collapseDuplicateLogEntries;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		[SerializeField]
		private bool _richTextInConsole;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		[SerializeField]
		private bool _requireEntryCode;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _requireEntryCodeEveryTime;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int[] _entryCode;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _useDebugCamera;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int _debugLayer;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD5457C", Offset = "0xD5457C")]
		private float _debugCameraDepth;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _apiKey;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _enableBugReporter;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private DefaultTabs[] _disabledTabs;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private PinAlignment _profilerAlignment;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private PinAlignment _optionsAlignment;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ConsoleAlignment _consoleAlignment;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private PinAlignment _triggerPosition;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private int _maximumConsoleEntries;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private bool _enableEventSystemCreation;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		[SerializeField]
		private bool _automaticShowCursor;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _uiScale;

		[Token(Token = "0x1700006A")]
		public static Settings Instance
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x12910D4", Offset = "0x12910D4", VA = "0x12910D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public bool IsEnabled
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x1291710", Offset = "0x1291710", VA = "0x1291710")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		public bool AutoLoad
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x1291718", Offset = "0x1291718", VA = "0x1291718")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		public DefaultTabs DefaultTab
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x1291720", Offset = "0x1291720", VA = "0x1291720")]
			get
			{
				return default(DefaultTabs);
			}
		}

		[Token(Token = "0x1700006E")]
		public TriggerEnableModes EnableTrigger
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x1291728", Offset = "0x1291728", VA = "0x1291728")]
			get
			{
				return default(TriggerEnableModes);
			}
		}

		[Token(Token = "0x1700006F")]
		public TriggerBehaviours TriggerBehaviour
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x1291730", Offset = "0x1291730", VA = "0x1291730")]
			get
			{
				return default(TriggerBehaviours);
			}
		}

		[Token(Token = "0x17000070")]
		public bool EnableKeyboardShortcuts
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x1291738", Offset = "0x1291738", VA = "0x1291738")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public IList<KeyboardShortcut> KeyboardShortcuts
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x1291740", Offset = "0x1291740", VA = "0x1291740")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public bool KeyboardEscapeClose
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x1291748", Offset = "0x1291748", VA = "0x1291748")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		public bool EnableBackgroundTransparency
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x1291750", Offset = "0x1291750", VA = "0x1291750")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		public bool RequireCode
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x1291758", Offset = "0x1291758", VA = "0x1291758")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		public bool RequireEntryCodeEveryTime
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x1291760", Offset = "0x1291760", VA = "0x1291760")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000076")]
		public IList<int> EntryCode
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x1291768", Offset = "0x1291768", VA = "0x1291768")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x12917D8", Offset = "0x12917D8", VA = "0x12917D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public bool UseDebugCamera
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x12919C0", Offset = "0x12919C0", VA = "0x12919C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		public int DebugLayer
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x12919C8", Offset = "0x12919C8", VA = "0x12919C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000079")]
		public float DebugCameraDepth
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x12919D0", Offset = "0x12919D0", VA = "0x12919D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700007A")]
		public bool CollapseDuplicateLogEntries
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x12919D8", Offset = "0x12919D8", VA = "0x12919D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007B")]
		public bool RichTextInConsole
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x12919E0", Offset = "0x12919E0", VA = "0x12919E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		public string ApiKey
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x12919E8", Offset = "0x12919E8", VA = "0x12919E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public bool EnableBugReporter
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x12919F0", Offset = "0x12919F0", VA = "0x12919F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007E")]
		public IList<DefaultTabs> DisabledTabs
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x12919F8", Offset = "0x12919F8", VA = "0x12919F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public PinAlignment TriggerPosition
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x1291A00", Offset = "0x1291A00", VA = "0x1291A00")]
			get
			{
				return default(PinAlignment);
			}
		}

		[Token(Token = "0x17000080")]
		public PinAlignment ProfilerAlignment
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x1291A08", Offset = "0x1291A08", VA = "0x1291A08")]
			get
			{
				return default(PinAlignment);
			}
		}

		[Token(Token = "0x17000081")]
		public PinAlignment OptionsAlignment
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x1291A10", Offset = "0x1291A10", VA = "0x1291A10")]
			get
			{
				return default(PinAlignment);
			}
		}

		[Token(Token = "0x17000082")]
		public ConsoleAlignment ConsoleAlignment
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x1291A18", Offset = "0x1291A18", VA = "0x1291A18")]
			get
			{
				return default(ConsoleAlignment);
			}
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x1291A20", Offset = "0x1291A20", VA = "0x1291A20")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public int MaximumConsoleEntries
		{
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x1291A28", Offset = "0x1291A28", VA = "0x1291A28")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x1291A30", Offset = "0x1291A30", VA = "0x1291A30")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool EnableEventSystemGeneration
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x1291A38", Offset = "0x1291A38", VA = "0x1291A38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x1291A40", Offset = "0x1291A40", VA = "0x1291A40")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public bool AutomaticallyShowCursor
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x1291A4C", Offset = "0x1291A4C", VA = "0x1291A4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000086")]
		public float UIScale
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1291A54", Offset = "0x1291A54", VA = "0x1291A54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x1291A5C", Offset = "0x1291A5C", VA = "0x1291A5C")]
			set
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event PropertyChangedEventHandler PropertyChanged
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x12915C8", Offset = "0x12915C8", VA = "0x12915C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57CC0", Offset = "0xD57CC0")]
			add
			{
			}
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x129166C", Offset = "0x129166C", VA = "0x129166C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57CD0", Offset = "0xD57CD0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x12913DC", Offset = "0x12913DC", VA = "0x12913DC")]
		private static KeyboardShortcut[] GetDefaultKeyboardShortcuts()
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x129124C", Offset = "0x129124C", VA = "0x129124C")]
		private void UpgradeKeyboardShortcuts()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1291AD8", Offset = "0x1291AD8", VA = "0x1291AD8")]
		private void OnPropertyChanged(string propertyName)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x129119C", Offset = "0x129119C", VA = "0x129119C")]
		private static Settings GetOrCreateInstance()
		{
			return null;
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1291B6C", Offset = "0x1291B6C", VA = "0x1291B6C")]
		public Settings()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public static class VersionInfo
	{
		[Token(Token = "0x400025D")]
		public const string Version = "1.7.1";
	}
}
namespace SRDebugger.Scripts
{
	[Token(Token = "0x2000088")]
	public class DebuggerTabController : SRMonoBehaviourEx
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SRTab _aboutTabInstance;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DefaultTabs? _activeTab;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _hasStarted;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SRTab AboutTab;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54674", Offset = "0xD54674")]
		public SRTabController TabController;

		[Token(Token = "0x17000087")]
		public DefaultTabs? ActiveTab
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x106765C", Offset = "0x106765C", VA = "0x106765C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x10677C4", Offset = "0x10677C4", VA = "0x10677C4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1067C8C", Offset = "0x1067C8C", VA = "0x1067C8C")]
		public bool OpenTab(DefaultTabs tab)
		{
			return default(bool);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1068018", Offset = "0x1068018", VA = "0x1068018")]
		public void ShowAboutTab()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x10680B0", Offset = "0x10680B0", VA = "0x10680B0")]
		public DebuggerTabController()
		{
		}
	}
}
namespace SRDebugger.UI
{
	[Token(Token = "0x2000089")]
	public class ProfilerFPSLabel : SRMonoBehaviourEx
	{
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _nextUpdate;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "ImportAttribute", RVA = "0xD54684", Offset = "0xD54684")]
		private IProfilerService _profilerService;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float UpdateFrequency;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54694", Offset = "0xD54694")]
		[SerializeField]
		private Text _text;

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x129C50C", Offset = "0x129C50C", VA = "0x129C50C", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x129C54C", Offset = "0x129C54C", VA = "0x129C54C")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x129C6D8", Offset = "0x129C6D8", VA = "0x129C6D8")]
		public ProfilerFPSLabel()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class DebugPanelRoot : SRMonoBehaviourEx
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD546CC", Offset = "0xD546CC")]
		public Canvas Canvas;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD546DC", Offset = "0xD546DC")]
		public CanvasGroup CanvasGroup;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD546EC", Offset = "0xD546EC")]
		public DebuggerTabController TabController;

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1298394", Offset = "0x1298394", VA = "0x1298394")]
		public void Close()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1298474", Offset = "0x1298474", VA = "0x1298474")]
		public void CloseAndDestroy()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1298554", Offset = "0x1298554", VA = "0x1298554")]
		public DebugPanelRoot()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class MobileMenuController : SRMonoBehaviourEx
	{
		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Button _closeButton;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _maxMenuWidth;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _peekAmount;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _targetXPosition;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5471C", Offset = "0xD5471C")]
		public RectTransform Content;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5472C", Offset = "0xD5472C")]
		public RectTransform Menu;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5473C", Offset = "0xD5473C")]
		public Button OpenButton;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5474C", Offset = "0xD5474C")]
		public SRTabController TabController;

		[Token(Token = "0x17000088")]
		public float PeekAmount
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x129855C", Offset = "0x129855C", VA = "0x129855C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000089")]
		public float MaxMenuWidth
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x1298564", Offset = "0x1298564", VA = "0x1298564")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x129856C", Offset = "0x129856C", VA = "0x129856C", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1298C80", Offset = "0x1298C80", VA = "0x1298C80", Slot = "9")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1298850", Offset = "0x1298850", VA = "0x1298850")]
		private void CreateCloseButton()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1298E5C", Offset = "0x1298E5C", VA = "0x1298E5C")]
		private void SetRectSize(RectTransform rect)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1298F48", Offset = "0x1298F48", VA = "0x1298F48")]
		private void CloseButtonClicked()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1298F84", Offset = "0x1298F84", VA = "0x1298F84", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x12990B4", Offset = "0x12990B4", VA = "0x12990B4")]
		private void TabControllerOnActiveTabChanged(SRTabController srTabController, SRTab srTab)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x12990B8", Offset = "0x12990B8", VA = "0x12990B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD57CE0", Offset = "0xD57CE0")]
		public void Open()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1298F4C", Offset = "0x1298F4C", VA = "0x1298F4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD57D18", Offset = "0xD57D18")]
		public void Close()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x129912C", Offset = "0x129912C", VA = "0x129912C")]
		public MobileMenuController()
		{
		}
	}
}
namespace SRDebugger.UI.Tabs
{
	[Token(Token = "0x200008C")]
	public class BugReportTabController : SRMonoBehaviourEx, IEnableTab
	{
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5475C", Offset = "0xD5475C")]
		public BugReportSheetController BugReportSheetPrefab;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5476C", Offset = "0xD5476C")]
		public RectTransform Container;

		[Token(Token = "0x1700008A")]
		public bool IsEnabled
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x129C6E8", Offset = "0x129C6E8", VA = "0x129C6E8", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x129C708", Offset = "0x129C708", VA = "0x129C708", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x129C7E8", Offset = "0x129C7E8", VA = "0x129C7E8")]
		private void TakingScreenshot()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x129C8A0", Offset = "0x129C8A0", VA = "0x129C8A0")]
		private void ScreenshotComplete()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x129C95C", Offset = "0x129C95C", VA = "0x129C95C")]
		public BugReportTabController()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class ConsoleTabController : SRMonoBehaviourEx
	{
		[Token(Token = "0x4000274")]
		private const int MaxLength = 2600;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas _consoleCanvas;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isDirty;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5477C", Offset = "0xD5477C")]
		public ConsoleLogControl ConsoleLogControl;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5478C", Offset = "0xD5478C")]
		public Toggle PinToggle;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5479C", Offset = "0xD5479C")]
		public ScrollRect StackTraceScrollRect;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD547AC", Offset = "0xD547AC")]
		public Text StackTraceText;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD547BC", Offset = "0xD547BC")]
		public Toggle ToggleErrors;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD547CC", Offset = "0xD547CC")]
		public Text ToggleErrorsText;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD547DC", Offset = "0xD547DC")]
		public Toggle ToggleInfo;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD547EC", Offset = "0xD547EC")]
		public Text ToggleInfoText;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD547FC", Offset = "0xD547FC")]
		public Toggle ToggleWarnings;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5480C", Offset = "0xD5480C")]
		public Text ToggleWarningsText;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5481C", Offset = "0xD5481C")]
		public Toggle FilterToggle;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5482C", Offset = "0xD5482C")]
		public InputField FilterField;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5483C", Offset = "0xD5483C")]
		public GameObject FilterBarContainer;

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x129C964", Offset = "0x129C964", VA = "0x129C964", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x129D278", Offset = "0x129D278", VA = "0x129D278")]
		private void FilterToggleValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x129D328", Offset = "0x129D328", VA = "0x129D328")]
		private void FilterValueChanged(string filterText)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x129D3DC", Offset = "0x129D3DC", VA = "0x129D3DC")]
		private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x129D490", Offset = "0x129D490", VA = "0x129D490")]
		private void PinToggleValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x129D550", Offset = "0x129D550", VA = "0x129D550", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x129D664", Offset = "0x129D664", VA = "0x129D664", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x129D670", Offset = "0x129D670", VA = "0x129D670")]
		private void ConsoleLogSelectedItemChanged(object item)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x129D700", Offset = "0x129D700", VA = "0x129D700", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x129CD8C", Offset = "0x129CD8C", VA = "0x129CD8C")]
		private void PopulateStackTraceArea(ConsoleEntry entry)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x129CF38", Offset = "0x129CF38", VA = "0x129CF38")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x129D710", Offset = "0x129D710", VA = "0x129D710")]
		private void ConsoleOnUpdated(IConsoleService console)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x129D71C", Offset = "0x129D71C", VA = "0x129D71C")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x129D7E4", Offset = "0x129D7E4", VA = "0x129D7E4")]
		public ConsoleTabController()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x129D7EC", Offset = "0x129D7EC", VA = "0x129D7EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57D50", Offset = "0xD57D50")]
		private void <Start>b__16_0(bool isOn)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x129D7F8", Offset = "0x129D7F8", VA = "0x129D7F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57D60", Offset = "0xD57D60")]
		private void <Start>b__16_1(bool isOn)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x129D804", Offset = "0x129D804", VA = "0x129D804")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57D70", Offset = "0xD57D70")]
		private void <Start>b__16_2(bool isOn)
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class InfoTabController : SRMonoBehaviourEx
	{
		[Token(Token = "0x4000284")]
		public const char Tick = '✓';

		[Token(Token = "0x4000285")]
		public const char Cross = '×';

		[Token(Token = "0x4000286")]
		public const string NameColor = "#BCBCBC";

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, InfoBlock> _infoBlocks;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5484C", Offset = "0xD5484C")]
		public InfoBlock InfoBlockPrefab;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5485C", Offset = "0xD5485C")]
		public RectTransform LayoutContainer;

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x129D810", Offset = "0x129D810", VA = "0x129D810", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x129D814", Offset = "0x129D814", VA = "0x129D814")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x129DD94", Offset = "0x129DD94", VA = "0x129DD94")]
		private void FillInfoBlock(InfoBlock block, IList<InfoEntry> info)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x129DCEC", Offset = "0x129DCEC", VA = "0x129DCEC")]
		private InfoBlock CreateBlock(string title)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x129E4B0", Offset = "0x129E4B0", VA = "0x129E4B0")]
		public InfoTabController()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class OptionsTabController : SRMonoBehaviourEx
	{
		[Token(Token = "0x20001A8")]
		private class CategoryInstance
		{
			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD569AC", Offset = "0xD569AC")]
			private CategoryGroup <CategoryGroup>k__BackingField;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly List<OptionsControlBase> Options;

			[Token(Token = "0x17000250")]
			public CategoryGroup CategoryGroup
			{
				[Token(Token = "0x6000C5A")]
				[Address(RVA = "0x12A0568", Offset = "0x12A0568", VA = "0x12A0568")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5955C", Offset = "0xD5955C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000C5B")]
				[Address(RVA = "0x12A0570", Offset = "0x12A0570", VA = "0x12A0570")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5956C", Offset = "0xD5956C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000C5C")]
			[Address(RVA = "0x12A0350", Offset = "0x12A0350", VA = "0x12A0350")]
			public CategoryInstance(CategoryGroup group)
			{
			}
		}

		[Token(Token = "0x20001A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD539CC", Offset = "0xD539CC")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public OptionsTabController <>4__this;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CategoryInstance categoryInstance;

			[Token(Token = "0x6000C5D")]
			[Address(RVA = "0x12A0348", Offset = "0x12A0348", VA = "0x12A0348")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000C5E")]
			[Address(RVA = "0x12A0540", Offset = "0x12A0540", VA = "0x12A0540")]
			internal void <CreateCategory>b__1(bool b)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD539DC", Offset = "0xD539DC")]
		private sealed class <>c
		{
			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<OptionDefinition> <>9__30_0;

			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x12A04F8", Offset = "0x12A04F8", VA = "0x12A04F8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000C61")]
			[Address(RVA = "0x12A0500", Offset = "0x12A0500", VA = "0x12A0500")]
			internal int <CreateCategory>b__30_0(OptionDefinition d1, OptionDefinition d2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<OptionsControlBase> _controls;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly List<CategoryInstance> _categories;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly Dictionary<OptionDefinition, OptionsControlBase> _options;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _queueRefresh;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _selectionModeEnabled;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Canvas _optionCanvas;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5486C", Offset = "0xD5486C")]
		public ActionControl ActionControlPrefab;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5487C", Offset = "0xD5487C")]
		public CategoryGroup CategoryGroupPrefab;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5488C", Offset = "0xD5488C")]
		public RectTransform ContentContainer;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5489C", Offset = "0xD5489C")]
		public GameObject NoOptionsNotice;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD548AC", Offset = "0xD548AC")]
		public Toggle PinButton;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD548BC", Offset = "0xD548BC")]
		public GameObject PinPromptSpacer;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD548CC", Offset = "0xD548CC")]
		public GameObject PinPromptText;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool _isTogglingCategory;

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x129E520", Offset = "0x129E520", VA = "0x129E520", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x129ED10", Offset = "0x129ED10", VA = "0x129ED10")]
		private void OnOptionPinnedStateChanged(OptionDefinition optionDefinition, bool isPinned)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x129EDB8", Offset = "0x129EDB8", VA = "0x129EDB8")]
		private void OnOptionsUpdated(object sender, EventArgs eventArgs)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x129EF60", Offset = "0x129EF60", VA = "0x129EF60")]
		private void OnOptionsValueChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x129EF6C", Offset = "0x129EF6C", VA = "0x129EF6C", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x129F06C", Offset = "0x129F06C", VA = "0x129F06C", Slot = "9")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x129F464", Offset = "0x129F464", VA = "0x129F464", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x129F628", Offset = "0x129F628", VA = "0x129F628")]
		private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x129F194", Offset = "0x129F194", VA = "0x129F194")]
		public void SetSelectionModeEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x129F478", Offset = "0x129F478", VA = "0x129F478")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x129F8B0", Offset = "0x129F8B0", VA = "0x129F8B0")]
		private void CommitPinnedOptions()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x129F700", Offset = "0x129F700", VA = "0x129F700")]
		private void RefreshCategorySelection()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x129FC30", Offset = "0x129FC30", VA = "0x129FC30")]
		private void OnOptionSelectionToggle(bool selected)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x129FC60", Offset = "0x129FC60", VA = "0x129FC60")]
		private void OnCategorySelectionToggle(CategoryInstance category, bool selected)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x129E808", Offset = "0x129E808", VA = "0x129E808")]
		protected void Populate()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x129FD20", Offset = "0x129FD20", VA = "0x129FD20")]
		protected void CreateCategory(string title, List<OptionDefinition> options)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x129EDDC", Offset = "0x129EDDC", VA = "0x129EDDC")]
		private void Clear()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x12A03D4", Offset = "0x12A03D4", VA = "0x12A03D4")]
		public OptionsTabController()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class ProfilerTabController : SRMonoBehaviourEx
	{
		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _isDirty;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD548DC", Offset = "0xD548DC")]
		public Toggle PinToggle;

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x12A0578", Offset = "0x12A0578", VA = "0x12A0578", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x12A0708", Offset = "0x12A0708", VA = "0x12A0708")]
		private void PinToggleValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x12A07C8", Offset = "0x12A07C8", VA = "0x12A07C8", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x12A07D4", Offset = "0x12A07D4", VA = "0x12A07D4", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x12A0624", Offset = "0x12A0624", VA = "0x12A0624")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x12A07E4", Offset = "0x12A07E4", VA = "0x12A07E4")]
		public ProfilerTabController()
		{
		}
	}
}
namespace SRDebugger.UI.Other
{
	[Token(Token = "0x2000091")]
	public class BugReportPopoverRoot : SRMonoBehaviourEx
	{
		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD548EC", Offset = "0xD548EC")]
		public CanvasGroup CanvasGroup;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD548FC", Offset = "0xD548FC")]
		public RectTransform Container;

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1299140", Offset = "0x1299140", VA = "0x1299140")]
		public BugReportPopoverRoot()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class BugReportSheetController : SRMonoBehaviourEx
	{
		[Token(Token = "0x20001AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD539EC", Offset = "0xD539EC")]
		private sealed class <SubmitCo>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BugReportSheetController <>4__this;

			[Token(Token = "0x17000251")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C65")]
				[Address(RVA = "0x1299BD8", Offset = "0x1299BD8", VA = "0x1299BD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000252")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C67")]
				[Address(RVA = "0x1299C40", Offset = "0x1299C40", VA = "0x1299C40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C62")]
			[Address(RVA = "0x1299588", Offset = "0x1299588", VA = "0x1299588")]
			[DebuggerHidden]
			public <SubmitCo>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000C63")]
			[Address(RVA = "0x1299824", Offset = "0x1299824", VA = "0x1299824", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C64")]
			[Address(RVA = "0x1299828", Offset = "0x1299828", VA = "0x1299828", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C66")]
			[Address(RVA = "0x1299BE0", Offset = "0x1299BE0", VA = "0x1299BE0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5490C", Offset = "0xD5490C")]
		public GameObject ButtonContainer;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5491C", Offset = "0xD5491C")]
		public Text ButtonText;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5492C", Offset = "0xD5492C")]
		public Button CancelButton;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Action CancelPressed;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5493C", Offset = "0xD5493C")]
		public InputField DescriptionField;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5494C", Offset = "0xD5494C")]
		public InputField EmailField;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5495C", Offset = "0xD5495C")]
		public Slider ProgressBar;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5496C", Offset = "0xD5496C")]
		public Text ResultMessageText;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Action ScreenshotComplete;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5497C", Offset = "0xD5497C")]
		public Button SubmitButton;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Action<bool, string> SubmitComplete;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Action TakingScreenshot;

		[Token(Token = "0x1700008B")]
		public bool IsCancelButtonEnabled
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x1299148", Offset = "0x1299148", VA = "0x1299148")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x1299174", Offset = "0x1299174", VA = "0x1299174")]
			set
			{
			}
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x12991B0", Offset = "0x12991B0", VA = "0x12991B0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1299334", Offset = "0x1299334", VA = "0x1299334")]
		public void Submit()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1299574", Offset = "0x1299574", VA = "0x1299574")]
		public void Cancel()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1299504", Offset = "0x1299504", VA = "0x1299504")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD57D80", Offset = "0xD57D80")]
		private IEnumerator SubmitCo()
		{
			return null;
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x12995B4", Offset = "0x12995B4", VA = "0x12995B4")]
		private void OnBugReportProgress(float progress)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x12995D8", Offset = "0x12995D8", VA = "0x12995D8")]
		private void OnBugReportComplete(bool didSucceed, string errorMessage)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x12991E0", Offset = "0x12991E0", VA = "0x12991E0")]
		protected void SetLoadingSpinnerVisible(bool visible)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x12992BC", Offset = "0x12992BC", VA = "0x12992BC")]
		protected void ClearForm()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x12996A4", Offset = "0x12996A4", VA = "0x12996A4")]
		protected void ShowErrorMessage(string userMessage, [Optional] string serverMessage)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1299238", Offset = "0x1299238", VA = "0x1299238")]
		protected void ClearErrorMessage()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1299428", Offset = "0x1299428", VA = "0x1299428")]
		protected void SetFormEnabled(bool e)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x12997C4", Offset = "0x12997C4", VA = "0x12997C4")]
		private string GetDefaultEmailFieldContents()
		{
			return null;
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x12994A8", Offset = "0x12994A8", VA = "0x12994A8")]
		private void SetDefaultEmailFieldContents(string value)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x129981C", Offset = "0x129981C", VA = "0x129981C")]
		public BugReportSheetController()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class CategoryGroup : SRMonoBehaviourEx
	{
		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5498C", Offset = "0xD5498C")]
		public RectTransform Container;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5499C", Offset = "0xD5499C")]
		public Text Header;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD549AC", Offset = "0xD549AC")]
		public GameObject Background;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD549BC", Offset = "0xD549BC")]
		public Toggle SelectionToggle;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject[] EnabledDuringSelectionMode;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _selectionModeEnabled;

		[Token(Token = "0x1700008C")]
		public bool IsSelected
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x1299C48", Offset = "0x1299C48", VA = "0x1299C48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x1299C64", Offset = "0x1299C64", VA = "0x1299C64")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool SelectionModeEnabled
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x1299D5C", Offset = "0x1299D5C", VA = "0x1299D5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x1299D64", Offset = "0x1299D64", VA = "0x1299D64")]
			set
			{
			}
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1299DF0", Offset = "0x1299DF0", VA = "0x1299DF0")]
		public CategoryGroup()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD5200C", Offset = "0xD5200C")]
	public class ConfigureCanvasFromSettings : SRMonoBehaviour
	{
		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas _canvas;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CanvasScaler _canvasScaler;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _originalScale;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _lastSetScale;

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1299E58", Offset = "0x1299E58", VA = "0x1299E58")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x129A04C", Offset = "0x129A04C", VA = "0x129A04C")]
		private void SettingsOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x129A164", Offset = "0x129A164", VA = "0x129A164")]
		public ConfigureCanvasFromSettings()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class ConsoleTabQuickViewControl : SRMonoBehaviourEx
	{
		[Token(Token = "0x40002B2")]
		private const int Max = 1000;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string MaxString;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _prevErrorCount;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _prevInfoCount;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _prevWarningCount;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "ImportAttribute", RVA = "0xD549CC", Offset = "0xD549CC")]
		public IConsoleService ConsoleService;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD549DC", Offset = "0xD549DC")]
		public Text ErrorCountText;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD549EC", Offset = "0xD549EC")]
		public Text InfoCountText;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD549FC", Offset = "0xD549FC")]
		public Text WarningCountText;

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x129A174", Offset = "0x129A174", VA = "0x129A174", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x129A21C", Offset = "0x129A21C", VA = "0x129A21C", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x129A6C0", Offset = "0x129A6C0", VA = "0x129A6C0")]
		private static bool HasChanged(int newCount, ref int oldCount, int max)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x129A76C", Offset = "0x129A76C", VA = "0x129A76C")]
		public ConsoleTabQuickViewControl()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD52070", Offset = "0xD52070")]
	public class DebugPanelBackgroundBehaviour : SRMonoBehaviour
	{
		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string _defaultKey;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isTransparent;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private StyleComponent _styleComponent;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string TransparentStyleKey;

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x129A804", Offset = "0x129A804", VA = "0x129A804")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x129A870", Offset = "0x129A870", VA = "0x129A870")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x129A8FC", Offset = "0x129A8FC", VA = "0x129A8FC")]
		public DebugPanelBackgroundBehaviour()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x40002BF")]
		public const float NonFocusOpacity = 0.65f;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _isDirty;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool _isDragging;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _pointersOver;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54A0C", Offset = "0xD54A0C")]
		public GameObject BottomHandle;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54A1C", Offset = "0xD54A1C")]
		public CanvasGroup CanvasGroup;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54A2C", Offset = "0xD54A2C")]
		public ConsoleLogControl Console;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54A3C", Offset = "0xD54A3C")]
		public GameObject Dropdown;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54A4C", Offset = "0xD54A4C")]
		public Image DropdownToggleSprite;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54A5C", Offset = "0xD54A5C")]
		public Text TextErrors;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54A6C", Offset = "0xD54A6C")]
		public Text TextInfo;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54A7C", Offset = "0xD54A7C")]
		public Text TextWarnings;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54A8C", Offset = "0xD54A8C")]
		public Toggle ToggleErrors;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54A9C", Offset = "0xD54A9C")]
		public Toggle ToggleInfo;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54AAC", Offset = "0xD54AAC")]
		public Toggle ToggleWarnings;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54ABC", Offset = "0xD54ABC")]
		public GameObject TopBar;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54ACC", Offset = "0xD54ACC")]
		public GameObject TopHandle;

		[Token(Token = "0x1700008E")]
		public bool IsVisible
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x129A954", Offset = "0x129A954", VA = "0x129A954")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x129AA04", Offset = "0x129AA04", VA = "0x129AA04")]
			set
			{
			}
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x129AA34", Offset = "0x129AA34", VA = "0x129AA34", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x129ADD8", Offset = "0x129ADD8", VA = "0x129ADD8", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x129AEEC", Offset = "0x129AEEC", VA = "0x129AEEC", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x129AEF8", Offset = "0x129AEF8", VA = "0x129AEF8", Slot = "9")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x129AF00", Offset = "0x129AF00", VA = "0x129AF00", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x129AF10", Offset = "0x129AF10", VA = "0x129AF10")]
		private void ConsoleOnUpdated(IConsoleService console)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x129AF1C", Offset = "0x129AF1C", VA = "0x129AF1C")]
		public void SetDropdownVisibility(bool visible)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x129AFF0", Offset = "0x129AFF0", VA = "0x129AFF0")]
		public void SetAlignmentMode(ConsoleAlignment alignment)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x129AB3C", Offset = "0x129AB3C", VA = "0x129AB3C")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x129AD8C", Offset = "0x129AD8C", VA = "0x129AD8C")]
		private void RefreshAlpha()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x129B21C", Offset = "0x129B21C", VA = "0x129B21C")]
		public void ToggleDropdownVisible()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x129B258", Offset = "0x129B258", VA = "0x129B258")]
		public void MenuButtonPressed()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x129B318", Offset = "0x129B318", VA = "0x129B318")]
		public void ClearButtonPressed()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x129B3D0", Offset = "0x129B3D0", VA = "0x129B3D0")]
		public void TogglesUpdated()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x129B448", Offset = "0x129B448", VA = "0x129B448", Slot = "11")]
		public void OnPointerEnter(PointerEventData e)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x129B454", Offset = "0x129B454", VA = "0x129B454", Slot = "12")]
		public void OnPointerExit(PointerEventData e)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x129B45C", Offset = "0x129B45C", VA = "0x129B45C")]
		public void OnBeginDrag()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x129B468", Offset = "0x129B468", VA = "0x129B468")]
		public void OnEndDrag()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x129B474", Offset = "0x129B474", VA = "0x129B474")]
		public DockConsoleController()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class HandleManager : SRMonoBehaviour
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _hasSet;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject BottomHandle;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject BottomLeftHandle;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject BottomRightHandle;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public PinAlignment DefaultAlignment;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject LeftHandle;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GameObject RightHandle;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public GameObject TopHandle;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GameObject TopLeftHandle;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject TopRightHandle;

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x129B47C", Offset = "0x129B47C", VA = "0x129B47C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x129B490", Offset = "0x129B490", VA = "0x129B490")]
		public void SetAlignment(PinAlignment alignment)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x129B62C", Offset = "0x129B62C", VA = "0x129B62C")]
		private void SetActive(GameObject obj, bool active)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x129B6D0", Offset = "0x129B6D0", VA = "0x129B6D0")]
		public HandleManager()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public interface IEnableTab
	{
		[Token(Token = "0x1700008F")]
		bool IsEnabled
		{
			[Token(Token = "0x60004E1")]
			get;
		}
	}
	[Token(Token = "0x200009A")]
	public class LoadingSpinnerBehaviour : SRMonoBehaviour
	{
		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _dt;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int FrameCount;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float SpinDuration;

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x129B6D8", Offset = "0x129B6D8", VA = "0x129B6D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x129B80C", Offset = "0x129B80C", VA = "0x129B80C")]
		public LoadingSpinnerBehaviour()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class PinnedUIRoot : SRMonoBehaviourEx
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54ADC", Offset = "0xD54ADC")]
		public Canvas Canvas;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54AEC", Offset = "0xD54AEC")]
		public RectTransform Container;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54AFC", Offset = "0xD54AFC")]
		public DockConsoleController DockConsoleController;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54B0C", Offset = "0xD54B0C")]
		public GameObject Options;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54B1C", Offset = "0xD54B1C")]
		public FlowLayoutGroup OptionsLayoutGroup;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54B2C", Offset = "0xD54B2C")]
		public GameObject Profiler;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54B3C", Offset = "0xD54B3C")]
		public HandleManager ProfilerHandleManager;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54B4C", Offset = "0xD54B4C")]
		public VerticalLayoutGroup ProfilerVerticalLayoutGroup;

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x129B824", Offset = "0x129B824", VA = "0x129B824")]
		public PinnedUIRoot()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class SRTab : SRMonoBehaviourEx
	{
		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public RectTransform HeaderExtraContent;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xD54B5C", Offset = "0xD54B5C")]
		[HideInInspector]
		public Sprite Icon;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RectTransform IconExtraContent;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string IconStyleKey;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int SortIndex;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public SRTabButton TabButton;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD54BA4", Offset = "0xD54BA4")]
		private string _title;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _longTitle;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string _key;

		[Token(Token = "0x17000090")]
		public string Title
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x129B82C", Offset = "0x129B82C", VA = "0x129B82C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
		public string LongTitle
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x129B834", Offset = "0x129B834", VA = "0x129B834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000092")]
		public string Key
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x129B870", Offset = "0x129B870", VA = "0x129B870")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x129B878", Offset = "0x129B878", VA = "0x129B878")]
		public SRTab()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class SRTabController : SRMonoBehaviourEx
	{
		[Token(Token = "0x20001AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD539FC", Offset = "0xD539FC")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SRTabController <>4__this;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SRTab tab;

			[Token(Token = "0x6000C68")]
			[Address(RVA = "0x129BF0C", Offset = "0x129BF0C", VA = "0x129BF0C")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000C69")]
			[Address(RVA = "0x129C1CC", Offset = "0x129C1CC", VA = "0x129C1CC")]
			internal void <AddTab>b__0()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD53A0C", Offset = "0xD53A0C")]
		private sealed class <>c
		{
			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<SRTab> <>9__17_0;

			[Token(Token = "0x6000C6B")]
			[Address(RVA = "0x129C198", Offset = "0x129C198", VA = "0x129C198")]
			public <>c()
			{
			}

			[Token(Token = "0x6000C6C")]
			[Address(RVA = "0x129C1A0", Offset = "0x129C1A0", VA = "0x129C1A0")]
			internal int <SortTabs>b__17_0(SRTab t1, SRTab t2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly SRList<SRTab> _tabs;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SRTab _activeTab;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54C10", Offset = "0xD54C10")]
		public RectTransform TabButtonContainer;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54C20", Offset = "0xD54C20")]
		public SRTabButton TabButtonPrefab;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54C30", Offset = "0xD54C30")]
		public RectTransform TabContentsContainer;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54C40", Offset = "0xD54C40")]
		public RectTransform TabHeaderContentContainer;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54C50", Offset = "0xD54C50")]
		public Text TabHeaderText;

		[Token(Token = "0x17000093")]
		public SRTab ActiveTab
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x129B8D0", Offset = "0x129B8D0", VA = "0x129B8D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x129B8D8", Offset = "0x129B8D8", VA = "0x129B8D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public IList<SRTab> Tabs
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x129BC3C", Offset = "0x129BC3C", VA = "0x129BC3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<SRTabController, SRTab> ActiveTabChanged
		{
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x1298BDC", Offset = "0x1298BDC", VA = "0x1298BDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57DE4", Offset = "0xD57DE4")]
			add
			{
			}
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x1298DB8", Offset = "0x1298DB8", VA = "0x1298DB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57DF4", Offset = "0xD57DF4")]
			remove
			{
			}
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x129BC94", Offset = "0x129BC94", VA = "0x129BC94")]
		public void AddTab(SRTab tab, bool visibleInSidebar = true)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x129B8DC", Offset = "0x129B8DC", VA = "0x129B8DC")]
		private void MakeActive(SRTab tab)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x129BF14", Offset = "0x129BF14", VA = "0x129BF14")]
		private void SortTabs()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x129C0C4", Offset = "0x129C0C4", VA = "0x129C0C4")]
		public SRTabController()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD520D4", Offset = "0xD520D4")]
	[ExecuteInEditMode]
	public class ScrollRectPatch : MonoBehaviour
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform Content;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mask ReplaceMask;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RectTransform Viewport;

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x129C1EC", Offset = "0x129C1EC", VA = "0x129C1EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x129C338", Offset = "0x129C338", VA = "0x129C338")]
		public ScrollRectPatch()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD52148", Offset = "0xD52148")]
	public class ScrollSettingsBehaviour : MonoBehaviour
	{
		[Token(Token = "0x40002F9")]
		public const float ScrollSensitivity = 40f;

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x129C340", Offset = "0x129C340", VA = "0x129C340")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x129C3C0", Offset = "0x129C3C0", VA = "0x129C3C0")]
		public ScrollSettingsBehaviour()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class SetLayerFromSettings : SRMonoBehaviour
	{
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x129C3C8", Offset = "0x129C3C8", VA = "0x129C3C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x129C430", Offset = "0x129C430", VA = "0x129C430")]
		public SetLayerFromSettings()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class TriggerRoot : SRMonoBehaviourEx
	{
		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54C70", Offset = "0xD54C70")]
		public Canvas Canvas;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54C80", Offset = "0xD54C80")]
		public LongPressButton TapHoldButton;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54C90", Offset = "0xD54C90")]
		public RectTransform TriggerTransform;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54CA0", Offset = "0xD54CA0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD54CA0", Offset = "0xD54CA0")]
		public MultiTapButton TripleTapButton;

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x129C438", Offset = "0x129C438", VA = "0x129C438")]
		public TriggerRoot()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class VersionTextBehaviour : SRMonoBehaviourEx
	{
		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Format;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54CEC", Offset = "0xD54CEC")]
		public Text Text;

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x129C440", Offset = "0x129C440", VA = "0x129C440", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x129C4B4", Offset = "0x129C4B4", VA = "0x129C4B4")]
		public VersionTextBehaviour()
		{
		}
	}
}
namespace SRDebugger.UI.Controls
{
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD521AC", Offset = "0xD521AC")]
	public class ConsoleEntryView : SRMonoBehaviourEx, IVirtualView
	{
		[Token(Token = "0x4000300")]
		public const string ConsoleBlobInfo = "Console_Info_Blob";

		[Token(Token = "0x4000301")]
		public const string ConsoleBlobWarning = "Console_Warning_Blob";

		[Token(Token = "0x4000302")]
		public const string ConsoleBlobError = "Console_Error_Blob";

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _count;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool _hasCount;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ConsoleEntry _prevData;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransform;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54CFC", Offset = "0xD54CFC")]
		public Text Count;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54D0C", Offset = "0xD54D0C")]
		public CanvasGroup CountContainer;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54D1C", Offset = "0xD54D1C")]
		public StyleComponent ImageStyle;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54D2C", Offset = "0xD54D2C")]
		public Text Message;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54D3C", Offset = "0xD54D3C")]
		public Text StackTrace;

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1291CC8", Offset = "0x1291CC8", VA = "0x1291CC8", Slot = "11")]
		public void SetDataContext(object data)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1291F9C", Offset = "0x1291F9C", VA = "0x1291F9C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x12920E4", Offset = "0x12920E4", VA = "0x12920E4")]
		public ConsoleEntryView()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class ConsoleLogControl : SRMonoBehaviourEx
	{
		[Token(Token = "0x20001AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD53A1C", Offset = "0xD53A1C")]
		private sealed class <ScrollToBottom>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ConsoleLogControl <>4__this;

			[Token(Token = "0x17000253")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C70")]
				[Address(RVA = "0x1292B68", Offset = "0x1292B68", VA = "0x1292B68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000254")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C72")]
				[Address(RVA = "0x1292BD0", Offset = "0x1292BD0", VA = "0x1292BD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C6D")]
			[Address(RVA = "0x12923DC", Offset = "0x12923DC", VA = "0x12923DC")]
			[DebuggerHidden]
			public <ScrollToBottom>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000C6E")]
			[Address(RVA = "0x12929F8", Offset = "0x12929F8", VA = "0x12929F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C6F")]
			[Address(RVA = "0x12929FC", Offset = "0x12929FC", VA = "0x12929FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C71")]
			[Address(RVA = "0x1292B70", Offset = "0x1292B70", VA = "0x1292B70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54D4C", Offset = "0xD54D4C")]
		[SerializeField]
		private VirtualVerticalLayoutGroup _consoleScrollLayoutGroup;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54D84", Offset = "0xD54D84")]
		[SerializeField]
		private ScrollRect _consoleScrollRect;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isDirty;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector2? _scrollPosition;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _showErrors;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _showInfo;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _showWarnings;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Action<ConsoleEntry> SelectedItemChanged;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string _filter;

		[Token(Token = "0x17000095")]
		public bool ShowErrors
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x12920F4", Offset = "0x12920F4", VA = "0x12920F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x12920FC", Offset = "0x12920FC", VA = "0x12920FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool ShowWarnings
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x129211C", Offset = "0x129211C", VA = "0x129211C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x1292124", Offset = "0x1292124", VA = "0x1292124")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public bool ShowInfo
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x1292138", Offset = "0x1292138", VA = "0x1292138")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x1292140", Offset = "0x1292140", VA = "0x1292140")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public bool EnableSelection
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x1292154", Offset = "0x1292154", VA = "0x1292154")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x1292170", Offset = "0x1292170", VA = "0x1292170")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public string Filter
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x1292190", Offset = "0x1292190", VA = "0x1292190")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x1292198", Offset = "0x1292198", VA = "0x1292198")]
			set
			{
			}
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x12921D4", Offset = "0x12921D4", VA = "0x12921D4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1292334", Offset = "0x1292334", VA = "0x1292334", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x129236C", Offset = "0x129236C", VA = "0x129236C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD57E04", Offset = "0xD57E04")]
		private IEnumerator ScrollToBottom()
		{
			return null;
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1292408", Offset = "0x1292408", VA = "0x1292408", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1292520", Offset = "0x1292520", VA = "0x1292520")]
		private void OnSelectedItemChanged(object arg0)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x12925D0", Offset = "0x12925D0", VA = "0x12925D0", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1292678", Offset = "0x1292678", VA = "0x1292678")]
		private void Refresh()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1292110", Offset = "0x1292110", VA = "0x1292110")]
		private void SetIsDirty()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x12929D4", Offset = "0x12929D4", VA = "0x12929D4")]
		private void ConsoleOnUpdated(IConsoleService console)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x12929E0", Offset = "0x12929E0", VA = "0x12929E0")]
		public ConsoleLogControl()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public abstract class DataBoundControl : OptionsControlBase
	{
		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _hasStarted;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _isReadOnly;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private object _prevValue;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private PropertyReference _prop;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD54DBC", Offset = "0xD54DBC")]
		private string <PropertyName>k__BackingField;

		[Token(Token = "0x1700009A")]
		public PropertyReference Property
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x12948F0", Offset = "0x12948F0", VA = "0x12948F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x12948F8", Offset = "0x12948F8", VA = "0x12948F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009C")]
		public string PropertyName
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x1294900", Offset = "0x1294900", VA = "0x1294900")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57E68", Offset = "0xD57E68")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x1294908", Offset = "0x1294908", VA = "0x1294908")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57E78", Offset = "0xD57E78")]
			private set
			{
			}
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1294910", Offset = "0x1294910", VA = "0x1294910")]
		public void Bind(string propertyName, PropertyReference prop)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1292F78", Offset = "0x1292F78", VA = "0x1292F78")]
		protected void UpdateValue(object newValue)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1294A98", Offset = "0x1294A98", VA = "0x1294A98", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1293010", Offset = "0x1293010", VA = "0x1293010", Slot = "12")]
		protected virtual void OnBind(string propertyName, Type t)
		{
		}

		[Token(Token = "0x600051A")]
		protected abstract void OnValueUpdated(object newValue);

		[Token(Token = "0x600051B")]
		public abstract bool CanBind(Type type, bool isReadOnly);

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1292ED8", Offset = "0x1292ED8", VA = "0x1292ED8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1294C18", Offset = "0x1294C18", VA = "0x1294C18", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1293134", Offset = "0x1293134", VA = "0x1293134")]
		protected DataBoundControl()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public abstract class OptionsControlBase : SRMonoBehaviourEx
	{
		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _selectionModeEnabled;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54DCC", Offset = "0xD54DCC")]
		public Toggle SelectionModeToggle;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OptionDefinition Option;

		[Token(Token = "0x1700009D")]
		public bool SelectionModeEnabled
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x1294DC8", Offset = "0x1294DC8", VA = "0x1294DC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x1294DD0", Offset = "0x1294DD0", VA = "0x1294DD0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public bool IsSelected
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x1294EF8", Offset = "0x1294EF8", VA = "0x1294EF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x1294F14", Offset = "0x1294F14", VA = "0x1294F14")]
			set
			{
			}
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x129500C", Offset = "0x129500C", VA = "0x129500C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1294C58", Offset = "0x1294C58", VA = "0x1294C58", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1295060", Offset = "0x1295060", VA = "0x1295060", Slot = "11")]
		public virtual void Refresh()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1292E14", Offset = "0x1292E14", VA = "0x1292E14")]
		protected OptionsControlBase()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class InfoBlock : SRMonoBehaviourEx
	{
		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54DDC", Offset = "0xD54DDC")]
		public Text Content;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54DEC", Offset = "0xD54DEC")]
		public Text Title;

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1294D34", Offset = "0x1294D34", VA = "0x1294D34")]
		public InfoBlock()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class MultiTapButton : Button
	{
		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float _lastTap;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int _tapCount;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public int RequiredTapCount;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float ResetTime;

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1294D3C", Offset = "0x1294D3C", VA = "0x1294D3C", Slot = "41")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1294DB4", Offset = "0x1294DB4", VA = "0x1294DB4")]
		public MultiTapButton()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public delegate void PinEntryControlCallback(IList<int> result, bool didCancel);
	[Token(Token = "0x20000AA")]
	public class PinEntryControl : SRMonoBehaviourEx
	{
		[Token(Token = "0x20001AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD53A2C", Offset = "0xD53A2C")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int number;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PinEntryControl <>4__this;

			[Token(Token = "0x6000C73")]
			[Address(RVA = "0x1295318", Offset = "0x1295318", VA = "0x1295318")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000C74")]
			[Address(RVA = "0x1295E20", Offset = "0x1295E20", VA = "0x1295E20")]
			internal void <Awake>b__0()
			{
			}
		}

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _isVisible;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<int> _numbers;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54DFC", Offset = "0xD54DFC")]
		public Image Background;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool CanCancel;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54E0C", Offset = "0xD54E0C")]
		public Button CancelButton;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54E1C", Offset = "0xD54E1C")]
		public Text CancelButtonText;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54E2C", Offset = "0xD54E2C")]
		public CanvasGroup CanvasGroup;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54E3C", Offset = "0xD54E3C")]
		public Animator DotAnimator;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Button[] NumberButtons;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Toggle[] NumberDots;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54E4C", Offset = "0xD54E4C")]
		public Text PromptText;

		[Token(Token = "0x14000005")]
		public event PinEntryControlCallback Complete
		{
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x1295064", Offset = "0x1295064", VA = "0x1295064")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57E88", Offset = "0xD57E88")]
			add
			{
			}
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x1295108", Offset = "0x1295108", VA = "0x1295108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD57E98", Offset = "0xD57E98")]
			remove
			{
			}
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x12951AC", Offset = "0x12951AC", VA = "0x12951AC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x129542C", Offset = "0x129542C", VA = "0x129542C", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1295664", Offset = "0x1295664", VA = "0x1295664")]
		public void Show()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x12956D0", Offset = "0x12956D0", VA = "0x12956D0")]
		public void Hide()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1295730", Offset = "0x1295730", VA = "0x1295730")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1295790", Offset = "0x1295790", VA = "0x1295790")]
		public void PlayInvalidCodeAnimation()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x12957EC", Offset = "0x12957EC", VA = "0x12957EC")]
		protected void OnComplete()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1295CAC", Offset = "0x1295CAC", VA = "0x1295CAC")]
		protected void OnCancel()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1295D20", Offset = "0x1295D20", VA = "0x1295D20")]
		private void CancelButtonPressed()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x129558C", Offset = "0x129558C", VA = "0x129558C")]
		public void PushNumber(int number)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1295320", Offset = "0x1295320", VA = "0x1295320")]
		private void RefreshState()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1295D98", Offset = "0x1295D98", VA = "0x1295D98")]
		public PinEntryControl()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class ProfilerMemoryBlock : SRMonoBehaviourEx
	{
		[Token(Token = "0x20001B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD53A3C", Offset = "0xD53A3C")]
		private sealed class <CleanUp>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ProfilerMemoryBlock <>4__this;

			[Token(Token = "0x17000255")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C78")]
				[Address(RVA = "0x1297EC0", Offset = "0x1297EC0", VA = "0x1297EC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000256")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C7A")]
				[Address(RVA = "0x1297F28", Offset = "0x1297F28", VA = "0x1297F28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C75")]
			[Address(RVA = "0x1297DA8", Offset = "0x1297DA8", VA = "0x1297DA8")]
			[DebuggerHidden]
			public <CleanUp>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000C76")]
			[Address(RVA = "0x1297DDC", Offset = "0x1297DDC", VA = "0x1297DDC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C77")]
			[Address(RVA = "0x1297DE0", Offset = "0x1297DE0", VA = "0x1297DE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C79")]
			[Address(RVA = "0x1297EC8", Offset = "0x1297EC8", VA = "0x1297EC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _lastRefresh;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54E6C", Offset = "0xD54E6C")]
		public Text CurrentUsedText;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54E7C", Offset = "0xD54E7C")]
		public Slider Slider;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54E8C", Offset = "0xD54E8C")]
		public Text TotalAllocatedText;

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1297A14", Offset = "0x1297A14", VA = "0x1297A14", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1297C18", Offset = "0x1297C18", VA = "0x1297C18", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1297A18", Offset = "0x1297A18", VA = "0x1297A18")]
		public void TriggerRefresh()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1297D0C", Offset = "0x1297D0C", VA = "0x1297D0C")]
		public void TriggerCleanup()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1297D38", Offset = "0x1297D38", VA = "0x1297D38")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD57EA8", Offset = "0xD57EA8")]
		private IEnumerator CleanUp()
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1297DD4", Offset = "0x1297DD4", VA = "0x1297DD4")]
		public ProfilerMemoryBlock()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class ProfilerMonoBlock : SRMonoBehaviourEx
	{
		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _lastRefresh;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54E9C", Offset = "0xD54E9C")]
		public Text CurrentUsedText;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54EAC", Offset = "0xD54EAC")]
		public GameObject NotSupportedMessage;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54EBC", Offset = "0xD54EBC")]
		public Slider Slider;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54ECC", Offset = "0xD54ECC")]
		public Text TotalAllocatedText;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _isSupported;

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1297F30", Offset = "0x1297F30", VA = "0x1297F30", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x12981E8", Offset = "0x12981E8", VA = "0x12981E8", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1297FA4", Offset = "0x1297FA4", VA = "0x1297FA4")]
		public void TriggerRefresh()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x12982DC", Offset = "0x12982DC", VA = "0x12982DC")]
		public void TriggerCollection()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1298348", Offset = "0x1298348", VA = "0x1298348")]
		public ProfilerMonoBlock()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class ProfilerEnableControl : SRMonoBehaviourEx
	{
		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _previousState;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54EDC", Offset = "0xD54EDC")]
		public Text ButtonText;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54EEC", Offset = "0xD54EEC")]
		public Button EnableButton;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54EFC", Offset = "0xD54EFC")]
		public Text Text;

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1295EFC", Offset = "0x1295EFC", VA = "0x1295EFC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1296034", Offset = "0x1296034", VA = "0x1296034")]
		protected void UpdateLabels()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x129616C", Offset = "0x129616C", VA = "0x129616C", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x12961B4", Offset = "0x12961B4", VA = "0x12961B4")]
		public void ToggleProfiler()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1296238", Offset = "0x1296238", VA = "0x1296238")]
		public ProfilerEnableControl()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD52210", Offset = "0xD52210")]
	public class ProfilerGraphAxisLabel : SRMonoBehaviourEx
	{
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _prevFrameTime;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float? _queuedFrameTime;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _yPosition;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54F0C", Offset = "0xD54F0C")]
		public Text Text;

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1296240", Offset = "0x1296240", VA = "0x1296240", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x12964D4", Offset = "0x12964D4", VA = "0x12964D4")]
		public void SetValue(float frameTime, float yPosition)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x12962A8", Offset = "0x12962A8", VA = "0x12962A8")]
		private void SetValueInternal(float frameTime)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x129656C", Offset = "0x129656C", VA = "0x129656C")]
		public ProfilerGraphAxisLabel()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD52274", Offset = "0xD52274")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD52274", Offset = "0xD52274")]
	public class ProfilerGraphControl : Graphic
	{
		[Token(Token = "0x20001B1")]
		public enum VerticalAlignments
		{
			[Token(Token = "0x4000806")]
			Top,
			[Token(Token = "0x4000807")]
			Bottom
		}

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public VerticalAlignments VerticalAlignment;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float[] ScaleSteps;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool FloatingScale;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool TargetFpsUseApplication;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		public bool DrawAxes;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int TargetFps;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool Clip;

		[Token(Token = "0x4000348")]
		public const float DataPointMargin = 2f;

		[Token(Token = "0x4000349")]
		public const float DataPointVerticalMargin = 2f;

		[Token(Token = "0x400034A")]
		public const float DataPointWidth = 4f;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int VerticalPadding;

		[Token(Token = "0x400034C")]
		public const int LineCount = 3;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color[] LineColours;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private IProfilerService _profilerService;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ProfilerGraphAxisLabel[] _axisLabels;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Rect _clipBounds;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<Vector3> _meshVertices;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly List<Color32> _meshVertexColors;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<int> _meshTriangles;

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1296574", Offset = "0x1296574", VA = "0x1296574", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x12965F4", Offset = "0x12965F4", VA = "0x12965F4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x12965FC", Offset = "0x12965FC", VA = "0x12965FC")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x129660C", Offset = "0x129660C", VA = "0x129660C", Slot = "43")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xD57F0C", Offset = "0xD57F0C")]
		protected override void OnPopulateMesh(Mesh m)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1296E18", Offset = "0x1296E18", VA = "0x1296E18")]
		protected void DrawDataPoint(float xPosition, float verticalScale, ProfilerFrame frame)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1297284", Offset = "0x1297284", VA = "0x1297284")]
		protected void DrawAxis(float frameTime, float yPosition, ProfilerGraphAxisLabel label)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x12974E0", Offset = "0x12974E0", VA = "0x12974E0")]
		protected void AddRect(Vector3 tl, Vector3 tr, Vector3 bl, Vector3 br, Color c)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1296D40", Offset = "0x1296D40", VA = "0x1296D40")]
		protected ProfilerFrame GetFrame(int i)
		{
			return default(ProfilerFrame);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1296BC8", Offset = "0x1296BC8", VA = "0x1296BC8")]
		protected int CalculateVisibleDataPointCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1296C80", Offset = "0x1296C80", VA = "0x1296C80")]
		protected int GetFrameBufferCurrentSize()
		{
			return default(int);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x12977B8", Offset = "0x12977B8", VA = "0x12977B8")]
		protected int GetFrameBufferMaxSize()
		{
			return default(int);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1296AEC", Offset = "0x1296AEC", VA = "0x1296AEC")]
		protected float CalculateMaxFrameTime()
		{
			return default(float);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1297198", Offset = "0x1297198", VA = "0x1297198")]
		private ProfilerGraphAxisLabel GetAxisLabel(int index)
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1297880", Offset = "0x1297880", VA = "0x1297880")]
		public ProfilerGraphControl()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class SRTabButton : SRMonoBehaviourEx
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54F1C", Offset = "0xD54F1C")]
		public Behaviour ActiveToggle;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54F2C", Offset = "0xD54F2C")]
		public Button Button;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54F3C", Offset = "0xD54F3C")]
		public RectTransform ExtraContentContainer;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54F4C", Offset = "0xD54F4C")]
		public StyleComponent IconStyleComponent;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54F5C", Offset = "0xD54F5C")]
		public Text TitleText;

		[Token(Token = "0x1700009F")]
		public bool IsActive
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x1298350", Offset = "0x1298350", VA = "0x1298350")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x129836C", Offset = "0x129836C", VA = "0x129836C")]
			set
			{
			}
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x129838C", Offset = "0x129838C", VA = "0x129838C")]
		public SRTabButton()
		{
		}
	}
}
namespace SRDebugger.UI.Controls.Data
{
	[Token(Token = "0x20000B1")]
	public class ActionControl : OptionsControlBase
	{
		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MethodReference _method;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54F6C", Offset = "0xD54F6C")]
		public Button Button;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54F7C", Offset = "0xD54F7C")]
		public Text Title;

		[Token(Token = "0x170000A0")]
		public MethodReference Method
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x1292BD8", Offset = "0x1292BD8", VA = "0x1292BD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1292BE0", Offset = "0x1292BE0", VA = "0x1292BE0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1292C74", Offset = "0x1292C74", VA = "0x1292C74")]
		private void ButtonOnClick()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1292DE0", Offset = "0x1292DE0", VA = "0x1292DE0")]
		public void SetMethod(string methodName, MethodReference method)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1292E0C", Offset = "0x1292E0C", VA = "0x1292E0C")]
		public ActionControl()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class BoolControl : DataBoundControl
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54F8C", Offset = "0xD54F8C")]
		public Text Title;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54F9C", Offset = "0xD54F9C")]
		public Toggle Toggle;

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1292E1C", Offset = "0x1292E1C", VA = "0x1292E1C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1292F08", Offset = "0x1292F08", VA = "0x1292F08")]
		private void ToggleOnValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1292FC0", Offset = "0x1292FC0", VA = "0x1292FC0", Slot = "12")]
		protected override void OnBind(string propertyName, Type t)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1293014", Offset = "0x1293014", VA = "0x1293014", Slot = "13")]
		protected override void OnValueUpdated(object newValue)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x12930A8", Offset = "0x12930A8", VA = "0x12930A8", Slot = "14")]
		public override bool CanBind(Type type, bool isReadOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x129312C", Offset = "0x129312C", VA = "0x129312C")]
		public BoolControl()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class EnumControl : DataBoundControl
	{
		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private object _lastValue;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string[] _names;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Array _values;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54FAC", Offset = "0xD54FAC")]
		public LayoutElement ContentLayoutElement;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GameObject[] DisableOnReadOnly;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54FBC", Offset = "0xD54FBC")]
		public SRSpinner Spinner;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54FCC", Offset = "0xD54FCC")]
		public Text Title;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54FDC", Offset = "0xD54FDC")]
		public Text Value;

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x129313C", Offset = "0x129313C", VA = "0x129313C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x129316C", Offset = "0x129316C", VA = "0x129316C", Slot = "12")]
		protected override void OnBind(string propertyName, Type t)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x12933A0", Offset = "0x12933A0", VA = "0x12933A0", Slot = "13")]
		protected override void OnValueUpdated(object newValue)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x12933F4", Offset = "0x12933F4", VA = "0x12933F4", Slot = "14")]
		public override bool CanBind(Type type, bool isReadOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1293418", Offset = "0x1293418", VA = "0x1293418")]
		private void SetIndex(int i)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1293460", Offset = "0x1293460", VA = "0x1293460")]
		public void GoToNext()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x12934BC", Offset = "0x12934BC", VA = "0x12934BC")]
		public void GoToPrevious()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1293518", Offset = "0x1293518", VA = "0x1293518")]
		public EnumControl()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class NumberControl : DataBoundControl
	{
		[Token(Token = "0x20001B2")]
		public struct ValueRange
		{
			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double MaxValue;

			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public double MinValue;
		}

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Type[] IntegerTypes;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Type[] DecimalTypes;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Dictionary<Type, ValueRange> ValueRanges;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string _lastValue;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Type _type;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject[] DisableOnReadOnly;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public SRNumberButton DownNumberButton;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54FEC", Offset = "0xD54FEC")]
		public SRNumberSpinner NumberSpinner;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD54FFC", Offset = "0xD54FFC")]
		public Text Title;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public SRNumberButton UpNumberButton;

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1293520", Offset = "0x1293520", VA = "0x1293520", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x12935DC", Offset = "0x12935DC", VA = "0x12935DC")]
		private void OnValueChanged(string newValue)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1293700", Offset = "0x1293700", VA = "0x1293700", Slot = "12")]
		protected override void OnBind(string propertyName, Type t)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1293EE4", Offset = "0x1293EE4", VA = "0x1293EE4", Slot = "13")]
		protected override void OnValueUpdated(object newValue)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1293FA8", Offset = "0x1293FA8", VA = "0x1293FA8", Slot = "14")]
		public override bool CanBind(Type type, bool isReadOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1293A0C", Offset = "0x1293A0C", VA = "0x1293A0C")]
		protected static bool IsIntegerType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1293B28", Offset = "0x1293B28", VA = "0x1293B28")]
		protected static bool IsDecimalType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1293C44", Offset = "0x1293C44", VA = "0x1293C44")]
		protected double GetMaxValue(Type t)
		{
			return default(double);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1293D94", Offset = "0x1293D94", VA = "0x1293D94")]
		protected double GetMinValue(Type t)
		{
			return default(double);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1294040", Offset = "0x1294040", VA = "0x1294040")]
		public NumberControl()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class ReadOnlyControl : DataBoundControl
	{
		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5500C", Offset = "0xD5500C")]
		public Text ValueText;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5501C", Offset = "0xD5501C")]
		public Text Title;

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x12944CC", Offset = "0x12944CC", VA = "0x12944CC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x12944FC", Offset = "0x12944FC", VA = "0x12944FC", Slot = "12")]
		protected override void OnBind(string propertyName, Type t)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1294520", Offset = "0x1294520", VA = "0x1294520", Slot = "13")]
		protected override void OnValueUpdated(object newValue)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x12945B8", Offset = "0x12945B8", VA = "0x12945B8", Slot = "14")]
		public override bool CanBind(Type type, bool isReadOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1294654", Offset = "0x1294654", VA = "0x1294654")]
		public ReadOnlyControl()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class StringControl : DataBoundControl
	{
		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5502C", Offset = "0xD5502C")]
		public InputField InputField;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xD5503C", Offset = "0xD5503C")]
		public Text Title;

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x129465C", Offset = "0x129465C", VA = "0x129465C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1294718", Offset = "0x1294718", VA = "0x1294718")]
		private void OnValueChanged(string newValue)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x129471C", Offset = "0x129471C", VA = "0x129471C", Slot = "12")]
		protected override void OnBind(string propertyName, Type t)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x12947BC", Offset = "0x12947BC", VA = "0x12947BC", Slot = "13")]
		protected override void OnValueUpdated(object newValue)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x129484C", Offset = "0x129484C", VA = "0x129484C", Slot = "14")]
		public override bool CanBind(Type type, bool isReadOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x12948E8", Offset = "0x12948E8", VA = "0x12948E8")]
		public StringControl()
		{
		}
	}
}
namespace SRDebugger.Services
{
	[Token(Token = "0x20000B7")]
	public class BugReport
	{
		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<ConsoleEntry> ConsoleLog;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Email;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public byte[] ScreenshotData;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<string, Dictionary<string, object>> SystemInformation;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string UserDescription;

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x10680B8", Offset = "0x10680B8", VA = "0x10680B8")]
		public BugReport()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public delegate void BugReportCompleteCallback(bool didSucceed, string errorMessage);
	[Token(Token = "0x20000B9")]
	public delegate void BugReportProgressCallback(float progress);
	[Token(Token = "0x20000BA")]
	public interface IBugReportService
	{
		[Token(Token = "0x6000594")]
		void SendBugReport(BugReport report, BugReportCompleteCallback completeHandler, [Optional] BugReportProgressCallback progressCallback);
	}
	[Token(Token = "0x20000BB")]
	public delegate void ConsoleUpdatedEventHandler(IConsoleService console);
	[Token(Token = "0x20000BC")]
	public interface IConsoleService
	{
		[Token(Token = "0x170000A1")]
		int ErrorCount
		{
			[Token(Token = "0x6000599")]
			get;
		}

		[Token(Token = "0x170000A2")]
		int WarningCount
		{
			[Token(Token = "0x600059A")]
			get;
		}

		[Token(Token = "0x170000A3")]
		int InfoCount
		{
			[Token(Token = "0x600059B")]
			get;
		}

		[Token(Token = "0x170000A4")]
		IReadOnlyList<ConsoleEntry> Entries
		{
			[Token(Token = "0x600059C")]
			get;
		}

		[Token(Token = "0x170000A5")]
		IReadOnlyList<ConsoleEntry> AllEntries
		{
			[Token(Token = "0x600059D")]
			get;
		}

		[Token(Token = "0x14000006")]
		event ConsoleUpdatedEventHandler Updated;

		[Token(Token = "0x60005A0")]
		void Clear();
	}
	[Token(Token = "0x20000BD")]
	public class ConsoleEntry
	{
		[Token(Token = "0x4000379")]
		private const int MessagePreviewLength = 180;

		[Token(Token = "0x400037A")]
		private const int StackTracePreviewLength = 120;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string _messagePreview;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _stackTracePreview;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int Count;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public LogType LogType;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Message;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string StackTrace;

		[Token(Token = "0x170000A6")]
		public string MessagePreview
		{
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x1068774", Offset = "0x1068774", VA = "0x1068774")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public string StackTracePreview
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x1068898", Offset = "0x1068898", VA = "0x1068898")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x106870C", Offset = "0x106870C", VA = "0x106870C")]
		public ConsoleEntry()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x106871C", Offset = "0x106871C", VA = "0x106871C")]
		public ConsoleEntry(ConsoleEntry other)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x10689BC", Offset = "0x10689BC", VA = "0x10689BC")]
		public bool Matches(ConsoleEntry other)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BE")]
	public interface IDebugCameraService
	{
		[Token(Token = "0x170000A8")]
		Camera Camera
		{
			[Token(Token = "0x60005A6")]
			get;
		}
	}
	[Token(Token = "0x20000BF")]
	public interface IDebugPanelService
	{
		[Token(Token = "0x170000A9")]
		bool IsLoaded
		{
			[Token(Token = "0x60005A7")]
			get;
		}

		[Token(Token = "0x170000AA")]
		bool IsVisible
		{
			[Token(Token = "0x60005A8")]
			get;
			[Token(Token = "0x60005A9")]
			set;
		}

		[Token(Token = "0x170000AB")]
		DefaultTabs? ActiveTab
		{
			[Token(Token = "0x60005AA")]
			get;
		}

		[Token(Token = "0x14000007")]
		event Action<IDebugPanelService, bool> VisibilityChanged;

		[Token(Token = "0x60005AD")]
		void Unload();

		[Token(Token = "0x60005AE")]
		void OpenTab(DefaultTabs tab);
	}
	[Token(Token = "0x20000C0")]
	public interface IDebugService
	{
		[Token(Token = "0x170000AC")]
		Settings Settings
		{
			[Token(Token = "0x60005AF")]
			get;
		}

		[Token(Token = "0x170000AD")]
		bool IsDebugPanelVisible
		{
			[Token(Token = "0x60005B0")]
			get;
		}

		[Token(Token = "0x170000AE")]
		bool IsTriggerEnabled
		{
			[Token(Token = "0x60005B1")]
			get;
			[Token(Token = "0x60005B2")]
			set;
		}

		[Token(Token = "0x170000AF")]
		IDockConsoleService DockConsole
		{
			[Token(Token = "0x60005B3")]
			get;
		}

		[Token(Token = "0x170000B0")]
		bool IsProfilerDocked
		{
			[Token(Token = "0x60005B4")]
			get;
			[Token(Token = "0x60005B5")]
			set;
		}

		[Token(Token = "0x14000008")]
		event VisibilityChangedDelegate PanelVisibilityChanged;

		[Token(Token = "0x60005B6")]
		void AddSystemInfo(InfoEntry entry, string category = "Default");

		[Token(Token = "0x60005B7")]
		void ShowDebugPanel(bool requireEntryCode = true);

		[Token(Token = "0x60005B8")]
		void ShowDebugPanel(DefaultTabs tab, bool requireEntryCode = true);

		[Token(Token = "0x60005B9")]
		void HideDebugPanel();

		[Token(Token = "0x60005BA")]
		void DestroyDebugPanel();

		[Token(Token = "0x60005BB")]
		void AddOptionContainer(object container);

		[Token(Token = "0x60005BC")]
		void RemoveOptionContainer(object container);

		[Token(Token = "0x60005BD")]
		void PinAllOptions(string category);

		[Token(Token = "0x60005BE")]
		void UnpinAllOptions(string category);

		[Token(Token = "0x60005BF")]
		void PinOption(string name);

		[Token(Token = "0x60005C0")]
		void UnpinOption(string name);

		[Token(Token = "0x60005C1")]
		void ClearPinnedOptions();

		[Token(Token = "0x60005C2")]
		void ShowBugReportSheet([Optional] ActionCompleteCallback onComplete, bool takeScreenshot = true, [Optional] string descriptionContent);

		[Token(Token = "0x60005C5")]
		RectTransform EnableWorldSpaceMode();
	}
	[Token(Token = "0x20000C1")]
	public interface IDebugTriggerService
	{
		[Token(Token = "0x170000B1")]
		bool IsEnabled
		{
			[Token(Token = "0x60005C6")]
			get;
			[Token(Token = "0x60005C7")]
			set;
		}

		[Token(Token = "0x170000B2")]
		PinAlignment Position
		{
			[Token(Token = "0x60005C8")]
			get;
			[Token(Token = "0x60005C9")]
			set;
		}
	}
	[Token(Token = "0x20000C2")]
	public interface IDockConsoleService
	{
		[Token(Token = "0x170000B3")]
		bool IsVisible
		{
			[Token(Token = "0x60005CA")]
			get;
			[Token(Token = "0x60005CB")]
			set;
		}

		[Token(Token = "0x170000B4")]
		bool IsExpanded
		{
			[Token(Token = "0x60005CC")]
			get;
			[Token(Token = "0x60005CD")]
			set;
		}

		[Token(Token = "0x170000B5")]
		ConsoleAlignment Alignment
		{
			[Token(Token = "0x60005CE")]
			get;
			[Token(Token = "0x60005CF")]
			set;
		}
	}
	[Token(Token = "0x20000C3")]
	public interface IOptionsService
	{
		[Token(Token = "0x170000B6")]
		ICollection<OptionDefinition> Options
		{
			[Token(Token = "0x60005D4")]
			get;
		}

		[Token(Token = "0x14000009")]
		event EventHandler OptionsUpdated;

		[Token(Token = "0x1400000A")]
		event EventHandler<PropertyChangedEventArgs> OptionsValueUpdated;

		[Token(Token = "0x60005D5")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xD57FBC", Offset = "0xD57FBC")]
		void Scan(object obj);

		[Token(Token = "0x60005D6")]
		void AddContainer(object obj);

		[Token(Token = "0x60005D7")]
		void RemoveContainer(object obj);
	}
	[Token(Token = "0x20000C4")]
	public delegate void PinEntryCompleteCallback(bool validPinEntered);
	[Token(Token = "0x20000C5")]
	public interface IPinEntryService
	{
		[Token(Token = "0x170000B7")]
		bool IsShowingKeypad
		{
			[Token(Token = "0x60005DC")]
			get;
		}

		[Token(Token = "0x60005DD")]
		void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = true);

		[Token(Token = "0x60005DE")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xD57FF4", Offset = "0xD57FF4")]
		void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool blockInput, bool allowCancel);
	}
	[Token(Token = "0x20000C6")]
	public interface IPinnedUIService
	{
		[Token(Token = "0x170000B8")]
		bool IsProfilerPinned
		{
			[Token(Token = "0x60005E1")]
			get;
			[Token(Token = "0x60005E2")]
			set;
		}

		[Token(Token = "0x1400000B")]
		event Action<OptionDefinition, bool> OptionPinStateChanged;

		[Token(Token = "0x60005E3")]
		void Pin(OptionDefinition option, int order = -1);

		[Token(Token = "0x60005E4")]
		void Unpin(OptionDefinition option);

		[Token(Token = "0x60005E5")]
		void UnpinAll();

		[Token(Token = "0x60005E6")]
		bool HasPinned(OptionDefinition option);
	}
	[Token(Token = "0x20000C7")]
	public struct ProfilerFrame
	{
		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double FrameTime;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double OtherTime;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double RenderTime;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double UpdateTime;
	}
	[Token(Token = "0x20000C8")]
	public interface IProfilerService
	{
		[Token(Token = "0x170000B9")]
		float AverageFrameTime
		{
			[Token(Token = "0x60005E7")]
			get;
		}

		[Token(Token = "0x170000BA")]
		float LastFrameTime
		{
			[Token(Token = "0x60005E8")]
			get;
		}

		[Token(Token = "0x170000BB")]
		CircularBuffer<ProfilerFrame> FrameBuffer
		{
			[Token(Token = "0x60005E9")]
			get;
		}
	}
	[Token(Token = "0x20000C9")]
	public interface ISystemInformationService
	{
		[Token(Token = "0x60005EA")]
		IEnumerable<string> GetCategories();

		[Token(Token = "0x60005EB")]
		IList<InfoEntry> GetInfo(string category);

		[Token(Token = "0x60005EC")]
		void Add(InfoEntry info, string category = "Default");

		[Token(Token = "0x60005ED")]
		Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = false);
	}
}
namespace SRDebugger.Services.Implementation
{
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xD52310", Offset = "0xD52310")]
	public class BugReportApiService : SRServiceBase<IBugReportService>, IBugReportService
	{
		[Token(Token = "0x4000385")]
		public const float Timeout = 12f;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BugReportCompleteCallback _completeCallback;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string _errorMessage;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isBusy;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _previousProgress;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BugReportProgressCallback _progressCallback;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BugReportApi _reportApi;

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1068E04", Offset = "0x1068E04", VA = "0x1068E04", Slot = "11")]
		public void SendBugReport(BugReport report, BugReportCompleteCallback completeHandler, [Optional] BugReportProgressCallback progressCallback)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1068F88", Offset = "0x1068F88", VA = "0x1068F88", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1069038", Offset = "0x1069038", VA = "0x1069038")]
		private void OnProgress(float progress)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1069048", Offset = "0x1069048", VA = "0x1069048")]
		private void OnComplete()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x10690D4", Offset = "0x10690D4", VA = "0x10690D4", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1069170", Offset = "0x1069170", VA = "0x1069170")]
		public BugReportApiService()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xD52374", Offset = "0xD52374")]
	public class BugReportPopoverService : SRServiceBase<BugReportPopoverService>
	{
		[Token(Token = "0x20001B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD53A4C", Offset = "0xD53A4C")]
		private sealed class <OpenCo>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool takeScreenshot;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BugReportPopoverService <>4__this;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string descriptionText;

			[Token(Token = "0x17000257")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C7E")]
				[Address(RVA = "0x1069C3C", Offset = "0x1069C3C", VA = "0x1069C3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000258")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C80")]
				[Address(RVA = "0x1069CA4", Offset = "0x1069CA4", VA = "0x1069CA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C7B")]
			[Address(RVA = "0x10696D0", Offset = "0x10696D0", VA = "0x10696D0")]
			[DebuggerHidden]
			public <OpenCo>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000C7C")]
			[Address(RVA = "0x1069AFC", Offset = "0x1069AFC", VA = "0x1069AFC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C7D")]
			[Address(RVA = "0x1069B00", Offset = "0x1069B00", VA = "0x1069B00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C7F")]
			[Address(RVA = "0x1069C44", Offset = "0x1069C44", VA = "0x1069C44", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BugReportCompleteCallback _callback;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isVisible;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BugReportPopoverRoot _popover;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BugReportSheetController _sheet;

		[Token(Token = "0x170000BC")]
		public bool IsShowingPopover
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x10691C0", Offset = "0x10691C0", VA = "0x10691C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x10691C8", Offset = "0x10691C8", VA = "0x10691C8")]
		public void ShowBugReporter(BugReportCompleteCallback callback, bool takeScreenshotFirst = true, [Optional] string descriptionText)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1069648", Offset = "0x1069648", VA = "0x1069648")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD5804C", Offset = "0xD5804C")]
		private IEnumerator OpenCo(bool takeScreenshot, string descriptionText)
		{
			return null;
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x10696FC", Offset = "0x10696FC", VA = "0x10696FC")]
		private void SubmitComplete(bool didSucceed, string errorMessage)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1069864", Offset = "0x1069864", VA = "0x1069864")]
		private void CancelPressed()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1069708", Offset = "0x1069708", VA = "0x1069708")]
		private void OnComplete(bool success, string errorMessage, bool close)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x10698BC", Offset = "0x10698BC", VA = "0x10698BC")]
		private void TakingScreenshot()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x106995C", Offset = "0x106995C", VA = "0x106995C")]
		private void ScreenshotComplete()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x10699FC", Offset = "0x10699FC", VA = "0x10699FC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x1069368", Offset = "0x1069368", VA = "0x1069368")]
		private void Load()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x1069AAC", Offset = "0x1069AAC", VA = "0x1069AAC")]
		public BugReportPopoverService()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xD523D8", Offset = "0xD523D8")]
	public class DebugCameraServiceImpl : IDebugCameraService
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Camera _debugCamera;

		[Token(Token = "0x170000BD")]
		public Camera Camera
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x1069E20", Offset = "0x1069E20", VA = "0x1069E20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1069CAC", Offset = "0x1069CAC", VA = "0x1069CAC")]
		public DebugCameraServiceImpl()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xD5243C", Offset = "0xD5243C")]
	public class DebugPanelServiceImpl : ScriptableObject, IDebugPanelService
	{
		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DebugPanelRoot _debugPanelRootObject;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isVisible;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool? _cursorWasVisible;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private CursorLockMode? _cursorLockMode;

		[Token(Token = "0x170000BE")]
		public DebugPanelRoot RootObject
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x1069F70", Offset = "0x1069F70", VA = "0x1069F70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		public bool IsLoaded
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1069F78", Offset = "0x1069F78", VA = "0x1069F78", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C0")]
		public bool IsVisible
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1069FE8", Offset = "0x1069FE8", VA = "0x1069FE8", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x106A020", Offset = "0x106A020", VA = "0x106A020", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public DefaultTabs? ActiveTab
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x106A3FC", Offset = "0x106A3FC", VA = "0x106A3FC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000C")]
		public event Action<IDebugPanelService, bool> VisibilityChanged
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x1069E28", Offset = "0x1069E28", VA = "0x1069E28", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD580B0", Offset = "0xD580B0")]
			add
			{
			}
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x1069ECC", Offset = "0x1069ECC", VA = "0x1069ECC", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD580C0", Offset = "0xD580C0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x106A498", Offset = "0x106A498", VA = "0x106A498", Slot = "11")]
		public void OpenTab(DefaultTabs tab)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x106A4EC", Offset = "0x106A4EC", VA = "0x106A4EC", Slot = "10")]
		public void Unload()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x106A25C", Offset = "0x106A25C", VA = "0x106A25C")]
		private void Load()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x106A5DC", Offset = "0x106A5DC", VA = "0x106A5DC")]
		public DebugPanelServiceImpl()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xD524A0", Offset = "0xD524A0")]
	public class DebugTriggerImpl : SRServiceBase<IDebugTriggerService>, IDebugTriggerService
	{
		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PinAlignment _position;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TriggerRoot _trigger;

		[Token(Token = "0x170000C2")]
		public bool IsEnabled
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x106A5E4", Offset = "0x106A5E4", VA = "0x106A5E4", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x106A688", Offset = "0x106A688", VA = "0x106A688", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public PinAlignment Position
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x106AA80", Offset = "0x106AA80", VA = "0x106AA80", Slot = "13")]
			get
			{
				return default(PinAlignment);
			}
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x106AA88", Offset = "0x106AA88", VA = "0x106AA88", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x106AC20", Offset = "0x106AC20", VA = "0x106AC20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x106A780", Offset = "0x106A780", VA = "0x106A780")]
		private void CreateTrigger()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x106AD2C", Offset = "0x106AD2C", VA = "0x106AD2C", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x106ADDC", Offset = "0x106ADDC", VA = "0x106ADDC")]
		private static void OnActiveSceneChanged(Scene s1, Scene s2)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x106ADE0", Offset = "0x106ADE0", VA = "0x106ADE0")]
		private void OnTriggerButtonClick()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x106AB28", Offset = "0x106AB28", VA = "0x106AB28")]
		private static void SetTriggerPosition(RectTransform t, PinAlignment position)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x106AE98", Offset = "0x106AE98", VA = "0x106AE98")]
		public DebugTriggerImpl()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xD52504", Offset = "0xD52504")]
	public class DockConsoleServiceImpl : IDockConsoleService
	{
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ConsoleAlignment _alignment;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DockConsoleController _consoleRoot;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _didSuspendTrigger;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool _isExpanded;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		private bool _isVisible;

		[Token(Token = "0x170000C4")]
		public bool IsVisible
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x106AF2C", Offset = "0x106AF2C", VA = "0x106AF2C", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000619")]
			[Address(RVA = "0x106AF34", Offset = "0x106AF34", VA = "0x106AF34", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public bool IsExpanded
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x106B480", Offset = "0x106B480", VA = "0x106B480", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x106B488", Offset = "0x106B488", VA = "0x106B488", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public ConsoleAlignment Alignment
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x106B564", Offset = "0x106B564", VA = "0x106B564", Slot = "8")]
			get
			{
				return default(ConsoleAlignment);
			}
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x106B56C", Offset = "0x106B56C", VA = "0x106B56C", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x106AEE8", Offset = "0x106AEE8", VA = "0x106AEE8")]
		public DockConsoleServiceImpl()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x106B01C", Offset = "0x106B01C", VA = "0x106B01C")]
		private void Load()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x106B1B8", Offset = "0x106B1B8", VA = "0x106B1B8")]
		private void CheckTrigger()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xD52568", Offset = "0xD52568")]
	public class KeyboardShortcutListenerService : SRServiceBase<KeyboardShortcutListenerService>
	{
		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Settings.KeyboardShortcut> _shortcuts;

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x106B6A0", Offset = "0x106B6A0", VA = "0x106B6A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x106B798", Offset = "0x106B798", VA = "0x106B798")]
		private void ToggleTab(DefaultTabs t)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x106BA04", Offset = "0x106BA04", VA = "0x106BA04")]
		private void ExecuteShortcut(Settings.KeyboardShortcut shortcut)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x106C044", Offset = "0x106C044", VA = "0x106C044", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x106C2DC", Offset = "0x106C2DC", VA = "0x106C2DC")]
		public KeyboardShortcutListenerService()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xD525CC", Offset = "0xD525CC")]
	public class OptionsServiceImpl : IOptionsService
	{
		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<object, ICollection<OptionDefinition>> _optionContainerLookup;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<OptionDefinition> _options;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IList<OptionDefinition> _optionsReadonly;

		[Token(Token = "0x170000C7")]
		public ICollection<OptionDefinition> Options
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x106C5BC", Offset = "0x106C5BC", VA = "0x106C5BC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000D")]
		public event EventHandler OptionsUpdated
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x106C32C", Offset = "0x106C32C", VA = "0x106C32C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD580D0", Offset = "0xD580D0")]
			add
			{
			}
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x106C3D0", Offset = "0x106C3D0", VA = "0x106C3D0", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD580E0", Offset = "0xD580E0")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event EventHandler<PropertyChangedEventArgs> OptionsValueUpdated
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x106C474", Offset = "0x106C474", VA = "0x106C474", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD580F0", Offset = "0xD580F0")]
			add
			{
			}
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x106C518", Offset = "0x106C518", VA = "0x106C518", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58100", Offset = "0xD58100")]
			remove
			{
			}
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x106C5C4", Offset = "0x106C5C4", VA = "0x106C5C4")]
		public OptionsServiceImpl()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x106C78C", Offset = "0x106C78C", VA = "0x106C78C", Slot = "9")]
		public void Scan(object obj)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x106C790", Offset = "0x106C790", VA = "0x106C790", Slot = "10")]
		public void AddContainer(object obj)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x106CA54", Offset = "0x106CA54", VA = "0x106CA54", Slot = "11")]
		public void RemoveContainer(object obj)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x106CDF4", Offset = "0x106CDF4", VA = "0x106CDF4")]
		private void OnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x106CE6C", Offset = "0x106CE6C", VA = "0x106CE6C")]
		private void OnSROptionsPropertyChanged(object sender, string propertyName)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x106C9BC", Offset = "0x106C9BC", VA = "0x106C9BC")]
		private void OnOptionsUpdated()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xD52630", Offset = "0xD52630")]
	public class PinEntryServiceImpl : SRServiceBase<IPinEntryService>, IPinEntryService
	{
		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PinEntryCompleteCallback _callback;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isVisible;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PinEntryControl _pinControl;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<int> _requiredPin;

		[Token(Token = "0x170000C8")]
		public bool IsShowingKeypad
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x106CEE0", Offset = "0x106CEE0", VA = "0x106CEE0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x106CEE8", Offset = "0x106CEE8", VA = "0x106CEE8", Slot = "12")]
		public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = true)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x106D4E4", Offset = "0x106D4E4", VA = "0x106D4E4", Slot = "13")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xD58110", Offset = "0xD58110")]
		public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool blockInput, bool allowCancel)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x106D4EC", Offset = "0x106D4EC", VA = "0x106D4EC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x106D364", Offset = "0x106D364", VA = "0x106D364")]
		private void Load()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x106D59C", Offset = "0x106D59C", VA = "0x106D59C")]
		private void PinControlOnComplete(IList<int> result, bool didCancel)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x106D100", Offset = "0x106D100", VA = "0x106D100")]
		private void VerifyPin(IList<int> pin)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x106D670", Offset = "0x106D670", VA = "0x106D670")]
		public PinEntryServiceImpl()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xD52694", Offset = "0xD52694")]
	public class PinnedUIServiceImpl : SRServiceBase<IPinnedUIService>, IPinnedUIService
	{
		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<OptionsControlBase> _controlList;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Dictionary<OptionDefinition, OptionsControlBase> _pinnedObjects;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _queueRefresh;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PinnedUIRoot _uiRoot;

		[Token(Token = "0x170000C9")]
		public DockConsoleController DockConsoleController
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x106B610", Offset = "0x106B610", VA = "0x106B610")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		public bool IsProfilerPinned
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x106DB6C", Offset = "0x106DB6C", VA = "0x106DB6C", Slot = "13")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x106DC0C", Offset = "0x106DC0C", VA = "0x106DC0C", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event Action<OptionDefinition, bool> OptionPinStateChanged
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x106DA24", Offset = "0x106DA24", VA = "0x106DA24", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58120", Offset = "0xD58120")]
			add
			{
			}
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x106DAC8", Offset = "0x106DAC8", VA = "0x106DAC8", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58130", Offset = "0xD58130")]
			remove
			{
			}
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x106DCB4", Offset = "0x106DCB4", VA = "0x106DCB4", Slot = "15")]
		public void Pin(OptionDefinition obj, int order = -1)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x106DE94", Offset = "0x106DE94", VA = "0x106DE94", Slot = "16")]
		public void Unpin(OptionDefinition obj)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x106DE18", Offset = "0x106DE18", VA = "0x106DE18")]
		private void OnPinnedStateChanged(OptionDefinition option, bool isPinned)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x106DFC0", Offset = "0x106DFC0", VA = "0x106DFC0", Slot = "17")]
		public void UnpinAll()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x106E128", Offset = "0x106E128", VA = "0x106E128", Slot = "18")]
		public bool HasPinned(OptionDefinition option)
		{
			return default(bool);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x106E190", Offset = "0x106E190", VA = "0x106E190", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x106D6EC", Offset = "0x106D6EC", VA = "0x106D6EC")]
		private void Load()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x106E240", Offset = "0x106E240", VA = "0x106E240")]
		private void UpdateAnchors()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x106E480", Offset = "0x106E480", VA = "0x106E480", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x106E55C", Offset = "0x106E55C", VA = "0x106E55C")]
		private void OnOptionsUpdated(object sender, EventArgs eventArgs)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x106E7A0", Offset = "0x106E7A0", VA = "0x106E7A0")]
		private void OptionsOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x106E7AC", Offset = "0x106E7AC", VA = "0x106E7AC")]
		private void OnDebugPanelVisibilityChanged(bool isVisible)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x106E4C0", Offset = "0x106E4C0", VA = "0x106E4C0")]
		private void Refresh()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x106E7BC", Offset = "0x106E7BC", VA = "0x106E7BC")]
		public PinnedUIServiceImpl()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xD526F8", Offset = "0xD526F8")]
	public class SRDebugService : IDebugService
	{
		[Token(Token = "0x20001B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD53A5C", Offset = "0xD53A5C")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ActionCompleteCallback onComplete;

			[Token(Token = "0x6000C81")]
			[Address(RVA = "0x10708C4", Offset = "0x10708C4", VA = "0x10708C4")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000C82")]
			[Address(RVA = "0x1070E6C", Offset = "0x1070E6C", VA = "0x1070E6C")]
			internal void <ShowBugReportSheet>b__0(bool succeed, string message)
			{
			}
		}

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDebugPanelService _debugPanelService;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IDebugTriggerService _debugTrigger;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly ISystemInformationService _informationService;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly IOptionsService _optionsService;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IPinnedUIService _pinnedUiService;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _entryCodeEnabled;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _hasAuthorised;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private DefaultTabs? _queuedTab;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _worldSpaceTransform;

		[Token(Token = "0x170000CB")]
		public Settings Settings
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x106ED40", Offset = "0x106ED40", VA = "0x106ED40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		public bool IsDebugPanelVisible
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x106ED48", Offset = "0x106ED48", VA = "0x106ED48", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CD")]
		public bool IsTriggerEnabled
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x106EDFC", Offset = "0x106EDFC", VA = "0x106EDFC", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x106EEAC", Offset = "0x106EEAC", VA = "0x106EEAC", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public bool IsProfilerDocked
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x106EF70", Offset = "0x106EF70", VA = "0x106EF70", Slot = "9")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x106F024", Offset = "0x106F024", VA = "0x106F024", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public IDockConsoleService DockConsole
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x10708CC", Offset = "0x10708CC", VA = "0x10708CC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000010")]
		public event VisibilityChangedDelegate PanelVisibilityChanged
		{
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x10708D0", Offset = "0x10708D0", VA = "0x10708D0", Slot = "24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58140", Offset = "0xD58140")]
			add
			{
			}
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x1070974", Offset = "0x1070974", VA = "0x1070974", Slot = "25")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58150", Offset = "0xD58150")]
			remove
			{
			}
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x106E85C", Offset = "0x106E85C", VA = "0x106E85C")]
		public SRDebugService()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x106F0E0", Offset = "0x106F0E0", VA = "0x106F0E0", Slot = "11")]
		public void AddSystemInfo(InfoEntry entry, string category = "Default")
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x106F1AC", Offset = "0x106F1AC", VA = "0x106F1AC", Slot = "12")]
		public void ShowDebugPanel(bool requireEntryCode = true)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x106F418", Offset = "0x106F418", VA = "0x106F418", Slot = "13")]
		public void ShowDebugPanel(DefaultTabs tab, bool requireEntryCode = true)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x106F5AC", Offset = "0x106F5AC", VA = "0x106F5AC", Slot = "14")]
		public void HideDebugPanel()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x106F664", Offset = "0x106F664", VA = "0x106F664", Slot = "15")]
		public void DestroyDebugPanel()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x106F790", Offset = "0x106F790", VA = "0x106F790", Slot = "16")]
		public void AddOptionContainer(object container)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x106F854", Offset = "0x106F854", VA = "0x106F854", Slot = "17")]
		public void RemoveOptionContainer(object container)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x106F918", Offset = "0x106F918", VA = "0x106F918", Slot = "18")]
		public void PinAllOptions(string category)
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x106FC98", Offset = "0x106FC98", VA = "0x106FC98", Slot = "19")]
		public void UnpinAllOptions(string category)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1070014", Offset = "0x1070014", VA = "0x1070014", Slot = "20")]
		public void PinOption(string name)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1070394", Offset = "0x1070394", VA = "0x1070394", Slot = "21")]
		public void UnpinOption(string name)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1070710", Offset = "0x1070710", VA = "0x1070710", Slot = "22")]
		public void ClearPinnedOptions()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x10707C4", Offset = "0x10707C4", VA = "0x10707C4", Slot = "23")]
		public void ShowBugReportSheet([Optional] ActionCompleteCallback onComplete, bool takeScreenshot = true, [Optional] string descriptionContent)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1070A18", Offset = "0x1070A18", VA = "0x1070A18")]
		private void DebugPanelServiceOnVisibilityChanged(IDebugPanelService debugPanelService, bool b)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x106F298", Offset = "0x106F298", VA = "0x106F298")]
		private void PromptEntryCode()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1070B30", Offset = "0x1070B30", VA = "0x1070B30", Slot = "26")]
		public RectTransform EnableWorldSpaceMode()
		{
			return null;
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1070DAC", Offset = "0x1070DAC", VA = "0x1070DAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58160", Offset = "0xD58160")]
		private void <PromptEntryCode>b__39_0(bool entered)
		{
		}
	}
	[Token(Token = "0x20000D5")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xD5275C", Offset = "0xD5275C")]
	public class StandardConsoleService : IConsoleService
	{
		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly bool _collapseEnabled;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool _hasCleared;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly CircularBuffer<ConsoleEntry> _allConsoleEntries;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CircularBuffer<ConsoleEntry> _consoleEntries;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly object _threadLock;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5509C", Offset = "0xD5509C")]
		private int <ErrorCount>k__BackingField;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD550AC", Offset = "0xD550AC")]
		private int <WarningCount>k__BackingField;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD550BC", Offset = "0xD550BC")]
		private int <InfoCount>k__BackingField;

		[Token(Token = "0x170000D0")]
		public int ErrorCount
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x1070E80", Offset = "0x1070E80", VA = "0x1070E80", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58170", Offset = "0xD58170")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x1070E88", Offset = "0x1070E88", VA = "0x1070E88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58180", Offset = "0xD58180")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public int WarningCount
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x1070E90", Offset = "0x1070E90", VA = "0x1070E90", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58190", Offset = "0xD58190")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x1070E98", Offset = "0x1070E98", VA = "0x1070E98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD581A0", Offset = "0xD581A0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public int InfoCount
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x1070EA0", Offset = "0x1070EA0", VA = "0x1070EA0", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD581B0", Offset = "0xD581B0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x1070EA8", Offset = "0x1070EA8", VA = "0x1070EA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD581C0", Offset = "0xD581C0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public IReadOnlyList<ConsoleEntry> Entries
		{
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x1070FF8", Offset = "0x1070FF8", VA = "0x1070FF8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		public IReadOnlyList<ConsoleEntry> AllEntries
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x1071014", Offset = "0x1071014", VA = "0x1071014", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000011")]
		public event ConsoleUpdatedEventHandler Updated
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x1070EB0", Offset = "0x1070EB0", VA = "0x1070EB0", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD581D0", Offset = "0xD581D0")]
			add
			{
			}
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1070F54", Offset = "0x1070F54", VA = "0x1070F54", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD581E0", Offset = "0xD581E0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x10631DC", Offset = "0x10631DC", VA = "0x10631DC")]
		public StandardConsoleService()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x107101C", Offset = "0x107101C", VA = "0x107101C", Slot = "11")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1071208", Offset = "0x1071208", VA = "0x1071208")]
		protected void OnEntryAdded(ConsoleEntry entry)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1071430", Offset = "0x1071430", VA = "0x1071430")]
		protected void OnEntryDuplicated(ConsoleEntry entry)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1071144", Offset = "0x1071144", VA = "0x1071144")]
		private void OnUpdated()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x10714F0", Offset = "0x10714F0", VA = "0x10714F0")]
		private void UnityLogCallback(string condition, string stackTrace, LogType type)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x10713E0", Offset = "0x10713E0", VA = "0x10713E0")]
		private void AdjustCounter(LogType type, int amount)
		{
		}
	}
	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xD527C0", Offset = "0xD527C0")]
	public class StandardSystemInformationService : ISystemInformationService
	{
		[Token(Token = "0x20001B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD53A6C", Offset = "0xD53A6C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InfoEntry info;

			[Token(Token = "0x6000C83")]
			[Address(RVA = "0x1290D84", Offset = "0x1290D84", VA = "0x1290D84")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000C84")]
			[Address(RVA = "0x1290D8C", Offset = "0x1290D8C", VA = "0x1290D8C")]
			internal bool <Add>b__0(InfoEntry p)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20001B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD53A7C", Offset = "0xD53A7C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<object> <>9__6_0;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<object> <>9__6_1;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<object> <>9__6_2;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<object> <>9__6_3;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<object> <>9__6_4;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<object> <>9__6_5;

			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<object> <>9__6_6;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<object> <>9__6_7;

			[Token(Token = "0x6000C86")]
			[Address(RVA = "0x1290818", Offset = "0x1290818", VA = "0x1290818")]
			public <>c()
			{
			}

			[Token(Token = "0x6000C87")]
			[Address(RVA = "0x1290820", Offset = "0x1290820", VA = "0x1290820")]
			internal object <CreateDefaultSet>b__6_0()
			{
				return null;
			}

			[Token(Token = "0x6000C88")]
			[Address(RVA = "0x12908C4", Offset = "0x12908C4", VA = "0x12908C4")]
			internal object <CreateDefaultSet>b__6_1()
			{
				return null;
			}

			[Token(Token = "0x6000C89")]
			[Address(RVA = "0x1290920", Offset = "0x1290920", VA = "0x1290920")]
			internal object <CreateDefaultSet>b__6_2()
			{
				return null;
			}

			[Token(Token = "0x6000C8A")]
			[Address(RVA = "0x1290984", Offset = "0x1290984", VA = "0x1290984")]
			internal object <CreateDefaultSet>b__6_3()
			{
				return null;
			}

			[Token(Token = "0x6000C8B")]
			[Address(RVA = "0x12909E4", Offset = "0x12909E4", VA = "0x12909E4")]
			internal object <CreateDefaultSet>b__6_4()
			{
				return null;
			}

			[Token(Token = "0x6000C8C")]
			[Address(RVA = "0x1290A40", Offset = "0x1290A40", VA = "0x1290A40")]
			internal object <CreateDefaultSet>b__6_5()
			{
				return null;
			}

			[Token(Token = "0x6000C8D")]
			[Address(RVA = "0x1290A9C", Offset = "0x1290A9C", VA = "0x1290A9C")]
			internal object <CreateDefaultSet>b__6_6()
			{
				return null;
			}

			[Token(Token = "0x6000C8E")]
			[Address(RVA = "0x1290BF4", Offset = "0x1290BF4", VA = "0x1290BF4")]
			internal object <CreateDefaultSet>b__6_7()
			{
				return null;
			}
		}

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, IList<InfoEntry>> _info;

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x10716E4", Offset = "0x10716E4", VA = "0x10716E4")]
		public StandardSystemInformationService()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1073024", Offset = "0x1073024", VA = "0x1073024", Slot = "4")]
		public IEnumerable<string> GetCategories()
		{
			return null;
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x107307C", Offset = "0x107307C", VA = "0x107307C", Slot = "5")]
		public IList<InfoEntry> GetInfo(string category)
		{
			return null;
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x10731B4", Offset = "0x10731B4", VA = "0x10731B4", Slot = "6")]
		public void Add(InfoEntry info, string category = "Default")
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x10733BC", Offset = "0x10733BC", VA = "0x10733BC", Slot = "7")]
		public Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x107175C", Offset = "0x107175C", VA = "0x107175C")]
		private void CreateDefaultSet()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1073830", Offset = "0x1073830", VA = "0x1073830")]
		private static string GetCloudManifestPrettyName(string name)
		{
			return null;
		}
	}
}
namespace SRDebugger.Profiler
{
	[Token(Token = "0x20000D7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD52824", Offset = "0xD52824")]
	public class ProfilerCameraListener : MonoBehaviour
	{
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera _camera;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Stopwatch _stopwatch;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<ProfilerCameraListener, double> RenderDurationCallback;

		[Token(Token = "0x170000D5")]
		protected Stopwatch Stopwatch
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x1066988", Offset = "0x1066988", VA = "0x1066988")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		public Camera Camera
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x10669F4", Offset = "0x10669F4", VA = "0x10669F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1066A8C", Offset = "0x1066A8C", VA = "0x1066A8C")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1066AD4", Offset = "0x1066AD4", VA = "0x1066AD4")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1066BD0", Offset = "0x1066BD0", VA = "0x1066BD0")]
		public ProfilerCameraListener()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class ProfilerLateUpdateListener : MonoBehaviour
	{
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action OnLateUpdate;

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1066BD8", Offset = "0x1066BD8", VA = "0x1066BD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1066BEC", Offset = "0x1066BEC", VA = "0x1066BEC")]
		public ProfilerLateUpdateListener()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xD52888", Offset = "0xD52888")]
	public class ProfilerServiceImpl : SRServiceBase<IProfilerService>, IProfilerService
	{
		[Token(Token = "0x40003C4")]
		private const int FrameBufferSize = 400;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly SRList<ProfilerCameraListener> _cameraListeners;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly CircularBuffer<ProfilerFrame> _frameBuffer;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Camera[] _cameraCache;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ProfilerLateUpdateListener _lateUpdateListener;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private double _renderDuration;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _reportedCameras;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Stopwatch _stopwatch;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private double _updateDuration;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private double _updateToRenderDuration;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD550DC", Offset = "0xD550DC")]
		private float <AverageFrameTime>k__BackingField;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD550EC", Offset = "0xD550EC")]
		private float <LastFrameTime>k__BackingField;

		[Token(Token = "0x170000D7")]
		public float AverageFrameTime
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x1066BF4", Offset = "0x1066BF4", VA = "0x1066BF4", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD581F0", Offset = "0xD581F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x1066BFC", Offset = "0x1066BFC", VA = "0x1066BFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58200", Offset = "0xD58200")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public float LastFrameTime
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x1066C04", Offset = "0x1066C04", VA = "0x1066C04", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58210", Offset = "0xD58210")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x1066C0C", Offset = "0x1066C0C", VA = "0x1066C0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58220", Offset = "0xD58220")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public CircularBuffer<ProfilerFrame> FrameBuffer
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x1066C14", Offset = "0x1066C14", VA = "0x1066C14", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1066C1C", Offset = "0x1066C1C", VA = "0x1066C1C")]
		protected void PushFrame(double totalTime, double updateTime, double renderTime)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1066CA4", Offset = "0x1066CA4", VA = "0x1066CA4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1066DD8", Offset = "0x1066DD8", VA = "0x1066DD8", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x106724C", Offset = "0x106724C", VA = "0x106724C")]
		private void OnLateUpdate()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1067294", Offset = "0x1067294", VA = "0x1067294")]
		private void EndFrame()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1067310", Offset = "0x1067310", VA = "0x1067310")]
		private void CameraDurationCallback(ProfilerCameraListener listener, double duration)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1067394", Offset = "0x1067394", VA = "0x1067394")]
		private int GetExpectedCameraCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1066F98", Offset = "0x1066F98", VA = "0x1066F98")]
		private void CameraCheck()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x10674B8", Offset = "0x10674B8", VA = "0x10674B8")]
		public ProfilerServiceImpl()
		{
		}
	}
}
namespace SRDebugger.Internal
{
	[Token(Token = "0x20000DA")]
	public static class SRDebugApi
	{
		[Token(Token = "0x40003D0")]
		public const string Protocol = "http://";

		[Token(Token = "0x40003D1")]
		public const string EndPoint = "http://srdebugger.stompyrobot.uk";

		[Token(Token = "0x40003D2")]
		public const string BugReportEndPoint = "http://srdebugger.stompyrobot.uk/report/submit";
	}
	[Token(Token = "0x20000DB")]
	public static class SRDebugApiUtil
	{
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x10659E0", Offset = "0x10659E0", VA = "0x10659E0")]
		public static string ParseErrorException(WebException ex)
		{
			return null;
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x106498C", Offset = "0x106498C", VA = "0x106498C")]
		public static string ParseErrorResponse(string response, string fallback = "Unexpected Response")
		{
			return null;
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1065CC4", Offset = "0x1065CC4", VA = "0x1065CC4")]
		public static bool ReadResponse(HttpWebRequest request, out string result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1065ACC", Offset = "0x1065ACC", VA = "0x1065ACC")]
		public static string ReadResponseStream(WebResponse stream)
		{
			return null;
		}
	}
	[Token(Token = "0x20000DC")]
	public class BugReportApi
	{
		[Token(Token = "0x20001B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD53A8C", Offset = "0xD53A8C")]
		private sealed class <Submit>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BugReportApi <>4__this;

			[Token(Token = "0x17000259")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C92")]
				[Address(RVA = "0x1064E0C", Offset = "0x1064E0C", VA = "0x1064E0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700025A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C94")]
				[Address(RVA = "0x1064E74", Offset = "0x1064E74", VA = "0x1064E74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C8F")]
			[Address(RVA = "0x1063EB0", Offset = "0x1063EB0", VA = "0x1063EB0")]
			[DebuggerHidden]
			public <Submit>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000C90")]
			[Address(RVA = "0x10645C8", Offset = "0x10645C8", VA = "0x10645C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C91")]
			[Address(RVA = "0x10645CC", Offset = "0x10645CC", VA = "0x10645CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C93")]
			[Address(RVA = "0x1064E14", Offset = "0x1064E14", VA = "0x1064E14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string _apiKey;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly BugReport _bugReport;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _isBusy;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WWW _www;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD550FC", Offset = "0xD550FC")]
		private bool <IsComplete>k__BackingField;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5510C", Offset = "0xD5510C")]
		private bool <WasSuccessful>k__BackingField;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5511C", Offset = "0xD5511C")]
		private string <ErrorMessage>k__BackingField;

		[Token(Token = "0x170000DA")]
		public bool IsComplete
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x1063D58", Offset = "0x1063D58", VA = "0x1063D58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58230", Offset = "0xD58230")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x1063D60", Offset = "0x1063D60", VA = "0x1063D60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58240", Offset = "0xD58240")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public bool WasSuccessful
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x1063D6C", Offset = "0x1063D6C", VA = "0x1063D6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58250", Offset = "0xD58250")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x1063D74", Offset = "0x1063D74", VA = "0x1063D74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58260", Offset = "0xD58260")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public string ErrorMessage
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x1063D80", Offset = "0x1063D80", VA = "0x1063D80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58270", Offset = "0xD58270")]
			get
			{
				return null;
			}
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x1063D88", Offset = "0x1063D88", VA = "0x1063D88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58280", Offset = "0xD58280")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public float Progress
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x1063D90", Offset = "0x1063D90", VA = "0x1063D90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1063D20", Offset = "0x1063D20", VA = "0x1063D20")]
		public BugReportApi(BugReport report, string apiKey)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1063E40", Offset = "0x1063E40", VA = "0x1063E40")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD58290", Offset = "0xD58290")]
		public IEnumerator Submit()
		{
			return null;
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1063EDC", Offset = "0x1063EDC", VA = "0x1063EDC")]
		private void SetCompletionState(bool wasSuccessful)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1063FA8", Offset = "0x1063FA8", VA = "0x1063FA8")]
		private static string BuildJsonRequest(BugReport report)
		{
			return null;
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1064104", Offset = "0x1064104", VA = "0x1064104")]
		private static IList<IList<string>> CreateConsoleDump()
		{
			return null;
		}
	}
	[Token(Token = "0x20000DD")]
	public class BugReportScreenshotUtil
	{
		[Token(Token = "0x20001B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD53A9C", Offset = "0xD53A9C")]
		private sealed class <ScreenshotCaptureCo>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x1700025B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C98")]
				[Address(RVA = "0x10650F8", Offset = "0x10650F8", VA = "0x10650F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700025C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C9A")]
				[Address(RVA = "0x1065160", Offset = "0x1065160", VA = "0x1065160", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C95")]
			[Address(RVA = "0x1064EDC", Offset = "0x1064EDC", VA = "0x1064EDC")]
			[DebuggerHidden]
			public <ScreenshotCaptureCo>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000C96")]
			[Address(RVA = "0x1064F10", Offset = "0x1064F10", VA = "0x1064F10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C97")]
			[Address(RVA = "0x1064F14", Offset = "0x1064F14", VA = "0x1064F14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C99")]
			[Address(RVA = "0x1065100", Offset = "0x1065100", VA = "0x1065100", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static byte[] ScreenshotData;

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x1064E7C", Offset = "0x1064E7C", VA = "0x1064E7C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD582F4", Offset = "0xD582F4")]
		public static IEnumerator ScreenshotCaptureCo()
		{
			return null;
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1064F08", Offset = "0x1064F08", VA = "0x1064F08")]
		public BugReportScreenshotUtil()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public static class OptionControlFactory
	{
		[Token(Token = "0x20001B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD53AAC", Offset = "0xD53AAC")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public OptionDefinition from;

			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x1065830", Offset = "0x1065830", VA = "0x1065830")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x1065838", Offset = "0x1065838", VA = "0x1065838")]
			internal bool <CreateDataControl>b__0(DataBoundControl p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IList<DataBoundControl> _dataControlPrefabs;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ActionControl _actionControlPrefab;

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1065168", Offset = "0x1065168", VA = "0x1065168")]
		public static OptionsControlBase CreateControl(OptionDefinition from, [Optional] string categoryPrefix)
		{
			return null;
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x106572C", Offset = "0x106572C", VA = "0x106572C")]
		private static ActionControl CreateActionControl(OptionDefinition from, [Optional] string categoryPrefix)
		{
			return null;
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x1065354", Offset = "0x1065354", VA = "0x1065354")]
		private static DataBoundControl CreateDataControl(OptionDefinition from, [Optional] string categoryPrefix)
		{
			return null;
		}
	}
	[Token(Token = "0x20000DF")]
	public class OptionDefinition
	{
		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5512C", Offset = "0xD5512C")]
		private string <Name>k__BackingField;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5513C", Offset = "0xD5513C")]
		private string <Category>k__BackingField;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5514C", Offset = "0xD5514C")]
		private int <SortPriority>k__BackingField;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5515C", Offset = "0xD5515C")]
		private MethodReference <Method>k__BackingField;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5516C", Offset = "0xD5516C")]
		private PropertyReference <Property>k__BackingField;

		[Token(Token = "0x170000DE")]
		public string Name
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x1065990", Offset = "0x1065990", VA = "0x1065990")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58358", Offset = "0xD58358")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x1065998", Offset = "0x1065998", VA = "0x1065998")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58368", Offset = "0xD58368")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public string Category
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x10659A0", Offset = "0x10659A0", VA = "0x10659A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58378", Offset = "0xD58378")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x10659A8", Offset = "0x10659A8", VA = "0x10659A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58388", Offset = "0xD58388")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public int SortPriority
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x10659B0", Offset = "0x10659B0", VA = "0x10659B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58398", Offset = "0xD58398")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x10659B8", Offset = "0x10659B8", VA = "0x10659B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD583A8", Offset = "0xD583A8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public MethodReference Method
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x10659C0", Offset = "0x10659C0", VA = "0x10659C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD583B8", Offset = "0xD583B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x10659C8", Offset = "0x10659C8", VA = "0x10659C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD583C8", Offset = "0xD583C8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public PropertyReference Property
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x10659D0", Offset = "0x10659D0", VA = "0x10659D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD583D8", Offset = "0xD583D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x10659D8", Offset = "0x10659D8", VA = "0x10659D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD583E8", Offset = "0xD583E8")]
			private set
			{
			}
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x10658B0", Offset = "0x10658B0", VA = "0x10658B0")]
		private OptionDefinition(string name, string category, int sortPriority)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x10658F0", Offset = "0x10658F0", VA = "0x10658F0")]
		public OptionDefinition(string name, string category, int sortPriority, MethodReference method)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1065940", Offset = "0x1065940", VA = "0x1065940")]
		public OptionDefinition(string name, string category, int sortPriority, PropertyReference property)
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public static class SRDebugPaths
	{
		[Token(Token = "0x40003E2")]
		public const string DataControlsResourcesPath = "SRDebugger/UI/Prefabs/Options";

		[Token(Token = "0x40003E3")]
		public const string TriggerPrefabPath = "SRDebugger/UI/Prefabs/Trigger";

		[Token(Token = "0x40003E4")]
		public const string DebugPanelPrefabPath = "SRDebugger/UI/Prefabs/DebugPanel";

		[Token(Token = "0x40003E5")]
		public const string PinnedUIPrefabPath = "SRDebugger/UI/Prefabs/PinnedUI";

		[Token(Token = "0x40003E6")]
		public const string DockConsolePrefabPath = "SRDebugger/UI/Prefabs/DockConsole";

		[Token(Token = "0x40003E7")]
		public const string PinEntryPrefabPath = "SRDebugger/UI/Prefabs/PinEntry";

		[Token(Token = "0x40003E8")]
		public const string BugReportPopoverPath = "SRDebugger/UI/Prefabs/BugReportPopover";

		[Token(Token = "0x40003E9")]
		public const string BugReportSheetPath = "SRDebugger/UI/Prefabs/BugReportSheet";

		[Token(Token = "0x40003EA")]
		public const string SettingsMenuItemPath = "Window/SRDebugger/Settings Window";

		[Token(Token = "0x40003EB")]
		public const string WelcomeItemPath = "Window/SRDebugger/Welcome Guide";

		[Token(Token = "0x40003EC")]
		public const string SROptionsMenuItemPath = "Window/SRDebugger/SROptions Window";

		[Token(Token = "0x40003ED")]
		public const string EditorLogoPath = "UI/Sprites/Default/Logo.psd";
	}
	[Token(Token = "0x20000E1")]
	public static class Service
	{
		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IConsoleService _consoleService;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IDebugPanelService _debugPanelService;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IDebugTriggerService _debugTriggerService;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IPinnedUIService _pinnedUiService;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static IDebugCameraService _debugCameraService;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static IOptionsService _optionsService;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static IDockConsoleService _dockConsoleService;

		[Token(Token = "0x170000E3")]
		public static IConsoleService Console
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x106452C", Offset = "0x106452C", VA = "0x106452C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		public static IDockConsoleService DockConsole
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x1066690", Offset = "0x1066690", VA = "0x1066690")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		public static IDebugPanelService Panel
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1066728", Offset = "0x1066728", VA = "0x1066728")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E6")]
		public static IDebugTriggerService Trigger
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x10667C0", Offset = "0x10667C0", VA = "0x10667C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E7")]
		public static IPinnedUIService PinnedUI
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x1066858", Offset = "0x1066858", VA = "0x1066858")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E8")]
		public static IDebugCameraService DebugCamera
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x10665F8", Offset = "0x10665F8", VA = "0x10665F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E9")]
		public static IOptionsService Options
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x10668F0", Offset = "0x10668F0", VA = "0x10668F0")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x20000E2")]
	public class SRDebugStrings
	{
		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SRDebugStrings Current;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Console_MessageTruncated;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string Console_NoStackTrace;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string PinEntryPrompt;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string Profiler_DisableProfilerInfo;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string Profiler_EnableProfilerInfo;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly string Profiler_NoProInfo;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly string Profiler_NotSupported;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly string ProfilerCameraListenerHelp;

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x1065DC0", Offset = "0x1065DC0", VA = "0x1065DC0")]
		public SRDebugStrings()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public static class SRDebuggerUtil
	{
		[Token(Token = "0x170000EA")]
		public static bool IsMobilePlatform
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1065EE8", Offset = "0x1065EE8", VA = "0x1065EE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1065F24", Offset = "0x1065F24", VA = "0x1065F24")]
		public static bool EnsureEventSystemExists()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x106608C", Offset = "0x106608C", VA = "0x106608C")]
		public static void CreateDefaultEventSystem()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x106611C", Offset = "0x106611C", VA = "0x106611C")]
		public static ICollection<OptionDefinition> ScanForOptions(object obj)
		{
			return null;
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x10664C8", Offset = "0x10664C8", VA = "0x10664C8")]
		public static string GetNumberString(int value, int max, string exceedsMaxString)
		{
			return null;
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1066500", Offset = "0x1066500", VA = "0x1066500")]
		public static void ConfigureCanvas(Canvas canvas)
		{
		}
	}
}
namespace Enhance
{
	[Token(Token = "0x20000E4")]
	[DisallowMultipleComponent]
	public class Outline : MonoBehaviour
	{
		[Token(Token = "0x20001BA")]
		public enum Mode
		{
			[Token(Token = "0x4000821")]
			OutlineAll,
			[Token(Token = "0x4000822")]
			OutlineVisible,
			[Token(Token = "0x4000823")]
			OutlineHidden,
			[Token(Token = "0x4000824")]
			OutlineAndSilhouette,
			[Token(Token = "0x4000825")]
			SilhouetteOnly
		}

		[Serializable]
		[Token(Token = "0x20001BB")]
		private class ListVector3
		{
			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Vector3> data;

			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x1244CE4", Offset = "0x1244CE4", VA = "0x1244CE4")]
			public ListVector3()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD53ABC", Offset = "0xD53ABC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Vector3, int, KeyValuePair<Vector3, int>> <>9__30_0;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<Vector3, int>, Vector3> <>9__30_1;

			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x1244E74", Offset = "0x1244E74", VA = "0x1244E74")]
			public <>c()
			{
			}

			[Token(Token = "0x6000CA0")]
			[Address(RVA = "0x1244E7C", Offset = "0x1244E7C", VA = "0x1244E7C")]
			internal KeyValuePair<Vector3, int> <SmoothNormals>b__30_0(Vector3 vertex, int index)
			{
				return default(KeyValuePair<Vector3, int>);
			}

			[Token(Token = "0x6000CA1")]
			[Address(RVA = "0x1244F0C", Offset = "0x1244F0C", VA = "0x1244F0C")]
			internal Vector3 <SmoothNormals>b__30_1(KeyValuePair<Vector3, int> pair)
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HashSet<Mesh> registeredMeshes;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Mode outlineMode;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color outlineColor;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD5519C", Offset = "0xD5519C")]
		private float outlineWidth;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD551DC", Offset = "0xD551DC")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD551DC", Offset = "0xD551DC")]
		private bool precomputeOutline;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private List<Mesh> bakeKeys;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private List<ListVector3> bakeValues;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Renderer[] renderers;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material outlineMaskMaterial;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material outlineFillMaterial;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool needsUpdate;

		[Token(Token = "0x170000EB")]
		public Mode OutlineMode
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x124368C", Offset = "0x124368C", VA = "0x124368C")]
			get
			{
				return default(Mode);
			}
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x1243694", Offset = "0x1243694", VA = "0x1243694")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public Color OutlineColor
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x12436A4", Offset = "0x12436A4", VA = "0x12436A4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x12436B0", Offset = "0x12436B0", VA = "0x12436B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public float OutlineWidth
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x12436C4", Offset = "0x12436C4", VA = "0x12436C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x12436CC", Offset = "0x12436CC", VA = "0x12436CC")]
			set
			{
			}
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x12436DC", Offset = "0x12436DC", VA = "0x12436DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1243ABC", Offset = "0x1243ABC", VA = "0x1243ABC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1243BCC", Offset = "0x1243BCC", VA = "0x1243BCC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1243E3C", Offset = "0x1243E3C", VA = "0x1243E3C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1244134", Offset = "0x1244134", VA = "0x1244134")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1244244", Offset = "0x1244244", VA = "0x1244244")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1243CA4", Offset = "0x1243CA4", VA = "0x1243CA4")]
		private void Bake()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1243808", Offset = "0x1243808", VA = "0x1243808")]
		private void LoadSmoothNormals()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x12442BC", Offset = "0x12442BC", VA = "0x12442BC")]
		private List<Vector3> SmoothNormals(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1243E50", Offset = "0x1243E50", VA = "0x1243E50")]
		private void UpdateMaterialProperties()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1244CEC", Offset = "0x1244CEC", VA = "0x1244CEC")]
		public Outline()
		{
		}
	}
}
namespace Photon.Realtime.Demo
{
	[Token(Token = "0x20000E5")]
	public class ConnectAndJoinRandomLb : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks, ILobbyCallbacks
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AppSettings appSettings;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LoadBalancingClient lbc;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ConnectionHandler ch;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text StateUiText;

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x106296C", Offset = "0x106296C", VA = "0x106296C")]
		public void Start()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1062AD0", Offset = "0x1062AD0", VA = "0x1062AD0")]
		public void Update()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1062C0C", Offset = "0x1062C0C", VA = "0x1062C0C", Slot = "4")]
		public void OnConnected()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1062C10", Offset = "0x1062C10", VA = "0x1062C10", Slot = "5")]
		public void OnConnectedToMaster()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1062C98", Offset = "0x1062C98", VA = "0x1062C98", Slot = "6")]
		public void OnDisconnected(DisconnectCause cause)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1062D54", Offset = "0x1062D54", VA = "0x1062D54", Slot = "8")]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1062D58", Offset = "0x1062D58", VA = "0x1062D58", Slot = "9")]
		public void OnCustomAuthenticationFailed(string debugMessage)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1062D5C", Offset = "0x1062D5C", VA = "0x1062D5C", Slot = "7")]
		public void OnRegionListReceived(RegionHandler regionHandler)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1062E28", Offset = "0x1062E28", VA = "0x1062E28", Slot = "19")]
		public void OnRoomListUpdate(List<RoomInfo> roomList)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1062E2C", Offset = "0x1062E2C", VA = "0x1062E2C", Slot = "20")]
		public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1062E30", Offset = "0x1062E30", VA = "0x1062E30", Slot = "17")]
		public void OnJoinedLobby()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1062E34", Offset = "0x1062E34", VA = "0x1062E34", Slot = "18")]
		public void OnLeftLobby()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1062E38", Offset = "0x1062E38", VA = "0x1062E38", Slot = "10")]
		public void OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1062E3C", Offset = "0x1062E3C", VA = "0x1062E3C", Slot = "11")]
		public void OnCreatedRoom()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1062E40", Offset = "0x1062E40", VA = "0x1062E40", Slot = "12")]
		public void OnCreateRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1062E44", Offset = "0x1062E44", VA = "0x1062E44", Slot = "13")]
		public void OnJoinedRoom()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1062EB0", Offset = "0x1062EB0", VA = "0x1062EB0", Slot = "14")]
		public void OnJoinRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1062EB4", Offset = "0x1062EB4", VA = "0x1062EB4", Slot = "15")]
		public void OnJoinRandomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1062F5C", Offset = "0x1062F5C", VA = "0x1062F5C", Slot = "16")]
		public void OnLeftRoom()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1062F60", Offset = "0x1062F60", VA = "0x1062F60")]
		private void OnRegionPingCompleted(RegionHandler regionHandler)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1063064", Offset = "0x1063064", VA = "0x1063064")]
		public ConnectAndJoinRandomLb()
		{
		}
	}
}
namespace Photon.Chat.UtilityScripts
{
	[Token(Token = "0x20000E6")]
	public class EventSystemSpawner : MonoBehaviour
	{
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1062260", Offset = "0x1062260", VA = "0x1062260")]
		private void Start()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x106233C", Offset = "0x106233C", VA = "0x106233C")]
		public EventSystemSpawner()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class OnStartDelete : MonoBehaviour
	{
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1062344", Offset = "0x1062344", VA = "0x1062344")]
		private void Start()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x10623C0", Offset = "0x10623C0", VA = "0x10623C0")]
		public OnStartDelete()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD528FC", Offset = "0xD528FC")]
	public class TextButtonTransition : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Text _text;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Selectable Selectable;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color NormalColor;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color HoverColor;

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x10623C8", Offset = "0x10623C8", VA = "0x10623C8")]
		public void Awake()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1062420", Offset = "0x1062420", VA = "0x1062420")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1062450", Offset = "0x1062450", VA = "0x1062450")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1062480", Offset = "0x1062480", VA = "0x1062480", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1062540", Offset = "0x1062540", VA = "0x1062540", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1062600", Offset = "0x1062600", VA = "0x1062600")]
		public TextButtonTransition()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD52960", Offset = "0xD52960")]
	public class TextToggleIsOnTransition : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle toggle;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text _text;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color NormalOnColor;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color NormalOffColor;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color HoverOnColor;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Color HoverOffColor;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isHover;

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1062644", Offset = "0x1062644", VA = "0x1062644")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1062778", Offset = "0x1062778", VA = "0x1062778")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1062714", Offset = "0x1062714", VA = "0x1062714")]
		public void OnValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x106281C", Offset = "0x106281C", VA = "0x106281C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1062894", Offset = "0x1062894", VA = "0x1062894", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1062908", Offset = "0x1062908", VA = "0x1062908")]
		public TextToggleIsOnTransition()
		{
		}
	}
}
namespace PathCreation.Examples
{
	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD529C4", Offset = "0xD529C4")]
	public class GeneratePathExample : MonoBehaviour
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool closedLoop;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform[] waypoints;

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1060728", Offset = "0x1060728", VA = "0x1060728")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x10607E0", Offset = "0x10607E0", VA = "0x10607E0")]
		public GeneratePathExample()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class PathFollower : MonoBehaviour
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PathCreator pathCreator;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EndOfPathInstruction endOfPathInstruction;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float distanceTravelled;

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x10607F0", Offset = "0x10607F0", VA = "0x10607F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x10608C4", Offset = "0x10608C4", VA = "0x10608C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x10609FC", Offset = "0x10609FC", VA = "0x10609FC")]
		private void OnPathChanged()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x1060A5C", Offset = "0x1060A5C", VA = "0x1060A5C")]
		public PathFollower()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[ExecuteInEditMode]
	public class PathPlacer : PathSceneTool
	{
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject prefab;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject holder;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float spacing;

		[Token(Token = "0x4000421")]
		private const float minSpacing = 0.1f;

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x1060A6C", Offset = "0x1060A6C", VA = "0x1060A6C")]
		private void Generate()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x1060CA8", Offset = "0x1060CA8", VA = "0x1060CA8")]
		private void DestroyObjects()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1060D84", Offset = "0x1060D84", VA = "0x1060D84", Slot = "5")]
		protected override void PathUpdated()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1060E0C", Offset = "0x1060E0C", VA = "0x1060E0C")]
		public PathPlacer()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	[ExecuteInEditMode]
	public abstract class PathSceneTool : MonoBehaviour
	{
		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PathCreator pathCreator;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoUpdate;

		[Token(Token = "0x170000EE")]
		protected VertexPath path
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x1060F7C", Offset = "0x1060F7C", VA = "0x1060F7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000012")]
		public event Action onDestroyed
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0x1060E34", Offset = "0x1060E34", VA = "0x1060E34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD583F8", Offset = "0xD583F8")]
			add
			{
			}
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x1060ED8", Offset = "0x1060ED8", VA = "0x1060ED8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58408", Offset = "0xD58408")]
			remove
			{
			}
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1060F98", Offset = "0x1060F98", VA = "0x1060F98")]
		public void TriggerUpdate()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x1060FA4", Offset = "0x1060FA4", VA = "0x1060FA4", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600070B")]
		protected abstract void PathUpdated();

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1060E24", Offset = "0x1060E24", VA = "0x1060E24")]
		protected PathSceneTool()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class PathSpawner : MonoBehaviour
	{
		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PathCreator pathPrefab;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PathFollower followerPrefab;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform[] spawnPoints;

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x1060FB8", Offset = "0x1060FB8", VA = "0x1060FB8")]
		private void Start()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1061148", Offset = "0x1061148", VA = "0x1061148")]
		public PathSpawner()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class RoadMeshCreator : PathSceneTool
	{
		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD552DC", Offset = "0xD552DC")]
		public float roadWidth;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD55314", Offset = "0xD55314")]
		public float thickness;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool flattenSurface;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5532C", Offset = "0xD5532C")]
		public Material roadMaterial;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Material undersideMaterial;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float textureTiling;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private GameObject meshHolder;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshFilter meshFilter;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshRenderer meshRenderer;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Mesh mesh;

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1061150", Offset = "0x1061150", VA = "0x1061150", Slot = "5")]
		protected override void PathUpdated()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x10616EC", Offset = "0x10616EC", VA = "0x10616EC")]
		private void CreateRoadMesh()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x10611E8", Offset = "0x10611E8", VA = "0x10611E8")]
		private void AssignMeshComponents()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x10614E8", Offset = "0x10614E8", VA = "0x10614E8")]
		private void AssignMaterials()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x106223C", Offset = "0x106223C", VA = "0x106223C")]
		public RoadMeshCreator()
		{
		}
	}
}
namespace PaintIn3D
{
	[Token(Token = "0x20000F0")]
	public class P3dPaintBrush : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20001BD")]
		public class SharedData
		{
			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Texture shape;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private P3dChannel shapeChannel;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private P3dModifierList modifiers;

			[Token(Token = "0x1700025D")]
			public Texture Shape
			{
				[Token(Token = "0x6000CA3")]
				[Address(RVA = "0x1846074", Offset = "0x1846074", VA = "0x1846074")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000CA2")]
				[Address(RVA = "0x184606C", Offset = "0x184606C", VA = "0x184606C")]
				set
				{
				}
			}

			[Token(Token = "0x1700025E")]
			public P3dChannel ShapeChannel
			{
				[Token(Token = "0x6000CA5")]
				[Address(RVA = "0x1846084", Offset = "0x1846084", VA = "0x1846084")]
				get
				{
					return default(P3dChannel);
				}
				[Token(Token = "0x6000CA4")]
				[Address(RVA = "0x184607C", Offset = "0x184607C", VA = "0x184607C")]
				set
				{
				}
			}

			[Token(Token = "0x1700025F")]
			public P3dModifierList Modifiers
			{
				[Token(Token = "0x6000CA6")]
				[Address(RVA = "0x184608C", Offset = "0x184608C", VA = "0x184608C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CA7")]
			[Address(RVA = "0x18460F8", Offset = "0x18460F8", VA = "0x18460F8")]
			public void Draw(Rect rect)
			{
			}

			[Token(Token = "0x6000CA8")]
			[Address(RVA = "0x1845EB8", Offset = "0x1845EB8", VA = "0x1845EB8")]
			public SharedData()
			{
			}
		}

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string category;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SharedData data;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<P3dPaintBrush> cachedInstances;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool cachedInstancesSet;

		[Token(Token = "0x170000EF")]
		public string Category
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1845E44", Offset = "0x1845E44", VA = "0x1845E44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x1845E3C", Offset = "0x1845E3C", VA = "0x1845E3C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public SharedData Data
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x1845E4C", Offset = "0x1845E4C", VA = "0x1845E4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F1")]
		public static List<P3dPaintBrush> CachedInstances
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x1845F48", Offset = "0x1845F48", VA = "0x1845F48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1845EC0", Offset = "0x1845EC0", VA = "0x1845EC0")]
		public static void UpdateCachedInstances()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1845FF0", Offset = "0x1845FF0", VA = "0x1845FF0")]
		public P3dPaintBrush()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class P3dPaintMaterial : ScriptableObject, P3dShaderTemplate.IHasTemplate
	{
		[Serializable]
		[Token(Token = "0x20001BE")]
		public class Slot
		{
			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public P3dGroup Group;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Texture Texture;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Color Color;

			[Token(Token = "0x6000CA9")]
			[Address(RVA = "0x184841C", Offset = "0x184841C", VA = "0x184841C")]
			public Slot()
			{
			}
		}

		[Token(Token = "0x20001BF")]
		public enum StyleType
		{
			[Token(Token = "0x4000831")]
			Seamless,
			[Token(Token = "0x4000832")]
			Decal
		}

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string category;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture2D thumbnail;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StyleType style;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Texture shape;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Material material;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private P3dShaderTemplate template;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<Slot> slots;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<P3dPaintMaterial> cachedInstances;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool cachedInstancesSet;

		[Token(Token = "0x170000F2")]
		public string Category
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1847ED0", Offset = "0x1847ED0", VA = "0x1847ED0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1847EC8", Offset = "0x1847EC8", VA = "0x1847EC8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public Texture2D Thumbnail
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x1847EE0", Offset = "0x1847EE0", VA = "0x1847EE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x1847ED8", Offset = "0x1847ED8", VA = "0x1847ED8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public StyleType Style
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x1847EF0", Offset = "0x1847EF0", VA = "0x1847EF0")]
			get
			{
				return default(StyleType);
			}
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1847EE8", Offset = "0x1847EE8", VA = "0x1847EE8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public Texture Shape
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1847F00", Offset = "0x1847F00", VA = "0x1847F00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x1847EF8", Offset = "0x1847EF8", VA = "0x1847EF8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public Material Material
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x1847F10", Offset = "0x1847F10", VA = "0x1847F10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1847F08", Offset = "0x1847F08", VA = "0x1847F08")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public P3dShaderTemplate Template
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x1847F20", Offset = "0x1847F20", VA = "0x1847F20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1847F18", Offset = "0x1847F18", VA = "0x1847F18")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public List<Slot> Slots
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x1847F28", Offset = "0x1847F28", VA = "0x1847F28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F9")]
		public static List<P3dPaintMaterial> CachedInstances
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x18481E0", Offset = "0x18481E0", VA = "0x18481E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1847F9C", Offset = "0x1847F9C", VA = "0x1847F9C")]
		public static void Draw(P3dPaintMaterial paintMaterial, Rect rect)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x18480D4", Offset = "0x18480D4", VA = "0x18480D4", Slot = "4")]
		public void SetTemplate(P3dShaderTemplate template)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x18480DC", Offset = "0x18480DC", VA = "0x18480DC", Slot = "5")]
		public P3dShaderTemplate GetTemplate()
		{
			return null;
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x18480E4", Offset = "0x18480E4", VA = "0x18480E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58418", Offset = "0xD58418")]
		public void ClearThumbnail()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x1848158", Offset = "0x1848158", VA = "0x1848158")]
		public static void UpdateCachedInstances()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1848288", Offset = "0x1848288", VA = "0x1848288")]
		public Slot GetSlot(P3dGroup group)
		{
			return null;
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x18483A0", Offset = "0x18483A0", VA = "0x18483A0")]
		public P3dPaintMaterial()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class P3dScene : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20001C0")]
		public class Image
		{
			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public P3dGroup Group;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int MatId;

			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int Width;

			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int Height;

			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public byte[] Pixels;

			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RenderTexture Current;

			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RenderTexture Preview;

			[Token(Token = "0x17000260")]
			public Image Clone
			{
				[Token(Token = "0x6000CAA")]
				[Address(RVA = "0x105A934", Offset = "0x105A934", VA = "0x105A934")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x105AAE4", Offset = "0x105AAE4", VA = "0x105AAE4")]
			public void Save()
			{
			}

			[Token(Token = "0x6000CAC")]
			[Address(RVA = "0x105AADC", Offset = "0x105AADC", VA = "0x105AADC")]
			public Image()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C1")]
		public class Layer
		{
			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float Opacity;

			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<Image> Images;

			[Token(Token = "0x17000261")]
			public Layer Clone
			{
				[Token(Token = "0x6000CAD")]
				[Address(RVA = "0x105AC1C", Offset = "0x105AC1C", VA = "0x105AC1C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CAE")]
			[Address(RVA = "0x105ADE8", Offset = "0x105ADE8", VA = "0x105ADE8")]
			public Image GetImage(int matId, P3dGroup group)
			{
				return null;
			}

			[Token(Token = "0x6000CAF")]
			[Address(RVA = "0x105AF5C", Offset = "0x105AF5C", VA = "0x105AF5C")]
			public void Save()
			{
			}

			[Token(Token = "0x6000CB0")]
			[Address(RVA = "0x105AD70", Offset = "0x105AD70", VA = "0x105AD70")]
			public Layer()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C2")]
		public class Slot
		{
			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool Dirty;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RenderTexture Texture;

			[Token(Token = "0x6000CB1")]
			[Address(RVA = "0x105B780", Offset = "0x105B780", VA = "0x105B780")]
			public Slot()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C3")]
		public class Mat : P3dShaderTemplate.IHasTemplate
		{
			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int Id;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string Name;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Material Material;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public P3dShaderTemplate Template;

			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int Width;

			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int Height;

			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<Slot> Slots;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Dictionary<P3dGroup, MergedLayer> MergedLayers;

			[NonSerialized]
			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public MaterialPropertyBlock Properties;

			[Token(Token = "0x17000262")]
			public Mat Clone
			{
				[Token(Token = "0x6000CB2")]
				[Address(RVA = "0x105B050", Offset = "0x105B050", VA = "0x105B050")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000263")]
			public bool SizesMatch
			{
				[Token(Token = "0x6000CB3")]
				[Address(RVA = "0x105B17C", Offset = "0x105B17C", VA = "0x105B17C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000264")]
			public RenderTextureDescriptor Desc
			{
				[Token(Token = "0x6000CB9")]
				[Address(RVA = "0x105B814", Offset = "0x105B814", VA = "0x105B814")]
				get
				{
					return default(RenderTextureDescriptor);
				}
			}

			[Token(Token = "0x6000CB4")]
			[Address(RVA = "0x105B334", Offset = "0x105B334", VA = "0x105B334")]
			public void Resize()
			{
			}

			[Token(Token = "0x6000CB5")]
			[Address(RVA = "0x105B604", Offset = "0x105B604", VA = "0x105B604", Slot = "4")]
			public void SetTemplate(P3dShaderTemplate template)
			{
			}

			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0x105B60C", Offset = "0x105B60C", VA = "0x105B60C", Slot = "5")]
			public P3dShaderTemplate GetTemplate()
			{
				return null;
			}

			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x105B614", Offset = "0x105B614", VA = "0x105B614")]
			public Slot GetSlot(string name)
			{
				return null;
			}

			[Token(Token = "0x6000CB8")]
			[Address(RVA = "0x105B788", Offset = "0x105B788", VA = "0x105B788")]
			public Texture GetFinalTexture(P3dGroup group)
			{
				return null;
			}

			[Token(Token = "0x6000CBA")]
			[Address(RVA = "0x105B8A0", Offset = "0x105B8A0", VA = "0x105B8A0")]
			public void UpdateMergedLayers(P3dGroup group)
			{
			}

			[Token(Token = "0x6000CBB")]
			[Address(RVA = "0x105B0E4", Offset = "0x105B0E4", VA = "0x105B0E4")]
			public Mat()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C4")]
		public class Obj
		{
			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Mesh Mesh;

			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool Paintable;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public P3dCoord Coord;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform Transform;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 Position;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion Rotation;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Vector3 Scale;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<int> MatIds;

			[Token(Token = "0x17000265")]
			public Matrix4x4 Matrix
			{
				[Token(Token = "0x6000CBC")]
				[Address(RVA = "0x105BA0C", Offset = "0x105BA0C", VA = "0x105BA0C")]
				get
				{
					return default(Matrix4x4);
				}
			}

			[Token(Token = "0x17000266")]
			public Obj Clone
			{
				[Token(Token = "0x6000CBD")]
				[Address(RVA = "0x105BAE4", Offset = "0x105BAE4", VA = "0x105BAE4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CBE")]
			[Address(RVA = "0x105BBD0", Offset = "0x105BBD0", VA = "0x105BBD0")]
			public Obj()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C5")]
		public class Cloner : IClone
		{
			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 Position;

			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 Euler;

			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool Flip;

			[Token(Token = "0x6000CBF")]
			[Address(RVA = "0x105A3C0", Offset = "0x105A3C0", VA = "0x105A3C0", Slot = "4")]
			public void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix)
			{
			}

			[Token(Token = "0x6000CC0")]
			[Address(RVA = "0x105A92C", Offset = "0x105A92C", VA = "0x105A92C")]
			public Cloner()
			{
			}
		}

		[Token(Token = "0x20001C6")]
		public class MergedLayer
		{
			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RenderTexture Under;

			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RenderTexture Above;

			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RenderTexture Final;

			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Layer Layer;

			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool Dirty;

			[Token(Token = "0x6000CC1")]
			[Address(RVA = "0x105B970", Offset = "0x105B970", VA = "0x105B970")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000CC2")]
			[Address(RVA = "0x105B968", Offset = "0x105B968", VA = "0x105B968")]
			public MergedLayer()
			{
			}
		}

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Layer> Layers;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Mat> Mats;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Obj> Objs;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<Cloner> Cloners;

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x184E57C", Offset = "0x184E57C", VA = "0x184E57C")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x184EA10", Offset = "0x184EA10", VA = "0x184EA10")]
		public void UpdateMergedLayers(Layer currentLayer)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x184F694", Offset = "0x184F694", VA = "0x184F694")]
		private static void TryBlendInto(ref RenderTexture renderTexture, Layer layer, int matId, P3dGroup group)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x184F814", Offset = "0x184F814", VA = "0x184F814")]
		public void Save()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x184F90C", Offset = "0x184F90C", VA = "0x184F90C")]
		public void RemoveObj(Obj obj)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x184F988", Offset = "0x184F988", VA = "0x184F988")]
		public Mat GetMat(int matId)
		{
			return null;
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x184FA9C", Offset = "0x184FA9C", VA = "0x184FA9C")]
		public bool MatNameValid(string name, int maxCount = 1)
		{
			return default(bool);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x184FBEC", Offset = "0x184FBEC", VA = "0x184FBEC")]
		public void RemoveMat(Mat mat)
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x184FC68", Offset = "0x184FC68", VA = "0x184FC68")]
		public bool ObjExists(Transform source)
		{
			return default(bool);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x184FDAC", Offset = "0x184FDAC", VA = "0x184FDAC")]
		public Mat AddMat(Material material, P3dShaderTemplate template, int size)
		{
			return null;
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x184FF58", Offset = "0x184FF58", VA = "0x184FF58")]
		public void AddObj(Transform source, Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale, Material[] materials, P3dShaderTemplate[] templates, int size)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x18502C4", Offset = "0x18502C4", VA = "0x18502C4")]
		public Cloner AddCloner(string name, Vector3 position, Vector3 euler)
		{
			return null;
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1850394", Offset = "0x1850394", VA = "0x1850394")]
		public void RemoveRepeater(Cloner repeater)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1850410", Offset = "0x1850410", VA = "0x1850410")]
		public Layer AddLayer()
		{
			return null;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x18504A4", Offset = "0x18504A4", VA = "0x18504A4")]
		public void RemoveLayer(Layer layer)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1850520", Offset = "0x1850520", VA = "0x1850520")]
		public P3dScene()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class P3dShaderTemplate : ScriptableObject
	{
		[Token(Token = "0x20001C7")]
		public interface IHasTemplate
		{
			[Token(Token = "0x6000CC3")]
			void SetTemplate(P3dShaderTemplate template);

			[Token(Token = "0x6000CC4")]
			P3dShaderTemplate GetTemplate();
		}

		[Token(Token = "0x20001C8")]
		public enum Channel
		{
			[Token(Token = "0x400085C")]
			Red,
			[Token(Token = "0x400085D")]
			Green,
			[Token(Token = "0x400085E")]
			Blue,
			[Token(Token = "0x400085F")]
			Alpha
		}

		[Serializable]
		[Token(Token = "0x20001C9")]
		public class Write
		{
			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public P3dGroup SourceGroup;

			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Channel SourceChannel;

			[Token(Token = "0x6000CC5")]
			[Address(RVA = "0x106007C", Offset = "0x106007C", VA = "0x106007C")]
			public Write GetCopy()
			{
				return null;
			}

			[Token(Token = "0x6000CC6")]
			[Address(RVA = "0x10600F4", Offset = "0x10600F4", VA = "0x10600F4")]
			public Write()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001CA")]
		public class Slot
		{
			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string Alias;

			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Write WriteR;

			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Write WriteG;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Write WriteB;

			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Write WriteA;

			[Token(Token = "0x6000CC7")]
			[Address(RVA = "0x1060038", Offset = "0x1060038", VA = "0x1060038")]
			public string GetAlias()
			{
				return null;
			}

			[Token(Token = "0x6000CC8")]
			[Address(RVA = "0x1060074", Offset = "0x1060074", VA = "0x1060074")]
			public Slot()
			{
			}
		}

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<P3dShaderTemplate> tempInstances;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Shader shader;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Slot> slots;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<P3dShaderTemplate> cachedInstances;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool cachedInstancesSet;

		[Token(Token = "0x170000FA")]
		public Shader Shader
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x105FF18", Offset = "0x105FF18", VA = "0x105FF18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x105FF10", Offset = "0x105FF10", VA = "0x105FF10")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public List<Slot> Slots
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x105FF20", Offset = "0x105FF20", VA = "0x105FF20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x105FC10", Offset = "0x105FC10", VA = "0x105FC10")]
		public static void UpdateCachedInstances()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x105FC98", Offset = "0x105FC98", VA = "0x105FC98")]
		public static List<P3dShaderTemplate> GetTemplates(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x105FF94", Offset = "0x105FF94", VA = "0x105FF94")]
		public P3dShaderTemplate()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD52A48", Offset = "0xD52A48")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD52A48", Offset = "0xD52A48")]
	public class P3dCloneMirror : P3dClone
	{
		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool flip;

		[Token(Token = "0x170000FC")]
		public bool Flip
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x12498D8", Offset = "0x12498D8", VA = "0x12498D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x12498CC", Offset = "0x12498CC", VA = "0x12498CC")]
			set
			{
			}
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x12498E0", Offset = "0x12498E0", VA = "0x12498E0", Slot = "7")]
		public override void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1249E6C", Offset = "0x1249E6C", VA = "0x1249E6C")]
		public P3dCloneMirror()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public abstract class P3dConnectableLines : MonoBehaviour
	{
		[Token(Token = "0x20001CB")]
		private class Link
		{
			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object Owner;

			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 Position;

			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 EndPosition;

			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float Age;

			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool Preview;

			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0x124E03C", Offset = "0x124E03C", VA = "0x124E03C")]
			public Link()
			{
			}
		}

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected bool connectHits;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float hitSpacing;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int hitLimit;

		[NonSerialized]
		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Link> links;

		[NonSerialized]
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Stack<Link> linkPool;

		[NonSerialized]
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected P3dHitCache hitCache;

		[Token(Token = "0x170000FD")]
		public bool ConnectHits
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x124D730", Offset = "0x124D730", VA = "0x124D730")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x124D724", Offset = "0x124D724", VA = "0x124D724")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public float HitSpacing
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x124D740", Offset = "0x124D740", VA = "0x124D740")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x124D738", Offset = "0x124D738", VA = "0x124D738")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public int HitLimit
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x124D750", Offset = "0x124D750", VA = "0x124D750")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x124D748", Offset = "0x124D748", VA = "0x124D748")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public P3dHitCache HitCache
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x124D758", Offset = "0x124D758", VA = "0x124D758")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x124D760", Offset = "0x124D760", VA = "0x124D760")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58450", Offset = "0xD58450")]
		public void ClearHitCache()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x124D77C", Offset = "0x124D77C", VA = "0x124D77C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58488", Offset = "0xD58488")]
		public void ResetConnections()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x124D870", Offset = "0x124D870", VA = "0x124D870")]
		protected void BreakHits(object owner)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x124D978", Offset = "0x124D978", VA = "0x124D978")]
		protected void SubmitLine(bool preview, int priority, Vector3 position, Vector3 endPosition, Quaternion rotation, float pressure, object owner)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x124E044", Offset = "0x124E044", VA = "0x124E044", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x124E048", Offset = "0x124E048", VA = "0x124E048", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x124DF74", Offset = "0x124DF74", VA = "0x124DF74")]
		private bool TryGetLink(object owner, ref Link link)
		{
			return default(bool);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x124E180", Offset = "0x124E180", VA = "0x124E180")]
		protected P3dConnectableLines()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public abstract class P3dConnectablePoints : MonoBehaviour
	{
		[Token(Token = "0x20001CC")]
		private class Link
		{
			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object Owner;

			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 Position;

			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float Age;

			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool Preview;

			[Token(Token = "0x6000CCA")]
			[Address(RVA = "0x124EA1C", Offset = "0x124EA1C", VA = "0x124EA1C")]
			public Link()
			{
			}
		}

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected bool connectHits;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float hitSpacing;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int hitLimit;

		[NonSerialized]
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Link> links;

		[NonSerialized]
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Stack<Link> linkPool;

		[NonSerialized]
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected P3dHitCache hitCache;

		[Token(Token = "0x17000101")]
		public bool ConnectHits
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x124E298", Offset = "0x124E298", VA = "0x124E298")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x124E28C", Offset = "0x124E28C", VA = "0x124E28C")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public float HitSpacing
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x124E2A8", Offset = "0x124E2A8", VA = "0x124E2A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x124E2A0", Offset = "0x124E2A0", VA = "0x124E2A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public int HitLimit
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x124E2B8", Offset = "0x124E2B8", VA = "0x124E2B8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x124E2B0", Offset = "0x124E2B0", VA = "0x124E2B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public P3dHitCache HitCache
		{
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x124E2C0", Offset = "0x124E2C0", VA = "0x124E2C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x124E2C8", Offset = "0x124E2C8", VA = "0x124E2C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD584C0", Offset = "0xD584C0")]
		public void ClearHitCache()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x124E2E4", Offset = "0x124E2E4", VA = "0x124E2E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD584F8", Offset = "0xD584F8")]
		public void ResetConnections()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x124E3D8", Offset = "0x124E3D8", VA = "0x124E3D8")]
		protected void BreakHits(object owner)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x124E4E0", Offset = "0x124E4E0", VA = "0x124E4E0")]
		protected void SubmitPoint(bool preview, int priority, float pressure, Vector3 position, Quaternion rotation, object owner)
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x124EA24", Offset = "0x124EA24", VA = "0x124EA24", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x124EA28", Offset = "0x124EA28", VA = "0x124EA28", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x124E954", Offset = "0x124E954", VA = "0x124E954")]
		private bool TryGetLink(object owner, ref Link link)
		{
			return default(bool);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x124EB60", Offset = "0x124EB60", VA = "0x124EB60")]
		protected P3dConnectablePoints()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD52AA8", Offset = "0xD52AA8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD52AA8", Offset = "0xD52AA8")]
	public class P3dHitBetween : P3dConnectablePoints
	{
		[Token(Token = "0x20001CD")]
		public enum PhaseType
		{
			[Token(Token = "0x4000872")]
			Update,
			[Token(Token = "0x4000873")]
			FixedUpdate
		}

		[Token(Token = "0x20001CE")]
		public enum OrientationType
		{
			[Token(Token = "0x4000875")]
			WorldUp,
			[Token(Token = "0x4000876")]
			CameraUp
		}

		[Token(Token = "0x20001CF")]
		public enum NormalType
		{
			[Token(Token = "0x4000878")]
			HitNormal,
			[Token(Token = "0x4000879")]
			RayDirection
		}

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PhaseType paintIn;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD554CC", Offset = "0xD554CC")]
		[SerializeField]
		private float interval;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform pointA;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform pointB;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float fraction;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private LayerMask layers;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private OrientationType orientation;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Camera _camera;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private NormalType normal;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float offset;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD55598", Offset = "0xD55598")]
		[SerializeField]
		private float pressure;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private bool preview;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private int priority;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform point;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private LineRenderer line;

		[NonSerialized]
		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float current;

		[Token(Token = "0x17000105")]
		public PhaseType PaintIn
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x183D34C", Offset = "0x183D34C", VA = "0x183D34C")]
			get
			{
				return default(PhaseType);
			}
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x183D344", Offset = "0x183D344", VA = "0x183D344")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public float Interval
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x183D35C", Offset = "0x183D35C", VA = "0x183D35C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x183D354", Offset = "0x183D354", VA = "0x183D354")]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public Transform PointA
		{
			[Token(Token = "0x6000771")]
			[Address(RVA = "0x183D36C", Offset = "0x183D36C", VA = "0x183D36C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000770")]
			[Address(RVA = "0x183D364", Offset = "0x183D364", VA = "0x183D364")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public Transform PointB
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x183D37C", Offset = "0x183D37C", VA = "0x183D37C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000772")]
			[Address(RVA = "0x183D374", Offset = "0x183D374", VA = "0x183D374")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public float Fraction
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x183D384", Offset = "0x183D384", VA = "0x183D384")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700010A")]
		public LayerMask Layers
		{
			[Token(Token = "0x6000776")]
			[Address(RVA = "0x183D394", Offset = "0x183D394", VA = "0x183D394")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x183D38C", Offset = "0x183D38C", VA = "0x183D38C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public OrientationType Orientation
		{
			[Token(Token = "0x6000778")]
			[Address(RVA = "0x183D3A4", Offset = "0x183D3A4", VA = "0x183D3A4")]
			get
			{
				return default(OrientationType);
			}
			[Token(Token = "0x6000777")]
			[Address(RVA = "0x183D39C", Offset = "0x183D39C", VA = "0x183D39C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public Camera Camera
		{
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x183D3B4", Offset = "0x183D3B4", VA = "0x183D3B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000779")]
			[Address(RVA = "0x183D3AC", Offset = "0x183D3AC", VA = "0x183D3AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public NormalType Normal
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x183D3C4", Offset = "0x183D3C4", VA = "0x183D3C4")]
			get
			{
				return default(NormalType);
			}
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x183D3BC", Offset = "0x183D3BC", VA = "0x183D3BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public float Offset
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0x183D3D4", Offset = "0x183D3D4", VA = "0x183D3D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600077D")]
			[Address(RVA = "0x183D3CC", Offset = "0x183D3CC", VA = "0x183D3CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public float Pressure
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x183D3E4", Offset = "0x183D3E4", VA = "0x183D3E4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x183D3DC", Offset = "0x183D3DC", VA = "0x183D3DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public bool Preview
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x183D3F8", Offset = "0x183D3F8", VA = "0x183D3F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x183D3EC", Offset = "0x183D3EC", VA = "0x183D3EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000111")]
		public int Priority
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x183D408", Offset = "0x183D408", VA = "0x183D408")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000783")]
			[Address(RVA = "0x183D400", Offset = "0x183D400", VA = "0x183D400")]
			set
			{
			}
		}

		[Token(Token = "0x17000112")]
		public Transform Point
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0x183D418", Offset = "0x183D418", VA = "0x183D418")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000785")]
			[Address(RVA = "0x183D410", Offset = "0x183D410", VA = "0x183D410")]
			set
			{
			}
		}

		[Token(Token = "0x17000113")]
		public LineRenderer Line
		{
			[Token(Token = "0x6000788")]
			[Address(RVA = "0x183D428", Offset = "0x183D428", VA = "0x183D428")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x183D420", Offset = "0x183D420", VA = "0x183D420")]
			set
			{
			}
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x183D430", Offset = "0x183D430", VA = "0x183D430")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58530", Offset = "0xD58530")]
		public void ManuallyHitNow()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x183DAE0", Offset = "0x183DAE0", VA = "0x183DAE0")]
		private void UpdatePointAndLine()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x183DD2C", Offset = "0x183DD2C", VA = "0x183DD2C", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x183DE10", Offset = "0x183DE10", VA = "0x183DE10", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x183DECC", Offset = "0x183DECC", VA = "0x183DECC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x183DED0", Offset = "0x183DED0", VA = "0x183DED0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x183DE64", Offset = "0x183DE64", VA = "0x183DE64")]
		private void UpdateHit()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x183DEEC", Offset = "0x183DEEC", VA = "0x183DEEC")]
		public P3dHitBetween()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class P3dHitCache
	{
		[NonSerialized]
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool cached;

		[NonSerialized]
		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<IHitPoint> hitPoints;

		[NonSerialized]
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<IHitLine> hitLines;

		[NonSerialized]
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<IHitQuad> hitQuads;

		[NonSerialized]
		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<IHitRaycast> hitRaycasts;

		[NonSerialized]
		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<IHit> hits;

		[Token(Token = "0x17000114")]
		public bool Cached
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0x183DF7C", Offset = "0x183DF7C", VA = "0x183DF7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x183DF84", Offset = "0x183DF84", VA = "0x183DF84")]
		public void InvokePoint(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x183E398", Offset = "0x183E398", VA = "0x183E398")]
		public void InvokeLine(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x183E54C", Offset = "0x183E54C", VA = "0x183E54C")]
		public void InvokeQuad(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x183D908", Offset = "0x183D908", VA = "0x183D908")]
		public void InvokeRaycast(GameObject gameObject, bool preview, int priority, float pressure, RaycastHit hit, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x183E728", Offset = "0x183E728", VA = "0x183E728")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x183E130", Offset = "0x183E130", VA = "0x183E130")]
		private void Cache(GameObject gameObject)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x183E7CC", Offset = "0x183E7CC", VA = "0x183E7CC")]
		public P3dHitCache()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD52B18", Offset = "0xD52B18")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD52B18", Offset = "0xD52B18")]
	public class P3dHitCollisions : MonoBehaviour
	{
		[Token(Token = "0x20001D0")]
		public enum OrientationType
		{
			[Token(Token = "0x400087B")]
			WorldUp,
			[Token(Token = "0x400087C")]
			CameraUp
		}

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Camera _camera;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float offset;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD55638", Offset = "0xD55638")]
		[SerializeField]
		private float impactMin;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD55684", Offset = "0xD55684")]
		[SerializeField]
		private float impactPressure;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool onlyUseFirstContact;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float delay;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask layers;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private OrientationType orientation;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float raycastDistance;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool preview;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int priority;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject root;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float cooldown;

		[NonSerialized]
		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private P3dHitCache hitCache;

		[Token(Token = "0x17000115")]
		public Camera Camera
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0x183E930", Offset = "0x183E930", VA = "0x183E930")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079A")]
			[Address(RVA = "0x183E928", Offset = "0x183E928", VA = "0x183E928")]
			set
			{
			}
		}

		[Token(Token = "0x17000116")]
		public float Offset
		{
			[Token(Token = "0x600079D")]
			[Address(RVA = "0x183E940", Offset = "0x183E940", VA = "0x183E940")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x183E938", Offset = "0x183E938", VA = "0x183E938")]
			set
			{
			}
		}

		[Token(Token = "0x17000117")]
		public float ImpactMin
		{
			[Token(Token = "0x600079F")]
			[Address(RVA = "0x183E950", Offset = "0x183E950", VA = "0x183E950")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600079E")]
			[Address(RVA = "0x183E948", Offset = "0x183E948", VA = "0x183E948")]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public float ImpactPressure
		{
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x183E960", Offset = "0x183E960", VA = "0x183E960")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x183E958", Offset = "0x183E958", VA = "0x183E958")]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public bool OnlyUseFirstContact
		{
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x183E974", Offset = "0x183E974", VA = "0x183E974")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x183E968", Offset = "0x183E968", VA = "0x183E968")]
			set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public float Delay
		{
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x183E984", Offset = "0x183E984", VA = "0x183E984")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x183E97C", Offset = "0x183E97C", VA = "0x183E97C")]
			set
			{
			}
		}

		[Token(Token = "0x1700011B")]
		public LayerMask Layers
		{
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x183E994", Offset = "0x183E994", VA = "0x183E994")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x183E98C", Offset = "0x183E98C", VA = "0x183E98C")]
			set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public OrientationType Orientation
		{
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x183E9A4", Offset = "0x183E9A4", VA = "0x183E9A4")]
			get
			{
				return default(OrientationType);
			}
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x183E99C", Offset = "0x183E99C", VA = "0x183E99C")]
			set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public float RaycastDistance
		{
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x183E9B4", Offset = "0x183E9B4", VA = "0x183E9B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x183E9AC", Offset = "0x183E9AC", VA = "0x183E9AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public bool Preview
		{
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x183E9C8", Offset = "0x183E9C8", VA = "0x183E9C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x183E9BC", Offset = "0x183E9BC", VA = "0x183E9BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		public int Priority
		{
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x183E9D8", Offset = "0x183E9D8", VA = "0x183E9D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x183E9D0", Offset = "0x183E9D0", VA = "0x183E9D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000120")]
		public GameObject Root
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x183EA2C", Offset = "0x183EA2C", VA = "0x183EA2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x183E9E0", Offset = "0x183E9E0", VA = "0x183E9E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000121")]
		public P3dHitCache HitCache
		{
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x183EA34", Offset = "0x183EA34", VA = "0x183EA34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x183EA14", Offset = "0x183EA14", VA = "0x183EA14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58568", Offset = "0xD58568")]
		public void ClearHitCache()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x183EA3C", Offset = "0x183EA3C", VA = "0x183EA3C", Slot = "4")]
		protected virtual void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x183F018", Offset = "0x183F018", VA = "0x183F018", Slot = "5")]
		protected virtual void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x183F01C", Offset = "0x183F01C", VA = "0x183F01C", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x183EA40", Offset = "0x183EA40", VA = "0x183EA40")]
		private void CheckCollision(Collision collision)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x183F054", Offset = "0x183F054", VA = "0x183F054")]
		public P3dHitCollisions()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD52B78", Offset = "0xD52B78")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD52B78", Offset = "0xD52B78")]
	public class P3dHitExplosion : MonoBehaviour
	{
		[Token(Token = "0x20001D1")]
		public enum OrientationType
		{
			[Token(Token = "0x400087E")]
			WorldUp,
			[Token(Token = "0x400087F")]
			CameraUp
		}

		[Token(Token = "0x20001D2")]
		public enum NormalType
		{
			[Token(Token = "0x4000881")]
			HitNormal,
			[Token(Token = "0x4000882")]
			RayDirection
		}

		[Token(Token = "0x20001D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD53ACC", Offset = "0xD53ACC")]
		private sealed class <DelayedOnHit>d__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pointB;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pointA;

			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public P3dHitExplosion <>4__this;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Ray <ray>5__2;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit <hit>5__3;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private float <distance01>5__4;

			[Token(Token = "0x17000267")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CCE")]
				[Address(RVA = "0x183F948", Offset = "0x183F948", VA = "0x183F948", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000268")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CD0")]
				[Address(RVA = "0x183F9B0", Offset = "0x183F9B0", VA = "0x183F9B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CCB")]
			[Address(RVA = "0x183F3AC", Offset = "0x183F3AC", VA = "0x183F3AC")]
			[DebuggerHidden]
			public <DelayedOnHit>d__48(int <>1__state)
			{
			}

			[Token(Token = "0x6000CCC")]
			[Address(RVA = "0x183F460", Offset = "0x183F460", VA = "0x183F460", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CCD")]
			[Address(RVA = "0x183F464", Offset = "0x183F464", VA = "0x183F464", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CCF")]
			[Address(RVA = "0x183F950", Offset = "0x183F950", VA = "0x183F950", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float radius;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int count;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float delayMax;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private LayerMask layers;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private OrientationType orientation;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Camera _camera;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private NormalType normal;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float offset;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool preview;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int priority;

		[NonSerialized]
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private P3dHitCache hitCache;

		[Token(Token = "0x17000122")]
		public float Radius
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x183F0F0", Offset = "0x183F0F0", VA = "0x183F0F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x183F0E8", Offset = "0x183F0E8", VA = "0x183F0E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public int Count
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x183F100", Offset = "0x183F100", VA = "0x183F100")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x183F0F8", Offset = "0x183F0F8", VA = "0x183F0F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000124")]
		public float DelayMax
		{
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x183F110", Offset = "0x183F110", VA = "0x183F110")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x183F108", Offset = "0x183F108", VA = "0x183F108")]
			set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public LayerMask Layers
		{
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x183F120", Offset = "0x183F120", VA = "0x183F120")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x183F118", Offset = "0x183F118", VA = "0x183F118")]
			set
			{
			}
		}

		[Token(Token = "0x17000126")]
		public OrientationType Orientation
		{
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x183F130", Offset = "0x183F130", VA = "0x183F130")]
			get
			{
				return default(OrientationType);
			}
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x183F128", Offset = "0x183F128", VA = "0x183F128")]
			set
			{
			}
		}

		[Token(Token = "0x17000127")]
		public Camera Camera
		{
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x183F140", Offset = "0x183F140", VA = "0x183F140")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x183F138", Offset = "0x183F138", VA = "0x183F138")]
			set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public NormalType Normal
		{
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x183F150", Offset = "0x183F150", VA = "0x183F150")]
			get
			{
				return default(NormalType);
			}
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x183F148", Offset = "0x183F148", VA = "0x183F148")]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public float Offset
		{
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x183F160", Offset = "0x183F160", VA = "0x183F160")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x183F158", Offset = "0x183F158", VA = "0x183F158")]
			set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public bool Preview
		{
			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x183F174", Offset = "0x183F174", VA = "0x183F174")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x183F168", Offset = "0x183F168", VA = "0x183F168")]
			set
			{
			}
		}

		[Token(Token = "0x1700012B")]
		public int Priority
		{
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x183F184", Offset = "0x183F184", VA = "0x183F184")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x183F17C", Offset = "0x183F17C", VA = "0x183F17C")]
			set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public P3dHitCache HitCache
		{
			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x183F18C", Offset = "0x183F18C", VA = "0x183F18C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x183F194", Offset = "0x183F194", VA = "0x183F194")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD585A0", Offset = "0xD585A0")]
		public void ClearHitCache()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x183F1AC", Offset = "0x183F1AC", VA = "0x183F1AC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x183F1B0", Offset = "0x183F1B0", VA = "0x183F1B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD585D8", Offset = "0xD585D8")]
		public void ExplodeNow()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x183F300", Offset = "0x183F300", VA = "0x183F300")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD58610", Offset = "0xD58610")]
		private IEnumerator DelayedOnHit(Vector3 pointA, Vector3 pointB)
		{
			return null;
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x183F3D8", Offset = "0x183F3D8", VA = "0x183F3D8")]
		public P3dHitExplosion()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD52BD8", Offset = "0xD52BD8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD52BD8", Offset = "0xD52BD8")]
	public class P3dHitNearby : P3dConnectablePoints
	{
		[Token(Token = "0x20001D4")]
		public enum PhaseType
		{
			[Token(Token = "0x400088C")]
			Update,
			[Token(Token = "0x400088D")]
			FixedUpdate
		}

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PhaseType paintIn;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD55810", Offset = "0xD55810")]
		[SerializeField]
		private float interval;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool preview;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int priority;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD5587C", Offset = "0xD5587C")]
		[SerializeField]
		private float pressure;

		[NonSerialized]
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float current;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 lastPosition;

		[Token(Token = "0x1700012D")]
		public PhaseType PaintIn
		{
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x183F9C0", Offset = "0x183F9C0", VA = "0x183F9C0")]
			get
			{
				return default(PhaseType);
			}
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x183F9B8", Offset = "0x183F9B8", VA = "0x183F9B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700012E")]
		public float Interval
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x183F9D0", Offset = "0x183F9D0", VA = "0x183F9D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x183F9C8", Offset = "0x183F9C8", VA = "0x183F9C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700012F")]
		public bool Preview
		{
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x183F9E4", Offset = "0x183F9E4", VA = "0x183F9E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x183F9D8", Offset = "0x183F9D8", VA = "0x183F9D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000130")]
		public int Priority
		{
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x183F9F4", Offset = "0x183F9F4", VA = "0x183F9F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x183F9EC", Offset = "0x183F9EC", VA = "0x183F9EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public float Pressure
		{
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x183FA04", Offset = "0x183FA04", VA = "0x183FA04")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x183F9FC", Offset = "0x183F9FC", VA = "0x183F9FC")]
			set
			{
			}
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x183FA0C", Offset = "0x183FA0C", VA = "0x183FA0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58674", Offset = "0xD58674")]
		public void ManuallyHitNow()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x183FAC4", Offset = "0x183FAC4", VA = "0x183FAC4", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x183FB80", Offset = "0x183FB80", VA = "0x183FB80", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x183FB18", Offset = "0x183FB18", VA = "0x183FB18")]
		private void UpdateHit()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x183FB9C", Offset = "0x183FB9C", VA = "0x183FB9C")]
		public P3dHitNearby()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD52C38", Offset = "0xD52C38")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD52C38", Offset = "0xD52C38")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD52C38", Offset = "0xD52C38")]
	public class P3dHitParticles : MonoBehaviour
	{
		[Token(Token = "0x20001D5")]
		public enum OrientationType
		{
			[Token(Token = "0x400088F")]
			WorldUp,
			[Token(Token = "0x4000890")]
			CameraUp
		}

		[Token(Token = "0x20001D6")]
		public enum NormalType
		{
			[Token(Token = "0x4000892")]
			ParticleVelocity,
			[Token(Token = "0x4000893")]
			CollisionNormal
		}

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OrientationType orientation;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera _camera;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private NormalType normal;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float offset;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int skip;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool preview;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int priority;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD5593C", Offset = "0xD5593C")]
		private float pressure;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float pressureMinDistance;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float pressureMaxDistance;

		[NonSerialized]
		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystem cachedParticleSystem;

		[NonSerialized]
		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ParticleCollisionEvent> particleCollisionEvents;

		[NonSerialized]
		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private P3dHitCache hitCache;

		[NonSerialized]
		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int skipCounter;

		[Token(Token = "0x17000132")]
		public OrientationType Orientation
		{
			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x183FC20", Offset = "0x183FC20", VA = "0x183FC20")]
			get
			{
				return default(OrientationType);
			}
			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x183FC18", Offset = "0x183FC18", VA = "0x183FC18")]
			set
			{
			}
		}

		[Token(Token = "0x17000133")]
		public Camera Camera
		{
			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x183FC30", Offset = "0x183FC30", VA = "0x183FC30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x183FC28", Offset = "0x183FC28", VA = "0x183FC28")]
			set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public NormalType Normal
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x183FC40", Offset = "0x183FC40", VA = "0x183FC40")]
			get
			{
				return default(NormalType);
			}
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x183FC38", Offset = "0x183FC38", VA = "0x183FC38")]
			set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public float Offset
		{
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x183FC50", Offset = "0x183FC50", VA = "0x183FC50")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x183FC48", Offset = "0x183FC48", VA = "0x183FC48")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public int Skip
		{
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x183FC60", Offset = "0x183FC60", VA = "0x183FC60")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x183FC58", Offset = "0x183FC58", VA = "0x183FC58")]
			set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public bool Preview
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x183FC74", Offset = "0x183FC74", VA = "0x183FC74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x183FC68", Offset = "0x183FC68", VA = "0x183FC68")]
			set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public int Priority
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x183FC84", Offset = "0x183FC84", VA = "0x183FC84")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x183FC7C", Offset = "0x183FC7C", VA = "0x183FC7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000139")]
		public float Pressure
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x183FC94", Offset = "0x183FC94", VA = "0x183FC94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x183FC8C", Offset = "0x183FC8C", VA = "0x183FC8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700013A")]
		public float PressureMinDistance
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x183FCA4", Offset = "0x183FCA4", VA = "0x183FCA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x183FC9C", Offset = "0x183FC9C", VA = "0x183FC9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public float PressureMaxDistance
		{
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x183FCB4", Offset = "0x183FCB4", VA = "0x183FCB4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x183FCAC", Offset = "0x183FCAC", VA = "0x183FCAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public P3dHitCache HitCache
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x183FCBC", Offset = "0x183FCBC", VA = "0x183FCBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x183FCC4", Offset = "0x183FCC4", VA = "0x183FCC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD586AC", Offset = "0xD586AC")]
		public void ClearHitCache()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x183FCDC", Offset = "0x183FCDC", VA = "0x183FCDC", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x183FD34", Offset = "0x183FD34", VA = "0x183FD34", Slot = "5")]
		protected virtual void OnParticleCollision(GameObject hitGameObject)
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x18402F4", Offset = "0x18402F4", VA = "0x18402F4")]
		public P3dHitParticles()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD52CE4", Offset = "0xD52CE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD52CE4", Offset = "0xD52CE4")]
	public class P3dHitScreen : P3dConnectablePoints
	{
		[Token(Token = "0x20001D7")]
		private class Link
		{
			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public P3dInputManager.Finger Finger;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float Distance;

			[Token(Token = "0x6000CD1")]
			[Address(RVA = "0x1841394", Offset = "0x1841394", VA = "0x1841394")]
			public Link()
			{
			}
		}

		[Token(Token = "0x20001D8")]
		public enum OrientationType
		{
			[Token(Token = "0x4000897")]
			WorldUp,
			[Token(Token = "0x4000898")]
			CameraUp
		}

		[Token(Token = "0x20001D9")]
		public enum NormalType
		{
			[Token(Token = "0x400089A")]
			HitNormal,
			[Token(Token = "0x400089B")]
			RayDirection,
			[Token(Token = "0x400089C")]
			CameraDirection
		}

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Camera _camera;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float spacing;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private LayerMask layers;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private KeyCode key;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private OrientationType orientation;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private NormalType normal;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float offset;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float touchOffset;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool showPreview;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int priority;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private bool storeStates;

		[NonSerialized]
		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<Link> links;

		[NonSerialized]
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private P3dInputManager inputManager;

		[Token(Token = "0x1700013D")]
		public Camera Camera
		{
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x18403DC", Offset = "0x18403DC", VA = "0x18403DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x18403D4", Offset = "0x18403D4", VA = "0x18403D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public float Spacing
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x18403EC", Offset = "0x18403EC", VA = "0x18403EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x18403E4", Offset = "0x18403E4", VA = "0x18403E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		public LayerMask Layers
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x18403FC", Offset = "0x18403FC", VA = "0x18403FC")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x18403F4", Offset = "0x18403F4", VA = "0x18403F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public KeyCode Key
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x184040C", Offset = "0x184040C", VA = "0x184040C")]
			get
			{
				return default(KeyCode);
			}
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x1840404", Offset = "0x1840404", VA = "0x1840404")]
			set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public OrientationType Orientation
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x184041C", Offset = "0x184041C", VA = "0x184041C")]
			get
			{
				return default(OrientationType);
			}
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x1840414", Offset = "0x1840414", VA = "0x1840414")]
			set
			{
			}
		}

		[Token(Token = "0x17000142")]
		public NormalType Normal
		{
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x184042C", Offset = "0x184042C", VA = "0x184042C")]
			get
			{
				return default(NormalType);
			}
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x1840424", Offset = "0x1840424", VA = "0x1840424")]
			set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public float Offset
		{
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x184043C", Offset = "0x184043C", VA = "0x184043C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000808")]
			[Address(RVA = "0x1840434", Offset = "0x1840434", VA = "0x1840434")]
			set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public float TouchOffset
		{
			[Token(Token = "0x600080B")]
			[Address(RVA = "0x184044C", Offset = "0x184044C", VA = "0x184044C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600080A")]
			[Address(RVA = "0x1840444", Offset = "0x1840444", VA = "0x1840444")]
			set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public bool ShowPreview
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x1840460", Offset = "0x1840460", VA = "0x1840460")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600080C")]
			[Address(RVA = "0x1840454", Offset = "0x1840454", VA = "0x1840454")]
			set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public int Priority
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x1840470", Offset = "0x1840470", VA = "0x1840470")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x1840468", Offset = "0x1840468", VA = "0x1840468")]
			set
			{
			}
		}

		[Token(Token = "0x17000147")]
		public bool StoreStates
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x1840484", Offset = "0x1840484", VA = "0x1840484")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x1840478", Offset = "0x1840478", VA = "0x1840478")]
			set
			{
			}
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x184048C", Offset = "0x184048C", VA = "0x184048C")]
		protected void LateUpdate()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1840F4C", Offset = "0x1840F4C", VA = "0x1840F4C")]
		private void Paint(P3dInputManager.Finger finger, bool down, bool up)
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1840A20", Offset = "0x1840A20", VA = "0x1840A20")]
		private void PaintAt(Vector2 screenPosition, bool preview, float pressure, object owner)
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x184127C", Offset = "0x184127C", VA = "0x184127C")]
		private Link GetLink(P3dInputManager.Finger finger)
		{
			return null;
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x184139C", Offset = "0x184139C", VA = "0x184139C")]
		public P3dHitScreen()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD52D44", Offset = "0xD52D44")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD52D44", Offset = "0xD52D44")]
	public class P3dHitThrough : P3dConnectableLines
	{
		[Token(Token = "0x20001DA")]
		public enum PhaseType
		{
			[Token(Token = "0x400089E")]
			Update,
			[Token(Token = "0x400089F")]
			FixedUpdate
		}

		[Token(Token = "0x20001DB")]
		public enum OrientationType
		{
			[Token(Token = "0x40008A1")]
			WorldUp,
			[Token(Token = "0x40008A2")]
			CameraUp
		}

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PhaseType paintIn;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD55A5C", Offset = "0xD55A5C")]
		[SerializeField]
		private float interval;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform pointA;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform pointB;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private OrientationType orientation;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Camera _camera;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD55AE8", Offset = "0xD55AE8")]
		[SerializeField]
		private float pressure;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private bool preview;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int priority;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private LineRenderer line;

		[NonSerialized]
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float current;

		[Token(Token = "0x17000148")]
		public PhaseType PaintIn
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x18414F8", Offset = "0x18414F8", VA = "0x18414F8")]
			get
			{
				return default(PhaseType);
			}
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x18414F0", Offset = "0x18414F0", VA = "0x18414F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000149")]
		public float Interval
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x1841508", Offset = "0x1841508", VA = "0x1841508")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x1841500", Offset = "0x1841500", VA = "0x1841500")]
			set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public Transform PointA
		{
			[Token(Token = "0x600081C")]
			[Address(RVA = "0x1841518", Offset = "0x1841518", VA = "0x1841518")]
			get
			{
				return null;
			}
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x1841510", Offset = "0x1841510", VA = "0x1841510")]
			set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public Transform PointB
		{
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x1841528", Offset = "0x1841528", VA = "0x1841528")]
			get
			{
				return null;
			}
			[Token(Token = "0x600081D")]
			[Address(RVA = "0x1841520", Offset = "0x1841520", VA = "0x1841520")]
			set
			{
			}
		}

		[Token(Token = "0x1700014C")]
		public OrientationType Orientation
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x1841538", Offset = "0x1841538", VA = "0x1841538")]
			get
			{
				return default(OrientationType);
			}
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x1841530", Offset = "0x1841530", VA = "0x1841530")]
			set
			{
			}
		}

		[Token(Token = "0x1700014D")]
		public Camera Camera
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x1841548", Offset = "0x1841548", VA = "0x1841548")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x1841540", Offset = "0x1841540", VA = "0x1841540")]
			set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public float Pressure
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x1841558", Offset = "0x1841558", VA = "0x1841558")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000823")]
			[Address(RVA = "0x1841550", Offset = "0x1841550", VA = "0x1841550")]
			set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		public bool Preview
		{
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x184156C", Offset = "0x184156C", VA = "0x184156C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x1841560", Offset = "0x1841560", VA = "0x1841560")]
			set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public int Priority
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x184157C", Offset = "0x184157C", VA = "0x184157C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x1841574", Offset = "0x1841574", VA = "0x1841574")]
			set
			{
			}
		}

		[Token(Token = "0x17000151")]
		public LineRenderer Line
		{
			[Token(Token = "0x600082A")]
			[Address(RVA = "0x184158C", Offset = "0x184158C", VA = "0x184158C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000829")]
			[Address(RVA = "0x1841584", Offset = "0x1841584", VA = "0x1841584")]
			set
			{
			}
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x1841594", Offset = "0x1841594", VA = "0x1841594")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD586E4", Offset = "0xD586E4")]
		public void ManuallyHitNow()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x1841888", Offset = "0x1841888", VA = "0x1841888", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x1841944", Offset = "0x1841944", VA = "0x1841944", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x1841AE8", Offset = "0x1841AE8", VA = "0x1841AE8", Slot = "7")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x18418DC", Offset = "0x18418DC", VA = "0x18418DC")]
		private void UpdateHit()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x1841948", Offset = "0x1841948", VA = "0x1841948")]
		private void UpdatePointAndLine()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x1841B04", Offset = "0x1841B04", VA = "0x1841B04")]
		public P3dHitThrough()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class P3dInputManager
	{
		[Token(Token = "0x20001DC")]
		public class Finger
		{
			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int Index;

			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float Pressure;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool LastSet;

			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool Set;

			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector2 PositionA;

			[Token(Token = "0x40008A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector2 PositionB;

			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector2 PositionC;

			[Token(Token = "0x40008AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector2 PositionD;

			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<Vector2> SmoothPositions;

			[Token(Token = "0x17000269")]
			public bool Down
			{
				[Token(Token = "0x6000CD2")]
				[Address(RVA = "0x1840F0C", Offset = "0x1840F0C", VA = "0x1840F0C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700026A")]
			public bool Up
			{
				[Token(Token = "0x6000CD3")]
				[Address(RVA = "0x1840F2C", Offset = "0x1840F2C", VA = "0x1840F2C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000CD4")]
			[Address(RVA = "0x18425EC", Offset = "0x18425EC", VA = "0x18425EC")]
			public Finger()
			{
			}
		}

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<RaycastResult> tempRaycastResults;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static PointerEventData tempPointerEventData;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static EventSystem tempEventSystem;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<Finger> fingers;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Stack<Finger> pool;

		[Token(Token = "0x17000152")]
		public static float ScaleFactor
		{
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x1841364", Offset = "0x1841364", VA = "0x1841364")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000153")]
		public List<Finger> Fingers
		{
			[Token(Token = "0x6000833")]
			[Address(RVA = "0x1841B80", Offset = "0x1841B80", VA = "0x1841B80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x1841B88", Offset = "0x1841B88", VA = "0x1841B88")]
		public Vector2 GetAverageDeltaScaled()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x1840994", Offset = "0x1840994", VA = "0x1840994")]
		public static bool PointOverGui(Vector2 screenPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x1841D5C", Offset = "0x1841D5C", VA = "0x1841D5C")]
		public static List<RaycastResult> RaycastGui(Vector2 screenPosition)
		{
			return null;
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x1841DE8", Offset = "0x1841DE8", VA = "0x1841DE8")]
		public static List<RaycastResult> RaycastGui(Vector2 screenPosition, LayerMask layerMask)
		{
			return null;
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x1840694", Offset = "0x1840694", VA = "0x1840694")]
		public void Update(KeyCode key)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x1842180", Offset = "0x1842180", VA = "0x1842180")]
		private void CreateFinger(int index, Vector2 screenPosition, float pressure)
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x1842334", Offset = "0x1842334", VA = "0x1842334")]
		private void UpdateFinger(int index, Vector2 screenPosition, float pressure, bool set)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x184265C", Offset = "0x184265C", VA = "0x184265C")]
		private static Vector2 Hermite(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x18427E4", Offset = "0x18427E4", VA = "0x18427E4")]
		private static float HermiteInterpolate(float y0, float y1, float y2, float y3, float mu, float mu2, float mu3)
		{
			return default(float);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x1841480", Offset = "0x1841480", VA = "0x1841480")]
		public P3dInputManager()
		{
		}
	}
	[Token(Token = "0x2000100")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD52DB4", Offset = "0xD52DB4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD52DB4", Offset = "0xD52DB4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD52DB4", Offset = "0xD52DB4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD52DB4", Offset = "0xD52DB4")]
	public class P3dMaterialCloner : MonoBehaviour
	{
		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int index;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool copySplatData;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[SerializeField]
		private bool activated;

		[Token(Token = "0x17000154")]
		public int Index
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x1842904", Offset = "0x1842904", VA = "0x1842904")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x18428FC", Offset = "0x18428FC", VA = "0x18428FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public bool CopySplatData
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x1842918", Offset = "0x1842918", VA = "0x1842918")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x184290C", Offset = "0x184290C", VA = "0x184290C")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public bool Activated
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x1842920", Offset = "0x1842920", VA = "0x1842920")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x1842928", Offset = "0x1842928", VA = "0x1842928")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD5871C", Offset = "0xD5871C")]
		public void ResetActivation()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x1842930", Offset = "0x1842930", VA = "0x1842930")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58754", Offset = "0xD58754")]
		public void Activate()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x1842C20", Offset = "0x1842C20", VA = "0x1842C20")]
		private void Replace(Renderer renderer, Material[] materials, Material oldMaterial, Material newMaterial)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x1842D80", Offset = "0x1842D80", VA = "0x1842D80")]
		public P3dMaterialCloner()
		{
		}
	}
	[Token(Token = "0x2000101")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD52E88", Offset = "0xD52E88")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD52E88", Offset = "0xD52E88")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD52E88", Offset = "0xD52E88")]
	public class P3dModel : P3dLinkedBehaviour<P3dModel>
	{
		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected P3dPaintable paintable;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool includeScale;

		[NonSerialized]
		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Renderer cachedRenderer;

		[NonSerialized]
		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool cachedRendererSet;

		[NonSerialized]
		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SkinnedMeshRenderer cachedSkinned;

		[NonSerialized]
		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MeshFilter cachedFilter;

		[NonSerialized]
		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool cachedSkinnedSet;

		[NonSerialized]
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform cachedTransform;

		[NonSerialized]
		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject cachedGameObject;

		[NonSerialized]
		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material[] materials;

		[NonSerialized]
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool materialsSet;

		[NonSerialized]
		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Mesh bakedMesh;

		[NonSerialized]
		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool bakedMeshSet;

		[NonSerialized]
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		protected bool prepared;

		[NonSerialized]
		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Mesh preparedMesh;

		[NonSerialized]
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Matrix4x4 preparedMatrix;

		[NonSerialized]
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int[] preparedTriangles;

		[NonSerialized]
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3[] preparedPositions;

		[NonSerialized]
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector2[] preparedCoord0;

		[NonSerialized]
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector2[] preparedCoord1;

		[NonSerialized]
		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<P3dModel> tempModels;

		[Token(Token = "0x17000157")]
		public virtual P3dPaintable Paintable
		{
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x1842D90", Offset = "0x1842D90", VA = "0x1842D90", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x1842D88", Offset = "0x1842D88", VA = "0x1842D88", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public virtual bool IncludeScale
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x1842DA4", Offset = "0x1842DA4", VA = "0x1842DA4", Slot = "9")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x1842D98", Offset = "0x1842D98", VA = "0x1842D98", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public bool Prepared
		{
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x1842DB8", Offset = "0x1842DB8", VA = "0x1842DB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x1842DAC", Offset = "0x1842DAC", VA = "0x1842DAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public GameObject CachedGameObject
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x1842DC0", Offset = "0x1842DC0", VA = "0x1842DC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015B")]
		public Renderer CachedRenderer
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x1842DC8", Offset = "0x1842DC8", VA = "0x1842DC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015C")]
		public Material[] Materials
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x1842EB8", Offset = "0x1842EB8", VA = "0x1842EB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x1842DF8", Offset = "0x1842DF8", VA = "0x1842DF8")]
		private void CacheRenderer()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x1842F14", Offset = "0x1842F14", VA = "0x1842F14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD5878C", Offset = "0xD5878C")]
		public void DirtyMaterials()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x1842F1C", Offset = "0x1842F1C", VA = "0x1842F1C")]
		public static List<P3dModel> FindOverlap(Vector3 position, float radius, int layerMask)
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x18433A4", Offset = "0x18433A4", VA = "0x18433A4")]
		public void GetPreparedPoints(int triangleIndex, ref Vector3 pointA, ref Vector3 pointB, ref Vector3 pointC)
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x1843570", Offset = "0x1843570", VA = "0x1843570")]
		public void GetPreparedCoords0(int triangleIndex, ref Vector2 coordA, ref Vector2 coordB, ref Vector2 coordC)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x1843718", Offset = "0x1843718", VA = "0x1843718")]
		public void GetPreparedCoords1(int triangleIndex, ref Vector2 coordA, ref Vector2 coordB, ref Vector2 coordC)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x18438C0", Offset = "0x18438C0", VA = "0x18438C0")]
		public void GetPrepared(ref Mesh mesh, ref Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x1843BB8", Offset = "0x1843BB8", VA = "0x1843BB8", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x1843C2C", Offset = "0x1843C2C", VA = "0x1843C2C", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x1843CA0", Offset = "0x1843CA0", VA = "0x1843CA0")]
		public P3dModel()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD52F44", Offset = "0xD52F44")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD52F44", Offset = "0xD52F44")]
	public class P3dPaintDecal : MonoBehaviour, IHit, IHitPoint, IHitLine, IHitQuad, IHitRaycast
	{
		[Token(Token = "0x20001DD")]
		public enum PaintType
		{
			[Token(Token = "0x40008AD")]
			In3D,
			[Token(Token = "0x40008AE")]
			OnUV
		}

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayerMask layers;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private P3dModel targetModel;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private P3dGroup group;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private P3dPaintableTexture targetTexture;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PaintType paint;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private P3dBlendMode blendMode;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Texture texture;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Texture shape;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private P3dChannel shapeChannel;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD55C48", Offset = "0xD55C48")]
		[SerializeField]
		private float opacity;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD55C88", Offset = "0xD55C88")]
		[SerializeField]
		private float angle;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private Vector3 scale;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float radius;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float hardness;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD55D00", Offset = "0xD55D00")]
		private float wrapping;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD55D40", Offset = "0xD55D40")]
		[SerializeField]
		private float normalFront;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD55D80", Offset = "0xD55D80")]
		[SerializeField]
		private float normalBack;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD55DC0", Offset = "0xD55DC0")]
		[SerializeField]
		private float normalFade;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Texture tileTexture;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform tileTransform;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD55E24", Offset = "0xD55E24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD55E24", Offset = "0xD55E24")]
		[SerializeField]
		private float tileOpacity;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private P3dModifierList modifiers;

		[Token(Token = "0x1700015D")]
		public LayerMask Layers
		{
			[Token(Token = "0x600085D")]
			[Address(RVA = "0x1846204", Offset = "0x1846204", VA = "0x1846204")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x600085C")]
			[Address(RVA = "0x18461FC", Offset = "0x18461FC", VA = "0x18461FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700015E")]
		public P3dModel TargetModel
		{
			[Token(Token = "0x600085F")]
			[Address(RVA = "0x1846214", Offset = "0x1846214", VA = "0x1846214")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085E")]
			[Address(RVA = "0x184620C", Offset = "0x184620C", VA = "0x184620C")]
			set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		public P3dGroup Group
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x1846224", Offset = "0x1846224", VA = "0x1846224")]
			get
			{
				return default(P3dGroup);
			}
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x184621C", Offset = "0x184621C", VA = "0x184621C")]
			set
			{
			}
		}

		[Token(Token = "0x17000160")]
		public P3dPaintableTexture TargetTexture
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x1846234", Offset = "0x1846234", VA = "0x1846234")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x184622C", Offset = "0x184622C", VA = "0x184622C")]
			set
			{
			}
		}

		[Token(Token = "0x17000161")]
		public PaintType Paint
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x1846244", Offset = "0x1846244", VA = "0x1846244")]
			get
			{
				return default(PaintType);
			}
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x184623C", Offset = "0x184623C", VA = "0x184623C")]
			set
			{
			}
		}

		[Token(Token = "0x17000162")]
		public P3dBlendMode BlendMode
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x1846258", Offset = "0x1846258", VA = "0x1846258")]
			get
			{
				return default(P3dBlendMode);
			}
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x184624C", Offset = "0x184624C", VA = "0x184624C")]
			set
			{
			}
		}

		[Token(Token = "0x17000163")]
		public Texture Texture
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x184626C", Offset = "0x184626C", VA = "0x184626C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x1846264", Offset = "0x1846264", VA = "0x1846264")]
			set
			{
			}
		}

		[Token(Token = "0x17000164")]
		public Texture Shape
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0x184627C", Offset = "0x184627C", VA = "0x184627C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x1846274", Offset = "0x1846274", VA = "0x1846274")]
			set
			{
			}
		}

		[Token(Token = "0x17000165")]
		public P3dChannel ShapeChannel
		{
			[Token(Token = "0x600086D")]
			[Address(RVA = "0x184628C", Offset = "0x184628C", VA = "0x184628C")]
			get
			{
				return default(P3dChannel);
			}
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x1846284", Offset = "0x1846284", VA = "0x1846284")]
			set
			{
			}
		}

		[Token(Token = "0x17000166")]
		public Color Color
		{
			[Token(Token = "0x600086F")]
			[Address(RVA = "0x18462A0", Offset = "0x18462A0", VA = "0x18462A0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x1846294", Offset = "0x1846294", VA = "0x1846294")]
			set
			{
			}
		}

		[Token(Token = "0x17000167")]
		public float Opacity
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x18462B4", Offset = "0x18462B4", VA = "0x18462B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x18462AC", Offset = "0x18462AC", VA = "0x18462AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000168")]
		public float Angle
		{
			[Token(Token = "0x6000873")]
			[Address(RVA = "0x18462C4", Offset = "0x18462C4", VA = "0x18462C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000872")]
			[Address(RVA = "0x18462BC", Offset = "0x18462BC", VA = "0x18462BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000169")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000875")]
			[Address(RVA = "0x18462D8", Offset = "0x18462D8", VA = "0x18462D8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000874")]
			[Address(RVA = "0x18462CC", Offset = "0x18462CC", VA = "0x18462CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700016A")]
		public float Radius
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x18462EC", Offset = "0x18462EC", VA = "0x18462EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000876")]
			[Address(RVA = "0x18462E4", Offset = "0x18462E4", VA = "0x18462E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700016B")]
		public float Hardness
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x18462FC", Offset = "0x18462FC", VA = "0x18462FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000878")]
			[Address(RVA = "0x18462F4", Offset = "0x18462F4", VA = "0x18462F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700016C")]
		public float Wrapping
		{
			[Token(Token = "0x600087B")]
			[Address(RVA = "0x184630C", Offset = "0x184630C", VA = "0x184630C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x1846304", Offset = "0x1846304", VA = "0x1846304")]
			set
			{
			}
		}

		[Token(Token = "0x1700016D")]
		public float NormalFront
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0x184631C", Offset = "0x184631C", VA = "0x184631C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600087C")]
			[Address(RVA = "0x1846314", Offset = "0x1846314", VA = "0x1846314")]
			set
			{
			}
		}

		[Token(Token = "0x1700016E")]
		public float NormalBack
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0x184632C", Offset = "0x184632C", VA = "0x184632C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600087E")]
			[Address(RVA = "0x1846324", Offset = "0x1846324", VA = "0x1846324")]
			set
			{
			}
		}

		[Token(Token = "0x1700016F")]
		public float NormalFade
		{
			[Token(Token = "0x6000881")]
			[Address(RVA = "0x184633C", Offset = "0x184633C", VA = "0x184633C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000880")]
			[Address(RVA = "0x1846334", Offset = "0x1846334", VA = "0x1846334")]
			set
			{
			}
		}

		[Token(Token = "0x17000170")]
		public Texture TileTexture
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0x184634C", Offset = "0x184634C", VA = "0x184634C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x1846344", Offset = "0x1846344", VA = "0x1846344")]
			set
			{
			}
		}

		[Token(Token = "0x17000171")]
		public Transform TileTransform
		{
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x184635C", Offset = "0x184635C", VA = "0x184635C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000884")]
			[Address(RVA = "0x1846354", Offset = "0x1846354", VA = "0x1846354")]
			set
			{
			}
		}

		[Token(Token = "0x17000172")]
		public float TileOpacity
		{
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x184636C", Offset = "0x184636C", VA = "0x184636C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000886")]
			[Address(RVA = "0x1846364", Offset = "0x1846364", VA = "0x1846364")]
			set
			{
			}
		}

		[Token(Token = "0x17000173")]
		public P3dModifierList Modifiers
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x1846374", Offset = "0x1846374", VA = "0x1846374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x18463E0", Offset = "0x18463E0", VA = "0x18463E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD587C4", Offset = "0xD587C4")]
		public void FlipHorizontal()
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x18463F0", Offset = "0x18463F0", VA = "0x18463F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD587FC", Offset = "0xD587FC")]
		public void FlipVertical()
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x1846400", Offset = "0x1846400", VA = "0x1846400")]
		public void IncrementOpacity(float delta)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x1846480", Offset = "0x1846480", VA = "0x1846480")]
		public void IncrementAngle(float degrees)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x1846520", Offset = "0x1846520", VA = "0x1846520")]
		public void MultiplyScale(float multiplier)
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x18465BC", Offset = "0x18465BC", VA = "0x18465BC")]
		public void MultiplyHardness(float multiplier)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x18465CC", Offset = "0x18465CC", VA = "0x18465CC", Slot = "4")]
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x1846E00", Offset = "0x1846E00", VA = "0x1846E00", Slot = "5")]
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x1847054", Offset = "0x1847054", VA = "0x1847054", Slot = "6")]
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x1847304", Offset = "0x1847304", VA = "0x1847304", Slot = "7")]
		public void HandleHitRaycast(bool preview, int priority, float pressure, int seed, RaycastHit hit, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x1846814", Offset = "0x1846814", VA = "0x1846814")]
		private Vector3 HandleHitCommon(bool preview, float pressure, int seed, Quaternion rotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x18478D8", Offset = "0x18478D8", VA = "0x18478D8")]
		public P3dPaintDecal()
		{
		}
	}
	[Token(Token = "0x2000103")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD52FA4", Offset = "0xD52FA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD52FA4", Offset = "0xD52FA4")]
	public class P3dPaintFill : MonoBehaviour, IHit, IHitRaycast
	{
		[Token(Token = "0x20001DE")]
		public enum RotationType
		{
			[Token(Token = "0x40008B0")]
			World,
			[Token(Token = "0x40008B1")]
			Normal
		}

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private P3dGroup group;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private P3dBlendMode blendMode;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Texture texture;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD55ED8", Offset = "0xD55ED8")]
		[SerializeField]
		private float opacity;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD55F18", Offset = "0xD55F18")]
		[SerializeField]
		private float minimum;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private P3dModifierList modifiers;

		[Token(Token = "0x17000174")]
		public P3dGroup Group
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x18479E4", Offset = "0x18479E4", VA = "0x18479E4")]
			get
			{
				return default(P3dGroup);
			}
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x18479DC", Offset = "0x18479DC", VA = "0x18479DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000175")]
		public P3dBlendMode BlendMode
		{
			[Token(Token = "0x6000898")]
			[Address(RVA = "0x18479F8", Offset = "0x18479F8", VA = "0x18479F8")]
			get
			{
				return default(P3dBlendMode);
			}
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x18479EC", Offset = "0x18479EC", VA = "0x18479EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000176")]
		public Texture Texture
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0x1847A0C", Offset = "0x1847A0C", VA = "0x1847A0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000899")]
			[Address(RVA = "0x1847A04", Offset = "0x1847A04", VA = "0x1847A04")]
			set
			{
			}
		}

		[Token(Token = "0x17000177")]
		public Color Color
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x1847A20", Offset = "0x1847A20", VA = "0x1847A20")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x1847A14", Offset = "0x1847A14", VA = "0x1847A14")]
			set
			{
			}
		}

		[Token(Token = "0x17000178")]
		public float Opacity
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x1847A34", Offset = "0x1847A34", VA = "0x1847A34")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x1847A2C", Offset = "0x1847A2C", VA = "0x1847A2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000179")]
		public float Minimum
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x1847A44", Offset = "0x1847A44", VA = "0x1847A44")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089F")]
			[Address(RVA = "0x1847A3C", Offset = "0x1847A3C", VA = "0x1847A3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700017A")]
		public P3dModifierList Modifiers
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x1847A4C", Offset = "0x1847A4C", VA = "0x1847A4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x1847AB8", Offset = "0x1847AB8", VA = "0x1847AB8")]
		public void IncrementOpacity(float delta)
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x1847B38", Offset = "0x1847B38", VA = "0x1847B38", Slot = "4")]
		public void HandleHitRaycast(bool preview, int priority, float pressure, int seed, RaycastHit hit, Quaternion rotation)
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x1847E28", Offset = "0x1847E28", VA = "0x1847E28")]
		public P3dPaintFill()
		{
		}
	}
	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD53004", Offset = "0xD53004")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD53004", Offset = "0xD53004")]
	public class P3dPaintReplace : MonoBehaviour, IHit, IHitRaycast
	{
		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private P3dGroup group;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture texture;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private P3dModifierList modifiers;

		[Token(Token = "0x1700017B")]
		public P3dGroup Group
		{
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x1848458", Offset = "0x1848458", VA = "0x1848458")]
			get
			{
				return default(P3dGroup);
			}
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x1848450", Offset = "0x1848450", VA = "0x1848450")]
			set
			{
			}
		}

		[Token(Token = "0x1700017C")]
		public Texture Texture
		{
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x1848468", Offset = "0x1848468", VA = "0x1848468")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x1848460", Offset = "0x1848460", VA = "0x1848460")]
			set
			{
			}
		}

		[Token(Token = "0x1700017D")]
		public Color Color
		{
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x184847C", Offset = "0x184847C", VA = "0x184847C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x1848470", Offset = "0x1848470", VA = "0x1848470")]
			set
			{
			}
		}

		[Token(Token = "0x1700017E")]
		public P3dModifierList Modifiers
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x1848488", Offset = "0x1848488", VA = "0x1848488")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x18484F4", Offset = "0x18484F4", VA = "0x18484F4", Slot = "4")]
		public void HandleHitRaycast(bool preview, int priority, float pressure, int seed, RaycastHit hit, Quaternion rotation)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x18487A8", Offset = "0x18487A8", VA = "0x18487A8")]
		public P3dPaintReplace()
		{
		}
	}
	[Token(Token = "0x2000105")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD53064", Offset = "0xD53064")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD53064", Offset = "0xD53064")]
	public class P3dPaintReplaceChannels : MonoBehaviour, IHit, IHitRaycast
	{
		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private P3dGroup group;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture textureR;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Texture textureG;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Texture textureB;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Texture textureA;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector4 channelR;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector4 channelG;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector4 channelB;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector4 channelA;

		[Token(Token = "0x1700017F")]
		public P3dGroup Group
		{
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x18487E4", Offset = "0x18487E4", VA = "0x18487E4")]
			get
			{
				return default(P3dGroup);
			}
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x18487DC", Offset = "0x18487DC", VA = "0x18487DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000180")]
		public Texture TextureR
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x18487F4", Offset = "0x18487F4", VA = "0x18487F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x18487EC", Offset = "0x18487EC", VA = "0x18487EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000181")]
		public Texture TextureG
		{
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x1848804", Offset = "0x1848804", VA = "0x1848804")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x18487FC", Offset = "0x18487FC", VA = "0x18487FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000182")]
		public Texture TextureB
		{
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x1848814", Offset = "0x1848814", VA = "0x1848814")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x184880C", Offset = "0x184880C", VA = "0x184880C")]
			set
			{
			}
		}

		[Token(Token = "0x17000183")]
		public Texture TextureA
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x1848824", Offset = "0x1848824", VA = "0x1848824")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x184881C", Offset = "0x184881C", VA = "0x184881C")]
			set
			{
			}
		}

		[Token(Token = "0x17000184")]
		public Vector4 ChannelR
		{
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x1848838", Offset = "0x1848838", VA = "0x1848838")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x184882C", Offset = "0x184882C", VA = "0x184882C")]
			set
			{
			}
		}

		[Token(Token = "0x17000185")]
		public Vector4 ChannelG
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x1848850", Offset = "0x1848850", VA = "0x1848850")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x1848844", Offset = "0x1848844", VA = "0x1848844")]
			set
			{
			}
		}

		[Token(Token = "0x17000186")]
		public Vector4 ChannelB
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x1848868", Offset = "0x1848868", VA = "0x1848868")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x184885C", Offset = "0x184885C", VA = "0x184885C")]
			set
			{
			}
		}

		[Token(Token = "0x17000187")]
		public Vector4 ChannelA
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x1848880", Offset = "0x1848880", VA = "0x1848880")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x1848874", Offset = "0x1848874", VA = "0x1848874")]
			set
			{
			}
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x184888C", Offset = "0x184888C", VA = "0x184888C", Slot = "4")]
		public void HandleHitRaycast(bool preview, int priority, float pressure, int seed, RaycastHit hit, Quaternion rotation)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x1848A9C", Offset = "0x1848A9C", VA = "0x1848A9C")]
		public P3dPaintReplaceChannels()
		{
		}
	}
	[Token(Token = "0x2000106")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD530C4", Offset = "0xD530C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD530C4", Offset = "0xD530C4")]
	public class P3dPaintSphere : MonoBehaviour, IHit, IHitPoint, IHitLine, IHitQuad, IHitRaycast
	{
		[Token(Token = "0x20001DF")]
		public enum RotationType
		{
			[Token(Token = "0x40008B3")]
			World,
			[Token(Token = "0x40008B4")]
			Normal
		}

		[Token(Token = "0x20001E0")]
		public enum PaintType
		{
			[Token(Token = "0x40008B6")]
			In3D,
			[Token(Token = "0x40008B7")]
			OnUV
		}

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayerMask layers;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private P3dGroup group;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private P3dModel targetModel;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private P3dPaintableTexture targetTexture;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PaintType paint;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private P3dBlendMode blendMode;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD560A8", Offset = "0xD560A8")]
		[SerializeField]
		private float opacity;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD560E8", Offset = "0xD560E8")]
		[SerializeField]
		private float angle;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector3 scale;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private RotationType rotateTo;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float radius;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float hardness;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Texture tileTexture;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform tileTransform;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD56190", Offset = "0xD56190")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD56190", Offset = "0xD56190")]
		[SerializeField]
		private float tileOpacity;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private P3dModifierList modifiers;

		[Token(Token = "0x17000188")]
		public LayerMask Layers
		{
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x1848B80", Offset = "0x1848B80", VA = "0x1848B80")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x1848B78", Offset = "0x1848B78", VA = "0x1848B78")]
			set
			{
			}
		}

		[Token(Token = "0x17000189")]
		public P3dGroup Group
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x1848B90", Offset = "0x1848B90", VA = "0x1848B90")]
			get
			{
				return default(P3dGroup);
			}
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x1848B88", Offset = "0x1848B88", VA = "0x1848B88")]
			set
			{
			}
		}

		[Token(Token = "0x1700018A")]
		public P3dModel TargetModel
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x1848BA0", Offset = "0x1848BA0", VA = "0x1848BA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x1848B98", Offset = "0x1848B98", VA = "0x1848B98")]
			set
			{
			}
		}

		[Token(Token = "0x1700018B")]
		public P3dPaintableTexture TargetTexture
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x1848BB0", Offset = "0x1848BB0", VA = "0x1848BB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x1848BA8", Offset = "0x1848BA8", VA = "0x1848BA8")]
			set
			{
			}
		}

		[Token(Token = "0x1700018C")]
		public PaintType Paint
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x1848BC0", Offset = "0x1848BC0", VA = "0x1848BC0")]
			get
			{
				return default(PaintType);
			}
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x1848BB8", Offset = "0x1848BB8", VA = "0x1848BB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public P3dBlendMode BlendMode
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x1848BD8", Offset = "0x1848BD8", VA = "0x1848BD8")]
			get
			{
				return default(P3dBlendMode);
			}
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x1848BC8", Offset = "0x1848BC8", VA = "0x1848BC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700018E")]
		public Color Color
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x1848BF4", Offset = "0x1848BF4", VA = "0x1848BF4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x1848BE8", Offset = "0x1848BE8", VA = "0x1848BE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700018F")]
		public float Opacity
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x1848C08", Offset = "0x1848C08", VA = "0x1848C08")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x1848C00", Offset = "0x1848C00", VA = "0x1848C00")]
			set
			{
			}
		}

		[Token(Token = "0x17000190")]
		public float Angle
		{
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x1848C18", Offset = "0x1848C18", VA = "0x1848C18")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x1848C10", Offset = "0x1848C10", VA = "0x1848C10")]
			set
			{
			}
		}

		[Token(Token = "0x17000191")]
		public Vector3 Scale
		{
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x1848C2C", Offset = "0x1848C2C", VA = "0x1848C2C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x1848C20", Offset = "0x1848C20", VA = "0x1848C20")]
			set
			{
			}
		}

		[Token(Token = "0x17000192")]
		public RotationType RotateTo
		{
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x1848C40", Offset = "0x1848C40", VA = "0x1848C40")]
			get
			{
				return default(RotationType);
			}
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x1848C38", Offset = "0x1848C38", VA = "0x1848C38")]
			set
			{
			}
		}

		[Token(Token = "0x17000193")]
		public float Radius
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x1848C50", Offset = "0x1848C50", VA = "0x1848C50")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x1848C48", Offset = "0x1848C48", VA = "0x1848C48")]
			set
			{
			}
		}

		[Token(Token = "0x17000194")]
		public float Hardness
		{
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x1848C60", Offset = "0x1848C60", VA = "0x1848C60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x1848C58", Offset = "0x1848C58", VA = "0x1848C58")]
			set
			{
			}
		}

		[Token(Token = "0x17000195")]
		public Texture TileTexture
		{
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x1848C70", Offset = "0x1848C70", VA = "0x1848C70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x1848C68", Offset = "0x1848C68", VA = "0x1848C68")]
			set
			{
			}
		}

		[Token(Token = "0x17000196")]
		public Transform TileTransform
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x1848C80", Offset = "0x1848C80", VA = "0x1848C80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x1848C78", Offset = "0x1848C78", VA = "0x1848C78")]
			set
			{
			}
		}

		[Token(Token = "0x17000197")]
		public float TileOpacity
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x1848C90", Offset = "0x1848C90", VA = "0x1848C90")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x1848C88", Offset = "0x1848C88", VA = "0x1848C88")]
			set
			{
			}
		}

		[Token(Token = "0x17000198")]
		public P3dModifierList Modifiers
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x1848C98", Offset = "0x1848C98", VA = "0x1848C98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x1848D04", Offset = "0x1848D04", VA = "0x1848D04")]
		public void IncrementOpacity(float delta)
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x1848D84", Offset = "0x1848D84", VA = "0x1848D84")]
		public void IncrementAngle(float degrees)
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x1848E24", Offset = "0x1848E24", VA = "0x1848E24")]
		public void MultiplyRadius(float multiplier)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x1848E34", Offset = "0x1848E34", VA = "0x1848E34")]
		public void MultiplyScale(float multiplier)
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x1848ED0", Offset = "0x1848ED0", VA = "0x1848ED0", Slot = "4")]
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x18494F4", Offset = "0x18494F4", VA = "0x18494F4", Slot = "5")]
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation)
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x1849744", Offset = "0x1849744", VA = "0x1849744", Slot = "6")]
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation)
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x18499F0", Offset = "0x18499F0", VA = "0x18499F0", Slot = "7")]
		public void HandleHitRaycast(bool preview, int priority, float pressure, int seed, RaycastHit hit, Quaternion rotation)
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x1849114", Offset = "0x1849114", VA = "0x1849114")]
		private Vector3 HandleHitCommon(bool preview, float pressure, int seed, Quaternion rotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x1849D68", Offset = "0x1849D68", VA = "0x1849D68")]
		public P3dPaintSphere()
		{
		}
	}
	[Token(Token = "0x2000107")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD53124", Offset = "0xD53124")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD53124", Offset = "0xD53124")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD53124", Offset = "0xD53124")]
	public class P3dPaintable : P3dModel
	{
		[Token(Token = "0x20001E1")]
		public enum ActivationType
		{
			[Token(Token = "0x40008B9")]
			Awake,
			[Token(Token = "0x40008BA")]
			OnEnable,
			[Token(Token = "0x40008BB")]
			Start,
			[Token(Token = "0x40008BC")]
			OnFirstUse
		}

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private ActivationType activation;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private Vector3 baseScale;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private List<Renderer> otherRenderers;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private bool activated;

		[NonSerialized]
		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<P3dPaintableTexture> paintableTextures;

		[NonSerialized]
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<P3dMaterialCloner> tempMaterialCloners;

		[Token(Token = "0x17000199")]
		public override P3dPaintable Paintable
		{
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x1849E60", Offset = "0x1849E60", VA = "0x1849E60", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x1849E5C", Offset = "0x1849E5C", VA = "0x1849E5C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700019A")]
		public ActivationType Activation
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x1849E70", Offset = "0x1849E70", VA = "0x1849E70")]
			get
			{
				return default(ActivationType);
			}
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x1849E68", Offset = "0x1849E68", VA = "0x1849E68")]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public Vector3 BaseScale
		{
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x1849E84", Offset = "0x1849E84", VA = "0x1849E84")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x1849E78", Offset = "0x1849E78", VA = "0x1849E78")]
			set
			{
			}
		}

		[Token(Token = "0x1700019C")]
		public List<Renderer> OtherRenderers
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x1849E98", Offset = "0x1849E98", VA = "0x1849E98")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x1849E90", Offset = "0x1849E90", VA = "0x1849E90")]
			set
			{
			}
		}

		[Token(Token = "0x1700019D")]
		public bool Activated
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x1849EA0", Offset = "0x1849EA0", VA = "0x1849EA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700019E")]
		public List<P3dPaintableTexture> PaintableTextures
		{
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x1849EA8", Offset = "0x1849EA8", VA = "0x1849EA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x1849EB0", Offset = "0x1849EB0", VA = "0x1849EB0")]
		public void ScaleSize(ref int width, ref int height)
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x184321C", Offset = "0x184321C", VA = "0x184321C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58834", Offset = "0xD58834")]
		public void Activate()
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x184A2F8", Offset = "0x184A2F8", VA = "0x184A2F8")]
		public void ClearAll(Color color)
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x184A300", Offset = "0x184A300", VA = "0x184A300")]
		public void ClearAll(Texture texture, Color color)
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x184A4B4", Offset = "0x184A4B4", VA = "0x184A4B4")]
		public void Register(P3dPaintableTexture paintableTexture)
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x184A5B0", Offset = "0x184A5B0", VA = "0x184A5B0")]
		public void Unregister(P3dPaintableTexture paintableTexture)
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x184A6B0", Offset = "0x184A6B0", VA = "0x184A6B0", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x184A6C8", Offset = "0x184A6C8", VA = "0x184A6C8", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x184A808", Offset = "0x184A808", VA = "0x184A808", Slot = "12")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x184A824", Offset = "0x184A824", VA = "0x184A824")]
		public P3dPaintable()
		{
		}
	}
	[Token(Token = "0x2000108")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD531E0", Offset = "0xD531E0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD531E0", Offset = "0xD531E0")]
	public class P3dPaintableManager : P3dLinkedBehaviour<P3dPaintableManager>
	{
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x184A704", Offset = "0x184A704", VA = "0x184A704")]
		public static P3dPaintableManager GetOrCreateInstance()
		{
			return null;
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x1846C20", Offset = "0x1846C20", VA = "0x1846C20")]
		public static void SubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group, P3dModel targetModel, P3dPaintableTexture targetTexture)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x184A924", Offset = "0x184A924", VA = "0x184A924")]
		private static void DoSubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group, P3dModel targetModel, P3dPaintableTexture targetTexture)
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x184ABEC", Offset = "0x184ABEC", VA = "0x184ABEC")]
		private static void SubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group)
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x184AAA8", Offset = "0x184AAA8", VA = "0x184AAA8")]
		private static void SubmitAll(P3dCommand command, P3dModel model, P3dGroup group)
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x1847874", Offset = "0x1847874", VA = "0x1847874")]
		public static void Submit(P3dCommand command, P3dModel model, P3dPaintableTexture paintableTexture)
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x184AE04", Offset = "0x184AE04", VA = "0x184AE04", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x184AEFC", Offset = "0x184AEFC", VA = "0x184AEFC")]
		private void ClearAll()
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x184AF80", Offset = "0x184AF80", VA = "0x184AF80")]
		private void UpdateAll()
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x184B384", Offset = "0x184B384", VA = "0x184B384")]
		public P3dPaintableManager()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class P3dPaintableState
	{
		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RenderTexture Texture;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<P3dCommand> Commands;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Stack<P3dPaintableState> pool;

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x184B3D4", Offset = "0x184B3D4", VA = "0x184B3D4")]
		public static P3dPaintableState Pop()
		{
			return null;
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x184B510", Offset = "0x184B510", VA = "0x184B510")]
		public void Write(RenderTexture current)
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x184B6F4", Offset = "0x184B6F4", VA = "0x184B6F4")]
		public void Write(List<P3dCommand> commands)
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x184B5DC", Offset = "0x184B5DC", VA = "0x184B5DC")]
		private void Clear()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x184B764", Offset = "0x184B764", VA = "0x184B764")]
		public void Pool()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x184B4A0", Offset = "0x184B4A0", VA = "0x184B4A0")]
		public P3dPaintableState()
		{
		}
	}
	[Token(Token = "0x200010A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD53250", Offset = "0xD53250")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD53250", Offset = "0xD53250")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD53250", Offset = "0xD53250")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD53250", Offset = "0xD53250")]
	public class P3dPaintableTexture : P3dLinkedBehaviour<P3dPaintableTexture>
	{
		[Token(Token = "0x20001E2")]
		public enum StateType
		{
			[Token(Token = "0x40008BE")]
			None,
			[Token(Token = "0x40008BF")]
			FullTextureCopy,
			[Token(Token = "0x40008C0")]
			LocalCommandCopy
		}

		[Token(Token = "0x20001E3")]
		public enum MipType
		{
			[Token(Token = "0x40008C2")]
			Auto,
			[Token(Token = "0x40008C3")]
			ForceOn,
			[Token(Token = "0x40008C4")]
			ForceOff
		}

		[Serializable]
		[Token(Token = "0x20001E4")]
		public class PaintableTextureEvent : UnityEvent<P3dPaintableTexture>
		{
			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0x184D8B0", Offset = "0x184D8B0", VA = "0x184D8B0")]
			public PaintableTextureEvent()
			{
			}
		}

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private P3dSlot slot;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD56254", Offset = "0xD56254")]
		[SerializeField]
		private P3dCoord coord;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private P3dGroup group;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private StateType state;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int stateLimit;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string saveName;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string shaderKeyword;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RenderTextureFormat format;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private MipType mipMaps;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool keepUnpaintable;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int width;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int height;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Texture texture;

		[NonSerialized]
		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private P3dPaintable cachedPaintable;

		[NonSerialized]
		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool cachedPaintableSet;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		[SerializeField]
		private bool activated;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RenderTexture current;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RenderTexture preview;

		[NonSerialized]
		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<P3dPaintableState> paintableStates;

		[NonSerialized]
		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int stateIndex;

		[NonSerialized]
		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private P3dPaintable paintable;

		[NonSerialized]
		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool paintableSet;

		[NonSerialized]
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material material;

		[NonSerialized]
		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool materialSet;

		[NonSerialized]
		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<P3dCommand> paintCommands;

		[NonSerialized]
		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<P3dCommand> previewCommands;

		[NonSerialized]
		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<P3dCommand> localCommands;

		[NonSerialized]
		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<P3dPaintableTexture> tempPaintableTextures;

		[Token(Token = "0x1700019F")]
		public P3dSlot Slot
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x184B86C", Offset = "0x184B86C", VA = "0x184B86C")]
			get
			{
				return default(P3dSlot);
			}
			[Token(Token = "0x6000913")]
			[Address(RVA = "0x184B864", Offset = "0x184B864", VA = "0x184B864")]
			set
			{
			}
		}

		[Token(Token = "0x170001A0")]
		public P3dCoord Coord
		{
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x184B880", Offset = "0x184B880", VA = "0x184B880")]
			get
			{
				return default(P3dCoord);
			}
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x184B878", Offset = "0x184B878", VA = "0x184B878")]
			set
			{
			}
		}

		[Token(Token = "0x170001A1")]
		public P3dGroup Group
		{
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x184B890", Offset = "0x184B890", VA = "0x184B890")]
			get
			{
				return default(P3dGroup);
			}
			[Token(Token = "0x6000917")]
			[Address(RVA = "0x184B888", Offset = "0x184B888", VA = "0x184B888")]
			set
			{
			}
		}

		[Token(Token = "0x170001A2")]
		public StateType State
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x184B8A0", Offset = "0x184B8A0", VA = "0x184B8A0")]
			get
			{
				return default(StateType);
			}
			[Token(Token = "0x6000919")]
			[Address(RVA = "0x184B898", Offset = "0x184B898", VA = "0x184B898")]
			set
			{
			}
		}

		[Token(Token = "0x170001A3")]
		public int StateLimit
		{
			[Token(Token = "0x600091C")]
			[Address(RVA = "0x184B8B0", Offset = "0x184B8B0", VA = "0x184B8B0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x184B8A8", Offset = "0x184B8A8", VA = "0x184B8A8")]
			set
			{
			}
		}

		[Token(Token = "0x170001A4")]
		public string SaveName
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x184B8C0", Offset = "0x184B8C0", VA = "0x184B8C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x184B8B8", Offset = "0x184B8B8", VA = "0x184B8B8")]
			set
			{
			}
		}

		[Token(Token = "0x170001A5")]
		public string ShaderKeyword
		{
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x184B8D0", Offset = "0x184B8D0", VA = "0x184B8D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x184B8C8", Offset = "0x184B8C8", VA = "0x184B8C8")]
			set
			{
			}
		}

		[Token(Token = "0x170001A6")]
		public RenderTextureFormat Format
		{
			[Token(Token = "0x6000922")]
			[Address(RVA = "0x184B8E0", Offset = "0x184B8E0", VA = "0x184B8E0")]
			get
			{
				return default(RenderTextureFormat);
			}
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x184B8D8", Offset = "0x184B8D8", VA = "0x184B8D8")]
			set
			{
			}
		}

		[Token(Token = "0x170001A7")]
		public MipType MipMaps
		{
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x184B8F0", Offset = "0x184B8F0", VA = "0x184B8F0")]
			get
			{
				return default(MipType);
			}
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x184B8E8", Offset = "0x184B8E8", VA = "0x184B8E8")]
			set
			{
			}
		}

		[Token(Token = "0x170001A8")]
		public bool KeepUnpaintable
		{
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x184B904", Offset = "0x184B904", VA = "0x184B904")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x184B8F8", Offset = "0x184B8F8", VA = "0x184B8F8")]
			set
			{
			}
		}

		[Token(Token = "0x170001A9")]
		public int Width
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x184B914", Offset = "0x184B914", VA = "0x184B914")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000927")]
			[Address(RVA = "0x184B90C", Offset = "0x184B90C", VA = "0x184B90C")]
			set
			{
			}
		}

		[Token(Token = "0x170001AA")]
		public int Height
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x184B924", Offset = "0x184B924", VA = "0x184B924")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x184B91C", Offset = "0x184B91C", VA = "0x184B91C")]
			set
			{
			}
		}

		[Token(Token = "0x170001AB")]
		public Color Color
		{
			[Token(Token = "0x600092C")]
			[Address(RVA = "0x184B938", Offset = "0x184B938", VA = "0x184B938")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x184B92C", Offset = "0x184B92C", VA = "0x184B92C")]
			set
			{
			}
		}

		[Token(Token = "0x170001AC")]
		public Texture Texture
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x184B94C", Offset = "0x184B94C", VA = "0x184B94C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600092D")]
			[Address(RVA = "0x184B944", Offset = "0x184B944", VA = "0x184B944")]
			set
			{
			}
		}

		[Token(Token = "0x170001AD")]
		public bool Activated
		{
			[Token(Token = "0x6000933")]
			[Address(RVA = "0x184BBE4", Offset = "0x184BBE4", VA = "0x184BBE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001AE")]
		public bool CanUndo
		{
			[Token(Token = "0x6000934")]
			[Address(RVA = "0x184BBEC", Offset = "0x184BBEC", VA = "0x184BBEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001AF")]
		public bool CanRedo
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x184BC0C", Offset = "0x184BC0C", VA = "0x184BC0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001B0")]
		public List<P3dPaintableState> States
		{
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x184BC7C", Offset = "0x184BC7C", VA = "0x184BC7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B1")]
		public int StateIndex
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x184BC84", Offset = "0x184BC84", VA = "0x184BC84")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001B2")]
		public P3dPaintable CachedPaintable
		{
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x184AB7C", Offset = "0x184AB7C", VA = "0x184AB7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B3")]
		public RenderTexture Current
		{
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x184BCC4", Offset = "0x184BCC4", VA = "0x184BCC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x184BC8C", Offset = "0x184BC8C", VA = "0x184BC8C")]
			set
			{
			}
		}

		[Token(Token = "0x170001B4")]
		public RenderTexture Preview
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x184BCCC", Offset = "0x184BCCC", VA = "0x184BCCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B5")]
		public bool CommandsPending
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x184D344", Offset = "0x184D344", VA = "0x184D344")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000013")]
		public event Action<P3dCommand> OnAddCommand
		{
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x184B954", Offset = "0x184B954", VA = "0x184B954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5886C", Offset = "0xD5886C")]
			add
			{
			}
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x184B9F8", Offset = "0x184B9F8", VA = "0x184B9F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5887C", Offset = "0xD5887C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event Action<bool> OnModified
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x184BA9C", Offset = "0x184BA9C", VA = "0x184BA9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5888C", Offset = "0xD5888C")]
			add
			{
			}
			[Token(Token = "0x6000932")]
			[Address(RVA = "0x184BB40", Offset = "0x184BB40", VA = "0x184BB40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5889C", Offset = "0xD5889C")]
			remove
			{
			}
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x184767C", Offset = "0x184767C", VA = "0x184767C")]
		public static List<P3dPaintableTexture> Filter(P3dModel model, P3dGroup group)
		{
			return null;
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x184BCD4", Offset = "0x184BCD4", VA = "0x184BCD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD588AC", Offset = "0xD588AC")]
		public void ClearStates()
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x184BD80", Offset = "0x184BD80", VA = "0x184BD80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD588E4", Offset = "0xD588E4")]
		public void StoreState()
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x184C084", Offset = "0x184C084", VA = "0x184C084")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD5891C", Offset = "0xD5891C")]
		public void Undo()
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x184C5B8", Offset = "0x184C5B8", VA = "0x184C5B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58954", Offset = "0xD58954")]
		public void Redo()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x1847830", Offset = "0x1847830", VA = "0x1847830")]
		public Vector2 GetCoord(ref RaycastHit hit)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x184C31C", Offset = "0x184C31C", VA = "0x184C31C")]
		private void RebuildFromCommands()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x184BEE0", Offset = "0x184BEE0", VA = "0x184BEE0")]
		private void AddState()
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x184BE1C", Offset = "0x184BE1C", VA = "0x184BE1C")]
		private void TrimFuture()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x184BFB4", Offset = "0x184BFB4", VA = "0x184BFB4")]
		private void TrimPast()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x184C544", Offset = "0x184C544", VA = "0x184C544")]
		public void NotifyOnModified(bool preview)
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x184C6C8", Offset = "0x184C6C8", VA = "0x184C6C8")]
		public Texture2D GetReadableCopy()
		{
			return null;
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x184C73C", Offset = "0x184C73C", VA = "0x184C73C")]
		public byte[] GetPngData()
		{
			return null;
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x184C810", Offset = "0x184C810", VA = "0x184C810")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD5898C", Offset = "0xD5898C")]
		public void Clear()
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x184A3E8", Offset = "0x184A3E8", VA = "0x184A3E8")]
		public void Clear(Texture texture, Color tint)
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x184C820", Offset = "0x184C820", VA = "0x184C820")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD589C4", Offset = "0xD589C4")]
		public void Replace()
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x184C830", Offset = "0x184C830", VA = "0x184C830")]
		public void Replace(Texture texture, Color tint)
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x184C934", Offset = "0x184C934", VA = "0x184C934")]
		public bool Resize(int width, int height, bool copyContents = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x184CB14", Offset = "0x184CB14", VA = "0x184CB14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD589FC", Offset = "0xD589FC")]
		public void Save()
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x184CB1C", Offset = "0x184CB1C", VA = "0x184CB1C")]
		public void Save(string saveName)
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x184CBD0", Offset = "0x184CBD0", VA = "0x184CBD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58A34", Offset = "0xD58A34")]
		public void Load()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x184CBDC", Offset = "0x184CBDC", VA = "0x184CBDC")]
		public void Load(string saveName, bool replace = true)
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x184CC78", Offset = "0x184CC78", VA = "0x184CC78")]
		public void LoadFromData(byte[] data, bool allowResize = true)
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x184CD94", Offset = "0x184CD94", VA = "0x184CD94")]
		public void HidePreview()
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x184CE74", Offset = "0x184CE74", VA = "0x184CE74")]
		public static void HideAllPreviews()
		{
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x184CF08", Offset = "0x184CF08", VA = "0x184CF08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58A6C", Offset = "0xD58A6C")]
		public void ClearSave()
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x184CF78", Offset = "0x184CF78", VA = "0x184CF78")]
		public static void ClearSave(string saveName)
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x184CFE4", Offset = "0x184CFE4", VA = "0x184CFE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58AA4", Offset = "0xD58AA4")]
		public void UpdateMaterial()
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x184D080", Offset = "0x184D080", VA = "0x184D080")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58ADC", Offset = "0xD58ADC")]
		public void CopySize()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x184D158", Offset = "0x184D158", VA = "0x184D158")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58B14", Offset = "0xD58B14")]
		public void CopyTexture()
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x184A008", Offset = "0x184A008", VA = "0x184A008")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58B4C", Offset = "0xD58B4C")]
		public void Activate()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x184D1A0", Offset = "0x184D1A0", VA = "0x184D1A0", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x184D230", Offset = "0x184D230", VA = "0x184D230", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x184D294", Offset = "0x184D294", VA = "0x184D294", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x184ACFC", Offset = "0x184ACFC", VA = "0x184ACFC")]
		public void AddCommand(P3dCommand command)
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x184C1B0", Offset = "0x184C1B0", VA = "0x184C1B0")]
		public void ClearCommands()
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x184B018", Offset = "0x184B018", VA = "0x184B018")]
		public void ExecuteCommands(bool sendNotifications)
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x184D3AC", Offset = "0x184D3AC", VA = "0x184D3AC")]
		private void ExecuteCommands(List<P3dCommand> commands, bool sendNotifications, ref RenderTexture main, ref RenderTexture swap, ref Mesh preparedMesh, ref Matrix4x4 preparedMatrix)
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x184D710", Offset = "0x184D710", VA = "0x184D710")]
		public P3dPaintableTexture()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public abstract class P3dPaintableTextureMonitor : MonoBehaviour
	{
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private P3dPaintableTexture paintableTexture;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private P3dPaintableTexture registeredPaintableTexture;

		[Token(Token = "0x170001B6")]
		public P3dPaintableTexture PaintableTexture
		{
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x184D9E4", Offset = "0x184D9E4", VA = "0x184D9E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x184D900", Offset = "0x184D900", VA = "0x184D900")]
			set
			{
			}
		}

		[Token(Token = "0x170001B7")]
		public bool Registered
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x184D9EC", Offset = "0x184D9EC", VA = "0x184D9EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x184D908", Offset = "0x184D908", VA = "0x184D908")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58B84", Offset = "0xD58B84")]
		public void Register()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x184DA5C", Offset = "0x184DA5C", VA = "0x184DA5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58BBC", Offset = "0xD58BBC")]
		public void Unregister()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x184DB2C", Offset = "0x184DB2C", VA = "0x184DB2C", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x184DB30", Offset = "0x184DB30", VA = "0x184DB30", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x184DB34", Offset = "0x184DB34", VA = "0x184DB34", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600096D")]
		protected abstract void UpdateMonitor(P3dPaintableTexture paintableTexture, bool preview);

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x184DB3C", Offset = "0x184DB3C", VA = "0x184DB3C")]
		private void HandleModified(bool preview)
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x184DBE4", Offset = "0x184DBE4", VA = "0x184DBE4")]
		protected P3dPaintableTextureMonitor()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public abstract class P3dPaintableTextureMonitorMask : P3dPaintableTextureMonitor
	{
		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Mesh mesh;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected int total;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected bool baked;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Mesh bakedMesh;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2Int bakedSize;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected List<bool> bakedPixels;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material cachedMaterial;

		[Token(Token = "0x170001B8")]
		public Mesh Mesh
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x184DBF4", Offset = "0x184DBF4", VA = "0x184DBF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x184DBEC", Offset = "0x184DBEC", VA = "0x184DBEC")]
			set
			{
			}
		}

		[Token(Token = "0x170001B9")]
		public int Total
		{
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x184DBFC", Offset = "0x184DBFC", VA = "0x184DBFC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x184DC04", Offset = "0x184DC04", VA = "0x184DC04", Slot = "8")]
		protected virtual void ClearBake()
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x184DCA8", Offset = "0x184DCA8", VA = "0x184DCA8")]
		protected void UpdateTotal(RenderTexture temporary, int width, int height, RenderTextureFormat format, int scale)
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x184DE00", Offset = "0x184DE00", VA = "0x184DE00")]
		private void Bake(RenderTexture temporary, int width, int height, RenderTextureFormat format, int scale)
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x184E2E8", Offset = "0x184E2E8", VA = "0x184E2E8")]
		protected P3dPaintableTextureMonitorMask()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010D")]
	public struct P3dSlot
	{
		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Index;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Name;

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x10600FC", Offset = "0x10600FC", VA = "0x10600FC")]
		public P3dSlot(int newIndex, string newName)
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x1060108", Offset = "0x1060108", VA = "0x1060108")]
		public Material FindMaterial(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x1060184", Offset = "0x1060184", VA = "0x1060184")]
		public Texture FindTexture(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x1060268", Offset = "0x1060268", VA = "0x1060268", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x10602F0", Offset = "0x10602F0", VA = "0x10602F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x1060338", Offset = "0x1060338", VA = "0x1060338")]
		public static bool operator ==(P3dSlot a, P3dSlot b)
		{
			return default(bool);
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x1060358", Offset = "0x1060358", VA = "0x1060358")]
		public static bool operator !=(P3dSlot a, P3dSlot b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010E")]
	public static class P3dStateManager
	{
		[Token(Token = "0x170001BA")]
		public static bool CanUndo
		{
			[Token(Token = "0x600097E")]
			[Address(RVA = "0x1060378", Offset = "0x1060378", VA = "0x1060378")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001BB")]
		public static bool CanRedo
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x1060420", Offset = "0x1060420", VA = "0x1060420")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x10604C8", Offset = "0x10604C8", VA = "0x10604C8")]
		public static void StoreAllStates()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x1060560", Offset = "0x1060560", VA = "0x1060560")]
		public static void ClearAllStates()
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x10605F8", Offset = "0x10605F8", VA = "0x10605F8")]
		public static void UndoAll()
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x1060690", Offset = "0x1060690", VA = "0x1060690")]
		public static void RedoAll()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public interface IClone
	{
		[Token(Token = "0x6000984")]
		void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix);
	}
	[Token(Token = "0x2000110")]
	public interface IHit
	{
	}
	[Token(Token = "0x2000111")]
	public interface IHitLine
	{
		[Token(Token = "0x6000985")]
		void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation);
	}
	[Token(Token = "0x2000112")]
	public interface IHitPoint
	{
		[Token(Token = "0x6000986")]
		void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation);
	}
	[Token(Token = "0x2000113")]
	public interface IHitQuad
	{
		[Token(Token = "0x6000987")]
		void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation);
	}
	[Token(Token = "0x2000114")]
	public interface IHitRaycast
	{
		[Token(Token = "0x6000988")]
		void HandleHitRaycast(bool preview, int priority, float pressure, int seed, RaycastHit hit, Quaternion rotation);
	}
	[Serializable]
	[Token(Token = "0x2000115")]
	public struct P3dBlendMode
	{
		[Token(Token = "0x400053D")]
		public const int ALPHA_BLEND = 0;

		[Token(Token = "0x400053E")]
		public const int ALPHA_BLEND_INVERSE = 1;

		[Token(Token = "0x400053F")]
		public const int ALPHA_BLEND_RGB = 2;

		[Token(Token = "0x4000540")]
		public const int ADDITIVE = 3;

		[Token(Token = "0x4000541")]
		public const int ADDITIVE_SOFT = 4;

		[Token(Token = "0x4000542")]
		public const int SUBTRACTIVE = 5;

		[Token(Token = "0x4000543")]
		public const int SUBTRACTIVE_SOFT = 6;

		[Token(Token = "0x4000544")]
		public const int REPLACE = 7;

		[Token(Token = "0x4000545")]
		public const int REPLACE_ORIGINAL = 8;

		[Token(Token = "0x4000546")]
		public const int REPLACE_CUSTOM = 9;

		[Token(Token = "0x4000547")]
		public const int MULTIPLY_INVERSE_RGB = 10;

		[Token(Token = "0x4000548")]
		public const int BLUR = 11;

		[Token(Token = "0x4000549")]
		public const int COUNT = 12;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string[] NAMES;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Index;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture Texture;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color Color;

		[Token(Token = "0x170001BC")]
		public static P3dBlendMode AlphaBlend
		{
			[Token(Token = "0x6000989")]
			[Address(RVA = "0x1248A2C", Offset = "0x1248A2C", VA = "0x1248A2C")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001BD")]
		public static P3dBlendMode AlphaBlendInverse
		{
			[Token(Token = "0x600098A")]
			[Address(RVA = "0x1248A5C", Offset = "0x1248A5C", VA = "0x1248A5C")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001BE")]
		public static P3dBlendMode AlphaBlendRGB
		{
			[Token(Token = "0x600098B")]
			[Address(RVA = "0x1248A98", Offset = "0x1248A98", VA = "0x1248A98")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001BF")]
		public static P3dBlendMode Additive
		{
			[Token(Token = "0x600098C")]
			[Address(RVA = "0x1248AD4", Offset = "0x1248AD4", VA = "0x1248AD4")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001C0")]
		public static P3dBlendMode AdditiveSoft
		{
			[Token(Token = "0x600098D")]
			[Address(RVA = "0x1248B10", Offset = "0x1248B10", VA = "0x1248B10")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001C1")]
		public static P3dBlendMode Subtractive
		{
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x1248B4C", Offset = "0x1248B4C", VA = "0x1248B4C")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001C2")]
		public static P3dBlendMode SubtractiveSoft
		{
			[Token(Token = "0x600098F")]
			[Address(RVA = "0x1248B88", Offset = "0x1248B88", VA = "0x1248B88")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001C3")]
		public static P3dBlendMode Replace
		{
			[Token(Token = "0x6000990")]
			[Address(RVA = "0x1248BC4", Offset = "0x1248BC4", VA = "0x1248BC4")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001C4")]
		public static P3dBlendMode ReplaceOriginal
		{
			[Token(Token = "0x6000991")]
			[Address(RVA = "0x12489F0", Offset = "0x12489F0", VA = "0x12489F0")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001C5")]
		public static P3dBlendMode MultiplyInverseRGB
		{
			[Token(Token = "0x6000993")]
			[Address(RVA = "0x1248C1C", Offset = "0x1248C1C", VA = "0x1248C1C")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001C6")]
		public static P3dBlendMode Blur
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0x1248C58", Offset = "0x1248C58", VA = "0x1248C58")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x1248C00", Offset = "0x1248C00", VA = "0x1248C00")]
		public static P3dBlendMode ReplaceCustom(Color color, Texture texture)
		{
			return default(P3dBlendMode);
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x1248C94", Offset = "0x1248C94", VA = "0x1248C94")]
		public void Apply(Material material)
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x1248D60", Offset = "0x1248D60", VA = "0x1248D60")]
		public static string GetName(int index)
		{
			return null;
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x1248E04", Offset = "0x1248E04", VA = "0x1248E04")]
		public static bool operator ==(P3dBlendMode a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x1248E14", Offset = "0x1248E14", VA = "0x1248E14")]
		public static bool operator !=(P3dBlendMode a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x1248E24", Offset = "0x1248E24", VA = "0x1248E24")]
		public static implicit operator int(P3dBlendMode a)
		{
			return default(int);
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x1248E2C", Offset = "0x1248E2C", VA = "0x1248E2C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x1248EA0", Offset = "0x1248EA0", VA = "0x1248EA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000116")]
	public enum P3dChannel
	{
		[Token(Token = "0x400054F")]
		Red,
		[Token(Token = "0x4000550")]
		Green,
		[Token(Token = "0x4000551")]
		Blue,
		[Token(Token = "0x4000552")]
		Alpha
	}
	[Token(Token = "0x2000117")]
	public abstract class P3dClone : P3dLinkedBehaviour<P3dClone>, IClone
	{
		[NonSerialized]
		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int MatrixCount;

		[NonSerialized]
		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int ClonerCount;

		[NonSerialized]
		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<Matrix4x4> tempPosMatrices;

		[NonSerialized]
		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<Matrix4x4> tempRotMatrices;

		[NonSerialized]
		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<IClone> tempCloners;

		[Token(Token = "0x600099D")]
		public abstract void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix);

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x124921C", Offset = "0x124921C", VA = "0x124921C")]
		public static void BuildCloners([Optional] List<IClone> cloners)
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x12494D4", Offset = "0x12494D4", VA = "0x12494D4")]
		public static void Clone(P3dCommand command, int clonerIndex, int matrixIndex)
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x12497B0", Offset = "0x12497B0", VA = "0x12497B0")]
		protected P3dClone()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public abstract class P3dCommand
	{
		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool Preview;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Priority;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Index;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public P3dBlendMode Blend;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Material Material;

		[Token(Token = "0x170001C7")]
		public abstract bool RequireMesh
		{
			[Token(Token = "0x60009A3")]
			get;
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x1249ED0", Offset = "0x1249ED0", VA = "0x1249ED0")]
		public static int Compare(P3dCommand a, P3dCommand b)
		{
			return default(int);
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x124882C", Offset = "0x124882C", VA = "0x124882C")]
		public void SetState(bool preview, int priority)
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x1249F3C", Offset = "0x1249F3C", VA = "0x1249F3C")]
		public void Apply(RenderTexture buffer)
		{
		}

		[Token(Token = "0x60009A6")]
		public abstract void Apply();

		[Token(Token = "0x60009A7")]
		public abstract void Pool();

		[Token(Token = "0x60009A8")]
		public abstract void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix);

		[Token(Token = "0x60009A9")]
		public abstract P3dCommand SpawnCopy();

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x124A078", Offset = "0x124A078", VA = "0x124A078")]
		public P3dCommand SpawnCopyLocal(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x124A150", Offset = "0x124A150", VA = "0x124A150")]
		public P3dCommand SpawnCopyWorld(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60009AC")]
		protected T SpawnCopy<T>(Stack<T> pool) where T : P3dCommand, new()
		{
			return null;
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x124A210", Offset = "0x124A210", VA = "0x124A210")]
		protected P3dCommand()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class P3dCommandDecal : P3dCommand
	{
		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool In3D;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 Position;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 EndPosition;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 Position2;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 EndPosition2;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int Extrusions;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Matrix4x4 Matrix;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Vector3 Direction;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public Color Color;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float Opacity;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float Hardness;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float Wrapping;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Texture Texture;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Texture Shape;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Vector4 ShapeChannel;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Vector2 NormalFront;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Vector2 NormalBack;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Texture TileTexture;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Matrix4x4 TileMatrix;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public float TileOpacity;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static P3dCommandDecal Instance;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Stack<P3dCommandDecal> pool;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Material[] cachedSpotMaterials;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Material[] cachedLineMaterials;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Material[] cachedQuadMaterials;

		[Token(Token = "0x170001C8")]
		public override bool RequireMesh
		{
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x124A218", Offset = "0x124A218", VA = "0x124A218", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x124A220", Offset = "0x124A220", VA = "0x124A220")]
		static P3dCommandDecal()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x124A348", Offset = "0x124A348", VA = "0x124A348", Slot = "5")]
		public override void Apply()
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x124A778", Offset = "0x124A778", VA = "0x124A778", Slot = "6")]
		public override void Pool()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x124A7FC", Offset = "0x124A7FC", VA = "0x124A7FC", Slot = "7")]
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix)
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x124A9D0", Offset = "0x124A9D0", VA = "0x124A9D0", Slot = "8")]
		public override P3dCommand SpawnCopy()
		{
			return null;
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x124AB38", Offset = "0x124AB38", VA = "0x124AB38")]
		public void SetShape(Quaternion rotation, Vector3 size, float angle)
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x124AE18", Offset = "0x124AE18", VA = "0x124AE18")]
		public void SetLocation(Vector3 position, bool in3D = true)
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x124AE30", Offset = "0x124AE30", VA = "0x124AE30")]
		public void SetLocation(Vector3 position, Vector3 endPosition, bool in3D = true)
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x124AE50", Offset = "0x124AE50", VA = "0x124AE50")]
		public void SetLocation(Vector3 positionA, Vector3 positionB, Vector3 positionC, bool in3D = true)
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x124AE84", Offset = "0x124AE84", VA = "0x124AE84")]
		public void SetLocation(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, bool in3D = true)
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x124AEC4", Offset = "0x124AEC4", VA = "0x124AEC4")]
		public void ApplyAspect(Texture texture)
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x124AF94", Offset = "0x124AF94", VA = "0x124AF94")]
		public void SetMaterial(P3dBlendMode blendMode, Texture texture, Texture shape, P3dChannel shapeChannel, float hardness, float wrapping, float normalBack, float normalFront, float normalFade, Color color, float opacity, Texture tileTexture, Matrix4x4 tileMatrix, float tileOpacity)
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x124A340", Offset = "0x124A340", VA = "0x124A340")]
		public P3dCommandDecal()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class P3dCommandFill : P3dCommand
	{
		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture Texture;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Color Color;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float Opacity;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float Minimum;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static P3dCommandFill Instance;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Stack<P3dCommandFill> pool;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Material[] cachedMaterials;

		[Token(Token = "0x170001C9")]
		public override bool RequireMesh
		{
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x124B310", Offset = "0x124B310", VA = "0x124B310", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x124B318", Offset = "0x124B318", VA = "0x124B318")]
		static P3dCommandFill()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x124B3F8", Offset = "0x124B3F8", VA = "0x124B3F8")]
		public static RenderTexture Blit(RenderTexture main, P3dBlendMode blendMode, Texture texture, Color color, float opacity, float minimum)
		{
			return null;
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x124B614", Offset = "0x124B614", VA = "0x124B614")]
		public static void Blit(ref RenderTexture main, ref RenderTexture swap, P3dBlendMode blendMode, Texture texture, Color color, float opacity, float minimum)
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x124B818", Offset = "0x124B818", VA = "0x124B818", Slot = "5")]
		public override void Apply()
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x124B94C", Offset = "0x124B94C", VA = "0x124B94C", Slot = "6")]
		public override void Pool()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x124B9D0", Offset = "0x124B9D0", VA = "0x124B9D0", Slot = "7")]
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix)
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x124B9D4", Offset = "0x124B9D4", VA = "0x124B9D4", Slot = "8")]
		public override P3dCommand SpawnCopy()
		{
			return null;
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x124883C", Offset = "0x124883C", VA = "0x124883C")]
		public void SetMaterial(P3dBlendMode blendMode, Texture texture, Color color, float opacity, float minimum)
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x124B3F0", Offset = "0x124B3F0", VA = "0x124B3F0")]
		public P3dCommandFill()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class P3dCommandReplace : P3dCommand
	{
		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture Texture;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Color Color;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static P3dCommandReplace Instance;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Stack<P3dCommandReplace> pool;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Material cachedMaterial;

		[Token(Token = "0x170001CA")]
		public override bool RequireMesh
		{
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x124BA7C", Offset = "0x124BA7C", VA = "0x124BA7C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x124BA84", Offset = "0x124BA84", VA = "0x124BA84")]
		static P3dCommandReplace()
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x124BB60", Offset = "0x124BB60", VA = "0x124BB60")]
		public static void Blit(RenderTexture renderTexture, Texture texture, Color tint)
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x124BD54", Offset = "0x124BD54", VA = "0x124BD54")]
		public static void BlitFast(RenderTexture renderTexture, Texture texture, Color tint)
		{
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x124BE6C", Offset = "0x124BE6C", VA = "0x124BE6C", Slot = "5")]
		public override void Apply()
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x124BF1C", Offset = "0x124BF1C", VA = "0x124BF1C", Slot = "6")]
		public override void Pool()
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x124BFA0", Offset = "0x124BFA0", VA = "0x124BFA0", Slot = "7")]
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix)
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x124BFA4", Offset = "0x124BFA4", VA = "0x124BFA4", Slot = "8")]
		public override P3dCommand SpawnCopy()
		{
			return null;
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x124BC70", Offset = "0x124BC70", VA = "0x124BC70")]
		public void SetMaterial(Texture texture, Color color)
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x124BB58", Offset = "0x124BB58", VA = "0x124BB58")]
		public P3dCommandReplace()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class P3dCommandReplaceChannels : P3dCommand
	{
		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture TextureR;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Texture TextureG;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Texture TextureB;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture TextureA;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector4 ChannelR;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector4 ChannelG;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Vector4 ChannelB;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Vector4 ChannelA;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static P3dCommandReplaceChannels Instance;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Stack<P3dCommandReplaceChannels> pool;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Material cachedMaterial;

		[Token(Token = "0x170001CB")]
		public override bool RequireMesh
		{
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x124C03C", Offset = "0x124C03C", VA = "0x124C03C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x124C044", Offset = "0x124C044", VA = "0x124C044")]
		static P3dCommandReplaceChannels()
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x124C120", Offset = "0x124C120", VA = "0x124C120")]
		public static void Blit(RenderTexture renderTexture, Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA)
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x124C470", Offset = "0x124C470", VA = "0x124C470")]
		public static void BlitFast(RenderTexture renderTexture, Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA)
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x124C658", Offset = "0x124C658", VA = "0x124C658", Slot = "5")]
		public override void Apply()
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x124C7D4", Offset = "0x124C7D4", VA = "0x124C7D4", Slot = "6")]
		public override void Pool()
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x124C858", Offset = "0x124C858", VA = "0x124C858", Slot = "7")]
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix)
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x124C85C", Offset = "0x124C85C", VA = "0x124C85C", Slot = "8")]
		public override P3dCommand SpawnCopy()
		{
			return null;
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x124C300", Offset = "0x124C300", VA = "0x124C300")]
		public void SetMaterial(Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA)
		{
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x124C118", Offset = "0x124C118", VA = "0x124C118")]
		public P3dCommandReplaceChannels()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class P3dCommandSphere : P3dCommand
	{
		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool In3D;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 Position;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 EndPosition;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 Position2;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 EndPosition2;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int Extrusions;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Matrix4x4 Matrix;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Color Color;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float Opacity;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float Hardness;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Texture TileTexture;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Matrix4x4 TileMatrix;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float TileOpacity;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static P3dCommandSphere Instance;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Stack<P3dCommandSphere> pool;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Material[] cachedSpotMaterials;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Material[] cachedLineMaterials;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Material[] cachedQuadMaterials;

		[Token(Token = "0x170001CC")]
		public override bool RequireMesh
		{
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x124C924", Offset = "0x124C924", VA = "0x124C924", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x124C92C", Offset = "0x124C92C", VA = "0x124C92C")]
		static P3dCommandSphere()
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x124CA54", Offset = "0x124CA54", VA = "0x124CA54", Slot = "5")]
		public override void Apply()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x124CD60", Offset = "0x124CD60", VA = "0x124CD60", Slot = "6")]
		public override void Pool()
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x124CDE4", Offset = "0x124CDE4", VA = "0x124CDE4", Slot = "7")]
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix)
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x124CF5C", Offset = "0x124CF5C", VA = "0x124CF5C", Slot = "8")]
		public override P3dCommand SpawnCopy()
		{
			return null;
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x124D07C", Offset = "0x124D07C", VA = "0x124D07C")]
		public void SetLocation(Vector3 position, bool in3D = true)
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x124D094", Offset = "0x124D094", VA = "0x124D094")]
		public void SetLocation(Vector3 position, Vector3 endPosition, bool in3D = true)
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x124D0B4", Offset = "0x124D0B4", VA = "0x124D0B4")]
		public void SetLocation(Vector3 positionA, Vector3 positionB, Vector3 positionC, bool in3D = true)
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x124D0E8", Offset = "0x124D0E8", VA = "0x124D0E8")]
		public void SetLocation(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, bool in3D = true)
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x124D128", Offset = "0x124D128", VA = "0x124D128")]
		public void ApplyAspect(Texture texture)
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x124D1F8", Offset = "0x124D1F8", VA = "0x124D1F8")]
		public void SetShape(float radius)
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x124D348", Offset = "0x124D348", VA = "0x124D348")]
		public void SetShape(Quaternion rotation, Vector3 size, float angle)
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x124D540", Offset = "0x124D540", VA = "0x124D540")]
		public void SetMaterial(P3dBlendMode blendMode, float hardness, Color color, float opacity, Texture tileTexture, Matrix4x4 tileMatrix, float tileOpacity)
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x124CA4C", Offset = "0x124CA4C", VA = "0x124CA4C")]
		public P3dCommandSphere()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public enum P3dCoord
	{
		[Token(Token = "0x40005A0")]
		First,
		[Token(Token = "0x40005A1")]
		Second,
		[Token(Token = "0x40005A2")]
		Third,
		[Token(Token = "0x40005A3")]
		Fourth
	}
	[Token(Token = "0x200011F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD53324", Offset = "0xD53324")]
	public class P3dCoordCopier : ScriptableObject
	{
		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Mesh source;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Mesh mesh;

		[NonSerialized]
		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<BoneWeight> boneWeights;

		[NonSerialized]
		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<Color32> colors;

		[NonSerialized]
		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<Vector3> positions;

		[NonSerialized]
		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<Vector3> normals;

		[NonSerialized]
		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static List<Vector4> tangents;

		[NonSerialized]
		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static List<Vector4> coords0;

		[NonSerialized]
		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static List<Vector4> coords1;

		[NonSerialized]
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static List<Vector4> coords2;

		[NonSerialized]
		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static List<Vector4> coords3;

		[NonSerialized]
		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static List<int> indices;

		[Token(Token = "0x170001CD")]
		public Mesh Source
		{
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x124EC74", Offset = "0x124EC74", VA = "0x124EC74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x124EC6C", Offset = "0x124EC6C", VA = "0x124EC6C")]
			set
			{
			}
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x124EC7C", Offset = "0x124EC7C", VA = "0x124EC7C")]
		public void Generate()
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x124F2C0", Offset = "0x124F2C0", VA = "0x124F2C0", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x124F334", Offset = "0x124F334", VA = "0x124F334")]
		public P3dCoordCopier()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000120")]
	public struct P3dGroup
	{
		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int index;

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x124F518", Offset = "0x124F518", VA = "0x124F518")]
		public P3dGroup(int newIndex)
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x124F520", Offset = "0x124F520", VA = "0x124F520")]
		public static implicit operator int(P3dGroup group)
		{
			return default(int);
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x124F524", Offset = "0x124F524", VA = "0x124F524")]
		public static implicit operator P3dGroup(int index)
		{
			return default(P3dGroup);
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x124F52C", Offset = "0x124F52C", VA = "0x124F52C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000121")]
	public class P3dGroupData : ScriptableObject
	{
		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int index;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color defaultColor;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Texture defaultTexture;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<P3dGroupData> cachedInstances;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool cachedInstancesSet;

		[Token(Token = "0x170001CE")]
		public int Index
		{
			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x124F53C", Offset = "0x124F53C", VA = "0x124F53C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x124F534", Offset = "0x124F534", VA = "0x124F534")]
			set
			{
			}
		}

		[Token(Token = "0x170001CF")]
		public Color DefaultColor
		{
			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x124F550", Offset = "0x124F550", VA = "0x124F550")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x124F544", Offset = "0x124F544", VA = "0x124F544")]
			set
			{
			}
		}

		[Token(Token = "0x170001D0")]
		public Texture DefaultTexture
		{
			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x124F564", Offset = "0x124F564", VA = "0x124F564")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x124F55C", Offset = "0x124F55C", VA = "0x124F55C")]
			set
			{
			}
		}

		[Token(Token = "0x170001D1")]
		public static List<P3dGroupData> CachedInstances
		{
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x124F688", Offset = "0x124F688", VA = "0x124F688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x124F56C", Offset = "0x124F56C", VA = "0x124F56C")]
		public string GetName(bool prefixNumber)
		{
			return null;
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x124F61C", Offset = "0x124F61C", VA = "0x124F61C")]
		public static void UpdateCachedInstances()
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x124F730", Offset = "0x124F730", VA = "0x124F730")]
		public static string GetGroupName(int index, bool prefixNumber)
		{
			return null;
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x124F804", Offset = "0x124F804", VA = "0x124F804")]
		public static P3dGroupData GetGroupData(int index)
		{
			return null;
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x124F970", Offset = "0x124F970", VA = "0x124F970")]
		public P3dGroupData()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public static class P3dHelper
	{
		[Token(Token = "0x40005B6")]
		public const string HelpUrlPrefix = "http://carloswilkes.github.io/Documentation/PaintIn3D#";

		[Token(Token = "0x40005B7")]
		public const string ComponentMenuPrefix = "Paint in 3D/";

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int uniqueSeed;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<UnityEngine.Random.State> states;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Mesh sphereMesh;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool sphereMeshSet;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Mesh quadMesh;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static bool quadMeshSet;

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x124F9EC", Offset = "0x124F9EC", VA = "0x124F9EC")]
		public static void BeginUniqueSeed()
		{
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x124FA80", Offset = "0x124FA80", VA = "0x124FA80")]
		public static void BeginSeed(int seed)
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x124FB28", Offset = "0x124FB28", VA = "0x124FB28")]
		public static void EndSeed()
		{
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x124FC28", Offset = "0x124FC28", VA = "0x124FC28")]
		public static Quaternion NormalToCameraRotation(Vector3 normal, [Optional] Camera optionalCamera)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x124FDC4", Offset = "0x124FDC4", VA = "0x124FDC4")]
		public static Camera GetCamera([Optional] Camera camera)
		{
			return null;
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x124FE64", Offset = "0x124FE64", VA = "0x124FE64")]
		public static Vector3 GetCameraUp([Optional] Camera camera)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x124FF54", Offset = "0x124FF54", VA = "0x124FF54")]
		public static bool IndexInMask(int index, int mask)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x124B55C", Offset = "0x124B55C", VA = "0x124B55C")]
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc)
		{
			return null;
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x124FF68", Offset = "0x124FF68", VA = "0x124FF68")]
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc, bool sRGB)
		{
			return null;
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x1247300", Offset = "0x1247300", VA = "0x1247300")]
		public static RenderTexture ReleaseRenderTexture(RenderTexture renderTexture)
		{
			return null;
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x1250040", Offset = "0x1250040", VA = "0x1250040")]
		public static bool CanReadPixels(TextureFormat format)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x1250074", Offset = "0x1250074", VA = "0x1250074")]
		public static void ReadPixelsLinearGamma(Texture2D texture2D, RenderTexture renderTexture)
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x1250294", Offset = "0x1250294", VA = "0x1250294")]
		public static void ReadPixels(Texture2D texture2D, RenderTexture renderTexture)
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x1246DAC", Offset = "0x1246DAC", VA = "0x1246DAC")]
		public static bool Downsample(RenderTexture renderTexture, int steps, ref RenderTexture temporary)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x1250504", Offset = "0x1250504", VA = "0x1250504")]
		public static bool HasMipMaps(Texture texture)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x125067C", Offset = "0x125067C", VA = "0x125067C")]
		public static Mesh GetSphereMesh()
		{
			return null;
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x12507A8", Offset = "0x12507A8", VA = "0x12507A8")]
		public static Mesh GetQuadMesh()
		{
			return null;
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x124731C", Offset = "0x124731C", VA = "0x124731C")]
		public static Texture2D GetReadableCopy(RenderTexture renderTexture, TextureFormat format = TextureFormat.ARGB32, bool mipMaps = false)
		{
			return null;
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x12508D4", Offset = "0x12508D4", VA = "0x12508D4")]
		public static Texture2D GetReadableCopy(Texture texture, TextureFormat format = TextureFormat.ARGB32, bool mipMaps = false, int width = 0, int height = 0)
		{
			return null;
		}

		[Token(Token = "0x6000A13")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x1250B70", Offset = "0x1250B70", VA = "0x1250B70")]
		public static void SaveBytes(string saveName, byte[] data, bool save = true)
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x1250C20", Offset = "0x1250C20", VA = "0x1250C20")]
		public static byte[] LoadBytes(string saveName)
		{
			return null;
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x1250CB4", Offset = "0x1250CB4", VA = "0x1250CB4")]
		public static bool SaveExists(string saveName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x1250CBC", Offset = "0x1250CBC", VA = "0x1250CBC")]
		public static void ClearSave(string saveName, bool save = true)
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x1250D08", Offset = "0x1250D08", VA = "0x1250D08")]
		public static Vector3 GetPosition(Vector3 position, Vector3 endPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x1250DBC", Offset = "0x1250DBC", VA = "0x1250DBC")]
		public static Vector3 GetPosition(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x1250EC4", Offset = "0x1250EC4", VA = "0x1250EC4")]
		public static float GetRadius(Vector3 size)
		{
			return default(float);
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x1250FA4", Offset = "0x1250FA4", VA = "0x1250FA4")]
		public static float GetRadius(Vector3 size, Vector3 position, Vector3 endPosition)
		{
			return default(float);
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x12510B8", Offset = "0x12510B8", VA = "0x12510B8")]
		public static float GetRadius(Vector3 size, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2)
		{
			return default(float);
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x1251334", Offset = "0x1251334", VA = "0x1251334")]
		public static Vector3 ScaleAspect(Vector3 size, float aspect)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x1251350", Offset = "0x1251350", VA = "0x1251350")]
		public static float GetAspect(Texture textureA, [Optional] Texture textureB)
		{
			return default(float);
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x125146C", Offset = "0x125146C", VA = "0x125146C")]
		public static void Blit(RenderTexture renderTexture, Texture other)
		{
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x124B784", Offset = "0x124B784", VA = "0x124B784")]
		public static void Blit(RenderTexture renderTexture, Material material)
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x124B248", Offset = "0x124B248", VA = "0x124B248")]
		public static Vector4 IndexToVector(int index)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x12515FC", Offset = "0x12515FC", VA = "0x12515FC")]
		public static void Draw(Material material, Mesh mesh, Matrix4x4 matrix, int subMesh, P3dCoord coord)
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x1251500", Offset = "0x1251500", VA = "0x1251500")]
		public static void Draw(Material material)
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x1251738", Offset = "0x1251738", VA = "0x1251738")]
		public static Texture2D CreateTexture(int width, int height, TextureFormat format, bool mipMaps)
		{
			return null;
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x12517D8", Offset = "0x12517D8", VA = "0x12517D8")]
		public static Material GetMaterial(GameObject gameObject, int materialIndex = 0)
		{
			return null;
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x12518FC", Offset = "0x12518FC", VA = "0x12518FC")]
		public static Material CloneMaterial(GameObject gameObject, int materialIndex = 0)
		{
			return null;
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x1251A9C", Offset = "0x1251A9C", VA = "0x1251A9C")]
		public static Material AddMaterial(Renderer renderer, Shader shader, int materialIndex = -1)
		{
			return null;
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x124B2F8", Offset = "0x124B2F8", VA = "0x124B2F8")]
		public static float Reciprocal(float a)
		{
			return default(float);
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x1251BEC", Offset = "0x1251BEC", VA = "0x1251BEC")]
		public static float Divide(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x1251C00", Offset = "0x1251C00", VA = "0x1251C00")]
		public static int Mod(int a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x1251C14", Offset = "0x1251C14", VA = "0x1251C14")]
		public static Vector3 Reciprocal3(Vector3 xyz)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x1251CB8", Offset = "0x1251CB8", VA = "0x1251CB8")]
		public static float DampenFactor(float dampening, float elapsed)
		{
			return default(float);
		}

		[Token(Token = "0x6000A2D")]
		public static T Destroy<T>(T o) where T : UnityEngine.Object
		{
			return null;
		}
	}
	[Token(Token = "0x2000123")]
	public abstract class P3dLinkedBehaviour<T> : MonoBehaviour where T : P3dLinkedBehaviour<T>
	{
		[NonSerialized]
		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static T FirstInstance;

		[NonSerialized]
		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int InstanceCount;

		[NonSerialized]
		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T PrevInstance;

		[NonSerialized]
		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T NextInstance;

		[Token(Token = "0x6000A2F")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000A30")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000A31")]
		protected P3dLinkedBehaviour()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000124")]
	public abstract class P3dModifier
	{
		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool preview;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool unique;

		[Token(Token = "0x170001D2")]
		public bool Preview
		{
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x1843D78", Offset = "0x1843D78", VA = "0x1843D78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x1843D6C", Offset = "0x1843D6C", VA = "0x1843D6C")]
			set
			{
			}
		}

		[Token(Token = "0x170001D3")]
		public bool Unique
		{
			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x1843D8C", Offset = "0x1843D8C", VA = "0x1843D8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x1843D80", Offset = "0x1843D80", VA = "0x1843D80")]
			set
			{
			}
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x1843D94", Offset = "0x1843D94", VA = "0x1843D94")]
		public void ModifyAngle(ref float angle, float pressure)
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x1843E60", Offset = "0x1843E60", VA = "0x1843E60", Slot = "4")]
		protected virtual void OnModifyAngle(ref float angle, float pressure)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x1843E64", Offset = "0x1843E64", VA = "0x1843E64")]
		public void ModifyColor(ref Color color, float pressure)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x1843F30", Offset = "0x1843F30", VA = "0x1843F30", Slot = "5")]
		protected virtual void OnModifyColor(ref Color color, float pressure)
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x1843F34", Offset = "0x1843F34", VA = "0x1843F34")]
		public void ModifyHardness(ref float hardness, float pressure)
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x1844000", Offset = "0x1844000", VA = "0x1844000", Slot = "6")]
		protected virtual void OnModifyHardness(ref float hardness, float pressure)
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x1844004", Offset = "0x1844004", VA = "0x1844004")]
		public void ModifyOpacity(ref float opacity, float pressure)
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x18440D0", Offset = "0x18440D0", VA = "0x18440D0", Slot = "7")]
		protected virtual void OnModifyOpacity(ref float opacity, float pressure)
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x18440D4", Offset = "0x18440D4", VA = "0x18440D4")]
		public void ModifyRadius(ref float radius, float pressure)
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x18441A0", Offset = "0x18441A0", VA = "0x18441A0", Slot = "8")]
		protected virtual void OnModifyRadius(ref float radius, float pressure)
		{
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x18441A4", Offset = "0x18441A4", VA = "0x18441A4")]
		public void ModifyTexture(ref Texture texture, float pressure)
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x1844270", Offset = "0x1844270", VA = "0x1844270", Slot = "9")]
		protected virtual void OnModifyTexture(ref Texture texture, float pressure)
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x1844274", Offset = "0x1844274", VA = "0x1844274")]
		public void ModifyPosition(ref Vector3 position, float pressure)
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x1844340", Offset = "0x1844340", VA = "0x1844340", Slot = "10")]
		protected virtual void OnModifyPosition(ref Vector3 position, float pressure)
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x1844344", Offset = "0x1844344", VA = "0x1844344")]
		protected P3dModifier()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000125")]
	public class P3dModifierList : ISerializationCallbackReceiver
	{
		[NonSerialized]
		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<P3dModifier> modifiers;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<string> types;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> jsons;

		[Token(Token = "0x170001D4")]
		public int Count
		{
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x1844354", Offset = "0x1844354", VA = "0x1844354")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x18443A8", Offset = "0x18443A8", VA = "0x18443A8")]
		public void ModifyAngle(ref float angle, bool preview, float pressure)
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x18444D8", Offset = "0x18444D8", VA = "0x18444D8")]
		public void ModifyColor(ref Color color, bool preview, float pressure)
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x1844608", Offset = "0x1844608", VA = "0x1844608")]
		public void ModifyHardness(ref float hardness, bool preview, float pressure)
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x1844738", Offset = "0x1844738", VA = "0x1844738")]
		public void ModifyOpacity(ref float opacity, bool preview, float pressure)
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x1844868", Offset = "0x1844868", VA = "0x1844868")]
		public void ModifyRadius(ref float radius, bool preview, float pressure)
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x1844998", Offset = "0x1844998", VA = "0x1844998")]
		public void ModifyTexture(ref Texture texture, bool preview, float pressure)
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x1844AC8", Offset = "0x1844AC8", VA = "0x1844AC8")]
		public void ModifyPosition(ref Vector3 position, bool preview, float pressure)
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x1844BF8", Offset = "0x1844BF8", VA = "0x1844BF8", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x1844EF8", Offset = "0x1844EF8", VA = "0x1844EF8", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x1845110", Offset = "0x1845110", VA = "0x1845110")]
		public P3dModifierList()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000126")]
	public class P3dModifyAngleRandom : P3dModifier
	{
		[Token(Token = "0x20001E5")]
		public enum BlendType
		{
			[Token(Token = "0x40008C6")]
			Replace,
			[Token(Token = "0x40008C7")]
			Multiply,
			[Token(Token = "0x40008C8")]
			Increment
		}

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float min;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float max;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001D5")]
		public float Min
		{
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x1845120", Offset = "0x1845120", VA = "0x1845120")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x1845118", Offset = "0x1845118", VA = "0x1845118")]
			set
			{
			}
		}

		[Token(Token = "0x170001D6")]
		public float Max
		{
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x1845130", Offset = "0x1845130", VA = "0x1845130")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x1845128", Offset = "0x1845128", VA = "0x1845128")]
			set
			{
			}
		}

		[Token(Token = "0x170001D7")]
		public BlendType Blend
		{
			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x1845140", Offset = "0x1845140", VA = "0x1845140")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x1845138", Offset = "0x1845138", VA = "0x1845138")]
			set
			{
			}
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x1845148", Offset = "0x1845148", VA = "0x1845148", Slot = "4")]
		protected override void OnModifyAngle(ref float angle, float pressure)
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x18451A4", Offset = "0x18451A4", VA = "0x18451A4")]
		public P3dModifyAngleRandom()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000127")]
	public class P3dModifyColorRandom : P3dModifier
	{
		[Token(Token = "0x20001E6")]
		public enum BlendType
		{
			[Token(Token = "0x40008CA")]
			Replace,
			[Token(Token = "0x40008CB")]
			Multiply,
			[Token(Token = "0x40008CC")]
			Increment
		}

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Gradient gradient;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001D8")]
		public Gradient Gradient
		{
			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x1845234", Offset = "0x1845234", VA = "0x1845234")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D9")]
		public BlendType Blend
		{
			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x18452A8", Offset = "0x18452A8", VA = "0x18452A8")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x18452A0", Offset = "0x18452A0", VA = "0x18452A0")]
			set
			{
			}
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x18452B0", Offset = "0x18452B0", VA = "0x18452B0", Slot = "5")]
		protected override void OnModifyColor(ref Color color, float pressure)
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x1845354", Offset = "0x1845354", VA = "0x1845354")]
		public P3dModifyColorRandom()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class P3dModifyHardnessPressure : P3dModifier
	{
		[Token(Token = "0x20001E7")]
		public enum BlendType
		{
			[Token(Token = "0x40008CE")]
			Replace,
			[Token(Token = "0x40008CF")]
			Multiply,
			[Token(Token = "0x40008D0")]
			Increment
		}

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float hardness;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001DA")]
		public float Hardness
		{
			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x18453E0", Offset = "0x18453E0", VA = "0x18453E0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x18453D8", Offset = "0x18453D8", VA = "0x18453D8")]
			set
			{
			}
		}

		[Token(Token = "0x170001DB")]
		public BlendType Blend
		{
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x18453F0", Offset = "0x18453F0", VA = "0x18453F0")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x18453E8", Offset = "0x18453E8", VA = "0x18453E8")]
			set
			{
			}
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x18453F8", Offset = "0x18453F8", VA = "0x18453F8", Slot = "6")]
		protected override void OnModifyHardness(ref float currentHardness, float pressure)
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x1845450", Offset = "0x1845450", VA = "0x1845450")]
		public P3dModifyHardnessPressure()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000129")]
	public class P3dModifyHardnessRandom : P3dModifier
	{
		[Token(Token = "0x20001E8")]
		public enum BlendType
		{
			[Token(Token = "0x40008D2")]
			Replace,
			[Token(Token = "0x40008D3")]
			Multiply,
			[Token(Token = "0x40008D4")]
			Increment
		}

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float min;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float max;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001DC")]
		public float Min
		{
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x18454E4", Offset = "0x18454E4", VA = "0x18454E4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x18454DC", Offset = "0x18454DC", VA = "0x18454DC")]
			set
			{
			}
		}

		[Token(Token = "0x170001DD")]
		public float Max
		{
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x18454F4", Offset = "0x18454F4", VA = "0x18454F4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x18454EC", Offset = "0x18454EC", VA = "0x18454EC")]
			set
			{
			}
		}

		[Token(Token = "0x170001DE")]
		public BlendType Blend
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x1845504", Offset = "0x1845504", VA = "0x1845504")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x18454FC", Offset = "0x18454FC", VA = "0x18454FC")]
			set
			{
			}
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x184550C", Offset = "0x184550C", VA = "0x184550C", Slot = "6")]
		protected override void OnModifyHardness(ref float hardness, float pressure)
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x1845568", Offset = "0x1845568", VA = "0x1845568")]
		public P3dModifyHardnessRandom()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012A")]
	public class P3dModifyOpacityPressure : P3dModifier
	{
		[Token(Token = "0x20001E9")]
		public enum BlendType
		{
			[Token(Token = "0x40008D6")]
			Replace,
			[Token(Token = "0x40008D7")]
			Multiply,
			[Token(Token = "0x40008D8")]
			Increment
		}

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float opacity;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001DF")]
		public float Opacity
		{
			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x1845600", Offset = "0x1845600", VA = "0x1845600")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x18455F8", Offset = "0x18455F8", VA = "0x18455F8")]
			set
			{
			}
		}

		[Token(Token = "0x170001E0")]
		public BlendType Blend
		{
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x1845610", Offset = "0x1845610", VA = "0x1845610")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x1845608", Offset = "0x1845608", VA = "0x1845608")]
			set
			{
			}
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x1845618", Offset = "0x1845618", VA = "0x1845618", Slot = "7")]
		protected override void OnModifyOpacity(ref float currentOpacity, float pressure)
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x1845670", Offset = "0x1845670", VA = "0x1845670")]
		public P3dModifyOpacityPressure()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012B")]
	public class P3dModifyOpacityRandom : P3dModifier
	{
		[Token(Token = "0x20001EA")]
		public enum BlendType
		{
			[Token(Token = "0x40008DA")]
			Replace,
			[Token(Token = "0x40008DB")]
			Multiply,
			[Token(Token = "0x40008DC")]
			Increment
		}

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float min;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float max;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001E1")]
		public float Min
		{
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x1845704", Offset = "0x1845704", VA = "0x1845704")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x18456FC", Offset = "0x18456FC", VA = "0x18456FC")]
			set
			{
			}
		}

		[Token(Token = "0x170001E2")]
		public float Max
		{
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x1845714", Offset = "0x1845714", VA = "0x1845714")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x184570C", Offset = "0x184570C", VA = "0x184570C")]
			set
			{
			}
		}

		[Token(Token = "0x170001E3")]
		public BlendType Blend
		{
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x1845724", Offset = "0x1845724", VA = "0x1845724")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x184571C", Offset = "0x184571C", VA = "0x184571C")]
			set
			{
			}
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x184572C", Offset = "0x184572C", VA = "0x184572C", Slot = "7")]
		protected override void OnModifyOpacity(ref float opacity, float pressure)
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x1845788", Offset = "0x1845788", VA = "0x1845788")]
		public P3dModifyOpacityRandom()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012C")]
	public class P3dModifyPositionRandom : P3dModifier
	{
		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float radius;

		[Token(Token = "0x170001E4")]
		public float Radius
		{
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x1845820", Offset = "0x1845820", VA = "0x1845820")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x1845818", Offset = "0x1845818", VA = "0x1845818")]
			set
			{
			}
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x1845828", Offset = "0x1845828", VA = "0x1845828", Slot = "10")]
		protected override void OnModifyPosition(ref Vector3 position, float pressure)
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x1845914", Offset = "0x1845914", VA = "0x1845914")]
		public P3dModifyPositionRandom()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012D")]
	public class P3dModifyRadiusPressure : P3dModifier
	{
		[Token(Token = "0x20001EB")]
		public enum BlendType
		{
			[Token(Token = "0x40008DE")]
			Replace,
			[Token(Token = "0x40008DF")]
			Multiply,
			[Token(Token = "0x40008E0")]
			Increment
		}

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float radius;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001E5")]
		public float Radius
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x18459A8", Offset = "0x18459A8", VA = "0x18459A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x18459A0", Offset = "0x18459A0", VA = "0x18459A0")]
			set
			{
			}
		}

		[Token(Token = "0x170001E6")]
		public BlendType Blend
		{
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x18459B8", Offset = "0x18459B8", VA = "0x18459B8")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x18459B0", Offset = "0x18459B0", VA = "0x18459B0")]
			set
			{
			}
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x18459C0", Offset = "0x18459C0", VA = "0x18459C0", Slot = "8")]
		protected override void OnModifyRadius(ref float currentRadius, float pressure)
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x1845A18", Offset = "0x1845A18", VA = "0x1845A18")]
		public P3dModifyRadiusPressure()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012E")]
	public class P3dModifyRadiusRandom : P3dModifier
	{
		[Token(Token = "0x20001EC")]
		public enum BlendType
		{
			[Token(Token = "0x40008E2")]
			Replace,
			[Token(Token = "0x40008E3")]
			Multiply,
			[Token(Token = "0x40008E4")]
			Increment
		}

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float min;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float max;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001E7")]
		public float Min
		{
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x1845AAC", Offset = "0x1845AAC", VA = "0x1845AAC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x1845AA4", Offset = "0x1845AA4", VA = "0x1845AA4")]
			set
			{
			}
		}

		[Token(Token = "0x170001E8")]
		public float Max
		{
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x1845ABC", Offset = "0x1845ABC", VA = "0x1845ABC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x1845AB4", Offset = "0x1845AB4", VA = "0x1845AB4")]
			set
			{
			}
		}

		[Token(Token = "0x170001E9")]
		public BlendType Blend
		{
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x1845ACC", Offset = "0x1845ACC", VA = "0x1845ACC")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x1845AC4", Offset = "0x1845AC4", VA = "0x1845AC4")]
			set
			{
			}
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x1845AD4", Offset = "0x1845AD4", VA = "0x1845AD4", Slot = "8")]
		protected override void OnModifyRadius(ref float radius, float pressure)
		{
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x1845B30", Offset = "0x1845B30", VA = "0x1845B30")]
		public P3dModifyRadiusRandom()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012F")]
	public class P3dModifyTexturePressure : P3dModifier
	{
		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Texture texture;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float pressureMin;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float pressureMax;

		[Token(Token = "0x170001EA")]
		public Texture Texture
		{
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x1845BC8", Offset = "0x1845BC8", VA = "0x1845BC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x1845BC0", Offset = "0x1845BC0", VA = "0x1845BC0")]
			set
			{
			}
		}

		[Token(Token = "0x170001EB")]
		public float PressureMin
		{
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x1845BD8", Offset = "0x1845BD8", VA = "0x1845BD8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x1845BD0", Offset = "0x1845BD0", VA = "0x1845BD0")]
			set
			{
			}
		}

		[Token(Token = "0x170001EC")]
		public float PressureMax
		{
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x1845BE8", Offset = "0x1845BE8", VA = "0x1845BE8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x1845BE0", Offset = "0x1845BE0", VA = "0x1845BE0")]
			set
			{
			}
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x1845BF0", Offset = "0x1845BF0", VA = "0x1845BF0", Slot = "9")]
		protected override void OnModifyTexture(ref Texture currentTexture, float pressure)
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x1845C14", Offset = "0x1845C14", VA = "0x1845C14")]
		public P3dModifyTexturePressure()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000130")]
	public class P3dModifyTextureRandom : P3dModifier
	{
		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Texture> textures;

		[Token(Token = "0x170001ED")]
		public List<Texture> Textures
		{
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x1845CA4", Offset = "0x1845CA4", VA = "0x1845CA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x1845D18", Offset = "0x1845D18", VA = "0x1845D18", Slot = "9")]
		protected override void OnModifyTexture(ref Texture texture, float pressure)
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x1845DB8", Offset = "0x1845DB8", VA = "0x1845DB8")]
		public P3dModifyTextureRandom()
		{
		}
	}
	[Token(Token = "0x2000131")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD53370", Offset = "0xD53370")]
	public class P3dRenderingPipeline : ScriptableObject
	{
		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static P3dRenderingPipeline instance;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool isScriptable;

		[Token(Token = "0x170001EE")]
		public static bool IsScriptable
		{
			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0x184E2F0", Offset = "0x184E2F0", VA = "0x184E2F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000015")]
		public static event Action<bool> OnPipelineChanged
		{
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x184E404", Offset = "0x184E404", VA = "0x184E404")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58BF4", Offset = "0xD58BF4")]
			add
			{
			}
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x184E4BC", Offset = "0x184E4BC", VA = "0x184E4BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58C04", Offset = "0xD58C04")]
			remove
			{
			}
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x184E574", Offset = "0x184E574", VA = "0x184E574")]
		public P3dRenderingPipeline()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD533BC", Offset = "0xD533BC")]
	public class P3dSeamFixer : ScriptableObject
	{
		[Token(Token = "0x20001ED")]
		private class Edge
		{
			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool Used;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int IndexA;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int IndexB;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector2 CoordA;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector2 CoordB;

			[Token(Token = "0x6000CD6")]
			[Address(RVA = "0x105E7F8", Offset = "0x105E7F8", VA = "0x105E7F8")]
			public Edge()
			{
			}
		}

		[Token(Token = "0x20001EE")]
		private struct Point
		{
			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int Index;

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector2 Coord;
		}

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float DebugScale;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Mesh source;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD56690", Offset = "0xD56690")]
		[SerializeField]
		private P3dCoord coord;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float threshold;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float border;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Mesh mesh;

		[NonSerialized]
		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<BoneWeight> boneWeights;

		[NonSerialized]
		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<Color32> colors;

		[NonSerialized]
		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<Vector3> positions;

		[NonSerialized]
		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static List<Vector3> normals;

		[NonSerialized]
		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static List<Vector4> tangents;

		[NonSerialized]
		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static List<Vector4> coords0;

		[NonSerialized]
		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static List<Vector4> coords1;

		[NonSerialized]
		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static List<Vector4> coords2;

		[NonSerialized]
		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static List<Vector4> coords3;

		[NonSerialized]
		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static List<int> indices;

		[NonSerialized]
		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static List<Edge> edges;

		[NonSerialized]
		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static List<Point> points;

		[NonSerialized]
		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static List<int> insertions;

		[NonSerialized]
		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static float areaThreshold;

		[NonSerialized]
		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private static float coordThreshold;

		[NonSerialized]
		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static Vector2 startCoord;

		[NonSerialized]
		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static List<Vector3> deltaVertices;

		[NonSerialized]
		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static List<Vector3> deltaNormals;

		[NonSerialized]
		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static List<Vector3> deltaTangents;

		[NonSerialized]
		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static Mesh currentSource;

		[NonSerialized]
		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static Mesh currentOutput;

		[NonSerialized]
		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static P3dCoord currentCoord;

		[NonSerialized]
		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private static float currentBorder;

		[Token(Token = "0x170001EF")]
		public Mesh Source
		{
			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x105BCB0", Offset = "0x105BCB0", VA = "0x105BCB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x105BCA8", Offset = "0x105BCA8", VA = "0x105BCA8")]
			set
			{
			}
		}

		[Token(Token = "0x170001F0")]
		public P3dCoord Coord
		{
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x105BCC0", Offset = "0x105BCC0", VA = "0x105BCC0")]
			get
			{
				return default(P3dCoord);
			}
			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x105BCB8", Offset = "0x105BCB8", VA = "0x105BCB8")]
			set
			{
			}
		}

		[Token(Token = "0x170001F1")]
		public float Threshold
		{
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x105BCD0", Offset = "0x105BCD0", VA = "0x105BCD0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x105BCC8", Offset = "0x105BCC8", VA = "0x105BCC8")]
			set
			{
			}
		}

		[Token(Token = "0x170001F2")]
		public float Border
		{
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x105BCE0", Offset = "0x105BCE0", VA = "0x105BCE0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x105BCD8", Offset = "0x105BCD8", VA = "0x105BCD8")]
			set
			{
			}
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x105BCE8", Offset = "0x105BCE8", VA = "0x105BCE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD58C14", Offset = "0xD58C14")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x105C5E4", Offset = "0x105C5E4", VA = "0x105C5E4", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x105BD7C", Offset = "0x105BD7C", VA = "0x105BD7C")]
		public static void Generate(Mesh source, ref Mesh output, P3dCoord coord, float threshold, float border)
		{
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x105C658", Offset = "0x105C658", VA = "0x105C658")]
		private static void DoGenerate()
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x105CD50", Offset = "0x105CD50", VA = "0x105CD50")]
		private static void AddTriangle(int a, int b, int c)
		{
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x105E3F8", Offset = "0x105E3F8", VA = "0x105E3F8")]
		private static void AddTriangle(int a, int b, int c, Vector2 coordA, Vector2 coordB, Vector2 coordC)
		{
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x105E4E8", Offset = "0x105E4E8", VA = "0x105E4E8")]
		private static void RemoveOrAddEdge(int a, int b, Vector2 coordA, Vector2 coordB)
		{
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x105D3C4", Offset = "0x105D3C4", VA = "0x105D3C4")]
		private static void TraceEdges(Vector2 head)
		{
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x105E744", Offset = "0x105E744", VA = "0x105E744")]
		private static bool Overlap(Vector2 delta)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x105E800", Offset = "0x105E800", VA = "0x105E800")]
		private static void AddVertex(int index, Vector2 coord)
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x105EF6C", Offset = "0x105EF6C", VA = "0x105EF6C")]
		public P3dSeamFixer()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public static class P3dShader
	{
		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int _BaseChannel;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int _BaseParallaxMap;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int _BaseParallaxMap_Transform;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static int _Buffer;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static int _BufferSize;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static int _Channel;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static int _ChannelR;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static int _ChannelG;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static int _ChannelB;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static int _ChannelA;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static int _Color;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static int _Direction;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static int _DstA;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static int _DstRGB;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static int _EndPosition;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static int _EndPosition2;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static int _Hardness;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static int _In3D;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static int _ParallaxMap;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static int _ParallaxMap_Transform;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static int _Position;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static int _Position2;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static int _ReplaceTexture;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static int _ReplaceColor;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static int _MainTex;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static int _Matrix;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static int _Minimum;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static int _NormalBack;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static int _NormalFront;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static int _Op;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static int _Opacity;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static int _Shape;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static int _ShapeChannel;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static int _SrcA;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static int _SrcRGB;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public static int _Texture;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static int _TextureR;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public static int _TextureG;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static int _TextureB;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public static int _TextureA;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static int _TileTexture;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public static int _TileMatrix;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static int _TileOpacity;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public static int _Wrapping;

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x105F244", Offset = "0x105F244", VA = "0x105F244")]
		static P3dShader()
		{
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x105F808", Offset = "0x105F808", VA = "0x105F808")]
		public static Shader Load(string shaderName)
		{
			return null;
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x105F8E8", Offset = "0x105F8E8", VA = "0x105F8E8")]
		public static Material Build(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x105F94C", Offset = "0x105F94C", VA = "0x105F94C")]
		public static void BuildBlendMode(Material material, int index)
		{
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x105FA28", Offset = "0x105FA28", VA = "0x105FA28")]
		public static Material[] BuildMaterialsBlendModes(string shaderName, [Optional] string keyword)
		{
			return null;
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x105FBA8", Offset = "0x105FBA8", VA = "0x105FBA8")]
		public static Material BuildMaterial(string shaderName)
		{
			return null;
		}
	}
}
namespace PaintIn3D.Examples
{
	[Token(Token = "0x2000134")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD53408", Offset = "0xD53408")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD53408", Offset = "0xD53408")]
	public class P3dChannelCounter : P3dPaintableTextureMonitorMask
	{
		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LinkedList<P3dChannelCounter> Instances;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LinkedListNode<P3dChannelCounter> node;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int downsampleSteps;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD5671C", Offset = "0xD5671C")]
		[SerializeField]
		private float threshold;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int solidR;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int solidG;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int solidB;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private int solidA;

		[Token(Token = "0x170001F3")]
		public int DownsampleSteps
		{
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x1245838", Offset = "0x1245838", VA = "0x1245838")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x1245830", Offset = "0x1245830", VA = "0x1245830")]
			set
			{
			}
		}

		[Token(Token = "0x170001F4")]
		public float Threshold
		{
			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x1245848", Offset = "0x1245848", VA = "0x1245848")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x1245840", Offset = "0x1245840", VA = "0x1245840")]
			set
			{
			}
		}

		[Token(Token = "0x170001F5")]
		public int SolidR
		{
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x1245850", Offset = "0x1245850", VA = "0x1245850")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F6")]
		public int SolidG
		{
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x1245858", Offset = "0x1245858", VA = "0x1245858")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F7")]
		public int SolidB
		{
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x1245860", Offset = "0x1245860", VA = "0x1245860")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F8")]
		public int SolidA
		{
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x1245868", Offset = "0x1245868", VA = "0x1245868")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F9")]
		public float RatioR
		{
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x1245870", Offset = "0x1245870", VA = "0x1245870")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001FA")]
		public float RatioG
		{
			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x1245898", Offset = "0x1245898", VA = "0x1245898")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001FB")]
		public float RatioB
		{
			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x12458C0", Offset = "0x12458C0", VA = "0x12458C0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001FC")]
		public float RatioA
		{
			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x12458E8", Offset = "0x12458E8", VA = "0x12458E8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001FD")]
		public Vector4 RatioRGBA
		{
			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0x1245910", Offset = "0x1245910", VA = "0x1245910")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x1245A3C", Offset = "0x1245A3C", VA = "0x1245A3C")]
		public static long GetTotal([Optional] ICollection<P3dChannelCounter> counters)
		{
			return default(long);
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x1245CD0", Offset = "0x1245CD0", VA = "0x1245CD0")]
		public static long GetSolidR([Optional] ICollection<P3dChannelCounter> counters)
		{
			return default(long);
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x1245F64", Offset = "0x1245F64", VA = "0x1245F64")]
		public static long GetSolidG([Optional] ICollection<P3dChannelCounter> counters)
		{
			return default(long);
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x12461F8", Offset = "0x12461F8", VA = "0x12461F8")]
		public static long GetSolidB([Optional] ICollection<P3dChannelCounter> counters)
		{
			return default(long);
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x124648C", Offset = "0x124648C", VA = "0x124648C")]
		public static long GetSolidA([Optional] ICollection<P3dChannelCounter> counters)
		{
			return default(long);
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x1246720", Offset = "0x1246720", VA = "0x1246720")]
		public static Vector4 GetRatioRGBA([Optional] ICollection<P3dChannelCounter> counters)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x1246B74", Offset = "0x1246B74", VA = "0x1246B74", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x1246C08", Offset = "0x1246C08", VA = "0x1246C08", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x1246CA0", Offset = "0x1246CA0", VA = "0x1246CA0", Slot = "7")]
		protected override void UpdateMonitor(P3dPaintableTexture paintableTexture, bool preview)
		{
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x124708C", Offset = "0x124708C", VA = "0x124708C")]
		private void Calculate(RenderTexture renderTexture, RenderTexture temporary, int scale)
		{
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x12474C8", Offset = "0x12474C8", VA = "0x12474C8")]
		public P3dChannelCounter()
		{
		}
	}
	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD53478", Offset = "0xD53478")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD53478", Offset = "0xD53478")]
	public class P3dColor : P3dLinkedBehaviour<P3dColor>
	{
		[Token(Token = "0x20001EF")]
		[SerializeField]
		private class Contribution
		{
			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public P3dColorCounter Counter;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int Solid;

			[Token(Token = "0x6000CD7")]
			[Address(RVA = "0x12479E8", Offset = "0x12479E8", VA = "0x12479E8")]
			public Contribution()
			{
			}
		}

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Contribution> contributions;

		[Token(Token = "0x170001FE")]
		public Color Color
		{
			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x124755C", Offset = "0x124755C", VA = "0x124755C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x1247550", Offset = "0x1247550", VA = "0x1247550")]
			set
			{
			}
		}

		[Token(Token = "0x170001FF")]
		public int Total
		{
			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x1247568", Offset = "0x1247568", VA = "0x1247568")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000200")]
		public int Solid
		{
			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x1247690", Offset = "0x1247690", VA = "0x1247690")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000201")]
		public float Ratio
		{
			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x12477BC", Offset = "0x12477BC", VA = "0x12477BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x1247804", Offset = "0x1247804", VA = "0x1247804")]
		public void Contribute(P3dColorCounter counter, int solid)
		{
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x12478D4", Offset = "0x12478D4", VA = "0x12478D4")]
		private bool TryGetContribution(P3dColorCounter counter, ref Contribution contribution)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x12479F0", Offset = "0x12479F0", VA = "0x12479F0")]
		public P3dColor()
		{
		}
	}
	[Token(Token = "0x2000136")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD534D8", Offset = "0xD534D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD534D8", Offset = "0xD534D8")]
	public class P3dColorCounter : P3dPaintableTextureMonitorMask
	{
		[Token(Token = "0x20001F0")]
		public class Contribution
		{
			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public P3dColor Color;

			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int Count;

			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float Ratio;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public byte R;

			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public byte G;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
			public byte B;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
			public byte A;

			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Stack<Contribution> Pool;

			[Token(Token = "0x6000CD8")]
			[Address(RVA = "0x1248434", Offset = "0x1248434", VA = "0x1248434")]
			public Contribution()
			{
			}
		}

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LinkedList<P3dColorCounter> Instances;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LinkedListNode<P3dColorCounter> node;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int downsampleSteps;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD567CC", Offset = "0xD567CC")]
		[SerializeField]
		private float threshold;

		[NonSerialized]
		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<Contribution> contributions;

		[Token(Token = "0x17000202")]
		public int DownsampleSteps
		{
			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0x1247A48", Offset = "0x1247A48", VA = "0x1247A48")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0x1247A40", Offset = "0x1247A40", VA = "0x1247A40")]
			set
			{
			}
		}

		[Token(Token = "0x17000203")]
		public float Threshold
		{
			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0x1247A58", Offset = "0x1247A58", VA = "0x1247A58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0x1247A50", Offset = "0x1247A50", VA = "0x1247A50")]
			set
			{
			}
		}

		[Token(Token = "0x17000204")]
		public List<Contribution> Contributions
		{
			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0x1247A60", Offset = "0x1247A60", VA = "0x1247A60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x1247A68", Offset = "0x1247A68", VA = "0x1247A68", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x1247B00", Offset = "0x1247B00", VA = "0x1247B00", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x1247D50", Offset = "0x1247D50", VA = "0x1247D50", Slot = "7")]
		protected override void UpdateMonitor(P3dPaintableTexture paintableTexture, bool preview)
		{
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x1247E54", Offset = "0x1247E54", VA = "0x1247E54")]
		private void Calculate(RenderTexture renderTexture, RenderTexture temporary, int scale)
		{
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x1248340", Offset = "0x1248340", VA = "0x1248340")]
		private void ClearContributions()
		{
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x12481B4", Offset = "0x12481B4", VA = "0x12481B4")]
		private void PrepareContributions()
		{
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x1247BA0", Offset = "0x1247BA0", VA = "0x1247BA0")]
		private void Contribute(int scale)
		{
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x124843C", Offset = "0x124843C", VA = "0x124843C")]
		public P3dColorCounter()
		{
		}
	}
	[Token(Token = "0x2000137")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD53548", Offset = "0xD53548")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD53548", Offset = "0xD53548")]
	public class P3dGraduallyFade : MonoBehaviour
	{
		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private P3dPaintableTexture paintableTexture;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private P3dBlendMode blendMode;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Texture texture;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD5684C", Offset = "0xD5684C")]
		[SerializeField]
		private float threshold;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float speed;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float counter;

		[Token(Token = "0x17000205")]
		public P3dPaintableTexture PaintableTexture
		{
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x12485A8", Offset = "0x12485A8", VA = "0x12485A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x12485A0", Offset = "0x12485A0", VA = "0x12485A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000206")]
		public P3dBlendMode BlendMode
		{
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x12485BC", Offset = "0x12485BC", VA = "0x12485BC")]
			get
			{
				return default(P3dBlendMode);
			}
			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x12485B0", Offset = "0x12485B0", VA = "0x12485B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000207")]
		public Texture Texture
		{
			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0x12485D0", Offset = "0x12485D0", VA = "0x12485D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x12485C8", Offset = "0x12485C8", VA = "0x12485C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000208")]
		public Color Color
		{
			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0x12485E4", Offset = "0x12485E4", VA = "0x12485E4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x12485D8", Offset = "0x12485D8", VA = "0x12485D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000209")]
		public float Threshold
		{
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x12485F8", Offset = "0x12485F8", VA = "0x12485F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x12485F0", Offset = "0x12485F0", VA = "0x12485F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700020A")]
		public float Speed
		{
			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x1248608", Offset = "0x1248608", VA = "0x1248608")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0x1248600", Offset = "0x1248600", VA = "0x1248600")]
			set
			{
			}
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x1248610", Offset = "0x1248610", VA = "0x1248610", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x124894C", Offset = "0x124894C", VA = "0x124894C")]
		public P3dGraduallyFade()
		{
		}
	}
}
namespace Array2DEditor
{
	[Token(Token = "0x2000138")]
	public abstract class Array2D<T> : ScriptableObject
	{
		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Vector2Int gridSize;

		[Token(Token = "0x1700020B")]
		public Vector2Int GridSize
		{
			[Token(Token = "0x6000AFC")]
			get
			{
				return default(Vector2Int);
			}
		}

		[Token(Token = "0x6000AFD")]
		protected abstract CellRow<T> GetCellRow(int idx);

		[Token(Token = "0x6000AFE")]
		public T[,] GetCells()
		{
			return null;
		}

		[Token(Token = "0x6000AFF")]
		protected Array2D()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000139")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xD535A8", Offset = "0xD535A8")]
	public class CellRow<T>
	{
		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T[] row;

		[Token(Token = "0x1700020C")]
		public T Item
		{
			[Token(Token = "0x6000B00")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x6000B01")]
		public CellRow()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200013A")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xD535E0", Offset = "0xD535E0")]
	public class Array2DBool : Array2D<bool>
	{
		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CellRowBool[] cells;

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x123925C", Offset = "0x123925C", VA = "0x123925C", Slot = "4")]
		protected override CellRow<bool> GetCellRow(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x1239298", Offset = "0x1239298", VA = "0x1239298")]
		public Array2DBool()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200013B")]
	public class CellRowBool : CellRow<bool>
	{
		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x1239590", Offset = "0x1239590", VA = "0x1239590")]
		public CellRowBool()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200013C")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xD5362C", Offset = "0xD5362C")]
	public class Array2DExampleEnum : Array2D<Enums.ExampleEnum>
	{
		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CellRowExampleEnum[] cells;

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x1239300", Offset = "0x1239300", VA = "0x1239300", Slot = "4")]
		protected override CellRow<Enums.ExampleEnum> GetCellRow(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x123933C", Offset = "0x123933C", VA = "0x123933C")]
		public Array2DExampleEnum()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200013D")]
	public class CellRowExampleEnum : CellRow<Enums.ExampleEnum>
	{
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x12395E0", Offset = "0x12395E0", VA = "0x12395E0")]
		public CellRowExampleEnum()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200013E")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xD53678", Offset = "0xD53678")]
	public class Array2DFloat : Array2D<float>
	{
		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CellRowFloat[] cells;

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x12393A4", Offset = "0x12393A4", VA = "0x12393A4", Slot = "4")]
		protected override CellRow<float> GetCellRow(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x12393E0", Offset = "0x12393E0", VA = "0x12393E0")]
		public Array2DFloat()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200013F")]
	public class CellRowFloat : CellRow<float>
	{
		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x1239630", Offset = "0x1239630", VA = "0x1239630")]
		public CellRowFloat()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000140")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xD536C4", Offset = "0xD536C4")]
	public class Array2DInt : Array2D<int>
	{
		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CellRowInt[] cells;

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x1239448", Offset = "0x1239448", VA = "0x1239448", Slot = "4")]
		protected override CellRow<int> GetCellRow(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x1239484", Offset = "0x1239484", VA = "0x1239484")]
		public Array2DInt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000141")]
	public class CellRowInt : CellRow<int>
	{
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x1239680", Offset = "0x1239680", VA = "0x1239680")]
		public CellRowInt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000142")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xD53710", Offset = "0xD53710")]
	public class Array2DString : Array2D<string>
	{
		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CellRowString[] cells;

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x12394EC", Offset = "0x12394EC", VA = "0x12394EC", Slot = "4")]
		protected override CellRow<string> GetCellRow(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x1239528", Offset = "0x1239528", VA = "0x1239528")]
		public Array2DString()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000143")]
	public class CellRowString : CellRow<string>
	{
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x12396D0", Offset = "0x12396D0", VA = "0x12396D0")]
		public CellRowString()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public static class Consts
	{
		[Token(Token = "0x400065F")]
		public const int defaultGridSize = 3;
	}
	[Token(Token = "0x2000145")]
	public class Enums
	{
		[Token(Token = "0x20001F1")]
		public enum ExampleEnum
		{
			[Token(Token = "0x40008F7")]
			Empty,
			[Token(Token = "0x40008F8")]
			Moving,
			[Token(Token = "0x40008F9")]
			Normal
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x1239720", Offset = "0x1239720", VA = "0x1239720")]
		public Enums()
		{
		}
	}
}
