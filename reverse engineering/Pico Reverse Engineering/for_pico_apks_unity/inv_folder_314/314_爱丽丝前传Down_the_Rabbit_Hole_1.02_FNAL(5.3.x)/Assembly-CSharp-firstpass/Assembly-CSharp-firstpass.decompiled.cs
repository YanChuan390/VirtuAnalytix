using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cortopia.BE.Runtime.Actions;
using Cortopia.BE.Runtime.Actions.Connectors;
using Cortopia.BE.Runtime.Actions.Interfaces;
using Cortopia.BE.Runtime.Components.Senses.Hearing;
using Cortopia.BE.Runtime.Components.Senses.Hearing.Collections;
using Cortopia.BE.Runtime.Components.Senses.Sight;
using Cortopia.BE.Runtime.Components.Senses.Sight.Collections;
using Cortopia.BE.Runtime.Events;
using Cortopia.BE.Runtime.Events.ActionEvents;
using Cortopia.BE.Runtime.Nodes;
using Cortopia.BE.Runtime.Nodes.Properties;
using Cortopia.BE.Runtime.Transition;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.Timeline;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6DE4D0", Offset = "0x6DE4D0")]
public class DynamicBone : MonoBehaviour
{
	[Token(Token = "0x200009D")]
	public enum UpdateMode
	{
		[Token(Token = "0x4000279")]
		Normal,
		[Token(Token = "0x400027A")]
		AnimatePhysics,
		[Token(Token = "0x400027B")]
		UnscaledTime
	}

	[Token(Token = "0x200009E")]
	public enum FreezeAxis
	{
		[Token(Token = "0x400027D")]
		None,
		[Token(Token = "0x400027E")]
		X,
		[Token(Token = "0x400027F")]
		Y,
		[Token(Token = "0x4000280")]
		Z
	}

	[Token(Token = "0x200009F")]
	private class Particle
	{
		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform m_Transform;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_ParentIndex;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m_Damping;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m_Elasticity;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m_Stiffness;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_Inert;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_Radius;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_BoneLength;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 m_Position;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 m_PrevPosition;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 m_EndOffset;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 m_InitLocalPosition;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion m_InitLocalRotation;

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xBA2EF8", Offset = "0xBA2EF8", VA = "0xBA2EF8")]
		public Particle()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform m_Root;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_UpdateRate;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UpdateMode m_UpdateMode;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6DEE3C", Offset = "0x6DEE3C")]
	public float m_Damping;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve m_DampingDistrib;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6DEE54", Offset = "0x6DEE54")]
	public float m_Elasticity;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve m_ElasticityDistrib;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6DEE6C", Offset = "0x6DEE6C")]
	public float m_Stiffness;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve m_StiffnessDistrib;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6DEE84", Offset = "0x6DEE84")]
	public float m_Inert;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AnimationCurve m_InertDistrib;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float m_Radius;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AnimationCurve m_RadiusDistrib;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float m_EndLength;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector3 m_EndOffset;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector3 m_Gravity;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public Vector3 m_Force;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<DynamicBoneColliderBase> m_Colliders;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<Transform> m_Exclusions;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public FreezeAxis m_FreezeAxis;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public bool m_DistantDisable;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform m_ReferenceObject;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float m_DistanceToObject;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private Vector3 m_LocalGravity;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Vector3 m_ObjectMove;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private Vector3 m_ObjectPrevPosition;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float m_BoneTotalLength;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float m_ObjectScale;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float m_Time;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float m_Weight;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private bool m_DistantDisabled;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<Particle> m_Particles;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xB9FE90", Offset = "0xB9FE90", VA = "0xB9FE90")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xBA0054", Offset = "0xBA0054", VA = "0xBA0054")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xBA00A8", Offset = "0xBA00A8", VA = "0xBA00A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xBA00D8", Offset = "0xBA00D8", VA = "0xBA00D8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xBA0084", Offset = "0xBA0084", VA = "0xBA0084")]
	private void PreUpdate()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xBA0138", Offset = "0xBA0138", VA = "0xBA0138")]
	private void CheckDistance()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xBA08FC", Offset = "0xBA08FC", VA = "0xBA08FC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xBA0900", Offset = "0xBA0900", VA = "0xBA0900")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xBA0904", Offset = "0xBA0904", VA = "0xBA0904")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xBA0A20", Offset = "0xBA0A20", VA = "0xBA0A20")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xBA0C18", Offset = "0xBA0C18", VA = "0xBA0C18")]
	public void SetWeight(float w)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xBA0C74", Offset = "0xBA0C74", VA = "0xBA0C74")]
	public float GetWeight()
	{
		return default(float);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xBA0358", Offset = "0xBA0358", VA = "0xBA0358")]
	private void UpdateDynamicBones(float t)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xB9FE94", Offset = "0xB9FE94", VA = "0xB9FE94")]
	private void SetupParticles()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xBA2314", Offset = "0xBA2314", VA = "0xBA2314")]
	private void AppendParticles(Transform b, int parentIndex, float boneLength)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xBA2AFC", Offset = "0xBA2AFC", VA = "0xBA2AFC")]
	public void UpdateParameters()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xBA05C8", Offset = "0xBA05C8", VA = "0xBA05C8")]
	private void InitTransforms()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xBA0738", Offset = "0xBA0738", VA = "0xBA0738")]
	private void ResetParticlesPosition()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xBA0C7C", Offset = "0xBA0C7C", VA = "0xBA0C7C")]
	private void UpdateParticles1()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xBA1014", Offset = "0xBA1014", VA = "0xBA1014")]
	private void UpdateParticles2()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xBA18A0", Offset = "0xBA18A0", VA = "0xBA18A0")]
	private void SkipUpdateParticles()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xBA2FD8", Offset = "0xBA2FD8", VA = "0xBA2FD8")]
	private static Vector3 MirrorVector(Vector3 v, Vector3 axis)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xBA1FA0", Offset = "0xBA1FA0", VA = "0xBA1FA0")]
	private void ApplyParticlesToTransforms()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xBA30B8", Offset = "0xBA30B8", VA = "0xBA30B8")]
	public DynamicBone()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6DE508", Offset = "0x6DE508")]
public class DynamicBoneCollider : DynamicBoneColliderBase
{
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float m_Radius;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float m_Height;

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xBA31D8", Offset = "0xBA31D8", VA = "0xBA31D8")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xBA3270", Offset = "0xBA3270", VA = "0xBA3270", Slot = "4")]
	public override void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xBA34CC", Offset = "0xBA34CC", VA = "0xBA34CC")]
	private static void OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xBA3660", Offset = "0xBA3660", VA = "0xBA3660")]
	private static void InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xBA3804", Offset = "0xBA3804", VA = "0xBA3804")]
	private static void OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xBA3C40", Offset = "0xBA3C40", VA = "0xBA3C40")]
	private static void InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xBA4050", Offset = "0xBA4050", VA = "0xBA4050")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xBA423C", Offset = "0xBA423C", VA = "0xBA423C")]
	public DynamicBoneCollider()
	{
	}
}
[Token(Token = "0x2000004")]
public class DynamicBoneColliderBase : MonoBehaviour
{
	[Token(Token = "0x20000A0")]
	public enum Direction
	{
		[Token(Token = "0x400028F")]
		X,
		[Token(Token = "0x4000290")]
		Y,
		[Token(Token = "0x4000291")]
		Z
	}

	[Token(Token = "0x20000A1")]
	public enum Bound
	{
		[Token(Token = "0x4000293")]
		Outside,
		[Token(Token = "0x4000294")]
		Inside
	}

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Direction m_Direction;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 m_Center;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Bound m_Bound;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xBA42C8", Offset = "0xBA42C8", VA = "0xBA42C8", Slot = "4")]
	public virtual void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xBA4248", Offset = "0xBA4248", VA = "0xBA4248")]
	public DynamicBoneColliderBase()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6DE540", Offset = "0x6DE540")]
public class DynamicBonePlaneCollider : DynamicBoneColliderBase
{
	[Token(Token = "0x6000023")]
	[Address(RVA = "0xBA42CC", Offset = "0xBA42CC", VA = "0xBA42CC")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xBA42D0", Offset = "0xBA42D0", VA = "0xBA42D0", Slot = "4")]
	public override void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xBA4500", Offset = "0xBA4500", VA = "0xBA4500")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xBA4714", Offset = "0xBA4714", VA = "0xBA4714")]
	public DynamicBonePlaneCollider()
	{
	}
}
namespace UnityEngine.AI
{
	[Token(Token = "0x2000006")]
	[Flags]
	public enum NavMeshAreas
	{
		[Token(Token = "0x4000027")]
		Walkable = 1,
		[Token(Token = "0x4000028")]
		NotWalkable = 2,
		[Token(Token = "0x4000029")]
		Jump = 4,
		[Token(Token = "0x400002A")]
		MainCharacter = 8,
		[Token(Token = "0x400002B")]
		Companion = 0x10,
		[Token(Token = "0x400002C")]
		Transition = 0x20
	}
	[Token(Token = "0x2000007")]
	public struct AreaMask
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEE9C", Offset = "0x6DEE9C")]
		private readonly int <Value>k__BackingField;

