using System;
using System.Collections.Generic;
using System.Reflection;
using DarkTonic.MasterAudio;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class MA_Bootstrapper : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0xF395B8", Offset = "0xF395B8", VA = "0xF395B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xF395BC", Offset = "0xF395BC", VA = "0xF395BC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xF396E8", Offset = "0xF396E8", VA = "0xF396E8")]
	public MA_Bootstrapper()
	{
	}
}
[Token(Token = "0x2000003")]
public class MA_DestroyFinishedParticle : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	private ParticleSystem particles;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xF396F0", Offset = "0xF396F0", VA = "0xF396F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xF39758", Offset = "0xF39758", VA = "0xF39758")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xF397E8", Offset = "0xF397E8", VA = "0xF397E8")]
	public MA_DestroyFinishedParticle()
	{
	}
}
[Token(Token = "0x2000004")]
public class MA_EnemyOne : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ExplosionParticlePrefab;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	private Transform _trans;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	private float _speed;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x2C")]
	private float _horizSpeed;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xF397F0", Offset = "0xF397F0", VA = "0xF397F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xF39880", Offset = "0xF39880", VA = "0xF39880")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xF39984", Offset = "0xF39984", VA = "0xF39984")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xF39ACC", Offset = "0xF39ACC", VA = "0xF39ACC")]
	public MA_EnemyOne()
	{
	}
}
[Token(Token = "0x2000005")]
public class MA_EnemySpawner : MonoBehaviour
{
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Enemy;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x20")]
	public bool spawnerEnabled;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x28")]
	private Transform trans;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x30")]
	private float nextSpawnTime;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xF39AD4", Offset = "0xF39AD4", VA = "0xF39AD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xF39B40", Offset = "0xF39B40", VA = "0xF39B40")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xF39CCC", Offset = "0xF39CCC", VA = "0xF39CCC")]
	public MA_EnemySpawner()
	{
	}
}
[Token(Token = "0x2000006")]
public class MA_GameScene : MonoBehaviour
{
	[Token(Token = "0x600000E")]
	[Address(RVA = "0xF39CD4", Offset = "0xF39CD4", VA = "0xF39CD4")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xF39D7C", Offset = "0xF39D7C", VA = "0xF39D7C")]
	public MA_GameScene()
	{
	}
}
[Token(Token = "0x2000007")]
public class MA_Laser : MonoBehaviour
{
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x18")]
	private Transform _trans;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xF39D84", Offset = "0xF39D84", VA = "0xF39D84")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xF39DB8", Offset = "0xF39DB8", VA = "0xF39DB8")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xF39E90", Offset = "0xF39E90", VA = "0xF39E90")]
	private void Update()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xF39F6C", Offset = "0xF39F6C", VA = "0xF39F6C")]
	public MA_Laser()
	{
	}
}
[Token(Token = "0x2000008")]
public class MA_LocalizationUI : MonoBehaviour
{
	[Token(Token = "0x6000014")]
	[Address(RVA = "0xF39F74", Offset = "0xF39F74", VA = "0xF39F74")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xF3A01C", Offset = "0xF3A01C", VA = "0xF3A01C")]
	public MA_LocalizationUI()
	{
	}
}
[Token(Token = "0x2000009")]
public class MA_PlayerControl : MonoBehaviour
{
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ProjectilePrefab;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x20")]
	public bool canShoot;

	[Token(Token = "0x400000D")]
	private const float MoveSpeed = 10f;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x30")]
	private float _lastMoveAmt;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xF3A024", Offset = "0xF3A024", VA = "0xF3A024")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xF3A058", Offset = "0xF3A058", VA = "0xF3A058")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xF3A0F4", Offset = "0xF3A0F4", VA = "0xF3A0F4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xF3A0F8", Offset = "0xF3A0F8", VA = "0xF3A0F8")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xF3A0FC", Offset = "0xF3A0FC", VA = "0xF3A0FC")]
	private void OnBecameVisible()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xF3A100", Offset = "0xF3A100", VA = "0xF3A100")]
	private void Update()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xF3A32C", Offset = "0xF3A32C", VA = "0xF3A32C")]
	public MA_PlayerControl()
	{
	}
}
[Token(Token = "0x200000A")]
public class MA_PlayerSpawnerControl : MonoBehaviour
{
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Player;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x20")]
	private float nextSpawnTime;

	[Token(Token = "0x17000001")]
	private bool PlayerActive
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xF3A360", Offset = "0xF3A360", VA = "0xF3A360")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xF3A33C", Offset = "0xF3A33C", VA = "0xF3A33C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xF3A37C", Offset = "0xF3A37C", VA = "0xF3A37C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xF3A3F4", Offset = "0xF3A3F4", VA = "0xF3A3F4")]
	public MA_PlayerSpawnerControl()
	{
	}
}
[Token(Token = "0x200000B")]
public class MA_SampleICustomEventReceiver : MonoBehaviour, ICustomEventReceiver
{
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x18")]
	private readonly List<string> _eventsSubscribedTo;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xF3A3FC", Offset = "0xF3A3FC", VA = "0xF3A3FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xF3A400", Offset = "0xF3A400", VA = "0xF3A400")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xF3A55C", Offset = "0xF3A55C", VA = "0xF3A55C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xF3A5D0", Offset = "0xF3A5D0", VA = "0xF3A5D0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xF3A404", Offset = "0xF3A404", VA = "0xF3A404", Slot = "4")]
	public void CheckForIllegalCustomEvents()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xF3A720", Offset = "0xF3A720", VA = "0xF3A720", Slot = "5")]
	public void ReceiveEvent(string customEventName, Vector3 originPoint)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xF3A850", Offset = "0xF3A850", VA = "0xF3A850", Slot = "6")]
	public bool SubscribesToEvent(string customEventName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xF3A560", Offset = "0xF3A560", VA = "0xF3A560", Slot = "7")]
	public void RegisterReceiver()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xF3A6C8", Offset = "0xF3A6C8", VA = "0xF3A6C8", Slot = "8")]
	public void UnregisterReceiver()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xF3A8C8", Offset = "0xF3A8C8", VA = "0xF3A8C8", Slot = "9")]
	public IList<AudioEventGroup> GetAllEvents()
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xF3AA54", Offset = "0xF3AA54", VA = "0xF3AA54")]
	public MA_SampleICustomEventReceiver()
	{
	}
}
[Token(Token = "0x200000C")]
public class MA_TestUI : MonoBehaviour
{
	[Token(Token = "0x600002C")]
	[Address(RVA = "0xF3ABD8", Offset = "0xF3ABD8", VA = "0xF3ABD8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xF3AC80", Offset = "0xF3AC80", VA = "0xF3AC80")]
	public MA_TestUI()
	{
	}
}
namespace RelationsInspector.Backend.AutoBackend;

[Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Class)]
public class AutoBackendAttribute : Attribute
{
	[Token(Token = "0x600002E")]
	[Address(RVA = "0xF3AC88", Offset = "0xF3AC88", VA = "0xF3AC88")]
	public AutoBackendAttribute()
	{
	}
}
[Token(Token = "0x200000E")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class RelatedAttribute : Attribute
{
	[Token(Token = "0x600002F")]
	[Address(RVA = "0xF3AC90", Offset = "0xF3AC90", VA = "0xF3AC90")]
	public RelatedAttribute()
	{
	}
}
[Token(Token = "0x200000F")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class RelatingAttribute : Attribute
{
	[Token(Token = "0x6000030")]
	[Address(RVA = "0xF3AC98", Offset = "0xF3AC98", VA = "0xF3AC98")]
	public RelatingAttribute()
	{
	}
}
