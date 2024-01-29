using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Play;
using RootMotion.Dynamics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class NavMeshPuppet : MonoBehaviour
{
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739228", Offset = "0x739228")]
	private sealed class <WaitPatrolTime>d__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NavMeshPuppet <>4__this;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int state;

		[Token(Token = "0x17000065")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0xBB84B0", Offset = "0xBB84B0", VA = "0xBB84B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0xBB8518", Offset = "0xBB8518", VA = "0xBB8518", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xBB7E94", Offset = "0xBB7E94", VA = "0xBB7E94")]
		[DebuggerHidden]
		public <WaitPatrolTime>d__58(int <>1__state)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xBB83A0", Offset = "0xBB83A0", VA = "0xBB83A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xBB83A4", Offset = "0xBB83A4", VA = "0xBB83A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xBB84B8", Offset = "0xBB84B8", VA = "0xBB84B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739238", Offset = "0x739238")]
	private sealed class <WaitLostTime>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NavMeshPuppet <>4__this;

		[Token(Token = "0x17000067")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0xBB8330", Offset = "0xBB8330", VA = "0xBB8330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0xBB8398", Offset = "0xBB8398", VA = "0xBB8398", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xBB7EC0", Offset = "0xBB7EC0", VA = "0xBB7EC0")]
		[DebuggerHidden]
		public <WaitLostTime>d__59(int <>1__state)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xBB820C", Offset = "0xBB820C", VA = "0xBB820C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xBB8210", Offset = "0xBB8210", VA = "0xBB8210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xBB8338", Offset = "0xBB8338", VA = "0xBB8338", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739248", Offset = "0x739248")]
	private sealed class <Healthback>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NavMeshPuppet <>4__this;

		[Token(Token = "0x17000069")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0xBB819C", Offset = "0xBB819C", VA = "0xBB819C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0xBB8204", Offset = "0xBB8204", VA = "0xBB8204", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xBB7EEC", Offset = "0xBB7EEC", VA = "0xBB7EEC")]
		[DebuggerHidden]
		public <Healthback>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xBB80E8", Offset = "0xBB80E8", VA = "0xBB80E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xBB80EC", Offset = "0xBB80EC", VA = "0xBB80EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xBB81A4", Offset = "0xBB81A4", VA = "0xBB81A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739258", Offset = "0x739258")]
	private sealed class <Doorwait>d__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NavMeshPuppet <>4__this;

		[Token(Token = "0x1700006B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0xBB8078", Offset = "0xBB8078", VA = "0xBB8078", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0xBB80E0", Offset = "0xBB80E0", VA = "0xBB80E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xBB7F18", Offset = "0xBB7F18", VA = "0xBB7F18")]
		[DebuggerHidden]
		public <Doorwait>d__61(int <>1__state)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xBB7FAC", Offset = "0xBB7FAC", VA = "0xBB7FAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xBB7FB0", Offset = "0xBB7FB0", VA = "0xBB7FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xBB8080", Offset = "0xBB8080", VA = "0xBB8080", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject find;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PlayerHealth PH;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool playerIN;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public BehaviourPuppet puppet;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public NavMeshAgent agent;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform target;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Animator animator;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool attack;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int Health;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public UnityEvent Die;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject player;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform head;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool Leave;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AudioClip[] foot;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AudioSource st;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public AudioSource hit;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public AudioClip catchSound;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7393B8", Offset = "0x7393B8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7393B8", Offset = "0x7393B8")]
	public Transform[] wayPoints;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739418", Offset = "0x739418")]
	public float wayPointWaitTime;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private int wpID;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x739450", Offset = "0x739450")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739450", Offset = "0x739450")]
	public LayerMask doorsLayer;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7394B0", Offset = "0x7394B0")]
	public float seeDistance;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float doorDistance;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7394E8", Offset = "0x7394E8")]
	public Vector2 enemyFOV;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public Vector2 BackFOV;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739520", Offset = "0x739520")]
	public float closeDistance;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float closestDist;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739558", Offset = "0x739558")]
	public float lostTime;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739590", Offset = "0x739590")]
	public float patrolTime;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7395C8", Offset = "0x7395C8")]
	public float walkSpeed;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public bool seePlayer;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
	public bool chasePlayer;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
	public bool searchPlayer;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private int searchState;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739600", Offset = "0x739600")]
	public float catchDistance;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private int catchPlayerState;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Vector3 lastSawPoint;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xBB6384", Offset = "0xBB6384", VA = "0xBB6384")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xBB6440", Offset = "0xBB6440", VA = "0xBB6440")]
	public bool DoorRaycast()
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xBB65A8", Offset = "0xBB65A8", VA = "0xBB65A8")]
	public void DoorAttack()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xBB6860", Offset = "0xBB6860", VA = "0xBB6860")]
	public void CallEnemy(Vector3 pos)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xBB68D4", Offset = "0xBB68D4", VA = "0xBB68D4")]
	private bool PlayerRaycast()
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xBB6BFC", Offset = "0xBB6BFC", VA = "0xBB6BFC")]
	private bool PlayerFOV()
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xBB6E7C", Offset = "0xBB6E7C", VA = "0xBB6E7C")]
	private void EnemySetDestination(Vector3 pos)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xBB6EF8", Offset = "0xBB6EF8", VA = "0xBB6EF8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xBB7B78", Offset = "0xBB7B78", VA = "0xBB7B78")]
	public void Hit()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xBB7B90", Offset = "0xBB7B90", VA = "0xBB7B90")]
	public void HitAxe()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xBB7BA8", Offset = "0xBB7BA8", VA = "0xBB7BA8")]
	public void Step()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xBB7BDC", Offset = "0xBB7BDC", VA = "0xBB7BDC")]
	private AudioClip RandomClip()
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xBB7C30", Offset = "0xBB7C30", VA = "0xBB7C30")]
	public void EndAttack()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xBB7C38", Offset = "0xBB7C38", VA = "0xBB7C38")]
	public void AttackB()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xBB7D60", Offset = "0xBB7D60", VA = "0xBB7D60")]
	public void EndAttack(string s)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xBB7714", Offset = "0xBB7714", VA = "0xBB7714")]
	private void CatchingPlayer()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xBB7518", Offset = "0xBB7518", VA = "0xBB7518")]
	private void CheckLastPoint()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xBB7270", Offset = "0xBB7270", VA = "0xBB7270")]
	private void SearchPlayer()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xBB78A0", Offset = "0xBB78A0", VA = "0xBB78A0")]
	private void PatrolWayPoints()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xBB7E6C", Offset = "0xBB7E6C", VA = "0xBB7E6C")]
	public void RestartEnemyStats()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xBB7DE8", Offset = "0xBB7DE8", VA = "0xBB7DE8")]
	public void ResetSearchStates()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xBB7D68", Offset = "0xBB7D68", VA = "0xBB7D68")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73DBEC", Offset = "0x73DBEC")]
	private IEnumerator WaitPatrolTime(int state)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xBB7DFC", Offset = "0xBB7DFC", VA = "0xBB7DFC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73DC50", Offset = "0x73DC50")]
	private IEnumerator WaitLostTime()
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xBB7B08", Offset = "0xBB7B08", VA = "0xBB7B08")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73DCB4", Offset = "0x73DCB4")]
	private IEnumerator Healthback()
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xBB67F0", Offset = "0xBB67F0", VA = "0xBB67F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73DD18", Offset = "0x73DD18")]
	private IEnumerator Doorwait()
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xBB7F44", Offset = "0xBB7F44", VA = "0xBB7F44")]
	public NavMeshPuppet()
	{
	}
}
[Token(Token = "0x2000003")]
public class Skeleton : MonoBehaviour
{
	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PuppetMaster puppetMaster;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ConfigurableJoint[] leftLeg;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ConfigurableJoint[] rightLeg;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool leftLegRemoved;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool rightLegRemoved;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xEB1648", Offset = "0xEB1648", VA = "0xEB1648")]
	private void Start()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xEB1748", Offset = "0xEB1748", VA = "0xEB1748")]
	public void OnRebuild()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xEB17D4", Offset = "0xEB17D4", VA = "0xEB17D4")]
	private void OnMuscleDisconnected(Muscle m)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xEB189C", Offset = "0xEB189C", VA = "0xEB189C")]
	private bool IsLegMuscle(Muscle m, out bool isLeft)
	{
		return default(bool);
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xEB1A24", Offset = "0xEB1A24", VA = "0xEB1A24")]
	public Skeleton()
	{
	}
}
namespace Play
{
	[Token(Token = "0x2000004")]
	public class PlayerHealth : MonoBehaviour
	{
		[Token(Token = "0x200007B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739268", Offset = "0x739268")]
		private sealed class <W>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlayerHealth <>4__this;

			[Token(Token = "0x1700006D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004A3")]
				[Address(RVA = "0xBB8AF4", Offset = "0xBB8AF4", VA = "0xBB8AF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004A5")]
				[Address(RVA = "0xBB8B5C", Offset = "0xBB8B5C", VA = "0xBB8B5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xBB87B8", Offset = "0xBB87B8", VA = "0xBB87B8")]
			[DebuggerHidden]
			public <W>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xBB8A2C", Offset = "0xBB8A2C", VA = "0xBB8A2C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xBB8A30", Offset = "0xBB8A30", VA = "0xBB8A30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xBB8AFC", Offset = "0xBB8AFC", VA = "0xBB8AFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200007C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739278", Offset = "0x739278")]
		private sealed class <W1>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlayerHealth <>4__this;

			[Token(Token = "0x1700006F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004A9")]
				[Address(RVA = "0xBB89BC", Offset = "0xBB89BC", VA = "0xBB89BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004AB")]
				[Address(RVA = "0xBB8A24", Offset = "0xBB8A24", VA = "0xBB8A24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xBB8854", Offset = "0xBB8854", VA = "0xBB8854")]
			[DebuggerHidden]
			public <W1>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xBB8908", Offset = "0xBB8908", VA = "0xBB8908", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xBB890C", Offset = "0xBB890C", VA = "0xBB890C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0xBB89C4", Offset = "0xBB89C4", VA = "0xBB89C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent Die1;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent Die;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int health;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject img;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float alpha;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Image image;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool q;

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xBB8520", Offset = "0xBB8520", VA = "0xBB8520")]
		private void Start()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xBB85A4", Offset = "0xBB85A4", VA = "0xBB85A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xBB8790", Offset = "0xBB8790", VA = "0xBB8790")]
		private void decreaseHunger()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xBB8720", Offset = "0xBB8720", VA = "0xBB8720")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73DD7C", Offset = "0x73DD7C")]
		private IEnumerator W()
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xBB87E4", Offset = "0xBB87E4", VA = "0xBB87E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73DDE0", Offset = "0x73DDE0")]
		private IEnumerator W1()
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xBB8880", Offset = "0xBB8880", VA = "0xBB8880")]
		public PlayerHealth()
		{
		}
	}
}
namespace Door
{
	[Token(Token = "0x2000005")]
	public class DoorDes : MonoBehaviour
	{
		[Token(Token = "0x200007D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739288", Offset = "0x739288")]
		private sealed class <WaithitTime>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DoorDes <>4__this;