		[Token(Token = "0x17000001")]
		public int Value
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x781094", Offset = "0x781094", VA = "0x781094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF8A4", Offset = "0x6DF8A4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000002")]
		public NavMeshAreas Enum
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x78109C", Offset = "0x78109C", VA = "0x78109C")]
			get
			{
				return default(NavMeshAreas);
			}
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x7810A4", Offset = "0x7810A4", VA = "0x7810A4")]
		public AreaMask(int value)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x7810AC", Offset = "0x7810AC", VA = "0x7810AC")]
		public AreaMask(NavMeshAreas areas)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x166AE58", Offset = "0x166AE58", VA = "0x166AE58")]
		public static implicit operator AreaMask(int value)
		{
			return default(AreaMask);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x166AE60", Offset = "0x166AE60", VA = "0x166AE60")]
		public static implicit operator AreaMask(string name)
		{
			return default(AreaMask);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x166AE84", Offset = "0x166AE84", VA = "0x166AE84")]
		public static implicit operator AreaMask(NavMeshAreas areas)
		{
			return default(AreaMask);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x166AE8C", Offset = "0x166AE8C", VA = "0x166AE8C")]
		public static implicit operator NavMeshAreas(AreaMask flag)
		{
			return default(NavMeshAreas);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x166AE90", Offset = "0x166AE90", VA = "0x166AE90")]
		public static implicit operator int(AreaMask flag)
		{
			return default(int);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x166AE94", Offset = "0x166AE94", VA = "0x166AE94")]
		public static bool operator ==(AreaMask a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x166AEC0", Offset = "0x166AEC0", VA = "0x166AEC0")]
		public static bool operator !=(AreaMask a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x166AEF0", Offset = "0x166AEF0", VA = "0x166AEF0")]
		public static int operator +(AreaMask a, AreaMask b)
		{
			return default(int);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x166AF04", Offset = "0x166AF04", VA = "0x166AF04")]
		public static int operator -(AreaMask a, AreaMask b)
		{
			return default(int);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x166AF18", Offset = "0x166AF18", VA = "0x166AF18")]
		public static int operator |(AreaMask a, AreaMask b)
		{
			return default(int);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x166AF20", Offset = "0x166AF20", VA = "0x166AF20")]
		public static int operator ~(AreaMask a)
		{
			return default(int);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x166AF28", Offset = "0x166AF28", VA = "0x166AF28")]
		public static int operator +(int a, AreaMask b)
		{
			return default(int);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x166AF30", Offset = "0x166AF30", VA = "0x166AF30")]
		public static int operator -(int a, AreaMask b)
		{
			return default(int);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x166AF38", Offset = "0x166AF38", VA = "0x166AF38")]
		public static int operator |(int a, AreaMask b)
		{
			return default(int);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x166AF40", Offset = "0x166AF40", VA = "0x166AF40")]
		public static int operator +(AreaMask a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x166AF48", Offset = "0x166AF48", VA = "0x166AF48")]
		public static int operator -(AreaMask a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x166AF50", Offset = "0x166AF50", VA = "0x166AF50")]
		public static int operator |(AreaMask a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x7810B4", Offset = "0x7810B4", VA = "0x7810B4")]
		public bool HasFlag(AreaMask flag)
		{
			return default(bool);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x7810E8", Offset = "0x7810E8", VA = "0x7810E8")]
		public bool HasFlag(int value)
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x7810F8", Offset = "0x7810F8", VA = "0x7810F8")]
		public AreaMask Add(AreaMask flag)
		{
			return default(AreaMask);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x781104", Offset = "0x781104", VA = "0x781104")]
		public AreaMask Remove(AreaMask flag)
		{
			return default(AreaMask);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x781110", Offset = "0x781110", VA = "0x781110")]
		public AreaMask Add(NavMeshAreas flags)
		{
			return default(AreaMask);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x78111C", Offset = "0x78111C", VA = "0x78111C")]
		public AreaMask Remove(NavMeshAreas flags)
		{
			return default(AreaMask);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x781128", Offset = "0x781128", VA = "0x781128")]
		public bool Equals(AreaMask other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x781138", Offset = "0x781138", VA = "0x781138", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x781140", Offset = "0x781140", VA = "0x781140", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x781148", Offset = "0x781148", VA = "0x781148", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
}
namespace I2.Loc
{
	[Token(Token = "0x2000008")]
	public static class PersistentStorage
	{
		[Token(Token = "0x20000A2")]
		public enum eFileType
		{
			[Token(Token = "0x4000296")]
			Raw,
			[Token(Token = "0x4000297")]
			Persistent,
			[Token(Token = "0x4000298")]
			Temporal,
			[Token(Token = "0x4000299")]
			Streaming
		}

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static I2CustomPersistentStorage mStorage;

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xA13DBC", Offset = "0xA13DBC", VA = "0xA13DBC")]
		public static void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xA13258", Offset = "0xA13258", VA = "0xA13258")]
		public static string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xA13458", Offset = "0xA13458", VA = "0xA13458")]
		public static void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xA131B0", Offset = "0xA131B0", VA = "0xA131B0")]
		public static bool HasSetting(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xA143E4", Offset = "0xA143E4", VA = "0xA143E4")]
		public static void ForceSaveSettings()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xA157AC", Offset = "0xA157AC", VA = "0xA157AC")]
		public static bool CanAccessFiles()
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xA1431C", Offset = "0xA1431C", VA = "0xA1431C")]
		public static bool SaveFile(eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xA130F0", Offset = "0xA130F0", VA = "0xA130F0")]
		public static string LoadFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xA13398", Offset = "0xA13398", VA = "0xA13398")]
		public static bool DeleteFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xA15B50", Offset = "0xA15B50", VA = "0xA15B50")]
		public static bool HasFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000009")]
	public abstract class I2BasePersistentStorage
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0xBB36F4", Offset = "0xBB36F4", VA = "0xBB36F4", Slot = "4")]
		public virtual void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xBB39BC", Offset = "0xBB39BC", VA = "0xBB39BC", Slot = "5")]
		public virtual string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xBB3C10", Offset = "0xBB3C10", VA = "0xBB3C10", Slot = "6")]
		public virtual void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xBB3E30", Offset = "0xBB3E30", VA = "0xBB3E30", Slot = "7")]
		public virtual void ForceSaveSettings()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xBB3E38", Offset = "0xBB3E38", VA = "0xBB3E38", Slot = "8")]
		public virtual bool HasSetting(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xBB3E44", Offset = "0xBB3E44", VA = "0xBB3E44", Slot = "9")]
		public virtual bool CanAccessFiles()
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xBB3E4C", Offset = "0xBB3E4C", VA = "0xBB3E4C")]
		private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xBB3EF8", Offset = "0xBB3EF8", VA = "0xBB3EF8", Slot = "10")]
		public virtual bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xBB41CC", Offset = "0xBB41CC", VA = "0xBB41CC", Slot = "11")]
		public virtual string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xBB448C", Offset = "0xBB448C", VA = "0xBB448C", Slot = "12")]
		public virtual bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xBB4740", Offset = "0xBB4740", VA = "0xBB4740", Slot = "13")]
		public virtual bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xBB49F4", Offset = "0xBB49F4", VA = "0xBB49F4")]
		protected I2BasePersistentStorage()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class I2CustomPersistentStorage : I2BasePersistentStorage
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0xA0A870", Offset = "0xA0A870", VA = "0xA0A870")]
		public I2CustomPersistentStorage()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class BaseSpecializationManager
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string[] mSpecializations;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> mSpecializationsFallbacks;

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xBA5598", Offset = "0xBA5598", VA = "0xBA5598", Slot = "4")]
		public virtual void InitializeSpecializations()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xBA5B8C", Offset = "0xBA5B8C", VA = "0xBA5B8C", Slot = "5")]
		public virtual string GetCurrentSpecialization()
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xBA5BF0", Offset = "0xBA5BF0", VA = "0xBA5BF0", Slot = "6")]
		public virtual string GetFallbackSpecialization(string specialization)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xBA5C98", Offset = "0xBA5C98", VA = "0xBA5C98")]
		public BaseSpecializationManager()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class SpecializationManager : BaseSpecializationManager
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SpecializationManager Singleton;

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1667670", Offset = "0x1667670", VA = "0x1667670")]
		private SpecializationManager()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x16676A0", Offset = "0x16676A0", VA = "0x16676A0")]
		public static string GetSpecializedText(string text, [Optional] string specialization)
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1667910", Offset = "0x1667910", VA = "0x1667910")]
		public static string SetSpecializedText(string text, string newText, string specialization)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1667C44", Offset = "0x1667C44", VA = "0x1667C44")]
		public static string SetSpecializedText(Dictionary<string, string> specializations)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1667A20", Offset = "0x1667A20", VA = "0x1667A20")]
		public static Dictionary<string, string> GetSpecializations(string text, [Optional] Dictionary<string, string> buffer)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1668018", Offset = "0x1668018", VA = "0x1668018")]
		public static void AppendSpecializations(string text, [Optional] List<string> list)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class EventCallback
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonoBehaviour Target;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string MethodName;

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xBA60B4", Offset = "0xBA60B4", VA = "0xBA60B4")]
		public void Execute([Optional] UnityEngine.Object Sender)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xBA6140", Offset = "0xBA6140", VA = "0xBA6140")]
		public bool HasCallback()
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xBA61D4", Offset = "0xBA61D4", VA = "0xBA61D4")]
		public EventCallback()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public enum ePluralType
	{
		[Token(Token = "0x4000035")]
		Zero,
		[Token(Token = "0x4000036")]
		One,
		[Token(Token = "0x4000037")]
		Two,
		[Token(Token = "0x4000038")]
		Few,
		[Token(Token = "0x4000039")]
		Many,
		[Token(Token = "0x400003A")]
		Plural
	}
	[Token(Token = "0x200000F")]
	public static class GoogleLanguages
	{
		[Token(Token = "0x20000A3")]
		public struct LanguageCodeDef
		{
			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Code;

			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string GoogleCode;

			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool HasJoinedWords;

			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int PluralRule;
		}

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<string, LanguageCodeDef> mLanguageDef;

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xBA6234", Offset = "0xBA6234", VA = "0xBA6234")]
		public static string GetLanguageCode(string Filter, bool ShowWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xBA66F0", Offset = "0xBA66F0", VA = "0xBA66F0")]
		public static List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xBA6500", Offset = "0xBA6500", VA = "0xBA6500")]
		private static bool LanguageMatchesFilter(string Language, string[] Filters)
		{
			return default(bool);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xBA6C68", Offset = "0xBA6C68", VA = "0xBA6C68")]
		public static string GetFormatedLanguageName(string Language)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xBA6DCC", Offset = "0xBA6DCC", VA = "0xBA6DCC")]
		public static string GetCodedLanguage(string Language, string code)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xBA6E94", Offset = "0xBA6E94", VA = "0xBA6E94")]
		public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xBA7034", Offset = "0xBA7034", VA = "0xBA7034")]
		public static string GetGoogleLanguageCode(string InternationalCode)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xBA7238", Offset = "0xBA7238", VA = "0xBA7238")]
		public static string GetLanguageName(string code, bool useParenthesesForRegion = false, bool allowDiscardRegion = true)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xBA7560", Offset = "0xBA7560", VA = "0xBA7560")]
		public static List<string> GetAllInternationalCodes()
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xBA7748", Offset = "0xBA7748", VA = "0xBA7748")]
		public static bool LanguageCode_HasJoinedWord(string languageCode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xBA7938", Offset = "0xBA7938", VA = "0xBA7938")]
		private static int GetPluralRule(string langCode)
		{
			return default(int);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xBA7B48", Offset = "0xBA7B48", VA = "0xBA7B48")]
		public static bool LanguageHasPluralType(string langCode, string pluralType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xBA7CCC", Offset = "0xBA7CCC", VA = "0xBA7CCC")]
		public static ePluralType GetPluralType(string langCode, int n)
		{
			return default(ePluralType);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xBA83DC", Offset = "0xBA83DC", VA = "0xBA83DC")]
		public static int GetPluralTestNumber(string langCode, ePluralType pluralType)
		{
			return default(int);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xBA83C4", Offset = "0xBA83C4", VA = "0xBA83C4")]
		private static bool inRange(int amount, int min, int max)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000010")]
	public static class GoogleTranslation
	{
		[Token(Token = "0x20000A4")]
		public delegate void fnOnTranslated(string Translation, string Error);

		[Token(Token = "0x20000A5")]
		public delegate void fnOnTranslationReady(Dictionary<string, TranslationQuery> dict, string error);

		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE8EC", Offset = "0x6DE8EC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public fnOnTranslated OnTranslationReady;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dictionary<string, TranslationQuery> queries;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string LanguageCodeTo;

			[Token(Token = "0x600052B")]
			[Address(RVA = "0xBAEAE4", Offset = "0xBAEAE4", VA = "0xBAEAE4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0xBB2360", Offset = "0xBB2360", VA = "0xBB2360")]
			internal void <Translate>b__0(Dictionary<string, TranslationQuery> results, string error)
			{
			}
		}

		[Token(Token = "0x20000A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE8FC", Offset = "0x6DE8FC")]
		private sealed class <WaitForTranslations>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x1700005E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000530")]
				[Address(RVA = "0xBB262C", Offset = "0xBB262C", VA = "0xBB262C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000532")]
				[Address(RVA = "0xBB269C", Offset = "0xBB269C", VA = "0xBB269C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600052D")]
			[Address(RVA = "0xBB02B0", Offset = "0xBB02B0", VA = "0xBB02B0")]
			[DebuggerHidden]
			public <WaitForTranslations>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0xBB245C", Offset = "0xBB245C", VA = "0xBB245C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0xBB2460", Offset = "0xBB2460", VA = "0xBB2460", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0xBB2634", Offset = "0xBB2634", VA = "0xBB2634", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<UnityWebRequest> mCurrentTranslations;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<TranslationJob> mTranslationJobs;

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xBAE7C4", Offset = "0xBAE7C4", VA = "0xBAE7C4")]
		public static bool CanTranslate()
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xBAE890", Offset = "0xBAE890", VA = "0xBAE890")]
		public static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, fnOnTranslated OnTranslationReady)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xBAF528", Offset = "0xBAF528", VA = "0xBAF528")]
		public static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xBAF494", Offset = "0xBAF494", VA = "0xBAF494")]
		public static void Translate(Dictionary<string, TranslationQuery> requests, fnOnTranslationReady OnTranslationReady, bool usePOST = true)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xBAFB70", Offset = "0xBAFB70", VA = "0xBAFB70")]
		public static bool ForceTranslate(Dictionary<string, TranslationQuery> requests, bool usePOST = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xBAFBFC", Offset = "0xBAFBFC", VA = "0xBAFBFC")]
		public static List<string> ConvertTranslationRequest(Dictionary<string, TranslationQuery> requests, bool encodeGET)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xBAFA78", Offset = "0xBAFA78", VA = "0xBAFA78")]
		private static void AddTranslationJob(TranslationJob job)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xBB0250", Offset = "0xBB0250", VA = "0xBB0250")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DF8B4", Offset = "0x6DF8B4")]
		private static IEnumerator WaitForTranslations()
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xBB02DC", Offset = "0xBB02DC", VA = "0xBB02DC")]
		public static string ParseTranslationResult(string html, Dictionary<string, TranslationQuery> requests)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xBB0ABC", Offset = "0xBB0ABC", VA = "0xBB0ABC")]
		public static bool IsTranslating()
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xBB0BA0", Offset = "0xBB0BA0", VA = "0xBB0BA0")]
		public static void CancelCurrentGoogleTranslations()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xBAF26C", Offset = "0xBAF26C", VA = "0xBAF26C")]
		public static void CreateQueries(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xBB0D60", Offset = "0xBB0D60", VA = "0xBB0D60")]
		private static void CreateQueries_Plurals(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xBAF668", Offset = "0xBAF668", VA = "0xBAF668")]
		public static void AddQuery(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xBB1924", Offset = "0xBB1924", VA = "0xBB1924")]
		private static string GetTranslation(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xBB0828", Offset = "0xBB0828", VA = "0xBB0828")]
		private static TranslationQuery FindQueryFromOrigText(string origText, Dictionary<string, TranslationQuery> dict)
		{
			return default(TranslationQuery);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xBB1058", Offset = "0xBB1058", VA = "0xBB1058")]
		public static bool HasParameters(string text)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xBB12A0", Offset = "0xBB12A0", VA = "0xBB12A0")]
		public static string GetPluralParameter(string text, bool forceTag)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xBB10FC", Offset = "0xBB10FC", VA = "0xBB10FC")]
		public static string GetPluralText(string text, string pluralType)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xBB1A28", Offset = "0xBB1A28", VA = "0xBB1A28")]
		private static int FindClosingTag(string tag, MatchCollection matches, int startIndex)
		{
			return default(int);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xBB0A18", Offset = "0xBB0A18", VA = "0xBB0A18")]
		private static string GetGoogleNoTranslateTag(int tagNumber)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xBB13B0", Offset = "0xBB13B0", VA = "0xBB13B0")]
		private static void ParseNonTranslatableElements(ref TranslationQuery query)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xBAF940", Offset = "0xBAF940", VA = "0xBAF940")]
		public static string GetQueryResult(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xBB1B24", Offset = "0xBB1B24", VA = "0xBB1B24")]
		public static string RebuildTranslation(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xBB1DDC", Offset = "0xBB1DDC", VA = "0xBB1DDC")]
		private static string RebuildTranslation_Plural(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xBB219C", Offset = "0xBB219C", VA = "0xBB219C")]
		public static string UppercaseFirst(string s)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xBB0184", Offset = "0xBB0184", VA = "0xBB0184")]
		public static string TitleCase(string s)
		{
			return null;
		}
	}
	[Token(Token = "0x2000011")]
	public struct TranslationQuery
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string OrigText;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Text;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string LanguageCode;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] TargetLanguagesCode;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] Results;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Tags;
	}
	[Token(Token = "0x2000012")]
	public class TranslationJob : IDisposable
	{
		[Token(Token = "0x20000A8")]
		public enum eJobState
		{
			[Token(Token = "0x40002A5")]
			Running,
			[Token(Token = "0x40002A6")]
			Succeeded,
			[Token(Token = "0x40002A7")]
			Failed
		}

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public eJobState mJobState;

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1669314", Offset = "0x1669314", VA = "0x1669314", Slot = "5")]
		public virtual eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x166931C", Offset = "0x166931C", VA = "0x166931C", Slot = "6")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1669320", Offset = "0x1669320", VA = "0x1669320")]
		public TranslationJob()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class TranslationJob_WWW : TranslationJob
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityWebRequest www;

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x166AE08", Offset = "0x166AE08", VA = "0x166AE08", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x16693C8", Offset = "0x16693C8", VA = "0x16693C8")]
		public TranslationJob_WWW()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class TranslationJob_GET : TranslationJob_WWW
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<string> mQueries;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mErrorMessage;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1669328", Offset = "0x1669328", VA = "0x1669328")]
		public TranslationJob_GET(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x16693D0", Offset = "0x16693D0", VA = "0x16693D0")]
		private void ExecuteNextQuery()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1669528", Offset = "0x1669528", VA = "0x1669528", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x16695F8", Offset = "0x16695F8", VA = "0x16695F8")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class TranslationJob_Main : TranslationJob
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TranslationJob_WEB mWeb;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TranslationJob_POST mPost;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TranslationJob_GET mGet;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mErrorMessage;

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1669720", Offset = "0x1669720", VA = "0x1669720")]
		public TranslationJob_Main(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1669918", Offset = "0x1669918", VA = "0x1669918", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1669AE8", Offset = "0x1669AE8", VA = "0x1669AE8", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class TranslationJob_POST : TranslationJob_WWW
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x16697A4", Offset = "0x16697A4", VA = "0x16697A4")]
		public TranslationJob_POST(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1669B34", Offset = "0x1669B34", VA = "0x1669B34", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1669BF4", Offset = "0x1669BF4", VA = "0x1669BF4")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class TranslationJob_WEB : TranslationJob_WWW
	{
		[Serializable]
		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE90C", Offset = "0x6DE90C")]
		private sealed class <>c
		{
			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<KeyValuePair<string, string>> <>9__8_0;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static MatchEvaluator <>9__12_0;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static MatchEvaluator <>9__12_1;

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x166ABDC", Offset = "0x166ABDC", VA = "0x166ABDC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x166ABE4", Offset = "0x166ABE4", VA = "0x166ABE4")]
			internal int <FindAllQueries>b__8_0(KeyValuePair<string, string> a, KeyValuePair<string, string> b)
			{
				return default(int);
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x166AC74", Offset = "0x166AC74", VA = "0x166AC74")]
			internal string <ParseTranslationResult>b__12_0(Match match)
			{
				return null;
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x166AD40", Offset = "0x166AD40", VA = "0x166AD40")]
			internal string <ParseTranslationResult>b__12_1(Match match)
			{
				return null;
			}
		}

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mErrorMessage;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string mCurrentBatch_ToLanguageCode;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mCurrentBatch_FromLanguageCode;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<string> mCurrentBatch_Text;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<KeyValuePair<string, string>> mQueries;

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1669D08", Offset = "0x1669D08", VA = "0x1669D08")]
		public TranslationJob_WEB(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1669D4C", Offset = "0x1669D4C", VA = "0x1669D4C")]
		private void FindAllQueries()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x166A0A8", Offset = "0x166A0A8", VA = "0x166A0A8")]
		private void ExecuteNextBatch()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x166A48C", Offset = "0x166A48C", VA = "0x166A48C", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x166A55C", Offset = "0x166A55C", VA = "0x166A55C")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x166A690", Offset = "0x166A690", VA = "0x166A690")]
		private string ParseTranslationResult(string html, string OriginalText)
		{
			return null;
		}
	}
	[Token(Token = "0x2000018")]
	public enum eLanguageDataFlags
	{
		[Token(Token = "0x400005A")]
		DISABLED = 1,
		[Token(Token = "0x400005B")]
		KEEP_LOADED = 2,
		[Token(Token = "0x400005C")]
		NOT_LOADED = 4
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public class LanguageData
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Code;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public byte Flags;

		[NonSerialized]
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Compressed;

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xA0BB80", Offset = "0xA0BB80", VA = "0xA0BB80")]
		public bool IsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xA0BB90", Offset = "0xA0BB90", VA = "0xA0BB90")]
		public void SetEnabled(bool bEnabled)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xA0BBAC", Offset = "0xA0BBAC", VA = "0xA0BBAC")]
		public bool IsLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xA0BBBC", Offset = "0xA0BBBC", VA = "0xA0BBBC")]
		public bool CanBeUnloaded()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xA0BBCC", Offset = "0xA0BBCC", VA = "0xA0BBCC")]
		public void SetLoaded(bool loaded)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xA0BBEC", Offset = "0xA0BBEC", VA = "0xA0BBEC")]
		public void SetCanBeUnLoaded(bool allowUnloading)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xA0BC0C", Offset = "0xA0BC0C", VA = "0xA0BC0C")]
		public LanguageData()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6DE588", Offset = "0x6DE588")]
	[ExecuteInEditMode]
	public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
	{
		[Token(Token = "0x20000AA")]
		public delegate void fnOnSourceUpdated(LanguageSourceData source, bool ReceivedNewData, string errorMsg);

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int version;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool NeverDestroy;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool GoogleLiveSyncIsUptoDate;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<UnityEngine.Object> Assets;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Google_WebServiceURL;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<TermData> mTerms;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool CaseInsensitiveTerms;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public LanguageSourceData.MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string mTerm_AppName;

		[Token(Token = "0x17000003")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0xA0BC14", Offset = "0xA0BC14", VA = "0xA0BC14", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xA0BC1C", Offset = "0xA0BC1C", VA = "0xA0BC1C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0xA0BC24", Offset = "0xA0BC24", VA = "0xA0BC24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF918", Offset = "0x6DF918")]
			add
			{
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0xA0BD10", Offset = "0xA0BD10", VA = "0xA0BD10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF928", Offset = "0x6DF928")]
			remove
			{
			}
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xA0BDFC", Offset = "0xA0BDFC", VA = "0xA0BDFC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xA0BEC0", Offset = "0xA0BEC0", VA = "0xA0BEC0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xA0BF54", Offset = "0xA0BF54", VA = "0xA0BF54")]
		public string GetSourceName()
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xA0C068", Offset = "0xA0C068", VA = "0xA0C068", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xA0C074", Offset = "0xA0C074", VA = "0xA0C074", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xA0C748", Offset = "0xA0C748", VA = "0xA0C748")]
		public LanguageSource()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x6DE5D4", Offset = "0x6DE5D4")]
	public class LanguageSourceAsset : ScriptableObject, ILanguageSource
	{
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x17000004")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0xA0D0C4", Offset = "0xA0D0C4", VA = "0xA0D0C4", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0xA0D0CC", Offset = "0xA0D0CC", VA = "0xA0D0CC", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xA0D0D4", Offset = "0xA0D0D4", VA = "0xA0D0D4")]
		public LanguageSourceAsset()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public interface ILanguageSource
	{
		[Token(Token = "0x17000005")]
		LanguageSourceData SourceData
		{
			[Token(Token = "0x60000C0")]
			get;
			[Token(Token = "0x60000C1")]
			set;
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	[ExecuteInEditMode]
	public class LanguageSourceData
	{
		[Token(Token = "0x20000AB")]
		public enum MissingTranslationAction
		{
			[Token(Token = "0x40002AD")]
			Empty,
			[Token(Token = "0x40002AE")]
			Fallback,
			[Token(Token = "0x40002AF")]
			ShowWarning,
			[Token(Token = "0x40002B0")]
			ShowTerm
		}

		[Token(Token = "0x20000AC")]
		public enum eAllowUnloadLanguages
		{
			[Token(Token = "0x40002B2")]
			Never,
			[Token(Token = "0x40002B3")]
			OnlyInDevice,
			[Token(Token = "0x40002B4")]
			EditorAndDevice
		}

		[Token(Token = "0x20000AD")]
		public enum eGoogleUpdateFrequency
		{
			[Token(Token = "0x40002B6")]
			Always,
			[Token(Token = "0x40002B7")]
			Never,
			[Token(Token = "0x40002B8")]
			Daily,
			[Token(Token = "0x40002B9")]
			Weekly,
			[Token(Token = "0x40002BA")]
			Monthly,
			[Token(Token = "0x40002BB")]
			OnlyOnce,
			[Token(Token = "0x40002BC")]
			EveryOtherDay
		}

		[Token(Token = "0x20000AE")]
		public enum eGoogleUpdateSynchronization
		{
			[Token(Token = "0x40002BE")]
			Manual,
			[Token(Token = "0x40002BF")]
			OnSceneLoaded,
			[Token(Token = "0x40002C0")]
			AsSoonAsDownloaded
		}

		[Serializable]
		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE91C", Offset = "0x6DE91C")]
		private sealed class <>c
		{
			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<UnityEngine.Object> <>9__39_0;

			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<UnityEngine.Object, string> <>9__39_1;

			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<IGrouping<string, UnityEngine.Object>, string> <>9__39_2;

			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<IGrouping<string, UnityEngine.Object>, UnityEngine.Object> <>9__39_3;

			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Comparison<TermData> <>9__43_0;

			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Comparison<TermData> <>9__47_0;

			[Token(Token = "0x600053D")]
			[Address(RVA = "0xA16900", Offset = "0xA16900", VA = "0xA16900")]
			public <>c()
			{
			}

			[Token(Token = "0x600053E")]
			[Address(RVA = "0xA16908", Offset = "0xA16908", VA = "0xA16908")]
			internal bool <UpdateAssetDictionary>b__39_0(UnityEngine.Object x)
			{
				return default(bool);
			}

			[Token(Token = "0x600053F")]
			[Address(RVA = "0xA16974", Offset = "0xA16974", VA = "0xA16974")]
			internal string <UpdateAssetDictionary>b__39_1(UnityEngine.Object o)
			{
				return null;
			}

			[Token(Token = "0x6000540")]
			[Address(RVA = "0xA169A4", Offset = "0xA169A4", VA = "0xA169A4")]
			internal string <UpdateAssetDictionary>b__39_2(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}

			[Token(Token = "0x6000541")]
			[Address(RVA = "0xA16A54", Offset = "0xA16A54", VA = "0xA16A54")]
			internal UnityEngine.Object <UpdateAssetDictionary>b__39_3(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}

			[Token(Token = "0x6000542")]
			[Address(RVA = "0xA16AA4", Offset = "0xA16AA4", VA = "0xA16AA4")]
			internal int <Export_I2CSV>b__43_0(TermData a, TermData b)
			{
				return default(int);
			}

			[Token(Token = "0x6000543")]
			[Address(RVA = "0xA16AEC", Offset = "0xA16AEC", VA = "0xA16AEC")]
			internal int <Export_CSV>b__47_0(TermData a, TermData b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x20000B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE92C", Offset = "0x6DE92C")]
		private sealed class <Import_Google_Coroutine>d__65 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LanguageSourceData <>4__this;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool JustCheck;

			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x17000060")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000547")]
				[Address(RVA = "0xA16E5C", Offset = "0xA16E5C", VA = "0xA16E5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000061")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000549")]
				[Address(RVA = "0xA16ECC", Offset = "0xA16ECC", VA = "0xA16ECC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0xA13F08", Offset = "0xA13F08", VA = "0xA13F08")]
			[DebuggerHidden]
			public <Import_Google_Coroutine>d__65(int <>1__state)
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0xA16B34", Offset = "0xA16B34", VA = "0xA16B34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0xA16B38", Offset = "0xA16B38", VA = "0xA16B38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0xA16E64", Offset = "0xA16E64", VA = "0xA16E64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ILanguageSource owner;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool GoogleLiveSyncIsUptoDate;

		[NonSerialized]
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool mIsGlobalSource;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<TermData> mTerms;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool CaseInsensitiveTerms;

		[NonSerialized]
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, TermData> mDictionary;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mTerm_AppName;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string Google_WebServiceURL;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public eGoogleUpdateFrequency GoogleInEditorCheckFrequency;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public eGoogleUpdateSynchronization GoogleUpdateSynchronization;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<UnityEngine.Object> Assets;

		[NonSerialized]
		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string mDelayedGoogleData;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string EmptyCategory;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static char[] CategorySeparators;

		[Token(Token = "0x17000006")]
		public UnityEngine.Object ownerObject
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0xA0D138", Offset = "0xA0D138", VA = "0xA0D138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xA0C65C", Offset = "0xA0C65C", VA = "0xA0C65C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF938", Offset = "0x6DF938")]
			add
			{
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xA0D1BC", Offset = "0xA0D1BC", VA = "0xA0D1BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF948", Offset = "0x6DF948")]
			remove
			{
			}
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xA0BE40", Offset = "0xA0BE40", VA = "0xA0BE40")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xA0BEF0", Offset = "0xA0BEF0", VA = "0xA0BEF0")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xA0DC80", Offset = "0xA0DC80", VA = "0xA0DC80")]
		public bool IsEqualTo(LanguageSourceData Source)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xA0E324", Offset = "0xA0E324", VA = "0xA0E324")]
		internal bool ManagerHasASimilarSource()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xA0E450", Offset = "0xA0E450", VA = "0xA0E450")]
		public void ClearAllData()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xA0E51C", Offset = "0xA0E51C", VA = "0xA0E51C")]
		public bool IsGlobalSource()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xA0E524", Offset = "0xA0E524", VA = "0xA0E524")]
		public void Editor_SetDirty()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xA0D7DC", Offset = "0xA0D7DC", VA = "0xA0D7DC")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xA0E528", Offset = "0xA0E528", VA = "0xA0E528")]
		public UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xA0E618", Offset = "0xA0E618", VA = "0xA0E618")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xA0E688", Offset = "0xA0E688", VA = "0xA0E688")]
		public void AddAsset(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xA0E73C", Offset = "0xA0E73C", VA = "0xA0E73C")]
		public string Export_I2CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xA0EE4C", Offset = "0xA0EE4C", VA = "0xA0EE4C")]
		private static void AppendI2Term(StringBuilder Builder, int nLanguages, string Term, TermData termData, char Separator, string forceSpecialization)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xA0F180", Offset = "0xA0F180", VA = "0xA0F180")]
		private static void AppendI2Text(StringBuilder Builder, string text)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xA0F270", Offset = "0xA0F270", VA = "0xA0F270")]
		private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xA0F8CC", Offset = "0xA0F8CC", VA = "0xA0F8CC")]
		public string Export_CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xA10214", Offset = "0xA10214", VA = "0xA10214")]
		private static void AppendTerm(StringBuilder Builder, int nLanguages, string Term, TermData termData, string specialization, char Separator)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xA100A8", Offset = "0xA100A8", VA = "0xA100A8")]
		private static void AppendString(StringBuilder Builder, string Text, char Separator)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xA10514", Offset = "0xA10514", VA = "0xA10514")]
		private static void AppendTranslation(StringBuilder Builder, string Text, char Separator, string tags)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xA106BC", Offset = "0xA106BC", VA = "0xA106BC")]
		public UnityWebRequest Export_Google_CreateWWWcall(eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xA108C4", Offset = "0xA108C4", VA = "0xA108C4")]
		private string Export_Google_CreateData()
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xA10EE4", Offset = "0xA10EE4", VA = "0xA10EE4")]
		public string Import_CSV(string Category, string CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xA11D80", Offset = "0xA11D80", VA = "0xA11D80")]
		public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xA11014", Offset = "0xA11014", VA = "0xA11014")]
		public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xA11FC8", Offset = "0xA11FC8", VA = "0xA11FC8")]
		private bool ArrayContains(string MainText, params string[] texts)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xA124AC", Offset = "0xA124AC", VA = "0xA124AC")]
		public static eTermType GetTermType(string type)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xA12790", Offset = "0xA12790", VA = "0xA12790")]
		private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xA12A38", Offset = "0xA12A38", VA = "0xA12A38")]
		public static void FreeUnusedLanguages()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xA12C64", Offset = "0xA12C64", VA = "0xA12C64")]
		public void Import_Google_FromCache()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xA13308", Offset = "0xA13308", VA = "0xA13308")]
		private bool IsNewerVersion(string currentVersion, string newVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xA13B48", Offset = "0xA13B48", VA = "0xA13B48")]
		public void Import_Google(bool ForceUpdate, bool justCheck)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xA12ED0", Offset = "0xA12ED0", VA = "0xA12ED0")]
		private string GetSourcePlayerPrefName()
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xA13E6C", Offset = "0xA13E6C", VA = "0xA13E6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DF958", Offset = "0x6DF958")]
		private IEnumerator Import_Google_Coroutine(bool JustCheck)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xA13F34", Offset = "0xA13F34", VA = "0xA13F34")]
		private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xA13FD8", Offset = "0xA13FD8", VA = "0xA13FD8")]
		public void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xA1411C", Offset = "0xA1411C", VA = "0xA1411C")]
		public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xA14274", Offset = "0xA14274", VA = "0xA14274")]
		public bool HasGoogleSpreadsheet()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xA13500", Offset = "0xA13500", VA = "0xA13500")]
		public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xA0DEAC", Offset = "0xA0DEAC", VA = "0xA0DEAC")]
		public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true)
		{
			return default(int);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xA1467C", Offset = "0xA1467C", VA = "0xA1467C")]
		public LanguageData GetLanguageData(string language, bool AllowDiscartingRegion = true)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xA14718", Offset = "0xA14718", VA = "0xA14718")]
		public bool IsCurrentLanguage(int languageIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xA12080", Offset = "0xA12080", VA = "0xA12080")]
		public int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false)
		{
			return default(int);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xA1447C", Offset = "0xA1447C", VA = "0xA1447C")]
		public static int GetCommonWordInLanguageNames(string Language1, string Language2)
		{
			return default(int);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xA147CC", Offset = "0xA147CC", VA = "0xA147CC")]
		public static bool AreTheSameLanguage(string Language1, string Language2)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xA14868", Offset = "0xA14868", VA = "0xA14868")]
		public static string GetLanguageWithoutRegion(string Language)
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xA14934", Offset = "0xA14934", VA = "0xA14934")]
		public void AddLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xA149BC", Offset = "0xA149BC", VA = "0xA149BC")]
		public void AddLanguage(string LanguageName, string LanguageCode)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xA14B98", Offset = "0xA14B98", VA = "0xA14B98")]
		public void RemoveLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xA14F10", Offset = "0xA14F10", VA = "0xA14F10")]
		public List<string> GetLanguages(bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xA15068", Offset = "0xA15068", VA = "0xA15068")]
		public List<string> GetLanguagesCode(bool allowRegions = true, bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xA15238", Offset = "0xA15238", VA = "0xA15238")]
		public bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xA152E8", Offset = "0xA152E8", VA = "0xA152E8")]
		public void EnableLanguage(string Language, bool bEnabled)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xA153A0", Offset = "0xA153A0", VA = "0xA153A0")]
		public bool AllowUnloadingLanguages()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xA153B0", Offset = "0xA153B0", VA = "0xA153B0")]
		private string GetSavedLanguageFileName(int languageIndex)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xA15608", Offset = "0xA15608", VA = "0xA15608")]
		public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xA15AA4", Offset = "0xA15AA4", VA = "0xA15AA4")]
		public void LoadAllLanguages(bool forceLoad = false)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xA15844", Offset = "0xA15844", VA = "0xA15844")]
		public void UnloadLanguage(int languageIndex)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xA12658", Offset = "0xA12658", VA = "0xA12658")]
		public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xA1258C", Offset = "0xA1258C", VA = "0xA1258C")]
		public bool HasUnloadedLanguages()
		{
			return default(bool);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xA10CD0", Offset = "0xA10CD0", VA = "0xA10CD0")]
		public List<string> GetCategories(bool OnlyMainCategory = false, [Optional] List<string> Categories)
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xA15D3C", Offset = "0xA15D3C", VA = "0xA15D3C")]
		public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xA15C10", Offset = "0xA15C10", VA = "0xA15C10")]
		public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xA15E44", Offset = "0xA15E44", VA = "0xA15E44")]
		public static void DeserializeFullTerm(string FullTerm, out string Key, out string Category, bool OnlyMainCategory = false)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xA0D4F4", Offset = "0xA0D4F4", VA = "0xA0D4F4")]
		public void UpdateDictionary(bool force = false)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xA15FBC", Offset = "0xA15FBC", VA = "0xA15FBC")]
		public string GetTranslation(string term, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xA16068", Offset = "0xA16068", VA = "0xA16068")]
		public bool TryGetTranslation(string term, out string Translation, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xA0F584", Offset = "0xA0F584", VA = "0xA0F584")]
		private bool TryGetFallbackTranslation(TermData termData, out string Translation, int langIndex, [Optional] string overrideSpecialization, bool skipDisabled = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xA1627C", Offset = "0xA1627C", VA = "0xA1627C")]
		public TermData AddTerm(string term)
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xA0E0D4", Offset = "0xA0E0D4", VA = "0xA0E0D4")]
		public TermData GetTermData(string term, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xA16498", Offset = "0xA16498", VA = "0xA16498")]
		public bool ContainsTerm(string term)
		{
			return default(bool);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xA164B8", Offset = "0xA164B8", VA = "0xA164B8")]
		public List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xA16288", Offset = "0xA16288", VA = "0xA16288")]
		public TermData AddTerm(string NewTerm, eTermType termType, bool SaveSource = true)
		{
			return null;
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xA166D8", Offset = "0xA166D8", VA = "0xA166D8")]
		public void RemoveTerm(string term)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xA12284", Offset = "0xA12284", VA = "0xA12284")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xA0C4E0", Offset = "0xA0C4E0", VA = "0xA0C4E0")]
		public LanguageSourceData()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public enum eSpreadsheetUpdateMode
	{
		[Token(Token = "0x4000093")]
		None,
		[Token(Token = "0x4000094")]
		Replace,
		[Token(Token = "0x4000095")]
		Merge,
		[Token(Token = "0x4000096")]
		AddNewTerms
	}
	[Token(Token = "0x200001F")]
	public class LocalizationReader
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0xA1F8EC", Offset = "0xA1F8EC", VA = "0xA1F8EC")]
		public static Dictionary<string, string> ReadTextAsset(TextAsset asset)
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xA1FB4C", Offset = "0xA1FB4C", VA = "0xA1FB4C")]
		public static bool TextAsset_ReadLine(string line, out string key, out string value, out string category, out string comment, out string termType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xA1FFE4", Offset = "0xA1FFE4", VA = "0xA1FFE4")]
		public static string ReadCSVfile(string Path, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xA10F2C", Offset = "0xA10F2C", VA = "0xA10F2C")]
		public static List<string[]> ReadCSV(string Text, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xA2017C", Offset = "0xA2017C", VA = "0xA2017C")]
		private static string[] ParseCSVline(string Line, ref int iStart, char Separator)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xA203AC", Offset = "0xA203AC", VA = "0xA203AC")]
		private static void AddCSVtoken(ref List<string> list, ref string Line, int iEnd, ref int iWordStart)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xA11DC4", Offset = "0xA11DC4", VA = "0xA11DC4")]
		public static List<string[]> ReadI2CSV(string Text)
		{
			return null;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xA1FF18", Offset = "0xA1FF18", VA = "0xA1FF18")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xA20578", Offset = "0xA20578", VA = "0xA20578")]
		public static string EncodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xA1FE7C", Offset = "0xA1FE7C", VA = "0xA1FE7C")]
		public static string DecodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xA20664", Offset = "0xA20664", VA = "0xA20664")]
		public LocalizationReader()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6DE654", Offset = "0x6DE654")]
	public class Localize : MonoBehaviour
	{
		[Token(Token = "0x20000B1")]
		public enum TermModification
		{
			[Token(Token = "0x40002CE")]
			DontModify,
			[Token(Token = "0x40002CF")]
			ToUpper,
			[Token(Token = "0x40002D0")]
			ToLower,
			[Token(Token = "0x40002D1")]
			ToUpperFirst,
			[Token(Token = "0x40002D2")]
			ToTitle
		}

		[Serializable]
		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE93C", Offset = "0x6DE93C")]
		private sealed class <>c
		{
			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<UnityEngine.Object> <>9__49_0;

			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<UnityEngine.Object, string> <>9__49_1;

			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<IGrouping<string, UnityEngine.Object>, string> <>9__49_2;

			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<IGrouping<string, UnityEngine.Object>, UnityEngine.Object> <>9__49_3;

			[Token(Token = "0x600054B")]
			[Address(RVA = "0xA2177C", Offset = "0xA2177C", VA = "0xA2177C")]
			public <>c()
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0xA21784", Offset = "0xA21784", VA = "0xA21784")]
			internal bool <UpdateAssetDictionary>b__49_0(UnityEngine.Object x)
			{
				return default(bool);
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0xA217F0", Offset = "0xA217F0", VA = "0xA217F0")]
			internal string <UpdateAssetDictionary>b__49_1(UnityEngine.Object o)
			{
				return null;
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0xA21820", Offset = "0xA21820", VA = "0xA21820")]
			internal string <UpdateAssetDictionary>b__49_2(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0xA218D0", Offset = "0xA218D0", VA = "0xA218D0")]
			internal UnityEngine.Object <UpdateAssetDictionary>b__49_3(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}
		}

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string mTerm;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mTermSecondary;

		[NonSerialized]
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string FinalTerm;

		[NonSerialized]
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string FinalSecondaryTerm;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TermModification PrimaryTermModifier;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public TermModification SecondaryTermModifier;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string TermPrefix;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string TermSuffix;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool LocalizeOnAwake;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string LastLocalizedLanguage;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool IgnoreRTL;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int MaxCharactersInRTL;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool IgnoreNumbersInRTL;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool CorrectAlignmentForRTL;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public bool AddSpacesToJoinedLanguages;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool AllowLocalizedParameters;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<UnityEngine.Object> TranslatedObjects;

		[NonSerialized]
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UnityEvent LocalizeEvent;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string MainTranslation;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string SecondaryTranslation;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string CallBackTerm;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string CallBackSecondaryTerm;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Localize CurrentLocalizeComponent;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool AlwaysForceLocalize;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		public EventCallback LocalizeCallBack;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool mGUI_ShowReferences;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool mGUI_ShowTems;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		public bool mGUI_ShowCallback;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public ILocalizeTarget mLocalizeTarget;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string mLocalizeTargetName;

		[Token(Token = "0x17000007")]
		public string Term
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0xA2066C", Offset = "0xA2066C", VA = "0xA2066C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0xA20674", Offset = "0xA20674", VA = "0xA20674")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public string SecondaryTerm
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0xA206B8", Offset = "0xA206B8", VA = "0xA206B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0xA206C0", Offset = "0xA206C0", VA = "0xA206C0")]
			set
			{
			}
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xA20724", Offset = "0xA20724", VA = "0xA20724")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xA20F9C", Offset = "0xA20F9C", VA = "0xA20F9C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xA20FA4", Offset = "0xA20FA4", VA = "0xA20FA4")]
		public bool HasCallback()
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xA1D2D4", Offset = "0xA1D2D4", VA = "0xA1D2D4")]
		public void OnLocalize(bool Force = false)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xA20A78", Offset = "0xA20A78", VA = "0xA20A78")]
		public bool FindTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xA2100C", Offset = "0xA2100C", VA = "0xA2100C")]
		public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xA21188", Offset = "0xA21188", VA = "0xA21188")]
		public string GetMainTargetsText()
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xA21268", Offset = "0xA21268", VA = "0xA21268")]
		public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xA20678", Offset = "0xA20678", VA = "0xA20678")]
		public void SetTerm(string primary)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xA206D0", Offset = "0xA206D0", VA = "0xA206D0")]
		public void SetTerm(string primary, string secondary)
		{
		}

		[Token(Token = "0x600012A")]
		internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xA20768", Offset = "0xA20768", VA = "0xA20768")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x600012C")]
		internal T GetObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		private T GetTranslatedObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xA212B0", Offset = "0xA212B0", VA = "0xA212B0")]
		private void DeserializeTranslation(string translation, out string value, out string secondary)
		{
		}

		[Token(Token = "0x600012F")]
		public T FindTranslatedObject<T>(string value) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xA21404", Offset = "0xA21404", VA = "0xA21404")]
		public bool HasTranslatedObject(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xA214B0", Offset = "0xA214B0", VA = "0xA214B0")]
		public void AddTranslatedObject(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xA21564", Offset = "0xA21564", VA = "0xA21564")]
		public void SetGlobalLanguage(string Language)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xA215C8", Offset = "0xA215C8", VA = "0xA215C8")]
		public Localize()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6DE68C", Offset = "0x6DE68C")]
	public class LocalizeDropdown : MonoBehaviour
	{
		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> _Terms;

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xA21920", Offset = "0xA21920", VA = "0xA21920")]
		public void Start()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xA21AB8", Offset = "0xA21AB8", VA = "0xA21AB8")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xA21B48", Offset = "0xA21B48", VA = "0xA21B48")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xA219B8", Offset = "0xA219B8", VA = "0xA219B8")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xA21BBC", Offset = "0xA21BBC", VA = "0xA21BBC")]
		private void FillValues()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xA21D98", Offset = "0xA21D98", VA = "0xA21D98")]
		public void UpdateLocalization()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xA221E8", Offset = "0xA221E8", VA = "0xA221E8")]
		public void UpdateLocalizationTMPro()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xA22024", Offset = "0xA22024", VA = "0xA22024")]
		private void FillValuesTMPro()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xA22468", Offset = "0xA22468", VA = "0xA22468")]
		public LocalizeDropdown()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public static class LocalizationManager
	{
		[Token(Token = "0x20000B3")]
		public delegate object _GetParam(string param);

		[Token(Token = "0x20000B4")]
		public delegate void OnLocalizeCallback();

		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE94C", Offset = "0x6DE94C")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<string> Languages;

			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<string, bool> <>9__0;

			[Token(Token = "0x6000558")]
			[Address(RVA = "0xA1941C", Offset = "0xA1941C", VA = "0xA1941C")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0xA1EE80", Offset = "0xA1EE80", VA = "0xA1EE80")]
			internal bool <GetAllLanguages>b__0(string x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE95C", Offset = "0x6DE95C")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<string> Languages;

			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<string, bool> <>9__0;

			[Token(Token = "0x600055A")]
			[Address(RVA = "0xA19654", Offset = "0xA19654", VA = "0xA19654")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x600055B")]
			[Address(RVA = "0xA1EEFC", Offset = "0xA1EEFC", VA = "0xA1EEFC")]
			internal bool <GetAllLanguagesCode>b__0(string x)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE96C", Offset = "0x6DE96C")]
		private sealed class <>c
		{
			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static _GetParam <>9__41_0;

			[Token(Token = "0x600055D")]
			[Address(RVA = "0xA1EE10", Offset = "0xA1EE10", VA = "0xA1EE10")]
			public <>c()
			{
			}

			[Token(Token = "0x600055E")]
			[Address(RVA = "0xA1EE18", Offset = "0xA1EE18", VA = "0xA1EE18")]
			internal object <ApplyLocalizationParams>b__41_0(string p)
			{
				return null;
			}
		}

		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE97C", Offset = "0x6DE97C")]
		private sealed class <>c__DisplayClass42_0
		{
			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject root;

			[Token(Token = "0x600055F")]
			[Address(RVA = "0xA1A0E8", Offset = "0xA1A0E8", VA = "0xA1A0E8")]
			public <>c__DisplayClass42_0()
			{
			}

			[Token(Token = "0x6000560")]
			[Address(RVA = "0xA1EF78", Offset = "0xA1EF78", VA = "0xA1EF78")]
			internal object <ApplyLocalizationParams>b__0(string p)
			{
				return null;
			}
		}

		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE98C", Offset = "0x6DE98C")]
		private sealed class <>c__DisplayClass43_0
		{
			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<string, object> parameters;

			[Token(Token = "0x6000561")]
			[Address(RVA = "0xA1A1C4", Offset = "0xA1A1C4", VA = "0xA1A1C4")]
			public <>c__DisplayClass43_0()
			{
			}

			[Token(Token = "0x6000562")]
			[Address(RVA = "0xA1EFF0", Offset = "0xA1EFF0", VA = "0xA1EFF0")]
			internal object <ApplyLocalizationParams>b__0(string p)
			{
				return null;
			}
		}

		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE99C", Offset = "0x6DE99C")]
		private sealed class <Delayed_Import_Google>d__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LanguageSourceData source;

			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool justCheck;

			[Token(Token = "0x17000062")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000566")]
				[Address(RVA = "0xA1F2D4", Offset = "0xA1F2D4", VA = "0xA1F2D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000063")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000568")]
				[Address(RVA = "0xA1F344", Offset = "0xA1F344", VA = "0xA1F344", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000563")]
			[Address(RVA = "0xA1BC38", Offset = "0xA1BC38", VA = "0xA1BC38")]
			[DebuggerHidden]
			public <Delayed_Import_Google>d__59(int <>1__state)
			{
			}

			[Token(Token = "0x6000564")]
			[Address(RVA = "0xA1F21C", Offset = "0xA1F21C", VA = "0xA1F21C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000565")]
			[Address(RVA = "0xA1F220", Offset = "0xA1F220", VA = "0xA1F220", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000567")]
			[Address(RVA = "0xA1F2DC", Offset = "0xA1F2DC", VA = "0xA1F2DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE9AC", Offset = "0x6DE9AC")]
		private sealed class <>c__DisplayClass69_0
		{
			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ILocalizeTargetDescriptor desc;

			[Token(Token = "0x6000569")]
			[Address(RVA = "0xA1C7E8", Offset = "0xA1C7E8", VA = "0xA1C7E8")]
			public <>c__DisplayClass69_0()
			{
			}

			[Token(Token = "0x600056A")]
			[Address(RVA = "0xA1F078", Offset = "0xA1F078", VA = "0xA1F078")]
			internal bool <RegisterTarget>b__0(ILocalizeTargetDescriptor x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE9BC", Offset = "0x6DE9BC")]
		private sealed class <Coroutine_LocalizeAll>d__84 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000064")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600056E")]
				[Address(RVA = "0xA1F1A4", Offset = "0xA1F1A4", VA = "0xA1F1A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000570")]
				[Address(RVA = "0xA1F214", Offset = "0xA1F214", VA = "0xA1F214", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600056B")]
			[Address(RVA = "0xA1D2A8", Offset = "0xA1D2A8", VA = "0xA1D2A8")]
			[DebuggerHidden]
			public <Coroutine_LocalizeAll>d__84(int <>1__state)
			{
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0xA1F0C4", Offset = "0xA1F0C4", VA = "0xA1F0C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0xA1F0C8", Offset = "0xA1F0C8", VA = "0xA1F0C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0xA1F1AC", Offset = "0xA1F1AC", VA = "0xA1F1AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string mCurrentLanguage;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string mLanguageCode;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static CultureInfo mCurrentCulture;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool mChangeCultureInfo;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public static bool IsRight2Left;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public static bool HasJoinedWords;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static List<ILocalizationParamsManager> ParamManagers;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string[] LanguagesRTL;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static List<LanguageSourceData> Sources;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] GlobalSources;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static string mCurrentDeviceLanguage;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static List<ILocalizeTargetDescriptor> mLocalizeTargets;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static bool mLocalizeIsScheduled;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private static bool mLocalizeIsScheduledWithForcedValue;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public static bool HighlightLocalizedTargets;

		[Token(Token = "0x17000009")]
		public static string CurrentLanguage
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0xA12BF8", Offset = "0xA12BF8", VA = "0xA12BF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0xA17744", Offset = "0xA17744", VA = "0xA17744")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public static string CurrentLanguageCode
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0xA181D0", Offset = "0xA181D0", VA = "0xA181D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0xA1823C", Offset = "0xA1823C", VA = "0xA1823C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public static string CurrentRegion
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0xA18560", Offset = "0xA18560", VA = "0xA18560")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0xA1872C", Offset = "0xA1872C", VA = "0xA1872C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public static string CurrentRegionCode
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0xA1892C", Offset = "0xA1892C", VA = "0xA1892C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xA18A18", Offset = "0xA18A18", VA = "0xA18A18")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public static CultureInfo CurrentCulture
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xA18B40", Offset = "0xA18B40", VA = "0xA18B40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000003")]
		public static event OnLocalizeCallback OnLocalizeEvent
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xA1C7F0", Offset = "0xA1C7F0", VA = "0xA1C7F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFA20", Offset = "0x6DFA20")]
			add
			{
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xA1C920", Offset = "0xA1C920", VA = "0xA1C920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFA30", Offset = "0x6DFA30")]
			remove
			{
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xA16ED4", Offset = "0xA16ED4", VA = "0xA16ED4")]
		public static void InitializeIfNeeded()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xA176FC", Offset = "0xA176FC", VA = "0xA176FC")]
		public static string GetVersion()
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xA14314", Offset = "0xA14314", VA = "0xA14314")]
		public static int GetRequiredWebServiceVersion()
		{
			return default(int);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xA10AE0", Offset = "0xA10AE0", VA = "0xA10AE0")]
		public static string GetWebServiceURL([Optional] LanguageSourceData source)
		{
			return null;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xA17FD4", Offset = "0xA17FD4", VA = "0xA17FD4")]
		public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true, bool Force = false)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xA18BA8", Offset = "0xA18BA8", VA = "0xA18BA8")]
		private static CultureInfo CreateCultureForCode(string code)
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xA18DC0", Offset = "0xA18DC0", VA = "0xA18DC0")]
		public static void EnableChangingCultureInfo(bool bEnable)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xA18CA8", Offset = "0xA18CA8", VA = "0xA18CA8")]
		private static void SetCurrentCultureInfo()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xA17204", Offset = "0xA17204", VA = "0xA17204")]
		private static void SelectStartupLanguage()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xA18F40", Offset = "0xA18F40", VA = "0xA18F40")]
		public static bool HasLanguage(string Language, bool AllowDiscartingRegion = true, bool Initialize = true, bool SkipDisabled = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xA17834", Offset = "0xA17834", VA = "0xA17834")]
		public static string GetSupportedLanguage(string Language, bool ignoreDisabled = false)
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xA17DB4", Offset = "0xA17DB4", VA = "0xA17DB4")]
		public static string GetLanguageCode(string Language)
		{
			return null;
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xA18330", Offset = "0xA18330", VA = "0xA18330")]
		public static string GetLanguageFromCode(string Code, bool exactMatch = true)
		{
			return null;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xA19184", Offset = "0xA19184", VA = "0xA19184")]
		public static List<string> GetAllLanguages(bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xA19424", Offset = "0xA19424", VA = "0xA19424")]
		public static List<string> GetAllLanguagesCode(bool allowRegions = true, bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xA1965C", Offset = "0xA1965C", VA = "0xA1965C")]
		public static bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xA19784", Offset = "0xA19784", VA = "0xA19784")]
		private static void LoadCurrentLanguage()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xA198F8", Offset = "0xA198F8", VA = "0xA198F8")]
		public static void PreviewLanguage(string NewLanguage)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xA16FBC", Offset = "0xA16FBC", VA = "0xA16FBC")]
		public static void AutoLoadGlobalParamManagers()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xA199E0", Offset = "0xA199E0", VA = "0xA199E0")]
		public static void ApplyLocalizationParams(ref string translation, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xA1A014", Offset = "0xA1A014", VA = "0xA1A014")]
		public static void ApplyLocalizationParams(ref string translation, GameObject root, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xA1A0F0", Offset = "0xA1A0F0", VA = "0xA1A0F0")]
		public static void ApplyLocalizationParams(ref string translation, Dictionary<string, object> parameters, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xA19AF8", Offset = "0xA19AF8", VA = "0xA19AF8")]
		public static void ApplyLocalizationParams(ref string translation, _GetParam getParam, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xA1AAA4", Offset = "0xA1AAA4", VA = "0xA1AAA4")]
		internal static string GetLocalizationParam(string ParamName, GameObject root)
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xA1AD98", Offset = "0xA1AD98", VA = "0xA1AD98")]
		private static string GetPluralType(MatchCollection matches, string langCode, _GetParam getParam)
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xA1B010", Offset = "0xA1B010", VA = "0xA1B010")]
		public static string ApplyRTLfix(string line)
		{
			return null;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xA1B07C", Offset = "0xA1B07C", VA = "0xA1B07C")]
		public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xA1B598", Offset = "0xA1B598", VA = "0xA1B598")]
		public static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = false)
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xA18D38", Offset = "0xA18D38", VA = "0xA18D38")]
		public static bool IsRTL(string Code)
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xA17168", Offset = "0xA17168", VA = "0xA17168")]
		public static bool UpdateSources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xA1B64C", Offset = "0xA1B64C", VA = "0xA1B64C")]
		private static void UnregisterDeletededSources()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xA1B974", Offset = "0xA1B974", VA = "0xA1B974")]
		private static void RegisterSceneSources()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xA1B77C", Offset = "0xA1B77C", VA = "0xA1B77C")]
		private static void RegisterSourceInResources()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xA0D2A8", Offset = "0xA0D2A8", VA = "0xA0D2A8")]
		internal static void AddSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xA1BB7C", Offset = "0xA1BB7C", VA = "0xA1BB7C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DF9BC", Offset = "0x6DF9BC")]
		private static IEnumerator Delayed_Import_Google(LanguageSourceData source, float delay, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xA0DBF4", Offset = "0xA0DBF4", VA = "0xA0DBF4")]
		internal static void RemoveSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xA1BC64", Offset = "0xA1BC64", VA = "0xA1BC64")]
		public static bool IsGlobalSource(string SourceName)
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xA1BCEC", Offset = "0xA1BCEC", VA = "0xA1BCEC")]
		public static LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = true)
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xA1BF10", Offset = "0xA1BF10", VA = "0xA1BF10")]
		public static UnityEngine.Object FindAsset(string value)
		{
			return null;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xA1C070", Offset = "0xA1C070", VA = "0xA1C070")]
		public static void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xA18E74", Offset = "0xA18E74", VA = "0xA18E74")]
		public static string GetCurrentDeviceLanguage(bool force = false)
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xA1C180", Offset = "0xA1C180", VA = "0xA1C180")]
		private static void DetectDeviceLanguage()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xA1C548", Offset = "0xA1C548", VA = "0xA1C548")]
		public static void RegisterTarget(ILocalizeTargetDescriptor desc)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xA1CA50", Offset = "0xA1CA50", VA = "0xA1CA50")]
		public static string GetTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xA1CD38", Offset = "0xA1CD38", VA = "0xA1CD38")]
		public static string GetTermTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xA1CB14", Offset = "0xA1CB14", VA = "0xA1CB14")]
		public static bool TryGetTranslation(string Term, out string Translation, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		public static T GetTranslatedObject<T>(string AssetName, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		public static T GetTranslatedObjectByTermName<T>(string Term, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xA1CDE4", Offset = "0xA1CDE4", VA = "0xA1CDE4")]
		public static string GetAppName(string languageCode)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xA0DAEC", Offset = "0xA0DAEC", VA = "0xA0DAEC")]
		public static void LocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xA1D248", Offset = "0xA1D248", VA = "0xA1D248")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DFA40", Offset = "0x6DFA40")]
		private static IEnumerator Coroutine_LocalizeAll()
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xA1D058", Offset = "0xA1D058", VA = "0xA1D058")]
		private static void DoLocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xA1E008", Offset = "0xA1E008", VA = "0xA1E008")]
		public static List<string> GetCategories()
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xA1E148", Offset = "0xA1E148", VA = "0xA1E148")]
		public static List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xA1E3F4", Offset = "0xA1E3F4", VA = "0xA1E3F4")]
		public static TermData GetTermData(string term)
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xA1A91C", Offset = "0xA1A91C", VA = "0xA1A91C")]
		public static TermData GetTermData(string term, out LanguageSourceData source)
		{
			return null;
		}
	}
	[Token(Token = "0x2000023")]
	public abstract class ILocalizeTarget : ScriptableObject
	{
		[Token(Token = "0x6000181")]
		public abstract bool IsValid(Localize cmp);

		[Token(Token = "0x6000182")]
		public abstract void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm);

		[Token(Token = "0x6000183")]
		public abstract void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation);

		[Token(Token = "0x6000184")]
		public abstract bool CanUseSecondaryTerm();

		[Token(Token = "0x6000185")]
		public abstract bool AllowMainTermToBeRTL();

		[Token(Token = "0x6000186")]
		public abstract bool AllowSecondTermToBeRTL();

		[Token(Token = "0x6000187")]
		public abstract eTermType GetPrimaryTermType(Localize cmp);

		[Token(Token = "0x6000188")]
		public abstract eTermType GetSecondaryTermType(Localize cmp);

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xA0BB70", Offset = "0xA0BB70", VA = "0xA0BB70")]
		protected ILocalizeTarget()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public abstract class LocalizeTarget<T> : ILocalizeTarget where T : UnityEngine.Object
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T mTarget;

		[Token(Token = "0x600018A")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		protected LocalizeTarget()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public abstract class ILocalizeTargetDescriptor
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Priority;

		[Token(Token = "0x600018C")]
		public abstract bool CanLocalize(Localize cmp);

		[Token(Token = "0x600018D")]
		public abstract ILocalizeTarget CreateTarget(Localize cmp);

		[Token(Token = "0x600018E")]
		public abstract Type GetTargetType();

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xA0BB78", Offset = "0xA0BB78", VA = "0xA0BB78")]
		protected ILocalizeTargetDescriptor()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public abstract class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor where T : ILocalizeTarget
	{
		[Token(Token = "0x6000190")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x6000191")]
		public override Type GetTargetType()
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		protected LocalizeTargetDesc()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G> where T : UnityEngine.Object where G : LocalizeTarget<T>
	{
		[Token(Token = "0x6000193")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		public LocalizeTargetDesc_Type()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TextMeshPro>
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xA225D4", Offset = "0xA225D4", VA = "0xA225D4")]
		static LocalizeTarget_TextMeshPro_Label()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xA225D8", Offset = "0xA225D8", VA = "0xA225D8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6DFAA4", Offset = "0x6DFAA4")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xA226A0", Offset = "0xA226A0", VA = "0xA226A0", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xA226A8", Offset = "0xA226A8", VA = "0xA226A8", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xA226B0", Offset = "0xA226B0", VA = "0xA226B0", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xA226B8", Offset = "0xA226B8", VA = "0xA226B8", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xA226C0", Offset = "0xA226C0", VA = "0xA226C0", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xA226C8", Offset = "0xA226C8", VA = "0xA226C8", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xA2281C", Offset = "0xA2281C", VA = "0xA2281C", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xA22F70", Offset = "0xA22F70", VA = "0xA22F70")]
		internal static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xA2327C", Offset = "0xA2327C", VA = "0xA2327C")]
		internal static void InitAlignment_TMPro(bool isRTL, TextAlignmentOptions alignment, out TextAlignmentOptions alignLTR, out TextAlignmentOptions alignRTL)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xA22E10", Offset = "0xA22E10", VA = "0xA22E10")]
		internal static void SetFont(TMP_Text label, TMP_FontAsset newFont)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xA23130", Offset = "0xA23130", VA = "0xA23130")]
		internal static void SetMaterial(TMP_Text label, Material newMat)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xA23490", Offset = "0xA23490", VA = "0xA23490")]
		public LocalizeTarget_TextMeshPro_Label()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TextMeshProUGUI>
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool mAlignmentWasRTL;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool mInitializeAlignment;

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xA234F4", Offset = "0xA234F4", VA = "0xA234F4")]
		static LocalizeTarget_TextMeshPro_UGUI()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xA234F8", Offset = "0xA234F8", VA = "0xA234F8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6DFAB8", Offset = "0x6DFAB8")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xA235C0", Offset = "0xA235C0", VA = "0xA235C0", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xA235C8", Offset = "0xA235C8", VA = "0xA235C8", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xA235D0", Offset = "0xA235D0", VA = "0xA235D0", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xA235D8", Offset = "0xA235D8", VA = "0xA235D8", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xA235E0", Offset = "0xA235E0", VA = "0xA235E0", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xA235E8", Offset = "0xA235E8", VA = "0xA235E8", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xA2373C", Offset = "0xA2373C", VA = "0xA2373C", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xA23D30", Offset = "0xA23D30", VA = "0xA23D30")]
		public LocalizeTarget_TextMeshPro_UGUI()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource>
	{
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xA23D94", Offset = "0xA23D94", VA = "0xA23D94")]
		static LocalizeTarget_UnityStandard_AudioSource()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xA23D98", Offset = "0xA23D98", VA = "0xA23D98")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6DFACC", Offset = "0x6DFACC")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xA23E60", Offset = "0xA23E60", VA = "0xA23E60", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xA23E68", Offset = "0xA23E68", VA = "0xA23E68", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xA23E70", Offset = "0xA23E70", VA = "0xA23E70", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xA23E78", Offset = "0xA23E78", VA = "0xA23E78", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xA23E80", Offset = "0xA23E80", VA = "0xA23E80", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xA23E88", Offset = "0xA23E88", VA = "0xA23E88", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xA23F80", Offset = "0xA23F80", VA = "0xA23F80", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xA24148", Offset = "0xA24148", VA = "0xA24148")]
		public LocalizeTarget_UnityStandard_AudioSource()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class LocalizeTargetDesc_Child : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Child>
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xA224D8", Offset = "0xA224D8", VA = "0xA224D8", Slot = "4")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xA2252C", Offset = "0xA2252C", VA = "0xA2252C")]
		public LocalizeTargetDesc_Child()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xA24198", Offset = "0xA24198", VA = "0xA24198")]
		static LocalizeTarget_UnityStandard_Child()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xA2419C", Offset = "0xA2419C", VA = "0xA2419C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6DFAE0", Offset = "0x6DFAE0")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xA24258", Offset = "0xA24258", VA = "0xA24258", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xA242AC", Offset = "0xA242AC", VA = "0xA242AC", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xA242B4", Offset = "0xA242B4", VA = "0xA242B4", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xA242BC", Offset = "0xA242BC", VA = "0xA242BC", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xA242C4", Offset = "0xA242C4", VA = "0xA242C4", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xA242CC", Offset = "0xA242CC", VA = "0xA242CC", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xA242D4", Offset = "0xA242D4", VA = "0xA242D4", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xA24320", Offset = "0xA24320", VA = "0xA24320", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xA244CC", Offset = "0xA244CC", VA = "0xA244CC")]
		public LocalizeTarget_UnityStandard_Child()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer>
	{
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xA2451C", Offset = "0xA2451C", VA = "0xA2451C")]
		static LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xA24520", Offset = "0xA24520", VA = "0xA24520")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6DFAF4", Offset = "0x6DFAF4")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xA245E8", Offset = "0xA245E8", VA = "0xA245E8", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xA245F0", Offset = "0xA245F0", VA = "0xA245F0", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xA245F8", Offset = "0xA245F8", VA = "0xA245F8", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xA24600", Offset = "0xA24600", VA = "0xA24600", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xA24608", Offset = "0xA24608", VA = "0xA24608", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xA24610", Offset = "0xA24610", VA = "0xA24610", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xA2485C", Offset = "0xA2485C", VA = "0xA2485C", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xA24A7C", Offset = "0xA24A7C", VA = "0xA24A7C")]
		public LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class LocalizeTargetDesc_Prefab : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Prefab>
	{
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xA2257C", Offset = "0xA2257C", VA = "0xA2257C", Slot = "4")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xA22584", Offset = "0xA22584", VA = "0xA22584")]
		public LocalizeTargetDesc_Prefab()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xA24ACC", Offset = "0xA24ACC", VA = "0xA24ACC")]
		static LocalizeTarget_UnityStandard_Prefab()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xA24AD0", Offset = "0xA24AD0", VA = "0xA24AD0")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6DFB08", Offset = "0x6DFB08")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xA24B8C", Offset = "0xA24B8C", VA = "0xA24B8C", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xA24B94", Offset = "0xA24B94", VA = "0xA24B94", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xA24B9C", Offset = "0xA24B9C", VA = "0xA24B9C", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xA24BA4", Offset = "0xA24BA4", VA = "0xA24BA4", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xA24BAC", Offset = "0xA24BAC", VA = "0xA24BAC", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xA24BB4", Offset = "0xA24BB4", VA = "0xA24BB4", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xA24BBC", Offset = "0xA24BBC", VA = "0xA24BBC", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xA24C08", Offset = "0xA24C08", VA = "0xA24C08", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xA24E88", Offset = "0xA24E88", VA = "0xA24E88")]
		private Transform InstantiateNewPrefab(Localize cmp, string mainTranslation)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xA250D0", Offset = "0xA250D0", VA = "0xA250D0")]
		public LocalizeTarget_UnityStandard_Prefab()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<SpriteRenderer>
	{
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xA25120", Offset = "0xA25120", VA = "0xA25120")]
		static LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xA25124", Offset = "0xA25124", VA = "0xA25124")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6DFB1C", Offset = "0x6DFB1C")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xA251EC", Offset = "0xA251EC", VA = "0xA251EC", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xA251F4", Offset = "0xA251F4", VA = "0xA251F4", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xA251FC", Offset = "0xA251FC", VA = "0xA251FC", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xA25204", Offset = "0xA25204", VA = "0xA25204", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xA2520C", Offset = "0xA2520C", VA = "0xA2520C", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xA25214", Offset = "0xA25214", VA = "0xA25214", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xA25310", Offset = "0xA25310", VA = "0xA25310", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xA25434", Offset = "0xA25434", VA = "0xA25434")]
		public LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<TextMesh>
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAlignment mAlignment_RTL;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAlignment mAlignment_LTR;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xA25484", Offset = "0xA25484", VA = "0xA25484")]
		static LocalizeTarget_UnityStandard_TextMesh()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xA25488", Offset = "0xA25488", VA = "0xA25488")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6DFB30", Offset = "0x6DFB30")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xA25550", Offset = "0xA25550", VA = "0xA25550", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xA25558", Offset = "0xA25558", VA = "0xA25558", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xA25560", Offset = "0xA25560", VA = "0xA25560", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xA25568", Offset = "0xA25568", VA = "0xA25568", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xA25570", Offset = "0xA25570", VA = "0xA25570", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xA25578", Offset = "0xA25578", VA = "0xA25578", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xA256D8", Offset = "0xA256D8", VA = "0xA256D8", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xA259D8", Offset = "0xA259D8", VA = "0xA259D8")]
		public LocalizeTarget_UnityStandard_TextMesh()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image>
	{
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xA25A38", Offset = "0xA25A38", VA = "0xA25A38")]
		static LocalizeTarget_UnityUI_Image()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xA25A3C", Offset = "0xA25A3C", VA = "0xA25A3C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6DFB44", Offset = "0x6DFB44")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xA25B04", Offset = "0xA25B04", VA = "0xA25B04", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xA25B0C", Offset = "0xA25B0C", VA = "0xA25B0C", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xA25B14", Offset = "0xA25B14", VA = "0xA25B14", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xA25B1C", Offset = "0xA25B1C", VA = "0xA25B1C", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xA25BC0", Offset = "0xA25BC0", VA = "0xA25BC0", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xA25BC8", Offset = "0xA25BC8", VA = "0xA25BC8", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xA25DBC", Offset = "0xA25DBC", VA = "0xA25DBC", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xA25EE0", Offset = "0xA25EE0", VA = "0xA25EE0")]
		public LocalizeTarget_UnityUI_Image()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<RawImage>
	{
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xA25F30", Offset = "0xA25F30", VA = "0xA25F30")]
		static LocalizeTarget_UnityUI_RawImage()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xA25F34", Offset = "0xA25F34", VA = "0xA25F34")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6DFB58", Offset = "0x6DFB58")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xA25FFC", Offset = "0xA25FFC", VA = "0xA25FFC", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xA26004", Offset = "0xA26004", VA = "0xA26004", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xA2600C", Offset = "0xA2600C", VA = "0xA2600C", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xA26014", Offset = "0xA26014", VA = "0xA26014", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xA2601C", Offset = "0xA2601C", VA = "0xA2601C", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xA26024", Offset = "0xA26024", VA = "0xA26024", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xA26124", Offset = "0xA26124", VA = "0xA26124", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xA26248", Offset = "0xA26248", VA = "0xA26248")]
		public LocalizeTarget_UnityUI_RawImage()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class LocalizeTarget_UnityUI_Text : LocalizeTarget<Text>
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAnchor mAlignment_RTL;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAnchor mAlignment_LTR;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xA26298", Offset = "0xA26298", VA = "0xA26298")]
		static LocalizeTarget_UnityUI_Text()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xA2629C", Offset = "0xA2629C", VA = "0xA2629C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6DFB6C", Offset = "0x6DFB6C")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xA26364", Offset = "0xA26364", VA = "0xA26364", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xA2636C", Offset = "0xA2636C", VA = "0xA2636C", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xA26374", Offset = "0xA26374", VA = "0xA26374", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xA2637C", Offset = "0xA2637C", VA = "0xA2637C", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xA26384", Offset = "0xA26384", VA = "0xA26384", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xA2638C", Offset = "0xA2638C", VA = "0xA2638C", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xA264E8", Offset = "0xA264E8", VA = "0xA264E8", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xA26894", Offset = "0xA26894", VA = "0xA26894")]
		private void InitAlignment(bool isRTL, TextAnchor alignment, out TextAnchor alignLTR, out TextAnchor alignRTL)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xA26954", Offset = "0xA26954", VA = "0xA26954")]
		public LocalizeTarget_UnityUI_Text()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public enum eTermType
	{
		[Token(Token = "0x40000DB")]
		Text,
		[Token(Token = "0x40000DC")]
		Font,
		[Token(Token = "0x40000DD")]
		Texture,
		[Token(Token = "0x40000DE")]
		AudioClip,
		[Token(Token = "0x40000DF")]
		GameObject,
		[Token(Token = "0x40000E0")]
		Sprite,
		[Token(Token = "0x40000E1")]
		Material,
		[Token(Token = "0x40000E2")]
		Child,
		[Token(Token = "0x40000E3")]
		Mesh,
		[Token(Token = "0x40000E4")]
		TextMeshPFont,
		[Token(Token = "0x40000E5")]
		Object
	}
	[Token(Token = "0x2000036")]
	public enum TranslationFlag : byte
	{
		[Token(Token = "0x40000E7")]
		Normal = 1,
		[Token(Token = "0x40000E8")]
		AutoTranslated
	}
	[Serializable]
	[Token(Token = "0x2000037")]
	public class TermData
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Term;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public eTermType TermType;

		[NonSerialized]
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Description;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Languages;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public byte[] Flags;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] Languages_Touch;

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1668814", Offset = "0x1668814", VA = "0x1668814")]
		public string GetTranslation(int idx, [Optional] string specialization, bool editMode = false)
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1668950", Offset = "0x1668950", VA = "0x1668950")]
		public void SetTranslation(int idx, string translation, [Optional] string specialization)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1668A60", Offset = "0x1668A60", VA = "0x1668A60")]
		public void RemoveSpecialization(string specialization)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1668AC0", Offset = "0x1668AC0", VA = "0x1668AC0")]
		public void RemoveSpecialization(int idx, string specialization)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1668C6C", Offset = "0x1668C6C", VA = "0x1668C6C")]
		public bool IsAutoTranslated(int idx, bool IsTouch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1668CC4", Offset = "0x1668CC4", VA = "0x1668CC4")]
		public void Validate()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1668F88", Offset = "0x1668F88", VA = "0x1668F88")]
		public bool IsTerm(string name, bool allowCategoryMistmatch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1669020", Offset = "0x1669020", VA = "0x1669020")]
		public bool HasSpecializations()
		{
			return default(bool);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1669144", Offset = "0x1669144", VA = "0x1669144")]
		public List<string> GetAllSpecializations()
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1669248", Offset = "0x1669248", VA = "0x1669248")]
		public TermData()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class TermsPopup : PropertyAttribute
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEEFC", Offset = "0x6DEEFC")]
		private string <Filter>k__BackingField;

		[Token(Token = "0x1700000E")]
		public string Filter
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x166930C", Offset = "0x166930C", VA = "0x166930C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFB80", Offset = "0x6DFB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x1669304", Offset = "0x1669304", VA = "0x1669304")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFB90", Offset = "0x6DFB90")]
			private set
			{
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x16692D8", Offset = "0x16692D8", VA = "0x16692D8")]
		public TermsPopup(string filter = "")
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class AutoChangeCultureInfo : MonoBehaviour
	{
		[Token(Token = "0x600021D")]
		[Address(RVA = "0xBA552C", Offset = "0xBA552C", VA = "0xBA552C")]
		public void Start()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xBA5590", Offset = "0xBA5590", VA = "0xBA5590")]
		public AutoChangeCultureInfo()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class CoroutineManager : MonoBehaviour
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CoroutineManager mInstance;

		[Token(Token = "0x1700000F")]
		private static CoroutineManager pInstance
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0xBA5CA0", Offset = "0xBA5CA0", VA = "0xBA5CA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xBA5DF0", Offset = "0xBA5DF0", VA = "0xBA5DF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xBA5E84", Offset = "0xBA5E84", VA = "0xBA5E84")]
		public static Coroutine Start(IEnumerator coroutine)
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xBA5EBC", Offset = "0xBA5EBC", VA = "0xBA5EBC")]
		public CoroutineManager()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6DE6C4", Offset = "0x6DE6C4")]
	public class CustomLocalizeCallback : MonoBehaviour
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent _OnLocalize;

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xBA5EC4", Offset = "0xBA5EC4", VA = "0xBA5EC4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xBA5F88", Offset = "0xBA5F88", VA = "0xBA5F88")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xBA601C", Offset = "0xBA601C", VA = "0xBA601C")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xBA604C", Offset = "0xBA604C", VA = "0xBA604C")]
		public CustomLocalizeCallback()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class HindiFixer
	{
		[Serializable]
		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE9CC", Offset = "0x6DE9CC")]
		private sealed class <>c
		{
			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<char, bool> <>9__0_0;

			[Token(Token = "0x6000572")]
			[Address(RVA = "0xBB36E0", Offset = "0xBB36E0", VA = "0xBB36E0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0xBB36E8", Offset = "0xBB36E8", VA = "0xBB36E8")]
			internal bool <Fix>b__0_0(char x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xBB2EAC", Offset = "0xBB2EAC", VA = "0xBB2EAC")]
		internal static string Fix(string text)
		{
			return null;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xBB3674", Offset = "0xBB3674", VA = "0xBB3674")]
		public HindiFixer()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public static class I2Utils
	{
		[Serializable]
		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE9DC", Offset = "0x6DE9DC")]
		private sealed class <>c
		{
			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<char, bool> <>9__6_0;

			[Token(Token = "0x6000575")]
			[Address(RVA = "0xA0BB5C", Offset = "0xA0BB5C", VA = "0xA0BB5C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0xA0BB64", Offset = "0xA0BB64", VA = "0xA0BB64")]
			internal bool <SplitLine>b__6_0(char c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40000F2")]
		public const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";

		[Token(Token = "0x40000F3")]
		public const string NumberChars = "0123456789";

		[Token(Token = "0x40000F4")]
		public const string ValidNameSymbols = ".-_$#@*()[]{}+:?!&',^=<>~`";

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xA0A878", Offset = "0xA0A878", VA = "0xA0A878")]
		public static string ReverseText(string source)
		{
			return null;
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xA0A98C", Offset = "0xA0A98C", VA = "0xA0A98C")]
		public static string RemoveNonASCII(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xA0AC34", Offset = "0xA0AC34", VA = "0xA0AC34")]
		public static string GetValidTermName(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xA0ACE8", Offset = "0xA0ACE8", VA = "0xA0ACE8")]
		public static string SplitLine(string line, int maxCharacters)
		{
			return null;
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xA0B040", Offset = "0xA0B040", VA = "0xA0B040")]
		public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xA0AC68", Offset = "0xA0AC68", VA = "0xA0AC68")]
		public static string RemoveTags(string text)
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xA0B22C", Offset = "0xA0B22C", VA = "0xA0B22C")]
		public static bool RemoveResourcesPath(ref string sPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xA0B544", Offset = "0xA0B544", VA = "0xA0B544")]
		public static bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xA0B54C", Offset = "0xA0B54C", VA = "0xA0B54C")]
		public static string GetPath(this Transform tr)
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xA0B63C", Offset = "0xA0B63C", VA = "0xA0B63C")]
		public static Transform FindObject(string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xA0B6AC", Offset = "0xA0B6AC", VA = "0xA0B6AC")]
		public static Transform FindObject(Scene scene, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xA0B858", Offset = "0xA0B858", VA = "0xA0B858")]
		public static Transform FindObject(Transform root, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		public static H FindInParents<H>(Transform tr) where H : Component
		{
			return null;
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xA0B9E0", Offset = "0xA0B9E0", VA = "0xA0B9E0")]
		public static string GetCaptureMatch(Match match)
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xA0BACC", Offset = "0xA0BACC", VA = "0xA0BACC")]
		public static void SendWebRequest(UnityWebRequest www)
		{
		}
	}
	[Token(Token = "0x200003E")]
	public interface ILocalizationParamsManager
	{
		[Token(Token = "0x6000238")]
		string GetParameterValue(string Param);
	}
	[Token(Token = "0x200003F")]
	public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
	{
		[Serializable]
		[Token(Token = "0x20000BF")]
		public struct ParamValue
		{
			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Name;

			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string Value;
		}

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<ParamValue> _Params;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool _IsGlobalManager;

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xA1F3CC", Offset = "0xA1F3CC", VA = "0xA1F3CC", Slot = "4")]
		public string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xA1F4B8", Offset = "0xA1F4B8", VA = "0xA1F4B8")]
		public void SetParameterValue(string ParamName, string ParamValue, bool localize = true)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xA1F638", Offset = "0xA1F638", VA = "0xA1F638")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xA1F6E8", Offset = "0xA1F6E8", VA = "0xA1F6E8", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xA1F6F8", Offset = "0xA1F6F8", VA = "0xA1F6F8")]
		public void DoAutoRegister()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xA1F7F0", Offset = "0xA1F7F0", VA = "0xA1F7F0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xA1F87C", Offset = "0xA1F87C", VA = "0xA1F87C")]
		public LocalizationParamsManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public struct LocalizedString
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string mTerm;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool mRTL_IgnoreArabicFix;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int mRTL_MaxLineLength;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool mRTL_ConvertNumbers;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool m_DontLocalizeParameters;

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xA269B4", Offset = "0xA269B4", VA = "0xA269B4")]
		public static implicit operator string(LocalizedString s)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xA26A80", Offset = "0xA26A80", VA = "0xA26A80")]
		public static implicit operator LocalizedString(string term)
		{
			return default(LocalizedString);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x7683F4", Offset = "0x7683F4", VA = "0x7683F4")]
		public LocalizedString(LocalizedString str)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x768438", Offset = "0x768438", VA = "0x768438", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000041")]
	public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
	{
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1660604", Offset = "0x1660604", VA = "0x1660604", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1660700", Offset = "0x1660700", VA = "0x1660700", Slot = "6")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x166078C", Offset = "0x166078C", VA = "0x166078C", Slot = "7")]
		public virtual string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1660794", Offset = "0x1660794", VA = "0x1660794")]
		public RegisterGlobalParameters()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public interface IResourceManager_Bundles
	{
		[Token(Token = "0x6000248")]
		UnityEngine.Object LoadFromBundle(string path, Type assetType);
	}
	[Token(Token = "0x2000043")]
	public class ResourceManager : MonoBehaviour
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ResourceManager mInstance;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<IResourceManager_Bundles> mBundleManagers;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object[] Assets;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, UnityEngine.Object> mResourcesCache;

		[Token(Token = "0x17000010")]
		public static ResourceManager pInstance
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x166079C", Offset = "0x166079C", VA = "0x166079C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1660B90", Offset = "0x1660B90", VA = "0x1660B90")]
		public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x600024B")]
		public T GetAsset<T>(string Name) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1660C7C", Offset = "0x1660C7C", VA = "0x1660C7C")]
		private UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1660E00", Offset = "0x1660E00", VA = "0x1660E00")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		public T LoadFromResources<T>(string Path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600024F")]
		public T LoadFromBundle<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1660C08", Offset = "0x1660C08", VA = "0x1660C08")]
		public void CleanResourceCache()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1660E70", Offset = "0x1660E70", VA = "0x1660E70")]
		public ResourceManager()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class RTLFixer
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x165CB4C", Offset = "0x165CB4C", VA = "0x165CB4C")]
		public static string Fix(string str)
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x165CE44", Offset = "0x165CE44", VA = "0x165CE44")]
		public static string Fix(string str, bool rtl)
		{
			return null;
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x165CB58", Offset = "0x165CB58", VA = "0x165CB58")]
		public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x165E6D8", Offset = "0x165E6D8", VA = "0x165E6D8")]
		public RTLFixer()
		{
		}
	}
	[Token(Token = "0x2000045")]
	internal enum IsolatedArabicLetters
	{
		[Token(Token = "0x4000101")]
		Hamza = 65152,
		[Token(Token = "0x4000102")]
		Alef = 65165,
		[Token(Token = "0x4000103")]
		AlefHamza = 65155,
		[Token(Token = "0x4000104")]
		WawHamza = 65157,
		[Token(Token = "0x4000105")]
		AlefMaksoor = 65159,
		[Token(Token = "0x4000106")]
		AlefMaksora = 64508,
		[Token(Token = "0x4000107")]
		HamzaNabera = 65161,
		[Token(Token = "0x4000108")]
		Ba = 65167,
		[Token(Token = "0x4000109")]
		Ta = 65173,
		[Token(Token = "0x400010A")]
		Tha2 = 65177,
		[Token(Token = "0x400010B")]
		Jeem = 65181,
		[Token(Token = "0x400010C")]
		H7aa = 65185,
		[Token(Token = "0x400010D")]
		Khaa2 = 65189,
		[Token(Token = "0x400010E")]
		Dal = 65193,
		[Token(Token = "0x400010F")]
		Thal = 65195,
		[Token(Token = "0x4000110")]
		Ra2 = 65197,
		[Token(Token = "0x4000111")]
		Zeen = 65199,
		[Token(Token = "0x4000112")]
		Seen = 65201,
		[Token(Token = "0x4000113")]
		Sheen = 65205,
		[Token(Token = "0x4000114")]
		S9a = 65209,
		[Token(Token = "0x4000115")]
		Dha = 65213,
		[Token(Token = "0x4000116")]
		T6a = 65217,
		[Token(Token = "0x4000117")]
		T6ha = 65221,
		[Token(Token = "0x4000118")]
		Ain = 65225,
		[Token(Token = "0x4000119")]
		Gain = 65229,
		[Token(Token = "0x400011A")]
		Fa = 65233,
		[Token(Token = "0x400011B")]
		Gaf = 65237,
		[Token(Token = "0x400011C")]
		Kaf = 65241,
		[Token(Token = "0x400011D")]
		Lam = 65245,
		[Token(Token = "0x400011E")]
		Meem = 65249,
		[Token(Token = "0x400011F")]
		Noon = 65253,
		[Token(Token = "0x4000120")]
		Ha = 65257,
		[Token(Token = "0x4000121")]
		Waw = 65261,
		[Token(Token = "0x4000122")]
		Ya = 65265,
		[Token(Token = "0x4000123")]
		AlefMad = 65153,
		[Token(Token = "0x4000124")]
		TaMarboota = 65171,
		[Token(Token = "0x4000125")]
		PersianPe = 64342,
		[Token(Token = "0x4000126")]
		PersianChe = 64378,
		[Token(Token = "0x4000127")]
		PersianZe = 64394,
		[Token(Token = "0x4000128")]
		PersianGaf = 64402,
		[Token(Token = "0x4000129")]
		PersianGaf2 = 64398
	}
	[Token(Token = "0x2000046")]
	internal enum GeneralArabicLetters
	{
		[Token(Token = "0x400012B")]
		Hamza = 1569,
		[Token(Token = "0x400012C")]
		Alef = 1575,
		[Token(Token = "0x400012D")]
		AlefHamza = 1571,
		[Token(Token = "0x400012E")]
		WawHamza = 1572,
		[Token(Token = "0x400012F")]
		AlefMaksoor = 1573,
		[Token(Token = "0x4000130")]
		AlefMagsora = 1609,
		[Token(Token = "0x4000131")]
		HamzaNabera = 1574,
		[Token(Token = "0x4000132")]
		Ba = 1576,
		[Token(Token = "0x4000133")]
		Ta = 1578,
		[Token(Token = "0x4000134")]
		Tha2 = 1579,
		[Token(Token = "0x4000135")]
		Jeem = 1580,
		[Token(Token = "0x4000136")]
		H7aa = 1581,
		[Token(Token = "0x4000137")]
		Khaa2 = 1582,
		[Token(Token = "0x4000138")]
		Dal = 1583,
		[Token(Token = "0x4000139")]
		Thal = 1584,
		[Token(Token = "0x400013A")]
		Ra2 = 1585,
		[Token(Token = "0x400013B")]
		Zeen = 1586,
		[Token(Token = "0x400013C")]
		Seen = 1587,
		[Token(Token = "0x400013D")]
		Sheen = 1588,
		[Token(Token = "0x400013E")]
		S9a = 1589,
		[Token(Token = "0x400013F")]
		Dha = 1590,
		[Token(Token = "0x4000140")]
		T6a = 1591,
		[Token(Token = "0x4000141")]
		T6ha = 1592,
		[Token(Token = "0x4000142")]
		Ain = 1593,
		[Token(Token = "0x4000143")]
		Gain = 1594,
		[Token(Token = "0x4000144")]
		Fa = 1601,
		[Token(Token = "0x4000145")]
		Gaf = 1602,
		[Token(Token = "0x4000146")]
		Kaf = 1603,
		[Token(Token = "0x4000147")]
		Lam = 1604,
		[Token(Token = "0x4000148")]
		Meem = 1605,
		[Token(Token = "0x4000149")]
		Noon = 1606,
		[Token(Token = "0x400014A")]
		Ha = 1607,
		[Token(Token = "0x400014B")]
		Waw = 1608,
		[Token(Token = "0x400014C")]
		Ya = 1610,
		[Token(Token = "0x400014D")]
		AlefMad = 1570,
		[Token(Token = "0x400014E")]
		TaMarboota = 1577,
		[Token(Token = "0x400014F")]
		PersianPe = 1662,
		[Token(Token = "0x4000150")]
		PersianChe = 1670,
		[Token(Token = "0x4000151")]
		PersianZe = 1688,
		[Token(Token = "0x4000152")]
		PersianGaf = 1711,
		[Token(Token = "0x4000153")]
		PersianGaf2 = 1705
	}
	[Token(Token = "0x2000047")]
	internal class ArabicMapping
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int from;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int to;

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xBA4718", Offset = "0xBA4718", VA = "0xBA4718")]
		public ArabicMapping(int from, int to)
		{
		}
	}
	[Token(Token = "0x2000048")]
	internal class ArabicTable
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ArabicMapping> mapList;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ArabicTable arabicMapper;

		[Token(Token = "0x17000011")]
		internal static ArabicTable ArabicMapper
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0xBA5378", Offset = "0xBA5378", VA = "0xBA5378")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xBA4750", Offset = "0xBA4750", VA = "0xBA4750")]
		private ArabicTable()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xBA53F0", Offset = "0xBA53F0", VA = "0xBA53F0")]
		internal int Convert(int toBeConverted)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000049")]
	internal class TashkeelLocation
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public char tashkeel;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int position;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x165EDDC", Offset = "0x165EDDC", VA = "0x165EDDC")]
		public TashkeelLocation(char tashkeel, int position)
		{
		}
	}
	[Token(Token = "0x200004A")]
	internal class RTLFixerTool
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool showTashkeel;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		internal static bool useHinduNumbers;

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x165E6E0", Offset = "0x165E6E0", VA = "0x165E6E0")]
		internal static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x165EE18", Offset = "0x165EE18", VA = "0x165EE18")]
		internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x165D0D8", Offset = "0x165D0D8", VA = "0x165D0D8")]
		internal static string FixLine(string str)
		{
			return null;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x165F078", Offset = "0x165F078", VA = "0x165F078")]
		internal static bool IsIgnoredCharacter(char ch)
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x165FDE4", Offset = "0x165FDE4", VA = "0x165FDE4")]
		internal static bool IsLeadingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x165FA18", Offset = "0x165FA18", VA = "0x165FA18")]
		internal static bool IsFinishingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x165F1F4", Offset = "0x165F1F4", VA = "0x165F1F4")]
		internal static bool IsMiddleLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x166059C", Offset = "0x166059C", VA = "0x166059C")]
		public RTLFixerTool()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6DE70C", Offset = "0x6DE70C")]
	public class SetLanguage : MonoBehaviour
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string _Language;

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1660F44", Offset = "0x1660F44", VA = "0x1660F44")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1660F48", Offset = "0x1660F48", VA = "0x1660F48")]
		public void ApplyLanguage()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1661004", Offset = "0x1661004", VA = "0x1661004")]
		public SetLanguage()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6DE744", Offset = "0x6DE744")]
	public class SetLanguageDropdown : MonoBehaviour
	{
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x166100C", Offset = "0x166100C", VA = "0x166100C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x16612D8", Offset = "0x16612D8", VA = "0x16612D8")]
		private void OnValueChanged(int index)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x16613EC", Offset = "0x16613EC", VA = "0x16613EC")]
		public SetLanguageDropdown()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class StringObfucator
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static char[] StringObfuscatorPassword;

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x166825C", Offset = "0x166825C", VA = "0x166825C")]
		public static string Encode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1668600", Offset = "0x1668600", VA = "0x1668600")]
		public static string Decode(string ObfucatedString)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1668564", Offset = "0x1668564", VA = "0x1668564")]
		private static string ToBase64(string regularString)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x16686E4", Offset = "0x16686E4", VA = "0x16686E4")]
		private static string FromBase64(string base64string)
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1668340", Offset = "0x1668340", VA = "0x1668340")]
		private static string XoREncode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x166879C", Offset = "0x166879C", VA = "0x166879C")]
		public StringObfucator()
		{
		}
	}
}
namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x200004E")]
	public enum JSONBinaryTag
	{
		[Token(Token = "0x400015F")]
		Array = 1,
		[Token(Token = "0x4000160")]
		Class,
		[Token(Token = "0x4000161")]
		Value,
		[Token(Token = "0x4000162")]
		IntValue,
		[Token(Token = "0x4000163")]
		DoubleValue,
		[Token(Token = "0x4000164")]
		BoolValue,
		[Token(Token = "0x4000165")]
		FloatValue
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6DE77C", Offset = "0x6DE77C")]
	public class JSONNode
	{
		[Token(Token = "0x20000C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE9EC", Offset = "0x6DE9EC")]
		private sealed class <get_Childs>d__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x17000066")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600057A")]
				[Address(RVA = "0x1666DD8", Offset = "0x1666DD8", VA = "0x1666DD8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600057C")]
				[Address(RVA = "0x1666E48", Offset = "0x1666E48", VA = "0x1666E48", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0x1665A68", Offset = "0x1665A68", VA = "0x1665A68")]
			[DebuggerHidden]
			public <get_Childs>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000578")]
			[Address(RVA = "0x1666DBC", Offset = "0x1666DBC", VA = "0x1666DBC", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0x1666DC0", Offset = "0x1666DC0", VA = "0x1666DC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600057B")]
			[Address(RVA = "0x1666DE0", Offset = "0x1666DE0", VA = "0x1666DE0", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600057D")]
			[Address(RVA = "0x1666E50", Offset = "0x1666E50", VA = "0x1666E50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600057E")]
			[Address(RVA = "0x1666EE8", Offset = "0x1666EE8", VA = "0x1666EE8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE9FC", Offset = "0x6DE9FC")]
		private sealed class <get_DeepChilds>d__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x17000068")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000584")]
				[Address(RVA = "0x1667544", Offset = "0x1667544", VA = "0x1667544", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000069")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000586")]
				[Address(RVA = "0x16675B4", Offset = "0x16675B4", VA = "0x16675B4", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600057F")]
			[Address(RVA = "0x1665B24", Offset = "0x1665B24", VA = "0x1665B24")]
			[DebuggerHidden]
			public <get_DeepChilds>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0x1666EEC", Offset = "0x1666EEC", VA = "0x1666EEC", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x1667108", Offset = "0x1667108", VA = "0x1667108", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x1667048", Offset = "0x1667048", VA = "0x1667048")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x1666F88", Offset = "0x1666F88", VA = "0x1666F88")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x166754C", Offset = "0x166754C", VA = "0x166754C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x16675BC", Offset = "0x16675BC", VA = "0x16675BC", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0x166766C", Offset = "0x166766C", VA = "0x166766C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x166590C", Offset = "0x166590C", VA = "0x166590C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x1665914", Offset = "0x1665914", VA = "0x1665914", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x1665918", Offset = "0x1665918", VA = "0x1665918", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x1665920", Offset = "0x1665920", VA = "0x1665920", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public virtual string Value
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x1665924", Offset = "0x1665924", VA = "0x1665924", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x166596C", Offset = "0x166596C", VA = "0x166596C", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public virtual int Count
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x1665970", Offset = "0x1665970", VA = "0x1665970", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000016")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x16659F8", Offset = "0x16659F8", VA = "0x16659F8", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DFBB0", Offset = "0x6DFBB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x1665AA0", Offset = "0x1665AA0", VA = "0x1665AA0")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DFC14", Offset = "0x6DFC14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public virtual int AsInt
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x1665BEC", Offset = "0x1665BEC", VA = "0x1665BEC", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x1665C2C", Offset = "0x1665C2C", VA = "0x1665C2C", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x1665C6C", Offset = "0x1665C6C", VA = "0x1665C6C", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x1665CB0", Offset = "0x1665CB0", VA = "0x1665CB0", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x1665CF0", Offset = "0x1665CF0", VA = "0x1665CF0", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x1665D94", Offset = "0x1665D94", VA = "0x1665D94", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x1665DD4", Offset = "0x1665DD4", VA = "0x1665DD4", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x1665E9C", Offset = "0x1665E9C", VA = "0x1665E9C", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x1665F20", Offset = "0x1665F20", VA = "0x1665F20", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x1665FA0", Offset = "0x1665FA0", VA = "0x1665FA0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1665908", Offset = "0x1665908", VA = "0x1665908", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1665978", Offset = "0x1665978", VA = "0x1665978", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x16659E0", Offset = "0x16659E0", VA = "0x16659E0", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x16659E8", Offset = "0x16659E8", VA = "0x16659E8", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x16659F0", Offset = "0x16659F0", VA = "0x16659F0", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1665B5C", Offset = "0x1665B5C", VA = "0x1665B5C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1665BA4", Offset = "0x1665BA4", VA = "0x1665BA4", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1666020", Offset = "0x1666020", VA = "0x1666020")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1666084", Offset = "0x1666084", VA = "0x1666084")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x16643E0", Offset = "0x16643E0", VA = "0x16643E0")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x16660D4", Offset = "0x16660D4", VA = "0x16660D4")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x16660F0", Offset = "0x16660F0", VA = "0x16660F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1665370", Offset = "0x1665370", VA = "0x1665370", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1663AB8", Offset = "0x1663AB8", VA = "0x1663AB8")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x16613F8", Offset = "0x16613F8", VA = "0x16613F8")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x16660FC", Offset = "0x16660FC", VA = "0x16660FC", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1666100", Offset = "0x1666100", VA = "0x1666100")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1666180", Offset = "0x1666180", VA = "0x1666180")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x16661F4", Offset = "0x16661F4", VA = "0x16661F4")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1666268", Offset = "0x1666268", VA = "0x1666268")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x16662DC", Offset = "0x16662DC", VA = "0x16662DC")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1666450", Offset = "0x1666450", VA = "0x1666450")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x16665DC", Offset = "0x16665DC", VA = "0x16665DC")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x166697C", Offset = "0x166697C", VA = "0x166697C")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x16669F0", Offset = "0x16669F0", VA = "0x16669F0")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1666A64", Offset = "0x1666A64", VA = "0x1666A64")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1666AD8", Offset = "0x1666AD8", VA = "0x1666AD8")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1666BF8", Offset = "0x1666BF8", VA = "0x1666BF8")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1666D04", Offset = "0x1666D04", VA = "0x1666D04")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1662734", Offset = "0x1662734", VA = "0x1662734")]
		public JSONNode()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6DE7B4", Offset = "0x6DE7B4")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEA0C", Offset = "0x6DEA0C")]
		private sealed class <get_Childs>d__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700006A")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600058D")]
				[Address(RVA = "0x1662B84", Offset = "0x1662B84", VA = "0x1662B84", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600058F")]
				[Address(RVA = "0x1662BF4", Offset = "0x1662BF4", VA = "0x1662BF4", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0x16620C8", Offset = "0x16620C8", VA = "0x16620C8")]
			[DebuggerHidden]
			public <get_Childs>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600058A")]
			[Address(RVA = "0x166299C", Offset = "0x166299C", VA = "0x166299C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0x1662A10", Offset = "0x1662A10", VA = "0x1662A10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600058C")]
			[Address(RVA = "0x16629B8", Offset = "0x16629B8", VA = "0x16629B8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0x1662B8C", Offset = "0x1662B8C", VA = "0x1662B8C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000590")]
			[Address(RVA = "0x1662BFC", Offset = "0x1662BFC", VA = "0x1662BFC", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000591")]
			[Address(RVA = "0x1662CAC", Offset = "0x1662CAC", VA = "0x1662CAC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEA1C", Offset = "0x6DEA1C")]
		private sealed class <GetEnumerator>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONArray <>4__this;

			[Token(Token = "0x40002FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700006C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000596")]
				[Address(RVA = "0x1662924", Offset = "0x1662924", VA = "0x1662924", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000598")]
				[Address(RVA = "0x1662994", Offset = "0x1662994", VA = "0x1662994", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000592")]
			[Address(RVA = "0x1662174", Offset = "0x1662174", VA = "0x1662174")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000593")]
			[Address(RVA = "0x166273C", Offset = "0x166273C", VA = "0x166273C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000594")]
			[Address(RVA = "0x16627B0", Offset = "0x16627B0", VA = "0x16627B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000595")]
			[Address(RVA = "0x1662758", Offset = "0x1662758", VA = "0x1662758")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000597")]
			[Address(RVA = "0x166292C", Offset = "0x166292C", VA = "0x166292C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x1700001E")]
		public override JSONNode Item
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x1661B74", Offset = "0x1661B74", VA = "0x1661B74", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x1661C70", Offset = "0x1661C70", VA = "0x1661C70", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public override JSONNode Item
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x1661D4C", Offset = "0x1661D4C", VA = "0x1661D4C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x1661DB0", Offset = "0x1661DB0", VA = "0x1661DB0", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public override int Count
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x1661E20", Offset = "0x1661E20", VA = "0x1661E20", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000021")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x1662044", Offset = "0x1662044", VA = "0x1662044", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DFC78", Offset = "0x6DFC78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1661E80", Offset = "0x1661E80", VA = "0x1661E80", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1661EF0", Offset = "0x1661EF0", VA = "0x1661EF0", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1661FCC", Offset = "0x1661FCC", VA = "0x1661FCC", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1662100", Offset = "0x1662100", VA = "0x1662100", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DFCDC", Offset = "0x6DFCDC")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x16621A0", Offset = "0x16621A0", VA = "0x16621A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x166236C", Offset = "0x166236C", VA = "0x166236C", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1662598", Offset = "0x1662598", VA = "0x1662598", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x16626C4", Offset = "0x16626C4", VA = "0x16626C4")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6DE7EC", Offset = "0x6DE7EC")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEA2C", Offset = "0x6DEA2C")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x1663564", Offset = "0x1663564", VA = "0x1663564")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x1664374", Offset = "0x1664374", VA = "0x1664374")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEA3C", Offset = "0x6DEA3C")]
		private sealed class <get_Childs>d__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONClass <>4__this;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700006E")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600059F")]
				[Address(RVA = "0x166491C", Offset = "0x166491C", VA = "0x166491C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005A1")]
				[Address(RVA = "0x166498C", Offset = "0x166498C", VA = "0x166498C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600059B")]
			[Address(RVA = "0x16635F0", Offset = "0x16635F0", VA = "0x16635F0")]
			[DebuggerHidden]
			public <get_Childs>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0x1664704", Offset = "0x1664704", VA = "0x1664704", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x1664778", Offset = "0x1664778", VA = "0x1664778", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600059E")]
			[Address(RVA = "0x1664720", Offset = "0x1664720", VA = "0x1664720")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x1664924", Offset = "0x1664924", VA = "0x1664924", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x1664994", Offset = "0x1664994", VA = "0x1664994", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x1664A44", Offset = "0x1664A44", VA = "0x1664A44", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEA4C", Offset = "0x6DEA4C")]
		private sealed class <GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONClass <>4__this;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000070")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005A8")]
				[Address(RVA = "0x166468C", Offset = "0x166468C", VA = "0x166468C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005AA")]
				[Address(RVA = "0x16646FC", Offset = "0x16646FC", VA = "0x16646FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x166369C", Offset = "0x166369C", VA = "0x166369C")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x1664478", Offset = "0x1664478", VA = "0x1664478", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x16644EC", Offset = "0x16644EC", VA = "0x16644EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x1664494", Offset = "0x1664494", VA = "0x1664494")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x1664694", Offset = "0x1664694", VA = "0x1664694", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x17000022")]
		public override JSONNode Item
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x1662CB0", Offset = "0x1662CB0", VA = "0x1662CB0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x1662DB8", Offset = "0x1662DB8", VA = "0x1662DB8", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public override JSONNode Item
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x1662E8C", Offset = "0x1662E8C", VA = "0x1662E8C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x1662F50", Offset = "0x1662F50", VA = "0x1662F50", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public override int Count
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x1663040", Offset = "0x1663040", VA = "0x1663040", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000025")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x166356C", Offset = "0x166356C", VA = "0x166356C", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DFD40", Offset = "0x6DFD40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x16630A0", Offset = "0x16630A0", VA = "0x16630A0", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x16631D8", Offset = "0x16631D8", VA = "0x16631D8", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x16632B0", Offset = "0x16632B0", VA = "0x16632B0", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x16633B0", Offset = "0x16633B0", VA = "0x16633B0", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1663628", Offset = "0x1663628", VA = "0x1663628", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DFDA4", Offset = "0x6DFDA4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x16636C8", Offset = "0x16636C8", VA = "0x16636C8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1663C44", Offset = "0x1663C44", VA = "0x1663C44", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x16640B8", Offset = "0x16640B8", VA = "0x16640B8", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x16642C8", Offset = "0x16642C8", VA = "0x16642C8")]
		public JSONClass()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x17000026")]
		public override string Value
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x1664A48", Offset = "0x1664A48", VA = "0x1664A48", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x1664A50", Offset = "0x1664A50", VA = "0x1664A50", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1664A58", Offset = "0x1664A58", VA = "0x1664A58")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1664A84", Offset = "0x1664A84", VA = "0x1664A84")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1664AC8", Offset = "0x1664AC8", VA = "0x1664AC8")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1664B0C", Offset = "0x1664B0C", VA = "0x1664B0C")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1664B48", Offset = "0x1664B48", VA = "0x1664B48")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1664B84", Offset = "0x1664B84", VA = "0x1664B84", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1664BE8", Offset = "0x1664BE8", VA = "0x1664BE8", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1664C4C", Offset = "0x1664C4C", VA = "0x1664C4C", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6DE824", Offset = "0x6DE824")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x17000027")]
		public override JSONNode Item
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x166500C", Offset = "0x166500C", VA = "0x166500C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x1665070", Offset = "0x1665070", VA = "0x1665070", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public override JSONNode Item
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x16650FC", Offset = "0x16650FC", VA = "0x16650FC", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x166516C", Offset = "0x166516C", VA = "0x166516C", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public override int AsInt
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x1665408", Offset = "0x1665408", VA = "0x1665408", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x166548C", Offset = "0x166548C", VA = "0x166548C", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public override float AsFloat
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x1665514", Offset = "0x1665514", VA = "0x1665514", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x1665598", Offset = "0x1665598", VA = "0x1665598", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public override double AsDouble
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x1665620", Offset = "0x1665620", VA = "0x1665620", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x16656A4", Offset = "0x16656A4", VA = "0x16656A4", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public override bool AsBool
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x166572C", Offset = "0x166572C", VA = "0x166572C", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x16657B0", Offset = "0x16657B0", VA = "0x16657B0", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x1665838", Offset = "0x1665838", VA = "0x1665838", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x16658A0", Offset = "0x16658A0", VA = "0x16658A0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1661C44", Offset = "0x1661C44", VA = "0x1661C44")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1662D80", Offset = "0x1662D80", VA = "0x1662D80")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1664F90", Offset = "0x1664F90", VA = "0x1664F90")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1665200", Offset = "0x1665200", VA = "0x1665200", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x166528C", Offset = "0x166528C", VA = "0x166528C", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1665320", Offset = "0x1665320", VA = "0x1665320")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1665338", Offset = "0x1665338", VA = "0x1665338")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1665350", Offset = "0x1665350", VA = "0x1665350", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1665368", Offset = "0x1665368", VA = "0x1665368", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1665378", Offset = "0x1665378", VA = "0x1665378", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x16653C0", Offset = "0x16653C0", VA = "0x16653C0", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
	[Token(Token = "0x2000054")]
	public static class JSON
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x16613F4", Offset = "0x16613F4", VA = "0x16613F4")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000055")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEA5C", Offset = "0x6DEA5C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xCA5168", Offset = "0xCA5168", VA = "0xCA5168")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xCA594C", Offset = "0xCA594C", VA = "0xCA594C")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xCA597C", Offset = "0xCA597C", VA = "0xCA597C")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEA6C", Offset = "0x6DEA6C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0xCA52B0", Offset = "0xCA52B0", VA = "0xCA52B0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xCA59BC", Offset = "0xCA59BC", VA = "0xCA59BC")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0xCA59EC", Offset = "0xCA59EC", VA = "0xCA59EC")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEA7C", Offset = "0x6DEA7C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xCA5418", Offset = "0xCA5418", VA = "0xCA5418")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0xCA5A2C", Offset = "0xCA5A2C", VA = "0xCA5A2C")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xCA5A78", Offset = "0xCA5A78", VA = "0xCA5A78")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xCA5000", Offset = "0xCA5000", VA = "0xCA5000")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xCA5170", Offset = "0xCA5170", VA = "0xCA5170")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xCA52B8", Offset = "0xCA52B8", VA = "0xCA52B8")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xCA5420", Offset = "0xCA5420", VA = "0xCA5420")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xCA5498", Offset = "0xCA5498", VA = "0xCA5498")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xCA5510", Offset = "0xCA5510", VA = "0xCA5510")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xCA5578", Offset = "0xCA5578", VA = "0xCA5578")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xCA5600", Offset = "0xCA5600", VA = "0xCA5600")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xCA5668", Offset = "0xCA5668", VA = "0xCA5668")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xCA56D0", Offset = "0xCA56D0", VA = "0xCA56D0")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xCA5738", Offset = "0xCA5738", VA = "0xCA5738")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xCA57A0", Offset = "0xCA57A0", VA = "0xCA57A0")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xCA5810", Offset = "0xCA5810", VA = "0xCA5810")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xCA587C", Offset = "0xCA587C", VA = "0xCA587C")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xCA58E4", Offset = "0xCA58E4", VA = "0xCA58E4")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000056")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x20000CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEA8C", Offset = "0x6DEA8C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0xB98008", Offset = "0xB98008", VA = "0xB98008")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xB98010", Offset = "0xB98010", VA = "0xB98010")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEA9C", Offset = "0x6DEA9C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0xB981A0", Offset = "0xB981A0", VA = "0xB981A0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xB981A8", Offset = "0xB981A8", VA = "0xB981A8")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEAAC", Offset = "0x6DEAAC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xB981D8", Offset = "0xB981D8", VA = "0xB981D8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xB981E0", Offset = "0xB981E0", VA = "0xB981E0")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEABC", Offset = "0x6DEABC")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xB98210", Offset = "0xB98210", VA = "0xB98210")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xB98218", Offset = "0xB98218", VA = "0xB98218")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEACC", Offset = "0x6DEACC")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xB98248", Offset = "0xB98248", VA = "0xB98248")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xB98250", Offset = "0xB98250", VA = "0xB98250")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEADC", Offset = "0x6DEADC")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0xB98280", Offset = "0xB98280", VA = "0xB98280")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xB98288", Offset = "0xB98288", VA = "0xB98288")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEAEC", Offset = "0x6DEAEC")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xB982B8", Offset = "0xB982B8", VA = "0xB982B8")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xB982C0", Offset = "0xB982C0", VA = "0xB982C0")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xB982F0", Offset = "0xB982F0", VA = "0xB982F0")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xB9832C", Offset = "0xB9832C", VA = "0xB9832C")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xB9835C", Offset = "0xB9835C", VA = "0xB9835C")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xB9838C", Offset = "0xB9838C", VA = "0xB9838C")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEAFC", Offset = "0x6DEAFC")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400031B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xB98474", Offset = "0xB98474", VA = "0xB98474")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xB9847C", Offset = "0xB9847C", VA = "0xB9847C")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEB0C", Offset = "0x6DEB0C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xB984AC", Offset = "0xB984AC", VA = "0xB984AC")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xB984B4", Offset = "0xB984B4", VA = "0xB984B4")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0xB984E4", Offset = "0xB984E4", VA = "0xB984E4")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEB1C", Offset = "0x6DEB1C")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xB9860C", Offset = "0xB9860C", VA = "0xB9860C")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0xB98614", Offset = "0xB98614", VA = "0xB98614")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEB2C", Offset = "0x6DEB2C")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xB98040", Offset = "0xB98040", VA = "0xB98040")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xB98048", Offset = "0xB98048", VA = "0xB98048")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xB98078", Offset = "0xB98078", VA = "0xB98078")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xCA5ABC", Offset = "0xCA5ABC", VA = "0xCA5ABC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xCA5C3C", Offset = "0xCA5C3C", VA = "0xCA5C3C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xCA5DD4", Offset = "0xCA5DD4", VA = "0xCA5DD4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xCA5F6C", Offset = "0xCA5F6C", VA = "0xCA5F6C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xCA6104", Offset = "0xCA6104", VA = "0xCA6104")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xCA6288", Offset = "0xCA6288", VA = "0xCA6288")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xCA64A4", Offset = "0xCA64A4", VA = "0xCA64A4")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xCA6978", Offset = "0xCA6978", VA = "0xCA6978")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xCA6BA0", Offset = "0xCA6BA0", VA = "0xCA6BA0")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xCA6E20", Offset = "0xCA6E20", VA = "0xCA6E20")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xCA6FD4", Offset = "0xCA6FD4", VA = "0xCA6FD4")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000057")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEB3C", Offset = "0x6DEB3C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xB987AC", Offset = "0xB987AC", VA = "0xB987AC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xB98D1C", Offset = "0xB98D1C", VA = "0xB98D1C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0xB98D4C", Offset = "0xB98D4C", VA = "0xB98D4C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEB4C", Offset = "0x6DEB4C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0xB988F4", Offset = "0xB988F4", VA = "0xB988F4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xB98DAC", Offset = "0xB98DAC", VA = "0xB98DAC")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xB98DDC", Offset = "0xB98DDC", VA = "0xB98DDC")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEB5C", Offset = "0x6DEB5C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0xB98D14", Offset = "0xB98D14", VA = "0xB98D14")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xB98E3C", Offset = "0xB98E3C", VA = "0xB98E3C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0xB98E48", Offset = "0xB98E48", VA = "0xB98E48")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xB98644", Offset = "0xB98644", VA = "0xB98644")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xB987B4", Offset = "0xB987B4", VA = "0xB987B4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xB988FC", Offset = "0xB988FC", VA = "0xB988FC")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xB98AE8", Offset = "0xB98AE8", VA = "0xB98AE8")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000058")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x20000D8")]
		public static class Utils
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xB9E8C0", Offset = "0xB9E8C0", VA = "0xB9E8C0")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEB6C", Offset = "0x6DEB6C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0xB99064", Offset = "0xB99064", VA = "0xB99064")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0xB9CD88", Offset = "0xB9CD88", VA = "0xB9CD88")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0xB9CDB8", Offset = "0xB9CDB8", VA = "0xB9CDB8")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEB7C", Offset = "0x6DEB7C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0xB991D4", Offset = "0xB991D4", VA = "0xB991D4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0xB9D318", Offset = "0xB9D318", VA = "0xB9D318")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0xB9D350", Offset = "0xB9D350", VA = "0xB9D350")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEB8C", Offset = "0x6DEB8C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0xB9931C", Offset = "0xB9931C", VA = "0xB9931C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0xB9DC80", Offset = "0xB9DC80", VA = "0xB9DC80")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0xB9DCB8", Offset = "0xB9DCB8", VA = "0xB9DCB8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEB9C", Offset = "0x6DEB9C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0xB9948C", Offset = "0xB9948C", VA = "0xB9948C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0xB9E404", Offset = "0xB9E404", VA = "0xB9E404")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xB9E43C", Offset = "0xB9E43C", VA = "0xB9E43C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEBAC", Offset = "0x6DEBAC")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xB995D4", Offset = "0xB995D4", VA = "0xB995D4")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xB9E4A4", Offset = "0xB9E4A4", VA = "0xB9E4A4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0xB9E4DC", Offset = "0xB9E4DC", VA = "0xB9E4DC")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEBBC", Offset = "0x6DEBBC")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400032A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xB99740", Offset = "0xB99740", VA = "0xB99740")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xB9E544", Offset = "0xB9E544", VA = "0xB9E544")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xB9E574", Offset = "0xB9E574", VA = "0xB9E574")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEBCC", Offset = "0x6DEBCC")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400032B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xB99A9C", Offset = "0xB99A9C", VA = "0xB99A9C")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xB9E5B4", Offset = "0xB9E5B4", VA = "0xB9E5B4")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0xB9E640", Offset = "0xB9E640", VA = "0xB9E640")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEBDC", Offset = "0x6DEBDC")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xB99C04", Offset = "0xB99C04", VA = "0xB99C04")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xB9E6B8", Offset = "0xB9E6B8", VA = "0xB9E6B8")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xB9E744", Offset = "0xB9E744", VA = "0xB9E744")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEBEC", Offset = "0x6DEBEC")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xB99D6C", Offset = "0xB99D6C", VA = "0xB99D6C")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xB9E7BC", Offset = "0xB9E7BC", VA = "0xB9E7BC")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xB9E848", Offset = "0xB9E848", VA = "0xB9E848")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEBFC", Offset = "0x6DEBFC")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xB99EDC", Offset = "0xB99EDC", VA = "0xB99EDC")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xB9CDF8", Offset = "0xB9CDF8", VA = "0xB9CDF8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xB9CE28", Offset = "0xB9CE28", VA = "0xB9CE28")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEC0C", Offset = "0x6DEC0C")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0xB9A024", Offset = "0xB9A024", VA = "0xB9A024")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xB9CE88", Offset = "0xB9CE88", VA = "0xB9CE88")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0xB9CEB8", Offset = "0xB9CEB8", VA = "0xB9CEB8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEC1C", Offset = "0x6DEC1C")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0xB9A17C", Offset = "0xB9A17C", VA = "0xB9A17C")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0xB9CF18", Offset = "0xB9CF18", VA = "0xB9CF18")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xB9CF48", Offset = "0xB9CF48", VA = "0xB9CF48")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEC2C", Offset = "0x6DEC2C")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xB9A2E4", Offset = "0xB9A2E4", VA = "0xB9A2E4")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xB9CF90", Offset = "0xB9CF90", VA = "0xB9CF90")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0xB9CFC0", Offset = "0xB9CFC0", VA = "0xB9CFC0")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEC3C", Offset = "0x6DEC3C")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000601")]
			[Address(RVA = "0xB9A460", Offset = "0xB9A460", VA = "0xB9A460")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0xB9D008", Offset = "0xB9D008", VA = "0xB9D008")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0xB9D038", Offset = "0xB9D038", VA = "0xB9D038")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEC4C", Offset = "0x6DEC4C")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000604")]
			[Address(RVA = "0xB9A5DC", Offset = "0xB9A5DC", VA = "0xB9A5DC")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0xB9D080", Offset = "0xB9D080", VA = "0xB9D080")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0xB9D0B0", Offset = "0xB9D0B0", VA = "0xB9D0B0")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEC5C", Offset = "0x6DEC5C")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000607")]
			[Address(RVA = "0xB9A74C", Offset = "0xB9A74C", VA = "0xB9A74C")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0xB9D0F8", Offset = "0xB9D0F8", VA = "0xB9D0F8")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0xB9D128", Offset = "0xB9D128", VA = "0xB9D128")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEC6C", Offset = "0x6DEC6C")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600060A")]
			[Address(RVA = "0xB9A8D4", Offset = "0xB9A8D4", VA = "0xB9A8D4")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0xB9D180", Offset = "0xB9D180", VA = "0xB9D180")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0xB9D1B0", Offset = "0xB9D1B0", VA = "0xB9D1B0")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEC7C", Offset = "0x6DEC7C")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600060D")]
			[Address(RVA = "0xB9AA5C", Offset = "0xB9AA5C", VA = "0xB9AA5C")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0xB9D208", Offset = "0xB9D208", VA = "0xB9D208")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0xB9D238", Offset = "0xB9D238", VA = "0xB9D238")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEC8C", Offset = "0x6DEC8C")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000610")]
			[Address(RVA = "0xB9ABE4", Offset = "0xB9ABE4", VA = "0xB9ABE4")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0xB9D290", Offset = "0xB9D290", VA = "0xB9D290")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0xB9D2C0", Offset = "0xB9D2C0", VA = "0xB9D2C0")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEC9C", Offset = "0x6DEC9C")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000613")]
			[Address(RVA = "0xB9AD4C", Offset = "0xB9AD4C", VA = "0xB9AD4C")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0xB9D3B8", Offset = "0xB9D3B8", VA = "0xB9D3B8")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0xB9D3E8", Offset = "0xB9D3E8", VA = "0xB9D3E8")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DECAC", Offset = "0x6DECAC")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000616")]
			[Address(RVA = "0xB9AEB4", Offset = "0xB9AEB4", VA = "0xB9AEB4")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0xB9D430", Offset = "0xB9D430", VA = "0xB9D430")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0xB9D460", Offset = "0xB9D460", VA = "0xB9D460")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DECBC", Offset = "0x6DECBC")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000619")]
			[Address(RVA = "0xB9B00C", Offset = "0xB9B00C", VA = "0xB9B00C")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0xB9D4A8", Offset = "0xB9D4A8", VA = "0xB9D4A8")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0xB9D4D8", Offset = "0xB9D4D8", VA = "0xB9D4D8")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DECCC", Offset = "0x6DECCC")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600061C")]
			[Address(RVA = "0xB9B17C", Offset = "0xB9B17C", VA = "0xB9B17C")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0xB9D520", Offset = "0xB9D520", VA = "0xB9D520")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0xB9D550", Offset = "0xB9D550", VA = "0xB9D550")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DECDC", Offset = "0x6DECDC")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600061F")]
			[Address(RVA = "0xB9B2EC", Offset = "0xB9B2EC", VA = "0xB9B2EC")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0xB9D598", Offset = "0xB9D598", VA = "0xB9D598")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0xB9D5C8", Offset = "0xB9D5C8", VA = "0xB9D5C8")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DECEC", Offset = "0x6DECEC")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000622")]
			[Address(RVA = "0xB9B454", Offset = "0xB9B454", VA = "0xB9B454")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0xB9D610", Offset = "0xB9D610", VA = "0xB9D610")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0xB9D640", Offset = "0xB9D640", VA = "0xB9D640")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DECFC", Offset = "0x6DECFC")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000625")]
			[Address(RVA = "0xB9B610", Offset = "0xB9B610", VA = "0xB9B610")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0xB9D688", Offset = "0xB9D688", VA = "0xB9D688")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0xB9D720", Offset = "0xB9D720", VA = "0xB9D720")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DED0C", Offset = "0x6DED0C")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000628")]
			[Address(RVA = "0xB9B79C", Offset = "0xB9B79C", VA = "0xB9B79C")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0xB9D7D8", Offset = "0xB9D7D8", VA = "0xB9D7D8")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0xB9D870", Offset = "0xB9D870", VA = "0xB9D870")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DED1C", Offset = "0x6DED1C")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600062B")]
			[Address(RVA = "0xB9B974", Offset = "0xB9B974", VA = "0xB9B974")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0xB9D928", Offset = "0xB9D928", VA = "0xB9D928")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0xB9D9C0", Offset = "0xB9D9C0", VA = "0xB9D9C0")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DED2C", Offset = "0x6DED2C")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x600062E")]
			[Address(RVA = "0xB9BD50", Offset = "0xB9BD50", VA = "0xB9BD50")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0xB9DA78", Offset = "0xB9DA78", VA = "0xB9DA78")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0xB9DAA8", Offset = "0xB9DAA8", VA = "0xB9DAA8")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0xB9DAF0", Offset = "0xB9DAF0", VA = "0xB9DAF0")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0xB9DB2C", Offset = "0xB9DB2C", VA = "0xB9DB2C")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0xB9DB5C", Offset = "0xB9DB5C", VA = "0xB9DB5C")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0xB9DBA4", Offset = "0xB9DBA4", VA = "0xB9DBA4")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DED3C", Offset = "0x6DED3C")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000635")]
			[Address(RVA = "0xB9BEAC", Offset = "0xB9BEAC", VA = "0xB9BEAC")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0xB9DD20", Offset = "0xB9DD20", VA = "0xB9DD20")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0xB9DD9C", Offset = "0xB9DD9C", VA = "0xB9DD9C")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DED4C", Offset = "0x6DED4C")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000638")]
			[Address(RVA = "0xB9BFF8", Offset = "0xB9BFF8", VA = "0xB9BFF8")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0xB9DE04", Offset = "0xB9DE04", VA = "0xB9DE04")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0xB9DE34", Offset = "0xB9DE34", VA = "0xB9DE34")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DED5C", Offset = "0x6DED5C")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600063B")]
			[Address(RVA = "0xB9C144", Offset = "0xB9C144", VA = "0xB9C144")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0xB9DE74", Offset = "0xB9DE74", VA = "0xB9DE74")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0xB9DEA4", Offset = "0xB9DEA4", VA = "0xB9DEA4")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DED6C", Offset = "0x6DED6C")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x600063E")]
			[Address(RVA = "0xB9C29C", Offset = "0xB9C29C", VA = "0xB9C29C")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0xB9DEE4", Offset = "0xB9DEE4", VA = "0xB9DEE4")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0xB9DF1C", Offset = "0xB9DF1C", VA = "0xB9DF1C")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DED7C", Offset = "0x6DED7C")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000641")]
			[Address(RVA = "0xB9C40C", Offset = "0xB9C40C", VA = "0xB9C40C")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0xB9DF64", Offset = "0xB9DF64", VA = "0xB9DF64")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0xB9DF9C", Offset = "0xB9DF9C", VA = "0xB9DF9C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DED8C", Offset = "0x6DED8C")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000644")]
			[Address(RVA = "0xB9C554", Offset = "0xB9C554", VA = "0xB9C554")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0xB9E004", Offset = "0xB9E004", VA = "0xB9E004")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0xB9E03C", Offset = "0xB9E03C", VA = "0xB9E03C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DED9C", Offset = "0x6DED9C")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000647")]
			[Address(RVA = "0xB9C6CC", Offset = "0xB9C6CC", VA = "0xB9C6CC")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0xB9E0A4", Offset = "0xB9E0A4", VA = "0xB9E0A4")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0xB9E0DC", Offset = "0xB9E0DC", VA = "0xB9E0DC")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEDAC", Offset = "0x6DEDAC")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x600064A")]
			[Address(RVA = "0xB9C908", Offset = "0xB9C908", VA = "0xB9C908")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0xB9E11C", Offset = "0xB9E11C", VA = "0xB9E11C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0xB9E128", Offset = "0xB9E128", VA = "0xB9E128")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEDBC", Offset = "0x6DEDBC")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x600064D")]
			[Address(RVA = "0xB9CB44", Offset = "0xB9CB44", VA = "0xB9CB44")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0xB9E214", Offset = "0xB9E214", VA = "0xB9E214")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0xB9E220", Offset = "0xB9E220", VA = "0xB9E220")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEDCC", Offset = "0x6DEDCC")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x6000650")]
			[Address(RVA = "0xB9CD80", Offset = "0xB9CD80", VA = "0xB9CD80")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0xB9E30C", Offset = "0xB9E30C", VA = "0xB9E30C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0xB9E318", Offset = "0xB9E318", VA = "0xB9E318")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xB98F24", Offset = "0xB98F24", VA = "0xB98F24")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xB9906C", Offset = "0xB9906C", VA = "0xB9906C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xB991DC", Offset = "0xB991DC", VA = "0xB991DC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xB99324", Offset = "0xB99324", VA = "0xB99324")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xB99494", Offset = "0xB99494", VA = "0xB99494")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xB995DC", Offset = "0xB995DC", VA = "0xB995DC")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xB99748", Offset = "0xB99748", VA = "0xB99748")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xB9993C", Offset = "0xB9993C", VA = "0xB9993C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xB99AA4", Offset = "0xB99AA4", VA = "0xB99AA4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xB99C0C", Offset = "0xB99C0C", VA = "0xB99C0C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xB99D74", Offset = "0xB99D74", VA = "0xB99D74")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xB99EE4", Offset = "0xB99EE4", VA = "0xB99EE4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xB9A02C", Offset = "0xB9A02C", VA = "0xB9A02C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xB9A184", Offset = "0xB9A184", VA = "0xB9A184")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xB9A2EC", Offset = "0xB9A2EC", VA = "0xB9A2EC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xB9A468", Offset = "0xB9A468", VA = "0xB9A468")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xB9A5E4", Offset = "0xB9A5E4", VA = "0xB9A5E4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xB9A754", Offset = "0xB9A754", VA = "0xB9A754")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xB9A8DC", Offset = "0xB9A8DC", VA = "0xB9A8DC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xB9AA64", Offset = "0xB9AA64", VA = "0xB9AA64")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xB9ABEC", Offset = "0xB9ABEC", VA = "0xB9ABEC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xB9AD54", Offset = "0xB9AD54", VA = "0xB9AD54")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xB9AEBC", Offset = "0xB9AEBC", VA = "0xB9AEBC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xB9B014", Offset = "0xB9B014", VA = "0xB9B014")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xB9B184", Offset = "0xB9B184", VA = "0xB9B184")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xB9B2F4", Offset = "0xB9B2F4", VA = "0xB9B2F4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xB9B45C", Offset = "0xB9B45C", VA = "0xB9B45C")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xB9B618", Offset = "0xB9B618", VA = "0xB9B618")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xB9B7A4", Offset = "0xB9B7A4", VA = "0xB9B7A4")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xB9B97C", Offset = "0xB9B97C", VA = "0xB9B97C")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xB9BD58", Offset = "0xB9BD58", VA = "0xB9BD58")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xB9BEB4", Offset = "0xB9BEB4", VA = "0xB9BEB4")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xB9C000", Offset = "0xB9C000", VA = "0xB9C000")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xB9C14C", Offset = "0xB9C14C", VA = "0xB9C14C")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xB9C2A4", Offset = "0xB9C2A4", VA = "0xB9C2A4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xB9C414", Offset = "0xB9C414", VA = "0xB9C414")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xB9C55C", Offset = "0xB9C55C", VA = "0xB9C55C")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xB9C6D4", Offset = "0xB9C6D4", VA = "0xB9C6D4")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xB9C910", Offset = "0xB9C910", VA = "0xB9C910")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xB9CB4C", Offset = "0xB9CB4C", VA = "0xB9CB4C")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000059")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEDDC", Offset = "0x6DEDDC")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000653")]
			[Address(RVA = "0xB9F618", Offset = "0xB9F618", VA = "0xB9F618")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0xB9F834", Offset = "0xB9F834", VA = "0xB9F834")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0xB9F86C", Offset = "0xB9F86C", VA = "0xB9F86C")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEDEC", Offset = "0x6DEDEC")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000656")]
			[Address(RVA = "0xB9F82C", Offset = "0xB9F82C", VA = "0xB9F82C")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0xB9F8BC", Offset = "0xB9F8BC", VA = "0xB9F8BC")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0xB9F8F4", Offset = "0xB9F8F4", VA = "0xB9F8F4")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xB9EBD8", Offset = "0xB9EBD8", VA = "0xB9EBD8")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xB9EDC8", Offset = "0xB9EDC8", VA = "0xB9EDC8")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xB9EFCC", Offset = "0xB9EFCC", VA = "0xB9EFCC")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xB9F07C", Offset = "0xB9F07C", VA = "0xB9F07C")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xB9F12C", Offset = "0xB9F12C", VA = "0xB9F12C")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xB9F1DC", Offset = "0xB9F1DC", VA = "0xB9F1DC")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xB9F29C", Offset = "0xB9F29C", VA = "0xB9F29C")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xB9F35C", Offset = "0xB9F35C", VA = "0xB9F35C")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xB9F40C", Offset = "0xB9F40C", VA = "0xB9F40C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xB9F620", Offset = "0xB9F620", VA = "0xB9F620")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200005A")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000102")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000072")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000659")]
				[Address(RVA = "0xCA4C48", Offset = "0xCA4C48", VA = "0xCA4C48", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0xCA4CA0", Offset = "0xCA4CA0", VA = "0xCA4CA0")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000103")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000073")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600065B")]
				[Address(RVA = "0xCA4E8C", Offset = "0xCA4E8C", VA = "0xCA4E8C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0xCA4F40", Offset = "0xCA4F40", VA = "0xCA4F40")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000104")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000074")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600065D")]
				[Address(RVA = "0xCA4D64", Offset = "0xCA4D64", VA = "0xCA4D64", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0xCA4D94", Offset = "0xCA4D94", VA = "0xCA4D94")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000105")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x17000075")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600065F")]
				[Address(RVA = "0xCA4CCC", Offset = "0xCA4CCC", VA = "0xCA4CCC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0xCA4D28", Offset = "0xCA4D28", VA = "0xCA4D28")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x2000106")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x17000076")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000661")]
				[Address(RVA = "0xCA4DC0", Offset = "0xCA4DC0", VA = "0xCA4DC0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0xCA4E50", Offset = "0xCA4E50", VA = "0xCA4E50")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x2000107")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000077")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000663")]
				[Address(RVA = "0xCA4F6C", Offset = "0xCA4F6C", VA = "0xCA4F6C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0xCA4FD4", Offset = "0xCA4FD4", VA = "0xCA4FD4")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x200005B")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000108")]
		public static class Physics
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0xB9FA9C", Offset = "0xB9FA9C", VA = "0xB9FA9C")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0xB9FC88", Offset = "0xB9FC88", VA = "0xB9FC88")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0xB9FC90", Offset = "0xB9FC90", VA = "0xB9FC90")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0xB9FD24", Offset = "0xB9FD24", VA = "0xB9FD24")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xB9F944", Offset = "0xB9F944", VA = "0xB9F944")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xB9F9E8", Offset = "0xB9F9E8", VA = "0xB9F9E8")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
namespace CurvesAndSplines
{
	[Token(Token = "0x200005C")]
	public static class Bezier
	{
		[Token(Token = "0x6000335")]
		[Address(RVA = "0xCA1ED8", Offset = "0xCA1ED8", VA = "0xCA1ED8")]
		public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xCA2064", Offset = "0xCA2064", VA = "0xCA2064")]
		public static Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xCA21C0", Offset = "0xCA21C0", VA = "0xCA21C0")]
		public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xCA23B8", Offset = "0xCA23B8", VA = "0xCA23B8")]
		public static Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200005D")]
	public enum BezierControlPointMode
	{
		[Token(Token = "0x400016D")]
		Free,
		[Token(Token = "0x400016E")]
		Aligned,
		[Token(Token = "0x400016F")]
		Mirrored
	}
	[Token(Token = "0x200005E")]
	public class BezierCurve : MonoBehaviour
	{
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3[] m_points;

