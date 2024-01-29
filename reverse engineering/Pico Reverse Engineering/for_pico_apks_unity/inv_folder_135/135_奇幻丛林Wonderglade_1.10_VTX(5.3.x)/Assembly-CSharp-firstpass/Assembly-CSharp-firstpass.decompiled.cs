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
	[Address(RVA = "0xF65058", Offset = "0xF65058", VA = "0xF65058")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xF6505C", Offset = "0xF6505C", VA = "0xF6505C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xF6515C", Offset = "0xF6515C", VA = "0xF6515C")]
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
	[Address(RVA = "0xF65164", Offset = "0xF65164", VA = "0xF65164")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xF651CC", Offset = "0xF651CC", VA = "0xF651CC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xF65274", Offset = "0xF65274", VA = "0xF65274")]
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
	[Address(RVA = "0xF6527C", Offset = "0xF6527C", VA = "0xF6527C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xF65304", Offset = "0xF65304", VA = "0xF65304")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xF65410", Offset = "0xF65410", VA = "0xF65410")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xF655C4", Offset = "0xF655C4", VA = "0xF655C4")]
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
	[Address(RVA = "0xF655CC", Offset = "0xF655CC", VA = "0xF655CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xF65638", Offset = "0xF65638", VA = "0xF65638")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xF657EC", Offset = "0xF657EC", VA = "0xF657EC")]
	public MA_EnemySpawner()
	{
	}
}
[Token(Token = "0x2000006")]
public class MA_GameScene : MonoBehaviour
{
	[Token(Token = "0x600000E")]
	[Address(RVA = "0xF657F4", Offset = "0xF657F4", VA = "0xF657F4")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xF658A0", Offset = "0xF658A0", VA = "0xF658A0")]
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
	[Address(RVA = "0xF658A8", Offset = "0xF658A8", VA = "0xF658A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xF658E0", Offset = "0xF658E0", VA = "0xF658E0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xF659F0", Offset = "0xF659F0", VA = "0xF659F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xF65B18", Offset = "0xF65B18", VA = "0xF65B18")]
	public MA_Laser()
	{
	}
}
[Token(Token = "0x2000008")]
public class MA_LocalizationUI : MonoBehaviour
{
	[Token(Token = "0x6000014")]
	[Address(RVA = "0xF65B20", Offset = "0xF65B20", VA = "0xF65B20")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xF65BCC", Offset = "0xF65BCC", VA = "0xF65BCC")]
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
	[Address(RVA = "0xF65BD4", Offset = "0xF65BD4", VA = "0xF65BD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xF65C0C", Offset = "0xF65C0C", VA = "0xF65C0C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xF65CE4", Offset = "0xF65CE4", VA = "0xF65CE4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xF65CE8", Offset = "0xF65CE8", VA = "0xF65CE8")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xF65CEC", Offset = "0xF65CEC", VA = "0xF65CEC")]
	private void OnBecameVisible()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xF65CF0", Offset = "0xF65CF0", VA = "0xF65CF0")]
	private void Update()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xF65FA0", Offset = "0xF65FA0", VA = "0xF65FA0")]
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
		[Address(RVA = "0xF65FE0", Offset = "0xF65FE0", VA = "0xF65FE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xF65FB0", Offset = "0xF65FB0", VA = "0xF65FB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xF66010", Offset = "0xF66010", VA = "0xF66010")]
	private void Update()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xF66090", Offset = "0xF66090", VA = "0xF66090")]
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
	[Address(RVA = "0xF66098", Offset = "0xF66098", VA = "0xF66098")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xF6609C", Offset = "0xF6609C", VA = "0xF6609C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xF66200", Offset = "0xF66200", VA = "0xF66200")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xF66284", Offset = "0xF66284", VA = "0xF66284")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xF660A0", Offset = "0xF660A0", VA = "0xF660A0", Slot = "4")]
	public void CheckForIllegalCustomEvents()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xF662F0", Offset = "0xF662F0", VA = "0xF662F0", Slot = "5")]
	public void ReceiveEvent(string customEventName, Vector3 originPoint)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xF66400", Offset = "0xF66400", VA = "0xF66400", Slot = "6")]
	public bool SubscribesToEvent(string customEventName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xF66204", Offset = "0xF66204", VA = "0xF66204", Slot = "7")]
	public void RegisterReceiver()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xF66288", Offset = "0xF66288", VA = "0xF66288", Slot = "8")]
	public void UnregisterReceiver()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xF66494", Offset = "0xF66494", VA = "0xF66494", Slot = "9")]
	public IList<AudioEventGroup> GetAllEvents()
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xF665D0", Offset = "0xF665D0", VA = "0xF665D0")]
	public MA_SampleICustomEventReceiver()
	{
	}
}
[Token(Token = "0x200000C")]
public class MA_TestUI : MonoBehaviour
{
	[Token(Token = "0x600002C")]
	[Address(RVA = "0xF666B8", Offset = "0xF666B8", VA = "0xF666B8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xF66764", Offset = "0xF66764", VA = "0xF66764")]
	public MA_TestUI()
	{
	}
}
[Token(Token = "0x200000D")]
public static class DebugExtension
{
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x8F5E1C", Offset = "0x8F5E1C", VA = "0x8F5E1C")]
	public static void DebugPoint(Vector3 position, Color color, float scale = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x8F6160", Offset = "0x8F6160", VA = "0x8F6160")]
	public static void DebugPoint(Vector3 position, float scale = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x8F61F4", Offset = "0x8F61F4", VA = "0x8F61F4")]
	public static void DebugBounds(Bounds bounds, Color color, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x8F675C", Offset = "0x8F675C", VA = "0x8F675C")]
	public static void DebugBounds(Bounds bounds, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x8F67B4", Offset = "0x8F67B4", VA = "0x8F67B4")]
	public static void DebugLocalCube(Transform transform, Vector3 size, Color color, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x8F6F78", Offset = "0x8F6F78", VA = "0x8F6F78")]
	public static void DebugLocalCube(Transform transform, Vector3 size, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x8F7028", Offset = "0x8F7028", VA = "0x8F7028")]
	public static void DebugLocalCube(Matrix4x4 space, Vector3 size, Color color, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x8F76D4", Offset = "0x8F76D4", VA = "0x8F76D4")]
	public static void DebugLocalCube(Matrix4x4 space, Vector3 size, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x8F77A0", Offset = "0x8F77A0", VA = "0x8F77A0")]
	public static void DebugCircle(Vector3 position, Vector3 up, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x8F7BDC", Offset = "0x8F7BDC", VA = "0x8F7BDC")]
	public static void DebugCircle(Vector3 position, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x8F7CC0", Offset = "0x8F7CC0", VA = "0x8F7CC0")]
	public static void DebugCircle(Vector3 position, Vector3 up, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x8F7D5C", Offset = "0x8F7D5C", VA = "0x8F7D5C")]
	public static void DebugCircle(Vector3 position, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x8F7E44", Offset = "0x8F7E44", VA = "0x8F7E44")]
	public static void DebugWireSphere(Vector3 position, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x8F8174", Offset = "0x8F8174", VA = "0x8F8174")]
	public static void DebugWireSphere(Vector3 position, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x8F8208", Offset = "0x8F8208", VA = "0x8F8208")]
	public static void DebugCylinder(Vector3 start, Vector3 end, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x8F8978", Offset = "0x8F8978", VA = "0x8F8978")]
	public static void DebugCylinder(Vector3 start, Vector3 end, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x8F8A14", Offset = "0x8F8A14", VA = "0x8F8A14")]
	public static void DebugCone(Vector3 position, Vector3 direction, Color color, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x8F90CC", Offset = "0x8F90CC", VA = "0x8F90CC")]
	public static void DebugCone(Vector3 position, Vector3 direction, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x8F9168", Offset = "0x8F9168", VA = "0x8F9168")]
	public static void DebugCone(Vector3 position, Color color, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x8F924C", Offset = "0x8F924C", VA = "0x8F924C")]
	public static void DebugCone(Vector3 position, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x8F9334", Offset = "0x8F9334", VA = "0x8F9334")]
	public static void DebugArrow(Vector3 position, Vector3 direction, Color color, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x8F94D8", Offset = "0x8F94D8", VA = "0x8F94D8")]
	public static void DebugArrow(Vector3 position, Vector3 direction, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x8F956C", Offset = "0x8F956C", VA = "0x8F956C")]
	public static void DebugCapsule(Vector3 start, Vector3 end, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x8FA440", Offset = "0x8FA440", VA = "0x8FA440")]
	public static void DebugCapsule(Vector3 start, Vector3 end, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x8FA4DC", Offset = "0x8FA4DC", VA = "0x8FA4DC")]
	public static void DrawPoint(Vector3 position, Color color, float scale = 1f)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x8FA730", Offset = "0x8FA730", VA = "0x8FA730")]
	public static void DrawPoint(Vector3 position, float scale = 1f)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x8FA798", Offset = "0x8FA798", VA = "0x8FA798")]
	public static void DrawBounds(Bounds bounds, Color color)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x8FAC88", Offset = "0x8FAC88", VA = "0x8FAC88")]
	public static void DrawBounds(Bounds bounds)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x8FACC0", Offset = "0x8FACC0", VA = "0x8FACC0")]
	public static void DrawLocalCube(Transform transform, Vector3 size, Color color, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x8FB3D0", Offset = "0x8FB3D0", VA = "0x8FB3D0")]
	public static void DrawLocalCube(Transform transform, Vector3 size, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x8FB468", Offset = "0x8FB468", VA = "0x8FB468")]
	public static void DrawLocalCube(Matrix4x4 space, Vector3 size, Color color, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x8FBA58", Offset = "0x8FBA58", VA = "0x8FBA58")]
	public static void DrawLocalCube(Matrix4x4 space, Vector3 size, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x8FBB04", Offset = "0x8FBB04", VA = "0x8FBB04")]
	public static void DrawCircle(Vector3 position, Vector3 up, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x8FBFB8", Offset = "0x8FBFB8", VA = "0x8FBFB8")]
	public static void DrawCircle(Vector3 position, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x8FC08C", Offset = "0x8FC08C", VA = "0x8FC08C")]
	public static void DrawCircle(Vector3 position, Vector3 up, float radius = 1f)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x8FC0F4", Offset = "0x8FC0F4", VA = "0x8FC0F4")]
	public static void DrawCircle(Vector3 position, float radius = 1f)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x8FC1CC", Offset = "0x8FC1CC", VA = "0x8FC1CC")]
	public static void DrawCylinder(Vector3 start, Vector3 end, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x8FC868", Offset = "0x8FC868", VA = "0x8FC868")]
	public static void DrawCylinder(Vector3 start, Vector3 end, float radius = 1f)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x8FC8EC", Offset = "0x8FC8EC", VA = "0x8FC8EC")]
	public static void DrawCone(Vector3 position, Vector3 direction, Color color, float angle = 45f)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x8FCF2C", Offset = "0x8FCF2C", VA = "0x8FCF2C")]
	public static void DrawCone(Vector3 position, Vector3 direction, float angle = 45f)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x8FCFB0", Offset = "0x8FCFB0", VA = "0x8FCFB0")]
	public static void DrawCone(Vector3 position, Color color, float angle = 45f)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x8FD084", Offset = "0x8FD084", VA = "0x8FD084")]
	public static void DrawCone(Vector3 position, float angle = 45f)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x8FD15C", Offset = "0x8FD15C", VA = "0x8FD15C")]
	public static void DrawArrow(Vector3 position, Vector3 direction, Color color)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x8FD2E4", Offset = "0x8FD2E4", VA = "0x8FD2E4")]
	public static void DrawArrow(Vector3 position, Vector3 direction)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x8FD358", Offset = "0x8FD358", VA = "0x8FD358")]
	public static void DrawCapsule(Vector3 start, Vector3 end, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x8FE030", Offset = "0x8FE030", VA = "0x8FE030")]
	public static void DrawCapsule(Vector3 start, Vector3 end, float radius = 1f)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x8FE0B4", Offset = "0x8FE0B4", VA = "0x8FE0B4")]
	public static string MethodsOfObject(object obj, bool includeInfo = false)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x8FE1EC", Offset = "0x8FE1EC", VA = "0x8FE1EC")]
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
	[Address(RVA = "0xA6F954", Offset = "0xA6F954", VA = "0xA6F954")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xA6FC14", Offset = "0xA6FC14", VA = "0xA6FC14")]
	private void Update()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xA6FECC", Offset = "0xA6FECC", VA = "0xA6FECC")]
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
	[Address(RVA = "0xA6F920", Offset = "0xA6F920", VA = "0xA6F920")]
	public EnumFlagAttribute()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xA6F928", Offset = "0xA6F928", VA = "0xA6F928")]
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
	[Address(RVA = "0xA6FED4", Offset = "0xA6FED4", VA = "0xA6FED4")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xA70004", Offset = "0xA70004", VA = "0xA70004")]
	public static void ShowToast(string message)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xA701D8", Offset = "0xA701D8", VA = "0xA701D8")]
	public static void SetSendErrorCallback(Action<string> onError)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xA70244", Offset = "0xA70244", VA = "0xA70244")]
	public static void SetMessageReceivedCallback(Action<string> onMessageReceived)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xA702B0", Offset = "0xA702B0", VA = "0xA702B0")]
	public static void SetMessageSentCallback(Action<string> onMessageSent)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xA7031C", Offset = "0xA7031C", VA = "0xA7031C")]
	public static void SetDeletedMessagesCallback(Action<string> onDeletedMessages)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xA70388", Offset = "0xA70388", VA = "0xA70388")]
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
	[Address(RVA = "0xA70394", Offset = "0xA70394", VA = "0xA70394")]
	private void Awake()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xA70428", Offset = "0xA70428", VA = "0xA70428")]
	public void OnMessageReceived(string message)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xA704E8", Offset = "0xA704E8", VA = "0xA704E8")]
	public void OnMessageSent(string msgId)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xA705A8", Offset = "0xA705A8", VA = "0xA705A8")]
	public void OnSendError(string error)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xA70668", Offset = "0xA70668", VA = "0xA70668")]
	public void OnDeletedMessages()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xA706F8", Offset = "0xA706F8", VA = "0xA706F8")]
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
		[Address(RVA = "0xA7D228", Offset = "0xA7D228", VA = "0xA7D228")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000003")]
	public static int maxSimulataneousTweens
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0xA7D290", Offset = "0xA7D290", VA = "0xA7D290")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000004")]
	public static int tweensRunning
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0xA7D2F8", Offset = "0xA7D2F8", VA = "0xA7D2F8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000005")]
	public static GameObject tweenEmpty
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xA8C984", Offset = "0xA8C984", VA = "0xA8C984")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xA7CE70", Offset = "0xA7CE70", VA = "0xA7CE70")]
	public static void init()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xA7CED8", Offset = "0xA7CED8", VA = "0xA7CED8")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xA7D3F4", Offset = "0xA7D3F4", VA = "0xA7D3F4")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xA7D52C", Offset = "0xA7D52C", VA = "0xA7D52C")]
	public void Update()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xA85F8C", Offset = "0xA85F8C", VA = "0xA85F8C")]
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xA85FFC", Offset = "0xA85FFC", VA = "0xA85FFC")]
	private static void internalOnLevelWasLoaded(int lvl)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xA7D588", Offset = "0xA7D588", VA = "0xA7D588")]
	public static void update()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xA87B44", Offset = "0xA87B44", VA = "0xA87B44")]
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xA8868C", Offset = "0xA8868C", VA = "0xA8868C")]
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xA88AC0", Offset = "0xA88AC0", VA = "0xA88AC0")]
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xA87720", Offset = "0xA87720", VA = "0xA87720")]
	private static void alphaRecursiveSprite(Transform transform, float val)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xA881EC", Offset = "0xA881EC", VA = "0xA881EC")]
	private static void colorRecursiveSprite(Transform transform, Color toColor)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xA89260", Offset = "0xA89260", VA = "0xA89260")]
	private static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xA88E74", Offset = "0xA88E74", VA = "0xA88E74")]
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xA89614", Offset = "0xA89614", VA = "0xA89614")]
	private static void textColorRecursive(Transform trans, Color toColor)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xA880C4", Offset = "0xA880C4", VA = "0xA880C4")]
	private static Color tweenColor(LTDescrImpl tween, float val)
	{
		return default(Color);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xA72C34", Offset = "0xA72C34", VA = "0xA72C34")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xA86058", Offset = "0xA86058", VA = "0xA86058")]
	public static void removeTween(int i)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xA89B34", Offset = "0xA89B34", VA = "0xA89B34")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xA747BC", Offset = "0xA747BC", VA = "0xA747BC")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xA89D20", Offset = "0xA89D20", VA = "0xA89D20")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xA89D80", Offset = "0xA89D80", VA = "0xA89D80")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xA89FCC", Offset = "0xA89FCC", VA = "0xA89FCC")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xA8A034", Offset = "0xA8A034", VA = "0xA8A034")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xA8A310", Offset = "0xA8A310", VA = "0xA8A310")]
	public static void cancel(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xA8A560", Offset = "0xA8A560", VA = "0xA8A560")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xA8A6D4", Offset = "0xA8A6D4", VA = "0xA8A6D4")]
	public static void cancel(int uniqueId)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xA8A73C", Offset = "0xA8A73C", VA = "0xA8A73C")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xA8A92C", Offset = "0xA8A92C", VA = "0xA8A92C")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xA8AC90", Offset = "0xA8AC90", VA = "0xA8AC90")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xA8ACF4", Offset = "0xA8ACF4", VA = "0xA8ACF4")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xA8AF98", Offset = "0xA8AF98", VA = "0xA8AF98")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4A6CD8", Offset = "0x4A6CD8")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xA8AFFC", Offset = "0xA8AFFC", VA = "0xA8AFFC")]
	public static void pause(int uniqueId)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xA8B134", Offset = "0xA8B134", VA = "0xA8B134")]
	public static void pause(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xA8B2EC", Offset = "0xA8B2EC", VA = "0xA8B2EC")]
	public static void pauseAll()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xA8B400", Offset = "0xA8B400", VA = "0xA8B400")]
	public static void resumeAll()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xA8B508", Offset = "0xA8B508", VA = "0xA8B508")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4A6D10", Offset = "0x4A6D10")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xA8B56C", Offset = "0xA8B56C", VA = "0xA8B56C")]
	public static void resume(int uniqueId)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xA8B698", Offset = "0xA8B698", VA = "0xA8B698")]
	public static void resume(GameObject gameObject)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xA8B844", Offset = "0xA8B844", VA = "0xA8B844")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xA8BAD0", Offset = "0xA8BAD0", VA = "0xA8BAD0")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xA8BC30", Offset = "0xA8BC30", VA = "0xA8BC30")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xA8BDA0", Offset = "0xA8BDA0", VA = "0xA8BDA0")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xA71248", Offset = "0xA71248", VA = "0xA71248")]
	public static object logError(string error)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xA8C518", Offset = "0xA8C518", VA = "0xA8C518")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xA8C58C", Offset = "0xA8C58C", VA = "0xA8C58C")]
	public static LTDescr options()
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xA8C9FC", Offset = "0xA8C9FC", VA = "0xA8C9FC")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, TweenAction tweenAction, LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xA8CCAC", Offset = "0xA8CCAC", VA = "0xA8CCAC")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xA8CE9C", Offset = "0xA8CE9C", VA = "0xA8CE9C")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xA8CF54", Offset = "0xA8CF54", VA = "0xA8CF54")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xA8D0AC", Offset = "0xA8D0AC", VA = "0xA8D0AC")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xA8D180", Offset = "0xA8D180", VA = "0xA8D180")]
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xA8D254", Offset = "0xA8D254", VA = "0xA8D254")]
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xA8D328", Offset = "0xA8D328", VA = "0xA8D328")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xA8D3E0", Offset = "0xA8D3E0", VA = "0xA8D3E0")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xA8D564", Offset = "0xA8D564", VA = "0xA8D564")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xA8D704", Offset = "0xA8D704", VA = "0xA8D704")]
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xA8D8A4", Offset = "0xA8D8A4", VA = "0xA8D8A4")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xA8D9FC", Offset = "0xA8D9FC", VA = "0xA8D9FC")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xA8DB54", Offset = "0xA8DB54", VA = "0xA8DB54")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xA8DCA4", Offset = "0xA8DCA4", VA = "0xA8DCA4")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xA8DDF4", Offset = "0xA8DDF4", VA = "0xA8DDF4")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xA8DFC0", Offset = "0xA8DFC0", VA = "0xA8DFC0")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xA8E060", Offset = "0xA8E060", VA = "0xA8E060")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xA8E150", Offset = "0xA8E150", VA = "0xA8E150")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xA8E438", Offset = "0xA8E438", VA = "0xA8E438")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xA8E590", Offset = "0xA8E590", VA = "0xA8E590")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xA8E6E8", Offset = "0xA8E6E8", VA = "0xA8E6E8")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xA8E864", Offset = "0xA8E864", VA = "0xA8E864")]
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xA8E9BC", Offset = "0xA8E9BC", VA = "0xA8E9BC")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xA8EB38", Offset = "0xA8EB38", VA = "0xA8EB38")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xA8ECA0", Offset = "0xA8ECA0", VA = "0xA8ECA0")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xA8EE08", Offset = "0xA8EE08", VA = "0xA8EE08")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xA8EEC0", Offset = "0xA8EEC0", VA = "0xA8EEC0")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xA8EF78", Offset = "0xA8EF78", VA = "0xA8EF78")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xA8F030", Offset = "0xA8F030", VA = "0xA8F030")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xA8F0D0", Offset = "0xA8F0D0", VA = "0xA8F0D0")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xA8F3B8", Offset = "0xA8F3B8", VA = "0xA8F3B8")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xA8F470", Offset = "0xA8F470", VA = "0xA8F470")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xA8F528", Offset = "0xA8F528", VA = "0xA8F528")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xA8F5E0", Offset = "0xA8F5E0", VA = "0xA8F5E0")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xA8F738", Offset = "0xA8F738", VA = "0xA8F738")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xA8F890", Offset = "0xA8F890", VA = "0xA8F890")]
	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xA8F9E0", Offset = "0xA8F9E0", VA = "0xA8F9E0")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xA8FA80", Offset = "0xA8FA80", VA = "0xA8FA80")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xA8FBC4", Offset = "0xA8FBC4", VA = "0xA8FBC4")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xA8FC64", Offset = "0xA8FC64", VA = "0xA8FC64")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xA8FD1C", Offset = "0xA8FD1C", VA = "0xA8FD1C")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xA8FDD4", Offset = "0xA8FDD4", VA = "0xA8FDD4")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xA8FE8C", Offset = "0xA8FE8C", VA = "0xA8FE8C")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xA8FFE4", Offset = "0xA8FFE4", VA = "0xA8FFE4")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xA9013C", Offset = "0xA9013C", VA = "0xA9013C")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xA901DC", Offset = "0xA901DC", VA = "0xA901DC")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xA90344", Offset = "0xA90344", VA = "0xA90344")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xA903FC", Offset = "0xA903FC", VA = "0xA903FC")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xA904B4", Offset = "0xA904B4", VA = "0xA904B4")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xA9056C", Offset = "0xA9056C", VA = "0xA9056C")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xA906E0", Offset = "0xA906E0", VA = "0xA906E0")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xA90914", Offset = "0xA90914", VA = "0xA90914")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xA90A54", Offset = "0xA90A54", VA = "0xA90A54")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xA90CEC", Offset = "0xA90CEC", VA = "0xA90CEC")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xA90F90", Offset = "0xA90F90", VA = "0xA90F90")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xA91234", Offset = "0xA91234", VA = "0xA91234")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xA91614", Offset = "0xA91614", VA = "0xA91614")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xA918C0", Offset = "0xA918C0", VA = "0xA918C0")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xA91AFC", Offset = "0xA91AFC", VA = "0xA91AFC")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xA91DA4", Offset = "0xA91DA4", VA = "0xA91DA4")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xA92008", Offset = "0xA92008", VA = "0xA92008")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xA92268", Offset = "0xA92268", VA = "0xA92268")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xA923AC", Offset = "0xA923AC", VA = "0xA923AC")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xA92504", Offset = "0xA92504", VA = "0xA92504")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xA9265C", Offset = "0xA9265C", VA = "0xA9265C")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xA927B4", Offset = "0xA927B4", VA = "0xA927B4")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xA929CC", Offset = "0xA929CC", VA = "0xA929CC")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xA92BBC", Offset = "0xA92BBC", VA = "0xA92BBC")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xA92DAC", Offset = "0xA92DAC", VA = "0xA92DAC")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xA92EF0", Offset = "0xA92EF0", VA = "0xA92EF0")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xA93048", Offset = "0xA93048", VA = "0xA93048")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xA8658C", Offset = "0xA8658C", VA = "0xA8658C")]
	private static float tweenOnCurve(LTDescrImpl tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xA89A08", Offset = "0xA89A08", VA = "0xA89A08")]
	private static Vector3 tweenOnCurveVector(LTDescrImpl tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xA86610", Offset = "0xA86610", VA = "0xA86610")]
	private static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xA86628", Offset = "0xA86628", VA = "0xA86628")]
	private static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xA86638", Offset = "0xA86638", VA = "0xA86638")]
	private static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xA93264", Offset = "0xA93264", VA = "0xA93264")]
	private static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xA932EC", Offset = "0xA932EC", VA = "0xA932EC")]
	private static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xA8761C", Offset = "0xA8761C", VA = "0xA8761C")]
	private static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xA933B8", Offset = "0xA933B8", VA = "0xA933B8")]
	private static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xA933CC", Offset = "0xA933CC", VA = "0xA933CC")]
	private static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xA933E8", Offset = "0xA933E8", VA = "0xA933E8")]
	private static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xA86688", Offset = "0xA86688", VA = "0xA86688")]
	private static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xA866A0", Offset = "0xA866A0", VA = "0xA866A0")]
	private static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xA866C8", Offset = "0xA866C8", VA = "0xA866C8")]
	private static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xA86720", Offset = "0xA86720", VA = "0xA86720")]
	private static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xA8673C", Offset = "0xA8673C", VA = "0xA8673C")]
	private static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xA86764", Offset = "0xA86764", VA = "0xA86764")]
	private static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xA867C0", Offset = "0xA867C0", VA = "0xA867C0")]
	private static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xA867E0", Offset = "0xA867E0", VA = "0xA867E0")]
	private static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xA86810", Offset = "0xA86810", VA = "0xA86810")]
	private static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xA86878", Offset = "0xA86878", VA = "0xA86878")]
	private static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xA86910", Offset = "0xA86910", VA = "0xA86910")]
	private static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xA869A4", Offset = "0xA869A4", VA = "0xA869A4")]
	private static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xA86A48", Offset = "0xA86A48", VA = "0xA86A48")]
	private static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xA86AE0", Offset = "0xA86AE0", VA = "0xA86AE0")]
	private static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xA86B78", Offset = "0xA86B78", VA = "0xA86B78")]
	private static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xA86C68", Offset = "0xA86C68", VA = "0xA86C68")]
	private static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xA86D14", Offset = "0xA86D14", VA = "0xA86D14")]
	private static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xA86DC0", Offset = "0xA86DC0", VA = "0xA86DC0")]
	private static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xA86EB8", Offset = "0xA86EB8", VA = "0xA86EB8")]
	private static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xA86F50", Offset = "0xA86F50", VA = "0xA86F50")]
	private static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xA87020", Offset = "0xA87020", VA = "0xA87020")]
	private static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xA870F8", Offset = "0xA870F8", VA = "0xA870F8")]
	private static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xA8712C", Offset = "0xA8712C", VA = "0xA8712C")]
	private static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xA8716C", Offset = "0xA8716C", VA = "0xA8716C")]
	private static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xA87204", Offset = "0xA87204", VA = "0xA87204")]
	private static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xA87338", Offset = "0xA87338", VA = "0xA87338")]
	private static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xA8745C", Offset = "0xA8745C", VA = "0xA8745C")]
	private static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xA9343C", Offset = "0xA9343C", VA = "0xA9343C")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xA934B4", Offset = "0xA934B4", VA = "0xA934B4")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xA939D4", Offset = "0xA939D4", VA = "0xA939D4")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xA93A4C", Offset = "0xA93A4C", VA = "0xA93A4C")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xA93CC8", Offset = "0xA93CC8", VA = "0xA93CC8")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xA93D30", Offset = "0xA93D30", VA = "0xA93D30")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xA93FAC", Offset = "0xA93FAC", VA = "0xA93FAC")]
	public LeanTween()
	{
	}
}
[Token(Token = "0x2000015")]
public class LTUtility
{
	[Token(Token = "0x600011A")]
	[Address(RVA = "0xA75814", Offset = "0xA75814", VA = "0xA75814")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xA7A244", Offset = "0xA7A244", VA = "0xA7A244")]
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
	[Address(RVA = "0xA70704", Offset = "0xA70704", VA = "0xA70704")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xA70B7C", Offset = "0xA70B7C", VA = "0xA70B7C")]
	private float map(float u)
	{
		return default(float);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xA70AA4", Offset = "0xA70AA4", VA = "0xA70AA4")]
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xA70D9C", Offset = "0xA70D9C", VA = "0xA70D9C")]
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
	[Address(RVA = "0xA70DC0", Offset = "0xA70DC0", VA = "0xA70DC0")]
	public LTBezierPath()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xA70DC8", Offset = "0xA70DC8", VA = "0xA70DC8")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xA70DF8", Offset = "0xA70DF8", VA = "0xA70DF8")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xA71308", Offset = "0xA71308", VA = "0xA71308")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xA714E0", Offset = "0xA714E0", VA = "0xA714E0")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xA71698", Offset = "0xA71698", VA = "0xA71698")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xA718A0", Offset = "0xA718A0", VA = "0xA718A0")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xA71944", Offset = "0xA71944", VA = "0xA71944")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xA71A3C", Offset = "0xA71A3C", VA = "0xA71A3C")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xA71AE0", Offset = "0xA71AE0", VA = "0xA71AE0")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xA71C44", Offset = "0xA71C44", VA = "0xA71C44")]
	public float getRationInOneRange(float ratio)
	{
		return default(float);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xA71CF0", Offset = "0xA71CF0", VA = "0xA71CF0")]
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
	[Address(RVA = "0xA7599C", Offset = "0xA7599C", VA = "0xA7599C")]
	public LTSpline(params Vector3[] pts)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xA791C0", Offset = "0xA791C0", VA = "0xA791C0")]
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xA78CF4", Offset = "0xA78CF4", VA = "0xA78CF4")]
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xA793D4", Offset = "0xA793D4", VA = "0xA793D4")]
	public float ratioAtPoint(Vector3 pt)
	{
		return default(float);
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xA7952C", Offset = "0xA7952C", VA = "0xA7952C")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xA79538", Offset = "0xA79538", VA = "0xA79538")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xA796F4", Offset = "0xA796F4", VA = "0xA796F4")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xA798FC", Offset = "0xA798FC", VA = "0xA798FC")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xA799A0", Offset = "0xA799A0", VA = "0xA799A0")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xA79AA0", Offset = "0xA79AA0", VA = "0xA79AA0")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xA79B44", Offset = "0xA79B44", VA = "0xA79B44")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xA79C9C", Offset = "0xA79C9C", VA = "0xA79C9C")]
	public void gizmoDraw(float t = -1f)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xA79D98", Offset = "0xA79D98", VA = "0xA79D98")]
	public void drawGizmo(Color color)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xA79F28", Offset = "0xA79F28", VA = "0xA79F28")]
	public static void drawGizmo(Transform[] arr, Color color)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xA7A1D4", Offset = "0xA7A1D4", VA = "0xA7A1D4")]
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
		[Address(RVA = "0xA773B0", Offset = "0xA773B0", VA = "0xA773B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000007")]
	public int id
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0xA77BF8", Offset = "0xA77BF8", VA = "0xA77BF8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000008")]
	public float x
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0xA78840", Offset = "0xA78840", VA = "0xA78840")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000147")]
		[Address(RVA = "0xA7884C", Offset = "0xA7884C", VA = "0xA7884C")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public float y
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0xA78858", Offset = "0xA78858", VA = "0xA78858")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000149")]
		[Address(RVA = "0xA78864", Offset = "0xA78864", VA = "0xA78864")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public float width
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0xA78870", Offset = "0xA78870", VA = "0xA78870")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600014B")]
		[Address(RVA = "0xA7887C", Offset = "0xA7887C", VA = "0xA7887C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public float height
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0xA78888", Offset = "0xA78888", VA = "0xA78888")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600014D")]
		[Address(RVA = "0xA78894", Offset = "0xA78894", VA = "0xA78894")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public Rect rect
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0xA74880", Offset = "0xA74880", VA = "0xA74880")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x600014F")]
		[Address(RVA = "0xA788A0", Offset = "0xA788A0", VA = "0xA788A0")]
		set
		{
		}
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xA783DC", Offset = "0xA783DC", VA = "0xA783DC")]
	public LTRect()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xA7553C", Offset = "0xA7553C", VA = "0xA7553C")]
	public LTRect(Rect rect)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xA78538", Offset = "0xA78538", VA = "0xA78538")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xA78628", Offset = "0xA78628", VA = "0xA78628")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xA78728", Offset = "0xA78728", VA = "0xA78728")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xA77C04", Offset = "0xA77C04", VA = "0xA77C04")]
	public void setId(int id, int counter)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xA784B4", Offset = "0xA784B4", VA = "0xA784B4")]
	public void reset()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xA74AA8", Offset = "0xA74AA8", VA = "0xA74AA8")]
	public void resetForRotation()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xA788AC", Offset = "0xA788AC", VA = "0xA788AC")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xA788B4", Offset = "0xA788B4", VA = "0xA788B4")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xA788C0", Offset = "0xA788C0", VA = "0xA788C0")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xA788D4", Offset = "0xA788D4", VA = "0xA788D4")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xA788DC", Offset = "0xA788DC", VA = "0xA788DC")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xA788E4", Offset = "0xA788E4", VA = "0xA788E4")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xA788F8", Offset = "0xA788F8", VA = "0xA788F8")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xA78974", Offset = "0xA78974", VA = "0xA78974")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xA78980", Offset = "0xA78980", VA = "0xA78980", Slot = "3")]
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
	[Address(RVA = "0xA75DC0", Offset = "0xA75DC0", VA = "0xA75DC0")]
	public LTEvent(int id, object data)
	{
	}
}
[Token(Token = "0x200001B")]
public class LTGUI
{
	[Token(Token = "0x200006F")]
	public enum Element_Type
	{
		[Token(Token = "0x40004A0")]
		Texture,
		[Token(Token = "0x40004A1")]
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
	[Address(RVA = "0xA75DFC", Offset = "0xA75DFC", VA = "0xA75DFC")]
	public static void init()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xA75ECC", Offset = "0xA75ECC", VA = "0xA75ECC")]
	public static void initRectCheck()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xA7606C", Offset = "0xA7606C", VA = "0xA7606C")]
	public static void reset()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xA76240", Offset = "0xA76240", VA = "0xA76240")]
	public static void update(int updateLevel)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xA770F0", Offset = "0xA770F0", VA = "0xA770F0")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xA771D0", Offset = "0xA771D0", VA = "0xA771D0")]
	public static void destroy(int id)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xA773C0", Offset = "0xA773C0", VA = "0xA773C0")]
	public static void destroyAll(int depth)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xA774D0", Offset = "0xA774D0", VA = "0xA774D0")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xA77590", Offset = "0xA77590", VA = "0xA77590")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xA77A98", Offset = "0xA77A98", VA = "0xA77A98")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xA77B58", Offset = "0xA77B58", VA = "0xA77B58")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xA77638", Offset = "0xA77638", VA = "0xA77638")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xA77C0C", Offset = "0xA77C0C", VA = "0xA77C0C")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xA78020", Offset = "0xA78020", VA = "0xA78020")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xA78264", Offset = "0xA78264", VA = "0xA78264")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xA78144", Offset = "0xA78144", VA = "0xA78144")]
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xA78338", Offset = "0xA78338", VA = "0xA78338")]
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
public class LeanAudioStream
{
	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int position;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip audioClip;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float[] audioArr;

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xA7B1F0", Offset = "0xA7B1F0", VA = "0xA7B1F0")]
	public LeanAudioStream(float[] audioArr)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xA7BAF4", Offset = "0xA7BAF4", VA = "0xA7BAF4")]
	public void OnAudioRead(float[] data)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xA7BBB4", Offset = "0xA7BBB4", VA = "0xA7BBB4")]
	public void OnAudioSetPosition(int newPosition)
	{
	}
}
[Token(Token = "0x200001E")]
public class LeanAudio
{
	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float MIN_FREQEUNCY_PERIOD;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int PROCESSING_ITERATIONS_MAX;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float[] generatedWaveDistances;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int generatedWaveDistancesCount;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static float[] longList;

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xA7A24C", Offset = "0xA7A24C", VA = "0xA7A24C")]
	public static LeanAudioOptions options()
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xA7A370", Offset = "0xA7A370", VA = "0xA7A370")]
	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xA7B130", Offset = "0xA7B130", VA = "0xA7B130")]
	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xA7A448", Offset = "0xA7A448", VA = "0xA7A448")]
	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		return default(int);
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xA7A9C4", Offset = "0xA7A9C4", VA = "0xA7A9C4")]
	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xA7B21C", Offset = "0xA7B21C", VA = "0xA7B21C")]
	private static void OnAudioSetPosition(int newPosition)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xA7B220", Offset = "0xA7B220", VA = "0xA7B220")]
	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xA7B3D0", Offset = "0xA7B3D0", VA = "0xA7B3D0")]
	public static AudioSource play(AudioClip audio, float volume)
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xA7B61C", Offset = "0xA7B61C", VA = "0xA7B61C")]
	public static AudioSource play(AudioClip audio)
	{
		return null;
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xA7B6D0", Offset = "0xA7B6D0", VA = "0xA7B6D0")]
	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xA7B75C", Offset = "0xA7B75C", VA = "0xA7B75C")]
	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xA7B4AC", Offset = "0xA7B4AC", VA = "0xA7B4AC")]
	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xA7B83C", Offset = "0xA7B83C", VA = "0xA7B83C")]
	public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xA7BA24", Offset = "0xA7BA24", VA = "0xA7BA24")]
	public LeanAudio()
	{
	}
}
[Token(Token = "0x200001F")]
public class LeanAudioOptions
{
	[Token(Token = "0x2000070")]
	public enum LeanAudioWaveStyle
	{
		[Token(Token = "0x40004A3")]
		Sine,
		[Token(Token = "0x40004A4")]
		Square,
		[Token(Token = "0x40004A5")]
		Sawtooth,
		[Token(Token = "0x40004A6")]
		Noise
	}

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LeanAudioWaveStyle waveStyle;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] vibrato;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] modulation;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int frequencyRate;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float waveNoiseScale;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float waveNoiseInfluence;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool useSetData;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LeanAudioStream stream;

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xA7A34C", Offset = "0xA7A34C", VA = "0xA7A34C")]
	public LeanAudioOptions()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xA7BAA0", Offset = "0xA7BAA0", VA = "0xA7BAA0")]
	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xA7BAA8", Offset = "0xA7BAA8", VA = "0xA7BAA8")]
	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xA7BAB0", Offset = "0xA7BAB0", VA = "0xA7BAB0")]
	public LeanAudioOptions setWaveSine()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xA7BAB8", Offset = "0xA7BAB8", VA = "0xA7BAB8")]
	public LeanAudioOptions setWaveSquare()
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xA7BAC4", Offset = "0xA7BAC4", VA = "0xA7BAC4")]
	public LeanAudioOptions setWaveSawtooth()
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xA7BAD0", Offset = "0xA7BAD0", VA = "0xA7BAD0")]
	public LeanAudioOptions setWaveNoise()
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xA7BADC", Offset = "0xA7BADC", VA = "0xA7BADC")]
	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xA7BAE4", Offset = "0xA7BAE4", VA = "0xA7BAE4")]
	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xA7BAEC", Offset = "0xA7BAEC", VA = "0xA7BAEC")]
	public LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		return null;
	}
}
[Token(Token = "0x2000020")]
public class LeanTester : MonoBehaviour
{
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6758", Offset = "0x4A6758")]
	private sealed class <timeoutCheck>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeanTester <>4__this;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <pauseEndTime>5__2;

