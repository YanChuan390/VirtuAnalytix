using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using RayFire;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class NewBarricadeZombie : NewNormalZombie
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float barricadeHealth;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject barricade1;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isHaveBarricade;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float barricadeMaxHealth;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x12C3BAC", Offset = "0x12C3BAC", VA = "0x12C3BAC", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x12C3CBC", Offset = "0x12C3CBC", VA = "0x12C3CBC", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x12C3D2C", Offset = "0x12C3D2C", VA = "0x12C3D2C", Slot = "6")]
	public override void Attack()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x12C3DE8", Offset = "0x12C3DE8", VA = "0x12C3DE8", Slot = "7")]
	public override void TakeDamage(float damage, bool freeze = false)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x12C3F74", Offset = "0x12C3F74", VA = "0x12C3F74")]
	private void Dead()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x12C4268", Offset = "0x12C4268", VA = "0x12C4268")]
	public NewBarricadeZombie()
	{
	}
}
[Token(Token = "0x2000003")]
public class NewNormalZombie : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float health;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected float maxHealth;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float damage;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float attackRange;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material[] normalMats;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material[] freezeMats;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Animator animator;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected float freezeTimer;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float freezeDuration;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected bool dead;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Renderer renderer;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected bool isFrozen;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x12C3BD4", Offset = "0x12C3BD4", VA = "0x12C3BD4", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x12C3CC0", Offset = "0x12C3CC0", VA = "0x12C3CC0", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x12C4290", Offset = "0x12C4290", VA = "0x12C4290")]
	protected void MoveTowardTarget()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x12C3D30", Offset = "0x12C3D30", VA = "0x12C3D30", Slot = "6")]
	public virtual void Attack()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x12C4570", Offset = "0x12C4570", VA = "0x12C4570", Slot = "7")]
	public virtual void TakeDamage(float damage, bool freeze = false)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x12C4054", Offset = "0x12C4054", VA = "0x12C4054")]
	protected void Freeze()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x12C4530", Offset = "0x12C4530", VA = "0x12C4530")]
	protected void Unfreeze()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x12C40B4", Offset = "0x12C40B4", VA = "0x12C40B4")]
	protected void ChangeFreezeMaterial(bool isFreeze)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x12C4280", Offset = "0x12C4280", VA = "0x12C4280")]
	public NewNormalZombie()
	{
	}
}
[Token(Token = "0x2000004")]
public class ZombieCameraLogic : MonoBehaviour
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform m_target;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_distance;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float m_height;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float m_lookAtAroundAngle;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x12D6A18", Offset = "0x12D6A18", VA = "0x12D6A18")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x12D6BC8", Offset = "0x12D6BC8", VA = "0x12D6BC8")]
	public ZombieCameraLogic()
	{
	}
}
[Token(Token = "0x2000005")]
public class ZombieCharacterControl : MonoBehaviour
{
	[Token(Token = "0x2000006")]
	private enum ControlMode
	{
		[Token(Token = "0x4000020")]
		Tank,
		[Token(Token = "0x4000021")]
		Direct
	}

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_moveSpeed;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_turnSpeed;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator m_animator;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rigidbody m_rigidBody;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ControlMode m_controlMode;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float m_currentV;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_currentH;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private readonly float m_interpolation;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 m_currentDirection;

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x12D6BE4", Offset = "0x12D6BE4", VA = "0x12D6BE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x12D6CE4", Offset = "0x12D6CE4", VA = "0x12D6CE4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x12D7064", Offset = "0x12D7064", VA = "0x12D7064")]
	private void TankUpdate()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x12D6D8C", Offset = "0x12D6D8C", VA = "0x12D6D8C")]
	private void DirectUpdate()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x12D723C", Offset = "0x12D723C", VA = "0x12D723C")]
	public ZombieCharacterControl()
	{
	}
}
[Token(Token = "0x2000007")]
public class ZombieFree : MonoBehaviour
{
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly string[] m_animations;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Animator[] m_animators;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ZombieCameraLogic m_cameraLogic;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x12D7284", Offset = "0x12D7284", VA = "0x12D7284")]
	private void Start()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x12D7308", Offset = "0x12D7308", VA = "0x12D7308")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x12D78F8", Offset = "0x12D78F8", VA = "0x12D78F8")]
	public ZombieFree()
	{
	}
}
[Token(Token = "0x2000008")]
public class dilei : MonoBehaviour
{
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FCE0", Offset = "0x60FCE0")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Collider collider;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public dilei <>4__this;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x12D7D94", Offset = "0x12D7D94", VA = "0x12D7D94")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x12E3444", Offset = "0x12E3444", VA = "0x12E3444")]
		internal void <MineExplode>b__0(GameObject obj)
		{
		}
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x12D7A78", Offset = "0x12D7A78", VA = "0x12D7A78")]
	private void Update()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x12D7BB4", Offset = "0x12D7BB4", VA = "0x12D7BB4")]
	private void MineExplode()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x12D7D9C", Offset = "0x12D7D9C", VA = "0x12D7D9C")]
	public dilei()
	{
	}
}
[Token(Token = "0x200000A")]
public class icepaota : BasePlant
{
	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform brain;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform detectedZombie;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float detectionRange;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float detectionAngle;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float fireTimer;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float fireRate;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject iceSpray;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform iceEndPoint;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float damage;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform shakeObj;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x12D8014", Offset = "0x12D8014", VA = "0x12D8014", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x12D808C", Offset = "0x12D808C", VA = "0x12D808C", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x12D872C", Offset = "0x12D872C", VA = "0x12D872C", Slot = "6")]
	public override bool TakeDamage(float damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x12D85B0", Offset = "0x12D85B0", VA = "0x12D85B0")]
	private void IceDamage()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x12D838C", Offset = "0x12D838C", VA = "0x12D838C")]
	private void RotateToFaceZombie(Transform detectedZombie)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x12D84D4", Offset = "0x12D84D4", VA = "0x12D84D4")]
	private bool IsFacingZombie(Transform detectedZombie)
	{
		return default(bool);
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x12D8210", Offset = "0x12D8210", VA = "0x12D8210")]
	private Transform DetectZombiesInRange()
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x12D88F4", Offset = "0x12D88F4", VA = "0x12D88F4")]
	public icepaota()
	{
	}
}
[Token(Token = "0x200000B")]
public class luzhang : BasePlant
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float maxHealth;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform shakeObj;

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x12D8910", Offset = "0x12D8910", VA = "0x12D8910", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x12D891C", Offset = "0x12D891C", VA = "0x12D891C", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x12D89A0", Offset = "0x12D89A0", VA = "0x12D89A0", Slot = "6")]
	public override bool TakeDamage(float damage)
	{
		return default(bool);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x12D8B50", Offset = "0x12D8B50", VA = "0x12D8B50")]
	public luzhang()
	{
	}
}
[Token(Token = "0x200000C")]
public class paodan : MonoBehaviour
{
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float damage;

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x12D8B58", Offset = "0x12D8B58", VA = "0x12D8B58")]
	private void Start()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x12D8BAC", Offset = "0x12D8BAC", VA = "0x12D8BAC")]
	private void Update()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x12D8C44", Offset = "0x12D8C44", VA = "0x12D8C44")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x12D8D9C", Offset = "0x12D8D9C", VA = "0x12D8D9C")]
	private void PushBullet()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x12D8E34", Offset = "0x12D8E34", VA = "0x12D8E34")]
	public paodan()
	{
	}
}
[Token(Token = "0x200000D")]
public class paota : BasePlant
{
	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform bulletSpawnPoint;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform brain;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform detectedZombie;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float detectionRange;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float detectionAngle;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float fireTimer;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float fireRate;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform shakeObj;

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x12D8E3C", Offset = "0x12D8E3C", VA = "0x12D8E3C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x12D8EB4", Offset = "0x12D8EB4", VA = "0x12D8EB4", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x12D94C0", Offset = "0x12D94C0", VA = "0x12D94C0", Slot = "6")]
	public override bool TakeDamage(float damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x12D929C", Offset = "0x12D929C", VA = "0x12D929C")]
	private void RotateToFaceZombie(Transform detectedZombie)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x12D93E4", Offset = "0x12D93E4", VA = "0x12D93E4")]
	private bool IsFacingZombie(Transform detectedZombie)
	{
		return default(bool);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x12D9120", Offset = "0x12D9120", VA = "0x12D9120")]
	private Transform DetectZombiesInRange()
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x12D9688", Offset = "0x12D9688", VA = "0x12D9688")]
	public paota()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x12D96A4", Offset = "0x12D96A4", VA = "0x12D96A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x610174", Offset = "0x610174")]
	private void <Update>b__9_0(GameObject o)
	{
	}
}
[Token(Token = "0x200000E")]
public class taiyangneng : BasePlant
{
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float minSunSpawnTime;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float maxSunSpawnTime;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float nextSunSpawnTime;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform shakeObj;

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x12D9750", Offset = "0x12D9750", VA = "0x12D9750", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x12D97E8", Offset = "0x12D97E8", VA = "0x12D97E8", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x12D9900", Offset = "0x12D9900", VA = "0x12D9900", Slot = "6")]
	public override bool TakeDamage(float damage)
	{
		return default(bool);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x12D97A0", Offset = "0x12D97A0", VA = "0x12D97A0")]
	private void SetNextSunSpawnTime()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x12D98B8", Offset = "0x12D98B8", VA = "0x12D98B8")]
	private void SpawnSun()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x12D9970", Offset = "0x12D9970", VA = "0x12D9970")]
	public taiyangneng()
	{
	}
}
[Token(Token = "0x200000F")]
public class AutoPushObj : MonoBehaviour
{
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float pushTimer;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x12A5784", Offset = "0x12A5784", VA = "0x12A5784")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x12A57D8", Offset = "0x12A57D8", VA = "0x12A57D8")]
	private void PushObj()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x12A5864", Offset = "0x12A5864", VA = "0x12A5864")]
	public AutoPushObj()
	{
	}
}
[Token(Token = "0x2000010")]
public class BarricadeZombie : BaseZombie
{
	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FCF0", Offset = "0x60FCF0")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BarricadeZombie <>4__this;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float damage;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x12D9984", Offset = "0x12D9984", VA = "0x12D9984")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x12D998C", Offset = "0x12D998C", VA = "0x12D998C")]
		internal void <TakeDamage>b__0(GameObject obj)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x12D9AD0", Offset = "0x12D9AD0", VA = "0x12D9AD0")]
		internal void <TakeDamage>b__1(GameObject obj)
		{
		}
	}

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float barricadeHealth;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject barricade1;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject barricade2;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject barricade3;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool isHaveBarricade;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float barricadeMaxHealth;

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x12A586C", Offset = "0x12A586C", VA = "0x12A586C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x12A5980", Offset = "0x12A5980", VA = "0x12A5980", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x12A59F0", Offset = "0x12A59F0", VA = "0x12A59F0", Slot = "6")]
	public override void Attack()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x12A5AAC", Offset = "0x12A5AAC", VA = "0x12A5AAC", Slot = "7")]
	public override void TakeDamage(float damage, bool freeze = false)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x12A5DEC", Offset = "0x12A5DEC", VA = "0x12A5DEC")]
	private void Dead()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x12A6190", Offset = "0x12A6190", VA = "0x12A6190")]
	public BarricadeZombie()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x12A61B8", Offset = "0x12A61B8", VA = "0x12A61B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x610184", Offset = "0x610184")]
	private void <Dead>b__10_0(GameObject obj)
	{
	}
}
[Token(Token = "0x2000012")]
public class BasePlant : MonoBehaviour
{
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float health;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected Animator animator;

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x12A63D4", Offset = "0x12A63D4", VA = "0x12A63D4", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x12A6430", Offset = "0x12A6430", VA = "0x12A6430", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x12A6434", Offset = "0x12A6434", VA = "0x12A6434", Slot = "6")]
	public virtual bool TakeDamage(float damage)
	{
		return default(bool);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x12A65A8", Offset = "0x12A65A8", VA = "0x12A65A8")]
	public BasePlant()
	{
	}
}
[Token(Token = "0x2000013")]
public class BaseZombie : MonoBehaviour
{
	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FD00", Offset = "0x60FD00")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BaseZombie <>4__this;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float damage;

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x12D9BC0", Offset = "0x12D9BC0", VA = "0x12D9BC0")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x12D9BC8", Offset = "0x12D9BC8", VA = "0x12D9BC8")]
		internal void <TakeDamage>b__0(GameObject obj)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x12D9CB8", Offset = "0x12D9CB8", VA = "0x12D9CB8")]
		internal void <TakeDamage>b__1(GameObject obj)
		{
		}
	}

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float health;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected float maxHealth;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float damage;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float attackRange;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material[] normalMats;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material[] freezeMats;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform arm;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform head;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Animator animator;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Renderer renderer;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected float freezeTimer;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float freezeDuration;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected bool isFrozen;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	protected bool armDetached;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	protected bool dead;

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x12A5894", Offset = "0x12A5894", VA = "0x12A5894", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x12A5984", Offset = "0x12A5984", VA = "0x12A5984", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x12A65B0", Offset = "0x12A65B0", VA = "0x12A65B0")]
	protected void MoveTowardTarget()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x12A59F4", Offset = "0x12A59F4", VA = "0x12A59F4", Slot = "6")]
	public virtual void Attack()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x12A6890", Offset = "0x12A6890", VA = "0x12A6890", Slot = "7")]
	public virtual void TakeDamage(float damage, bool freeze = false)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x12A5F7C", Offset = "0x12A5F7C", VA = "0x12A5F7C")]
	protected void Freeze()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x12A6850", Offset = "0x12A6850", VA = "0x12A6850")]
	protected void Unfreeze()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x12A5FDC", Offset = "0x12A5FDC", VA = "0x12A5FDC")]
	protected void ChangeFreezeMaterial(bool isFreeze)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x12A61A8", Offset = "0x12A61A8", VA = "0x12A61A8")]
	public BaseZombie()
	{
	}
}
[Token(Token = "0x2000015")]
public class Brain : BasePlant
{
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x12A7AD4", Offset = "0x12A7AD4", VA = "0x12A7AD4", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x12A7AD8", Offset = "0x12A7AD8", VA = "0x12A7AD8", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x12A7ADC", Offset = "0x12A7ADC", VA = "0x12A7ADC", Slot = "6")]
	public override bool TakeDamage(float damage)
	{
		return default(bool);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x12A7B84", Offset = "0x12A7B84", VA = "0x12A7B84")]
	public Brain()
	{
	}
}
[Token(Token = "0x2000016")]
public class BucketZombie : BaseZombie
{
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FD10", Offset = "0x60FD10")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BucketZombie <>4__this;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float damage;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x12DA93C", Offset = "0x12DA93C", VA = "0x12DA93C")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x12DA944", Offset = "0x12DA944", VA = "0x12DA944")]
		internal void <TakeDamage>b__0(GameObject obj)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x12DAA6C", Offset = "0x12DAA6C", VA = "0x12DAA6C")]
		internal void <TakeDamage>b__1(GameObject obj)
		{
		}
	}

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float bucketHealth;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject bucket1;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject bucket2;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject bucket3;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool isHaveBucket;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float bucketMaxHealth;

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x12A7B8C", Offset = "0x12A7B8C", VA = "0x12A7B8C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x12A7BB4", Offset = "0x12A7BB4", VA = "0x12A7BB4", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x12A7BB8", Offset = "0x12A7BB8", VA = "0x12A7BB8", Slot = "6")]
	public override void Attack()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x12A7BBC", Offset = "0x12A7BBC", VA = "0x12A7BBC", Slot = "7")]
	public override void TakeDamage(float damage, bool freeze = false)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x12A7EB0", Offset = "0x12A7EB0", VA = "0x12A7EB0")]
	private void Dead()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x12A8040", Offset = "0x12A8040", VA = "0x12A8040")]
	public BucketZombie()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x12A8058", Offset = "0x12A8058", VA = "0x12A8058")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x610194", Offset = "0x610194")]
	private void <Dead>b__10_0(GameObject obj)
	{
	}
}
[Token(Token = "0x2000018")]
public class CalibrationPanel : BasePanel
{
	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PVZ_MR_InputManager inputManager;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject brainContainer;

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x12A8118", Offset = "0x12A8118", VA = "0x12A8118")]
	private void Start()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x12A8138", Offset = "0x12A8138", VA = "0x12A8138")]
	private void Update()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x12A813C", Offset = "0x12A813C", VA = "0x12A813C", Slot = "5")]
	protected override void OnClick(string btnName)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x12A830C", Offset = "0x12A830C", VA = "0x12A830C")]
	public CalibrationPanel()
	{
	}
}
[Token(Token = "0x2000019")]
public class CanvasController : SingletonMono<CanvasController>
{
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FD20", Offset = "0x60FD20")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 randomPosition;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x12DAB5C", Offset = "0x12DAB5C", VA = "0x12DAB5C")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x12DAB64", Offset = "0x12DAB64", VA = "0x12DAB64")]
		internal void <Update>b__0(GameObject obj)
		{
		}
	}

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform brainContainer;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform cloestPlant;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float spawnRadius;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float spawnInterval;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public PVZ_MR_InputManager inputManager;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TMP_Text totalSun;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TMP_Text sf;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TMP_Text ps;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TMP_Text ips;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TMP_Text nw;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TMP_Text pm;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Collider sf_c;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Collider ps_c;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Collider ips_c;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Collider nw_c;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Collider pm_c;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int sunshine;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float sunTimer;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool isSpawnSun;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float zombieTimer;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool isSpawnZombie;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private int zombieCount;

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x12A8FF4", Offset = "0x12A8FF4", VA = "0x12A8FF4")]
	private void Start()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x12A8FF8", Offset = "0x12A8FF8", VA = "0x12A8FF8")]
	private void Update()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x12A9750", Offset = "0x12A9750", VA = "0x12A9750")]
	public void GameStart()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x12A97AC", Offset = "0x12A97AC", VA = "0x12A97AC")]
	public void GameOver()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x12A97B0", Offset = "0x12A97B0", VA = "0x12A97B0")]
	private void ZombieEnter()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x12A97BC", Offset = "0x12A97BC", VA = "0x12A97BC")]
	public CanvasController()
	{
	}
}
[Token(Token = "0x200001B")]
public class DisclaimerPanel : BasePanel
{
	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject calibrationPanel;

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x12AAFEC", Offset = "0x12AAFEC", VA = "0x12AAFEC", Slot = "5")]
	protected override void OnClick(string btnName)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x12AB0D0", Offset = "0x12AB0D0", VA = "0x12AB0D0")]
	public DisclaimerPanel()
	{
	}
}
[Token(Token = "0x200001C")]
public class DrawLineRenderer : MonoBehaviour
{
	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform Point1;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform Point2;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform Point3;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LineRenderer linerenderer;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float vertexCount;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float Point2Ypositio;

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x12AB0D4", Offset = "0x12AB0D4", VA = "0x12AB0D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x12AB0D8", Offset = "0x12AB0D8", VA = "0x12AB0D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x12AB448", Offset = "0x12AB448", VA = "0x12AB448")]
	public DrawLineRenderer()
	{
	}
}
[Token(Token = "0x200001D")]
public class GameManager : BaseManager<GameManager>
{
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x12AC530", Offset = "0x12AC530", VA = "0x12AC530")]
	private void Start()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x12AC534", Offset = "0x12AC534", VA = "0x12AC534")]
	private void Update()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x12AC538", Offset = "0x12AC538", VA = "0x12AC538")]
	public GameManager()
	{
	}
}
[Token(Token = "0x200001E")]
public class IcePeaBullet : MonoBehaviour
{
	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int damage;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform target;

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x12AC584", Offset = "0x12AC584", VA = "0x12AC584")]
	public void Initialize(float speed, Transform target)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x12AC590", Offset = "0x12AC590", VA = "0x12AC590")]
	private void Update()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x12AC7A0", Offset = "0x12AC7A0", VA = "0x12AC7A0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x12AC8FC", Offset = "0x12AC8FC", VA = "0x12AC8FC")]
	public IcePeaBullet()
	{
	}
}
[Token(Token = "0x200001F")]
public class IcePeaShooter : BasePlant
{
	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform bulletSpawnPoint;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float fireRate;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float detectionRange;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float detectionAngle;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float fireTimer;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform detectedZombie;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform brain;

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x12AC910", Offset = "0x12AC910", VA = "0x12AC910", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x12AC984", Offset = "0x12AC984", VA = "0x12AC984", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x12ACCA8", Offset = "0x12ACCA8", VA = "0x12ACCA8")]
	private void RotateToFaceZombie(Transform detectedZombie)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x12ACDF0", Offset = "0x12ACDF0", VA = "0x12ACDF0")]
	private bool IsFacingZombie(Transform detectedZombie)
	{
		return default(bool);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x12ACECC", Offset = "0x12ACECC", VA = "0x12ACECC")]
	public void Shoot()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x12ACB2C", Offset = "0x12ACB2C", VA = "0x12ACB2C")]
	private Transform DetectZombiesInRange()
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x12ACFAC", Offset = "0x12ACFAC", VA = "0x12ACFAC")]
	public IcePeaShooter()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x12ACFC8", Offset = "0x12ACFC8", VA = "0x12ACFC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6101A4", Offset = "0x6101A4")]
	private void <Shoot>b__11_0(GameObject obj)
	{
	}
}
[Token(Token = "0x2000020")]
public class NutWall : BasePlant
{
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject nut1;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject nut2;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject nut3;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float maxHealth;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool isMoving;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float timer;

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x12C46A8", Offset = "0x12C46A8", VA = "0x12C46A8", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x12C470C", Offset = "0x12C470C", VA = "0x12C470C", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x12C4790", Offset = "0x12C4790", VA = "0x12C4790")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x12C4794", Offset = "0x12C4794", VA = "0x12C4794", Slot = "6")]
	public override bool TakeDamage(float damage)
	{
		return default(bool);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x12C4934", Offset = "0x12C4934", VA = "0x12C4934")]
	public NutWall()
	{
	}
}
[Token(Token = "0x2000021")]
public class PVZ_Canvas : MonoBehaviour
{
	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform main_cam;

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x12C5114", Offset = "0x12C5114", VA = "0x12C5114")]
	private void Start()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x12C51D4", Offset = "0x12C51D4", VA = "0x12C51D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x12C529C", Offset = "0x12C529C", VA = "0x12C529C")]
	public PVZ_Canvas()
	{
	}
}
[Token(Token = "0x2000022")]
public class PVZ_MR_InputManager : MonoBehaviour
{
	[Token(Token = "0x2000023")]
	public enum State
	{
		[Token(Token = "0x40000A2")]
		Normal,
		[Token(Token = "0x40000A3")]
		Calibration,
		[Token(Token = "0x40000A4")]
		Brain
	}

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform CalibrationPoint;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform brain;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform brainContainer;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform rightController;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float groundHeight;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public DrawLineRenderer lineRenderer;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool isGrabBrain;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject newObj;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public State state;

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x12C52A4", Offset = "0x12C52A4", VA = "0x12C52A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x12C52A8", Offset = "0x12C52A8", VA = "0x12C52A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x12C5A78", Offset = "0x12C5A78", VA = "0x12C5A78")]
	public PVZ_MR_InputManager()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x12C5A80", Offset = "0x12C5A80", VA = "0x12C5A80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6101B4", Offset = "0x6101B4")]
	private void <Update>b__11_0()
	{
	}
}
[Token(Token = "0x2000024")]
public class PeaBullet : MonoBehaviour
{
	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int damage;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform target;

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x12C5B0C", Offset = "0x12C5B0C", VA = "0x12C5B0C")]
	public void Initialize(float speed, Transform target)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x12C5B18", Offset = "0x12C5B18", VA = "0x12C5B18")]
	private void Update()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x12C5ED4", Offset = "0x12C5ED4", VA = "0x12C5ED4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x12C6028", Offset = "0x12C6028", VA = "0x12C6028")]
	public PeaBullet()
	{
	}
}
[Token(Token = "0x2000025")]
public class PeaShooter : BasePlant
{
	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform bulletSpawnPoint;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float fireRate;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float detectionRange;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float detectionAngle;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float fireTimer;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform detectedZombie;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform brain;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x12C603C", Offset = "0x12C603C", VA = "0x12C603C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x12C60B4", Offset = "0x12C60B4", VA = "0x12C60B4", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x12C63D8", Offset = "0x12C63D8", VA = "0x12C63D8")]
	private void RotateToFaceZombie(Transform detectedZombie)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x12C6520", Offset = "0x12C6520", VA = "0x12C6520")]
	private bool IsFacingZombie(Transform detectedZombie)
	{
		return default(bool);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x12C65FC", Offset = "0x12C65FC", VA = "0x12C65FC")]
	public void Shoot()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x12C625C", Offset = "0x12C625C", VA = "0x12C625C")]
	private Transform DetectZombiesInRange()
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x12C68F0", Offset = "0x12C68F0", VA = "0x12C68F0")]
	public PeaShooter()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x12C690C", Offset = "0x12C690C", VA = "0x12C690C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6101C4", Offset = "0x6101C4")]
	private void <Shoot>b__11_0(GameObject obj)
	{
	}
}
[Token(Token = "0x2000026")]
public class PotatoMine : BasePlant
{
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FD30", Offset = "0x60FD30")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Collider collider;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PotatoMine <>4__this;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x12DC9B8", Offset = "0x12DC9B8", VA = "0x12DC9B8")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x12DC9C0", Offset = "0x12DC9C0", VA = "0x12DC9C0")]
		internal void <PotatoMineExplode>b__0(GameObject obj)
		{
		}
	}

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject pm1;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject pm2;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float growTime;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float growUpTimer;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isGrowUp;

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x12C6EF8", Offset = "0x12C6EF8", VA = "0x12C6EF8", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x12C6F28", Offset = "0x12C6F28", VA = "0x12C6F28", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x12C7194", Offset = "0x12C7194", VA = "0x12C7194")]
	private void PotatoMineExplode()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x12C7370", Offset = "0x12C7370", VA = "0x12C7370")]
	public PotatoMine()
	{
	}
}
[Token(Token = "0x2000028")]
public class RealWorldSunlight : MonoBehaviour
{
	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float latitude;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float longitude;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light directionalLight;

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x12C7378", Offset = "0x12C7378", VA = "0x12C7378")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x12C73D4", Offset = "0x12C73D4", VA = "0x12C73D4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x12C73D8", Offset = "0x12C73D8", VA = "0x12C73D8")]
	private void UpdateSunlightDirection()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x12C74CC", Offset = "0x12C74CC", VA = "0x12C74CC")]
	private (float, float) CalculateSunAngles(DateTime dateTime, float lat, float lon)
	{
		return default((float, float));
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x12C76B8", Offset = "0x12C76B8", VA = "0x12C76B8")]
	public RealWorldSunlight()
	{
	}
}
[Token(Token = "0x2000029")]
public class RightControllerPoint : MonoBehaviour
{
	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 scale;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float time;

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x12C7718", Offset = "0x12C7718", VA = "0x12C7718")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x12C7818", Offset = "0x12C7818", VA = "0x12C7818")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x12C7914", Offset = "0x12C7914", VA = "0x12C7914")]
	public RightControllerPoint()
	{
	}
}
[Token(Token = "0x200002A")]
public class Sun : MonoBehaviour
{
	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform sunHolo;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform sunHoloP;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform sunCore;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform mainCam;

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x12CA840", Offset = "0x12CA840", VA = "0x12CA840")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x12CA880", Offset = "0x12CA880", VA = "0x12CA880")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x12CA910", Offset = "0x12CA910", VA = "0x12CA910")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x12CAA8C", Offset = "0x12CAA8C", VA = "0x12CAA8C")]
	public Sun()
	{
	}
}
[Token(Token = "0x200002B")]
public class SunFlower : BasePlant
{
	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float minSunSpawnTime;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float maxSunSpawnTime;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform sunSpawnPoint;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float nextSunSpawnTime;

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x12CAA94", Offset = "0x12CAA94", VA = "0x12CAA94", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x12CAB2C", Offset = "0x12CAB2C", VA = "0x12CAB2C", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x12CAAE4", Offset = "0x12CAAE4", VA = "0x12CAAE4")]
	private void SetNextSunSpawnTime()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x12CAC14", Offset = "0x12CAC14", VA = "0x12CAC14")]
	public void SpawnSun()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x12CAD1C", Offset = "0x12CAD1C", VA = "0x12CAD1C")]
	public SunFlower()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x12CAD30", Offset = "0x12CAD30", VA = "0x12CAD30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6101D4", Offset = "0x6101D4")]
	private void <SpawnSun>b__7_0(GameObject obj)
	{
	}
}
[Token(Token = "0x200002C")]
public class TouTao : MonoBehaviour
{
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x12D1E50", Offset = "0x12D1E50", VA = "0x12D1E50")]
	private void Start()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x12D1E54", Offset = "0x12D1E54", VA = "0x12D1E54")]
	private void Update()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x12D1E58", Offset = "0x12D1E58", VA = "0x12D1E58")]
	public void BarricadeSelect()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x12D1F68", Offset = "0x12D1F68", VA = "0x12D1F68")]
	public void BucketSelect()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x12D2078", Offset = "0x12D2078", VA = "0x12D2078")]
	public TouTao()
	{
	}
}
[Token(Token = "0x200002D")]
public class TrackPlayerPoint : MonoBehaviour
{
	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform mainCam;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform ground;

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x12D2080", Offset = "0x12D2080", VA = "0x12D2080")]
	private void Start()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x12D2110", Offset = "0x12D2110", VA = "0x12D2110")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x12D2194", Offset = "0x12D2194", VA = "0x12D2194")]
	public TrackPlayerPoint()
	{
	}
}
[Token(Token = "0x200002E")]
public class fmground : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FD40", Offset = "0x60FD40")]
	private sealed class <>c
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static UnityAction<GameObject> <>9__5_0;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x12E360C", Offset = "0x12E360C", VA = "0x12E360C")]
		public <>c()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x12E3614", Offset = "0x12E3614", VA = "0x12E3614")]
		internal void <CreatObj>b__5_0(GameObject obj)
		{
		}
	}

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform flag;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform RightControllerPoint;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform ground;

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x12D7DA4", Offset = "0x12D7DA4", VA = "0x12D7DA4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x12D7DA8", Offset = "0x12D7DA8", VA = "0x12D7DA8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x12D7EB0", Offset = "0x12D7EB0", VA = "0x12D7EB0")]
	public void CreatObj(string name)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x12D800C", Offset = "0x12D800C", VA = "0x12D800C")]
	public fmground()
	{
	}
}
[Token(Token = "0x2000030")]
public class AutoPush : MonoBehaviour
{
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x12A5690", Offset = "0x12A5690", VA = "0x12A5690")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x12A56E4", Offset = "0x12A56E4", VA = "0x12A56E4")]
	private void DelayPush()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x12A577C", Offset = "0x12A577C", VA = "0x12A577C")]
	public AutoPush()
	{
	}
}
[Token(Token = "0x2000031")]
public class BaseManager<T> where T : new()
{
	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T _instance;

