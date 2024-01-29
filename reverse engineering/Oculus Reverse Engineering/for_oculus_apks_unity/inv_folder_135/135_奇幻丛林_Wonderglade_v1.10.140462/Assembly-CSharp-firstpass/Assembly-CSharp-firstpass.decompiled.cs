using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using DarkTonic.MasterAudio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class MA_Bootstrapper : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0xDF74E8", Offset = "0xDF74E8", VA = "0xDF74E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xDF74EC", Offset = "0xDF74EC", VA = "0xDF74EC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xDF760C", Offset = "0xDF760C", VA = "0xDF760C")]
	public MA_Bootstrapper()
	{
	}
}
[Token(Token = "0x2000003")]
public class MA_DestroyFinishedParticle : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem particles;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xDF7614", Offset = "0xDF7614", VA = "0xDF7614")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xDF767C", Offset = "0xDF767C", VA = "0xDF767C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xDF771C", Offset = "0xDF771C", VA = "0xDF771C")]
	public MA_DestroyFinishedParticle()
	{
	}
}
[Token(Token = "0x2000004")]
public class MA_EnemyOne : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ExplosionParticlePrefab;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform _trans;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _speed;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _horizSpeed;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xDF7724", Offset = "0xDF7724", VA = "0xDF7724")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xDF77AC", Offset = "0xDF77AC", VA = "0xDF77AC")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xDF78B4", Offset = "0xDF78B4", VA = "0xDF78B4")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xDF7A18", Offset = "0xDF7A18", VA = "0xDF7A18")]
	public MA_EnemyOne()
	{
	}
}
[Token(Token = "0x2000005")]
public class MA_EnemySpawner : MonoBehaviour
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Enemy;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool spawnerEnabled;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform trans;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float nextSpawnTime;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xDF7A20", Offset = "0xDF7A20", VA = "0xDF7A20")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xDF7A8C", Offset = "0xDF7A8C", VA = "0xDF7A8C")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xDF7C2C", Offset = "0xDF7C2C", VA = "0xDF7C2C")]
	public MA_EnemySpawner()
	{
	}
}
[Token(Token = "0x2000006")]
public class MA_GameScene : MonoBehaviour
{
	[Token(Token = "0x600000E")]
	[Address(RVA = "0xDF7C34", Offset = "0xDF7C34", VA = "0xDF7C34")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xDF7CE0", Offset = "0xDF7CE0", VA = "0xDF7CE0")]
	public MA_GameScene()
	{
	}
}
[Token(Token = "0x2000007")]
public class MA_Laser : MonoBehaviour
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform _trans;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xDF7CE8", Offset = "0xDF7CE8", VA = "0xDF7CE8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xDF7D20", Offset = "0xDF7D20", VA = "0xDF7D20")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xDF7E08", Offset = "0xDF7E08", VA = "0xDF7E08")]
	private void Update()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xDF7EF4", Offset = "0xDF7EF4", VA = "0xDF7EF4")]
	public MA_Laser()
	{
	}
}
[Token(Token = "0x2000008")]
public class MA_LocalizationUI : MonoBehaviour
{
	[Token(Token = "0x6000014")]
	[Address(RVA = "0xDF7EFC", Offset = "0xDF7EFC", VA = "0xDF7EFC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xDF7FA8", Offset = "0xDF7FA8", VA = "0xDF7FA8")]
	public MA_LocalizationUI()
	{
	}
}
[Token(Token = "0x2000009")]
public class MA_PlayerControl : MonoBehaviour
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ProjectilePrefab;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool canShoot;

	[Token(Token = "0x400000D")]
	private const float MoveSpeed = 10f;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float _lastMoveAmt;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xDF7FB0", Offset = "0xDF7FB0", VA = "0xDF7FB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xDF7FE8", Offset = "0xDF7FE8", VA = "0xDF7FE8")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xDF8098", Offset = "0xDF8098", VA = "0xDF8098")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xDF809C", Offset = "0xDF809C", VA = "0xDF809C")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xDF80A0", Offset = "0xDF80A0", VA = "0xDF80A0")]
	private void OnBecameVisible()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xDF80A4", Offset = "0xDF80A4", VA = "0xDF80A4")]
	private void Update()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xDF82F4", Offset = "0xDF82F4", VA = "0xDF82F4")]
	public MA_PlayerControl()
	{
	}
}
[Token(Token = "0x200000A")]
public class MA_PlayerSpawnerControl : MonoBehaviour
{
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Player;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float nextSpawnTime;

	[Token(Token = "0x17000001")]
	private bool PlayerActive
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xDF8334", Offset = "0xDF8334", VA = "0xDF8334")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xDF8304", Offset = "0xDF8304", VA = "0xDF8304")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xDF8350", Offset = "0xDF8350", VA = "0xDF8350")]
	private void Update()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xDF83D4", Offset = "0xDF83D4", VA = "0xDF83D4")]
	public MA_PlayerSpawnerControl()
	{
	}
}
[Token(Token = "0x200000B")]
public class MA_SampleICustomEventReceiver : MonoBehaviour, ICustomEventReceiver
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly List<string> _eventsSubscribedTo;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xDF83DC", Offset = "0xDF83DC", VA = "0xDF83DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xDF83E0", Offset = "0xDF83E0", VA = "0xDF83E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xDF851C", Offset = "0xDF851C", VA = "0xDF851C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xDF85A0", Offset = "0xDF85A0", VA = "0xDF85A0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xDF83E4", Offset = "0xDF83E4", VA = "0xDF83E4", Slot = "4")]
	public void CheckForIllegalCustomEvents()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xDF860C", Offset = "0xDF860C", VA = "0xDF860C", Slot = "5")]
	public void ReceiveEvent(string customEventName, Vector3 originPoint)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xDF871C", Offset = "0xDF871C", VA = "0xDF871C", Slot = "6")]
	public bool SubscribesToEvent(string customEventName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xDF8520", Offset = "0xDF8520", VA = "0xDF8520", Slot = "7")]
	public void RegisterReceiver()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xDF85A4", Offset = "0xDF85A4", VA = "0xDF85A4", Slot = "8")]
	public void UnregisterReceiver()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xDF87A8", Offset = "0xDF87A8", VA = "0xDF87A8", Slot = "9")]
	public IList<AudioEventGroup> GetAllEvents()
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xDF88B8", Offset = "0xDF88B8", VA = "0xDF88B8")]
	public MA_SampleICustomEventReceiver()
	{
	}
}
[Token(Token = "0x200000C")]
public class MA_TestUI : MonoBehaviour
{
	[Token(Token = "0x600002C")]
	[Address(RVA = "0xDF8970", Offset = "0xDF8970", VA = "0xDF8970")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xDF8A1C", Offset = "0xDF8A1C", VA = "0xDF8A1C")]
	public MA_TestUI()
	{
	}
}
[Token(Token = "0x200000D")]
public static class DebugExtension
{
	[Token(Token = "0x600002E")]
	[Address(RVA = "0xB5B5EC", Offset = "0xB5B5EC", VA = "0xB5B5EC")]
	public static void DebugPoint(Vector3 position, Color color, float scale = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xB5B930", Offset = "0xB5B930", VA = "0xB5B930")]
	public static void DebugPoint(Vector3 position, float scale = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xB5B9C4", Offset = "0xB5B9C4", VA = "0xB5B9C4")]
	public static void DebugBounds(Bounds bounds, Color color, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xB5BF28", Offset = "0xB5BF28", VA = "0xB5BF28")]
	public static void DebugBounds(Bounds bounds, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xB5BF80", Offset = "0xB5BF80", VA = "0xB5BF80")]
	public static void DebugLocalCube(Transform transform, Vector3 size, Color color, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xB5C5F0", Offset = "0xB5C5F0", VA = "0xB5C5F0")]
	public static void DebugLocalCube(Transform transform, Vector3 size, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xB5C6A0", Offset = "0xB5C6A0", VA = "0xB5C6A0")]
	public static void DebugLocalCube(Matrix4x4 space, Vector3 size, Color color, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xB5CD50", Offset = "0xB5CD50", VA = "0xB5CD50")]
	public static void DebugLocalCube(Matrix4x4 space, Vector3 size, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xB5CE0C", Offset = "0xB5CE0C", VA = "0xB5CE0C")]
	public static void DebugCircle(Vector3 position, Vector3 up, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xB5D248", Offset = "0xB5D248", VA = "0xB5D248")]
	public static void DebugCircle(Vector3 position, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xB5D32C", Offset = "0xB5D32C", VA = "0xB5D32C")]
	public static void DebugCircle(Vector3 position, Vector3 up, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xB5D3C8", Offset = "0xB5D3C8", VA = "0xB5D3C8")]
	public static void DebugCircle(Vector3 position, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xB5D4B0", Offset = "0xB5D4B0", VA = "0xB5D4B0")]
	public static void DebugWireSphere(Vector3 position, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xB5D7DC", Offset = "0xB5D7DC", VA = "0xB5D7DC")]
	public static void DebugWireSphere(Vector3 position, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xB5D870", Offset = "0xB5D870", VA = "0xB5D870")]
	public static void DebugCylinder(Vector3 start, Vector3 end, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xB5DFE0", Offset = "0xB5DFE0", VA = "0xB5DFE0")]
	public static void DebugCylinder(Vector3 start, Vector3 end, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xB5E07C", Offset = "0xB5E07C", VA = "0xB5E07C")]
	public static void DebugCone(Vector3 position, Vector3 direction, Color color, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xB5E72C", Offset = "0xB5E72C", VA = "0xB5E72C")]
	public static void DebugCone(Vector3 position, Vector3 direction, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xB5E7C8", Offset = "0xB5E7C8", VA = "0xB5E7C8")]
	public static void DebugCone(Vector3 position, Color color, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xB5E8AC", Offset = "0xB5E8AC", VA = "0xB5E8AC")]
	public static void DebugCone(Vector3 position, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xB5E994", Offset = "0xB5E994", VA = "0xB5E994")]
	public static void DebugArrow(Vector3 position, Vector3 direction, Color color, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xB5EB38", Offset = "0xB5EB38", VA = "0xB5EB38")]
	public static void DebugArrow(Vector3 position, Vector3 direction, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xB5EBCC", Offset = "0xB5EBCC", VA = "0xB5EBCC")]
	public static void DebugCapsule(Vector3 start, Vector3 end, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xB5FA9C", Offset = "0xB5FA9C", VA = "0xB5FA9C")]
	public static void DebugCapsule(Vector3 start, Vector3 end, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xB5FB38", Offset = "0xB5FB38", VA = "0xB5FB38")]
	public static void DrawPoint(Vector3 position, Color color, float scale = 1f)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xB5FD8C", Offset = "0xB5FD8C", VA = "0xB5FD8C")]
	public static void DrawPoint(Vector3 position, float scale = 1f)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xB5FDF4", Offset = "0xB5FDF4", VA = "0xB5FDF4")]
	public static void DrawBounds(Bounds bounds, Color color)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xB602D8", Offset = "0xB602D8", VA = "0xB602D8")]
	public static void DrawBounds(Bounds bounds)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xB60310", Offset = "0xB60310", VA = "0xB60310")]
	public static void DrawLocalCube(Transform transform, Vector3 size, Color color, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xB608EC", Offset = "0xB608EC", VA = "0xB608EC")]
	public static void DrawLocalCube(Transform transform, Vector3 size, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xB60984", Offset = "0xB60984", VA = "0xB60984")]
	public static void DrawLocalCube(Matrix4x4 space, Vector3 size, Color color, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xB60F7C", Offset = "0xB60F7C", VA = "0xB60F7C")]
	public static void DrawLocalCube(Matrix4x4 space, Vector3 size, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xB61018", Offset = "0xB61018", VA = "0xB61018")]
	public static void DrawCircle(Vector3 position, Vector3 up, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xB614CC", Offset = "0xB614CC", VA = "0xB614CC")]
	public static void DrawCircle(Vector3 position, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xB615A0", Offset = "0xB615A0", VA = "0xB615A0")]
	public static void DrawCircle(Vector3 position, Vector3 up, float radius = 1f)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xB61608", Offset = "0xB61608", VA = "0xB61608")]
	public static void DrawCircle(Vector3 position, float radius = 1f)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xB616E0", Offset = "0xB616E0", VA = "0xB616E0")]
	public static void DrawCylinder(Vector3 start, Vector3 end, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xB61D74", Offset = "0xB61D74", VA = "0xB61D74")]
	public static void DrawCylinder(Vector3 start, Vector3 end, float radius = 1f)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xB61DF8", Offset = "0xB61DF8", VA = "0xB61DF8")]
	public static void DrawCone(Vector3 position, Vector3 direction, Color color, float angle = 45f)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xB62430", Offset = "0xB62430", VA = "0xB62430")]
	public static void DrawCone(Vector3 position, Vector3 direction, float angle = 45f)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xB624B4", Offset = "0xB624B4", VA = "0xB624B4")]
	public static void DrawCone(Vector3 position, Color color, float angle = 45f)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xB62588", Offset = "0xB62588", VA = "0xB62588")]
	public static void DrawCone(Vector3 position, float angle = 45f)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xB62660", Offset = "0xB62660", VA = "0xB62660")]
	public static void DrawArrow(Vector3 position, Vector3 direction, Color color)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xB627E8", Offset = "0xB627E8", VA = "0xB627E8")]
	public static void DrawArrow(Vector3 position, Vector3 direction)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xB6285C", Offset = "0xB6285C", VA = "0xB6285C")]
	public static void DrawCapsule(Vector3 start, Vector3 end, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xB634E8", Offset = "0xB634E8", VA = "0xB634E8")]
	public static void DrawCapsule(Vector3 start, Vector3 end, float radius = 1f)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xB6356C", Offset = "0xB6356C", VA = "0xB6356C")]
	public static string MethodsOfObject(object obj, bool includeInfo = false)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xB63688", Offset = "0xB63688", VA = "0xB63688")]
	public static string MethodsOfType(Type type, bool includeInfo = false)
	{
		return null;
	}
}
[Token(Token = "0x200000E")]
public class Example : MonoBehaviour
{
	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool debugPoint;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 debugPoint_Position;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float debugPoint_Scale;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color debugPoint_Color;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool debugBounds;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 debugBounds_Position;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector3 debugBounds_Size;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Color debugBounds_Color;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool debugCircle;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 debugCircle_Up;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float debugCircle_Radius;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Color debugCircle_Color;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool debugWireSphere;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float debugWireSphere_Radius;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public Color debugWireSphere_Color;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool debugCylinder;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Vector3 debugCylinder_End;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public float debugCylinder_Radius;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Color debugCylinder_Color;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool debugCone;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public Vector3 debugCone_Direction;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public float debugCone_Angle;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public Color debugCone_Color;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public bool debugArrow;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Vector3 debugArrow_Direction;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public Color debugArrow_Color;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public bool debugCapsule;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Vector3 debugCapsule_End;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public float debugCapsule_Radius;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Color debugCapsule_Color;

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x8D4234", Offset = "0x8D4234", VA = "0x8D4234")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x8D44F4", Offset = "0x8D44F4", VA = "0x8D44F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x8D47AC", Offset = "0x8D47AC", VA = "0x8D47AC")]
	public Example()
	{
	}
}
[Token(Token = "0x200000F")]
public class EnumFlagAttribute : PropertyAttribute
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string enumName;

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x8D4200", Offset = "0x8D4200", VA = "0x8D4200")]
	public EnumFlagAttribute()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x8D4208", Offset = "0x8D4208", VA = "0x8D4208")]
	public EnumFlagAttribute(string name)
	{
	}
}
[Token(Token = "0x2000010")]
public class GCM
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject _receiver;

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x8D47B4", Offset = "0x8D47B4", VA = "0x8D47B4")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x8D48DC", Offset = "0x8D48DC", VA = "0x8D48DC")]
	public static void ShowToast(string message)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x8D4A7C", Offset = "0x8D4A7C", VA = "0x8D4A7C")]
	public static void SetSendErrorCallback(Action<string> onError)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x8D4AE8", Offset = "0x8D4AE8", VA = "0x8D4AE8")]
	public static void SetMessageReceivedCallback(Action<string> onMessageReceived)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x8D4B54", Offset = "0x8D4B54", VA = "0x8D4B54")]
	public static void SetMessageSentCallback(Action<string> onMessageSent)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x8D4BC0", Offset = "0x8D4BC0", VA = "0x8D4BC0")]
	public static void SetDeletedMessagesCallback(Action<string> onDeletedMessages)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x8D4C2C", Offset = "0x8D4C2C", VA = "0x8D4C2C")]
	public GCM()
	{
	}
}
[Token(Token = "0x2000011")]
public class GCMReceiver : MonoBehaviour
{
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Action<string> _onMessageReceived;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Action<string> _onMessageSent;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Action<string> _onSendError;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static Action<string> _onDeletedMessages;

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x8D4C38", Offset = "0x8D4C38", VA = "0x8D4C38")]
	private void Awake()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x8D4CC4", Offset = "0x8D4CC4", VA = "0x8D4CC4")]
	public void OnMessageReceived(string message)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x8D4D7C", Offset = "0x8D4D7C", VA = "0x8D4D7C")]
	public void OnMessageSent(string msgId)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x8D4E34", Offset = "0x8D4E34", VA = "0x8D4E34")]
	public void OnSendError(string error)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x8D4EEC", Offset = "0x8D4EEC", VA = "0x8D4EEC")]
	public void OnDeletedMessages()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x8D4F74", Offset = "0x8D4F74", VA = "0x8D4F74")]
	public GCMReceiver()
	{
	}
}
[Token(Token = "0x2000012")]
public enum TweenAction
{
	[Token(Token = "0x4000038")]
	MOVE_X,
	[Token(Token = "0x4000039")]
	MOVE_Y,
	[Token(Token = "0x400003A")]
	MOVE_Z,
	[Token(Token = "0x400003B")]
	MOVE_LOCAL_X,
	[Token(Token = "0x400003C")]
	MOVE_LOCAL_Y,
	[Token(Token = "0x400003D")]
	MOVE_LOCAL_Z,
	[Token(Token = "0x400003E")]
	MOVE_CURVED,
	[Token(Token = "0x400003F")]
	MOVE_CURVED_LOCAL,
	[Token(Token = "0x4000040")]
	MOVE_SPLINE,
	[Token(Token = "0x4000041")]
	MOVE_SPLINE_LOCAL,
	[Token(Token = "0x4000042")]
	SCALE_X,
	[Token(Token = "0x4000043")]
	SCALE_Y,
	[Token(Token = "0x4000044")]
	SCALE_Z,
	[Token(Token = "0x4000045")]
	ROTATE_X,
	[Token(Token = "0x4000046")]
	ROTATE_Y,
	[Token(Token = "0x4000047")]
	ROTATE_Z,
	[Token(Token = "0x4000048")]
	ROTATE_AROUND,
	[Token(Token = "0x4000049")]
	ROTATE_AROUND_LOCAL,
	[Token(Token = "0x400004A")]
	CANVAS_ROTATEAROUND,
	[Token(Token = "0x400004B")]
	CANVAS_ROTATEAROUND_LOCAL,
	[Token(Token = "0x400004C")]
	CANVAS_PLAYSPRITE,
	[Token(Token = "0x400004D")]
	ALPHA,
	[Token(Token = "0x400004E")]
	TEXT_ALPHA,
	[Token(Token = "0x400004F")]
	CANVAS_ALPHA,
	[Token(Token = "0x4000050")]
	CANVASGROUP_ALPHA,
	[Token(Token = "0x4000051")]
	ALPHA_VERTEX,
	[Token(Token = "0x4000052")]
	COLOR,
	[Token(Token = "0x4000053")]
	CALLBACK_COLOR,
	[Token(Token = "0x4000054")]
	TEXT_COLOR,
	[Token(Token = "0x4000055")]
	CANVAS_COLOR,
	[Token(Token = "0x4000056")]
	CANVAS_MOVE_X,
	[Token(Token = "0x4000057")]
	CANVAS_MOVE_Y,
	[Token(Token = "0x4000058")]
	CANVAS_MOVE_Z,
	[Token(Token = "0x4000059")]
	CALLBACK,
	[Token(Token = "0x400005A")]
	MOVE,
	[Token(Token = "0x400005B")]
	MOVE_LOCAL,
	[Token(Token = "0x400005C")]
	MOVE_TO_TRANSFORM,
	[Token(Token = "0x400005D")]
	ROTATE,
	[Token(Token = "0x400005E")]
	ROTATE_LOCAL,
	[Token(Token = "0x400005F")]
	SCALE,
	[Token(Token = "0x4000060")]
	VALUE3,
	[Token(Token = "0x4000061")]
	GUI_MOVE,
	[Token(Token = "0x4000062")]
	GUI_MOVE_MARGIN,
	[Token(Token = "0x4000063")]
	GUI_SCALE,
	[Token(Token = "0x4000064")]
	GUI_ALPHA,
	[Token(Token = "0x4000065")]
	GUI_ROTATE,
	[Token(Token = "0x4000066")]
	DELAYED_SOUND,
	[Token(Token = "0x4000067")]
	CANVAS_MOVE,
	[Token(Token = "0x4000068")]
	CANVAS_SCALE
}
[Token(Token = "0x2000013")]
public enum LeanTweenType
{
	[Token(Token = "0x400006A")]
	notUsed,
	[Token(Token = "0x400006B")]
	linear,
	[Token(Token = "0x400006C")]
	easeOutQuad,
	[Token(Token = "0x400006D")]
	easeInQuad,
	[Token(Token = "0x400006E")]
	easeInOutQuad,
	[Token(Token = "0x400006F")]
	easeInCubic,
	[Token(Token = "0x4000070")]
	easeOutCubic,
	[Token(Token = "0x4000071")]
	easeInOutCubic,
	[Token(Token = "0x4000072")]
	easeInQuart,
	[Token(Token = "0x4000073")]
	easeOutQuart,
	[Token(Token = "0x4000074")]
	easeInOutQuart,
	[Token(Token = "0x4000075")]
	easeInQuint,
	[Token(Token = "0x4000076")]
	easeOutQuint,
	[Token(Token = "0x4000077")]
	easeInOutQuint,
	[Token(Token = "0x4000078")]
	easeInSine,
	[Token(Token = "0x4000079")]
	easeOutSine,
	[Token(Token = "0x400007A")]
	easeInOutSine,
	[Token(Token = "0x400007B")]
	easeInExpo,
	[Token(Token = "0x400007C")]
	easeOutExpo,
	[Token(Token = "0x400007D")]
	easeInOutExpo,
	[Token(Token = "0x400007E")]
	easeInCirc,
	[Token(Token = "0x400007F")]
	easeOutCirc,
	[Token(Token = "0x4000080")]
	easeInOutCirc,
	[Token(Token = "0x4000081")]
	easeInBounce,
	[Token(Token = "0x4000082")]
	easeOutBounce,
	[Token(Token = "0x4000083")]
	easeInOutBounce,
	[Token(Token = "0x4000084")]
	easeInBack,
	[Token(Token = "0x4000085")]
	easeOutBack,
	[Token(Token = "0x4000086")]
	easeInOutBack,
	[Token(Token = "0x4000087")]
	easeInElastic,
	[Token(Token = "0x4000088")]
	easeOutElastic,
	[Token(Token = "0x4000089")]
	easeInOutElastic,
	[Token(Token = "0x400008A")]
	easeSpring,
	[Token(Token = "0x400008B")]
	easeShake,
	[Token(Token = "0x400008C")]
	punch,
	[Token(Token = "0x400008D")]
	once,
	[Token(Token = "0x400008E")]
	clamp,
	[Token(Token = "0x400008F")]
	pingPong,
	[Token(Token = "0x4000090")]
	animationCurve
}
[Token(Token = "0x2000014")]
public class LeanTween : MonoBehaviour
{
	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool throwErrors;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float tau;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static LTDescrImpl[] tweens;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int[] tweensFinished;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static LTDescrImpl tween;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static int tweenMaxSearch;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static int maxTweens;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int frameRendered;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static GameObject _tweenEmpty;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static float dtEstimated;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public static float dtManual;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static float dt;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static float dtActual;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static int i;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private static int j;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static int finishedCnt;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static AnimationCurve punch;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static AnimationCurve shake;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static Transform trans;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static float timeTotal;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private static TweenAction tweenAction;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static float ratioPassed;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private static float from;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static float val;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private static bool isTweenFinished;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static int maxTweenReached;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private static Vector3 newVect;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static GameObject target;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static GameObject customTarget;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static int startSearch;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public static LTDescr d;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static Action<LTEvent>[] eventListeners;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static GameObject[] goListeners;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private static int eventsMaxSearch;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public static int EVENTS_MAX;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public static int LISTENERS_MAX;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private static int INIT_LISTENERS_MAX;

	[Token(Token = "0x17000002")]
	public static int maxSearch
	{
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x8DF8C8", Offset = "0x8DF8C8", VA = "0x8DF8C8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000003")]
	public static int maxSimulataneousTweens
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x8DF930", Offset = "0x8DF930", VA = "0x8DF930")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000004")]
	public static int tweensRunning
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x8DF998", Offset = "0x8DF998", VA = "0x8DF998")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000005")]
	public static GameObject tweenEmpty
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x8EB3D4", Offset = "0x8EB3D4", VA = "0x8EB3D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x8DF534", Offset = "0x8DF534", VA = "0x8DF534")]
	public static void init()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x8DF59C", Offset = "0x8DF59C", VA = "0x8DF59C")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x8DFA78", Offset = "0x8DFA78", VA = "0x8DFA78")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x8DFBA0", Offset = "0x8DFBA0", VA = "0x8DFBA0")]
	public void Update()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x8E58A0", Offset = "0x8E58A0", VA = "0x8E58A0")]
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x8E5910", Offset = "0x8E5910", VA = "0x8E5910")]
	private static void internalOnLevelWasLoaded(int lvl)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x8DFBFC", Offset = "0x8DFBFC", VA = "0x8DFBFC")]
	public static void update()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x8E7238", Offset = "0x8E7238", VA = "0x8E7238")]
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x8E7B38", Offset = "0x8E7B38", VA = "0x8E7B38")]
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x8E7EC0", Offset = "0x8E7EC0", VA = "0x8E7EC0")]
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x8E6EBC", Offset = "0x8E6EBC", VA = "0x8E6EBC")]
	private static void alphaRecursiveSprite(Transform transform, float val)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x8E7780", Offset = "0x8E7780", VA = "0x8E7780")]
	private static void colorRecursiveSprite(Transform transform, Color toColor)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x8E8514", Offset = "0x8E8514", VA = "0x8E8514")]
	private static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x8E81EC", Offset = "0x8E81EC", VA = "0x8E81EC")]
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x8E8840", Offset = "0x8E8840", VA = "0x8E8840")]
	private static void textColorRecursive(Transform trans, Color toColor)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x8E7674", Offset = "0x8E7674", VA = "0x8E7674")]
	private static Color tweenColor(LTDescrImpl tween, float val)
	{
		return default(Color);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x8D6CB8", Offset = "0x8D6CB8", VA = "0x8D6CB8")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x8E596C", Offset = "0x8E596C", VA = "0x8E596C")]
	public static void removeTween(int i)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x8E8C84", Offset = "0x8E8C84", VA = "0x8E8C84")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x8D81BC", Offset = "0x8D81BC", VA = "0x8D81BC")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x8E8E40", Offset = "0x8E8E40", VA = "0x8E8E40")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x8E8EA0", Offset = "0x8E8EA0", VA = "0x8E8EA0")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x8CD6C8", Offset = "0x8CD6C8", VA = "0x8CD6C8")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x8E908C", Offset = "0x8E908C", VA = "0x8E908C")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x8E92DC", Offset = "0x8E92DC", VA = "0x8E92DC")]
	public static void cancel(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x8E94D8", Offset = "0x8E94D8", VA = "0x8E94D8")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x8E9608", Offset = "0x8E9608", VA = "0x8E9608")]
	public static void cancel(int uniqueId)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x8E9670", Offset = "0x8E9670", VA = "0x8E9670")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x8E97F0", Offset = "0x8E97F0", VA = "0x8E97F0")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x8E9A84", Offset = "0x8E9A84", VA = "0x8E9A84")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x8E9AE8", Offset = "0x8E9AE8", VA = "0x8E9AE8")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x8E9D24", Offset = "0x8E9D24", VA = "0x8E9D24")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x58C2B0", Offset = "0x58C2B0")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x8E9D88", Offset = "0x8E9D88", VA = "0x8E9D88")]
	public static void pause(int uniqueId)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x8E9E8C", Offset = "0x8E9E8C", VA = "0x8E9E8C")]
	public static void pause(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x8EA00C", Offset = "0x8EA00C", VA = "0x8EA00C")]
	public static void pauseAll()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x8EA104", Offset = "0x8EA104", VA = "0x8EA104")]
	public static void resumeAll()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x8EA1F0", Offset = "0x8EA1F0", VA = "0x8EA1F0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x58C2E8", Offset = "0x58C2E8")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x8EA254", Offset = "0x8EA254", VA = "0x8EA254")]
	public static void resume(int uniqueId)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x8EA34C", Offset = "0x8EA34C", VA = "0x8EA34C")]
	public static void resume(GameObject gameObject)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x8EA4C0", Offset = "0x8EA4C0", VA = "0x8EA4C0")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x8EA6EC", Offset = "0x8EA6EC", VA = "0x8EA6EC")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x8EA818", Offset = "0x8EA818", VA = "0x8EA818")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x8EA94C", Offset = "0x8EA94C", VA = "0x8EA94C")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x8D5850", Offset = "0x8D5850", VA = "0x8D5850")]
	public static object logError(string error)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x8EAFE0", Offset = "0x8EAFE0", VA = "0x8EAFE0")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x8EB054", Offset = "0x8EB054", VA = "0x8EB054")]
	public static LTDescr options()
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x8EB44C", Offset = "0x8EB44C", VA = "0x8EB44C")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, TweenAction tweenAction, LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x8D375C", Offset = "0x8D375C", VA = "0x8D375C")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x8D1474", Offset = "0x8D1474", VA = "0x8D1474")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x8EB6F8", Offset = "0x8EB6F8", VA = "0x8EB6F8")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x8D34F8", Offset = "0x8D34F8", VA = "0x8D34F8")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x8EB848", Offset = "0x8EB848", VA = "0x8EB848")]
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x8EB918", Offset = "0x8EB918", VA = "0x8EB918")]
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x8D152C", Offset = "0x8D152C", VA = "0x8D152C")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x8D3938", Offset = "0x8D3938", VA = "0x8D3938")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x8D35C8", Offset = "0x8D35C8", VA = "0x8D35C8")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x8EB9E8", Offset = "0x8EB9E8", VA = "0x8EB9E8")]
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x8EBB7C", Offset = "0x8EBB7C", VA = "0x8EBB7C")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x8EBCD4", Offset = "0x8EBCD4", VA = "0x8EBCD4")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x8CD9F8", Offset = "0x8CD9F8", VA = "0x8CD9F8")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x8D4040", Offset = "0x8D4040", VA = "0x8D4040")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x8EBE2C", Offset = "0x8EBE2C", VA = "0x8EBE2C")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x8D15E4", Offset = "0x8D15E4", VA = "0x8D15E4")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x8EBFF4", Offset = "0x8EBFF4", VA = "0x8EBFF4")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x8D1B74", Offset = "0x8D1B74", VA = "0x8D1B74")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x8EC0D4", Offset = "0x8EC0D4", VA = "0x8EC0D4")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x8EC228", Offset = "0x8EC228", VA = "0x8EC228")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x8D2104", Offset = "0x8D2104", VA = "0x8D2104")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x8EC37C", Offset = "0x8EC37C", VA = "0x8EC37C")]
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x8EC4D0", Offset = "0x8EC4D0", VA = "0x8EC4D0")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x8EC648", Offset = "0x8EC648", VA = "0x8EC648")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x8EC7B0", Offset = "0x8EC7B0", VA = "0x8EC7B0")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x8D194C", Offset = "0x8D194C", VA = "0x8D194C")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x8D1A04", Offset = "0x8D1A04", VA = "0x8D1A04")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x8D1ABC", Offset = "0x8D1ABC", VA = "0x8D1ABC")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x8D1684", Offset = "0x8D1684", VA = "0x8D1684")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x8D1E3C", Offset = "0x8D1E3C", VA = "0x8D1E3C")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x8D1724", Offset = "0x8D1724", VA = "0x8D1724")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x8D17DC", Offset = "0x8D17DC", VA = "0x8D17DC")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x8D1894", Offset = "0x8D1894", VA = "0x8D1894")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x8EC918", Offset = "0x8EC918", VA = "0x8EC918")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x8ECA6C", Offset = "0x8ECA6C", VA = "0x8ECA6C")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x8ECBC0", Offset = "0x8ECBC0", VA = "0x8ECBC0")]
	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x8D227C", Offset = "0x8D227C", VA = "0x8D227C")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x8ECD10", Offset = "0x8ECD10", VA = "0x8ECD10")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x8D25CC", Offset = "0x8D25CC", VA = "0x8D25CC")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x8D266C", Offset = "0x8D266C", VA = "0x8D266C")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x8D2724", Offset = "0x8D2724", VA = "0x8D2724")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x8D27DC", Offset = "0x8D27DC", VA = "0x8D27DC")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x8D231C", Offset = "0x8D231C", VA = "0x8D231C")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x8D2474", Offset = "0x8D2474", VA = "0x8D2474")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x8D2894", Offset = "0x8D2894", VA = "0x8D2894")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x8ECE54", Offset = "0x8ECE54", VA = "0x8ECE54")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x8D2934", Offset = "0x8D2934", VA = "0x8D2934")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x8D29EC", Offset = "0x8D29EC", VA = "0x8D29EC")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x8D2AA4", Offset = "0x8D2AA4", VA = "0x8D2AA4")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x8ECFBC", Offset = "0x8ECFBC", VA = "0x8ECFBC")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x8ED12C", Offset = "0x8ED12C", VA = "0x8ED12C")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x8ED354", Offset = "0x8ED354", VA = "0x8ED354")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x8ED494", Offset = "0x8ED494", VA = "0x8ED494")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x8ED720", Offset = "0x8ED720", VA = "0x8ED720")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x8ED9B4", Offset = "0x8ED9B4", VA = "0x8ED9B4")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x8EDC48", Offset = "0x8EDC48", VA = "0x8EDC48")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x8EE00C", Offset = "0x8EE00C", VA = "0x8EE00C")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x8EE2A8", Offset = "0x8EE2A8", VA = "0x8EE2A8")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x8EE4DC", Offset = "0x8EE4DC", VA = "0x8EE4DC")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x8EE774", Offset = "0x8EE774", VA = "0x8EE774")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x8D3AB8", Offset = "0x8D3AB8", VA = "0x8D3AB8")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x8D2B5C", Offset = "0x8D2B5C", VA = "0x8D2B5C")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x8EE9CC", Offset = "0x8EE9CC", VA = "0x8EE9CC")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x8EEB1C", Offset = "0x8EEB1C", VA = "0x8EEB1C")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x8EEC6C", Offset = "0x8EEC6C", VA = "0x8EEC6C")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x8EEDBC", Offset = "0x8EEDBC", VA = "0x8EEDBC")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x8D2DD4", Offset = "0x8D2DD4", VA = "0x8D2DD4")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x8D2FB8", Offset = "0x8D2FB8", VA = "0x8D2FB8")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x8D2C98", Offset = "0x8D2C98", VA = "0x8D2C98")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x8D319C", Offset = "0x8D319C", VA = "0x8D319C")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x8D32EC", Offset = "0x8D32EC", VA = "0x8D32EC")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x8E5D6C", Offset = "0x8E5D6C", VA = "0x8E5D6C")]
	private static float tweenOnCurve(LTDescrImpl tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x8E8BA0", Offset = "0x8E8BA0", VA = "0x8E8BA0")]
	private static Vector3 tweenOnCurveVector(LTDescrImpl tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x8E5DB0", Offset = "0x8E5DB0", VA = "0x8E5DB0")]
	private static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x8E5DC8", Offset = "0x8E5DC8", VA = "0x8E5DC8")]
	private static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x8E5DD8", Offset = "0x8E5DD8", VA = "0x8E5DD8")]
	private static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x8EEFC4", Offset = "0x8EEFC4", VA = "0x8EEFC4")]
	private static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x8EF04C", Offset = "0x8EF04C", VA = "0x8EF04C")]
	private static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x8E6DB8", Offset = "0x8E6DB8", VA = "0x8E6DB8")]
	private static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x8EF120", Offset = "0x8EF120", VA = "0x8EF120")]
	private static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x8EF134", Offset = "0x8EF134", VA = "0x8EF134")]
	private static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x8EF150", Offset = "0x8EF150", VA = "0x8EF150")]
	private static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x8E5E28", Offset = "0x8E5E28", VA = "0x8E5E28")]
	private static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x8E5E40", Offset = "0x8E5E40", VA = "0x8E5E40")]
	private static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x8E5E68", Offset = "0x8E5E68", VA = "0x8E5E68")]
	private static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x8E5EC0", Offset = "0x8E5EC0", VA = "0x8E5EC0")]
	private static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x8E5EDC", Offset = "0x8E5EDC", VA = "0x8E5EDC")]
	private static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x8E5F04", Offset = "0x8E5F04", VA = "0x8E5F04")]
	private static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x8E5F60", Offset = "0x8E5F60", VA = "0x8E5F60")]
	private static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x8E5F80", Offset = "0x8E5F80", VA = "0x8E5F80")]
	private static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x8E5FB0", Offset = "0x8E5FB0", VA = "0x8E5FB0")]
	private static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x8E6018", Offset = "0x8E6018", VA = "0x8E6018")]
	private static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x8E60B0", Offset = "0x8E60B0", VA = "0x8E60B0")]
	private static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x8E6144", Offset = "0x8E6144", VA = "0x8E6144")]
	private static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x8E61E8", Offset = "0x8E61E8", VA = "0x8E61E8")]
	private static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x8E6280", Offset = "0x8E6280", VA = "0x8E6280")]
	private static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x8E6318", Offset = "0x8E6318", VA = "0x8E6318")]
	private static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x8E6408", Offset = "0x8E6408", VA = "0x8E6408")]
	private static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x8E64B4", Offset = "0x8E64B4", VA = "0x8E64B4")]
	private static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x8E6560", Offset = "0x8E6560", VA = "0x8E6560")]
	private static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x8E6658", Offset = "0x8E6658", VA = "0x8E6658")]
	private static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x8E66F0", Offset = "0x8E66F0", VA = "0x8E66F0")]
	private static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x8E67BC", Offset = "0x8E67BC", VA = "0x8E67BC")]
	private static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x8E6894", Offset = "0x8E6894", VA = "0x8E6894")]
	private static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x8E68C8", Offset = "0x8E68C8", VA = "0x8E68C8")]
	private static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x8E6908", Offset = "0x8E6908", VA = "0x8E6908")]
	private static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x8E69A0", Offset = "0x8E69A0", VA = "0x8E69A0")]
	private static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x8E6AD4", Offset = "0x8E6AD4", VA = "0x8E6AD4")]
	private static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x8E6BF8", Offset = "0x8E6BF8", VA = "0x8E6BF8")]
	private static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x8EF1A4", Offset = "0x8EF1A4", VA = "0x8EF1A4")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x8EF21C", Offset = "0x8EF21C", VA = "0x8EF21C")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x8EF6C8", Offset = "0x8EF6C8", VA = "0x8EF6C8")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x8EF740", Offset = "0x8EF740", VA = "0x8EF740")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x8EF96C", Offset = "0x8EF96C", VA = "0x8EF96C")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x8EF9D4", Offset = "0x8EF9D4", VA = "0x8EF9D4")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x8EFBF4", Offset = "0x8EFBF4", VA = "0x8EFBF4")]
	public LeanTween()
	{
	}
}
[Token(Token = "0x2000015")]
public class LTUtility
{
	[Token(Token = "0x600011A")]
	[Address(RVA = "0x8D9198", Offset = "0x8D9198", VA = "0x8D9198")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x8DCFFC", Offset = "0x8DCFFC", VA = "0x8DCFFC")]
	public LTUtility()
	{
	}
}
[Token(Token = "0x2000016")]
public class LTBezier
{
	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float length;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Vector3 a;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 aa;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 bb;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 cc;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float len;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] arcLengths;

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x8D4F80", Offset = "0x8D4F80", VA = "0x8D4F80")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x8D53C8", Offset = "0x8D53C8", VA = "0x8D53C8")]
	private float map(float u)
	{
		return default(float);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x8D52F0", Offset = "0x8D52F0", VA = "0x8D52F0")]
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x8D54CC", Offset = "0x8D54CC", VA = "0x8D54CC")]
	public Vector3 point(float t)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000017")]
public class LTBezierPath
{
	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3[] pts;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float length;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool orientToPath;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool orientToPath2d;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LTBezier[] beziers;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] lengthRatio;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int currentBezier;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int previousBezier;

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x8D54F0", Offset = "0x8D54F0", VA = "0x8D54F0")]
	public LTBezierPath()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x8D54F8", Offset = "0x8D54F8", VA = "0x8D54F8")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x8D5528", Offset = "0x8D5528", VA = "0x8D5528")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x8D5910", Offset = "0x8D5910", VA = "0x8D5910")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x8D59E8", Offset = "0x8D59E8", VA = "0x8D59E8")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x8D5B6C", Offset = "0x8D5B6C", VA = "0x8D5B6C")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x8D5D14", Offset = "0x8D5D14", VA = "0x8D5D14")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x8D5DB8", Offset = "0x8D5DB8", VA = "0x8D5DB8")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x8D5E58", Offset = "0x8D5E58", VA = "0x8D5E58")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x8D5EFC", Offset = "0x8D5EFC", VA = "0x8D5EFC")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x8D5FDC", Offset = "0x8D5FDC", VA = "0x8D5FDC")]
	public float getRationInOneRange(float ratio)
	{
		return default(float);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x8D6088", Offset = "0x8D6088", VA = "0x8D6088")]
	public void gizmoDraw(float t = -1f)
	{
	}
}
[Serializable]
[Token(Token = "0x2000018")]
public class LTSpline
{
	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int DISTANCE_COUNT;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int SUBLINE_COUNT;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float distance;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] pts;

	[NonSerialized]
	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] ptsAdj;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int ptsAdjLength;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool orientToPath;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool orientToPath2d;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int numSections;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int currPt;

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x8D9240", Offset = "0x8D9240", VA = "0x8D9240")]
	public LTSpline(params Vector3[] pts)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x8DC22C", Offset = "0x8DC22C", VA = "0x8DC22C")]
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x8DBDEC", Offset = "0x8DBDEC", VA = "0x8DBDEC")]
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x8DC3D4", Offset = "0x8DC3D4", VA = "0x8DC3D4")]
	public float ratioAtPoint(Vector3 pt)
	{
		return default(float);
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x8DC518", Offset = "0x8DC518", VA = "0x8DC518")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x8DC524", Offset = "0x8DC524", VA = "0x8DC524")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x8DC6AC", Offset = "0x8DC6AC", VA = "0x8DC6AC")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x8DC854", Offset = "0x8DC854", VA = "0x8DC854")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x8DC8F8", Offset = "0x8DC8F8", VA = "0x8DC8F8")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x8DC9AC", Offset = "0x8DC9AC", VA = "0x8DC9AC")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x8DCA50", Offset = "0x8DCA50", VA = "0x8DCA50")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x8DCB30", Offset = "0x8DCB30", VA = "0x8DCB30")]
	public void gizmoDraw(float t = -1f)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x8DCBF8", Offset = "0x8DCBF8", VA = "0x8DCBF8")]
	public void drawGizmo(Color color)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x8DCD5C", Offset = "0x8DCD5C", VA = "0x8DCD5C")]
	public static void drawGizmo(Transform[] arr, Color color)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x8DCF84", Offset = "0x8DCF84", VA = "0x8DCF84")]
	public static void drawLine(Transform[] arr, float width, Color color)
	{
	}
}
[Serializable]
[Token(Token = "0x2000019")]
public class LTRect
{
	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Rect _rect;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float alpha;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float rotation;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 pivot;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 margin;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rect relativeRect;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool rotateEnabled;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[HideInInspector]
	public bool rotateFinished;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool alphaEnabled;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string labelStr;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LTGUI.Element_Type type;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GUIStyle style;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool useColor;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Color color;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool fontScaleToFit;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool useSimpleScale;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
	public bool sizeByHeight;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Texture texture;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _id;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public int counter;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool colorTouched;

