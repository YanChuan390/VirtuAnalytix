using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityStandardAssets.Effects;

[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x61B29C", Offset = "0x61B29C")]
public class AfterburnerPhysicsForce : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public float effectAngle;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x1C")]
	public float effectWidth;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	public float effectDistance;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x24")]
	public float force;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x28")]
	private Collider[] m_Cols;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x30")]
	private SphereCollider m_Sphere;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1537044", Offset = "0x1537044", VA = "0x1537044")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x15370E8", Offset = "0x15370E8", VA = "0x15370E8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x15374F4", Offset = "0x15374F4", VA = "0x15374F4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x153797C", Offset = "0x153797C", VA = "0x153797C")]
	public AfterburnerPhysicsForce()
	{
	}
}
[Token(Token = "0x2000003")]
public class ExplosionFireAndDebris : MonoBehaviour
{
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B2FC", Offset = "0x61B2FC")]
	private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x20")]
		public ExplosionFireAndDebris <>4__this;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x28")]
		private float <multiplier>5__1;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x2C")]
		private float <r>5__2;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x30")]
		private Collider[] <cols>5__3;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x38")]
		private float <testR>5__4;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x3C")]
		private int <n>5__5;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x40")]
		private Transform <prefab>5__6;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 <pos>5__7;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x54")]
		private Quaternion <rot>5__8;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x68")]
		private Collider[] <>s__9;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x70")]
		private int <>s__10;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x78")]
		private Collider <col>5__11;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x80")]
		private RaycastHit <fireHit>5__12;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0xAC")]
		private Ray <fireRay>5__13;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0xC4")]
		private RaycastHit <fireHit>5__14;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0xF0")]
		private Ray <fireRay>5__15;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x1538CF4", Offset = "0x1538CF4", VA = "0x1538CF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x1538D3C", Offset = "0x1538D3C", VA = "0x1538D3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1537A08", Offset = "0x1537A08", VA = "0x1537A08")]
		[DebuggerHidden]
		public <Start>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x15386A0", Offset = "0x15386A0", VA = "0x15386A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x15386A4", Offset = "0x15386A4", VA = "0x15386A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1538CFC", Offset = "0x1538CFC", VA = "0x1538CFC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x18")]
	public Transform[] debrisPrefabs;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x20")]
	public Transform firePrefab;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x28")]
	public int numDebrisPieces;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x2C")]
	public int numFires;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1537990", Offset = "0x1537990", VA = "0x1537990")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61B31C", Offset = "0x61B31C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1537A34", Offset = "0x1537A34", VA = "0x1537A34")]
	private void AddFire(Transform t, Vector3 pos, Vector3 normal)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1537B58", Offset = "0x1537B58", VA = "0x1537B58")]
	public ExplosionFireAndDebris()
	{
	}
}
[Token(Token = "0x2000005")]
public class ExplosionPhysicsForce : MonoBehaviour
{
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B30C", Offset = "0x61B30C")]
	private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x20")]
		public ExplosionPhysicsForce <>4__this;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x28")]
		private float <multiplier>5__1;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x2C")]
		private float <r>5__2;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x30")]
		private Collider[] <cols>5__3;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x38")]
		private List<Rigidbody> <rigidbodies>5__4;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x40")]
		private Collider[] <>s__5;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x48")]
		private int <>s__6;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x50")]
		private Collider <col>5__7;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x58")]
		private List<Rigidbody>.Enumerator <>s__8;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x70")]
		private Rigidbody <rb>5__9;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x1539194", Offset = "0x1539194", VA = "0x1539194", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x15391DC", Offset = "0x15391DC", VA = "0x15391DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1537BDC", Offset = "0x1537BDC", VA = "0x1537BDC")]
		[DebuggerHidden]
		public <Start>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1538D44", Offset = "0x1538D44", VA = "0x1538D44", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1538D48", Offset = "0x1538D48", VA = "0x1538D48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x153919C", Offset = "0x153919C", VA = "0x153919C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x18")]
	public float explosionForce;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1537B64", Offset = "0x1537B64", VA = "0x1537B64")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61B3CC", Offset = "0x61B3CC")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1537C08", Offset = "0x1537C08", VA = "0x1537C08")]
	public ExplosionPhysicsForce()
	{
	}
}
[Token(Token = "0x2000007")]
public class ExtinguishableParticleSystem : MonoBehaviour
{
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x18")]
	public float multiplier;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem[] m_Systems;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1537C18", Offset = "0x1537C18", VA = "0x1537C18")]
	private void Start()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1537C74", Offset = "0x1537C74", VA = "0x1537C74")]
	public void Extinguish()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1537D00", Offset = "0x1537D00", VA = "0x1537D00")]
	public ExtinguishableParticleSystem()
	{
	}
}
[Token(Token = "0x2000008")]
public class FireLight : MonoBehaviour
{
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x18")]
	private float m_Rnd;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_Burning;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x20")]
	private Light m_Light;

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1537D10", Offset = "0x1537D10", VA = "0x1537D10")]
	private void Start()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1537D84", Offset = "0x1537D84", VA = "0x1537D84")]
	private void Update()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1537F40", Offset = "0x1537F40", VA = "0x1537F40")]
	public void Extinguish()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1537F68", Offset = "0x1537F68", VA = "0x1537F68")]
	public FireLight()
	{
	}
}
[Token(Token = "0x2000009")]
public class Hose : MonoBehaviour
{
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x18")]
	public float maxPower;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x1C")]
	public float minPower;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x20")]
	public float changeSpeed;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem[] hoseWaterSystems;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x30")]
	public Renderer systemRenderer;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x38")]
	private float m_Power;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1537F78", Offset = "0x1537F78", VA = "0x1537F78")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x15380F4", Offset = "0x15380F4", VA = "0x15380F4")]
	public Hose()
	{
	}
}
[Token(Token = "0x200000A")]
public class ParticleSystemMultiplier : MonoBehaviour
{
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x18")]
	public float multiplier;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1538110", Offset = "0x1538110", VA = "0x1538110")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1538270", Offset = "0x1538270", VA = "0x1538270")]
	public ParticleSystemMultiplier()
	{
	}
}
[Token(Token = "0x200000B")]
public class SmokeParticles : MonoBehaviour
{
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip[] extinguishSounds;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1538280", Offset = "0x1538280", VA = "0x1538280")]
	private void Start()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x153833C", Offset = "0x153833C", VA = "0x153833C")]
	public SmokeParticles()
	{
	}
}
[Token(Token = "0x200000C")]
public class WaterHoseParticles : MonoBehaviour
{
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x0")]
	public static float lastSoundTime;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x18")]
	public float force;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x20")]
	private List<ParticleCollisionEvent> m_CollisionEvents;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem m_ParticleSystem;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1538344", Offset = "0x1538344", VA = "0x1538344")]
	private void Start()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x15383A0", Offset = "0x15383A0", VA = "0x15383A0")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1538614", Offset = "0x1538614", VA = "0x1538614")]
	public WaterHoseParticles()
	{
	}
}