	[Token(Token = "0x60000CB")]
	public static T GetInstance()
	{
		return (T)null;
	}

	[Token(Token = "0x60000CC")]
	public BaseManager()
	{
	}
}
[Token(Token = "0x2000032")]
public class BasePanel : MonoBehaviour
{
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FD50", Offset = "0x60FD50")]
	private sealed class <>c__DisplayClass3_0<T> where T : UIBehaviour
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string objname;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BasePanel <>4__this;

		[Token(Token = "0x60000D4")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60000D5")]
		internal void <FindChildControl>b__0()
		{
		}
	}

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<string, List<UIBehaviour>> controlDic;

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x12A6278", Offset = "0x12A6278", VA = "0x12A6278", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60000CE")]
	protected T GetControl<T>(string controlName) where T : UIBehaviour
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	private void FindChildControl<T>() where T : UIBehaviour
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x12A6344", Offset = "0x12A6344", VA = "0x12A6344", Slot = "5")]
	protected virtual void OnClick(string btnName)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x12A6348", Offset = "0x12A6348", VA = "0x12A6348", Slot = "6")]
	public virtual void ShowMe()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x12A634C", Offset = "0x12A634C", VA = "0x12A634C", Slot = "7")]
	public virtual void HideMe()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x12A6350", Offset = "0x12A6350", VA = "0x12A6350")]
	public BasePanel()
	{
	}
}
[Token(Token = "0x2000034")]
public interface IEventInfo
{
}
[Token(Token = "0x2000035")]
public class EventInfo<T> : IEventInfo
{
	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public UnityAction<T> actions;

	[Token(Token = "0x60000D6")]
	public EventInfo(UnityAction<T> action)
	{
	}
}
[Token(Token = "0x2000036")]
public class EventInfo : IEventInfo
{
	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UnityAction actions;

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x12AB800", Offset = "0x12AB800", VA = "0x12AB800")]
	public EventInfo(UnityAction action)
	{
	}
}
[Token(Token = "0x2000037")]
public class EventCenter : BaseManager<EventCenter>
{
	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<string, IEventInfo> eventDic;

	[Token(Token = "0x60000D8")]
	public void AddEventListener<T>(string name, UnityAction<T> action)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x12AB678", Offset = "0x12AB678", VA = "0x12AB678")]
	public void AddEventListener(string name, UnityAction action)
	{
	}

	[Token(Token = "0x60000DA")]
	public void EventTrigger<T>(string name, T info)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x12AB898", Offset = "0x12AB898", VA = "0x12AB898")]
	public void EventTrigger(string name)
	{
	}

	[Token(Token = "0x60000DC")]
	public void RemoveEventListener<T>(string name, UnityAction<T> action)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x12AB98C", Offset = "0x12AB98C", VA = "0x12AB98C")]
	public void RemoveEventListener(string name, UnityAction action)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x12ABACC", Offset = "0x12ABACC", VA = "0x12ABACC")]
	public void Clear()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x12ABB20", Offset = "0x12ABB20", VA = "0x12ABB20")]
	public EventCenter()
	{
	}
}
[Token(Token = "0x2000038")]
public class InputMgr : BaseManager<InputMgr>
{
	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool isStart;

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x12AD460", Offset = "0x12AD460", VA = "0x12AD460")]
	public InputMgr()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x12AD534", Offset = "0x12AD534", VA = "0x12AD534")]
	public void StartOrEndCheck(bool isOpen)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x12AD540", Offset = "0x12AD540", VA = "0x12AD540")]
	private void CheckKeyCode(KeyCode key)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x12AD634", Offset = "0x12AD634", VA = "0x12AD634")]
	private void MyUpdate()
	{
	}
}
[Token(Token = "0x2000039")]
public class JsonMgr : BaseManager<JsonMgr>
{
	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x12BD6F4", Offset = "0x12BD6F4", VA = "0x12BD6F4")]
	public void SaveData(object data, string fileName)
	{
	}

	[Token(Token = "0x60000E5")]
	public T LoadData<T>(string fileName) where T : new()
	{
		return (T)null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x12BD864", Offset = "0x12BD864", VA = "0x12BD864")]
	public JsonMgr()
	{
	}
}
[Token(Token = "0x200003A")]
public class MonoController : MonoBehaviour
{
	[Token(Token = "0x14000001")]
	private event UnityAction updateEvent
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x12C2BAC", Offset = "0x12C2BAC", VA = "0x12C2BAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6101E4", Offset = "0x6101E4")]
		add
		{
		}
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x12C2C4C", Offset = "0x12C2C4C", VA = "0x12C2C4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6101F4", Offset = "0x6101F4")]
		remove
		{
		}
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x12C2CEC", Offset = "0x12C2CEC", VA = "0x12C2CEC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x12C2D64", Offset = "0x12C2D64", VA = "0x12C2D64")]
	private void Update()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x12C2E00", Offset = "0x12C2E00", VA = "0x12C2E00")]
	public void AddUpdateListener(UnityAction func)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x12C2E04", Offset = "0x12C2E04", VA = "0x12C2E04")]
	public void RemoveUpdateListener(UnityAction func)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x12C2E08", Offset = "0x12C2E08", VA = "0x12C2E08")]
	public MonoController()
	{
	}
}
[Token(Token = "0x200003B")]
public class MonoMgr : BaseManager<MonoMgr>
{
	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private MonoController controller;

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x12C2E10", Offset = "0x12C2E10", VA = "0x12C2E10")]
	public MonoMgr()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x12C2ED4", Offset = "0x12C2ED4", VA = "0x12C2ED4")]
	public void AddUpdateListener(UnityAction func)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x12C2EEC", Offset = "0x12C2EEC", VA = "0x12C2EEC")]
	public void RemoveUpdateListener(UnityAction func)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x12C2F04", Offset = "0x12C2F04", VA = "0x12C2F04")]
	public Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x12C2F20", Offset = "0x12C2F20", VA = "0x12C2F20")]
	public Coroutine StartCoroutine(string methodName, [AttributeAttribute(Name = "DefaultValueAttribute", RVA = "0x610F78", Offset = "0x610F78")] object value)
	{
		return null;
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x12C2F3C", Offset = "0x12C2F3C", VA = "0x12C2F3C")]
	public Coroutine StartCoroutine(string methodName)
	{
		return null;
	}
}
[Token(Token = "0x200003C")]
public class MusicMgr : BaseManager<MusicMgr>
{
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FD60", Offset = "0x60FD60")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource source;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isLoop;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MusicMgr <>4__this;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityAction<AudioSource> callback;

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x12DC838", Offset = "0x12DC838", VA = "0x12DC838")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x12DC840", Offset = "0x12DC840", VA = "0x12DC840")]
		internal void <PlaySound>b__0(AudioClip clip)
		{
		}
	}

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private AudioSource bkMusic;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float bkVaule;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float soundVaule;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject soundObj;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<AudioSource> soundList;

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x12C2F58", Offset = "0x12C2F58", VA = "0x12C2F58")]
	public MusicMgr()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x12C3080", Offset = "0x12C3080", VA = "0x12C3080")]
	private void update()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x12C3284", Offset = "0x12C3284", VA = "0x12C3284")]
	public void PlayBKMusic(string name)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x12C3450", Offset = "0x12C3450", VA = "0x12C3450")]
	public void ChangeBKValue(float v)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x12C34F8", Offset = "0x12C34F8", VA = "0x12C34F8")]
	public void PauseBKMusic()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x12C3588", Offset = "0x12C3588", VA = "0x12C3588")]
	public void StopBKMusic()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x12C3618", Offset = "0x12C3618", VA = "0x12C3618")]
	public void PlaySound(string name, bool isLoop, [Optional] UnityAction<AudioSource> callback)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x12C3864", Offset = "0x12C3864", VA = "0x12C3864")]
	public void ChangeSoundValue(float value)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x12C3918", Offset = "0x12C3918", VA = "0x12C3918")]
	public void StopSound(AudioSource source)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x12C3A00", Offset = "0x12C3A00", VA = "0x12C3A00")]
	public void StopAllSound()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x12C3B48", Offset = "0x12C3B48", VA = "0x12C3B48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x610204", Offset = "0x610204")]
	private void <PlayBKMusic>b__7_0(AudioClip clip)
	{
	}
}
[Token(Token = "0x200003E")]
public class PoolData
{
	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject fatherObj;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> poolList;

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x12C6B50", Offset = "0x12C6B50", VA = "0x12C6B50")]
	public PoolData(GameObject obj, GameObject poolObj)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x12C6C8C", Offset = "0x12C6C8C", VA = "0x12C6C8C")]
	public void PushObj(GameObject obj)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x12C6D3C", Offset = "0x12C6D3C", VA = "0x12C6D3C")]
	public GameObject GetObj()
	{
		return null;
	}
}
[Token(Token = "0x200003F")]
public class PoolMgr : BaseManager<PoolMgr>
{
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FD70", Offset = "0x60FD70")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityAction<GameObject> callBack;

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x12DC938", Offset = "0x12DC938", VA = "0x12DC938")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x12DC940", Offset = "0x12DC940", VA = "0x12DC940")]
		internal void <GetObj>b__0(GameObject o)
		{
		}
	}

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Dictionary<string, PoolData> poolDic;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject poolObj;

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x12C66D8", Offset = "0x12C66D8", VA = "0x12C66D8")]
	public void GetObj(string name, UnityAction<GameObject> callBack)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x12C5D24", Offset = "0x12C5D24", VA = "0x12C5D24")]
	public void PushObj(string name, GameObject obj)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x12C6DFC", Offset = "0x12C6DFC", VA = "0x12C6DFC")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x12C6E60", Offset = "0x12C6E60", VA = "0x12C6E60")]
	public PoolMgr()
	{
	}
}
[Token(Token = "0x2000041")]
public class ResMgr : BaseManager<ResMgr>
{
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FD80", Offset = "0x60FD80")]
	private sealed class <ReallyLoadAsync>d__2<T> : IEnumerator<object>, IEnumerator, IDisposable where T : UnityEngine.Object
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string name;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UnityAction<T> callback;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ResourceRequest <r>5__2;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000111")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000113")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010E")]
		[DebuggerHidden]
		public <ReallyLoadAsync>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x600010F")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000110")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x600010A")]
	public T Load<T>(string name) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600010B")]
	public void LoadAsync<T>(string name, UnityAction<T> callback) where T : UnityEngine.Object
	{
	}

	[Token(Token = "0x600010C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x610214", Offset = "0x610214")]
	private IEnumerator ReallyLoadAsync<T>(string name, UnityAction<T> callback) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x12C76CC", Offset = "0x12C76CC", VA = "0x12C76CC")]
	public ResMgr()
	{
	}
}
[Token(Token = "0x2000043")]
public class SceneMgr : BaseManager<SceneMgr>
{
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FD90", Offset = "0x60FD90")]
	private sealed class <ReallyLoadSceneAsyn>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityAction func;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AsyncOperation <ao>5__2;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x12DCD18", Offset = "0x12DCD18", VA = "0x12DCD18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x12DCD60", Offset = "0x12DCD60", VA = "0x12DCD60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x12DCB24", Offset = "0x12DCB24", VA = "0x12DCB24")]
		[DebuggerHidden]
		public <ReallyLoadSceneAsyn>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x12DCB50", Offset = "0x12DCB50", VA = "0x12DCB50", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x12DCB54", Offset = "0x12DCB54", VA = "0x12DCB54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x12DCD20", Offset = "0x12DCD20", VA = "0x12DCD20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x12C7928", Offset = "0x12C7928", VA = "0x12C7928")]
	public void LoadScene(string name, UnityAction func)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x12C79AC", Offset = "0x12C79AC", VA = "0x12C79AC")]
	public void LoadScene(string name)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x12C7A60", Offset = "0x12C7A60", VA = "0x12C7A60")]
	public void LoadSceneAsyn(string name, [Optional] UnityAction func)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x12C7AE0", Offset = "0x12C7AE0", VA = "0x12C7AE0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6102C4", Offset = "0x6102C4")]
	private IEnumerator ReallyLoadSceneAsyn(string name, UnityAction func)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x12C7B74", Offset = "0x12C7B74", VA = "0x12C7B74")]
	public SceneMgr()
	{
	}
}
[Token(Token = "0x2000045")]
public class SingletonAutoMono<T> : MonoBehaviour where T : MonoBehaviour
{
	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T instance;