		[Token(Token = "0x1700002F")]
		public Vector3[] Points
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0xCA25F8", Offset = "0xCA25F8", VA = "0xCA25F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xCA2600", Offset = "0xCA2600", VA = "0xCA2600")]
		public Vector3 GetPoint(float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xCA278C", Offset = "0xCA278C", VA = "0xCA278C")]
		public Vector3 GetVelocity(float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xCA29BC", Offset = "0xCA29BC", VA = "0xCA29BC")]
		public Vector3 GetDirection(float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xCA29EC", Offset = "0xCA29EC", VA = "0xCA29EC")]
		public void Reset()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xCA2B98", Offset = "0xCA2B98", VA = "0xCA2B98")]
		public BezierCurve()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class BezierSpline : MonoBehaviour
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3[] m_points;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BezierControlPointMode[] m_modes;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_loop;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool m_isReversed;

		[Token(Token = "0x17000030")]
		public bool Loop
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0xCA2BA0", Offset = "0xCA2BA0", VA = "0xCA2BA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000340")]
			[Address(RVA = "0xCA2BA8", Offset = "0xCA2BA8", VA = "0xCA2BA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool IsReversed
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0xCA328C", Offset = "0xCA328C", VA = "0xCA328C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000342")]
			[Address(RVA = "0xCA3294", Offset = "0xCA3294", VA = "0xCA3294")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public int ControlPointCount
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0xCA32A0", Offset = "0xCA32A0", VA = "0xCA32A0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000033")]
		public int CurveCount
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0xCA3898", Offset = "0xCA3898", VA = "0xCA3898")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xCA32CC", Offset = "0xCA32CC", VA = "0xCA32CC")]
		public Vector3 GetControlPoint(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xCA2C98", Offset = "0xCA2C98", VA = "0xCA2C98")]
		public void SetControlPoint(int index, Vector3 point)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xCA36F4", Offset = "0xCA36F4", VA = "0xCA36F4")]
		public BezierControlPointMode GetControlPointMode(int index)
		{
			return default(BezierControlPointMode);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xCA3764", Offset = "0xCA3764", VA = "0xCA3764")]
		public void SetControlPointMode(int index, BezierControlPointMode mode)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xCA3328", Offset = "0xCA3328", VA = "0xCA3328")]
		private void EnforceMode(int index)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xCA38E0", Offset = "0xCA38E0", VA = "0xCA38E0")]
		public Vector3 GetPoint(float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xCA3B80", Offset = "0xCA3B80", VA = "0xCA3B80")]
		public Vector3 GetVelocity(float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xCA3EA4", Offset = "0xCA3EA4", VA = "0xCA3EA4")]
		public Vector3 GetDirection(float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xCA3ED4", Offset = "0xCA3ED4", VA = "0xCA3ED4")]
		public void AddCurve()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xCA42BC", Offset = "0xCA42BC", VA = "0xCA42BC")]
		public void RemoveCurve()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xCA44D4", Offset = "0xCA44D4", VA = "0xCA44D4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xCA4698", Offset = "0xCA4698", VA = "0xCA4698")]
		public BezierSpline()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class Line : MonoBehaviour
	{
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 P0;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 P1;

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xCA46A0", Offset = "0xCA46A0", VA = "0xCA46A0")]
		public Line()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class SplineDecorator : MonoBehaviour
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BezierSpline m_spline;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_frequency;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_lookForward;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform[] m_items;

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xCA46A8", Offset = "0xCA46A8", VA = "0xCA46A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xCA49B0", Offset = "0xCA49B0", VA = "0xCA49B0")]
		public SplineDecorator()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class SplineWalker : MonoBehaviour
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BezierSpline m_spline;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_duration;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_lookForward;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SplineWalkerMode m_mode;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_progress;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_goingForward;

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xCA4A1C", Offset = "0xCA4A1C", VA = "0xCA4A1C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xCA4C2C", Offset = "0xCA4C2C", VA = "0xCA4C2C")]
		public SplineWalker()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public enum SplineWalkerMode
	{
		[Token(Token = "0x4000182")]
		Once,
		[Token(Token = "0x4000183")]
		Loop,
		[Token(Token = "0x4000184")]
		PingPong
	}
}
namespace Cortopia.CortopiaExtensions
{
	[Token(Token = "0x2000064")]
	public static class ExtensionMethods
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEDFC", Offset = "0x6DEDFC")]
		private sealed class <>c__13<T>
		{
			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__13<T> <>9;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<T, string> <>9__13_0;

			[Token(Token = "0x600066A")]
			public <>c__13()
			{
			}

			[Token(Token = "0x600066B")]
			internal string <ToFormattedString>b__13_0(T p)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEE0C", Offset = "0x6DEE0C")]
		private sealed class <>c__14<TK, TV>
		{
			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__14<TK, TV> <>9;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<TK, TV>, string> <>9__14_0;

			[Token(Token = "0x600066D")]
			public <>c__14()
			{
			}

			[Token(Token = "0x600066E")]
			internal string <ToFormattedString>b__14_0(KeyValuePair<TK, TV> p)
			{
				return null;
			}
		}

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Random sm_random;

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xCA069C", Offset = "0xCA069C", VA = "0xCA069C")]
		public static int Wrap(this int value, int min, int max)
		{
			return default(int);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xCA06B8", Offset = "0xCA06B8", VA = "0xCA06B8")]
		public static string SplitCase(this string value)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xCA07AC", Offset = "0xCA07AC", VA = "0xCA07AC")]
		public static string Truncate(this string value, int maxLength)
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xCA0824", Offset = "0xCA0824", VA = "0xCA0824")]
		public static bool IsNullOrEmpty(this string value)
		{
			return default(bool);
		}

		[Token(Token = "0x600035A")]
		public static IList<T> MoveItemToIndex<T>(this IList<T> list, T item, int index)
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		public static T GetRandomElement<T>(this IList<T> list)
		{
			return (T)null;
		}

		[Token(Token = "0x600035C")]
		public static T GetRandomElement<T>(this IList<T> list, T excludedElement) where T : IEquatable<T>
		{
			return (T)null;
		}

		[Token(Token = "0x600035D")]
		public static KeyValuePair<TK, TV> GetRandomElement<TK, TV>(this IDictionary<TK, TV> dictionary)
		{
			return default(KeyValuePair<TK, TV>);
		}

		[Token(Token = "0x600035E")]
		public static void Shuffle<T>(this T[] array)
		{
		}

		[Token(Token = "0x600035F")]
		public static void Shuffle<T>(this IList<T> array)
		{
		}

		[Token(Token = "0x6000360")]
		public static bool IsEmpty<T>(this ICollection<T> collection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		public static string ToFormattedString<T>(this IList<T> list)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		public static string ToFormattedString<TK, TV>(this IDictionary<TK, TV> dictionary)
		{
			return null;
		}

		[Token(Token = "0x6000364")]
		public static bool ContainsFlag<T>(this Enum e, T mask) where T : struct, IConvertible
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		public static bool FastRemove<T>(this IList<T> list, T removeElement)
		{
			return default(bool);
		}

		[Token(Token = "0x6000366")]
		public static void FastRemove<T>(this IList<T> list, int index)
		{
		}
	}
	[Token(Token = "0x2000065")]
	public enum ResetBehaviour
	{
		[Token(Token = "0x4000187")]
		Position = 1,
		[Token(Token = "0x4000188")]
		Rotation = 2,
		[Token(Token = "0x4000189")]
		Scale = 4,
		[Token(Token = "0x400018A")]
		PositionAndRotation = 3,
		[Token(Token = "0x400018B")]
		All = 7
	}
	[Token(Token = "0x2000066")]
	public static class EnumExtensions
	{
		[Token(Token = "0x6000368")]
		[Address(RVA = "0xCA0690", Offset = "0xCA0690", VA = "0xCA0690")]
		public static bool ContainsFlag(this ResetBehaviour a, ResetBehaviour b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000067")]
	public static class UnityExtensionMethods
	{
		[Token(Token = "0x6000369")]
		[Address(RVA = "0xCA08BC", Offset = "0xCA08BC", VA = "0xCA08BC")]
		public static Transform RetrieveOrCreateChild(this Transform transform, string childName, bool includeInactive = false)
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xCA0A5C", Offset = "0xCA0A5C", VA = "0xCA0A5C")]
		public static Transform RetrieveChild(this Transform transform, string childName, bool includeInactive = false, bool includePartials = false)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xCA0BEC", Offset = "0xCA0BEC", VA = "0xCA0BEC")]
		public static void SetParent(this Transform transform, Transform parent, ResetBehaviour resetBehaviour)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xCA0DA0", Offset = "0xCA0DA0", VA = "0xCA0DA0")]
		public static List<Transform> RetrieveChildren(this Transform transform, string childName, bool includeInactive = false, bool includePartials = false)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xCA0F4C", Offset = "0xCA0F4C", VA = "0xCA0F4C")]
		public static Transform FindFirstChildWithName(this Transform transform, string childName)
		{
			return null;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xCA12D8", Offset = "0xCA12D8", VA = "0xCA12D8")]
		public static bool HasParameterOfType(this Animator animator, string parameterName, AnimatorControllerParameterType parameterType)
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		public static T GetOrAddComponent<T>(this Component component) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		public static T GetOrAddComponent<T>(this Transform transform) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xCA13C0", Offset = "0xCA13C0", VA = "0xCA13C0")]
		public static float GetRoll(this Quaternion quaternion)
		{
			return default(float);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xCA1468", Offset = "0xCA1468", VA = "0xCA1468")]
		public static float GetPitch(this Quaternion quaternion)
		{
			return default(float);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xCA1510", Offset = "0xCA1510", VA = "0xCA1510")]
		public static float GetYaw(this Quaternion quaternion)
		{
			return default(float);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xCA15A0", Offset = "0xCA15A0", VA = "0xCA15A0")]
		public static bool IsValid(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xCA15D0", Offset = "0xCA15D0", VA = "0xCA15D0")]
		public static bool IsValidThorough(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xCA16CC", Offset = "0xCA16CC", VA = "0xCA16CC")]
		public static bool AlmostEquals(this Vector3 first, Vector3 second, float sqrMagnitudePrecision)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xCA17B0", Offset = "0xCA17B0", VA = "0xCA17B0")]
		public static bool AlmostEquals(this Vector2 first, Vector2 second, float sqrMagnitudePrecision)
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xCA1874", Offset = "0xCA1874", VA = "0xCA1874")]
		public static bool AlmostEquals(this Quaternion first, Quaternion second, float maxAngle)
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xCA194C", Offset = "0xCA194C", VA = "0xCA194C")]
		public static bool AlmostEquals(this float first, float second, float floatDiff)
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xCA19D4", Offset = "0xCA19D4", VA = "0xCA19D4")]
		public static void SetTimelineBinding(this PlayableDirector director, string trackName, Animator bindingAnimator)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xCA1CB8", Offset = "0xCA1CB8", VA = "0xCA1CB8")]
		public static void SetTimelineBinding(this PlayableDirector director, string trackName, AudioSource bindingAudioSource)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xCA1BF4", Offset = "0xCA1BF4", VA = "0xCA1BF4")]
		public static TrackAsset GetTrackByName(this TimelineAsset timeline, string trackName)
		{
			return null;
		}
	}
}
namespace Cortopia.BE.Runtime
{
	[Token(Token = "0x2000068")]
	public class BehaviourSystem : ScriptableObject
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Node m_firstNode;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private Rect m_startNodeRect;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MonoBehaviour m_owner;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Node> Nodes;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF034", Offset = "0x6DF034")]
		private bool <IsLooping>k__BackingField;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF044", Offset = "0x6DF044")]
		private Node <CurrentNode>k__BackingField;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF054", Offset = "0x6DF054")]
		private NodePriority <CurrentNodePriority>k__BackingField;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF064", Offset = "0x6DF064")]
		private Node <PendingNodeChange>k__BackingField;

		[Token(Token = "0x17000034")]
		public virtual bool IsLooping
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0xC92C58", Offset = "0xC92C58", VA = "0xC92C58", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0598", Offset = "0x6E0598")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600037F")]
			[Address(RVA = "0xC92C60", Offset = "0xC92C60", VA = "0xC92C60", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E05A8", Offset = "0x6E05A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public Node CurrentNode
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0xC92C6C", Offset = "0xC92C6C", VA = "0xC92C6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E05B8", Offset = "0x6E05B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000381")]
			[Address(RVA = "0xC92C74", Offset = "0xC92C74", VA = "0xC92C74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E05C8", Offset = "0x6E05C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public NodePriority CurrentNodePriority
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0xC92C7C", Offset = "0xC92C7C", VA = "0xC92C7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E05D8", Offset = "0x6E05D8")]
			get
			{
				return default(NodePriority);
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0xC92C84", Offset = "0xC92C84", VA = "0xC92C84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E05E8", Offset = "0x6E05E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public Node FirstNode
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0xC92C8C", Offset = "0xC92C8C", VA = "0xC92C8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public Rect StartNodeRect
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0xC92C94", Offset = "0xC92C94", VA = "0xC92C94")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000386")]
			[Address(RVA = "0xC92CA0", Offset = "0xC92CA0", VA = "0xC92CA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public MonoBehaviour Owner
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0xC92CAC", Offset = "0xC92CAC", VA = "0xC92CAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000388")]
			[Address(RVA = "0xC92CB4", Offset = "0xC92CB4", VA = "0xC92CB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public Node PendingNodeChange
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0xC92FCC", Offset = "0xC92FCC", VA = "0xC92FCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E05F8", Offset = "0x6E05F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038A")]
			[Address(RVA = "0xC92FD4", Offset = "0xC92FD4", VA = "0xC92FD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0608", Offset = "0x6E0608")]
			private set
			{
			}
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xC92CB8", Offset = "0xC92CB8", VA = "0xC92CB8")]
		private void SetOwner(MonoBehaviour owner)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xC93174", Offset = "0xC93174", VA = "0xC93174")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xC932A8", Offset = "0xC932A8", VA = "0xC932A8")]
		public void UpdateReferences()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xC933D4", Offset = "0xC933D4", VA = "0xC933D4")]
		public void AddNode(Node newNode)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xC93480", Offset = "0xC93480", VA = "0xC93480")]
		public void RemoveNode(Node node)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xC934F0", Offset = "0xC934F0", VA = "0xC934F0")]
		public void SetFirstNode(Node node)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xC931F8", Offset = "0xC931F8", VA = "0xC931F8")]
		public void ChangeNode(Node newNode)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xC935CC", Offset = "0xC935CC", VA = "0xC935CC")]
		public void SetPendingNodeChange(Node newNode)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xC93714", Offset = "0xC93714", VA = "0xC93714")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xC9371C", Offset = "0xC9371C", VA = "0xC9371C")]
		public void Restart()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xC93724", Offset = "0xC93724", VA = "0xC93724")]
		private void NodeFinished()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xC9383C", Offset = "0xC9383C", VA = "0xC9383C", Slot = "6")]
		public virtual bool UpdateNode()
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xC93908", Offset = "0xC93908", VA = "0xC93908")]
		public BehaviourSystem()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class BehaviourTree : BehaviourSystem
	{
		[Token(Token = "0x4000194")]
		private const int m_maxIterationCount = 64;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private State m_ownerState;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_doStateIteration;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF0AC", Offset = "0x6DF0AC")]
		private Branch <LastBranch>k__BackingField;

		[Token(Token = "0x1700003B")]
		public State OwnerState
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0xC93978", Offset = "0xC93978", VA = "0xC93978")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000399")]
			[Address(RVA = "0xC93980", Offset = "0xC93980", VA = "0xC93980")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public Branch LastBranch
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0xC93988", Offset = "0xC93988", VA = "0xC93988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0618", Offset = "0x6E0618")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039B")]
			[Address(RVA = "0xC93990", Offset = "0xC93990", VA = "0xC93990")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0628", Offset = "0x6E0628")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public override bool IsLooping
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0xC93998", Offset = "0xC93998", VA = "0xC93998", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xC939A0", Offset = "0xC939A0", VA = "0xC939A0", Slot = "6")]
		public override bool UpdateNode()
		{
			return default(bool);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xC93B2C", Offset = "0xC93B2C", VA = "0xC93B2C")]
		public BehaviourTree()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class BE_Objective
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<Func<bool>> m_objectiveConditions;

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xC92A04", Offset = "0xC92A04", VA = "0xC92A04")]
		public BE_Objective([Optional] Func<bool> condition)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xC92AA4", Offset = "0xC92AA4", VA = "0xC92AA4")]
		public void AddCondition(Func<bool> condition)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xC92B14", Offset = "0xC92B14", VA = "0xC92B14")]
		public bool AreAllConditionsMet()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200006B")]
	public class StateMachine : BehaviourSystem
	{
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_isLooping;

		[Token(Token = "0x1700003E")]
		public override bool IsLooping
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0xCA0640", Offset = "0xCA0640", VA = "0xCA0640", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0xCA0648", Offset = "0xCA0648", VA = "0xCA0648", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xCA0654", Offset = "0xCA0654", VA = "0xCA0654")]
		public StateMachine()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Transition
{
	[Serializable]
	[Token(Token = "0x200006C")]
	public class BE_Transition
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Node From;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Node To;

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xCA0658", Offset = "0xCA0658", VA = "0xCA0658")]
		public BE_Transition(Node from, Node to)
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Nodes
{
	[Token(Token = "0x200006D")]
	public class Branch : Node
	{
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xC9F05C", Offset = "0xC9F05C", VA = "0xC9F05C", Slot = "6")]
		public override void UpdateNode()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xC9F16C", Offset = "0xC9F16C", VA = "0xC9F16C")]
		public Branch()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class Node : ScriptableObject
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<BE_Transition> m_transitions;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<BE_Action> m_beActions;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BE_Transition m_activeTransition;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<BE_Action> m_actionsToProcessThisUpdate;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<BE_Action> m_processedActionsThisUpdate;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<BE_Action> m_finishedActions;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF0EC", Offset = "0x6DF0EC")]
		private string <Name>k__BackingField;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF0FC", Offset = "0x6DF0FC")]
		private MonoBehaviour <Owner>k__BackingField;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF10C", Offset = "0x6DF10C")]
		private bool <IsRunning>k__BackingField;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF11C", Offset = "0x6DF11C")]
		private bool <IsFinished>k__BackingField;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF12C", Offset = "0x6DF12C")]
		private int <Index>k__BackingField;

		[Token(Token = "0x1700003F")]
		public List<BE_Action> Actions
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xC9F26C", Offset = "0xC9F26C", VA = "0xC9F26C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public string Name
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xC9F274", Offset = "0xC9F274", VA = "0xC9F274")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0638", Offset = "0x6E0638")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xC9F27C", Offset = "0xC9F27C", VA = "0xC9F27C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0648", Offset = "0x6E0648")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public MonoBehaviour Owner
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0xC8F584", Offset = "0xC8F584", VA = "0xC8F584")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0658", Offset = "0x6E0658")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xC9F284", Offset = "0xC9F284", VA = "0xC9F284")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0668", Offset = "0x6E0668")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public bool IsRunning
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xC9F28C", Offset = "0xC9F28C", VA = "0xC9F28C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0678", Offset = "0x6E0678")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xC9F294", Offset = "0xC9F294", VA = "0xC9F294")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0688", Offset = "0x6E0688")]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool IsFinished
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0xC93900", Offset = "0xC93900", VA = "0xC93900")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0698", Offset = "0x6E0698")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xC9F160", Offset = "0xC9F160", VA = "0xC9F160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E06A8", Offset = "0x6E06A8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public int Index
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xC9F2A0", Offset = "0xC9F2A0", VA = "0xC9F2A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E06B8", Offset = "0x6E06B8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0xC9F2A8", Offset = "0xC9F2A8", VA = "0xC9F2A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E06C8", Offset = "0x6E06C8")]
			private set
			{
			}
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xC9F2B0", Offset = "0xC9F2B0", VA = "0xC9F2B0")]
		private void RemoveActionSubAsset(BE_Action action)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xC9F350", Offset = "0xC9F350", VA = "0xC9F350")]
		public void Initialize(string name)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xC9F3D0", Offset = "0xC9F3D0", VA = "0xC9F3D0", Slot = "4")]
		public virtual void SetOwner(BehaviourSystem system, MonoBehaviour owner)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xC92FDC", Offset = "0xC92FDC", VA = "0xC92FDC")]
		public void UpdateTransitions(List<Node> oldStates, List<Node> newStates)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xC9F578", Offset = "0xC9F578", VA = "0xC9F578", Slot = "5")]
		public virtual void UpdateReferences()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xC9F57C", Offset = "0xC9F57C", VA = "0xC9F57C")]
		public void UpdateActions()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xC9F73C", Offset = "0xC9F73C", VA = "0xC9F73C")]
		public void AddActionInstance(BE_Action action)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xC9F7BC", Offset = "0xC9F7BC", VA = "0xC9F7BC")]
		public void RemoveActionInstance(BE_Action action)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xC9F868", Offset = "0xC9F868", VA = "0xC9F868")]
		public void ClearTransitions()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xC9F8C8", Offset = "0xC9F8C8", VA = "0xC9F8C8")]
		public void AddTransition(BE_Transition transition)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xC9F938", Offset = "0xC9F938", VA = "0xC9F938")]
		public List<BE_Transition> GetTransitions()
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xC93560", Offset = "0xC93560", VA = "0xC93560")]
		public void EnterState()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xC934F8", Offset = "0xC934F8", VA = "0xC934F8")]
		public void ExitState()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xC935FC", Offset = "0xC935FC", VA = "0xC935FC")]
		public void ForceFinish()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xC93834", Offset = "0xC93834", VA = "0xC93834")]
		public BE_Transition GetActiveTransition()
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xC8EA38", Offset = "0xC8EA38", VA = "0xC8EA38")]
		public void OnActionFinished(BE_Action action)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xC8F130", Offset = "0xC8F130", VA = "0xC8F130")]
		public void PerformTransition(int index)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xC9F9A8", Offset = "0xC9F9A8", VA = "0xC9F9A8")]
		private void AddActionsToProcess()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xC9FADC", Offset = "0xC9FADC", VA = "0xC9FADC")]
		public void ProcessActions()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xC9F084", Offset = "0xC9F084", VA = "0xC9F084", Slot = "6")]
		public virtual void UpdateNode()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xC9FD54", Offset = "0xC9FD54", VA = "0xC9FD54")]
		public void OnRemove()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xC9F170", Offset = "0xC9F170", VA = "0xC9F170")]
		public Node()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class State : Node
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<BehaviourTree> m_behaviourTrees;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF14C", Offset = "0x6DF14C")]
		private Branch <CurrentBranch>k__BackingField;

		[Token(Token = "0x17000045")]
		public List<BehaviourTree> BehaviourTrees
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0xCA0074", Offset = "0xCA0074", VA = "0xCA0074")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public Branch CurrentBranch
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0xCA007C", Offset = "0xCA007C", VA = "0xCA007C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E06D8", Offset = "0x6E06D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0xCA0084", Offset = "0xCA0084", VA = "0xCA0084")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E06E8", Offset = "0x6E06E8")]
			private set
			{
			}
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xCA008C", Offset = "0xCA008C", VA = "0xCA008C", Slot = "4")]
		public override void SetOwner(BehaviourSystem system, MonoBehaviour owner)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xCA023C", Offset = "0xCA023C", VA = "0xCA023C", Slot = "5")]
		public override void UpdateReferences()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xCA0368", Offset = "0xCA0368", VA = "0xCA0368")]
		public void AddBehaviourTreeInstance(BehaviourTree behaviourTree)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xCA03E8", Offset = "0xCA03E8", VA = "0xCA03E8")]
		public void RemoveActionInstance(BehaviourTree behaviourTree)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xCA0494", Offset = "0xCA0494", VA = "0xCA0494", Slot = "6")]
		public override void UpdateNode()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xCA05D0", Offset = "0xCA05D0", VA = "0xCA05D0")]
		public State()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Nodes.Properties
{
	[Token(Token = "0x2000070")]
	public static class NodeColor
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static IDictionary<NodePriority, Color> StateTypeColorDictionary;

		[Token(Token = "0x17000047")]
		public static Color Neutral
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0xC9FDBC", Offset = "0xC9FDBC", VA = "0xC9FDBC")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x17000048")]
		public static Color Normal
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0xC9FDC4", Offset = "0xC9FDC4", VA = "0xC9FDC4")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x17000049")]
		public static Color Prioritized
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0xC9FDCC", Offset = "0xC9FDCC", VA = "0xC9FDCC")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x1700004A")]
		public static Color Imminent
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0xC9FDD4", Offset = "0xC9FDD4", VA = "0xC9FDD4")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xC9FDDC", Offset = "0xC9FDDC", VA = "0xC9FDDC")]
		public static Color GetStateColor(NodePriority type)
		{
			return default(Color);
		}
	}
	[Token(Token = "0x2000071")]
	public enum NodePriority
	{
		[Token(Token = "0x40001AB")]
		Normal,
		[Token(Token = "0x40001AC")]
		Prioritized,
		[Token(Token = "0x40001AD")]
		Imminent
	}
}
namespace Cortopia.BE.Runtime.Managers
{
	[Token(Token = "0x2000072")]
	public static class ReferenceManager
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IDictionary<BehaviourSystem, BehaviourSystem> sm_behaviourSystemMapping;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IDictionary<Node, Node> sm_nodeMapping;

		[Token(Token = "0x60003D8")]
		public static T InstantiateBehaviourSystem<T>(T original) where T : BehaviourSystem
		{
			return null;
		}

		[Token(Token = "0x60003D9")]
		public static T InstantiateNode<T>(T original) where T : Node
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		public static T GetBehaviourSystemInstance<T>(T original) where T : BehaviourSystem
		{
			return null;
		}

		[Token(Token = "0x60003DB")]
		public static T GetNodeInstance<T>(T original) where T : Node
		{
			return null;
		}
	}
}
namespace Cortopia.BE.Runtime.Instance
{
	[Token(Token = "0x2000073")]
	public class BE_AI : MonoBehaviour
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BehaviourSystem m_behaviourAsset;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_currentStateName;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float m_updateInterval;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_updateintervalDelta;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF17C", Offset = "0x6DF17C")]
		private BE_Objective <Objective>k__BackingField;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_initialized;

		[Token(Token = "0x1700004B")]
		public BE_Objective Objective
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0xC9ECF0", Offset = "0xC9ECF0", VA = "0xC9ECF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E06F8", Offset = "0x6E06F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xC9ECF8", Offset = "0xC9ECF8", VA = "0xC9ECF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0708", Offset = "0x6E0708")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public BehaviourSystem BehaviourSystem
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0xC9ED00", Offset = "0xC9ED00", VA = "0xC9ED00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0xC9ED08", Offset = "0xC9ED08", VA = "0xC9ED08")]
			set
			{
			}
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xC9ED10", Offset = "0xC9ED10", VA = "0xC9ED10", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xC9EE78", Offset = "0xC9EE78", VA = "0xC9EE78", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xC9EFB0", Offset = "0xC9EFB0", VA = "0xC9EFB0")]
		public BE_AI()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Events
{
	[Token(Token = "0x2000074")]
	public class EventDelegate : MonoBehaviour
	{
		[Token(Token = "0x200010B")]
		public delegate void EventHandler();

		[Token(Token = "0x200010C")]
		public delegate void EventHandlerParam<TParam>(TParam param);

		[Token(Token = "0x200010D")]
		public delegate void EventHandlerMultipleParam<TParam1, TParam2>(TParam1 param1, TParam2 param2);

		[Serializable]
		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEE1C", Offset = "0x6DEE1C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static EventHandler <>9__200_0;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static EventHandler <>9__200_1;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static EventHandler <>9__200_2;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static EventHandlerParam<int> <>9__200_3;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static EventHandler <>9__200_4;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static EventHandlerParam<bool> <>9__200_5;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static EventHandlerParam<bool> <>9__200_6;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static EventHandler <>9__200_7;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static EventHandlerMultipleParam<float[], int> <>9__200_8;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static EventHandler <>9__200_9;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static EventHandler <>9__200_10;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static EventHandlerParam<Collision> <>9__200_11;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static EventHandlerParam<Collision2D> <>9__200_12;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static EventHandlerParam<Collision> <>9__200_13;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static EventHandlerParam<Collision2D> <>9__200_14;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static EventHandlerParam<Collision> <>9__200_15;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public static EventHandlerParam<Collision2D> <>9__200_16;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static EventHandler <>9__200_17;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public static EventHandlerParam<ControllerColliderHit> <>9__200_18;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public static EventHandler <>9__200_19;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public static EventHandler <>9__200_20;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public static EventHandler <>9__200_21;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public static EventHandler <>9__200_22;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public static EventHandler <>9__200_23;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public static EventHandler <>9__200_24;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public static EventHandlerParam<float> <>9__200_25;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			public static EventHandler <>9__200_26;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			public static EventHandler <>9__200_27;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			public static EventHandler <>9__200_28;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public static EventHandler <>9__200_29;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			public static EventHandler <>9__200_30;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			public static EventHandler <>9__200_31;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			public static EventHandler <>9__200_32;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			public static EventHandlerParam<GameObject> <>9__200_33;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			public static EventHandler <>9__200_34;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			public static EventHandler <>9__200_35;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			public static EventHandler <>9__200_36;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			public static EventHandlerMultipleParam<RenderTexture, RenderTexture> <>9__200_37;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			public static EventHandler <>9__200_38;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			public static EventHandler <>9__200_39;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			public static EventHandlerParam<Collider> <>9__200_40;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			public static EventHandlerParam<Collider2D> <>9__200_41;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			public static EventHandlerParam<Collider> <>9__200_42;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			public static EventHandlerParam<Collider2D> <>9__200_43;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			public static EventHandlerParam<Collider> <>9__200_44;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			public static EventHandlerParam<Collider2D> <>9__200_45;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			public static EventHandler <>9__200_46;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			public static EventHandler <>9__200_47;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			public static EventHandler <>9__200_48;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			public static EventHandler <>9__200_49;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			public static EventHandler <>9__200_50;

			[Token(Token = "0x600067C")]
			[Address(RVA = "0xC9EBDC", Offset = "0xC9EBDC", VA = "0xC9EBDC")]
			public <>c()
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0xC9EBE4", Offset = "0xC9EBE4", VA = "0xC9EBE4")]
			internal void <.ctor>b__200_0()
			{
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0xC9EBE8", Offset = "0xC9EBE8", VA = "0xC9EBE8")]
			internal void <.ctor>b__200_1()
			{
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0xC9EBEC", Offset = "0xC9EBEC", VA = "0xC9EBEC")]
			internal void <.ctor>b__200_2()
			{
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0xC9EBF0", Offset = "0xC9EBF0", VA = "0xC9EBF0")]
			internal void <.ctor>b__200_3(int layerIndex)
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0xC9EBF4", Offset = "0xC9EBF4", VA = "0xC9EBF4")]
			internal void <.ctor>b__200_4()
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0xC9EBF8", Offset = "0xC9EBF8", VA = "0xC9EBF8")]
			internal void <.ctor>b__200_5(bool focusStatus)
			{
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0xC9EBFC", Offset = "0xC9EBFC", VA = "0xC9EBFC")]
			internal void <.ctor>b__200_6(bool pauseStatus)
			{
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0xC9EC00", Offset = "0xC9EC00", VA = "0xC9EC00")]
			internal void <.ctor>b__200_7()
			{
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0xC9EC04", Offset = "0xC9EC04", VA = "0xC9EC04")]
			internal void <.ctor>b__200_8(float[] data, int channels)
			{
			}

			[Token(Token = "0x6000686")]
			[Address(RVA = "0xC9EC08", Offset = "0xC9EC08", VA = "0xC9EC08")]
			internal void <.ctor>b__200_9()
			{
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0xC9EC0C", Offset = "0xC9EC0C", VA = "0xC9EC0C")]
			internal void <.ctor>b__200_10()
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0xC9EC10", Offset = "0xC9EC10", VA = "0xC9EC10")]
			internal void <.ctor>b__200_11(Collision collision)
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0xC9EC14", Offset = "0xC9EC14", VA = "0xC9EC14")]
			internal void <.ctor>b__200_12(Collision2D collision)
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0xC9EC18", Offset = "0xC9EC18", VA = "0xC9EC18")]
			internal void <.ctor>b__200_13(Collision collision)
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0xC9EC1C", Offset = "0xC9EC1C", VA = "0xC9EC1C")]
			internal void <.ctor>b__200_14(Collision2D collision)
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0xC9EC20", Offset = "0xC9EC20", VA = "0xC9EC20")]
			internal void <.ctor>b__200_15(Collision collision)
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0xC9EC24", Offset = "0xC9EC24", VA = "0xC9EC24")]
			internal void <.ctor>b__200_16(Collision2D collision)
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0xC9EC28", Offset = "0xC9EC28", VA = "0xC9EC28")]
			internal void <.ctor>b__200_17()
			{
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0xC9EC2C", Offset = "0xC9EC2C", VA = "0xC9EC2C")]
			internal void <.ctor>b__200_18(ControllerColliderHit hit)
			{
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0xC9EC30", Offset = "0xC9EC30", VA = "0xC9EC30")]
			internal void <.ctor>b__200_19()
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0xC9EC34", Offset = "0xC9EC34", VA = "0xC9EC34")]
			internal void <.ctor>b__200_20()
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0xC9EC38", Offset = "0xC9EC38", VA = "0xC9EC38")]
			internal void <.ctor>b__200_21()
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0xC9EC3C", Offset = "0xC9EC3C", VA = "0xC9EC3C")]
			internal void <.ctor>b__200_22()
			{
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0xC9EC40", Offset = "0xC9EC40", VA = "0xC9EC40")]
			internal void <.ctor>b__200_23()
			{
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0xC9EC44", Offset = "0xC9EC44", VA = "0xC9EC44")]
			internal void <.ctor>b__200_24()
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0xC9EC48", Offset = "0xC9EC48", VA = "0xC9EC48")]
			internal void <.ctor>b__200_25(float breakForce)
			{
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0xC9EC4C", Offset = "0xC9EC4C", VA = "0xC9EC4C")]
			internal void <.ctor>b__200_26()
			{
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0xC9EC50", Offset = "0xC9EC50", VA = "0xC9EC50")]
			internal void <.ctor>b__200_27()
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0xC9EC54", Offset = "0xC9EC54", VA = "0xC9EC54")]
			internal void <.ctor>b__200_28()
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0xC9EC58", Offset = "0xC9EC58", VA = "0xC9EC58")]
			internal void <.ctor>b__200_29()
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0xC9EC5C", Offset = "0xC9EC5C", VA = "0xC9EC5C")]
			internal void <.ctor>b__200_30()
			{
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0xC9EC60", Offset = "0xC9EC60", VA = "0xC9EC60")]
			internal void <.ctor>b__200_31()
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0xC9EC64", Offset = "0xC9EC64", VA = "0xC9EC64")]
			internal void <.ctor>b__200_32()
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0xC9EC68", Offset = "0xC9EC68", VA = "0xC9EC68")]
			internal void <.ctor>b__200_33(GameObject other)
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0xC9EC6C", Offset = "0xC9EC6C", VA = "0xC9EC6C")]
			internal void <.ctor>b__200_34()
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xC9EC70", Offset = "0xC9EC70", VA = "0xC9EC70")]
			internal void <.ctor>b__200_35()
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0xC9EC74", Offset = "0xC9EC74", VA = "0xC9EC74")]
			internal void <.ctor>b__200_36()
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xC9EC78", Offset = "0xC9EC78", VA = "0xC9EC78")]
			internal void <.ctor>b__200_37(RenderTexture src, RenderTexture dest)
			{
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xC9EC7C", Offset = "0xC9EC7C", VA = "0xC9EC7C")]
			internal void <.ctor>b__200_38()
			{
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xC9EC80", Offset = "0xC9EC80", VA = "0xC9EC80")]
			internal void <.ctor>b__200_39()
			{
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xC9EC84", Offset = "0xC9EC84", VA = "0xC9EC84")]
			internal void <.ctor>b__200_40(Collider other)
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xC9EC88", Offset = "0xC9EC88", VA = "0xC9EC88")]
			internal void <.ctor>b__200_41(Collider2D other)
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xC9EC8C", Offset = "0xC9EC8C", VA = "0xC9EC8C")]
			internal void <.ctor>b__200_42(Collider other)
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0xC9EC90", Offset = "0xC9EC90", VA = "0xC9EC90")]
			internal void <.ctor>b__200_43(Collider2D other)
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0xC9EC94", Offset = "0xC9EC94", VA = "0xC9EC94")]
			internal void <.ctor>b__200_44(Collider other)
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xC9EC98", Offset = "0xC9EC98", VA = "0xC9EC98")]
			internal void <.ctor>b__200_45(Collider2D other)
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0xC9EC9C", Offset = "0xC9EC9C", VA = "0xC9EC9C")]
			internal void <.ctor>b__200_46()
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0xC9ECA0", Offset = "0xC9ECA0", VA = "0xC9ECA0")]
			internal void <.ctor>b__200_47()
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0xC9ECA4", Offset = "0xC9ECA4", VA = "0xC9ECA4")]
			internal void <.ctor>b__200_48()
			{
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0xC9ECA8", Offset = "0xC9ECA8", VA = "0xC9ECA8")]
			internal void <.ctor>b__200_49()
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0xC9ECAC", Offset = "0xC9ECAC", VA = "0xC9ECAC")]
			internal void <.ctor>b__200_50()
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event EventHandler AwakeEvent
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0xC96C5C", Offset = "0xC96C5C", VA = "0xC96C5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0718", Offset = "0x6E0718")]
			add
			{
			}
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0xC96D48", Offset = "0xC96D48", VA = "0xC96D48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0728", Offset = "0x6E0728")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event EventHandler FixedUpdateEvent
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0xC96E34", Offset = "0xC96E34", VA = "0xC96E34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0738", Offset = "0x6E0738")]
			add
			{
			}
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xC96F20", Offset = "0xC96F20", VA = "0xC96F20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0748", Offset = "0x6E0748")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event EventHandler LateUpdateEvent
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0xC9700C", Offset = "0xC9700C", VA = "0xC9700C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0758", Offset = "0x6E0758")]
			add
			{
			}
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xC970F8", Offset = "0xC970F8", VA = "0xC970F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0768", Offset = "0x6E0768")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event EventHandlerParam<int> OnAnimatorIKEvent
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xC971E4", Offset = "0xC971E4", VA = "0xC971E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0778", Offset = "0x6E0778")]
			add
			{
			}
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0xC972D0", Offset = "0xC972D0", VA = "0xC972D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0788", Offset = "0x6E0788")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event EventHandler OnAnimatorMoveEvent
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0xC973BC", Offset = "0xC973BC", VA = "0xC973BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0798", Offset = "0x6E0798")]
			add
			{
			}
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0xC974A8", Offset = "0xC974A8", VA = "0xC974A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E07A8", Offset = "0x6E07A8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event EventHandlerParam<bool> OnApplicationFocusEvent
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0xC97594", Offset = "0xC97594", VA = "0xC97594")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E07B8", Offset = "0x6E07B8")]
			add
			{
			}
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0xC97680", Offset = "0xC97680", VA = "0xC97680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E07C8", Offset = "0x6E07C8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event EventHandlerParam<bool> OnApplicationPauseEvent
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0xC9776C", Offset = "0xC9776C", VA = "0xC9776C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E07D8", Offset = "0x6E07D8")]
			add
			{
			}
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0xC97858", Offset = "0xC97858", VA = "0xC97858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E07E8", Offset = "0x6E07E8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event EventHandler OnApplicationQuitEvent
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0xC97944", Offset = "0xC97944", VA = "0xC97944")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E07F8", Offset = "0x6E07F8")]
			add
			{
			}
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0xC97A30", Offset = "0xC97A30", VA = "0xC97A30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0808", Offset = "0x6E0808")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event EventHandlerMultipleParam<float[], int> OnAudioFilterReadEvent
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0xC97B1C", Offset = "0xC97B1C", VA = "0xC97B1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0818", Offset = "0x6E0818")]
			add
			{
			}
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xC97C08", Offset = "0xC97C08", VA = "0xC97C08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0828", Offset = "0x6E0828")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event EventHandler OnBecameInvisibleEvent
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xC97CF4", Offset = "0xC97CF4", VA = "0xC97CF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0838", Offset = "0x6E0838")]
			add
			{
			}
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0xC97DE0", Offset = "0xC97DE0", VA = "0xC97DE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0848", Offset = "0x6E0848")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event EventHandler OnBecameVisibleEvent
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0xC97ECC", Offset = "0xC97ECC", VA = "0xC97ECC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0858", Offset = "0x6E0858")]
			add
			{
			}
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0xC97FB8", Offset = "0xC97FB8", VA = "0xC97FB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0868", Offset = "0x6E0868")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event EventHandlerParam<Collision> OnCollisionEnterEvent
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0xC8FAFC", Offset = "0xC8FAFC", VA = "0xC8FAFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0878", Offset = "0x6E0878")]
			add
			{
			}
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0xC8FF2C", Offset = "0xC8FF2C", VA = "0xC8FF2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0888", Offset = "0x6E0888")]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event EventHandlerParam<Collision2D> OnCollisionEnter2DEvent
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xC980A4", Offset = "0xC980A4", VA = "0xC980A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0898", Offset = "0x6E0898")]
			add
			{
			}
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0xC98190", Offset = "0xC98190", VA = "0xC98190")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E08A8", Offset = "0x6E08A8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event EventHandlerParam<Collision> OnCollisionExitEvent
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0xC90D48", Offset = "0xC90D48", VA = "0xC90D48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E08B8", Offset = "0x6E08B8")]
			add
			{
			}
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0xC90E34", Offset = "0xC90E34", VA = "0xC90E34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E08C8", Offset = "0x6E08C8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event EventHandlerParam<Collision2D> OnCollisionExit2DEvent
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0xC9827C", Offset = "0xC9827C", VA = "0xC9827C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E08D8", Offset = "0x6E08D8")]
			add
			{
			}
			[Token(Token = "0x6000401")]
			[Address(RVA = "0xC98368", Offset = "0xC98368", VA = "0xC98368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E08E8", Offset = "0x6E08E8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event EventHandlerParam<Collision> OnCollisionStayEvent
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0xC90B70", Offset = "0xC90B70", VA = "0xC90B70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E08F8", Offset = "0x6E08F8")]
			add
			{
			}
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xC90C5C", Offset = "0xC90C5C", VA = "0xC90C5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0908", Offset = "0x6E0908")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event EventHandlerParam<Collision2D> OnCollisionStay2DEvent
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0xC98454", Offset = "0xC98454", VA = "0xC98454")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0918", Offset = "0x6E0918")]
			add
			{
			}
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xC98540", Offset = "0xC98540", VA = "0xC98540")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0928", Offset = "0x6E0928")]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event EventHandler OnConnectedToServerEvent
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xC9862C", Offset = "0xC9862C", VA = "0xC9862C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0938", Offset = "0x6E0938")]
			add
			{
			}
			[Token(Token = "0x6000407")]
			[Address(RVA = "0xC98718", Offset = "0xC98718", VA = "0xC98718")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0948", Offset = "0x6E0948")]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event EventHandlerParam<ControllerColliderHit> OnControllerColliderHitEvent
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0xC98804", Offset = "0xC98804", VA = "0xC98804")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0958", Offset = "0x6E0958")]
			add
			{
			}
			[Token(Token = "0x6000409")]
			[Address(RVA = "0xC988F0", Offset = "0xC988F0", VA = "0xC988F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0968", Offset = "0x6E0968")]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event EventHandler OnDestroyEvent
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0xC8FBF8", Offset = "0xC8FBF8", VA = "0xC8FBF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0978", Offset = "0x6E0978")]
			add
			{
			}
			[Token(Token = "0x600040B")]
			[Address(RVA = "0xC90018", Offset = "0xC90018", VA = "0xC90018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0988", Offset = "0x6E0988")]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event EventHandler OnDisableEvent
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0xC989DC", Offset = "0xC989DC", VA = "0xC989DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0998", Offset = "0x6E0998")]
			add
			{
			}
			[Token(Token = "0x600040D")]
			[Address(RVA = "0xC98AC8", Offset = "0xC98AC8", VA = "0xC98AC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E09A8", Offset = "0x6E09A8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		public event EventHandler OnDrawGizmosEvent
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0xC98BB4", Offset = "0xC98BB4", VA = "0xC98BB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E09B8", Offset = "0x6E09B8")]
			add
			{
			}
			[Token(Token = "0x600040F")]
			[Address(RVA = "0xC98CA0", Offset = "0xC98CA0", VA = "0xC98CA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E09C8", Offset = "0x6E09C8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001A")]
		public event EventHandler OnDrawGizmosSelectedEvent
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0xC98D8C", Offset = "0xC98D8C", VA = "0xC98D8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E09D8", Offset = "0x6E09D8")]
			add
			{
			}
			[Token(Token = "0x6000411")]
			[Address(RVA = "0xC98E78", Offset = "0xC98E78", VA = "0xC98E78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E09E8", Offset = "0x6E09E8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001B")]
		public event EventHandler OnEnableEvent
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0xC98F64", Offset = "0xC98F64", VA = "0xC98F64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E09F8", Offset = "0x6E09F8")]
			add
			{
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0xC99050", Offset = "0xC99050", VA = "0xC99050")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0A08", Offset = "0x6E0A08")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001C")]
		public event EventHandler OnGUIEvent
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0xC9913C", Offset = "0xC9913C", VA = "0xC9913C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0A18", Offset = "0x6E0A18")]
			add
			{
			}
			[Token(Token = "0x6000415")]
			[Address(RVA = "0xC99228", Offset = "0xC99228", VA = "0xC99228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0A28", Offset = "0x6E0A28")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001D")]
		public event EventHandlerParam<float> OnJointBreakEvent
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0xC99314", Offset = "0xC99314", VA = "0xC99314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0A38", Offset = "0x6E0A38")]
			add
			{
			}
			[Token(Token = "0x6000417")]
			[Address(RVA = "0xC99400", Offset = "0xC99400", VA = "0xC99400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0A48", Offset = "0x6E0A48")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001E")]
		public event EventHandler OnMouseDownEvent
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0xC994EC", Offset = "0xC994EC", VA = "0xC994EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0A58", Offset = "0x6E0A58")]
			add
			{
			}
			[Token(Token = "0x6000419")]
			[Address(RVA = "0xC995D8", Offset = "0xC995D8", VA = "0xC995D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0A68", Offset = "0x6E0A68")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001F")]
		public event EventHandler OnMouseDragEvent
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0xC996C4", Offset = "0xC996C4", VA = "0xC996C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0A78", Offset = "0x6E0A78")]
			add
			{
			}
			[Token(Token = "0x600041B")]
			[Address(RVA = "0xC997B0", Offset = "0xC997B0", VA = "0xC997B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0A88", Offset = "0x6E0A88")]
			remove
			{
			}
		}

		[Token(Token = "0x14000020")]
		public event EventHandler OnMouseEnterEvent
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0xC9989C", Offset = "0xC9989C", VA = "0xC9989C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0A98", Offset = "0x6E0A98")]
			add
			{
			}
			[Token(Token = "0x600041D")]
			[Address(RVA = "0xC99988", Offset = "0xC99988", VA = "0xC99988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0AA8", Offset = "0x6E0AA8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000021")]
		public event EventHandler OnMouseExitEvent
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0xC99A74", Offset = "0xC99A74", VA = "0xC99A74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0AB8", Offset = "0x6E0AB8")]
			add
			{
			}
			[Token(Token = "0x600041F")]
			[Address(RVA = "0xC99B64", Offset = "0xC99B64", VA = "0xC99B64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0AC8", Offset = "0x6E0AC8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000022")]
		public event EventHandler OnMouseOverEvent
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0xC99C54", Offset = "0xC99C54", VA = "0xC99C54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0AD8", Offset = "0x6E0AD8")]
			add
			{
			}
			[Token(Token = "0x6000421")]
			[Address(RVA = "0xC99D44", Offset = "0xC99D44", VA = "0xC99D44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0AE8", Offset = "0x6E0AE8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000023")]
		public event EventHandler OnMouseUpEvent
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0xC99E34", Offset = "0xC99E34", VA = "0xC99E34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0AF8", Offset = "0x6E0AF8")]
			add
			{
			}
			[Token(Token = "0x6000423")]
			[Address(RVA = "0xC99F24", Offset = "0xC99F24", VA = "0xC99F24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0B08", Offset = "0x6E0B08")]
			remove
			{
			}
		}

		[Token(Token = "0x14000024")]
		public event EventHandler OnMouseUpAsButtonEvent
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0xC9A014", Offset = "0xC9A014", VA = "0xC9A014")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0B18", Offset = "0x6E0B18")]
			add
			{
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0xC9A104", Offset = "0xC9A104", VA = "0xC9A104")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0B28", Offset = "0x6E0B28")]
			remove
			{
			}
		}

		[Token(Token = "0x14000025")]
		public event EventHandlerParam<GameObject> OnParticleCollisionEvent
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0xC9A1F4", Offset = "0xC9A1F4", VA = "0xC9A1F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0B38", Offset = "0x6E0B38")]
			add
			{
			}
			[Token(Token = "0x6000427")]
			[Address(RVA = "0xC9A2E4", Offset = "0xC9A2E4", VA = "0xC9A2E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0B48", Offset = "0x6E0B48")]
			remove
			{
			}
		}

		[Token(Token = "0x14000026")]
		public event EventHandler OnPostRenderEvent
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0xC9A3D4", Offset = "0xC9A3D4", VA = "0xC9A3D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0B58", Offset = "0x6E0B58")]
			add
			{
			}
			[Token(Token = "0x6000429")]
			[Address(RVA = "0xC9A4C4", Offset = "0xC9A4C4", VA = "0xC9A4C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0B68", Offset = "0x6E0B68")]
			remove
			{
			}
		}

		[Token(Token = "0x14000027")]
		public event EventHandler OnPreCullEvent
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0xC9A5B4", Offset = "0xC9A5B4", VA = "0xC9A5B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0B78", Offset = "0x6E0B78")]
			add
			{
			}
			[Token(Token = "0x600042B")]
			[Address(RVA = "0xC9A6A4", Offset = "0xC9A6A4", VA = "0xC9A6A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0B88", Offset = "0x6E0B88")]
			remove
			{
			}
		}

		[Token(Token = "0x14000028")]
		public event EventHandler OnPreRenderEvent
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0xC9A794", Offset = "0xC9A794", VA = "0xC9A794")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0B98", Offset = "0x6E0B98")]
			add
			{
			}
			[Token(Token = "0x600042D")]
			[Address(RVA = "0xC9A884", Offset = "0xC9A884", VA = "0xC9A884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0BA8", Offset = "0x6E0BA8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000029")]
		public event EventHandlerMultipleParam<RenderTexture, RenderTexture> OnRenderImageEvent
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0xC9A974", Offset = "0xC9A974", VA = "0xC9A974")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0BB8", Offset = "0x6E0BB8")]
			add
			{
			}
			[Token(Token = "0x600042F")]
			[Address(RVA = "0xC9AA64", Offset = "0xC9AA64", VA = "0xC9AA64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0BC8", Offset = "0x6E0BC8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002A")]
		public event EventHandler OnRenderObjectEvent
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0xC9AB54", Offset = "0xC9AB54", VA = "0xC9AB54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0BD8", Offset = "0x6E0BD8")]
			add
			{
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0xC9AC44", Offset = "0xC9AC44", VA = "0xC9AC44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0BE8", Offset = "0x6E0BE8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002B")]
		public event EventHandler OnServerInitializedEvent
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0xC9AD34", Offset = "0xC9AD34", VA = "0xC9AD34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0BF8", Offset = "0x6E0BF8")]
			add
			{
			}
			[Token(Token = "0x6000433")]
			[Address(RVA = "0xC9AE24", Offset = "0xC9AE24", VA = "0xC9AE24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0C08", Offset = "0x6E0C08")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002C")]
		public event EventHandlerParam<Collider> OnTriggerEnterEvent
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0xC8FA0C", Offset = "0xC8FA0C", VA = "0xC8FA0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0C18", Offset = "0x6E0C18")]
			add
			{
			}
			[Token(Token = "0x6000435")]
			[Address(RVA = "0xC8FE3C", Offset = "0xC8FE3C", VA = "0xC8FE3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0C28", Offset = "0x6E0C28")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002D")]
		public event EventHandlerParam<Collider2D> OnTriggerEnter2DEvent
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0xC9AF14", Offset = "0xC9AF14", VA = "0xC9AF14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0C38", Offset = "0x6E0C38")]
			add
			{
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0xC9B004", Offset = "0xC9B004", VA = "0xC9B004")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0C48", Offset = "0x6E0C48")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002E")]
		public event EventHandlerParam<Collider> OnTriggerExitEvent
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0xC912F0", Offset = "0xC912F0", VA = "0xC912F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0C58", Offset = "0x6E0C58")]
			add
			{
			}
			[Token(Token = "0x6000439")]
			[Address(RVA = "0xC91538", Offset = "0xC91538", VA = "0xC91538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0C68", Offset = "0x6E0C68")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002F")]
		public event EventHandlerParam<Collider2D> OnTriggerExit2DEvent
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0xC9B0F4", Offset = "0xC9B0F4", VA = "0xC9B0F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0C78", Offset = "0x6E0C78")]
			add
			{
			}
			[Token(Token = "0x600043B")]
			[Address(RVA = "0xC9B1E4", Offset = "0xC9B1E4", VA = "0xC9B1E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0C88", Offset = "0x6E0C88")]
			remove
			{
			}
		}

		[Token(Token = "0x14000030")]
		public event EventHandlerParam<Collider> OnTriggerStayEvent
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0xC9B2D4", Offset = "0xC9B2D4", VA = "0xC9B2D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0C98", Offset = "0x6E0C98")]
			add
			{
			}
			[Token(Token = "0x600043D")]
			[Address(RVA = "0xC9B3C4", Offset = "0xC9B3C4", VA = "0xC9B3C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0CA8", Offset = "0x6E0CA8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000031")]
		public event EventHandlerParam<Collider2D> OnTriggerStay2DEvent
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0xC9B4B4", Offset = "0xC9B4B4", VA = "0xC9B4B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0CB8", Offset = "0x6E0CB8")]
			add
			{
			}
			[Token(Token = "0x600043F")]
			[Address(RVA = "0xC9B5A4", Offset = "0xC9B5A4", VA = "0xC9B5A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0CC8", Offset = "0x6E0CC8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000032")]
		public event EventHandler OnValidateEvent
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0xC9B694", Offset = "0xC9B694", VA = "0xC9B694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0CD8", Offset = "0x6E0CD8")]
			add
			{
			}
			[Token(Token = "0x6000441")]
			[Address(RVA = "0xC9B784", Offset = "0xC9B784", VA = "0xC9B784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0CE8", Offset = "0x6E0CE8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000033")]
		public event EventHandler OnWillRenderObjectEvent
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0xC9B874", Offset = "0xC9B874", VA = "0xC9B874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0CF8", Offset = "0x6E0CF8")]
			add
			{
			}
			[Token(Token = "0x6000443")]
			[Address(RVA = "0xC9B964", Offset = "0xC9B964", VA = "0xC9B964")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0D08", Offset = "0x6E0D08")]
			remove
			{
			}
		}

		[Token(Token = "0x14000034")]
		public event EventHandler ResetEvent
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0xC9BA54", Offset = "0xC9BA54", VA = "0xC9BA54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0D18", Offset = "0x6E0D18")]
			add
			{
			}
			[Token(Token = "0x6000445")]
			[Address(RVA = "0xC9BB44", Offset = "0xC9BB44", VA = "0xC9BB44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0D28", Offset = "0x6E0D28")]
			remove
			{
			}
		}

		[Token(Token = "0x14000035")]
		public event EventHandler StartEvent
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0xC9BC34", Offset = "0xC9BC34", VA = "0xC9BC34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0D38", Offset = "0x6E0D38")]
			add
			{
			}
			[Token(Token = "0x6000447")]
			[Address(RVA = "0xC9BD24", Offset = "0xC9BD24", VA = "0xC9BD24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0D48", Offset = "0x6E0D48")]
			remove
			{
			}
		}

		[Token(Token = "0x14000036")]
		public event EventHandler UpdateEvent
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0xC9BE14", Offset = "0xC9BE14", VA = "0xC9BE14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0D58", Offset = "0x6E0D58")]
			add
			{
			}
			[Token(Token = "0x6000449")]
			[Address(RVA = "0xC9BF04", Offset = "0xC9BF04", VA = "0xC9BF04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0D68", Offset = "0x6E0D68")]
			remove
			{
			}
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xC9BFF4", Offset = "0xC9BFF4", VA = "0xC9BFF4")]
		public void Awake()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xC9C420", Offset = "0xC9C420", VA = "0xC9C420")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xC9C44C", Offset = "0xC9C44C", VA = "0xC9C44C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xC9C478", Offset = "0xC9C478", VA = "0xC9C478")]
		public void OnAnimatorIK(int layerIndex)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xC9C4E8", Offset = "0xC9C4E8", VA = "0xC9C4E8")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xC9C514", Offset = "0xC9C514", VA = "0xC9C514")]
		public void OnApplicationFocus(bool focusStatus)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xC9C584", Offset = "0xC9C584", VA = "0xC9C584")]
		public void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xC9C5F4", Offset = "0xC9C5F4", VA = "0xC9C5F4")]
		public void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xC9C620", Offset = "0xC9C620", VA = "0xC9C620")]
		public void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xC9C698", Offset = "0xC9C698", VA = "0xC9C698")]
		public void OnBecameInvisible()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xC9C6C4", Offset = "0xC9C6C4", VA = "0xC9C6C4")]
		public void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xC9C6F0", Offset = "0xC9C6F0", VA = "0xC9C6F0")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xC9C760", Offset = "0xC9C760", VA = "0xC9C760")]
		public void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xC9C7D0", Offset = "0xC9C7D0", VA = "0xC9C7D0")]
		public void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xC9C840", Offset = "0xC9C840", VA = "0xC9C840")]
		public void OnCollisionExit2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xC9C8B0", Offset = "0xC9C8B0", VA = "0xC9C8B0")]
		public void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xC9C920", Offset = "0xC9C920", VA = "0xC9C920")]
		public void OnCollisionStay2D(Collision2D collision)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xC9C990", Offset = "0xC9C990", VA = "0xC9C990")]
		public void OnConnectedToServer()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xC9C9BC", Offset = "0xC9C9BC", VA = "0xC9C9BC")]
		public void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xC9CA2C", Offset = "0xC9CA2C", VA = "0xC9CA2C")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xC9CA58", Offset = "0xC9CA58", VA = "0xC9CA58")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xC9CA84", Offset = "0xC9CA84", VA = "0xC9CA84")]
		public void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xC9CAB0", Offset = "0xC9CAB0", VA = "0xC9CAB0")]
		public void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xC9CADC", Offset = "0xC9CADC", VA = "0xC9CADC")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xC9CB08", Offset = "0xC9CB08", VA = "0xC9CB08")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xC9CB34", Offset = "0xC9CB34", VA = "0xC9CB34")]
		public void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xC9CBA4", Offset = "0xC9CBA4", VA = "0xC9CBA4")]
		public void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xC9CC14", Offset = "0xC9CC14", VA = "0xC9CC14")]
		public void OnPostRender()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xC9CC40", Offset = "0xC9CC40", VA = "0xC9CC40")]
		public void OnPreCull()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xC9CC6C", Offset = "0xC9CC6C", VA = "0xC9CC6C")]
		public void OnPreRender()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xC9CC98", Offset = "0xC9CC98", VA = "0xC9CC98")]
		public void OnRenderImage(RenderTexture src, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xC9CD10", Offset = "0xC9CD10", VA = "0xC9CD10")]
		public void OnRenderObject()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xC9CD3C", Offset = "0xC9CD3C", VA = "0xC9CD3C")]
		public void OnServerInitialized()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xC9CD68", Offset = "0xC9CD68", VA = "0xC9CD68")]
		public void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xC9CDD8", Offset = "0xC9CDD8", VA = "0xC9CDD8")]
		public void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xC9CE48", Offset = "0xC9CE48", VA = "0xC9CE48")]
		public void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xC9CEB8", Offset = "0xC9CEB8", VA = "0xC9CEB8")]
		public void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xC9CF28", Offset = "0xC9CF28", VA = "0xC9CF28")]
		public void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xC9CF98", Offset = "0xC9CF98", VA = "0xC9CF98")]
		public void OnTriggerStay2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xC9D008", Offset = "0xC9D008", VA = "0xC9D008")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xC9D034", Offset = "0xC9D034", VA = "0xC9D034")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xC9D060", Offset = "0xC9D060", VA = "0xC9D060")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xC9D08C", Offset = "0xC9D08C", VA = "0xC9D08C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xC9D0B8", Offset = "0xC9D0B8", VA = "0xC9D0B8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xC9D0E4", Offset = "0xC9D0E4", VA = "0xC9D0E4")]
		public EventDelegate()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Events.ActionEvents
{
	[Serializable]
	[Token(Token = "0x2000075")]
	public class ActionEvent : UnityEvent
	{
		[Token(Token = "0x6000477")]
		[Address(RVA = "0xC96C54", Offset = "0xC96C54", VA = "0xC96C54")]
		public ActionEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class StateChangeEvent : UnityEvent<State>
	{
		[Token(Token = "0x6000478")]
		[Address(RVA = "0xC8F05C", Offset = "0xC8F05C", VA = "0xC8F05C")]
		public StateChangeEvent()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Components.Senses
{
	[Token(Token = "0x2000077")]
	public class Sense : MonoBehaviour
	{
		[Token(Token = "0x6000479")]
		[Address(RVA = "0xC94460", Offset = "0xC94460", VA = "0xC94460")]
		public Sense()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Components.Senses.Sight
{
	[Serializable]
	[Token(Token = "0x2000078")]
	public struct FieldOfView
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6DF4BC", Offset = "0x6DF4BC")]
		private float m_angle;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6DF500", Offset = "0x6DF500")]
		private float m_distance;

		[Token(Token = "0x1700004D")]
		public float Angle
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x77029C", Offset = "0x77029C", VA = "0x77029C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004E")]
		public float Distance
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x7702A4", Offset = "0x7702A4", VA = "0x7702A4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004F")]
		public float AngleFromForward
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x7702AC", Offset = "0x7702AC", VA = "0x7702AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x7702BC", Offset = "0x7702BC", VA = "0x7702BC")]
		public FieldOfView(float angle, float distance)
		{
		}
	}
	[Token(Token = "0x2000079")]
	public interface ISight
	{
		[Token(Token = "0x600047E")]
		Sight GetSight();
	}
	[Token(Token = "0x200007A")]
	public class Sight : Sense
	{
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_runInUpdate;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private FieldOfView m_fov;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private LayerMask m_targetMask;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask m_obstacleMask;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_origin;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Collider[] m_excludedColliders;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_excludeSelf;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_targetsCachedTime;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SightRayCollection m_unblockedRays;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject m_sightObj;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ColliderCollection m_visibleTargets;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ColliderCollection m_allTargetsInSightRange;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Collider m_currentTargetCollider;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] m_currentMatchingLayerColliders;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Component[] m_currentMatchingTypes;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Component[] m_currentMatchingComponents;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ColliderCollection m_currentColliders;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] m_currentBoundPositions;

		[Token(Token = "0x17000050")]
		public Transform Origin
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0xC94964", Offset = "0xC94964", VA = "0xC94964")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public FieldOfView FOV
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0xC949F4", Offset = "0xC949F4", VA = "0xC949F4")]
			get
			{
				return default(FieldOfView);
			}
		}

		[Token(Token = "0x17000052")]
		public ColliderCollection VisibleTargets
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0xC949FC", Offset = "0xC949FC", VA = "0xC949FC")]
			get
			{
				return default(ColliderCollection);
			}
		}

		[Token(Token = "0x17000053")]
		public ColliderCollection AllTargetsInSightRange
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0xC94A08", Offset = "0xC94A08", VA = "0xC94A08")]
			get
			{
				return default(ColliderCollection);
			}
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xC94A14", Offset = "0xC94A14", VA = "0xC94A14")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xC94C68", Offset = "0xC94C68", VA = "0xC94C68")]
		private void SetSightOrigin(Transform originTransform)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xC94C70", Offset = "0xC94C70", VA = "0xC94C70")]
		private void Start()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xC94F24", Offset = "0xC94F24", VA = "0xC94F24")]
		private ColliderCollection GetTargetsInFieldOfVision()
		{
			return default(ColliderCollection);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xC952E0", Offset = "0xC952E0", VA = "0xC952E0")]
		public bool IsInLineOfSight(Collider target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xC9532C", Offset = "0xC9532C", VA = "0xC9532C")]
		public bool IsInLineOfSight(Collider target, out SightRay unblockedRay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xC95C88", Offset = "0xC95C88", VA = "0xC95C88")]
		public bool IsRayBlocked(Vector3 rayStart, Vector3 rayEnd, [Optional] Collider testedCollider)
		{
			return default(bool);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xC95B5C", Offset = "0xC95B5C", VA = "0xC95B5C")]
		public bool IsRayBlocked(ref SightRay sightRay, [Optional] Collider testedCollider)
		{
			return default(bool);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xC95E24", Offset = "0xC95E24", VA = "0xC95E24")]
		private void UpdateVisibleTargets()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xC95FF0", Offset = "0xC95FF0", VA = "0xC95FF0")]
		public bool IsVisible(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xC9601C", Offset = "0xC9601C", VA = "0xC9601C")]
		public bool IsInSightRange(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x600048E")]
		public T GetClosest<T>(T[] components, int length = -1) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xC96048", Offset = "0xC96048", VA = "0xC96048")]
		public int MatchTargets(Collider[] matchingTargets, bool InFieldOfView = true, int length = -1, float customRange = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x6000490")]
		public int MatchTargets<T>(T[] matchingTargets, bool InFieldOfView = true, int length = -1, float customRange = 0f) where T : Component
		{
			return default(int);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xC9604C", Offset = "0xC9604C", VA = "0xC9604C")]
		public int FindTargets(Collider[] matchingColliders, LayerMask layerMask, bool InFieldOfView = true, int length = -1, float customRange = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x6000492")]
		public int FindTargets<T>(T[] matchingComponents, LayerMask layerMask, bool InFieldOfView = true, int length = -1, float customRange = 0f) where T : Component
		{
			return default(int);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xC960DC", Offset = "0xC960DC", VA = "0xC960DC")]
		public Collider GetClosestTarget(bool InFieldOfView = true, float customRange = 0f, int length = -1)
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		public T GetClosestTarget<T>(bool InFieldOfView = true, float customRange = 0f, int length = -1) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xC9211C", Offset = "0xC9211C", VA = "0xC9211C")]
		public Collider GetClosestTarget(LayerMask layerMask, bool InFieldOfView = true, float customRange = 0f, int length = -1)
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		public T GetClosestTarget<T>(LayerMask layerMask, bool InFieldOfView = true, float customRange = 0f, int length = -1) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xC96154", Offset = "0xC96154", VA = "0xC96154")]
		public Component GetClosestTarget(Type type, bool inFieldOfView = true, int length = -1, float customRange = 0f)
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xC96474", Offset = "0xC96474", VA = "0xC96474")]
		public Component GetClosestTarget(Type type, LayerMask layerMask, bool inFieldOfView = true, int length = -1, float customRange = 0f)
		{
			return null;
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xC96584", Offset = "0xC96584", VA = "0xC96584")]
		private int FindTargetsInLayers(Collider[] matchingColliders, Collider[] colliders, LayerMask layerMask, int length = -1)
		{
			return default(int);
		}

		[Token(Token = "0x600049A")]
		private int FindTargetsInLayers<T>(T[] matchingComponents, Collider[] colliders, LayerMask layerMask, int length = -1) where T : Component
		{
			return default(int);
		}

		[Token(Token = "0x600049B")]
		private int FindTargetsInLayers<T>(T[] matchingComponents, T[] collection, LayerMask layerMask, int length = -1) where T : Component
		{
			return default(int);
		}

		[Token(Token = "0x600049C")]
		private int FindTargetsInRange<T>(T[] targetsInRange, T[] collection, float range, int length = -1) where T : Component
		{
			return default(int);
		}

		[Token(Token = "0x600049D")]
		private T GetTargetInRange<T>(T target, float range) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		private int FindTargetsOfType<T>(Component[] matchingComponents, Collider[] colliders, int length = -1) where T : Component
		{
			return default(int);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xC96244", Offset = "0xC96244", VA = "0xC96244")]
		private int FindTargetsOfType(Component[] matchingComponents, Collider[] colliders, Type type, int length = -1)
		{
			return default(int);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xC9672C", Offset = "0xC9672C", VA = "0xC9672C")]
		public SightRay GetUnblockedSightRayForCollider(Collider collider)
		{
			return default(SightRay);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xC94B90", Offset = "0xC94B90", VA = "0xC94B90")]
		private bool ArrayContains(Collider[] collection, Collider element)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A2")]
		private bool IsEmpty<T>(List<T> collection)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		private bool IsEmpty<T>(T[] collection)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xC92708", Offset = "0xC92708", VA = "0xC92708")]
		public void TryUpdateOutdatedVisualTargets()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xC968E0", Offset = "0xC968E0", VA = "0xC968E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xC968DC", Offset = "0xC968DC", VA = "0xC968DC")]
		public void UpdateSight()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xC968F0", Offset = "0xC968F0", VA = "0xC968F0")]
		public Sight()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public struct SightRay
	{
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SightRay Invalid;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly Color HitColor;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly Color MissColor;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF5B4", Offset = "0x6DF5B4")]
		private readonly Vector3 <Origin>k__BackingField;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF5C4", Offset = "0x6DF5C4")]
		private Vector3 <Direction>k__BackingField;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF5D4", Offset = "0x6DF5D4")]
		private readonly Vector3 <End>k__BackingField;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF5E4", Offset = "0x6DF5E4")]
		private readonly float <Range>k__BackingField;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF5F4", Offset = "0x6DF5F4")]
		private bool <IsBlocked>k__BackingField;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF604", Offset = "0x6DF604")]
		private Color <Color>k__BackingField;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF614", Offset = "0x6DF614")]
		private Collider <HitCollider>k__BackingField;

		[Token(Token = "0x17000054")]
		public Vector3 Origin
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x770310", Offset = "0x770310", VA = "0x770310")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0D78", Offset = "0x6E0D78")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000055")]
		public Vector3 Direction
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x77031C", Offset = "0x77031C", VA = "0x77031C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0D88", Offset = "0x6E0D88")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x770328", Offset = "0x770328", VA = "0x770328")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0D98", Offset = "0x6E0D98")]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public Vector3 End
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x770334", Offset = "0x770334", VA = "0x770334")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0DA8", Offset = "0x6E0DA8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000057")]
		public float Range
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x770340", Offset = "0x770340", VA = "0x770340")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0DB8", Offset = "0x6E0DB8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000058")]
		public bool IsBlocked
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x770348", Offset = "0x770348", VA = "0x770348")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0DC8", Offset = "0x6E0DC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x770350", Offset = "0x770350", VA = "0x770350")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0DD8", Offset = "0x6E0DD8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public Color Color
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x77035C", Offset = "0x77035C", VA = "0x77035C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0DE8", Offset = "0x6E0DE8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x770368", Offset = "0x770368", VA = "0x770368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0DF8", Offset = "0x6E0DF8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public Collider HitCollider
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x770374", Offset = "0x770374", VA = "0x770374")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0E08", Offset = "0x6E0E08")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x77037C", Offset = "0x77037C", VA = "0x77037C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0E18", Offset = "0x6E0E18")]
			private set
			{
			}
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x770384", Offset = "0x770384", VA = "0x770384")]
		public SightRay(Vector3 origin, Vector3 end, [Optional] Collider hitCollider, bool isBlocked = true)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x770390", Offset = "0x770390", VA = "0x770390")]
		public void SetBlocked(bool isBlocked)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x77039C", Offset = "0x77039C", VA = "0x77039C")]
		public void SetHitCollider(Collider collider)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x7703A4", Offset = "0x7703A4", VA = "0x7703A4")]
		public bool IsInvalid()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x7703AC", Offset = "0x7703AC", VA = "0x7703AC")]
		public bool EqualTo(SightRay ray)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x7703EC", Offset = "0x7703EC", VA = "0x7703EC")]
		public bool AlmostEquals(Vector3 target, Vector3 second, float sqrMagnitudePrecision)
		{
			return default(bool);
		}
	}
}
namespace Cortopia.BE.Runtime.Components.Senses.Sight.Collections
{
	[Token(Token = "0x200007C")]
	public struct ColliderCollection
	{
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Count;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Collider[] Colliders;

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x7701F0", Offset = "0x7701F0", VA = "0x7701F0")]
		public ColliderCollection(int size)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x7701F8", Offset = "0x7701F8", VA = "0x7701F8")]
		public bool Contains(Collider element)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007D")]
	public struct ComponentCollection<T> where T : Component
	{
		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Count;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] Components;

		[Token(Token = "0x60004BC")]
		public ComponentCollection(int size)
		{
		}

		[Token(Token = "0x60004BD")]
		public bool Contains(T element)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007E")]
	public struct SightRayCollection
	{
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Count;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SightRay[] SightRays;

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x77024C", Offset = "0x77024C", VA = "0x77024C")]
		public SightRayCollection(int size)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x770254", Offset = "0x770254", VA = "0x770254")]
		public bool Contains(SightRay element)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007F")]
	public struct VectorCollection
	{
		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Count;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3[] Vectors;

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x770294", Offset = "0x770294", VA = "0x770294")]
		public VectorCollection(int size)
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Components.Senses.Hearing
{
	[Token(Token = "0x2000080")]
	public struct AudibleSource
	{
		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 Position;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float Amplitude;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float RegisteredTime;

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x770150", Offset = "0x770150", VA = "0x770150")]
		public AudibleSource(Vector3 position, float amplitude, float registeredTime)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class AudioEvent : UnityEvent<Vector3, float>
	{
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static AudioEvent Event;

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xC93B40", Offset = "0xC93B40", VA = "0xC93B40")]
		public AudioEvent()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class Hearing : Sense
	{
		[Token(Token = "0x4000213")]
		private const float MinDistanceVolumeCap = 0.1f;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_runInUpdate;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6DF634", Offset = "0x6DF634")]
		private float m_sensitivity;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_minRange;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_maxRange;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_sourceRegistryCapacity;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_origin;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_noticeDuration;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AudibleSourceCollection m_registeredAudioSources;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudibleSourceCollection HeardAudioPositions;

		[Token(Token = "0x1700005B")]
		public float MinRange
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xC93DFC", Offset = "0xC93DFC", VA = "0xC93DFC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005C")]
		public float MaxRange
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xC93E04", Offset = "0xC93E04", VA = "0xC93E04")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xC93E0C", Offset = "0xC93E0C", VA = "0xC93E0C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xC93F10", Offset = "0xC93F10", VA = "0xC93F10")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xC93F8C", Offset = "0xC93F8C", VA = "0xC93F8C")]
		private void OnAudioEvent(Vector3 position, float amplitude)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xC940DC", Offset = "0xC940DC", VA = "0xC940DC")]
		private float GetVolumeFactorAtDistance(Vector3 position)
		{
			return default(float);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xC94218", Offset = "0xC94218", VA = "0xC94218")]
		public bool IsWithinHearingRange(Vector3 position)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xC91D60", Offset = "0xC91D60", VA = "0xC91D60")]
		public bool IsWithinHearingRange(Vector3 position, float range)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xC94320", Offset = "0xC94320", VA = "0xC94320")]
		private void UpdateHearing()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xC94428", Offset = "0xC94428", VA = "0xC94428")]
		private void Update()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xC94438", Offset = "0xC94438", VA = "0xC94438")]
		public Hearing()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public interface IHearing
	{
		[Token(Token = "0x60004CF")]
		Hearing GetHearing();

		[Token(Token = "0x60004D0")]
		Vector3 GetOpponentPosition();
	}
}
namespace Cortopia.BE.Runtime.Components.Senses.Hearing.Collections
{
	[Token(Token = "0x2000084")]
	public struct AudibleSourceCollection
	{
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_nextIndex;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int Count;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AudibleSource[] Sources;

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x770160", Offset = "0x770160", VA = "0x770160")]
		public AudibleSourceCollection(int size)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x770168", Offset = "0x770168", VA = "0x770168")]
		public void Add(Vector3 position, float amplitude)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x770170", Offset = "0x770170", VA = "0x770170")]
		public void Add(AudibleSource source)
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions
{
	[Serializable]
	[Token(Token = "0x2000085")]
	public class BE_Action : ScriptableObject
	{
		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6DF6B4", Offset = "0x6DF6B4")]
		public List<TransitionConnector> TransitionConnectors;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Node OwnerNode;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string TypeName;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF6EC", Offset = "0x6DF6EC")]
		private string <Description>k__BackingField;

		[Token(Token = "0x1700005D")]
		public string Description
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xC8E734", Offset = "0xC8E734", VA = "0xC8E734")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0E28", Offset = "0x6E0E28")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xC8E73C", Offset = "0xC8E73C", VA = "0xC8E73C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0E38", Offset = "0x6E0E38")]
			protected set
			{
			}
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xC8E744", Offset = "0xC8E744", VA = "0xC8E744", Slot = "4")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xC8E748", Offset = "0xC8E748", VA = "0xC8E748")]
		public void AddTransitionConnector(TransitionConnector connector)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xC8E8B4", Offset = "0xC8E8B4", VA = "0xC8E8B4")]
		public int GetTransitionIndexByName(string transitionName)
		{
			return default(int);
		}

		[Token(Token = "0x60004D9")]
		public T GetValidComponent<T>(Component owner)
		{
			return (T)null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xC8E9FC", Offset = "0xC8E9FC", VA = "0xC8E9FC", Slot = "5")]
		public virtual void Process()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xC8EA00", Offset = "0xC8EA00", VA = "0xC8EA00", Slot = "6")]
		public virtual void DrawCustomProperties()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xC8EA04", Offset = "0xC8EA04", VA = "0xC8EA04")]
		public void Finish()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xC8EC18", Offset = "0xC8EC18", VA = "0xC8EC18")]
		public BE_Action()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public enum RelationalOperator
	{
		[Token(Token = "0x4000225")]
		Equal,
		[Token(Token = "0x4000226")]
		Not,
		[Token(Token = "0x4000227")]
		Greater,
		[Token(Token = "0x4000228")]
		Less,
		[Token(Token = "0x4000229")]
		GreaterOrEqual,
		[Token(Token = "0x400022A")]
		LessOrEqual
	}
}
namespace Cortopia.BE.Runtime.Actions.SightSense
{
	[Token(Token = "0x2000087")]
	public class InLineOfSight : BE_Action
	{
		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool IsInsideFOV;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float Distance;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool UseLayerMask;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public LayerMask LayerMaskFilter;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Component m_componentFilter;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private Sight m_sight;

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xC92444", Offset = "0xC92444", VA = "0xC92444", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xC9250C", Offset = "0xC9250C", VA = "0xC9250C", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xC92764", Offset = "0xC92764", VA = "0xC92764")]
		public InLineOfSight()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class InProximityRange : BE_Action
	{
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Range;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool UseLayerMask;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LayerMask LayerMaskFilter;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Component m_componentFilter;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private Sight m_sight;

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xC92768", Offset = "0xC92768", VA = "0xC92768", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xC92830", Offset = "0xC92830", VA = "0xC92830", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xC92A00", Offset = "0xC92A00", VA = "0xC92A00")]
		public InProximityRange()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Senses
{
	[Token(Token = "0x2000089")]
	public class InHearingRange : BE_Action
	{
		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Range;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private Hearing m_hearing;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IHearing m_interface;

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xC91A98", Offset = "0xC91A98", VA = "0xC91A98", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xC91B60", Offset = "0xC91B60", VA = "0xC91B60", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xC91E70", Offset = "0xC91E70", VA = "0xC91E70")]
		public InHearingRange()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class InLineOfSight : BE_Action
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool IsInsideFOV;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float Distance;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool UseLayerMask;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public LayerMask LayerMaskFilter;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Component m_componentFilter;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private Sight m_sight;

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xC91E74", Offset = "0xC91E74", VA = "0xC91E74", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xC91F3C", Offset = "0xC91F3C", VA = "0xC91F3C", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xC921A4", Offset = "0xC921A4", VA = "0xC921A4")]
		public InLineOfSight()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class InProximityRange : BE_Action
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Range;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool UseLayerMask;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LayerMask LayerMaskFilter;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Component m_componentFilter;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private Sight m_sight;

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xC921A8", Offset = "0xC921A8", VA = "0xC921A8", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xC92270", Offset = "0xC92270", VA = "0xC92270", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xC92440", Offset = "0xC92440", VA = "0xC92440")]
		public InProximityRange()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Script
{
	[Token(Token = "0x200008C")]
	public class CallScriptMethod : BE_Action
	{
		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DEE2C", Offset = "0x6DEE2C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MethodInfo method;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CallScriptMethod <>4__this;

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xC91A28", Offset = "0xC91A28", VA = "0xC91A28")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xC91A34", Offset = "0xC91A34", VA = "0xC91A34")]
			internal void <Process>b__0(object[] caller)
			{
			}
		}

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MethodName;

		[Token(Token = "0x4000245")]
		private const int MaxInheritanceLevel = 3;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action<object[]> m_action;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private object[] m_object;

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xC91818", Offset = "0xC91818", VA = "0xC91818", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xC91A30", Offset = "0xC91A30", VA = "0xC91A30")]
		public CallScriptMethod()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Randomness
{
	[Token(Token = "0x200008D")]
	public class RandomBranch : BE_Action
	{
		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int TransitionsCount;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly System.Random m_random;

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xC9162C", Offset = "0xC9162C", VA = "0xC9162C", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xC916F4", Offset = "0xC916F4", VA = "0xC916F4", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xC91760", Offset = "0xC91760", VA = "0xC91760")]
		public RandomBranch()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Physics.Collision
{
	[Token(Token = "0x200008E")]
	public enum ColliderEventType
	{
		[Token(Token = "0x400024B")]
		Default,
		[Token(Token = "0x400024C")]
		OnEnter,
		[Token(Token = "0x400024D")]
		OnStay,
		[Token(Token = "0x400024E")]
		OnExit
	}
	[Token(Token = "0x200008F")]
	public class OnColliderEnter : BE_Action
	{
		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool IsTrigger;

		[NonSerialized]
		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Collider m_collider;

		[NonSerialized]
		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EventDelegate m_eventDelegate;

		[NonSerialized]
		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_hasEntered;

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xC8F6DC", Offset = "0xC8F6DC", VA = "0xC8F6DC", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xC8F7A4", Offset = "0xC8F7A4", VA = "0xC8F7A4", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xC8FCE4", Offset = "0xC8FCE4", VA = "0xC8FCE4")]
		private void OnCollisionEnter(UnityEngine.Collision collision)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xC8FCF0", Offset = "0xC8FCF0", VA = "0xC8FCF0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xC8FCFC", Offset = "0xC8FCFC", VA = "0xC8FCFC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xC90104", Offset = "0xC90104", VA = "0xC90104")]
		public OnColliderEnter()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class OnColliderEvent : BE_Action
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6DF814", Offset = "0x6DF814")]
		public bool IsTrigger;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6DF84C", Offset = "0x6DF84C")]
		public bool OnEnter;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool OnStay;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		public bool OnExit;

		[NonSerialized]
		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Collider m_collider;

		[NonSerialized]
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EventDelegate m_eventDelegate;

		[NonSerialized]
		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ColliderEventType m_currentState;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IDictionary<ColliderEventType, TransitionConnector> m_transitionTypes;

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xC90108", Offset = "0xC90108", VA = "0xC90108", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xC90240", Offset = "0xC90240", VA = "0xC90240")]
		private void AddConnector(ColliderEventType colliderEvent, TransitionConnector connector)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xC9031C", Offset = "0xC9031C", VA = "0xC9031C", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xC908E8", Offset = "0xC908E8", VA = "0xC908E8")]
		private void OnCollisionEnter(UnityEngine.Collision collision)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xC90954", Offset = "0xC90954", VA = "0xC90954")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xC909C0", Offset = "0xC909C0", VA = "0xC909C0")]
		private void OnCollisionStay(UnityEngine.Collision collision)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xC90A2C", Offset = "0xC90A2C", VA = "0xC90A2C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xC90A98", Offset = "0xC90A98", VA = "0xC90A98")]
		private void OnCollisionExit(UnityEngine.Collision collision)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xC90B04", Offset = "0xC90B04", VA = "0xC90B04")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xC904C0", Offset = "0xC904C0", VA = "0xC904C0")]
		private void SetEventDelegates(bool shouldActivate)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xC90F20", Offset = "0xC90F20", VA = "0xC90F20")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xC90F48", Offset = "0xC90F48", VA = "0xC90F48")]
		public OnColliderEvent()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class OnColliderExit : BE_Action
	{
		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool IsTrigger;

		[NonSerialized]
		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Collider m_collider;

		[NonSerialized]
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EventDelegate m_eventDelegate;

		[NonSerialized]
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_hasExited;

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xC90FC4", Offset = "0xC90FC4", VA = "0xC90FC4", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xC9108C", Offset = "0xC9108C", VA = "0xC9108C", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xC913E0", Offset = "0xC913E0", VA = "0xC913E0")]
		private void OnCollisionExit(UnityEngine.Collision collision)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xC913EC", Offset = "0xC913EC", VA = "0xC913EC")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xC913F8", Offset = "0xC913F8", VA = "0xC913F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xC91628", Offset = "0xC91628", VA = "0xC91628")]
		public OnColliderExit()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Parameters
{
	[Serializable]
	[Token(Token = "0x2000092")]
	public class BE_ActionParam
	{
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object Value;

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xC8F6A4", Offset = "0xC8F6A4", VA = "0xC8F6A4")]
		public BE_ActionParam(string name, object value)
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Movement
{
	[Token(Token = "0x2000093")]
	public class Rotate : BE_Action
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 EulerAngles;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float Seconds;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve Curve;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_duration;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 m_frameDeltaRotation;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 m_totalRotation;

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xC8F30C", Offset = "0xC8F30C", VA = "0xC8F30C", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xC8F35C", Offset = "0xC8F35C", VA = "0xC8F35C", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xC8F58C", Offset = "0xC8F58C", VA = "0xC8F58C")]
		public Rotate()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class Wait : BE_Action
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Seconds;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_duration;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_lastUpdateTime;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_isStarted;

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xC8F590", Offset = "0xC8F590", VA = "0xC8F590", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xC8F5E0", Offset = "0xC8F5E0", VA = "0xC8F5E0", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xC8F6A0", Offset = "0xC8F6A0", VA = "0xC8F6A0")]
		public Wait()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Interfaces
{
	[Token(Token = "0x2000095")]
	public interface IBehaviourSystemReferable
	{
		[Token(Token = "0x6000511")]
		void UpdateReferences();
	}
}
namespace Cortopia.BE.Runtime.Actions.Execution
{
	[Token(Token = "0x2000096")]
	public class ChangeState : BE_Action, IBehaviourSystemReferable
	{
		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public State State;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public StateMachine StateMachine;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private StateChangeEvent m_stateChangeEvent;

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xC8EDAC", Offset = "0xC8EDAC", VA = "0xC8EDAC", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xC8EDFC", Offset = "0xC8EDFC", VA = "0xC8EDFC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xC8EED4", Offset = "0xC8EED4", VA = "0xC8EED4", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xC8EE04", Offset = "0xC8EE04", VA = "0xC8EE04")]
		private void SetListenerActive(bool shouldBeActive)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xC8EF60", Offset = "0xC8EF60", VA = "0xC8EF60", Slot = "7")]
		public void UpdateReferences()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xC8EFFC", Offset = "0xC8EFFC", VA = "0xC8EFFC")]
		public ChangeState()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public enum ExecutionType
	{
		[Token(Token = "0x400026F")]
		FixedNumber,
		[Token(Token = "0x4000270")]
		Infinity
	}
	[Token(Token = "0x2000098")]
	public class PerformTransition : BE_Action
	{
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int ConnectionIndex;

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xC8F0AC", Offset = "0xC8F0AC", VA = "0xC8F0AC", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xC8F0FC", Offset = "0xC8F0FC", VA = "0xC8F0FC", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xC8F1E4", Offset = "0xC8F1E4", VA = "0xC8F1E4")]
		public PerformTransition()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class Repeat : BE_Action
	{
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ExecutionType RepetitionType;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public uint Repetitions;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private uint m_repetitions;

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xC8F1E8", Offset = "0xC8F1E8", VA = "0xC8F1E8", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xC8F238", Offset = "0xC8F238", VA = "0xC8F238", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xC8F300", Offset = "0xC8F300", VA = "0xC8F300")]
		public Repeat()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Connectors
{
	[Serializable]
	[Token(Token = "0x200009A")]
	public class TransitionConnector
	{
		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public string Name;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public int TransitionIndex;

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xC8ED70", Offset = "0xC8ED70", VA = "0xC8ED70")]
		public TransitionConnector(string name, int index)
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Conditions
{
	[Token(Token = "0x200009B")]
	public class RelationalCondition : BE_Action
	{
		[Token(Token = "0x600051F")]
		[Address(RVA = "0xC8EC8C", Offset = "0xC8EC8C", VA = "0xC8EC8C")]
		protected bool Evaluate(RelationalOperator type, int a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xC8ECFC", Offset = "0xC8ECFC", VA = "0xC8ECFC")]
		protected bool Evaluate(RelationalOperator type, float a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xC8ED6C", Offset = "0xC8ED6C", VA = "0xC8ED6C")]
		public RelationalCondition()
		{
		}
	}
}