	[Token(Token = "0x17000006")]
	public bool hasInitiliazed
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x8DA7DC", Offset = "0x8DA7DC", VA = "0x8DA7DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000007")]
	public int id
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x8DAF44", Offset = "0x8DAF44", VA = "0x8DAF44")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000008")]
	public float x
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x8DBA30", Offset = "0x8DBA30", VA = "0x8DBA30")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x8DBA3C", Offset = "0x8DBA3C", VA = "0x8DBA3C")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public float y
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x8DBA48", Offset = "0x8DBA48", VA = "0x8DBA48")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x8DBA54", Offset = "0x8DBA54", VA = "0x8DBA54")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public float width
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x8DBA60", Offset = "0x8DBA60", VA = "0x8DBA60")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x8DBA6C", Offset = "0x8DBA6C", VA = "0x8DBA6C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public float height
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x8DBA78", Offset = "0x8DBA78", VA = "0x8DBA78")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x8DBA84", Offset = "0x8DBA84", VA = "0x8DBA84")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public Rect rect
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x8D827C", Offset = "0x8D827C", VA = "0x8D827C")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x8DBA90", Offset = "0x8DBA90", VA = "0x8DBA90")]
		set
		{
		}
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x8DB640", Offset = "0x8DB640", VA = "0x8DB640")]
	public LTRect()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x8D8EF4", Offset = "0x8D8EF4", VA = "0x8D8EF4")]
	public LTRect(Rect rect)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x8DB780", Offset = "0x8DB780", VA = "0x8DB780")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x8DB858", Offset = "0x8DB858", VA = "0x8DB858")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x8DB938", Offset = "0x8DB938", VA = "0x8DB938")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x8DAF50", Offset = "0x8DAF50", VA = "0x8DAF50")]
	public void setId(int id, int counter)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x8DB6F8", Offset = "0x8DB6F8", VA = "0x8DB6F8")]
	public void reset()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x8D8494", Offset = "0x8D8494", VA = "0x8D8494")]
	public void resetForRotation()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x8DBA9C", Offset = "0x8DBA9C", VA = "0x8DBA9C")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x8DBAA4", Offset = "0x8DBAA4", VA = "0x8DBAA4")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x8DBAB0", Offset = "0x8DBAB0", VA = "0x8DBAB0")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x8DBAC4", Offset = "0x8DBAC4", VA = "0x8DBAC4")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x8DBACC", Offset = "0x8DBACC", VA = "0x8DBACC")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x8DBAD4", Offset = "0x8DBAD4", VA = "0x8DBAD4")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x8DBAE8", Offset = "0x8DBAE8", VA = "0x8DBAE8")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x8DBB54", Offset = "0x8DBB54", VA = "0x8DBB54")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x8DBB60", Offset = "0x8DBB60", VA = "0x8DBB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x200001A")]
public class LTEvent
{
	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public object data;

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x8D95FC", Offset = "0x8D95FC", VA = "0x8D95FC")]
	public LTEvent(int id, object data)
	{
	}
}
[Token(Token = "0x200001B")]
public class LTGUI
{
	[Token(Token = "0x200007B")]
	public enum Element_Type
	{
		[Token(Token = "0x40004C1")]
		Texture,
		[Token(Token = "0x40004C2")]
		Label
	}

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int RECT_LEVELS;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int RECTS_PER_LEVEL;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int BUTTONS_MAX;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTRect[] levels;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int[] levelDepths;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Rect[] buttons;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int[] buttonLevels;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int[] buttonLastFrame;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static LTRect r;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static Color color;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static bool isGUIEnabled;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static int global_counter;

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x8D9638", Offset = "0x8D9638", VA = "0x8D9638")]
	public static void init()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x8D970C", Offset = "0x8D970C", VA = "0x8D970C")]
	public static void initRectCheck()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x8D988C", Offset = "0x8D988C", VA = "0x8D988C")]
	public static void reset()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x8D9A1C", Offset = "0x8D9A1C", VA = "0x8D9A1C")]
	public static void update(int updateLevel)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x8DA588", Offset = "0x8DA588", VA = "0x8DA588")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x8DA668", Offset = "0x8DA668", VA = "0x8DA668")]
	public static void destroy(int id)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x8DA7EC", Offset = "0x8DA7EC", VA = "0x8DA7EC")]
	public static void destroyAll(int depth)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x8DA8F0", Offset = "0x8DA8F0", VA = "0x8DA8F0")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x8DA9B0", Offset = "0x8DA9B0", VA = "0x8DA9B0")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x8DADFC", Offset = "0x8DADFC", VA = "0x8DADFC")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x8DAEBC", Offset = "0x8DAEBC", VA = "0x8DAEBC")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x8DAA3C", Offset = "0x8DAA3C", VA = "0x8DAA3C")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x8DAF58", Offset = "0x8DAF58", VA = "0x8DAF58")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x8DB28C", Offset = "0x8DB28C", VA = "0x8DB28C")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x8DB4C8", Offset = "0x8DB4C8", VA = "0x8DB4C8")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x8DB3B0", Offset = "0x8DB3B0", VA = "0x8DB3B0")]
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x8DB59C", Offset = "0x8DB59C", VA = "0x8DB59C")]
	public LTGUI()
	{
	}
}
[Token(Token = "0x200001C")]
public interface ILeanTween
{
	[Token(Token = "0x1700000D")]
	GameObject tweenEmpty
	{
		[Token(Token = "0x6000187")]
		get;
	}

	[Token(Token = "0x600016C")]
	void removeTween(int i, int uniqueId);

	[Token(Token = "0x600016D")]
	void removeTween(int i);

	[Token(Token = "0x600016E")]
	Vector3[] add(Vector3[] a, Vector3 b);

	[Token(Token = "0x600016F")]
	float closestRot(float from, float to);

	[Token(Token = "0x6000170")]
	void cancelAll();

	[Token(Token = "0x6000171")]
	void cancelAll(bool callComplete);

	[Token(Token = "0x6000172")]
	void cancel(GameObject gameObject);

	[Token(Token = "0x6000173")]
	void cancel(GameObject gameObject, bool callOnComplete);

	[Token(Token = "0x6000174")]
	void cancel(GameObject gameObject, int uniqueId);

	[Token(Token = "0x6000175")]
	void cancel(LTRect ltRect, int uniqueId);

	[Token(Token = "0x6000176")]
	void cancel(int uniqueId);

	[Token(Token = "0x6000177")]
	void cancel(int uniqueId, bool callOnComplete);

	[Token(Token = "0x6000178")]
	LTDescr descr(int uniqueId);

	[Token(Token = "0x6000179")]
	LTDescr description(int uniqueId);

	[Token(Token = "0x600017A")]
	LTDescr[] descriptions([Optional] GameObject gameObject);

	[Token(Token = "0x600017B")]
	void pause(int uniqueId);

	[Token(Token = "0x600017C")]
	void pause(GameObject gameObject);

	[Token(Token = "0x600017D")]
	void pauseAll();

	[Token(Token = "0x600017E")]
	void resumeAll();

	[Token(Token = "0x600017F")]
	void resume(int uniqueId);

	[Token(Token = "0x6000180")]
	void resume(GameObject gameObject);

	[Token(Token = "0x6000181")]
	bool isTweening([Optional] GameObject gameObject);

	[Token(Token = "0x6000182")]
	bool isTweening(int uniqueId);

	[Token(Token = "0x6000183")]
	bool isTweening(LTRect ltRect);

	[Token(Token = "0x6000184")]
	void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform);

	[Token(Token = "0x6000185")]
	LTDescr options(LTDescr seed);

	[Token(Token = "0x6000186")]
	LTDescr options();

	[Token(Token = "0x6000188")]
	LTDescr alpha(GameObject gameObject, float to, float time);

	[Token(Token = "0x6000189")]
	LTDescr alpha(LTRect ltRect, float to, float time);

	[Token(Token = "0x600018A")]
	LTDescr alphaVertex(GameObject gameObject, float to, float time);

	[Token(Token = "0x600018B")]
	LTDescr color(GameObject gameObject, Color to, float time);

	[Token(Token = "0x600018C")]
	LTDescr delayedCall(float delayTime, Action callback);

	[Token(Token = "0x600018D")]
	LTDescr delayedCall(float delayTime, Action<object> callback);

	[Token(Token = "0x600018E")]
	LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback);

	[Token(Token = "0x600018F")]
	LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback);

	[Token(Token = "0x6000190")]
	LTDescr destroyAfter(LTRect rect, float delayTime);

	[Token(Token = "0x6000191")]
	LTDescr move(GameObject gameObject, Vector3 to, float time);

	[Token(Token = "0x6000192")]
	LTDescr move(GameObject gameObject, Vector2 to, float time);

	[Token(Token = "0x6000193")]
	LTDescr move(GameObject gameObject, Vector3[] to, float time);

	[Token(Token = "0x6000194")]
	LTDescr move(GameObject gameObject, LTBezierPath to, float time);

	[Token(Token = "0x6000195")]
	LTDescr move(GameObject gameObject, LTSpline to, float time);

	[Token(Token = "0x6000196")]
	LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time);

	[Token(Token = "0x6000197")]
	LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time);

	[Token(Token = "0x6000198")]
	LTDescr move(LTRect ltRect, Vector2 to, float time);

	[Token(Token = "0x6000199")]
	LTDescr moveMargin(LTRect ltRect, Vector2 to, float time);

	[Token(Token = "0x600019A")]
	LTDescr moveX(GameObject gameObject, float to, float time);

	[Token(Token = "0x600019B")]
	LTDescr moveY(GameObject gameObject, float to, float time);

	[Token(Token = "0x600019C")]
	LTDescr moveZ(GameObject gameObject, float to, float time);

	[Token(Token = "0x600019D")]
	LTDescr moveLocal(GameObject gameObject, Vector3 to, float time);

	[Token(Token = "0x600019E")]
	LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time);

	[Token(Token = "0x600019F")]
	LTDescr moveLocalX(GameObject gameObject, float to, float time);

	[Token(Token = "0x60001A0")]
	LTDescr moveLocalY(GameObject gameObject, float to, float time);

	[Token(Token = "0x60001A1")]
	LTDescr moveLocalZ(GameObject gameObject, float to, float time);

	[Token(Token = "0x60001A2")]
	LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time);

	[Token(Token = "0x60001A3")]
	LTDescr moveLocal(GameObject gameObject, LTSpline to, float time);

	[Token(Token = "0x60001A4")]
	LTDescr move(GameObject gameObject, Transform to, float time);

	[Token(Token = "0x60001A5")]
	LTDescr rotate(GameObject gameObject, Vector3 to, float time);

	[Token(Token = "0x60001A6")]
	LTDescr rotate(LTRect ltRect, float to, float time);

	[Token(Token = "0x60001A7")]
	LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time);

	[Token(Token = "0x60001A8")]
	LTDescr rotateX(GameObject gameObject, float to, float time);

	[Token(Token = "0x60001A9")]
	LTDescr rotateY(GameObject gameObject, float to, float time);

	[Token(Token = "0x60001AA")]
	LTDescr rotateZ(GameObject gameObject, float to, float time);

	[Token(Token = "0x60001AB")]
	LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time);

	[Token(Token = "0x60001AC")]
	LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time);

	[Token(Token = "0x60001AD")]
	LTDescr scale(GameObject gameObject, Vector3 to, float time);

	[Token(Token = "0x60001AE")]
	LTDescr scale(LTRect ltRect, Vector2 to, float time);

	[Token(Token = "0x60001AF")]
	LTDescr scaleX(GameObject gameObject, float to, float time);

	[Token(Token = "0x60001B0")]
	LTDescr scaleY(GameObject gameObject, float to, float time);

	[Token(Token = "0x60001B1")]
	LTDescr scaleZ(GameObject gameObject, float to, float time);

	[Token(Token = "0x60001B2")]
	LTDescr value(GameObject gameObject, float from, float to, float time);

	[Token(Token = "0x60001B3")]
	LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time);

	[Token(Token = "0x60001B4")]
	LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time);

	[Token(Token = "0x60001B5")]
	LTDescr value(GameObject gameObject, Color from, Color to, float time);

	[Token(Token = "0x60001B6")]
	LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time);

	[Token(Token = "0x60001B7")]
	LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time);

	[Token(Token = "0x60001B8")]
	LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time);

	[Token(Token = "0x60001B9")]
	LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time);

	[Token(Token = "0x60001BA")]
	LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time);

	[Token(Token = "0x60001BB")]
	LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time);

	[Token(Token = "0x60001BC")]
	LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume);

	[Token(Token = "0x60001BD")]
	LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume);

	[Token(Token = "0x60001BE")]
	LTDescr play(RectTransform rectTransform, Sprite[] sprites);

	[Token(Token = "0x60001BF")]
	LTDescr textAlpha(RectTransform rectTransform, float to, float time);

	[Token(Token = "0x60001C0")]
	LTDescr textColor(RectTransform rectTransform, Color to, float time);

	[Token(Token = "0x60001C1")]
	LTDescr move(RectTransform rectTrans, Vector3 to, float time);

	[Token(Token = "0x60001C2")]
	LTDescr moveX(RectTransform rectTrans, float to, float time);

	[Token(Token = "0x60001C3")]
	LTDescr moveY(RectTransform rectTrans, float to, float time);

	[Token(Token = "0x60001C4")]
	LTDescr moveZ(RectTransform rectTrans, float to, float time);

	[Token(Token = "0x60001C5")]
	LTDescr rotate(RectTransform rectTrans, float to, float time);

	[Token(Token = "0x60001C6")]
	LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time);

	[Token(Token = "0x60001C7")]
	LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time);

	[Token(Token = "0x60001C8")]
	LTDescr scale(RectTransform rectTrans, Vector3 to, float time);

	[Token(Token = "0x60001C9")]
	LTDescr alpha(RectTransform rectTrans, float to, float time);

	[Token(Token = "0x60001CA")]
	LTDescr color(RectTransform rectTrans, Color to, float time);
}
[Token(Token = "0x200001D")]
public interface LTDescr
{
	[Token(Token = "0x1700000E")]
	bool toggle
	{
		[Token(Token = "0x60001CB")]
		get;
		[Token(Token = "0x60001CC")]
		set;
	}

	[Token(Token = "0x1700000F")]
	bool useEstimatedTime
	{
		[Token(Token = "0x60001CD")]
		get;
		[Token(Token = "0x60001CE")]
		set;
	}

	[Token(Token = "0x17000010")]
	bool useFrames
	{
		[Token(Token = "0x60001CF")]
		get;
		[Token(Token = "0x60001D0")]
		set;
	}

	[Token(Token = "0x17000011")]
	bool useManualTime
	{
		[Token(Token = "0x60001D1")]
		get;
		[Token(Token = "0x60001D2")]
		set;
	}

	[Token(Token = "0x17000012")]
	bool hasInitiliazed
	{
		[Token(Token = "0x60001D3")]
		get;
		[Token(Token = "0x60001D4")]
		set;
	}

	[Token(Token = "0x17000013")]
	bool hasPhysics
	{
		[Token(Token = "0x60001D5")]
		get;
		[Token(Token = "0x60001D6")]
		set;
	}

	[Token(Token = "0x17000014")]
	bool onCompleteOnRepeat
	{
		[Token(Token = "0x60001D7")]
		get;
		[Token(Token = "0x60001D8")]
		set;
	}

	[Token(Token = "0x17000015")]
	bool onCompleteOnStart
	{
		[Token(Token = "0x60001D9")]
		get;
		[Token(Token = "0x60001DA")]
		set;
	}

	[Token(Token = "0x17000016")]
	bool useRecursion
	{
		[Token(Token = "0x60001DB")]
		get;
		[Token(Token = "0x60001DC")]
		set;
	}

	[Token(Token = "0x17000017")]
	float passed
	{
		[Token(Token = "0x60001DD")]
		get;
		[Token(Token = "0x60001DE")]
		set;
	}

	[Token(Token = "0x17000018")]
	float delay
	{
		[Token(Token = "0x60001DF")]
		get;
		[Token(Token = "0x60001E0")]
		set;
	}

	[Token(Token = "0x17000019")]
	float time
	{
		[Token(Token = "0x60001E1")]
		get;
		[Token(Token = "0x60001E2")]
		set;
	}

	[Token(Token = "0x1700001A")]
	float lastVal
	{
		[Token(Token = "0x60001E3")]
		get;
		[Token(Token = "0x60001E4")]
		set;
	}

	[Token(Token = "0x1700001B")]
	int loopCount
	{
		[Token(Token = "0x60001E5")]
		get;
		[Token(Token = "0x60001E6")]
		set;
	}

	[Token(Token = "0x1700001C")]
	uint counter
	{
		[Token(Token = "0x60001E7")]
		get;
		[Token(Token = "0x60001E8")]
		set;
	}

	[Token(Token = "0x1700001D")]
	float direction
	{
		[Token(Token = "0x60001E9")]
		get;
		[Token(Token = "0x60001EA")]
		set;
	}

	[Token(Token = "0x1700001E")]
	float directionLast
	{
		[Token(Token = "0x60001EB")]
		get;
		[Token(Token = "0x60001EC")]
		set;
	}

	[Token(Token = "0x1700001F")]
	float overshoot
	{
		[Token(Token = "0x60001ED")]
		get;
		[Token(Token = "0x60001EE")]
		set;
	}

	[Token(Token = "0x17000020")]
	float period
	{
		[Token(Token = "0x60001EF")]
		get;
		[Token(Token = "0x60001F0")]
		set;
	}

	[Token(Token = "0x17000021")]
	bool destroyOnComplete
	{
		[Token(Token = "0x60001F1")]
		get;
		[Token(Token = "0x60001F2")]
		set;
	}

	[Token(Token = "0x17000022")]
	Transform trans
	{
		[Token(Token = "0x60001F3")]
		get;
		[Token(Token = "0x60001F4")]
		set;
	}

	[Token(Token = "0x17000023")]
	Transform toTrans
	{
		[Token(Token = "0x60001F5")]
		get;
		[Token(Token = "0x60001F6")]
		set;
	}

	[Token(Token = "0x17000024")]
	LTRect ltRect
	{
		[Token(Token = "0x60001F7")]
		get;
		[Token(Token = "0x60001F8")]
		set;
	}

	[Token(Token = "0x17000025")]
	Vector3 from
	{
		[Token(Token = "0x60001F9")]
		get;
		[Token(Token = "0x60001FA")]
		set;
	}

	[Token(Token = "0x17000026")]
	Vector3 to
	{
		[Token(Token = "0x60001FB")]
		get;
		[Token(Token = "0x60001FC")]
		set;
	}

	[Token(Token = "0x17000027")]
	Vector3 diff
	{
		[Token(Token = "0x60001FD")]
		get;
		[Token(Token = "0x60001FE")]
		set;
	}

	[Token(Token = "0x17000028")]
	Vector3 point
	{
		[Token(Token = "0x60001FF")]
		get;
		[Token(Token = "0x6000200")]
		set;
	}

	[Token(Token = "0x17000029")]
	Vector3 axis
	{
		[Token(Token = "0x6000201")]
		get;
		[Token(Token = "0x6000202")]
		set;
	}

	[Token(Token = "0x1700002A")]
	Quaternion origRotation
	{
		[Token(Token = "0x6000203")]
		get;
		[Token(Token = "0x6000204")]
		set;
	}

	[Token(Token = "0x1700002B")]
	LTBezierPath path
	{
		[Token(Token = "0x6000205")]
		get;
		[Token(Token = "0x6000206")]
		set;
	}

	[Token(Token = "0x1700002C")]
	LTSpline spline
	{
		[Token(Token = "0x6000207")]
		get;
		[Token(Token = "0x6000208")]
		set;
	}

	[Token(Token = "0x1700002D")]
	TweenAction type
	{
		[Token(Token = "0x6000209")]
		get;
		[Token(Token = "0x600020A")]
		set;
	}

	[Token(Token = "0x1700002E")]
	LeanTweenType tweenType
	{
		[Token(Token = "0x600020B")]
		get;
		[Token(Token = "0x600020C")]
		set;
	}

	[Token(Token = "0x1700002F")]
	AnimationCurve animationCurve
	{
		[Token(Token = "0x600020D")]
		get;
		[Token(Token = "0x600020E")]
		set;
	}

	[Token(Token = "0x17000030")]
	LeanTweenType loopType
	{
		[Token(Token = "0x600020F")]
		get;
		[Token(Token = "0x6000210")]
		set;
	}

	[Token(Token = "0x17000031")]
	bool hasUpdateCallback
	{
		[Token(Token = "0x6000211")]
		get;
		[Token(Token = "0x6000212")]
		set;
	}

	[Token(Token = "0x17000032")]
	Action<float> onUpdateFloat
	{
		[Token(Token = "0x6000213")]
		get;
		[Token(Token = "0x6000214")]
		set;
	}

	[Token(Token = "0x17000033")]
	Action<float, float> onUpdateFloatRatio
	{
		[Token(Token = "0x6000215")]
		get;
		[Token(Token = "0x6000216")]
		set;
	}

	[Token(Token = "0x17000034")]
	Action<float, object> onUpdateFloatObject
	{
		[Token(Token = "0x6000217")]
		get;
		[Token(Token = "0x6000218")]
		set;
	}

	[Token(Token = "0x17000035")]
	Action<Vector2> onUpdateVector2
	{
		[Token(Token = "0x6000219")]
		get;
		[Token(Token = "0x600021A")]
		set;
	}

	[Token(Token = "0x17000036")]
	Action<Vector3> onUpdateVector3
	{
		[Token(Token = "0x600021B")]
		get;
		[Token(Token = "0x600021C")]
		set;
	}

	[Token(Token = "0x17000037")]
	Action<Vector3, object> onUpdateVector3Object
	{
		[Token(Token = "0x600021D")]
		get;
		[Token(Token = "0x600021E")]
		set;
	}

	[Token(Token = "0x17000038")]
	Action<Color> onUpdateColor
	{
		[Token(Token = "0x600021F")]
		get;
		[Token(Token = "0x6000220")]
		set;
	}

	[Token(Token = "0x17000039")]
	Action onComplete
	{
		[Token(Token = "0x6000221")]
		get;
		[Token(Token = "0x6000222")]
		set;
	}

	[Token(Token = "0x1700003A")]
	Action<object> onCompleteObject
	{
		[Token(Token = "0x6000223")]
		get;
		[Token(Token = "0x6000224")]
		set;
	}

	[Token(Token = "0x1700003B")]
	object onCompleteParam
	{
		[Token(Token = "0x6000225")]
		get;
		[Token(Token = "0x6000226")]
		set;
	}

	[Token(Token = "0x1700003C")]
	object onUpdateParam
	{
		[Token(Token = "0x6000227")]
		get;
		[Token(Token = "0x6000228")]
		set;
	}

	[Token(Token = "0x1700003D")]
	Action onStart
	{
		[Token(Token = "0x6000229")]
		get;
		[Token(Token = "0x600022A")]
		set;
	}

	[Token(Token = "0x1700003E")]
	int uniqueId
	{
		[Token(Token = "0x600022D")]
		get;
	}

	[Token(Token = "0x1700003F")]
	int id
	{
		[Token(Token = "0x600022E")]
		get;
	}

	[Token(Token = "0x600022B")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x58C320", Offset = "0x58C320")]
	LTDescr cancel(GameObject gameObject);

	[Token(Token = "0x600022C")]
	void cleanup();

	[Token(Token = "0x600022F")]
	void init();

	[Token(Token = "0x6000230")]
	LTDescr pause();

	[Token(Token = "0x6000231")]
	void reset();

	[Token(Token = "0x6000232")]
	LTDescr resume();

	[Token(Token = "0x6000233")]
	LTDescr setAudio(object audio);

	[Token(Token = "0x6000234")]
	LTDescr setAxis(Vector3 axis);

	[Token(Token = "0x6000235")]
	LTDescr setDelay(float delay);

	[Token(Token = "0x6000236")]
	LTDescr setDestroyOnComplete(bool doesDestroy);

	[Token(Token = "0x6000237")]
	LTDescr setDiff(Vector3 diff);

	[Token(Token = "0x6000238")]
	LTDescr setDirection(float direction);

	[Token(Token = "0x6000239")]
	LTDescr setEase(LeanTweenType easeType);

	[Token(Token = "0x600023A")]
	LTDescr setEase(AnimationCurve easeCurve);

	[Token(Token = "0x600023B")]
	LTDescr setFrom(float from);

	[Token(Token = "0x600023C")]
	LTDescr setFrom(Vector3 from);

	[Token(Token = "0x600023D")]
	LTDescr setFromColor(Color col);

	[Token(Token = "0x600023E")]
	LTDescr setHasInitialized(bool has);

	[Token(Token = "0x600023F")]
	LTDescr setId(uint id);

	[Token(Token = "0x6000240")]
	LTDescr setIgnoreTimeScale(bool useUnScaledTime);

	[Token(Token = "0x6000241")]
	LTDescr setLoopClamp();

	[Token(Token = "0x6000242")]
	LTDescr setLoopClamp(int loops);

	[Token(Token = "0x6000243")]
	LTDescr setLoopCount(int loopCount);

	[Token(Token = "0x6000244")]
	LTDescr setLoopOnce();

	[Token(Token = "0x6000245")]
	LTDescr setLoopPingPong();

	[Token(Token = "0x6000246")]
	LTDescr setLoopPingPong(int loops);

	[Token(Token = "0x6000247")]
	LTDescr setLoopType(LeanTweenType loopType);

	[Token(Token = "0x6000248")]
	LTDescr setOnComplete(Action onComplete);

	[Token(Token = "0x6000249")]
	LTDescr setOnComplete(Action<object> onComplete);

	[Token(Token = "0x600024A")]
	LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam);

	[Token(Token = "0x600024B")]
	LTDescr setOnCompleteOnRepeat(bool isOn);

	[Token(Token = "0x600024C")]
	LTDescr setOnCompleteOnStart(bool isOn);

	[Token(Token = "0x600024D")]
	LTDescr setOnCompleteParam(object onCompleteParam);

	[Token(Token = "0x600024E")]
	LTDescr setOnStart(Action onStart);