	[Token(Token = "0x600011F")]
	public static T GetInstance()
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	public SingletonAutoMono()
	{
	}
}
[Token(Token = "0x2000046")]
public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
{
	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T instance;

	[Token(Token = "0x6000121")]
	public static T GetInstance()
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000123")]
	public SingletonMono()
	{
	}
}
[Token(Token = "0x2000047")]
public enum E_UI_Layer
{
	[Token(Token = "0x40000F0")]
	Bot,
	[Token(Token = "0x40000F1")]
	Mid,
	[Token(Token = "0x40000F2")]
	Top,
	[Token(Token = "0x40000F3")]
	System
}
[Token(Token = "0x2000048")]
public class UIManager : BaseManager<UIManager>
{
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FDA0", Offset = "0x60FDA0")]
	private sealed class <>c__DisplayClass7_0<T> where T : BasePanel
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UIManager <>4__this;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public E_UI_Layer layer;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UnityAction<T> callback;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string panelName;

		[Token(Token = "0x600012A")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x600012B")]
		internal void <ShowPanel>b__0(GameObject obj)
		{
		}
	}

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Dictionary<string, BasePanel> panelDic;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform bot;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform mid;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform top;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform system;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform canvas;

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x12D42C4", Offset = "0x12D42C4", VA = "0x12D42C4")]
	public UIManager()
	{
	}

	[Token(Token = "0x6000125")]
	public void ShowPanel<T>(string panelName, E_UI_Layer layer = E_UI_Layer.Top, [Optional] UnityAction<T> callback) where T : BasePanel
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x12D456C", Offset = "0x12D456C", VA = "0x12D456C")]
	public Transform GetLayerFather(E_UI_Layer layer)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x12D45B8", Offset = "0x12D45B8", VA = "0x12D45B8")]
	public void HidePanel(string panelName)
	{
	}

