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
[AttributeAttribute(Name = "RequireComponent", RVA = "0x876A60", Offset = "0x876A60")]
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
	[Address(RVA = "0x1D66818", Offset = "0x1D66818", VA = "0x1D66818")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1D668BC", Offset = "0x1D668BC", VA = "0x1D668BC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1D66CC8", Offset = "0x1D66CC8", VA = "0x1D66CC8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1D67150", Offset = "0x1D67150", VA = "0x1D67150")]
	public AfterburnerPhysicsForce()
	{
	}
}
[Token(Token = "0x2000003")]
public class ExplosionFireAndDebris : MonoBehaviour
{
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876AC0", Offset = "0x876AC0")]
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
		private float <multiplier>5__2;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x1D68394", Offset = "0x1D68394", VA = "0x1D68394", Slot = "4")]
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
			[Address(RVA = "0x1D683DC", Offset = "0x1D683DC", VA = "0x1D683DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1D671DC", Offset = "0x1D671DC", VA = "0x1D671DC")]
		[DebuggerHidden]
		public <Start>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1D67E70", Offset = "0x1D67E70", VA = "0x1D67E70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1D67E74", Offset = "0x1D67E74", VA = "0x1D67E74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1D6839C", Offset = "0x1D6839C", VA = "0x1D6839C", Slot = "8")]
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
	[Address(RVA = "0x1D67164", Offset = "0x1D67164", VA = "0x1D67164")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x876AE0", Offset = "0x876AE0")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1D67208", Offset = "0x1D67208", VA = "0x1D67208")]
	private void AddFire(Transform t, Vector3 pos, Vector3 normal)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1D6732C", Offset = "0x1D6732C", VA = "0x1D6732C")]
	public ExplosionFireAndDebris()
	{
	}
}
[Token(Token = "0x2000005")]
public class ExplosionPhysicsForce : MonoBehaviour
{
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876AD0", Offset = "0x876AD0")]
	private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x20")]
		public ExplosionPhysicsForce <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x1D68768", Offset = "0x1D68768", VA = "0x1D68768", Slot = "4")]
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
			[Address(RVA = "0x1D687B0", Offset = "0x1D687B0", VA = "0x1D687B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1D673AC", Offset = "0x1D673AC", VA = "0x1D673AC")]
		[DebuggerHidden]
		public <Start>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1D683E4", Offset = "0x1D683E4", VA = "0x1D683E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1D683E8", Offset = "0x1D683E8", VA = "0x1D683E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1D68770", Offset = "0x1D68770", VA = "0x1D68770", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x18")]
	public float explosionForce;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1D67334", Offset = "0x1D67334", VA = "0x1D67334")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x876B90", Offset = "0x876B90")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1D673D8", Offset = "0x1D673D8", VA = "0x1D673D8")]
	public ExplosionPhysicsForce()
	{
	}
}
[Token(Token = "0x2000007")]
public class ExtinguishableParticleSystem : MonoBehaviour
{
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x18")]
	public float multiplier;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem[] m_Systems;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1D673E8", Offset = "0x1D673E8", VA = "0x1D673E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1D67444", Offset = "0x1D67444", VA = "0x1D67444")]
	public void Extinguish()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1D674D0", Offset = "0x1D674D0", VA = "0x1D674D0")]
	public ExtinguishableParticleSystem()
	{
	}
}
[Token(Token = "0x2000008")]
public class FireLight : MonoBehaviour
{
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x18")]
	private float m_Rnd;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_Burning;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x20")]
	private Light m_Light;

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1D674E0", Offset = "0x1D674E0", VA = "0x1D674E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1D67554", Offset = "0x1D67554", VA = "0x1D67554")]
	private void Update()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1D67710", Offset = "0x1D67710", VA = "0x1D67710")]
	public void Extinguish()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1D67738", Offset = "0x1D67738", VA = "0x1D67738")]
	public FireLight()
	{
	}
}
[Token(Token = "0x2000009")]
public class Hose : MonoBehaviour
{
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x18")]
	public float maxPower;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x1C")]
	public float minPower;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x20")]
	public float changeSpeed;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem[] hoseWaterSystems;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x30")]
	public Renderer systemRenderer;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x38")]
	private float m_Power;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1D67748", Offset = "0x1D67748", VA = "0x1D67748")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1D678C4", Offset = "0x1D678C4", VA = "0x1D678C4")]
	public Hose()
	{
	}
}
[Token(Token = "0x200000A")]
public class ParticleSystemMultiplier : MonoBehaviour
{
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x18")]
	public float multiplier;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1D678E0", Offset = "0x1D678E0", VA = "0x1D678E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1D67A40", Offset = "0x1D67A40", VA = "0x1D67A40")]
	public ParticleSystemMultiplier()
	{
	}
}
[Token(Token = "0x200000B")]
public class SmokeParticles : MonoBehaviour
{
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip[] extinguishSounds;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1D67A50", Offset = "0x1D67A50", VA = "0x1D67A50")]
	private void Start()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1D67B0C", Offset = "0x1D67B0C", VA = "0x1D67B0C")]
	public SmokeParticles()
	{
	}
}
[Token(Token = "0x200000C")]
public class WaterHoseParticles : MonoBehaviour
{
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x0")]
	public static float lastSoundTime;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x18")]
	public float force;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x20")]
	private List<ParticleCollisionEvent> m_CollisionEvents;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem m_ParticleSystem;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1D67B14", Offset = "0x1D67B14", VA = "0x1D67B14")]
	private void Start()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1D67B70", Offset = "0x1D67B70", VA = "0x1D67B70")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1D67DE4", Offset = "0x1D67DE4", VA = "0x1D67DE4")]
	public WaterHoseParticles()
	{
	}
}
