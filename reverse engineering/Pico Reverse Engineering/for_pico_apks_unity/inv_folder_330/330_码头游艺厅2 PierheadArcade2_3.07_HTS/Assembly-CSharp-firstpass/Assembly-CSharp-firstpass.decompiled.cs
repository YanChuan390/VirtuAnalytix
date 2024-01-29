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
[AttributeAttribute(Name = "RequireComponent", RVA = "0x603B98", Offset = "0x603B98")]
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
	[Address(RVA = "0x14D4854", Offset = "0x14D4854", VA = "0x14D4854")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x14D48F8", Offset = "0x14D48F8", VA = "0x14D48F8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x14D4D04", Offset = "0x14D4D04", VA = "0x14D4D04")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x14D518C", Offset = "0x14D518C", VA = "0x14D518C")]
	public AfterburnerPhysicsForce()
	{
	}
}
[Token(Token = "0x2000003")]
public class ExplosionFireAndDebris : MonoBehaviour
{
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x603BF8", Offset = "0x603BF8")]
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
			[Address(RVA = "0x14D63D0", Offset = "0x14D63D0", VA = "0x14D63D0", Slot = "4")]
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
			[Address(RVA = "0x14D6418", Offset = "0x14D6418", VA = "0x14D6418", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x14D5218", Offset = "0x14D5218", VA = "0x14D5218")]
		[DebuggerHidden]
		public <Start>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x14D5EAC", Offset = "0x14D5EAC", VA = "0x14D5EAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x14D5EB0", Offset = "0x14D5EB0", VA = "0x14D5EB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x14D63D8", Offset = "0x14D63D8", VA = "0x14D63D8", Slot = "8")]
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
	[Address(RVA = "0x14D51A0", Offset = "0x14D51A0", VA = "0x14D51A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x603C18", Offset = "0x603C18")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x14D5244", Offset = "0x14D5244", VA = "0x14D5244")]
	private void AddFire(Transform t, Vector3 pos, Vector3 normal)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x14D5368", Offset = "0x14D5368", VA = "0x14D5368")]
	public ExplosionFireAndDebris()
	{
	}
}
[Token(Token = "0x2000005")]
public class ExplosionPhysicsForce : MonoBehaviour
{
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x603C08", Offset = "0x603C08")]
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
			[Address(RVA = "0x14D67A4", Offset = "0x14D67A4", VA = "0x14D67A4", Slot = "4")]
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
			[Address(RVA = "0x14D67EC", Offset = "0x14D67EC", VA = "0x14D67EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x14D53E8", Offset = "0x14D53E8", VA = "0x14D53E8")]
		[DebuggerHidden]
		public <Start>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x14D6420", Offset = "0x14D6420", VA = "0x14D6420", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x14D6424", Offset = "0x14D6424", VA = "0x14D6424", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x14D67AC", Offset = "0x14D67AC", VA = "0x14D67AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x18")]
	public float explosionForce;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x14D5370", Offset = "0x14D5370", VA = "0x14D5370")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x603CC8", Offset = "0x603CC8")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x14D5414", Offset = "0x14D5414", VA = "0x14D5414")]
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
	[Address(RVA = "0x14D5424", Offset = "0x14D5424", VA = "0x14D5424")]
	private void Start()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x14D5480", Offset = "0x14D5480", VA = "0x14D5480")]
	public void Extinguish()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x14D550C", Offset = "0x14D550C", VA = "0x14D550C")]
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
	[Address(RVA = "0x14D551C", Offset = "0x14D551C", VA = "0x14D551C")]
	private void Start()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x14D5590", Offset = "0x14D5590", VA = "0x14D5590")]
	private void Update()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x14D574C", Offset = "0x14D574C", VA = "0x14D574C")]
	public void Extinguish()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x14D5774", Offset = "0x14D5774", VA = "0x14D5774")]
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
	[Address(RVA = "0x14D5784", Offset = "0x14D5784", VA = "0x14D5784")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x14D5900", Offset = "0x14D5900", VA = "0x14D5900")]
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
	[Address(RVA = "0x14D591C", Offset = "0x14D591C", VA = "0x14D591C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x14D5A7C", Offset = "0x14D5A7C", VA = "0x14D5A7C")]
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
	[Address(RVA = "0x14D5A8C", Offset = "0x14D5A8C", VA = "0x14D5A8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x14D5B48", Offset = "0x14D5B48", VA = "0x14D5B48")]
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
	[Address(RVA = "0x14D5B50", Offset = "0x14D5B50", VA = "0x14D5B50")]
	private void Start()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x14D5BAC", Offset = "0x14D5BAC", VA = "0x14D5BAC")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x14D5E20", Offset = "0x14D5E20", VA = "0x14D5E20")]
	public WaterHoseParticles()
	{
	}
}