	[Token(Token = "0x600024F")]
	LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam);

	[Token(Token = "0x6000250")]
	LTDescr setOnUpdate(Action<float> onUpdate);

	[Token(Token = "0x6000251")]
	LTDescr setOnUpdate(Action<Color> onUpdate);

	[Token(Token = "0x6000252")]
	LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam);

	[Token(Token = "0x6000253")]
	LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam);

	[Token(Token = "0x6000254")]
	LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam);

	[Token(Token = "0x6000255")]
	LTDescr setOnUpdateColor(Action<Color> onUpdate);

	[Token(Token = "0x6000256")]
	LTDescr setOnUpdateObject(Action<float, object> onUpdate);

	[Token(Token = "0x6000257")]
	LTDescr setOnUpdateParam(object onUpdateParam);

	[Token(Token = "0x6000258")]
	LTDescr setOnUpdateRatio(Action<float, float> onUpdate);

	[Token(Token = "0x6000259")]
	LTDescr setOnUpdateVector2(Action<Vector2> onUpdate);

	[Token(Token = "0x600025A")]
	LTDescr setOnUpdateVector3(Action<Vector3> onUpdate);

	[Token(Token = "0x600025B")]
	LTDescr setOrientToPath(bool doesOrient);

	[Token(Token = "0x600025C")]
	LTDescr setOrientToPath2d(bool doesOrient2d);

	[Token(Token = "0x600025D")]
	LTDescr setOvershoot(float overshoot);

	[Token(Token = "0x600025E")]
	LTDescr setPath(LTBezierPath path);

	[Token(Token = "0x600025F")]
	LTDescr setPeriod(float period);

	[Token(Token = "0x6000260")]
	LTDescr setPoint(Vector3 point);

	[Token(Token = "0x6000261")]
	LTDescr setRect(LTRect rect);

	[Token(Token = "0x6000262")]
	LTDescr setRect(Rect rect);

	[Token(Token = "0x6000263")]
	LTDescr setRepeat(int repeat);

	[Token(Token = "0x6000264")]
	LTDescr setRecursive(bool useRecursion);

	[Token(Token = "0x6000265")]
	LTDescr setRect(RectTransform rect);

	[Token(Token = "0x6000266")]
	LTDescr setSprites(Sprite[] sprites);

	[Token(Token = "0x6000267")]
	LTDescr setFrameRate(float frameRate);

	[Token(Token = "0x6000268")]
	LTDescr setTime(float time);

	[Token(Token = "0x6000269")]
	LTDescr setTo(Transform to);

	[Token(Token = "0x600026A")]
	LTDescr setTo(Vector3 to);

	[Token(Token = "0x600026B")]
	LTDescr setUseEstimatedTime(bool useEstimatedTime);

	[Token(Token = "0x600026C")]
	LTDescr setUseFrames(bool useFrames);

	[Token(Token = "0x600026D")]
	LTDescr setUseManualTime(bool useManualTime);

	[Token(Token = "0x600026E")]
	new string ToString();
}
[Token(Token = "0x200001E")]
public class LTDescrImpl : LTDescr
{
	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BED0", Offset = "0x58BED0")]
	private bool <toggle>k__BackingField;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BEE0", Offset = "0x58BEE0")]
	private bool <useEstimatedTime>k__BackingField;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BEF0", Offset = "0x58BEF0")]
	private bool <useFrames>k__BackingField;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BF00", Offset = "0x58BF00")]
	private bool <useManualTime>k__BackingField;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BF10", Offset = "0x58BF10")]
	private bool <hasInitiliazed>k__BackingField;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BF20", Offset = "0x58BF20")]
	private bool <hasPhysics>k__BackingField;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BF30", Offset = "0x58BF30")]
	private bool <onCompleteOnRepeat>k__BackingField;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BF40", Offset = "0x58BF40")]
	private bool <onCompleteOnStart>k__BackingField;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BF50", Offset = "0x58BF50")]
	private bool <useRecursion>k__BackingField;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BF60", Offset = "0x58BF60")]
	private float <passed>k__BackingField;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BF70", Offset = "0x58BF70")]
	private float <delay>k__BackingField;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BF80", Offset = "0x58BF80")]
	private float <time>k__BackingField;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BF90", Offset = "0x58BF90")]
	private float <lastVal>k__BackingField;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private uint _id;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BFA0", Offset = "0x58BFA0")]
	private int <loopCount>k__BackingField;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BFB0", Offset = "0x58BFB0")]
	private uint <counter>k__BackingField;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BFC0", Offset = "0x58BFC0")]
	private float <direction>k__BackingField;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BFD0", Offset = "0x58BFD0")]
	private float <directionLast>k__BackingField;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BFE0", Offset = "0x58BFE0")]
	private float <overshoot>k__BackingField;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BFF0", Offset = "0x58BFF0")]
	private float <period>k__BackingField;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C000", Offset = "0x58C000")]
	private bool <destroyOnComplete>k__BackingField;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C010", Offset = "0x58C010")]
	private Transform <trans>k__BackingField;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C020", Offset = "0x58C020")]
	private Transform <toTrans>k__BackingField;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C030", Offset = "0x58C030")]
	private LTRect <ltRect>k__BackingField;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	internal Vector3 fromInternal;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	internal Vector3 toInternal;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	internal Vector3 diffInternal;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C040", Offset = "0x58C040")]
	private Vector3 <point>k__BackingField;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C050", Offset = "0x58C050")]
	private Vector3 <axis>k__BackingField;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C060", Offset = "0x58C060")]
	private Quaternion <origRotation>k__BackingField;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C070", Offset = "0x58C070")]
	private LTBezierPath <path>k__BackingField;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C080", Offset = "0x58C080")]
	private LTSpline <spline>k__BackingField;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C090", Offset = "0x58C090")]
	private TweenAction <type>k__BackingField;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C0A0", Offset = "0x58C0A0")]
	private LeanTweenType <tweenType>k__BackingField;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C0B0", Offset = "0x58C0B0")]
	private AnimationCurve <animationCurve>k__BackingField;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C0C0", Offset = "0x58C0C0")]
	private LeanTweenType <loopType>k__BackingField;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C0D0", Offset = "0x58C0D0")]
	private bool <hasUpdateCallback>k__BackingField;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C0E0", Offset = "0x58C0E0")]
	private Action<float> <onUpdateFloat>k__BackingField;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C0F0", Offset = "0x58C0F0")]
	private Action<float, float> <onUpdateFloatRatio>k__BackingField;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C100", Offset = "0x58C100")]
	private Action<float, object> <onUpdateFloatObject>k__BackingField;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C110", Offset = "0x58C110")]
	private Action<Vector2> <onUpdateVector2>k__BackingField;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C120", Offset = "0x58C120")]
	private Action<Vector3> <onUpdateVector3>k__BackingField;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C130", Offset = "0x58C130")]
	private Action<Vector3, object> <onUpdateVector3Object>k__BackingField;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C140", Offset = "0x58C140")]
	private Action<Color> <onUpdateColor>k__BackingField;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C150", Offset = "0x58C150")]
	private Action <onComplete>k__BackingField;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C160", Offset = "0x58C160")]
	private Action<object> <onCompleteObject>k__BackingField;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C170", Offset = "0x58C170")]
	private object <onCompleteParam>k__BackingField;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C180", Offset = "0x58C180")]
	private object <onUpdateParam>k__BackingField;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C190", Offset = "0x58C190")]
	private Action <onStart>k__BackingField;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public RectTransform rectTransform;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Text uiText;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public Image uiImage;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Sprite[] sprites;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static uint global_counter;

	[Token(Token = "0x17000040")]
	public bool toggle
	{
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x8D6164", Offset = "0x8D6164", VA = "0x8D6164", Slot = "4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C358", Offset = "0x58C358")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x8D616C", Offset = "0x8D616C", VA = "0x8D616C", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C368", Offset = "0x58C368")]
		set
		{
		}
	}

	[Token(Token = "0x17000041")]
	public bool useEstimatedTime
	{
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x8D6178", Offset = "0x8D6178", VA = "0x8D6178", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C378", Offset = "0x58C378")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x8D6180", Offset = "0x8D6180", VA = "0x8D6180", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C388", Offset = "0x58C388")]
		set
		{
		}
	}

	[Token(Token = "0x17000042")]
	public bool useFrames
	{
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x8D618C", Offset = "0x8D618C", VA = "0x8D618C", Slot = "8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C398", Offset = "0x58C398")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x8D6194", Offset = "0x8D6194", VA = "0x8D6194", Slot = "9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C3A8", Offset = "0x58C3A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public bool useManualTime
	{
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x8D61A0", Offset = "0x8D61A0", VA = "0x8D61A0", Slot = "10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C3B8", Offset = "0x58C3B8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x8D61A8", Offset = "0x8D61A8", VA = "0x8D61A8", Slot = "11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C3C8", Offset = "0x58C3C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000044")]
	public bool hasInitiliazed
	{
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x8D61B4", Offset = "0x8D61B4", VA = "0x8D61B4", Slot = "12")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C3D8", Offset = "0x58C3D8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x8D61BC", Offset = "0x8D61BC", VA = "0x8D61BC", Slot = "13")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C3E8", Offset = "0x58C3E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public bool hasPhysics
	{
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x8D61C8", Offset = "0x8D61C8", VA = "0x8D61C8", Slot = "14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C3F8", Offset = "0x58C3F8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x8D61D0", Offset = "0x8D61D0", VA = "0x8D61D0", Slot = "15")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C408", Offset = "0x58C408")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public bool onCompleteOnRepeat
	{
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x8D61DC", Offset = "0x8D61DC", VA = "0x8D61DC", Slot = "16")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C418", Offset = "0x58C418")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x8D61E4", Offset = "0x8D61E4", VA = "0x8D61E4", Slot = "17")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C428", Offset = "0x58C428")]
		set
		{
		}
	}

	[Token(Token = "0x17000047")]
	public bool onCompleteOnStart
	{
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x8D61F0", Offset = "0x8D61F0", VA = "0x8D61F0", Slot = "18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C438", Offset = "0x58C438")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x8D61F8", Offset = "0x8D61F8", VA = "0x8D61F8", Slot = "19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C448", Offset = "0x58C448")]
		set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public bool useRecursion
	{
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x8D6204", Offset = "0x8D6204", VA = "0x8D6204", Slot = "20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C458", Offset = "0x58C458")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x8D620C", Offset = "0x8D620C", VA = "0x8D620C", Slot = "21")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C468", Offset = "0x58C468")]
		set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public float passed
	{
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x8D6218", Offset = "0x8D6218", VA = "0x8D6218", Slot = "22")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C478", Offset = "0x58C478")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x8D6220", Offset = "0x8D6220", VA = "0x8D6220", Slot = "23")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C488", Offset = "0x58C488")]
		set
		{
		}
	}

	[Token(Token = "0x1700004A")]
	public float delay
	{
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x8D6228", Offset = "0x8D6228", VA = "0x8D6228", Slot = "24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C498", Offset = "0x58C498")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x8D6230", Offset = "0x8D6230", VA = "0x8D6230", Slot = "25")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C4A8", Offset = "0x58C4A8")]
		set
		{
		}
	}

	[Token(Token = "0x1700004B")]
	public float time
	{
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x8D6238", Offset = "0x8D6238", VA = "0x8D6238", Slot = "26")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C4B8", Offset = "0x58C4B8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x8D6240", Offset = "0x8D6240", VA = "0x8D6240", Slot = "27")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C4C8", Offset = "0x58C4C8")]
		set
		{
		}
	}

	[Token(Token = "0x1700004C")]
	public float lastVal
	{
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x8D6248", Offset = "0x8D6248", VA = "0x8D6248", Slot = "28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C4D8", Offset = "0x58C4D8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x8D6250", Offset = "0x8D6250", VA = "0x8D6250", Slot = "29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C4E8", Offset = "0x58C4E8")]
		set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	public int loopCount
	{
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x8D6258", Offset = "0x8D6258", VA = "0x8D6258", Slot = "30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C4F8", Offset = "0x58C4F8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x8D6260", Offset = "0x8D6260", VA = "0x8D6260", Slot = "31")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C508", Offset = "0x58C508")]
		set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	public uint counter
	{
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x8D6268", Offset = "0x8D6268", VA = "0x8D6268", Slot = "32")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C518", Offset = "0x58C518")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x8D6270", Offset = "0x8D6270", VA = "0x8D6270", Slot = "33")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C528", Offset = "0x58C528")]
		set
		{
		}
	}

	[Token(Token = "0x1700004F")]
	public float direction
	{
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x8D6278", Offset = "0x8D6278", VA = "0x8D6278", Slot = "34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C538", Offset = "0x58C538")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x8D6280", Offset = "0x8D6280", VA = "0x8D6280", Slot = "35")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C548", Offset = "0x58C548")]
		set
		{
		}
	}

	[Token(Token = "0x17000050")]
	public float directionLast
	{
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x8D6288", Offset = "0x8D6288", VA = "0x8D6288", Slot = "36")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C558", Offset = "0x58C558")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x8D6290", Offset = "0x8D6290", VA = "0x8D6290", Slot = "37")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C568", Offset = "0x58C568")]
		set
		{
		}
	}

	[Token(Token = "0x17000051")]
	public float overshoot
	{
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x8D6298", Offset = "0x8D6298", VA = "0x8D6298", Slot = "38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C578", Offset = "0x58C578")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x8D62A0", Offset = "0x8D62A0", VA = "0x8D62A0", Slot = "39")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C588", Offset = "0x58C588")]
		set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public float period
	{
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x8D62A8", Offset = "0x8D62A8", VA = "0x8D62A8", Slot = "40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C598", Offset = "0x58C598")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x8D62B0", Offset = "0x8D62B0", VA = "0x8D62B0", Slot = "41")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C5A8", Offset = "0x58C5A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000053")]
	public bool destroyOnComplete
	{
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x8D62B8", Offset = "0x8D62B8", VA = "0x8D62B8", Slot = "42")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C5B8", Offset = "0x58C5B8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x8D62C0", Offset = "0x8D62C0", VA = "0x8D62C0", Slot = "43")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C5C8", Offset = "0x58C5C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000054")]
	public Transform trans
	{
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x8D62CC", Offset = "0x8D62CC", VA = "0x8D62CC", Slot = "44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C5D8", Offset = "0x58C5D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x8D62D4", Offset = "0x8D62D4", VA = "0x8D62D4", Slot = "45")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C5E8", Offset = "0x58C5E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	public Transform toTrans
	{
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x8D62DC", Offset = "0x8D62DC", VA = "0x8D62DC", Slot = "46")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C5F8", Offset = "0x58C5F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x8D62E4", Offset = "0x8D62E4", VA = "0x8D62E4", Slot = "47")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C608", Offset = "0x58C608")]
		set
		{
		}
	}

	[Token(Token = "0x17000056")]
	public LTRect ltRect
	{
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x8D62EC", Offset = "0x8D62EC", VA = "0x8D62EC", Slot = "48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C618", Offset = "0x58C618")]
		get
		{
			return null;
		}
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x8D62F4", Offset = "0x8D62F4", VA = "0x8D62F4", Slot = "49")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C628", Offset = "0x58C628")]
		set
		{
		}
	}

	[Token(Token = "0x17000057")]
	public Vector3 from
	{
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x8D62FC", Offset = "0x8D62FC", VA = "0x8D62FC", Slot = "50")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x8D6308", Offset = "0x8D6308", VA = "0x8D6308", Slot = "51")]
		set
		{
		}
	}

	[Token(Token = "0x17000058")]
	public Vector3 to
	{
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x8D6314", Offset = "0x8D6314", VA = "0x8D6314", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x8D6320", Offset = "0x8D6320", VA = "0x8D6320", Slot = "53")]
		set
		{
		}
	}

	[Token(Token = "0x17000059")]
	public Vector3 diff
	{
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x8D632C", Offset = "0x8D632C", VA = "0x8D632C", Slot = "54")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x8D6338", Offset = "0x8D6338", VA = "0x8D6338", Slot = "55")]
		set
		{
		}
	}

	[Token(Token = "0x1700005A")]
	public Vector3 point
	{
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x8D6344", Offset = "0x8D6344", VA = "0x8D6344", Slot = "56")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C638", Offset = "0x58C638")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x8D6350", Offset = "0x8D6350", VA = "0x8D6350", Slot = "57")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C648", Offset = "0x58C648")]
		set
		{
		}
	}

	[Token(Token = "0x1700005B")]
	public Vector3 axis
	{
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x8D635C", Offset = "0x8D635C", VA = "0x8D635C", Slot = "58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C658", Offset = "0x58C658")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x8D6368", Offset = "0x8D6368", VA = "0x8D6368", Slot = "59")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C668", Offset = "0x58C668")]
		set
		{
		}
	}

	[Token(Token = "0x1700005C")]
	public Quaternion origRotation
	{
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x8D6374", Offset = "0x8D6374", VA = "0x8D6374", Slot = "60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C678", Offset = "0x58C678")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x8D6380", Offset = "0x8D6380", VA = "0x8D6380", Slot = "61")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C688", Offset = "0x58C688")]
		set
		{
		}
	}

	[Token(Token = "0x1700005D")]
	public LTBezierPath path
	{
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x8D638C", Offset = "0x8D638C", VA = "0x8D638C", Slot = "62")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C698", Offset = "0x58C698")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x8D6394", Offset = "0x8D6394", VA = "0x8D6394", Slot = "63")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C6A8", Offset = "0x58C6A8")]
		set
		{
		}
	}

	[Token(Token = "0x1700005E")]
	public LTSpline spline
	{
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x8D639C", Offset = "0x8D639C", VA = "0x8D639C", Slot = "64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C6B8", Offset = "0x58C6B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x8D63A4", Offset = "0x8D63A4", VA = "0x8D63A4", Slot = "65")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C6C8", Offset = "0x58C6C8")]
		set
		{
		}
	}

	[Token(Token = "0x1700005F")]
	public TweenAction type
	{
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x8D63AC", Offset = "0x8D63AC", VA = "0x8D63AC", Slot = "66")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C6D8", Offset = "0x58C6D8")]
		get
		{
			return default(TweenAction);
		}
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x8D63B4", Offset = "0x8D63B4", VA = "0x8D63B4", Slot = "67")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C6E8", Offset = "0x58C6E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000060")]
	public LeanTweenType tweenType
	{
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x8D63BC", Offset = "0x8D63BC", VA = "0x8D63BC", Slot = "68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C6F8", Offset = "0x58C6F8")]
		get
		{
			return default(LeanTweenType);
		}
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x8D63C4", Offset = "0x8D63C4", VA = "0x8D63C4", Slot = "69")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C708", Offset = "0x58C708")]
		set
		{
		}
	}

	[Token(Token = "0x17000061")]
	public AnimationCurve animationCurve
	{
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x8D63CC", Offset = "0x8D63CC", VA = "0x8D63CC", Slot = "70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C718", Offset = "0x58C718")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x8D63D4", Offset = "0x8D63D4", VA = "0x8D63D4", Slot = "71")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C728", Offset = "0x58C728")]
		set
		{
		}
	}

	[Token(Token = "0x17000062")]
	public LeanTweenType loopType
	{
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x8D63DC", Offset = "0x8D63DC", VA = "0x8D63DC", Slot = "72")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C738", Offset = "0x58C738")]
		get
		{
			return default(LeanTweenType);
		}
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x8D63E4", Offset = "0x8D63E4", VA = "0x8D63E4", Slot = "73")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C748", Offset = "0x58C748")]
		set
		{
		}
	}

	[Token(Token = "0x17000063")]
	public bool hasUpdateCallback
	{
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x8D63EC", Offset = "0x8D63EC", VA = "0x8D63EC", Slot = "74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C758", Offset = "0x58C758")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x8D63F4", Offset = "0x8D63F4", VA = "0x8D63F4", Slot = "75")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C768", Offset = "0x58C768")]
		set
		{
		}
	}

	[Token(Token = "0x17000064")]
	public Action<float> onUpdateFloat
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x8D6400", Offset = "0x8D6400", VA = "0x8D6400", Slot = "76")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C778", Offset = "0x58C778")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x8D6408", Offset = "0x8D6408", VA = "0x8D6408", Slot = "77")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C788", Offset = "0x58C788")]
		set
		{
		}
	}

	[Token(Token = "0x17000065")]
	public Action<float, float> onUpdateFloatRatio
	{
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x8D6410", Offset = "0x8D6410", VA = "0x8D6410", Slot = "78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C798", Offset = "0x58C798")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x8D6418", Offset = "0x8D6418", VA = "0x8D6418", Slot = "79")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C7A8", Offset = "0x58C7A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000066")]
	public Action<float, object> onUpdateFloatObject
	{
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x8D6420", Offset = "0x8D6420", VA = "0x8D6420", Slot = "80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C7B8", Offset = "0x58C7B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x8D6428", Offset = "0x8D6428", VA = "0x8D6428", Slot = "81")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C7C8", Offset = "0x58C7C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000067")]
	public Action<Vector2> onUpdateVector2
	{
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x8D6430", Offset = "0x8D6430", VA = "0x8D6430", Slot = "82")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C7D8", Offset = "0x58C7D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x8D6438", Offset = "0x8D6438", VA = "0x8D6438", Slot = "83")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C7E8", Offset = "0x58C7E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000068")]
	public Action<Vector3> onUpdateVector3
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x8D6440", Offset = "0x8D6440", VA = "0x8D6440", Slot = "84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C7F8", Offset = "0x58C7F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x8D6448", Offset = "0x8D6448", VA = "0x8D6448", Slot = "85")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C808", Offset = "0x58C808")]
		set
		{
		}
	}

	[Token(Token = "0x17000069")]
	public Action<Vector3, object> onUpdateVector3Object
	{
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x8D6450", Offset = "0x8D6450", VA = "0x8D6450", Slot = "86")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C818", Offset = "0x58C818")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x8D6458", Offset = "0x8D6458", VA = "0x8D6458", Slot = "87")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C828", Offset = "0x58C828")]
		set
		{
		}
	}

	[Token(Token = "0x1700006A")]
	public Action<Color> onUpdateColor
	{
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x8D6460", Offset = "0x8D6460", VA = "0x8D6460", Slot = "88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C838", Offset = "0x58C838")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x8D6468", Offset = "0x8D6468", VA = "0x8D6468", Slot = "89")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C848", Offset = "0x58C848")]
		set
		{
		}
	}

	[Token(Token = "0x1700006B")]
	public Action onComplete
	{
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x8D6470", Offset = "0x8D6470", VA = "0x8D6470", Slot = "90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C858", Offset = "0x58C858")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x8D6478", Offset = "0x8D6478", VA = "0x8D6478", Slot = "91")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C868", Offset = "0x58C868")]
		set
		{
		}
	}

	[Token(Token = "0x1700006C")]
	public Action<object> onCompleteObject
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x8D6480", Offset = "0x8D6480", VA = "0x8D6480", Slot = "92")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C878", Offset = "0x58C878")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x8D6488", Offset = "0x8D6488", VA = "0x8D6488", Slot = "93")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C888", Offset = "0x58C888")]
		set
		{
		}
	}

	[Token(Token = "0x1700006D")]
	public object onCompleteParam
	{
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x8D6490", Offset = "0x8D6490", VA = "0x8D6490", Slot = "94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C898", Offset = "0x58C898")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x8D6498", Offset = "0x8D6498", VA = "0x8D6498", Slot = "95")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C8A8", Offset = "0x58C8A8")]
		set
		{
		}
	}

	[Token(Token = "0x1700006E")]
	public object onUpdateParam
	{
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x8D64A0", Offset = "0x8D64A0", VA = "0x8D64A0", Slot = "96")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C8B8", Offset = "0x58C8B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x8D64A8", Offset = "0x8D64A8", VA = "0x8D64A8", Slot = "97")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C8C8", Offset = "0x58C8C8")]
		set
		{
		}
	}

	[Token(Token = "0x1700006F")]
	public Action onStart
	{
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x8D64B0", Offset = "0x8D64B0", VA = "0x8D64B0", Slot = "98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C8D8", Offset = "0x58C8D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x8D64B8", Offset = "0x8D64B8", VA = "0x8D64B8", Slot = "99")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C8E8", Offset = "0x58C8E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000070")]
	public int uniqueId
	{
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x8D6CA8", Offset = "0x8D6CA8", VA = "0x8D6CA8", Slot = "102")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000071")]
	public int id
	{
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x8D6BB8", Offset = "0x8D6BB8", VA = "0x8D6BB8", Slot = "103")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x8D64C0", Offset = "0x8D64C0", VA = "0x8D64C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x8D6BC8", Offset = "0x8D6BC8", VA = "0x8D6BC8")]
	public LTDescrImpl()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x8D6BD0", Offset = "0x8D6BD0", VA = "0x8D6BD0", Slot = "100")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x58C8F8", Offset = "0x58C8F8")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x8D6D98", Offset = "0x8D6D98", VA = "0x8D6D98", Slot = "106")]
	public void reset()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x8D6EE0", Offset = "0x8D6EE0", VA = "0x8D6EE0", Slot = "101")]
	public void cleanup()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x8D6F18", Offset = "0x8D6F18", VA = "0x8D6F18", Slot = "104")]
	public void init()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x8D8738", Offset = "0x8D8738", VA = "0x8D8738", Slot = "118")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x8D880C", Offset = "0x8D880C", VA = "0x8D880C", Slot = "105")]
	public LTDescr pause()
	{
		return null;
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x8D8824", Offset = "0x8D8824", VA = "0x8D8824", Slot = "107")]
	public LTDescr resume()
	{
		return null;
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x8D8830", Offset = "0x8D8830", VA = "0x8D8830", Slot = "109")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x8D883C", Offset = "0x8D883C", VA = "0x8D883C", Slot = "110")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x8D8844", Offset = "0x8D8844", VA = "0x8D8844", Slot = "114")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x8D884C", Offset = "0x8D884C", VA = "0x8D884C", Slot = "150")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x8D8854", Offset = "0x8D8854", VA = "0x8D8854", Slot = "152")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x8D885C", Offset = "0x8D885C", VA = "0x8D885C", Slot = "115")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x8D8864", Offset = "0x8D8864", VA = "0x8D8864", Slot = "163")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x8D892C", Offset = "0x8D892C", VA = "0x8D892C", Slot = "162")]
	public LTDescr setTo(Transform to)
	{
		return null;
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x8D8934", Offset = "0x8D8934", VA = "0x8D8934", Slot = "117")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x8D8A30", Offset = "0x8D8A30", VA = "0x8D8A30", Slot = "116")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x8D8A80", Offset = "0x8D8A80", VA = "0x8D8A80", Slot = "112")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x8D8A8C", Offset = "0x8D8A8C", VA = "0x8D8A8C", Slot = "119")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x8D8A98", Offset = "0x8D8A98", VA = "0x8D8A98", Slot = "120")]
	public LTDescr setId(uint id)
	{
		return null;
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x8D8B1C", Offset = "0x8D8B1C", VA = "0x8D8B1C", Slot = "161")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x8D8B38", Offset = "0x8D8B38", VA = "0x8D8B38", Slot = "156")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x8D8B8C", Offset = "0x8D8B8C", VA = "0x8D8B8C", Slot = "128")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x8D8B94", Offset = "0x8D8B94", VA = "0x8D8B94", Slot = "164")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x8D8BA0", Offset = "0x8D8BA0", VA = "0x8D8BA0", Slot = "121")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x8D8BAC", Offset = "0x8D8BAC", VA = "0x8D8BAC", Slot = "165")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x8D8BB8", Offset = "0x8D8BB8", VA = "0x8D8BB8", Slot = "166")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x8D8BC4", Offset = "0x8D8BC4", VA = "0x8D8BC4", Slot = "124")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x8D8BCC", Offset = "0x8D8BCC", VA = "0x8D8BCC", Slot = "125")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x8D8BD8", Offset = "0x8D8BD8", VA = "0x8D8BD8", Slot = "122")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x8D8BF8", Offset = "0x8D8BF8", VA = "0x8D8BF8", Slot = "123")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x8D8C00", Offset = "0x8D8C00", VA = "0x8D8C00", Slot = "126")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x8D8C20", Offset = "0x8D8C20", VA = "0x8D8C20", Slot = "127")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x8D8C4C", Offset = "0x8D8C4C", VA = "0x8D8C4C", Slot = "129")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x8D8C54", Offset = "0x8D8C54", VA = "0x8D8C54", Slot = "130")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x8D8C5C", Offset = "0x8D8C5C", VA = "0x8D8C5C", Slot = "131")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x8D8C6C", Offset = "0x8D8C6C", VA = "0x8D8C6C", Slot = "134")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x8D8C74", Offset = "0x8D8C74", VA = "0x8D8C74", Slot = "137")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x8D8C84", Offset = "0x8D8C84", VA = "0x8D8C84", Slot = "145")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x8D8C94", Offset = "0x8D8C94", VA = "0x8D8C94", Slot = "143")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x8D8CA4", Offset = "0x8D8CA4", VA = "0x8D8CA4", Slot = "146")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x8D8CB4", Offset = "0x8D8CB4", VA = "0x8D8CB4", Slot = "147")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x8D8CC4", Offset = "0x8D8CC4", VA = "0x8D8CC4", Slot = "142")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x8D8CD4", Offset = "0x8D8CD4", VA = "0x8D8CD4", Slot = "138")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x8D8CE4", Offset = "0x8D8CE4", VA = "0x8D8CE4", Slot = "136")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x8D8CFC", Offset = "0x8D8CFC", VA = "0x8D8CFC", Slot = "140")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x8D8D14", Offset = "0x8D8D14", VA = "0x8D8D14", Slot = "139")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x8D8D2C", Offset = "0x8D8D2C", VA = "0x8D8D2C", Slot = "141")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x8D8D44", Offset = "0x8D8D44", VA = "0x8D8D44", Slot = "144")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x8D8D4C", Offset = "0x8D8D4C", VA = "0x8D8D4C", Slot = "148")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x8D8DF8", Offset = "0x8D8DF8", VA = "0x8D8DF8", Slot = "149")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x8D8E5C", Offset = "0x8D8E5C", VA = "0x8D8E5C", Slot = "154")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x8D8E64", Offset = "0x8D8E64", VA = "0x8D8E64", Slot = "155")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x8D8FA0", Offset = "0x8D8FA0", VA = "0x8D8FA0", Slot = "151")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x8D8FA8", Offset = "0x8D8FA8", VA = "0x8D8FA8", Slot = "153")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x8D8FB4", Offset = "0x8D8FB4", VA = "0x8D8FB4", Slot = "111")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x8D8FC0", Offset = "0x8D8FC0", VA = "0x8D8FC0", Slot = "108")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x8D8B80", Offset = "0x8D8B80", VA = "0x8D8B80", Slot = "132")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x8D8FC8", Offset = "0x8D8FC8", VA = "0x8D8FC8", Slot = "133")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x8D8FD4", Offset = "0x8D8FD4", VA = "0x8D8FD4", Slot = "158")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x8D8FDC", Offset = "0x8D8FDC", VA = "0x8D8FDC", Slot = "159")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x8D8FE4", Offset = "0x8D8FE4", VA = "0x8D8FE4", Slot = "160")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x8D900C", Offset = "0x8D900C", VA = "0x8D900C", Slot = "135")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x8D9014", Offset = "0x8D9014", VA = "0x8D9014", Slot = "113")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x8D95EC", Offset = "0x8D95EC", VA = "0x8D95EC", Slot = "157")]
	public LTDescr setRecursive(bool useRecursion)
	{
		return null;
	}
}
[Token(Token = "0x200001F")]
public class LeanAudioStream
{
	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int position;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip audioClip;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float[] audioArr;

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x8DDC80", Offset = "0x8DDC80", VA = "0x8DDC80")]
	public LeanAudioStream(float[] audioArr)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x8DE474", Offset = "0x8DE474", VA = "0x8DE474")]
	public void OnAudioRead(float[] data)
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x8DE4F8", Offset = "0x8DE4F8", VA = "0x8DE4F8")]
	public void OnAudioSetPosition(int newPosition)
	{
	}
}
[Token(Token = "0x2000020")]
public class LeanAudio
{
	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float MIN_FREQEUNCY_PERIOD;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int PROCESSING_ITERATIONS_MAX;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float[] generatedWaveDistances;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int generatedWaveDistancesCount;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static float[] longList;

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x8DD004", Offset = "0x8DD004", VA = "0x8DD004")]
	public static LeanAudioOptions options()
	{
		return null;
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x8DD128", Offset = "0x8DD128", VA = "0x8DD128")]
	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x8DDBC0", Offset = "0x8DDBC0", VA = "0x8DDBC0")]
	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x8DD1FC", Offset = "0x8DD1FC", VA = "0x8DD1FC")]
	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		return default(int);
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x8DD674", Offset = "0x8DD674", VA = "0x8DD674")]
	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x8DDCAC", Offset = "0x8DDCAC", VA = "0x8DDCAC")]
	private static void OnAudioSetPosition(int newPosition)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x8DDCB0", Offset = "0x8DDCB0", VA = "0x8DDCB0")]
	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		return null;
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x8DDE14", Offset = "0x8DDE14", VA = "0x8DDE14")]
	public static AudioSource play(AudioClip audio, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x8DE014", Offset = "0x8DE014", VA = "0x8DE014")]
	public static AudioSource play(AudioClip audio)
	{
		return null;
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x8DE0C8", Offset = "0x8DE0C8", VA = "0x8DE0C8")]
	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x8DE154", Offset = "0x8DE154", VA = "0x8DE154")]
	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x8DDEEC", Offset = "0x8DDEEC", VA = "0x8DDEEC")]
	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x8DE214", Offset = "0x8DE214", VA = "0x8DE214")]
	public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x8DE3A4", Offset = "0x8DE3A4", VA = "0x8DE3A4")]
	public LeanAudio()
	{
	}
}
[Token(Token = "0x2000021")]
public class LeanAudioOptions
{
	[Token(Token = "0x200007C")]
	public enum LeanAudioWaveStyle
	{
		[Token(Token = "0x40004C4")]
		Sine,
		[Token(Token = "0x40004C5")]
		Square,
		[Token(Token = "0x40004C6")]
		Sawtooth,
		[Token(Token = "0x40004C7")]
		Noise
	}

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LeanAudioWaveStyle waveStyle;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] vibrato;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] modulation;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int frequencyRate;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float waveNoiseScale;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float waveNoiseInfluence;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool useSetData;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LeanAudioStream stream;

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x8DD104", Offset = "0x8DD104", VA = "0x8DD104")]
	public LeanAudioOptions()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x8DE420", Offset = "0x8DE420", VA = "0x8DE420")]
	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		return null;
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x8DE428", Offset = "0x8DE428", VA = "0x8DE428")]
	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		return null;
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x8DE430", Offset = "0x8DE430", VA = "0x8DE430")]
	public LeanAudioOptions setWaveSine()
	{
		return null;
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x8DE438", Offset = "0x8DE438", VA = "0x8DE438")]
	public LeanAudioOptions setWaveSquare()
	{
		return null;
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x8DE444", Offset = "0x8DE444", VA = "0x8DE444")]
	public LeanAudioOptions setWaveSawtooth()
	{
		return null;
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x8DE450", Offset = "0x8DE450", VA = "0x8DE450")]
	public LeanAudioOptions setWaveNoise()
	{
		return null;
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x8DE45C", Offset = "0x8DE45C", VA = "0x8DE45C")]
	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		return null;
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x8DE464", Offset = "0x8DE464", VA = "0x8DE464")]
	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		return null;
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x8DE46C", Offset = "0x8DE46C", VA = "0x8DE46C")]
	public LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		return null;
	}
}
[Token(Token = "0x2000022")]
public class LeanTester : MonoBehaviour
{
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BCD0", Offset = "0x58BCD0")]
	private sealed class <timeoutCheck>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeanTester <>4__this;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <pauseEndTime>5__2;

		[Token(Token = "0x17000140")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x8DF4C4", Offset = "0x8DF4C4", VA = "0x8DF4C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000141")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x8DF52C", Offset = "0x8DF52C", VA = "0x8DF52C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x8DF324", Offset = "0x8DF324", VA = "0x8DF324")]
		[DebuggerHidden]
		public <timeoutCheck>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x8DF360", Offset = "0x8DF360", VA = "0x8DF360", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x8DF364", Offset = "0x8DF364", VA = "0x8DF364", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x8DF4CC", Offset = "0x8DF4CC", VA = "0x8DF4CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeout;

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x8DF288", Offset = "0x8DF288", VA = "0x8DF288")]
	public void Start()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x8DF2B4", Offset = "0x8DF2B4", VA = "0x8DF2B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58C930", Offset = "0x58C930")]
	private IEnumerator timeoutCheck()
	{
		return null;
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x8DF350", Offset = "0x8DF350", VA = "0x8DF350")]
	public LeanTester()
	{
	}
}
[Token(Token = "0x2000023")]
public class LeanTest
{
	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int expected;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int tests;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int passes;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static float timeout;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool timeoutStarted;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public static bool testsFinished;

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x8DE500", Offset = "0x8DE500", VA = "0x8DE500")]
	public static void debug(string name, bool didPass, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x8DE57C", Offset = "0x8DE57C", VA = "0x8DE57C")]
	public static void expect(bool didPass, string definition, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x8DF114", Offset = "0x8DF114", VA = "0x8DF114")]
	public static string padRight(int len)
	{
		return null;
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x8DEB10", Offset = "0x8DEB10", VA = "0x8DEB10")]
	public static float printOutLength(string str)
	{
		return default(float);
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x8DF184", Offset = "0x8DF184", VA = "0x8DF184")]
	public static string formatBC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x8DEC40", Offset = "0x8DEC40", VA = "0x8DEC40")]
	public static string formatB(string str)
	{
		return null;
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x8DECA0", Offset = "0x8DECA0", VA = "0x8DECA0")]
	public static string formatC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x8DEE14", Offset = "0x8DEE14", VA = "0x8DEE14")]
	public static void overview()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x8DF1FC", Offset = "0x8DF1FC", VA = "0x8DF1FC")]
	public LeanTest()
	{
	}
}
[Token(Token = "0x2000024")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x58B788", Offset = "0x58B788")]
public class LeanTweenPath : MonoBehaviour
{
	[Token(Token = "0x200007E")]
	public enum LeanTweenPathType
	{
		[Token(Token = "0x40004CD")]
		bezier,
		[Token(Token = "0x40004CE")]
		spline
	}

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int count;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform[] pts;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3[] path;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LeanTweenPathType pathType;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float controlSize;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool showArrows;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool nodesMaximized;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool creatorMaximized;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	public bool importMaximized;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int i;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int k;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int lastCount;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Color curveColor;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Color lineColor;

	[Token(Token = "0x17000072")]
	public Vector3[] vec3
	{
		[Token(Token = "0x6000346")]
		[Address(RVA = "0xDF6284", Offset = "0xDF6284", VA = "0xDF6284")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000347")]
		[Address(RVA = "0xDF63E0", Offset = "0xDF63E0", VA = "0xDF63E0")]
		set
		{
		}
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xDF3F2C", Offset = "0xDF3F2C", VA = "0xDF3F2C")]
	private void init()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xDF4F00", Offset = "0xDF4F00", VA = "0xDF4F00")]
	private void reset()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xDF4DCC", Offset = "0xDF4DCC", VA = "0xDF4DCC")]
	public Transform createChild(int i, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xDF5324", Offset = "0xDF5324", VA = "0xDF5324")]
	private void initNode(Transform trans, int i)
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xDF57B4", Offset = "0xDF57B4", VA = "0xDF57B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xDF58BC", Offset = "0xDF58BC", VA = "0xDF58BC")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xDF602C", Offset = "0xDF602C", VA = "0xDF602C")]
	public Vector3[] splineVector()
	{
		return null;
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xDF6194", Offset = "0xDF6194", VA = "0xDF6194")]
	public Vector3[] splineVectorNoEndCaps()
	{
		return null;
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xDF63E4", Offset = "0xDF63E4", VA = "0xDF63E4")]
	private void resetPath()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xDF64D0", Offset = "0xDF64D0", VA = "0xDF64D0")]
	public void addNode()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0xDF6500", Offset = "0xDF6500", VA = "0xDF6500")]
	public void addNodeAfter(int after)
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xDF6C50", Offset = "0xDF6C50", VA = "0xDF6C50")]
	public void deleteNode(int i)
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xDF6D24", Offset = "0xDF6D24", VA = "0xDF6D24")]
	public LeanTweenPath()
	{
	}
}
[Token(Token = "0x2000025")]
[ExecuteInEditMode]
public class LeanTweenPathControl : MonoBehaviour
{
	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 lastPos;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3[] lastPosControl;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LeanTweenPathControl[] controlRef;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int i;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool isControl;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool isBezier;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Material matPoints;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Material matControls;

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xDF6D44", Offset = "0xDF6D44", VA = "0xDF6D44")]
	public void createMaterials()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0xDF6EE4", Offset = "0xDF6EE4", VA = "0xDF6EE4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xDF6EE8", Offset = "0xDF6EE8", VA = "0xDF6EE8")]
	private void OnApplicationFocus()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xDF6FA0", Offset = "0xDF6FA0", VA = "0xDF6FA0")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xDF6F44", Offset = "0xDF6F44", VA = "0xDF6F44")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xDF554C", Offset = "0xDF554C", VA = "0xDF554C")]
	public void init(LeanTweenPathControl[] controlRef, int i, bool isControl)
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xDF5718", Offset = "0xDF5718", VA = "0xDF5718")]
	public void init(int i)
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xDF6FFC", Offset = "0xDF6FFC", VA = "0xDF6FFC")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0xDF74E0", Offset = "0xDF74E0", VA = "0xDF74E0")]
	public LeanTweenPathControl()
	{
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58B7D0", Offset = "0x58B7D0")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x6000356")]
		[Address(RVA = "0xE04170", Offset = "0xE04170", VA = "0xE04170")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xE04194", Offset = "0xE04194", VA = "0xE04194")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xE041F4", Offset = "0xE041F4", VA = "0xE041F4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xE04254", Offset = "0xE04254", VA = "0xE04254")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58B844", Offset = "0x58B844")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x600035A")]
		[Address(RVA = "0xE0425C", Offset = "0xE0425C", VA = "0xE0425C")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class MeshContainer
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xE04264", Offset = "0xE04264", VA = "0xE04264")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xE042B8", Offset = "0xE042B8", VA = "0xE042B8")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58B8B8", Offset = "0x58B8B8")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xE042FC", Offset = "0xE042FC", VA = "0xE042FC")]
		public void Start()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xE043EC", Offset = "0xE043EC", VA = "0xE043EC")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xE046F4", Offset = "0xE046F4", VA = "0xE046F4")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xE047A8", Offset = "0xE047A8", VA = "0xE047A8")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xE048B0", Offset = "0xE048B0", VA = "0xE048B0")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xE05178", Offset = "0xE05178", VA = "0xE05178")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xE051D8", Offset = "0xE051D8", VA = "0xE051D8")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xE052D0", Offset = "0xE052D0", VA = "0xE052D0")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xE05330", Offset = "0xE05330", VA = "0xE05330")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xE04A18", Offset = "0xE04A18", VA = "0xE04A18")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xE05390", Offset = "0xE05390", VA = "0xE05390")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xE05890", Offset = "0xE05890", VA = "0xE05890")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xE053F4", Offset = "0xE053F4", VA = "0xE053F4")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xE05AC8", Offset = "0xE05AC8", VA = "0xE05AC8")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xE056AC", Offset = "0xE056AC", VA = "0xE056AC")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xE05AE8", Offset = "0xE05AE8", VA = "0xE05AE8")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58B92C", Offset = "0x58B92C")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xE05B5C", Offset = "0xE05B5C", VA = "0xE05B5C")]
		public void Start()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xE05C48", Offset = "0xE05C48", VA = "0xE05C48")]
		public void Update()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xE05E70", Offset = "0xE05E70", VA = "0xE05E70")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x200007F")]
		public enum WaterMode
		{
			[Token(Token = "0x40004D0")]
			Simple,
			[Token(Token = "0x40004D1")]
			Reflective,
			[Token(Token = "0x40004D2")]
			Refractive
		}

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xE05E78", Offset = "0xE05E78", VA = "0xE05E78")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xE078AC", Offset = "0xE078AC", VA = "0xE078AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xE07B98", Offset = "0xE07B98", VA = "0xE07B98")]
		private void Update()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xE071C8", Offset = "0xE071C8", VA = "0xE071C8")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xE067C0", Offset = "0xE067C0", VA = "0xE067C0")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xE067AC", Offset = "0xE067AC", VA = "0xE067AC")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xE06664", Offset = "0xE06664", VA = "0xE06664")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xE076C8", Offset = "0xE076C8", VA = "0xE076C8")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xE07424", Offset = "0xE07424", VA = "0xE07424")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xE07E24", Offset = "0xE07E24", VA = "0xE07E24")]
		public Water()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public enum WaterQuality
	{
		[Token(Token = "0x4000172")]
		High = 2,
		[Token(Token = "0x4000173")]
		Medium = 1,
		[Token(Token = "0x4000174")]
		Low = 0
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xE07F00", Offset = "0xE07F00", VA = "0xE07F00")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xE08080", Offset = "0xE08080", VA = "0xE08080")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xE08134", Offset = "0xE08134", VA = "0xE08134")]
		public void Update()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xE081B8", Offset = "0xE081B8", VA = "0xE081B8")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xE081D0", Offset = "0xE081D0", VA = "0xE081D0")]
		public void Start()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xE081D4", Offset = "0xE081D4", VA = "0xE081D4")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xE08378", Offset = "0xE08378", VA = "0xE08378")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xE08480", Offset = "0xE08480", VA = "0xE08480")]
		public WaterTile()
		{
		}
	}
}
namespace SimpleJSON
{
	[Token(Token = "0x200002F")]
	public enum JSONNodeType
	{
		[Token(Token = "0x400017B")]
		Array = 1,
		[Token(Token = "0x400017C")]
		Object = 2,
		[Token(Token = "0x400017D")]
		String = 3,
		[Token(Token = "0x400017E")]
		Number = 4,
		[Token(Token = "0x400017F")]
		NullValue = 5,
		[Token(Token = "0x4000180")]
		Boolean = 6,
		[Token(Token = "0x4000181")]
		None = 7,
		[Token(Token = "0x4000182")]
		Custom = 255
	}
	[Token(Token = "0x2000030")]
	public enum JSONTextMode
	{
		[Token(Token = "0x4000184")]
		Compact,
		[Token(Token = "0x4000185")]
		Indent
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x58B9D0", Offset = "0x58B9D0")]
	public abstract class JSONNode
	{
		[Token(Token = "0x2000080")]
		public struct Enumerator
		{
			[Token(Token = "0x20000DF")]
			private enum Type
			{
				[Token(Token = "0x400067E")]
				None,
				[Token(Token = "0x400067F")]
				Array,
				[Token(Token = "0x4000680")]
				Object
			}

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Type type;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Dictionary<string, JSONNode>.Enumerator m_Object;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator m_Array;