			[Token(Token = "0x17000071")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004AF")]
				[Address(RVA = "0xBB6314", Offset = "0xBB6314", VA = "0xBB6314", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004B1")]
				[Address(RVA = "0xBB637C", Offset = "0xBB637C", VA = "0xBB637C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xBB61C8", Offset = "0xBB61C8", VA = "0xBB61C8")]
			[DebuggerHidden]
			public <WaithitTime>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xBB625C", Offset = "0xBB625C", VA = "0xBB625C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0xBB6260", Offset = "0xBB6260", VA = "0xBB6260", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0xBB631C", Offset = "0xBB631C", VA = "0xBB631C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent On;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xBB612C", Offset = "0xBB612C", VA = "0xBB612C")]
		public void Destr()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xBB6158", Offset = "0xBB6158", VA = "0xBB6158")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73DE44", Offset = "0x73DE44")]
		private IEnumerator WaithitTime()
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xBB61F4", Offset = "0xBB61F4", VA = "0xBB61F4")]
		public DoorDes()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x738D54", Offset = "0x738D54")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x738D54", Offset = "0x738D54")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200007E")]
		public enum Mode
		{
			[Token(Token = "0x4000433")]
			AnimationClips,
			[Token(Token = "0x4000434")]
			AnimationStates,
			[Token(Token = "0x4000435")]
			PlayableDirector,
			[Token(Token = "0x4000436")]
			Realtime
		}

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739638", Offset = "0x739638")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739638", Offset = "0x739638")]
		public int frameRate;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739690", Offset = "0x739690")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739690", Offset = "0x739690")]
		public float keyReductionError;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7396E8", Offset = "0x7396E8")]
		public Mode mode;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739720", Offset = "0x739720")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739758", Offset = "0x739758")]
		public string[] animationStates;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739790", Offset = "0x739790")]
		public bool loop;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7397C8", Offset = "0x7397C8")]
		public string saveToFolder;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739800", Offset = "0x739800")]
		public string appendName;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739838", Offset = "0x739838")]
		public string saveName;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739870", Offset = "0x739870")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739880", Offset = "0x739880")]
		private float <bakingProgress>k__BackingField;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7398B0", Offset = "0x7398B0")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0xBB9CAC", Offset = "0xBB9CAC", VA = "0xBB9CAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DF88", Offset = "0x73DF88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0xBB9CB4", Offset = "0xBB9CB4", VA = "0xBB9CB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DF98", Offset = "0x73DF98")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0xBB9CC0", Offset = "0xBB9CC0", VA = "0xBB9CC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DFA8", Offset = "0x73DFA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0xBB9CC8", Offset = "0xBB9CC8", VA = "0xBB9CC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DFB8", Offset = "0x73DFB8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0xBB9CD0", Offset = "0xBB9CD0", VA = "0xBB9CD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DFC8", Offset = "0x73DFC8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0xBB9CD8", Offset = "0xBB9CD8", VA = "0xBB9CD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DFD8", Offset = "0x73DFD8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xBB9B7C", Offset = "0xBB9B7C", VA = "0xBB9B7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DEA8", Offset = "0x73DEA8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xBB9BC8", Offset = "0xBB9BC8", VA = "0xBB9BC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DEE0", Offset = "0x73DEE0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xBB9C14", Offset = "0xBB9C14", VA = "0xBB9C14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DF18", Offset = "0x73DF18")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xBB9C60", Offset = "0xBB9C60", VA = "0xBB9C60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DF50", Offset = "0x73DF50")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000031")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x6000032")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x6000033")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x6000034")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x6000035")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xBB9CE0", Offset = "0xBB9CE0", VA = "0xBB9CE0")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xBB9CE4", Offset = "0xBB9CE4", VA = "0xBB9CE4")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xBB9CE8", Offset = "0xBB9CE8", VA = "0xBB9CE8")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xBB9CEC", Offset = "0xBB9CEC", VA = "0xBB9CEC")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7398C0", Offset = "0x7398C0")]
		public bool markAsLegacy;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7398F8", Offset = "0x7398F8")]
		public Transform root;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739930", Offset = "0x739930")]
		public Transform rootNode;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739968", Offset = "0x739968")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7399A0", Offset = "0x7399A0")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xEA9810", Offset = "0xEA9810", VA = "0xEA9810")]
		private void Awake()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xEA9BDC", Offset = "0xEA9BDC", VA = "0xEA9BDC", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xEA9BE4", Offset = "0xEA9BE4", VA = "0xEA9BE4", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xEA9CF4", Offset = "0xEA9CF4", VA = "0xEA9CF4", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xEA9D70", Offset = "0xEA9D70", VA = "0xEA9D70", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xEA9DEC", Offset = "0xEA9DEC", VA = "0xEA9DEC", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xEA9A2C", Offset = "0xEA9A2C", VA = "0xEA9A2C")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xEA9B04", Offset = "0xEA9B04", VA = "0xEA9B04")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xEA9E68", Offset = "0xEA9E68", VA = "0xEA9E68")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class TQ
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xEAEF98", Offset = "0xEAEF98", VA = "0xEAEF98")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class AvatarUtility
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0xBB8B64", Offset = "0xBB8B64", VA = "0xBB8B64")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xBB8D78", Offset = "0xBB8D78", VA = "0xBB8D78")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xBB8D58", Offset = "0xBB8D58", VA = "0xBB8D58")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xBB93F8", Offset = "0xBB93F8", VA = "0xBB93F8")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public static class BakerUtilities
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0xBBAF60", Offset = "0xBBAF60", VA = "0xBBAF60")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xBBC434", Offset = "0xBBC434", VA = "0xBBC434")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xBBA974", Offset = "0xBBA974", VA = "0xBBA974")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xBBAFA8", Offset = "0xBBAFA8", VA = "0xBBAFA8")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xBBA4AC", Offset = "0xBBA4AC", VA = "0xBBA4AC")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xBB9DAC", Offset = "0xBB9DAC", VA = "0xBB9DAC")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xBB9FF8", Offset = "0xBB9FF8", VA = "0xBB9FF8")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xBB9ECC", Offset = "0xBB9ECC", VA = "0xBB9ECC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xBBA130", Offset = "0xBBA130", VA = "0xBBA130")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xBBA708", Offset = "0xBBA708", VA = "0xBBA708")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xBBA804", Offset = "0xBBA804", VA = "0xBBA804")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xBBA900", Offset = "0xBBA900", VA = "0xBBA900")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xBBA878", Offset = "0xBBA878", VA = "0xBBA878")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xBBABC0", Offset = "0xBBABC0", VA = "0xBBABC0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xBBAC74", Offset = "0xBBAC74", VA = "0xBBAC74")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public class BakerMuscle
	{
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xBBAFAC", Offset = "0xBBAFAC", VA = "0xBBAFAC")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xBBB01C", Offset = "0xBBB01C", VA = "0xBBB01C")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xBBB704", Offset = "0xBBB704", VA = "0xBBB704")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xBBB7B8", Offset = "0xBBB7B8", VA = "0xBBB7B8")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xBBB6A4", Offset = "0xBBB6A4", VA = "0xBBB6A4")]
		public void Reset()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xBBB89C", Offset = "0xBBB89C", VA = "0xBBB89C")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xBBB8E4", Offset = "0xBBB8E4", VA = "0xBBB8E4")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class BakerTransform
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xBBB8EC", Offset = "0xBBB8EC", VA = "0xBBB8EC")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xBBBA80", Offset = "0xBBBA80", VA = "0xBBBA80")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xBBBA94", Offset = "0xBBBA94", VA = "0xBBBA94")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xBBBD24", Offset = "0xBBBD24", VA = "0xBBBD24")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xBBB988", Offset = "0xBBB988", VA = "0xBBB988")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xBBBF70", Offset = "0xBBBF70", VA = "0xBBBF70")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xBBBFE4", Offset = "0xBBBFE4", VA = "0xBBBFE4")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xBBC230", Offset = "0xBBC230", VA = "0xBBC230")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7399D8", Offset = "0x7399D8")]
		public bool bakeHandIK;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739A10", Offset = "0x739A10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739A10", Offset = "0x739A10")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739A68", Offset = "0x739A68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739A68", Offset = "0x739A68")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xEAADA0", Offset = "0xEAADA0", VA = "0xEAADA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xEAB1CC", Offset = "0xEAB1CC", VA = "0xEAB1CC", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xEAB1E8", Offset = "0xEAB1E8", VA = "0xEAB1E8", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xEAB308", Offset = "0xEAB308", VA = "0xEAB308", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xEAB3E4", Offset = "0xEAB3E4", VA = "0xEAB3E4", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xEAB5B4", Offset = "0xEAB5B4", VA = "0xEAB5B4", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xEAB94C", Offset = "0xEAB94C", VA = "0xEAB94C")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xEABA28", Offset = "0xEABA28", VA = "0xEABA28")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200007F")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000438")]
			Update,
			[Token(Token = "0x4000439")]
			FixedUpdate,
			[Token(Token = "0x400043A")]
			LateUpdate,
			[Token(Token = "0x400043B")]
			FixedLateUpdate
		}

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x739ABC", Offset = "0x739ABC")]
		public bool smoothFollow;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x739AF4", Offset = "0x739AF4")]
		public float rotationSensitivity;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x739B2C", Offset = "0x739B2C")]
		public float distance;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x739B64", Offset = "0x739B64")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockingOriginOffset;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739B9C", Offset = "0x739B9C")]
		public float blockedOffset;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739BB4", Offset = "0x739BB4")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739BC4", Offset = "0x739BC4")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739BD4", Offset = "0x739BD4")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetDistance;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 position;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion rotation;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000004")]
		public float x
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0xBC2F7C", Offset = "0xBC2F7C", VA = "0xBC2F7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DFE8", Offset = "0x73DFE8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0xBC2F84", Offset = "0xBC2F84", VA = "0xBC2F84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DFF8", Offset = "0x73DFF8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0xBC2F8C", Offset = "0xBC2F8C", VA = "0xBC2F8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E008", Offset = "0x73E008")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0xBC2F94", Offset = "0xBC2F94", VA = "0xBC2F94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E018", Offset = "0x73E018")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0xBC2F9C", Offset = "0xBC2F9C", VA = "0xBC2F9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E028", Offset = "0x73E028")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0xBC2FA4", Offset = "0xBC2FA4", VA = "0xBC2FA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E038", Offset = "0x73E038")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xBC3AD4", Offset = "0xBC3AD4", VA = "0xBC3AD4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xBC2FAC", Offset = "0xBC2FAC", VA = "0xBC2FAC")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xBC2FE8", Offset = "0xBC2FE8", VA = "0xBC2FE8")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xBC2FF0", Offset = "0xBC2FF0", VA = "0xBC2FF0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xBC310C", Offset = "0xBC310C", VA = "0xBC310C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xBC3168", Offset = "0xBC3168", VA = "0xBC3168", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xBC31D0", Offset = "0xBC31D0", VA = "0xBC31D0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xBC3234", Offset = "0xBC3234", VA = "0xBC3234")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xBC3140", Offset = "0xBC3140", VA = "0xBC3140")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xBC33B4", Offset = "0xBC33B4", VA = "0xBC33B4")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xBC3A24", Offset = "0xBC3A24", VA = "0xBC3A24")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xBC3B48", Offset = "0xBC3B48", VA = "0xBC3B48")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xBC3C60", Offset = "0xBC3C60", VA = "0xBC3C60")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xBC3C98", Offset = "0xBC3C98", VA = "0xBC3C98")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xBC3E50", Offset = "0xBC3E50", VA = "0xBC3E50")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xBC3F00", Offset = "0xBC3F00", VA = "0xBC3F00")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public enum Axis
	{
		[Token(Token = "0x40000AA")]
		X,
		[Token(Token = "0x40000AB")]
		Y,
		[Token(Token = "0x40000AC")]
		Z
	}
	[Token(Token = "0x2000012")]
	public class AxisTools
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0xBB9400", Offset = "0xBB9400", VA = "0xBB9400")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xBB94B8", Offset = "0xBB94B8", VA = "0xBB94B8")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xBB9564", Offset = "0xBB9564", VA = "0xBB9564")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xBB9748", Offset = "0xBB9748", VA = "0xBB9748")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xBB9680", Offset = "0xBB9680", VA = "0xBB9680")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xBB9864", Offset = "0xBB9864", VA = "0xBB9864")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xBB98AC", Offset = "0xBB98AC", VA = "0xBB98AC")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xBB9B74", Offset = "0xBB9B74", VA = "0xBB9B74")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000080")]
		public class LimbOrientation
		{
			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0xBBCADC", Offset = "0xBBCADC", VA = "0xBBCADC")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xBBC868", Offset = "0xBBC868", VA = "0xBBC868")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xBBCB54", Offset = "0xBBCB54", VA = "0xBBCB54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xBBC81C", Offset = "0xBBC81C", VA = "0xBBC81C")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000014")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000081")]
		public enum BoneType
		{
			[Token(Token = "0x4000440")]
			Unassigned,
			[Token(Token = "0x4000441")]
			Spine,
			[Token(Token = "0x4000442")]
			Head,
			[Token(Token = "0x4000443")]
			Arm,
			[Token(Token = "0x4000444")]
			Leg,
			[Token(Token = "0x4000445")]
			Tail,
			[Token(Token = "0x4000446")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000082")]
		public enum BoneSide
		{
			[Token(Token = "0x4000448")]
			Center,
			[Token(Token = "0x4000449")]
			Left,
			[Token(Token = "0x400044A")]
			Right
		}

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xBBCDC8", Offset = "0xBBCDC8", VA = "0xBBCDC8")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xBBD0C8", Offset = "0xBBD0C8", VA = "0xBBD0C8")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xBBD318", Offset = "0xBBD318", VA = "0xBBD318")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xBBD39C", Offset = "0xBBD39C", VA = "0xBBD39C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xBBD448", Offset = "0xBBD448", VA = "0xBBD448")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xBBCF78", Offset = "0xBBCF78", VA = "0xBBCF78")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xBBD278", Offset = "0xBBD278", VA = "0xBBD278")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xBBDC88", Offset = "0xBBDC88", VA = "0xBBDC88")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xBBDAA0", Offset = "0xBBDAA0", VA = "0xBBDAA0")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xBBDB94", Offset = "0xBBDB94", VA = "0xBBDB94")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xBBD668", Offset = "0xBBD668", VA = "0xBBD668")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xBBD71C", Offset = "0xBBD71C", VA = "0xBBD71C")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xBBD7D0", Offset = "0xBBD7D0", VA = "0xBBD7D0")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xBBD884", Offset = "0xBBD884", VA = "0xBBD884")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xBBD938", Offset = "0xBBD938", VA = "0xBBD938")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xBBD9EC", Offset = "0xBBD9EC", VA = "0xBBD9EC")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xBBDE9C", Offset = "0xBBDE9C", VA = "0xBBDE9C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xBBD57C", Offset = "0xBBD57C", VA = "0xBBD57C")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xBBDE0C", Offset = "0xBBDE0C", VA = "0xBBDE0C")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xBBDF0C", Offset = "0xBBDF0C", VA = "0xBBDF0C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xBBDFE4", Offset = "0xBBDFE4", VA = "0xBBDFE4")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xBBDD90", Offset = "0xBBDD90", VA = "0xBBDD90")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xBBDD18", Offset = "0xBBDD18", VA = "0xBBDD18")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000015")]
	public class BipedReferences
	{
		[Token(Token = "0x2000083")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000073")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60004B4")]
				[Address(RVA = "0xBC2F74", Offset = "0xBC2F74", VA = "0xBC2F74")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x635DCC", Offset = "0x635DCC", VA = "0x635DCC")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0xBBFB58", Offset = "0xBBFB58", VA = "0xBBFB58", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xBBFF44", Offset = "0xBBFF44", VA = "0xBBFF44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xBBFF54", Offset = "0xBBFF54", VA = "0xBBFF54", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xBC0380", Offset = "0xBC0380", VA = "0xBC0380", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xBC07B8", Offset = "0xBC07B8", VA = "0xBC07B8")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xBC0DC8", Offset = "0xBC0DC8", VA = "0xBC0DC8")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xBC0A04", Offset = "0xBC0A04", VA = "0xBC0A04")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xBC1578", Offset = "0xBC1578", VA = "0xBC1578")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xBC166C", Offset = "0xBC166C", VA = "0xBC166C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xBC1BC4", Offset = "0xBC1BC4", VA = "0xBC1BC4")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xBC19C8", Offset = "0xBC19C8", VA = "0xBC19C8")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xBC1840", Offset = "0xBC1840", VA = "0xBC1840")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xBC170C", Offset = "0xBC170C", VA = "0xBC170C")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xBC1ACC", Offset = "0xBC1ACC", VA = "0xBC1ACC")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xBC1CC0", Offset = "0xBC1CC0", VA = "0xBC1CC0")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xBC2760", Offset = "0xBC2760", VA = "0xBC2760")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xBC2244", Offset = "0xBC2244", VA = "0xBC2244")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xBC2A54", Offset = "0xBC2A54", VA = "0xBC2A54")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xBC2584", Offset = "0xBC2584", VA = "0xBC2584")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xBC2A5C", Offset = "0xBC2A5C", VA = "0xBC2A5C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xBC2A64", Offset = "0xBC2A64", VA = "0xBC2A64")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xBC2C24", Offset = "0xBC2C24", VA = "0xBC2C24")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xBC2E3C", Offset = "0xBC2E3C", VA = "0xBC2E3C")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xBC0994", Offset = "0xBC0994", VA = "0xBC0994")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xBC3F1C", Offset = "0xBC3F1C", VA = "0xBC3F1C")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xBC3F24", Offset = "0xBC3F24", VA = "0xBC3F24")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xBC4064", Offset = "0xBC4064", VA = "0xBC4064")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class Hierarchy
	{
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xEA9ED0", Offset = "0xEA9ED0", VA = "0xEA9ED0")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xEAA0D0", Offset = "0xEAA0D0", VA = "0xEAA0D0")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xEA9F68", Offset = "0xEA9F68", VA = "0xEA9F68")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xEAA1F4", Offset = "0xEAA1F4", VA = "0xEAA1F4")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xEAA318", Offset = "0xEAA318", VA = "0xEAA318")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xEAA5C0", Offset = "0xEAA5C0", VA = "0xEAA5C0")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xEAA6DC", Offset = "0xEAA6DC", VA = "0xEAA6DC")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xEAA864", Offset = "0xEAA864", VA = "0xEAA864")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xEAABF8", Offset = "0xEAABF8", VA = "0xEAABF8")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xEAA9E4", Offset = "0xEAA9E4", VA = "0xEAA9E4")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xEAAD98", Offset = "0xEAAD98", VA = "0xEAAD98")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xEABADC", Offset = "0xEABADC", VA = "0xEABADC")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xEABB4C", Offset = "0xEABB4C", VA = "0xEABB4C")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000DA")]
		None,
		[Token(Token = "0x40000DB")]
		InOutCubic,
		[Token(Token = "0x40000DC")]
		InOutQuintic,
		[Token(Token = "0x40000DD")]
		InOutSine,
		[Token(Token = "0x40000DE")]
		InQuintic,
		[Token(Token = "0x40000DF")]
		InQuartic,
		[Token(Token = "0x40000E0")]
		InCubic,
		[Token(Token = "0x40000E1")]
		InQuadratic,
		[Token(Token = "0x40000E2")]
		InElastic,
		[Token(Token = "0x40000E3")]
		InElasticSmall,
		[Token(Token = "0x40000E4")]
		InElasticBig,
		[Token(Token = "0x40000E5")]
		InSine,
		[Token(Token = "0x40000E6")]
		InBack,
		[Token(Token = "0x40000E7")]
		OutQuintic,
		[Token(Token = "0x40000E8")]
		OutQuartic,
		[Token(Token = "0x40000E9")]
		OutCubic,
		[Token(Token = "0x40000EA")]
		OutInCubic,
		[Token(Token = "0x40000EB")]
		OutInQuartic,
		[Token(Token = "0x40000EC")]
		OutElastic,
		[Token(Token = "0x40000ED")]
		OutElasticSmall,
		[Token(Token = "0x40000EE")]
		OutElasticBig,
		[Token(Token = "0x40000EF")]
		OutSine,
		[Token(Token = "0x40000F0")]
		OutBack,
		[Token(Token = "0x40000F1")]
		OutBackCubic,
		[Token(Token = "0x40000F2")]
		OutBackQuartic,
		[Token(Token = "0x40000F3")]
		BackInCubic,
		[Token(Token = "0x40000F4")]
		BackInQuartic
	}
	[Token(Token = "0x200001B")]
	public class Interp
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xEABBBC", Offset = "0xEABBBC", VA = "0xEABBBC")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xEAC624", Offset = "0xEAC624", VA = "0xEAC624")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xEAC72C", Offset = "0xEAC72C", VA = "0xEAC72C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xEABF28", Offset = "0xEABF28", VA = "0xEABF28")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xEABF34", Offset = "0xEABF34", VA = "0xEABF34")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xEABF58", Offset = "0xEABF58", VA = "0xEABF58")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xEABF94", Offset = "0xEABF94", VA = "0xEABF94")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xEABFAC", Offset = "0xEABFAC", VA = "0xEABFAC")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xEABFC0", Offset = "0xEABFC0", VA = "0xEABFC0")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xEABFD4", Offset = "0xEABFD4", VA = "0xEABFD4")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xEABFE4", Offset = "0xEABFE4", VA = "0xEABFE4")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xEAC02C", Offset = "0xEAC02C", VA = "0xEAC02C")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xEAC064", Offset = "0xEAC064", VA = "0xEAC064")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xEAC08C", Offset = "0xEAC08C", VA = "0xEAC08C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xEAC828", Offset = "0xEAC828", VA = "0xEAC828")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xEAC0C0", Offset = "0xEAC0C0", VA = "0xEAC0C0")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xEAC0E8", Offset = "0xEAC0E8", VA = "0xEAC0E8")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xEAC118", Offset = "0xEAC118", VA = "0xEAC118")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xEAC14C", Offset = "0xEAC14C", VA = "0xEAC14C")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xEAC190", Offset = "0xEAC190", VA = "0xEAC190")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xEAC1F4", Offset = "0xEAC1F4", VA = "0xEAC1F4")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xEAC258", Offset = "0xEAC258", VA = "0xEAC258")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xEAC2AC", Offset = "0xEAC2AC", VA = "0xEAC2AC")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xEAC300", Offset = "0xEAC300", VA = "0xEAC300")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xEAC398", Offset = "0xEAC398", VA = "0xEAC398")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xEAC42C", Offset = "0xEAC42C", VA = "0xEAC42C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xEAC85C", Offset = "0xEAC85C", VA = "0xEAC85C")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xEAC4D0", Offset = "0xEAC4D0", VA = "0xEAC4D0")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xEAC5B4", Offset = "0xEAC5B4", VA = "0xEAC5B4")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xEAC5E4", Offset = "0xEAC5E4", VA = "0xEAC5E4")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xEAC944", Offset = "0xEAC944", VA = "0xEAC944")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xEAC94C", Offset = "0xEAC94C", VA = "0xEAC94C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xEAC9BC", Offset = "0xEAC9BC", VA = "0xEAC9BC")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001D")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xEA857C", Offset = "0xEA857C", VA = "0xEA857C")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xEACA2C", Offset = "0xEACA2C", VA = "0xEACA2C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xEACAF8", Offset = "0xEACAF8", VA = "0xEACAF8")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xEACA44", Offset = "0xEACA44", VA = "0xEACA44")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xEACB10", Offset = "0xEACB10", VA = "0xEACB10")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xEACBB4", Offset = "0xEACBB4", VA = "0xEACBB4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xEACBE0", Offset = "0xEACBE0", VA = "0xEACBE0")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xEACC30", Offset = "0xEACC30", VA = "0xEACC30")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xEACC9C", Offset = "0xEACC9C", VA = "0xEACC9C")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xEACD90", Offset = "0xEACD90", VA = "0xEACD90")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xEACE68", Offset = "0xEACE68", VA = "0xEACE68")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xEACEC8", Offset = "0xEACEC8", VA = "0xEACEC8")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200001E")]
	public static class QuaTools
	{
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xEACEF8", Offset = "0xEACEF8", VA = "0xEACEF8")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xEACFFC", Offset = "0xEACFFC", VA = "0xEACFFC")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xEAD0FC", Offset = "0xEAD0FC", VA = "0xEAD0FC")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xEAD2F8", Offset = "0xEAD2F8", VA = "0xEAD2F8")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xEAD46C", Offset = "0xEAD46C", VA = "0xEAD46C")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xEAD5D8", Offset = "0xEAD5D8", VA = "0xEAD5D8")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xEAD834", Offset = "0xEAD834", VA = "0xEAD834")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xEAD980", Offset = "0xEAD980", VA = "0xEAD980")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xEADACC", Offset = "0xEADACC", VA = "0xEADACC")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xEADBE0", Offset = "0xEADBE0", VA = "0xEADBE0")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xEADCF4", Offset = "0xEADCF4", VA = "0xEADCF4")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xEADE80", Offset = "0xEADE80", VA = "0xEADE80")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xEADF50", Offset = "0xEADF50", VA = "0xEADF50")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xEAE0A4", Offset = "0xEAE0A4", VA = "0xEAE0A4")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xEAE328", Offset = "0xEAE328", VA = "0xEAE328")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xEAE53C", Offset = "0xEAE53C", VA = "0xEAE53C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xEAE6BC", Offset = "0xEAE6BC", VA = "0xEAE6BC")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xEAE82C", Offset = "0xEAE82C", VA = "0xEAE82C")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xEAE93C", Offset = "0xEAE93C", VA = "0xEAE93C")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200001F")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000C")]
		public static T instance
		{
			[Token(Token = "0x6000111")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000112")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000113")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739BF4", Offset = "0x739BF4")]
		public bool fixTransforms;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000D")]
		private bool animatePhysics
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0xEAEAD0", Offset = "0xEAEAD0", VA = "0xEAEAD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		private bool isAnimated
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0xEAEDCC", Offset = "0xEAEDCC", VA = "0xEAEDCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xEAE998", Offset = "0xEAE998", VA = "0xEAE998")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xEAEA30", Offset = "0xEAEA30", VA = "0xEAEA30", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xEAEA34", Offset = "0xEAEA34", VA = "0xEAEA34", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xEAEA38", Offset = "0xEAEA38", VA = "0xEAEA38", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xEAEA3C", Offset = "0xEAEA3C", VA = "0xEAEA3C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xEAEACC", Offset = "0xEAEACC", VA = "0xEAEACC")]
		private void Start()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xEAEA74", Offset = "0xEAEA74", VA = "0xEAEA74")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xEAED80", Offset = "0xEAED80", VA = "0xEAED80")]
		private void Update()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xEAEBC0", Offset = "0xEAEBC0", VA = "0xEAEBC0")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xEAEE88", Offset = "0xEAEE88", VA = "0xEAEE88")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xEAEEE4", Offset = "0xEAEEE4", VA = "0xEAEEE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xEAEF40", Offset = "0xEAEF40", VA = "0xEAEF40")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xEAEF88", Offset = "0xEAEF88", VA = "0xEAEF88")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xEAF008", Offset = "0xEAF008", VA = "0xEAF008")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xEAF0C0", Offset = "0xEAF0C0", VA = "0xEAF0C0")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xEAF178", Offset = "0xEAF178", VA = "0xEAF178")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xEAF230", Offset = "0xEAF230", VA = "0xEAF230")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public static class V2Tools
	{
		[Token(Token = "0x6000128")]
		[Address(RVA = "0xEAF238", Offset = "0xEAF238", VA = "0xEAF238")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xEAF268", Offset = "0xEAF268", VA = "0xEAF268")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xEAF314", Offset = "0xEAF314", VA = "0xEAF314")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xEAF3C0", Offset = "0xEAF3C0", VA = "0xEAF3C0")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xEAF590", Offset = "0xEAF590", VA = "0xEAF590")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000023")]
	public static class V3Tools
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0xEAF6F8", Offset = "0xEAF6F8", VA = "0xEAF6F8")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xEAF77C", Offset = "0xEAF77C", VA = "0xEAF77C")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xEAF81C", Offset = "0xEAF81C", VA = "0xEAF81C")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xEAF960", Offset = "0xEAF960", VA = "0xEAF960")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xEAFA80", Offset = "0xEAFA80", VA = "0xEAFA80")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xEAFB98", Offset = "0xEAFB98", VA = "0xEAFB98")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xEAFD5C", Offset = "0xEAFD5C", VA = "0xEAFD5C")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xEAFE54", Offset = "0xEAFE54", VA = "0xEAFE54")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xEAFF4C", Offset = "0xEAFF4C", VA = "0xEAFF4C")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xEB0044", Offset = "0xEB0044", VA = "0xEB0044")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xEB0144", Offset = "0xEB0144", VA = "0xEB0144")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xEB0368", Offset = "0xEB0368", VA = "0xEB0368")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xEB05A4", Offset = "0xEB05A4", VA = "0xEB05A4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xEB07F4", Offset = "0xEB07F4", VA = "0xEB07F4")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xEB09F4", Offset = "0xEB09F4", VA = "0xEB09F4")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xEB0BD0", Offset = "0xEB0BD0", VA = "0xEB0BD0")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xEB0D04", Offset = "0xEB0D04", VA = "0xEB0D04")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xEB0E5C", Offset = "0xEB0E5C", VA = "0xEB0E5C")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xEB0FE8", Offset = "0xEB0FE8", VA = "0xEB0FE8")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xEB0FA8", Offset = "0xEB0FA8", VA = "0xEB0FA8")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000024")]
	public static class Warning
	{
		[Token(Token = "0x2000084")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xEB1124", Offset = "0xEB1124", VA = "0xEB1124")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xEB1550", Offset = "0xEB1550", VA = "0xEB1550")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000025")]
	public class AnimationBlocker : MonoBehaviour
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0xC9A464", Offset = "0xC9A464", VA = "0xC9A464")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xC9A53C", Offset = "0xC9A53C", VA = "0xC9A53C")]
		public AnimationBlocker()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public abstract class BehaviourBase : MonoBehaviour
	{
		[Token(Token = "0x2000085")]
		public delegate void BehaviourDelegate();

		[Token(Token = "0x2000086")]
		public delegate void BehaviourUpdateDelegate(float deltaTime);

		[Token(Token = "0x2000087")]
		public delegate void HitDelegate(MuscleHit hit);

		[Token(Token = "0x2000088")]
		public delegate void CollisionDelegate(MuscleCollision collision);

		[Serializable]
		[Token(Token = "0x2000089")]
		public struct PuppetEvent
		{
			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CF48", Offset = "0x73CF48")]
			public string switchToBehaviour;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CF80", Offset = "0x73CF80")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CFB8", Offset = "0x73CFB8")]
			public UnityEvent unityEvent;

			[Token(Token = "0x4000450")]
			private const string empty = "";

			[Token(Token = "0x17000074")]
			public bool switchBehaviour
			{
				[Token(Token = "0x60004C9")]
				[Address(RVA = "0x6371C8", Offset = "0x6371C8", VA = "0x6371C8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x6371D0", Offset = "0x6371D0", VA = "0x6371D0")]
			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string animationState;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float crossfadeTime;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int layer;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000455")]
			private const string empty = "";

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xC9BEF8", Offset = "0xC9BEF8", VA = "0xC9BEF8")]
			public void Activate(Animator animator, Animation animation)
			{
			}

			[Token(Token = "0x60004CC")]
			[Address(RVA = "0xC9BFCC", Offset = "0xC9BFCC", VA = "0xC9BFCC")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004CD")]
			[Address(RVA = "0xC9C0D0", Offset = "0xC9C0D0", VA = "0xC9C0D0")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0xC9C1B0", Offset = "0xC9C1B0", VA = "0xC9C1B0")]
			public AnimatorEvent()
			{
			}
		}

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviourDelegate OnPreActivate;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BehaviourDelegate OnPreInitiate;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BehaviourUpdateDelegate OnPreFixedUpdate;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BehaviourUpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BehaviourUpdateDelegate OnPreLateUpdate;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourUpdateDelegate OnPreRead;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BehaviourUpdateDelegate OnPreWrite;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BehaviourDelegate OnPreDeactivate;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public BehaviourDelegate OnPreFixTransforms;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public HitDelegate OnPreMuscleHit;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public CollisionDelegate OnPreMuscleCollision;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CollisionDelegate OnPreMuscleCollisionExit;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public BehaviourDelegate OnHierarchyChanged;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public BehaviourDelegate OnPostActivate;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BehaviourDelegate OnPostInitiate;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public BehaviourUpdateDelegate OnPostFixedUpdate;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public BehaviourUpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public BehaviourUpdateDelegate OnPostLateUpdate;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public BehaviourUpdateDelegate OnPostRead;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public BehaviourUpdateDelegate OnPostWrite;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public BehaviourDelegate OnPostDeactivate;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public BehaviourDelegate OnPostDrawGizmos;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public BehaviourDelegate OnPostFixTransforms;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public HitDelegate OnPostMuscleHit;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public CollisionDelegate OnPostMuscleCollision;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public CollisionDelegate OnPostMuscleCollisionExit;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public bool deactivated;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739C4C", Offset = "0x739C4C")]
		private bool <forceActive>k__BackingField;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool initiated;

		[Token(Token = "0x400011E")]
		private const string typeSpringBase = "BehaviourBase";

		[Token(Token = "0x1700000F")]
		public bool forceActive
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0xC9A7C4", Offset = "0xC9A7C4", VA = "0xC9A7C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E0B8", Offset = "0x73E0B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0xC9A7CC", Offset = "0xC9A7CC", VA = "0xC9A7CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E0C8", Offset = "0x73E0C8")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000145")]
		public abstract void OnReactivate();

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xC9A544", Offset = "0xC9A544", VA = "0xC9A544", Slot = "5")]
		public virtual void Resurrect()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xC9A548", Offset = "0xC9A548", VA = "0xC9A548", Slot = "6")]
		public virtual void Freeze()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xC9A54C", Offset = "0xC9A54C", VA = "0xC9A54C", Slot = "7")]
		public virtual void Unfreeze()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xC9A550", Offset = "0xC9A550", VA = "0xC9A550", Slot = "8")]
		public virtual void KillStart()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xC9A554", Offset = "0xC9A554", VA = "0xC9A554", Slot = "9")]
		public virtual void KillEnd()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xC9A558", Offset = "0xC9A558", VA = "0xC9A558", Slot = "10")]
		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xC9A55C", Offset = "0xC9A55C", VA = "0xC9A55C", Slot = "11")]
		public virtual void OnMuscleDisconnected(Muscle m)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xC9A560", Offset = "0xC9A560", VA = "0xC9A560", Slot = "12")]
		public virtual void OnMuscleReconnected(Muscle m)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xC9A564", Offset = "0xC9A564", VA = "0xC9A564", Slot = "13")]
		public virtual void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xC9A780", Offset = "0xC9A780", VA = "0xC9A780", Slot = "14")]
		public virtual void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xC9A790", Offset = "0xC9A790", VA = "0xC9A790", Slot = "15")]
		protected virtual void OnActivate()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xC9A794", Offset = "0xC9A794", VA = "0xC9A794", Slot = "16")]
		protected virtual void OnDeactivate()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xC9A798", Offset = "0xC9A798", VA = "0xC9A798", Slot = "17")]
		protected virtual void OnInitiate()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xC9A79C", Offset = "0xC9A79C", VA = "0xC9A79C", Slot = "18")]
		protected virtual void OnFixedUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xC9A7A0", Offset = "0xC9A7A0", VA = "0xC9A7A0", Slot = "19")]
		protected virtual void OnUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xC9A7A4", Offset = "0xC9A7A4", VA = "0xC9A7A4", Slot = "20")]
		protected virtual void OnLateUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xC9A7A8", Offset = "0xC9A7A8", VA = "0xC9A7A8", Slot = "21")]
		protected virtual void OnReadBehaviour(float deltaTime)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xC9A7AC", Offset = "0xC9A7AC", VA = "0xC9A7AC", Slot = "22")]
		protected virtual void OnWriteBehaviour(float deltaTime)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xC9A7B0", Offset = "0xC9A7B0", VA = "0xC9A7B0", Slot = "23")]
		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xC9A7B4", Offset = "0xC9A7B4", VA = "0xC9A7B4", Slot = "24")]
		protected virtual void OnFixTransformsBehaviour()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xC9A7B8", Offset = "0xC9A7B8", VA = "0xC9A7B8", Slot = "25")]
		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xC9A7BC", Offset = "0xC9A7BC", VA = "0xC9A7BC", Slot = "26")]
		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xC9A7C0", Offset = "0xC9A7C0", VA = "0xC9A7C0", Slot = "27")]
		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xC9A7D8", Offset = "0xC9A7D8", VA = "0xC9A7D8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xC9A830", Offset = "0xC9A830", VA = "0xC9A830")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xC9A894", Offset = "0xC9A894", VA = "0xC9A894")]
		public void OnRead(float deltaTime)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xC9AB74", Offset = "0xC9AB74", VA = "0xC9AB74")]
		public void OnWrite(float deltaTime)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xC9ABF4", Offset = "0xC9ABF4", VA = "0xC9ABF4")]
		public void OnMuscleHit(MuscleHit hit)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xC9AF44", Offset = "0xC9AF44", VA = "0xC9AF44")]
		public void OnMuscleCollision(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xC9B308", Offset = "0xC9B308", VA = "0xC9B308")]
		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xC9B3B0", Offset = "0xC9B3B0", VA = "0xC9B3B0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xC9B3C0", Offset = "0xC9B3C0", VA = "0xC9B3C0")]
		public void Activate()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xC9B4E0", Offset = "0xC9B4E0", VA = "0xC9B4E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xC9B530", Offset = "0xC9B530", VA = "0xC9B530")]
		public void FixedUpdateB(float deltaTime)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xC9B5FC", Offset = "0xC9B5FC", VA = "0xC9B5FC")]
		public void UpdateB(float deltaTime)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xC9B6C8", Offset = "0xC9B6C8", VA = "0xC9B6C8")]
		public void LateUpdateB(float deltaTime)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xC9B794", Offset = "0xC9B794", VA = "0xC9B794", Slot = "28")]
		protected virtual void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xC9B7D4", Offset = "0xC9B7D4", VA = "0xC9B7D4", Slot = "29")]
		protected virtual string GetTypeSpring()
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xC9B81C", Offset = "0xC9B81C", VA = "0xC9B81C")]
		protected void RotateTargetToRootMuscle()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xC9B9B4", Offset = "0xC9B9B4", VA = "0xC9B9B4")]
		protected void TranslateTargetToRootMuscle(float maintainY)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xC9BB5C", Offset = "0xC9BB5C", VA = "0xC9BB5C")]
		protected void RemovePropMuscles()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xC9BC90", Offset = "0xC9BC90", VA = "0xC9BC90", Slot = "30")]
		protected virtual void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xC9BC08", Offset = "0xC9BC08", VA = "0xC9BC08")]
		protected bool ContainsRemovablePropMuscle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xC9BEF0", Offset = "0xC9BEF0", VA = "0xC9BEF0")]
		protected BehaviourBase()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x738DC4", Offset = "0x738DC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x738DC4", Offset = "0x738DC4")]
	public class BehaviourFall : BehaviourBase
	{
		[Token(Token = "0x200008B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739298", Offset = "0x739298")]
		private sealed class <SmoothActivate>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BehaviourFall <>4__this;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <fader>5__2;

			[Token(Token = "0x17000075")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004D2")]
				[Address(RVA = "0xC9D254", Offset = "0xC9D254", VA = "0xC9D254", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000076")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004D4")]
				[Address(RVA = "0xC9D2BC", Offset = "0xC9D2BC", VA = "0xC9D2BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0xC9C840", Offset = "0xC9C840", VA = "0xC9C840")]
			[DebuggerHidden]
			public <SmoothActivate>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0xC9D070", Offset = "0xC9D070", VA = "0xC9D070", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0xC9D074", Offset = "0xC9D074", VA = "0xC9D074", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0xC9D25C", Offset = "0xC9D25C", VA = "0xC9D25C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400011F")]
		private const string typeSpring = "BehaviourFall";

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x739C5C", Offset = "0x739C5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739C5C", Offset = "0x739C5C")]
		public string stateName;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739CBC", Offset = "0x739CBC")]
		public float transitionDuration;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739CF4", Offset = "0x739CF4")]
		public int layer;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739D2C", Offset = "0x739D2C")]
		public float fixedTime;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x739D64", Offset = "0x739D64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739D64", Offset = "0x739D64")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739DC4", Offset = "0x739DC4")]
		public string blendParameter;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739DFC", Offset = "0x739DFC")]
		public float writheHeight;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739E34", Offset = "0x739E34")]
		public float writheYVelocity;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739E6C", Offset = "0x739E6C")]
		public float blendSpeed;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739EA4", Offset = "0x739EA4")]
		public float blendMappingSpeed;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x739EDC", Offset = "0x739EDC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739EDC", Offset = "0x739EDC")]
		public bool canEnd;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739F3C", Offset = "0x739F3C")]
		public float minTime;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739F74", Offset = "0x739F74")]
		public float maxEndVelocity;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739FAC", Offset = "0x739FAC")]
		public PuppetEvent onEnd;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private float timer;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private bool endTriggered;

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xC9C69C", Offset = "0xC9C69C", VA = "0xC9C69C", Slot = "29")]
		protected override string GetTypeSpring()
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xC9C6E4", Offset = "0xC9C6E4", VA = "0xC9C6E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E0D8", Offset = "0x73E0D8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xC9C730", Offset = "0xC9C730", VA = "0xC9C730")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E110", Offset = "0x73E110")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xC9C77C", Offset = "0xC9C77C", VA = "0xC9C77C", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xC9C82C", Offset = "0xC9C82C", VA = "0xC9C82C", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xC9C834", Offset = "0xC9C834", VA = "0xC9C834", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xC9C7BC", Offset = "0xC9C7BC", VA = "0xC9C7BC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E148", Offset = "0x73E148")]
		private IEnumerator SmoothActivate()
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xC9C86C", Offset = "0xC9C86C", VA = "0xC9C86C", Slot = "18")]
		protected override void OnFixedUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xC9CDAC", Offset = "0xC9CDAC", VA = "0xC9CDAC", Slot = "20")]
		protected override void OnLateUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xC9CF4C", Offset = "0xC9CF4C", VA = "0xC9CF4C", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xC9CBF8", Offset = "0xC9CBF8", VA = "0xC9CBF8")]
		private float GetBlendTarget(float groundHeight)
		{
			return default(float);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xC9CA80", Offset = "0xC9CA80", VA = "0xC9CA80")]
		private float GetGroundHeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xC9CFB4", Offset = "0xC9CFB4", VA = "0xC9CFB4", Slot = "12")]
		public override void OnMuscleReconnected(Muscle m)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xC9CFDC", Offset = "0xC9CFDC", VA = "0xC9CFDC")]
		public BehaviourFall()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x738E24", Offset = "0x738E24")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x738E24", Offset = "0x738E24")]
	public class BehaviourPuppet : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x200008C")]
		public enum State
		{
			[Token(Token = "0x400045B")]
			Puppet,
			[Token(Token = "0x400045C")]
			Unpinned,
			[Token(Token = "0x400045D")]
			GetUp
		}

		[Serializable]
		[Token(Token = "0x200008D")]
		public enum NormalMode
		{
			[Token(Token = "0x400045F")]
			Active,
			[Token(Token = "0x4000460")]
			Unmapped,
			[Token(Token = "0x4000461")]
			Kinematic
		}

		[Serializable]
		[Token(Token = "0x200008E")]
		public class MasterProps
		{
			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NormalMode normalMode;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float mappingBlendSpeed;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool activateOnStaticCollisions;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float activateOnImpulse;

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xCA0EA8", Offset = "0xCA0EA8", VA = "0xCA0EA8")]
			public MasterProps()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008F")]
		public struct MuscleProps
		{
			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CFF0", Offset = "0x73CFF0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73CFF0", Offset = "0x73CFF0")]
			public float unpinParents;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D044", Offset = "0x73D044")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73D044", Offset = "0x73D044")]
			public float unpinChildren;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D098", Offset = "0x73D098")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73D098", Offset = "0x73D098")]
			public float unpinGroup;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D0EC", Offset = "0x73D0EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73D0EC", Offset = "0x73D0EC")]
			public float minMappingWeight;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D140", Offset = "0x73D140")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73D140", Offset = "0x73D140")]
			public float maxMappingWeight;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D194", Offset = "0x73D194")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73D194", Offset = "0x73D194")]
			public float minPinWeight;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D1E8", Offset = "0x73D1E8")]
			public bool disableColliders;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D220", Offset = "0x73D220")]
			public float regainPinSpeed;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D258", Offset = "0x73D258")]
			public float collisionResistance;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D290", Offset = "0x73D290")]
			public float knockOutDistance;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D2C8", Offset = "0x73D2C8")]
			public PhysicMaterial puppetMaterial;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D300", Offset = "0x73D300")]
			public PhysicMaterial unpinnedMaterial;
		}

		[Serializable]
		[Token(Token = "0x2000090")]
		public struct MusclePropsGroup
		{
			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D348", Offset = "0x73D348")]
			public Muscle.Group[] groups;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D380", Offset = "0x73D380")]
			public MuscleProps props;
		}

		[Serializable]
		[Token(Token = "0x2000091")]
		public struct CollisionResistanceMultiplier
		{
			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LayerMask layers;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D3B8", Offset = "0x73D3B8")]
			public float multiplier;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D3F0", Offset = "0x73D3F0")]
			public float collisionThreshold;
		}

		[Token(Token = "0x2000092")]
		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);

		[Token(Token = "0x4000130")]
		private const string typeSpring = "BehaviourPuppet";

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x739FE4", Offset = "0x739FE4")]
		public MasterProps masterProps;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A01C", Offset = "0x73A01C")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A054", Offset = "0x73A054")]
		public LayerMask collisionLayers;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A08C", Offset = "0x73A08C")]
		public float collisionThreshold;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Weight collisionResistance;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A0C4", Offset = "0x73A0C4")]
		public CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A0FC", Offset = "0x73A0FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73A0FC", Offset = "0x73A0FC")]
		public int maxCollisions;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A150", Offset = "0x73A150")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73A150", Offset = "0x73A150")]
		public float regainPinSpeed;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A1A8", Offset = "0x73A1A8")]
		public float boostFalloff;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73A1E0", Offset = "0x73A1E0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A1E0", Offset = "0x73A1E0")]
		public MuscleProps defaults;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A240", Offset = "0x73A240")]
		public MusclePropsGroup[] groupOverrides;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73A278", Offset = "0x73A278")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A278", Offset = "0x73A278")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73A278", Offset = "0x73A278")]
		public float knockOutDistance;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A2F4", Offset = "0x73A2F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73A2F4", Offset = "0x73A2F4")]
		public float unpinnedMuscleWeightMlp;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A348", Offset = "0x73A348")]
		public float maxRigidbodyVelocity;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A380", Offset = "0x73A380")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73A380", Offset = "0x73A380")]
		public float pinWeightThreshold;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A3D4", Offset = "0x73A3D4")]
		public bool unpinnedMuscleKnockout;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A40C", Offset = "0x73A40C")]
		public bool dropProps;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x182")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73A444", Offset = "0x73A444")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A444", Offset = "0x73A444")]
		public bool canGetUp;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A4A4", Offset = "0x73A4A4")]
		public float getUpDelay;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A4DC", Offset = "0x73A4DC")]
		public float blendToAnimationTime;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A514", Offset = "0x73A514")]
		public float maxGetUpVelocity;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A54C", Offset = "0x73A54C")]
		public float minGetUpDuration;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A584", Offset = "0x73A584")]
		public float getUpCollisionResistanceMlp;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A5BC", Offset = "0x73A5BC")]
		public float getUpRegainPinSpeedMlp;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A5F4", Offset = "0x73A5F4")]
		public float getUpKnockOutDistanceMlp;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A62C", Offset = "0x73A62C")]
		public Vector3 getUpOffsetProne;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A664", Offset = "0x73A664")]
		public Vector3 getUpOffsetSupine;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73A69C", Offset = "0x73A69C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A69C", Offset = "0x73A69C")]
		public PuppetEvent onGetUpProne;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A6FC", Offset = "0x73A6FC")]
		public PuppetEvent onGetUpSupine;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A734", Offset = "0x73A734")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A76C", Offset = "0x73A76C")]
		public PuppetEvent onLoseBalanceFromPuppet;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A7A4", Offset = "0x73A7A4")]
		public PuppetEvent onLoseBalanceFromGetUp;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A7DC", Offset = "0x73A7DC")]
		public PuppetEvent onRegainBalance;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public CollisionDelegate OnCollision;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public CollisionImpulseDelegate OnCollisionImpulse;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A814", Offset = "0x73A814")]
		private State <state>k__BackingField;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		[HideInInspector]
		public bool canMoveTarget;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private float unpinnedTimer;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
		private float getUpTimer;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private Vector3 hipsForward;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x274")]
		private Vector3 hipsUp;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private float getupAnimationBlendWeight;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private bool getUpTargetFixed;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private NormalMode lastNormalMode;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private int collisions;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private bool eventsEnabled;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		private float lastKnockOutDistance;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private float knockOutDistanceSqr;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
		private bool getupDisabled;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29D")]
		private bool hasCollidedSinceGetUp;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29E")]
		private bool hasBoosted;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private Vector3 getUpPosition;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		private bool dropPropFlag;

		[Token(Token = "0x17000010")]
		public State state
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0xC9D3A4", Offset = "0xC9D3A4", VA = "0xC9D3A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E21C", Offset = "0x73E21C")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0xC9D3AC", Offset = "0xC9D3AC", VA = "0xC9D3AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E22C", Offset = "0x73E22C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xC9D2C4", Offset = "0xC9D2C4", VA = "0xC9D2C4", Slot = "29")]
		protected override string GetTypeSpring()
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xC9D30C", Offset = "0xC9D30C", VA = "0xC9D30C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E1AC", Offset = "0x73E1AC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xC9D358", Offset = "0xC9D358", VA = "0xC9D358")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E1E4", Offset = "0x73E1E4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xC9D3B4", Offset = "0xC9D3B4", VA = "0xC9D3B4", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xC9D668", Offset = "0xC9D668", VA = "0xC9D668")]
		public void Reset(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xC9D6D4", Offset = "0xC9D6D4", VA = "0xC9D6D4", Slot = "10")]
		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xC9D840", Offset = "0xC9D840", VA = "0xC9D840", Slot = "17")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xC9DDA8", Offset = "0xC9DDA8", VA = "0xC9DDA8", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xC9DE5C", Offset = "0xC9DE5C", VA = "0xC9DE5C", Slot = "8")]
		public override void KillStart()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xC9DF00", Offset = "0xC9DF00", VA = "0xC9DF00", Slot = "9")]
		public override void KillEnd()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xC9DF08", Offset = "0xC9DF08", VA = "0xC9DF08", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xC9DF90", Offset = "0xC9DF90", VA = "0xC9DF90", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xC9DF9C", Offset = "0xC9DF9C", VA = "0xC9DF9C", Slot = "18")]
		protected override void OnFixedUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xC9E82C", Offset = "0xC9E82C", VA = "0xC9E82C", Slot = "20")]
		protected override void OnLateUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xC9EB54", Offset = "0xC9EB54", VA = "0xC9EB54")]
		private bool SetKinematic()
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xC9EC3C", Offset = "0xC9EC3C", VA = "0xC9EC3C", Slot = "21")]
		protected override void OnReadBehaviour(float deltaTime)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xC9E9C4", Offset = "0xC9E9C4", VA = "0xC9E9C4")]
		private void BlendMuscleMapping(int muscleIndex, ref bool to, float deltaTime)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xC9F050", Offset = "0xC9F050", VA = "0xC9F050", Slot = "13")]
		public override void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xC9F090", Offset = "0xC9F090", VA = "0xC9F090", Slot = "14")]
		public override void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xC9F018", Offset = "0xC9F018", VA = "0xC9F018")]
		protected void MoveTarget(Vector3 position)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xC9F0C8", Offset = "0xC9F0C8", VA = "0xC9F0C8")]
		protected void RotateTarget(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xC9F100", Offset = "0xC9F100", VA = "0xC9F100", Slot = "30")]
		protected override void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xC9F114", Offset = "0xC9F114", VA = "0xC9F114")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xC9F2FC", Offset = "0xC9F2FC", VA = "0xC9F2FC")]
		public void Boost(float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xC9F38C", Offset = "0xC9F38C", VA = "0xC9F38C")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xC9F574", Offset = "0xC9F574", VA = "0xC9F574")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xC9F7B8", Offset = "0xC9F7B8", VA = "0xC9F7B8")]
		public void BoostImmunity(float immunity)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xC9F3D0", Offset = "0xC9F3D0", VA = "0xC9F3D0")]
		public void BoostImmunity(int muscleIndex, float immunity)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xC9F830", Offset = "0xC9F830", VA = "0xC9F830")]
		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xC9F8D4", Offset = "0xC9F8D4", VA = "0xC9F8D4")]
		public void BoostImpulseMlp(float impulseMlp)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xC9F4A4", Offset = "0xC9F4A4", VA = "0xC9F4A4")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xC9F944", Offset = "0xC9F944", VA = "0xC9F944")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xC9F9E8", Offset = "0xC9F9E8", VA = "0xC9F9E8")]
		public void Unpin()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xC9FA64", Offset = "0xC9FA64", VA = "0xC9FA64", Slot = "25")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xC9FD0C", Offset = "0xC9FD0C", VA = "0xC9FD0C", Slot = "26")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xCA012C", Offset = "0xCA012C", VA = "0xCA012C")]
		private float GetImpulse(MuscleCollision m, ref float layerThreshold)
		{
			return default(float);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xC9FB3C", Offset = "0xC9FB3C", VA = "0xC9FB3C")]
		public void UnPin(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xCA07D8", Offset = "0xCA07D8", VA = "0xCA07D8")]
		private void UnPinMuscle(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xCA05F0", Offset = "0xCA05F0", VA = "0xCA05F0")]
		private bool Activate(Collision collision, float impulse)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xCA0A24", Offset = "0xCA0A24", VA = "0xCA0A24")]
		public bool IsProne()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xC9F694", Offset = "0xC9F694", VA = "0xC9F694")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			return default(float);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xCA0688", Offset = "0xCA0688", VA = "0xCA0688")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			return default(float);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xCA0B9C", Offset = "0xCA0B9C", VA = "0xCA0B9C")]
		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xC9E744", Offset = "0xC9E744", VA = "0xC9E744")]
		private MuscleProps GetProps(Muscle.Group group)
		{
			return default(MuscleProps);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xC97B88", Offset = "0xC97B88", VA = "0xC97B88")]
		public void SetState(State newState)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xCA0C7C", Offset = "0xCA0C7C", VA = "0xCA0C7C")]
		public void SetColliders(bool unpinned)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xC9D494", Offset = "0xC9D494", VA = "0xC9D494")]
		public void SetColliders(Muscle m, bool unpinned)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xCA0D0C", Offset = "0xCA0D0C", VA = "0xCA0D0C", Slot = "11")]
		public override void OnMuscleDisconnected(Muscle m)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xCA0D14", Offset = "0xCA0D14", VA = "0xCA0D14", Slot = "12")]
		public override void OnMuscleReconnected(Muscle m)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xCA0DB4", Offset = "0xCA0DB4", VA = "0xCA0DB4")]
		public BehaviourPuppet()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x738E84", Offset = "0x738E84")]
	public class BehaviourTemplate : BehaviourBase
	{
		[Token(Token = "0x4000167")]
		private const string typeSpring = "BehaviourTemplate";

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public LayerMask groundLayers;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float loseBalanceAngle;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xCA0F88", Offset = "0xCA0F88", VA = "0xCA0F88", Slot = "29")]
		protected override string GetTypeSpring()
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xCA0FD0", Offset = "0xCA0FD0", VA = "0xCA0FD0", Slot = "17")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xCA0FF4", Offset = "0xCA0FF4", VA = "0xCA0FF4", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xCA0FF8", Offset = "0xCA0FF8", VA = "0xCA0FF8", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xCA0FFC", Offset = "0xCA0FFC", VA = "0xCA0FFC", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xCA1000", Offset = "0xCA1000", VA = "0xCA1000", Slot = "18")]
		protected override void OnFixedUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xCA1038", Offset = "0xCA1038", VA = "0xCA1038", Slot = "20")]
		protected override void OnLateUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xCA103C", Offset = "0xCA103C", VA = "0xCA103C", Slot = "25")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xCA1044", Offset = "0xCA1044", VA = "0xCA1044", Slot = "26")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xCA104C", Offset = "0xCA104C", VA = "0xCA104C")]
		public BehaviourTemplate()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002A")]
	public class SubBehaviourBalancer : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000093")]
		public class Settings
		{
			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D428", Offset = "0x73D428")]
			public float damperForSpring;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D460", Offset = "0x73D460")]
			public float maxForceMlp;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D498", Offset = "0x73D498")]
			public float IMlp;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D4D0", Offset = "0x73D4D0")]
			public float velocityF;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D508", Offset = "0x73D508")]
			public Vector3 copOffset;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D540", Offset = "0x73D540")]
			public float torqueMlp;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D578", Offset = "0x73D578")]
			public float maxTorqueMag;

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xEA7F24", Offset = "0xEA7F24", VA = "0xEA7F24")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A834", Offset = "0x73A834")]
		private ConfigurableJoint <joint>k__BackingField;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A844", Offset = "0x73A844")]
		private Vector3 <dir>k__BackingField;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A854", Offset = "0x73A854")]
		private Vector3 <dirVel>k__BackingField;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A864", Offset = "0x73A864")]
		private Vector3 <cop>k__BackingField;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A874", Offset = "0x73A874")]
		private Vector3 <com>k__BackingField;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A884", Offset = "0x73A884")]
		private Vector3 <comV>k__BackingField;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Settings settings;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] copPoints;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PressureSensor pressureSensor;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody Ibody;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 I;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion toJointSpace;

		[Token(Token = "0x17000011")]
		public ConfigurableJoint joint
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xEA7724", Offset = "0xEA7724", VA = "0xEA7724")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E23C", Offset = "0x73E23C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xEA772C", Offset = "0xEA772C", VA = "0xEA772C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E24C", Offset = "0x73E24C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Vector3 dir
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0xEA7734", Offset = "0xEA7734", VA = "0xEA7734")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E25C", Offset = "0x73E25C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0xEA7740", Offset = "0xEA7740", VA = "0xEA7740")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E26C", Offset = "0x73E26C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Vector3 dirVel
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0xEA774C", Offset = "0xEA774C", VA = "0xEA774C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E27C", Offset = "0x73E27C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0xEA7758", Offset = "0xEA7758", VA = "0xEA7758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E28C", Offset = "0x73E28C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public Vector3 cop
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xEA7764", Offset = "0xEA7764", VA = "0xEA7764")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E29C", Offset = "0x73E29C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xEA7770", Offset = "0xEA7770", VA = "0xEA7770")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E2AC", Offset = "0x73E2AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Vector3 com
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xEA777C", Offset = "0xEA777C", VA = "0xEA777C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E2BC", Offset = "0x73E2BC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xEA7788", Offset = "0xEA7788", VA = "0xEA7788")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E2CC", Offset = "0x73E2CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 comV
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xEA7794", Offset = "0xEA7794", VA = "0xEA7794")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E2DC", Offset = "0x73E2DC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0xEA77A0", Offset = "0xEA77A0", VA = "0xEA77A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E2EC", Offset = "0x73E2EC")]
			private set
			{
			}
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xEA77AC", Offset = "0xEA77AC", VA = "0xEA77AC")]
		public void Initiate(BehaviourBase behaviour, Settings settings, Rigidbody Ibody, Rigidbody[] rigidbodies, ConfigurableJoint joint, Transform[] copPoints, PressureSensor pressureSensor)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xEA78B0", Offset = "0xEA78B0", VA = "0xEA78B0")]
		private void Solve(float deltaTime)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xEA7E74", Offset = "0xEA7E74", VA = "0xEA7E74")]
		public SubBehaviourBalancer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public abstract class SubBehaviourBase
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected BehaviourBase behaviour;

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xEA7F40", Offset = "0xEA7F40", VA = "0xEA7F40")]
		protected static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xEA7F70", Offset = "0xEA7F70", VA = "0xEA7F70")]
		protected static Vector3 XYZ(Vector2 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xEA7FAC", Offset = "0xEA7FAC", VA = "0xEA7FAC")]
		protected static Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xEA7FE4", Offset = "0xEA7FE4", VA = "0xEA7FE4")]
		protected static Vector3 SetY(Vector3 v, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xEA7F1C", Offset = "0xEA7F1C", VA = "0xEA7F1C")]
		protected SubBehaviourBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000094")]
		public enum Mode
		{
			[Token(Token = "0x4000480")]
			FeetCentroid,
			[Token(Token = "0x4000481")]
			CenterOfPressure
		}

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode mode;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float velocityDamper;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityLerpSpeed;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float velocityMax;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centerOfPressureSpeed;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A894", Offset = "0x73A894")]
		private Vector3 <position>k__BackingField;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A8A4", Offset = "0x73A8A4")]
		private Vector3 <direction>k__BackingField;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A8B4", Offset = "0x73A8B4")]
		private float <angle>k__BackingField;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A8C4", Offset = "0x73A8C4")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A8D4", Offset = "0x73A8D4")]
		private Vector3 <centerOfPressure>k__BackingField;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A8E4", Offset = "0x73A8E4")]
		private Quaternion <rotation>k__BackingField;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A8F4", Offset = "0x73A8F4")]
		private Quaternion <inverseRotation>k__BackingField;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A904", Offset = "0x73A904")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A914", Offset = "0x73A914")]
		private float <lastGroundedTime>k__BackingField;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public bool[] groundContacts;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3[] groundContactPoints;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private LayerMask groundLayers;

		[Token(Token = "0x17000017")]
		public Vector3 position
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xEA801C", Offset = "0xEA801C", VA = "0xEA801C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E2FC", Offset = "0x73E2FC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0xEA8028", Offset = "0xEA8028", VA = "0xEA8028")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E30C", Offset = "0x73E30C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Vector3 direction
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0xEA8034", Offset = "0xEA8034", VA = "0xEA8034")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E31C", Offset = "0x73E31C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0xEA8040", Offset = "0xEA8040", VA = "0xEA8040")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E32C", Offset = "0x73E32C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public float angle
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0xEA804C", Offset = "0xEA804C", VA = "0xEA804C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E33C", Offset = "0x73E33C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xEA8054", Offset = "0xEA8054", VA = "0xEA8054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E34C", Offset = "0x73E34C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Vector3 velocity
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xEA805C", Offset = "0xEA805C", VA = "0xEA805C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E35C", Offset = "0x73E35C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xEA8068", Offset = "0xEA8068", VA = "0xEA8068")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E36C", Offset = "0x73E36C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Vector3 centerOfPressure
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0xEA8074", Offset = "0xEA8074", VA = "0xEA8074")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E37C", Offset = "0x73E37C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xEA8080", Offset = "0xEA8080", VA = "0xEA8080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E38C", Offset = "0x73E38C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Quaternion rotation
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xEA808C", Offset = "0xEA808C", VA = "0xEA808C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E39C", Offset = "0x73E39C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xEA8098", Offset = "0xEA8098", VA = "0xEA8098")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E3AC", Offset = "0x73E3AC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Quaternion inverseRotation
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xEA80A4", Offset = "0xEA80A4", VA = "0xEA80A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E3BC", Offset = "0x73E3BC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xEA80B0", Offset = "0xEA80B0", VA = "0xEA80B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E3CC", Offset = "0x73E3CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public bool isGrounded
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xEA80BC", Offset = "0xEA80BC", VA = "0xEA80BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E3DC", Offset = "0x73E3DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xEA80C4", Offset = "0xEA80C4", VA = "0xEA80C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E3EC", Offset = "0x73E3EC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public float lastGroundedTime
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xEA80D0", Offset = "0xEA80D0", VA = "0xEA80D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E3FC", Offset = "0x73E3FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xEA80D8", Offset = "0xEA80D8", VA = "0xEA80D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E40C", Offset = "0x73E40C")]
			private set
			{
			}
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xEA80E0", Offset = "0xEA80E0", VA = "0xEA80E0")]
		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xEA83BC", Offset = "0xEA83BC", VA = "0xEA83BC")]
		private void OnHierarchyChanged()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xEA845C", Offset = "0xEA845C", VA = "0xEA845C")]
		private void OnPreMuscleCollision(MuscleCollision c)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xEA8774", Offset = "0xEA8774", VA = "0xEA8774")]
		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xEA889C", Offset = "0xEA889C", VA = "0xEA889C")]
		private void OnPreActivate()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xEA8D1C", Offset = "0xEA8D1C", VA = "0xEA8D1C")]
		private void OnPreLateUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xEA94BC", Offset = "0xEA94BC", VA = "0xEA94BC")]
		private void OnPreDeactivate()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xEA85D4", Offset = "0xEA85D4", VA = "0xEA85D4")]
		private Vector3 GetCollisionCOP(Collision collision)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xEA9094", Offset = "0xEA9094", VA = "0xEA9094")]
		private bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xEA89B8", Offset = "0xEA89B8", VA = "0xEA89B8")]
		private Vector3 GetCenterOfMass()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xEA927C", Offset = "0xEA927C", VA = "0xEA927C")]
		private Vector3 GetCenterOfMassVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xEA952C", Offset = "0xEA952C", VA = "0xEA952C")]
		private Vector3 GetMomentum()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xEA90F8", Offset = "0xEA90F8", VA = "0xEA90F8")]
		private Vector3 GetCenterOfPressure()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xEA8B88", Offset = "0xEA8B88", VA = "0xEA8B88")]
		private Vector3 GetFeetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xEA96E4", Offset = "0xEA96E4", VA = "0xEA96E4")]
		public SubBehaviourCOM()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class Booster
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A944", Offset = "0x73A944")]
		public bool fullBody;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A97C", Offset = "0x73A97C")]
		public ConfigurableJoint[] muscles;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A9B4", Offset = "0x73A9B4")]
		public Muscle.Group[] groups;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A9EC", Offset = "0x73A9EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73A9EC", Offset = "0x73A9EC")]
		public float immunity;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AA40", Offset = "0x73AA40")]
		public float impulseMlp;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AA78", Offset = "0x73AA78")]
		public float boostParents;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AAB0", Offset = "0x73AAB0")]
		public float boostChildren;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AAE8", Offset = "0x73AAE8")]
		public float delay;

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xCA5914", Offset = "0xCA5914", VA = "0xCA5914")]
		public void Boost(BehaviourPuppet puppet)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xCA5B20", Offset = "0xCA5B20", VA = "0xCA5B20")]
		public Booster()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public int muscleIndex;

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xCA5E88", Offset = "0xCA5E88", VA = "0xCA5E88")]
		private void OnJointBreak()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xCA5F0C", Offset = "0xCA5F0C", VA = "0xCA5F0C")]
		public JointBreakBroadcaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class Muscle
	{
		[Serializable]
		[Token(Token = "0x2000095")]
		public enum Group
		{
			[Token(Token = "0x4000483")]
			Hips,
			[Token(Token = "0x4000484")]
			Spine,
			[Token(Token = "0x4000485")]
			Head,
			[Token(Token = "0x4000486")]
			Arm,
			[Token(Token = "0x4000487")]
			Hand,
			[Token(Token = "0x4000488")]
			Leg,
			[Token(Token = "0x4000489")]
			Foot,
			[Token(Token = "0x400048A")]
			Tail,
			[Token(Token = "0x400048B")]
			Prop
		}

		[Serializable]
		[Token(Token = "0x2000096")]
		public class InternalCollisionIgnoreSettings
		{
			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D5B0", Offset = "0x73D5B0")]
			public bool ignoreAll;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D5E8", Offset = "0x73D5E8")]
			public ConfigurableJoint[] muscles;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D620", Offset = "0x73D620")]
			public Group[] groups;

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xD6987C", Offset = "0xD6987C", VA = "0xD6987C")]
			public InternalCollisionIgnoreSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000097")]
		public class Props
		{
			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D658", Offset = "0x73D658")]
			public Group group;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D690", Offset = "0x73D690")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73D690", Offset = "0x73D690")]
			public float mappingWeight;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D6E4", Offset = "0x73D6E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73D6E4", Offset = "0x73D6E4")]
			public float pinWeight;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D738", Offset = "0x73D738")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73D738", Offset = "0x73D738")]
			public float muscleWeight;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D78C", Offset = "0x73D78C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73D78C", Offset = "0x73D78C")]
			public float muscleDamper;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D7E0", Offset = "0x73D7E0")]
			public InternalCollisionIgnoreSettings internalCollisionIgnores;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D818", Offset = "0x73D818")]
			public Transform[] animatedTargetChildren;

			[Token(Token = "0x17000077")]
			public bool mapPosition
			{
				[Token(Token = "0x60004DC")]
				[Address(RVA = "0xD698F4", Offset = "0xD698F4", VA = "0xD698F4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60004DD")]
				[Address(RVA = "0xD698FC", Offset = "0xD698FC", VA = "0xD698FC")]
				set
				{
				}
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xD69968", Offset = "0xD69968", VA = "0xD69968")]
			public Props()
			{
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xD69A04", Offset = "0xD69A04", VA = "0xD69A04")]
			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, Group group = Group.Hips)
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0xD69AC4", Offset = "0xD69AC4", VA = "0xD69AC4")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x2000098")]
		public struct State
		{
			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float mappingWeightMlp;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float pinWeightMlp;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float muscleWeightMlp;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxForceMlp;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float muscleDamperMlp;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float muscleDamperAdd;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float immunity;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float impulseMlp;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 velocity;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 angularVelocity;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isDisconnected;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool resetFlag;

			[Token(Token = "0x17000078")]
			public static State Default
			{
				[Token(Token = "0x60004E1")]
				[Address(RVA = "0xD69BA0", Offset = "0xD69BA0", VA = "0xD69BA0")]
				get
				{
					return default(State);
				}
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x6382FC", Offset = "0x6382FC", VA = "0x6382FC")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x2000099")]
		public class TargetChild
		{
			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0xD69CB0", Offset = "0xD69CB0", VA = "0xD69CB0")]
			public TargetChild(Transform t)
			{
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xD69D6C", Offset = "0xD69D6C", VA = "0xD69D6C")]
			public void Map()
			{
			}
		}

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public string name;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ConfigurableJoint joint;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Props props;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public State state;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public int[] parentIndexes;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public int[] childIndexes;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public bool[] childFlags;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public int[] kinshipDegrees;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3 positionOffset;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ABC0", Offset = "0x73ABC0")]
		private Transform <transform>k__BackingField;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ABD0", Offset = "0x73ABD0")]
		private Rigidbody <rigidbody>k__BackingField;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ABE0", Offset = "0x73ABE0")]
		private Transform <connectedBodyTarget>k__BackingField;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ABF0", Offset = "0x73ABF0")]
		private Vector3 <targetAnimatedPosition>k__BackingField;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AC00", Offset = "0x73AC00")]
		private Quaternion <targetAnimatedWorldRotation>k__BackingField;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AC10", Offset = "0x73AC10")]
		private Vector3 <targetVelocity>k__BackingField;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AC20", Offset = "0x73AC20")]
		private Rigidbody <additionalRigidbody>k__BackingField;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[HideInInspector]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[HideInInspector]
		public Transform additionalPinTarget;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[HideInInspector]
		public float additionalPinWeight;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[HideInInspector]
		public Vector3 mappedVelocity;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[HideInInspector]
		public Vector3 mappedAngularVelocity;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[HideInInspector]
		public bool isPropMuscle;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[HideInInspector]
		public int index;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ACA0", Offset = "0x73ACA0")]
		private Quaternion <targetRotationRelative>k__BackingField;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ACB0", Offset = "0x73ACB0")]
		private Rigidbody <rebuildConnectedBody>k__BackingField;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ACC0", Offset = "0x73ACC0")]
		private Transform <rebuildTargetParent>k__BackingField;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ACD0", Offset = "0x73ACD0")]
		private Vector3 <defaultTargetPosRelToMuscle>k__BackingField;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ACE0", Offset = "0x73ACE0")]
		private Quaternion <defaultTargetRotRelToMuscle>k__BackingField;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ACF0", Offset = "0x73ACF0")]
		private Quaternion <defaultMuscleRotRelToTarget>k__BackingField;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Transform rebuildParent;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Vector3 rebuildPosition;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private Quaternion rebuildRotation;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 rebuildTargetPosition;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion rebuildTargetRotation;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private ConfigurableJointMotion rebuildAngularXMotion;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private ConfigurableJointMotion rebuildAngularYMotion;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private ConfigurableJointMotion rebuildAngularZMotion;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		[HideInInspector]
		public Vector3 targetMappedPosition;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[HideInInspector]
		public Quaternion targetMappedRotation;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[HideInInspector]
		public Vector3 targetSampledPosition;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		[HideInInspector]
		public Quaternion targetSampledRotation;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private JointDrive slerpDrive;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private float lastJointDriveRotationWeight;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private float lastRotationDamper;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private Vector3 defaultTargetLocalPosition;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Vector3 lastMappedPosition;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private Quaternion localRotationConvert;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private Quaternion toParentSpace;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		private Quaternion toJointSpaceInverse;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private Quaternion toJointSpaceDefault;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private Quaternion targetAnimatedRotation;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		private Quaternion rotationRelativeToTarget;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2CC")]
		private Quaternion lastMappedRotation;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private Transform targetParent;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private Transform connectedBodyTransform;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private ConfigurableJointMotion angularXMotionDefault;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
		private ConfigurableJointMotion angularYMotionDefault;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private ConfigurableJointMotion angularZMotionDefault;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2FC")]
		private bool directTargetParent;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2FD")]
		private bool initiated;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private Collider[] _colliders;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private float lastReadTime;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30C")]
		private float lastWriteTime;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private bool[] disabledColliders;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private TargetChild[] targetChildren;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private Vector3 additionalTargetVelocity;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		private Vector3 targetAnimatedCenterOfMass;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private Vector3 additionalPinTargetAnimatedCenterOfMass;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
		private Quaternion defaultTargetRotRelToMuscleInverse;

		[Token(Token = "0x17000020")]
		public Transform transform
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0xCA6CA4", Offset = "0xCA6CA4", VA = "0xCA6CA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E41C", Offset = "0x73E41C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0xCA6CAC", Offset = "0xCA6CAC", VA = "0xCA6CAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E42C", Offset = "0x73E42C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0xCA6CB4", Offset = "0xCA6CB4", VA = "0xCA6CB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E43C", Offset = "0x73E43C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0xCA6CBC", Offset = "0xCA6CBC", VA = "0xCA6CBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E44C", Offset = "0x73E44C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public Transform connectedBodyTarget
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0xCA6CC4", Offset = "0xCA6CC4", VA = "0xCA6CC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E45C", Offset = "0x73E45C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0xCA6CCC", Offset = "0xCA6CCC", VA = "0xCA6CCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E46C", Offset = "0x73E46C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Vector3 targetAnimatedPosition
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xCA6CD4", Offset = "0xCA6CD4", VA = "0xCA6CD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E47C", Offset = "0x73E47C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0xCA6CE0", Offset = "0xCA6CE0", VA = "0xCA6CE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E48C", Offset = "0x73E48C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Quaternion targetAnimatedWorldRotation
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0xCA6CEC", Offset = "0xCA6CEC", VA = "0xCA6CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E49C", Offset = "0x73E49C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0xCA6CF8", Offset = "0xCA6CF8", VA = "0xCA6CF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E4AC", Offset = "0x73E4AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Collider[] colliders
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0xCA6D04", Offset = "0xCA6D04", VA = "0xCA6D04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000204")]
			[Address(RVA = "0xCA6D0C", Offset = "0xCA6D0C", VA = "0xCA6D0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Vector3 targetVelocity
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0xCA6D14", Offset = "0xCA6D14", VA = "0xCA6D14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E4BC", Offset = "0x73E4BC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xCA6D20", Offset = "0xCA6D20", VA = "0xCA6D20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E4CC", Offset = "0x73E4CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public Rigidbody additionalRigidbody
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0xCA6D2C", Offset = "0xCA6D2C", VA = "0xCA6D2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E4DC", Offset = "0x73E4DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000208")]
			[Address(RVA = "0xCA6D34", Offset = "0xCA6D34", VA = "0xCA6D34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E4EC", Offset = "0x73E4EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public Quaternion targetRotationRelative
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0xCA6D3C", Offset = "0xCA6D3C", VA = "0xCA6D3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E4FC", Offset = "0x73E4FC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600020A")]
			[Address(RVA = "0xCA6D50", Offset = "0xCA6D50", VA = "0xCA6D50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E50C", Offset = "0x73E50C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public Rigidbody rebuildConnectedBody
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0xCA6F48", Offset = "0xCA6F48", VA = "0xCA6F48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E51C", Offset = "0x73E51C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0xCA6F50", Offset = "0xCA6F50", VA = "0xCA6F50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E52C", Offset = "0x73E52C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Transform rebuildTargetParent
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0xCA6F58", Offset = "0xCA6F58", VA = "0xCA6F58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E53C", Offset = "0x73E53C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020F")]
			[Address(RVA = "0xCA6F60", Offset = "0xCA6F60", VA = "0xCA6F60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E54C", Offset = "0x73E54C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Vector3 defaultTargetPosRelToMuscle
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0xCA6F68", Offset = "0xCA6F68", VA = "0xCA6F68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E55C", Offset = "0x73E55C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000211")]
			[Address(RVA = "0xCA6F78", Offset = "0xCA6F78", VA = "0xCA6F78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E56C", Offset = "0x73E56C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public Quaternion defaultTargetRotRelToMuscle
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0xCA6F88", Offset = "0xCA6F88", VA = "0xCA6F88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E57C", Offset = "0x73E57C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0xCA6F9C", Offset = "0xCA6F9C", VA = "0xCA6F9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E58C", Offset = "0x73E58C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public Quaternion defaultMuscleRotRelToTarget
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0xCA6FB0", Offset = "0xCA6FB0", VA = "0xCA6FB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E59C", Offset = "0x73E59C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0xCA6FC4", Offset = "0xCA6FC4", VA = "0xCA6FC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E5AC", Offset = "0x73E5AC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		private Quaternion localRotation
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0xCA84D4", Offset = "0xCA84D4", VA = "0xCA84D4")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700002F")]
		private Quaternion parentRotation
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0xCA8674", Offset = "0xCA8674", VA = "0xCA8674")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000030")]
		private Quaternion targetParentRotation
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0xCA85BC", Offset = "0xCA85BC", VA = "0xCA85BC")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000031")]
		private Quaternion targetLocalRotation
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0xCA87C4", Offset = "0xCA87C4", VA = "0xCA87C4")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xCA6D64", Offset = "0xCA6D64", VA = "0xCA6D64")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xCA6FD8", Offset = "0xCA6FD8", VA = "0xCA6FD8")]
		public void Rebuild()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xCA7124", Offset = "0xCA7124", VA = "0xCA7124", Slot = "4")]
		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xCA8270", Offset = "0xCA8270", VA = "0xCA8270")]
		public void InitiateAdditionalPin()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xCA83C0", Offset = "0xCA83C0", VA = "0xCA83C0")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xCA8F94", Offset = "0xCA8F94", VA = "0xCA8F94")]
		public void DisableColliders()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xCA909C", Offset = "0xCA909C", VA = "0xCA909C")]
		public void EnableColliders()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xCA8C40", Offset = "0xCA8C40", VA = "0xCA8C40")]
		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xCA8E8C", Offset = "0xCA8E8C", VA = "0xCA8E8C")]
		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xCA9148", Offset = "0xCA9148", VA = "0xCA9148")]
		public void IgnoreInternalCollisions(Muscle m)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xCA9320", Offset = "0xCA9320", VA = "0xCA9320")]
		public void ResetInternalCollisions(Muscle m, bool useInternalCollisionIgnores)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xCA9520", Offset = "0xCA9520", VA = "0xCA9520")]
		private bool ForceIgnore(Muscle otherMuscle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xCA978C", Offset = "0xCA978C", VA = "0xCA978C")]
		public void IgnoreAngularLimits(bool ignore)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xCA982C", Offset = "0xCA982C", VA = "0xCA982C")]
		public void ResetTargetLocalPosition()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xCA9858", Offset = "0xCA9858", VA = "0xCA9858")]
		public void FixTargetTransforms()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xCA98C4", Offset = "0xCA98C4", VA = "0xCA98C4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xCA9AF0", Offset = "0xCA9AF0", VA = "0xCA9AF0")]
		public void MoveToTarget()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xC9FC38", Offset = "0xC9FC38", VA = "0xC9FC38")]
		public void SetKinematic(bool to)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xCA88E4", Offset = "0xCA88E4", VA = "0xCA88E4")]
		public void Read()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xCA9D14", Offset = "0xCA9D14", VA = "0xCA9D14")]
		public void ClearVelocities()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xCA9EC0", Offset = "0xCA9EC0", VA = "0xCA9EC0")]
		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xCAA260", Offset = "0xCAA260", VA = "0xCAA260", Slot = "5")]
		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged, bool angularPinning, float deltaTime)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xCAA944", Offset = "0xCAA944", VA = "0xCAA944")]
		public void StoreTargetMappedPosition()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xCAA980", Offset = "0xCAA980", VA = "0xCAA980")]
		public void StoreTargetMappedRotation()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xCAA9C0", Offset = "0xCAA9C0", VA = "0xCAA9C0")]
		public void Map(float mappingWeightMaster)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xCAADA4", Offset = "0xCAADA4", VA = "0xCAADA4")]
		public void CalculateMappedVelocity()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xCAAF48", Offset = "0xCAAF48", VA = "0xCAAF48")]
		public void MapDisconnected()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xCAA388", Offset = "0xCAA388", VA = "0xCAA388")]
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff, bool angularPinning, float deltaTime)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xCAB0C8", Offset = "0xCAB0C8", VA = "0xCAB0C8")]
		private void Pin(Rigidbody r, Vector3 posOffset, Vector3 targetVel, float w, float pinDistanceFalloff, float deltaTime)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xCAA760", Offset = "0xCAA760", VA = "0xCAA760")]
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xCAB468", Offset = "0xCAB468", VA = "0xCAB468")]
		public void SetMuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xCAB374", Offset = "0xCAB374", VA = "0xCAB374")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xCAA140", Offset = "0xCAA140", VA = "0xCAA140")]
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xCAB5F8", Offset = "0xCAB5F8", VA = "0xCAB5F8")]
		public Muscle()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public struct MuscleCollision
	{
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Collision collision;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isStay;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x638340", Offset = "0x638340", VA = "0x638340")]
		public MuscleCollision(int muscleIndex, Collision collision, bool isStay = false)
		{
		}
	}
	[Token(Token = "0x2000031")]
	public struct MuscleHit
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float unPin;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 force;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 position;

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x638354", Offset = "0x638354", VA = "0x638354")]
		public MuscleHit(int muscleIndex, float unPin, Vector3 force, Vector3 position)
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x738EBC", Offset = "0x738EBC")]
	public class MuscleCollisionBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public int muscleIndex;

		[Token(Token = "0x40001EB")]
		private const string onMuscleHit = "OnMuscleHit";

		[Token(Token = "0x40001EC")]
		private const string onMuscleCollision = "OnMuscleCollision";

		[Token(Token = "0x40001ED")]
		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MuscleCollisionBroadcaster otherBroadcaster;

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xD69DCC", Offset = "0xD69DCC", VA = "0xD69DCC")]
		public void Hit(float unPin, Vector3 force, Vector3 position)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xD69ED0", Offset = "0xD69ED0", VA = "0xD69ED0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xD6A0B4", Offset = "0xD6A0B4", VA = "0xD6A0B4")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xD6A32C", Offset = "0xD6A32C", VA = "0xD6A32C")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xD6A5A0", Offset = "0xD6A5A0", VA = "0xD6A5A0")]
		public MuscleCollisionBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public static class PhysXTools
	{
		[Token(Token = "0x6000242")]
		[Address(RVA = "0xD6C810", Offset = "0xD6C810", VA = "0xD6C810")]
		public static void Predict(Rigidbody r, int steps, out Vector3 position, out Quaternion rotation)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xD6C8AC", Offset = "0xD6C8AC", VA = "0xD6C8AC")]
		public static void Predict(Rigidbody r, int steps, out Vector3 position, out Quaternion rotation, Vector3 gravity, float drag, float angularDrag)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xD6C9AC", Offset = "0xD6C9AC", VA = "0xD6C9AC")]
		public static void Predict(ref Vector3 position, ref Quaternion rotation, ref Vector3 velocity, ref Vector3 angularVelocity, Vector3 gravity, float drag, float angularDrag)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xD6CC9C", Offset = "0xD6CC9C", VA = "0xD6CC9C")]
		public static Vector3 GetCenterOfMass(PuppetMaster puppet)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xD6CED8", Offset = "0xD6CED8", VA = "0xD6CED8")]
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xD6D0D0", Offset = "0xD6D0D0", VA = "0xD6D0D0")]
		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xD6D2C8", Offset = "0xD6D2C8", VA = "0xD6D2C8")]
		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xD6D408", Offset = "0xD6D408", VA = "0xD6D408")]
		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xD6D544", Offset = "0xD6D544", VA = "0xD6D544")]
		public static Vector3 GetAngularVelocity(Quaternion lastRotation, Quaternion rotation, float deltaTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xD6D738", Offset = "0xD6D738", VA = "0xD6D738")]
		public static Vector3 GetFromToAcceleration(Vector3 fromV, Vector3 toV)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xD6BCE0", Offset = "0xD6BCE0", VA = "0xD6BCE0")]
		public static Vector3 GetAngularAcceleration(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xD6D89C", Offset = "0xD6D89C", VA = "0xD6D89C")]
		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xD6DB4C", Offset = "0xD6DB4C", VA = "0xD6DB4C")]
		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xD6DE00", Offset = "0xD6DE00", VA = "0xD6DE00")]
		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xD6E06C", Offset = "0xD6E06C", VA = "0xD6E06C")]
		public static Vector3 GetLinearAcceleration(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xD6E140", Offset = "0xD6E140", VA = "0xD6E140")]
		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xD6E290", Offset = "0xD6E290", VA = "0xD6E290")]
		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xD6D3C8", Offset = "0xD6D3C8", VA = "0xD6D3C8")]
		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xD6E2F4", Offset = "0xD6E2F4", VA = "0xD6E2F4")]
		public static bool RayCapsuleIntersectUnscaled(Vector3 origin, Vector3 direction, CapsuleCollider capsule)
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xD6E73C", Offset = "0xD6E73C", VA = "0xD6E73C")]
		public static bool RayCapsuleIntersect(Vector3 origin, Vector3 direction, CapsuleCollider capsule, float uniformScale)
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xD6E444", Offset = "0xD6E444", VA = "0xD6E444")]
		public static bool RayCapsuleIntersect(Vector3 origin, Vector3 direction, Vector3 capsuleTransformPos, Quaternion capsuleTransformRot, Vector3 capsuleCenter, float capsuleRadius, float capsuleHeight, int capsuleDir, float scale)
		{
			return default(bool);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xD6E890", Offset = "0xD6E890", VA = "0xD6E890")]
		public static bool RayCapsuleIntersect(Vector3 rayOrigin, Vector3 rayDir, Vector3 c1, Vector3 c2, float cRadius)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000034")]
	public class PressureSensor : MonoBehaviour
	{
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool visualize;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layers;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AD60", Offset = "0x73AD60")]
		private Vector3 <center>k__BackingField;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AD70", Offset = "0x73AD70")]
		private bool <inContact>k__BackingField;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AD80", Offset = "0x73AD80")]
		private Vector3 <bottom>k__BackingField;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AD90", Offset = "0x73AD90")]
		private Rigidbody <r>k__BackingField;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool fixedFrame;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 P;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int count;

		[Token(Token = "0x17000032")]
		public Vector3 center
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0xD6EC58", Offset = "0xD6EC58", VA = "0xD6EC58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E5BC", Offset = "0x73E5BC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000259")]
			[Address(RVA = "0xD6EC64", Offset = "0xD6EC64", VA = "0xD6EC64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E5CC", Offset = "0x73E5CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public bool inContact
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0xD6EC70", Offset = "0xD6EC70", VA = "0xD6EC70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E5DC", Offset = "0x73E5DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600025B")]
			[Address(RVA = "0xD6EC78", Offset = "0xD6EC78", VA = "0xD6EC78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E5EC", Offset = "0x73E5EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public Vector3 bottom
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0xD6EC84", Offset = "0xD6EC84", VA = "0xD6EC84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E5FC", Offset = "0x73E5FC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0xD6EC90", Offset = "0xD6EC90", VA = "0xD6EC90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E60C", Offset = "0x73E60C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public Rigidbody r
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xD6EC9C", Offset = "0xD6EC9C", VA = "0xD6EC9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E61C", Offset = "0x73E61C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0xD6ECA4", Offset = "0xD6ECA4", VA = "0xD6ECA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E62C", Offset = "0x73E62C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xD6ECAC", Offset = "0xD6ECAC", VA = "0xD6ECAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xD6ED28", Offset = "0xD6ED28", VA = "0xD6ED28")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xD6EF48", Offset = "0xD6EF48", VA = "0xD6EF48")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xD6EF4C", Offset = "0xD6EF4C", VA = "0xD6EF4C")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xD6EF54", Offset = "0xD6EF54", VA = "0xD6EF54")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xD6EFE8", Offset = "0xD6EFE8", VA = "0xD6EFE8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xD6ED2C", Offset = "0xD6ED2C", VA = "0xD6ED2C")]
		private void ProcessCollision(Collision c)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xD6F098", Offset = "0xD6F098", VA = "0xD6F098")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xD6F0BC", Offset = "0xD6F0BC", VA = "0xD6F0BC")]
		public PressureSensor()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public abstract class Prop : MonoBehaviour
	{
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73ADA0", Offset = "0x73ADA0")]
		public int propType;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73ADD8", Offset = "0x73ADD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73ADD8", Offset = "0x73ADD8")]
		public ConfigurableJoint muscle;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AE38", Offset = "0x73AE38")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AE70", Offset = "0x73AE70")]
		public bool forceLayers;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73AEA8", Offset = "0x73AEA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AEA8", Offset = "0x73AEA8")]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AF08", Offset = "0x73AF08")]
		public Transform additionalPinTarget;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AF40", Offset = "0x73AF40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73AF40", Offset = "0x73AF40")]
		public float additionalPinWeight;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73AF94", Offset = "0x73AF94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AF94", Offset = "0x73AF94")]
		public PhysicMaterial pickedUpMaterial;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AFF4", Offset = "0x73AFF4")]
		public PhysicMaterial droppedMaterial;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B02C", Offset = "0x73B02C")]
		private PropRoot <propRoot>k__BackingField;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B03C", Offset = "0x73B03C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private ConfigurableJointMotion xMotion;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ConfigurableJointMotion yMotion;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private ConfigurableJointMotion zMotion;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ConfigurableJointMotion angularXMotion;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private ConfigurableJointMotion angularYMotion;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ConfigurableJointMotion angularZMotion;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] colliders;

		[Token(Token = "0x17000036")]
		public bool isPickedUp
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0xD6F0C4", Offset = "0xD6F0C4", VA = "0xD6F0C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		public PropRoot propRoot
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0xD6F134", Offset = "0xD6F134", VA = "0xD6F134")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E63C", Offset = "0x73E63C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0xD6F13C", Offset = "0xD6F13C", VA = "0xD6F13C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E64C", Offset = "0x73E64C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool initiated
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xD6F408", Offset = "0xD6F408", VA = "0xD6F408")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E65C", Offset = "0x73E65C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0xD6F410", Offset = "0xD6F410", VA = "0xD6F410")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E66C", Offset = "0x73E66C")]
			private set
			{
			}
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xD6F144", Offset = "0xD6F144", VA = "0xD6F144")]
		public void PickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xD6F3CC", Offset = "0xD6F3CC", VA = "0xD6F3CC")]
		public void Drop()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xD6F400", Offset = "0xD6F400", VA = "0xD6F400")]
		public void StartPickedUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xD6F41C", Offset = "0xD6F41C", VA = "0xD6F41C", Slot = "4")]
		protected virtual void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xD6F420", Offset = "0xD6F420", VA = "0xD6F420", Slot = "5")]
		protected virtual void OnDrop()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xD6F424", Offset = "0xD6F424", VA = "0xD6F424", Slot = "6")]
		protected virtual void OnStart()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xD6F428", Offset = "0xD6F428", VA = "0xD6F428")]
		private void Start()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xD6F684", Offset = "0xD6F684", VA = "0xD6F684")]
		private void ReleaseJoint()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xD6F2F4", Offset = "0xD6F2F4", VA = "0xD6F2F4")]
		private void SetMaterial(PhysicMaterial material)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xD6F7D0", Offset = "0xD6F7D0", VA = "0xD6F7D0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xD6F980", Offset = "0xD6F980", VA = "0xD6F980")]
		protected Prop()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class PropMuscle : MonoBehaviour
	{
		[Token(Token = "0x200009A")]
		public delegate void PropDelegate(PuppetMasterProp prop);

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B05C", Offset = "0x73B05C")]
		public PuppetMasterProp currentProp;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73B094", Offset = "0x73B094")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B094", Offset = "0x73B094")]
		public Vector3 additionalPinOffset;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B0F4", Offset = "0x73B0F4")]
		private PuppetMasterProp <activeProp>k__BackingField;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PropDelegate OnPickUpProp;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PropDelegate OnDropProp;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Muscle _muscle;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PuppetMasterProp lastProp;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastAdditionalPinOffset;

		[Token(Token = "0x17000039")]
		public Muscle muscle
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0xD6FA0C", Offset = "0xD6FA0C", VA = "0xD6FA0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public PuppetMasterProp activeProp
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0xD6FAE0", Offset = "0xD6FAE0", VA = "0xD6FAE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E67C", Offset = "0x73E67C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600027B")]
			[Address(RVA = "0xD6FAE8", Offset = "0xD6FAE8", VA = "0xD6FAE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E68C", Offset = "0x73E68C")]
			private set
			{
			}
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xD6FAF0", Offset = "0xD6FAF0", VA = "0xD6FAF0")]
		public bool AddAdditionalPin()
		{
			return default(bool);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xD6FF30", Offset = "0xD6FF30", VA = "0xD6FF30")]
		public bool RemoveAdditionalPin()
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xD700B8", Offset = "0xD700B8", VA = "0xD700B8")]
		public void OnInitiate()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xD70318", Offset = "0xD70318", VA = "0xD70318")]
		public void TakeOver()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xD70360", Offset = "0xD70360", VA = "0xD70360")]
		public void OnUpdate()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xD70F24", Offset = "0xD70F24", VA = "0xD70F24")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xD711DC", Offset = "0xD711DC", VA = "0xD711DC")]
		public PropMuscle()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x738EF4", Offset = "0x738EF4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x738EF4", Offset = "0x738EF4")]
	public class PropRoot : MonoBehaviour
	{
		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B104", Offset = "0x73B104")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B13C", Offset = "0x73B13C")]
		public Rigidbody connectTo;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B174", Offset = "0x73B174")]
		public Prop currentProp;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Prop lastProp;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool fixedUpdateCalled;

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xD71294", Offset = "0xD71294", VA = "0xD71294")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E69C", Offset = "0x73E69C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xD712E0", Offset = "0xD712E0", VA = "0xD712E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E6D4", Offset = "0x73E6D4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xD7132C", Offset = "0xD7132C", VA = "0xD7132C")]
		public void DropImmediate()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xD7217C", Offset = "0xD7217C", VA = "0xD7217C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xD72250", Offset = "0xD72250", VA = "0xD72250")]
		private void Update()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xD72388", Offset = "0xD72388", VA = "0xD72388")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xD725A0", Offset = "0xD725A0", VA = "0xD725A0")]
		private void AttachProp(Prop prop)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xD73120", Offset = "0xD73120", VA = "0xD73120")]
		public PropRoot()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x738F54", Offset = "0x738F54")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x738F54", Offset = "0x738F54")]
	public class PropTemplate : Prop
	{
		[Token(Token = "0x600028B")]
		[Address(RVA = "0xD73128", Offset = "0xD73128", VA = "0xD73128", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xD7312C", Offset = "0xD7312C", VA = "0xD7312C", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xD73130", Offset = "0xD73130", VA = "0xD73130", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xD73134", Offset = "0xD73134", VA = "0xD73134")]
		public PropTemplate()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x738FB4", Offset = "0x738FB4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x738FB4", Offset = "0x738FB4")]
	public class PuppetMaster : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009B")]
		public enum Mode
		{
			[Token(Token = "0x40004A6")]
			Active,
			[Token(Token = "0x40004A7")]
			Kinematic,
			[Token(Token = "0x40004A8")]
			Disabled
		}

		[Token(Token = "0x200009C")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200009D")]
		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		[Token(Token = "0x200009E")]
		public enum UpdateMode
		{
			[Token(Token = "0x40004AA")]
			Normal,
			[Token(Token = "0x40004AB")]
			AnimatePhysics,
			[Token(Token = "0x40004AC")]
			FixedUpdate
		}

		[Serializable]
		[Token(Token = "0x200009F")]
		public enum State
		{
			[Token(Token = "0x40004AE")]
			Alive,
			[Token(Token = "0x40004AF")]
			Dead,
			[Token(Token = "0x40004B0")]
			Frozen
		}

		[Serializable]
		[Token(Token = "0x20000A0")]
		public struct StateSettings
		{
			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D850", Offset = "0x73D850")]
			public float killDuration;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D888", Offset = "0x73D888")]
			public float deadMuscleWeight;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D8C0", Offset = "0x73D8C0")]
			public float deadMuscleDamper;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D8F8", Offset = "0x73D8F8")]
			public float maxFreezeSqrVelocity;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D930", Offset = "0x73D930")]
			public bool freezePermanently;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D968", Offset = "0x73D968")]
			public bool enableAngularLimitsOnKill;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D9A0", Offset = "0x73D9A0")]
			public bool enableInternalCollisionsOnKill;

			[Token(Token = "0x17000079")]
			public static StateSettings Default
			{
				[Token(Token = "0x60004F2")]
				[Address(RVA = "0xEA1544", Offset = "0xEA1544", VA = "0xEA1544")]
				get
				{
					return default(StateSettings);
				}
			}

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x63AB20", Offset = "0x63AB20", VA = "0x63AB20")]
			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool freezePermanently = false, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
			}
		}

		[Token(Token = "0x20000A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7392A8", Offset = "0x7392A8")]
		private sealed class <DisabledToActive>d__174 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x1700007A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004F6")]
				[Address(RVA = "0xEA0E14", Offset = "0xEA0E14", VA = "0xEA0E14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004F8")]
				[Address(RVA = "0xEA0E7C", Offset = "0xEA0E7C", VA = "0xEA0E7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0xEA0B44", Offset = "0xEA0B44", VA = "0xEA0B44")]
			[DebuggerHidden]
			public <DisabledToActive>d__174(int <>1__state)
			{
			}

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0xEA0B70", Offset = "0xEA0B70", VA = "0xEA0B70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0xEA0B74", Offset = "0xEA0B74", VA = "0xEA0B74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004F7")]
			[Address(RVA = "0xEA0E1C", Offset = "0xEA0E1C", VA = "0xEA0E1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7392B8", Offset = "0x7392B8")]
		private sealed class <KinematicToActive>d__176 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x1700007C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004FC")]
				[Address(RVA = "0xEA10DC", Offset = "0xEA10DC", VA = "0xEA10DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004FE")]
				[Address(RVA = "0xEA1144", Offset = "0xEA1144", VA = "0xEA1144", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004F9")]
			[Address(RVA = "0xEA0E84", Offset = "0xEA0E84", VA = "0xEA0E84")]
			[DebuggerHidden]
			public <KinematicToActive>d__176(int <>1__state)
			{
			}

			[Token(Token = "0x60004FA")]
			[Address(RVA = "0xEA0EB0", Offset = "0xEA0EB0", VA = "0xEA0EB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004FB")]
			[Address(RVA = "0xEA0EB4", Offset = "0xEA0EB4", VA = "0xEA0EB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004FD")]
			[Address(RVA = "0xEA10E4", Offset = "0xEA10E4", VA = "0xEA10E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7392C8", Offset = "0x7392C8")]
		private sealed class <ActiveToDisabled>d__177 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x1700007E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000502")]
				[Address(RVA = "0xEA0228", Offset = "0xEA0228", VA = "0xEA0228", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000504")]
				[Address(RVA = "0xEA0290", Offset = "0xEA0290", VA = "0xEA0290", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004FF")]
			[Address(RVA = "0xEA0070", Offset = "0xEA0070", VA = "0xEA0070")]
			[DebuggerHidden]
			public <ActiveToDisabled>d__177(int <>1__state)
			{
			}

			[Token(Token = "0x6000500")]
			[Address(RVA = "0xEA009C", Offset = "0xEA009C", VA = "0xEA009C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000501")]
			[Address(RVA = "0xEA00A0", Offset = "0xEA00A0", VA = "0xEA00A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0xEA0230", Offset = "0xEA0230", VA = "0xEA0230", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7392D8", Offset = "0x7392D8")]
		private sealed class <ActiveToKinematic>d__178 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000080")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000508")]
				[Address(RVA = "0xEA0488", Offset = "0xEA0488", VA = "0xEA0488", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000081")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600050A")]
				[Address(RVA = "0xEA04F0", Offset = "0xEA04F0", VA = "0xEA04F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000505")]
			[Address(RVA = "0xEA0298", Offset = "0xEA0298", VA = "0xEA0298")]
			[DebuggerHidden]
			public <ActiveToKinematic>d__178(int <>1__state)
			{
			}

			[Token(Token = "0x6000506")]
			[Address(RVA = "0xEA02C4", Offset = "0xEA02C4", VA = "0xEA02C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0xEA02C8", Offset = "0xEA02C8", VA = "0xEA02C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0xEA0490", Offset = "0xEA0490", VA = "0xEA0490", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7392E8", Offset = "0x7392E8")]
		private sealed class <AliveToDead>d__229 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool freeze;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <range>5__2;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <mW>5__3;

			[Token(Token = "0x17000082")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600050E")]
				[Address(RVA = "0xEA0AD4", Offset = "0xEA0AD4", VA = "0xEA0AD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000083")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000510")]
				[Address(RVA = "0xEA0B3C", Offset = "0xEA0B3C", VA = "0xEA0B3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0xEA04F8", Offset = "0xEA04F8", VA = "0xEA04F8")]
			[DebuggerHidden]
			public <AliveToDead>d__229(int <>1__state)
			{
			}

			[Token(Token = "0x600050C")]
			[Address(RVA = "0xEA0524", Offset = "0xEA0524", VA = "0xEA0524", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600050D")]
			[Address(RVA = "0xEA0528", Offset = "0xEA0528", VA = "0xEA0528", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600050F")]
			[Address(RVA = "0xEA0ADC", Offset = "0xEA0ADC", VA = "0xEA0ADC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B1AC", Offset = "0x73B1AC")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform targetRoot;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73B1E4", Offset = "0x73B1E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B1E4", Offset = "0x73B1E4")]
		public State state;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x73B244", Offset = "0x73B244")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B244", Offset = "0x73B244")]
		public StateSettings stateSettings;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B2C0", Offset = "0x73B2C0")]
		public Mode mode;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B2F8", Offset = "0x73B2F8")]
		public float blendTime;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B330", Offset = "0x73B330")]
		public bool fixTargetTransforms;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B368", Offset = "0x73B368")]
		public int solverIterationCount;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B3A0", Offset = "0x73B3A0")]
		public bool visualizeTargetPose;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73B3D8", Offset = "0x73B3D8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B3D8", Offset = "0x73B3D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B3D8", Offset = "0x73B3D8")]
		public float mappingWeight;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B450", Offset = "0x73B450")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B450", Offset = "0x73B450")]
		public float pinWeight;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B4A4", Offset = "0x73B4A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B4A4", Offset = "0x73B4A4")]
		public float muscleWeight;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73B4F8", Offset = "0x73B4F8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B4F8", Offset = "0x73B4F8")]
		public float muscleSpring;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B558", Offset = "0x73B558")]
		public float muscleDamper;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B590", Offset = "0x73B590")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B590", Offset = "0x73B590")]
		public float pinPow;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B5E4", Offset = "0x73B5E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B5E4", Offset = "0x73B5E4")]
		public float pinDistanceFalloff;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B63C", Offset = "0x73B63C")]
		public bool angularPinning;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B674", Offset = "0x73B674")]
		public bool updateJointAnchors;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B6AC", Offset = "0x73B6AC")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B6E4", Offset = "0x73B6E4")]
		public bool angularLimits;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B71C", Offset = "0x73B71C")]
		public bool internalCollisions;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73B754", Offset = "0x73B754")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B754", Offset = "0x73B754")]
		public Muscle[] muscles;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public PropMuscle[] propMuscles;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnRead;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnWrite;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UpdateDelegate OnPostLateUpdate;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnHierarchyChanged;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public MuscleDelegate OnMuscleRemoved;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public MuscleDelegate OnMuscleDisconnected;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public MuscleDelegate OnMuscleReconnected;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Animator _targetAnimator;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B7C4", Offset = "0x73B7C4")]
		private Animation <targetAnimation>k__BackingField;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B7D4", Offset = "0x73B7D4")]
		private BehaviourBase[] <behaviours>k__BackingField;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B7E4", Offset = "0x73B7E4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public List<SolverManager> solvers;

		[NonSerialized]
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[HideInInspector]
		public bool manualInternalCollisionControl;

		[NonSerialized]
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		[HideInInspector]
		public bool manualAngularLimitControl;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		[HideInInspector]
		public bool mapDisconnectedMuscles;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		private bool internalCollisionsEnabled;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool angularLimitsEnabled;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		private bool fixedFrame;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int lastSolverIterationCount;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private bool isLegacy;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		private bool animatorDisabled;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		private bool awakeFailed;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x107")]
		private bool interpolated;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool freezeFlag;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		private bool hasBeenDisabled;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
		private bool hierarchyIsFlat;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10B")]
		private bool teleport;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Vector3 teleportPosition;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion teleportRotation;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool teleportMoveToTarget;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		private bool rebuildFlag;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
		private bool onPostRebuildFlag;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool[] disconnectMuscleFlags;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private MuscleDisconnectMode[] muscleDisconnectModes;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private bool[] disconnectDeactivateFlags;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool[] reconnectMuscleFlags;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Muscle[] defaultMuscles;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 rebuildPelvisPos;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Quaternion rebuildPelvisRot;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float simulationDeltaTime;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private bool readInFixedUpdate;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x179")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B834", Offset = "0x73B834")]
		private bool <isSwitchingMode>k__BackingField;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Mode activeMode;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Mode lastMode;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private float mappingBlend;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B844", Offset = "0x73B844")]
		private bool <isKilling>k__BackingField;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public UpdateDelegate OnFreeze;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public UpdateDelegate OnUnfreeze;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public UpdateDelegate OnDeath;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public UpdateDelegate OnResurrection;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private State activeState;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private State lastState;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private bool angularLimitsEnabledOnKill;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		private bool internalCollisionsEnabledOnKill;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		private bool animationDisabledbyStates;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BB")]
		[HideInInspector]
		public bool storeTargetMappedState;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool targetMappedStateStored;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
		private bool targetMappedStateSampled;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BE")]
		private bool sampleTargetMappedState;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BF")]
		private bool hasProp;

		[Token(Token = "0x1700003B")]
		public Animator targetAnimator
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0xD73C18", Offset = "0xD73C18", VA = "0xD73C18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000297")]
			[Address(RVA = "0xD73D60", Offset = "0xD73D60", VA = "0xD73D60")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public Animation targetAnimation
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0xD73D68", Offset = "0xD73D68", VA = "0xD73D68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E85C", Offset = "0x73E85C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000299")]
			[Address(RVA = "0xD73D70", Offset = "0xD73D70", VA = "0xD73D70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E86C", Offset = "0x73E86C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public BehaviourBase[] behaviours
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0xD73D78", Offset = "0xD73D78", VA = "0xD73D78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E87C", Offset = "0x73E87C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029B")]
			[Address(RVA = "0xD73D80", Offset = "0xD73D80", VA = "0xD73D80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E88C", Offset = "0x73E88C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public bool isActive
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0xD73D88", Offset = "0xD73D88", VA = "0xD73D88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public bool initiated
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0xD73E1C", Offset = "0xD73E1C", VA = "0xD73E1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E89C", Offset = "0x73E89C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029E")]
			[Address(RVA = "0xD73E24", Offset = "0xD73E24", VA = "0xD73E24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E8AC", Offset = "0x73E8AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public UpdateMode updateMode
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0xD73E30", Offset = "0xD73E30", VA = "0xD73E30")]
			get
			{
				return default(UpdateMode);
			}
		}

		[Token(Token = "0x17000041")]
		public bool controlsAnimator
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0xD73F6C", Offset = "0xD73F6C", VA = "0xD73F6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		public bool isBlending
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0xD73DF8", Offset = "0xD73DF8", VA = "0xD73DF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		private bool autoSimulate
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0xD74158", Offset = "0xD74158", VA = "0xD74158")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		private AnimatorUpdateMode targetUpdateMode
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0xD73E70", Offset = "0xD73E70", VA = "0xD73E70")]
			get
			{
				return default(AnimatorUpdateMode);
			}
		}

		[Token(Token = "0x17000045")]
		public bool isSwitchingMode
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xD7BCE8", Offset = "0xD7BCE8", VA = "0xD7BCE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E99C", Offset = "0x73E99C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xD7BCF0", Offset = "0xD7BCF0", VA = "0xD7BCF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E9AC", Offset = "0x73E9AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public bool isSwitchingState
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0xD73FCC", Offset = "0xD73FCC", VA = "0xD73FCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public bool isKilling
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0xD7F29C", Offset = "0xD7F29C", VA = "0xD7F29C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EB4C", Offset = "0x73EB4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000306")]
			[Address(RVA = "0xD7F2A4", Offset = "0xD7F2A4", VA = "0xD7F2A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EB5C", Offset = "0x73EB5C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public bool isAlive
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0xD7906C", Offset = "0xD7906C", VA = "0xD7906C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		public bool isFrozen
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0xD77C44", Offset = "0xD77C44", VA = "0xD77C44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xD73A10", Offset = "0xD73A10", VA = "0xD73A10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E70C", Offset = "0x73E70C")]
		private void OpenUserManualSetup()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xD73A5C", Offset = "0xD73A5C", VA = "0xD73A5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E744", Offset = "0x73E744")]
		private void OpenUserManualComponent()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xD73AA8", Offset = "0xD73AA8", VA = "0xD73AA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E77C", Offset = "0x73E77C")]
		private void OpenUserManualPerformance()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xD73AF4", Offset = "0xD73AF4", VA = "0xD73AF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E7B4", Offset = "0x73E7B4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xD73B40", Offset = "0xD73B40", VA = "0xD73B40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E7EC", Offset = "0x73E7EC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xD73B8C", Offset = "0xD73B8C", VA = "0xD73B8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E824", Offset = "0x73E824")]
		private void OpenComponentTutorial()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xD73BD8", Offset = "0xD73BD8", VA = "0xD73BD8")]
		private void ResetStateSettings()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xD73FE0", Offset = "0xD73FE0", VA = "0xD73FE0")]
		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xD73FE4", Offset = "0xD73FE4", VA = "0xD73FE4")]
		public void SetInternalCollisionsManual(bool collide, bool useInternalCollisionIgnores)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xD740D0", Offset = "0xD740D0", VA = "0xD740D0")]
		public void SetAngularLimitsManual(bool limited)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xD74160", Offset = "0xD74160", VA = "0xD74160")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xD7420C", Offset = "0xD7420C", VA = "0xD7420C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xD74994", Offset = "0xD74994", VA = "0xD74994")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xD753BC", Offset = "0xD753BC", VA = "0xD753BC")]
		public void Start()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xD75464", Offset = "0xD75464", VA = "0xD75464")]
		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xD749D8", Offset = "0xD749D8", VA = "0xD749D8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xD765B4", Offset = "0xD765B4", VA = "0xD765B4")]
		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xD766B0", Offset = "0xD766B0", VA = "0xD766B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xD767A4", Offset = "0xD767A4", VA = "0xD767A4")]
		private bool IsInterpolated()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xD76830", Offset = "0xD76830", VA = "0xD76830")]
		private void OnRebuild()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xD76B64", Offset = "0xD76B64", VA = "0xD76B64")]
		public void OnPreSimulate(float deltaTime)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xD77D3C", Offset = "0xD77D3C", VA = "0xD77D3C")]
		public void OnPostSimulate()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xD784E8", Offset = "0xD784E8", VA = "0xD784E8", Slot = "4")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xD78A80", Offset = "0xD78A80", VA = "0xD78A80", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xD78B70", Offset = "0xD78B70", VA = "0xD78B70", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xD78D08", Offset = "0xD78D08", VA = "0xD78D08", Slot = "7")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xD780C8", Offset = "0xD780C8", VA = "0xD780C8")]
		private void MoveToTarget()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xD7722C", Offset = "0xD7722C", VA = "0xD7722C")]
		private void Read()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xD77AB0", Offset = "0xD77AB0", VA = "0xD77AB0")]
		private void FixTargetTransforms()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xD7907C", Offset = "0xD7907C", VA = "0xD7907C")]
		private void VisualizeTargetPose()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xD79324", Offset = "0xD79324", VA = "0xD79324")]
		private void VisualizeHierarchy(Transform t, Color color)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xD764C0", Offset = "0xD764C0", VA = "0xD764C0")]
		public void FlagInternalCollisionsForUpdate()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xD77C54", Offset = "0xD77C54", VA = "0xD77C54")]
		private void UpdateInternalCollisions()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xD7965C", Offset = "0xD7965C", VA = "0xD7965C")]
		public void UpdateInternalCollisions(Muscle m)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xD79584", Offset = "0xD79584", VA = "0xD79584")]
		private void IgnoreInternalCollisions()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xD79714", Offset = "0xD79714", VA = "0xD79714")]
		public void IgnoreInternalCollisions(Muscle m)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xD794A4", Offset = "0xD794A4", VA = "0xD794A4")]
		private void ResetInternalCollisions()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xD797A4", Offset = "0xD797A4", VA = "0xD797A4")]
		public void ResetInternalCollisions(Muscle m, bool useInternalCollisionIgnores)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xD764DC", Offset = "0xD764DC", VA = "0xD764DC")]
		public void FlagAngularLimitsForUpdate()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xD77C8C", Offset = "0xD77C8C", VA = "0xD77C8C")]
		private void UpdateAngularLimits()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xD79844", Offset = "0xD79844", VA = "0xD79844")]
		public bool AddPropMuscle(ConfigurableJoint addPropMuscleTo, Vector3 position, Quaternion rotation, Vector3 additionalPinOffset, [Optional] Transform targetParent, [Optional] PuppetMasterProp initiateWithProp)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xD70900", Offset = "0xD70900", VA = "0xD70900")]
		public bool IsDisconnecting(int muscleIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xD7093C", Offset = "0xD7093C", VA = "0xD7093C")]
		public bool IsReconnecting(int muscleIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xD701B4", Offset = "0xD701B4", VA = "0xD701B4")]
		public void DisconnectMuscleRecursive(int index, MuscleDisconnectMode disconnectMode = MuscleDisconnectMode.Sever, bool deactivate = false)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xD70D0C", Offset = "0xD70D0C", VA = "0xD70D0C")]
		public void ReconnectMuscleRecursive(int index)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xD727D8", Offset = "0xD727D8", VA = "0xD727D8")]
		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, [Optional] Muscle.Props muscleProps, bool forceTreeHierarchy = false, bool forceLayers = true)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xD7A338", Offset = "0xD7A338", VA = "0xD7A338")]
		public void Rebuild()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xD713F8", Offset = "0xD713F8", VA = "0xD713F8")]
		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xD7A6A0", Offset = "0xD7A6A0", VA = "0xD7A6A0")]
		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xD7A740", Offset = "0xD7A740", VA = "0xD7A740")]
		public void SetMuscles(Muscle[] newMuscles)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xD7A7E0", Offset = "0xD7A7E0", VA = "0xD7A7E0")]
		public void DisableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xD7A880", Offset = "0xD7A880", VA = "0xD7A880")]
		public void EnableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xD7A920", Offset = "0xD7A920", VA = "0xD7A920")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E8BC", Offset = "0x73E8BC")]
		public void FlattenHierarchy()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xD7AA30", Offset = "0xD7AA30", VA = "0xD7AA30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E8F4", Offset = "0x73E8F4")]
		public void TreeHierarchy()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xD7ABA4", Offset = "0xD7ABA4", VA = "0xD7ABA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E92C", Offset = "0x73E92C")]
		public void FixMusclePositions()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xD7ACE0", Offset = "0xD7ACE0", VA = "0xD7ACE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E964", Offset = "0x73E964")]
		public void FixMusclePositionsAndRotations()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xD763B0", Offset = "0xD763B0", VA = "0xD763B0")]
		public bool HierarchyIsFlat()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xD79EE4", Offset = "0xD79EE4", VA = "0xD79EE4")]
		private int GetHighestDisconnectedParentIndex(int index)
		{
			return default(int);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xD77088", Offset = "0xD77088", VA = "0xD77088")]
		private void ProcessDisconnects()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xD77184", Offset = "0xD77184", VA = "0xD77184")]
		private void ProcessReconnects()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xD7AE54", Offset = "0xD7AE54", VA = "0xD7AE54")]
		private void OnDisconnectMuscleRecursive(int index, MuscleDisconnectMode disconnectMode = MuscleDisconnectMode.Sever, bool deactivate = false)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xD7B2C4", Offset = "0xD7B2C4", VA = "0xD7B2C4")]
		private void DisconnectMuscle(Muscle m, bool sever, bool deactivate)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xD7B118", Offset = "0xD7B118", VA = "0xD7B118")]
		private void OnReconnectMuscleRecursive(int index)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xD7B764", Offset = "0xD7B764", VA = "0xD7B764")]
		private void ReconnectMuscle(Muscle m)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xD7BB58", Offset = "0xD7BB58", VA = "0xD7BB58")]
		private void AddIndexesRecursive(int index, ref int[] indexes)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xD7A510", Offset = "0xD7A510", VA = "0xD7A510")]
		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xD7A5D8", Offset = "0xD7A5D8", VA = "0xD7A5D8")]
		private void KillJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xD7BCC8", Offset = "0xD7BCC8", VA = "0xD7BCC8")]
		public void SwitchToActiveMode()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xD7BCD0", Offset = "0xD7BCD0", VA = "0xD7BCD0")]
		public void SwitchToKinematicMode()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xD7BCDC", Offset = "0xD7BCDC", VA = "0xD7BCDC")]
		public void SwitchToDisabledMode()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xD7BCFC", Offset = "0xD7BCFC", VA = "0xD7BCFC")]
		public void DisableImmediately()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xD7BD9C", Offset = "0xD7BD9C", VA = "0xD7BD9C", Slot = "8")]
		protected virtual void SwitchModes()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xD7BF00", Offset = "0xD7BF00", VA = "0xD7BF00")]
		private void DisabledToKinematic()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xD7C060", Offset = "0xD7C060", VA = "0xD7C060")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E9BC", Offset = "0x73E9BC")]
		private IEnumerator DisabledToActive()
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xD7C0D0", Offset = "0xD7C0D0", VA = "0xD7C0D0")]
		private void KinematicToDisabled()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xD7C174", Offset = "0xD7C174", VA = "0xD7C174")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73EA20", Offset = "0x73EA20")]
		private IEnumerator KinematicToActive()
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xD7C1E4", Offset = "0xD7C1E4", VA = "0xD7C1E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73EA84", Offset = "0x73EA84")]
		private IEnumerator ActiveToDisabled()
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xD7C254", Offset = "0xD7C254", VA = "0xD7C254")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73EAE8", Offset = "0x73EAE8")]
		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xD7C2C4", Offset = "0xD7C2C4", VA = "0xD7C2C4")]
		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xD7C394", Offset = "0xD7C394", VA = "0xD7C394")]
		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xD7C7C8", Offset = "0xD7C7C8", VA = "0xD7C7C8")]
		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xD7CA7C", Offset = "0xD7CA7C", VA = "0xD7CA7C")]
		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xD7CBB0", Offset = "0xD7CBB0", VA = "0xD7CBB0")]
		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xD7CC9C", Offset = "0xD7CC9C", VA = "0xD7CC9C")]
		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xD7C5F4", Offset = "0xD7C5F4", VA = "0xD7C5F4")]
		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xD7CD24", Offset = "0xD7CD24", VA = "0xD7CD24")]
		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xD7A004", Offset = "0xD7A004", VA = "0xD7A004")]
		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xD6FA84", Offset = "0xD6FA84", VA = "0xD6FA84")]
		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xD76A74", Offset = "0xD76A74", VA = "0xD76A74")]
		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xD7C850", Offset = "0xD7C850", VA = "0xD7C850")]
		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return default(int);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xD7C41C", Offset = "0xD7C41C", VA = "0xD7C41C")]
		public int GetMuscleIndex(Transform target)
		{
			return default(int);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xD7CD80", Offset = "0xD7CD80", VA = "0xD7CD80")]
		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return default(int);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xD7A344", Offset = "0xD7A344", VA = "0xD7A344")]
		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xD7CF58", Offset = "0xD7CF58", VA = "0xD7CF58")]
		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xD7DB20", Offset = "0xD7DB20", VA = "0xD7DB20")]
		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xD7D04C", Offset = "0xD7D04C", VA = "0xD7D04C")]
		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xD7DC80", Offset = "0xD7DC80", VA = "0xD7DC80")]
		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xD7E47C", Offset = "0xD7E47C", VA = "0xD7E47C")]
		private void SetUpMuscles(Transform setUpTo)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xD7EDF4", Offset = "0xD7EDF4", VA = "0xD7EDF4")]
		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return default(Muscle.Group);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xD7E0A8", Offset = "0xD7E0A8", VA = "0xD7E0A8")]
		private void RemoveUnnecessaryBones()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xD7EAE0", Offset = "0xD7EAE0", VA = "0xD7EAE0")]
		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xD7F2B0", Offset = "0xD7F2B0", VA = "0xD7F2B0")]
		public void Kill()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xD7F2BC", Offset = "0xD7F2BC", VA = "0xD7F2BC")]
		public void Kill(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xD7F2D8", Offset = "0xD7F2D8", VA = "0xD7F2D8")]
		public void Freeze()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xD7F2E4", Offset = "0xD7F2E4", VA = "0xD7F2E4")]
		public void Freeze(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xD7F300", Offset = "0xD7F300", VA = "0xD7F300")]
		public void Resurrect()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xD7F308", Offset = "0xD7F308", VA = "0xD7F308", Slot = "9")]
		protected virtual void SwitchStates()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xD7F408", Offset = "0xD7F408", VA = "0xD7F408")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73EB6C", Offset = "0x73EB6C")]
		private IEnumerator AliveToDead(bool freeze)
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xD78264", Offset = "0xD78264", VA = "0xD78264")]
		private void OnFreezeFlag()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xD7F48C", Offset = "0xD7F48C", VA = "0xD7F48C")]
		private void DeadToAlive()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xD746A8", Offset = "0xD746A8", VA = "0xD746A8")]
		private void SetAnimationEnabled(bool to)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xD7F59C", Offset = "0xD7F59C", VA = "0xD7F59C")]
		private void DeadToFrozen()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xD7F5A8", Offset = "0xD7F5A8", VA = "0xD7F5A8")]
		private void FrozenToAlive()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xD7F7C8", Offset = "0xD7F7C8", VA = "0xD7F7C8")]
		private void FrozenToDead()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xD747A8", Offset = "0xD747A8", VA = "0xD747A8")]
		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xD7F89C", Offset = "0xD7F89C", VA = "0xD7F89C")]
		private bool CanFreeze()
		{
			return default(bool);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xD7F958", Offset = "0xD7F958", VA = "0xD7F958")]
		public void SampleTargetMappedState()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xD7FA24", Offset = "0xD7FA24", VA = "0xD7FA24")]
		public void FixTargetToSampledState(float weight)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xD764F8", Offset = "0xD764F8", VA = "0xD764F8")]
		public void StoreTargetMappedState()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xD76134", Offset = "0xD76134", VA = "0xD76134")]
		private void UpdateHierarchies()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xD80284", Offset = "0xD80284", VA = "0xD80284")]
		private bool HasProp()
		{
			return default(bool);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xD80118", Offset = "0xD80118", VA = "0xD80118")]
		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xD7FD14", Offset = "0xD7FD14", VA = "0xD7FD14")]
		private void AssignParentAndChildIndexes()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xD802FC", Offset = "0xD802FC", VA = "0xD802FC")]
		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xD80474", Offset = "0xD80474", VA = "0xD80474")]
		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xD8000C", Offset = "0xD8000C", VA = "0xD8000C")]
		private void AssignKinshipDegrees()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xD80754", Offset = "0xD80754", VA = "0xD80754")]
		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xD808B8", Offset = "0xD808B8", VA = "0xD808B8")]
		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xD80678", Offset = "0xD80678", VA = "0xD80678")]
		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xD757D8", Offset = "0xD757D8", VA = "0xD757D8")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xD7A060", Offset = "0xD7A060", VA = "0xD7A060")]
		private bool CheckMassVariation(float threshold, bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xD79F74", Offset = "0xD79F74", VA = "0xD79F74")]
		private bool CheckIfInitiated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xD80B1C", Offset = "0xD80B1C", VA = "0xD80B1C")]
		public PuppetMaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	public enum MuscleRemoveMode
	{
		[Token(Token = "0x400026E")]
		Sever,
		[Token(Token = "0x400026F")]
		Explode,
		[Token(Token = "0x4000270")]
		Numb
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public enum MuscleDisconnectMode
	{
		[Token(Token = "0x4000272")]
		Sever,
		[Token(Token = "0x4000273")]
		Explode
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x739014", Offset = "0x739014")]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20000A6")]
		public class HumanoidMuscle
		{
			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Muscle.Props props;

			[Token(Token = "0x6000511")]
			[Address(RVA = "0xEA1B08", Offset = "0xEA1B08", VA = "0xEA1B08")]
			public HumanoidMuscle()
			{
			}
		}

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73B864", Offset = "0x73B864")]
		public PuppetMaster.State state;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PuppetMaster.Mode mode;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blendTime;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool fixTargetTransforms;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int solverIterationCount;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool visualizeTargetPose;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73B89C", Offset = "0x73B89C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B89C", Offset = "0x73B89C")]
		public float mappingWeight;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B8F0", Offset = "0x73B8F0")]
		public float pinWeight;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B908", Offset = "0x73B908")]
		public float muscleWeight;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73B920", Offset = "0x73B920")]
		public float muscleSpring;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float muscleDamper;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B958", Offset = "0x73B958")]
		public float pinPow;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B970", Offset = "0x73B970")]
		public float pinDistanceFalloff;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool angularPinning;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool updateJointAnchors;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool angularLimits;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool internalCollisions;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73B98C", Offset = "0x73B98C")]
		public HumanoidMuscle[] muscles;

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xEA15B4", Offset = "0xEA15B4", VA = "0xEA15B4")]
		public void ApplyTo(PuppetMaster p)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xEA1920", Offset = "0xEA1920", VA = "0xEA1920")]
		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			return null;
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xEA1A54", Offset = "0xEA1A54", VA = "0xEA1A54")]
		public PuppetMasterHumanoidConfig()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public interface ICollisionEventListener
	{
		[Token(Token = "0x600032C")]
		void OnCollisionEnterEvent(Collision collision, CollisionEventBroadcaster broadcaster);

		[Token(Token = "0x600032D")]
		void OnCollisionStayEvent(Collision collision, CollisionEventBroadcaster broadcaster);

		[Token(Token = "0x600032E")]
		void OnCollisionExitEvent(Collision collision, CollisionEventBroadcaster broadcaster);
	}
	[Token(Token = "0x200003E")]
	public class CollisionEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ICollisionEventListener listener;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MuscleLite muscle;

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xCA5B98", Offset = "0xCA5B98", VA = "0xCA5B98")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xCA5C68", Offset = "0xCA5C68", VA = "0xCA5C68")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xCA5D3C", Offset = "0xCA5D3C", VA = "0xCA5D3C")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xCA5E10", Offset = "0xCA5E10", VA = "0xCA5E10")]
		public CollisionEventBroadcaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class MuscleLite
	{
		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public string name;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ConfigurableJoint joint;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float pinWeightMlp;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float muscleWeightMlp;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float muscleDamperMlp;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float mappingWeightMlp;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B9D4", Offset = "0x73B9D4")]
		private Transform <transform>k__BackingField;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B9E4", Offset = "0x73B9E4")]
		private Rigidbody <rigidbody>k__BackingField;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B9F4", Offset = "0x73B9F4")]
		private Vector3 <positionOffset>k__BackingField;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73BA04", Offset = "0x73BA04")]
		private int <index>k__BackingField;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private JointDrive slerpDrive;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion toJointSpaceInverse;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion toJointSpaceDefault;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion targetAnimatedRotation;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private Quaternion toParentSpace;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion localRotationConvert;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion targetAnimatedWorldRotation;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector3 defaultTargetLocalPosition;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private float lastJointDriveRotationWeight;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float lastRotationDamper;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private bool initiated;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform connectedBodyTarget;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Transform connectedBodyTransform;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Transform targetParent;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool directTargetParent;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 targetVelocity;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 targetAnimatedCenterOfMass;

		[Token(Token = "0x1700004A")]
		public Transform transform
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0xD6A5A8", Offset = "0xD6A5A8", VA = "0xD6A5A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EBD0", Offset = "0x73EBD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000334")]
			[Address(RVA = "0xD6A5B0", Offset = "0xD6A5B0", VA = "0xD6A5B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EBE0", Offset = "0x73EBE0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0xD6A5B8", Offset = "0xD6A5B8", VA = "0xD6A5B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EBF0", Offset = "0x73EBF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000336")]
			[Address(RVA = "0xD6A5C0", Offset = "0xD6A5C0", VA = "0xD6A5C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EC00", Offset = "0x73EC00")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public Vector3 positionOffset
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0xD6A5C8", Offset = "0xD6A5C8", VA = "0xD6A5C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EC10", Offset = "0x73EC10")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000338")]
			[Address(RVA = "0xD6A5D4", Offset = "0xD6A5D4", VA = "0xD6A5D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EC20", Offset = "0x73EC20")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public int index
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0xD6A5E0", Offset = "0xD6A5E0", VA = "0xD6A5E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EC30", Offset = "0x73EC30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600033A")]
			[Address(RVA = "0xD6A5E8", Offset = "0xD6A5E8", VA = "0xD6A5E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EC40", Offset = "0x73EC40")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		private Quaternion localRotation
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0xD6B070", Offset = "0xD6B070", VA = "0xD6B070")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700004F")]
		private Quaternion targetLocalRotation
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0xD6AF58", Offset = "0xD6AF58", VA = "0xD6AF58")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000050")]
		private Quaternion parentRotation
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0xD6AE08", Offset = "0xD6AE08", VA = "0xD6AE08")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000051")]
		private Quaternion targetParentRotation
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0xD6AD50", Offset = "0xD6AD50", VA = "0xD6AD50")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xD6A5F0", Offset = "0xD6A5F0", VA = "0xD6A5F0")]
		public void Initiate(MuscleLite[] colleagues)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xD6B34C", Offset = "0xD6B34C", VA = "0xD6B34C")]
		public void FixTargetTransforms()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xD6B3B0", Offset = "0xD6B3B0", VA = "0xD6B3B0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xD6B5BC", Offset = "0xD6B5BC", VA = "0xD6B5BC")]
		public void MoveToTarget()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xD6B67C", Offset = "0xD6B67C", VA = "0xD6B67C")]
		public void ClearVelocities()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xD6B158", Offset = "0xD6B158", VA = "0xD6B158")]
		public void Read()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xD6B758", Offset = "0xD6B758", VA = "0xD6B758")]
		public void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, bool angularPinning)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xD6B7B0", Offset = "0xD6B7B0", VA = "0xD6B7B0")]
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff, bool angularPinning)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xD6BB34", Offset = "0xD6BB34", VA = "0xD6BB34")]
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xD6C050", Offset = "0xD6C050", VA = "0xD6C050")]
		public void Map(float masterWeight)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xD6C380", Offset = "0xD6C380", VA = "0xD6C380")]
		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xD6BF6C", Offset = "0xD6BF6C", VA = "0xD6BF6C")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xD6C5F0", Offset = "0xD6C5F0", VA = "0xD6C5F0")]
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xD6C710", Offset = "0xD6C710", VA = "0xD6C710")]
		public MuscleLite()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class PuppetControllerLite : MonoBehaviour, ICollisionEventListener
	{
		[Serializable]
		[Token(Token = "0x20000A7")]
		public class Group
		{
			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D9E8", Offset = "0x73D9E8")]
			public int[] indices;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73DA20", Offset = "0x73DA20")]
			public float pinWeightMlp;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73DA38", Offset = "0x73DA38")]
			public float muscleWeightMlp;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73DA50", Offset = "0x73DA50")]
			public float drag;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73DA88", Offset = "0x73DA88")]
			public float blendInTime;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73DAC0", Offset = "0x73DAC0")]
			public float blendOutTime;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DAF8", Offset = "0x73DAF8")]
			private bool <enabled>k__BackingField;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB08", Offset = "0x73DB08")]
			private float <mappingWeight>k__BackingField;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float dam;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float damTime;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float damV;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float map;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float mapV;

			[Token(Token = "0x17000084")]
			public bool enabled
			{
				[Token(Token = "0x6000512")]
				[Address(RVA = "0xD73970", Offset = "0xD73970", VA = "0xD73970")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F7A0", Offset = "0x73F7A0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000513")]
				[Address(RVA = "0xD73978", Offset = "0xD73978", VA = "0xD73978")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F7B0", Offset = "0x73F7B0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public float mappingWeight
			{
				[Token(Token = "0x6000514")]
				[Address(RVA = "0xD73984", Offset = "0xD73984", VA = "0xD73984")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F7C0", Offset = "0x73F7C0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000515")]
				[Address(RVA = "0xD7398C", Offset = "0xD7398C", VA = "0xD7398C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F7D0", Offset = "0x73F7D0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000516")]
			[Address(RVA = "0xD7387C", Offset = "0xD7387C", VA = "0xD7387C")]
			public void TryDamage(Collision collision, CollisionEventBroadcaster broadcaster)
			{
			}

			[Token(Token = "0x6000517")]
			[Address(RVA = "0xD733BC", Offset = "0xD733BC", VA = "0xD733BC")]
			public void Update(PuppetMasterLite puppetMaster)
			{
			}

			[Token(Token = "0x6000518")]
			[Address(RVA = "0xD73994", Offset = "0xD73994", VA = "0xD73994")]
			public Group()
			{
			}
		}

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMasterLite puppetMaster;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask collisionLayers;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BA14", Offset = "0x73BA14")]
		public Group[] groups;

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xD73138", Offset = "0xD73138", VA = "0xD73138")]
		private void Start()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xD73208", Offset = "0xD73208", VA = "0xD73208")]
		private bool NeedToUpdate()
		{
			return default(bool);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xD73274", Offset = "0xD73274", VA = "0xD73274")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xD73718", Offset = "0xD73718", VA = "0xD73718", Slot = "4")]
		public void OnCollisionEnterEvent(Collision collision, CollisionEventBroadcaster broadcaster)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xD73878", Offset = "0xD73878", VA = "0xD73878", Slot = "5")]
		public void OnCollisionStayEvent(Collision collision, CollisionEventBroadcaster broadcaster)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xD7371C", Offset = "0xD7371C", VA = "0xD7371C")]
		private void ProcessCollisionEvent(Collision collision, CollisionEventBroadcaster broadcaster)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xD7390C", Offset = "0xD7390C", VA = "0xD7390C", Slot = "6")]
		public void OnCollisionExitEvent(Collision collision, CollisionEventBroadcaster broadcaster)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xD73910", Offset = "0xD73910", VA = "0xD73910")]
		public PuppetControllerLite()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class PuppetMasterLite : MonoBehaviour
	{
		[Token(Token = "0x20000A8")]
		public delegate void PuppetMasterLiteDelegate();

		[Token(Token = "0x20000A9")]
		public enum UpdateMode
		{
			[Token(Token = "0x40004DC")]
			Normal,
			[Token(Token = "0x40004DD")]
			Fixed
		}

		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7392F8", Offset = "0x7392F8")]
		private sealed class <Activation>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMasterLite <>4__this;

			[Token(Token = "0x17000086")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000520")]
				[Address(RVA = "0xEA2904", Offset = "0xEA2904", VA = "0xEA2904", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000522")]
				[Address(RVA = "0xEA296C", Offset = "0xEA296C", VA = "0xEA296C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600051D")]
			[Address(RVA = "0xEA1F4C", Offset = "0xEA1F4C", VA = "0xEA1F4C")]
			[DebuggerHidden]
			public <Activation>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600051E")]
			[Address(RVA = "0xEA27F4", Offset = "0xEA27F4", VA = "0xEA27F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600051F")]
			[Address(RVA = "0xEA27F8", Offset = "0xEA27F8", VA = "0xEA27F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000521")]
			[Address(RVA = "0xEA290C", Offset = "0xEA290C", VA = "0xEA290C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739308", Offset = "0x739308")]
		private sealed class <Deactivation>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMasterLite <>4__this;

			[Token(Token = "0x17000088")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000526")]
				[Address(RVA = "0xEA2AB4", Offset = "0xEA2AB4", VA = "0xEA2AB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000528")]
				[Address(RVA = "0xEA2B1C", Offset = "0xEA2B1C", VA = "0xEA2B1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000523")]
			[Address(RVA = "0xEA204C", Offset = "0xEA204C", VA = "0xEA204C")]
			[DebuggerHidden]
			public <Deactivation>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0xEA2974", Offset = "0xEA2974", VA = "0xEA2974", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000525")]
			[Address(RVA = "0xEA2978", Offset = "0xEA2978", VA = "0xEA2978", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000527")]
			[Address(RVA = "0xEA2ABC", Offset = "0xEA2ABC", VA = "0xEA2ABC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform targetRoot;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool fixTargetTransforms;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float blendTime;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73BA4C", Offset = "0x73BA4C")]
		public float mappingWeight;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73BA64", Offset = "0x73BA64")]
		public float pinWeight;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73BA7C", Offset = "0x73BA7C")]
		public float muscleWeight;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float muscleSpring;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float muscleDamper;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool updateJointAnchors;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool angularPinning;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73BA94", Offset = "0x73BA94")]
		public MuscleLite[] muscles;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PuppetMasterLiteDelegate OnRead;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public PuppetMasterLiteDelegate OnWrite;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animator targetAnimator;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool animatorDisabled;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool fixedFrame;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private UpdateMode updateMode;

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xEA1B10", Offset = "0xEA1B10", VA = "0xEA1B10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xEA1CBC", Offset = "0xEA1CBC", VA = "0xEA1CBC")]
		public void Activate()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xEA1EDC", Offset = "0xEA1EDC", VA = "0xEA1EDC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73EC50", Offset = "0x73EC50")]
		private IEnumerator Activation()
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xEA1F78", Offset = "0xEA1F78", VA = "0xEA1F78")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xEA1FDC", Offset = "0xEA1FDC", VA = "0xEA1FDC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73ECB4", Offset = "0x73ECB4")]
		private IEnumerator Deactivation()
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xEA1B14", Offset = "0xEA1B14", VA = "0xEA1B14")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xEA2078", Offset = "0xEA2078", VA = "0xEA2078")]
		private void Update()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xEA2128", Offset = "0xEA2128", VA = "0xEA2128")]
		private void FixTargetTransforms()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xEA219C", Offset = "0xEA219C", VA = "0xEA219C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xEA22C8", Offset = "0xEA22C8", VA = "0xEA22C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xEA1E08", Offset = "0xEA1E08", VA = "0xEA1E08")]
		private void Read()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xEA2344", Offset = "0xEA2344", VA = "0xEA2344")]
		private void Write()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xEA25E4", Offset = "0xEA25E4", VA = "0xEA25E4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xEA2770", Offset = "0xEA2770", VA = "0xEA2770")]
		public PuppetMasterLite()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class PuppetMasterProp : MonoBehaviour
	{
		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BACC", Offset = "0x73BACC")]
		public Transform meshRoot;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BB04", Offset = "0x73BB04")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BB3C", Offset = "0x73BB3C")]
		public bool forceLayers;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BB74", Offset = "0x73BB74")]
		public float mass;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BBAC", Offset = "0x73BBAC")]
		public int propType;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73BBE4", Offset = "0x73BBE4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BBE4", Offset = "0x73BBE4")]
		public PhysicMaterial pickedUpMaterial;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73BC44", Offset = "0x73BC44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BC44", Offset = "0x73BC44")]
		public Vector3 additionalPinOffsetAdd;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BCA4", Offset = "0x73BCA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73BCA4", Offset = "0x73BCA4")]
		public float additionalPinWeight;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BCF8", Offset = "0x73BCF8")]
		public float additionalPinMass;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73BD30", Offset = "0x73BD30")]
		private bool <isPickedUp>k__BackingField;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73BD40", Offset = "0x73BD40")]
		private Muscle <propMuscle>k__BackingField;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int defaultLayer;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform defaultParent;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Collider[] colliders;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PhysicMaterial[] droppedMaterials;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody r;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _mass;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _drag;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _angularDrag;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool _useGravity;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		private bool _isKinematic;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RigidbodyInterpolation _interpolation;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private CollisionDetectionMode _collisionDetectionMode;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RigidbodyConstraints _constraints;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] emptyColliders;

		[Token(Token = "0x17000052")]
		public bool isPickedUp
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0xEA2B6C", Offset = "0xEA2B6C", VA = "0xEA2B6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ED18", Offset = "0x73ED18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000364")]
			[Address(RVA = "0xEA2B74", Offset = "0xEA2B74", VA = "0xEA2B74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ED28", Offset = "0x73ED28")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		protected Muscle propMuscle
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0xEA2C30", Offset = "0xEA2C30", VA = "0xEA2C30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ED38", Offset = "0x73ED38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000369")]
			[Address(RVA = "0xEA2C38", Offset = "0xEA2C38", VA = "0xEA2C38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ED48", Offset = "0x73ED48")]
			private set
			{
			}
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xEA2B80", Offset = "0xEA2B80", VA = "0xEA2B80")]
		public Rigidbody GetRigidbody()
		{
			return null;
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xEA2C28", Offset = "0xEA2C28", VA = "0xEA2C28", Slot = "4")]
		protected virtual void OnPickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xEA2C2C", Offset = "0xEA2C2C", VA = "0xEA2C2C", Slot = "5")]
		protected virtual void OnDrop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xEA2C40", Offset = "0xEA2C40", VA = "0xEA2C40")]
		public void PickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xEA31A0", Offset = "0xEA31A0", VA = "0xEA31A0")]
		public void Drop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xEA371C", Offset = "0xEA371C", VA = "0xEA371C", Slot = "6")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xEA3868", Offset = "0xEA3868", VA = "0xEA3868", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xEA3A7C", Offset = "0xEA3A7C", VA = "0xEA3A7C", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xEA3030", Offset = "0xEA3030", VA = "0xEA3030")]
		private void RemoveRigidbody()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xEA35D8", Offset = "0xEA35D8", VA = "0xEA35D8")]
		private void ReattachRigidbody()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xEA3B68", Offset = "0xEA3B68", VA = "0xEA3B68")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xEA3CD4", Offset = "0xEA3CD4", VA = "0xEA3CD4")]
		public PuppetMasterProp()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x739068", Offset = "0x739068")]
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		[Serializable]
		[Token(Token = "0x20000AC")]
		public class PuppetUpdateLimit
		{
			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73DB18", Offset = "0x73DB18")]
			public int puppetsPerFrame;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int index;

			[Token(Token = "0x6000529")]
			[Address(RVA = "0xEA43B4", Offset = "0xEA43B4", VA = "0xEA43B4")]
			public PuppetUpdateLimit()
			{
			}

			[Token(Token = "0x600052A")]
			[Address(RVA = "0xEA4220", Offset = "0xEA4220", VA = "0xEA4220")]
			public void Step(int puppetCount)
			{
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0xEA3ED0", Offset = "0xEA3ED0", VA = "0xEA3ED0")]
			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73BD50", Offset = "0x73BD50")]
		public PuppetUpdateLimit kinematicCollidersUpdateLimit;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PuppetUpdateLimit freeUpdateLimit;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PuppetUpdateLimit fixedUpdateLimit;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool collisionStayMessages;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool collisionExitMessages;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float activePuppetCollisionThresholdMlp;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73BD88", Offset = "0x73BD88")]
		private int <currentlyActivePuppets>k__BackingField;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73BD98", Offset = "0x73BD98")]
		private int <currentlyKinematicPuppets>k__BackingField;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73BDA8", Offset = "0x73BDA8")]
		private int <currentlyDisabledPuppets>k__BackingField;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PuppetMaster> _puppets;

		[Token(Token = "0x17000054")]
		public int currentlyActivePuppets
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0xEA3D74", Offset = "0xEA3D74", VA = "0xEA3D74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ED58", Offset = "0x73ED58")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000374")]
			[Address(RVA = "0xEA3D7C", Offset = "0xEA3D7C", VA = "0xEA3D7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ED68", Offset = "0x73ED68")]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public int currentlyKinematicPuppets
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0xEA3D84", Offset = "0xEA3D84", VA = "0xEA3D84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ED78", Offset = "0x73ED78")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000376")]
			[Address(RVA = "0xEA3D8C", Offset = "0xEA3D8C", VA = "0xEA3D8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ED88", Offset = "0x73ED88")]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public int currentlyDisabledPuppets
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0xEA3D94", Offset = "0xEA3D94", VA = "0xEA3D94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ED98", Offset = "0x73ED98")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000378")]
			[Address(RVA = "0xEA3D9C", Offset = "0xEA3D9C", VA = "0xEA3D9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EDA8", Offset = "0x73EDA8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public List<PuppetMaster> puppets
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0xEA3DA4", Offset = "0xEA3DA4", VA = "0xEA3DA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xEA3DAC", Offset = "0xEA3DAC", VA = "0xEA3DAC")]
		public void Register(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xEA3E44", Offset = "0xEA3E44", VA = "0xEA3E44")]
		public void Unregister(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xEA3EAC", Offset = "0xEA3EAC", VA = "0xEA3EAC")]
		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xEA3FE8", Offset = "0xEA3FE8", VA = "0xEA3FE8")]
		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xEA400C", Offset = "0xEA400C", VA = "0xEA400C")]
		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xEA4030", Offset = "0xEA4030", VA = "0xEA4030")]
		private void Update()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xEA423C", Offset = "0xEA423C", VA = "0xEA423C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xEA42AC", Offset = "0xEA42AC", VA = "0xEA42AC")]
		public PuppetMasterSettings()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public static class PuppetMasterTools
	{
		[Token(Token = "0x6000382")]
		[Address(RVA = "0xEA43E0", Offset = "0xEA43E0", VA = "0xEA43E0")]
		public static void PositionRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xEA4A68", Offset = "0xEA4A68", VA = "0xEA4A68")]
		public static void RealignRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xEA5354", Offset = "0xEA5354", VA = "0xEA5354")]
		private static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xEA540C", Offset = "0xEA540C", VA = "0xEA540C")]
		private static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000045")]
	public class RigidbodyController : MonoBehaviour
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73BDB8", Offset = "0x73BDB8")]
		public float weight;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool useTargetVelocity;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody r;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 lastTargetPos;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion lastTargetRot;

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xEA7180", Offset = "0xEA7180", VA = "0xEA7180")]
		public void OnTargetTeleported()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xEA71D0", Offset = "0xEA71D0", VA = "0xEA71D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xEA722C", Offset = "0xEA722C", VA = "0xEA722C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xEA769C", Offset = "0xEA769C", VA = "0xEA769C")]
		public RigidbodyController()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class Weight
	{
		[Serializable]
		[Token(Token = "0x20000AD")]
		public enum Mode
		{
			[Token(Token = "0x40004E7")]
			Float,
			[Token(Token = "0x40004E8")]
			Curve
		}

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mode mode;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float floatValue;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve curve;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xEA96F8", Offset = "0xEA96F8", VA = "0xEA96F8")]
		public Weight(float floatValue)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xEA9764", Offset = "0xEA9764", VA = "0xEA9764")]
		public Weight(float floatValue, string tooltip)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xEA97E0", Offset = "0xEA97E0", VA = "0xEA97E0")]
		public float GetValue(float param)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000047")]
	public class InitialVelocity : MonoBehaviour
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 initialVelocity;

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xCA5E18", Offset = "0xCA5E18", VA = "0xCA5E18")]
		private void Start()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xCA5E80", Offset = "0xCA5E80", VA = "0xCA5E80")]
		public InitialVelocity()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7390A0", Offset = "0x7390A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7390A0", Offset = "0x7390A0")]
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		[Token(Token = "0x20000AE")]
		public struct Options
		{
			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float weight;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73DB34", Offset = "0x73DB34")]
			public bool spine;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public bool chest;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public bool hands;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public bool feet;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73DB6C", Offset = "0x73DB6C")]
			public JointType joints;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float jointRange;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73DBA4", Offset = "0x73DBA4")]
			public float colliderLengthOverlap;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ColliderType torsoColliders;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ColliderType headCollider;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColliderType armColliders;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ColliderType handColliders;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public ColliderType legColliders;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ColliderType footColliders;

			[Token(Token = "0x1700008A")]
			public static Options Default
			{
				[Token(Token = "0x600052C")]
				[Address(RVA = "0xCA1370", Offset = "0xCA1370", VA = "0xCA1370")]
				get
				{
					return default(Options);
				}
			}
		}

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool canBuild;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedRagdollReferences references;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Options options;

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xCA105C", Offset = "0xCA105C", VA = "0xCA105C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EDB8", Offset = "0x73EDB8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xCA10A8", Offset = "0xCA10A8", VA = "0xCA10A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EDF0", Offset = "0x73EDF0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xCA10F4", Offset = "0xCA10F4", VA = "0xCA10F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EE28", Offset = "0x73EE28")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xCA1140", Offset = "0xCA1140", VA = "0xCA1140")]
		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default(Options);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xCA147C", Offset = "0xCA147C", VA = "0xCA147C")]
		public static void Create(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xCA1D90", Offset = "0xCA1D90", VA = "0xCA1D90")]
		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xCA3738", Offset = "0xCA3738", VA = "0xCA3738")]
		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xCA3A30", Offset = "0xCA3A30", VA = "0xCA3A30")]
		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xCA4064", Offset = "0xCA4064", VA = "0xCA4064")]
		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xCA29CC", Offset = "0xCA29CC", VA = "0xCA29CC")]
		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xCA2E30", Offset = "0xCA2E30", VA = "0xCA2E30")]
		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xCA4214", Offset = "0xCA4214", VA = "0xCA4214")]
		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xCA4918", Offset = "0xCA4918", VA = "0xCA4918")]
		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xCA4CD0", Offset = "0xCA4CD0", VA = "0xCA4CD0")]
		public static bool IsClear(BipedRagdollReferences r)
		{
			return default(bool);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xCA3654", Offset = "0xCA3654", VA = "0xCA3654")]
		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xCA13A8", Offset = "0xCA13A8", VA = "0xCA13A8")]
		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xCA4DCC", Offset = "0xCA4DCC", VA = "0xCA4DCC")]
		public BipedRagdollCreator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public struct BipedRagdollReferences
	{
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform root;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform hips;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform spine;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform chest;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform head;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftUpperLeg;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftLowerLeg;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform leftFoot;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightUpperLeg;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightLowerLeg;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightFoot;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftUpperArm;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftLowerArm;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform leftHand;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightUpperArm;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightLowerArm;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform rightHand;

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x63739C", Offset = "0x63739C", VA = "0x63739C")]
		public bool IsValid(ref string msg)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x6373A4", Offset = "0x6373A4", VA = "0x6373A4")]
		private bool IsChildRecursive(Transform t, Transform parent)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x6373AC", Offset = "0x6373AC", VA = "0x6373AC")]
		public bool IsEmpty(bool considerRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x6373B8", Offset = "0x6373B8", VA = "0x6373B8")]
		public bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x6373C4", Offset = "0x6373C4", VA = "0x6373C4")]
		public Transform[] GetRagdollTransforms()
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xCA5654", Offset = "0xCA5654", VA = "0xCA5654")]
		public static BipedRagdollReferences FromAvatar(Animator animator)
		{
			return default(BipedRagdollReferences);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xCA5870", Offset = "0xCA5870", VA = "0xCA5870")]
		public static BipedRagdollReferences FromBipedReferences(BipedReferences biped)
		{
			return default(BipedRagdollReferences);
		}
	}
	[Token(Token = "0x200004A")]
	public static class JointConverter
	{
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xCA5F14", Offset = "0xCA5F14", VA = "0xCA5F14")]
		public static void ToConfigurable(GameObject root)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xCA63F0", Offset = "0xCA63F0", VA = "0xCA63F0")]
		public static void HingeToConfigurable(HingeJoint src)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xCA66A4", Offset = "0xCA66A4", VA = "0xCA66A4")]
		public static void FixedToConfigurable(FixedJoint src)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xCA67F0", Offset = "0xCA67F0", VA = "0xCA67F0")]
		public static void SpringToConfigurable(SpringJoint src)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xCA61B0", Offset = "0xCA61B0", VA = "0xCA61B0")]
		public static void CharacterToConfigurable(CharacterJoint src)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xCA6998", Offset = "0xCA6998", VA = "0xCA6998")]
		private static void ConvertJoint(ref ConfigurableJoint conf, Joint src)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xCA6AD0", Offset = "0xCA6AD0", VA = "0xCA6AD0")]
		private static SoftJointLimit ConvertToHighSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xCA6B8C", Offset = "0xCA6B8C", VA = "0xCA6B8C")]
		private static SoftJointLimit ConvertToLowSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xCA6B34", Offset = "0xCA6B34", VA = "0xCA6B34")]
		private static SoftJointLimitSpring ConvertToSoftJointLimitSpring(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimitSpring);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xCA6BF0", Offset = "0xCA6BF0", VA = "0xCA6BF0")]
		private static SoftJointLimit CopyLimit(SoftJointLimit src)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xCA6C50", Offset = "0xCA6C50", VA = "0xCA6C50")]
		private static SoftJointLimitSpring CopyLimitSpring(SoftJointLimitSpring src)
		{
			return default(SoftJointLimitSpring);
		}
	}
	[Token(Token = "0x200004B")]
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000AF")]
		public enum ColliderType
		{
			[Token(Token = "0x40004F8")]
			Box,
			[Token(Token = "0x40004F9")]
			Capsule
		}

		[Serializable]
		[Token(Token = "0x20000B0")]
		public enum JointType
		{
			[Token(Token = "0x40004FB")]
			Configurable,
			[Token(Token = "0x40004FC")]
			Character
		}

		[Serializable]
		[Token(Token = "0x20000B1")]
		public enum Direction
		{
			[Token(Token = "0x40004FE")]
			X,
			[Token(Token = "0x40004FF")]
			Y,
			[Token(Token = "0x4000500")]
			Z
		}

		[Token(Token = "0x20000B2")]
		public struct CreateJointParams
		{
			[Token(Token = "0x20000C5")]
			public struct Limits
			{
				[Token(Token = "0x400054F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float minSwing;

				[Token(Token = "0x4000550")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public float maxSwing;

				[Token(Token = "0x4000551")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public float swing2;

				[Token(Token = "0x4000552")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public float twist;

				[Token(Token = "0x600056D")]
				[Address(RVA = "0x63ABB8", Offset = "0x63ABB8", VA = "0x63ABB8")]
				public Limits(float minSwing, float maxSwing, float swing2, float twist)
				{
				}
			}

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody rigidbody;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rigidbody connectedBody;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform child;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 worldSwingAxis;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Limits limits;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public JointType type;

			[Token(Token = "0x600052D")]
			[Address(RVA = "0x63AB98", Offset = "0x63AB98", VA = "0x63AB98")]
			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type)
			{
			}
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xEA5564", Offset = "0xEA5564", VA = "0xEA5564")]
		public static void ClearAll(Transform root)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xEA5764", Offset = "0xEA5764", VA = "0xEA5764")]
		protected static void ClearTransform(Transform transform)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xEA5998", Offset = "0xEA5998", VA = "0xEA5998")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xEA5F14", Offset = "0xEA5F14", VA = "0xEA5F14")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xEA5D8C", Offset = "0xEA5D8C", VA = "0xEA5D8C")]
		protected static float GetScaleF(Transform t)
		{
			return default(float);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xEA630C", Offset = "0xEA630C", VA = "0xEA630C")]
		protected static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xEA633C", Offset = "0xEA633C", VA = "0xEA633C")]
		protected static void Vector3Abs(ref Vector3 v)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xEA63BC", Offset = "0xEA63BC", VA = "0xEA63BC")]
		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xEA6474", Offset = "0xEA6474", VA = "0xEA6474")]
		protected static Vector3 DirectionToVector3(Direction dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xEA5DBC", Offset = "0xEA5DBC", VA = "0xEA5DBC")]
		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xEA652C", Offset = "0xEA652C", VA = "0xEA652C")]
		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xEA6844", Offset = "0xEA6844", VA = "0xEA6844")]
		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xEA6A04", Offset = "0xEA6A04", VA = "0xEA6A04")]
		protected static void CreateJoint(CreateJointParams p)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xEA7024", Offset = "0xEA7024", VA = "0xEA7024")]
		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xEA7058", Offset = "0xEA7058", VA = "0xEA7058")]
		protected RagdollCreator()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x739100", Offset = "0x739100")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x739100", Offset = "0x739100")]
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B3")]
		public enum Mode
		{
			[Token(Token = "0x4000508")]
			Colliders,
			[Token(Token = "0x4000509")]
			Joints
		}

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Rigidbody selectedRigidbody;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Collider selectedCollider;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool symmetry;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public Mode mode;

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xEA708C", Offset = "0xEA708C", VA = "0xEA708C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EE60", Offset = "0x73EE60")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xEA70D8", Offset = "0xEA70D8", VA = "0xEA70D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EE98", Offset = "0x73EE98")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xEA7124", Offset = "0xEA7124", VA = "0xEA7124")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EED0", Offset = "0x73EED0")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xEA7170", Offset = "0xEA7170", VA = "0xEA7170")]
		public RagdollEditor()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x200004D")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		public class Offset
		{
			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x600052E")]
			[Address(RVA = "0xBCB074", Offset = "0xBCB074", VA = "0xBCB074")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0xBCB300", Offset = "0xBCB300", VA = "0xBCB300")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xBCAFA4", Offset = "0xBCAFA4", VA = "0xBCAFA4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xBCAFFC", Offset = "0xBCAFFC", VA = "0xBCAFFC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xBCB21C", Offset = "0xBCB21C", VA = "0xBCB21C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xBCB2F8", Offset = "0xBCB2F8", VA = "0xBCB2F8")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x739160", Offset = "0x739160")]
	public class AnimatorIKDemo : MonoBehaviour
	{
		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftHandIKTarget;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xBC4098", Offset = "0xBC4098", VA = "0xBC4098")]
		private void Start()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xBC40F0", Offset = "0xBC40F0", VA = "0xBC40F0")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xBC414C", Offset = "0xBC414C", VA = "0xBC414C")]
		public AnimatorIKDemo()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class BallShooter : MonoBehaviour
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode keyCode;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject ball;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 spawnOffset;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 force;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float mass;

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xBC4198", Offset = "0xBC4198", VA = "0xBC4198")]
		private void Update()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xBC4460", Offset = "0xBC4460", VA = "0xBC4460")]
		public BallShooter()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class BoardController : MonoBehaviour
	{
		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int groundLayer;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationTarget;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float torque;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float skidDrag;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float turnSensitivity;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody r;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isGrounded;

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xBC44FC", Offset = "0xBC44FC", VA = "0xBC44FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xBC4554", Offset = "0xBC4554", VA = "0xBC4554")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xBC4724", Offset = "0xBC4724", VA = "0xBC4724")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xBC4A48", Offset = "0xBC4A48", VA = "0xBC4A48")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xBC4AA4", Offset = "0xBC4AA4", VA = "0xBC4AA4")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xBC4B00", Offset = "0xBC4B00", VA = "0xBC4B00")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xBC4B58", Offset = "0xBC4B58", VA = "0xBC4B58")]
		public BoardController()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class CharacterAnimationMeleeDemo : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x17000058")]
		private CharacterMeleeDemo melee
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0xBC50C0", Offset = "0xBC50C0", VA = "0xBC50C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xBC5144", Offset = "0xBC5144", VA = "0xBC5144", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xBC565C", Offset = "0xBC565C", VA = "0xBC565C")]
		public CharacterAnimationMeleeDemo()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class CharacterMeleeDemo : CharacterPuppet
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		public class Action
		{
			[Serializable]
			[Token(Token = "0x20000C6")]
			public class Anim
			{
				[Token(Token = "0x4000553")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string stateName;

				[Token(Token = "0x4000554")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public int layer;

				[Token(Token = "0x4000555")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public float transitionDuration;

				[Token(Token = "0x4000556")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public float fixedTime;

				[Token(Token = "0x600056E")]
				[Address(RVA = "0xBC6E10", Offset = "0xBC6E10", VA = "0xBC6E10")]
				public Anim()
				{
				}
			}

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int inputActionIndex;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float duration;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float minFrequency;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Anim anim;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int[] requiredPropTypes;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Booster[] boosters;

			[Token(Token = "0x6000530")]
			[Address(RVA = "0xBC6E00", Offset = "0xBC6E00", VA = "0xBC6E00")]
			public Action()
			{
			}
		}

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73BE10", Offset = "0x73BE10")]
		public Action[] actions;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[HideInInspector]
		public int currentActionIndex;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		[HideInInspector]
		public float lastActionTime;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private float lastActionMoveMag;

		[Token(Token = "0x17000059")]
		public Action currentAction
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0xBC5610", Offset = "0xBC5610", VA = "0xBC5610")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xBC6864", Offset = "0xBC6864", VA = "0xBC6864", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xBC68EC", Offset = "0xBC68EC", VA = "0xBC68EC", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xBC6B78", Offset = "0xBC6B78", VA = "0xBC6B78")]
		private bool StartAction(Action action)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xBC6DF0", Offset = "0xBC6DF0", VA = "0xBC6DF0")]
		public CharacterMeleeDemo()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class CharacterPuppet : CharacterThirdPerson
	{
		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73BE68", Offset = "0x73BE68")]
		public PropMuscle propMuscle;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73BEA0", Offset = "0x73BEA0")]
		private BehaviourPuppet <puppet>k__BackingField;

		[Token(Token = "0x1700005A")]
		public BehaviourPuppet puppet
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0xBC6E18", Offset = "0xBC6E18", VA = "0xBC6E18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EF08", Offset = "0x73EF08")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xBC6E20", Offset = "0xBC6E20", VA = "0xBC6E20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EF18", Offset = "0x73EF18")]
			private set
			{
			}
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xBC6870", Offset = "0xBC6870", VA = "0xBC6870", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xBC6FAC", Offset = "0xBC6FAC", VA = "0xBC6FAC", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xBC7200", Offset = "0xBC7200", VA = "0xBC7200", Slot = "9")]
		protected override void Rotate()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xBC78C8", Offset = "0xBC78C8", VA = "0xBC78C8", Slot = "10")]
		protected override bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xBC6DFC", Offset = "0xBC6DFC", VA = "0xBC6DFC")]
		public CharacterPuppet()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class CreatePuppetInRuntime : MonoBehaviour
	{
		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BEB0", Offset = "0x73BEB0")]
		public Transform ragdollPrefab;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BEE8", Offset = "0x73BEE8")]
		public string instanceName;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BF20", Offset = "0x73BF20")]
		public int characterControllerLayer;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BF58", Offset = "0x73BF58")]
		public int ragdollLayer;

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xBC9A84", Offset = "0xBC9A84", VA = "0xBC9A84")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xBC9BDC", Offset = "0xBC9BDC", VA = "0xBC9BDC")]
		public CreatePuppetInRuntime()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class CreateRagdollInRuntime : MonoBehaviour
	{
		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BF90", Offset = "0x73BF90")]
		public GameObject prefab;

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xBC9C34", Offset = "0xBC9C34", VA = "0xBC9C34")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xBC9D78", Offset = "0xBC9D78", VA = "0xBC9D78")]
		private void Update()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xBC9D7C", Offset = "0xBC9D7C", VA = "0xBC9D7C")]
		public CreateRagdollInRuntime()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class DeathBaker : MonoBehaviour
	{
		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739318", Offset = "0x739318")]
		private sealed class <Bake>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DeathBaker <>4__this;

			[Token(Token = "0x1700008B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000534")]
				[Address(RVA = "0xBCA348", Offset = "0xBCA348", VA = "0xBCA348", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000536")]
				[Address(RVA = "0xBCA3B0", Offset = "0xBCA3B0", VA = "0xBCA3B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0xBCA16C", Offset = "0xBCA16C", VA = "0xBCA16C")]
			[DebuggerHidden]
			public <Bake>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000532")]
			[Address(RVA = "0xBCA284", Offset = "0xBCA284", VA = "0xBCA284", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0xBCA288", Offset = "0xBCA288", VA = "0xBCA288", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0xBCA350", Offset = "0xBCA350", VA = "0xBCA350", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739328", Offset = "0x739328")]
		private sealed class <FadeOutPinWeight>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DeathBaker <>4__this;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600053A")]
				[Address(RVA = "0xBCA604", Offset = "0xBCA604", VA = "0xBCA604", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600053C")]
				[Address(RVA = "0xBCA66C", Offset = "0xBCA66C", VA = "0xBCA66C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0xBCA198", Offset = "0xBCA198", VA = "0xBCA198")]
			[DebuggerHidden]
			public <FadeOutPinWeight>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0xBCA518", Offset = "0xBCA518", VA = "0xBCA518", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0xBCA51C", Offset = "0xBCA51C", VA = "0xBCA51C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600053B")]
			[Address(RVA = "0xBCA60C", Offset = "0xBCA60C", VA = "0xBCA60C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739338", Offset = "0x739338")]
		private sealed class <FadeOutMuscleWeight>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DeathBaker <>4__this;

			[Token(Token = "0x1700008F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000540")]
				[Address(RVA = "0xBCA4A8", Offset = "0xBCA4A8", VA = "0xBCA4A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000542")]
				[Address(RVA = "0xBCA510", Offset = "0xBCA510", VA = "0xBCA510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600053D")]
			[Address(RVA = "0xBCA1C4", Offset = "0xBCA1C4", VA = "0xBCA1C4")]
			[DebuggerHidden]
			public <FadeOutMuscleWeight>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600053E")]
			[Address(RVA = "0xBCA3B8", Offset = "0xBCA3B8", VA = "0xBCA3B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600053F")]
			[Address(RVA = "0xBCA3BC", Offset = "0xBCA3BC", VA = "0xBCA3BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000541")]
			[Address(RVA = "0xBCA4B0", Offset = "0xBCA4B0", VA = "0xBCA4B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BFC8", Offset = "0x73BFC8")]
		public HumanoidBaker baker;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C000", Offset = "0x73C000")]
		public float bakeTime;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C038", Offset = "0x73C038")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C070", Offset = "0x73C070")]
		public float fadeOutPinWeightSpeed;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C0A8", Offset = "0x73C0A8")]
		public float fadeOutMuscleWeightSpeed;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C0E0", Offset = "0x73C0E0")]
		public float deadMuscleWeight;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator animator;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool isDead;

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xBC9D84", Offset = "0xBC9D84", VA = "0xBC9D84")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xBC9E20", Offset = "0xBC9E20", VA = "0xBC9E20")]
		private void Update()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xBCA0FC", Offset = "0xBCA0FC", VA = "0xBCA0FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73EF28", Offset = "0x73EF28")]
		private IEnumerator Bake()
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xBCA01C", Offset = "0xBCA01C", VA = "0xBCA01C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73EF8C", Offset = "0x73EF8C")]
		private IEnumerator FadeOutPinWeight()
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xBCA08C", Offset = "0xBCA08C", VA = "0xBCA08C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73EFF0", Offset = "0x73EFF0")]
		private IEnumerator FadeOutMuscleWeight()
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xBCA1F0", Offset = "0xBCA1F0", VA = "0xBCA1F0")]
		public DeathBaker()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class Destructor : MonoBehaviour
	{
		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739348", Offset = "0x739348")]
		private sealed class <Destruct>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Destructor <>4__this;

			[Token(Token = "0x17000091")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000546")]
				[Address(RVA = "0xBCA83C", Offset = "0xBCA83C", VA = "0xBCA83C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000548")]
				[Address(RVA = "0xBCA8A4", Offset = "0xBCA8A4", VA = "0xBCA8A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000543")]
			[Address(RVA = "0xBCA710", Offset = "0xBCA710", VA = "0xBCA710")]
			[DebuggerHidden]
			public <Destruct>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0xBCA74C", Offset = "0xBCA74C", VA = "0xBCA74C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0xBCA750", Offset = "0xBCA750", VA = "0xBCA750", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000547")]
			[Address(RVA = "0xBCA844", Offset = "0xBCA844", VA = "0xBCA844", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float delay;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xBCA674", Offset = "0xBCA674", VA = "0xBCA674")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xBCA6A0", Offset = "0xBCA6A0", VA = "0xBCA6A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73F054", Offset = "0x73F054")]
		private IEnumerator Destruct()
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xBCA73C", Offset = "0xBCA73C", VA = "0xBCA73C")]
		public Destructor()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class Dying : MonoBehaviour
	{
		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739358", Offset = "0x739358")]
		private sealed class <FadeOutPinWeight>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x17000093")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600054C")]
				[Address(RVA = "0xBCAF34", Offset = "0xBCAF34", VA = "0xBCAF34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600054E")]
				[Address(RVA = "0xBCAF9C", Offset = "0xBCAF9C", VA = "0xBCAF9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000549")]
			[Address(RVA = "0xBCAC04", Offset = "0xBCAC04", VA = "0xBCAC04")]
			[DebuggerHidden]
			public <FadeOutPinWeight>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0xBCAE48", Offset = "0xBCAE48", VA = "0xBCAE48", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0xBCAE4C", Offset = "0xBCAE4C", VA = "0xBCAE4C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0xBCAF3C", Offset = "0xBCAF3C", VA = "0xBCAF3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739368", Offset = "0x739368")]
		private sealed class <FadeOutMuscleWeight>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x17000095")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000552")]
				[Address(RVA = "0xBCADD8", Offset = "0xBCADD8", VA = "0xBCADD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000554")]
				[Address(RVA = "0xBCAE40", Offset = "0xBCAE40", VA = "0xBCAE40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0xBCAC30", Offset = "0xBCAC30", VA = "0xBCAC30")]
			[DebuggerHidden]
			public <FadeOutMuscleWeight>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0xBCACE8", Offset = "0xBCACE8", VA = "0xBCACE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0xBCACEC", Offset = "0xBCACEC", VA = "0xBCACEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0xBCADE0", Offset = "0xBCADE0", VA = "0xBCADE0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C118", Offset = "0x73C118")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C150", Offset = "0x73C150")]
		public float fadeOutPinWeightSpeed;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C188", Offset = "0x73C188")]
		public float fadeOutMuscleWeightSpeed;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C1C0", Offset = "0x73C1C0")]
		public float deadMuscleWeight;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool isDead;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xBCA8AC", Offset = "0xBCA8AC", VA = "0xBCA8AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xBCA948", Offset = "0xBCA948", VA = "0xBCA948")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xBCAB24", Offset = "0xBCAB24", VA = "0xBCAB24")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73F0B8", Offset = "0x73F0B8")]
		private IEnumerator FadeOutPinWeight()
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xBCAB94", Offset = "0xBCAB94", VA = "0xBCAB94")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73F11C", Offset = "0x73F11C")]
		private IEnumerator FadeOutMuscleWeight()
		{
			return null;
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xBCAC5C", Offset = "0xBCAC5C", VA = "0xBCAC5C")]
		public Dying()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7391C4", Offset = "0x7391C4")]
	public class FXCollisionBlood : MonoBehaviour
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minCollisionImpulse;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int emission;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float emissionImpulseAdd;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int maxEmission;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem particles;

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xBCB308", Offset = "0xBCB308", VA = "0xBCB308")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xBCB3D8", Offset = "0xBCB3D8", VA = "0xBCB3D8")]
		private void OnCollisionImpulse(MuscleCollision m, float impulse)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xBCB694", Offset = "0xBCB694", VA = "0xBCB694")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xBCB784", Offset = "0xBCB784", VA = "0xBCB784")]
		public FXCollisionBlood()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class Grab : MonoBehaviour
	{
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C1F8", Offset = "0x73C1F8")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C230", Offset = "0x73C230")]
		public UserControlMelee userControl;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C268", Offset = "0x73C268")]
		public int grabLayer;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool grabbed;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Collider c;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BehaviourPuppet otherPuppet;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Collider otherCollider;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ConfigurableJoint joint;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float nextGrabTime;

		[Token(Token = "0x4000342")]
		private const float massMlp = 5f;

		[Token(Token = "0x4000343")]
		private const int solverIterationMlp = 10;

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xBCB7A4", Offset = "0xBCB7A4", VA = "0xBCB7A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xBCB814", Offset = "0xBCB814", VA = "0xBCB814")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xBCBBE4", Offset = "0xBCBBE4", VA = "0xBCBBE4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xBCBD10", Offset = "0xBCBD10", VA = "0xBCBD10")]
		public Grab()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class Killing : MonoBehaviour
	{
		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739378", Offset = "0x739378")]
		private sealed class <WaitKilllTime>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Killing <>4__this;

			[Token(Token = "0x17000097")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000558")]
				[Address(RVA = "0xBCC08C", Offset = "0xBCC08C", VA = "0xBCC08C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600055A")]
				[Address(RVA = "0xBCC0F4", Offset = "0xBCC0F4", VA = "0xBCC0F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0xBCBECC", Offset = "0xBCBECC", VA = "0xBCBECC")]
			[DebuggerHidden]
			public <WaitKilllTime>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0xBCBF44", Offset = "0xBCBF44", VA = "0xBCBF44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0xBCBF48", Offset = "0xBCBF48", VA = "0xBCBF48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0xBCC094", Offset = "0xBCC094", VA = "0xBCC094", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C2A0", Offset = "0x73C2A0")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C2D8", Offset = "0x73C2D8")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int killtim;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public NavMeshAgent agent;

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xBCBD18", Offset = "0xBCBD18", VA = "0xBCBD18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xBCBDE8", Offset = "0xBCBDE8", VA = "0xBCBDE8")]
		public void Kill()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xBCBE5C", Offset = "0xBCBE5C", VA = "0xBCBE5C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73F180", Offset = "0x73F180")]
		private IEnumerator WaitKilllTime()
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xBCBEF8", Offset = "0xBCBEF8", VA = "0xBCBEF8")]
		public Killing()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class LayerSetup : MonoBehaviour
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C310", Offset = "0x73C310")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C310", Offset = "0x73C310")]
		public Transform characterController;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C370", Offset = "0x73C370")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C370", Offset = "0x73C370")]
		public int characterControllerLayer;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C3D0", Offset = "0x73C3D0")]
		public int ragdollLayer;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C408", Offset = "0x73C408")]
		public LayerMask ignoreCollisionWithCharacterController;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C440", Offset = "0x73C440")]
		public LayerMask ignoreCollisionWithRagdoll;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PuppetMaster puppetMaster;

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xBCC0FC", Offset = "0xBCC0FC", VA = "0xBCC0FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xBCC2F8", Offset = "0xBCC2F8", VA = "0xBCC2F8")]
		public LayerSetup()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class Planet : MonoBehaviour
	{
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float mass;

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xBCCD14", Offset = "0xBCCD14", VA = "0xBCCD14")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xBCCDFC", Offset = "0xBCCDFC", VA = "0xBCCDFC")]
		public Planet()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class PlanetaryGravity : MonoBehaviour
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Planet planet;

		[Token(Token = "0x4000350")]
		private const float G = 6.672E-11f;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody _r;

		[Token(Token = "0x1700005B")]
		private Rigidbody r
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0xBCCE0C", Offset = "0xBCCE0C", VA = "0xBCCE0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xBCCEA4", Offset = "0xBCCEA4", VA = "0xBCCEA4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xBCCF84", Offset = "0xBCCF84", VA = "0xBCCF84")]
		private void ApplyGravity(Rigidbody r)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xBCD154", Offset = "0xBCD154", VA = "0xBCD154")]
		public PlanetaryGravity()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class PropDemo : MonoBehaviour
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C478", Offset = "0x73C478")]
		public PuppetMasterProp prop;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C4B0", Offset = "0x73C4B0")]
		public PropMuscle propMuscleLeft;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C4E8", Offset = "0x73C4E8")]
		public PropMuscle propMuscleRight;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C520", Offset = "0x73C520")]
		public bool pickUpOnAwake;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool right;

		[Token(Token = "0x1700005C")]
		private PropMuscle connectTo
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0xBCD198", Offset = "0xBCD198", VA = "0xBCD198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xBCD15C", Offset = "0xBCD15C", VA = "0xBCD15C")]
		private void Start()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xBCD1B4", Offset = "0xBCD1B4", VA = "0xBCD1B4")]
		private void Update()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xBCD274", Offset = "0xBCD274", VA = "0xBCD274")]
		public PropDemo()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class PropMelee : Prop
	{
		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739388", Offset = "0x739388")]
		private sealed class <Action>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropMelee <>4__this;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <additionalPinMuscleIndex>5__2;

			[Token(Token = "0x17000099")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600055E")]
				[Address(RVA = "0xC9672C", Offset = "0xC9672C", VA = "0xC9672C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000560")]
				[Address(RVA = "0xC96794", Offset = "0xC96794", VA = "0xC96794", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600055B")]
			[Address(RVA = "0xC964D8", Offset = "0xC964D8", VA = "0xC964D8")]
			[DebuggerHidden]
			public <Action>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0xC96504", Offset = "0xC96504", VA = "0xC96504", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600055D")]
			[Address(RVA = "0xC96508", Offset = "0xC96508", VA = "0xC96508", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600055F")]
			[Address(RVA = "0xC96734", Offset = "0xC96734", VA = "0xC96734", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73C558", Offset = "0x73C558")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C558", Offset = "0x73C558")]
		public CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C5B8", Offset = "0x73C5B8")]
		public BoxCollider boxCollider;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C5F0", Offset = "0x73C5F0")]
		public float actionColliderRadiusMlp;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C628", Offset = "0x73C628")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C628", Offset = "0x73C628")]
		public float actionAdditionalPinWeight;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C67C", Offset = "0x73C67C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C67C", Offset = "0x73C67C")]
		public float actionMassMlp;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C6D4", Offset = "0x73C6D4")]
		public Vector3 COMOffset;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float defaultColliderRadius;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float defaultMass;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float defaultAddMass;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Rigidbody r;

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xBCD284", Offset = "0xBCD284", VA = "0xBCD284")]
		public void StartAction(float duration)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xBCD2CC", Offset = "0xBCD2CC", VA = "0xBCD2CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73F1E4", Offset = "0x73F1E4")]
		public IEnumerator Action(float duration)
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xBCD34C", Offset = "0xBCD34C", VA = "0xBCD34C", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xBCD45C", Offset = "0xBCD45C", VA = "0xBCD45C", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xBCD4D4", Offset = "0xBCD4D4", VA = "0xBCD4D4", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xBCD54C", Offset = "0xBCD54C", VA = "0xBCD54C")]
		public PropMelee()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class PropPickUpTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMasterProp prop;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask characterLayers;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CharacterPuppet characterPuppet;

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xC9679C", Offset = "0xC9679C", VA = "0xC9679C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xC96920", Offset = "0xC96920", VA = "0xC96920")]
		public PropPickUpTrigger()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class PuppetBoard : MonoBehaviour
	{
		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C70C", Offset = "0x73C70C")]
		public Rigidbody target;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C744", Offset = "0x73C744")]
		public Transform bodyTargetPivot;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C77C", Offset = "0x73C77C")]
		public Transform bodyTarget;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xC96928", Offset = "0xC96928", VA = "0xC96928")]
		private void Start()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xC969D0", Offset = "0xC969D0", VA = "0xC969D0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xC96BF4", Offset = "0xC96BF4", VA = "0xC96BF4")]
		public PuppetBoard()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class PuppetMasterPropMelee : PuppetMasterProp
	{
		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739398", Offset = "0x739398")]
		private sealed class <Action>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMasterPropMelee <>4__this;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x1700009B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000564")]
				[Address(RVA = "0xC9700C", Offset = "0xC9700C", VA = "0xC9700C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000566")]
				[Address(RVA = "0xC97074", Offset = "0xC97074", VA = "0xC97074", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000561")]
			[Address(RVA = "0xC96CC4", Offset = "0xC96CC4", VA = "0xC96CC4")]
			[DebuggerHidden]
			public <Action>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000562")]
			[Address(RVA = "0xC96EFC", Offset = "0xC96EFC", VA = "0xC96EFC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000563")]
			[Address(RVA = "0xC96F00", Offset = "0xC96F00", VA = "0xC96F00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000565")]
			[Address(RVA = "0xC97014", Offset = "0xC97014", VA = "0xC97014", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73C7B4", Offset = "0x73C7B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C7B4", Offset = "0x73C7B4")]
		public CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C814", Offset = "0x73C814")]
		public BoxCollider boxCollider;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C84C", Offset = "0x73C84C")]
		public float actionColliderRadiusMlp;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C884", Offset = "0x73C884")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C884", Offset = "0x73C884")]
		public float actionAdditionalPinWeight;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C8D8", Offset = "0x73C8D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C8D8", Offset = "0x73C8D8")]
		public float actionMassMlp;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C92C", Offset = "0x73C92C")]
		public Vector3 COMOffset;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float defaultColliderRadius;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float defaultMass;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float defaultAdditionalPinWeight;

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xC96BFC", Offset = "0xC96BFC", VA = "0xC96BFC")]
		public void StartAction(float duration)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xC96C44", Offset = "0xC96C44", VA = "0xC96C44")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73F248", Offset = "0x73F248")]
		public IEnumerator Action(float duration)
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xC96CF0", Offset = "0xC96CF0", VA = "0xC96CF0", Slot = "7")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xC96D5C", Offset = "0xC96D5C", VA = "0xC96D5C", Slot = "4")]
		protected override void OnPickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xC96E80", Offset = "0xC96E80", VA = "0xC96E80", Slot = "5")]
		protected override void OnDrop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xC96EE4", Offset = "0xC96EE4", VA = "0xC96EE4")]
		public PuppetMasterPropMelee()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class PuppetScaling : MonoBehaviour
	{
		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C964", Offset = "0x73C964")]
		public float masterScale;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int muscleIndex;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C980", Offset = "0x73C980")]
		public float muscleScale;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float defaultMuscleSpring;

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xC9707C", Offset = "0xC9707C", VA = "0xC9707C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xC970BC", Offset = "0xC970BC", VA = "0xC970BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xC97458", Offset = "0xC97458", VA = "0xC97458")]
		public PuppetScaling()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class RaycastShooter : MonoBehaviour
	{
		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask layers;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unpin;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float force;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem blood;

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xC9746C", Offset = "0xC9746C", VA = "0xC9746C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xC9774C", Offset = "0xC9774C", VA = "0xC9774C")]
		public RaycastShooter()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class Respawning : MonoBehaviour
	{
		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C99C", Offset = "0x73C99C")]
		public Transform pool;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C9D4", Offset = "0x73C9D4")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CA0C", Offset = "0x73CA0C")]
		public string idleAnimation;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform puppetRoot;

		[Token(Token = "0x1700005D")]
		private bool isPooled
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0xC9775C", Offset = "0xC9775C", VA = "0xC9775C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xC977F4", Offset = "0xC977F4", VA = "0xC977F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xC97854", Offset = "0xC97854", VA = "0xC97854")]
		private void Update()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xC97A38", Offset = "0xC97A38", VA = "0xC97A38")]
		private void Pool()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xC97A5C", Offset = "0xC97A5C", VA = "0xC97A5C")]
		private void Respawn(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xC98364", Offset = "0xC98364", VA = "0xC98364")]
		public Respawning()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class RotateShoulderToTarget : MonoBehaviour
	{
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform shoulder;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 euler;

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xC9836C", Offset = "0xC9836C", VA = "0xC9836C")]
		private void OnPuppetMasterRead()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xC98454", Offset = "0xC98454", VA = "0xC98454")]
		public RotateShoulderToTarget()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class SkeletonDisconnector : MonoBehaviour
	{
		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Skeleton skeleton;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MuscleDisconnectMode disconnectMuscleMode;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask layers;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float unpin;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float force;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParticleSystem particles;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PropMuscle propMuscle;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PuppetMasterProp prop;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xC98DF0", Offset = "0xC98DF0", VA = "0xC98DF0")]
		private void Update()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xC992BC", Offset = "0xC992BC", VA = "0xC992BC")]
		public SkeletonDisconnector()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class SkeletonShooter : MonoBehaviour
	{
		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Skeleton skeleton;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MuscleRemoveMode removeMuscleMode;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask layers;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float unpin;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float force;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParticleSystem particles;

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xC992CC", Offset = "0xC992CC", VA = "0xC992CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xC99718", Offset = "0xC99718", VA = "0xC99718")]
		public SkeletonShooter()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class UserControlAIMelee : UserControlThirdPerson
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourPuppet targetPuppet;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isAttacking;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float attackTimer;

		[Token(Token = "0x1700005E")]
		private Transform moveTarget
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0xC99B88", Offset = "0xC99B88", VA = "0xC99B88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xC99BDC", Offset = "0xC99BDC", VA = "0xC99BDC", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xC99E8C", Offset = "0xC99E8C", VA = "0xC99E8C")]
		private bool CanAttack()
		{
			return default(bool);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xC9A0A0", Offset = "0xC9A0A0", VA = "0xC9A0A0")]
		public UserControlAIMelee()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class UserControlMelee : UserControlThirdPerson
	{
		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public KeyCode hitKey;

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xC9A0BC", Offset = "0xC9A0BC", VA = "0xC9A0BC", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xC9A454", Offset = "0xC9A454", VA = "0xC9A454")]
		public UserControlMelee()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x1700005F")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0xBC4BA0", Offset = "0xBC4BA0", VA = "0xBC4BA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xBC4B7C", Offset = "0xBC4B7C", VA = "0xBC4B7C", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xBC4BA8", Offset = "0xBC4BA8", VA = "0xBC4BA8")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xBC4C6C", Offset = "0xBC4C6C", VA = "0xBC4C6C", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xBC4DE4", Offset = "0xBC4DE4", VA = "0xBC4DE4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xBC5098", Offset = "0xBC5098", VA = "0xBC5098", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xBC4DF4", Offset = "0xBC4DF4", VA = "0xBC4DF4")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xBC50A8", Offset = "0xBC50A8", VA = "0xBC50A8")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xBC56A4", Offset = "0xBC56A4", VA = "0xBC56A4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xBC5704", Offset = "0xBC5704", VA = "0xBC5704", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xBC5830", Offset = "0xBC5830", VA = "0xBC5830")]
		private void Update()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xBC59AC", Offset = "0xBC59AC", VA = "0xBC59AC")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73CA74", Offset = "0x73CA74")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40003A8")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40003A9")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x17000060")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0xBC5A64", Offset = "0xBC5A64", VA = "0xBC5A64", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xBC59C4", Offset = "0xBC59C4", VA = "0xBC59C4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xBC5A48", Offset = "0xBC5A48", VA = "0xBC5A48", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xBC5240", Offset = "0xBC5240", VA = "0xBC5240", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xBC5B54", Offset = "0xBC5B54", VA = "0xBC5B54")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xBC5680", Offset = "0xBC5680", VA = "0xBC5680")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CAB8", Offset = "0x73CAB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CAB8", Offset = "0x73CAB8")]
		public Transform gravityTarget;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CB18", Offset = "0x73CB18")]
		public float gravityMultiplier;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40003B7")]
		protected const float half = 0.5f;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000449")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xBC5D08", Offset = "0xBC5D08", VA = "0xBC5D08")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xBC5E8C", Offset = "0xBC5E8C", VA = "0xBC5E8C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xBC6024", Offset = "0xBC6024", VA = "0xBC6024", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xBC629C", Offset = "0xBC629C", VA = "0xBC629C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xBC6360", Offset = "0xBC6360", VA = "0xBC6360")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xBC6548", Offset = "0xBC6548", VA = "0xBC6548")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xBC66F8", Offset = "0xBC66F8", VA = "0xBC66F8")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xBC671C", Offset = "0xBC671C", VA = "0xBC671C")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xBC6740", Offset = "0xBC6740", VA = "0xBC6740")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xBC6844", Offset = "0xBC6844", VA = "0xBC6844")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x20000BF")]
		public enum MoveMode
		{
			[Token(Token = "0x4000534")]
			Directional,
			[Token(Token = "0x4000535")]
			Strafe
		}

		[Token(Token = "0x20000C0")]
		public struct AnimState
		{
			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7393A8", Offset = "0x7393A8")]
		private sealed class <JumpSmooth>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x1700009D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600056A")]
				[Address(RVA = "0xBC9A14", Offset = "0xBC9A14", VA = "0xBC9A14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600056C")]
				[Address(RVA = "0xBC9A7C", Offset = "0xBC9A7C", VA = "0xBC9A7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000567")]
			[Address(RVA = "0xBC98A8", Offset = "0xBC98A8", VA = "0xBC98A8")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x6000568")]
			[Address(RVA = "0xBC98D4", Offset = "0xBC98D4", VA = "0xBC98D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000569")]
			[Address(RVA = "0xBC98D8", Offset = "0xBC98D8", VA = "0xBC98D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600056B")]
			[Address(RVA = "0xBC9A1C", Offset = "0xBC9A1C", VA = "0xBC9A1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CB50", Offset = "0x73CB50")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CB88", Offset = "0x73CB88")]
		public MoveMode moveMode;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CBC0", Offset = "0x73CBC0")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CBF8", Offset = "0x73CBF8")]
		public bool smoothJump;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CC30", Offset = "0x73CC30")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CC68", Offset = "0x73CC68")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CCA0", Offset = "0x73CCA0")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x17000061")]
		public bool onGround
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0xBC7C3C", Offset = "0xBC7C3C", VA = "0xBC7C3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F2AC", Offset = "0x73F2AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0xBC7C44", Offset = "0xBC7C44", VA = "0xBC7C44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F2BC", Offset = "0x73F2BC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xBC6E28", Offset = "0xBC6E28", VA = "0xBC6E28", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xBC7C50", Offset = "0xBC7C50", VA = "0xBC7C50")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xBC70B0", Offset = "0xBC70B0", VA = "0xBC70B0", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xBC7CE0", Offset = "0xBC7CE0", VA = "0xBC7CE0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xBC6D14", Offset = "0xBC6D14", VA = "0xBC6D14", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xBC8F18", Offset = "0xBC8F18", VA = "0xBC8F18", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xBC82F0", Offset = "0xBC82F0", VA = "0xBC82F0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xBC8FF8", Offset = "0xBC8FF8", VA = "0xBC8FF8")]
		private void WallRun()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xBC95E8", Offset = "0xBC95E8", VA = "0xBC95E8")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xBC8C5C", Offset = "0xBC8C5C", VA = "0xBC8C5C")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xBC7458", Offset = "0xBC7458", VA = "0xBC7458", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xBC9688", Offset = "0xBC9688", VA = "0xBC9688")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xBC78F0", Offset = "0xBC78F0", VA = "0xBC78F0", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xBC9814", Offset = "0xBC9814", VA = "0xBC9814")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73F2CC", Offset = "0x73F2CC")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xBC883C", Offset = "0xBC883C", VA = "0xBC883C")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xBC7B08", Offset = "0xBC7B08", VA = "0xBC7B08")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C2")]
		public enum RotationMode
		{
			[Token(Token = "0x4000544")]
			Smooth,
			[Token(Token = "0x4000545")]
			Linear
		}

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CCB0", Offset = "0x73CCB0")]
		public CameraController cameraController;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CCE8", Offset = "0x73CCE8")]
		public float accelerationTime;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CD20", Offset = "0x73CD20")]
		public float turnTime;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CD58", Offset = "0x73CD58")]
		public bool walkByDefault;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CD90", Offset = "0x73CD90")]
		public RotationMode rotationMode;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CDC8", Offset = "0x73CDC8")]
		public float moveSpeed;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CE00", Offset = "0x73CE00")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000062")]
		public bool isGrounded
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0xC9845C", Offset = "0xC9845C", VA = "0xC9845C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F330", Offset = "0x73F330")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000467")]
			[Address(RVA = "0xC98464", Offset = "0xC98464", VA = "0xC98464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F340", Offset = "0x73F340")]
			private set
			{
			}
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xC98470", Offset = "0xC98470", VA = "0xC98470")]
		private void Start()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xC984F8", Offset = "0xC984F8", VA = "0xC984F8")]
		private void Update()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xC98BF4", Offset = "0xC98BF4", VA = "0xC98BF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xC9854C", Offset = "0xC9854C", VA = "0xC9854C")]
		private void Rotate()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xC9894C", Offset = "0xC9894C", VA = "0xC9894C")]
		private void Move()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xC98C30", Offset = "0xC98C30", VA = "0xC98C30")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xC98D28", Offset = "0xC98D28", VA = "0xC98D28")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xC98DC8", Offset = "0xC98DC8", VA = "0xC98DC8")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xC99820", Offset = "0xC99820", VA = "0xC99820", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xC9989C", Offset = "0xC9989C", VA = "0xC9989C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xC99B34", Offset = "0xC99B34", VA = "0xC99B34")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xC99B5C", Offset = "0xC99B5C", VA = "0xC99B5C")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x20000C3")]
		public struct State
		{
			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xC99864", Offset = "0xC99864", VA = "0xC99864", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xC9A0F0", Offset = "0xC9A0F0", VA = "0xC9A0F0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xC99B78", Offset = "0xC99B78", VA = "0xC99B78")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000477")]
		[Address(RVA = "0xBC4154", Offset = "0xBC4154", VA = "0xBC4154")]
		private void Update()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xBC4190", Offset = "0xBC4190", VA = "0xBC4190")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xC99728", Offset = "0xC99728", VA = "0xC99728")]
		private void Update()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xC9975C", Offset = "0xC9975C", VA = "0xC9975C")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xC9980C", Offset = "0xC9980C", VA = "0xC9980C")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class Navigator
	{
		[Token(Token = "0x20000C4")]
		public enum State
		{
			[Token(Token = "0x400054C")]
			Idle,
			[Token(Token = "0x400054D")]
			Seeking,
			[Token(Token = "0x400054E")]
			OnPath
		}

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CE10", Offset = "0x73CE10")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CE48", Offset = "0x73CE48")]
		public float cornerRadius;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CE80", Offset = "0x73CE80")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CEB8", Offset = "0x73CEB8")]
		public float maxSampleDistance;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CEF0", Offset = "0x73CEF0")]
		public float nextPathInterval;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CF28", Offset = "0x73CF28")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CF38", Offset = "0x73CF38")]
		private State <state>k__BackingField;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x17000063")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0xBCC300", Offset = "0xBCC300", VA = "0xBCC300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F350", Offset = "0x73F350")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0xBCC30C", Offset = "0xBCC30C", VA = "0xBCC30C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F360", Offset = "0x73F360")]
			private set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public State state
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0xBCC318", Offset = "0xBCC318", VA = "0xBCC318")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F370", Offset = "0x73F370")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0xBCC320", Offset = "0xBCC320", VA = "0xBCC320")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F380", Offset = "0x73F380")]
			private set
			{
			}
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xBCC328", Offset = "0xBCC328", VA = "0xBCC328")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xBCC3FC", Offset = "0xBCC3FC", VA = "0xBCC3FC")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xBCC940", Offset = "0xBCC940", VA = "0xBCC940")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xBCC9B0", Offset = "0xBCC9B0", VA = "0xBCC9B0")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xBCC808", Offset = "0xBCC808", VA = "0xBCC808")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xBCC87C", Offset = "0xBCC87C", VA = "0xBCC87C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xBCCAF8", Offset = "0xBCCAF8", VA = "0xBCCAF8")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xBCCCA8", Offset = "0xBCCCA8", VA = "0xBCCCA8")]
		public Navigator()
		{
		}
	}
}