		[Token(Token = "0x170000FF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0xA7CDF8", Offset = "0xA7CDF8", VA = "0xA7CDF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000100")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0xA7CE68", Offset = "0xA7CE68", VA = "0xA7CE68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xA7CC50", Offset = "0xA7CC50", VA = "0xA7CC50")]
		[DebuggerHidden]
		public <timeoutCheck>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xA7CC8C", Offset = "0xA7CC8C", VA = "0xA7CC8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xA7CC90", Offset = "0xA7CC90", VA = "0xA7CC90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xA7CE00", Offset = "0xA7CE00", VA = "0xA7CE00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeout;

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xA7CBB0", Offset = "0xA7CBB0", VA = "0xA7CBB0")]
	public void Start()
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xA7CBDC", Offset = "0xA7CBDC", VA = "0xA7CBDC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4A6D48", Offset = "0x4A6D48")]
	private IEnumerator timeoutCheck()
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xA7CC7C", Offset = "0xA7CC7C", VA = "0xA7CC7C")]
	public LeanTester()
	{
	}
}
[Token(Token = "0x2000021")]
public class LeanTest
{
	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int expected;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int tests;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int passes;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static float timeout;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool timeoutStarted;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public static bool testsFinished;

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xA7BBBC", Offset = "0xA7BBBC", VA = "0xA7BBBC")]
	public static void debug(string name, bool didPass, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xA7BC38", Offset = "0xA7BC38", VA = "0xA7BC38")]
	public static void expect(bool didPass, string definition, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xA7CA3C", Offset = "0xA7CA3C", VA = "0xA7CA3C")]
	public static string padRight(int len)
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xA7C2D8", Offset = "0xA7C2D8", VA = "0xA7C2D8")]
	public static float printOutLength(string str)
	{
		return default(float);
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xA7CAAC", Offset = "0xA7CAAC", VA = "0xA7CAAC")]
	public static string formatBC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xA7C434", Offset = "0xA7C434", VA = "0xA7C434")]
	public static string formatB(string str)
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xA7C494", Offset = "0xA7C494", VA = "0xA7C494")]
	public static string formatC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xA7C690", Offset = "0xA7C690", VA = "0xA7C690")]
	public static void overview()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xA7CB24", Offset = "0xA7CB24", VA = "0xA7CB24")]
	public LeanTest()
	{
	}
}
[Token(Token = "0x2000022")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4A62F0", Offset = "0x4A62F0")]
public class LeanTweenPath : MonoBehaviour
{
	[Token(Token = "0x2000072")]
	public enum LeanTweenPathType
	{
		[Token(Token = "0x40004AC")]
		bezier,
		[Token(Token = "0x40004AD")]
		spline
	}

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int count;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform[] pts;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3[] path;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LeanTweenPathType pathType;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float controlSize;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool showArrows;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool nodesMaximized;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool creatorMaximized;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	public bool importMaximized;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int i;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int k;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int lastCount;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Color curveColor;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Color lineColor;

	[Token(Token = "0x1700000E")]
	public Vector3[] vec3
	{
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xF63738", Offset = "0xF63738", VA = "0xF63738")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xF638E4", Offset = "0xF638E4", VA = "0xF638E4")]
		set
		{
		}
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xF607C0", Offset = "0xF607C0", VA = "0xF607C0")]
	private void init()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xF61D20", Offset = "0xF61D20", VA = "0xF61D20")]
	private void reset()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xF61B78", Offset = "0xF61B78", VA = "0xF61B78")]
	public Transform createChild(int i, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xF62388", Offset = "0xF62388", VA = "0xF62388")]
	private void initNode(Transform trans, int i)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xF62928", Offset = "0xF62928", VA = "0xF62928")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xF62A7C", Offset = "0xF62A7C", VA = "0xF62A7C")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xF63438", Offset = "0xF63438", VA = "0xF63438")]
	public Vector3[] splineVector()
	{
		return null;
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xF63600", Offset = "0xF63600", VA = "0xF63600")]
	public Vector3[] splineVectorNoEndCaps()
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xF638E8", Offset = "0xF638E8", VA = "0xF638E8")]
	private void resetPath()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xF63A0C", Offset = "0xF63A0C", VA = "0xF63A0C")]
	public void addNode()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xF63A54", Offset = "0xF63A54", VA = "0xF63A54")]
	public void addNodeAfter(int after)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xF644A4", Offset = "0xF644A4", VA = "0xF644A4")]
	public void deleteNode(int i)
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xF64590", Offset = "0xF64590", VA = "0xF64590")]
	public LeanTweenPath()
	{
	}
}
[Token(Token = "0x2000023")]
[ExecuteInEditMode]
public class LeanTweenPathControl : MonoBehaviour
{
	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 lastPos;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3[] lastPosControl;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LeanTweenPathControl[] controlRef;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int i;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool isControl;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool isBezier;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Material matPoints;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Material matControls;

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xF645B0", Offset = "0xF645B0", VA = "0xF645B0")]
	public void createMaterials()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xF647CC", Offset = "0xF647CC", VA = "0xF647CC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xF647D0", Offset = "0xF647D0", VA = "0xF647D0")]
	private void OnApplicationFocus()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xF64888", Offset = "0xF64888", VA = "0xF64888")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xF6482C", Offset = "0xF6482C", VA = "0xF6482C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xF62620", Offset = "0xF62620", VA = "0xF62620")]
	public void init(LeanTweenPathControl[] controlRef, int i, bool isControl)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xF62874", Offset = "0xF62874", VA = "0xF62874")]
	public void init(int i)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xF648E4", Offset = "0xF648E4", VA = "0xF648E4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xF65050", Offset = "0xF65050", VA = "0xF65050")]
	public LeanTweenPathControl()
	{
	}
}
[Token(Token = "0x2000024")]
public interface LTDescr
{
	[Token(Token = "0x1700000F")]
	bool toggle
	{
		[Token(Token = "0x600020C")]
		get;
		[Token(Token = "0x600020D")]
		set;
	}

	[Token(Token = "0x17000010")]
	bool useEstimatedTime
	{
		[Token(Token = "0x600020E")]
		get;
		[Token(Token = "0x600020F")]
		set;
	}

	[Token(Token = "0x17000011")]
	bool useFrames
	{
		[Token(Token = "0x6000210")]
		get;
		[Token(Token = "0x6000211")]
		set;
	}

	[Token(Token = "0x17000012")]
	bool useManualTime
	{
		[Token(Token = "0x6000212")]
		get;
		[Token(Token = "0x6000213")]
		set;
	}

	[Token(Token = "0x17000013")]
	bool hasInitiliazed
	{
		[Token(Token = "0x6000214")]
		get;
		[Token(Token = "0x6000215")]
		set;
	}

	[Token(Token = "0x17000014")]
	bool hasPhysics
	{
		[Token(Token = "0x6000216")]
		get;
		[Token(Token = "0x6000217")]
		set;
	}

	[Token(Token = "0x17000015")]
	bool onCompleteOnRepeat
	{
		[Token(Token = "0x6000218")]
		get;
		[Token(Token = "0x6000219")]
		set;
	}

	[Token(Token = "0x17000016")]
	bool onCompleteOnStart
	{
		[Token(Token = "0x600021A")]
		get;
		[Token(Token = "0x600021B")]
		set;
	}

	[Token(Token = "0x17000017")]
	bool useRecursion
	{
		[Token(Token = "0x600021C")]
		get;
		[Token(Token = "0x600021D")]
		set;
	}

	[Token(Token = "0x17000018")]
	float passed
	{
		[Token(Token = "0x600021E")]
		get;
		[Token(Token = "0x600021F")]
		set;
	}

	[Token(Token = "0x17000019")]
	float delay
	{
		[Token(Token = "0x6000220")]
		get;
		[Token(Token = "0x6000221")]
		set;
	}

	[Token(Token = "0x1700001A")]
	float time
	{
		[Token(Token = "0x6000222")]
		get;
		[Token(Token = "0x6000223")]
		set;
	}

	[Token(Token = "0x1700001B")]
	float lastVal
	{
		[Token(Token = "0x6000224")]
		get;
		[Token(Token = "0x6000225")]
		set;
	}

	[Token(Token = "0x1700001C")]
	int loopCount
	{
		[Token(Token = "0x6000226")]
		get;
		[Token(Token = "0x6000227")]
		set;
	}

	[Token(Token = "0x1700001D")]
	uint counter
	{
		[Token(Token = "0x6000228")]
		get;
		[Token(Token = "0x6000229")]
		set;
	}

	[Token(Token = "0x1700001E")]
	float direction
	{
		[Token(Token = "0x600022A")]
		get;
		[Token(Token = "0x600022B")]
		set;
	}

	[Token(Token = "0x1700001F")]
	float directionLast
	{
		[Token(Token = "0x600022C")]
		get;
		[Token(Token = "0x600022D")]
		set;
	}

	[Token(Token = "0x17000020")]
	float overshoot
	{
		[Token(Token = "0x600022E")]
		get;
		[Token(Token = "0x600022F")]
		set;
	}

	[Token(Token = "0x17000021")]
	float period
	{
		[Token(Token = "0x6000230")]
		get;
		[Token(Token = "0x6000231")]
		set;
	}

	[Token(Token = "0x17000022")]
	bool destroyOnComplete
	{
		[Token(Token = "0x6000232")]
		get;
		[Token(Token = "0x6000233")]
		set;
	}

	[Token(Token = "0x17000023")]
	Transform trans
	{
		[Token(Token = "0x6000234")]
		get;
		[Token(Token = "0x6000235")]
		set;
	}

	[Token(Token = "0x17000024")]
	Transform toTrans
	{
		[Token(Token = "0x6000236")]
		get;
		[Token(Token = "0x6000237")]
		set;
	}

	[Token(Token = "0x17000025")]
	LTRect ltRect
	{
		[Token(Token = "0x6000238")]
		get;
		[Token(Token = "0x6000239")]
		set;
	}

	[Token(Token = "0x17000026")]
	Vector3 from
	{
		[Token(Token = "0x600023A")]
		get;
		[Token(Token = "0x600023B")]
		set;
	}

	[Token(Token = "0x17000027")]
	Vector3 to
	{
		[Token(Token = "0x600023C")]
		get;
		[Token(Token = "0x600023D")]
		set;
	}

	[Token(Token = "0x17000028")]
	Vector3 diff
	{
		[Token(Token = "0x600023E")]
		get;
		[Token(Token = "0x600023F")]
		set;
	}

	[Token(Token = "0x17000029")]
	Vector3 point
	{
		[Token(Token = "0x6000240")]
		get;
		[Token(Token = "0x6000241")]
		set;
	}

	[Token(Token = "0x1700002A")]
	Vector3 axis
	{
		[Token(Token = "0x6000242")]
		get;
		[Token(Token = "0x6000243")]
		set;
	}

	[Token(Token = "0x1700002B")]
	Quaternion origRotation
	{
		[Token(Token = "0x6000244")]
		get;
		[Token(Token = "0x6000245")]
		set;
	}

	[Token(Token = "0x1700002C")]
	LTBezierPath path
	{
		[Token(Token = "0x6000246")]
		get;
		[Token(Token = "0x6000247")]
		set;
	}

	[Token(Token = "0x1700002D")]
	LTSpline spline
	{
		[Token(Token = "0x6000248")]
		get;
		[Token(Token = "0x6000249")]
		set;
	}

	[Token(Token = "0x1700002E")]
	TweenAction type
	{
		[Token(Token = "0x600024A")]
		get;
		[Token(Token = "0x600024B")]
		set;
	}

	[Token(Token = "0x1700002F")]
	LeanTweenType tweenType
	{
		[Token(Token = "0x600024C")]
		get;
		[Token(Token = "0x600024D")]
		set;
	}

	[Token(Token = "0x17000030")]
	AnimationCurve animationCurve
	{
		[Token(Token = "0x600024E")]
		get;
		[Token(Token = "0x600024F")]
		set;
	}

	[Token(Token = "0x17000031")]
	LeanTweenType loopType
	{
		[Token(Token = "0x6000250")]
		get;
		[Token(Token = "0x6000251")]
		set;
	}

	[Token(Token = "0x17000032")]
	bool hasUpdateCallback
	{
		[Token(Token = "0x6000252")]
		get;
		[Token(Token = "0x6000253")]
		set;
	}

	[Token(Token = "0x17000033")]
	Action<float> onUpdateFloat
	{
		[Token(Token = "0x6000254")]
		get;
		[Token(Token = "0x6000255")]
		set;
	}

	[Token(Token = "0x17000034")]
	Action<float, float> onUpdateFloatRatio
	{
		[Token(Token = "0x6000256")]
		get;
		[Token(Token = "0x6000257")]
		set;
	}

	[Token(Token = "0x17000035")]
	Action<float, object> onUpdateFloatObject
	{
		[Token(Token = "0x6000258")]
		get;
		[Token(Token = "0x6000259")]
		set;
	}

	[Token(Token = "0x17000036")]
	Action<Vector2> onUpdateVector2
	{
		[Token(Token = "0x600025A")]
		get;
		[Token(Token = "0x600025B")]
		set;
	}

	[Token(Token = "0x17000037")]
	Action<Vector3> onUpdateVector3
	{
		[Token(Token = "0x600025C")]
		get;
		[Token(Token = "0x600025D")]
		set;
	}

	[Token(Token = "0x17000038")]
	Action<Vector3, object> onUpdateVector3Object
	{
		[Token(Token = "0x600025E")]
		get;
		[Token(Token = "0x600025F")]
		set;
	}

	[Token(Token = "0x17000039")]
	Action<Color> onUpdateColor
	{
		[Token(Token = "0x6000260")]
		get;
		[Token(Token = "0x6000261")]
		set;
	}

	[Token(Token = "0x1700003A")]
	Action onComplete
	{
		[Token(Token = "0x6000262")]
		get;
		[Token(Token = "0x6000263")]
		set;
	}

	[Token(Token = "0x1700003B")]
	Action<object> onCompleteObject
	{
		[Token(Token = "0x6000264")]
		get;
		[Token(Token = "0x6000265")]
		set;
	}

	[Token(Token = "0x1700003C")]
	object onCompleteParam
	{
		[Token(Token = "0x6000266")]
		get;
		[Token(Token = "0x6000267")]
		set;
	}

	[Token(Token = "0x1700003D")]
	object onUpdateParam
	{
		[Token(Token = "0x6000268")]
		get;
		[Token(Token = "0x6000269")]
		set;
	}

	[Token(Token = "0x1700003E")]
	Action onStart
	{
		[Token(Token = "0x600026A")]
		get;
		[Token(Token = "0x600026B")]
		set;
	}

	[Token(Token = "0x1700003F")]
	int uniqueId
	{
		[Token(Token = "0x600026E")]
		get;
	}

	[Token(Token = "0x17000040")]
	int id
	{
		[Token(Token = "0x600026F")]
		get;
	}

	[Token(Token = "0x600026C")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4A6DAC", Offset = "0x4A6DAC")]
	LTDescr cancel(GameObject gameObject);

	[Token(Token = "0x600026D")]
	void cleanup();

	[Token(Token = "0x6000270")]
	void init();

	[Token(Token = "0x6000271")]
	LTDescr pause();

	[Token(Token = "0x6000272")]
	void reset();

	[Token(Token = "0x6000273")]
	LTDescr resume();

	[Token(Token = "0x6000274")]
	LTDescr setAudio(object audio);

	[Token(Token = "0x6000275")]
	LTDescr setAxis(Vector3 axis);

	[Token(Token = "0x6000276")]
	LTDescr setDelay(float delay);

	[Token(Token = "0x6000277")]
	LTDescr setDestroyOnComplete(bool doesDestroy);

	[Token(Token = "0x6000278")]
	LTDescr setDiff(Vector3 diff);

	[Token(Token = "0x6000279")]
	LTDescr setDirection(float direction);

	[Token(Token = "0x600027A")]
	LTDescr setEase(LeanTweenType easeType);

	[Token(Token = "0x600027B")]
	LTDescr setEase(AnimationCurve easeCurve);

	[Token(Token = "0x600027C")]
	LTDescr setFrom(float from);

	[Token(Token = "0x600027D")]
	LTDescr setFrom(Vector3 from);

	[Token(Token = "0x600027E")]
	LTDescr setFromColor(Color col);

	[Token(Token = "0x600027F")]
	LTDescr setHasInitialized(bool has);

	[Token(Token = "0x6000280")]
	LTDescr setId(uint id);

	[Token(Token = "0x6000281")]
	LTDescr setIgnoreTimeScale(bool useUnScaledTime);

	[Token(Token = "0x6000282")]
	LTDescr setLoopClamp();

	[Token(Token = "0x6000283")]
	LTDescr setLoopClamp(int loops);

	[Token(Token = "0x6000284")]
	LTDescr setLoopCount(int loopCount);

	[Token(Token = "0x6000285")]
	LTDescr setLoopOnce();

	[Token(Token = "0x6000286")]
	LTDescr setLoopPingPong();

	[Token(Token = "0x6000287")]
	LTDescr setLoopPingPong(int loops);

	[Token(Token = "0x6000288")]
	LTDescr setLoopType(LeanTweenType loopType);

	[Token(Token = "0x6000289")]
	LTDescr setOnComplete(Action onComplete);

	[Token(Token = "0x600028A")]
	LTDescr setOnComplete(Action<object> onComplete);

	[Token(Token = "0x600028B")]
	LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam);

	[Token(Token = "0x600028C")]
	LTDescr setOnCompleteOnRepeat(bool isOn);

	[Token(Token = "0x600028D")]
	LTDescr setOnCompleteOnStart(bool isOn);

	[Token(Token = "0x600028E")]
	LTDescr setOnCompleteParam(object onCompleteParam);

	[Token(Token = "0x600028F")]
	LTDescr setOnStart(Action onStart);

	[Token(Token = "0x6000290")]
	LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam);

	[Token(Token = "0x6000291")]
	LTDescr setOnUpdate(Action<float> onUpdate);

	[Token(Token = "0x6000292")]
	LTDescr setOnUpdate(Action<Color> onUpdate);

	[Token(Token = "0x6000293")]
	LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam);

	[Token(Token = "0x6000294")]
	LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam);