			[Token(Token = "0x17000142")]
			public bool IsValid
			{
				[Token(Token = "0x6000745")]
				[Address(RVA = "0xE01CA0", Offset = "0xE01CA0", VA = "0xE01CA0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000143")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x6000748")]
				[Address(RVA = "0xE01CD4", Offset = "0xE01CD4", VA = "0xE01CD4")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0xDFAC24", Offset = "0xDFAC24", VA = "0xDFAC24")]
			public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0xE01CB0", Offset = "0xE01CB0", VA = "0xE01CB0")]
			public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0xE01D88", Offset = "0xE01D88", VA = "0xE01D88")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000081")]
		public struct ValueEnumerator
		{
			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000144")]
			public JSONNode Current
			{
				[Token(Token = "0x600074D")]
				[Address(RVA = "0xE021D8", Offset = "0xE021D8", VA = "0xE021D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0xE0212C", Offset = "0xE0212C", VA = "0xE0212C")]
			public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x600074B")]
			[Address(RVA = "0xE02174", Offset = "0xE02174", VA = "0xE02174")]
			public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0xE021C0", Offset = "0xE021C0", VA = "0xE021C0")]
			public ValueEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0xE02224", Offset = "0xE02224", VA = "0xE02224")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0xE02228", Offset = "0xE02228", VA = "0xE02228")]
			public ValueEnumerator GetEnumerator()
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x2000082")]
		public struct KeyEnumerator
		{
			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000145")]
			public string Current
			{
				[Token(Token = "0x6000753")]
				[Address(RVA = "0xE01EC4", Offset = "0xE01EC4", VA = "0xE01EC4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0xE01E18", Offset = "0xE01E18", VA = "0xE01E18")]
			public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0xE01E60", Offset = "0xE01E60", VA = "0xE01E60")]
			public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0xE01EAC", Offset = "0xE01EAC", VA = "0xE01EAC")]
			public KeyEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0xE01F08", Offset = "0xE01F08", VA = "0xE01F08")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0xE01F0C", Offset = "0xE01F0C", VA = "0xE01F0C")]
			public KeyEnumerator GetEnumerator()
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x2000083")]
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerator, IDisposable, IEnumerable<KeyValuePair<string, JSONNode>>, IEnumerable
		{
			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private JSONNode m_Node;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000146")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x6000757")]
				[Address(RVA = "0xE01F1C", Offset = "0xE01F1C", VA = "0xE01F1C", Slot = "4")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x17000147")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000758")]
				[Address(RVA = "0xE01F24", Offset = "0xE01F24", VA = "0xE01F24", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0xDFD140", Offset = "0xDFD140", VA = "0xDFD140")]
			internal LinqEnumerator(JSONNode aNode)
			{
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0xE01F90", Offset = "0xE01F90", VA = "0xE01F90", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0xE01F98", Offset = "0xE01F98", VA = "0xE01F98", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0xE01FB8", Offset = "0xE01FB8", VA = "0xE01FB8", Slot = "9")]
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0xE0201C", Offset = "0xE0201C", VA = "0xE0201C", Slot = "8")]
			public void Reset()
			{
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0xE020C8", Offset = "0xE020C8", VA = "0xE020C8", Slot = "10")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BCE0", Offset = "0x58BCE0")]
		private sealed class <get_Children>d__42 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x17000148")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000761")]
				[Address(RVA = "0xE01444", Offset = "0xE01444", VA = "0xE01444", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000149")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000763")]
				[Address(RVA = "0xE014AC", Offset = "0xE014AC", VA = "0xE014AC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0xDFCEAC", Offset = "0xDFCEAC", VA = "0xDFCEAC")]
			[DebuggerHidden]
			public <get_Children>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0xE01428", Offset = "0xE01428", VA = "0xE01428", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0xE0142C", Offset = "0xE0142C", VA = "0xE0142C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0xE0144C", Offset = "0xE0144C", VA = "0xE0144C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0xE014B4", Offset = "0xE014B4", VA = "0xE014B4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0xE0154C", Offset = "0xE0154C", VA = "0xE0154C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000085")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BCF0", Offset = "0x58BCF0")]
		private sealed class <get_DeepChildren>d__44 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x1700014A")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600076B")]
				[Address(RVA = "0xE01B80", Offset = "0xE01B80", VA = "0xE01B80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600076D")]
				[Address(RVA = "0xE01BE8", Offset = "0xE01BE8", VA = "0xE01BE8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0xDFCF64", Offset = "0xDFCF64", VA = "0xDFCF64")]
			[DebuggerHidden]
			public <get_DeepChildren>d__44(int <>1__state)
			{
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0xE01550", Offset = "0xE01550", VA = "0xE01550", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0xE01760", Offset = "0xE01760", VA = "0xE01760", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0xE016A0", Offset = "0xE016A0", VA = "0xE016A0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0xE015E0", Offset = "0xE015E0", VA = "0xE015E0")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0xE01B88", Offset = "0xE01B88", VA = "0xE01B88", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0xE01BF0", Offset = "0xE01BF0", VA = "0xE01BF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0xE01C9C", Offset = "0xE01C9C", VA = "0xE01C9C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool forceASCII;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool longAsString;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public static bool allowLineComments;

		[Token(Token = "0x4000189")]
		[ThreadStatic]
		private static StringBuilder m_EscapeBuilder;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static JSONContainerType VectorContainerType;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static JSONContainerType QuaternionContainerType;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static JSONContainerType RectContainerType;

		[Token(Token = "0x17000073")]
		public abstract JSONNodeType Tag
		{
			[Token(Token = "0x6000382")]
			get;
		}

		[Token(Token = "0x17000074")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0xDFCD04", Offset = "0xDFCD04", VA = "0xDFCD04", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000384")]
			[Address(RVA = "0xDFCD0C", Offset = "0xDFCD0C", VA = "0xDFCD0C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0xDFCD10", Offset = "0xDFCD10", VA = "0xDFCD10", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000386")]
			[Address(RVA = "0xDFCD18", Offset = "0xDFCD18", VA = "0xDFCD18", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public virtual string Value
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0xDFCD1C", Offset = "0xDFCD1C", VA = "0xDFCD1C", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000388")]
			[Address(RVA = "0xDFCD64", Offset = "0xDFCD64", VA = "0xDFCD64", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public virtual int Count
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0xDFCD68", Offset = "0xDFCD68", VA = "0xDFCD68", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000078")]
		public virtual bool IsNumber
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0xDFCD70", Offset = "0xDFCD70", VA = "0xDFCD70", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000079")]
		public virtual bool IsString
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0xDFCD78", Offset = "0xDFCD78", VA = "0xDFCD78", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007A")]
		public virtual bool IsBoolean
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0xDFCD80", Offset = "0xDFCD80", VA = "0xDFCD80", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007B")]
		public virtual bool IsNull
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0xDFCD88", Offset = "0xDFCD88", VA = "0xDFCD88", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		public virtual bool IsArray
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0xDFCD90", Offset = "0xDFCD90", VA = "0xDFCD90", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007D")]
		public virtual bool IsObject
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0xDFCD98", Offset = "0xDFCD98", VA = "0xDFCD98", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007E")]
		public virtual bool Inline
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0xDFCDA0", Offset = "0xDFCDA0", VA = "0xDFCDA0", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0xDFCDA8", Offset = "0xDFCDA8", VA = "0xDFCDA8", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public virtual IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0xDFCE3C", Offset = "0xDFCE3C", VA = "0xDFCE3C", Slot = "26")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58C994", Offset = "0x58C994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public IEnumerable<JSONNode> DeepChildren
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0xDFCEE4", Offset = "0xDFCEE4", VA = "0xDFCEE4")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58C9F8", Offset = "0x58C9F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0xDFD0E0", Offset = "0xDFD0E0", VA = "0xDFD0E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public KeyEnumerator Keys
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0xDFD204", Offset = "0xDFD204", VA = "0xDFD204")]
			get
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x17000083")]
		public ValueEnumerator Values
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0xDFD24C", Offset = "0xDFD24C", VA = "0xDFD24C")]
			get
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x17000084")]
		public virtual double AsDouble
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0xDFD294", Offset = "0xDFD294", VA = "0xDFD294", Slot = "32")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0xDFD370", Offset = "0xDFD370", VA = "0xDFD370", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public virtual int AsInt
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0xDFD408", Offset = "0xDFD408", VA = "0xDFD408", Slot = "34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0xDFD42C", Offset = "0xDFD42C", VA = "0xDFD42C", Slot = "35")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public virtual float AsFloat
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0xDFD444", Offset = "0xDFD444", VA = "0xDFD444", Slot = "36")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xDFD468", Offset = "0xDFD468", VA = "0xDFD468", Slot = "37")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public virtual bool AsBool
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xDFD47C", Offset = "0xDFD47C", VA = "0xDFD47C", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xDFD544", Offset = "0xDFD544", VA = "0xDFD544", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public virtual long AsLong
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0xDFD5C0", Offset = "0xDFD5C0", VA = "0xDFD5C0", Slot = "40")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xDFD600", Offset = "0xDFD600", VA = "0xDFD600", Slot = "41")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xDFD640", Offset = "0xDFD640", VA = "0xDFD640", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		public virtual JSONObject AsObject
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xDFD6C0", Offset = "0xDFD6C0", VA = "0xDFD6C0", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		internal static StringBuilder EscapeBuilder
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0xDFDDE4", Offset = "0xDFDDE4", VA = "0xDFDDE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xDFCDAC", Offset = "0xDFCDAC", VA = "0xDFCDAC", Slot = "20")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xDFCDB0", Offset = "0xDFCDB0", VA = "0xDFCDB0", Slot = "21")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xDFCE1C", Offset = "0xDFCE1C", VA = "0xDFCE1C", Slot = "22")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xDFCE24", Offset = "0xDFCE24", VA = "0xDFCE24", Slot = "23")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xDFCE2C", Offset = "0xDFCE2C", VA = "0xDFCE2C", Slot = "24")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xDFCE34", Offset = "0xDFCE34", VA = "0xDFCE34", Slot = "25")]
		public virtual JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xDFCF9C", Offset = "0xDFCF9C", VA = "0xDFCF9C", Slot = "27")]
		public virtual bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xDFCFA4", Offset = "0xDFCFA4", VA = "0xDFCFA4", Slot = "28")]
		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xDFCFAC", Offset = "0xDFCFAC", VA = "0xDFCFAC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xDFD040", Offset = "0xDFD040", VA = "0xDFD040", Slot = "29")]
		public virtual string ToString(int aIndent)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		[Token(Token = "0x600039F")]
		public abstract Enumerator GetEnumerator();

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xDFD740", Offset = "0xDFD740", VA = "0xDFD740")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xDFD7A0", Offset = "0xDFD7A0", VA = "0xDFD7A0")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xDFD834", Offset = "0xDFD834", VA = "0xDFD834")]
		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xDFD89C", Offset = "0xDFD89C", VA = "0xDFD89C")]
		public static implicit operator double(JSONNode d)
		{
			return default(double);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xDFD934", Offset = "0xDFD934", VA = "0xDFD934")]
		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xDFD99C", Offset = "0xDFD99C", VA = "0xDFD99C")]
		public static implicit operator float(JSONNode d)
		{
			return default(float);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xDFDA34", Offset = "0xDFDA34", VA = "0xDFDA34")]
		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xDFDA94", Offset = "0xDFDA94", VA = "0xDFDA94")]
		public static implicit operator int(JSONNode d)
		{
			return default(int);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xDFDB2C", Offset = "0xDFDB2C", VA = "0xDFDB2C")]
		public static implicit operator JSONNode(long n)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xDFDBFC", Offset = "0xDFDBFC", VA = "0xDFDBFC")]
		public static implicit operator long(JSONNode d)
		{
			return default(long);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xDFDC94", Offset = "0xDFDC94", VA = "0xDFDC94")]
		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xDFDCF4", Offset = "0xDFDCF4", VA = "0xDFDCF4")]
		public static implicit operator bool(JSONNode d)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xDFDD8C", Offset = "0xDFDD8C", VA = "0xDFDD8C")]
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xDFAE68", Offset = "0xDFAE68", VA = "0xDFAE68")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xDFB648", Offset = "0xDFB648", VA = "0xDFB648")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xDFDDD0", Offset = "0xDFDDD0", VA = "0xDFDDD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xDFDDDC", Offset = "0xDFDDDC", VA = "0xDFDDDC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xDFDEB4", Offset = "0xDFDEB4", VA = "0xDFDEB4")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xDFE154", Offset = "0xDFE154", VA = "0xDFE154")]
		private static JSONNode ParseElement(string token, bool quoted)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xDFA3FC", Offset = "0xDFA3FC", VA = "0xDFA3FC")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		public abstract void SerializeBinary(BinaryWriter aWriter);

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xDFE358", Offset = "0xDFE358", VA = "0xDFE358")]
		public void SaveToBinaryStream(Stream aData)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xDFE3D8", Offset = "0xDFE3D8", VA = "0xDFE3D8")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xDFE444", Offset = "0xDFE444", VA = "0xDFE444")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xDFE4B0", Offset = "0xDFE4B0", VA = "0xDFE4B0")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xDFE51C", Offset = "0xDFE51C", VA = "0xDFE51C")]
		public void SaveToBinaryFile(string aFileName)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xDFE670", Offset = "0xDFE670", VA = "0xDFE670")]
		public string SaveToBinaryBase64()
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xDFE7F4", Offset = "0xDFE7F4", VA = "0xDFE7F4")]
		public static JSONNode DeserializeBinary(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xDFEB18", Offset = "0xDFEB18", VA = "0xDFEB18")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xDFEB84", Offset = "0xDFEB84", VA = "0xDFEB84")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xDFEBF0", Offset = "0xDFEBF0", VA = "0xDFEBF0")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xDFEC5C", Offset = "0xDFEC5C", VA = "0xDFEC5C")]
		public static JSONNode LoadFromBinaryStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xDFED9C", Offset = "0xDFED9C", VA = "0xDFED9C")]
		public static JSONNode LoadFromBinaryFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xDFEED0", Offset = "0xDFEED0", VA = "0xDFEED0")]
		public static JSONNode LoadFromBinaryBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xDFEFA4", Offset = "0xDFEFA4", VA = "0xDFEFA4")]
		private static JSONNode GetContainer(JSONContainerType aType)
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xDFF020", Offset = "0xDFF020", VA = "0xDFF020")]
		public static implicit operator JSONNode(Vector2 aVec)
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xDFF200", Offset = "0xDFF200", VA = "0xDFF200")]
		public static implicit operator JSONNode(Vector3 aVec)
		{
			return null;
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xDFF464", Offset = "0xDFF464", VA = "0xDFF464")]
		public static implicit operator JSONNode(Vector4 aVec)
		{
			return null;
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xDFF73C", Offset = "0xDFF73C", VA = "0xDFF73C")]
		public static implicit operator JSONNode(Quaternion aRot)
		{
			return null;
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xDFFA14", Offset = "0xDFFA14", VA = "0xDFFA14")]
		public static implicit operator JSONNode(Rect aRect)
		{
			return null;
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xDFFD48", Offset = "0xDFFD48", VA = "0xDFFD48")]
		public static implicit operator JSONNode(RectOffset aRect)
		{
			return null;
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xE00074", Offset = "0xE00074", VA = "0xE00074")]
		public static implicit operator Vector2(JSONNode aNode)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xE000F4", Offset = "0xE000F4", VA = "0xE000F4")]
		public static implicit operator Vector3(JSONNode aNode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xE00174", Offset = "0xE00174", VA = "0xE00174")]
		public static implicit operator Vector4(JSONNode aNode)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xE001F4", Offset = "0xE001F4", VA = "0xE001F4")]
		public static implicit operator Quaternion(JSONNode aNode)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xE00274", Offset = "0xE00274", VA = "0xE00274")]
		public static implicit operator Rect(JSONNode aNode)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xE002AC", Offset = "0xE002AC", VA = "0xE002AC")]
		public static implicit operator RectOffset(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xE00324", Offset = "0xE00324", VA = "0xE00324")]
		public Vector2 ReadVector2(Vector2 aDefault)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xE00480", Offset = "0xE00480", VA = "0xE00480")]
		public Vector2 ReadVector2(string aXName, string aYName)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xE00088", Offset = "0xE00088", VA = "0xE00088")]
		public Vector2 ReadVector2()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xDFF0C4", Offset = "0xDFF0C4", VA = "0xDFF0C4")]
		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x", string aYName = "y")
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xE00594", Offset = "0xE00594", VA = "0xE00594")]
		public Vector3 ReadVector3(Vector3 aDefault)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xE0076C", Offset = "0xE0076C", VA = "0xE0076C")]
		public Vector3 ReadVector3(string aXName, string aYName, string aZName)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xE00108", Offset = "0xE00108", VA = "0xE00108")]
		public Vector3 ReadVector3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xDFF2C0", Offset = "0xDFF2C0", VA = "0xDFF2C0")]
		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x", string aYName = "y", string aZName = "z")
		{
			return null;
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xE008D0", Offset = "0xE008D0", VA = "0xE008D0")]
		public Vector4 ReadVector4(Vector4 aDefault)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xE00188", Offset = "0xE00188", VA = "0xE00188")]
		public Vector4 ReadVector4()
		{
			return default(Vector4);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xDFF508", Offset = "0xDFF508", VA = "0xDFF508")]
		public JSONNode WriteVector4(Vector4 aVec)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xE00B0C", Offset = "0xE00B0C", VA = "0xE00B0C")]
		public Quaternion ReadQuaternion(Quaternion aDefault)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xE00208", Offset = "0xE00208", VA = "0xE00208")]
		public Quaternion ReadQuaternion()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xDFF7E0", Offset = "0xDFF7E0", VA = "0xDFF7E0")]
		public JSONNode WriteQuaternion(Quaternion aRot)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xE00D48", Offset = "0xE00D48", VA = "0xE00D48")]
		public Rect ReadRect(Rect aDefault)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xE00298", Offset = "0xE00298", VA = "0xE00298")]
		public Rect ReadRect()
		{
			return default(Rect);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xDFFAB8", Offset = "0xDFFAB8", VA = "0xDFFAB8")]
		public JSONNode WriteRect(Rect aRect)
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xE00F84", Offset = "0xE00F84", VA = "0xE00F84")]
		public RectOffset ReadRectOffset(RectOffset aDefault)
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xE002C0", Offset = "0xE002C0", VA = "0xE002C0")]
		public RectOffset ReadRectOffset()
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xDFFDC4", Offset = "0xDFFDC4", VA = "0xDFFDC4")]
		public JSONNode WriteRectOffset(RectOffset aRect)
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xE011DC", Offset = "0xE011DC", VA = "0xE011DC")]
		public Matrix4x4 ReadMatrix()
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xE012EC", Offset = "0xE012EC", VA = "0xE012EC")]
		public JSONNode WriteMatrix(Matrix4x4 aMatrix)
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xDFB9D8", Offset = "0xDFB9D8", VA = "0xDFB9D8")]
		protected JSONNode()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x58BA08", Offset = "0x58BA08")]
	public class JSONArray : JSONNode
	{
		[Token(Token = "0x2000086")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BD00", Offset = "0x58BD00")]
		private sealed class <get_Children>d__23 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700014C")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000774")]
				[Address(RVA = "0xDFBBA8", Offset = "0xDFBBA8", VA = "0xDFBBA8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000776")]
				[Address(RVA = "0xDFBC10", Offset = "0xDFBC10", VA = "0xDFBC10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0xDFB748", Offset = "0xDFB748", VA = "0xDFB748")]
			[DebuggerHidden]
			public <get_Children>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0xDFB9E0", Offset = "0xDFB9E0", VA = "0xDFB9E0", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0xDFBA54", Offset = "0xDFBA54", VA = "0xDFBA54", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0xDFB9FC", Offset = "0xDFB9FC", VA = "0xDFB9FC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0xDFBBB0", Offset = "0xDFBBB0", VA = "0xDFBBB0", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0xDFBC18", Offset = "0xDFBC18", VA = "0xDFBC18", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0xDFBCC4", Offset = "0xDFBCC4", VA = "0xDFBCC4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x1700008C")]
		public override bool Inline
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0xDFAB6C", Offset = "0xDFAB6C", VA = "0xDFAB6C", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0xDFAB74", Offset = "0xDFAB74", VA = "0xDFAB74", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0xDFAB80", Offset = "0xDFAB80", VA = "0xDFAB80", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700008E")]
		public override bool IsArray
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0xDFAB88", Offset = "0xDFAB88", VA = "0xDFAB88", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008F")]
		public override JSONNode Item
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xDFAC4C", Offset = "0xDFAC4C", VA = "0xDFAC4C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0xDFAD6C", Offset = "0xDFAD6C", VA = "0xDFAD6C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public override JSONNode Item
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0xDFB098", Offset = "0xDFB098", VA = "0xDFB098", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0xDFB0F8", Offset = "0xDFB0F8", VA = "0xDFB0F8", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public override int Count
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0xDFB1B8", Offset = "0xDFB1B8", VA = "0xDFB1B8", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000092")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xDFB6C8", Offset = "0xDFB6C8", VA = "0xDFB6C8", Slot = "26")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58CA5C", Offset = "0x58CA5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xDFAB90", Offset = "0xDFAB90", VA = "0xDFAB90", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xDFB208", Offset = "0xDFB208", VA = "0xDFB208", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xDFB2C8", Offset = "0xDFB2C8", VA = "0xDFB2C8", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xDFB374", Offset = "0xDFB374", VA = "0xDFB374", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xDFB3E4", Offset = "0xDFB3E4", VA = "0xDFB3E4", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xDFB780", Offset = "0xDFB780", VA = "0xDFB780", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xDFB8F8", Offset = "0xDFB8F8", VA = "0xDFB8F8", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xDFB5B8", Offset = "0xDFB5B8", VA = "0xDFB5B8")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x58BA40", Offset = "0x58BA40")]
	public class JSONObject : JSONNode
	{
		[Token(Token = "0x2000087")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BD10", Offset = "0x58BD10")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x6000779")]
			[Address(RVA = "0xE03398", Offset = "0xE03398", VA = "0xE03398")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0xE03B28", Offset = "0xE03B28", VA = "0xE03B28")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000088")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BD20", Offset = "0x58BD20")]
		private sealed class <get_Children>d__26 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700014E")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600077F")]
				[Address(RVA = "0xE03D70", Offset = "0xE03D70", VA = "0xE03D70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000781")]
				[Address(RVA = "0xE03DD8", Offset = "0xE03DD8", VA = "0xE03DD8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600077B")]
			[Address(RVA = "0xE0366C", Offset = "0xE0366C", VA = "0xE0366C")]
			[DebuggerHidden]
			public <get_Children>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x600077C")]
			[Address(RVA = "0xE03BA0", Offset = "0xE03BA0", VA = "0xE03BA0", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600077D")]
			[Address(RVA = "0xE03C14", Offset = "0xE03C14", VA = "0xE03C14", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600077E")]
			[Address(RVA = "0xE03BBC", Offset = "0xE03BBC", VA = "0xE03BBC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000780")]
			[Address(RVA = "0xE03D78", Offset = "0xE03D78", VA = "0xE03D78", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0xE03DE0", Offset = "0xE03DE0", VA = "0xE03DE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000783")]
			[Address(RVA = "0xE03E8C", Offset = "0xE03E8C", VA = "0xE03E8C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x17000093")]
		public override bool Inline
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0xE02A98", Offset = "0xE02A98", VA = "0xE02A98", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600040A")]
			[Address(RVA = "0xE02AA0", Offset = "0xE02AA0", VA = "0xE02AA0", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0xE02AAC", Offset = "0xE02AAC", VA = "0xE02AAC", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000095")]
		public override bool IsObject
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0xE02AB4", Offset = "0xE02AB4", VA = "0xE02AB4", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000096")]
		public override JSONNode Item
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0xE02B54", Offset = "0xE02B54", VA = "0xE02B54", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600040F")]
			[Address(RVA = "0xE02C10", Offset = "0xE02C10", VA = "0xE02C10", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0xE02D24", Offset = "0xE02D24", VA = "0xE02D24", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000411")]
			[Address(RVA = "0xE02DBC", Offset = "0xE02DBC", VA = "0xE02DBC", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public override int Count
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0xE02ED8", Offset = "0xE02ED8", VA = "0xE02ED8", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000099")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0xE035EC", Offset = "0xE035EC", VA = "0xE035EC", Slot = "26")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58CAC0", Offset = "0x58CAC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xE02ABC", Offset = "0xE02ABC", VA = "0xE02ABC", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xE02F30", Offset = "0xE02F30", VA = "0xE02F30", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xE030A8", Offset = "0xE030A8", VA = "0xE030A8", Slot = "22")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xE03164", Offset = "0xE03164", VA = "0xE03164", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xE03220", Offset = "0xE03220", VA = "0xE03220", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xE033A0", Offset = "0xE033A0", VA = "0xE033A0", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xE034F8", Offset = "0xE034F8", VA = "0xE034F8", Slot = "27")]
		public override bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xE03560", Offset = "0xE03560", VA = "0xE03560", Slot = "28")]
		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xE036A4", Offset = "0xE036A4", VA = "0xE036A4", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xE03970", Offset = "0xE03970", VA = "0xE03970", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xDFC314", Offset = "0xDFC314", VA = "0xDFC314")]
		public JSONObject()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class JSONString : JSONNode
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x1700009A")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0xE03E90", Offset = "0xE03E90", VA = "0xE03E90", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700009B")]
		public override bool IsString
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0xE03E98", Offset = "0xE03E98", VA = "0xE03E98", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009C")]
		public override string Value
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0xE03EC0", Offset = "0xE03EC0", VA = "0xE03EC0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0xE03EC8", Offset = "0xE03EC8", VA = "0xE03EC8", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xE03EA0", Offset = "0xE03EA0", VA = "0xE03EA0", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xDFC954", Offset = "0xDFC954", VA = "0xDFC954")]
		public JSONString(string aData)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xE03ED0", Offset = "0xE03ED0", VA = "0xE03ED0", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xE03F34", Offset = "0xE03F34", VA = "0xE03F34", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xE03FEC", Offset = "0xE03FEC", VA = "0xE03FEC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xE04100", Offset = "0xE04100", VA = "0xE04100", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xE04120", Offset = "0xE04120", VA = "0xE04120", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class JSONNumber : JSONNode
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double m_Data;

		[Token(Token = "0x1700009D")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0xE02518", Offset = "0xE02518", VA = "0xE02518", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700009E")]
		public override bool IsNumber
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0xE02520", Offset = "0xE02520", VA = "0xE02520", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009F")]
		public override string Value
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0xE02548", Offset = "0xE02548", VA = "0xE02548", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042D")]
			[Address(RVA = "0xE025C0", Offset = "0xE025C0", VA = "0xE025C0", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public override double AsDouble
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0xE02684", Offset = "0xE02684", VA = "0xE02684", Slot = "32")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600042F")]
			[Address(RVA = "0xE0268C", Offset = "0xE0268C", VA = "0xE0268C", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public override long AsLong
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0xE02694", Offset = "0xE02694", VA = "0xE02694", Slot = "40")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0xE026A0", Offset = "0xE026A0", VA = "0xE026A0", Slot = "41")]
			set
			{
			}
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xE02528", Offset = "0xE02528", VA = "0xE02528", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xDFC59C", Offset = "0xDFC59C", VA = "0xDFC59C")]
		public JSONNumber(double aData)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xE026AC", Offset = "0xE026AC", VA = "0xE026AC")]
		public JSONNumber(string aData)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xE02734", Offset = "0xE02734", VA = "0xE02734", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xE027A0", Offset = "0xE027A0", VA = "0xE027A0", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xE027E0", Offset = "0xE027E0", VA = "0xE027E0")]
		private static bool IsNumeric(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xE02910", Offset = "0xE02910", VA = "0xE02910", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xE02A3C", Offset = "0xE02A3C", VA = "0xE02A3C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xE02A48", Offset = "0xE02A48", VA = "0xE02A48", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class JSONBool : JSONNode
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_Data;

		[Token(Token = "0x170000A2")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0xDFBCC8", Offset = "0xDFBCC8", VA = "0xDFBCC8", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x170000A3")]
		public override bool IsBoolean
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0xDFBCD0", Offset = "0xDFBCD0", VA = "0xDFBCD0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A4")]
		public override string Value
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0xDFBCF8", Offset = "0xDFBCF8", VA = "0xDFBCF8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043E")]
			[Address(RVA = "0xDFBD04", Offset = "0xDFBD04", VA = "0xDFBD04", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public override bool AsBool
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0xDFBD90", Offset = "0xDFBD90", VA = "0xDFBD90", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000440")]
			[Address(RVA = "0xDFBD98", Offset = "0xDFBD98", VA = "0xDFBD98", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xDFBCD8", Offset = "0xDFBCD8", VA = "0xDFBCD8", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xDFBDA4", Offset = "0xDFBDA4", VA = "0xDFBDA4")]
		public JSONBool(bool aData)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xDFBE24", Offset = "0xDFBE24", VA = "0xDFBE24")]
		public JSONBool(string aData)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xDFBEAC", Offset = "0xDFBEAC", VA = "0xDFBEAC", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xDFBF10", Offset = "0xDFBF10", VA = "0xDFBF10", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xDFBF8C", Offset = "0xDFBF8C", VA = "0xDFBF8C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xDFC014", Offset = "0xDFC014", VA = "0xDFC014", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xDFC020", Offset = "0xDFC020", VA = "0xDFC020", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class JSONNull : JSONNode
	{
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static JSONNull m_StaticInstance;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool reuseSameInstance;

		[Token(Token = "0x170000A6")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0xE022A0", Offset = "0xE022A0", VA = "0xE022A0", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x170000A7")]
		public override bool IsNull
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0xE022A8", Offset = "0xE022A8", VA = "0xE022A8", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A8")]
		public override string Value
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0xE022D0", Offset = "0xE022D0", VA = "0xE022D0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044E")]
			[Address(RVA = "0xE02318", Offset = "0xE02318", VA = "0xE02318", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public override bool AsBool
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0xE0231C", Offset = "0xE0231C", VA = "0xE0231C", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000450")]
			[Address(RVA = "0xE02324", Offset = "0xE02324", VA = "0xE02324", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xDFAFF8", Offset = "0xDFAFF8", VA = "0xDFAFF8")]
		public static JSONNull CreateOrGet()
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xE02238", Offset = "0xE02238", VA = "0xE02238")]
		private JSONNull()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xE022B0", Offset = "0xE022B0", VA = "0xE022B0", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xE02328", Offset = "0xE02328", VA = "0xE02328", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xE02384", Offset = "0xE02384", VA = "0xE02384", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xE02420", Offset = "0xE02420", VA = "0xE02420", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xE02428", Offset = "0xE02428", VA = "0xE02428", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xE02484", Offset = "0xE02484", VA = "0xE02484", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x58BA78", Offset = "0x58BA78")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x170000AA")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0xDFC06C", Offset = "0xDFC06C", VA = "0xDFC06C", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x170000AB")]
		public override JSONNode Item
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0xDFC114", Offset = "0xDFC114", VA = "0xDFC114", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045D")]
			[Address(RVA = "0xDFC174", Offset = "0xDFC174", VA = "0xDFC174", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public override JSONNode Item
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0xDFC208", Offset = "0xDFC208", VA = "0xDFC208", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045F")]
			[Address(RVA = "0xDFC278", Offset = "0xDFC278", VA = "0xDFC278", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public override int AsInt
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0xDFC524", Offset = "0xDFC524", VA = "0xDFC524", Slot = "34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000467")]
			[Address(RVA = "0xDFC618", Offset = "0xDFC618", VA = "0xDFC618", Slot = "35")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public override float AsFloat
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0xDFC694", Offset = "0xDFC694", VA = "0xDFC694", Slot = "36")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000469")]
			[Address(RVA = "0xDFC70C", Offset = "0xDFC70C", VA = "0xDFC70C", Slot = "37")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public override double AsDouble
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0xDFC788", Offset = "0xDFC788", VA = "0xDFC788", Slot = "32")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600046B")]
			[Address(RVA = "0xDFC800", Offset = "0xDFC800", VA = "0xDFC800", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public override long AsLong
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0xDFC87C", Offset = "0xDFC87C", VA = "0xDFC87C", Slot = "40")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600046D")]
			[Address(RVA = "0xDFC9D0", Offset = "0xDFC9D0", VA = "0xDFC9D0", Slot = "41")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public override bool AsBool
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0xDFCAD8", Offset = "0xDFCAD8", VA = "0xDFCAD8", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600046F")]
			[Address(RVA = "0xDFCB50", Offset = "0xDFCB50", VA = "0xDFCB50", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0xDFCBCC", Offset = "0xDFCBCC", VA = "0xDFCBCC", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		public override JSONObject AsObject
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0xDFCC38", Offset = "0xDFCC38", VA = "0xDFCC38", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xDFC074", Offset = "0xDFC074", VA = "0xDFC074", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xDFACF0", Offset = "0xDFACF0", VA = "0xDFACF0")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xDFC094", Offset = "0xDFC094", VA = "0xDFC094")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x600045B")]
		private T Set<T>(T aVal) where T : JSONNode
		{
			return null;
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xDFC3A4", Offset = "0xDFC3A4", VA = "0xDFC3A4", Slot = "21")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xDFC438", Offset = "0xDFC438", VA = "0xDFC438", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xDFC4D4", Offset = "0xDFC4D4", VA = "0xDFC4D4")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xDFC4EC", Offset = "0xDFC4EC", VA = "0xDFC4EC")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xDFC504", Offset = "0xDFC504", VA = "0xDFC504", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xDFC51C", Offset = "0xDFC51C", VA = "0xDFC51C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xDFCCA4", Offset = "0xDFCCA4", VA = "0xDFCCA4", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xDFCD00", Offset = "0xDFCD00", VA = "0xDFCD00", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000039")]
	public static class JSON
	{
		[Token(Token = "0x6000474")]
		[Address(RVA = "0xDFA398", Offset = "0xDFA398", VA = "0xDFA398")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
	[Token(Token = "0x200003A")]
	public enum JSONContainerType
	{
		[Token(Token = "0x4000199")]
		Array,
		[Token(Token = "0x400019A")]
		Object
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x58BAB0", Offset = "0x58BAB0")]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x6000475")]
		[Address(RVA = "0xDFA380", Offset = "0xDFA380", VA = "0xDFA380")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x58BAC4", Offset = "0x58BAC4")]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x6000476")]
		[Address(RVA = "0xDFA388", Offset = "0xDFA388", VA = "0xDFA388")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x58BAD8", Offset = "0x58BAD8")]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x6000477")]
		[Address(RVA = "0xDFA390", Offset = "0xDFA390", VA = "0xDFA390")]
		public RelatingAttribute()
		{
		}
	}
}
namespace DentedPixel.LTEditor
{
	[Token(Token = "0x200003E")]
	public class LTVisualShared : MonoBehaviour
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] LT_2_12_MethodNames;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static object[][] methodLabelsGrouping;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] methodLabels;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] methodStrMapping;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static int[] methodIntMapping;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] methodStrMappingGrouping;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static int[] methodIntMappingGrouping;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static int[] easeIntMapping;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] easeStrMapping;

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xB63798", Offset = "0xB63798", VA = "0xB63798")]
		public static void updateTweens(LeanTweenVisual tween)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xB642DC", Offset = "0xB642DC", VA = "0xB642DC")]
		public static int actionIndex(LeanTweenItem item)
		{
			return default(int);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xB643DC", Offset = "0xB643DC", VA = "0xB643DC")]
		public static void setActionIndex(LeanTweenItem item, int newIndex)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xB644AC", Offset = "0xB644AC", VA = "0xB644AC")]
		public static int easeIndex(LeanTweenItem item)
		{
			return default(int);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xB64620", Offset = "0xB64620", VA = "0xB64620")]
		public static void setEaseIndex(LeanTweenItem item, int newIndex)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xB646F0", Offset = "0xB646F0", VA = "0xB646F0")]
		public LTVisualShared()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class LeanTweenVisual : MonoBehaviour
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<LeanTweenGroup> groupList;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool repeat;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float repeatDelay;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int repeatCount;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int repeatIter;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float nextCall;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool restartOnEnable;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int versionNum;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private StringBuilder codeBuild;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string tabs;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LTDescr tween;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float allTweensDelaySaved;

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x8CCE10", Offset = "0x8CCE10", VA = "0x8CCE10")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x8CCE78", Offset = "0x8CCE78", VA = "0x8CCE78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x8CD624", Offset = "0x8CD624", VA = "0x8CD624")]
		private void Update()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x8CD628", Offset = "0x8CD628", VA = "0x8CD628")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x8CD63C", Offset = "0x8CD63C", VA = "0x8CD63C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x8CD730", Offset = "0x8CD730", VA = "0x8CD730")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x8CD7A8", Offset = "0x8CD7A8", VA = "0x8CD7A8")]
		public void CopyTo(LeanTweenVisual tween)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x8CD938", Offset = "0x8CD938", VA = "0x8CD938")]
		public void buildAllTweensAgain()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x8CDB48", Offset = "0x8CDB48", VA = "0x8CDB48")]
		public void buildAllTweensAgainNow()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x8CDB50", Offset = "0x8CDB50", VA = "0x8CDB50")]
		public LTDescr append(string method, float to, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x8CDDB4", Offset = "0x8CDDB4", VA = "0x8CDDB4")]
		public LTDescr appendRect(string method, float to, float duration)
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x8CE018", Offset = "0x8CE018", VA = "0x8CE018")]
		public LTDescr append(string method, Vector3 to, float duration)
		{
			return null;
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x8CE4B8", Offset = "0x8CE4B8", VA = "0x8CE4B8")]
		public LTDescr appendRect(string method, Vector3 to, float duration)
		{
			return null;
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x8CE72C", Offset = "0x8CE72C", VA = "0x8CE72C")]
		public LTDescr appendRect(string method, Color color, float duration)
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x8CEC40", Offset = "0x8CEC40", VA = "0x8CEC40")]
		public LTDescr append(string method, Color color, float duration)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x8CEEBC", Offset = "0x8CEEBC", VA = "0x8CEEBC")]
		public LTDescr append(string method, Vector3[] to, float duration)
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x8CF084", Offset = "0x8CF084", VA = "0x8CF084")]
		public void append(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x8CE28C", Offset = "0x8CE28C", VA = "0x8CE28C")]
		private string vecToStr(Vector3 vec3)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x8CE9A8", Offset = "0x8CE9A8", VA = "0x8CE9A8")]
		private string colorToStr(Color color)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x8CF374", Offset = "0x8CF374", VA = "0x8CF374")]
		private void buildTween(LeanTweenItem item, float delayAdd, bool generateCode)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x8D3D0C", Offset = "0x8D3D0C", VA = "0x8D3D0C")]
		public void buildGroup(object g)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x8CCE80", Offset = "0x8CCE80", VA = "0x8CCE80")]
		public string buildAllTweens(bool generateCode)
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x8D4190", Offset = "0x8D4190", VA = "0x8D4190")]
		public LeanTweenVisual()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public enum LeanTweenBetween
	{
		[Token(Token = "0x40001B1")]
		FromTo,
		[Token(Token = "0x40001B2")]
		To
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class LeanTweenItem
	{
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TweenAction action;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int actionLast;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string actionStr;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LeanTweenBetween between;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LeanTweenType ease;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string easeStr;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve animationCurve;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 from;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 to;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Color colorTo;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 axis;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float duration;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float delay;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool alignWithPrevious;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public bool foldout;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public LeanTweenPath bezierPath;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LeanTweenPath splinePath;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioClip audioClip;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool orientToPath;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isPath2d;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool doesLoop;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int loopCount;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public LeanTweenType loopType;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Sprite[] sprites;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool spritesMaximized;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float frameRate;

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x8CCBCC", Offset = "0x8CCBCC", VA = "0x8CCBCC")]
		public LeanTweenItem()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x8CCCE4", Offset = "0x8CCCE4", VA = "0x8CCCE4")]
		public LeanTweenItem(float delay)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x8CC74C", Offset = "0x8CC74C", VA = "0x8CC74C")]
		public LeanTweenItem(LeanTweenItem item)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public class LeanTweenGroup
	{
		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool repeat;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float delay;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int repeatCount;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int repeatIter;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool foldout;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject gameObject;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<LeanTweenItem> itemList;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _generateCode;

		[Token(Token = "0x170000B4")]
		public float startTime
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x8CC8E4", Offset = "0x8CC8E4", VA = "0x8CC8E4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B5")]
		public float endTime
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x8CCA4C", Offset = "0x8CCA4C", VA = "0x8CCA4C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B6")]
		public bool generateCode
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x8CCBC4", Offset = "0x8CCBC4", VA = "0x8CCBC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x8CC44C", Offset = "0x8CC44C", VA = "0x8CC44C")]
		public LeanTweenGroup()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x8CC4DC", Offset = "0x8CC4DC", VA = "0x8CC4DC")]
		public LeanTweenGroup(float delay)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x8CC580", Offset = "0x8CC580", VA = "0x8CC580")]
		public LeanTweenGroup(LeanTweenGroup group)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x8CCBB8", Offset = "0x8CCBB8", VA = "0x8CCBB8")]
		public void setGenerateCode()
		{
		}
	}
}
namespace MiniJSON
{
	[Token(Token = "0x2000043")]
	public static class Json
	{
		[Token(Token = "0x2000089")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x20000E0")]
			private enum TOKEN
			{
				[Token(Token = "0x4000682")]
				NONE,
				[Token(Token = "0x4000683")]
				CURLY_OPEN,
				[Token(Token = "0x4000684")]
				CURLY_CLOSE,
				[Token(Token = "0x4000685")]
				SQUARED_OPEN,
				[Token(Token = "0x4000686")]
				SQUARED_CLOSE,
				[Token(Token = "0x4000687")]
				COLON,
				[Token(Token = "0x4000688")]
				COMMA,
				[Token(Token = "0x4000689")]
				STRING,
				[Token(Token = "0x400068A")]
				NUMBER,
				[Token(Token = "0x400068B")]
				TRUE,
				[Token(Token = "0x400068C")]
				FALSE,
				[Token(Token = "0x400068D")]
				NULL
			}

			[Token(Token = "0x40004EE")]
			private const string WHITE_SPACE = " \t\n\r";

			[Token(Token = "0x40004EF")]
			private const string WORD_BREAK = " \t\n\r{}[],:\"";

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x17000150")]
			private char PeekChar
			{
				[Token(Token = "0x600078E")]
				[Address(RVA = "0xDF967C", Offset = "0xDF967C", VA = "0xDF967C")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000151")]
			private char NextChar
			{
				[Token(Token = "0x600078F")]
				[Address(RVA = "0xDF946C", Offset = "0xDF946C", VA = "0xDF946C")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000152")]
			private string NextWord
			{
				[Token(Token = "0x6000790")]
				[Address(RVA = "0xDF94F4", Offset = "0xDF94F4", VA = "0xDF94F4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000153")]
			private TOKEN NextToken
			{
				[Token(Token = "0x6000791")]
				[Address(RVA = "0xDF8DC8", Offset = "0xDF8DC8", VA = "0xDF8DC8")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0xDF8BDC", Offset = "0xDF8BDC", VA = "0xDF8BDC")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0xDF8A30", Offset = "0xDF8A30", VA = "0xDF8A30")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0xDF8C80", Offset = "0xDF8C80", VA = "0xDF8C80", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000787")]
			[Address(RVA = "0xDF8CB4", Offset = "0xDF8CB4", VA = "0xDF8CB4")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6000788")]
			[Address(RVA = "0xDF91E0", Offset = "0xDF91E0", VA = "0xDF91E0")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6000789")]
			[Address(RVA = "0xDF8C58", Offset = "0xDF8C58", VA = "0xDF8C58")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x600078A")]
			[Address(RVA = "0xDF92B4", Offset = "0xDF92B4", VA = "0xDF92B4")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x600078B")]
			[Address(RVA = "0xDF8F78", Offset = "0xDF8F78", VA = "0xDF8F78")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0xDF9390", Offset = "0xDF9390", VA = "0xDF9390")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x600078D")]
			[Address(RVA = "0xDF95D8", Offset = "0xDF95D8", VA = "0xDF95D8")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x200008A")]
		private sealed class Serializer
		{
			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x6000792")]
			[Address(RVA = "0xDF9704", Offset = "0xDF9704", VA = "0xDF9704")]
			private Serializer()
			{
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0xDF8B60", Offset = "0xDF8B60", VA = "0xDF8B60")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0xDF9770", Offset = "0xDF9770", VA = "0xDF9770")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0xDF9E20", Offset = "0xDF9E20", VA = "0xDF9E20")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0xDF9B64", Offset = "0xDF9B64", VA = "0xDF9B64")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0xDF98F4", Offset = "0xDF98F4", VA = "0xDF98F4")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0xDFA208", Offset = "0xDFA208", VA = "0xDFA208")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xDF8A24", Offset = "0xDF8A24", VA = "0xDF8A24")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xDF8B5C", Offset = "0xDF8B5C", VA = "0xDF8B5C")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
namespace DarkTonic.MasterAudio
{
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x58BAEC", Offset = "0x58BAEC")]
	public class ButtonClicker : MonoBehaviour
	{
		[Token(Token = "0x40001D8")]
		public const float SmallSizeMultiplier = 0.9f;

		[Token(Token = "0x40001D9")]
		public const float LargeSizeMultiplier = 1.1f;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool resizeOnClick;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool resizeClickAllSiblings;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool resizeOnHover;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool resizeHoverAllSiblings;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mouseDownSound;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string mouseUpSound;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mouseClickSound;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mouseOverSound;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mouseOutSound;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _originalSize;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _smallerSize;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _largerSize;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _trans;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Dictionary<Transform, Vector3> _siblingClickScaleByTransform;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<Transform, Vector3> _siblingHoverScaleByTransform;

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x7313C8", Offset = "0x7313C8", VA = "0x7313C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x73167C", Offset = "0x73167C", VA = "0x73167C")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x731A6C", Offset = "0x731A6C", VA = "0x731A6C")]
		private void OnClick()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x731B00", Offset = "0x731B00", VA = "0x731B00")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x731D3C", Offset = "0x731D3C", VA = "0x731D3C")]
		public ButtonClicker()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x58BB24", Offset = "0x58BB24")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x58BB24", Offset = "0x58BB24")]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x200008B")]
		public enum UnityUIVersion
		{
			[Token(Token = "0x40004F3")]
			Legacy,
			[Token(Token = "0x40004F4")]
			uGUI
		}

		[Token(Token = "0x200008C")]
		public enum EventType
		{
			[Token(Token = "0x40004F6")]
			OnStart,
			[Token(Token = "0x40004F7")]
			OnVisible,
			[Token(Token = "0x40004F8")]
			OnInvisible,
			[Token(Token = "0x40004F9")]
			OnCollision,
			[Token(Token = "0x40004FA")]
			OnTriggerEnter,
			[Token(Token = "0x40004FB")]
			OnTriggerExit,
			[Token(Token = "0x40004FC")]
			OnMouseEnter,
			[Token(Token = "0x40004FD")]
			OnMouseClick,
			[Token(Token = "0x40004FE")]
			OnSpawned,
			[Token(Token = "0x40004FF")]
			OnDespawned,
			[Token(Token = "0x4000500")]
			OnEnable,
			[Token(Token = "0x4000501")]
			OnDisable,
			[Token(Token = "0x4000502")]
			OnCollision2D,
			[Token(Token = "0x4000503")]
			OnTriggerEnter2D,
			[Token(Token = "0x4000504")]
			OnTriggerExit2D,
			[Token(Token = "0x4000505")]
			OnParticleCollision,
			[Token(Token = "0x4000506")]
			UserDefinedEvent,
			[Token(Token = "0x4000507")]
			OnCollisionExit,
			[Token(Token = "0x4000508")]
			OnCollisionExit2D,
			[Token(Token = "0x4000509")]
			OnMouseUp,
			[Token(Token = "0x400050A")]
			OnMouseExit,
			[Token(Token = "0x400050B")]
			OnMouseDrag,
			[Token(Token = "0x400050C")]
			NGUIOnClick,
			[Token(Token = "0x400050D")]
			NGUIMouseDown,
			[Token(Token = "0x400050E")]
			NGUIMouseUp,
			[Token(Token = "0x400050F")]
			NGUIMouseEnter,
			[Token(Token = "0x4000510")]
			NGUIMouseExit,
			[Token(Token = "0x4000511")]
			MechanimStateChanged,
			[Token(Token = "0x4000512")]
			UnitySliderChanged,
			[Token(Token = "0x4000513")]
			UnityButtonClicked,
			[Token(Token = "0x4000514")]
			UnityPointerDown,
			[Token(Token = "0x4000515")]
			UnityPointerUp,
			[Token(Token = "0x4000516")]
			UnityPointerEnter,
			[Token(Token = "0x4000517")]
			UnityPointerExit,
			[Token(Token = "0x4000518")]
			UnityDrag,
			[Token(Token = "0x4000519")]
			UnityDrop,
			[Token(Token = "0x400051A")]
			UnityScroll,
			[Token(Token = "0x400051B")]
			UnityUpdateSelected,
			[Token(Token = "0x400051C")]
			UnitySelect,
			[Token(Token = "0x400051D")]
			UnityDeselect,
			[Token(Token = "0x400051E")]
			UnityMove,
			[Token(Token = "0x400051F")]
			UnityInitializePotentialDrag,
			[Token(Token = "0x4000520")]
			UnityBeginDrag,
			[Token(Token = "0x4000521")]
			UnityEndDrag,
			[Token(Token = "0x4000522")]
			UnitySubmit,
			[Token(Token = "0x4000523")]
			UnityCancel,
			[Token(Token = "0x4000524")]
			UnityToggle
		}

		[Token(Token = "0x200008D")]
		public enum VariationType
		{
			[Token(Token = "0x4000526")]
			PlaySpecific,
			[Token(Token = "0x4000527")]
			PlayRandom
		}

		[Token(Token = "0x200008E")]
		public enum PreviousSoundStopMode
		{
			[Token(Token = "0x4000529")]
			None,
			[Token(Token = "0x400052A")]
			Stop,
			[Token(Token = "0x400052B")]
			FadeOut
		}

		[Token(Token = "0x200008F")]
		public enum RetriggerLimMode
		{
			[Token(Token = "0x400052D")]
			None,
			[Token(Token = "0x400052E")]
			FrameBased,
			[Token(Token = "0x400052F")]
			TimeBased
		}

		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BD30", Offset = "0x58BD30")]
		private sealed class <CoUpdate>d__116 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EventSounds <>4__this;

			[Token(Token = "0x17000154")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600079C")]
				[Address(RVA = "0x741298", Offset = "0x741298", VA = "0x741298", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000155")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600079E")]
				[Address(RVA = "0x741300", Offset = "0x741300", VA = "0x741300", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x736E4C", Offset = "0x736E4C", VA = "0x736E4C")]
			[DebuggerHidden]
			public <CoUpdate>d__116(int <>1__state)
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x741118", Offset = "0x741118", VA = "0x741118", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x74111C", Offset = "0x74111C", VA = "0x74111C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x7412A0", Offset = "0x7412A0", VA = "0x7412A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool showGizmo;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableSounds;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool showPoolManager;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool showNGUI;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public UnityUIVersion unityUIMode;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool logMissingEvents;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> LayerTagFilterEvents;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<MasterAudio.PlaylistCommand> PlaylistCommandsWithAll;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEventGroup startSound;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioEventGroup visibleSound;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioEventGroup invisibleSound;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioEventGroup collisionSound;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioEventGroup collisionExitSound;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioEventGroup triggerSound;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioEventGroup triggerExitSound;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioEventGroup mouseEnterSound;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioEventGroup mouseExitSound;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioEventGroup mouseClickSound;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AudioEventGroup mouseUpSound;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AudioEventGroup mouseDragSound;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AudioEventGroup spawnedSound;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioEventGroup despawnedSound;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AudioEventGroup enableSound;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AudioEventGroup disableSound;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AudioEventGroup collision2dSound;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AudioEventGroup collisionExit2dSound;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AudioEventGroup triggerEnter2dSound;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public AudioEventGroup triggerExit2dSound;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AudioEventGroup particleCollisionSound;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AudioEventGroup nguiOnClickSound;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AudioEventGroup nguiMouseDownSound;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioEventGroup nguiMouseUpSound;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AudioEventGroup nguiMouseEnterSound;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public AudioEventGroup nguiMouseExitSound;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public AudioEventGroup unitySliderChangedSound;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public AudioEventGroup unityButtonClickedSound;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public AudioEventGroup unityPointerDownSound;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AudioEventGroup unityDragSound;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public AudioEventGroup unityPointerUpSound;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public AudioEventGroup unityPointerEnterSound;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AudioEventGroup unityPointerExitSound;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioEventGroup unityDropSound;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioEventGroup unityScrollSound;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public AudioEventGroup unityUpdateSelectedSound;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public AudioEventGroup unitySelectSound;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public AudioEventGroup unityDeselectSound;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public AudioEventGroup unityMoveSound;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public AudioEventGroup unityInitializePotentialDragSound;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public AudioEventGroup unityBeginDragSound;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public AudioEventGroup unityEndDragSound;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public AudioEventGroup unitySubmitSound;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public AudioEventGroup unityCancelSound;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public AudioEventGroup unityToggleSound;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public List<AudioEventGroup> userDefinedSounds;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public List<AudioEventGroup> mechanimStateChangedSounds;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public bool useStartSound;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A9")]
		public bool useVisibleSound;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AA")]
		public bool useInvisibleSound;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AB")]
		public bool useCollisionSound;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public bool useCollisionExitSound;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AD")]
		public bool useTriggerEnterSound;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AE")]
		public bool useTriggerExitSound;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AF")]
		public bool useMouseEnterSound;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public bool useMouseExitSound;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B1")]
		public bool useMouseClickSound;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B2")]
		public bool useMouseUpSound;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B3")]
		public bool useMouseDragSound;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		public bool useSpawnedSound;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B5")]
		public bool useDespawnedSound;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B6")]
		public bool useEnableSound;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B7")]
		public bool useDisableSound;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public bool useCollision2dSound;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		public bool useCollisionExit2dSound;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		public bool useTriggerEnter2dSound;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BB")]
		public bool useTriggerExit2dSound;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public bool useParticleCollisionSound;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
		public bool useNguiOnClickSound;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BE")]
		public bool useNguiMouseDownSound;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BF")]
		public bool useNguiMouseUpSound;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public bool useNguiMouseEnterSound;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C1")]
		public bool useNguiMouseExitSound;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C2")]
		public bool useUnitySliderChangedSound;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C3")]
		public bool useUnityButtonClickedSound;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public bool useUnityPointerDownSound;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C5")]
		public bool useUnityDragSound;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C6")]
		public bool useUnityPointerUpSound;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C7")]
		public bool useUnityPointerEnterSound;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public bool useUnityPointerExitSound;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		public bool useUnityDropSound;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		public bool useUnityScrollSound;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CB")]
		public bool useUnityUpdateSelectedSound;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool useUnitySelectSound;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CD")]
		public bool useUnityDeselectSound;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CE")]
		public bool useUnityMoveSound;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CF")]
		public bool useUnityInitializePotentialDragSound;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool useUnityBeginDragSound;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		public bool useUnityEndDragSound;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		public bool useUnitySubmitSound;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		public bool useUnityCancelSound;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool useUnityToggleSound;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Slider _slider;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Toggle _toggle;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Button _button;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private bool _isVisible;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
		private bool _needsCoroutine;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Transform _trans;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly List<AudioEventGroup> _validMechanimStateChangedSounds;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Animator _anim;

		[Token(Token = "0x170000B7")]
		private bool IsSetToUGUI
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x736ADC", Offset = "0x736ADC", VA = "0x736ADC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B8")]
		private bool IsSetToLegacyUI
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x738728", Offset = "0x738728", VA = "0x738728")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x736A10", Offset = "0x736A10", VA = "0x736A10")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x736CA8", Offset = "0x736CA8", VA = "0x736CA8", Slot = "10")]
		protected virtual void SpawnedOrAwake()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x736DDC", Offset = "0x736DDC", VA = "0x736DDC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58CB24", Offset = "0x58CB24")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x736E78", Offset = "0x736E78", VA = "0x736E78")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x7374EC", Offset = "0x7374EC", VA = "0x7374EC")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x737514", Offset = "0x737514", VA = "0x737514")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x737530", Offset = "0x737530", VA = "0x737530")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x737800", Offset = "0x737800", VA = "0x737800")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x737B08", Offset = "0x737B08", VA = "0x737B08")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x737C1C", Offset = "0x737C1C", VA = "0x737C1C")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x737D30", Offset = "0x737D30", VA = "0x737D30")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x737E44", Offset = "0x737E44", VA = "0x737E44")]
		private void OnCollisionExit2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x737F58", Offset = "0x737F58", VA = "0x737F58")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x73806C", Offset = "0x73806C", VA = "0x73806C")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x738180", Offset = "0x738180", VA = "0x738180")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x738294", Offset = "0x738294", VA = "0x738294")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x7383A8", Offset = "0x7383A8", VA = "0x7383A8")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x7384BC", Offset = "0x7384BC", VA = "0x7384BC")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x7384DC", Offset = "0x7384DC", VA = "0x7384DC")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x7384FC", Offset = "0x7384FC", VA = "0x7384FC")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x73851C", Offset = "0x73851C", VA = "0x73851C")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x73853C", Offset = "0x73853C", VA = "0x73853C")]
		private void OnDrag(Vector2 delta)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x738540", Offset = "0x738540", VA = "0x738540")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x738560", Offset = "0x738560", VA = "0x738560")]
		private void OnDrop(GameObject go)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x738564", Offset = "0x738564", VA = "0x738564")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x738584", Offset = "0x738584", VA = "0x738584")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x7385A4", Offset = "0x7385A4", VA = "0x7385A4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x7385C4", Offset = "0x7385C4", VA = "0x7385C4")]
		private void OnSelect(bool isSelected)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x7385C8", Offset = "0x7385C8", VA = "0x7385C8")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x7385E8", Offset = "0x7385E8", VA = "0x7385E8")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x738608", Offset = "0x738608", VA = "0x738608")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x738628", Offset = "0x738628", VA = "0x738628")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x738648", Offset = "0x738648", VA = "0x738648")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x738668", Offset = "0x738668", VA = "0x738668")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x738688", Offset = "0x738688", VA = "0x738688")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x7386A8", Offset = "0x7386A8", VA = "0x7386A8")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x7386C8", Offset = "0x7386C8", VA = "0x7386C8")]
		private void SliderChanged(float newValue)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x7386F8", Offset = "0x7386F8", VA = "0x7386F8")]
		private void ToggleChanged(bool newValue)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x738710", Offset = "0x738710", VA = "0x738710")]
		private void ButtonClicked()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x738738", Offset = "0x738738", VA = "0x738738")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x738770", Offset = "0x738770", VA = "0x738770")]
		private void OnClick()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x738790", Offset = "0x738790", VA = "0x738790")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x7387C8", Offset = "0x7387C8", VA = "0x7387C8")]
		private void OnSpawned()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x738818", Offset = "0x738818", VA = "0x738818")]
		private void OnDespawned()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x738838", Offset = "0x738838", VA = "0x738838")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x7388BC", Offset = "0x7388BC", VA = "0x7388BC")]
		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x7372C0", Offset = "0x7372C0", VA = "0x7372C0")]
		public void PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x7389C0", Offset = "0x7389C0", VA = "0x7389C0")]
		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x73FFD8", Offset = "0x73FFD8", VA = "0x73FFD8")]
		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x736EB8", Offset = "0x736EB8", VA = "0x736EB8", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x7403B0", Offset = "0x7403B0", VA = "0x7403B0", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x740484", Offset = "0x740484", VA = "0x740484", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x737770", Offset = "0x737770", VA = "0x737770", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x737A80", Offset = "0x737A80", VA = "0x737A80", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x740BD0", Offset = "0x740BD0", VA = "0x740BD0", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x736AEC", Offset = "0x736AEC", VA = "0x736AEC")]
		private void AddUGUIComponents()
		{
		}

		[Token(Token = "0x60004E1")]
		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x740C28", Offset = "0x740C28", VA = "0x740C28")]
		public EventSounds()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C1B0", Offset = "0x58C1B0")]
		private EventSounds <eventSounds>k__BackingField;

		[Token(Token = "0x170000B9")]
		public EventSounds eventSounds
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x741D60", Offset = "0x741D60", VA = "0x741D60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CB88", Offset = "0x58CB88")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x741D68", Offset = "0x741D68", VA = "0x741D68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CB98", Offset = "0x58CB98")]
			set
			{
			}
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x7413B8", Offset = "0x7413B8", VA = "0x7413B8")]
		public EventSoundsUGUIHandler()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x741940", Offset = "0x741940", VA = "0x741940", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x7419E8", Offset = "0x7419E8", VA = "0x7419E8")]
		public EventSoundsPointerEnterHandler()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x7419F0", Offset = "0x7419F0", VA = "0x7419F0", Slot = "4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x741A98", Offset = "0x741A98", VA = "0x741A98")]
		public EventSoundsPointerExitHandler()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x741890", Offset = "0x741890", VA = "0x741890", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x741938", Offset = "0x741938", VA = "0x741938")]
		public EventSoundsPointerDownHandler()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x741AA0", Offset = "0x741AA0", VA = "0x741AA0", Slot = "4")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x741B48", Offset = "0x741B48", VA = "0x741B48")]
		public EventSoundsPointerUpHandler()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x741520", Offset = "0x741520", VA = "0x741520", Slot = "4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x7415C8", Offset = "0x7415C8", VA = "0x7415C8")]
		public EventSoundsDragHandler()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x7415D0", Offset = "0x7415D0", VA = "0x7415D0", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x741678", Offset = "0x741678", VA = "0x741678")]
		public EventSoundsDropHandler()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x741B50", Offset = "0x741B50", VA = "0x741B50", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x741BF8", Offset = "0x741BF8", VA = "0x741BF8")]
		public EventSoundsScrollHandler()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x741D70", Offset = "0x741D70", VA = "0x741D70", Slot = "4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x741E18", Offset = "0x741E18", VA = "0x741E18")]
		public EventSoundsUpdateSelectedHandler()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x741C00", Offset = "0x741C00", VA = "0x741C00", Slot = "4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x741CA8", Offset = "0x741CA8", VA = "0x741CA8")]
		public EventSoundsSelectHandler()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x741470", Offset = "0x741470", VA = "0x741470", Slot = "4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x741518", Offset = "0x741518", VA = "0x741518")]
		public EventSoundsDeselectHandler()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x7417E0", Offset = "0x7417E0", VA = "0x7417E0", Slot = "4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x741888", Offset = "0x741888", VA = "0x741888")]
		public EventSoundsMoveHandler()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x741730", Offset = "0x741730", VA = "0x741730", Slot = "4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x7417D8", Offset = "0x7417D8", VA = "0x7417D8")]
		public EventSoundsInitializePotentialDragHandler()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x741308", Offset = "0x741308", VA = "0x741308", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x7413B0", Offset = "0x7413B0", VA = "0x7413B0")]
		public EventSoundsBeginDragHandler()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x741680", Offset = "0x741680", VA = "0x741680", Slot = "4")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x741728", Offset = "0x741728", VA = "0x741728")]
		public EventSoundsEndDragHandler()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x741CB0", Offset = "0x741CB0", VA = "0x741CB0", Slot = "4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x741D58", Offset = "0x741D58", VA = "0x741D58")]
		public EventSoundsSubmitHandler()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x7413C0", Offset = "0x7413C0", VA = "0x7413C0", Slot = "4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x741468", Offset = "0x741468", VA = "0x741468")]
		public EventSoundsCancelHandler()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x58BB74", Offset = "0x58BB74")]
	public class FootstepSounds : MonoBehaviour
	{
		[Token(Token = "0x2000091")]
		public enum FootstepTriggerMode
		{
			[Token(Token = "0x4000534")]
			None,
			[Token(Token = "0x4000535")]
			OnCollision,
			[Token(Token = "0x4000536")]
			OnTriggerEnter,
			[Token(Token = "0x4000537")]
			OnCollision2D,
			[Token(Token = "0x4000538")]
			OnTriggerEnter2D
		}

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public FootstepTriggerMode footstepEvent;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FootstepGroup> footstepGroups;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int limitPerXFrm;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float limitPerXSec;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int triggeredLastFrame;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float triggeredLastTime;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _trans;

		[Token(Token = "0x170000BA")]
		private Transform Trans
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x7423EC", Offset = "0x7423EC", VA = "0x7423EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x741F40", Offset = "0x741F40", VA = "0x741F40")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x74226C", Offset = "0x74226C", VA = "0x74226C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x7422BC", Offset = "0x7422BC", VA = "0x7422BC")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x74230C", Offset = "0x74230C", VA = "0x74230C")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x74235C", Offset = "0x74235C", VA = "0x74235C")]
		private bool CheckForRetriggerLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x741F90", Offset = "0x741F90", VA = "0x741F90")]
		private void PlaySoundsIfMatch(GameObject go)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x74247C", Offset = "0x74247C", VA = "0x74247C")]
		public FootstepSounds()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[MasterCustomEvent]
		public string enterCustomEvent;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MasterCustomEvent]
		public string exitCustomEvent;

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xB4E450", Offset = "0xB4E450", VA = "0xB4E450", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xB4E514", Offset = "0xB4E514", VA = "0xB4E514", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xB4E5D8", Offset = "0xB4E5D8", VA = "0xB4E5D8")]
		public MechanimStateCustomEvents()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool SoundFollowsObject;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SoundGroup]
		public string enterSoundGroup;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SoundGroup]
		public string exitSoundGroup;

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xB4E5E0", Offset = "0xB4E5E0", VA = "0xB4E5E0", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xB4E6D0", Offset = "0xB4E6D0", VA = "0xB4E6D0", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xB4E7C0", Offset = "0xB4E7C0", VA = "0xB4E7C0")]
		public MechanimStateSounds()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[SerializeField]
	public class PlaySoundResult
	{
		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C200", Offset = "0x58C200")]
		private bool <SoundPlayed>k__BackingField;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C210", Offset = "0x58C210")]
		private bool <SoundScheduled>k__BackingField;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C220", Offset = "0x58C220")]
		private SoundGroupVariation <ActingVariation>k__BackingField;

		[Token(Token = "0x170000BB")]
		public bool SoundPlayed
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0xB4F8C8", Offset = "0xB4F8C8", VA = "0xB4F8C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CBA8", Offset = "0x58CBA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000517")]
			[Address(RVA = "0xB4F8D0", Offset = "0xB4F8D0", VA = "0xB4F8D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CBB8", Offset = "0x58CBB8")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public bool SoundScheduled
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0xB4F8DC", Offset = "0xB4F8DC", VA = "0xB4F8DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CBC8", Offset = "0x58CBC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000519")]
			[Address(RVA = "0xB4F8E4", Offset = "0xB4F8E4", VA = "0xB4F8E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CBD8", Offset = "0x58CBD8")]
			set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public SoundGroupVariation ActingVariation
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0xB4F8F0", Offset = "0xB4F8F0", VA = "0xB4F8F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CBE8", Offset = "0x58CBE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051B")]
			[Address(RVA = "0xB4F8F8", Offset = "0xB4F8F8", VA = "0xB4F8F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CBF8", Offset = "0x58CBF8")]
			set
			{
			}
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xB4F89C", Offset = "0xB4F89C", VA = "0xB4F89C")]
		public PlaySoundResult()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class AudioEvent
	{
		[Token(Token = "0x2000092")]
		public enum TargetVolumeMode
		{
			[Token(Token = "0x400053A")]
			UseSliderValue,
			[Token(Token = "0x400053B")]
			UseSpecificValue
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public class MA_SnapshotInfo
		{
			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixerSnapshot snapshot;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x72D0FC", Offset = "0x72D0FC", VA = "0x72D0FC")]
			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
			}
		}

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actionName;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isExpanded;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string soundType;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allPlaylistControllersForGroupCmd;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool allSoundTypesForGroupCmd;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool allSoundTypesForBusCmd;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float volume;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useFixedPitch;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float pitch;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float delaySound;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudio.BusCommand currentBusCommand;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.GlobalCommand currentGlobalCommand;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MasterAudio.UnityMixerCommand currentMixerCommand;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioMixerSnapshot snapshotToTransitionTo;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float snapshotTransitionTime;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<MA_SnapshotInfo> snapshotsToBlend;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string busName;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string playlistName;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string playlistControllerName;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool startPlaylist;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float fadeVolume;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float fadeTime;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public TargetVolumeMode targetVolMode;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string clipName;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string variationName;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string theCustomEventName;

		[Token(Token = "0x170000BE")]
		public bool IsFadeCommand
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x72CF34", Offset = "0x72CF34", VA = "0x72CF34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x72CF9C", Offset = "0x72CF9C", VA = "0x72CF9C")]
		public AudioEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class AudioEventGroup
	{
		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool customSoundActive;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isCustomEvent;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string customEventName;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool mechanimEventActive;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isMechanimStateCheckEvent;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mechanimStateName;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mechEventPlayedForState;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<AudioEvent> SoundEvents;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float mouseDragFadeOutTime;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int limitPerXFrm;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float limitPerXSec;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int triggeredLastFrame;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float triggeredLastTime;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float sliderValue;

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x72D138", Offset = "0x72D138", VA = "0x72D138")]
		public AudioEventGroup()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class AudioScriptOrder : Attribute
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Order;

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x730E84", Offset = "0x730E84", VA = "0x730E84")]
		public AudioScriptOrder(int order)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class BusFadeInfo
	{
		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GroupBus ActingBus;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TargetVolume;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float VolumeStep;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action completionAction;

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x7313B8", Offset = "0x7313B8", VA = "0x7313B8")]
		public BusFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class CustomEvent
	{
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ProspectiveName;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool eventExpanded;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float distanceThreshold;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int frameLastFired;

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x731FFC", Offset = "0x731FFC", VA = "0x731FFC")]
		public CustomEvent(string eventName)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class DuckGroupInfo
	{
		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundType;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float riseVolStart;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unduckTime;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duckedVolumeCut;

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x7324DC", Offset = "0x7324DC", VA = "0x7324DC")]
		public DuckGroupInfo()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool useLocalization;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool useRandomPitch;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float randomPitchMin;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float randomPitchMax;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool useRandomVolume;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float randomVolumeMin;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float randomVolumeMax;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int weight;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string resourceFileName;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string internetFileUrl;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isExpanded;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool isChecked;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float fxTailTime;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool useFades;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float fadeInTime;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float fadeOutTime;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool useIntroSilence;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float introSilenceMin;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float introSilenceMax;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useRandomStartTime;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float randomStartMinPercent;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float randomStartMaxPercent;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private DynamicSoundGroup _parentGroupScript;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Transform _trans;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioSource _aud;

		[Token(Token = "0x170000BF")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x732548", Offset = "0x732548", VA = "0x732548")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x7325E0", Offset = "0x7325E0", VA = "0x7325E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x732678", Offset = "0x732678", VA = "0x732678")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x732710", Offset = "0x732710", VA = "0x732710")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x7327A8", Offset = "0x7327A8", VA = "0x7327A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x732840", Offset = "0x732840", VA = "0x732840")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public DynamicSoundGroup ParentGroup
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x7328D8", Offset = "0x7328D8", VA = "0x7328D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public Transform Trans
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x732A2C", Offset = "0x732A2C", VA = "0x732A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x732ABC", Offset = "0x732ABC", VA = "0x732ABC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C8")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x732D14", Offset = "0x732D14", VA = "0x732D14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x732DAC", Offset = "0x732DAC", VA = "0x732DAC")]
		public DynamicGroupVariation()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class DynamicSoundGroup : MonoBehaviour
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject variationTemplate;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float groupMasterVolume;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int retriggerPercentage;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudioGroup.VariationSequence curVariationSequence;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudioGroup.VariationMode curVariationMode;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float chainLoopDelayMin;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMax;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chainLoopNumLoops;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useDialogFadeOut;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dialogFadeOutTime;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool logSound;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int busIndex;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float spatialBlend;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string busName;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool isExistingBus;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool isCopiedFromDGSC;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public MasterAudioGroup.LimitMode limitMode;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int limitPerXFrames;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float minimumTimeBetween;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool limitPolyphony;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int voiceLimitCount;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float despawnFadeTime;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool copySettingsExpanded;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int selectedVariationIndex;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public MasterAudioGroup.ChildGroupMode childGroupMode;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public List<string> childSoundGroups;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public List<DynamicGroupVariation> groupVariations;

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x732DC4", Offset = "0x732DC4", VA = "0x732DC4")]
		public DynamicSoundGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class FootstepGroup
	{
		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundType;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string variationName;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float volume;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useFixedPitch;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitch;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float delaySound;

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x741E20", Offset = "0x741E20", VA = "0x741E20")]
		public FootstepGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class GroupBus
	{
		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string busName;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isSoloed;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool isMuted;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int voiceLimit;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool stopOldest;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExisting;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isUsingOcclusion;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool forceTo2D;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<int> _activeAudioSourcesIds;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _originalVolume;

		[Token(Token = "0x170000C9")]
		public int ActiveVoices
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x742604", Offset = "0x742604", VA = "0x742604")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CA")]
		public bool BusVoiceLimitReached
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x742654", Offset = "0x742654", VA = "0x742654")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CB")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x7426C0", Offset = "0x7426C0", VA = "0x7426C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x7426C8", Offset = "0x7426C8", VA = "0x7426C8")]
			set
			{
			}
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x742504", Offset = "0x742504", VA = "0x742504")]
		public void AddActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x74259C", Offset = "0x74259C", VA = "0x74259C")]
		public void RemoveActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x7426D0", Offset = "0x7426D0", VA = "0x7426D0")]
		public GroupBus()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class GroupFadeInfo
	{
		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TargetVolume;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float VolumeStep;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action completionAction;

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x742760", Offset = "0x742760", VA = "0x742760")]
		public GroupFadeInfo()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public interface ICustomEventReceiver
	{
		[Token(Token = "0x6000538")]
		void CheckForIllegalCustomEvents();

		[Token(Token = "0x6000539")]
		void ReceiveEvent(string customEventName, Vector3 originPoint);

		[Token(Token = "0x600053A")]
		bool SubscribesToEvent(string customEventName);

		[Token(Token = "0x600053B")]
		void RegisterReceiver();

		[Token(Token = "0x600053C")]
		void UnregisterReceiver();

		[Token(Token = "0x600053D")]
		IList<AudioEventGroup> GetAllEvents();
	}
	[Token(Token = "0x2000067")]
	public class MasterAudioGroup : MonoBehaviour
	{
		[Token(Token = "0x2000094")]
		public enum ChildGroupMode
		{
			[Token(Token = "0x400053F")]
			None,
			[Token(Token = "0x4000540")]
			TriggerLinkedGroupsWhenRequested,
			[Token(Token = "0x4000541")]
			TriggerLinkedGroupsWhenPlayed
		}

		[Token(Token = "0x2000095")]
		public enum TargetDespawnedBehavior
		{
			[Token(Token = "0x4000543")]
			None,
			[Token(Token = "0x4000544")]
			Stop,
			[Token(Token = "0x4000545")]
			FadeOut
		}

		[Token(Token = "0x2000096")]
		public enum VariationSequence
		{
			[Token(Token = "0x4000547")]
			Randomized,
			[Token(Token = "0x4000548")]
			TopToBottom
		}

		[Token(Token = "0x2000097")]
		public enum VariationMode
		{
			[Token(Token = "0x400054A")]
			Normal,
			[Token(Token = "0x400054B")]
			LoopedChain,
			[Token(Token = "0x400054C")]
			Dialog
		}

		[Token(Token = "0x2000098")]
		public enum ChainedLoopLoopMode
		{
			[Token(Token = "0x400054E")]
			Endless,
			[Token(Token = "0x400054F")]
			NumberOfLoops
		}

		[Token(Token = "0x2000099")]
		public enum LimitMode
		{
			[Token(Token = "0x4000551")]
			None,
			[Token(Token = "0x4000552")]
			FrameBased,
			[Token(Token = "0x4000553")]
			TimeBased
		}

		[Token(Token = "0x4000315")]
		public const float UseCurveSpatialBlend = -99f;

		[Token(Token = "0x4000316")]
		public const string NoBus = "[NO BUS]";

		[Token(Token = "0x4000317")]
		public const int MinNoRepeatVariations = 3;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int busIndex;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spatialBlend;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isSelected;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExpanded;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float groupMasterVolume;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int retriggerPercentage;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VariationMode curVariationMode;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float chainLoopDelayMin;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float chainLoopDelayMax;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int chainLoopNumLoops;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool useDialogFadeOut;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float dialogFadeOutTime;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public VariationSequence curVariationSequence;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupVariation> groupVariations;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		public bool logSound;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		public bool copySettingsExpanded;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int selectedVariationIndex;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public ChildGroupMode childGroupMode;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<string> childSoundGroups;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public LimitMode limitMode;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public int limitPerXFrames;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float minimumTimeBetween;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		public bool limitPolyphony;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int voiceLimitCount;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float despawnFadeTime;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool isUsingOcclusion;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		public bool isSoloed;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E")]
		public bool isMuted;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9F")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<int> _activeAudioSourcesIds;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string _objectName;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Transform _trans;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int _childCount;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float _originalVolume;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int frames;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C230", Offset = "0x58C230")]
		private int <ChainLoopCount>k__BackingField;

		[Token(Token = "0x170000CC")]
		public MasterAudio.InternetFileLoadStatus GroupLoadStatus
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0xB4D9B8", Offset = "0xB4D9B8", VA = "0xB4D9B8")]
			get
			{
				return default(MasterAudio.InternetFileLoadStatus);
			}
		}

		[Token(Token = "0x170000CD")]
		public float SpatialBlendForGroup
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0xB4E11C", Offset = "0xB4E11C", VA = "0xB4E11C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CE")]
		public int ActiveVoices
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0xB4E20C", Offset = "0xB4E20C", VA = "0xB4E20C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CF")]
		public int TotalVoices
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0xB4E260", Offset = "0xB4E260", VA = "0xB4E260")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D0")]
		public GroupBus BusForGroup
		{
			[Token(Token = "0x6000546")]
			[Address(RVA = "0xB4DFB0", Offset = "0xB4DFB0", VA = "0xB4DFB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0xB4E284", Offset = "0xB4E284", VA = "0xB4E284")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000548")]
			[Address(RVA = "0xB4E28C", Offset = "0xB4E28C", VA = "0xB4E28C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public int ChainLoopCount
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0xB4E294", Offset = "0xB4E294", VA = "0xB4E294")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CC08", Offset = "0x58CC08")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600054A")]
			[Address(RVA = "0xB4E29C", Offset = "0xB4E29C", VA = "0xB4E29C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CC18", Offset = "0x58CC18")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public string GameObjectName
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0xB4DD88", Offset = "0xB4DD88", VA = "0xB4DD88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		public bool UsesNoRepeat
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0xB4E2A4", Offset = "0xB4E2A4", VA = "0xB4E2A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D5")]
		private Transform Trans
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0xB4DA90", Offset = "0xB4DA90", VA = "0xB4DA90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		private List<int> ActiveAudioSourceIds
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0xB4DCE8", Offset = "0xB4DCE8", VA = "0xB4DCE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xB4DB20", Offset = "0xB4DB20", VA = "0xB4DB20")]
		private void Start()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xB4DDCC", Offset = "0xB4DDCC", VA = "0xB4DDCC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xB4DEF8", Offset = "0xB4DEF8", VA = "0xB4DEF8")]
		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xB4E088", Offset = "0xB4E088", VA = "0xB4E088")]
		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xB4E318", Offset = "0xB4E318", VA = "0xB4E318")]
		public MasterAudioGroup()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class MasterCustomEventAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000550")]
		[Address(RVA = "0xB4E448", Offset = "0xB4E448", VA = "0xB4E448")]
		public MasterCustomEventAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class MusicSetting
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string alias;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string songName;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string resourceFileName;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pitch;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isExpanded;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isLoop;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float customStartTime;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int lastKnownTimePoint;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int songIndex;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool songStartedEventExpanded;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string songStartedCustomEvent;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string songChangedCustomEvent;

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xB4E7C8", Offset = "0xB4E7C8", VA = "0xB4E7C8")]
		public MusicSetting()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xB4E870", Offset = "0xB4E870", VA = "0xB4E870")]
		public static MusicSetting Clone(MusicSetting mus)
		{
			return null;
		}
	}
	[Token(Token = "0x200006A")]
	public class SoundGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000553")]
		[Address(RVA = "0xB55C8C", Offset = "0xB55C8C", VA = "0xB55C8C")]
		public SoundGroupAttribute()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x58BBBC", Offset = "0x58BBBC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58BBBC", Offset = "0x58BBBC")]
	public class SoundGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x200009A")]
		public delegate void SoundFinishedEventHandler();

		[Token(Token = "0x200009B")]
		public class PlaySoundParams
		{
			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string SoundType;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VolumePercentage;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float? Pitch;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform SourceTrans;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool AttachToSource;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float DelaySoundTime;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool IsChainLoop;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool IsSingleSubscribedPlay;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float GroupCalcVolume;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool IsPlaying;

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0xB59768", Offset = "0xB59768", VA = "0xB59768")]
			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		[Token(Token = "0x200009C")]
		public enum FadeMode
		{
			[Token(Token = "0x400055F")]
			None,
			[Token(Token = "0x4000560")]
			FadeInOut,
			[Token(Token = "0x4000561")]
			FadeOutEarly,
			[Token(Token = "0x4000562")]
			GradualFade
		}

		[Token(Token = "0x200009D")]
		public enum RandomPitchMode
		{
			[Token(Token = "0x4000564")]
			AddToClipPitch,
			[Token(Token = "0x4000565")]
			IgnoreClipPitch
		}

		[Token(Token = "0x200009E")]
		public enum RandomVolumeMode
		{
			[Token(Token = "0x4000567")]
			AddToClipVolume,
			[Token(Token = "0x4000568")]
			IgnoreClipVolume
		}

		[Token(Token = "0x200009F")]
		public enum DetectEndMode
		{
			[Token(Token = "0x400056A")]
			None,
			[Token(Token = "0x400056B")]
			DetectEnd
		}

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int weight;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool useLocalization;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool useRandomPitch;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RandomPitchMode randomPitchMode;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float randomPitchMin;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMax;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool useRandomVolume;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float randomVolumeMin;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMax;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string resourceFileName;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string internetFileUrl;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.InternetFileLoadStatus internetFileLoadStatus;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float fxTailTime;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float original_pitch;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float original_volume;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool isExpanded;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool isChecked;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool useFades;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float fadeInTime;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float fadeOutTime;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool useRandomStartTime;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float randomStartMinPercent;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float randomStartMaxPercent;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool useIntroSilence;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float introSilenceMin;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float introSilenceMax;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float fadeMaxVolume;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public FadeMode curFadeMode;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public DetectEndMode curDetectEndMode;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int frames;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioSource _audioSource;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly PlaySoundParams _playSndParam;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool _isWaitingForDelay;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float _maxVol;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _instanceId;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private bool? _audioLoops;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private SoundGroupVariationUpdater _varUpdater;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _previousSoundFinishedFrame;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string _soundGroupName;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Transform _trans;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private GameObject _go;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private AudioSource _aud;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Transform _objectToFollow;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Transform _objectToTriggerFrom;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private MasterAudioGroup _parentGroupScript;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private bool _attachToSource;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private string _resFileName;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C250", Offset = "0x58C250")]
		private float <LastTimePlayed>k__BackingField;

		[Token(Token = "0x170000D7")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0xB58F3C", Offset = "0xB58F3C", VA = "0xB58F3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0xB58FD4", Offset = "0xB58FD4", VA = "0xB58FD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0xB5906C", Offset = "0xB5906C", VA = "0xB5906C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DA")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0xB59104", Offset = "0xB59104", VA = "0xB59104")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0xB56D24", Offset = "0xB56D24", VA = "0xB56D24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0xB5919C", Offset = "0xB5919C", VA = "0xB5919C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public Transform ObjectToFollow
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0xB59234", Offset = "0xB59234", VA = "0xB59234")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000576")]
			[Address(RVA = "0xB5923C", Offset = "0xB5923C", VA = "0xB5923C")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public Transform ObjectToTriggerFrom
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0xB59244", Offset = "0xB59244", VA = "0xB59244")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000578")]
			[Address(RVA = "0xB5924C", Offset = "0xB5924C", VA = "0xB5924C")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0xB59254", Offset = "0xB59254", VA = "0xB59254")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E0")]
		public MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0xB56354", Offset = "0xB56354", VA = "0xB56354")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E1")]
		public float OriginalPitch
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0xB57828", Offset = "0xB57828", VA = "0xB57828")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E2")]
		public float OriginalVolume
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0xB594AC", Offset = "0xB594AC", VA = "0xB594AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E3")]
		public string SoundGroupName
		{
			[Token(Token = "0x600057D")]
			[Address(RVA = "0xB594EC", Offset = "0xB594EC", VA = "0xB594EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		public bool IsAvailableToPlay
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0xB59528", Offset = "0xB59528", VA = "0xB59528")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E5")]
		public float LastTimePlayed
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0xB595C4", Offset = "0xB595C4", VA = "0xB595C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CC48", Offset = "0x58CC48")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000580")]
			[Address(RVA = "0xB595CC", Offset = "0xB595CC", VA = "0xB595CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CC58", Offset = "0x58CC58")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		private int InstanceId
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0xB57F6C", Offset = "0xB57F6C", VA = "0xB57F6C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E7")]
		public Transform Trans
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0xB58690", Offset = "0xB58690", VA = "0xB58690")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E8")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0xB562C4", Offset = "0xB562C4", VA = "0xB562C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E9")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0xB5622C", Offset = "0xB5622C", VA = "0xB5622C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EA")]
		public bool AudioLoops
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0xB57EC4", Offset = "0xB57EC4", VA = "0xB57EC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EB")]
		public string ResFileName
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0xB57BCC", Offset = "0xB57BCC", VA = "0xB57BCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EC")]
		public SoundGroupVariationUpdater VariationUpdater
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0xB569D4", Offset = "0xB569D4", VA = "0xB569D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		public bool IsWaitingForDelay
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0xB595D4", Offset = "0xB595D4", VA = "0xB595D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000589")]
			[Address(RVA = "0xB595DC", Offset = "0xB595DC", VA = "0xB595DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public PlaySoundParams PlaySoundParm
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0xB595E8", Offset = "0xB595E8", VA = "0xB595E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EF")]
		public bool IsPlaying
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0xB572A8", Offset = "0xB572A8", VA = "0xB572A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F0")]
		public float SetGroupVolume
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0xB595F0", Offset = "0xB595F0", VA = "0xB595F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600058D")]
			[Address(RVA = "0xB5960C", Offset = "0xB5960C", VA = "0xB5960C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		private bool Is2D
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0xB59628", Offset = "0xB59628", VA = "0xB59628")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F2")]
		private bool ShouldLoadAsync
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0xB57790", Offset = "0xB57790", VA = "0xB57790")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F3")]
		public bool UsesOcclusion
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0xB56BE4", Offset = "0xB56BE4", VA = "0xB56BE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000001")]
		public event SoundFinishedEventHandler SoundFinished
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0xB4D100", Offset = "0xB4D100", VA = "0xB4D100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CC28", Offset = "0x58CC28")]
			add
			{
			}
			[Token(Token = "0x6000555")]
			[Address(RVA = "0xB55EA8", Offset = "0xB55EA8", VA = "0xB55EA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CC38", Offset = "0x58CC38")]
			remove
			{
			}
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xB55F50", Offset = "0xB55F50", VA = "0xB55F50")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xB564F8", Offset = "0xB564F8", VA = "0xB564F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xB56730", Offset = "0xB56730", VA = "0xB56730")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xB56650", Offset = "0xB56650", VA = "0xB56650")]
		public void LoadInternetFile()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xB568E0", Offset = "0xB568E0", VA = "0xB568E0")]
		private void SetOcclusion()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xB56830", Offset = "0xB56830", VA = "0xB56830")]
		private void SetPriority()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xB56DBC", Offset = "0xB56DBC", VA = "0xB56DBC")]
		public void DisableUpdater()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xB56E64", Offset = "0xB56E64", VA = "0xB56E64")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xB56F34", Offset = "0xB56F34", VA = "0xB56F34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xB56E68", Offset = "0xB56E68", VA = "0xB56E68")]
		private void StopSoundEarly()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xB571E8", Offset = "0xB571E8", VA = "0xB571E8")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xB572C4", Offset = "0xB572C4", VA = "0xB572C4")]
		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xB57C6C", Offset = "0xB57C6C", VA = "0xB57C6C")]
		private void InternetFileFailedToLoad()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xB57C78", Offset = "0xB57C78", VA = "0xB57C78")]
		private void InternetFileLoaded()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xB57D48", Offset = "0xB57D48", VA = "0xB57D48")]
		private void ResourceFailedToLoad()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xB57868", Offset = "0xB57868", VA = "0xB57868")]
		private void FinishSetupToPlay()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xB581AC", Offset = "0xB581AC", VA = "0xB581AC")]
		public void JumpToTime(float timeToJumpTo)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xB581F8", Offset = "0xB581F8", VA = "0xB581F8")]
		public void AdjustVolume(float volumePercentage)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xB58270", Offset = "0xB58270", VA = "0xB58270")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xB583AC", Offset = "0xB583AC", VA = "0xB583AC")]
		private void MaybeUnloadClip()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xB56F38", Offset = "0xB56F38", VA = "0xB56F38")]
		public void Stop(bool stopEndDetection = false)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xB58720", Offset = "0xB58720", VA = "0xB58720")]
		public void FadeToVolume(float newVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xB58A58", Offset = "0xB58A58", VA = "0xB58A58")]
		public void FadeOutNow()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xB58D40", Offset = "0xB58D40", VA = "0xB58D40")]
		public void FadeOutNow(float fadeTime)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xB58E7C", Offset = "0xB58E7C", VA = "0xB58E7C")]
		public bool WasTriggeredFromTransform(Transform trans)
		{
			return default(bool);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xB59654", Offset = "0xB59654", VA = "0xB59654")]
		public void ClearSubscribers()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xB5965C", Offset = "0xB5965C", VA = "0xB5965C")]
		public SoundGroupVariation()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		[Token(Token = "0x20000A0")]
		private enum WaitForSoundFinishMode
		{
			[Token(Token = "0x400056D")]
			None,
			[Token(Token = "0x400056E")]
			Delay,
			[Token(Token = "0x400056F")]
			Play,
			[Token(Token = "0x4000570")]
			WaitForEnd,
			[Token(Token = "0x4000571")]
			StopOrRepeat,
			[Token(Token = "0x4000572")]
			FxTailWait
		}

		[Token(Token = "0x4000390")]
		private const float FakeNegativeFloatValue = -10f;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _objectToFollow;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _objectToFollowGo;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isFollowing;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SoundGroupVariation _variation;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _priorityLastUpdated;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _occlusionOnLastFrame;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _occlusionLastCalculated;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool _useClipAgePriority;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private WaitForSoundFinishMode _waitMode;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _soundPlayTime;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AudioSource _varAudio;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MasterAudioGroup _parentGrp;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform _trans;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _frameNum;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _fadeOutStartTime;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _fadeInOutWillFadeOut;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool _hasFadeInOutSetMaxVolume;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _fadeInOutInFactor;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _fadeInOutOutFactor;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _fadeOutEarlyTotalFrames;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float _fadeOutEarlyFrameVolChange;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int _fadeOutEarlyFrameNumber;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _fadeOutEarlyOrigVol;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _fadeToTargetFrameVolChange;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _fadeToTargetFrameNumber;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float _fadeToTargetOrigVol;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _fadeToTargetTotalFrames;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _fadeToTargetVolume;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _fadeOutStarted;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float _lastFrameClipTime;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float _fxTailEndTime;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool _isPlayingBackward;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool _hasStartedNextInChain;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _maCachedFromFrame;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MasterAudio _maThisFrame;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static int _listenerCachedFromFrame;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Transform _listenerThisFrame;

		[Token(Token = "0x170000F4")]
		public MasterAudio MAThisFrame
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xB5B3CC", Offset = "0xB5B3CC", VA = "0xB5B3CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F5")]
		private Transform Trans
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xB59D78", Offset = "0xB59D78", VA = "0xB59D78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F6")]
		private AudioSource VarAudio
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xB598DC", Offset = "0xB598DC", VA = "0xB598DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F7")]
		private MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xB59E10", Offset = "0xB59E10", VA = "0xB59E10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F8")]
		private SoundGroupVariation GrpVariation
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xB59844", Offset = "0xB59844", VA = "0xB59844")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xB588CC", Offset = "0xB588CC", VA = "0xB588CC")]
		public void FadeOverTimeToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xB58B8C", Offset = "0xB58B8C", VA = "0xB58B8C")]
		public void FadeOutEarly(float fadeTime)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xB57D50", Offset = "0xB57D50", VA = "0xB57D50")]
		public void FadeInOut()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xB580E0", Offset = "0xB580E0", VA = "0xB580E0")]
		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xB57FA0", Offset = "0xB57FA0", VA = "0xB57FA0")]
		public void WaitForSoundFinish(float delaySound)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xB58454", Offset = "0xB58454", VA = "0xB58454")]
		public void StopFading()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xB58378", Offset = "0xB58378", VA = "0xB58378")]
		public void StopWaitingForFinish()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xB58444", Offset = "0xB58444", VA = "0xB58444")]
		public void StopFollowing()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xB59D10", Offset = "0xB59D10", VA = "0xB59D10")]
		private void DisableIfFinished()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xB59974", Offset = "0xB59974", VA = "0xB59974")]
		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xB59EA8", Offset = "0xB59EA8", VA = "0xB59EA8")]
		private void ResetToNonOcclusionSetting()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xB59F58", Offset = "0xB59F58", VA = "0xB59F58")]
		private void UpdateOcclusion()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xB59AF0", Offset = "0xB59AF0", VA = "0xB59AF0")]
		private void PlaySoundAndWait()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xB5AB00", Offset = "0xB5AB00", VA = "0xB5AB00")]
		private void StopOrChain()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xB5AB98", Offset = "0xB5AB98", VA = "0xB5AB98")]
		private void MaybeChain()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xB5AE1C", Offset = "0xB5AE1C", VA = "0xB5AE1C")]
		private void PerformFading()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xB5B150", Offset = "0xB5B150", VA = "0xB5B150")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xB56A6C", Offset = "0xB56A6C", VA = "0xB56A6C")]
		public void UpdateCachedObjects()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xB5B160", Offset = "0xB5B160", VA = "0xB5B160")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xB5B434", Offset = "0xB5B434", VA = "0xB5B434")]
		public SoundGroupVariationUpdater()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public static class AudioPrioritizer
	{
		[Token(Token = "0x40003B6")]
		private const int MaxPriority = 0;

		[Token(Token = "0x40003B7")]
		private const int HighestPriority = 16;

		[Token(Token = "0x40003B8")]
		private const int LowestPriority = 128;

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x72D280", Offset = "0x72D280", VA = "0x72D280")]
		public static void Set2DSoundPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x72D29C", Offset = "0x72D29C", VA = "0x72D29C")]
		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x72D2B8", Offset = "0x72D2B8", VA = "0x72D2B8")]
		public static void SetPreviewPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x72D2D4", Offset = "0x72D2D4", VA = "0x72D2D4")]
		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
		}
	}
	[Token(Token = "0x200006E")]
	public static class AudioResourceOptimizer
	{
		[Token(Token = "0x20000A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BD40", Offset = "0x58BD40")]
		private sealed class <PopulateResourceSongToPlaylistControllerAsync>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string songResourceName;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string playlistName;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PlaylistController controller;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public PlaylistController.AudioPlayType playType;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x17000156")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007A8")]
				[Address(RVA = "0x72FF40", Offset = "0x72FF40", VA = "0x72FF40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000157")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007AA")]
				[Address(RVA = "0x72FFA8", Offset = "0x72FFA8", VA = "0x72FFA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x72EAB0", Offset = "0x72EAB0", VA = "0x72EAB0")]
			[DebuggerHidden]
			public <PopulateResourceSongToPlaylistControllerAsync>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x72FA98", Offset = "0x72FA98", VA = "0x72FA98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x72FA9C", Offset = "0x72FA9C", VA = "0x72FA9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x72FF48", Offset = "0x72FF48", VA = "0x72FF48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BD50", Offset = "0x58BD50")]
		private sealed class <PopulateSourceWithInternetFile>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string fileUrl;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SoundGroupVariation variation;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action failureAction;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private WWW <fileRequest>5__2;

			[Token(Token = "0x17000158")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007AF")]
				[Address(RVA = "0x730854", Offset = "0x730854", VA = "0x730854", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000159")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007B1")]
				[Address(RVA = "0x7308BC", Offset = "0x7308BC", VA = "0x7308BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x72EB6C", Offset = "0x72EB6C", VA = "0x72EB6C")]
			[DebuggerHidden]
			public <PopulateSourceWithInternetFile>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x72FFB0", Offset = "0x72FFB0", VA = "0x72FFB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x73008C", Offset = "0x73008C", VA = "0x73008C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x72FFCC", Offset = "0x72FFCC", VA = "0x72FFCC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x73085C", Offset = "0x73085C", VA = "0x73085C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BD60", Offset = "0x58BD60")]
		private sealed class <PopulateSourcesWithResourceClipAsync>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action failureAction;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public SoundGroupVariation variation;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x1700015A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007B5")]
				[Address(RVA = "0x730E14", Offset = "0x730E14", VA = "0x730E14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007B7")]
				[Address(RVA = "0x730E7C", Offset = "0x730E7C", VA = "0x730E7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x72EEF0", Offset = "0x72EEF0", VA = "0x72EEF0")]
			[DebuggerHidden]
			public <PopulateSourcesWithResourceClipAsync>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x7308C4", Offset = "0x7308C4", VA = "0x7308C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x7308C8", Offset = "0x7308C8", VA = "0x7308C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x730E1C", Offset = "0x730E1C", VA = "0x730E1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, AudioClip> AudioClipsByName;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly List<string> InternetFilesStartedLoading;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string _supportedLanguageFolder;

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x72D898", Offset = "0x72D898", VA = "0x72D898")]
		public static void ClearAudioClips()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x72D934", Offset = "0x72D934", VA = "0x72D934")]
		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x72DC6C", Offset = "0x72DC6C", VA = "0x72DC6C")]
		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x72DFC0", Offset = "0x72DFC0", VA = "0x72DFC0")]
		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x72DD08", Offset = "0x72DD08", VA = "0x72DD08")]
		private static string SupportedLanguageFolder()
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x72E3DC", Offset = "0x72E3DC", VA = "0x72E3DC")]
		public static void ClearSupportLanguageFolder()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x72E458", Offset = "0x72E458", VA = "0x72E458")]
		public static AudioClip PopulateResourceSongToPlaylistController(string controllerName, string songResourceName, string playlistName)
		{
			return null;
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x72E8BC", Offset = "0x72E8BC", VA = "0x72E8BC")]
		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x72EA1C", Offset = "0x72EA1C", VA = "0x72EA1C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58CC68", Offset = "0x58CC68")]
		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x72EADC", Offset = "0x72EADC", VA = "0x72EADC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58CCCC", Offset = "0x58CCCC")]
		public static IEnumerator PopulateSourceWithInternetFile(string fileUrl, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x72EB98", Offset = "0x72EB98", VA = "0x72EB98")]
		public static void RemoveLoadedInternetClip(string fileUrl)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x72EE60", Offset = "0x72EE60", VA = "0x72EE60")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58CD30", Offset = "0x58CD30")]
		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x72EF1C", Offset = "0x72EF1C", VA = "0x72EF1C")]
		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x72F088", Offset = "0x72F088", VA = "0x72F088")]
		public static bool PopulateSourcesWithResourceClip(string clipName, SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x72F548", Offset = "0x72F548", VA = "0x72F548")]
		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x72F6E8", Offset = "0x72F6E8", VA = "0x72F6E8")]
		public static void UnloadClipIfUnused(string clipName)
		{
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x58BC34", Offset = "0x58BC34")]
	public class MasterAudio : MonoBehaviour
	{
		[Token(Token = "0x20000A4")]
		public enum OcclusionSelectionType
		{
			[Token(Token = "0x4000589")]
			AllGroups,
			[Token(Token = "0x400058A")]
			TurnOnPerBusOrGroup
		}

		[Token(Token = "0x20000A5")]
		public enum RaycastMode
		{
			[Token(Token = "0x400058C")]
			Physics3D,
			[Token(Token = "0x400058D")]
			Physics2D
		}

		[Token(Token = "0x20000A6")]
		public enum AllMusicSpatialBlendType
		{
			[Token(Token = "0x400058F")]
			ForceAllTo2D,
			[Token(Token = "0x4000590")]
			ForceAllTo3D,
			[Token(Token = "0x4000591")]
			ForceAllToCustom,
			[Token(Token = "0x4000592")]
			AllowDifferentPerController
		}

		[Token(Token = "0x20000A7")]
		public enum AllMixerSpatialBlendType
		{
			[Token(Token = "0x4000594")]
			ForceAllTo2D,
			[Token(Token = "0x4000595")]
			ForceAllTo3D,
			[Token(Token = "0x4000596")]
			ForceAllToCustom,
			[Token(Token = "0x4000597")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x20000A8")]
		public enum ItemSpatialBlendType
		{
			[Token(Token = "0x4000599")]
			ForceTo2D,
			[Token(Token = "0x400059A")]
			ForceTo3D,
			[Token(Token = "0x400059B")]
			ForceToCustom,
			[Token(Token = "0x400059C")]
			UseCurveFromAudioSource
		}

		[Token(Token = "0x20000A9")]
		public enum InternetFileLoadStatus
		{
			[Token(Token = "0x400059E")]
			Loading,
			[Token(Token = "0x400059F")]
			Loaded,
			[Token(Token = "0x40005A0")]
			Failed
		}

		[Token(Token = "0x20000AA")]
		public enum MixerWidthMode
		{
			[Token(Token = "0x40005A2")]
			Narrow,
			[Token(Token = "0x40005A3")]
			Normal,
			[Token(Token = "0x40005A4")]
			Wide
		}

		[Token(Token = "0x20000AB")]
		public enum CustomEventReceiveMode
		{
			[Token(Token = "0x40005A6")]
			Always,
			[Token(Token = "0x40005A7")]
			WhenDistanceLessThan,
			[Token(Token = "0x40005A8")]
			WhenDistanceMoreThan,
			[Token(Token = "0x40005A9")]
			Never
		}

		[Token(Token = "0x20000AC")]
		public enum AudioLocation
		{
			[Token(Token = "0x40005AB")]
			Clip,
			[Token(Token = "0x40005AC")]
			ResourceFile,
			[Token(Token = "0x40005AD")]
			FileOnInternet
		}

		[Token(Token = "0x20000AD")]
		public enum BusCommand
		{
			[Token(Token = "0x40005AF")]
			None,
			[Token(Token = "0x40005B0")]
			FadeToVolume,
			[Token(Token = "0x40005B1")]
			Mute,
			[Token(Token = "0x40005B2")]
			Pause,
			[Token(Token = "0x40005B3")]
			Solo,
			[Token(Token = "0x40005B4")]
			Unmute,
			[Token(Token = "0x40005B5")]
			Unpause,
			[Token(Token = "0x40005B6")]
			Unsolo,
			[Token(Token = "0x40005B7")]
			Stop,
			[Token(Token = "0x40005B8")]
			ChangeBusPitch,
			[Token(Token = "0x40005B9")]
			ToggleMute
		}

		[Token(Token = "0x20000AE")]
		public enum DragGroupMode
		{
			[Token(Token = "0x40005BB")]
			OneGroupPerClip,
			[Token(Token = "0x40005BC")]
			OneGroupWithVariations
		}

		[Token(Token = "0x20000AF")]
		public enum EventSoundFunctionType
		{
			[Token(Token = "0x40005BE")]
			PlaySound,
			[Token(Token = "0x40005BF")]
			GroupControl,
			[Token(Token = "0x40005C0")]
			BusControl,
			[Token(Token = "0x40005C1")]
			PlaylistControl,
			[Token(Token = "0x40005C2")]
			CustomEventControl,
			[Token(Token = "0x40005C3")]
			GlobalControl,
			[Token(Token = "0x40005C4")]
			UnityMixerControl,
			[Token(Token = "0x40005C5")]
			PersistentSettingsControl
		}

		[Token(Token = "0x20000B0")]
		public enum LanguageMode
		{
			[Token(Token = "0x40005C7")]
			UseDeviceSetting,
			[Token(Token = "0x40005C8")]
			SpecificLanguage,
			[Token(Token = "0x40005C9")]
			DynamicallySet
		}

		[Token(Token = "0x20000B1")]
		public enum UnityMixerCommand
		{
			[Token(Token = "0x40005CB")]
			None,
			[Token(Token = "0x40005CC")]
			TransitionToSnapshot,
			[Token(Token = "0x40005CD")]
			TransitionToSnapshotBlend
		}

		[Token(Token = "0x20000B2")]
		public enum PlaylistCommand
		{
			[Token(Token = "0x40005CF")]
			None,
			[Token(Token = "0x40005D0")]
			ChangePlaylist,
			[Token(Token = "0x40005D1")]
			FadeToVolume,
			[Token(Token = "0x40005D2")]
			PlayClip,
			[Token(Token = "0x40005D3")]
			PlayRandomSong,
			[Token(Token = "0x40005D4")]
			PlayNextSong,
			[Token(Token = "0x40005D5")]
			Pause,
			[Token(Token = "0x40005D6")]
			Resume,
			[Token(Token = "0x40005D7")]
			Stop,
			[Token(Token = "0x40005D8")]
			Mute,
			[Token(Token = "0x40005D9")]
			Unmute,
			[Token(Token = "0x40005DA")]
			ToggleMute,
			[Token(Token = "0x40005DB")]
			Restart,
			[Token(Token = "0x40005DC")]
			Start,
			[Token(Token = "0x40005DD")]
			StopLoopingCurrentSong
		}

		[Token(Token = "0x20000B3")]
		public enum CustomEventCommand
		{
			[Token(Token = "0x40005DF")]
			None,
			[Token(Token = "0x40005E0")]
			FireEvent
		}

		[Token(Token = "0x20000B4")]
		public enum GlobalCommand
		{
			[Token(Token = "0x40005E2")]
			None,
			[Token(Token = "0x40005E3")]
			PauseMixer,
			[Token(Token = "0x40005E4")]
			UnpauseMixer,
			[Token(Token = "0x40005E5")]
			StopMixer,
			[Token(Token = "0x40005E6")]
			StopEverything,
			[Token(Token = "0x40005E7")]
			PauseEverything,
			[Token(Token = "0x40005E8")]
			UnpauseEverything,
			[Token(Token = "0x40005E9")]
			MuteEverything,
			[Token(Token = "0x40005EA")]
			UnmuteEverything,
			[Token(Token = "0x40005EB")]
			SetMasterMixerVolume,
			[Token(Token = "0x40005EC")]
			SetMasterPlaylistVolume
		}

		[Token(Token = "0x20000B5")]
		public enum SoundGroupCommand
		{
			[Token(Token = "0x40005EE")]
			None,
			[Token(Token = "0x40005EF")]
			FadeToVolume,
			[Token(Token = "0x40005F0")]
			FadeOutAllOfSound,
			[Token(Token = "0x40005F1")]
			Mute,
			[Token(Token = "0x40005F2")]
			Pause,
			[Token(Token = "0x40005F3")]
			Solo,
			[Token(Token = "0x40005F4")]
			StopAllOfSound,
			[Token(Token = "0x40005F5")]
			Unmute,
			[Token(Token = "0x40005F6")]
			Unpause,
			[Token(Token = "0x40005F7")]
			Unsolo,
			[Token(Token = "0x40005F8")]
			StopAllSoundsOfTransform,
			[Token(Token = "0x40005F9")]
			PauseAllSoundsOfTransform,
			[Token(Token = "0x40005FA")]
			UnpauseAllSoundsOfTransform,
			[Token(Token = "0x40005FB")]
			StopSoundGroupOfTransform,
			[Token(Token = "0x40005FC")]
			PauseSoundGroupOfTransform,
			[Token(Token = "0x40005FD")]
			UnpauseSoundGroupOfTransform,
			[Token(Token = "0x40005FE")]
			FadeOutSoundGroupOfTransform,
			[Token(Token = "0x40005FF")]
			RefillSoundGroupPool
		}

		[Token(Token = "0x20000B6")]
		public enum PersistentSettingsCommand
		{
			[Token(Token = "0x4000601")]
			None,
			[Token(Token = "0x4000602")]
			SetBusVolume,
			[Token(Token = "0x4000603")]
			SetGroupVolume,
			[Token(Token = "0x4000604")]
			SetMixerVolume,
			[Token(Token = "0x4000605")]
			SetMusicVolume,
			[Token(Token = "0x4000606")]
			MixerMuteToggle,
			[Token(Token = "0x4000607")]
			MusicMuteToggle
		}

		[Token(Token = "0x20000B7")]
		public enum SongFadeInPosition
		{
			[Token(Token = "0x4000609")]
			NewClipFromBeginning = 1,
			[Token(Token = "0x400060A")]
			NewClipFromLastKnownPosition = 3,
			[Token(Token = "0x400060B")]
			SynchronizeClips = 5
		}

		[Token(Token = "0x20000B8")]
		public enum SoundSpawnLocationMode
		{
			[Token(Token = "0x400060D")]
			MasterAudioLocation,
			[Token(Token = "0x400060E")]
			CallerLocation,
			[Token(Token = "0x400060F")]
			AttachToCaller
		}

		[Token(Token = "0x20000B9")]
		public enum VariationCommand
		{
			[Token(Token = "0x4000611")]
			None,
			[Token(Token = "0x4000612")]
			Stop,
			[Token(Token = "0x4000613")]
			Pause,
			[Token(Token = "0x4000614")]
			Unpause
		}

		[Serializable]
		[Token(Token = "0x20000BA")]
		public class AudioGroupInfo
		{
			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<AudioInfo> Sources;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastFramePlayed;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastTimePlayed;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MasterAudioGroup Group;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool PlayedForWarming;

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0xB4D840", Offset = "0xB4D840", VA = "0xB4D840")]
			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BB")]
		public class AudioInfo
		{
			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource Source;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float OriginalVolume;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastPercentageVolume;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float LastRandomVolume;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation Variation;

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0xB4D88C", Offset = "0xB4D88C", VA = "0xB4D88C")]
			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BC")]
		public class Playlist
		{
			[Token(Token = "0x20000E1")]
			public enum CrossfadeTimeMode
			{
				[Token(Token = "0x400068F")]
				UseMasterSetting,
				[Token(Token = "0x4000690")]
				Override
			}

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isExpanded;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string playlistName;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SongFadeInPosition songTransitionType;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MusicSetting> MusicSettings;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioLocation bulkLocationMode;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CrossfadeTimeMode crossfadeMode;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float crossFadeTime;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool fadeInFirstSong;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool fadeOutLastSong;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			public bool resourceClipsAllLoadAsync;

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0xB4D8E4", Offset = "0xB4D8E4", VA = "0xB4D8E4")]
			public Playlist()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BD")]
		public class SoundGroupRefillInfo
		{
			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float LastTimePlayed;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float InactivePeriodSeconds;

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0xB4D980", Offset = "0xB4D980", VA = "0xB4D980")]
			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BD70", Offset = "0x58BD70")]
		private sealed class <>c
		{
			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<BusFadeInfo> <>9__163_0;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<GroupFadeInfo> <>9__164_0;

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0xB4CC90", Offset = "0xB4CC90", VA = "0xB4CC90")]
			public <>c()
			{
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0xB4CC98", Offset = "0xB4CC98", VA = "0xB4CC98")]
			internal bool <PerformBusFades>b__163_0(BusFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0xB4CCB8", Offset = "0xB4CCB8", VA = "0xB4CCB8")]
			internal bool <PerformGroupFades>b__164_0(GroupFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BD80", Offset = "0x58BD80")]
		private sealed class <>c__DisplayClass175_0
		{
			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0xB4CCD8", Offset = "0xB4CCD8", VA = "0xB4CCD8")]
			public <>c__DisplayClass175_0()
			{
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0xB4CCE0", Offset = "0xB4CCE0", VA = "0xB4CCE0")]
			internal void <PlaySoundAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x20000C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BD90", Offset = "0x58BD90")]
		private sealed class <PlaySoundAndWaitUntilFinished>d__175 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float volumePercentage;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float? pitch;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delaySoundTime;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string variationName;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass175_0 <>8__1;

			[Token(Token = "0x1700015C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007C5")]
				[Address(RVA = "0xB4D7D0", Offset = "0xB4D7D0", VA = "0xB4D7D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007C7")]
				[Address(RVA = "0xB4D838", Offset = "0xB4D838", VA = "0xB4D838", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0xB4D530", Offset = "0xB4D530", VA = "0xB4D530")]
			[DebuggerHidden]
			public <PlaySoundAndWaitUntilFinished>d__175(int <>1__state)
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0xB4D55C", Offset = "0xB4D55C", VA = "0xB4D55C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0xB4D560", Offset = "0xB4D560", VA = "0xB4D560", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0xB4D7D8", Offset = "0xB4D7D8", VA = "0xB4D7D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BDA0", Offset = "0x58BDA0")]
		private sealed class <>c__DisplayClass176_0
		{
			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0xB4CCEC", Offset = "0xB4CCEC", VA = "0xB4CCEC")]
			public <>c__DisplayClass176_0()
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0xB4CCF4", Offset = "0xB4CCF4", VA = "0xB4CCF4")]
			internal void <PlaySound3DAtTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BDB0", Offset = "0x58BDB0")]
		private sealed class <PlaySound3DAtTransformAndWaitUntilFinished>d__176 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private <>c__DisplayClass176_0 <>8__1;

			[Token(Token = "0x1700015E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007CD")]
				[Address(RVA = "0xB4D1A8", Offset = "0xB4D1A8", VA = "0xB4D1A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007CF")]
				[Address(RVA = "0xB4D210", Offset = "0xB4D210", VA = "0xB4D210", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0xB4CE48", Offset = "0xB4CE48", VA = "0xB4CE48")]
			[DebuggerHidden]
			public <PlaySound3DAtTransformAndWaitUntilFinished>d__176(int <>1__state)
			{
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0xB4CE74", Offset = "0xB4CE74", VA = "0xB4CE74", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0xB4CE78", Offset = "0xB4CE78", VA = "0xB4CE78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0xB4D1B0", Offset = "0xB4D1B0", VA = "0xB4D1B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BDC0", Offset = "0x58BDC0")]
		private sealed class <>c__DisplayClass177_0
		{
			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0xB4CD00", Offset = "0xB4CD00", VA = "0xB4CD00")]
			public <>c__DisplayClass177_0()
			{
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0xB4CD08", Offset = "0xB4CD08", VA = "0xB4CD08")]
			internal void <PlaySound3DFollowTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BDD0", Offset = "0x58BDD0")]
		private sealed class <PlaySound3DFollowTransformAndWaitUntilFinished>d__177 : IEnumerator<object>, IEnumerator, IDisposable
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
			public Transform sourceTrans;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private <>c__DisplayClass177_0 <>8__1;

			[Token(Token = "0x17000160")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D5")]
				[Address(RVA = "0xB4D4C0", Offset = "0xB4D4C0", VA = "0xB4D4C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000161")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D7")]
				[Address(RVA = "0xB4D528", Offset = "0xB4D528", VA = "0xB4D528", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0xB4D218", Offset = "0xB4D218", VA = "0xB4D218")]
			[DebuggerHidden]
			public <PlaySound3DFollowTransformAndWaitUntilFinished>d__177(int <>1__state)
			{
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0xB4D244", Offset = "0xB4D244", VA = "0xB4D244", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0xB4D248", Offset = "0xB4D248", VA = "0xB4D248", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0xB4D4C8", Offset = "0xB4D4C8", VA = "0xB4D4C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BDE0", Offset = "0x58BDE0")]
		private sealed class <>c__DisplayClass207_0
		{
			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0xB4CD14", Offset = "0xB4CD14", VA = "0xB4CD14")]
			public <>c__DisplayClass207_0()
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0xB4CD1C", Offset = "0xB4CD1C", VA = "0xB4CD1C")]
			internal bool <FadeSoundGroupToVolume>b__0(GroupFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BDF0", Offset = "0x58BDF0")]
		private sealed class <>c__DisplayClass251_0
		{
			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0xB4CD40", Offset = "0xB4CD40", VA = "0xB4CD40")]
			public <>c__DisplayClass251_0()
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0xB4CD48", Offset = "0xB4CD48", VA = "0xB4CD48")]
			internal bool <CreateBus>b__0(GroupBus obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BE00", Offset = "0x58BE00")]
		private sealed class <>c__DisplayClass255_0
		{
			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0xB4CD6C", Offset = "0xB4CD6C", VA = "0xB4CD6C")]
			public <>c__DisplayClass255_0()
			{
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0xB4CD74", Offset = "0xB4CD74", VA = "0xB4CD74")]
			internal bool <FadeBusToVolume>b__0(BusFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BE10", Offset = "0x58BE10")]
		private sealed class <>c__DisplayClass325_0
		{
			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0xB4CD98", Offset = "0xB4CD98", VA = "0xB4CD98")]
			public <>c__DisplayClass325_0()
			{
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0xB4CDA0", Offset = "0xB4CDA0", VA = "0xB4CDA0")]
			internal bool <CreateCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BE20", Offset = "0x58BE20")]
		private sealed class <>c__DisplayClass326_0
		{
			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0xB4CDC4", Offset = "0xB4CDC4", VA = "0xB4CDC4")]
			public <>c__DisplayClass326_0()
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0xB4CDCC", Offset = "0xB4CDCC", VA = "0xB4CDCC")]
			internal bool <DeleteCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BE30", Offset = "0x58BE30")]
		private sealed class <>c__DisplayClass327_0
		{
			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0xB4CDF0", Offset = "0xB4CDF0", VA = "0xB4CDF0")]
			public <>c__DisplayClass327_0()
			{
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0xB4CDF8", Offset = "0xB4CDF8", VA = "0xB4CDF8")]
			internal bool <GetCustomEventByName>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BE40", Offset = "0x58BE40")]
		private sealed class <>c__DisplayClass329_0
		{
			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0xB4CE1C", Offset = "0xB4CE1C", VA = "0xB4CE1C")]
			public <>c__DisplayClass329_0()
			{
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0xB4CE24", Offset = "0xB4CE24", VA = "0xB4CE24")]
			internal bool <CustomEventExists>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40003BE")]
		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		[Token(Token = "0x40003BF")]
		public const string PreviewText = "Fading & random settings are ignored by preview in edit mode.";

		[Token(Token = "0x40003C0")]
		public const float SemiTonePitchFactor = 1.05946f;

		[Token(Token = "0x40003C1")]
		public const float SpatialBlend_2DValue = 0f;

		[Token(Token = "0x40003C2")]
		public const float SpatialBlend_3DValue = 1f;

		[Token(Token = "0x40003C3")]
		public const int FramesEarlyToTrigger = 2;

		[Token(Token = "0x40003C4")]
		public const float MaxCrossFadeTimeSeconds = 120f;

		[Token(Token = "0x40003C5")]
		public const float DefaultDuckVolCut = -6f;

		[Token(Token = "0x40003C6")]
		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly YieldInstruction EndOfFrameDelay;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action NumberOfAudioSourcesChanged;

		[Token(Token = "0x40003C9")]
		public const string GizmoFileName = "MasterAudio/MasterAudio Icon.png";

		[Token(Token = "0x40003CA")]
		public const int HardCodedBusOptions = 2;

		[Token(Token = "0x40003CB")]
		public const string AllBusesName = "[All]";

		[Token(Token = "0x40003CC")]
		public const string NoGroupName = "[None]";

		[Token(Token = "0x40003CD")]
		public const string DynamicGroupName = "[Type In]";

		[Token(Token = "0x40003CE")]
		public const string NoPlaylistName = "[No Playlist]";

		[Token(Token = "0x40003CF")]
		public const string NoVoiceLimitName = "[NO LMT]";

		[Token(Token = "0x40003D0")]
		public const string OnlyPlaylistControllerName = "~only~";

		[Token(Token = "0x40003D1")]
		public const float InnerLoopCheckInterval = 0.1f;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioLocation bulkLocationMode;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupTemplateName;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string audioSourceTemplateName;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showGroupCreation;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useGroupTemplates;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DragGroupMode curDragGroupMode;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> groupTemplates;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mixerMuted;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool playlistsMuted;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LanguageMode langMode;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SystemLanguage testLanguage;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SystemLanguage defaultLanguage;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SystemLanguage> supportedLanguages;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string busFilter;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useTextGroupFilter;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string textGroupFilter;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool resourceClipsPauseDoNotUnload;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform playlistControllerPrefab;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool persistBetweenScenes;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool areGroupsExpanded;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform soundGroupTemplate;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform soundGroupVariationTemplate;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool groupByBus;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool showGizmos;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool showAdvancedSettings;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
		public bool showLocalization;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool playListExpanded;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		public bool playlistsExpanded;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AllMusicSpatialBlendType musicSpatialBlendType;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float musicSpatialBlend;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AllMixerSpatialBlendType mixerSpatialBlendType;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float mixerSpatialBlend;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ItemSpatialBlendType newGroupSpatialType;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float newGroupSpatialBlend;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<Playlist> musicPlaylists;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float _masterAudioVolume;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public bool ignoreTimeScale;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
		public bool followAudioListener;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD6")]
		public bool useGaplessPlaylists;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD7")]
		public bool saveRuntimeChanges;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool prioritizeOnDistance;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public int rePrioritizeEverySecIndex;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool useOcclusion;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public int reOccludeEverySecIndex;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public OcclusionSelectionType occlusionSelectType;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool occlusionUseLayerMask;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public LayerMask occlusionLayerMask;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public bool occlusionShowRaycasts;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		public bool occlusionShowCategories;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public RaycastMode occlusionRaycastMode;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public bool occlusionIncludeStartRaycast2DCollider;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		public bool visualAdvancedExpanded;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		public bool logAdvancedExpanded;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x107")]
		public bool showFadingSettings;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool stopZeroVolumeVariations;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		public bool stopZeroVolumeGroups;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
		public bool stopZeroVolumeBuses;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10B")]
		public bool stopZeroVolumePlaylists;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public bool resourceAdvancedExpanded;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
		public bool LogSounds;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10F")]
		public bool logCustomEvents;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool disableLogging;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		public bool showMusicDucking;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x112")]
		public bool enableMusicDucking;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float defaultRiseVolStart;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public float defaultUnduckTime;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float defaultDuckedVolumeCut;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public float crossFadeTime;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public float _masterPlaylistVolume;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public bool showGroupSelect;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x135")]
		public bool hideGroupsWithNoActiveVars;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public string newEventName;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool showCustomEvents;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public Dictionary<string, DuckGroupInfo> duckingBySoundType;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public int frames;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Transform _trans;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool _soundsLoaded;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		private bool _warming;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Dictionary<string, List<int>> _randomizer;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Dictionary<string, List<int>> _randomizerLeftovers;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly List<MasterAudioGroup> SoloedGroups;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly List<BusFadeInfo> BusFades;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly List<GroupFadeInfo> GroupFades;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly List<AudioSource> AllAudioSources;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly Dictionary<string, PlaylistController> PlaylistControllersByName;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly List<GameObject> OcclusionSourcesInRange;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static readonly List<GameObject> OcclusionSourcesOutOfRange;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static readonly List<GameObject> OcclusionSourcesBlocked;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static MasterAudio _instance;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static float _repriTime;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static List<string> _groupsToRemove;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static string _prospectiveMAFolder;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static Transform _listenerTrans;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static YieldInstruction _innerLoopDelay;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C260", Offset = "0x58C260")]
		private static bool <AppIsShuttingDown>k__BackingField;

		[Token(Token = "0x170000F9")]
		public static float PlaylistMasterVolume
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x74CFEC", Offset = "0x74CFEC", VA = "0x74CFEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x73F828", Offset = "0x73F828", VA = "0x73F828")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public static bool LogSoundsEnabled
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x74D7E8", Offset = "0x74D7E8", VA = "0x74D7E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x74D854", Offset = "0x74D854", VA = "0x74D854")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public static List<AudioSource> MasterAudioSources
		{
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x74E194", Offset = "0x74E194", VA = "0x74E194")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		public static Transform ListenerTrans
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x72D664", Offset = "0x72D664", VA = "0x72D664")]
			get
			{
				return null;
			}
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x74E1FC", Offset = "0x74E1FC", VA = "0x74E1FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public static PlaylistController OnlyPlaylistController
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x74E268", Offset = "0x74E268", VA = "0x74E268")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FE")]
		public static bool IsWarming
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x738954", Offset = "0x738954", VA = "0x738954")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FF")]
		public static bool MixerMuted
		{
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x74E300", Offset = "0x74E300", VA = "0x74E300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000683")]
			[Address(RVA = "0x74ACC4", Offset = "0x74ACC4", VA = "0x74ACC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public static bool PlaylistsMuted
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x74E36C", Offset = "0x74E36C", VA = "0x74E36C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x74BEC0", Offset = "0x74BEC0", VA = "0x74BEC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public bool EnableMusicDucking
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x74E3D8", Offset = "0x74E3D8", VA = "0x74E3D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x74E3E0", Offset = "0x74E3E0", VA = "0x74E3E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public float MasterCrossFadeTime
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x74E3EC", Offset = "0x74E3EC", VA = "0x74E3EC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000103")]
		public static List<Playlist> MusicPlaylists
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x74BB38", Offset = "0x74BB38", VA = "0x74BB38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000104")]
		public static List<GroupBus> GroupBuses
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x74B240", Offset = "0x74B240", VA = "0x74B240")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000105")]
		public static List<string> RuntimeSoundGroupNames
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x73C8BC", Offset = "0x73C8BC", VA = "0x73C8BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		public static List<string> RuntimeBusNames
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x73E684", Offset = "0x73E684", VA = "0x73E684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000107")]
		public static MasterAudio SafeInstance
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x7331CC", Offset = "0x7331CC", VA = "0x7331CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000108")]
		public static MasterAudio Instance
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x72DA84", Offset = "0x72DA84", VA = "0x72DA84")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x74E3F4", Offset = "0x74E3F4", VA = "0x74E3F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public static bool SoundsReady
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x7335A0", Offset = "0x7335A0", VA = "0x7335A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010A")]
		public static bool AppIsShuttingDown
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x74E45C", Offset = "0x74E45C", VA = "0x74E45C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CEC0", Offset = "0x58CEC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x74E4C4", Offset = "0x74E4C4", VA = "0x74E4C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CED0", Offset = "0x58CED0")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public List<string> GroupNames
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x74E534", Offset = "0x74E534", VA = "0x74E534")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010C")]
		public List<string> BusNames
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x74E6C4", Offset = "0x74E6C4", VA = "0x74E6C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010D")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x74E7D0", Offset = "0x74E7D0", VA = "0x74E7D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010E")]
		public Transform Trans
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x743D0C", Offset = "0x743D0C", VA = "0x743D0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010F")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x74E8DC", Offset = "0x74E8DC", VA = "0x74E8DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000110")]
		public List<string> CustomEventNames
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x74E8E4", Offset = "0x74E8E4", VA = "0x74E8E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000111")]
		public static float MasterVolumeLevel
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x74EA10", Offset = "0x74EA10", VA = "0x74EA10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x73F6E0", Offset = "0x73F6E0", VA = "0x73F6E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000112")]
		private static bool SceneHasMasterAudio
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x74532C", Offset = "0x74532C", VA = "0x74532C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000113")]
		public static bool IgnoreTimeScale
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x732400", Offset = "0x732400", VA = "0x732400")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000114")]
		public static YieldInstruction InnerLoopDelay
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x74EA7C", Offset = "0x74EA7C", VA = "0x74EA7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000115")]
		public static SystemLanguage DynamicLanguage
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x72E270", Offset = "0x72E270", VA = "0x72E270")]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x74EAE4", Offset = "0x74EAE4", VA = "0x74EAE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000116")]
		public static float ReprioritizeTime
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x74EBA8", Offset = "0x74EBA8", VA = "0x74EBA8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000117")]
		public static float ReOccludeCheckTime
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x74EC80", Offset = "0x74EC80", VA = "0x74EC80")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000118")]
		public static string ProspectiveMAPath
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x74ED60", Offset = "0x74ED60", VA = "0x74ED60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x74EDC8", Offset = "0x74EDC8", VA = "0x74EDC8")]
			set
			{
			}
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x742770", Offset = "0x742770", VA = "0x742770")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x744004", Offset = "0x744004", VA = "0x744004")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x744184", Offset = "0x744184", VA = "0x744184")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x744370", Offset = "0x744370", VA = "0x744370")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x7443EC", Offset = "0x7443EC", VA = "0x7443EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x744470", Offset = "0x744470", VA = "0x744470")]
		public void UpdateLocation()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x744E5C", Offset = "0x744E5C", VA = "0x744E5C")]
		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x744BEC", Offset = "0x744BEC", VA = "0x744BEC")]
		private static void RefillInactiveGroupPools()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x744578", Offset = "0x744578", VA = "0x744578")]
		private void PerformBusFades()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x744890", Offset = "0x744890", VA = "0x744890")]
		private void PerformGroupFades()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x745284", Offset = "0x745284", VA = "0x745284")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x7318B8", Offset = "0x7318B8", VA = "0x7318B8")]
		public static void PlaySoundAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x73AC70", Offset = "0x73AC70", VA = "0x73AC70")]
		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x746598", Offset = "0x746598", VA = "0x746598")]
		public static void PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x746724", Offset = "0x746724", VA = "0x746724")]
		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x73A728", Offset = "0x73A728", VA = "0x73A728")]
		public static void PlaySound3DAtTransformAndForget(string sType, [Optional] Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x73A568", Offset = "0x73A568", VA = "0x73A568")]
		public static PlaySoundResult PlaySound3DAtTransform(string sType, [Optional] Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x73AAAC", Offset = "0x73AAAC", VA = "0x73AAAC")]
		public static void PlaySound3DFollowTransformAndForget(string sType, [Optional] Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x73A8EC", Offset = "0x73A8EC", VA = "0x73A8EC")]
		public static PlaySoundResult PlaySound3DFollowTransform(string sType, [Optional] Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x74689C", Offset = "0x74689C", VA = "0x74689C")]
		public static void PlaySound3DAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x746A50", Offset = "0x746A50", VA = "0x746A50")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58CD94", Offset = "0x58CD94")]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x746AF0", Offset = "0x746AF0", VA = "0x746AF0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58CDF8", Offset = "0x58CDF8")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x746B9C", Offset = "0x746B9C", VA = "0x746B9C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58CE5C", Offset = "0x58CE5C")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x7453C0", Offset = "0x7453C0", VA = "0x7453C0")]
		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, [Optional] float? pitch, [Optional] Transform sourceTrans, [Optional] string variationName, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x746EF0", Offset = "0x746EF0", VA = "0x746EF0")]
		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x74717C", Offset = "0x74717C", VA = "0x74717C")]
		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x747384", Offset = "0x747384", VA = "0x747384")]
		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, ref bool forgetSoundPlayed, [Optional] float? pitch, [Optional] AudioGroupInfo audioGroup, [Optional] Transform sourceTrans, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x74799C", Offset = "0x74799C", VA = "0x74799C")]
		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x747B4C", Offset = "0x747B4C", VA = "0x747B4C")]
		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x73DB14", Offset = "0x73DB14", VA = "0x73DB14")]
		public static void StopAllSoundsOfTransform(Transform trans)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x73DCCC", Offset = "0x73DCCC", VA = "0x73DCCC")]
		public static void StopSoundGroupOfTransform(Transform trans, string sType)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x73DE44", Offset = "0x73DE44", VA = "0x73DE44")]
		public static void PauseAllSoundsOfTransform(Transform trans)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x73DFFC", Offset = "0x73DFFC", VA = "0x73DFFC")]
		public static void PauseSoundGroupOfTransform(Transform trans, string sType)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x73E174", Offset = "0x73E174", VA = "0x73E174")]
		public static void UnpauseAllSoundsOfTransform(Transform trans)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x73E32C", Offset = "0x73E32C", VA = "0x73E32C")]
		public static void UnpauseSoundGroupOfTransform(Transform trans, string sType)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x73E4A4", Offset = "0x73E4A4", VA = "0x73E4A4")]
		public static void FadeOutSoundGroupOfTransform(Transform trans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x73D550", Offset = "0x73D550", VA = "0x73D550")]
		public static void StopAllOfSound(string sType)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x73CFBC", Offset = "0x73CFBC", VA = "0x73CFBC")]
		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x747EB8", Offset = "0x747EB8", VA = "0x747EB8")]
		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x748124", Offset = "0x748124", VA = "0x748124")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x748444", Offset = "0x748444", VA = "0x748444")]
		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x7489EC", Offset = "0x7489EC", VA = "0x7489EC")]
		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x748D30", Offset = "0x748D30", VA = "0x748D30")]
		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x74900C", Offset = "0x74900C", VA = "0x74900C")]
		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x7491BC", Offset = "0x7491BC", VA = "0x7491BC")]
		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x749408", Offset = "0x749408", VA = "0x749408")]
		public static float GetVariationLength(string sType, string variationName)
		{
			return default(float);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x73C9A4", Offset = "0x73C9A4", VA = "0x73C9A4")]
		public static void RefillSoundGroupPool(string sType)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x749B60", Offset = "0x749B60", VA = "0x749B60")]
		public static bool SoundGroupExists(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x73D2EC", Offset = "0x73D2EC", VA = "0x73D2EC")]
		public static void PauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x749C00", Offset = "0x749C00", VA = "0x749C00")]
		public static void SetGroupSpatialBlend(string sType)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x749D4C", Offset = "0x749D4C", VA = "0x749D4C")]
		public void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x73D8AC", Offset = "0x73D8AC", VA = "0x73D8AC")]
		public static void UnpauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x73CCA8", Offset = "0x73CCA8", VA = "0x73CCA8")]
		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x734134", Offset = "0x734134", VA = "0x734134")]
		public static void RemoveSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x734D54", Offset = "0x734D54", VA = "0x734D54")]
		public static Transform CreateNewSoundGroup(DynamicSoundGroup aGroup, string creatorObjectName, bool errorOnExisting = true)
		{
			return null;
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x74A06C", Offset = "0x74A06C", VA = "0x74A06C")]
		public static float GetGroupVolume(string sType)
		{
			return default(float);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x744FD0", Offset = "0x744FD0", VA = "0x744FD0")]
		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x73D1D8", Offset = "0x73D1D8", VA = "0x73D1D8")]
		public static void MuteGroup(string sType)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x73D7C8", Offset = "0x73D7C8", VA = "0x73D7C8")]
		public static void UnmuteGroup(string sType)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x743DA4", Offset = "0x743DA4", VA = "0x743DA4")]
		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x74A384", Offset = "0x74A384", VA = "0x74A384")]
		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x74A228", Offset = "0x74A228", VA = "0x74A228")]
		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x744214", Offset = "0x744214", VA = "0x744214")]
		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x749EAC", Offset = "0x749EAC", VA = "0x749EAC")]
		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x74A42C", Offset = "0x74A42C", VA = "0x74A42C")]
		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x74A124", Offset = "0x74A124", VA = "0x74A124")]
		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x73D438", Offset = "0x73D438", VA = "0x73D438")]
		public static void SoloGroup(string sType)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x73DA1C", Offset = "0x73DA1C", VA = "0x73DA1C")]
		public static void UnsoloGroup(string sType)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x747D40", Offset = "0x747D40", VA = "0x747D40")]
		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x74A5B8", Offset = "0x74A5B8", VA = "0x74A5B8")]
		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x74A768", Offset = "0x74A768", VA = "0x74A768")]
		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x74A8A8", Offset = "0x74A8A8", VA = "0x74A8A8")]
		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x74A978", Offset = "0x74A978", VA = "0x74A978")]
		public void SetSpatialBlendForMixer()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x73F8F8", Offset = "0x73F8F8", VA = "0x73F8F8")]
		public static void PauseMixer()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x73FAA0", Offset = "0x73FAA0", VA = "0x73FAA0")]
		public static void UnpauseMixer()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x73FC48", Offset = "0x73FC48", VA = "0x73FC48")]
		public static void StopMixer()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x74AABC", Offset = "0x74AABC", VA = "0x74AABC")]
		public static void UnsubscribeFromAllVariations()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x73FF78", Offset = "0x73FF78", VA = "0x73FF78")]
		public static void StopEverything()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x73FEB8", Offset = "0x73FEB8", VA = "0x73FEB8")]
		public static void PauseEverything()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x73FF18", Offset = "0x73FF18", VA = "0x73FF18")]
		public static void UnpauseEverything()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x73FDF0", Offset = "0x73FDF0", VA = "0x73FDF0")]
		public static void MuteEverything()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x73FE54", Offset = "0x73FE54", VA = "0x73FE54")]
		public static void UnmuteEverything()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x74AFC0", Offset = "0x74AFC0", VA = "0x74AFC0")]
		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x7482F4", Offset = "0x7482F4", VA = "0x7482F4")]
		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return default(int);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x74B2AC", Offset = "0x74B2AC", VA = "0x74B2AC")]
		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x73F564", Offset = "0x73F564", VA = "0x73F564")]
		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x73EEC0", Offset = "0x73EEC0", VA = "0x73EEC0")]
		public static void MuteBus(string busName)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x73F050", Offset = "0x73F050", VA = "0x73F050")]
		public static void UnmuteBus(string busName)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x73F19C", Offset = "0x73F19C", VA = "0x73F19C")]
		public static void ToggleMuteBus(string busName)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x73EB0C", Offset = "0x73EB0C", VA = "0x73EB0C")]
		public static void PauseBus(string busName)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x73F288", Offset = "0x73F288", VA = "0x73F288")]
		public static void SoloBus(string busName)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x73F418", Offset = "0x73F418", VA = "0x73F418")]
		public static void UnsoloBus(string busName)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x74B34C", Offset = "0x74B34C", VA = "0x74B34C")]
		public void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x746F2C", Offset = "0x746F2C", VA = "0x746F2C")]
		private static void StopOldestSoundOnBus(GroupBus bus)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x73EC48", Offset = "0x73EC48", VA = "0x73EC48")]
		public static void StopBus(string busName)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x73ED84", Offset = "0x73ED84", VA = "0x73ED84")]
		public static void UnpauseBus(string busName)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x734B1C", Offset = "0x734B1C", VA = "0x734B1C")]
		public static bool CreateBus(string busName, bool errorOnExisting = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x734094", Offset = "0x734094", VA = "0x734094")]
		public static void DeleteBusByName(string busName)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x74B47C", Offset = "0x74B47C", VA = "0x74B47C")]
		public static void DeleteBus(int busIndex)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x7478E4", Offset = "0x7478E4", VA = "0x7478E4")]
		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return default(float);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x73E7C0", Offset = "0x73E7C0", VA = "0x73E7C0")]
		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x743EF8", Offset = "0x743EF8", VA = "0x743EF8")]
		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x74B5E8", Offset = "0x74B5E8", VA = "0x74B5E8")]
		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x734A2C", Offset = "0x734A2C", VA = "0x734A2C")]
		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x735CBC", Offset = "0x735CBC", VA = "0x735CBC")]
		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x74B90C", Offset = "0x74B90C", VA = "0x74B90C")]
		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x74B9C0", Offset = "0x74B9C0", VA = "0x74B9C0")]
		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x74BBA4", Offset = "0x74BBA4", VA = "0x74BBA4")]
		public static void ChangePlaylistPitch(string playlistName, float pitch, [Optional] string songName)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x74BCC0", Offset = "0x74BCC0", VA = "0x74BCC0")]
		public static void MutePlaylist()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x73B718", Offset = "0x73B718", VA = "0x73B718")]
		public static void MutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x73B6A8", Offset = "0x73B6A8", VA = "0x73B6A8")]
		public static void MuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x74BDEC", Offset = "0x74BDEC", VA = "0x74BDEC")]
		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x74BFA0", Offset = "0x74BFA0", VA = "0x74BFA0")]
		public static void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x73B92C", Offset = "0x73B92C", VA = "0x73B92C")]
		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x73B8BC", Offset = "0x73B8BC", VA = "0x73B8BC")]
		public static void UnmuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x74C008", Offset = "0x74C008", VA = "0x74C008")]
		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x74C0DC", Offset = "0x74C0DC", VA = "0x74C0DC")]
		public static void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x73BB40", Offset = "0x73BB40", VA = "0x73BB40")]
		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x73BAD0", Offset = "0x73BAD0", VA = "0x73BAD0")]
		public static void ToggleMuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x74C144", Offset = "0x74C144", VA = "0x74C144")]
		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x74C1D4", Offset = "0x74C1D4", VA = "0x74C1D4")]
		public static void PausePlaylist()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x73C2F0", Offset = "0x73C2F0", VA = "0x73C2F0")]
		public static void PausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x73C280", Offset = "0x73C280", VA = "0x73C280")]
		public static void PauseAllPlaylists()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x74C23C", Offset = "0x74C23C", VA = "0x74C23C")]
		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x74C2CC", Offset = "0x74C2CC", VA = "0x74C2CC")]
		public static void ResumePlaylist()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x73C718", Offset = "0x73C718", VA = "0x73C718")]
		public static void ResumePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x73C6A8", Offset = "0x73C6A8", VA = "0x73C6A8")]
		public static void ResumeAllPlaylists()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x74C334", Offset = "0x74C334", VA = "0x74C334")]
		private static void ResumePlaylists(List<PlaylistController> controllers)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x74C3C4", Offset = "0x74C3C4", VA = "0x74C3C4")]
		public static void StopPlaylist()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x73C504", Offset = "0x73C504", VA = "0x73C504")]
		public static void StopPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x73C494", Offset = "0x73C494", VA = "0x73C494")]
		public static void StopAllPlaylists()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x74C42C", Offset = "0x74C42C", VA = "0x74C42C")]
		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x74C4C0", Offset = "0x74C4C0", VA = "0x74C4C0")]
		public static void TriggerNextPlaylistClip()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x73C0DC", Offset = "0x73C0DC", VA = "0x73C0DC")]
		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x73C06C", Offset = "0x73C06C", VA = "0x73C06C")]
		public static void TriggerNextClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x74C528", Offset = "0x74C528", VA = "0x74C528")]
		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x74C5B8", Offset = "0x74C5B8", VA = "0x74C5B8")]
		public static void TriggerRandomPlaylistClip()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x73BEC8", Offset = "0x73BEC8", VA = "0x73BEC8")]
		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x73BE58", Offset = "0x73BE58", VA = "0x73BE58")]
		public static void TriggerRandomClipAllPlaylists()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x74C620", Offset = "0x74C620", VA = "0x74C620")]
		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x74C6B0", Offset = "0x74C6B0", VA = "0x74C6B0")]
		public static void RestartPlaylist()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x73AE94", Offset = "0x73AE94", VA = "0x73AE94")]
		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x73AE24", Offset = "0x73AE24", VA = "0x73AE24")]
		public static void RestartAllPlaylists()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x74C718", Offset = "0x74C718", VA = "0x74C718")]
		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x74C7A8", Offset = "0x74C7A8", VA = "0x74C7A8")]
		public static void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x73B048", Offset = "0x73B048", VA = "0x73B048")]
		public static void StartPlaylist(string playlistControllerName, string playlistName)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x73B388", Offset = "0x73B388", VA = "0x73B388")]
		public static void StopLoopingAllCurrentSongs()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x73B3F8", Offset = "0x73B3F8", VA = "0x73B3F8")]
		public static void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x74C8A8", Offset = "0x74C8A8", VA = "0x74C8A8")]
		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x74C818", Offset = "0x74C818", VA = "0x74C818")]
		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x74CA5C", Offset = "0x74CA5C", VA = "0x74CA5C")]
		public static void QueuePlaylistClip(string clipName)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x74CACC", Offset = "0x74CACC", VA = "0x74CACC")]
		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x74CC40", Offset = "0x74CC40", VA = "0x74CC40")]
		public static bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x73BCE4", Offset = "0x73BCE4", VA = "0x73BCE4")]
		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x74CCB0", Offset = "0x74CCB0", VA = "0x74CCB0")]
		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x73B210", Offset = "0x73B210", VA = "0x73B210")]
		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x74CD30", Offset = "0x74CD30", VA = "0x74CD30")]
		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x73B4E8", Offset = "0x73B4E8", VA = "0x73B4E8")]
		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x73B460", Offset = "0x73B460", VA = "0x73B460")]
		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x74CDB0", Offset = "0x74CDB0", VA = "0x74CDB0")]
		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x736064", Offset = "0x736064", VA = "0x736064")]
		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x73463C", Offset = "0x73463C", VA = "0x73463C")]
		public static void DeletePlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x74CEF0", Offset = "0x74CEF0", VA = "0x74CEF0")]
		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x74D058", Offset = "0x74D058", VA = "0x74D058")]
		public static void ReDownloadAllInternetFiles()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x740554", Offset = "0x740554", VA = "0x740554")]
		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x740958", Offset = "0x740958", VA = "0x740958")]
		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x74D450", Offset = "0x74D450", VA = "0x74D450")]
		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x735DE8", Offset = "0x735DE8", VA = "0x735DE8")]
		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, bool errorOnDuplicate = true)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x73448C", Offset = "0x73448C", VA = "0x73448C")]
		public static void DeleteCustomEvent(string customEventName)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x74D6DC", Offset = "0x74D6DC", VA = "0x74D6DC")]
		private static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x736194", Offset = "0x736194", VA = "0x736194")]
		public static void FireCustomEvent(string customEventName, Vector3 originPoint, bool logDupe = true)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x74024C", Offset = "0x74024C", VA = "0x74024C")]
		public static bool CustomEventExists(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x746C48", Offset = "0x746C48", VA = "0x746C48")]
		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x746D58", Offset = "0x746D58", VA = "0x746D58")]
		private static void LogMessage(string message)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x72E7FC", Offset = "0x72E7FC", VA = "0x72E7FC")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x72F4A0", Offset = "0x72F4A0", VA = "0x72F4A0")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x74D8C8", Offset = "0x74D8C8", VA = "0x74D8C8")]
		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x74BD28", Offset = "0x74BD28", VA = "0x74BD28")]
		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x74DA6C", Offset = "0x74DA6C", VA = "0x74DA6C")]
		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x74DBF0", Offset = "0x74DBF0", VA = "0x74DBF0")]
		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x74DE98", Offset = "0x74DE98", VA = "0x74DE98")]
		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x74DD94", Offset = "0x74DD94", VA = "0x74DD94")]
		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x74DF9C", Offset = "0x74DF9C", VA = "0x74DF9C")]
		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x74ED58", Offset = "0x74ED58", VA = "0x74ED58")]
		public static bool HasAsyncResourceLoaderFeature()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x74EE34", Offset = "0x74EE34", VA = "0x74EE34")]
		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x74EFA0", Offset = "0x74EFA0", VA = "0x74EFA0")]
		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x74F10C", Offset = "0x74F10C", VA = "0x74F10C")]
		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x74F278", Offset = "0x74F278", VA = "0x74F278")]
		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x74F3E4", Offset = "0x74F3E4", VA = "0x74F3E4")]
		public MasterAudio()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public static class PersistentAudioSettings
	{
		[Token(Token = "0x4000440")]
		public const string SfxVolKey = "MA_sfxVolume";

		[Token(Token = "0x4000441")]
		public const string MusicVolKey = "MA_musicVolume";

		[Token(Token = "0x4000442")]
		public const string SfxMuteKey = "MA_sfxMute";

		[Token(Token = "0x4000443")]
		public const string MusicMuteKey = "MA_musicMute";

		[Token(Token = "0x4000444")]
		public const string BusVolKey = "MA_BusVolume_";

		[Token(Token = "0x4000445")]
		public const string GroupVolKey = "MA_GroupVolume_";

		[Token(Token = "0x4000446")]
		public const string BusKeysKey = "MA_BusKeys";

		[Token(Token = "0x4000447")]
		public const string GroupKeysKey = "MA_GroupsKeys";

		[Token(Token = "0x4000448")]
		public const string Separator = ";";

		[Token(Token = "0x17000119")]
		public static string BusesUpdatedKeys
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0xB4EB20", Offset = "0xB4EB20", VA = "0xB4EB20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0xB4EB94", Offset = "0xB4EB94", VA = "0xB4EB94")]
			set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public static string GroupsUpdatedKeys
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xB4ECD0", Offset = "0xB4ECD0", VA = "0xB4ECD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0xB4ED44", Offset = "0xB4ED44", VA = "0xB4ED44")]
			set
			{
			}
		}

		[Token(Token = "0x1700011B")]
		public static bool? MixerMuted
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0xB4EFE4", Offset = "0xB4EFE4", VA = "0xB4EFE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xB4F074", Offset = "0xB4F074", VA = "0xB4F074")]
			set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public static float? MixerVolume
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xB4F1A8", Offset = "0xB4F1A8", VA = "0xB4F1A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0xB4F230", Offset = "0xB4F230", VA = "0xB4F230")]
			set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public static bool? MusicMuted
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0xB4F358", Offset = "0xB4F358", VA = "0xB4F358")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0xB4F3E8", Offset = "0xB4F3E8", VA = "0xB4F3E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public static float? MusicVolume
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0xB4F51C", Offset = "0xB4F51C", VA = "0xB4F51C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xB4F5A4", Offset = "0xB4F5A4", VA = "0xB4F5A4")]
			set
			{
			}
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xB4E948", Offset = "0xB4E948", VA = "0xB4E948")]
		public static void SetBusVolume(string busName, float vol)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xB4EACC", Offset = "0xB4EACC", VA = "0xB4EACC")]
		public static string MakeBusKey(string busName)
		{
			return null;
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xB4EBE8", Offset = "0xB4EBE8", VA = "0xB4EBE8")]
		public static float? GetBusVolume(string busName)
		{
			return null;
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xB4EC7C", Offset = "0xB4EC7C", VA = "0xB4EC7C")]
		public static string GetGroupKey(string groupName)
		{
			return null;
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xB4ED98", Offset = "0xB4ED98", VA = "0xB4ED98")]
		public static void SetGroupVolume(string grpName, float vol)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xB4EF50", Offset = "0xB4EF50", VA = "0xB4EF50")]
		public static float? GetGroupVolume(string grpName)
		{
			return null;
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xB4F6CC", Offset = "0xB4F6CC", VA = "0xB4F6CC")]
		public static void RestoreMasterSettings()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class SoundGroupOrganizer : MonoBehaviour
	{
		[Token(Token = "0x20000CC")]
		public class CustomEventSelection
		{
			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEvent Event;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0xB55E28", Offset = "0xB55E28", VA = "0xB55E28")]
			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
			}
		}

		[Token(Token = "0x20000CD")]
		public class SoundGroupSelection
		{
			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject Go;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0xB55E68", Offset = "0xB55E68", VA = "0xB55E68")]
			public SoundGroupSelection(GameObject go, bool isSelected)
			{
			}
		}

		[Token(Token = "0x20000CE")]
		public enum MAItemType
		{
			[Token(Token = "0x4000657")]
			SoundGroups,
			[Token(Token = "0x4000658")]
			CustomEvents
		}

		[Token(Token = "0x20000CF")]
		public enum TransferMode
		{
			[Token(Token = "0x400065A")]
			None,
			[Token(Token = "0x400065B")]
			Import,
			[Token(Token = "0x400065C")]
			Export
		}

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject dynGroupTemplate;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject dynVariationTemplate;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject maGroupTemplate;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject maVariationTemplate;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useTextGroupFilter;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string textGroupFilter;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TransferMode transMode;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject sourceObject;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupSelection> selectedSourceSoundGroups;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject destObject;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<SoundGroupSelection> selectedDestSoundGroups;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public MAItemType itemType;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<CustomEventSelection> selectedSourceCustomEvents;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<CustomEventSelection> selectedDestCustomEvents;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string newEventName;

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xB55C94", Offset = "0xB55C94", VA = "0xB55C94")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xB55D00", Offset = "0xB55D00", VA = "0xB55D00")]
		public SoundGroupOrganizer()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public static class ArrayListUtil
	{
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x72CE24", Offset = "0x72CE24", VA = "0x72CE24")]
		public static void SortIntArray(ref List<int> list)
		{
		}
	}
	[Token(Token = "0x2000073")]
	public static class AudioUtil
	{
		[Token(Token = "0x400045C")]
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		[Token(Token = "0x400045D")]
		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		[Token(Token = "0x400045E")]
		private const float SemitonePitchChangeAmt = 1.0594635f;

		[Token(Token = "0x1700011F")]
		private static float CutoffRange
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x730EB0", Offset = "0x730EB0", VA = "0x730EB0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000120")]
		private static float MaxCutoffFreq
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x730F34", Offset = "0x730F34", VA = "0x730F34")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000121")]
		public static float MinCutoffFreq
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x730FA0", Offset = "0x730FA0", VA = "0x730FA0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000122")]
		public static float FrameTime
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x73100C", Offset = "0x73100C", VA = "0x73100C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x731014", Offset = "0x731014", VA = "0x731014")]
		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio)
		{
			return default(float);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x731044", Offset = "0x731044", VA = "0x731044")]
		public static float GetSemitonesFromPitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x731108", Offset = "0x731108", VA = "0x731108")]
		public static float GetPitchFromSemitones(float semitones)
		{
			return default(float);
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x7311BC", Offset = "0x7311BC", VA = "0x7311BC")]
		public static float GetDbFromFloatVolume(float vol)
		{
			return default(float);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x731234", Offset = "0x731234", VA = "0x731234")]
		public static float GetFloatVolumeFromDb(float db)
		{
			return default(float);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x72D7AC", Offset = "0x72D7AC", VA = "0x72D7AC")]
		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x7312A8", Offset = "0x7312A8", VA = "0x7312A8")]
		public static bool IsAudioPaused(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x7312F0", Offset = "0x7312F0", VA = "0x7312F0")]
		public static void UnloadNonPreloadedAudioData(AudioClip clip)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x72E8A4", Offset = "0x72E8A4", VA = "0x72E8A4")]
		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x731390", Offset = "0x731390", VA = "0x731390")]
		public static bool IsClipReadyToPlay(AudioClip clip)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000074")]
	public static class CoroutineHelper
	{
		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BE50", Offset = "0x58BE50")]
		private sealed class <WaitForActualSeconds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <start>5__2;

			[Token(Token = "0x17000162")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007EB")]
				[Address(RVA = "0x731F8C", Offset = "0x731F8C", VA = "0x731F8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000163")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007ED")]
				[Address(RVA = "0x731FF4", Offset = "0x731FF4", VA = "0x731FF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x731E94", Offset = "0x731E94", VA = "0x731E94")]
			[DebuggerHidden]
			public <WaitForActualSeconds>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x731EC0", Offset = "0x731EC0", VA = "0x731EC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x731EC4", Offset = "0x731EC4", VA = "0x731EC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x731F94", Offset = "0x731F94", VA = "0x731F94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x731E1C", Offset = "0x731E1C", VA = "0x731E1C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58CEE0", Offset = "0x58CEE0")]
		public static IEnumerator WaitForActualSeconds(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x2000075")]
	public static class DTMonoHelper
	{
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x73203C", Offset = "0x73203C", VA = "0x73203C")]
		public static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x732054", Offset = "0x732054", VA = "0x732054")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class DelayBetweenSongs : MonoBehaviour
	{
		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BE60", Offset = "0x58BE60")]
		private sealed class <PlaySongWithDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayBetweenSongs <>4__this;

			[Token(Token = "0x17000164")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F1")]
				[Address(RVA = "0x73246C", Offset = "0x73246C", VA = "0x73246C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000165")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007F3")]
				[Address(RVA = "0x7324D4", Offset = "0x7324D4", VA = "0x7324D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x732244", Offset = "0x732244", VA = "0x732244")]
			[DebuggerHidden]
			public <PlaySongWithDelay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x7322D4", Offset = "0x7322D4", VA = "0x7322D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x7322D8", Offset = "0x7322D8", VA = "0x7322D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x732474", Offset = "0x732474", VA = "0x732474", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minTimeToWait;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxTimeToWait;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playlistControllerName;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlaylistController _controller;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x732070", Offset = "0x732070", VA = "0x732070")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x732110", Offset = "0x732110", VA = "0x732110")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x73219C", Offset = "0x73219C", VA = "0x73219C")]
		private void SongEnded(string songName)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x7321D4", Offset = "0x7321D4", VA = "0x7321D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58CF44", Offset = "0x58CF44")]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x732270", Offset = "0x732270", VA = "0x732270")]
		public DelayBetweenSongs()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		[Token(Token = "0x20000D2")]
		public enum CreateItemsWhen
		{
			[Token(Token = "0x4000665")]
			FirstEnableOnly,
			[Token(Token = "0x4000666")]
			EveryEnable
		}

		[Token(Token = "0x4000463")]
		public const int ExtraHardCodedBusOptions = 1;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject groupTemplate;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject variationTemplate;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool errorOnDuplicates;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool createOnAwake;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool soundGroupsAreExpanded;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool removeGroupsOnSceneChange;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CreateItemsWhen reUseMode;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool showCustomEvents;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CustomEvent> customEventsToCreate;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string newEventName;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool showMusicDucking;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool playListExpanded;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool playlistEditorExp;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<MasterAudio.Playlist> musicPlaylists;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string audioSourceTemplateName;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool groupByBus;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool itemsCreatedEventExpanded;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string itemsCreatedCustomEvent;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool _hasCreated;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly List<Transform> _groupsToRemove;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform _trans;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly List<DynamicSoundGroup> _groupsToCreate;

		[Token(Token = "0x17000123")]
		public static int HardCodedBusOptions
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x734D4C", Offset = "0x734D4C", VA = "0x734D4C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000124")]
		public List<DynamicSoundGroup> GroupsToCreate
		{
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x736834", Offset = "0x736834", VA = "0x736834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000125")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x73683C", Offset = "0x73683C", VA = "0x73683C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x732EE4", Offset = "0x732EE4", VA = "0x732EE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x732FB4", Offset = "0x732FB4", VA = "0x732FB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x7330A4", Offset = "0x7330A4", VA = "0x7330A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x7330A8", Offset = "0x7330A8", VA = "0x7330A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x732FB8", Offset = "0x732FB8", VA = "0x732FB8")]
		private void CreateItemsIfReady()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x733368", Offset = "0x733368", VA = "0x733368")]
		public void RemoveItems()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x733674", Offset = "0x733674", VA = "0x733674")]
		public void CreateItems()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x7347F0", Offset = "0x7347F0", VA = "0x7347F0")]
		public void PopulateGroupData()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x736844", Offset = "0x736844", VA = "0x736844")]
		public DynamicSoundGroupCreator()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x58BC48", Offset = "0x58BC48")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58BC48", Offset = "0x58BC48")]
	public class PlaylistController : MonoBehaviour
	{
		[Token(Token = "0x20000D3")]
		public delegate void SongChangedEventHandler(string newSongName);

		[Token(Token = "0x20000D4")]
		public delegate void SongEndedEventHandler(string songName);

		[Token(Token = "0x20000D5")]
		public enum AudioPlayType
		{
			[Token(Token = "0x4000668")]
			PlayNow,
			[Token(Token = "0x4000669")]
			Schedule,
			[Token(Token = "0x400066A")]
			AlreadyScheduled
		}

		[Token(Token = "0x20000D6")]
		public enum PlaylistStates
		{
			[Token(Token = "0x400066C")]
			NotInScene,
			[Token(Token = "0x400066D")]
			Stopped,
			[Token(Token = "0x400066E")]
			Playing,
			[Token(Token = "0x400066F")]
			Paused,
			[Token(Token = "0x4000670")]
			Crossfading
		}

		[Token(Token = "0x20000D7")]
		public enum FadeMode
		{
			[Token(Token = "0x4000672")]
			None,
			[Token(Token = "0x4000673")]
			GradualFade
		}

		[Token(Token = "0x20000D8")]
		public enum AudioDuckingMode
		{
			[Token(Token = "0x4000675")]
			NotDucking,
			[Token(Token = "0x4000676")]
			SetToDuck,
			[Token(Token = "0x4000677")]
			Ducked
		}

		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BE70", Offset = "0x58BE70")]
		private sealed class <>c__DisplayClass79_0
		{
			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string playlistControllerName;

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0xB51CA8", Offset = "0xB51CA8", VA = "0xB51CA8")]
			public <>c__DisplayClass79_0()
			{
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0xB55990", Offset = "0xB55990", VA = "0xB55990")]
			internal bool <InstanceByName>b__0(PlaylistController obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BE80", Offset = "0x58BE80")]
		private sealed class <>c__DisplayClass96_0
		{
			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string clipName;

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0xB53934", Offset = "0xB53934", VA = "0xB53934")]
			public <>c__DisplayClass96_0()
			{
			}

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0xB55A3C", Offset = "0xB55A3C", VA = "0xB55A3C")]
			internal bool <QueuePlaylistClip>b__0(MusicSetting obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BE90", Offset = "0x58BE90")]
		private sealed class <>c__DisplayClass97_0
		{
			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string clipName;

			[Token(Token = "0x6000800")]
			[Address(RVA = "0xB53C88", Offset = "0xB53C88", VA = "0xB53C88")]
			public <>c__DisplayClass97_0()
			{
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0xB55B04", Offset = "0xB55B04", VA = "0xB55B04")]
			internal bool <TriggerPlaylistClip>b__0(MusicSetting obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0xB55B28", Offset = "0xB55B28", VA = "0xB55B28")]
			internal bool <TriggerPlaylistClip>b__1(MusicSetting obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58BEA0", Offset = "0x58BEA0")]
		private sealed class <>c__DisplayClass105_0
		{
			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlaylistController <>4__this;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volumeBeforeFade;

			[Token(Token = "0x6000803")]
			[Address(RVA = "0xB54118", Offset = "0xB54118", VA = "0xB54118")]
			public <>c__DisplayClass105_0()
			{
			}

			[Token(Token = "0x6000804")]
			[Address(RVA = "0xB55950", Offset = "0xB55950", VA = "0xB55950")]
			internal void <FadeOutPlaylist>b__0()
			{
			}
		}

		[Token(Token = "0x4000481")]
		public const int ScheduledSongMinBadOffset = 1;

		[Token(Token = "0x4000482")]
		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		[Token(Token = "0x4000483")]
		private const float MinSongLength = 0.5f;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool startPlaylistOnAwake;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isShuffle;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isAutoAdvance;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool loopPlaylist;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float _playlistVolume;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isMuted;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string startPlaylistName;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int syncGroupNum;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float spatialBlend;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string songChangedCustomEvent;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool songEndedEventExpanded;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string songEndedCustomEvent;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AudioSource _activeAudio;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AudioSource _transitioningAudio;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _activeAudioEndVolume;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _transitioningAudioStartVolume;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float _crossFadeStartTime;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly List<int> _clipsRemaining;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _currentSequentialClipIndex;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private AudioDuckingMode _duckingMode;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _timeToStartUnducking;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _timeToFinishUnducking;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _originalMusicVolume;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float _initialDuckVolume;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float _duckRange;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private MusicSetting _currentSong;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject _go;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string _name;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private FadeMode _curFadeMode;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _slowFadeTargetVolume;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _slowFadeVolStep;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private MasterAudio.Playlist _currentPlaylist;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _lastTimeMissingPlaylistLogged;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Action _fadeCompleteCallback;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly List<MusicSetting> _queuedSongs;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool _lostFocus;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private AudioSource _audioClip;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private AudioSource _transClip;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private MusicSetting _newSongSetting;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool _nextSongRequested;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		private bool _nextSongScheduled;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int _lastRandomClipIndex;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float _lastTimeSongRequested;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float _currentDuckVolCut;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private readonly Dictionary<AudioSource, double> _scheduledSongsByAudioSource;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<PlaylistController> _instances;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int _songsPlayedFromPlaylist;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private AudioSource _audio1;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private AudioSource _audio2;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Transform _trans;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool _willPersist;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C290", Offset = "0x58C290")]
		private bool <ControllerIsReady>k__BackingField;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C2A0", Offset = "0x58C2A0")]
		private bool <IsCrossFading>k__BackingField;

		[Token(Token = "0x17000126")]
		private bool SongIsNonAdvancible
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0xB55304", Offset = "0xB55304", VA = "0xB55304")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000127")]
		private bool ShouldLoadAsync
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0xB54240", Offset = "0xB54240", VA = "0xB54240")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000128")]
		public bool ControllerIsReady
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0xB5535C", Offset = "0xB5535C", VA = "0xB5535C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CFE8", Offset = "0x58CFE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600071E")]
			[Address(RVA = "0xB55364", Offset = "0xB55364", VA = "0xB55364")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CFF8", Offset = "0x58CFF8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public PlaylistStates PlaylistState
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0xB51850", Offset = "0xB51850", VA = "0xB51850")]
			get
			{
				return default(PlaylistStates);
			}
		}

		[Token(Token = "0x1700012A")]
		public AudioSource ActiveAudioSource
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0xB50F6C", Offset = "0xB50F6C", VA = "0xB50F6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012B")]
		public static List<PlaylistController> Instances
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0xB51CB0", Offset = "0xB51CB0", VA = "0xB51CB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000722")]
			[Address(RVA = "0xB55370", Offset = "0xB55370", VA = "0xB55370")]
			set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public GameObject PlaylistControllerGameObject
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0xB553C4", Offset = "0xB553C4", VA = "0xB553C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012D")]
		public AudioSource CurrentPlaylistSource
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0xB553CC", Offset = "0xB553CC", VA = "0xB553CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012E")]
		public AudioClip CurrentPlaylistClip
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0xB553D4", Offset = "0xB553D4", VA = "0xB553D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012F")]
		public AudioClip FadingPlaylistClip
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0xB5546C", Offset = "0xB5546C", VA = "0xB5546C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000130")]
		public AudioSource FadingSource
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0xB5550C", Offset = "0xB5550C", VA = "0xB5550C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000131")]
		public bool IsCrossFading
		{
			[Token(Token = "0x6000728")]
			[Address(RVA = "0xB55524", Offset = "0xB55524", VA = "0xB55524")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58D008", Offset = "0x58D008")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000729")]
			[Address(RVA = "0xB5552C", Offset = "0xB5552C", VA = "0xB5552C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58D018", Offset = "0x58D018")]
			private set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public bool IsFading
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0xB55538", Offset = "0xB55538", VA = "0xB55538")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000133")]
		public float PlaylistVolume
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0xB53E20", Offset = "0xB53E20", VA = "0xB53E20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600072C")]
			[Address(RVA = "0xB55558", Offset = "0xB55558", VA = "0xB55558")]
			set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public MasterAudio.Playlist CurrentPlaylist
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0xB542D8", Offset = "0xB542D8", VA = "0xB542D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000135")]
		public bool HasPlaylist
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0xB555A4", Offset = "0xB555A4", VA = "0xB555A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000136")]
		public string PlaylistName
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0xB555B4", Offset = "0xB555B4", VA = "0xB555B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000137")]
		private bool IsMuted
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0xB5562C", Offset = "0xB5562C", VA = "0xB5562C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000138")]
		private bool PlaylistIsMuted
		{
			[Token(Token = "0x6000732")]
			[Address(RVA = "0xB51FAC", Offset = "0xB51FAC", VA = "0xB51FAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000139")]
		private float CrossFadeTime
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0xB51788", Offset = "0xB51788", VA = "0xB51788")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700013A")]
		private bool IsAutoAdvance
		{
			[Token(Token = "0x6000734")]
			[Address(RVA = "0xB51818", Offset = "0xB51818", VA = "0xB51818")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700013B")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0xB55634", Offset = "0xB55634", VA = "0xB55634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013C")]
		public string ControllerName
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0xB4FFE8", Offset = "0xB4FFE8", VA = "0xB4FFE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013D")]
		public bool CanSchedule
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0xB50998", Offset = "0xB50998", VA = "0xB50998")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700013E")]
		private Transform Trans
		{
			[Token(Token = "0x6000738")]
			[Address(RVA = "0xB54120", Offset = "0xB54120", VA = "0xB54120")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013F")]
		public int ClipsRemainingInCurrentPlaylist
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0xB556C4", Offset = "0xB556C4", VA = "0xB556C4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000002")]
		public event SongChangedEventHandler SongChanged
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0xB4F900", Offset = "0xB4F900", VA = "0xB4F900")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CFA8", Offset = "0x58CFA8")]
			add
			{
			}
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0xB4F9A8", Offset = "0xB4F9A8", VA = "0xB4F9A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CFB8", Offset = "0x58CFB8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event SongEndedEventHandler SongEnded
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0xB4FA50", Offset = "0xB4FA50", VA = "0xB4FA50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CFC8", Offset = "0x58CFC8")]
			add
			{
			}
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0xB4FAF8", Offset = "0xB4FAF8", VA = "0xB4FAF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CFD8", Offset = "0x58CFD8")]
			remove
			{
			}
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xB4FBA0", Offset = "0xB4FBA0", VA = "0xB4FBA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xB50028", Offset = "0xB50028", VA = "0xB50028")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xB50240", Offset = "0xB50240", VA = "0xB50240")]
		private void SetAudiosIfEmpty()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xB5018C", Offset = "0xB5018C", VA = "0xB5018C")]
		private void SetAudioSpatialBlend(float blend)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xB502CC", Offset = "0xB502CC", VA = "0xB502CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xB50548", Offset = "0xB50548", VA = "0xB50548")]
		private void CoUpdate()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xB50D1C", Offset = "0xB50D1C", VA = "0xB50D1C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xB50DF4", Offset = "0xB50DF4", VA = "0xB50DF4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xB51044", Offset = "0xB51044", VA = "0xB51044")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xB51050", Offset = "0xB51050", VA = "0xB51050")]
		private void Update()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xB51B30", Offset = "0xB51B30", VA = "0xB51B30")]
		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xB51E5C", Offset = "0xB51E5C", VA = "0xB51E5C")]
		public void ClearQueue()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xB51EF8", Offset = "0xB51EF8", VA = "0xB51EF8")]
		public void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xB50540", Offset = "0xB50540", VA = "0xB50540")]
		public void MutePlaylist()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xB51FA4", Offset = "0xB51FA4", VA = "0xB51FA4")]
		public void UnmutePlaylist()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xB52114", Offset = "0xB52114", VA = "0xB52114")]
		public void PausePlaylist()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xB5223C", Offset = "0xB5223C", VA = "0xB5223C")]
		public bool ResumePlaylist()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xB50C50", Offset = "0xB50C50", VA = "0xB50C50")]
		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xB524CC", Offset = "0xB524CC", VA = "0xB524CC")]
		public void FadeToVolume(float targetVolume, float fadeTime, [Optional] Action callback)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xB525D0", Offset = "0xB525D0", VA = "0xB525D0")]
		public void PlayRandomSong()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xB52660", Offset = "0xB52660", VA = "0xB52660")]
		public void PlayARandomSong(AudioPlayType playType, bool isMidsong)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xB52820", Offset = "0xB52820", VA = "0xB52820")]
		private void RemoveRandomClip(int randIndex)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xB530BC", Offset = "0xB530BC", VA = "0xB530BC")]
		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xB531C0", Offset = "0xB531C0", VA = "0xB531C0")]
		public void PlayNextSong()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xB53250", Offset = "0xB53250", VA = "0xB53250")]
		public void PlayTheNextSong(AudioPlayType playType, bool isMidsong)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xB533A8", Offset = "0xB533A8", VA = "0xB533A8")]
		private void AdvanceSongCounter()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xB53420", Offset = "0xB53420", VA = "0xB53420")]
		public void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xB5359C", Offset = "0xB5359C", VA = "0xB5359C")]
		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xB5393C", Offset = "0xB5393C", VA = "0xB5393C")]
		public bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xB53C90", Offset = "0xB53C90", VA = "0xB53C90")]
		public void DuckMusicForTime(float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xB53DF0", Offset = "0xB53DF0", VA = "0xB53DF0")]
		private void InitControllerIfNot()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xB50B54", Offset = "0xB50B54", VA = "0xB50B54")]
		public void UpdateMasterVolume()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xB53E90", Offset = "0xB53E90", VA = "0xB53E90")]
		public void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xB53FEC", Offset = "0xB53FEC", VA = "0xB53FEC")]
		public void ChangePlaylist(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xB52420", Offset = "0xB52420", VA = "0xB52420")]
		private void FinishPlaylistInit(bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xB53F60", Offset = "0xB53F60", VA = "0xB53F60")]
		public void RestartPlaylist()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xB5195C", Offset = "0xB5195C", VA = "0xB5195C")]
		private void FadeOutPlaylist()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xB50420", Offset = "0xB50420", VA = "0xB50420")]
		private void InitializePlaylist()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xB5048C", Offset = "0xB5048C", VA = "0xB5048C")]
		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xB52F3C", Offset = "0xB52F3C", VA = "0xB52F3C")]
		private void FillClips()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xB528B8", Offset = "0xB528B8", VA = "0xB528B8")]
		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xB54380", Offset = "0xB54380", VA = "0xB54380")]
		public void FinishLoadingNewSong(AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xB54B3C", Offset = "0xB54B3C", VA = "0xB54B3C")]
		private void RemoveScheduledClip()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xB53594", Offset = "0xB53594", VA = "0xB53594")]
		private void ScheduleNextSong()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xB51A44", Offset = "0xB51A44", VA = "0xB51A44")]
		private void FadeInScheduledSong()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xB50A30", Offset = "0xB50A30", VA = "0xB50A30")]
		private double CalculateNextTrackStartTime()
		{
			return default(double);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xB50ACC", Offset = "0xB50ACC", VA = "0xB50ACC")]
		private void ScheduleClipPlay(double scheduledPlayTime)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xB54AF0", Offset = "0xB54AF0", VA = "0xB54AF0")]
		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xB513F0", Offset = "0xB513F0", VA = "0xB513F0")]
		private void CeaseAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xB516A4", Offset = "0xB516A4", VA = "0xB516A4")]
		private void SetDuckProperties()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xB51A4C", Offset = "0xB51A4C", VA = "0xB51A4C")]
		private void AudioDucking()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xB541B0", Offset = "0xB541B0", VA = "0xB541B0")]
		private bool SongShouldLoop(MusicSetting setting)
		{
			return default(bool);
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xB55560", Offset = "0xB55560", VA = "0xB55560")]
		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xB55714", Offset = "0xB55714", VA = "0xB55714")]
		public PlaylistController()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xB55848", Offset = "0xB55848", VA = "0xB55848")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58D028", Offset = "0x58D028")]
		private bool <FinishLoadingNewSong>b__110_0(PlaylistController obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xB55940", Offset = "0xB55940", VA = "0xB55940")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58D038", Offset = "0x58D038")]
		private bool <FinishLoadingNewSong>b__110_1(MusicSetting obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000079")]
	public static class UtilStrings
	{
		[Token(Token = "0x600073D")]
		[Address(RVA = "0xB5B4BC", Offset = "0xB5B4BC", VA = "0xB5B4BC")]
		public static string TrimSpace(string untrimmed)
		{
			return null;
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xB5B53C", Offset = "0xB5B53C", VA = "0xB5B53C")]
		public static string ReplaceUnsafeChars(string source)
		{
			return null;
		}
	}
}