	[Token(Token = "0x6000128")]
	public T GetPanel<T>(string name) where T : BasePanel
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x12D46F0", Offset = "0x12D46F0", VA = "0x12D46F0")]
	public static void AddCustomEventListener(UIBehaviour control, EventTriggerType type, UnityAction<BaseEventData> callback)
	{
	}
}
[Token(Token = "0x200004A")]
public class Seethough : MonoBehaviour
{
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x12C7BC0", Offset = "0x12C7BC0", VA = "0x12C7BC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x12C7BCC", Offset = "0x12C7BCC", VA = "0x12C7BCC")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x12C7BE0", Offset = "0x12C7BE0", VA = "0x12C7BE0")]
	public Seethough()
	{
	}
}
[Token(Token = "0x200004B")]
public class ChatController : MonoBehaviour
{
	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_InputField ChatInputField;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_Text ChatDisplayOutput;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Scrollbar ChatScrollbar;

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x12A9808", Offset = "0x12A9808", VA = "0x12A9808")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x12A98CC", Offset = "0x12A98CC", VA = "0x12A98CC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x12A9990", Offset = "0x12A9990", VA = "0x12A9990")]
	private void AddToChatOutput(string newText)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x12A9E2C", Offset = "0x12A9E2C", VA = "0x12A9E2C")]
	public ChatController()
	{
	}
}
[Token(Token = "0x200004C")]
public class DropdownSample : MonoBehaviour
{
	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI text;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TMP_Dropdown dropdownWithoutPlaceholder;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Dropdown dropdownWithPlaceholder;

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x12AB45C", Offset = "0x12AB45C", VA = "0x12AB45C")]
	public void OnButtonClick()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x12AB568", Offset = "0x12AB568", VA = "0x12AB568")]
	public DropdownSample()
	{
	}
}
[Token(Token = "0x200004D")]
public class EnvMapAnimator : MonoBehaviour
{
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FDB0", Offset = "0x60FDB0")]
	private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnvMapAnimator <>4__this;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Matrix4x4 <matrix>5__2;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x12DAD8C", Offset = "0x12DAD8C", VA = "0x12DAD8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x12DADD4", Offset = "0x12DADD4", VA = "0x12DADD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x12DABA4", Offset = "0x12DABA4", VA = "0x12DABA4")]
		[DebuggerHidden]
		public <Start>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x12DABD0", Offset = "0x12DABD0", VA = "0x12DABD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x12DABD4", Offset = "0x12DABD4", VA = "0x12DABD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x12DAD94", Offset = "0x12DAD94", VA = "0x12DAD94", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 RotationSpeeds;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TMP_Text m_textMeshPro;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material m_material;

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x12AB570", Offset = "0x12AB570", VA = "0x12AB570")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x12AB5F8", Offset = "0x12AB5F8", VA = "0x12AB5F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x610374", Offset = "0x610374")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x12AB670", Offset = "0x12AB670", VA = "0x12AB670")]
	public EnvMapAnimator()
	{
	}
}
[Token(Token = "0x200004F")]
public class ActivationEventScript : MonoBehaviour
{
	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x61007C", Offset = "0x61007C")]
	public bool globalSubscriptionRigid;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool localSubscriptionRigid;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RayfireRigid localRigidComponent;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6100B4", Offset = "0x6100B4")]
	public bool localSubscriptionMeshRoot;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RayfireRigid localMeshRootComponent;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6100EC", Offset = "0x6100EC")]
	public bool globalSubscriptionRoot;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool localSubscriptionRoot;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RayfireRigidRoot localRigidRootComponentRoot;

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x12A48D8", Offset = "0x12A48D8", VA = "0x12A48D8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x12A4BB0", Offset = "0x12A4BB0", VA = "0x12A4BB0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x12A4E88", Offset = "0x12A4E88", VA = "0x12A4E88")]
	private void LocalMethodRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x12A4F48", Offset = "0x12A4F48", VA = "0x12A4F48")]
	private void GlobalMethodRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x12A5008", Offset = "0x12A5008", VA = "0x12A5008")]
	private void LocalMethodMeshRoot(RayfireRigid rigid, RayfireRigid meshRoot)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x12A5118", Offset = "0x12A5118", VA = "0x12A5118")]
	private void LocalMethodRoot(RFShard shard, RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x12A522C", Offset = "0x12A522C", VA = "0x12A522C")]
	private void GlobalMethodRoot(RFShard shard, RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x12A5340", Offset = "0x12A5340", VA = "0x12A5340")]
	public ActivationEventScript()
	{
	}
}
[Token(Token = "0x2000050")]
public class AddRigidComponent : MonoBehaviour
{
	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject targetObject;

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x12A5348", Offset = "0x12A5348", VA = "0x12A5348")]
	private void Update()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x12A5428", Offset = "0x12A5428", VA = "0x12A5428")]
	public AddRigidComponent()
	{
	}
}
[Token(Token = "0x2000051")]
public class ApplyDamageScript : MonoBehaviour
{
	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RayfireRigid rigid;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float damageValue;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform damagePoint;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float damageRadius;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Collider coll;

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x12A5430", Offset = "0x12A5430", VA = "0x12A5430")]
	private void Update()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x12A5580", Offset = "0x12A5580", VA = "0x12A5580")]
	public ApplyDamageScript()
	{
	}
}
[Token(Token = "0x2000052")]
public class ConnectivityEventScript : MonoBehaviour
{
	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool globalSubscription;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool localSubscription;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RayfireConnectivity localConnectivityComponent;

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x12A9E34", Offset = "0x12A9E34", VA = "0x12A9E34")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x12A9F78", Offset = "0x12A9F78", VA = "0x12A9F78")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x12AA0BC", Offset = "0x12AA0BC", VA = "0x12AA0BC")]
	private void LocalMethodConnectivity(RayfireConnectivity connectivity, List<RFShard> shards, List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x12AA430", Offset = "0x12AA430", VA = "0x12AA430")]
	private void GlobalMethodConnectivity(RayfireConnectivity connectivity, List<RFShard> shards, List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x12AA7A4", Offset = "0x12AA7A4", VA = "0x12AA7A4")]
	public ConnectivityEventScript()
	{
	}
}
[Token(Token = "0x2000053")]
public class DemolitionEventScript : MonoBehaviour
{
	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool globalSubscription;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool localSubscription;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RayfireRigid localRigidComponent;

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x12AA7AC", Offset = "0x12AA7AC", VA = "0x12AA7AC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x12AA8F0", Offset = "0x12AA8F0", VA = "0x12AA8F0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x12AAA34", Offset = "0x12AAA34", VA = "0x12AAA34")]
	private void LocalMethod(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x12AAD0C", Offset = "0x12AAD0C", VA = "0x12AAD0C")]
	private void GlobalMethod(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x12AAFE4", Offset = "0x12AAFE4", VA = "0x12AAFE4")]
	public DemolitionEventScript()
	{
	}
}
namespace EzySlice
{
	[Token(Token = "0x2000054")]
	public sealed class IntersectionResult
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool is_success;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Triangle[] upper_hull;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Triangle[] lower_hull;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Vector3[] intersection_pt;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int upper_hull_count;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int lower_hull_count;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int intersection_pt_count;

		[Token(Token = "0x17000007")]
		public Triangle[] upperHull
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x12AD730", Offset = "0x12AD730", VA = "0x12AD730")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public Triangle[] lowerHull
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x12AD738", Offset = "0x12AD738", VA = "0x12AD738")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public Vector3[] intersectionPoints
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x12AD740", Offset = "0x12AD740", VA = "0x12AD740")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		public int upperHullCount
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x12AD748", Offset = "0x12AD748", VA = "0x12AD748")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000B")]
		public int lowerHullCount
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x12AD750", Offset = "0x12AD750", VA = "0x12AD750")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000C")]
		public int intersectionPointCount
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x12AD758", Offset = "0x12AD758", VA = "0x12AD758")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000D")]
		public bool isValid
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x12AD760", Offset = "0x12AD760", VA = "0x12AD760")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x12AD66C", Offset = "0x12AD66C", VA = "0x12AD66C")]
		public IntersectionResult()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x12AD768", Offset = "0x12AD768", VA = "0x12AD768")]
		public IntersectionResult AddUpperHull(Triangle tri)
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x12AD804", Offset = "0x12AD804", VA = "0x12AD804")]
		public IntersectionResult AddLowerHull(Triangle tri)
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x12AD8A0", Offset = "0x12AD8A0", VA = "0x12AD8A0")]
		public void AddIntersectionPoint(Vector3 pt)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x12AD8F0", Offset = "0x12AD8F0", VA = "0x12AD8F0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x12AD900", Offset = "0x12AD900", VA = "0x12AD900")]
		public void OnDebugDraw()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x12AD908", Offset = "0x12AD908", VA = "0x12AD908")]
		public void OnDebugDraw(Color drawColor)
		{
		}
	}
	[Token(Token = "0x2000055")]
	public sealed class Intersector
	{
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x12AD90C", Offset = "0x12AD90C", VA = "0x12AD90C")]
		public static bool Intersect(Plane pl, Line ln, out Vector3 q)
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x12AD948", Offset = "0x12AD948", VA = "0x12AD948")]
		public static bool Intersect(Plane pl, Vector3 a, Vector3 b, out Vector3 q)
		{
			return default(bool);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x12AD9F8", Offset = "0x12AD9F8", VA = "0x12AD9F8")]
		public static float TriArea2D(float x1, float y1, float x2, float y2, float x3, float y3)
		{
			return default(float);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x12ADA18", Offset = "0x12ADA18", VA = "0x12ADA18")]
		public static void Intersect(Plane pl, Triangle tri, IntersectionResult result)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x12AF418", Offset = "0x12AF418", VA = "0x12AF418")]
		public Intersector()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public struct Line
	{
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Vector3 m_pos_a;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly Vector3 m_pos_b;

		[Token(Token = "0x1700000E")]
		public float dist
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x12C2B3C", Offset = "0x12C2B3C", VA = "0x12C2B3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000F")]
		public float distSq
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x12C2B50", Offset = "0x12C2B50", VA = "0x12C2B50")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000010")]
		public Vector3 positionA
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x12C2B94", Offset = "0x12C2B94", VA = "0x12C2B94")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000011")]
		public Vector3 positionB
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x12C2BA0", Offset = "0x12C2BA0", VA = "0x12C2BA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x12C2B2C", Offset = "0x12C2B2C", VA = "0x12C2B2C")]
		public Line(Vector3 pta, Vector3 ptb)
		{
		}
	}
	[Token(Token = "0x2000057")]
	public enum SideOfPlane
	{
		[Token(Token = "0x4000129")]
		UP,
		[Token(Token = "0x400012A")]
		DOWN,
		[Token(Token = "0x400012B")]
		ON
	}
	[Token(Token = "0x2000058")]
	public struct Plane
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 m_normal;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private float m_dist;

		[Token(Token = "0x17000012")]
		public Vector3 normal
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x12C6AE0", Offset = "0x12C6AE0", VA = "0x12C6AE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000013")]
		public float dist
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x12C6AEC", Offset = "0x12C6AEC", VA = "0x12C6AEC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x12C69E4", Offset = "0x12C69E4", VA = "0x12C69E4")]
		public Plane(Vector3 pos, Vector3 norm)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x12C6A04", Offset = "0x12C6A04", VA = "0x12C6A04")]
		public Plane(Vector3 norm, float dot)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x12C6A10", Offset = "0x12C6A10", VA = "0x12C6A10")]
		public void Compute(Vector3 pos, Vector3 norm)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x12C6A30", Offset = "0x12C6A30", VA = "0x12C6A30")]
		public void Compute(Transform trans)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x12C6AA8", Offset = "0x12C6AA8", VA = "0x12C6AA8")]
		public void Compute(GameObject obj)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x12C6AF4", Offset = "0x12C6AF4", VA = "0x12C6AF4")]
		public SideOfPlane SideOf(Vector3 pt)
		{
			return default(SideOfPlane);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x12C6B44", Offset = "0x12C6B44", VA = "0x12C6B44")]
		public void OnDebugDraw()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x12C6B4C", Offset = "0x12C6B4C", VA = "0x12C6B4C")]
		public void OnDebugDraw(Color drawColor)
		{
		}
	}
	[Token(Token = "0x2000059")]
	public struct TextureRegion
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly float pos_start_x;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private readonly float pos_start_y;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly float pos_end_x;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly float pos_end_y;

		[Token(Token = "0x17000014")]
		public float startX
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x12D1C88", Offset = "0x12D1C88", VA = "0x12D1C88")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000015")]
		public float startY
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x12D1C90", Offset = "0x12D1C90", VA = "0x12D1C90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000016")]
		public float endX
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x12D1C98", Offset = "0x12D1C98", VA = "0x12D1C98")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000017")]
		public float endY
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x12D1CA0", Offset = "0x12D1CA0", VA = "0x12D1CA0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000018")]
		public Vector2 start
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x12D1CA8", Offset = "0x12D1CA8", VA = "0x12D1CA8")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000019")]
		public Vector2 end
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x12D1CB0", Offset = "0x12D1CB0", VA = "0x12D1CB0")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x12CA2C0", Offset = "0x12CA2C0", VA = "0x12CA2C0")]
		public TextureRegion(float startX, float startY, float endX, float endY)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x12D1CB8", Offset = "0x12D1CB8", VA = "0x12D1CB8")]
		public Vector2 Map(Vector2 uv)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x12D1CD4", Offset = "0x12D1CD4", VA = "0x12D1CD4")]
		public Vector2 Map(float x, float y)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x12D1CF0", Offset = "0x12D1CF0", VA = "0x12D1CF0")]
		private static float MAP(float x, float in_min, float in_max, float out_min, float out_max)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200005A")]
	public static class TextureRegionExtension
	{
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x12D1D0C", Offset = "0x12D1D0C", VA = "0x12D1D0C")]
		public static TextureRegion GetTextureRegion(this Material mat, int pixX, int pixY, int pixWidth, int pixHeight)
		{
			return default(TextureRegion);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x12D1D5C", Offset = "0x12D1D5C", VA = "0x12D1D5C")]
		public static TextureRegion GetTextureRegion(this Texture tex, int pixX, int pixY, int pixWidth, int pixHeight)
		{
			return default(TextureRegion);
		}
	}
	[Token(Token = "0x200005B")]
	public struct Triangle
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Vector3 m_pos_a;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly Vector3 m_pos_b;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Vector3 m_pos_c;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_uv_set;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2 m_uv_a;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 m_uv_b;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 m_uv_c;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_nor_set;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_nor_a;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 m_nor_b;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 m_nor_c;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_tan_set;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector4 m_tan_a;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector4 m_tan_b;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector4 m_tan_c;

		[Token(Token = "0x1700001A")]
		public Vector3 positionA
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x12D219C", Offset = "0x12D219C", VA = "0x12D219C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001B")]
		public Vector3 positionB
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x12D21A8", Offset = "0x12D21A8", VA = "0x12D21A8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001C")]
		public Vector3 positionC
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x12D21B4", Offset = "0x12D21B4", VA = "0x12D21B4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001D")]
		public bool hasUV
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x12D21C0", Offset = "0x12D21C0", VA = "0x12D21C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public Vector2 uvA
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x12D21C8", Offset = "0x12D21C8", VA = "0x12D21C8")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector2 uvB
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x12D21D0", Offset = "0x12D21D0", VA = "0x12D21D0")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000020")]
		public Vector2 uvC
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x12D21D8", Offset = "0x12D21D8", VA = "0x12D21D8")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000021")]
		public bool hasNormal
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x12D21E0", Offset = "0x12D21E0", VA = "0x12D21E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public Vector3 normalA
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x12D21E8", Offset = "0x12D21E8", VA = "0x12D21E8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000023")]
		public Vector3 normalB
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x12D21F4", Offset = "0x12D21F4", VA = "0x12D21F4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000024")]
		public Vector3 normalC
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x12D2200", Offset = "0x12D2200", VA = "0x12D2200")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000025")]
		public bool hasTangent
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x12D220C", Offset = "0x12D220C", VA = "0x12D220C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000026")]
		public Vector4 tangentA
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x12D2214", Offset = "0x12D2214", VA = "0x12D2214")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000027")]
		public Vector4 tangentB
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x12D2220", Offset = "0x12D2220", VA = "0x12D2220")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000028")]
		public Vector4 tangentC
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x12D222C", Offset = "0x12D222C", VA = "0x12D222C")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x12C9580", Offset = "0x12C9580", VA = "0x12C9580")]
		public Triangle(Vector3 posa, Vector3 posb, Vector3 posc)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x12C9648", Offset = "0x12C9648", VA = "0x12C9648")]
		public void SetUV(Vector2 uvA, Vector2 uvB, Vector2 uvC)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x12C9660", Offset = "0x12C9660", VA = "0x12C9660")]
		public void SetNormal(Vector3 norA, Vector3 norB, Vector3 norC)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x12C9688", Offset = "0x12C9688", VA = "0x12C9688")]
		public void SetTangent(Vector4 tanA, Vector4 tanB, Vector4 tanC)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x12D2238", Offset = "0x12D2238", VA = "0x12D2238")]
		public void ComputeTangents()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x12D2514", Offset = "0x12D2514", VA = "0x12D2514")]
		public Vector3 Barycentric(Vector3 p)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x12D26E0", Offset = "0x12D26E0", VA = "0x12D26E0")]
		public Vector2 GenerateUV(Vector3 pt)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x12D2738", Offset = "0x12D2738", VA = "0x12D2738")]
		public Vector3 GenerateNormal(Vector3 pt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x12D27B4", Offset = "0x12D27B4", VA = "0x12D27B4")]
		public Vector4 GenerateTangent(Vector3 pt)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x12C96AC", Offset = "0x12C96AC", VA = "0x12C96AC")]
		public bool Split(Plane pl, IntersectionResult result)
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x12D28F4", Offset = "0x12D28F4", VA = "0x12D28F4")]
		public bool IsCW()
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x12D2954", Offset = "0x12D2954", VA = "0x12D2954")]
		public static float SignedSquare(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(float);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x12D2998", Offset = "0x12D2998", VA = "0x12D2998")]
		public void OnDebugDraw()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x12D29A0", Offset = "0x12D29A0", VA = "0x12D29A0")]
		public void OnDebugDraw(Color drawColor)
		{
		}
	}
	[Token(Token = "0x200005C")]
	public sealed class Triangulator
	{
		[Token(Token = "0x200005D")]
		internal struct Mapped2D
		{
			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Vector3 original;

			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private readonly Vector2 mapped;

			[Token(Token = "0x17000029")]
			public Vector2 mappedValue
			{
				[Token(Token = "0x60001A3")]
				[Address(RVA = "0x12DEE50", Offset = "0x12DEE50", VA = "0x12DEE50")]
				get
				{
					return default(Vector2);
				}
			}

			[Token(Token = "0x1700002A")]
			public Vector3 originalValue
			{
				[Token(Token = "0x60001A4")]
				[Address(RVA = "0x12DEE58", Offset = "0x12DEE58", VA = "0x12DEE58")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x12D427C", Offset = "0x12D427C", VA = "0x12D427C")]
			public Mapped2D(Vector3 newOriginal, Vector3 u, Vector3 v)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FDD0", Offset = "0x60FDD0")]
		private sealed class <>c
		{
			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<Mapped2D> <>9__2_0;

			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x12DEE14", Offset = "0x12DEE14", VA = "0x12DEE14")]
			public <>c()
			{
			}

			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x12DEE1C", Offset = "0x12DEE1C", VA = "0x12DEE1C")]
			internal int <MonotoneChain>b__2_0(Mapped2D a, Mapped2D b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x12D39A4", Offset = "0x12D39A4", VA = "0x12D39A4")]
		public static bool MonotoneChain(List<Vector3> vertices, Vector3 normal, out List<Triangle> tri)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x12D3A2C", Offset = "0x12D3A2C", VA = "0x12D3A2C")]
		public static bool MonotoneChain(List<Vector3> vertices, Vector3 normal, out List<Triangle> tri, TextureRegion texRegion)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x12D42BC", Offset = "0x12D42BC", VA = "0x12D42BC")]
		public Triangulator()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public sealed class SlicedHull
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Mesh upper_hull;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Mesh lower_hull;

		[Token(Token = "0x1700002B")]
		public Mesh upperHull
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x12C89CC", Offset = "0x12C89CC", VA = "0x12C89CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public Mesh lowerHull
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x12C89D4", Offset = "0x12C89D4", VA = "0x12C89D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x12C8254", Offset = "0x12C8254", VA = "0x12C8254")]
		public SlicedHull(Mesh upperHull, Mesh lowerHull)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x12C82A4", Offset = "0x12C82A4", VA = "0x12C82A4")]
		public GameObject CreateUpperHull(GameObject original)
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x12C82AC", Offset = "0x12C82AC", VA = "0x12C82AC")]
		public GameObject CreateUpperHull(GameObject original, Material crossSectionMat)
		{
			return null;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x12C85B4", Offset = "0x12C85B4", VA = "0x12C85B4")]
		public GameObject CreateLowerHull(GameObject original)
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x12C85BC", Offset = "0x12C85BC", VA = "0x12C85BC")]
		public GameObject CreateLowerHull(GameObject original, Material crossSectionMat)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x12C8568", Offset = "0x12C8568", VA = "0x12C8568")]
		public GameObject CreateUpperHull()
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x12C8878", Offset = "0x12C8878", VA = "0x12C8878")]
		public GameObject CreateLowerHull()
		{
			return null;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x12C88C4", Offset = "0x12C88C4", VA = "0x12C88C4")]
		private static GameObject CreateEmptyObject(string name, Mesh hull)
		{
			return null;
		}
	}
	[Token(Token = "0x2000060")]
	public sealed class Slicer
	{
		[Token(Token = "0x2000061")]
		internal class SlicedSubmesh
		{
			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly List<Triangle> upperHull;

			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly List<Triangle> lowerHull;

			[Token(Token = "0x1700002D")]
			public bool hasUV
			{
				[Token(Token = "0x60001BA")]
				[Address(RVA = "0x12DD864", Offset = "0x12DD864", VA = "0x12DD864")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002E")]
			public bool hasNormal
			{
				[Token(Token = "0x60001BB")]
				[Address(RVA = "0x12DD8F0", Offset = "0x12DD8F0", VA = "0x12DD8F0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002F")]
			public bool hasTangent
			{
				[Token(Token = "0x60001BC")]
				[Address(RVA = "0x12DD97C", Offset = "0x12DD97C", VA = "0x12DD97C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000030")]
			public bool isValid
			{
				[Token(Token = "0x60001BD")]
				[Address(RVA = "0x12DDA08", Offset = "0x12DDA08", VA = "0x12DDA08")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x12DDA78", Offset = "0x12DDA78", VA = "0x12DDA78")]
			public SlicedSubmesh()
			{
			}
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x12C89DC", Offset = "0x12C89DC", VA = "0x12C89DC")]
		public static SlicedHull Slice(GameObject obj, Plane pl, TextureRegion crossRegion, Material crossMaterial)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x12C8D98", Offset = "0x12C8D98", VA = "0x12C8D98")]
		public static SlicedHull Slice(Mesh sharedMesh, Plane pl, TextureRegion region, int crossIndex)
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x12C9760", Offset = "0x12C9760", VA = "0x12C9760")]
		private static SlicedHull CreateFrom(SlicedSubmesh[] meshes, List<Triangle> cross, int crossSectionIndex)
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x12C9880", Offset = "0x12C9880", VA = "0x12C9880")]
		private static Mesh CreateUpperHull(SlicedSubmesh[] mesh, int total, List<Triangle> crossSection, int crossSectionIndex)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x12C9888", Offset = "0x12C9888", VA = "0x12C9888")]
		private static Mesh CreateLowerHull(SlicedSubmesh[] mesh, int total, List<Triangle> crossSection, int crossSectionIndex)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x12C9890", Offset = "0x12C9890", VA = "0x12C9890")]
		private static Mesh CreateHull(SlicedSubmesh[] meshes, int total, List<Triangle> crossSection, int crossIndex, bool isUpper)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x12C972C", Offset = "0x12C972C", VA = "0x12C972C")]
		private static List<Triangle> CreateFrom(List<Vector3> intPoints, Vector3 planeNormal, TextureRegion region)
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x12CA2A4", Offset = "0x12CA2A4", VA = "0x12CA2A4")]
		public Slicer()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public static class SlicerExtensions
	{
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x12CA2AC", Offset = "0x12CA2AC", VA = "0x12CA2AC")]
		public static SlicedHull Slice(this GameObject obj, Plane pl, [Optional] Material crossSectionMaterial)
		{
			return null;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x12CA2D0", Offset = "0x12CA2D0", VA = "0x12CA2D0")]
		public static SlicedHull Slice(this GameObject obj, Vector3 position, Vector3 direction, [Optional] Material crossSectionMaterial)
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x12CA2F4", Offset = "0x12CA2F4", VA = "0x12CA2F4")]
		public static SlicedHull Slice(this GameObject obj, Vector3 position, Vector3 direction, TextureRegion textureRegion, [Optional] Material crossSectionMaterial)
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x12CA2CC", Offset = "0x12CA2CC", VA = "0x12CA2CC")]
		public static SlicedHull Slice(this GameObject obj, Plane pl, TextureRegion textureRegion, [Optional] Material crossSectionMaterial)
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x12CA3F4", Offset = "0x12CA3F4", VA = "0x12CA3F4")]
		public static GameObject[] SliceInstantiate(this GameObject obj, Plane pl)
		{
			return null;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x12CA6F4", Offset = "0x12CA6F4", VA = "0x12CA6F4")]
		public static GameObject[] SliceInstantiate(this GameObject obj, Vector3 position, Vector3 direction)
		{
			return null;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x12CA71C", Offset = "0x12CA71C", VA = "0x12CA71C")]
		public static GameObject[] SliceInstantiate(this GameObject obj, Vector3 position, Vector3 direction, Material crossSectionMat)
		{
			return null;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x12CA740", Offset = "0x12CA740", VA = "0x12CA740")]
		public static GameObject[] SliceInstantiate(this GameObject obj, Vector3 position, Vector3 direction, TextureRegion cuttingRegion, [Optional] Material crossSectionMaterial)
		{
			return null;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x12CA40C", Offset = "0x12CA40C", VA = "0x12CA40C")]
		public static GameObject[] SliceInstantiate(this GameObject obj, Plane pl, TextureRegion cuttingRegion, [Optional] Material crossSectionMaterial)
		{
			return null;
		}
	}
}
namespace LitJson
{
	[Token(Token = "0x2000063")]
	public enum JsonType
	{
		[Token(Token = "0x400014A")]
		None,
		[Token(Token = "0x400014B")]
		Object,
		[Token(Token = "0x400014C")]
		Array,
		[Token(Token = "0x400014D")]
		String,
		[Token(Token = "0x400014E")]
		Int,
		[Token(Token = "0x400014F")]
		Long,
		[Token(Token = "0x4000150")]
		Double,
		[Token(Token = "0x4000151")]
		Boolean
	}
	[Token(Token = "0x2000064")]
	public interface IJsonWrapper : IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
	{
		[Token(Token = "0x17000031")]
		bool IsArray
		{
			[Token(Token = "0x60001C8")]
			get;
		}

		[Token(Token = "0x17000032")]
		bool IsBoolean
		{
			[Token(Token = "0x60001C9")]
			get;
		}

		[Token(Token = "0x17000033")]
		bool IsDouble
		{
			[Token(Token = "0x60001CA")]
			get;
		}

		[Token(Token = "0x17000034")]
		bool IsInt
		{
			[Token(Token = "0x60001CB")]
			get;
		}

		[Token(Token = "0x17000035")]
		bool IsLong
		{
			[Token(Token = "0x60001CC")]
			get;
		}

		[Token(Token = "0x17000036")]
		bool IsObject
		{
			[Token(Token = "0x60001CD")]
			get;
		}

		[Token(Token = "0x17000037")]
		bool IsString
		{
			[Token(Token = "0x60001CE")]
			get;
		}

		[Token(Token = "0x60001CF")]
		bool GetBoolean();

		[Token(Token = "0x60001D0")]
		double GetDouble();

		[Token(Token = "0x60001D1")]
		int GetInt();

		[Token(Token = "0x60001D2")]
		JsonType GetJsonType();

		[Token(Token = "0x60001D3")]
		long GetLong();

		[Token(Token = "0x60001D4")]
		string GetString();

		[Token(Token = "0x60001D5")]
		void SetBoolean(bool val);

		[Token(Token = "0x60001D6")]
		void SetDouble(double val);

		[Token(Token = "0x60001D7")]
		void SetInt(int val);

		[Token(Token = "0x60001D8")]
		void SetJsonType(JsonType type);

		[Token(Token = "0x60001D9")]
		void SetLong(long val);

		[Token(Token = "0x60001DA")]
		void SetString(string val);

		[Token(Token = "0x60001DB")]
		string ToJson();

		[Token(Token = "0x60001DC")]
		void ToJson(JsonWriter writer);
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x60FDF0", Offset = "0x60FDF0")]
	public class JsonData : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary, IEquatable<JsonData>
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IList<JsonData> inst_array;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inst_boolean;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private double inst_double;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int inst_int;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long inst_long;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IDictionary<string, JsonData> inst_object;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string inst_string;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string json;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private JsonType type;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IList<KeyValuePair<string, JsonData>> object_list;

		[Token(Token = "0x17000038")]
		public int Count
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x12AF420", Offset = "0x12AF420", VA = "0x12AF420")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000039")]
		public bool IsArray
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x12AF5AC", Offset = "0x12AF5AC", VA = "0x12AF5AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		public bool IsBoolean
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x12AF5BC", Offset = "0x12AF5BC", VA = "0x12AF5BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public bool IsDouble
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x12AF5CC", Offset = "0x12AF5CC", VA = "0x12AF5CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public bool IsInt
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x12AF5DC", Offset = "0x12AF5DC", VA = "0x12AF5DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		public bool IsLong
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x12AF5EC", Offset = "0x12AF5EC", VA = "0x12AF5EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		public bool IsObject
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x12AF5FC", Offset = "0x12AF5FC", VA = "0x12AF5FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public bool IsString
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x12AF60C", Offset = "0x12AF60C", VA = "0x12AF60C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x12AF61C", Offset = "0x12AF61C", VA = "0x12AF61C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private int System.Collections.ICollection.Count
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x12AF984", Offset = "0x12AF984", VA = "0x12AF984", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000042")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x12AF988", Offset = "0x12AF988", VA = "0x12AF988", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.ICollection.SyncRoot
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x12AFA40", Offset = "0x12AFA40", VA = "0x12AFA40", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private bool System.Collections.IDictionary.IsFixedSize
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x12AFAF8", Offset = "0x12AFAF8", VA = "0x12AFAF8", Slot = "54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		private bool System.Collections.IDictionary.IsReadOnly
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x12AFBB0", Offset = "0x12AFBB0", VA = "0x12AFBB0", Slot = "53")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		private ICollection System.Collections.IDictionary.Keys
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x12AFC68", Offset = "0x12AFC68", VA = "0x12AFC68", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		private ICollection System.Collections.IDictionary.Values
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x12B0030", Offset = "0x12B0030", VA = "0x12B0030", Slot = "49")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private bool LitJson.IJsonWrapper.IsArray
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x12B03F8", Offset = "0x12B03F8", VA = "0x12B03F8", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		private bool LitJson.IJsonWrapper.IsBoolean
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x12B0408", Offset = "0x12B0408", VA = "0x12B0408", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		private bool LitJson.IJsonWrapper.IsDouble
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x12B0418", Offset = "0x12B0418", VA = "0x12B0418", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		private bool LitJson.IJsonWrapper.IsInt
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x12B0428", Offset = "0x12B0428", VA = "0x12B0428", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		private bool LitJson.IJsonWrapper.IsLong
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x12B0438", Offset = "0x12B0438", VA = "0x12B0438", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		private bool LitJson.IJsonWrapper.IsObject
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x12B0448", Offset = "0x12B0448", VA = "0x12B0448", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		private bool LitJson.IJsonWrapper.IsString
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x12B0458", Offset = "0x12B0458", VA = "0x12B0458", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		private bool System.Collections.IList.IsFixedSize
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x12B0468", Offset = "0x12B0468", VA = "0x12B0468", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000050")]
		private bool System.Collections.IList.IsReadOnly
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x12B063C", Offset = "0x12B063C", VA = "0x12B063C", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		private object System.Collections.IDictionary.Item
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x12B06F4", Offset = "0x12B06F4", VA = "0x12B06F4", Slot = "46")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x12B07B8", Offset = "0x12B07B8", VA = "0x12B07B8", Slot = "47")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.Specialized.IOrderedDictionary.Item
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x12B0D00", Offset = "0x12B0D00", VA = "0x12B0D00", Slot = "41")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x12B0DD8", Offset = "0x12B0DD8", VA = "0x12B0DD8", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		private object System.Collections.IList.Item
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x12B1000", Offset = "0x12B1000", VA = "0x12B1000", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x12B10C4", Offset = "0x12B10C4", VA = "0x12B10C4", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public JsonData Item
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x12B13D4", Offset = "0x12B13D4", VA = "0x12B13D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x12B092C", Offset = "0x12B092C", VA = "0x12B092C")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public JsonData Item
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x12B1498", Offset = "0x12B1498", VA = "0x12B1498")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x12B1108", Offset = "0x12B1108", VA = "0x12B1108")]
			set
			{
			}
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x12AF83C", Offset = "0x12AF83C", VA = "0x12AF83C")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x12B1608", Offset = "0x12B1608", VA = "0x12B1608")]
		public JsonData()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x12B1610", Offset = "0x12B1610", VA = "0x12B1610")]
		public JsonData(bool boolean)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x12B1648", Offset = "0x12B1648", VA = "0x12B1648")]
		public JsonData(double number)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x12B1684", Offset = "0x12B1684", VA = "0x12B1684")]
		public JsonData(int number)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x12B16B8", Offset = "0x12B16B8", VA = "0x12B16B8")]
		public JsonData(long number)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x12B16EC", Offset = "0x12B16EC", VA = "0x12B16EC")]
		public JsonData(object obj)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x12B1920", Offset = "0x12B1920", VA = "0x12B1920")]
		public JsonData(string str)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x12B195C", Offset = "0x12B195C", VA = "0x12B195C")]
		public static implicit operator JsonData(bool data)
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x12B19C8", Offset = "0x12B19C8", VA = "0x12B19C8")]
		public static implicit operator JsonData(double data)
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x12B1A38", Offset = "0x12B1A38", VA = "0x12B1A38")]
		public static implicit operator JsonData(int data)
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x12B1AA0", Offset = "0x12B1AA0", VA = "0x12B1AA0")]
		public static implicit operator JsonData(long data)
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x12B1B08", Offset = "0x12B1B08", VA = "0x12B1B08")]
		public static implicit operator JsonData(string data)
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x12B1B7C", Offset = "0x12B1B7C", VA = "0x12B1B7C")]
		public static explicit operator bool(JsonData data)
		{
			return default(bool);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x12B1BF4", Offset = "0x12B1BF4", VA = "0x12B1BF4")]
		public static explicit operator double(JsonData data)
		{
			return default(double);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x12B1C6C", Offset = "0x12B1C6C", VA = "0x12B1C6C")]
		public static explicit operator int(JsonData data)
		{
			return default(int);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x12B1CF4", Offset = "0x12B1CF4", VA = "0x12B1CF4")]
		public static explicit operator long(JsonData data)
		{
			return default(long);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x12B1D7C", Offset = "0x12B1D7C", VA = "0x12B1D7C")]
		public static explicit operator string(JsonData data)
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x12B1DF4", Offset = "0x12B1DF4", VA = "0x12B1DF4", Slot = "36")]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x12B1EC0", Offset = "0x12B1EC0", VA = "0x12B1EC0", Slot = "51")]
		private void System.Collections.IDictionary.Add(object key, object value)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x12B20A0", Offset = "0x12B20A0", VA = "0x12B20A0", Slot = "52")]
		private void System.Collections.IDictionary.Clear()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x12B21E8", Offset = "0x12B21E8", VA = "0x12B21E8", Slot = "50")]
		private bool System.Collections.IDictionary.Contains(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x12B22B0", Offset = "0x12B22B0", VA = "0x12B22B0", Slot = "55")]
		private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x12B2354", Offset = "0x12B2354", VA = "0x12B2354", Slot = "56")]
		private void System.Collections.IDictionary.Remove(object key)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x12B260C", Offset = "0x12B260C", VA = "0x12B260C", Slot = "40")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x12B26C0", Offset = "0x12B26C0", VA = "0x12B26C0", Slot = "11")]
		private bool LitJson.IJsonWrapper.GetBoolean()
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x12B2728", Offset = "0x12B2728", VA = "0x12B2728", Slot = "12")]
		private double LitJson.IJsonWrapper.GetDouble()
		{
			return default(double);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x12B2790", Offset = "0x12B2790", VA = "0x12B2790", Slot = "13")]
		private int LitJson.IJsonWrapper.GetInt()
		{
			return default(int);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x12B27F8", Offset = "0x12B27F8", VA = "0x12B27F8", Slot = "15")]
		private long LitJson.IJsonWrapper.GetLong()
		{
			return default(long);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x12B2860", Offset = "0x12B2860", VA = "0x12B2860", Slot = "16")]
		private string LitJson.IJsonWrapper.GetString()
		{
			return null;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x12B28C8", Offset = "0x12B28C8", VA = "0x12B28C8", Slot = "17")]
		private void LitJson.IJsonWrapper.SetBoolean(bool val)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x12B28E4", Offset = "0x12B28E4", VA = "0x12B28E4", Slot = "18")]
		private void LitJson.IJsonWrapper.SetDouble(double val)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x12B28FC", Offset = "0x12B28FC", VA = "0x12B28FC", Slot = "19")]
		private void LitJson.IJsonWrapper.SetInt(int val)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x12B2914", Offset = "0x12B2914", VA = "0x12B2914", Slot = "21")]
		private void LitJson.IJsonWrapper.SetLong(long val)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x12B292C", Offset = "0x12B292C", VA = "0x12B292C", Slot = "22")]
		private void LitJson.IJsonWrapper.SetString(string val)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x12B2964", Offset = "0x12B2964", VA = "0x12B2964", Slot = "23")]
		private string LitJson.IJsonWrapper.ToJson()
		{
			return null;
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x12B2A3C", Offset = "0x12B2A3C", VA = "0x12B2A3C", Slot = "24")]
		private void LitJson.IJsonWrapper.ToJson(JsonWriter writer)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x12B2A74", Offset = "0x12B2A74", VA = "0x12B2A74", Slot = "27")]
		private int System.Collections.IList.Add(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x12B2B5C", Offset = "0x12B2B5C", VA = "0x12B2B5C", Slot = "29")]
		private void System.Collections.IList.Clear()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x12B2C24", Offset = "0x12B2C24", VA = "0x12B2C24", Slot = "28")]
		private bool System.Collections.IList.Contains(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x12B2CEC", Offset = "0x12B2CEC", VA = "0x12B2CEC", Slot = "32")]
		private int System.Collections.IList.IndexOf(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x12B2DB4", Offset = "0x12B2DB4", VA = "0x12B2DB4", Slot = "33")]
		private void System.Collections.IList.Insert(int index, object value)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x12B2E94", Offset = "0x12B2E94", VA = "0x12B2E94", Slot = "34")]
		private void System.Collections.IList.Remove(object value)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x12B2F6C", Offset = "0x12B2F6C", VA = "0x12B2F6C", Slot = "35")]
		private void System.Collections.IList.RemoveAt(int index)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x12B3044", Offset = "0x12B3044", VA = "0x12B3044", Slot = "43")]
		private IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x12B3134", Offset = "0x12B3134", VA = "0x12B3134", Slot = "44")]
		private void System.Collections.Specialized.IOrderedDictionary.Insert(int idx, object key, object value)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x12B3294", Offset = "0x12B3294", VA = "0x12B3294", Slot = "45")]
		private void System.Collections.Specialized.IOrderedDictionary.RemoveAt(int idx)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x12AF4D8", Offset = "0x12AF4D8", VA = "0x12AF4D8")]
		private ICollection EnsureCollection()
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x12AF6D4", Offset = "0x12AF6D4", VA = "0x12AF6D4")]
		private IDictionary EnsureDictionary()
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x12B0520", Offset = "0x12B0520", VA = "0x12B0520")]
		private IList EnsureList()
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x12B0894", Offset = "0x12B0894", VA = "0x12B0894")]
		private JsonData ToJsonData(object obj)
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x12B3464", Offset = "0x12B3464", VA = "0x12B3464")]
		private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x12B2A78", Offset = "0x12B2A78", VA = "0x12B2A78")]
		public int Add(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x12B4490", Offset = "0x12B4490", VA = "0x12B4490")]
		public bool Remove(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x12B4848", Offset = "0x12B4848", VA = "0x12B4848")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x12B496C", Offset = "0x12B496C", VA = "0x12B496C", Slot = "57")]
		public bool Equals(JsonData x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x12B4ABC", Offset = "0x12B4ABC", VA = "0x12B4ABC", Slot = "14")]
		public JsonType GetJsonType()
		{
			return default(JsonType);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x12B4AC4", Offset = "0x12B4AC4", VA = "0x12B4AC4", Slot = "20")]
		public void SetJsonType(JsonType type)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x12B2968", Offset = "0x12B2968", VA = "0x12B2968")]
		public string ToJson()
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x12B2A40", Offset = "0x12B2A40", VA = "0x12B2A40")]
		public void ToJson(JsonWriter writer)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x12B4CCC", Offset = "0x12B4CCC", VA = "0x12B4CCC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000066")]
	internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;

		[Token(Token = "0x17000056")]
		public object Current
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x12C4CB0", Offset = "0x12C4CB0", VA = "0x12C4CB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public DictionaryEntry Entry
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x12C4D18", Offset = "0x12C4D18", VA = "0x12C4D18", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Token(Token = "0x17000058")]
		public object Key
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x12C4E0C", Offset = "0x12C4E0C", VA = "0x12C4E0C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public object Value
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x12C4EC4", Offset = "0x12C4EC4", VA = "0x12C4EC4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x12C4F84", Offset = "0x12C4F84", VA = "0x12C4F84")]
		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x12C4FB8", Offset = "0x12C4FB8", VA = "0x12C4FB8", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x12C5064", Offset = "0x12C5064", VA = "0x12C5064", Slot = "9")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class JsonException : ApplicationException
	{
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x12B4DC0", Offset = "0x12B4DC0", VA = "0x12B4DC0")]
		public JsonException()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x12B4DC8", Offset = "0x12B4DC8", VA = "0x12B4DC8")]
		internal JsonException(ParserToken token)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x12B4E60", Offset = "0x12B4E60", VA = "0x12B4E60")]
		internal JsonException(ParserToken token, Exception inner_exception)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x12B4F08", Offset = "0x12B4F08", VA = "0x12B4F08")]
		internal JsonException(int c)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x12B4FA0", Offset = "0x12B4FA0", VA = "0x12B4FA0")]
		internal JsonException(int c, Exception inner_exception)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x12B5048", Offset = "0x12B5048", VA = "0x12B5048")]
		public JsonException(string message)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x12B5050", Offset = "0x12B5050", VA = "0x12B5050")]
		public JsonException(string message, Exception inner_exception)
		{
		}
	}
	[Token(Token = "0x2000068")]
	internal struct PropertyMetadata
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MemberInfo Info;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool IsField;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type Type;
	}
	[Token(Token = "0x2000069")]
	internal struct ArrayMetadata
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Type element_type;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool is_array;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private bool is_list;

		[Token(Token = "0x1700005A")]
		public Type ElementType
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x12A5598", Offset = "0x12A5598", VA = "0x12A5598")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x12A5660", Offset = "0x12A5660", VA = "0x12A5660")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public bool IsArray
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x12A5668", Offset = "0x12A5668", VA = "0x12A5668")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x12A5670", Offset = "0x12A5670", VA = "0x12A5670")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public bool IsList
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x12A567C", Offset = "0x12A567C", VA = "0x12A567C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x12A5684", Offset = "0x12A5684", VA = "0x12A5684")]
			set
			{
			}
		}
	}
	[Token(Token = "0x200006A")]
	internal struct ObjectMetadata
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Type element_type;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool is_dictionary;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IDictionary<string, PropertyMetadata> properties;

		[Token(Token = "0x1700005D")]
		public Type ElementType
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x12C493C", Offset = "0x12C493C", VA = "0x12C493C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x12C4A04", Offset = "0x12C4A04", VA = "0x12C4A04")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public bool IsDictionary
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x12C4A0C", Offset = "0x12C4A0C", VA = "0x12C4A0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x12C4A14", Offset = "0x12C4A14", VA = "0x12C4A14")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public IDictionary<string, PropertyMetadata> Properties
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x12C4A20", Offset = "0x12C4A20", VA = "0x12C4A20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x12C4A28", Offset = "0x12C4A28", VA = "0x12C4A28")]
			set
			{
			}
		}
	}
	[Token(Token = "0x200006B")]
	internal delegate void ExporterFunc(object obj, JsonWriter writer);
	[Token(Token = "0x200006C")]
	public delegate void ExporterFunc<T>(T obj, JsonWriter writer);
	[Token(Token = "0x200006D")]
	internal delegate object ImporterFunc(object input);
	[Token(Token = "0x200006E")]
	public delegate TValue ImporterFunc<TJson, TValue>(TJson input);
	[Token(Token = "0x200006F")]
	public delegate IJsonWrapper WrapperFactory();
	[Token(Token = "0x2000070")]
	public class JsonMapper
	{
		[Serializable]
		[Token(Token = "0x2000071")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FE28", Offset = "0x60FE28")]
		private sealed class <>c
		{
			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static WrapperFactory <>9__23_0;

			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static ExporterFunc <>9__24_0;

			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static ExporterFunc <>9__24_1;

			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static ExporterFunc <>9__24_2;

			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static ExporterFunc <>9__24_3;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static ExporterFunc <>9__24_4;

			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static ExporterFunc <>9__24_5;

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static ExporterFunc <>9__24_6;

			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static ExporterFunc <>9__24_7;

			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static ExporterFunc <>9__24_8;

			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static ExporterFunc <>9__24_9;

			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static ImporterFunc <>9__25_0;

			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static ImporterFunc <>9__25_1;

			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static ImporterFunc <>9__25_2;

			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static ImporterFunc <>9__25_3;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static ImporterFunc <>9__25_4;

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public static ImporterFunc <>9__25_5;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static ImporterFunc <>9__25_6;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public static ImporterFunc <>9__25_7;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public static ImporterFunc <>9__25_8;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public static ImporterFunc <>9__25_9;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public static ImporterFunc <>9__25_10;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public static ImporterFunc <>9__25_11;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public static ImporterFunc <>9__25_12;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public static ImporterFunc <>9__25_13;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public static ImporterFunc <>9__25_14;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			public static WrapperFactory <>9__30_0;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			public static WrapperFactory <>9__31_0;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			public static WrapperFactory <>9__32_0;

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x12DAE40", Offset = "0x12DAE40", VA = "0x12DAE40")]
			public <>c()
			{
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x12DAE48", Offset = "0x12DAE48", VA = "0x12DAE48")]
			internal IJsonWrapper <ReadSkip>b__23_0()
			{
				return null;
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x12DAEA0", Offset = "0x12DAEA0", VA = "0x12DAEA0")]
			internal void <RegisterBaseExporters>b__24_0(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x12DAF64", Offset = "0x12DAF64", VA = "0x12DAF64")]
			internal void <RegisterBaseExporters>b__24_1(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x600028C")]
			[Address(RVA = "0x12DB028", Offset = "0x12DB028", VA = "0x12DB028")]
			internal void <RegisterBaseExporters>b__24_2(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0x12DB12C", Offset = "0x12DB12C", VA = "0x12DB12C")]
			internal void <RegisterBaseExporters>b__24_3(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0x12DB1B8", Offset = "0x12DB1B8", VA = "0x12DB1B8")]
			internal void <RegisterBaseExporters>b__24_4(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0x12DB27C", Offset = "0x12DB27C", VA = "0x12DB27C")]
			internal void <RegisterBaseExporters>b__24_5(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x12DB340", Offset = "0x12DB340", VA = "0x12DB340")]
			internal void <RegisterBaseExporters>b__24_6(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0x12DB404", Offset = "0x12DB404", VA = "0x12DB404")]
			internal void <RegisterBaseExporters>b__24_7(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x6000292")]
			[Address(RVA = "0x12DB4C8", Offset = "0x12DB4C8", VA = "0x12DB4C8")]
			internal void <RegisterBaseExporters>b__24_8(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x6000293")]
			[Address(RVA = "0x12DB554", Offset = "0x12DB554", VA = "0x12DB554")]
			internal void <RegisterBaseExporters>b__24_9(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x6000294")]
			[Address(RVA = "0x12DB654", Offset = "0x12DB654", VA = "0x12DB654")]
			internal object <RegisterBaseImporters>b__25_0(object input)
			{
				return null;
			}

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x12DB72C", Offset = "0x12DB72C", VA = "0x12DB72C")]
			internal object <RegisterBaseImporters>b__25_1(object input)
			{
				return null;
			}

			[Token(Token = "0x6000296")]
			[Address(RVA = "0x12DB804", Offset = "0x12DB804", VA = "0x12DB804")]
			internal object <RegisterBaseImporters>b__25_2(object input)
			{
				return null;
			}

			[Token(Token = "0x6000297")]
			[Address(RVA = "0x12DB8DC", Offset = "0x12DB8DC", VA = "0x12DB8DC")]
			internal object <RegisterBaseImporters>b__25_3(object input)
			{
				return null;
			}

			[Token(Token = "0x6000298")]
			[Address(RVA = "0x12DB9B4", Offset = "0x12DB9B4", VA = "0x12DB9B4")]
			internal object <RegisterBaseImporters>b__25_4(object input)
			{
				return null;
			}

			[Token(Token = "0x6000299")]
			[Address(RVA = "0x12DBA8C", Offset = "0x12DBA8C", VA = "0x12DBA8C")]
			internal object <RegisterBaseImporters>b__25_5(object input)
			{
				return null;
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0x12DBB64", Offset = "0x12DBB64", VA = "0x12DBB64")]
			internal object <RegisterBaseImporters>b__25_6(object input)
			{
				return null;
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0x12DBC3C", Offset = "0x12DBC3C", VA = "0x12DBC3C")]
			internal object <RegisterBaseImporters>b__25_7(object input)
			{
				return null;
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0x12DBD10", Offset = "0x12DBD10", VA = "0x12DBD10")]
			internal object <RegisterBaseImporters>b__25_8(object input)
			{
				return null;
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0x12DBDE4", Offset = "0x12DBDE4", VA = "0x12DBDE4")]
			internal object <RegisterBaseImporters>b__25_9(object input)
			{
				return null;
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x12DBEBC", Offset = "0x12DBEBC", VA = "0x12DBEBC")]
			internal object <RegisterBaseImporters>b__25_10(object input)
			{
				return null;
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0x12DBF90", Offset = "0x12DBF90", VA = "0x12DBF90")]
			internal object <RegisterBaseImporters>b__25_11(object input)
			{
				return null;
			}

			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x12DC068", Offset = "0x12DC068", VA = "0x12DC068")]
			internal object <RegisterBaseImporters>b__25_12(object input)
			{
				return null;
			}

			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x12DC138", Offset = "0x12DC138", VA = "0x12DC138")]
			internal object <RegisterBaseImporters>b__25_13(object input)
			{
				return null;
			}

			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x12DC248", Offset = "0x12DC248", VA = "0x12DC248")]
			internal object <RegisterBaseImporters>b__25_14(object input)
			{
				return null;
			}

			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x12DC34C", Offset = "0x12DC34C", VA = "0x12DC34C")]
			internal IJsonWrapper <ToObject>b__30_0()
			{
				return null;
			}

			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x12DC3A4", Offset = "0x12DC3A4", VA = "0x12DC3A4")]
			internal IJsonWrapper <ToObject>b__31_0()
			{
				return null;
			}

			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x12DC3FC", Offset = "0x12DC3FC", VA = "0x12DC3FC")]
			internal IJsonWrapper <ToObject>b__32_0()
			{
				return null;
			}
		}

		[Token(Token = "0x2000072")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FE38", Offset = "0x60FE38")]
		private sealed class <>c__DisplayClass39_0<T>
		{
			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ExporterFunc<T> exporter;

			[Token(Token = "0x60002A6")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x60002A7")]
			internal void <RegisterExporter>b__0(object obj, JsonWriter writer)
			{
			}
		}

		[Token(Token = "0x2000073")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FE48", Offset = "0x60FE48")]
		private sealed class <>c__DisplayClass40_0<TJson, TValue>
		{
			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ImporterFunc<TJson, TValue> importer;

			[Token(Token = "0x60002A8")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x60002A9")]
			internal object <RegisterImporter>b__0(object input)
			{
				return null;
			}
		}

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int max_nesting_depth;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly IFormatProvider datetime_format;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly IDictionary<Type, ExporterFunc> base_exporters_table;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly IDictionary<Type, ExporterFunc> custom_exporters_table;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly IDictionary<Type, ArrayMetadata> array_metadata;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly object array_metadata_lock;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly object conv_ops_lock;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly IDictionary<Type, ObjectMetadata> object_metadata;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly object object_metadata_lock;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly IDictionary<Type, IList<PropertyMetadata>> type_properties;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly object type_properties_lock;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static readonly JsonWriter static_writer;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static readonly object static_writer_lock;

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x12B5060", Offset = "0x12B5060", VA = "0x12B5060")]
		static JsonMapper()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x12B766C", Offset = "0x12B766C", VA = "0x12B766C")]
		private static void AddArrayMetadata(Type type)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x12B7B4C", Offset = "0x12B7B4C", VA = "0x12B7B4C")]
		private static void AddObjectMetadata(Type type)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x12B832C", Offset = "0x12B832C", VA = "0x12B832C")]
		private static void AddTypeProperties(Type type)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x12B88E4", Offset = "0x12B88E4", VA = "0x12B88E4")]
		private static MethodInfo GetConvOp(Type t1, Type t2)
		{
			return null;
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x12B9274", Offset = "0x12B9274", VA = "0x12B9274")]
		private static object ReadValue(Type inst_type, JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x12BA914", Offset = "0x12BA914", VA = "0x12BA914")]
		private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x12BA7F4", Offset = "0x12BA7F4", VA = "0x12BA7F4")]
		private static void ReadSkip(JsonReader reader)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x12B550C", Offset = "0x12B550C", VA = "0x12B550C")]
		private static void RegisterBaseExporters()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x12B6484", Offset = "0x12B6484", VA = "0x12B6484")]
		private static void RegisterBaseImporters()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x12BB078", Offset = "0x12BB078", VA = "0x12BB078")]
		private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x12BB2DC", Offset = "0x12BB2DC", VA = "0x12BB2DC")]
		private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x12BCBEC", Offset = "0x12BCBEC", VA = "0x12BCBEC")]
		public static string ToJson(object obj, bool prettyPrint = true)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x12BCE98", Offset = "0x12BCE98", VA = "0x12BCE98")]
		public static void ToJson(object obj, JsonWriter writer)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x12BCF10", Offset = "0x12BCF10", VA = "0x12BCF10")]
		public static JsonData ToObject(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x12BD07C", Offset = "0x12BD07C", VA = "0x12BD07C")]
		public static JsonData ToObject(TextReader reader)
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x12BD21C", Offset = "0x12BD21C", VA = "0x12BD21C")]
		public static JsonData ToObject(string json)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		public static T ToObject<T>(JsonReader reader)
		{
			return (T)null;
		}

		[Token(Token = "0x600027D")]
		public static T ToObject<T>(TextReader reader)
		{
			return (T)null;
		}

		[Token(Token = "0x600027E")]
		public static T ToObject<T>(string json)
		{
			return (T)null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x12BD420", Offset = "0x12BD420", VA = "0x12BD420")]
		public static object ToObject(string json, Type ConvertType)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x12BB008", Offset = "0x12BB008", VA = "0x12BB008")]
		public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x12BD388", Offset = "0x12BD388", VA = "0x12BD388")]
		public static IJsonWrapper ToWrapper(WrapperFactory factory, string json)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		public static void RegisterExporter<T>(ExporterFunc<T> exporter)
		{
		}

		[Token(Token = "0x6000283")]
		public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x12BD52C", Offset = "0x12BD52C", VA = "0x12BD52C")]
		public static void UnregisterExporters()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x12BD60C", Offset = "0x12BD60C", VA = "0x12BD60C")]
		public static void UnregisterImporters()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x12BD6EC", Offset = "0x12BD6EC", VA = "0x12BD6EC")]
		public JsonMapper()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class JsonMockWrapper : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
	{
		[Token(Token = "0x17000060")]
		public bool IsArray
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x12BD8B0", Offset = "0x12BD8B0", VA = "0x12BD8B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		public bool IsBoolean
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x12BD8B8", Offset = "0x12BD8B8", VA = "0x12BD8B8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000062")]
		public bool IsDouble
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x12BD8C0", Offset = "0x12BD8C0", VA = "0x12BD8C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000063")]
		public bool IsInt
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x12BD8C8", Offset = "0x12BD8C8", VA = "0x12BD8C8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		public bool IsLong
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x12BD8D0", Offset = "0x12BD8D0", VA = "0x12BD8D0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		public bool IsObject
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x12BD8D8", Offset = "0x12BD8D8", VA = "0x12BD8D8", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		public bool IsString
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x12BD8E0", Offset = "0x12BD8E0", VA = "0x12BD8E0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		private bool System.Collections.IList.IsFixedSize
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x12BD9B4", Offset = "0x12BD9B4", VA = "0x12BD9B4", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		private bool System.Collections.IList.IsReadOnly
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x12BD9BC", Offset = "0x12BD9BC", VA = "0x12BD9BC", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		private object System.Collections.IList.Item
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x12BD9C4", Offset = "0x12BD9C4", VA = "0x12BD9C4", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x12BD9CC", Offset = "0x12BD9CC", VA = "0x12BD9CC", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		private int System.Collections.ICollection.Count
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x12BD9F8", Offset = "0x12BD9F8", VA = "0x12BD9F8", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006B")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x12BDA00", Offset = "0x12BDA00", VA = "0x12BDA00", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		private object System.Collections.ICollection.SyncRoot
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x12BDA08", Offset = "0x12BDA08", VA = "0x12BDA08", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		private bool System.Collections.IDictionary.IsFixedSize
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x12BDA1C", Offset = "0x12BDA1C", VA = "0x12BDA1C", Slot = "54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		private bool System.Collections.IDictionary.IsReadOnly
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x12BDA24", Offset = "0x12BDA24", VA = "0x12BDA24", Slot = "53")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		private ICollection System.Collections.IDictionary.Keys
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x12BDA2C", Offset = "0x12BDA2C", VA = "0x12BDA2C", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		private ICollection System.Collections.IDictionary.Values
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x12BDA34", Offset = "0x12BDA34", VA = "0x12BDA34", Slot = "49")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private object System.Collections.IDictionary.Item
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x12BDA3C", Offset = "0x12BDA3C", VA = "0x12BDA3C", Slot = "46")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x12BDA44", Offset = "0x12BDA44", VA = "0x12BDA44", Slot = "47")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		private object System.Collections.Specialized.IOrderedDictionary.Item
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x12BDA64", Offset = "0x12BDA64", VA = "0x12BDA64", Slot = "41")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x12BDA6C", Offset = "0x12BDA6C", VA = "0x12BDA6C", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x12BD8E8", Offset = "0x12BD8E8", VA = "0x12BD8E8", Slot = "11")]
		public bool GetBoolean()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x12BD8F0", Offset = "0x12BD8F0", VA = "0x12BD8F0", Slot = "12")]
		public double GetDouble()
		{
			return default(double);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x12BD8F8", Offset = "0x12BD8F8", VA = "0x12BD8F8", Slot = "13")]
		public int GetInt()
		{
			return default(int);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x12BD900", Offset = "0x12BD900", VA = "0x12BD900", Slot = "14")]
		public JsonType GetJsonType()
		{
			return default(JsonType);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x12BD908", Offset = "0x12BD908", VA = "0x12BD908", Slot = "15")]
		public long GetLong()
		{
			return default(long);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x12BD910", Offset = "0x12BD910", VA = "0x12BD910", Slot = "16")]
		public string GetString()
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x12BD954", Offset = "0x12BD954", VA = "0x12BD954", Slot = "17")]
		public void SetBoolean(bool val)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x12BD958", Offset = "0x12BD958", VA = "0x12BD958", Slot = "18")]
		public void SetDouble(double val)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x12BD95C", Offset = "0x12BD95C", VA = "0x12BD95C", Slot = "19")]
		public void SetInt(int val)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x12BD960", Offset = "0x12BD960", VA = "0x12BD960", Slot = "20")]
		public void SetJsonType(JsonType type)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x12BD964", Offset = "0x12BD964", VA = "0x12BD964", Slot = "21")]
		public void SetLong(long val)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x12BD968", Offset = "0x12BD968", VA = "0x12BD968", Slot = "22")]
		public void SetString(string val)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x12BD96C", Offset = "0x12BD96C", VA = "0x12BD96C", Slot = "23")]
		public string ToJson()
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x12BD9B0", Offset = "0x12BD9B0", VA = "0x12BD9B0", Slot = "24")]
		public void ToJson(JsonWriter writer)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x12BD9D0", Offset = "0x12BD9D0", VA = "0x12BD9D0", Slot = "27")]
		private int System.Collections.IList.Add(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x12BD9D8", Offset = "0x12BD9D8", VA = "0x12BD9D8", Slot = "29")]
		private void System.Collections.IList.Clear()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x12BD9DC", Offset = "0x12BD9DC", VA = "0x12BD9DC", Slot = "28")]
		private bool System.Collections.IList.Contains(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x12BD9E4", Offset = "0x12BD9E4", VA = "0x12BD9E4", Slot = "32")]
		private int System.Collections.IList.IndexOf(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x12BD9EC", Offset = "0x12BD9EC", VA = "0x12BD9EC", Slot = "33")]
		private void System.Collections.IList.Insert(int i, object v)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x12BD9F0", Offset = "0x12BD9F0", VA = "0x12BD9F0", Slot = "34")]
		private void System.Collections.IList.Remove(object value)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x12BD9F4", Offset = "0x12BD9F4", VA = "0x12BD9F4", Slot = "35")]
		private void System.Collections.IList.RemoveAt(int index)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x12BDA10", Offset = "0x12BDA10", VA = "0x12BDA10", Slot = "36")]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x12BDA14", Offset = "0x12BDA14", VA = "0x12BDA14", Slot = "40")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x12BDA48", Offset = "0x12BDA48", VA = "0x12BDA48", Slot = "51")]
		private void System.Collections.IDictionary.Add(object k, object v)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x12BDA4C", Offset = "0x12BDA4C", VA = "0x12BDA4C", Slot = "52")]
		private void System.Collections.IDictionary.Clear()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x12BDA50", Offset = "0x12BDA50", VA = "0x12BDA50", Slot = "50")]
		private bool System.Collections.IDictionary.Contains(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x12BDA58", Offset = "0x12BDA58", VA = "0x12BDA58", Slot = "56")]
		private void System.Collections.IDictionary.Remove(object key)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x12BDA5C", Offset = "0x12BDA5C", VA = "0x12BDA5C", Slot = "55")]
		private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x12BDA70", Offset = "0x12BDA70", VA = "0x12BDA70", Slot = "43")]
		private IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x12BDA78", Offset = "0x12BDA78", VA = "0x12BDA78", Slot = "44")]
		private void System.Collections.Specialized.IOrderedDictionary.Insert(int i, object k, object v)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x12BDA7C", Offset = "0x12BDA7C", VA = "0x12BDA7C", Slot = "45")]
		private void System.Collections.Specialized.IOrderedDictionary.RemoveAt(int i)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x12BDA80", Offset = "0x12BDA80", VA = "0x12BDA80")]
		public JsonMockWrapper()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public enum JsonToken
	{
		[Token(Token = "0x4000197")]
		None,
		[Token(Token = "0x4000198")]
		ObjectStart,
		[Token(Token = "0x4000199")]
		PropertyName,
		[Token(Token = "0x400019A")]
		ObjectEnd,
		[Token(Token = "0x400019B")]
		ArrayStart,
		[Token(Token = "0x400019C")]
		ArrayEnd,
		[Token(Token = "0x400019D")]
		Int,
		[Token(Token = "0x400019E")]
		Long,
		[Token(Token = "0x400019F")]
		Double,
		[Token(Token = "0x40001A0")]
		String,
		[Token(Token = "0x40001A1")]
		Boolean,
		[Token(Token = "0x40001A2")]
		Null
	}
	[Token(Token = "0x2000076")]
	public class JsonReader
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IDictionary<int, IDictionary<int, int[]>> parse_table;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Stack<int> automaton_stack;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int current_input;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int current_symbol;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool end_of_json;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool end_of_input;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Lexer lexer;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool parser_in_string;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool parser_return;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool read_started;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextReader reader;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool reader_is_owned;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool skip_non_members;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private object token_value;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private JsonToken token;

		[Token(Token = "0x17000073")]
		public bool AllowComments
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x12BDA88", Offset = "0x12BDA88", VA = "0x12BDA88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x12BDAA4", Offset = "0x12BDAA4", VA = "0x12BDAA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x12BDAC4", Offset = "0x12BDAC4", VA = "0x12BDAC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x12BDAE0", Offset = "0x12BDAE0", VA = "0x12BDAE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public bool SkipNonMembers
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x12BDB00", Offset = "0x12BDB00", VA = "0x12BDB00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x12BDB08", Offset = "0x12BDB08", VA = "0x12BDB08")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public bool EndOfInput
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x12BDB14", Offset = "0x12BDB14", VA = "0x12BDB14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public bool EndOfJson
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x12BDB1C", Offset = "0x12BDB1C", VA = "0x12BDB1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		public JsonToken Token
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x12BDB24", Offset = "0x12BDB24", VA = "0x12BDB24")]
			get
			{
				return default(JsonToken);
			}
		}

		[Token(Token = "0x17000079")]
		public object Value
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x12BDB2C", Offset = "0x12BDB2C", VA = "0x12BDB2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x12BDB34", Offset = "0x12BDB34", VA = "0x12BDB34")]
		static JsonReader()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x12BD4B8", Offset = "0x12BD4B8", VA = "0x12BD4B8")]
		public JsonReader(string json_text)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x12BD214", Offset = "0x12BD214", VA = "0x12BD214")]
		public JsonReader(TextReader reader)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x12BE300", Offset = "0x12BE300", VA = "0x12BE300")]
		private JsonReader(TextReader reader, bool owned)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x12BDB8C", Offset = "0x12BDB8C", VA = "0x12BDB8C")]
		private static IDictionary<int, IDictionary<int, int[]>> PopulateParseTable()
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x12BE5A0", Offset = "0x12BE5A0", VA = "0x12BE5A0")]
		private static void TableAddCol(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken row, int col, params int[] symbols)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x12BE4A4", Offset = "0x12BE4A4", VA = "0x12BE4A4")]
		private static void TableAddRow(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken rule)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x12BE6F0", Offset = "0x12BE6F0", VA = "0x12BE6F0")]
		private void ProcessNumber(string number)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x12BE990", Offset = "0x12BE990", VA = "0x12BE990")]
		private void ProcessSymbol()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x12BEB54", Offset = "0x12BEB54", VA = "0x12BEB54")]
		private bool ReadToken()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x12BEBB8", Offset = "0x12BEBB8", VA = "0x12BEBB8")]
		public void Close()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x12BA360", Offset = "0x12BA360", VA = "0x12BA360")]
		public bool Read()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000077")]
	internal enum Condition
	{
		[Token(Token = "0x40001B3")]
		InArray,
		[Token(Token = "0x40001B4")]
		InObject,
		[Token(Token = "0x40001B5")]
		NotAProperty,
		[Token(Token = "0x40001B6")]
		Property,
		[Token(Token = "0x40001B7")]
		Value
	}
	[Token(Token = "0x2000078")]
	internal class WriterContext
	{
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Count;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool InArray;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool InObject;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public bool ExpectingValue;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Padding;

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x12D6A10", Offset = "0x12D6A10", VA = "0x12D6A10")]
		public WriterContext()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class JsonWriter
	{
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly NumberFormatInfo number_format;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private WriterContext context;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Stack<WriterContext> ctx_stack;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool has_reached_end;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private char[] hex_seq;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int indentation;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int indent_value;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private StringBuilder inst_string_builder;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool pretty_print;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool validate;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool lower_case_properties;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextWriter writer;

		[Token(Token = "0x1700007A")]
		public int IndentValue
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x12BEC98", Offset = "0x12BEC98", VA = "0x12BEC98")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x12BECA0", Offset = "0x12BECA0", VA = "0x12BECA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public bool PrettyPrint
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x12BECB4", Offset = "0x12BECB4", VA = "0x12BECB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x12BECBC", Offset = "0x12BECBC", VA = "0x12BECBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public TextWriter TextWriter
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x12BECC8", Offset = "0x12BECC8", VA = "0x12BECC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public bool Validate
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x12BECD0", Offset = "0x12BECD0", VA = "0x12BECD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x12BECD8", Offset = "0x12BECD8", VA = "0x12BECD8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public bool LowerCaseProperties
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x12BECE4", Offset = "0x12BECE4", VA = "0x12BECE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x12BECEC", Offset = "0x12BECEC", VA = "0x12BECEC")]
			set
			{
			}
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x12BECF8", Offset = "0x12BECF8", VA = "0x12BECF8")]
		static JsonWriter()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x12B544C", Offset = "0x12B544C", VA = "0x12B544C")]
		public JsonWriter()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x12BEE88", Offset = "0x12BEE88", VA = "0x12BEE88")]
		public JsonWriter(StringBuilder sb)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x12B4C44", Offset = "0x12B4C44", VA = "0x12B4C44")]
		public JsonWriter(TextWriter writer)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x12BEEF8", Offset = "0x12BEEF8", VA = "0x12BEEF8")]
		private void DoValidation(Condition cond)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x12BED54", Offset = "0x12BED54", VA = "0x12BED54")]
		private void Init()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x12BF0BC", Offset = "0x12BF0BC", VA = "0x12BF0BC")]
		private static void IntToHex(int n, char[] hex)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x12BF144", Offset = "0x12BF144", VA = "0x12BF144")]
		private void Indent()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x12BF15C", Offset = "0x12BF15C", VA = "0x12BF15C")]
		private void Put(string str)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x12BF1F0", Offset = "0x12BF1F0", VA = "0x12BF1F0")]
		private void PutNewline()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x12BF1F8", Offset = "0x12BF1F8", VA = "0x12BF1F8")]
		private void PutNewline(bool add_comma)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x12BF298", Offset = "0x12BF298", VA = "0x12BF298")]
		private void PutString(string str)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x12BF590", Offset = "0x12BF590", VA = "0x12BF590")]
		private void Unindent()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x12BF5A8", Offset = "0x12BF5A8", VA = "0x12BF5A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x12BCD9C", Offset = "0x12BCD9C", VA = "0x12BCD9C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x12AC2F8", Offset = "0x12AC2F8", VA = "0x12AC2F8")]
		public void Write(bool boolean)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x12BF614", Offset = "0x12BF614", VA = "0x12BF614")]
		public void Write(decimal number)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x12AC3D8", Offset = "0x12AC3D8", VA = "0x12AC3D8")]
		public void Write(double number)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x12BCA1C", Offset = "0x12BCA1C", VA = "0x12BCA1C")]
		public void Write(float number)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x12B3FB0", Offset = "0x12B3FB0", VA = "0x12B3FB0")]
		public void Write(int number)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x12AC110", Offset = "0x12AC110", VA = "0x12AC110")]
		public void Write(long number)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x12AC22C", Offset = "0x12AC22C", VA = "0x12AC22C")]
		public void Write(string str)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x12BCB04", Offset = "0x12BCB04", VA = "0x12BCB04")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x6104D4", Offset = "0x6104D4")]
		public void Write(ulong number)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x12B4190", Offset = "0x12B4190", VA = "0x12B4190")]
		public void WriteArrayEnd()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x12B4098", Offset = "0x12B4098", VA = "0x12B4098")]
		public void WriteArrayStart()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x12B438C", Offset = "0x12B438C", VA = "0x12B438C")]
		public void WriteObjectEnd()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x12B4294", Offset = "0x12B4294", VA = "0x12B4294")]
		public void WriteObjectStart()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x12ABFCC", Offset = "0x12ABFCC", VA = "0x12ABFCC")]
		public void WritePropertyName(string property_name)
		{
		}
	}
	[Token(Token = "0x200007A")]
	internal class FsmContext
	{
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool Return;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int NextState;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Lexer L;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int StateStack;

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x12AC528", Offset = "0x12AC528", VA = "0x12AC528")]
		public FsmContext()
		{
		}
	}
	[Token(Token = "0x200007B")]
	internal class Lexer
	{
		[Token(Token = "0x200007C")]
		private delegate bool StateHandler(FsmContext ctx);

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] fsm_return_table;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly StateHandler[] fsm_handler_table;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool allow_comments;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool allow_single_quoted_strings;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		private bool end_of_input;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FsmContext fsm_context;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int input_buffer;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int input_char;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextReader reader;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int state;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private StringBuilder string_buffer;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string string_value;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int token;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int unichar;

		[Token(Token = "0x1700007F")]
		public bool AllowComments
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x12C0704", Offset = "0x12C0704", VA = "0x12C0704")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x12C070C", Offset = "0x12C070C", VA = "0x12C070C")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x12C0718", Offset = "0x12C0718", VA = "0x12C0718")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x12C0720", Offset = "0x12C0720", VA = "0x12C0720")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public bool EndOfInput
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x12C072C", Offset = "0x12C072C", VA = "0x12C072C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000082")]
		public int Token
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x12C0734", Offset = "0x12C0734", VA = "0x12C0734")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000083")]
		public string StringValue
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x12C073C", Offset = "0x12C073C", VA = "0x12C073C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x12C0744", Offset = "0x12C0744", VA = "0x12C0744")]
		static Lexer()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x12C1380", Offset = "0x12C1380", VA = "0x12C1380")]
		public Lexer(TextReader reader)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x12C147C", Offset = "0x12C147C", VA = "0x12C147C")]
		private static int HexValue(int digit)
		{
			return default(int);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x12C0790", Offset = "0x12C0790", VA = "0x12C0790")]
		private static void PopulateFsmTables(out StateHandler[] fsm_handler_table, out int[] fsm_return_table)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x12C14F8", Offset = "0x12C14F8", VA = "0x12C14F8")]
		private static char ProcessEscChar(int esc_char)
		{
			return default(char);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x12C15F4", Offset = "0x12C15F4", VA = "0x12C15F4")]
		private static bool State1(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x12C1804", Offset = "0x12C1804", VA = "0x12C1804")]
		private static bool State2(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x12C18AC", Offset = "0x12C18AC", VA = "0x12C18AC")]
		private static bool State3(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x12C19EC", Offset = "0x12C19EC", VA = "0x12C19EC")]
		private static bool State4(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x12C1AEC", Offset = "0x12C1AEC", VA = "0x12C1AEC")]
		private static bool State5(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x12C1B70", Offset = "0x12C1B70", VA = "0x12C1B70")]
		private static bool State6(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x12C1C6C", Offset = "0x12C1C6C", VA = "0x12C1C6C")]
		private static bool State7(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x12C1D04", Offset = "0x12C1D04", VA = "0x12C1D04")]
		private static bool State8(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x12C1DC4", Offset = "0x12C1DC4", VA = "0x12C1DC4")]
		private static bool State9(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x12C1E34", Offset = "0x12C1E34", VA = "0x12C1E34")]
		private static bool State10(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x12C1EA4", Offset = "0x12C1EA4", VA = "0x12C1EA4")]
		private static bool State11(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x12C1F14", Offset = "0x12C1F14", VA = "0x12C1F14")]
		private static bool State12(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x12C1F84", Offset = "0x12C1F84", VA = "0x12C1F84")]
		private static bool State13(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x12C1FF4", Offset = "0x12C1FF4", VA = "0x12C1FF4")]
		private static bool State14(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x12C2064", Offset = "0x12C2064", VA = "0x12C2064")]
		private static bool State15(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x12C20D4", Offset = "0x12C20D4", VA = "0x12C20D4")]
		private static bool State16(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x12C2144", Offset = "0x12C2144", VA = "0x12C2144")]
		private static bool State17(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x12C21B4", Offset = "0x12C21B4", VA = "0x12C21B4")]
		private static bool State18(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x12C2224", Offset = "0x12C2224", VA = "0x12C2224")]
		private static bool State19(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x12C22D0", Offset = "0x12C22D0", VA = "0x12C22D0")]
		private static bool State20(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x12C2340", Offset = "0x12C2340", VA = "0x12C2340")]
		private static bool State21(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x12C2488", Offset = "0x12C2488", VA = "0x12C2488")]
		private static bool State22(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x12C2614", Offset = "0x12C2614", VA = "0x12C2614")]
		private static bool State23(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x12C26C0", Offset = "0x12C26C0", VA = "0x12C26C0")]
		private static bool State24(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x12C2738", Offset = "0x12C2738", VA = "0x12C2738")]
		private static bool State25(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x12C27B8", Offset = "0x12C27B8", VA = "0x12C27B8")]
		private static bool State26(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x12C2824", Offset = "0x12C2824", VA = "0x12C2824")]
		private static bool State27(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x12C2890", Offset = "0x12C2890", VA = "0x12C2890")]
		private static bool State28(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x12C17CC", Offset = "0x12C17CC", VA = "0x12C17CC")]
		private bool GetChar()
		{
			return default(bool);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x12C290C", Offset = "0x12C290C", VA = "0x12C290C")]
		private int NextChar()
		{
			return default(int);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x12C2940", Offset = "0x12C2940", VA = "0x12C2940")]
		public bool NextToken()
		{
			return default(bool);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x12C19E0", Offset = "0x12C19E0", VA = "0x12C19E0")]
		private void UngetChar()
		{
		}
	}
	[Token(Token = "0x200007D")]
	internal enum ParserToken
	{
		[Token(Token = "0x40001DC")]
		None = 65536,
		[Token(Token = "0x40001DD")]
		Number,
		[Token(Token = "0x40001DE")]
		True,
		[Token(Token = "0x40001DF")]
		False,
		[Token(Token = "0x40001E0")]
		Null,
		[Token(Token = "0x40001E1")]
		CharSeq,
		[Token(Token = "0x40001E2")]
		Char,
		[Token(Token = "0x40001E3")]
		Text,
		[Token(Token = "0x40001E4")]
		Object,
		[Token(Token = "0x40001E5")]
		ObjectPrime,
		[Token(Token = "0x40001E6")]
		Pair,
		[Token(Token = "0x40001E7")]
		PairRest,
		[Token(Token = "0x40001E8")]
		Array,
		[Token(Token = "0x40001E9")]
		ArrayPrime,
		[Token(Token = "0x40001EA")]
		Value,
		[Token(Token = "0x40001EB")]
		ValueRest,
		[Token(Token = "0x40001EC")]
		String,
		[Token(Token = "0x40001ED")]
		End,
		[Token(Token = "0x40001EE")]
		Epsilon
	}
	[Token(Token = "0x200007E")]
	public static class UnityTypeBindings
	{
		[Token(Token = "0x200007F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FE58", Offset = "0x60FE58")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<Vector2, JsonWriter> writeVector2;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<Vector3, JsonWriter> writeVector3;

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x12D53E0", Offset = "0x12D53E0", VA = "0x12D53E0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0x12DF7AC", Offset = "0x12DF7AC", VA = "0x12DF7AC")]
			internal void <Register>b__3(Vector2 v, JsonWriter w)
			{
			}

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x12DF828", Offset = "0x12DF828", VA = "0x12DF828")]
			internal void <Register>b__5(Vector3 v, JsonWriter w)
			{
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x12DF8B4", Offset = "0x12DF8B4", VA = "0x12DF8B4")]
			internal void <Register>b__10(Bounds v, JsonWriter w)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000080")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FE68", Offset = "0x60FE68")]
		private sealed class <>c
		{
			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static ExporterFunc<Type> <>9__2_0;

			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static ImporterFunc<string, Type> <>9__2_1;

			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Action<Vector2, JsonWriter> <>9__2_2;

			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Action<Vector3, JsonWriter> <>9__2_4;

			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static ExporterFunc<Vector4> <>9__2_6;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static ExporterFunc<Quaternion> <>9__2_7;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static ExporterFunc<Color> <>9__2_8;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static ExporterFunc<Color32> <>9__2_9;

			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static ExporterFunc<Rect> <>9__2_11;

			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static ExporterFunc<RectOffset> <>9__2_12;

			[Token(Token = "0x6000354")]
			[Address(RVA = "0x12DEEC8", Offset = "0x12DEEC8", VA = "0x12DEEC8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000355")]
			[Address(RVA = "0x12DEED0", Offset = "0x12DEED0", VA = "0x12DEED0")]
			internal void <Register>b__2_0(Type v, JsonWriter w)
			{
			}

			[Token(Token = "0x6000356")]
			[Address(RVA = "0x12DEF18", Offset = "0x12DEF18", VA = "0x12DEF18")]
			internal Type <Register>b__2_1(string s)
			{
				return null;
			}

			[Token(Token = "0x6000357")]
			[Address(RVA = "0x12DEFA8", Offset = "0x12DEFA8", VA = "0x12DEFA8")]
			internal void <Register>b__2_2(Vector2 v, JsonWriter w)
			{
			}

			[Token(Token = "0x6000358")]
			[Address(RVA = "0x12DF054", Offset = "0x12DF054", VA = "0x12DF054")]
			internal void <Register>b__2_4(Vector3 v, JsonWriter w)
			{
			}

			[Token(Token = "0x6000359")]
			[Address(RVA = "0x12DF134", Offset = "0x12DF134", VA = "0x12DF134")]
			internal void <Register>b__2_6(Vector4 v, JsonWriter w)
			{
			}

			[Token(Token = "0x600035A")]
			[Address(RVA = "0x12DF240", Offset = "0x12DF240", VA = "0x12DF240")]
			internal void <Register>b__2_7(Quaternion v, JsonWriter w)
			{
			}

			[Token(Token = "0x600035B")]
			[Address(RVA = "0x12DF34C", Offset = "0x12DF34C", VA = "0x12DF34C")]
			internal void <Register>b__2_8(Color v, JsonWriter w)
			{
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0x12DF458", Offset = "0x12DF458", VA = "0x12DF458")]
			internal void <Register>b__2_9(Color32 v, JsonWriter w)
			{
			}

			[Token(Token = "0x600035D")]
			[Address(RVA = "0x12DF550", Offset = "0x12DF550", VA = "0x12DF550")]
			internal void <Register>b__2_11(Rect v, JsonWriter w)
			{
			}

			[Token(Token = "0x600035E")]
			[Address(RVA = "0x12DF680", Offset = "0x12DF680", VA = "0x12DF680")]
			internal void <Register>b__2_12(RectOffset v, JsonWriter w)
			{
			}
		}

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool registerd;

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x12D4858", Offset = "0x12D4858", VA = "0x12D4858")]
		static UnityTypeBindings()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x12D485C", Offset = "0x12D485C", VA = "0x12D485C")]
		public static void Register()
		{
		}
	}
}
namespace LitJson.Extensions
{
	[Token(Token = "0x2000081")]
	public static class Extensions
	{
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x12ABF98", Offset = "0x12ABF98", VA = "0x12ABF98")]
		public static void WriteProperty(this JsonWriter w, string name, long value)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x12AC1F8", Offset = "0x12AC1F8", VA = "0x12AC1F8")]
		public static void WriteProperty(this JsonWriter w, string name, string value)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x12AC2C4", Offset = "0x12AC2C4", VA = "0x12AC2C4")]
		public static void WriteProperty(this JsonWriter w, string name, bool value)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x12AC39C", Offset = "0x12AC39C", VA = "0x12AC39C")]
		public static void WriteProperty(this JsonWriter w, string name, double value)
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x60FE88", Offset = "0x60FE88")]
	public sealed class JsonIgnore : Attribute
	{
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x12B5058", Offset = "0x12B5058", VA = "0x12B5058")]
		public JsonIgnore()
		{
		}
	}
}
namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000083")]
	public class TMP_DigitValidator : TMP_InputValidator
	{
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x12CAEA0", Offset = "0x12CAEA0", VA = "0x12CAEA0", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x12CAF24", Offset = "0x12CAF24", VA = "0x12CAF24")]
		public TMP_DigitValidator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class TMP_PhoneNumberValidator : TMP_InputValidator
	{
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x12CB7CC", Offset = "0x12CB7CC", VA = "0x12CB7CC", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x12CBC4C", Offset = "0x12CBC4C", VA = "0x12CBC4C")]
		public TMP_PhoneNumberValidator()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Serializable]
		[Token(Token = "0x2000086")]
		public class CharacterSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x12DDB28", Offset = "0x12DDB28", VA = "0x12DDB28")]
			public CharacterSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000087")]
		public class SpriteSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x12DDC0C", Offset = "0x12DDC0C", VA = "0x12DDC0C")]
			public SpriteSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000088")]
		public class WordSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x12DDC58", Offset = "0x12DDC58", VA = "0x12DDC58")]
			public WordSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000089")]
		public class LineSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x12DDB74", Offset = "0x12DDB74", VA = "0x12DDB74")]
			public LineSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public class LinkSelectionEvent : UnityEvent<string, string, int>
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x12DDBC0", Offset = "0x12DDBC0", VA = "0x12DDBC0")]
			public LinkSelectionEvent()
			{
			}
		}

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterSelectionEvent m_OnCharacterSelection;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpriteSelectionEvent m_OnSpriteSelection;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WordSelectionEvent m_OnWordSelection;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LineSelectionEvent m_OnLineSelection;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LinkSelectionEvent m_OnLinkSelection;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Camera;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas m_Canvas;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_selectedLink;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_lastCharIndex;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_lastWordIndex;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_lastLineIndex;

		[Token(Token = "0x17000084")]
		public CharacterSelectionEvent onCharacterSelection
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x12CCF74", Offset = "0x12CCF74", VA = "0x12CCF74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x12CCF7C", Offset = "0x12CCF7C", VA = "0x12CCF7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public SpriteSelectionEvent onSpriteSelection
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x12CCF84", Offset = "0x12CCF84", VA = "0x12CCF84")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x12CCF8C", Offset = "0x12CCF8C", VA = "0x12CCF8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public WordSelectionEvent onWordSelection
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x12CCF94", Offset = "0x12CCF94", VA = "0x12CCF94")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x12CCF9C", Offset = "0x12CCF9C", VA = "0x12CCF9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public LineSelectionEvent onLineSelection
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x12CCFA4", Offset = "0x12CCFA4", VA = "0x12CCFA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x12CCFAC", Offset = "0x12CCFAC", VA = "0x12CCFAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public LinkSelectionEvent onLinkSelection
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x12CCFB4", Offset = "0x12CCFB4", VA = "0x12CCFB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x12CCFBC", Offset = "0x12CCFBC", VA = "0x12CCFBC")]
			set
			{
			}
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x12CCFC4", Offset = "0x12CCFC4", VA = "0x12CCFC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x12CD19C", Offset = "0x12CD19C", VA = "0x12CD19C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x12CD8E8", Offset = "0x12CD8E8", VA = "0x12CD8E8", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x12CD8EC", Offset = "0x12CD8EC", VA = "0x12CD8EC", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x12CD654", Offset = "0x12CD654", VA = "0x12CD654")]
		private void SendOnCharacterSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x12CD6CC", Offset = "0x12CD6CC", VA = "0x12CD6CC")]
		private void SendOnSpriteSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x12CD744", Offset = "0x12CD744", VA = "0x12CD744")]
		private void SendOnWordSelection(string word, int charIndex, int length)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x12CD7D0", Offset = "0x12CD7D0", VA = "0x12CD7D0")]
		private void SendOnLineSelection(string line, int charIndex, int length)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x12CD85C", Offset = "0x12CD85C", VA = "0x12CD85C")]
		private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x12CD8F0", Offset = "0x12CD8F0", VA = "0x12CD8F0")]
		public TMP_TextEventHandler()
		{
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x200008B")]
	public class Benchmark01 : MonoBehaviour
	{
		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FEBC", Offset = "0x60FEBC")]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Benchmark01 <>4__this;

			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x17000089")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000386")]
				[Address(RVA = "0x12DA3A0", Offset = "0x12DA3A0", VA = "0x12DA3A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000388")]
				[Address(RVA = "0x12DA3E8", Offset = "0x12DA3E8", VA = "0x12DA3E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000383")]
			[Address(RVA = "0x12D9D88", Offset = "0x12D9D88", VA = "0x12D9D88")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000384")]
			[Address(RVA = "0x12D9DB4", Offset = "0x12D9DB4", VA = "0x12D9DB4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000385")]
			[Address(RVA = "0x12D9DB8", Offset = "0x12D9DB8", VA = "0x12D9DB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000387")]
			[Address(RVA = "0x12DA3A8", Offset = "0x12DA3A8", VA = "0x12DA3A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Font TextMeshFont;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextContainer m_textContainer;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMesh m_textMesh;

		[Token(Token = "0x400020F")]
		private const string label01 = "The <#0050FF>count is: </color>{0}";

		[Token(Token = "0x4000210")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x12A6B60", Offset = "0x12A6B60", VA = "0x12A6B60")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x610528", Offset = "0x610528")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x12A6BD8", Offset = "0x12A6BD8", VA = "0x12A6BD8")]
		public Benchmark01()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class Benchmark01_UGUI : MonoBehaviour
	{
		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FECC", Offset = "0x60FECC")]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Benchmark01_UGUI <>4__this;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700008B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600038E")]
				[Address(RVA = "0x12DA8EC", Offset = "0x12DA8EC", VA = "0x12DA8EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000390")]
				[Address(RVA = "0x12DA934", Offset = "0x12DA934", VA = "0x12DA934", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600038B")]
			[Address(RVA = "0x12DA3F0", Offset = "0x12DA3F0", VA = "0x12DA3F0")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600038C")]
			[Address(RVA = "0x12DA41C", Offset = "0x12DA41C", VA = "0x12DA41C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0x12DA420", Offset = "0x12DA420", VA = "0x12DA420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600038F")]
			[Address(RVA = "0x12DA8F4", Offset = "0x12DA8F4", VA = "0x12DA8F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Canvas canvas;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Font TextMeshFont;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI m_textMeshPro;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text m_textMesh;

		[Token(Token = "0x400021D")]
		private const string label01 = "The <#0050FF>count is: </color>";

		[Token(Token = "0x400021E")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x12A6BE0", Offset = "0x12A6BE0", VA = "0x12A6BE0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6105D8", Offset = "0x6105D8")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x12A6C58", Offset = "0x12A6C58", VA = "0x12A6C58")]
		public Benchmark01_UGUI()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class Benchmark02 : MonoBehaviour
	{
		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x12A6C60", Offset = "0x12A6C60", VA = "0x12A6C60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x12A72B4", Offset = "0x12A72B4", VA = "0x12A72B4")]
		public Benchmark02()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class Benchmark03 : MonoBehaviour
	{
		[Token(Token = "0x2000091")]
		public enum BenchmarkType
		{
			[Token(Token = "0x400022D")]
			TMP_SDF_MOBILE,
			[Token(Token = "0x400022E")]
			TMP_SDF__MOBILE_SSD,
			[Token(Token = "0x400022F")]
			TMP_SDF,
			[Token(Token = "0x4000230")]
			TMP_BITMAP_MOBILE,
			[Token(Token = "0x4000231")]
			TEXTMESH_BITMAP
		}

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int NumberOfSamples;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BenchmarkType Benchmark;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Font SourceFont;

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x12A72C4", Offset = "0x12A72C4", VA = "0x12A72C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x12A72C8", Offset = "0x12A72C8", VA = "0x12A72C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x12A7784", Offset = "0x12A7784", VA = "0x12A7784")]
		public Benchmark03()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class Benchmark04 : MonoBehaviour
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int MinPointSize;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int MaxPointSize;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int Steps;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform m_Transform;

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x12A7794", Offset = "0x12A7794", VA = "0x12A7794")]
		private void Start()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x12A7AB8", Offset = "0x12A7AB8", VA = "0x12A7AB8")]
		public Benchmark04()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class CameraController : MonoBehaviour
	{
		[Token(Token = "0x2000094")]
		public enum CameraModes
		{
			[Token(Token = "0x4000251")]
			Follow,
			[Token(Token = "0x4000252")]
			Isometric,
			[Token(Token = "0x4000253")]
			Free
		}

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform cameraTransform;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform dummyTarget;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform CameraTarget;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float FollowDistance;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float MaxFollowDistance;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float MinFollowDistance;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float ElevationAngle;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MaxElevationAngle;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MinElevationAngle;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OrbitalAngle;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public CameraModes CameraMode;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool MovementSmoothing;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool RotationSmoothing;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool previousSmoothing;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float MovementSmoothingValue;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float RotationSmoothingValue;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float MoveSensitivity;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 currentVelocity;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 desiredPosition;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float mouseX;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float mouseY;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 moveVector;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float mouseWheel;

		[Token(Token = "0x400024E")]
		private const string event_SmoothingValue = "Slider - Smoothing Value";

		[Token(Token = "0x400024F")]
		private const string event_FollowDistance = "Slider - Camera Zoom";

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x12A8310", Offset = "0x12A8310", VA = "0x12A8310")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x12A83A0", Offset = "0x12A83A0", VA = "0x12A83A0")]
		private void Start()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x12A84A0", Offset = "0x12A84A0", VA = "0x12A84A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x12A87B8", Offset = "0x12A87B8", VA = "0x12A87B8")]
		private void GetPlayerInput()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x12A8F90", Offset = "0x12A8F90", VA = "0x12A8F90")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class ObjectSpin : MonoBehaviour
	{
		[Token(Token = "0x2000096")]
		public enum MotionType
		{
			[Token(Token = "0x400025F")]
			Rotation,
			[Token(Token = "0x4000260")]
			BackAndForth,
			[Token(Token = "0x4000261")]
			Translation
		}

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float SpinSpeed;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int RotationRange;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_transform;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_time;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_prevPOS;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_initial_Rotation;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_initial_Position;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Color32 m_lightColor;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int frames;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MotionType Motion;

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x12C4A30", Offset = "0x12C4A30", VA = "0x12C4A30")]
		private void Awake()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x12C4B60", Offset = "0x12C4B60", VA = "0x12C4B60")]
		private void Update()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x12C4C9C", Offset = "0x12C4C9C", VA = "0x12C4C9C")]
		public ObjectSpin()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class ShaderPropAnimator : MonoBehaviour
	{
		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FEDC", Offset = "0x60FEDC")]
		private sealed class <AnimateProperties>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShaderPropAnimator <>4__this;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003A7")]
				[Address(RVA = "0x12DCF04", Offset = "0x12DCF04", VA = "0x12DCF04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003A9")]
				[Address(RVA = "0x12DCF4C", Offset = "0x12DCF4C", VA = "0x12DCF4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x12DCD68", Offset = "0x12DCD68", VA = "0x12DCD68")]
			[DebuggerHidden]
			public <AnimateProperties>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x12DCD94", Offset = "0x12DCD94", VA = "0x12DCD94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x12DCD98", Offset = "0x12DCD98", VA = "0x12DCD98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x12DCF0C", Offset = "0x12DCF0C", VA = "0x12DCF0C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer m_Renderer;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve GlowCurve;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_frame;

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x12C7BE8", Offset = "0x12C7BE8", VA = "0x12C7BE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x12C7C68", Offset = "0x12C7C68", VA = "0x12C7C68")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x12C7C94", Offset = "0x12C7C94", VA = "0x12C7C94")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x610688", Offset = "0x610688")]
		private IEnumerator AnimateProperties()
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x12C7D0C", Offset = "0x12C7D0C", VA = "0x12C7D0C")]
		public ShaderPropAnimator()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class SimpleScript : MonoBehaviour
	{
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x400026A")]
		private const string label = "The <#0050FF>count is: </color>{0:2}";

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_frame;

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x12C7D14", Offset = "0x12C7D14", VA = "0x12C7D14")]
		private void Start()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x12C7DDC", Offset = "0x12C7DDC", VA = "0x12C7DDC")]
		private void Update()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x12C7E74", Offset = "0x12C7E74", VA = "0x12C7E74")]
		public SimpleScript()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class SkewTextExample : MonoBehaviour
	{
		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FEEC", Offset = "0x60FEEC")]
		private sealed class <WarpText>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkewTextExample <>4__this;

			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x4000274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <old_ShearValue>5__3;

			[Token(Token = "0x4000275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__4;

			[Token(Token = "0x1700008F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003B5")]
				[Address(RVA = "0x12DD814", Offset = "0x12DD814", VA = "0x12DD814", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B7")]
				[Address(RVA = "0x12DD85C", Offset = "0x12DD85C", VA = "0x12DD85C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x12DCF54", Offset = "0x12DCF54", VA = "0x12DCF54")]
			[DebuggerHidden]
			public <WarpText>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x12DCF80", Offset = "0x12DCF80", VA = "0x12DCF80", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x12DCF84", Offset = "0x12DCF84", VA = "0x12DCF84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x12DD81C", Offset = "0x12DD81C", VA = "0x12DD81C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float CurveScale;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float ShearAmount;

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x12C7E7C", Offset = "0x12C7E7C", VA = "0x12C7E7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x12C7EE8", Offset = "0x12C7EE8", VA = "0x12C7EE8")]
		private void Start()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x12C7F8C", Offset = "0x12C7F8C", VA = "0x12C7F8C")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x12C7F14", Offset = "0x12C7F14", VA = "0x12C7F14")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x610738", Offset = "0x610738")]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x12C8010", Offset = "0x12C8010", VA = "0x12C8010")]
		public SkewTextExample()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class TMP_ExampleScript_01 : MonoBehaviour
	{
		[Token(Token = "0x200009D")]
		public enum objectType
		{
			[Token(Token = "0x400027C")]
			TextMeshPro,
			[Token(Token = "0x400027D")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public objectType ObjectType;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isStatic;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_text;

		[Token(Token = "0x4000279")]
		private const string k_label = "The count is <#0080ff>{0}</color>";

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int count;

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x12CAF2C", Offset = "0x12CAF2C", VA = "0x12CAF2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x12CB148", Offset = "0x12CB148", VA = "0x12CB148")]
		private void Update()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x12CB1E0", Offset = "0x12CB1E0", VA = "0x12CB1E0")]
		public TMP_ExampleScript_01()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class TMP_FrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x200009F")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x4000289")]
			TopLeft,
			[Token(Token = "0x400028A")]
			BottomLeft,
			[Token(Token = "0x400028B")]
			TopRight,
			[Token(Token = "0x400028C")]
			BottomRight
		}

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x4000283")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera m_camera;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x12CB1E8", Offset = "0x12CB1E8", VA = "0x12CB1E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x12CB618", Offset = "0x12CB618", VA = "0x12CB618")]
		private void Start()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x12CB644", Offset = "0x12CB644", VA = "0x12CB644")]
		private void Update()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x12CB410", Offset = "0x12CB410", VA = "0x12CB410")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x12CB7B4", Offset = "0x12CB7B4", VA = "0x12CB7B4")]
		public TMP_FrameRateCounter()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class TMP_TextEventCheck : MonoBehaviour
	{
		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_TextEventHandler TextEventHandler;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x12CBC54", Offset = "0x12CBC54", VA = "0x12CBC54")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x12CBF68", Offset = "0x12CBF68", VA = "0x12CBF68")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x12CC244", Offset = "0x12CC244", VA = "0x12CC244")]
		private void OnCharacterSelection(char c, int index)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x12CC484", Offset = "0x12CC484", VA = "0x12CC484")]
		private void OnSpriteSelection(char c, int index)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x12CC6C4", Offset = "0x12CC6C4", VA = "0x12CC6C4")]
		private void OnWordSelection(string word, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x12CC988", Offset = "0x12CC988", VA = "0x12CC988")]
		private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x12CCC4C", Offset = "0x12CCC4C", VA = "0x12CCC4C")]
		private void OnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x12CCF6C", Offset = "0x12CCF6C", VA = "0x12CCF6C")]
		public TMP_TextEventCheck()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class TMP_TextInfoDebugTool : MonoBehaviour
	{
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x12CDA48", Offset = "0x12CDA48", VA = "0x12CDA48")]
		public TMP_TextInfoDebugTool()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Camera m_Camera;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_isHoveringObject;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_selectedLink;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_lastCharIndex;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_lastWordIndex;

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x12CDA50", Offset = "0x12CDA50", VA = "0x12CDA50")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x12CDAF4", Offset = "0x12CDAF4", VA = "0x12CDAF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x12CE214", Offset = "0x12CE214", VA = "0x12CE214", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x12CE298", Offset = "0x12CE298", VA = "0x12CE298", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x12CE318", Offset = "0x12CE318", VA = "0x12CE318")]
		public TMP_TextSelector_A()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class TMP_TextSelector_B : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform TextPopup_Prefab_01;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform m_TextPopup_RectTransform;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProUGUI m_TextPopup_TMPComponent;

		[Token(Token = "0x4000298")]
		private const string k_LinkText = "You have selected link <#ffff00>";

		[Token(Token = "0x4000299")]
		private const string k_WordText = "Word Index: <#ffff00>";

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Canvas m_Canvas;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera m_Camera;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool isHoveringObject;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_selectedWord;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_selectedLink;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_lastIndex;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Matrix4x4 m_matrix;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TMP_MeshInfo[] m_cachedMeshInfoVertexData;

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x12CE330", Offset = "0x12CE330", VA = "0x12CE330")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x12CE50C", Offset = "0x12CE50C", VA = "0x12CE50C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x12CE5FC", Offset = "0x12CE5FC", VA = "0x12CE5FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x12CE6EC", Offset = "0x12CE6EC", VA = "0x12CE6EC")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x12CE7A4", Offset = "0x12CE7A4", VA = "0x12CE7A4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x12CFC9C", Offset = "0x12CFC9C", VA = "0x12CFC9C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x12CFCA8", Offset = "0x12CFCA8", VA = "0x12CFCA8", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x12CFCB0", Offset = "0x12CFCB0", VA = "0x12CFCB0", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x12CFCB4", Offset = "0x12CFCB4", VA = "0x12CFCB4", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x12CF40C", Offset = "0x12CF40C", VA = "0x12CF40C")]
		private void RestoreCachedVertexAttributes(int index)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x12CFCB8", Offset = "0x12CFCB8", VA = "0x12CFCB8")]
		public TMP_TextSelector_B()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class TMP_UiFrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x20000A5")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x40002AD")]
			TopLeft,
			[Token(Token = "0x40002AE")]
			BottomLeft,
			[Token(Token = "0x40002AF")]
			TopRight,
			[Token(Token = "0x40002B0")]
			BottomRight
		}

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x40002A8")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform m_frameCounter_transform;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x12CFCD0", Offset = "0x12CFCD0", VA = "0x12CFCD0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x12D0134", Offset = "0x12D0134", VA = "0x12D0134")]
		private void Start()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x12D0160", Offset = "0x12D0160", VA = "0x12D0160")]
		private void Update()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x12CFEF0", Offset = "0x12CFEF0", VA = "0x12CFEF0")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x12D02D0", Offset = "0x12D02D0", VA = "0x12D02D0")]
		public TMP_UiFrameRateCounter()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class TMPro_InstructionOverlay : MonoBehaviour
	{
		[Token(Token = "0x20000A7")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x40002B8")]
			TopLeft,
			[Token(Token = "0x40002B9")]
			BottomLeft,
			[Token(Token = "0x40002BA")]
			TopRight,
			[Token(Token = "0x40002BB")]
			BottomRight
		}

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x40002B2")]
		private const string instructions = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextContainer m_textContainer;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Camera m_camera;

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x12D02E8", Offset = "0x12D02E8", VA = "0x12D02E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x12D0568", Offset = "0x12D0568", VA = "0x12D0568")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x12D0690", Offset = "0x12D0690", VA = "0x12D0690")]
		public TMPro_InstructionOverlay()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class TeleType : MonoBehaviour
	{
		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FEFC", Offset = "0x60FEFC")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TeleType <>4__this;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <totalVisibleCharacters>5__2;

			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <counter>5__3;

			[Token(Token = "0x17000091")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003E7")]
				[Address(RVA = "0x12DDF2C", Offset = "0x12DDF2C", VA = "0x12DDF2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003E9")]
				[Address(RVA = "0x12DDF74", Offset = "0x12DDF74", VA = "0x12DDF74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x12DDCA4", Offset = "0x12DDCA4", VA = "0x12DDCA4")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x12DDCD0", Offset = "0x12DDCD0", VA = "0x12DDCD0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x12DDCD4", Offset = "0x12DDCD4", VA = "0x12DDCD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x12DDF34", Offset = "0x12DDF34", VA = "0x12DDF34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string label01;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string label02;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_textMeshPro;

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x12D06A0", Offset = "0x12D06A0", VA = "0x12D06A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x12D0748", Offset = "0x12D0748", VA = "0x12D0748")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6107E8", Offset = "0x6107E8")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x12D07C0", Offset = "0x12D07C0", VA = "0x12D07C0")]
		public TeleType()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class TextConsoleSimulator : MonoBehaviour
	{
		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FF0C", Offset = "0x60FF0C")]
		private sealed class <RevealCharacters>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TextConsoleSimulator <>4__this;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int <visibleCount>5__4;

			[Token(Token = "0x17000093")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003F5")]
				[Address(RVA = "0x12DE12C", Offset = "0x12DE12C", VA = "0x12DE12C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003F7")]
				[Address(RVA = "0x12DE174", Offset = "0x12DE174", VA = "0x12DE174", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x12DDF7C", Offset = "0x12DDF7C", VA = "0x12DDF7C")]
			[DebuggerHidden]
			public <RevealCharacters>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x12DDFA8", Offset = "0x12DDFA8", VA = "0x12DDFA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x12DDFAC", Offset = "0x12DDFAC", VA = "0x12DDFAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x12DE134", Offset = "0x12DE134", VA = "0x12DE134", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FF1C", Offset = "0x60FF1C")]
		private sealed class <RevealWords>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <totalWordCount>5__2;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <counter>5__4;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <visibleCount>5__5;

			[Token(Token = "0x17000095")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003FB")]
				[Address(RVA = "0x12DE3A0", Offset = "0x12DE3A0", VA = "0x12DE3A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003FD")]
				[Address(RVA = "0x12DE3E8", Offset = "0x12DE3E8", VA = "0x12DE3E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x12DE17C", Offset = "0x12DE17C", VA = "0x12DE17C")]
			[DebuggerHidden]
			public <RevealWords>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x12DE1A8", Offset = "0x12DE1A8", VA = "0x12DE1A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x12DE1AC", Offset = "0x12DE1AC", VA = "0x12DE1AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x12DE3A8", Offset = "0x12DE3A8", VA = "0x12DE3A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool hasTextChanged;

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x12D0840", Offset = "0x12D0840", VA = "0x12D0840")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x12D08AC", Offset = "0x12D08AC", VA = "0x12D08AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x12D0970", Offset = "0x12D0970", VA = "0x12D0970")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x12D0A60", Offset = "0x12D0A60", VA = "0x12D0A60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x12D0B50", Offset = "0x12D0B50", VA = "0x12D0B50")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x12D08DC", Offset = "0x12D08DC", VA = "0x12D08DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x610898", Offset = "0x610898")]
		private IEnumerator RevealCharacters(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x12D0B5C", Offset = "0x12D0B5C", VA = "0x12D0B5C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6108F8", Offset = "0x6108F8")]
		private IEnumerator RevealWords(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x12D0BD4", Offset = "0x12D0BD4", VA = "0x12D0BD4")]
		public TextConsoleSimulator()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class TextMeshProFloatingText : MonoBehaviour
	{
		[Token(Token = "0x20000AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FF2C", Offset = "0x60FF2C")]
		private sealed class <DisplayTextMeshProFloatingText>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x17000097")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000407")]
				[Address(RVA = "0x12DED60", Offset = "0x12DED60", VA = "0x12DED60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000409")]
				[Address(RVA = "0x12DEDA8", Offset = "0x12DEDA8", VA = "0x12DEDA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000404")]
			[Address(RVA = "0x12DE8C4", Offset = "0x12DE8C4", VA = "0x12DE8C4")]
			[DebuggerHidden]
			public <DisplayTextMeshProFloatingText>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000405")]
			[Address(RVA = "0x12DE8F0", Offset = "0x12DE8F0", VA = "0x12DE8F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000406")]
			[Address(RVA = "0x12DE8F4", Offset = "0x12DE8F4", VA = "0x12DE8F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000408")]
			[Address(RVA = "0x12DED68", Offset = "0x12DED68", VA = "0x12DED68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FF3C", Offset = "0x60FF3C")]
		private sealed class <DisplayTextMeshFloatingText>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x40002EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x17000099")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600040D")]
				[Address(RVA = "0x12DE874", Offset = "0x12DE874", VA = "0x12DE874", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600040F")]
				[Address(RVA = "0x12DE8BC", Offset = "0x12DE8BC", VA = "0x12DE8BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x12DE3F0", Offset = "0x12DE3F0", VA = "0x12DE3F0")]
			[DebuggerHidden]
			public <DisplayTextMeshFloatingText>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x12DE41C", Offset = "0x12DE41C", VA = "0x12DE41C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x12DE420", Offset = "0x12DE420", VA = "0x12DE420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600040E")]
			[Address(RVA = "0x12DE87C", Offset = "0x12DE87C", VA = "0x12DE87C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Font TheFont;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject m_floatingText;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMesh m_textMesh;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_transform;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_floatingText_Transform;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform m_cameraTransform;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 lastPOS;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion lastRotation;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int SpawnType;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static WaitForEndOfFrame k_WaitForEndOfFrame;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static WaitForSeconds[] k_WaitForSecondsRandom;

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x12D0BDC", Offset = "0x12D0BDC", VA = "0x12D0BDC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x12D0CC4", Offset = "0x12D0CC4", VA = "0x12D0CC4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x12D10E0", Offset = "0x12D10E0", VA = "0x12D10E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6109F8", Offset = "0x6109F8")]
		public IEnumerator DisplayTextMeshProFloatingText()
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x12D1158", Offset = "0x12D1158", VA = "0x12D1158")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x610A58", Offset = "0x610A58")]
		public IEnumerator DisplayTextMeshFloatingText()
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x12D11D0", Offset = "0x12D11D0", VA = "0x12D11D0")]
		public TextMeshProFloatingText()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class TextMeshSpawner : MonoBehaviour
	{
		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Font TheFont;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x12D1930", Offset = "0x12D1930", VA = "0x12D1930")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x12D1934", Offset = "0x12D1934", VA = "0x12D1934")]
		private void Start()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x12D1C78", Offset = "0x12D1C78", VA = "0x12D1C78")]
		public TextMeshSpawner()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class VertexColorCycler : MonoBehaviour
	{
		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FF4C", Offset = "0x60FF4C")]
		private sealed class <AnimateVertexColors>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexColorCycler <>4__this;

			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <currentCharacter>5__3;

			[Token(Token = "0x1700009B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600041A")]
				[Address(RVA = "0x12DFCA0", Offset = "0x12DFCA0", VA = "0x12DFCA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600041C")]
				[Address(RVA = "0x12DFCE8", Offset = "0x12DFCE8", VA = "0x12DFCE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000417")]
			[Address(RVA = "0x12D54E8", Offset = "0x12D54E8", VA = "0x12D54E8")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000418")]
			[Address(RVA = "0x12DF9BC", Offset = "0x12DF9BC", VA = "0x12DF9BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0x12DF9C0", Offset = "0x12DF9C0", VA = "0x12DF9C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0x12DFCA8", Offset = "0x12DFCA8", VA = "0x12DFCA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x12D53E8", Offset = "0x12D53E8", VA = "0x12D53E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x12D5444", Offset = "0x12D5444", VA = "0x12D5444")]
		private void Start()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x12D5470", Offset = "0x12D5470", VA = "0x12D5470")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x610B58", Offset = "0x610B58")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x12D5514", Offset = "0x12D5514", VA = "0x12D5514")]
		public VertexColorCycler()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class VertexJitter : MonoBehaviour
	{
		[Token(Token = "0x20000B4")]
		private struct VertexAnim
		{
			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float angleRange;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float angle;

			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float speed;
		}

		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FF5C", Offset = "0x60FF5C")]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexJitter <>4__this;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <loopCount>5__3;

			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private VertexAnim[] <vertexAnim>5__4;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TMP_MeshInfo[] <cachedMeshInfo>5__5;

			[Token(Token = "0x1700009D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000427")]
				[Address(RVA = "0x12E056C", Offset = "0x12E056C", VA = "0x12E056C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000429")]
				[Address(RVA = "0x12E05B4", Offset = "0x12E05B4", VA = "0x12E05B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x12D5884", Offset = "0x12D5884", VA = "0x12D5884")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x12DFCF0", Offset = "0x12DFCF0", VA = "0x12DFCF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x12DFCF4", Offset = "0x12DFCF4", VA = "0x12DFCF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x12E0574", Offset = "0x12E0574", VA = "0x12E0574", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x12D551C", Offset = "0x12D551C", VA = "0x12D551C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x12D5578", Offset = "0x12D5578", VA = "0x12D5578")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x12D5668", Offset = "0x12D5668", VA = "0x12D5668")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x12D5758", Offset = "0x12D5758", VA = "0x12D5758")]
		private void Start()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x12D57FC", Offset = "0x12D57FC", VA = "0x12D57FC")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x12D5784", Offset = "0x12D5784", VA = "0x12D5784")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x610C08", Offset = "0x610C08")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x12D58B0", Offset = "0x12D58B0", VA = "0x12D58B0")]
		public VertexJitter()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class VertexShakeA : MonoBehaviour
	{
		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FF6C", Offset = "0x60FF6C")]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexShakeA <>4__this;

			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x1700009F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000434")]
				[Address(RVA = "0x12E0FE8", Offset = "0x12E0FE8", VA = "0x12E0FE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000436")]
				[Address(RVA = "0x12E1030", Offset = "0x12E1030", VA = "0x12E1030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000431")]
			[Address(RVA = "0x12D5C20", Offset = "0x12D5C20", VA = "0x12D5C20")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x12E05BC", Offset = "0x12E05BC", VA = "0x12E05BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x12E05C0", Offset = "0x12E05C0", VA = "0x12E05C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x12E0FF0", Offset = "0x12E0FF0", VA = "0x12E0FF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ScaleMultiplier;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RotationMultiplier;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x12D58C8", Offset = "0x12D58C8", VA = "0x12D58C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x12D5924", Offset = "0x12D5924", VA = "0x12D5924")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x12D5A14", Offset = "0x12D5A14", VA = "0x12D5A14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x12D5B04", Offset = "0x12D5B04", VA = "0x12D5B04")]
		private void Start()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x12D5BA8", Offset = "0x12D5BA8", VA = "0x12D5BA8")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x12D5B30", Offset = "0x12D5B30", VA = "0x12D5B30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x610CB8", Offset = "0x610CB8")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x12D5C4C", Offset = "0x12D5C4C", VA = "0x12D5C4C")]
		public VertexShakeA()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class VertexShakeB : MonoBehaviour
	{
		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FF7C", Offset = "0x60FF7C")]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexShakeB <>4__this;

			[Token(Token = "0x4000321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x170000A1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000441")]
				[Address(RVA = "0x12E1EF0", Offset = "0x12E1EF0", VA = "0x12E1EF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000443")]
				[Address(RVA = "0x12E1F38", Offset = "0x12E1F38", VA = "0x12E1F38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0x12D5FB4", Offset = "0x12D5FB4", VA = "0x12D5FB4")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x12E1038", Offset = "0x12E1038", VA = "0x12E1038", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x12E103C", Offset = "0x12E103C", VA = "0x12E103C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x12E1EF8", Offset = "0x12E1EF8", VA = "0x12E1EF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x12D5C5C", Offset = "0x12D5C5C", VA = "0x12D5C5C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x12D5CB8", Offset = "0x12D5CB8", VA = "0x12D5CB8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x12D5DA8", Offset = "0x12D5DA8", VA = "0x12D5DA8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x12D5E98", Offset = "0x12D5E98", VA = "0x12D5E98")]
		private void Start()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x12D5F3C", Offset = "0x12D5F3C", VA = "0x12D5F3C")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x12D5EC4", Offset = "0x12D5EC4", VA = "0x12D5EC4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x610D68", Offset = "0x610D68")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x12D5FE0", Offset = "0x12D5FE0", VA = "0x12D5FE0")]
		public VertexShakeB()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class VertexZoom : MonoBehaviour
	{
		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FF8C", Offset = "0x60FF8C")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<float> modifiedCharScale;

			[Token(Token = "0x4000329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Comparison<int> <>9__0;

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x12E1F40", Offset = "0x12E1F40", VA = "0x12E1F40")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x12E1F48", Offset = "0x12E1F48", VA = "0x12E1F48")]
			internal int <AnimateVertexColors>b__0(int a, int b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FF9C", Offset = "0x60FF9C")]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400032A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400032B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexZoom <>4__this;

			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass10_0 <>8__1;

			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TMP_MeshInfo[] <cachedMeshInfoVertexData>5__3;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<int> <scaleSortingOrder>5__4;

			[Token(Token = "0x170000A3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x12E2BD0", Offset = "0x12E2BD0", VA = "0x12E2BD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x12E2C18", Offset = "0x12E2C18", VA = "0x12E2C18", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x12D6360", Offset = "0x12D6360", VA = "0x12D6360")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x12E2008", Offset = "0x12E2008", VA = "0x12E2008", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0x12E200C", Offset = "0x12E200C", VA = "0x12E200C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0x12E2BD8", Offset = "0x12E2BD8", VA = "0x12E2BD8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x12D5FF8", Offset = "0x12D5FF8", VA = "0x12D5FF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x12D6054", Offset = "0x12D6054", VA = "0x12D6054")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x12D6144", Offset = "0x12D6144", VA = "0x12D6144")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x12D6234", Offset = "0x12D6234", VA = "0x12D6234")]
		private void Start()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x12D62D8", Offset = "0x12D62D8", VA = "0x12D62D8")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x12D6260", Offset = "0x12D6260", VA = "0x12D6260")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x610E18", Offset = "0x610E18")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x12D638C", Offset = "0x12D638C", VA = "0x12D638C")]
		public VertexZoom()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class WarpTextExample : MonoBehaviour
	{
		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60FFAC", Offset = "0x60FFAC")]
		private sealed class <WarpText>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WarpTextExample <>4__this;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__3;

			[Token(Token = "0x170000A5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600045B")]
				[Address(RVA = "0x12E33F4", Offset = "0x12E33F4", VA = "0x12E33F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600045D")]
				[Address(RVA = "0x12E343C", Offset = "0x12E343C", VA = "0x12E343C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x12D6538", Offset = "0x12D6538", VA = "0x12D6538")]
			[DebuggerHidden]
			public <WarpText>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x12E2C20", Offset = "0x12E2C20", VA = "0x12E2C20", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x12E2C24", Offset = "0x12E2C24", VA = "0x12E2C24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x12E33FC", Offset = "0x12E33FC", VA = "0x12E33FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float AngleMultiplier;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float CurveScale;

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x12D63A4", Offset = "0x12D63A4", VA = "0x12D63A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x12D6410", Offset = "0x12D6410", VA = "0x12D6410")]
		private void Start()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x12D64B4", Offset = "0x12D64B4", VA = "0x12D64B4")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x12D643C", Offset = "0x12D643C", VA = "0x12D643C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x610EC8", Offset = "0x610EC8")]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x12D6564", Offset = "0x12D6564", VA = "0x12D6564")]
		public WarpTextExample()
		{
		}
	}
}