	[Token(Token = "0x6000295")]
	LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam);

	[Token(Token = "0x6000296")]
	LTDescr setOnUpdateColor(Action<Color> onUpdate);

	[Token(Token = "0x6000297")]
	LTDescr setOnUpdateObject(Action<float, object> onUpdate);

	[Token(Token = "0x6000298")]
	LTDescr setOnUpdateParam(object onUpdateParam);

	[Token(Token = "0x6000299")]
	LTDescr setOnUpdateRatio(Action<float, float> onUpdate);

	[Token(Token = "0x600029A")]
	LTDescr setOnUpdateVector2(Action<Vector2> onUpdate);

	[Token(Token = "0x600029B")]
	LTDescr setOnUpdateVector3(Action<Vector3> onUpdate);

	[Token(Token = "0x600029C")]
	LTDescr setOrientToPath(bool doesOrient);

	[Token(Token = "0x600029D")]
	LTDescr setOrientToPath2d(bool doesOrient2d);

	[Token(Token = "0x600029E")]
	LTDescr setOvershoot(float overshoot);

	[Token(Token = "0x600029F")]
	LTDescr setPath(LTBezierPath path);

	[Token(Token = "0x60002A0")]
	LTDescr setPeriod(float period);

	[Token(Token = "0x60002A1")]
	LTDescr setPoint(Vector3 point);

	[Token(Token = "0x60002A2")]
	LTDescr setRect(LTRect rect);

	[Token(Token = "0x60002A3")]
	LTDescr setRect(Rect rect);

	[Token(Token = "0x60002A4")]
	LTDescr setRepeat(int repeat);

	[Token(Token = "0x60002A5")]
	LTDescr setRecursive(bool useRecursion);

	[Token(Token = "0x60002A6")]
	LTDescr setRect(RectTransform rect);

	[Token(Token = "0x60002A7")]
	LTDescr setSprites(Sprite[] sprites);

	[Token(Token = "0x60002A8")]
	LTDescr setFrameRate(float frameRate);

	[Token(Token = "0x60002A9")]
	LTDescr setTime(float time);

	[Token(Token = "0x60002AA")]
	LTDescr setTo(Transform to);

	[Token(Token = "0x60002AB")]
	LTDescr setTo(Vector3 to);

	[Token(Token = "0x60002AC")]
	LTDescr setUseEstimatedTime(bool useEstimatedTime);

	[Token(Token = "0x60002AD")]
	LTDescr setUseFrames(bool useFrames);

	[Token(Token = "0x60002AE")]
	LTDescr setUseManualTime(bool useManualTime);

	[Token(Token = "0x60002AF")]
	new string ToString();
}
[Token(Token = "0x2000025")]
public class LTDescrImpl : LTDescr
{
	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6908", Offset = "0x4A6908")]
	private bool <toggle>k__BackingField;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6918", Offset = "0x4A6918")]
	private bool <useEstimatedTime>k__BackingField;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6928", Offset = "0x4A6928")]
	private bool <useFrames>k__BackingField;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6938", Offset = "0x4A6938")]
	private bool <useManualTime>k__BackingField;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6948", Offset = "0x4A6948")]
	private bool <hasInitiliazed>k__BackingField;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6958", Offset = "0x4A6958")]
	private bool <hasPhysics>k__BackingField;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6968", Offset = "0x4A6968")]
	private bool <onCompleteOnRepeat>k__BackingField;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6978", Offset = "0x4A6978")]
	private bool <onCompleteOnStart>k__BackingField;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6988", Offset = "0x4A6988")]
	private bool <useRecursion>k__BackingField;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6998", Offset = "0x4A6998")]
	private float <passed>k__BackingField;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A69A8", Offset = "0x4A69A8")]
	private float <delay>k__BackingField;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A69B8", Offset = "0x4A69B8")]
	private float <time>k__BackingField;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A69C8", Offset = "0x4A69C8")]
	private float <lastVal>k__BackingField;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private uint _id;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A69D8", Offset = "0x4A69D8")]
	private int <loopCount>k__BackingField;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A69E8", Offset = "0x4A69E8")]
	private uint <counter>k__BackingField;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A69F8", Offset = "0x4A69F8")]
	private float <direction>k__BackingField;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6A08", Offset = "0x4A6A08")]
	private float <directionLast>k__BackingField;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6A18", Offset = "0x4A6A18")]
	private float <overshoot>k__BackingField;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6A28", Offset = "0x4A6A28")]
	private float <period>k__BackingField;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6A38", Offset = "0x4A6A38")]
	private bool <destroyOnComplete>k__BackingField;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6A48", Offset = "0x4A6A48")]
	private Transform <trans>k__BackingField;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6A58", Offset = "0x4A6A58")]
	private Transform <toTrans>k__BackingField;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6A68", Offset = "0x4A6A68")]
	private LTRect <ltRect>k__BackingField;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	internal Vector3 fromInternal;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	internal Vector3 toInternal;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	internal Vector3 diffInternal;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6A78", Offset = "0x4A6A78")]
	private Vector3 <point>k__BackingField;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6A88", Offset = "0x4A6A88")]
	private Vector3 <axis>k__BackingField;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6A98", Offset = "0x4A6A98")]
	private Quaternion <origRotation>k__BackingField;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6AA8", Offset = "0x4A6AA8")]
	private LTBezierPath <path>k__BackingField;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6AB8", Offset = "0x4A6AB8")]
	private LTSpline <spline>k__BackingField;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6AC8", Offset = "0x4A6AC8")]
	private TweenAction <type>k__BackingField;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6AD8", Offset = "0x4A6AD8")]
	private LeanTweenType <tweenType>k__BackingField;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6AE8", Offset = "0x4A6AE8")]
	private AnimationCurve <animationCurve>k__BackingField;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6AF8", Offset = "0x4A6AF8")]
	private LeanTweenType <loopType>k__BackingField;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6B08", Offset = "0x4A6B08")]
	private bool <hasUpdateCallback>k__BackingField;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6B18", Offset = "0x4A6B18")]
	private Action<float> <onUpdateFloat>k__BackingField;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6B28", Offset = "0x4A6B28")]
	private Action<float, float> <onUpdateFloatRatio>k__BackingField;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6B38", Offset = "0x4A6B38")]
	private Action<float, object> <onUpdateFloatObject>k__BackingField;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6B48", Offset = "0x4A6B48")]
	private Action<Vector2> <onUpdateVector2>k__BackingField;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6B58", Offset = "0x4A6B58")]
	private Action<Vector3> <onUpdateVector3>k__BackingField;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6B68", Offset = "0x4A6B68")]
	private Action<Vector3, object> <onUpdateVector3Object>k__BackingField;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6B78", Offset = "0x4A6B78")]
	private Action<Color> <onUpdateColor>k__BackingField;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6B88", Offset = "0x4A6B88")]
	private Action <onComplete>k__BackingField;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6B98", Offset = "0x4A6B98")]
	private Action<object> <onCompleteObject>k__BackingField;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6BA8", Offset = "0x4A6BA8")]
	private object <onCompleteParam>k__BackingField;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6BB8", Offset = "0x4A6BB8")]
	private object <onUpdateParam>k__BackingField;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6BC8", Offset = "0x4A6BC8")]
	private Action <onStart>k__BackingField;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public RectTransform rectTransform;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Text uiText;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public Image uiImage;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Sprite[] sprites;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static uint global_counter;

	[Token(Token = "0x17000041")]
	public bool toggle
	{
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xA71DCC", Offset = "0xA71DCC", VA = "0xA71DCC", Slot = "4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6DE4", Offset = "0x4A6DE4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xA71DD4", Offset = "0xA71DD4", VA = "0xA71DD4", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6DF4", Offset = "0x4A6DF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000042")]
	public bool useEstimatedTime
	{
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xA71DE0", Offset = "0xA71DE0", VA = "0xA71DE0", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6E04", Offset = "0x4A6E04")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xA71DE8", Offset = "0xA71DE8", VA = "0xA71DE8", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6E14", Offset = "0x4A6E14")]
		set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public bool useFrames
	{
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xA71DF4", Offset = "0xA71DF4", VA = "0xA71DF4", Slot = "8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6E24", Offset = "0x4A6E24")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xA71DFC", Offset = "0xA71DFC", VA = "0xA71DFC", Slot = "9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6E34", Offset = "0x4A6E34")]
		set
		{
		}
	}

	[Token(Token = "0x17000044")]
	public bool useManualTime
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xA71E08", Offset = "0xA71E08", VA = "0xA71E08", Slot = "10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6E44", Offset = "0x4A6E44")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xA71E10", Offset = "0xA71E10", VA = "0xA71E10", Slot = "11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6E54", Offset = "0x4A6E54")]
		set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public bool hasInitiliazed
	{
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xA71E1C", Offset = "0xA71E1C", VA = "0xA71E1C", Slot = "12")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6E64", Offset = "0x4A6E64")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xA71E24", Offset = "0xA71E24", VA = "0xA71E24", Slot = "13")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6E74", Offset = "0x4A6E74")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public bool hasPhysics
	{
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xA71E30", Offset = "0xA71E30", VA = "0xA71E30", Slot = "14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6E84", Offset = "0x4A6E84")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xA71E38", Offset = "0xA71E38", VA = "0xA71E38", Slot = "15")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6E94", Offset = "0x4A6E94")]
		set
		{
		}
	}

	[Token(Token = "0x17000047")]
	public bool onCompleteOnRepeat
	{
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xA71E44", Offset = "0xA71E44", VA = "0xA71E44", Slot = "16")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6EA4", Offset = "0x4A6EA4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xA71E4C", Offset = "0xA71E4C", VA = "0xA71E4C", Slot = "17")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6EB4", Offset = "0x4A6EB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public bool onCompleteOnStart
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xA71E58", Offset = "0xA71E58", VA = "0xA71E58", Slot = "18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6EC4", Offset = "0x4A6EC4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xA71E60", Offset = "0xA71E60", VA = "0xA71E60", Slot = "19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6ED4", Offset = "0x4A6ED4")]
		set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public bool useRecursion
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xA71E6C", Offset = "0xA71E6C", VA = "0xA71E6C", Slot = "20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6EE4", Offset = "0x4A6EE4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xA71E74", Offset = "0xA71E74", VA = "0xA71E74", Slot = "21")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6EF4", Offset = "0x4A6EF4")]
		set
		{
		}
	}

	[Token(Token = "0x1700004A")]
	public float passed
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xA71E80", Offset = "0xA71E80", VA = "0xA71E80", Slot = "22")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6F04", Offset = "0x4A6F04")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xA71E88", Offset = "0xA71E88", VA = "0xA71E88", Slot = "23")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6F14", Offset = "0x4A6F14")]
		set
		{
		}
	}

	[Token(Token = "0x1700004B")]
	public float delay
	{
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xA71E90", Offset = "0xA71E90", VA = "0xA71E90", Slot = "24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6F24", Offset = "0x4A6F24")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xA71E98", Offset = "0xA71E98", VA = "0xA71E98", Slot = "25")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6F34", Offset = "0x4A6F34")]
		set
		{
		}
	}

	[Token(Token = "0x1700004C")]
	public float time
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xA71EA0", Offset = "0xA71EA0", VA = "0xA71EA0", Slot = "26")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6F44", Offset = "0x4A6F44")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xA71EA8", Offset = "0xA71EA8", VA = "0xA71EA8", Slot = "27")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6F54", Offset = "0x4A6F54")]
		set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	public float lastVal
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xA71EB0", Offset = "0xA71EB0", VA = "0xA71EB0", Slot = "28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6F64", Offset = "0x4A6F64")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xA71EB8", Offset = "0xA71EB8", VA = "0xA71EB8", Slot = "29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6F74", Offset = "0x4A6F74")]
		set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	public int loopCount
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xA71EC0", Offset = "0xA71EC0", VA = "0xA71EC0", Slot = "30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6F84", Offset = "0x4A6F84")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xA71EC8", Offset = "0xA71EC8", VA = "0xA71EC8", Slot = "31")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6F94", Offset = "0x4A6F94")]
		set
		{
		}
	}

	[Token(Token = "0x1700004F")]
	public uint counter
	{
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xA71ED0", Offset = "0xA71ED0", VA = "0xA71ED0", Slot = "32")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6FA4", Offset = "0x4A6FA4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xA71ED8", Offset = "0xA71ED8", VA = "0xA71ED8", Slot = "33")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6FB4", Offset = "0x4A6FB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000050")]
	public float direction
	{
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xA71EE0", Offset = "0xA71EE0", VA = "0xA71EE0", Slot = "34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6FC4", Offset = "0x4A6FC4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xA71EE8", Offset = "0xA71EE8", VA = "0xA71EE8", Slot = "35")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6FD4", Offset = "0x4A6FD4")]
		set
		{
		}
	}

	[Token(Token = "0x17000051")]
	public float directionLast
	{
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xA71EF0", Offset = "0xA71EF0", VA = "0xA71EF0", Slot = "36")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6FE4", Offset = "0x4A6FE4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xA71EF8", Offset = "0xA71EF8", VA = "0xA71EF8", Slot = "37")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6FF4", Offset = "0x4A6FF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public float overshoot
	{
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xA71F00", Offset = "0xA71F00", VA = "0xA71F00", Slot = "38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7004", Offset = "0x4A7004")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xA71F08", Offset = "0xA71F08", VA = "0xA71F08", Slot = "39")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7014", Offset = "0x4A7014")]
		set
		{
		}
	}

	[Token(Token = "0x17000053")]
	public float period
	{
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xA71F10", Offset = "0xA71F10", VA = "0xA71F10", Slot = "40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7024", Offset = "0x4A7024")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xA71F18", Offset = "0xA71F18", VA = "0xA71F18", Slot = "41")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7034", Offset = "0x4A7034")]
		set
		{
		}
	}

	[Token(Token = "0x17000054")]
	public bool destroyOnComplete
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xA71F20", Offset = "0xA71F20", VA = "0xA71F20", Slot = "42")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7044", Offset = "0x4A7044")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xA71F28", Offset = "0xA71F28", VA = "0xA71F28", Slot = "43")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7054", Offset = "0x4A7054")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	public Transform trans
	{
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xA71F34", Offset = "0xA71F34", VA = "0xA71F34", Slot = "44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7064", Offset = "0x4A7064")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xA71F3C", Offset = "0xA71F3C", VA = "0xA71F3C", Slot = "45")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7074", Offset = "0x4A7074")]
		set
		{
		}
	}

	[Token(Token = "0x17000056")]
	public Transform toTrans
	{
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xA71F44", Offset = "0xA71F44", VA = "0xA71F44", Slot = "46")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7084", Offset = "0x4A7084")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xA71F4C", Offset = "0xA71F4C", VA = "0xA71F4C", Slot = "47")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7094", Offset = "0x4A7094")]
		set
		{
		}
	}

	[Token(Token = "0x17000057")]
	public LTRect ltRect
	{
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xA71F54", Offset = "0xA71F54", VA = "0xA71F54", Slot = "48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A70A4", Offset = "0x4A70A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xA71F5C", Offset = "0xA71F5C", VA = "0xA71F5C", Slot = "49")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A70B4", Offset = "0x4A70B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000058")]
	public Vector3 from
	{
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xA71F64", Offset = "0xA71F64", VA = "0xA71F64", Slot = "50")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xA71F70", Offset = "0xA71F70", VA = "0xA71F70", Slot = "51")]
		set
		{
		}
	}

	[Token(Token = "0x17000059")]
	public Vector3 to
	{
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xA71F7C", Offset = "0xA71F7C", VA = "0xA71F7C", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xA71F88", Offset = "0xA71F88", VA = "0xA71F88", Slot = "53")]
		set
		{
		}
	}

	[Token(Token = "0x1700005A")]
	public Vector3 diff
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xA71F94", Offset = "0xA71F94", VA = "0xA71F94", Slot = "54")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xA71FA0", Offset = "0xA71FA0", VA = "0xA71FA0", Slot = "55")]
		set
		{
		}
	}

	[Token(Token = "0x1700005B")]
	public Vector3 point
	{
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xA71FAC", Offset = "0xA71FAC", VA = "0xA71FAC", Slot = "56")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A70C4", Offset = "0x4A70C4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xA71FB8", Offset = "0xA71FB8", VA = "0xA71FB8", Slot = "57")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A70D4", Offset = "0x4A70D4")]
		set
		{
		}
	}

	[Token(Token = "0x1700005C")]
	public Vector3 axis
	{
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xA71FC4", Offset = "0xA71FC4", VA = "0xA71FC4", Slot = "58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A70E4", Offset = "0x4A70E4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xA71FD0", Offset = "0xA71FD0", VA = "0xA71FD0", Slot = "59")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A70F4", Offset = "0x4A70F4")]
		set
		{
		}
	}

	[Token(Token = "0x1700005D")]
	public Quaternion origRotation
	{
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xA71FDC", Offset = "0xA71FDC", VA = "0xA71FDC", Slot = "60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7104", Offset = "0x4A7104")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xA71FE8", Offset = "0xA71FE8", VA = "0xA71FE8", Slot = "61")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7114", Offset = "0x4A7114")]
		set
		{
		}
	}

	[Token(Token = "0x1700005E")]
	public LTBezierPath path
	{
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xA71FF4", Offset = "0xA71FF4", VA = "0xA71FF4", Slot = "62")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7124", Offset = "0x4A7124")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xA71FFC", Offset = "0xA71FFC", VA = "0xA71FFC", Slot = "63")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7134", Offset = "0x4A7134")]
		set
		{
		}
	}

	[Token(Token = "0x1700005F")]
	public LTSpline spline
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xA72004", Offset = "0xA72004", VA = "0xA72004", Slot = "64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7144", Offset = "0x4A7144")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xA7200C", Offset = "0xA7200C", VA = "0xA7200C", Slot = "65")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7154", Offset = "0x4A7154")]
		set
		{
		}
	}

	[Token(Token = "0x17000060")]
	public TweenAction type
	{
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xA72014", Offset = "0xA72014", VA = "0xA72014", Slot = "66")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7164", Offset = "0x4A7164")]
		get
		{
			return default(TweenAction);
		}
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xA7201C", Offset = "0xA7201C", VA = "0xA7201C", Slot = "67")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7174", Offset = "0x4A7174")]
		set
		{
		}
	}

	[Token(Token = "0x17000061")]
	public LeanTweenType tweenType
	{
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xA72024", Offset = "0xA72024", VA = "0xA72024", Slot = "68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7184", Offset = "0x4A7184")]
		get
		{
			return default(LeanTweenType);
		}
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xA7202C", Offset = "0xA7202C", VA = "0xA7202C", Slot = "69")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7194", Offset = "0x4A7194")]
		set
		{
		}
	}

	[Token(Token = "0x17000062")]
	public AnimationCurve animationCurve
	{
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xA72034", Offset = "0xA72034", VA = "0xA72034", Slot = "70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A71A4", Offset = "0x4A71A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xA7203C", Offset = "0xA7203C", VA = "0xA7203C", Slot = "71")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A71B4", Offset = "0x4A71B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000063")]
	public LeanTweenType loopType
	{
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xA72044", Offset = "0xA72044", VA = "0xA72044", Slot = "72")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A71C4", Offset = "0x4A71C4")]
		get
		{
			return default(LeanTweenType);
		}
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xA7204C", Offset = "0xA7204C", VA = "0xA7204C", Slot = "73")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A71D4", Offset = "0x4A71D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000064")]
	public bool hasUpdateCallback
	{
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xA72054", Offset = "0xA72054", VA = "0xA72054", Slot = "74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A71E4", Offset = "0x4A71E4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xA7205C", Offset = "0xA7205C", VA = "0xA7205C", Slot = "75")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A71F4", Offset = "0x4A71F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000065")]
	public Action<float> onUpdateFloat
	{
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xA72068", Offset = "0xA72068", VA = "0xA72068", Slot = "76")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7204", Offset = "0x4A7204")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xA72070", Offset = "0xA72070", VA = "0xA72070", Slot = "77")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7214", Offset = "0x4A7214")]
		set
		{
		}
	}

	[Token(Token = "0x17000066")]
	public Action<float, float> onUpdateFloatRatio
	{
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xA72078", Offset = "0xA72078", VA = "0xA72078", Slot = "78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7224", Offset = "0x4A7224")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xA72080", Offset = "0xA72080", VA = "0xA72080", Slot = "79")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7234", Offset = "0x4A7234")]
		set
		{
		}
	}

	[Token(Token = "0x17000067")]
	public Action<float, object> onUpdateFloatObject
	{
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xA72088", Offset = "0xA72088", VA = "0xA72088", Slot = "80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7244", Offset = "0x4A7244")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xA72090", Offset = "0xA72090", VA = "0xA72090", Slot = "81")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7254", Offset = "0x4A7254")]
		set
		{
		}
	}

	[Token(Token = "0x17000068")]
	public Action<Vector2> onUpdateVector2
	{
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xA72098", Offset = "0xA72098", VA = "0xA72098", Slot = "82")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7264", Offset = "0x4A7264")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xA720A0", Offset = "0xA720A0", VA = "0xA720A0", Slot = "83")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7274", Offset = "0x4A7274")]
		set
		{
		}
	}

	[Token(Token = "0x17000069")]
	public Action<Vector3> onUpdateVector3
	{
		[Token(Token = "0x6000300")]
		[Address(RVA = "0xA720A8", Offset = "0xA720A8", VA = "0xA720A8", Slot = "84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7284", Offset = "0x4A7284")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000301")]
		[Address(RVA = "0xA720B0", Offset = "0xA720B0", VA = "0xA720B0", Slot = "85")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7294", Offset = "0x4A7294")]
		set
		{
		}
	}

	[Token(Token = "0x1700006A")]
	public Action<Vector3, object> onUpdateVector3Object
	{
		[Token(Token = "0x6000302")]
		[Address(RVA = "0xA720B8", Offset = "0xA720B8", VA = "0xA720B8", Slot = "86")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A72A4", Offset = "0x4A72A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000303")]
		[Address(RVA = "0xA720C0", Offset = "0xA720C0", VA = "0xA720C0", Slot = "87")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A72B4", Offset = "0x4A72B4")]
		set
		{
		}
	}

	[Token(Token = "0x1700006B")]
	public Action<Color> onUpdateColor
	{
		[Token(Token = "0x6000304")]
		[Address(RVA = "0xA720C8", Offset = "0xA720C8", VA = "0xA720C8", Slot = "88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A72C4", Offset = "0x4A72C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000305")]
		[Address(RVA = "0xA720D0", Offset = "0xA720D0", VA = "0xA720D0", Slot = "89")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A72D4", Offset = "0x4A72D4")]
		set
		{
		}
	}

	[Token(Token = "0x1700006C")]
	public Action onComplete
	{
		[Token(Token = "0x6000306")]
		[Address(RVA = "0xA720D8", Offset = "0xA720D8", VA = "0xA720D8", Slot = "90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A72E4", Offset = "0x4A72E4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000307")]
		[Address(RVA = "0xA720E0", Offset = "0xA720E0", VA = "0xA720E0", Slot = "91")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A72F4", Offset = "0x4A72F4")]
		set
		{
		}
	}

	[Token(Token = "0x1700006D")]
	public Action<object> onCompleteObject
	{
		[Token(Token = "0x6000308")]
		[Address(RVA = "0xA720E8", Offset = "0xA720E8", VA = "0xA720E8", Slot = "92")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7304", Offset = "0x4A7304")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000309")]
		[Address(RVA = "0xA720F0", Offset = "0xA720F0", VA = "0xA720F0", Slot = "93")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7314", Offset = "0x4A7314")]
		set
		{
		}
	}

	[Token(Token = "0x1700006E")]
	public object onCompleteParam
	{
		[Token(Token = "0x600030A")]
		[Address(RVA = "0xA720F8", Offset = "0xA720F8", VA = "0xA720F8", Slot = "94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7324", Offset = "0x4A7324")]
		get
		{
			return null;
		}
		[Token(Token = "0x600030B")]
		[Address(RVA = "0xA72100", Offset = "0xA72100", VA = "0xA72100", Slot = "95")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7334", Offset = "0x4A7334")]
		set
		{
		}
	}

	[Token(Token = "0x1700006F")]
	public object onUpdateParam
	{
		[Token(Token = "0x600030C")]
		[Address(RVA = "0xA72108", Offset = "0xA72108", VA = "0xA72108", Slot = "96")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7344", Offset = "0x4A7344")]
		get
		{
			return null;
		}
		[Token(Token = "0x600030D")]
		[Address(RVA = "0xA72110", Offset = "0xA72110", VA = "0xA72110", Slot = "97")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7354", Offset = "0x4A7354")]
		set
		{
		}
	}

	[Token(Token = "0x17000070")]
	public Action onStart
	{
		[Token(Token = "0x600030E")]
		[Address(RVA = "0xA72118", Offset = "0xA72118", VA = "0xA72118", Slot = "98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7364", Offset = "0x4A7364")]
		get
		{
			return null;
		}
		[Token(Token = "0x600030F")]
		[Address(RVA = "0xA72120", Offset = "0xA72120", VA = "0xA72120", Slot = "99")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7374", Offset = "0x4A7374")]
		set
		{
		}
	}

	[Token(Token = "0x17000071")]
	public int uniqueId
	{
		[Token(Token = "0x6000313")]
		[Address(RVA = "0xA72C24", Offset = "0xA72C24", VA = "0xA72C24", Slot = "102")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000072")]
	public int id
	{
		[Token(Token = "0x6000314")]
		[Address(RVA = "0xA72B2C", Offset = "0xA72B2C", VA = "0xA72B2C", Slot = "103")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0xA72128", Offset = "0xA72128", VA = "0xA72128", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0xA72B3C", Offset = "0xA72B3C", VA = "0xA72B3C")]
	public LTDescrImpl()
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xA72B44", Offset = "0xA72B44", VA = "0xA72B44", Slot = "100")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4A7384", Offset = "0x4A7384")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xA72D38", Offset = "0xA72D38", VA = "0xA72D38", Slot = "106")]
	public void reset()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xA72E7C", Offset = "0xA72E7C", VA = "0xA72E7C", Slot = "101")]
	public void cleanup()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xA72EB4", Offset = "0xA72EB4", VA = "0xA72EB4", Slot = "104")]
	public void init()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0xA74D4C", Offset = "0xA74D4C", VA = "0xA74D4C", Slot = "118")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0xA74E20", Offset = "0xA74E20", VA = "0xA74E20", Slot = "105")]
	public LTDescr pause()
	{
		return null;
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xA74E38", Offset = "0xA74E38", VA = "0xA74E38", Slot = "107")]
	public LTDescr resume()
	{
		return null;
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0xA74E44", Offset = "0xA74E44", VA = "0xA74E44", Slot = "109")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xA74E50", Offset = "0xA74E50", VA = "0xA74E50", Slot = "110")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xA74E58", Offset = "0xA74E58", VA = "0xA74E58", Slot = "114")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xA74E60", Offset = "0xA74E60", VA = "0xA74E60", Slot = "150")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xA74E68", Offset = "0xA74E68", VA = "0xA74E68", Slot = "152")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xA74E70", Offset = "0xA74E70", VA = "0xA74E70", Slot = "115")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xA74E78", Offset = "0xA74E78", VA = "0xA74E78", Slot = "163")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xA74F40", Offset = "0xA74F40", VA = "0xA74F40", Slot = "162")]
	public LTDescr setTo(Transform to)
	{
		return null;
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0xA74F48", Offset = "0xA74F48", VA = "0xA74F48", Slot = "117")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xA75044", Offset = "0xA75044", VA = "0xA75044", Slot = "116")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0xA75094", Offset = "0xA75094", VA = "0xA75094", Slot = "112")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0xA750A0", Offset = "0xA750A0", VA = "0xA750A0", Slot = "119")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0xA750AC", Offset = "0xA750AC", VA = "0xA750AC", Slot = "120")]
	public LTDescr setId(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0xA75130", Offset = "0xA75130", VA = "0xA75130", Slot = "161")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xA7514C", Offset = "0xA7514C", VA = "0xA7514C", Slot = "156")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xA751A0", Offset = "0xA751A0", VA = "0xA751A0", Slot = "128")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xA751A8", Offset = "0xA751A8", VA = "0xA751A8", Slot = "164")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0xA751B4", Offset = "0xA751B4", VA = "0xA751B4", Slot = "121")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0xA751C0", Offset = "0xA751C0", VA = "0xA751C0", Slot = "165")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0xA751CC", Offset = "0xA751CC", VA = "0xA751CC", Slot = "166")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0xA751D8", Offset = "0xA751D8", VA = "0xA751D8", Slot = "124")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0xA751E0", Offset = "0xA751E0", VA = "0xA751E0", Slot = "125")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xA751EC", Offset = "0xA751EC", VA = "0xA751EC", Slot = "122")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0xA7520C", Offset = "0xA7520C", VA = "0xA7520C", Slot = "123")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xA75214", Offset = "0xA75214", VA = "0xA75214", Slot = "126")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xA75234", Offset = "0xA75234", VA = "0xA75234", Slot = "127")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0xA75274", Offset = "0xA75274", VA = "0xA75274", Slot = "129")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0xA7527C", Offset = "0xA7527C", VA = "0xA7527C", Slot = "130")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0xA75284", Offset = "0xA75284", VA = "0xA75284", Slot = "131")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0xA75294", Offset = "0xA75294", VA = "0xA75294", Slot = "134")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0xA7529C", Offset = "0xA7529C", VA = "0xA7529C", Slot = "137")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xA752AC", Offset = "0xA752AC", VA = "0xA752AC", Slot = "145")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xA752BC", Offset = "0xA752BC", VA = "0xA752BC", Slot = "143")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xA752CC", Offset = "0xA752CC", VA = "0xA752CC", Slot = "146")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xA752DC", Offset = "0xA752DC", VA = "0xA752DC", Slot = "147")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xA752EC", Offset = "0xA752EC", VA = "0xA752EC", Slot = "142")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xA752FC", Offset = "0xA752FC", VA = "0xA752FC", Slot = "138")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xA7530C", Offset = "0xA7530C", VA = "0xA7530C", Slot = "136")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xA75324", Offset = "0xA75324", VA = "0xA75324", Slot = "140")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xA7533C", Offset = "0xA7533C", VA = "0xA7533C", Slot = "139")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xA75354", Offset = "0xA75354", VA = "0xA75354", Slot = "141")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xA7536C", Offset = "0xA7536C", VA = "0xA7536C", Slot = "144")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xA75374", Offset = "0xA75374", VA = "0xA75374", Slot = "148")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xA7542C", Offset = "0xA7542C", VA = "0xA7542C", Slot = "149")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xA754A4", Offset = "0xA754A4", VA = "0xA754A4", Slot = "154")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xA754AC", Offset = "0xA754AC", VA = "0xA754AC", Slot = "155")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xA755F8", Offset = "0xA755F8", VA = "0xA755F8", Slot = "151")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0xA75600", Offset = "0xA75600", VA = "0xA75600", Slot = "153")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xA7560C", Offset = "0xA7560C", VA = "0xA7560C", Slot = "111")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xA75618", Offset = "0xA75618", VA = "0xA75618", Slot = "108")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xA75194", Offset = "0xA75194", VA = "0xA75194", Slot = "132")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0xA75620", Offset = "0xA75620", VA = "0xA75620", Slot = "133")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xA7562C", Offset = "0xA7562C", VA = "0xA7562C", Slot = "158")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xA75634", Offset = "0xA75634", VA = "0xA75634", Slot = "159")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xA7563C", Offset = "0xA7563C", VA = "0xA7563C", Slot = "160")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xA75688", Offset = "0xA75688", VA = "0xA75688", Slot = "135")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xA75690", Offset = "0xA75690", VA = "0xA75690", Slot = "113")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xA75DB0", Offset = "0xA75DB0", VA = "0xA75DB0", Slot = "157")]
	public LTDescr setRecursive(bool useRecursion)
	{
		return null;
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4A6338", Offset = "0x4A6338")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x6000356")]
		[Address(RVA = "0xF683C4", Offset = "0xF683C4", VA = "0xF683C4")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xF683E8", Offset = "0xF683E8", VA = "0xF683E8")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xF68448", Offset = "0xF68448", VA = "0xF68448")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xF684A8", Offset = "0xF684A8", VA = "0xF684A8")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4A63AC", Offset = "0x4A63AC")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x600035A")]
		[Address(RVA = "0xF684B0", Offset = "0xF684B0", VA = "0xF684B0")]
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
		[Address(RVA = "0xF684B8", Offset = "0xF684B8", VA = "0xF684B8")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xF6852C", Offset = "0xF6852C", VA = "0xF6852C")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4A6420", Offset = "0x4A6420")]
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
		[Address(RVA = "0xF68590", Offset = "0xF68590", VA = "0xF68590")]
		public void Start()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xF68740", Offset = "0xF68740", VA = "0xF68740")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xF68B00", Offset = "0xF68B00", VA = "0xF68B00")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xF68C24", Offset = "0xF68C24", VA = "0xF68C24")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xF68D44", Offset = "0xF68D44", VA = "0xF68D44")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xF69998", Offset = "0xF69998", VA = "0xF69998")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xF699F8", Offset = "0xF699F8", VA = "0xF699F8")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xF69B00", Offset = "0xF69B00", VA = "0xF69B00")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xF69B60", Offset = "0xF69B60", VA = "0xF69B60")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xF68ED4", Offset = "0xF68ED4", VA = "0xF68ED4")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xF69BC0", Offset = "0xF69BC0", VA = "0xF69BC0")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xF6A150", Offset = "0xF6A150", VA = "0xF6A150")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xF69CA4", Offset = "0xF69CA4", VA = "0xF69CA4")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xF6A398", Offset = "0xF6A398", VA = "0xF6A398")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xF69F68", Offset = "0xF69F68", VA = "0xF69F68")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xF6A3B8", Offset = "0xF6A3B8", VA = "0xF6A3B8")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4A6494", Offset = "0x4A6494")]
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
		[Address(RVA = "0xF6A42C", Offset = "0xF6A42C", VA = "0xF6A42C")]
		public void Start()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xF6A564", Offset = "0xF6A564", VA = "0xF6A564")]
		public void Update()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xF6A81C", Offset = "0xF6A81C", VA = "0xF6A81C")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000073")]
		public enum WaterMode
		{
			[Token(Token = "0x40004AF")]
			Simple,
			[Token(Token = "0x40004B0")]
			Reflective,
			[Token(Token = "0x40004B1")]
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
		[Address(RVA = "0xF6A824", Offset = "0xF6A824", VA = "0xF6A824")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xF6C9BC", Offset = "0xF6C9BC", VA = "0xF6C9BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xF6CD68", Offset = "0xF6CD68", VA = "0xF6CD68")]
		private void Update()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xF6C15C", Offset = "0xF6C15C", VA = "0xF6C15C")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xF6B3D8", Offset = "0xF6B3D8", VA = "0xF6B3D8")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xF6B3C4", Offset = "0xF6B3C4", VA = "0xF6B3C4")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xF6B26C", Offset = "0xF6B26C", VA = "0xF6B26C")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xF6C7D4", Offset = "0xF6C7D4", VA = "0xF6C7D4")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xF6C530", Offset = "0xF6C530", VA = "0xF6C530")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xF6D048", Offset = "0xF6D048", VA = "0xF6D048")]
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
		[Address(RVA = "0xF6D124", Offset = "0xF6D124", VA = "0xF6D124")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xF6D304", Offset = "0xF6D304", VA = "0xF6D304")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xF6D3DC", Offset = "0xF6D3DC", VA = "0xF6D3DC")]
		public void Update()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xF6D460", Offset = "0xF6D460", VA = "0xF6D460")]
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
		[Address(RVA = "0xF6D478", Offset = "0xF6D478", VA = "0xF6D478")]
		public void Start()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xF6D47C", Offset = "0xF6D47C", VA = "0xF6D47C")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xF6D674", Offset = "0xF6D674", VA = "0xF6D674")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xF6D790", Offset = "0xF6D790", VA = "0xF6D790")]
		public WaterTile()
		{
		}
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x4A6538", Offset = "0x4A6538")]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x6000382")]
		[Address(RVA = "0xF683AC", Offset = "0xF683AC", VA = "0xF683AC")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x4A654C", Offset = "0x4A654C")]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x6000383")]
		[Address(RVA = "0xF683B4", Offset = "0xF683B4", VA = "0xF683B4")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x4A6560", Offset = "0x4A6560")]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x6000384")]
		[Address(RVA = "0xF683BC", Offset = "0xF683BC", VA = "0xF683BC")]
		public RelatingAttribute()
		{
		}
	}
}
namespace DentedPixel.LTEditor
{
	[Token(Token = "0x2000032")]
	public class LeanTweenVisual : MonoBehaviour
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<LeanTweenGroup> groupList;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool repeat;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float repeatDelay;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int repeatCount;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int repeatIter;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float nextCall;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool restartOnEnable;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int versionNum;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private StringBuilder codeBuild;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string tabs;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LTDescr tween;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float allTweensDelaySaved;

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x904C8C", Offset = "0x904C8C", VA = "0x904C8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x904CF0", Offset = "0x904CF0", VA = "0x904CF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x905560", Offset = "0x905560", VA = "0x905560")]
		private void Update()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x905564", Offset = "0x905564", VA = "0x905564")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x905578", Offset = "0x905578", VA = "0x905578")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x905608", Offset = "0x905608", VA = "0x905608")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x905684", Offset = "0x905684", VA = "0x905684")]
		public void CopyTo(LeanTweenVisual tween)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x905894", Offset = "0x905894", VA = "0x905894")]
		public void buildAllTweensAgain()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x905958", Offset = "0x905958", VA = "0x905958")]
		public void buildAllTweensAgainNow()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x905960", Offset = "0x905960", VA = "0x905960")]
		public LTDescr append(string method, float to, float duration)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x905CC0", Offset = "0x905CC0", VA = "0x905CC0")]
		public LTDescr appendRect(string method, float to, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x906020", Offset = "0x906020", VA = "0x906020")]
		public LTDescr append(string method, Vector3 to, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x906684", Offset = "0x906684", VA = "0x906684")]
		public LTDescr appendRect(string method, Vector3 to, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x9069F4", Offset = "0x9069F4", VA = "0x9069F4")]
		public LTDescr appendRect(string method, Color color, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x90710C", Offset = "0x90710C", VA = "0x90710C")]
		public LTDescr append(string method, Color color, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x907484", Offset = "0x907484", VA = "0x907484")]
		public LTDescr append(string method, Vector3[] to, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x907684", Offset = "0x907684", VA = "0x907684")]
		public void append(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x906390", Offset = "0x906390", VA = "0x906390")]
		private string vecToStr(Vector3 vec3)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x906D6C", Offset = "0x906D6C", VA = "0x906D6C")]
		private string colorToStr(Color color)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x907A40", Offset = "0x907A40", VA = "0x907A40")]
		private void buildTween(LeanTweenItem item, float delayAdd, bool generateCode)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x90A19C", Offset = "0x90A19C", VA = "0x90A19C")]
		public void buildGroup(object g)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x904CF8", Offset = "0x904CF8", VA = "0x904CF8")]
		public string buildAllTweens(bool generateCode)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x90A594", Offset = "0x90A594", VA = "0x90A594")]
		public LeanTweenVisual()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public enum LeanTweenBetween
	{
		[Token(Token = "0x4000187")]
		FromTo,
		[Token(Token = "0x4000188")]
		To
	}
	[Serializable]
	[Token(Token = "0x2000034")]
	public class LeanTweenItem
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TweenAction action;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int actionLast;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string actionStr;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LeanTweenBetween between;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LeanTweenType ease;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string easeStr;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve animationCurve;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 from;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 to;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Color colorTo;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 axis;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float duration;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float delay;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool alignWithPrevious;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public bool foldout;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public LeanTweenPath bezierPath;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LeanTweenPath splinePath;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioClip audioClip;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool orientToPath;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isPath2d;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool doesLoop;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int loopCount;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public LeanTweenType loopType;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Sprite[] sprites;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool spritesMaximized;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float frameRate;

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x904A48", Offset = "0x904A48", VA = "0x904A48")]
		public LeanTweenItem()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x904B60", Offset = "0x904B60", VA = "0x904B60")]
		public LeanTweenItem(float delay)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x90447C", Offset = "0x90447C", VA = "0x90447C")]
		public LeanTweenItem(LeanTweenItem item)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000035")]
	public class LeanTweenGroup
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool repeat;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float delay;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int repeatCount;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int repeatIter;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool foldout;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject gameObject;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<LeanTweenItem> itemList;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _generateCode;

		[Token(Token = "0x17000073")]
		public float startTime
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x9046BC", Offset = "0x9046BC", VA = "0x9046BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000074")]
		public float endTime
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x904868", Offset = "0x904868", VA = "0x904868")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000075")]
		public bool generateCode
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x904A40", Offset = "0x904A40", VA = "0x904A40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x904110", Offset = "0x904110", VA = "0x904110")]
		public LeanTweenGroup()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x9041A0", Offset = "0x9041A0", VA = "0x9041A0")]
		public LeanTweenGroup(float delay)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x904244", Offset = "0x904244", VA = "0x904244")]
		public LeanTweenGroup(LeanTweenGroup group)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x904A34", Offset = "0x904A34", VA = "0x904A34")]
		public void setGenerateCode()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class LTVisualShared : MonoBehaviour
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] LT_2_12_MethodNames;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static object[][] methodLabelsGrouping;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] methodLabels;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] methodStrMapping;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static int[] methodIntMapping;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] methodStrMappingGrouping;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static int[] methodIntMappingGrouping;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static int[] easeIntMapping;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] easeStrMapping;

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x8FE30C", Offset = "0x8FE30C", VA = "0x8FE30C")]
		public static void updateTweens(LeanTweenVisual tween)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x8FF218", Offset = "0x8FF218", VA = "0x8FF218")]
		public static int actionIndex(LeanTweenItem item)
		{
			return default(int);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x8FF338", Offset = "0x8FF338", VA = "0x8FF338")]
		public static void setActionIndex(LeanTweenItem item, int newIndex)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x8FF43C", Offset = "0x8FF43C", VA = "0x8FF43C")]
		public static int easeIndex(LeanTweenItem item)
		{
			return default(int);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x8FF5FC", Offset = "0x8FF5FC", VA = "0x8FF5FC")]
		public static void setEaseIndex(LeanTweenItem item, int newIndex)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x8FF700", Offset = "0x8FF700", VA = "0x8FF700")]
		public LTVisualShared()
		{
		}
	}
}
namespace MiniJSON
{
	[Token(Token = "0x2000037")]
	public static class Json
	{
		[Token(Token = "0x2000074")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x20000CA")]
			private enum TOKEN
			{
				[Token(Token = "0x4000642")]
				NONE,
				[Token(Token = "0x4000643")]
				CURLY_OPEN,
				[Token(Token = "0x4000644")]
				CURLY_CLOSE,
				[Token(Token = "0x4000645")]
				SQUARED_OPEN,
				[Token(Token = "0x4000646")]
				SQUARED_CLOSE,
				[Token(Token = "0x4000647")]
				COLON,
				[Token(Token = "0x4000648")]
				COMMA,
				[Token(Token = "0x4000649")]
				STRING,
				[Token(Token = "0x400064A")]
				NUMBER,
				[Token(Token = "0x400064B")]
				TRUE,
				[Token(Token = "0x400064C")]
				FALSE,
				[Token(Token = "0x400064D")]
				NULL
			}

			[Token(Token = "0x40004B2")]
			private const string WHITE_SPACE = " \t\n\r";

			[Token(Token = "0x40004B3")]
			private const string WORD_BREAK = " \t\n\r{}[],:\"";

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x17000101")]
			private char PeekChar
			{
				[Token(Token = "0x600065C")]
				[Address(RVA = "0xF67548", Offset = "0xF67548", VA = "0xF67548")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000102")]
			private char NextChar
			{
				[Token(Token = "0x600065D")]
				[Address(RVA = "0xF672DC", Offset = "0xF672DC", VA = "0xF672DC")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000103")]
			private string NextWord
			{
				[Token(Token = "0x600065E")]
				[Address(RVA = "0xF6736C", Offset = "0xF6736C", VA = "0xF6736C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000104")]
			private TOKEN NextToken
			{
				[Token(Token = "0x600065F")]
				[Address(RVA = "0xF66B80", Offset = "0xF66B80", VA = "0xF66B80")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0xF66964", Offset = "0xF66964", VA = "0xF66964")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0xF66778", Offset = "0xF66778", VA = "0xF66778")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0xF66A08", Offset = "0xF66A08", VA = "0xF66A08", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0xF66A44", Offset = "0xF66A44", VA = "0xF66A44")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0xF67034", Offset = "0xF67034", VA = "0xF67034")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0xF669E0", Offset = "0xF669E0", VA = "0xF669E0")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0xF67120", Offset = "0xF67120", VA = "0xF67120")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0xF66D5C", Offset = "0xF66D5C", VA = "0xF66D5C")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0xF671FC", Offset = "0xF671FC", VA = "0xF671FC")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0xF67478", Offset = "0xF67478", VA = "0xF67478")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x2000075")]
		private sealed class Serializer
		{
			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x6000660")]
			[Address(RVA = "0xF675D8", Offset = "0xF675D8", VA = "0xF675D8")]
			private Serializer()
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0xF668C0", Offset = "0xF668C0", VA = "0xF668C0")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0xF67644", Offset = "0xF67644", VA = "0xF67644")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0xF67DDC", Offset = "0xF67DDC", VA = "0xF67DDC")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0xF67AE0", Offset = "0xF67AE0", VA = "0xF67AE0")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0xF677F0", Offset = "0xF677F0", VA = "0xF677F0")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0xF68220", Offset = "0xF68220", VA = "0xF68220")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xF6676C", Offset = "0xF6676C", VA = "0xF6676C")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xF668BC", Offset = "0xF668BC", VA = "0xF668BC")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
namespace DarkTonic.MasterAudio
{
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4A6574", Offset = "0x4A6574")]
	public class ButtonClicker : MonoBehaviour
	{
		[Token(Token = "0x40001B7")]
		public const float SmallSizeMultiplier = 0.9f;

		[Token(Token = "0x40001B8")]
		public const float LargeSizeMultiplier = 1.1f;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool resizeOnClick;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool resizeClickAllSiblings;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool resizeOnHover;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool resizeHoverAllSiblings;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mouseDownSound;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string mouseUpSound;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mouseClickSound;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mouseOverSound;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mouseOutSound;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _originalSize;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _smallerSize;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _largerSize;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _trans;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Dictionary<Transform, Vector3> _siblingClickScaleByTransform;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<Transform, Vector3> _siblingHoverScaleByTransform;

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x60DB58", Offset = "0x60DB58", VA = "0x60DB58")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x60DEAC", Offset = "0x60DEAC", VA = "0x60DEAC")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x60E424", Offset = "0x60E424", VA = "0x60E424")]
		private void OnClick()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x60E4B8", Offset = "0x60E4B8", VA = "0x60E4B8")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x60E87C", Offset = "0x60E87C", VA = "0x60E87C")]
		public ButtonClicker()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x4A65AC", Offset = "0x4A65AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4A65AC", Offset = "0x4A65AC")]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x2000076")]
		public enum UnityUIVersion
		{
			[Token(Token = "0x40004B7")]
			Legacy,
			[Token(Token = "0x40004B8")]
			uGUI
		}

		[Token(Token = "0x2000077")]
		public enum EventType
		{
			[Token(Token = "0x40004BA")]
			OnStart,
			[Token(Token = "0x40004BB")]
			OnVisible,
			[Token(Token = "0x40004BC")]
			OnInvisible,
			[Token(Token = "0x40004BD")]
			OnCollision,
			[Token(Token = "0x40004BE")]
			OnTriggerEnter,
			[Token(Token = "0x40004BF")]
			OnTriggerExit,
			[Token(Token = "0x40004C0")]
			OnMouseEnter,
			[Token(Token = "0x40004C1")]
			OnMouseClick,
			[Token(Token = "0x40004C2")]
			OnSpawned,
			[Token(Token = "0x40004C3")]
			OnDespawned,
			[Token(Token = "0x40004C4")]
			OnEnable,
			[Token(Token = "0x40004C5")]
			OnDisable,
			[Token(Token = "0x40004C6")]
			OnCollision2D,
			[Token(Token = "0x40004C7")]
			OnTriggerEnter2D,
			[Token(Token = "0x40004C8")]
			OnTriggerExit2D,
			[Token(Token = "0x40004C9")]
			OnParticleCollision,
			[Token(Token = "0x40004CA")]
			UserDefinedEvent,
			[Token(Token = "0x40004CB")]
			OnCollisionExit,
			[Token(Token = "0x40004CC")]
			OnCollisionExit2D,
			[Token(Token = "0x40004CD")]
			OnMouseUp,
			[Token(Token = "0x40004CE")]
			OnMouseExit,
			[Token(Token = "0x40004CF")]
			OnMouseDrag,
			[Token(Token = "0x40004D0")]
			NGUIOnClick,
			[Token(Token = "0x40004D1")]
			NGUIMouseDown,
			[Token(Token = "0x40004D2")]
			NGUIMouseUp,
			[Token(Token = "0x40004D3")]
			NGUIMouseEnter,
			[Token(Token = "0x40004D4")]
			NGUIMouseExit,
			[Token(Token = "0x40004D5")]
			MechanimStateChanged,
			[Token(Token = "0x40004D6")]
			UnitySliderChanged,
			[Token(Token = "0x40004D7")]
			UnityButtonClicked,
			[Token(Token = "0x40004D8")]
			UnityPointerDown,
			[Token(Token = "0x40004D9")]
			UnityPointerUp,
			[Token(Token = "0x40004DA")]
			UnityPointerEnter,
			[Token(Token = "0x40004DB")]
			UnityPointerExit,
			[Token(Token = "0x40004DC")]
			UnityDrag,
			[Token(Token = "0x40004DD")]
			UnityDrop,
			[Token(Token = "0x40004DE")]
			UnityScroll,
			[Token(Token = "0x40004DF")]
			UnityUpdateSelected,
			[Token(Token = "0x40004E0")]
			UnitySelect,
			[Token(Token = "0x40004E1")]
			UnityDeselect,
			[Token(Token = "0x40004E2")]
			UnityMove,
			[Token(Token = "0x40004E3")]
			UnityInitializePotentialDrag,
			[Token(Token = "0x40004E4")]
			UnityBeginDrag,
			[Token(Token = "0x40004E5")]
			UnityEndDrag,
			[Token(Token = "0x40004E6")]
			UnitySubmit,
			[Token(Token = "0x40004E7")]
			UnityCancel,
			[Token(Token = "0x40004E8")]
			UnityToggle
		}

		[Token(Token = "0x2000078")]
		public enum VariationType
		{
			[Token(Token = "0x40004EA")]
			PlaySpecific,
			[Token(Token = "0x40004EB")]
			PlayRandom
		}

		[Token(Token = "0x2000079")]
		public enum PreviousSoundStopMode
		{
			[Token(Token = "0x40004ED")]
			None,
			[Token(Token = "0x40004EE")]
			Stop,
			[Token(Token = "0x40004EF")]
			FadeOut
		}

		[Token(Token = "0x200007A")]
		public enum RetriggerLimMode
		{
			[Token(Token = "0x40004F1")]
			None,
			[Token(Token = "0x40004F2")]
			FrameBased,
			[Token(Token = "0x40004F3")]
			TimeBased
		}

		[Token(Token = "0x200007B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6768", Offset = "0x4A6768")]
		private sealed class <CoUpdate>d__116 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EventSounds <>4__this;

			[Token(Token = "0x17000105")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600066A")]
				[Address(RVA = "0x6202F8", Offset = "0x6202F8", VA = "0x6202F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000106")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600066C")]
				[Address(RVA = "0x620368", Offset = "0x620368", VA = "0x620368", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x614484", Offset = "0x614484", VA = "0x614484")]
			[DebuggerHidden]
			public <CoUpdate>d__116(int <>1__state)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x620120", Offset = "0x620120", VA = "0x620120", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x620124", Offset = "0x620124", VA = "0x620124", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x620300", Offset = "0x620300", VA = "0x620300", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool showGizmo;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableSounds;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool showPoolManager;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool showNGUI;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public UnityUIVersion unityUIMode;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool logMissingEvents;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> LayerTagFilterEvents;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<MasterAudio.PlaylistCommand> PlaylistCommandsWithAll;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEventGroup startSound;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioEventGroup visibleSound;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioEventGroup invisibleSound;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioEventGroup collisionSound;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioEventGroup collisionExitSound;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioEventGroup triggerSound;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioEventGroup triggerExitSound;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioEventGroup mouseEnterSound;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioEventGroup mouseExitSound;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioEventGroup mouseClickSound;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AudioEventGroup mouseUpSound;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AudioEventGroup mouseDragSound;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AudioEventGroup spawnedSound;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioEventGroup despawnedSound;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AudioEventGroup enableSound;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AudioEventGroup disableSound;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AudioEventGroup collision2dSound;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AudioEventGroup collisionExit2dSound;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AudioEventGroup triggerEnter2dSound;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public AudioEventGroup triggerExit2dSound;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AudioEventGroup particleCollisionSound;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AudioEventGroup nguiOnClickSound;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AudioEventGroup nguiMouseDownSound;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioEventGroup nguiMouseUpSound;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AudioEventGroup nguiMouseEnterSound;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public AudioEventGroup nguiMouseExitSound;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public AudioEventGroup unitySliderChangedSound;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public AudioEventGroup unityButtonClickedSound;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public AudioEventGroup unityPointerDownSound;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AudioEventGroup unityDragSound;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public AudioEventGroup unityPointerUpSound;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public AudioEventGroup unityPointerEnterSound;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AudioEventGroup unityPointerExitSound;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioEventGroup unityDropSound;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioEventGroup unityScrollSound;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public AudioEventGroup unityUpdateSelectedSound;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public AudioEventGroup unitySelectSound;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public AudioEventGroup unityDeselectSound;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public AudioEventGroup unityMoveSound;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public AudioEventGroup unityInitializePotentialDragSound;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public AudioEventGroup unityBeginDragSound;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public AudioEventGroup unityEndDragSound;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public AudioEventGroup unitySubmitSound;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public AudioEventGroup unityCancelSound;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public AudioEventGroup unityToggleSound;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public List<AudioEventGroup> userDefinedSounds;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public List<AudioEventGroup> mechanimStateChangedSounds;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public bool useStartSound;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A9")]
		public bool useVisibleSound;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AA")]
		public bool useInvisibleSound;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AB")]
		public bool useCollisionSound;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public bool useCollisionExitSound;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AD")]
		public bool useTriggerEnterSound;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AE")]
		public bool useTriggerExitSound;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AF")]
		public bool useMouseEnterSound;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public bool useMouseExitSound;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B1")]
		public bool useMouseClickSound;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B2")]
		public bool useMouseUpSound;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B3")]
		public bool useMouseDragSound;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		public bool useSpawnedSound;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B5")]
		public bool useDespawnedSound;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B6")]
		public bool useEnableSound;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B7")]
		public bool useDisableSound;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public bool useCollision2dSound;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		public bool useCollisionExit2dSound;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		public bool useTriggerEnter2dSound;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BB")]
		public bool useTriggerExit2dSound;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public bool useParticleCollisionSound;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
		public bool useNguiOnClickSound;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BE")]
		public bool useNguiMouseDownSound;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BF")]
		public bool useNguiMouseUpSound;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public bool useNguiMouseEnterSound;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C1")]
		public bool useNguiMouseExitSound;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C2")]
		public bool useUnitySliderChangedSound;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C3")]
		public bool useUnityButtonClickedSound;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public bool useUnityPointerDownSound;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C5")]
		public bool useUnityDragSound;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C6")]
		public bool useUnityPointerUpSound;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C7")]
		public bool useUnityPointerEnterSound;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public bool useUnityPointerExitSound;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		public bool useUnityDropSound;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		public bool useUnityScrollSound;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CB")]
		public bool useUnityUpdateSelectedSound;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool useUnitySelectSound;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CD")]
		public bool useUnityDeselectSound;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CE")]
		public bool useUnityMoveSound;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CF")]
		public bool useUnityInitializePotentialDragSound;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool useUnityBeginDragSound;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		public bool useUnityEndDragSound;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		public bool useUnitySubmitSound;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		public bool useUnityCancelSound;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool useUnityToggleSound;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Slider _slider;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Toggle _toggle;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Button _button;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private bool _isVisible;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
		private bool _needsCoroutine;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Transform _trans;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly List<AudioEventGroup> _validMechanimStateChangedSounds;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Animator _anim;

		[Token(Token = "0x17000076")]
		private bool IsSetToUGUI
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x6140CC", Offset = "0x6140CC", VA = "0x6140CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		private bool IsSetToLegacyUI
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x6161EC", Offset = "0x6161EC", VA = "0x6161EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x614000", Offset = "0x614000", VA = "0x614000")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x614298", Offset = "0x614298", VA = "0x614298", Slot = "10")]
		protected virtual void SpawnedOrAwake()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x614410", Offset = "0x614410", VA = "0x614410")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4A73BC", Offset = "0x4A73BC")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x6144B0", Offset = "0x6144B0", VA = "0x6144B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x614B38", Offset = "0x614B38", VA = "0x614B38")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x614B60", Offset = "0x614B60", VA = "0x614B60")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x614B7C", Offset = "0x614B7C", VA = "0x614B7C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x614EAC", Offset = "0x614EAC", VA = "0x614EAC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x6151D0", Offset = "0x6151D0", VA = "0x6151D0")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x615350", Offset = "0x615350", VA = "0x615350")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x6154D0", Offset = "0x6154D0", VA = "0x6154D0")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x615650", Offset = "0x615650", VA = "0x615650")]
		private void OnCollisionExit2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x6157D0", Offset = "0x6157D0", VA = "0x6157D0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x615950", Offset = "0x615950", VA = "0x615950")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x615AD0", Offset = "0x615AD0", VA = "0x615AD0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x615C50", Offset = "0x615C50", VA = "0x615C50")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x615DD0", Offset = "0x615DD0", VA = "0x615DD0")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x615F50", Offset = "0x615F50", VA = "0x615F50")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x615F70", Offset = "0x615F70", VA = "0x615F70")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x615F90", Offset = "0x615F90", VA = "0x615F90")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x615FB0", Offset = "0x615FB0", VA = "0x615FB0")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x615FD0", Offset = "0x615FD0", VA = "0x615FD0")]
		private void OnDrag(Vector2 delta)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x615FD4", Offset = "0x615FD4", VA = "0x615FD4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x615FF4", Offset = "0x615FF4", VA = "0x615FF4")]
		private void OnDrop(GameObject go)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x615FF8", Offset = "0x615FF8", VA = "0x615FF8")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x616018", Offset = "0x616018", VA = "0x616018")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x616038", Offset = "0x616038", VA = "0x616038")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x616058", Offset = "0x616058", VA = "0x616058")]
		private void OnSelect(bool isSelected)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x61605C", Offset = "0x61605C", VA = "0x61605C")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x61607C", Offset = "0x61607C", VA = "0x61607C")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x61609C", Offset = "0x61609C", VA = "0x61609C")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x6160BC", Offset = "0x6160BC", VA = "0x6160BC")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x6160DC", Offset = "0x6160DC", VA = "0x6160DC")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x6160FC", Offset = "0x6160FC", VA = "0x6160FC")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x61611C", Offset = "0x61611C", VA = "0x61611C")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x61613C", Offset = "0x61613C", VA = "0x61613C")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x61615C", Offset = "0x61615C", VA = "0x61615C")]
		private void SliderChanged(float newValue)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x6161BC", Offset = "0x6161BC", VA = "0x6161BC")]
		private void ToggleChanged(bool newValue)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x6161D4", Offset = "0x6161D4", VA = "0x6161D4")]
		private void ButtonClicked()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x6161FC", Offset = "0x6161FC", VA = "0x6161FC")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x616234", Offset = "0x616234", VA = "0x616234")]
		private void OnClick()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x616254", Offset = "0x616254", VA = "0x616254")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x61628C", Offset = "0x61628C", VA = "0x61628C")]
		private void OnSpawned()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x6162DC", Offset = "0x6162DC", VA = "0x6162DC")]
		private void OnDespawned()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x6162FC", Offset = "0x6162FC", VA = "0x6162FC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x616388", Offset = "0x616388", VA = "0x616388")]
		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x61491C", Offset = "0x61491C", VA = "0x61491C")]
		public void PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x616490", Offset = "0x616490", VA = "0x616490")]
		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x61EC34", Offset = "0x61EC34", VA = "0x61EC34")]
		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x6144F0", Offset = "0x6144F0", VA = "0x6144F0", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x61F0CC", Offset = "0x61F0CC", VA = "0x61F0CC", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x61F1E0", Offset = "0x61F1E0", VA = "0x61F1E0", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x614E08", Offset = "0x614E08", VA = "0x614E08", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x615134", Offset = "0x615134", VA = "0x615134", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x61F9AC", Offset = "0x61F9AC", VA = "0x61F9AC", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x6140DC", Offset = "0x6140DC", VA = "0x6140DC")]
		private void AddUGUIComponents()
		{
		}

		[Token(Token = "0x60003EE")]
		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x61FA0C", Offset = "0x61FA0C", VA = "0x61FA0C")]
		public EventSounds()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6BD8", Offset = "0x4A6BD8")]
		private EventSounds <eventSounds>k__BackingField;

		[Token(Token = "0x17000078")]
		public EventSounds eventSounds
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x620420", Offset = "0x620420", VA = "0x620420")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7420", Offset = "0x4A7420")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x620E48", Offset = "0x620E48", VA = "0x620E48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7430", Offset = "0x4A7430")]
			set
			{
			}
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x620430", Offset = "0x620430", VA = "0x620430")]
		public EventSoundsUGUIHandler()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x6209F8", Offset = "0x6209F8", VA = "0x6209F8", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x620AA8", Offset = "0x620AA8", VA = "0x620AA8")]
		public EventSoundsPointerEnterHandler()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x620AB0", Offset = "0x620AB0", VA = "0x620AB0", Slot = "4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x620B60", Offset = "0x620B60", VA = "0x620B60")]
		public EventSoundsPointerExitHandler()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x620940", Offset = "0x620940", VA = "0x620940", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x6209F0", Offset = "0x6209F0", VA = "0x6209F0")]
		public EventSoundsPointerDownHandler()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x620B68", Offset = "0x620B68", VA = "0x620B68", Slot = "4")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x620C18", Offset = "0x620C18", VA = "0x620C18")]
		public EventSoundsPointerUpHandler()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x6205A8", Offset = "0x6205A8", VA = "0x6205A8", Slot = "4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x620658", Offset = "0x620658", VA = "0x620658")]
		public EventSoundsDragHandler()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x620660", Offset = "0x620660", VA = "0x620660", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x620710", Offset = "0x620710", VA = "0x620710")]
		public EventSoundsDropHandler()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x620C20", Offset = "0x620C20", VA = "0x620C20", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x620CD0", Offset = "0x620CD0", VA = "0x620CD0")]
		public EventSoundsScrollHandler()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x620E50", Offset = "0x620E50", VA = "0x620E50", Slot = "4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x620F00", Offset = "0x620F00", VA = "0x620F00")]
		public EventSoundsUpdateSelectedHandler()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x620CD8", Offset = "0x620CD8", VA = "0x620CD8", Slot = "4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x620D88", Offset = "0x620D88", VA = "0x620D88")]
		public EventSoundsSelectHandler()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x6204F0", Offset = "0x6204F0", VA = "0x6204F0", Slot = "4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x6205A0", Offset = "0x6205A0", VA = "0x6205A0")]
		public EventSoundsDeselectHandler()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x620888", Offset = "0x620888", VA = "0x620888", Slot = "4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x620938", Offset = "0x620938", VA = "0x620938")]
		public EventSoundsMoveHandler()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x6207D0", Offset = "0x6207D0", VA = "0x6207D0", Slot = "4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x620880", Offset = "0x620880", VA = "0x620880")]
		public EventSoundsInitializePotentialDragHandler()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x620370", Offset = "0x620370", VA = "0x620370", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x620428", Offset = "0x620428", VA = "0x620428")]
		public EventSoundsBeginDragHandler()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x620718", Offset = "0x620718", VA = "0x620718", Slot = "4")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x6207C8", Offset = "0x6207C8", VA = "0x6207C8")]
		public EventSoundsEndDragHandler()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x620D90", Offset = "0x620D90", VA = "0x620D90", Slot = "4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x620E40", Offset = "0x620E40", VA = "0x620E40")]
		public EventSoundsSubmitHandler()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x620438", Offset = "0x620438", VA = "0x620438", Slot = "4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x6204E8", Offset = "0x6204E8", VA = "0x6204E8")]
		public EventSoundsCancelHandler()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4A65FC", Offset = "0x4A65FC")]
	public class FootstepSounds : MonoBehaviour
	{
		[Token(Token = "0x200007C")]
		public enum FootstepTriggerMode
		{
			[Token(Token = "0x40004F8")]
			None,
			[Token(Token = "0x40004F9")]
			OnCollision,
			[Token(Token = "0x40004FA")]
			OnTriggerEnter,
			[Token(Token = "0x40004FB")]
			OnCollision2D,
			[Token(Token = "0x40004FC")]
			OnTriggerEnter2D
		}

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public FootstepTriggerMode footstepEvent;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FootstepGroup> footstepGroups;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int limitPerXFrm;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float limitPerXSec;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int triggeredLastFrame;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float triggeredLastTime;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _trans;

		[Token(Token = "0x17000079")]
		private Transform Trans
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x62154C", Offset = "0x62154C", VA = "0x62154C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x621034", Offset = "0x621034", VA = "0x621034")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x6213B4", Offset = "0x6213B4", VA = "0x6213B4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x62140C", Offset = "0x62140C", VA = "0x62140C")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x621464", Offset = "0x621464", VA = "0x621464")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x6214BC", Offset = "0x6214BC", VA = "0x6214BC")]
		private bool CheckForRetriggerLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x62108C", Offset = "0x62108C", VA = "0x62108C")]
		private void PlaySoundsIfMatch(GameObject go)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x6215DC", Offset = "0x6215DC", VA = "0x6215DC")]
		public FootstepSounds()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[MasterCustomEvent]
		public string enterCustomEvent;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MasterCustomEvent]
		public string exitCustomEvent;

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x8E6AA4", Offset = "0x8E6AA4", VA = "0x8E6AA4", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x8E6B78", Offset = "0x8E6B78", VA = "0x8E6B78", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x8E6C4C", Offset = "0x8E6C4C", VA = "0x8E6C4C")]
		public MechanimStateCustomEvents()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool SoundFollowsObject;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SoundGroup]
		public string enterSoundGroup;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SoundGroup]
		public string exitSoundGroup;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x8E6C54", Offset = "0x8E6C54", VA = "0x8E6C54", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x8E6D48", Offset = "0x8E6D48", VA = "0x8E6D48", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x8E6E3C", Offset = "0x8E6E3C", VA = "0x8E6E3C")]
		public MechanimStateSounds()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[SerializeField]
	public class PlaySoundResult
	{
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6C28", Offset = "0x4A6C28")]
		private bool <SoundPlayed>k__BackingField;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6C38", Offset = "0x4A6C38")]
		private bool <SoundScheduled>k__BackingField;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6C48", Offset = "0x4A6C48")]
		private SoundGroupVariation <ActingVariation>k__BackingField;

		[Token(Token = "0x1700007A")]
		public bool SoundPlayed
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x8E80C0", Offset = "0x8E80C0", VA = "0x8E80C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7440", Offset = "0x4A7440")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x8E80A0", Offset = "0x8E80A0", VA = "0x8E80A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7450", Offset = "0x4A7450")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public bool SoundScheduled
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x8E80C8", Offset = "0x8E80C8", VA = "0x8E80C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7460", Offset = "0x4A7460")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x8E80AC", Offset = "0x8E80AC", VA = "0x8E80AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7470", Offset = "0x4A7470")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public SoundGroupVariation ActingVariation
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x8E55AC", Offset = "0x8E55AC", VA = "0x8E55AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7480", Offset = "0x4A7480")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x8E80B8", Offset = "0x8E80B8", VA = "0x8E80B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7490", Offset = "0x4A7490")]
			set
			{
			}
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x8E8074", Offset = "0x8E8074", VA = "0x8E8074")]
		public PlaySoundResult()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class AudioEvent
	{
		[Token(Token = "0x200007D")]
		public enum TargetVolumeMode
		{
			[Token(Token = "0x40004FE")]
			UseSliderValue,
			[Token(Token = "0x40004FF")]
			UseSpecificValue
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public class MA_SnapshotInfo
		{
			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixerSnapshot snapshot;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x608CB8", Offset = "0x608CB8", VA = "0x608CB8")]
			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
			}
		}

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actionName;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isExpanded;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string soundType;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allPlaylistControllersForGroupCmd;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool allSoundTypesForGroupCmd;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool allSoundTypesForBusCmd;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float volume;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useFixedPitch;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float pitch;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float delaySound;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudio.BusCommand currentBusCommand;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.GlobalCommand currentGlobalCommand;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MasterAudio.UnityMixerCommand currentMixerCommand;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioMixerSnapshot snapshotToTransitionTo;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float snapshotTransitionTime;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<MA_SnapshotInfo> snapshotsToBlend;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string busName;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string playlistName;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string playlistControllerName;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool startPlaylist;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float fadeVolume;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float fadeTime;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public TargetVolumeMode targetVolMode;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string clipName;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string variationName;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string theCustomEventName;

		[Token(Token = "0x1700007D")]
		public bool IsFadeCommand
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x608AE8", Offset = "0x608AE8", VA = "0x608AE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x608B54", Offset = "0x608B54", VA = "0x608B54")]
		public AudioEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class AudioEventGroup
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool customSoundActive;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isCustomEvent;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string customEventName;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool mechanimEventActive;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isMechanimStateCheckEvent;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mechanimStateName;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mechEventPlayedForState;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<AudioEvent> SoundEvents;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float mouseDragFadeOutTime;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int limitPerXFrm;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float limitPerXSec;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int triggeredLastFrame;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float triggeredLastTime;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float sliderValue;

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x608CF4", Offset = "0x608CF4", VA = "0x608CF4")]
		public AudioEventGroup()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class AudioScriptOrder : Attribute
	{
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Order;

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x60D5DC", Offset = "0x60D5DC", VA = "0x60D5DC")]
		public AudioScriptOrder(int order)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class BusFadeInfo
	{
		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GroupBus ActingBus;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TargetVolume;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float VolumeStep;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action completionAction;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x60DB48", Offset = "0x60DB48", VA = "0x60DB48")]
		public BusFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class CustomEvent
	{
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ProspectiveName;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool eventExpanded;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float distanceThreshold;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int frameLastFired;

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x60EB48", Offset = "0x60EB48", VA = "0x60EB48")]
		public CustomEvent(string eventName)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class DuckGroupInfo
	{
		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundType;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float riseVolStart;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unduckTime;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duckedVolumeCut;

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x60F0A0", Offset = "0x60F0A0", VA = "0x60F0A0")]
		public DuckGroupInfo()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool useLocalization;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool useRandomPitch;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float randomPitchMin;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float randomPitchMax;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool useRandomVolume;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float randomVolumeMin;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float randomVolumeMax;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int weight;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string resourceFileName;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string internetFileUrl;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isExpanded;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool isChecked;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float fxTailTime;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool useFades;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float fadeInTime;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float fadeOutTime;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool useIntroSilence;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float introSilenceMin;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float introSilenceMax;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useRandomStartTime;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float randomStartMinPercent;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float randomStartMaxPercent;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private DynamicSoundGroup _parentGroupScript;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Transform _trans;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioSource _aud;

		[Token(Token = "0x1700007E")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x60F108", Offset = "0x60F108", VA = "0x60F108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x60F1A0", Offset = "0x60F1A0", VA = "0x60F1A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x60F238", Offset = "0x60F238", VA = "0x60F238")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x60F2D0", Offset = "0x60F2D0", VA = "0x60F2D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x60F368", Offset = "0x60F368", VA = "0x60F368")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x60F400", Offset = "0x60F400", VA = "0x60F400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public DynamicSoundGroup ParentGroup
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x60F498", Offset = "0x60F498", VA = "0x60F498")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public Transform Trans
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x60F600", Offset = "0x60F600", VA = "0x60F600")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x60F690", Offset = "0x60F690", VA = "0x60F690")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000087")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x60F92C", Offset = "0x60F92C", VA = "0x60F92C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x60F9C4", Offset = "0x60F9C4", VA = "0x60F9C4")]
		public DynamicGroupVariation()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class DynamicSoundGroup : MonoBehaviour
	{
		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject variationTemplate;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float groupMasterVolume;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int retriggerPercentage;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudioGroup.VariationSequence curVariationSequence;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudioGroup.VariationMode curVariationMode;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float chainLoopDelayMin;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMax;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chainLoopNumLoops;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useDialogFadeOut;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dialogFadeOutTime;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool logSound;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int busIndex;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float spatialBlend;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string busName;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool isExistingBus;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool isCopiedFromDGSC;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public MasterAudioGroup.LimitMode limitMode;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int limitPerXFrames;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float minimumTimeBetween;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool limitPolyphony;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int voiceLimitCount;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float despawnFadeTime;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool copySettingsExpanded;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int selectedVariationIndex;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public MasterAudioGroup.ChildGroupMode childGroupMode;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public List<string> childSoundGroups;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public List<DynamicGroupVariation> groupVariations;

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x60F9DC", Offset = "0x60F9DC", VA = "0x60F9DC")]
		public DynamicSoundGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class FootstepGroup
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundType;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string variationName;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float volume;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useFixedPitch;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitch;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float delaySound;

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x620F08", Offset = "0x620F08", VA = "0x620F08")]
		public FootstepGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class GroupBus
	{
		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string busName;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isSoloed;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool isMuted;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int voiceLimit;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool stopOldest;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExisting;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool forceTo2D;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<int> _activeAudioSourcesIds;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _originalVolume;

		[Token(Token = "0x17000088")]
		public int ActiveVoices
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x621780", Offset = "0x621780", VA = "0x621780")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000089")]
		public bool BusVoiceLimitReached
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x6217E0", Offset = "0x6217E0", VA = "0x6217E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008A")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x621864", Offset = "0x621864", VA = "0x621864")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x611EB0", Offset = "0x611EB0", VA = "0x611EB0")]
			set
			{
			}
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x621664", Offset = "0x621664", VA = "0x621664")]
		public void AddActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x621710", Offset = "0x621710", VA = "0x621710")]
		public void RemoveActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x62186C", Offset = "0x62186C", VA = "0x62186C")]
		public GroupBus()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class GroupFadeInfo
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TargetVolume;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float VolumeStep;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action completionAction;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x6218FC", Offset = "0x6218FC", VA = "0x6218FC")]
		public GroupFadeInfo()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public interface ICustomEventReceiver
	{
		[Token(Token = "0x6000445")]
		void CheckForIllegalCustomEvents();

		[Token(Token = "0x6000446")]
		void ReceiveEvent(string customEventName, Vector3 originPoint);

		[Token(Token = "0x6000447")]
		bool SubscribesToEvent(string customEventName);

		[Token(Token = "0x6000448")]
		void RegisterReceiver();

		[Token(Token = "0x6000449")]
		void UnregisterReceiver();

		[Token(Token = "0x600044A")]
		IList<AudioEventGroup> GetAllEvents();
	}
	[Token(Token = "0x200005B")]
	public class MasterAudioGroup : MonoBehaviour
	{
		[Token(Token = "0x200007F")]
		public enum ChildGroupMode
		{
			[Token(Token = "0x4000503")]
			None,
			[Token(Token = "0x4000504")]
			TriggerLinkedGroupsWhenRequested,
			[Token(Token = "0x4000505")]
			TriggerLinkedGroupsWhenPlayed
		}

		[Token(Token = "0x2000080")]
		public enum TargetDespawnedBehavior
		{
			[Token(Token = "0x4000507")]
			None,
			[Token(Token = "0x4000508")]
			Stop,
			[Token(Token = "0x4000509")]
			FadeOut
		}

		[Token(Token = "0x2000081")]
		public enum VariationSequence
		{
			[Token(Token = "0x400050B")]
			Randomized,
			[Token(Token = "0x400050C")]
			TopToBottom
		}

		[Token(Token = "0x2000082")]
		public enum VariationMode
		{
			[Token(Token = "0x400050E")]
			Normal,
			[Token(Token = "0x400050F")]
			LoopedChain,
			[Token(Token = "0x4000510")]
			Dialog
		}

		[Token(Token = "0x2000083")]
		public enum ChainedLoopLoopMode
		{
			[Token(Token = "0x4000512")]
			Endless,
			[Token(Token = "0x4000513")]
			NumberOfLoops
		}

		[Token(Token = "0x2000084")]
		public enum LimitMode
		{
			[Token(Token = "0x4000515")]
			None,
			[Token(Token = "0x4000516")]
			FrameBased,
			[Token(Token = "0x4000517")]
			TimeBased
		}

		[Token(Token = "0x40002F4")]
		public const float UseCurveSpatialBlend = -99f;

		[Token(Token = "0x40002F5")]
		public const string NoBus = "[NO BUS]";

		[Token(Token = "0x40002F6")]
		public const int MinNoRepeatVariations = 3;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int busIndex;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spatialBlend;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isSelected;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExpanded;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float groupMasterVolume;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int retriggerPercentage;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VariationMode curVariationMode;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float chainLoopDelayMin;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float chainLoopDelayMax;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int chainLoopNumLoops;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool useDialogFadeOut;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float dialogFadeOutTime;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public VariationSequence curVariationSequence;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupVariation> groupVariations;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		public bool logSound;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		public bool copySettingsExpanded;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int selectedVariationIndex;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public ChildGroupMode childGroupMode;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<string> childSoundGroups;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public LimitMode limitMode;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public int limitPerXFrames;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float minimumTimeBetween;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		public bool limitPolyphony;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int voiceLimitCount;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float despawnFadeTime;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool isUsingOcclusion;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		public bool isSoloed;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E")]
		public bool isMuted;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9F")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<int> _activeAudioSourcesIds;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string _objectName;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Transform _trans;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int _childCount;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float _originalVolume;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int frames;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6C58", Offset = "0x4A6C58")]
		private int <ChainLoopCount>k__BackingField;

		[Token(Token = "0x1700008B")]
		public MasterAudio.InternetFileLoadStatus GroupLoadStatus
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x8E5F08", Offset = "0x8E5F08", VA = "0x8E5F08")]
			get
			{
				return default(MasterAudio.InternetFileLoadStatus);
			}
		}

		[Token(Token = "0x1700008C")]
		public float SpatialBlendForGroup
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x8E6730", Offset = "0x8E6730", VA = "0x8E6730")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008D")]
		public int ActiveVoices
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x8E6834", Offset = "0x8E6834", VA = "0x8E6834")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008E")]
		public int TotalVoices
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x8E6898", Offset = "0x8E6898", VA = "0x8E6898")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008F")]
		public GroupBus BusForGroup
		{
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x8E65A4", Offset = "0x8E65A4", VA = "0x8E65A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x8E68CC", Offset = "0x8E68CC", VA = "0x8E68CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x8E68D4", Offset = "0x8E68D4", VA = "0x8E68D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public int ChainLoopCount
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x8E68DC", Offset = "0x8E68DC", VA = "0x8E68DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A74A0", Offset = "0x4A74A0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x8E68E4", Offset = "0x8E68E4", VA = "0x8E68E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A74B0", Offset = "0x4A74B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public string GameObjectName
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x8E6348", Offset = "0x8E6348", VA = "0x8E6348")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		public bool UsesNoRepeat
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x8E68EC", Offset = "0x8E68EC", VA = "0x8E68EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000094")]
		private Transform Trans
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x8E600C", Offset = "0x8E600C", VA = "0x8E600C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		private List<int> ActiveAudioSourceIds
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x8E62A0", Offset = "0x8E62A0", VA = "0x8E62A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x8E609C", Offset = "0x8E609C", VA = "0x8E609C")]
		private void Start()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x8E638C", Offset = "0x8E638C", VA = "0x8E638C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x8E64D8", Offset = "0x8E64D8", VA = "0x8E64D8")]
		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x8E6694", Offset = "0x8E6694", VA = "0x8E6694")]
		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x8E6974", Offset = "0x8E6974", VA = "0x8E6974")]
		public MasterAudioGroup()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class MasterCustomEventAttribute : PropertyAttribute
	{
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x8E6A9C", Offset = "0x8E6A9C", VA = "0x8E6A9C")]
		public MasterCustomEventAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class MusicSetting
	{
		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string alias;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string songName;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string resourceFileName;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pitch;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isExpanded;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isLoop;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float customStartTime;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int lastKnownTimePoint;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int songIndex;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool songStartedEventExpanded;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string songStartedCustomEvent;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string songChangedCustomEvent;

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x8E6E44", Offset = "0x8E6E44", VA = "0x8E6E44")]
		public MusicSetting()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x8E6EE8", Offset = "0x8E6EE8", VA = "0x8E6EE8")]
		public static MusicSetting Clone(MusicSetting mus)
		{
			return null;
		}
	}
	[Token(Token = "0x200005E")]
	public class SoundGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x8EF874", Offset = "0x8EF874", VA = "0x8EF874")]
		public SoundGroupAttribute()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x4A6644", Offset = "0x4A6644")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4A6644", Offset = "0x4A6644")]
	public class SoundGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x2000085")]
		public delegate void SoundFinishedEventHandler();

		[Token(Token = "0x2000086")]
		public class PlaySoundParams
		{
			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string SoundType;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VolumePercentage;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float? Pitch;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform SourceTrans;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool AttachToSource;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float DelaySoundTime;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool IsChainLoop;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool IsSingleSubscribedPlay;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float GroupCalcVolume;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool IsPlaying;

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x8F3BD8", Offset = "0x8F3BD8", VA = "0x8F3BD8")]
			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		[Token(Token = "0x2000087")]
		public enum FadeMode
		{
			[Token(Token = "0x4000523")]
			None,
			[Token(Token = "0x4000524")]
			FadeInOut,
			[Token(Token = "0x4000525")]
			FadeOutEarly,
			[Token(Token = "0x4000526")]
			GradualFade
		}

		[Token(Token = "0x2000088")]
		public enum RandomPitchMode
		{
			[Token(Token = "0x4000528")]
			AddToClipPitch,
			[Token(Token = "0x4000529")]
			IgnoreClipPitch
		}

		[Token(Token = "0x2000089")]
		public enum RandomVolumeMode
		{
			[Token(Token = "0x400052B")]
			AddToClipVolume,
			[Token(Token = "0x400052C")]
			IgnoreClipVolume
		}

		[Token(Token = "0x200008A")]
		public enum DetectEndMode
		{
			[Token(Token = "0x400052E")]
			None,
			[Token(Token = "0x400052F")]
			DetectEnd
		}

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int weight;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool useLocalization;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool useRandomPitch;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RandomPitchMode randomPitchMode;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float randomPitchMin;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMax;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool useRandomVolume;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float randomVolumeMin;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMax;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string resourceFileName;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string internetFileUrl;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.InternetFileLoadStatus internetFileLoadStatus;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float fxTailTime;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float original_pitch;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float original_volume;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool isExpanded;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool isChecked;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool useFades;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float fadeInTime;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float fadeOutTime;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool useRandomStartTime;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float randomStartMinPercent;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float randomStartMaxPercent;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool useIntroSilence;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float introSilenceMin;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float introSilenceMax;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float fadeMaxVolume;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public FadeMode curFadeMode;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public DetectEndMode curDetectEndMode;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int frames;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioSource _audioSource;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly PlaySoundParams _playSndParam;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool _isWaitingForDelay;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float _maxVol;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _instanceId;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private bool? _audioLoops;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private SoundGroupVariationUpdater _varUpdater;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _previousSoundFinishedFrame;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string _soundGroupName;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Transform _trans;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private GameObject _go;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private AudioSource _aud;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Transform _objectToFollow;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Transform _objectToTriggerFrom;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private MasterAudioGroup _parentGroupScript;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private bool _attachToSource;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private string _resFileName;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6C78", Offset = "0x4A6C78")]
		private float <LastTimePlayed>k__BackingField;

		[Token(Token = "0x17000096")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x8F32A8", Offset = "0x8F32A8", VA = "0x8F32A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x8F3340", Offset = "0x8F3340", VA = "0x8F3340")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x8F33D8", Offset = "0x8F33D8", VA = "0x8F33D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x8F3470", Offset = "0x8F3470", VA = "0x8F3470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x8F0A80", Offset = "0x8F0A80", VA = "0x8F0A80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x8F3508", Offset = "0x8F3508", VA = "0x8F3508")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public Transform ObjectToFollow
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x8F2130", Offset = "0x8F2130", VA = "0x8F2130")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x8F35A0", Offset = "0x8F35A0", VA = "0x8F35A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public Transform ObjectToTriggerFrom
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x8F32A0", Offset = "0x8F32A0", VA = "0x8F32A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x8F35A8", Offset = "0x8F35A8", VA = "0x8F35A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x8F35B0", Offset = "0x8F35B0", VA = "0x8F35B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009F")]
		public MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x8F0054", Offset = "0x8F0054", VA = "0x8F0054")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public float OriginalPitch
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x8F1684", Offset = "0x8F1684", VA = "0x8F1684")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A1")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x8F384C", Offset = "0x8F384C", VA = "0x8F384C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A2")]
		public string SoundGroupName
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x8F3898", Offset = "0x8F3898", VA = "0x8F3898")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		public bool IsAvailableToPlay
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x8F38DC", Offset = "0x8F38DC", VA = "0x8F38DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A4")]
		public float LastTimePlayed
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x8F3990", Offset = "0x8F3990", VA = "0x8F3990")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A74E0", Offset = "0x4A74E0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x8F3998", Offset = "0x8F3998", VA = "0x8F3998")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A74F0", Offset = "0x4A74F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		private int InstanceId
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x8F1F98", Offset = "0x8F1F98", VA = "0x8F1F98")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A6")]
		public Transform Trans
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x8F2968", Offset = "0x8F2968", VA = "0x8F2968")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x8EFFC4", Offset = "0x8EFFC4", VA = "0x8EFFC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x8EFF2C", Offset = "0x8EFF2C", VA = "0x8EFF2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		public bool AudioLoops
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x8F1ED8", Offset = "0x8F1ED8", VA = "0x8F1ED8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AA")]
		public string ResFileName
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x8F1B4C", Offset = "0x8F1B4C", VA = "0x8F1B4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		public SoundGroupVariationUpdater VariationUpdater
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x8F0794", Offset = "0x8F0794", VA = "0x8F0794")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		public bool IsWaitingForDelay
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x8F39A0", Offset = "0x8F39A0", VA = "0x8F39A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x8F39A8", Offset = "0x8F39A8", VA = "0x8F39A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public PlaySoundParams PlaySoundParm
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x8F39B4", Offset = "0x8F39B4", VA = "0x8F39B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x8F1074", Offset = "0x8F1074", VA = "0x8F1074")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AF")]
		public float SetGroupVolume
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x8F39BC", Offset = "0x8F39BC", VA = "0x8F39BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x8F39E8", Offset = "0x8F39E8", VA = "0x8F39E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		private bool Is2D
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x8F3A20", Offset = "0x8F3A20", VA = "0x8F3A20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		private bool ShouldLoadAsync
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x8F15E0", Offset = "0x8F15E0", VA = "0x8F15E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B2")]
		public bool UsesOcclusion
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x8F09A0", Offset = "0x8F09A0", VA = "0x8F09A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000001")]
		public event SoundFinishedEventHandler SoundFinished
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x8E55C4", Offset = "0x8E55C4", VA = "0x8E55C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A74C0", Offset = "0x4A74C0")]
			add
			{
			}
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x8EFA90", Offset = "0x8EFA90", VA = "0x8EFA90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A74D0", Offset = "0x4A74D0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x8EFB80", Offset = "0x8EFB80", VA = "0x8EFB80")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x8F0218", Offset = "0x8F0218", VA = "0x8F0218")]
		private void Start()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x8F0474", Offset = "0x8F0474", VA = "0x8F0474")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x8F0394", Offset = "0x8F0394", VA = "0x8F0394")]
		public void LoadInternetFile()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x8F0670", Offset = "0x8F0670", VA = "0x8F0670")]
		private void SetOcclusion()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x8F05B4", Offset = "0x8F05B4", VA = "0x8F05B4")]
		private void SetPriority()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x8F0B18", Offset = "0x8F0B18", VA = "0x8F0B18")]
		public void DisableUpdater()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x8F0BC8", Offset = "0x8F0BC8", VA = "0x8F0BC8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x8F0C4C", Offset = "0x8F0C4C", VA = "0x8F0C4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x8F0BCC", Offset = "0x8F0BCC", VA = "0x8F0BCC")]
		private void StopSoundEarly()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x8F0F9C", Offset = "0x8F0F9C", VA = "0x8F0F9C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x8F10A0", Offset = "0x8F10A0", VA = "0x8F10A0")]
		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x8F1BEC", Offset = "0x8F1BEC", VA = "0x8F1BEC")]
		private void InternetFileFailedToLoad()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x8F1BF8", Offset = "0x8F1BF8", VA = "0x8F1BF8")]
		private void InternetFileLoaded()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x8F1CD4", Offset = "0x8F1CD4", VA = "0x8F1CD4")]
		private void ResourceFailedToLoad()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x8F16D0", Offset = "0x8F16D0", VA = "0x8F16D0")]
		private void FinishSetupToPlay()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x8F2208", Offset = "0x8F2208", VA = "0x8F2208")]
		public void JumpToTime(float timeToJumpTo)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x8F2278", Offset = "0x8F2278", VA = "0x8F2278")]
		public void AdjustVolume(float volumePercentage)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x8F2328", Offset = "0x8F2328", VA = "0x8F2328")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x8F2484", Offset = "0x8F2484", VA = "0x8F2484")]
		private void MaybeUnloadClip()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x8F0C50", Offset = "0x8F0C50", VA = "0x8F0C50")]
		public void Stop(bool stopEndDetection = false)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x8F29F8", Offset = "0x8F29F8", VA = "0x8F29F8")]
		public void FadeToVolume(float newVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x8F2DA8", Offset = "0x8F2DA8", VA = "0x8F2DA8")]
		public void FadeOutNow()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x8F30E0", Offset = "0x8F30E0", VA = "0x8F30E0")]
		public void FadeOutNow(float fadeTime)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x8F31E0", Offset = "0x8F31E0", VA = "0x8F31E0")]
		public bool WasTriggeredFromTransform(Transform trans)
		{
			return default(bool);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x8F3AC4", Offset = "0x8F3AC4", VA = "0x8F3AC4")]
		public void ClearSubscribers()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x8F3ACC", Offset = "0x8F3ACC", VA = "0x8F3ACC")]
		public SoundGroupVariation()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		[Token(Token = "0x200008B")]
		private enum WaitForSoundFinishMode
		{
			[Token(Token = "0x4000531")]
			None,
			[Token(Token = "0x4000532")]
			Delay,
			[Token(Token = "0x4000533")]
			Play,
			[Token(Token = "0x4000534")]
			WaitForEnd,
			[Token(Token = "0x4000535")]
			StopOrRepeat,
			[Token(Token = "0x4000536")]
			FxTailWait
		}

		[Token(Token = "0x400036F")]
		private const float FakeNegativeFloatValue = -10f;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _objectToFollow;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _objectToFollowGo;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isFollowing;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SoundGroupVariation _variation;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _priorityLastUpdated;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _occlusionOnLastFrame;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _occlusionLastCalculated;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool _useClipAgePriority;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private WaitForSoundFinishMode _waitMode;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _soundPlayTime;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AudioSource _varAudio;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MasterAudioGroup _parentGrp;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform _trans;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _frameNum;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _fadeOutStartTime;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _fadeInOutWillFadeOut;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool _hasFadeInOutSetMaxVolume;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _fadeInOutInFactor;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _fadeInOutOutFactor;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _fadeOutEarlyTotalFrames;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float _fadeOutEarlyFrameVolChange;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int _fadeOutEarlyFrameNumber;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _fadeOutEarlyOrigVol;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _fadeToTargetFrameVolChange;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _fadeToTargetFrameNumber;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float _fadeToTargetOrigVol;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _fadeToTargetTotalFrames;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _fadeToTargetVolume;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _fadeOutStarted;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float _lastFrameClipTime;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float _fxTailEndTime;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool _isPlayingBackward;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool _hasStartedNextInChain;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _maCachedFromFrame;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MasterAudio _maThisFrame;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static int _listenerCachedFromFrame;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Transform _listenerThisFrame;

		[Token(Token = "0x170000B3")]
		public MasterAudio MAThisFrame
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x8F3A5C", Offset = "0x8F3A5C", VA = "0x8F3A5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private Transform Trans
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x8F42D8", Offset = "0x8F42D8", VA = "0x8F42D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		private AudioSource VarAudio
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x8F3D54", Offset = "0x8F3D54", VA = "0x8F3D54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		private MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x8F4378", Offset = "0x8F4378", VA = "0x8F4378")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		private SoundGroupVariation GrpVariation
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x8F3CBC", Offset = "0x8F3CBC", VA = "0x8F3CBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x8F2BC4", Offset = "0x8F2BC4", VA = "0x8F2BC4")]
		public void FadeOverTimeToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x8F2EB0", Offset = "0x8F2EB0", VA = "0x8F2EB0")]
		public void FadeOutEarly(float fadeTime)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x8F1CDC", Offset = "0x8F1CDC", VA = "0x8F1CDC")]
		public void FadeInOut()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x8F2138", Offset = "0x8F2138", VA = "0x8F2138")]
		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x8F1FCC", Offset = "0x8F1FCC", VA = "0x8F1FCC")]
		public void WaitForSoundFinish(float delaySound)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x8F2534", Offset = "0x8F2534", VA = "0x8F2534")]
		public void StopFading()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x8F244C", Offset = "0x8F244C", VA = "0x8F244C")]
		public void StopWaitingForFinish()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x8F2524", Offset = "0x8F2524", VA = "0x8F2524")]
		public void StopFollowing()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x8F4260", Offset = "0x8F4260", VA = "0x8F4260")]
		private void DisableIfFinished()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x8F3DF4", Offset = "0x8F3DF4", VA = "0x8F3DF4")]
		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x8F4418", Offset = "0x8F4418", VA = "0x8F4418")]
		private void ResetToNonOcclusionSetting()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x8F44D8", Offset = "0x8F44D8", VA = "0x8F44D8")]
		private void UpdateOcclusion()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x8F3FAC", Offset = "0x8F3FAC", VA = "0x8F3FAC")]
		private void PlaySoundAndWait()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x8F51A0", Offset = "0x8F51A0", VA = "0x8F51A0")]
		private void StopOrChain()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x8F5268", Offset = "0x8F5268", VA = "0x8F5268")]
		private void MaybeChain()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x8F5530", Offset = "0x8F5530", VA = "0x8F5530")]
		private void PerformFading()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x8F5964", Offset = "0x8F5964", VA = "0x8F5964")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x8F082C", Offset = "0x8F082C", VA = "0x8F082C")]
		public void UpdateCachedObjects()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x8F5974", Offset = "0x8F5974", VA = "0x8F5974")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x8F5C44", Offset = "0x8F5C44", VA = "0x8F5C44")]
		public SoundGroupVariationUpdater()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public static class AudioPrioritizer
	{
		[Token(Token = "0x4000395")]
		private const int MaxPriority = 0;

		[Token(Token = "0x4000396")]
		private const int HighestPriority = 16;

		[Token(Token = "0x4000397")]
		private const int LowestPriority = 128;

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x608E44", Offset = "0x608E44", VA = "0x608E44")]
		public static void Set2DSoundPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x608E74", Offset = "0x608E74", VA = "0x608E74")]
		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x608EA4", Offset = "0x608EA4", VA = "0x608EA4")]
		public static void SetPreviewPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x608ED4", Offset = "0x608ED4", VA = "0x608ED4")]
		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
		}
	}
	[Token(Token = "0x2000062")]
	public static class AudioResourceOptimizer
	{
		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6778", Offset = "0x4A6778")]
		private sealed class <PopulateResourceSongToPlaylistControllerAsync>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string songResourceName;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string playlistName;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PlaylistController controller;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public PlaylistController.AudioPlayType playType;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x17000107")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000676")]
				[Address(RVA = "0x60C474", Offset = "0x60C474", VA = "0x60C474", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000108")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000678")]
				[Address(RVA = "0x60C4E4", Offset = "0x60C4E4", VA = "0x60C4E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x60AB40", Offset = "0x60AB40", VA = "0x60AB40")]
			[DebuggerHidden]
			public <PopulateResourceSongToPlaylistControllerAsync>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x60BE60", Offset = "0x60BE60", VA = "0x60BE60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x60BE64", Offset = "0x60BE64", VA = "0x60BE64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x60C47C", Offset = "0x60C47C", VA = "0x60C47C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6788", Offset = "0x4A6788")]
		private sealed class <PopulateSourceWithInternetFile>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string fileUrl;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SoundGroupVariation variation;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action failureAction;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private WWW <fileRequest>5__2;

			[Token(Token = "0x17000109")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600067D")]
				[Address(RVA = "0x60CE5C", Offset = "0x60CE5C", VA = "0x60CE5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600067F")]
				[Address(RVA = "0x60CECC", Offset = "0x60CECC", VA = "0x60CECC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x60AC38", Offset = "0x60AC38", VA = "0x60AC38")]
			[DebuggerHidden]
			public <PopulateSourceWithInternetFile>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x60C4EC", Offset = "0x60C4EC", VA = "0x60C4EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x60C5C8", Offset = "0x60C5C8", VA = "0x60C5C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x60C508", Offset = "0x60C508", VA = "0x60C508")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x60CE64", Offset = "0x60CE64", VA = "0x60CE64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6798", Offset = "0x4A6798")]
		private sealed class <PopulateSourcesWithResourceClipAsync>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action failureAction;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public SoundGroupVariation variation;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x1700010B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000683")]
				[Address(RVA = "0x60D564", Offset = "0x60D564", VA = "0x60D564", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000685")]
				[Address(RVA = "0x60D5D4", Offset = "0x60D5D4", VA = "0x60D5D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x60B070", Offset = "0x60B070", VA = "0x60B070")]
			[DebuggerHidden]
			public <PopulateSourcesWithResourceClipAsync>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x60CED4", Offset = "0x60CED4", VA = "0x60CED4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x60CED8", Offset = "0x60CED8", VA = "0x60CED8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x60D56C", Offset = "0x60D56C", VA = "0x60D56C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, AudioClip> AudioClipsByName;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly List<string> InternetFilesStartedLoading;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string _supportedLanguageFolder;

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x6095E4", Offset = "0x6095E4", VA = "0x6095E4")]
		public static void ClearAudioClips()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x609694", Offset = "0x609694", VA = "0x609694")]
		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x609A20", Offset = "0x609A20", VA = "0x609A20")]
		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x609DBC", Offset = "0x609DBC", VA = "0x609DBC")]
		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x609ABC", Offset = "0x609ABC", VA = "0x609ABC")]
		private static string SupportedLanguageFolder()
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x60A2C0", Offset = "0x60A2C0", VA = "0x60A2C0")]
		public static void ClearSupportLanguageFolder()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x60A33C", Offset = "0x60A33C", VA = "0x60A33C")]
		public static AudioClip PopulateResourceSongToPlaylistController(string controllerName, string songResourceName, string playlistName)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x60A8EC", Offset = "0x60A8EC", VA = "0x60A8EC")]
		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x60AA74", Offset = "0x60AA74", VA = "0x60AA74")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4A7500", Offset = "0x4A7500")]
		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x60AB6C", Offset = "0x60AB6C", VA = "0x60AB6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4A7564", Offset = "0x4A7564")]
		public static IEnumerator PopulateSourceWithInternetFile(string fileUrl, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x60AC64", Offset = "0x60AC64", VA = "0x60AC64")]
		public static void RemoveLoadedInternetClip(string fileUrl)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x60AFA4", Offset = "0x60AFA4", VA = "0x60AFA4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4A75C8", Offset = "0x4A75C8")]
		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x60B09C", Offset = "0x60B09C", VA = "0x60B09C")]
		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x60B254", Offset = "0x60B254", VA = "0x60B254")]
		public static bool PopulateSourcesWithResourceClip(string clipName, SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x60B820", Offset = "0x60B820", VA = "0x60B820")]
		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x60BA1C", Offset = "0x60BA1C", VA = "0x60BA1C")]
		public static void UnloadClipIfUnused(string clipName)
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x4A66BC", Offset = "0x4A66BC")]
	public class MasterAudio : MonoBehaviour
	{
		[Token(Token = "0x200008F")]
		public enum OcclusionSelectionType
		{
			[Token(Token = "0x400054D")]
			AllGroups,
			[Token(Token = "0x400054E")]
			TurnOnPerBusOrGroup
		}

		[Token(Token = "0x2000090")]
		public enum RaycastMode
		{
			[Token(Token = "0x4000550")]
			Physics3D,
			[Token(Token = "0x4000551")]
			Physics2D
		}

		[Token(Token = "0x2000091")]
		public enum AllMusicSpatialBlendType
		{
			[Token(Token = "0x4000553")]
			ForceAllTo2D,
			[Token(Token = "0x4000554")]
			ForceAllTo3D,
			[Token(Token = "0x4000555")]
			ForceAllToCustom,
			[Token(Token = "0x4000556")]
			AllowDifferentPerController
		}

		[Token(Token = "0x2000092")]
		public enum AllMixerSpatialBlendType
		{
			[Token(Token = "0x4000558")]
			ForceAllTo2D,
			[Token(Token = "0x4000559")]
			ForceAllTo3D,
			[Token(Token = "0x400055A")]
			ForceAllToCustom,
			[Token(Token = "0x400055B")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x2000093")]
		public enum ItemSpatialBlendType
		{
			[Token(Token = "0x400055D")]
			ForceTo2D,
			[Token(Token = "0x400055E")]
			ForceTo3D,
			[Token(Token = "0x400055F")]
			ForceToCustom,
			[Token(Token = "0x4000560")]
			UseCurveFromAudioSource
		}

		[Token(Token = "0x2000094")]
		public enum InternetFileLoadStatus
		{
			[Token(Token = "0x4000562")]
			Loading,
			[Token(Token = "0x4000563")]
			Loaded,
			[Token(Token = "0x4000564")]
			Failed
		}

		[Token(Token = "0x2000095")]
		public enum MixerWidthMode
		{
			[Token(Token = "0x4000566")]
			Narrow,
			[Token(Token = "0x4000567")]
			Normal,
			[Token(Token = "0x4000568")]
			Wide
		}

		[Token(Token = "0x2000096")]
		public enum CustomEventReceiveMode
		{
			[Token(Token = "0x400056A")]
			Always,
			[Token(Token = "0x400056B")]
			WhenDistanceLessThan,
			[Token(Token = "0x400056C")]
			WhenDistanceMoreThan,
			[Token(Token = "0x400056D")]
			Never
		}

		[Token(Token = "0x2000097")]
		public enum AudioLocation
		{
			[Token(Token = "0x400056F")]
			Clip,
			[Token(Token = "0x4000570")]
			ResourceFile,
			[Token(Token = "0x4000571")]
			FileOnInternet
		}

		[Token(Token = "0x2000098")]
		public enum BusCommand
		{
			[Token(Token = "0x4000573")]
			None,
			[Token(Token = "0x4000574")]
			FadeToVolume,
			[Token(Token = "0x4000575")]
			Mute,
			[Token(Token = "0x4000576")]
			Pause,
			[Token(Token = "0x4000577")]
			Solo,
			[Token(Token = "0x4000578")]
			Unmute,
			[Token(Token = "0x4000579")]
			Unpause,
			[Token(Token = "0x400057A")]
			Unsolo,
			[Token(Token = "0x400057B")]
			Stop,
			[Token(Token = "0x400057C")]
			ChangeBusPitch,
			[Token(Token = "0x400057D")]
			ToggleMute
		}

		[Token(Token = "0x2000099")]
		public enum DragGroupMode
		{
			[Token(Token = "0x400057F")]
			OneGroupPerClip,
			[Token(Token = "0x4000580")]
			OneGroupWithVariations
		}

		[Token(Token = "0x200009A")]
		public enum EventSoundFunctionType
		{
			[Token(Token = "0x4000582")]
			PlaySound,
			[Token(Token = "0x4000583")]
			GroupControl,
			[Token(Token = "0x4000584")]
			BusControl,
			[Token(Token = "0x4000585")]
			PlaylistControl,
			[Token(Token = "0x4000586")]
			CustomEventControl,
			[Token(Token = "0x4000587")]
			GlobalControl,
			[Token(Token = "0x4000588")]
			UnityMixerControl,
			[Token(Token = "0x4000589")]
			PersistentSettingsControl
		}

		[Token(Token = "0x200009B")]
		public enum LanguageMode
		{
			[Token(Token = "0x400058B")]
			UseDeviceSetting,
			[Token(Token = "0x400058C")]
			SpecificLanguage,
			[Token(Token = "0x400058D")]
			DynamicallySet
		}

		[Token(Token = "0x200009C")]
		public enum UnityMixerCommand
		{
			[Token(Token = "0x400058F")]
			None,
			[Token(Token = "0x4000590")]
			TransitionToSnapshot,
			[Token(Token = "0x4000591")]
			TransitionToSnapshotBlend
		}

		[Token(Token = "0x200009D")]
		public enum PlaylistCommand
		{
			[Token(Token = "0x4000593")]
			None,
			[Token(Token = "0x4000594")]
			ChangePlaylist,
			[Token(Token = "0x4000595")]
			FadeToVolume,
			[Token(Token = "0x4000596")]
			PlayClip,
			[Token(Token = "0x4000597")]
			PlayRandomSong,
			[Token(Token = "0x4000598")]
			PlayNextSong,
			[Token(Token = "0x4000599")]
			Pause,
			[Token(Token = "0x400059A")]
			Resume,
			[Token(Token = "0x400059B")]
			Stop,
			[Token(Token = "0x400059C")]
			Mute,
			[Token(Token = "0x400059D")]
			Unmute,
			[Token(Token = "0x400059E")]
			ToggleMute,
			[Token(Token = "0x400059F")]
			Restart,
			[Token(Token = "0x40005A0")]
			Start,
			[Token(Token = "0x40005A1")]
			StopLoopingCurrentSong
		}

		[Token(Token = "0x200009E")]
		public enum CustomEventCommand
		{
			[Token(Token = "0x40005A3")]
			None,
			[Token(Token = "0x40005A4")]
			FireEvent
		}

		[Token(Token = "0x200009F")]
		public enum GlobalCommand
		{
			[Token(Token = "0x40005A6")]
			None,
			[Token(Token = "0x40005A7")]
			PauseMixer,
			[Token(Token = "0x40005A8")]
			UnpauseMixer,
			[Token(Token = "0x40005A9")]
			StopMixer,
			[Token(Token = "0x40005AA")]
			StopEverything,
			[Token(Token = "0x40005AB")]
			PauseEverything,
			[Token(Token = "0x40005AC")]
			UnpauseEverything,
			[Token(Token = "0x40005AD")]
			MuteEverything,
			[Token(Token = "0x40005AE")]
			UnmuteEverything,
			[Token(Token = "0x40005AF")]
			SetMasterMixerVolume,
			[Token(Token = "0x40005B0")]
			SetMasterPlaylistVolume
		}

		[Token(Token = "0x20000A0")]
		public enum SoundGroupCommand
		{
			[Token(Token = "0x40005B2")]
			None,
			[Token(Token = "0x40005B3")]
			FadeToVolume,
			[Token(Token = "0x40005B4")]
			FadeOutAllOfSound,
			[Token(Token = "0x40005B5")]
			Mute,
			[Token(Token = "0x40005B6")]
			Pause,
			[Token(Token = "0x40005B7")]
			Solo,
			[Token(Token = "0x40005B8")]
			StopAllOfSound,
			[Token(Token = "0x40005B9")]
			Unmute,
			[Token(Token = "0x40005BA")]
			Unpause,
			[Token(Token = "0x40005BB")]
			Unsolo,
			[Token(Token = "0x40005BC")]
			StopAllSoundsOfTransform,
			[Token(Token = "0x40005BD")]
			PauseAllSoundsOfTransform,
			[Token(Token = "0x40005BE")]
			UnpauseAllSoundsOfTransform,
			[Token(Token = "0x40005BF")]
			StopSoundGroupOfTransform,
			[Token(Token = "0x40005C0")]
			PauseSoundGroupOfTransform,
			[Token(Token = "0x40005C1")]
			UnpauseSoundGroupOfTransform,
			[Token(Token = "0x40005C2")]
			FadeOutSoundGroupOfTransform,
			[Token(Token = "0x40005C3")]
			RefillSoundGroupPool
		}

		[Token(Token = "0x20000A1")]
		public enum PersistentSettingsCommand
		{
			[Token(Token = "0x40005C5")]
			None,
			[Token(Token = "0x40005C6")]
			SetBusVolume,
			[Token(Token = "0x40005C7")]
			SetGroupVolume,
			[Token(Token = "0x40005C8")]
			SetMixerVolume,
			[Token(Token = "0x40005C9")]
			SetMusicVolume,
			[Token(Token = "0x40005CA")]
			MixerMuteToggle,
			[Token(Token = "0x40005CB")]
			MusicMuteToggle
		}

		[Token(Token = "0x20000A2")]
		public enum SongFadeInPosition
		{
			[Token(Token = "0x40005CD")]
			NewClipFromBeginning = 1,
			[Token(Token = "0x40005CE")]
			NewClipFromLastKnownPosition = 3,
			[Token(Token = "0x40005CF")]
			SynchronizeClips = 5
		}

		[Token(Token = "0x20000A3")]
		public enum SoundSpawnLocationMode
		{
			[Token(Token = "0x40005D1")]
			MasterAudioLocation,
			[Token(Token = "0x40005D2")]
			CallerLocation,
			[Token(Token = "0x40005D3")]
			AttachToCaller
		}

		[Token(Token = "0x20000A4")]
		public enum VariationCommand
		{
			[Token(Token = "0x40005D5")]
			None,
			[Token(Token = "0x40005D6")]
			Stop,
			[Token(Token = "0x40005D7")]
			Pause,
			[Token(Token = "0x40005D8")]
			Unpause
		}

		[Serializable]
		[Token(Token = "0x20000A5")]
		public class AudioGroupInfo
		{
			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<AudioInfo> Sources;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastFramePlayed;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastTimePlayed;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MasterAudioGroup Group;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool PlayedForWarming;

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x8E5D94", Offset = "0x8E5D94", VA = "0x8E5D94")]
			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A6")]
		public class AudioInfo
		{
			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource Source;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float OriginalVolume;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastPercentageVolume;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float LastRandomVolume;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation Variation;

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x8E5DE0", Offset = "0x8E5DE0", VA = "0x8E5DE0")]
			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A7")]
		public class Playlist
		{
			[Token(Token = "0x20000CB")]
			public enum CrossfadeTimeMode
			{
				[Token(Token = "0x400064F")]
				UseMasterSetting,
				[Token(Token = "0x4000650")]
				Override
			}

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isExpanded;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string playlistName;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SongFadeInPosition songTransitionType;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MusicSetting> MusicSettings;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioLocation bulkLocationMode;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CrossfadeTimeMode crossfadeMode;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float crossFadeTime;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool fadeInFirstSong;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool fadeOutLastSong;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			public bool resourceClipsAllLoadAsync;

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x8E5E34", Offset = "0x8E5E34", VA = "0x8E5E34")]
			public Playlist()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A8")]
		public class SoundGroupRefillInfo
		{
			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float LastTimePlayed;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float InactivePeriodSeconds;

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x8E5ED0", Offset = "0x8E5ED0", VA = "0x8E5ED0")]
			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A67A8", Offset = "0x4A67A8")]
		private sealed class <>c
		{
			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<BusFadeInfo> <>9__163_0;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<GroupFadeInfo> <>9__164_0;

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x8E5080", Offset = "0x8E5080", VA = "0x8E5080")]
			public <>c()
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x8E5088", Offset = "0x8E5088", VA = "0x8E5088")]
			internal bool <PerformBusFades>b__163_0(BusFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x8E50BC", Offset = "0x8E50BC", VA = "0x8E50BC")]
			internal bool <PerformGroupFades>b__164_0(GroupFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A67B8", Offset = "0x4A67B8")]
		private sealed class <>c__DisplayClass175_0
		{
			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x8E50F0", Offset = "0x8E50F0", VA = "0x8E50F0")]
			public <>c__DisplayClass175_0()
			{
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x8E50F8", Offset = "0x8E50F8", VA = "0x8E50F8")]
			internal void <PlaySoundAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A67C8", Offset = "0x4A67C8")]
		private sealed class <PlaySoundAndWaitUntilFinished>d__175 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float volumePercentage;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float? pitch;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delaySoundTime;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string variationName;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass175_0 <>8__1;

			[Token(Token = "0x1700010D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000693")]
				[Address(RVA = "0x8E5D1C", Offset = "0x8E5D1C", VA = "0x8E5D1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000695")]
				[Address(RVA = "0x8E5D8C", Offset = "0x8E5D8C", VA = "0x8E5D8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x8E5A64", Offset = "0x8E5A64", VA = "0x8E5A64")]
			[DebuggerHidden]
			public <PlaySoundAndWaitUntilFinished>d__175(int <>1__state)
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x8E5A90", Offset = "0x8E5A90", VA = "0x8E5A90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x8E5A94", Offset = "0x8E5A94", VA = "0x8E5A94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x8E5D24", Offset = "0x8E5D24", VA = "0x8E5D24", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A67D8", Offset = "0x4A67D8")]
		private sealed class <>c__DisplayClass176_0
		{
			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x8E5104", Offset = "0x8E5104", VA = "0x8E5104")]
			public <>c__DisplayClass176_0()
			{
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x8E510C", Offset = "0x8E510C", VA = "0x8E510C")]
			internal void <PlaySound3DAtTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A67E8", Offset = "0x4A67E8")]
		private sealed class <PlaySound3DAtTransformAndWaitUntilFinished>d__176 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private <>c__DisplayClass176_0 <>8__1;

			[Token(Token = "0x1700010F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600069B")]
				[Address(RVA = "0x8E56B4", Offset = "0x8E56B4", VA = "0x8E56B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000110")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600069D")]
				[Address(RVA = "0x8E5724", Offset = "0x8E5724", VA = "0x8E5724", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x8E52EC", Offset = "0x8E52EC", VA = "0x8E52EC")]
			[DebuggerHidden]
			public <PlaySound3DAtTransformAndWaitUntilFinished>d__176(int <>1__state)
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x8E5318", Offset = "0x8E5318", VA = "0x8E5318", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x8E531C", Offset = "0x8E531C", VA = "0x8E531C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x8E56BC", Offset = "0x8E56BC", VA = "0x8E56BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A67F8", Offset = "0x4A67F8")]
		private sealed class <>c__DisplayClass177_0
		{
			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x8E5118", Offset = "0x8E5118", VA = "0x8E5118")]
			public <>c__DisplayClass177_0()
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x8E5120", Offset = "0x8E5120", VA = "0x8E5120")]
			internal void <PlaySound3DFollowTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6808", Offset = "0x4A6808")]
		private sealed class <PlaySound3DFollowTransformAndWaitUntilFinished>d__177 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private <>c__DisplayClass177_0 <>8__1;

			[Token(Token = "0x17000111")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006A3")]
				[Address(RVA = "0x8E59EC", Offset = "0x8E59EC", VA = "0x8E59EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000112")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006A5")]
				[Address(RVA = "0x8E5A5C", Offset = "0x8E5A5C", VA = "0x8E5A5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x8E572C", Offset = "0x8E572C", VA = "0x8E572C")]
			[DebuggerHidden]
			public <PlaySound3DFollowTransformAndWaitUntilFinished>d__177(int <>1__state)
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x8E5758", Offset = "0x8E5758", VA = "0x8E5758", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x8E575C", Offset = "0x8E575C", VA = "0x8E575C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x8E59F4", Offset = "0x8E59F4", VA = "0x8E59F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6818", Offset = "0x4A6818")]
		private sealed class <>c__DisplayClass207_0
		{
			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x8E512C", Offset = "0x8E512C", VA = "0x8E512C")]
			public <>c__DisplayClass207_0()
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x8E5134", Offset = "0x8E5134", VA = "0x8E5134")]
			internal bool <FadeSoundGroupToVolume>b__0(GroupFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6828", Offset = "0x4A6828")]
		private sealed class <>c__DisplayClass251_0
		{
			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x8E516C", Offset = "0x8E516C", VA = "0x8E516C")]
			public <>c__DisplayClass251_0()
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x8E5174", Offset = "0x8E5174", VA = "0x8E5174")]
			internal bool <CreateBus>b__0(GroupBus obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6838", Offset = "0x4A6838")]
		private sealed class <>c__DisplayClass255_0
		{
			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x8E51AC", Offset = "0x8E51AC", VA = "0x8E51AC")]
			public <>c__DisplayClass255_0()
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x8E51B4", Offset = "0x8E51B4", VA = "0x8E51B4")]
			internal bool <FadeBusToVolume>b__0(BusFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6848", Offset = "0x4A6848")]
		private sealed class <>c__DisplayClass325_0
		{
			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x8E51EC", Offset = "0x8E51EC", VA = "0x8E51EC")]
			public <>c__DisplayClass325_0()
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x8E51F4", Offset = "0x8E51F4", VA = "0x8E51F4")]
			internal bool <CreateCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6858", Offset = "0x4A6858")]
		private sealed class <>c__DisplayClass326_0
		{
			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x8E522C", Offset = "0x8E522C", VA = "0x8E522C")]
			public <>c__DisplayClass326_0()
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x8E5234", Offset = "0x8E5234", VA = "0x8E5234")]
			internal bool <DeleteCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6868", Offset = "0x4A6868")]
		private sealed class <>c__DisplayClass327_0
		{
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x8E526C", Offset = "0x8E526C", VA = "0x8E526C")]
			public <>c__DisplayClass327_0()
			{
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x8E5274", Offset = "0x8E5274", VA = "0x8E5274")]
			internal bool <GetCustomEventByName>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6878", Offset = "0x4A6878")]
		private sealed class <>c__DisplayClass329_0
		{
			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x8E52AC", Offset = "0x8E52AC", VA = "0x8E52AC")]
			public <>c__DisplayClass329_0()
			{
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x8E52B4", Offset = "0x8E52B4", VA = "0x8E52B4")]
			internal bool <CustomEventExists>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400039D")]
		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		[Token(Token = "0x400039E")]
		public const string PreviewText = "Fading & random settings are ignored by preview in edit mode.";

		[Token(Token = "0x400039F")]
		public const float SemiTonePitchFactor = 1.05946f;

		[Token(Token = "0x40003A0")]
		public const float SpatialBlend_2DValue = 0f;

		[Token(Token = "0x40003A1")]
		public const float SpatialBlend_3DValue = 1f;

		[Token(Token = "0x40003A2")]
		public const int FramesEarlyToTrigger = 2;

		[Token(Token = "0x40003A3")]
		public const float MaxCrossFadeTimeSeconds = 120f;

		[Token(Token = "0x40003A4")]
		public const float DefaultDuckVolCut = -6f;

		[Token(Token = "0x40003A5")]
		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly YieldInstruction EndOfFrameDelay;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action NumberOfAudioSourcesChanged;

		[Token(Token = "0x40003A8")]
		public const string GizmoFileName = "MasterAudio/MasterAudio Icon.png";

		[Token(Token = "0x40003A9")]
		public const int HardCodedBusOptions = 2;

		[Token(Token = "0x40003AA")]
		public const string AllBusesName = "[All]";

		[Token(Token = "0x40003AB")]
		public const string NoGroupName = "[None]";

		[Token(Token = "0x40003AC")]
		public const string DynamicGroupName = "[Type In]";

		[Token(Token = "0x40003AD")]
		public const string NoPlaylistName = "[No Playlist]";

		[Token(Token = "0x40003AE")]
		public const string NoVoiceLimitName = "[NO LMT]";

		[Token(Token = "0x40003AF")]
		public const string OnlyPlaylistControllerName = "~only~";

		[Token(Token = "0x40003B0")]
		public const float InnerLoopCheckInterval = 0.1f;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioLocation bulkLocationMode;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupTemplateName;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string audioSourceTemplateName;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showGroupCreation;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useGroupTemplates;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DragGroupMode curDragGroupMode;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> groupTemplates;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mixerMuted;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool playlistsMuted;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LanguageMode langMode;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SystemLanguage testLanguage;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SystemLanguage defaultLanguage;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SystemLanguage> supportedLanguages;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string busFilter;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useTextGroupFilter;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string textGroupFilter;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool resourceClipsPauseDoNotUnload;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform playlistControllerPrefab;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool persistBetweenScenes;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool areGroupsExpanded;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform soundGroupTemplate;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform soundGroupVariationTemplate;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool groupByBus;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool showGizmos;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool showAdvancedSettings;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
		public bool showLocalization;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool playListExpanded;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		public bool playlistsExpanded;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AllMusicSpatialBlendType musicSpatialBlendType;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float musicSpatialBlend;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AllMixerSpatialBlendType mixerSpatialBlendType;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float mixerSpatialBlend;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ItemSpatialBlendType newGroupSpatialType;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float newGroupSpatialBlend;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<Playlist> musicPlaylists;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float _masterAudioVolume;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public bool ignoreTimeScale;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
		public bool followAudioListener;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD6")]
		public bool useGaplessPlaylists;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD7")]
		public bool saveRuntimeChanges;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool prioritizeOnDistance;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public int rePrioritizeEverySecIndex;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool useOcclusion;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public int reOccludeEverySecIndex;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public OcclusionSelectionType occlusionSelectType;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool occlusionUseLayerMask;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public LayerMask occlusionLayerMask;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public bool occlusionShowRaycasts;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		public bool occlusionShowCategories;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public RaycastMode occlusionRaycastMode;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public bool occlusionIncludeStartRaycast2DCollider;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		public bool visualAdvancedExpanded;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		public bool logAdvancedExpanded;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x107")]
		public bool showFadingSettings;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool stopZeroVolumeVariations;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		public bool stopZeroVolumeGroups;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
		public bool stopZeroVolumeBuses;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10B")]
		public bool stopZeroVolumePlaylists;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public bool resourceAdvancedExpanded;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
		public bool useClipAgePriority;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
		public bool LogSounds;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10F")]
		public bool logCustomEvents;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool disableLogging;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		public bool showMusicDucking;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x112")]
		public bool enableMusicDucking;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float defaultRiseVolStart;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public float defaultUnduckTime;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float defaultDuckedVolumeCut;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public float crossFadeTime;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public float _masterPlaylistVolume;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public bool showGroupSelect;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x135")]
		public bool hideGroupsWithNoActiveVars;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public string newEventName;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool showCustomEvents;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public Dictionary<string, DuckGroupInfo> duckingBySoundType;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public int frames;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Transform _trans;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool _soundsLoaded;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		private bool _warming;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Dictionary<string, List<int>> _randomizer;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Dictionary<string, List<int>> _randomizerLeftovers;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly List<MasterAudioGroup> SoloedGroups;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly List<BusFadeInfo> BusFades;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly List<GroupFadeInfo> GroupFades;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly List<AudioSource> AllAudioSources;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly Dictionary<string, PlaylistController> PlaylistControllersByName;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly List<GameObject> OcclusionSourcesInRange;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static readonly List<GameObject> OcclusionSourcesOutOfRange;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static readonly List<GameObject> OcclusionSourcesBlocked;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static MasterAudio _instance;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static float _repriTime;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static List<string> _groupsToRemove;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static string _prospectiveMAFolder;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static Transform _listenerTrans;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static YieldInstruction _innerLoopDelay;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6C88", Offset = "0x4A6C88")]
		private static bool <AppIsShuttingDown>k__BackingField;

		[Token(Token = "0x170000B8")]
		public static float PlaylistMasterVolume
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x62E698", Offset = "0x62E698", VA = "0x62E698")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x61E398", Offset = "0x61E398", VA = "0x61E398")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public static bool LogSoundsEnabled
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x62F008", Offset = "0x62F008", VA = "0x62F008")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x62F078", Offset = "0x62F078", VA = "0x62F078")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public static List<AudioSource> MasterAudioSources
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x62FB48", Offset = "0x62FB48", VA = "0x62FB48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public static Transform ListenerTrans
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x609368", Offset = "0x609368", VA = "0x609368")]
			get
			{
				return null;
			}
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x62FBB0", Offset = "0x62FBB0", VA = "0x62FBB0")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public static PlaylistController OnlyPlaylistController
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x62FC1C", Offset = "0x62FC1C", VA = "0x62FC1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public static bool IsWarming
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x616420", Offset = "0x616420", VA = "0x616420")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BE")]
		public static bool MixerMuted
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x62FCE4", Offset = "0x62FCE4", VA = "0x62FCE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x62BCDC", Offset = "0x62BCDC", VA = "0x62BCDC")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public static bool PlaylistsMuted
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x62FD54", Offset = "0x62FD54", VA = "0x62FD54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x62D2B8", Offset = "0x62D2B8", VA = "0x62D2B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public bool EnableMusicDucking
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x628054", Offset = "0x628054", VA = "0x628054")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x62FDC4", Offset = "0x62FDC4", VA = "0x62FDC4")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public float MasterCrossFadeTime
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x62FDD0", Offset = "0x62FDD0", VA = "0x62FDD0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C2")]
		public static List<Playlist> MusicPlaylists
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x62CE74", Offset = "0x62CE74", VA = "0x62CE74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		public static List<GroupBus> GroupBuses
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x62C39C", Offset = "0x62C39C", VA = "0x62C39C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public static List<string> RuntimeSoundGroupNames
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x61AB2C", Offset = "0x61AB2C", VA = "0x61AB2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public static List<string> RuntimeBusNames
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x61CDA8", Offset = "0x61CDA8", VA = "0x61CDA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public static MasterAudio SafeInstance
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x60FDF8", Offset = "0x60FDF8", VA = "0x60FDF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public static MasterAudio Instance
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x6097F4", Offset = "0x6097F4", VA = "0x6097F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x62FDD8", Offset = "0x62FDD8", VA = "0x62FDD8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public static bool SoundsReady
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x6102AC", Offset = "0x6102AC", VA = "0x6102AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C9")]
		public static bool AppIsShuttingDown
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x60FD90", Offset = "0x60FD90", VA = "0x60FD90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7758", Offset = "0x4A7758")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x624D00", Offset = "0x624D00", VA = "0x624D00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7768", Offset = "0x4A7768")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public List<string> GroupNames
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x62FE40", Offset = "0x62FE40", VA = "0x62FE40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		public List<string> BusNames
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x63004C", Offset = "0x63004C", VA = "0x63004C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x6301D0", Offset = "0x6301D0", VA = "0x6301D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		public Transform Trans
		{
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x6233E8", Offset = "0x6233E8", VA = "0x6233E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CE")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x630354", Offset = "0x630354", VA = "0x630354")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		public List<string> CustomEventNames
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x63035C", Offset = "0x63035C", VA = "0x63035C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D0")]
		public static float MasterVolumeLevel
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x630508", Offset = "0x630508", VA = "0x630508")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x61E1D4", Offset = "0x61E1D4", VA = "0x61E1D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		private static bool SceneHasMasterAudio
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x624D70", Offset = "0x624D70", VA = "0x624D70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D2")]
		public static bool IgnoreTimeScale
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x60EFB8", Offset = "0x60EFB8", VA = "0x60EFB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D3")]
		public static YieldInstruction InnerLoopDelay
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x630578", Offset = "0x630578", VA = "0x630578")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		public static SystemLanguage DynamicLanguage
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x60A0F0", Offset = "0x60A0F0", VA = "0x60A0F0")]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x6305E0", Offset = "0x6305E0", VA = "0x6305E0")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public static float ReprioritizeTime
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x6306B4", Offset = "0x6306B4", VA = "0x6306B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D6")]
		public static float ReOccludeCheckTime
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x63078C", Offset = "0x63078C", VA = "0x63078C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D7")]
		public static string ProspectiveMAPath
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x63086C", Offset = "0x63086C", VA = "0x63086C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x6308D4", Offset = "0x6308D4", VA = "0x6308D4")]
			set
			{
			}
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x62190C", Offset = "0x62190C", VA = "0x62190C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x623744", Offset = "0x623744", VA = "0x623744")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x623974", Offset = "0x623974", VA = "0x623974")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x623BA0", Offset = "0x623BA0", VA = "0x623BA0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x623C24", Offset = "0x623C24", VA = "0x623C24")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x623CA8", Offset = "0x623CA8", VA = "0x623CA8")]
		public void UpdateLocation()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x62481C", Offset = "0x62481C", VA = "0x62481C")]
		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x6244DC", Offset = "0x6244DC", VA = "0x6244DC")]
		private static void RefillInactiveGroupPools()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x623DF0", Offset = "0x623DF0", VA = "0x623DF0")]
		private void PerformBusFades()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x624140", Offset = "0x624140", VA = "0x624140")]
		private void PerformGroupFades()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x624CA0", Offset = "0x624CA0", VA = "0x624CA0")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x60E270", Offset = "0x60E270", VA = "0x60E270")]
		public static void PlaySoundAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x618E88", Offset = "0x618E88", VA = "0x618E88")]
		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x6264E4", Offset = "0x6264E4", VA = "0x6264E4")]
		public static void PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x626670", Offset = "0x626670", VA = "0x626670")]
		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x618940", Offset = "0x618940", VA = "0x618940")]
		public static void PlaySound3DAtTransformAndForget(string sType, [Optional] Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x618780", Offset = "0x618780", VA = "0x618780")]
		public static PlaySoundResult PlaySound3DAtTransform(string sType, [Optional] Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x618CC4", Offset = "0x618CC4", VA = "0x618CC4")]
		public static void PlaySound3DFollowTransformAndForget(string sType, [Optional] Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x618B04", Offset = "0x618B04", VA = "0x618B04")]
		public static PlaySoundResult PlaySound3DFollowTransform(string sType, [Optional] Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x6267E8", Offset = "0x6267E8", VA = "0x6267E8")]
		public static void PlaySound3DAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x62699C", Offset = "0x62699C", VA = "0x62699C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4A762C", Offset = "0x4A762C")]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x626A7C", Offset = "0x626A7C", VA = "0x626A7C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4A7690", Offset = "0x4A7690")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x626B78", Offset = "0x626B78", VA = "0x626B78")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4A76F4", Offset = "0x4A76F4")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x624E04", Offset = "0x624E04", VA = "0x624E04")]
		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, [Optional] float? pitch, [Optional] Transform sourceTrans, [Optional] string variationName, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x626FA0", Offset = "0x626FA0", VA = "0x626FA0")]
		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x627334", Offset = "0x627334", VA = "0x627334")]
		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x6275F8", Offset = "0x6275F8", VA = "0x6275F8")]
		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, ref bool forgetSoundPlayed, [Optional] float? pitch, [Optional] AudioGroupInfo audioGroup, [Optional] Transform sourceTrans, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x627DF0", Offset = "0x627DF0", VA = "0x627DF0")]
		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x62805C", Offset = "0x62805C", VA = "0x62805C")]
		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x61C0BC", Offset = "0x61C0BC", VA = "0x61C0BC")]
		public static void StopAllSoundsOfTransform(Transform trans)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x61C2B8", Offset = "0x61C2B8", VA = "0x61C2B8")]
		public static void StopSoundGroupOfTransform(Transform trans, string sType)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x61C44C", Offset = "0x61C44C", VA = "0x61C44C")]
		public static void PauseAllSoundsOfTransform(Transform trans)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x61C648", Offset = "0x61C648", VA = "0x61C648")]
		public static void PauseSoundGroupOfTransform(Transform trans, string sType)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x61C7DC", Offset = "0x61C7DC", VA = "0x61C7DC")]
		public static void UnpauseAllSoundsOfTransform(Transform trans)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x61C9D8", Offset = "0x61C9D8", VA = "0x61C9D8")]
		public static void UnpauseSoundGroupOfTransform(Transform trans, string sType)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x61CB6C", Offset = "0x61CB6C", VA = "0x61CB6C")]
		public static void FadeOutSoundGroupOfTransform(Transform trans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x61BA38", Offset = "0x61BA38", VA = "0x61BA38")]
		public static void StopAllOfSound(string sType)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x61B3D4", Offset = "0x61B3D4", VA = "0x61B3D4")]
		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x628490", Offset = "0x628490", VA = "0x628490")]
		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x62875C", Offset = "0x62875C", VA = "0x62875C")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x628B20", Offset = "0x628B20", VA = "0x628B20")]
		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x629254", Offset = "0x629254", VA = "0x629254")]
		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x629630", Offset = "0x629630", VA = "0x629630")]
		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x629984", Offset = "0x629984", VA = "0x629984")]
		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x629B34", Offset = "0x629B34", VA = "0x629B34")]
		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x629E10", Offset = "0x629E10", VA = "0x629E10")]
		public static float GetVariationLength(string sType, string variationName)
		{
			return default(float);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x61AC1C", Offset = "0x61AC1C", VA = "0x61AC1C")]
		public static void RefillSoundGroupPool(string sType)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x62A870", Offset = "0x62A870", VA = "0x62A870")]
		public static bool SoundGroupExists(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x61B768", Offset = "0x61B768", VA = "0x61B768")]
		public static void PauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x62A910", Offset = "0x62A910", VA = "0x62A910")]
		public static void SetGroupSpatialBlend(string sType)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x62AAA0", Offset = "0x62AAA0", VA = "0x62AAA0")]
		public void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x61BDEC", Offset = "0x61BDEC", VA = "0x61BDEC")]
		public static void UnpauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x61B078", Offset = "0x61B078", VA = "0x61B078")]
		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x6110F4", Offset = "0x6110F4", VA = "0x6110F4")]
		public static void RemoveSoundGroup(string sType)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x611EC0", Offset = "0x611EC0", VA = "0x611EC0")]
		public static Transform CreateNewSoundGroup(DynamicSoundGroup aGroup, string creatorObjectName, bool errorOnExisting = true)
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x62AE74", Offset = "0x62AE74", VA = "0x62AE74")]
		public static float GetGroupVolume(string sType)
		{
			return default(float);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x6249B8", Offset = "0x6249B8", VA = "0x6249B8")]
		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x61B644", Offset = "0x61B644", VA = "0x61B644")]
		public static void MuteGroup(string sType)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x61BD08", Offset = "0x61BD08", VA = "0x61BD08")]
		public static void UnmuteGroup(string sType)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x623480", Offset = "0x623480", VA = "0x623480")]
		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x62B224", Offset = "0x62B224", VA = "0x62B224")]
		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x62B088", Offset = "0x62B088", VA = "0x62B088")]
		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x623A04", Offset = "0x623A04", VA = "0x623A04")]
		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x62AC50", Offset = "0x62AC50", VA = "0x62AC50")]
		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x62B2D4", Offset = "0x62B2D4", VA = "0x62B2D4")]
		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x62AF30", Offset = "0x62AF30", VA = "0x62AF30")]
		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x61B8F8", Offset = "0x61B8F8", VA = "0x61B8F8")]
		public static void SoloGroup(string sType)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x61BFB4", Offset = "0x61BFB4", VA = "0x61BFB4")]
		public static void UnsoloGroup(string sType)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x6282DC", Offset = "0x6282DC", VA = "0x6282DC")]
		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x62B4C8", Offset = "0x62B4C8", VA = "0x62B4C8")]
		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x62B6AC", Offset = "0x62B6AC", VA = "0x62B6AC")]
		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x62B808", Offset = "0x62B808", VA = "0x62B808")]
		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x62B8F4", Offset = "0x62B8F4", VA = "0x62B8F4")]
		public void SetSpatialBlendForMixer()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x61E4A0", Offset = "0x61E4A0", VA = "0x61E4A0")]
		public static void PauseMixer()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x61E684", Offset = "0x61E684", VA = "0x61E684")]
		public static void UnpauseMixer()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x61E868", Offset = "0x61E868", VA = "0x61E868")]
		public static void StopMixer()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x62BA68", Offset = "0x62BA68", VA = "0x62BA68")]
		public static void UnsubscribeFromAllVariations()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x61EBD4", Offset = "0x61EBD4", VA = "0x61EBD4")]
		public static void StopEverything()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x61EB14", Offset = "0x61EB14", VA = "0x61EB14")]
		public static void PauseEverything()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x61EB74", Offset = "0x61EB74", VA = "0x61EB74")]
		public static void UnpauseEverything()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x61EA4C", Offset = "0x61EA4C", VA = "0x61EA4C")]
		public static void MuteEverything()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x61EAB0", Offset = "0x61EAB0", VA = "0x61EAB0")]
		public static void UnmuteEverything()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x62C07C", Offset = "0x62C07C", VA = "0x62C07C")]
		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x6289B0", Offset = "0x6289B0", VA = "0x6289B0")]
		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return default(int);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x62C40C", Offset = "0x62C40C", VA = "0x62C40C")]
		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x61E004", Offset = "0x61E004", VA = "0x61E004")]
		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x61D780", Offset = "0x61D780", VA = "0x61D780")]
		public static void MuteBus(string busName)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x61D990", Offset = "0x61D990", VA = "0x61D990")]
		public static void UnmuteBus(string busName)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x61DB44", Offset = "0x61DB44", VA = "0x61DB44")]
		public static void ToggleMuteBus(string busName)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x61D2AC", Offset = "0x61D2AC", VA = "0x61D2AC")]
		public static void PauseBus(string busName)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x61DC40", Offset = "0x61DC40", VA = "0x61DC40")]
		public static void SoloBus(string busName)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x61DE50", Offset = "0x61DE50", VA = "0x61DE50")]
		public static void UnsoloBus(string busName)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x62C4A4", Offset = "0x62C4A4", VA = "0x62C4A4")]
		public void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x627010", Offset = "0x627010", VA = "0x627010")]
		private static void StopOldestSoundOnBus(GroupBus bus)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x61D448", Offset = "0x61D448", VA = "0x61D448")]
		public static void StopBus(string busName)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x61D5E4", Offset = "0x61D5E4", VA = "0x61D5E4")]
		public static void UnpauseBus(string busName)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x611C3C", Offset = "0x611C3C", VA = "0x611C3C")]
		public static bool CreateBus(string busName, bool errorOnExisting = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x611054", Offset = "0x611054", VA = "0x611054")]
		public static void DeleteBusByName(string busName)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x62C634", Offset = "0x62C634", VA = "0x62C634")]
		public static void DeleteBus(int busIndex)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x627D34", Offset = "0x627D34", VA = "0x627D34")]
		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return default(float);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x61CF24", Offset = "0x61CF24", VA = "0x61CF24")]
		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x623638", Offset = "0x623638", VA = "0x623638")]
		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x62C808", Offset = "0x62C808", VA = "0x62C808")]
		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x611B2C", Offset = "0x611B2C", VA = "0x611B2C")]
		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x61316C", Offset = "0x61316C", VA = "0x61316C")]
		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x62CC04", Offset = "0x62CC04", VA = "0x62CC04")]
		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x62CCDC", Offset = "0x62CCDC", VA = "0x62CCDC")]
		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x62CEE4", Offset = "0x62CEE4", VA = "0x62CEE4")]
		public static void ChangePlaylistPitch(string playlistName, float pitch, [Optional] string songName)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x62D034", Offset = "0x62D034", VA = "0x62D034")]
		public static void MutePlaylist()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x619978", Offset = "0x619978", VA = "0x619978")]
		public static void MutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x619908", Offset = "0x619908", VA = "0x619908")]
		public static void MuteAllPlaylists()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x62D18C", Offset = "0x62D18C", VA = "0x62D18C")]
		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x62D3D4", Offset = "0x62D3D4", VA = "0x62D3D4")]
		public static void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x619B8C", Offset = "0x619B8C", VA = "0x619B8C")]
		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x619B1C", Offset = "0x619B1C", VA = "0x619B1C")]
		public static void UnmuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x62D43C", Offset = "0x62D43C", VA = "0x62D43C")]
		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x62D568", Offset = "0x62D568", VA = "0x62D568")]
		public static void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x619DA0", Offset = "0x619DA0", VA = "0x619DA0")]
		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x619D30", Offset = "0x619D30", VA = "0x619D30")]
		public static void ToggleMuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x62D5D0", Offset = "0x62D5D0", VA = "0x62D5D0")]
		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x62D690", Offset = "0x62D690", VA = "0x62D690")]
		public static void PausePlaylist()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x61A560", Offset = "0x61A560", VA = "0x61A560")]
		public static void PausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x61A4F0", Offset = "0x61A4F0", VA = "0x61A4F0")]
		public static void PauseAllPlaylists()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x62D6F8", Offset = "0x62D6F8", VA = "0x62D6F8")]
		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x62D7B8", Offset = "0x62D7B8", VA = "0x62D7B8")]
		public static void ResumePlaylist()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x61A988", Offset = "0x61A988", VA = "0x61A988")]
		public static void ResumePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x61A918", Offset = "0x61A918", VA = "0x61A918")]
		public static void ResumeAllPlaylists()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x62D820", Offset = "0x62D820", VA = "0x62D820")]
		private static void ResumePlaylists(List<PlaylistController> controllers)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x62D8E0", Offset = "0x62D8E0", VA = "0x62D8E0")]
		public static void StopPlaylist()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x61A774", Offset = "0x61A774", VA = "0x61A774")]
		public static void StopPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x61A704", Offset = "0x61A704", VA = "0x61A704")]
		public static void StopAllPlaylists()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x62D948", Offset = "0x62D948", VA = "0x62D948")]
		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x62DA0C", Offset = "0x62DA0C", VA = "0x62DA0C")]
		public static void TriggerNextPlaylistClip()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x61A34C", Offset = "0x61A34C", VA = "0x61A34C")]
		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x61A2DC", Offset = "0x61A2DC", VA = "0x61A2DC")]
		public static void TriggerNextClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x62DA74", Offset = "0x62DA74", VA = "0x62DA74")]
		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x62DB34", Offset = "0x62DB34", VA = "0x62DB34")]
		public static void TriggerRandomPlaylistClip()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x61A138", Offset = "0x61A138", VA = "0x61A138")]
		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x61A0C8", Offset = "0x61A0C8", VA = "0x61A0C8")]
		public static void TriggerRandomClipAllPlaylists()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x62DB9C", Offset = "0x62DB9C", VA = "0x62DB9C")]
		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x62DC5C", Offset = "0x62DC5C", VA = "0x62DC5C")]
		public static void RestartPlaylist()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x6190AC", Offset = "0x6190AC", VA = "0x6190AC")]
		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x61903C", Offset = "0x61903C", VA = "0x61903C")]
		public static void RestartAllPlaylists()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x62DCC4", Offset = "0x62DCC4", VA = "0x62DCC4")]
		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x62DD84", Offset = "0x62DD84", VA = "0x62DD84")]
		public static void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x619270", Offset = "0x619270", VA = "0x619270")]
		public static void StartPlaylist(string playlistControllerName, string playlistName)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x6195E8", Offset = "0x6195E8", VA = "0x6195E8")]
		public static void StopLoopingAllCurrentSongs()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x619658", Offset = "0x619658", VA = "0x619658")]
		public static void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x62DEB4", Offset = "0x62DEB4", VA = "0x62DEB4")]
		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x62DDF4", Offset = "0x62DDF4", VA = "0x62DDF4")]
		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x62E078", Offset = "0x62E078", VA = "0x62E078")]
		public static void QueuePlaylistClip(string clipName)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x62E0E8", Offset = "0x62E0E8", VA = "0x62E0E8")]
		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x62E26C", Offset = "0x62E26C", VA = "0x62E26C")]
		public static bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x619F44", Offset = "0x619F44", VA = "0x619F44")]
		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x62E2DC", Offset = "0x62E2DC", VA = "0x62E2DC")]
		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x619460", Offset = "0x619460", VA = "0x619460")]
		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x62E35C", Offset = "0x62E35C", VA = "0x62E35C")]
		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x619748", Offset = "0x619748", VA = "0x619748")]
		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x6196C0", Offset = "0x6196C0", VA = "0x6196C0")]
		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x62E3DC", Offset = "0x62E3DC", VA = "0x62E3DC")]
		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x613590", Offset = "0x613590", VA = "0x613590")]
		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x611684", Offset = "0x611684", VA = "0x611684")]
		public static void DeletePlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x62E544", Offset = "0x62E544", VA = "0x62E544")]
		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x62E708", Offset = "0x62E708", VA = "0x62E708")]
		public static void ReDownloadAllInternetFiles()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x61F2E8", Offset = "0x61F2E8", VA = "0x61F2E8")]
		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x61F710", Offset = "0x61F710", VA = "0x61F710")]
		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x62EBD8", Offset = "0x62EBD8", VA = "0x62EBD8")]
		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x6132FC", Offset = "0x6132FC", VA = "0x6132FC")]
		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, bool errorOnDuplicate = true)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x611500", Offset = "0x611500", VA = "0x611500")]
		public static void DeleteCustomEvent(string customEventName)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x62EEB4", Offset = "0x62EEB4", VA = "0x62EEB4")]
		private static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x6136D0", Offset = "0x6136D0", VA = "0x6136D0")]
		public static void FireCustomEvent(string customEventName, Vector3 originPoint, bool logDupe = true)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x61EF7C", Offset = "0x61EF7C", VA = "0x61EF7C")]
		public static bool CustomEventExists(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x626C74", Offset = "0x626C74", VA = "0x626C74")]
		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x626DA0", Offset = "0x626DA0", VA = "0x626DA0")]
		private static void LogMessage(string message)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x60A814", Offset = "0x60A814", VA = "0x60A814")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x60B774", Offset = "0x60B774", VA = "0x60B774")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x62F0F0", Offset = "0x62F0F0", VA = "0x62F0F0")]
		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x62D09C", Offset = "0x62D09C", VA = "0x62D09C")]
		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x62F31C", Offset = "0x62F31C", VA = "0x62F31C")]
		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x62F4D4", Offset = "0x62F4D4", VA = "0x62F4D4")]
		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x62F7D8", Offset = "0x62F7D8", VA = "0x62F7D8")]
		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x62F6AC", Offset = "0x62F6AC", VA = "0x62F6AC")]
		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x62F904", Offset = "0x62F904", VA = "0x62F904")]
		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x630864", Offset = "0x630864", VA = "0x630864")]
		public static bool HasAsyncResourceLoaderFeature()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x630940", Offset = "0x630940", VA = "0x630940")]
		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x630AB8", Offset = "0x630AB8", VA = "0x630AB8")]
		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x630C30", Offset = "0x630C30", VA = "0x630C30")]
		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x630DA8", Offset = "0x630DA8", VA = "0x630DA8")]
		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x630F20", Offset = "0x630F20", VA = "0x630F20")]
		public MasterAudio()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public static class PersistentAudioSettings
	{
		[Token(Token = "0x400041F")]
		public const string SfxVolKey = "MA_sfxVolume";

		[Token(Token = "0x4000420")]
		public const string MusicVolKey = "MA_musicVolume";

		[Token(Token = "0x4000421")]
		public const string SfxMuteKey = "MA_sfxMute";

		[Token(Token = "0x4000422")]
		public const string MusicMuteKey = "MA_musicMute";

		[Token(Token = "0x4000423")]
		public const string BusVolKey = "MA_BusVolume_";

		[Token(Token = "0x4000424")]
		public const string GroupVolKey = "MA_GroupVolume_";

		[Token(Token = "0x4000425")]
		public const string BusKeysKey = "MA_BusKeys";

		[Token(Token = "0x4000426")]
		public const string GroupKeysKey = "MA_GroupsKeys";

		[Token(Token = "0x4000427")]
		public const string Separator = ";";

		[Token(Token = "0x170000D8")]
		public static string BusesUpdatedKeys
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x8E72B4", Offset = "0x8E72B4", VA = "0x8E72B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x8E7328", Offset = "0x8E7328", VA = "0x8E7328")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public static string GroupsUpdatedKeys
		{
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x8E7464", Offset = "0x8E7464", VA = "0x8E7464")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x8E74D8", Offset = "0x8E74D8", VA = "0x8E74D8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public static bool? MixerMuted
		{
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x8E7784", Offset = "0x8E7784", VA = "0x8E7784")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x8E7814", Offset = "0x8E7814", VA = "0x8E7814")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public static float? MixerVolume
		{
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x8E7948", Offset = "0x8E7948", VA = "0x8E7948")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x8E79D0", Offset = "0x8E79D0", VA = "0x8E79D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public static bool? MusicMuted
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x8E7AFC", Offset = "0x8E7AFC", VA = "0x8E7AFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x8E7B8C", Offset = "0x8E7B8C", VA = "0x8E7B8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public static float? MusicVolume
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x8E7CC0", Offset = "0x8E7CC0", VA = "0x8E7CC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x8E7D48", Offset = "0x8E7D48", VA = "0x8E7D48")]
			set
			{
			}
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x8E70D0", Offset = "0x8E70D0", VA = "0x8E70D0")]
		public static void SetBusVolume(string busName, float vol)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x8E7260", Offset = "0x8E7260", VA = "0x8E7260")]
		public static string MakeBusKey(string busName)
		{
			return null;
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x8E737C", Offset = "0x8E737C", VA = "0x8E737C")]
		public static float? GetBusVolume(string busName)
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x8E7410", Offset = "0x8E7410", VA = "0x8E7410")]
		public static string GetGroupKey(string groupName)
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x8E752C", Offset = "0x8E752C", VA = "0x8E752C")]
		public static void SetGroupVolume(string grpName, float vol)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x8E76F0", Offset = "0x8E76F0", VA = "0x8E76F0")]
		public static float? GetGroupVolume(string grpName)
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x8E7E74", Offset = "0x8E7E74", VA = "0x8E7E74")]
		public static void RestoreMasterSettings()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class SoundGroupOrganizer : MonoBehaviour
	{
		[Token(Token = "0x20000B7")]
		public class CustomEventSelection
		{
			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEvent Event;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x8EFA10", Offset = "0x8EFA10", VA = "0x8EFA10")]
			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
			}
		}

		[Token(Token = "0x20000B8")]
		public class SoundGroupSelection
		{
			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject Go;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x8EFA50", Offset = "0x8EFA50", VA = "0x8EFA50")]
			public SoundGroupSelection(GameObject go, bool isSelected)
			{
			}
		}

		[Token(Token = "0x20000B9")]
		public enum MAItemType
		{
			[Token(Token = "0x400061B")]
			SoundGroups,
			[Token(Token = "0x400061C")]
			CustomEvents
		}

		[Token(Token = "0x20000BA")]
		public enum TransferMode
		{
			[Token(Token = "0x400061E")]
			None,
			[Token(Token = "0x400061F")]
			Import,
			[Token(Token = "0x4000620")]
			Export
		}

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject dynGroupTemplate;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject dynVariationTemplate;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject maGroupTemplate;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject maVariationTemplate;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useTextGroupFilter;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string textGroupFilter;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TransferMode transMode;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject sourceObject;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupSelection> selectedSourceSoundGroups;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject destObject;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<SoundGroupSelection> selectedDestSoundGroups;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public MAItemType itemType;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<CustomEventSelection> selectedSourceCustomEvents;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<CustomEventSelection> selectedDestCustomEvents;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string newEventName;

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x8EF87C", Offset = "0x8EF87C", VA = "0x8EF87C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x8EF8E8", Offset = "0x8EF8E8", VA = "0x8EF8E8")]
		public SoundGroupOrganizer()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public static class ArrayListUtil
	{
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x608970", Offset = "0x608970", VA = "0x608970")]
		public static void SortIntArray(ref List<int> list)
		{
		}
	}
	[Token(Token = "0x2000067")]
	public static class AudioUtil
	{
		[Token(Token = "0x400043B")]
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		[Token(Token = "0x400043C")]
		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		[Token(Token = "0x400043D")]
		private const float SemitonePitchChangeAmt = 1.0594635f;

		[Token(Token = "0x170000DE")]
		private static float CutoffRange
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x60D608", Offset = "0x60D608", VA = "0x60D608")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000DF")]
		private static float MaxCutoffFreq
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x60D698", Offset = "0x60D698", VA = "0x60D698")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E0")]
		public static float MinCutoffFreq
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x60D708", Offset = "0x60D708", VA = "0x60D708")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E1")]
		public static float FrameTime
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x60D778", Offset = "0x60D778", VA = "0x60D778")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x60D780", Offset = "0x60D780", VA = "0x60D780")]
		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio)
		{
			return default(float);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x60D7B0", Offset = "0x60D7B0", VA = "0x60D7B0")]
		public static float GetSemitonesFromPitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x60D874", Offset = "0x60D874", VA = "0x60D874")]
		public static float GetPitchFromSemitones(float semitones)
		{
			return default(float);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x60D928", Offset = "0x60D928", VA = "0x60D928")]
		public static float GetDbFromFloatVolume(float vol)
		{
			return default(float);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x60D9A0", Offset = "0x60D9A0", VA = "0x60D9A0")]
		public static float GetFloatVolumeFromDb(float db)
		{
			return default(float);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x6094B4", Offset = "0x6094B4", VA = "0x6094B4")]
		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x60DA14", Offset = "0x60DA14", VA = "0x60DA14")]
		public static bool IsAudioPaused(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x60DA60", Offset = "0x60DA60", VA = "0x60DA60")]
		public static void UnloadNonPreloadedAudioData(AudioClip clip)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x60A8C0", Offset = "0x60A8C0", VA = "0x60A8C0")]
		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x60DB10", Offset = "0x60DB10", VA = "0x60DB10")]
		public static bool IsClipReadyToPlay(AudioClip clip)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000068")]
	public static class CoroutineHelper
	{
		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6888", Offset = "0x4A6888")]
		private sealed class <WaitForActualSeconds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <start>5__2;

			[Token(Token = "0x17000113")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006B9")]
				[Address(RVA = "0x60EAD0", Offset = "0x60EAD0", VA = "0x60EAD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000114")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006BB")]
				[Address(RVA = "0x60EB40", Offset = "0x60EB40", VA = "0x60EB40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x60E9D8", Offset = "0x60E9D8", VA = "0x60E9D8")]
			[DebuggerHidden]
			public <WaitForActualSeconds>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x60EA04", Offset = "0x60EA04", VA = "0x60EA04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x60EA08", Offset = "0x60EA08", VA = "0x60EA08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x60EAD8", Offset = "0x60EAD8", VA = "0x60EAD8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x60E95C", Offset = "0x60E95C", VA = "0x60E95C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4A7778", Offset = "0x4A7778")]
		public static IEnumerator WaitForActualSeconds(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x2000069")]
	public class DelayBetweenSongs : MonoBehaviour
	{
		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6898", Offset = "0x4A6898")]
		private sealed class <PlaySongWithDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayBetweenSongs <>4__this;

			[Token(Token = "0x17000115")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006BF")]
				[Address(RVA = "0x60F028", Offset = "0x60F028", VA = "0x60F028", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000116")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006C1")]
				[Address(RVA = "0x60F098", Offset = "0x60F098", VA = "0x60F098", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x60EDC8", Offset = "0x60EDC8", VA = "0x60EDC8")]
			[DebuggerHidden]
			public <PlaySongWithDelay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x60EE58", Offset = "0x60EE58", VA = "0x60EE58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x60EE5C", Offset = "0x60EE5C", VA = "0x60EE5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x60F030", Offset = "0x60F030", VA = "0x60F030", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minTimeToWait;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxTimeToWait;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playlistControllerName;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlaylistController _controller;

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x60EBE8", Offset = "0x60EBE8", VA = "0x60EBE8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x60EC8C", Offset = "0x60EC8C", VA = "0x60EC8C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x60ED1C", Offset = "0x60ED1C", VA = "0x60ED1C")]
		private void SongEnded(string songName)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x60ED54", Offset = "0x60ED54", VA = "0x60ED54")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4A77DC", Offset = "0x4A77DC")]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x60EDF4", Offset = "0x60EDF4", VA = "0x60EDF4")]
		public DelayBetweenSongs()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public static class DTMonoHelper
	{
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x60EB88", Offset = "0x60EB88", VA = "0x60EB88")]
		public static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x60EBB4", Offset = "0x60EBB4", VA = "0x60EBB4")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		[Token(Token = "0x20000BD")]
		public enum CreateItemsWhen
		{
			[Token(Token = "0x4000629")]
			FirstEnableOnly,
			[Token(Token = "0x400062A")]
			EveryEnable
		}

		[Token(Token = "0x4000442")]
		public const int ExtraHardCodedBusOptions = 1;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject groupTemplate;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject variationTemplate;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool errorOnDuplicates;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool createOnAwake;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool soundGroupsAreExpanded;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool removeGroupsOnSceneChange;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CreateItemsWhen reUseMode;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool showCustomEvents;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CustomEvent> customEventsToCreate;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string newEventName;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool showMusicDucking;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool playListExpanded;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool playlistEditorExp;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<MasterAudio.Playlist> musicPlaylists;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string audioSourceTemplateName;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool groupByBus;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool itemsCreatedEventExpanded;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string itemsCreatedCustomEvent;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool _hasCreated;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly List<Transform> _groupsToRemove;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform _trans;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly List<DynamicSoundGroup> _groupsToCreate;

		[Token(Token = "0x170000E2")]
		public static int HardCodedBusOptions
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x611EB8", Offset = "0x611EB8", VA = "0x611EB8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E3")]
		public List<DynamicSoundGroup> GroupsToCreate
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x613E24", Offset = "0x613E24", VA = "0x613E24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x613E2C", Offset = "0x613E2C", VA = "0x613E2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x60FAF4", Offset = "0x60FAF4", VA = "0x60FAF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x60FBC4", Offset = "0x60FBC4", VA = "0x60FBC4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x60FCB4", Offset = "0x60FCB4", VA = "0x60FCB4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x60FCB8", Offset = "0x60FCB8", VA = "0x60FCB8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x60FBC8", Offset = "0x60FBC8", VA = "0x60FBC8")]
		private void CreateItemsIfReady()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x60FFCC", Offset = "0x60FFCC", VA = "0x60FFCC")]
		public void RemoveItems()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x610384", Offset = "0x610384", VA = "0x610384")]
		public void CreateItems()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x611864", Offset = "0x611864", VA = "0x611864")]
		public void PopulateGroupData()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x613E34", Offset = "0x613E34", VA = "0x613E34")]
		public DynamicSoundGroupCreator()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x4A66D0", Offset = "0x4A66D0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4A66D0", Offset = "0x4A66D0")]
	public class PlaylistController : MonoBehaviour
	{
		[Token(Token = "0x20000BE")]
		public delegate void SongChangedEventHandler(string newSongName);

		[Token(Token = "0x20000BF")]
		public delegate void SongEndedEventHandler(string songName);

		[Token(Token = "0x20000C0")]
		public enum AudioPlayType
		{
			[Token(Token = "0x400062C")]
			PlayNow,
			[Token(Token = "0x400062D")]
			Schedule,
			[Token(Token = "0x400062E")]
			AlreadyScheduled
		}

		[Token(Token = "0x20000C1")]
		public enum PlaylistStates
		{
			[Token(Token = "0x4000630")]
			NotInScene,
			[Token(Token = "0x4000631")]
			Stopped,
			[Token(Token = "0x4000632")]
			Playing,
			[Token(Token = "0x4000633")]
			Paused,
			[Token(Token = "0x4000634")]
			Crossfading
		}

		[Token(Token = "0x20000C2")]
		public enum FadeMode
		{
			[Token(Token = "0x4000636")]
			None,
			[Token(Token = "0x4000637")]
			GradualFade
		}

		[Token(Token = "0x20000C3")]
		public enum AudioDuckingMode
		{
			[Token(Token = "0x4000639")]
			NotDucking,
			[Token(Token = "0x400063A")]
			SetToDuck,
			[Token(Token = "0x400063B")]
			Ducked
		}

		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A68A8", Offset = "0x4A68A8")]
		private sealed class <>c__DisplayClass79_0
		{
			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string playlistControllerName;

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x8EAA68", Offset = "0x8EAA68", VA = "0x8EAA68")]
			public <>c__DisplayClass79_0()
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x8EF518", Offset = "0x8EF518", VA = "0x8EF518")]
			internal bool <InstanceByName>b__0(PlaylistController obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A68B8", Offset = "0x4A68B8")]
		private sealed class <>c__DisplayClass96_0
		{
			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string clipName;

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x8ECAC4", Offset = "0x8ECAC4", VA = "0x8ECAC4")]
			public <>c__DisplayClass96_0()
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x8EF5C8", Offset = "0x8EF5C8", VA = "0x8EF5C8")]
			internal bool <QueuePlaylistClip>b__0(MusicSetting obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A68C8", Offset = "0x4A68C8")]
		private sealed class <>c__DisplayClass97_0
		{
			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string clipName;

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x8ECEC4", Offset = "0x8ECEC4", VA = "0x8ECEC4")]
			public <>c__DisplayClass97_0()
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x8EF6B4", Offset = "0x8EF6B4", VA = "0x8EF6B4")]
			internal bool <TriggerPlaylistClip>b__0(MusicSetting obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x8EF6EC", Offset = "0x8EF6EC", VA = "0x8EF6EC")]
			internal bool <TriggerPlaylistClip>b__1(MusicSetting obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A68D8", Offset = "0x4A68D8")]
		private sealed class <>c__DisplayClass105_0
		{
			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlaylistController <>4__this;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volumeBeforeFade;

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x8ED360", Offset = "0x8ED360", VA = "0x8ED360")]
			public <>c__DisplayClass105_0()
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x8EF4C8", Offset = "0x8EF4C8", VA = "0x8EF4C8")]
			internal void <FadeOutPlaylist>b__0()
			{
			}
		}

		[Token(Token = "0x4000460")]
		public const int ScheduledSongMinBadOffset = 1;

		[Token(Token = "0x4000461")]
		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		[Token(Token = "0x4000462")]
		private const float MinSongLength = 0.5f;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool startPlaylistOnAwake;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isShuffle;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isAutoAdvance;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool loopPlaylist;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float _playlistVolume;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isMuted;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string startPlaylistName;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int syncGroupNum;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float spatialBlend;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string songChangedCustomEvent;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool songEndedEventExpanded;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string songEndedCustomEvent;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AudioSource _activeAudio;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AudioSource _transitioningAudio;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _activeAudioEndVolume;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _transitioningAudioStartVolume;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float _crossFadeStartTime;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly List<int> _clipsRemaining;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _currentSequentialClipIndex;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private AudioDuckingMode _duckingMode;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _timeToStartUnducking;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _timeToFinishUnducking;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _originalMusicVolume;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float _initialDuckVolume;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float _duckRange;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private MusicSetting _currentSong;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject _go;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string _name;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private FadeMode _curFadeMode;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _slowFadeTargetVolume;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _slowFadeVolStep;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private MasterAudio.Playlist _currentPlaylist;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _lastTimeMissingPlaylistLogged;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Action _fadeCompleteCallback;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly List<MusicSetting> _queuedSongs;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool _lostFocus;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private AudioSource _audioClip;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private AudioSource _transClip;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private MusicSetting _newSongSetting;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool _nextSongRequested;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		private bool _nextSongScheduled;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int _lastRandomClipIndex;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float _lastTimeSongRequested;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float _currentDuckVolCut;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private readonly Dictionary<AudioSource, double> _scheduledSongsByAudioSource;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<PlaylistController> _instances;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int _songsPlayedFromPlaylist;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private AudioSource _audio1;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private AudioSource _audio2;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Transform _trans;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool _willPersist;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6CB8", Offset = "0x4A6CB8")]
		private bool <ControllerIsReady>k__BackingField;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A6CC8", Offset = "0x4A6CC8")]
		private bool <IsCrossFading>k__BackingField;

		[Token(Token = "0x170000E5")]
		private bool SongIsNonAdvancible
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x8EEE5C", Offset = "0x8EEE5C", VA = "0x8EEE5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E6")]
		private bool ShouldLoadAsync
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x8ED4A4", Offset = "0x8ED4A4", VA = "0x8ED4A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E7")]
		public bool ControllerIsReady
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x8E8998", Offset = "0x8E8998", VA = "0x8E8998")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7880", Offset = "0x4A7880")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x8E89A0", Offset = "0x8E89A0", VA = "0x8E89A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7890", Offset = "0x4A7890")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public PlaylistStates PlaylistState
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x8EA5AC", Offset = "0x8EA5AC", VA = "0x8EA5AC")]
			get
			{
				return default(PlaylistStates);
			}
		}

		[Token(Token = "0x170000E9")]
		public AudioSource ActiveAudioSource
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x8E9B10", Offset = "0x8E9B10", VA = "0x8E9B10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EA")]
		public static List<PlaylistController> Instances
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x8EAA70", Offset = "0x8EAA70", VA = "0x8EAA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x8EEEB8", Offset = "0x8EEEB8", VA = "0x8EEEB8")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public GameObject PlaylistControllerGameObject
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x8EEF0C", Offset = "0x8EEF0C", VA = "0x8EEF0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EC")]
		public AudioSource CurrentPlaylistSource
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x8E9544", Offset = "0x8E9544", VA = "0x8E9544")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		public AudioClip CurrentPlaylistClip
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x8EEF14", Offset = "0x8EEF14", VA = "0x8EEF14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EE")]
		public AudioClip FadingPlaylistClip
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x8EEFB4", Offset = "0x8EEFB4", VA = "0x8EEFB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EF")]
		public AudioSource FadingSource
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x8EF05C", Offset = "0x8EF05C", VA = "0x8EF05C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		public bool IsCrossFading
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x8EA0A8", Offset = "0x8EA0A8", VA = "0x8EA0A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A78A0", Offset = "0x4A78A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x8EA3E0", Offset = "0x8EA3E0", VA = "0x8EA3E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A78B0", Offset = "0x4A78B0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public bool IsFading
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x8EF074", Offset = "0x8EF074", VA = "0x8EF074")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F2")]
		public float PlaylistVolume
		{
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x8ED068", Offset = "0x8ED068", VA = "0x8ED068")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x8EF094", Offset = "0x8EF094", VA = "0x8EF094")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public MasterAudio.Playlist CurrentPlaylist
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x8ED548", Offset = "0x8ED548", VA = "0x8ED548")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F4")]
		public bool HasPlaylist
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x8EF100", Offset = "0x8EF100", VA = "0x8EF100")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F5")]
		public string PlaylistName
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x8EF110", Offset = "0x8EF110", VA = "0x8EF110")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F6")]
		private bool IsMuted
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x8E8F58", Offset = "0x8E8F58", VA = "0x8E8F58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F7")]
		private bool PlaylistIsMuted
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x8EAD84", Offset = "0x8EAD84", VA = "0x8EAD84")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		private float CrossFadeTime
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x8EA4D8", Offset = "0x8EA4D8", VA = "0x8EA4D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F9")]
		private bool IsAutoAdvance
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x8EA574", Offset = "0x8EA574", VA = "0x8EA574")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FA")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x8EF18C", Offset = "0x8EF18C", VA = "0x8EF18C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		public string ControllerName
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x8E89AC", Offset = "0x8E89AC", VA = "0x8E89AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		public bool CanSchedule
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x8E94A8", Offset = "0x8E94A8", VA = "0x8E94A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FD")]
		private Transform Trans
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x8ED368", Offset = "0x8ED368", VA = "0x8ED368")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FE")]
		public int ClipsRemainingInCurrentPlaylist
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x8EF21C", Offset = "0x8EF21C", VA = "0x8EF21C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000002")]
		public event SongChangedEventHandler SongChanged
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x8E80D0", Offset = "0x8E80D0", VA = "0x8E80D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7840", Offset = "0x4A7840")]
			add
			{
			}
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x8E81C0", Offset = "0x8E81C0", VA = "0x8E81C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7850", Offset = "0x4A7850")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event SongEndedEventHandler SongEnded
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x8E82B0", Offset = "0x8E82B0", VA = "0x8E82B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7860", Offset = "0x4A7860")]
			add
			{
			}
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x8E83A0", Offset = "0x8E83A0", VA = "0x8E83A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A7870", Offset = "0x4A7870")]
			remove
			{
			}
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x8E8490", Offset = "0x8E8490", VA = "0x8E8490")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x8E89F4", Offset = "0x8E89F4", VA = "0x8E89F4")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x8E8C2C", Offset = "0x8E8C2C", VA = "0x8E8C2C")]
		private void SetAudiosIfEmpty()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x8E8B64", Offset = "0x8E8B64", VA = "0x8E8B64")]
		private void SetAudioSpatialBlend(float blend)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x8E8CD0", Offset = "0x8E8CD0", VA = "0x8E8CD0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x8E8F68", Offset = "0x8E8F68", VA = "0x8E8F68")]
		private void CoUpdate()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x8E9884", Offset = "0x8E9884", VA = "0x8E9884")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x8E9974", Offset = "0x8E9974", VA = "0x8E9974")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x8E9BF0", Offset = "0x8E9BF0", VA = "0x8E9BF0")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x8E9BFC", Offset = "0x8E9BFC", VA = "0x8E9BFC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x8EA8E4", Offset = "0x8EA8E4", VA = "0x8EA8E4")]
		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x8EAC2C", Offset = "0x8EAC2C", VA = "0x8EAC2C")]
		public void ClearQueue()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x8EACD0", Offset = "0x8EACD0", VA = "0x8EACD0")]
		public void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x8E8F60", Offset = "0x8E8F60", VA = "0x8E8F60")]
		public void MutePlaylist()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x8EAD7C", Offset = "0x8EAD7C", VA = "0x8EAD7C")]
		public void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x8EAF14", Offset = "0x8EAF14", VA = "0x8EAF14")]
		public void PausePlaylist()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x8EB050", Offset = "0x8EB050", VA = "0x8EB050")]
		public bool ResumePlaylist()
		{
			return default(bool);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x8E97B8", Offset = "0x8E97B8", VA = "0x8E97B8")]
		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x8EB314", Offset = "0x8EB314", VA = "0x8EB314")]
		public void FadeToVolume(float targetVolume, float fadeTime, [Optional] Action callback)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x8EB418", Offset = "0x8EB418", VA = "0x8EB418")]
		public void PlayRandomSong()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x8EB4A8", Offset = "0x8EB4A8", VA = "0x8EB4A8")]
		public void PlayARandomSong(AudioPlayType playType, bool isMidsong)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x8EB6BC", Offset = "0x8EB6BC", VA = "0x8EB6BC")]
		private void RemoveRandomClip(int randIndex)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x8EC0B0", Offset = "0x8EC0B0", VA = "0x8EC0B0")]
		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x8EC208", Offset = "0x8EC208", VA = "0x8EC208")]
		public void PlayNextSong()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x8EC298", Offset = "0x8EC298", VA = "0x8EC298")]
		public void PlayTheNextSong(AudioPlayType playType, bool isMidsong)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x8EC424", Offset = "0x8EC424", VA = "0x8EC424")]
		private void AdvanceSongCounter()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x8EC4C0", Offset = "0x8EC4C0", VA = "0x8EC4C0")]
		public void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x8EC668", Offset = "0x8EC668", VA = "0x8EC668")]
		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x8ECACC", Offset = "0x8ECACC", VA = "0x8ECACC")]
		public bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x8ECECC", Offset = "0x8ECECC", VA = "0x8ECECC")]
		public void DuckMusicForTime(float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x8ED02C", Offset = "0x8ED02C", VA = "0x8ED02C")]
		private void InitControllerIfNot()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x8E96B4", Offset = "0x8E96B4", VA = "0x8E96B4")]
		public void UpdateMasterVolume()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x8ED0D8", Offset = "0x8ED0D8", VA = "0x8ED0D8")]
		public void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x8ED234", Offset = "0x8ED234", VA = "0x8ED234")]
		public void ChangePlaylist(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x8EB260", Offset = "0x8EB260", VA = "0x8EB260")]
		private void FinishPlaylistInit(bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x8ED1A8", Offset = "0x8ED1A8", VA = "0x8ED1A8")]
		public void RestartPlaylist()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x8EA6CC", Offset = "0x8EA6CC", VA = "0x8EA6CC")]
		private void FadeOutPlaylist()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x8E8E24", Offset = "0x8E8E24", VA = "0x8E8E24")]
		private void InitializePlaylist()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x8E8E90", Offset = "0x8E8E90", VA = "0x8E8E90")]
		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x8EBE9C", Offset = "0x8EBE9C", VA = "0x8EBE9C")]
		private void FillClips()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x8EB774", Offset = "0x8EB774", VA = "0x8EB774")]
		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x8ED5F0", Offset = "0x8ED5F0", VA = "0x8ED5F0")]
		public void FinishLoadingNewSong(AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x8EDF48", Offset = "0x8EDF48", VA = "0x8EDF48")]
		private void RemoveScheduledClip()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x8EC660", Offset = "0x8EC660", VA = "0x8EC660")]
		private void ScheduleNextSong()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x8EA7B8", Offset = "0x8EA7B8", VA = "0x8EA7B8")]
		private void FadeInScheduledSong()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x8E954C", Offset = "0x8E954C", VA = "0x8E954C")]
		private double CalculateNextTrackStartTime()
		{
			return default(double);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x8E9614", Offset = "0x8E9614", VA = "0x8E9614")]
		private void ScheduleClipPlay(double scheduledPlayTime)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x8EDEF4", Offset = "0x8EDEF4", VA = "0x8EDEF4")]
		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x8EA0B0", Offset = "0x8EA0B0", VA = "0x8EA0B0")]
		private void CeaseAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x8EA3EC", Offset = "0x8EA3EC", VA = "0x8EA3EC")]
		private void SetDuckProperties()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x8EA7C0", Offset = "0x8EA7C0", VA = "0x8EA7C0")]
		private void AudioDucking()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x8ED3F8", Offset = "0x8ED3F8", VA = "0x8ED3F8")]
		private bool SongShouldLoop(MusicSetting setting)
		{
			return default(bool);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x8EF09C", Offset = "0x8EF09C", VA = "0x8EF09C")]
		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x8EF27C", Offset = "0x8EF27C", VA = "0x8EF27C")]
		public PlaylistController()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x8EF3B0", Offset = "0x8EF3B0", VA = "0x8EF3B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A78C0", Offset = "0x4A78C0")]
		private bool <FinishLoadingNewSong>b__110_0(PlaylistController obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x8EF4B8", Offset = "0x8EF4B8", VA = "0x8EF4B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A78D0", Offset = "0x4A78D0")]
		private bool <FinishLoadingNewSong>b__110_1(MusicSetting obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200006D")]
	public static class UtilStrings
	{
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x8F5CCC", Offset = "0x8F5CCC", VA = "0x8F5CCC")]
		public static string TrimSpace(string untrimmed)
		{
			return null;
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x8F5D50", Offset = "0x8F5D50", VA = "0x8F5D50")]
		public static string ReplaceUnsafeChars(string source)
		{
			return null;
		}
	}
}
