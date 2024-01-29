using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using DG.Tweening;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Oculus.Platform;
using Oculus.Platform.Models;
using Odders.ShapeIt.GameFlow;
using Odders.ShapeIt.GameTools;
using Odders.ShapeIt.Menu;
using Odders.VR.Players;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.Video;
using Zenject;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class CircleRunner : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private InputActionProperty aButton;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Header("Player")]
	[SerializeField]
	private Transform player;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float jumpForce;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float gravity;

	[Token(Token = "0x4000005")]
	private const float _FloorY = -0.475f;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool _isGrounded;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float _velocity;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Header("Obstacles")]
	private Transform rotationReference;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform obstacleParent;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject obstacle1;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject obstacle2;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Transform obstacle1Spawn;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform obstacle2Spawn;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float obstacleSpeed;

	[Token(Token = "0x400000F")]
	private const float _ObstacleSpeedUpRate = 0.0001f;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float _maxTimeToSpawn;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float _maxTimeDownRate;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float _minTimeToSpawn;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _selectedTime;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float _time;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject[] _obstacles;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int _obstaclesSize;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int _obstacleNumber;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[Header("Score")]
	private float _score;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private TextMeshPro scoreText;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool _isGameOver;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xDB4AA0", Offset = "0xDB4AA0", VA = "0xDB4AA0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xDB4B3C", Offset = "0xDB4B3C", VA = "0xDB4B3C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xDB4BD8", Offset = "0xDB4BD8", VA = "0xDB4BD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xDB4E0C", Offset = "0xDB4E0C", VA = "0xDB4E0C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xDB4F1C", Offset = "0xDB4F1C", VA = "0xDB4F1C")]
	private void SpawnObstacles()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xDB5130", Offset = "0xDB5130", VA = "0xDB5130")]
	private void Gravity()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xDB4EC0", Offset = "0xDB4EC0", VA = "0xDB4EC0")]
	private void Jump(InputAction.CallbackContext obj)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xDB51EC", Offset = "0xDB51EC", VA = "0xDB51EC")]
	private void MoveObstacles()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xDB5344", Offset = "0xDB5344", VA = "0xDB5344")]
	public void AddScore()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xDB5358", Offset = "0xDB5358", VA = "0xDB5358")]
	public void GameOver()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xDB540C", Offset = "0xDB540C", VA = "0xDB540C")]
	public CircleRunner()
	{
	}
}
[Token(Token = "0x2000003")]
[RequireComponent(typeof(MeshRenderer), typeof(BoxCollider))]
public class CircleRunnerObstacle : MonoBehaviour
{
	[Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class <Activate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CircleRunnerObstacle <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0xDB5798", Offset = "0xDB5798", VA = "0xDB5798", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xDB57E0", Offset = "0xDB57E0", VA = "0xDB57E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xDB5570", Offset = "0xDB5570", VA = "0xDB5570")]
		[DebuggerHidden]
		public <Activate>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xDB56D0", Offset = "0xDB56D0", VA = "0xDB56D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xDB56D4", Offset = "0xDB56D4", VA = "0xDB56D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xDB57A0", Offset = "0xDB57A0", VA = "0xDB57A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CircleRunner circleRunner;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer _mesh;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private BoxCollider _boxCollider;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xDB5434", Offset = "0xDB5434", VA = "0xDB5434")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xDB54B0", Offset = "0xDB54B0", VA = "0xDB54B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xDB5538", Offset = "0xDB5538", VA = "0xDB5538")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xDB54D0", Offset = "0xDB54D0", VA = "0xDB54D0")]
	[IteratorStateMachine(typeof(<Activate>d__6))]
	private IEnumerator Activate()
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xDB5598", Offset = "0xDB5598", VA = "0xDB5598")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xDB5640", Offset = "0xDB5640", VA = "0xDB5640")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xDB56C8", Offset = "0xDB56C8", VA = "0xDB56C8")]
	public CircleRunnerObstacle()
	{
	}
}
[Token(Token = "0x2000005")]
public class Arkanoid : MonoBehaviour
{
	[Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class <Reset>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Arkanoid <>4__this;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool resetScores;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <i>5__2;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0xDB6B44", Offset = "0xDB6B44", VA = "0xDB6B44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0xDB6B8C", Offset = "0xDB6B8C", VA = "0xDB6B8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xDB68C0", Offset = "0xDB68C0", VA = "0xDB68C0")]
		[DebuggerHidden]
		public <Reset>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xDB6990", Offset = "0xDB6990", VA = "0xDB6990", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xDB6994", Offset = "0xDB6994", VA = "0xDB6994", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xDB6B4C", Offset = "0xDB6B4C", VA = "0xDB6B4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody ball;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TMP_Text counter;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Text scoreText;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TMP_Text healthText;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TMP_Text endGameText;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float velocity;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform centerPlayer;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 _initBallPos;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Vector3 _velocity;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3 _playerLocalRotation;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool _canMove;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	private bool _endGame;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float mapRadius;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject enemie;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _health;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public int score;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int enemies;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<GameObject> blocksList;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Tween _tween;

	[Token(Token = "0x17000003")]
	private float direction
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0xDB57E8", Offset = "0xDB57E8", VA = "0xDB57E8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000004")]
	private bool Bounds
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0xDB582C", Offset = "0xDB582C", VA = "0xDB582C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xDB5914", Offset = "0xDB5914", VA = "0xDB5914")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xDB591C", Offset = "0xDB591C", VA = "0xDB591C")]
	public void RestartGame(bool resetScores = true)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xDB5A40", Offset = "0xDB5A40", VA = "0xDB5A40")]
	private void CleanBlocks()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xDB5B30", Offset = "0xDB5B30", VA = "0xDB5B30")]
	private void GenerateBlocks()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xDB60FC", Offset = "0xDB60FC", VA = "0xDB60FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xDB67BC", Offset = "0xDB67BC", VA = "0xDB67BC")]
	private void Lose()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xDB66D0", Offset = "0xDB66D0", VA = "0xDB66D0")]
	private void Win()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xDB68A8", Offset = "0xDB68A8", VA = "0xDB68A8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xDB65A4", Offset = "0xDB65A4", VA = "0xDB65A4")]
	public void PlayerMovement()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xDB5E74", Offset = "0xDB5E74", VA = "0xDB5E74")]
	[IteratorStateMachine(typeof(<Reset>d__32))]
	private IEnumerator Reset(bool resetScores = true)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xDB68E8", Offset = "0xDB68E8", VA = "0xDB68E8")]
	public Arkanoid()
	{
	}
}
[Token(Token = "0x2000007")]
public class ArkanoidBlock : MonoBehaviour
{
	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Arkanoid _controller;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _collided;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Tweener _tweener;

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xDB5EF0", Offset = "0xDB5EF0", VA = "0xDB5EF0")]
	public void Init(Arkanoid controller)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xDB6B9C", Offset = "0xDB6B9C", VA = "0xDB6B9C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xDB6BAC", Offset = "0xDB6BAC", VA = "0xDB6BAC")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xDB6DCC", Offset = "0xDB6DCC", VA = "0xDB6DCC")]
	private Vector3 Bounce(Vector3 collisionNormal, Rigidbody rb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xDB6F78", Offset = "0xDB6F78", VA = "0xDB6F78")]
	public ArkanoidBlock()
	{
	}
}
[Token(Token = "0x2000009")]
public class ArkanoidPlayer : MonoBehaviour
{
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 latePos;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 direction;

	[Token(Token = "0x17000007")]
	private Vector3 mapDirection
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0xDB700C", Offset = "0xDB700C", VA = "0xDB700C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xDB713C", Offset = "0xDB713C", VA = "0xDB713C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xDB71A0", Offset = "0xDB71A0", VA = "0xDB71A0")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xDB7498", Offset = "0xDB7498", VA = "0xDB7498")]
	private Vector3 MapDirection(Vector3 origin)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xDB75AC", Offset = "0xDB75AC", VA = "0xDB75AC")]
	private Vector3 Bounce(Vector3 Normal, Rigidbody rb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xDB7804", Offset = "0xDB7804", VA = "0xDB7804")]
	public ArkanoidPlayer()
	{
	}
}
[Token(Token = "0x200000A")]
public class FeetMenu : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200000B")]
	public class MenuMini
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject mini;

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xDB8538", Offset = "0xDB8538", VA = "0xDB8538")]
		public MenuMini()
		{
		}
	}

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private InputActionProperty xButton;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private InputActionProperty yButton;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private InputActionProperty verticalDirection;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private InputActionProperty backButton;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private InputActionProperty acceptButton;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Renderer[] feetRenderer;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Camera footCamera;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private GameObject menuGameobject;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private MenuMini[] minis;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private GameObject textPrefab;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private RectTransform pointer;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private List<RectTransform> _textsTransform;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool _discoverMinigames;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	private bool _openedMenu;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private int _miniIndex;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private GameObject _currentGame;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private bool _canMove;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private GameplayWindowsManager.State _currentState;

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xDB780C", Offset = "0xDB780C", VA = "0xDB780C")]
	private void CheckShow(InputAction.CallbackContext obj)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xDB78F4", Offset = "0xDB78F4", VA = "0xDB78F4")]
	private void Close()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xDB79C8", Offset = "0xDB79C8", VA = "0xDB79C8")]
	private void Open(bool resetIndex = true)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xDB7D3C", Offset = "0xDB7D3C", VA = "0xDB7D3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xDB7F4C", Offset = "0xDB7F4C", VA = "0xDB7F4C")]
	private void OnChangeState(GameplayWindowsManager.State newstate)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xDB7F84", Offset = "0xDB7F84", VA = "0xDB7F84")]
	private void Update()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xDB7AB4", Offset = "0xDB7AB4", VA = "0xDB7AB4")]
	private void CreateTexts()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xDB80F8", Offset = "0xDB80F8", VA = "0xDB80F8")]
	private void GoDown()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xDB80A8", Offset = "0xDB80A8", VA = "0xDB80A8")]
	private void GoUp()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xDB7CC8", Offset = "0xDB7CC8", VA = "0xDB7CC8")]
	private void RedrawUI()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xDB8148", Offset = "0xDB8148", VA = "0xDB8148")]
	private void Accept(InputAction.CallbackContext obj)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xDB8220", Offset = "0xDB8220", VA = "0xDB8220")]
	private void Back(InputAction.CallbackContext obj)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xDB82AC", Offset = "0xDB82AC", VA = "0xDB82AC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xDB84BC", Offset = "0xDB84BC", VA = "0xDB84BC")]
	public FeetMenu()
	{
	}
}
[Token(Token = "0x200000C")]
public class Ship : MonoBehaviour
{
	[Token(Token = "0x200000D")]
	private class Ent
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float _dx;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float _dy;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _x;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _y;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _angle;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _t;

		[Token(Token = "0x400006B")]
		private const float MaxSpeed = 0.005f;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Rot;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Acc;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int Tag;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int Mode;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int Life;

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xDB8E00", Offset = "0xDB8E00", VA = "0xDB8E00")]
		public Ent(Transform t, float x, float y, int tag = 0, int mode = 0)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xDB939C", Offset = "0xDB939C", VA = "0xDB939C")]
		public void Draw()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xDB9340", Offset = "0xDB9340", VA = "0xDB9340")]
		public Vector3 PosRot()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xDB8E94", Offset = "0xDB8E94", VA = "0xDB8E94")]
		public void SetDir(float rot, float force)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xDB97CC", Offset = "0xDB97CC", VA = "0xDB97CC")]
		public void PhysUpdate()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xDB9BC8", Offset = "0xDB9BC8", VA = "0xDB9BC8")]
		public static Vector2 ToPolar(Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xDB8E58", Offset = "0xDB8E58", VA = "0xDB8E58")]
		public static Vector2 ToCartesian(Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xDB9B4C", Offset = "0xDB9B4C", VA = "0xDB9B4C")]
		private void Warp()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xDB9A40", Offset = "0xDB9A40", VA = "0xDB9A40")]
		public void Reflect(float dx, float dy)
		{
		}
	}

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_Text levelText;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_Text scoreText;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject gameOver;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RectTransform ship;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform bullet;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform boom;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RectTransform asteroid;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ParticleSystem smoke;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _canShoot;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool _vrMode;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly string _inputH;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly string _inputV;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly string _inputFire;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem.EmissionModule _emissionModule;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<Ent> ents;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<Transform> bullets;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<Transform> booms;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<Transform> asteroids;

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xDB8540", Offset = "0xDB8540", VA = "0xDB8540")]
	private Transform Pool(Transform from, List<Transform> list, bool isParticle = false)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xDB8A4C", Offset = "0xDB8A4C", VA = "0xDB8A4C")]
	private void Start()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xDB8F70", Offset = "0xDB8F70", VA = "0xDB8F70")]
	private void Update()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xDB9430", Offset = "0xDB9430", VA = "0xDB9430")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xDB93E0", Offset = "0xDB93E0", VA = "0xDB93E0")]
	private void Explode(float x, float y)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xDB9A50", Offset = "0xDB9A50", VA = "0xDB9A50")]
	public Ship()
	{
	}
}
[Token(Token = "0x200000F")]
public class Tetris : MonoBehaviour
{
	[Token(Token = "0x2000010")]
	private struct Vec2
	{
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int X;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int Y;
	}

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_Text levelText;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_Text scoreText;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject screen;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject block;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject next;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject gameOver;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int _score;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int _level;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject[,] _blocks;

	[Token(Token = "0x400007C")]
	private const int M = 20;

	[Token(Token = "0x400007D")]
	private const int N = 10;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int[,] _field;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int[,] _figures;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vec2[] _vA;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vec2[] _vB;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int _dx;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int _n0;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int _n1;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _rotate;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
	private bool _canMove;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
	private bool _canRotate;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x87")]
	private bool _canRotateT;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _gameOver;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float _timer;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float _delay;

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xDB9CCC", Offset = "0xDB9CCC", VA = "0xDB9CCC")]
	private void UpdateLevel()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xDB9D98", Offset = "0xDB9D98", VA = "0xDB9D98")]
	private void UpdateScore(int addScore)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xDB9E54", Offset = "0xDB9E54", VA = "0xDB9E54")]
	private void Init()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xDBA09C", Offset = "0xDBA09C", VA = "0xDBA09C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xDBA280", Offset = "0xDBA280", VA = "0xDBA280")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xDBA290", Offset = "0xDBA290", VA = "0xDBA290")]
	private bool Check()
	{
		return default(bool);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xDB9F0C", Offset = "0xDB9F0C", VA = "0xDB9F0C")]
	private void Next()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xDBA328", Offset = "0xDBA328", VA = "0xDBA328")]
	private void Update()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xDBAA00", Offset = "0xDBAA00", VA = "0xDBAA00")]
	public Tetris()
	{
	}
}
[Token(Token = "0x2000011")]
public class KeyBoard : MonoBehaviour
{
	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static KeyBoard keyBoard;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string inputString;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _letters;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _symbols;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private TMP_InputField _inputField;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Text> keys;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool _caps;

	[Token(Token = "0x17000008")]
	public string Text
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0xDBAC98", Offset = "0xDBAC98", VA = "0xDBAC98")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000068")]
		[Address(RVA = "0xDBACB4", Offset = "0xDBACB4", VA = "0xDBACB4")]
		set
		{
		}
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xDBAB14", Offset = "0xDBAB14", VA = "0xDBAB14")]
	public void UseKeyBoard(TMP_InputField inputField)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xDBAB3C", Offset = "0xDBAB3C", VA = "0xDBAB3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xDBACD0", Offset = "0xDBACD0", VA = "0xDBACD0")]
	public void SendBackspace()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xDBAE2C", Offset = "0xDBAE2C", VA = "0xDBAE2C")]
	public void SendEnd()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xDBAE54", Offset = "0xDBAE54", VA = "0xDBAE54")]
	public void SendEnter()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xDBAE7C", Offset = "0xDBAE7C", VA = "0xDBAE7C")]
	public void SendSpace()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xDBAEF0", Offset = "0xDBAEF0", VA = "0xDBAEF0")]
	public void PressKey(GameObject go)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xDBAF8C", Offset = "0xDBAF8C", VA = "0xDBAF8C")]
	public void SendKey(string value)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xDBB23C", Offset = "0xDBB23C", VA = "0xDBB23C")]
	public void PressKey(string key)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xDBB240", Offset = "0xDBB240", VA = "0xDBB240")]
	public void Caps()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xDBB5BC", Offset = "0xDBB5BC", VA = "0xDBB5BC")]
	public void LeftArrow()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xDBB604", Offset = "0xDBB604", VA = "0xDBB604")]
	public void RightArrow()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xDBB64C", Offset = "0xDBB64C", VA = "0xDBB64C")]
	public void SwitchSymbols()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xDBAD44", Offset = "0xDBAD44", VA = "0xDBAD44")]
	private void ProcessEvent(string keyEvent)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xDBB6DC", Offset = "0xDBB6DC", VA = "0xDBB6DC")]
	public KeyBoard()
	{
	}
}
[Token(Token = "0x2000012")]
public class OculusKeyBoard : MonoBehaviour
{
	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TouchScreenKeyboard overlayKeyboard;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_InputField inputText;

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xDBB77C", Offset = "0xDBB77C", VA = "0xDBB77C")]
	public void OpenKeyBoard(TMP_InputField inputText)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xDBB7E0", Offset = "0xDBB7E0", VA = "0xDBB7E0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xDBB8B8", Offset = "0xDBB8B8", VA = "0xDBB8B8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xDBB990", Offset = "0xDBB990", VA = "0xDBB990")]
	public void Test()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xDBBA44", Offset = "0xDBBA44", VA = "0xDBBA44")]
	public OculusKeyBoard()
	{
	}
}
[Token(Token = "0x2000013")]
public class Entrypoint_SceneChange : MonoBehaviour
{
	[Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Entrypoint_SceneChange <>4__this;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xDBBC40", Offset = "0xDBBC40", VA = "0xDBBC40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xDBBC88", Offset = "0xDBBC88", VA = "0xDBBC88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xDBBAB4", Offset = "0xDBBAB4", VA = "0xDBBAB4")]
		[DebuggerHidden]
		public <Start>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xDBBAE4", Offset = "0xDBBAE4", VA = "0xDBBAE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xDBBAE8", Offset = "0xDBBAE8", VA = "0xDBBAE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xDBBC48", Offset = "0xDBBC48", VA = "0xDBBC48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image logo;

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xDBBA4C", Offset = "0xDBBA4C", VA = "0xDBBA4C")]
	[IteratorStateMachine(typeof(<Start>d__1))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xDBBADC", Offset = "0xDBBADC", VA = "0xDBBADC")]
	public Entrypoint_SceneChange()
	{
	}
}
[Token(Token = "0x2000015")]
public class ScrollDeactiveObject : MonoBehaviour
{
	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform topObject;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float topY;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float botY;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform botObject;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform[] childs;

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xDBBC90", Offset = "0xDBBC90", VA = "0xDBBC90")]
	private void Start()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xDBBD0C", Offset = "0xDBBD0C", VA = "0xDBBD0C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xDBBDF0", Offset = "0xDBBDF0", VA = "0xDBBDF0")]
	public void ManageObjects(Transform t, bool active)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xDBBF04", Offset = "0xDBBF04", VA = "0xDBBF04")]
	public ScrollDeactiveObject()
	{
	}
}
[Token(Token = "0x2000016")]
public class TextVideo3D : MonoBehaviour
{
	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Right Hand")]
	[CanBeNull]
	public GameObject rightHand;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[CanBeNull]
	public GameObject leftHand;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("X Value")]
	public float xValue;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float xRotation;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Button Xxlus;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Button xMinuns;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TMP_Text xText;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Button XRotPlus;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Button XRotMinuss;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TMP_Text xRot;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Header("Y Value")]
	public float yValue;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float yRotation;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Button yPlus;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Button yMinuns;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TMP_Text yText;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Button YRotPlus;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Button YRotMinuss;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TMP_Text yRot;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Header("Z Value")]
	public float zValue;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float zRotation;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Button zPlus;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Button zMinuns;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TMP_Text zText;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Button ZRotPlus;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Button ZRotMinuss;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public TMP_Text zRot;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public XRPlayerController _xrPlayerController;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float initX;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float initY;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float initZ;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float initRotX;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float initRotY;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float initRotZ;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool setUp;

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xDBBF0C", Offset = "0xDBBF0C", VA = "0xDBBF0C")]
	[Inject]
	private void Constructor(Odders.VR.Players.PlayerController playerController)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xDBBF8C", Offset = "0xDBBF8C", VA = "0xDBBF8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xDBC3C4", Offset = "0xDBC3C4", VA = "0xDBC3C4")]
	private void Update()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xDBC840", Offset = "0xDBC840", VA = "0xDBC840")]
	private void SetUP()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xDBC860", Offset = "0xDBC860", VA = "0xDBC860")]
	public float PlussValue(float value, float increment)
	{
		return default(float);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xDBC868", Offset = "0xDBC868", VA = "0xDBC868")]
	public TextVideo3D()
	{
	}
}
[Token(Token = "0x2000017")]
public class YmlToBinary : MonoBehaviour
{
	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string filePath;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LevelData song;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xDBC978", Offset = "0xDBC978", VA = "0xDBC978")]
	public void Serialize()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xDBCBF4", Offset = "0xDBCBF4", VA = "0xDBCBF4")]
	public YmlToBinary()
	{
	}
}
[Token(Token = "0x2000018")]
[RequireComponent(typeof(ParticleSystem))]
public class particleAttractorLinear : MonoBehaviour
{
	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int numParticlesAlive;

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xDBCC44", Offset = "0xDBCC44", VA = "0xDBCC44")]
	private void Start()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xDBCD10", Offset = "0xDBCD10", VA = "0xDBCD10")]
	private void Update()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xDBCE94", Offset = "0xDBCE94", VA = "0xDBCE94")]
	public particleAttractorLinear()
	{
	}
}
[Token(Token = "0x2000019")]
[RequireComponent(typeof(ParticleSystem))]
public class particleAttractorMove : MonoBehaviour
{
	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int numParticlesAlive;

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xDBCEA4", Offset = "0xDBCEA4", VA = "0xDBCEA4")]
	private void Start()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xDBCF70", Offset = "0xDBCF70", VA = "0xDBCF70")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xDBD1CC", Offset = "0xDBD1CC", VA = "0xDBD1CC")]
	public particleAttractorMove()
	{
	}
}
[Token(Token = "0x200001A")]
[RequireComponent(typeof(ParticleSystem))]
public class particleAttractorSelf : MonoBehaviour
{
	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int numParticlesAlive;

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xDBD1DC", Offset = "0xDBD1DC", VA = "0xDBD1DC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xDBD2A8", Offset = "0xDBD2A8", VA = "0xDBD2A8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xDBD448", Offset = "0xDBD448", VA = "0xDBD448")]
	public particleAttractorSelf()
	{
	}
}
[Token(Token = "0x200001B")]
[RequireComponent(typeof(ParticleSystem))]
public class particleAttractorSpherical : MonoBehaviour
{
	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int numParticlesAlive;

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xDBD458", Offset = "0xDBD458", VA = "0xDBD458")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xDBD524", Offset = "0xDBD524", VA = "0xDBD524")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xDBD6A8", Offset = "0xDBD6A8", VA = "0xDBD6A8")]
	public particleAttractorSpherical()
	{
	}
}
[Token(Token = "0x200001C")]
public class rotation : MonoBehaviour
{
	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float xRotation;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float yRotation;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float zRotation;

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xDBD6B8", Offset = "0xDBD6B8", VA = "0xDBD6B8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xDBD710", Offset = "0xDBD710", VA = "0xDBD710")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xDBD718", Offset = "0xDBD718", VA = "0xDBD718")]
	public void clickOn()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xDBD770", Offset = "0xDBD770", VA = "0xDBD770")]
	public void clickOff()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xDBD778", Offset = "0xDBD778", VA = "0xDBD778")]
	private void rotate()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xDBD7C8", Offset = "0xDBD7C8", VA = "0xDBD7C8")]
	public rotation()
	{
	}
}
[Token(Token = "0x200001D")]
public class OvrAvatarTestDriver : OvrAvatarDriver
{
	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 headPos;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion headRot;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xDBD7D0", Offset = "0xDBD7D0", VA = "0xDBD7D0")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xDBD910", Offset = "0xDBD910", VA = "0xDBD910")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xDBDC40", Offset = "0xDBDC40", VA = "0xDBDC40")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xDBDDD8", Offset = "0xDBDDD8", VA = "0xDBDDD8", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xDBDE04", Offset = "0xDBDE04", VA = "0xDBDE04")]
	public OvrAvatarTestDriver()
	{
	}
}
[Token(Token = "0x200001E")]
public class PoseEditHelper : MonoBehaviour
{
	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform poseRoot;

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xDBDE6C", Offset = "0xDBDE6C", VA = "0xDBDE6C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xDBDEE8", Offset = "0xDBDEE8", VA = "0xDBDEE8")]
	private void DrawJoints(Transform joint)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xDBE058", Offset = "0xDBE058", VA = "0xDBE058")]
	public PoseEditHelper()
	{
	}
}
[Token(Token = "0x200001F")]
public class GazeTargetSpawner : MonoBehaviour
{
	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject GazeTargetPrefab;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int NumberOfDummyTargets;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int RadiusMultiplier;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isVisible;

	[Token(Token = "0x1700000B")]
	public bool IsVisible
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xDBE060", Offset = "0xDBE060", VA = "0xDBE060")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xDBE068", Offset = "0xDBE068", VA = "0xDBE068")]
		set
		{
		}
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xDBE18C", Offset = "0xDBE18C", VA = "0xDBE18C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xDBE37C", Offset = "0xDBE37C", VA = "0xDBE37C")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xDBE384", Offset = "0xDBE384", VA = "0xDBE384")]
	public GazeTargetSpawner()
	{
	}
}
[Token(Token = "0x2000020")]
public class RemoteLoopbackManager : MonoBehaviour
{
	[Token(Token = "0x2000021")]
	private class PacketLatencyPair
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] PacketData;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FakeLatency;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xDBEF74", Offset = "0xDBEF74", VA = "0xDBEF74")]
		public PacketLatencyPair()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000022")]
	public class SimulatedLatencySettings
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 0.5f)]
		public float FakeLatencyMax;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 0.5f)]
		public float FakeLatencyMin;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float LatencyWeight;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 10f)]
		public int MaxSamples;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal float AverageWindow;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float LatencySum;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal LinkedList<float> LatencyValues;

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xDBEF7C", Offset = "0xDBEF7C", VA = "0xDBEF7C")]
		public float NextValue()
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xDBF158", Offset = "0xDBF158", VA = "0xDBF158")]
		public SimulatedLatencySettings()
		{
		}
	}

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OvrAvatar LocalAvatar;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar LoopbackAvatar;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimulatedLatencySettings LatencySettings;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int PacketSequence;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LinkedList<PacketLatencyPair> packetQueue;

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xDBE398", Offset = "0xDBE398", VA = "0xDBE398")]
	private void Start()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xDBE4DC", Offset = "0xDBE4DC", VA = "0xDBE4DC")]
	private void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xDBE8CC", Offset = "0xDBE8CC", VA = "0xDBE8CC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xDBE82C", Offset = "0xDBE82C", VA = "0xDBE82C")]
	private void SendPacketData(byte[] data)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xDBEC58", Offset = "0xDBEC58", VA = "0xDBEC58")]
	private void ReceivePacketData(byte[] data)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xDBF0B0", Offset = "0xDBF0B0", VA = "0xDBF0B0")]
	public RemoteLoopbackManager()
	{
	}
}
[Token(Token = "0x2000023")]
public class P2PManager
{
	[Token(Token = "0x2000024")]
	private enum MessageType : byte
	{
		[Token(Token = "0x40000F1")]
		Update = 1
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xDBF1EC", Offset = "0xDBF1EC", VA = "0xDBF1EC")]
	public P2PManager()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xDBF2B8", Offset = "0xDBF2B8", VA = "0xDBF2B8")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xDBF4F8", Offset = "0xDBF4F8", VA = "0xDBF4F8")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xDBF640", Offset = "0xDBF640", VA = "0xDBF640")]
	private void PeerConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xDBF790", Offset = "0xDBF790", VA = "0xDBF790")]
	private void ConnectionStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xDBF97C", Offset = "0xDBF97C", VA = "0xDBF97C")]
	public void SendAvatarUpdate(ulong userID, Transform rootTransform, uint sequence, byte[] avatarPacket)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xDBFD34", Offset = "0xDBFD34", VA = "0xDBFD34")]
	public void GetRemotePackets()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xDBFFBC", Offset = "0xDBFFBC", VA = "0xDBFFBC")]
	public void processAvatarPacket(RemotePlayer remote, ref byte[] packet, ref int offset)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xDBFB40", Offset = "0xDBFB40", VA = "0xDBFB40")]
	private void PackByte(byte b, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xDBFF08", Offset = "0xDBFF08", VA = "0xDBFF08")]
	private byte ReadByte(byte[] buf, ref int offset)
	{
		return default(byte);
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xDBFC0C", Offset = "0xDBFC0C", VA = "0xDBFC0C")]
	private void PackFloat(float f, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xDC01E4", Offset = "0xDC01E4", VA = "0xDC01E4")]
	private float ReadFloat(byte[] buf, ref int offset)
	{
		return default(float);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xDBFB7C", Offset = "0xDBFB7C", VA = "0xDBFB7C")]
	private void PackULong(ulong u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xDBFF40", Offset = "0xDBFF40", VA = "0xDBFF40")]
	private ulong ReadULong(byte[] buf, ref int offset)
	{
		return default(ulong);
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xDBFCA4", Offset = "0xDBFCA4", VA = "0xDBFCA4")]
	private void PackUInt32(uint u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xDC0260", Offset = "0xDC0260", VA = "0xDC0260")]
	private uint ReadUInt32(byte[] buf, ref int offset)
	{
		return default(uint);
	}
}
[Token(Token = "0x2000025")]
public class PlayerController : SocialPlatformManager
{
	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Camera spyCamera;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject cameraRig;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool showUI;

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xDC02DC", Offset = "0xDC02DC", VA = "0xDC02DC", Slot = "5")]
	public override void Awake()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xDC065C", Offset = "0xDC065C", VA = "0xDC065C", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xDC0680", Offset = "0xDC0680", VA = "0xDC0680", Slot = "4")]
	public override void Update()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xDC0A20", Offset = "0xDC0A20", VA = "0xDC0A20")]
	private void checkInput()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xDC0B80", Offset = "0xDC0B80", VA = "0xDC0B80")]
	private void ToggleCamera()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xDC0BFC", Offset = "0xDC0BFC", VA = "0xDC0BFC")]
	private void ToggleUI()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xDC0C44", Offset = "0xDC0C44", VA = "0xDC0C44")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x2000026")]
public class RemotePlayer
{
	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong remoteUserID;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool stillInRoom;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public PeerConnectionState p2pConnectionState;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PeerConnectionState voipConnectionState;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar RemoteAvatar;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 receivedRootPosition;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 receivedRootPositionPrior;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Quaternion receivedRootRotation;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Quaternion receivedRootRotationPrior;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public VoipAudioSourceHiLevel voipSource;

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xDC0D1C", Offset = "0xDC0D1C", VA = "0xDC0D1C")]
	public RemotePlayer()
	{
	}
}
[Token(Token = "0x2000027")]
public class RoomManager
{
	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong roomID;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong invitedRoomID;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool amIServer;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool startupDone;

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xDC0D24", Offset = "0xDC0D24", VA = "0xDC0D24")]
	public RoomManager()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xDC0E08", Offset = "0xDC0E08", VA = "0xDC0E08")]
	private void AcceptingInviteCallback(Message<string> msg)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xDC1008", Offset = "0xDC1008", VA = "0xDC1008")]
	public bool CheckForInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xDC1120", Offset = "0xDC1120", VA = "0xDC1120")]
	public void CreateRoom()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xDC11D8", Offset = "0xDC11D8", VA = "0xDC11D8")]
	private void CreateAndJoinPrivateRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xDC15C4", Offset = "0xDC15C4", VA = "0xDC15C4")]
	private void OnLaunchInviteWorkflowComplete(Message msg)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xDC1034", Offset = "0xDC1034", VA = "0xDC1034")]
	public void JoinExistingRoom(ulong roomID)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xDC163C", Offset = "0xDC163C", VA = "0xDC163C")]
	private void JoinRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xDC1D54", Offset = "0xDC1D54", VA = "0xDC1D54")]
	private void RoomUpdateCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xDC2028", Offset = "0xDC2028", VA = "0xDC2028")]
	public void LeaveCurrentRoom()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xDC1904", Offset = "0xDC1904", VA = "0xDC1904")]
	private void ProcessRoomData(Message<Room> msg)
	{
	}
}
[Token(Token = "0x2000028")]
public class SocialPlatformManager : MonoBehaviour
{
	[Token(Token = "0x2000029")]
	public enum State
	{
		[Token(Token = "0x4000129")]
		INITIALIZING,
		[Token(Token = "0x400012A")]
		CHECKING_LAUNCH_STATE,
		[Token(Token = "0x400012B")]
		CREATING_A_ROOM,
		[Token(Token = "0x400012C")]
		WAITING_IN_A_ROOM,
		[Token(Token = "0x400012D")]
		JOINING_A_ROOM,
		[Token(Token = "0x400012E")]
		CONNECTED_IN_A_ROOM,
		[Token(Token = "0x400012F")]
		LEAVING_A_ROOM,
		[Token(Token = "0x4000130")]
		SHUTDOWN
	}

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 START_ROTATION_ONE;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly Vector3 START_POSITION_ONE;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 START_ROTATION_TWO;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly Vector3 START_POSITION_TWO;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Vector3 START_ROTATION_THREE;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly Vector3 START_POSITION_THREE;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly Vector3 START_ROTATION_FOUR;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static readonly Vector3 START_POSITION_FOUR;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly Color BLACK;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static readonly Color WHITE;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static readonly Color CYAN;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static readonly Color BLUE;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static readonly Color GREEN;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float voiceCurrent;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private uint packetSequence;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar localAvatarPrefab;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar remoteAvatarPrefab;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject helpPanel;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected MeshRenderer helpMesh;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material riftMaterial;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material gearMaterial;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected OvrAvatar localAvatar;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected GameObject localTrackingSpace;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject localPlayerHead;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Dictionary<ulong, RemotePlayer> remoteUsers;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject roomSphere;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected MeshRenderer sphereMesh;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject roomFloor;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected MeshRenderer floorMesh;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected State currentState;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected static SocialPlatformManager s_instance;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected RoomManager roomManager;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected P2PManager p2pManager;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected VoipManager voipManager;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected ulong myID;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected string myOculusID;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public static readonly float VOIP_SCALE;

	[Token(Token = "0x1700000C")]
	public static State CurrentState
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xDC3D74", Offset = "0xDC3D74", VA = "0xDC3D74")]
		get
		{
			return default(State);
		}
	}

	[Token(Token = "0x1700000D")]
	public static ulong MyID
	{
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xDBF380", Offset = "0xDBF380", VA = "0xDBF380")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700000E")]
	public static string MyOculusID
	{
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xDC3DD8", Offset = "0xDC3DD8", VA = "0xDC3DD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xDC0698", Offset = "0xDC0698", VA = "0xDC0698", Slot = "4")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xDC0308", Offset = "0xDC0308", VA = "0xDC0308", Slot = "5")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xDC2AB4", Offset = "0xDC2AB4", VA = "0xDC2AB4")]
	private void InitCallback(Message<PlatformInitialize> msg)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xDC067C", Offset = "0xDC067C", VA = "0xDC067C", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xDC2C3C", Offset = "0xDC2C3C", VA = "0xDC2C3C")]
	private void IsEntitledCallback(Message msg)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xDC2D34", Offset = "0xDC2D34", VA = "0xDC2D34")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xDC34C4", Offset = "0xDC34C4", VA = "0xDC34C4")]
	private void GetLoggedInUserFriendsAndRoomsCallback(Message<UserAndRoomList> msg)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xDC38DC", Offset = "0xDC38DC", VA = "0xDC38DC")]
	public void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xDC3B00", Offset = "0xDC3B00", VA = "0xDC3B00")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xDC3D0C", Offset = "0xDC3D0C", VA = "0xDC3D0C")]
	public void AddUser(ulong userID, ref RemotePlayer remoteUser)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xDC2940", Offset = "0xDC2940", VA = "0xDC2940")]
	public void LogOutputLine(string line)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xDC0F5C", Offset = "0xDC0F5C", VA = "0xDC0F5C")]
	public static void TerminateWithError(Message msg)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xDC12C4", Offset = "0xDC12C4", VA = "0xDC12C4")]
	public static void TransitionToState(State newState)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xDC3EDC", Offset = "0xDC3EDC", VA = "0xDC3EDC")]
	private static void SetSphereColorForState()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xDC1504", Offset = "0xDC1504", VA = "0xDC1504")]
	public static void SetFloorColorForState(bool host)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xDC2090", Offset = "0xDC2090", VA = "0xDC2090")]
	public static void MarkAllRemoteUsersAsNotInRoom()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xDC246C", Offset = "0xDC246C", VA = "0xDC246C")]
	public static void MarkRemoteUserInRoom(ulong userID)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xDC254C", Offset = "0xDC254C", VA = "0xDC254C")]
	public static void ForgetRemoteUsersNotInRoom()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xDBF444", Offset = "0xDBF444", VA = "0xDBF444")]
	public static void LogOutput(string line)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xDC2214", Offset = "0xDC2214", VA = "0xDC2214")]
	public static bool IsUserInRoom(ulong userID)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xDC229C", Offset = "0xDC229C", VA = "0xDC229C")]
	public static void AddRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xDC4060", Offset = "0xDC4060", VA = "0xDC4060")]
	public static void RemoveRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xDC4324", Offset = "0xDC4324", VA = "0xDC4324")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xDC28C8", Offset = "0xDC28C8", VA = "0xDC28C8")]
	[MonoPInvokeCallback(typeof(CAPI.FilterCallback))]
	public static void MicFilter(short[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xDBF568", Offset = "0xDBF568", VA = "0xDBF568")]
	public static RemotePlayer GetRemoteUser(ulong userID)
	{
		return null;
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xDC0CA0", Offset = "0xDC0CA0", VA = "0xDC0CA0")]
	public SocialPlatformManager()
	{
	}
}
[Token(Token = "0x200002A")]
public class VoipManager
{
	[Token(Token = "0x6000104")]
	[Address(RVA = "0xDC29E8", Offset = "0xDC29E8", VA = "0xDC29E8")]
	public VoipManager()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xDC425C", Offset = "0xDC425C", VA = "0xDC425C")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xDC3C9C", Offset = "0xDC3C9C", VA = "0xDC3C9C")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xDC458C", Offset = "0xDC458C", VA = "0xDC458C")]
	private void VoipConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xDC46DC", Offset = "0xDC46DC", VA = "0xDC46DC")]
	private void VoipStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}
}
[Token(Token = "0x200002B")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x200002C")]
	public delegate void OnClick();

	[Token(Token = "0x200002D")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x200002E")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x200002F")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x4000131")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x4000132")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x4000133")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform[] additionalButtonPrefab;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool[] reEnable;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float elementSpacing;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float marginH;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float marginV;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2[] insertPositions;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 menuOffset;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private OVRCameraRig rig;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private LaserPointer lp;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private LineRenderer lr;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool isHorizontal;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	public bool usePanelCentricRelayout;

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xDC48C8", Offset = "0xDC48C8", VA = "0xDC48C8")]
	public void Awake()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xDC4DBC", Offset = "0xDC4DBC", VA = "0xDC4DBC")]
	public void Show()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xDC5124", Offset = "0xDC5124", VA = "0xDC5124")]
	public void Hide()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xDC52A0", Offset = "0xDC52A0", VA = "0xDC52A0")]
	private void StackedRelayout()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xDC54B8", Offset = "0xDC54B8", VA = "0xDC54B8")]
	private void PanelCentricRelayout()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xDC5114", Offset = "0xDC5114", VA = "0xDC5114")]
	private void Relayout()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xDC57AC", Offset = "0xDC57AC", VA = "0xDC57AC")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xDC5AB0", Offset = "0xDC5AB0", VA = "0xDC5AB0")]
	public RectTransform AddButton(string label, [Optional] OnClick handler, int buttonIndex = -1, int targetCanvas = 0, bool highResolutionText = false)
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xDC5E48", Offset = "0xDC5E48", VA = "0xDC5E48")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xDC5F40", Offset = "0xDC5F40", VA = "0xDC5F40")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xDC6104", Offset = "0xDC6104", VA = "0xDC6104")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xDC619C", Offset = "0xDC619C", VA = "0xDC619C")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xDC6358", Offset = "0xDC6358", VA = "0xDC6358")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xDC6534", Offset = "0xDC6534", VA = "0xDC6534")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xDC6810", Offset = "0xDC6810", VA = "0xDC6810")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xDC6900", Offset = "0xDC6900", VA = "0xDC6900")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xDC6994", Offset = "0xDC6994", VA = "0xDC6994")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x2000035")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xDC6FC8", Offset = "0xDC6FC8", VA = "0xDC6FC8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xDC7058", Offset = "0xDC7058", VA = "0xDC7058")]
	private void Update()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xDC70F4", Offset = "0xDC70F4", VA = "0xDC70F4")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xDC712C", Offset = "0xDC712C", VA = "0xDC712C")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x2000036")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x2000037")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x4000163")]
		On,
		[Token(Token = "0x4000164")]
		Off,
		[Token(Token = "0x4000165")]
		OnWhenHitTarget
	}

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x1700000F")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0xDC7134", Offset = "0xDC7134", VA = "0xDC7134")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x6000138")]
		[Address(RVA = "0xDC4D7C", Offset = "0xDC4D7C", VA = "0xDC4D7C")]
		set
		{
		}
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xDC713C", Offset = "0xDC713C", VA = "0xDC713C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xDC718C", Offset = "0xDC718C", VA = "0xDC718C")]
	private void Start()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xDC72C4", Offset = "0xDC72C4", VA = "0xDC72C4", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xDC72E0", Offset = "0xDC72E0", VA = "0xDC72E0", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xDC7330", Offset = "0xDC7330", VA = "0xDC7330")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xDC74D0", Offset = "0xDC74D0", VA = "0xDC74D0")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xDC75E0", Offset = "0xDC75E0", VA = "0xDC75E0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xDC7664", Offset = "0xDC7664", VA = "0xDC7664")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xDC7724", Offset = "0xDC7724", VA = "0xDC7724")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xDC77CC", Offset = "0xDC77CC", VA = "0xDC77CC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xDC78B8", Offset = "0xDC78B8", VA = "0xDC78B8")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x2000038")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x4000166")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x4000167")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x4000168")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("This should be a reference to the OVRCameraRig that is usually a child of the PlayerController.")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Collision layers to be used for the purposes of fading out the screen when the HMD is inside world geometry and adjusting the capsule height.")]
	public LayerMask CollideLayers;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Offset is added to camera's real world height, effectively treating it as though the player was taller/standing higher.")]
	public float HeightOffset;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Minimum height that the character capsule can shrink to.  To disable, set to capsule's height.")]
	public float MinimumHeight;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("Maximum height that the character capsule can grow to.  To disable, set to capsule's height.")]
	public float MaximumHeight;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xDC78C8", Offset = "0xDC78C8", VA = "0xDC78C8")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xDC78D0", Offset = "0xDC78D0", VA = "0xDC78D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xDC794C", Offset = "0xDC794C", VA = "0xDC794C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xDC79D8", Offset = "0xDC79D8", VA = "0xDC79D8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xDC7A64", Offset = "0xDC7A64", VA = "0xDC7A64")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xDC7D84", Offset = "0xDC7D84", VA = "0xDC7D84")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xDC7FE4", Offset = "0xDC7FE4", VA = "0xDC7FE4")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000039")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xDC873C", Offset = "0xDC873C", VA = "0xDC873C")]
	private void Start()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xDC87D4", Offset = "0xDC87D4", VA = "0xDC87D4")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x200003A")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x200003B")]
	public enum States
	{
		[Token(Token = "0x4000196")]
		Ready,
		[Token(Token = "0x4000197")]
		Aim,
		[Token(Token = "0x4000198")]
		CancelAim,
		[Token(Token = "0x4000199")]
		PreTeleport,
		[Token(Token = "0x400019A")]
		CancelTeleport,
		[Token(Token = "0x400019B")]
		Teleporting,
		[Token(Token = "0x400019C")]
		PostTeleport
	}

	[Token(Token = "0x200003C")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x400019E")]
		None,
		[Token(Token = "0x400019F")]
		Aim,
		[Token(Token = "0x40001A0")]
		PreTeleport,
		[Token(Token = "0x40001A1")]
		Teleport
	}

	[Token(Token = "0x200003D")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x40001A3")]
		Point,
		[Token(Token = "0x40001A4")]
		Sphere,
		[Token(Token = "0x40001A5")]
		Capsule
	}

	[Token(Token = "0x200003E")]
	public class AimData
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x17000013")]
		public List<Vector3> Points
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0xDCA34C", Offset = "0xDCA34C", VA = "0xDCA34C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0xDCA354", Offset = "0xDCA354", VA = "0xDCA354")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xDCA2CC", Offset = "0xDCA2CC", VA = "0xDCA2CC")]
		public AimData()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xDCA35C", Offset = "0xDCA35C", VA = "0xDCA35C")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000014")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xDCA4D4", Offset = "0xDCA4D4", VA = "0xDCA4D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0xDCA51C", Offset = "0xDCA51C", VA = "0xDCA51C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xDCA3B4", Offset = "0xDCA3B4", VA = "0xDCA3B4")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xDCA3DC", Offset = "0xDCA3DC", VA = "0xDCA3DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xDCA3E0", Offset = "0xDCA3E0", VA = "0xDCA3E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xDCA4DC", Offset = "0xDCA4DC", VA = "0xDCA4DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0xDCA69C", Offset = "0xDCA69C", VA = "0xDCA69C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0xDCA6E4", Offset = "0xDCA6E4", VA = "0xDCA6E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xDCA524", Offset = "0xDCA524", VA = "0xDCA524")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xDCA54C", Offset = "0xDCA54C", VA = "0xDCA54C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xDCA550", Offset = "0xDCA550", VA = "0xDCA550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xDCA6A4", Offset = "0xDCA6A4", VA = "0xDCA6A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0xDCA7BC", Offset = "0xDCA7BC", VA = "0xDCA7BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0xDCA804", Offset = "0xDCA804", VA = "0xDCA804", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xDCA6EC", Offset = "0xDCA6EC", VA = "0xDCA6EC")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xDCA714", Offset = "0xDCA714", VA = "0xDCA714", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xDCA718", Offset = "0xDCA718", VA = "0xDCA718", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xDCA7C4", Offset = "0xDCA7C4", VA = "0xDCA7C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0xDCA91C", Offset = "0xDCA91C", VA = "0xDCA91C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0xDCA964", Offset = "0xDCA964", VA = "0xDCA964", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xDCA80C", Offset = "0xDCA80C", VA = "0xDCA80C")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xDCA834", Offset = "0xDCA834", VA = "0xDCA834", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xDCA838", Offset = "0xDCA838", VA = "0xDCA838", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xDCA924", Offset = "0xDCA924", VA = "0xDCA924", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0xDCAA3C", Offset = "0xDCAA3C", VA = "0xDCAA3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0xDCAA84", Offset = "0xDCAA84", VA = "0xDCAA84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xDCA96C", Offset = "0xDCA96C", VA = "0xDCA96C")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xDCA994", Offset = "0xDCA994", VA = "0xDCA994", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xDCA998", Offset = "0xDCA998", VA = "0xDCA998", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xDCAA44", Offset = "0xDCAA44", VA = "0xDCAA44", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0xDCAB94", Offset = "0xDCAB94", VA = "0xDCAB94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xDCABDC", Offset = "0xDCABDC", VA = "0xDCABDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xDCAA8C", Offset = "0xDCAA8C", VA = "0xDCAA8C")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xDCAAB4", Offset = "0xDCAAB4", VA = "0xDCAAB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xDCAAB8", Offset = "0xDCAAB8", VA = "0xDCAAB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xDCAB9C", Offset = "0xDCAB9C", VA = "0xDCAB9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xDCACFC", Offset = "0xDCACFC", VA = "0xDCACFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xDCAD44", Offset = "0xDCAD44", VA = "0xDCAD44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xDCABE4", Offset = "0xDCABE4", VA = "0xDCABE4")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xDCAC0C", Offset = "0xDCAC0C", VA = "0xDCAC0C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xDCAC10", Offset = "0xDCAC10", VA = "0xDCAC10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xDCAD04", Offset = "0xDCAD04", VA = "0xDCAD04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Allow linear movement prior to the teleport system being activated.")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Tooltip("Allow linear movement while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[Tooltip("Allow linear movement while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[Tooltip("Allow linear movement after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("Allow rotation prior to the teleport system being activated.")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[Tooltip("Allow rotation while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[Tooltip("Allow rotation while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[Tooltip("Allow rotation after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableRotationDuringPostTeleport;

	[NonSerialized]
	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("This prefab will be instantiated as needed and updated to match the current aim target.")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("TeleportDestinationPrefab will be instantiated into this layer.")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Tooltip("When aiming at possible destinations, the aim collision type determines which shape to use for collision tests.")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Tooltip("Use the character collision radius/height/skinwidth for sphere/capsule collision tests.")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Tooltip("Radius of the sphere or capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionRadius;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Tooltip("Height of the capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionHeight;

	[Token(Token = "0x17000010")]
	public States CurrentState
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0xDC8824", Offset = "0xDC8824", VA = "0xDC8824")]
		[CompilerGenerated]
		get
		{
			return default(States);
		}
		[Token(Token = "0x6000151")]
		[Address(RVA = "0xDC882C", Offset = "0xDC882C", VA = "0xDC882C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x6000155")]
		[Address(RVA = "0xDC89FC", Offset = "0xDC89FC", VA = "0xDC89FC")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x17000012")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0xDC8A20", Offset = "0xDC8A20", VA = "0xDC8A20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000157")]
		[Address(RVA = "0xDC8A28", Offset = "0xDC8A28", VA = "0xDC8A28")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0xDC8834", Offset = "0xDC8834", VA = "0xDC8834")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000153")]
		[Address(RVA = "0xDC88E4", Offset = "0xDC88E4", VA = "0xDC88E4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0xDC9048", Offset = "0xDC9048", VA = "0xDC9048")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000162")]
		[Address(RVA = "0xDC90E4", Offset = "0xDC90E4", VA = "0xDC90E4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x6000164")]
		[Address(RVA = "0xDC9180", Offset = "0xDC9180", VA = "0xDC9180")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000165")]
		[Address(RVA = "0xDC921C", Offset = "0xDC921C", VA = "0xDC921C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x6000166")]
		[Address(RVA = "0xDC92B8", Offset = "0xDC92B8", VA = "0xDC92B8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000167")]
		[Address(RVA = "0xDC9368", Offset = "0xDC9368", VA = "0xDC9368")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x6000169")]
		[Address(RVA = "0xDC9434", Offset = "0xDC9434", VA = "0xDC9434")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600016A")]
		[Address(RVA = "0xDC94D0", Offset = "0xDC94D0", VA = "0xDC94D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x600016C")]
		[Address(RVA = "0xDC95D4", Offset = "0xDC95D4", VA = "0xDC95D4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600016D")]
		[Address(RVA = "0xDC9670", Offset = "0xDC9670", VA = "0xDC9670")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x600016F")]
		[Address(RVA = "0xDC9774", Offset = "0xDC9774", VA = "0xDC9774")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000170")]
		[Address(RVA = "0xDC9810", Offset = "0xDC9810", VA = "0xDC9810")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x6000172")]
		[Address(RVA = "0xDC9914", Offset = "0xDC9914", VA = "0xDC9914")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000173")]
		[Address(RVA = "0xDC99B0", Offset = "0xDC99B0", VA = "0xDC99B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x6000175")]
		[Address(RVA = "0xDC9AB4", Offset = "0xDC9AB4", VA = "0xDC9AB4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000176")]
		[Address(RVA = "0xDC9B50", Offset = "0xDC9B50", VA = "0xDC9B50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x6000178")]
		[Address(RVA = "0xDC9C54", Offset = "0xDC9C54", VA = "0xDC9C54")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000179")]
		[Address(RVA = "0xDC9CF0", Offset = "0xDC9CF0", VA = "0xDC9CF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x600017B")]
		[Address(RVA = "0xDC9DF4", Offset = "0xDC9DF4", VA = "0xDC9DF4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600017C")]
		[Address(RVA = "0xDC9EA4", Offset = "0xDC9EA4", VA = "0xDC9EA4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xDC87DC", Offset = "0xDC87DC", VA = "0xDC87DC")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xDC8800", Offset = "0xDC8800", VA = "0xDC8800")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xDC8994", Offset = "0xDC8994", VA = "0xDC8994")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xDC8A30", Offset = "0xDC8A30", VA = "0xDC8A30")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xDC8CF8", Offset = "0xDC8CF8", VA = "0xDC8CF8")]
	[Conditional("DEBUG_TELEPORT_STATES")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xDC8DA0", Offset = "0xDC8DA0", VA = "0xDC8DA0")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xDC8E64", Offset = "0xDC8E64", VA = "0xDC8E64")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xDC8E80", Offset = "0xDC8E80", VA = "0xDC8E80")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xDC8F30", Offset = "0xDC8F30", VA = "0xDC8F30")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xDC8F60", Offset = "0xDC8F60", VA = "0xDC8F60")]
	private void Awake()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xDC8FB4", Offset = "0xDC8FB4", VA = "0xDC8FB4", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xDC9040", Offset = "0xDC9040", VA = "0xDC9040", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xDC8FD8", Offset = "0xDC8FD8", VA = "0xDC8FD8")]
	[IteratorStateMachine(typeof(<ReadyStateCoroutine>d__52))]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xDC9418", Offset = "0xDC9418", VA = "0xDC9418")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xDC956C", Offset = "0xDC956C", VA = "0xDC956C")]
	[IteratorStateMachine(typeof(<AimStateCoroutine>d__64))]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xDC970C", Offset = "0xDC970C", VA = "0xDC970C")]
	[IteratorStateMachine(typeof(<CancelAimStateCoroutine>d__68))]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xDC98AC", Offset = "0xDC98AC", VA = "0xDC98AC")]
	[IteratorStateMachine(typeof(<PreTeleportStateCoroutine>d__72))]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xDC9A4C", Offset = "0xDC9A4C", VA = "0xDC9A4C")]
	[IteratorStateMachine(typeof(<CancelTeleportStateCoroutine>d__76))]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xDC9BEC", Offset = "0xDC9BEC", VA = "0xDC9BEC")]
	[IteratorStateMachine(typeof(<TeleportingStateCoroutine>d__80))]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xDC9D8C", Offset = "0xDC9D8C", VA = "0xDC9D8C")]
	[IteratorStateMachine(typeof(<PostTeleportStateCoroutine>d__84))]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xDC9F54", Offset = "0xDC9F54", VA = "0xDC9F54")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xDCA068", Offset = "0xDCA068", VA = "0xDCA068")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xDCA098", Offset = "0xDCA098", VA = "0xDCA098")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xDCA1D4", Offset = "0xDCA1D4", VA = "0xDCA1D4")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xDCA2BC", Offset = "0xDCA2BC", VA = "0xDCA2BC")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x2000046")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000C")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xDCAD4C", Offset = "0xDCAD4C", VA = "0xDCAD4C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xDCADE8", Offset = "0xDCADE8", VA = "0xDCADE8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xDCAE84", Offset = "0xDCAE84", VA = "0xDCAE84")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xDCAF20", Offset = "0xDCAF20", VA = "0xDCAF20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xDCAFBC", Offset = "0xDCAFBC", VA = "0xDCAFBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xDCB074", Offset = "0xDCB074", VA = "0xDCB074")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xDCB078", Offset = "0xDCB078", VA = "0xDCB078")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xDCB0EC", Offset = "0xDCB0EC", VA = "0xDCB0EC")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xDCB210", Offset = "0xDCB210", VA = "0xDCB210")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xDCB488", Offset = "0xDCB488", VA = "0xDCB488")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xDCB6A8", Offset = "0xDCB6A8", VA = "0xDCB6A8")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x2000047")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xDCB6C8", Offset = "0xDCB6C8", VA = "0xDCB6C8", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xDCB748", Offset = "0xDCB748", VA = "0xDCB748", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60001BD")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xDCB7FC", Offset = "0xDCB7FC", VA = "0xDCB7FC")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x2000048")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xDCB80C", Offset = "0xDCB80C", VA = "0xDCB80C", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xDCB99C", Offset = "0xDCB99C", VA = "0xDCB99C")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x2000049")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The MinimumElevation is relative to the AimPosition.")]
	public float MinimumElevation;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The Gravity is used in conjunction with AimVelocity and the aim direction to simulate a projectile.")]
	public float Gravity;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("The AimVelocity is the initial speed of the faked projectile.")]
	[Range(0.001f, 50f)]
	public float AimVelocity;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("The AimStep is the how much to subdivide the iteration.")]
	[Range(0.001f, 1f)]
	public float AimStep;

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xDCB9AC", Offset = "0xDCB9AC", VA = "0xDCB9AC", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xDCBB80", Offset = "0xDCBB80", VA = "0xDCBB80")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x200004A")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This prefab will be instantiated when the aim visual is awakened, and will be set active when the user is aiming, and deactivated when they are done aiming.")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xDCBB94", Offset = "0xDCBB94", VA = "0xDCBB94")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xDCBCA0", Offset = "0xDCBCA0", VA = "0xDCBCA0")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xDCBCCC", Offset = "0xDCBCCC", VA = "0xDCBCCC")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xDCBCF8", Offset = "0xDCBCF8", VA = "0xDCBCF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xDCBD94", Offset = "0xDCBD94", VA = "0xDCBD94", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xDCBDF4", Offset = "0xDCBDF4", VA = "0xDCBDF4", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xDCBE50", Offset = "0xDCBE50", VA = "0xDCBE50")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x200004B")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("If the target handler provides a target position, this transform will be moved to that position and it's game object enabled. A target position being provided does not mean the position is valid, only that the aim handler found something to test as a destination.")]
	public Transform PositionIndicator;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This transform will be rotated to match the rotation of the aiming target. Simple teleport destinations should assign this to the object containing this component. More complex teleport destinations might assign this to a sub-object that is used to indicate the landing orientation independently from the rest of the destination indicator, such as when world space effects are required. This will typically be a child of the PositionIndicator.")]
	public Transform OrientationIndicator;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("After the player teleports, the character controller will have it's rotation set to this value. It is different from the OrientationIndicator transform.rotation in order to support both head-relative and forward-facing teleport modes (See TeleportOrientationHandlerThumbstick.cs).")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x17000022")]
	public bool IsValidDestination
	{
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xDCBF4C", Offset = "0xDCBF4C", VA = "0xDCBF4C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xDCBF54", Offset = "0xDCBF54", VA = "0xDCBF54")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xDCC0DC", Offset = "0xDCC0DC", VA = "0xDCC0DC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xDCC18C", Offset = "0xDCC18C", VA = "0xDCC18C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xDCBF60", Offset = "0xDCBF60", VA = "0xDCBF60")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xDCBFDC", Offset = "0xDCBFDC", VA = "0xDCBFDC")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xDCC0A4", Offset = "0xDCC0A4", VA = "0xDCC0A4")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xDCC0D8", Offset = "0xDCC0D8", VA = "0xDCC0D8")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xDCC23C", Offset = "0xDCC23C", VA = "0xDCC23C")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xDCC260", Offset = "0xDCC260", VA = "0xDCC260")]
	public void Recycle()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xDCC280", Offset = "0xDCC280", VA = "0xDCC280", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x200004C")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xDCC80C", Offset = "0xDCC80C", VA = "0xDCC80C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xDCC854", Offset = "0xDCC854", VA = "0xDCC854", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xDCC690", Offset = "0xDCC690", VA = "0xDCC690")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xDCC788", Offset = "0xDCC788", VA = "0xDCC788", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xDCC78C", Offset = "0xDCC78C", VA = "0xDCC78C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xDCC814", Offset = "0xDCC814", VA = "0xDCC814", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xDCC8EC", Offset = "0xDCC8EC", VA = "0xDCC8EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xDCC934", Offset = "0xDCC934", VA = "0xDCC934", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xDCC720", Offset = "0xDCC720", VA = "0xDCC720")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xDCC85C", Offset = "0xDCC85C", VA = "0xDCC85C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xDCC860", Offset = "0xDCC860", VA = "0xDCC860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xDCC8F4", Offset = "0xDCC8F4", VA = "0xDCC8F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xDCC474", Offset = "0xDCC474", VA = "0xDCC474")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xDCC534", Offset = "0xDCC534", VA = "0xDCC534", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xDCC578", Offset = "0xDCC578", VA = "0xDCC578", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xDCC628", Offset = "0xDCC628", VA = "0xDCC628")]
	[IteratorStateMachine(typeof(<TeleportReadyCoroutine>d__5))]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xDCC6B8", Offset = "0xDCC6B8", VA = "0xDCC6B8")]
	[IteratorStateMachine(typeof(<TeleportAimCoroutine>d__6))]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001DA")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x60001DB")]
	public abstract void GetAimData(out Ray aimRay);
}
[Token(Token = "0x200004F")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("The button used to begin aiming for a teleport.")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("The button used to trigger the teleport after aiming. It can be the same button as the AimButton, however you cannot abort a teleport if it is.")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("When true, the system will not use the PreTeleport intention which will allow a teleport to occur on a button downpress. When false, the button downpress will trigger the PreTeleport intention and the Teleport intention when the button is released.")]
	public bool FastTeleport;

	[Token(Token = "0x17000027")]
	public Transform Pointer
	{
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xDCC93C", Offset = "0xDCC93C", VA = "0xDCC93C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xDCC944", Offset = "0xDCC944", VA = "0xDCC944")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xDCC94C", Offset = "0xDCC94C", VA = "0xDCC94C", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xDCCA78", Offset = "0xDCCA78", VA = "0xDCCA78", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xDCCB2C", Offset = "0xDCCB2C", VA = "0xDCCB2C")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x2000050")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x2000051")]
	public enum InputModes
	{
		[Token(Token = "0x40001F6")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x40001F7")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x40001F8")]
		ThumbstickTeleport,
		[Token(Token = "0x40001F9")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x2000052")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x40001FB")]
		A,
		[Token(Token = "0x40001FC")]
		B,
		[Token(Token = "0x40001FD")]
		LeftTrigger,
		[Token(Token = "0x40001FE")]
		LeftThumbstick,
		[Token(Token = "0x40001FF")]
		RightTrigger,
		[Token(Token = "0x4000200")]
		RightThumbstick,
		[Token(Token = "0x4000201")]
		X,
		[Token(Token = "0x4000202")]
		Y
	}

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Tooltip("CapacitiveButtonForAimAndTeleport=Activate aiming via cap touch detection, press the same button to teleport.\nSeparateButtonsForAimAndTeleport=Use one button to begin aiming, and another to trigger the teleport.\nThumbstickTeleport=Push a thumbstick to begin aiming, release to teleport.")]
	public InputModes InputMode;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Tooltip("Select the controller to be used for aiming. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Tooltip("Select the button to use for triggering aim and teleport when InputMode==CapacitiveButtonForAimAndTeleport")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[Tooltip("The thumbstick magnitude required to trigger aiming and teleports when InputMode==InputModes.ThumbstickTeleport")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xDCCB30", Offset = "0xDCCB30", VA = "0xDCCB30")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xDCCB34", Offset = "0xDCCB34", VA = "0xDCCB34", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xDCCF68", Offset = "0xDCCF68", VA = "0xDCCF68", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xDCD024", Offset = "0xDCD024", VA = "0xDCD024")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x2000053")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x2000054")]
	public enum OrientationModes
	{
		[Token(Token = "0x4000207")]
		HeadRelative,
		[Token(Token = "0x4000208")]
		ForwardFacing
	}

	[Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xDCD4A0", Offset = "0xDCD4A0", VA = "0xDCD4A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0xDCD4E8", Offset = "0xDCD4E8", VA = "0xDCD4E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xDCD2BC", Offset = "0xDCD2BC", VA = "0xDCD2BC")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xDCD3FC", Offset = "0xDCD3FC", VA = "0xDCD3FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xDCD400", Offset = "0xDCD400", VA = "0xDCD400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xDCD4A8", Offset = "0xDCD4A8", VA = "0xDCD4A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xDCD0FC", Offset = "0xDCD0FC", VA = "0xDCD0FC")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xDCD1D0", Offset = "0xDCD1D0", VA = "0xDCD1D0")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xDCD1D8", Offset = "0xDCD1D8", VA = "0xDCD1D8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xDCD218", Offset = "0xDCD218", VA = "0xDCD218", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xDCD254", Offset = "0xDCD254", VA = "0xDCD254")]
	[IteratorStateMachine(typeof(<UpdateOrientationCoroutine>d__7))]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x60001F9")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xDCD2E4", Offset = "0xDCD2E4", VA = "0xDCD2E4")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}
}
[Token(Token = "0x2000056")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x6000202")]
	[Address(RVA = "0xDCD4F0", Offset = "0xDCD4F0", VA = "0xDCD4F0", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xDCD4F4", Offset = "0xDCD4F4", VA = "0xDCD4F4", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xDCD56C", Offset = "0xDCD56C", VA = "0xDCD56C")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x2000057")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Should the destination orientation be updated during the aim state in addition to the PreTeleport state?")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("How far from the destination must the HMD be pointing before using it for orientation")]
	public float AimDistanceThreshold;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[Tooltip("How far from the destination must the HMD be pointing before rejecting the teleport")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xDCD570", Offset = "0xDCD570", VA = "0xDCD570", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xDCD5C0", Offset = "0xDCD5C0", VA = "0xDCD5C0", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xDCDA3C", Offset = "0xDCDA3C", VA = "0xDCDA3C")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x2000058")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Which thumbstick is to be used for adjusting the teleport orientation. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("The orientation will only change if the thumbstick magnitude is above this value. This will usually be larger than the TeleportInputHandlerTouch.ThumbstickTeleportThreshold.")]
	public float RotateStickThreshold;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xDCDA40", Offset = "0xDCDA40", VA = "0xDCDA40", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xDCDA78", Offset = "0xDCDA78", VA = "0xDCDA78", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xDCDF50", Offset = "0xDCDF50", VA = "0xDCDF50")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x2000059")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xDCDF60", Offset = "0xDCDF60", VA = "0xDCDF60")]
	private void Start()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xDCDF64", Offset = "0xDCDF64", VA = "0xDCDF64")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xDCDF6C", Offset = "0xDCDF6C", VA = "0xDCDF6C")]
	private void Update()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xDCE058", Offset = "0xDCE058", VA = "0xDCE058")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xDCE074", Offset = "0xDCE074", VA = "0xDCE074")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x200005A")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x1700002A")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x6000210")]
		[Address(RVA = "0xDCE08C", Offset = "0xDCE08C", VA = "0xDCE08C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000211")]
		[Address(RVA = "0xDCE094", Offset = "0xDCE094", VA = "0xDCE094")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xDCB6EC", Offset = "0xDCB6EC", VA = "0xDCB6EC", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xDCB7DC", Offset = "0xDCB7DC", VA = "0xDCB7DC", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xDCE09C", Offset = "0xDCE09C", VA = "0xDCE09C")]
	[Conditional("DEBUG_TELEPORT_EVENT_HANDLERS")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xDCBDE8", Offset = "0xDCBDE8", VA = "0xDCBDE8", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xDCBE48", Offset = "0xDCBE48", VA = "0xDCBE48", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xDCB804", Offset = "0xDCB804", VA = "0xDCB804")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x200005B")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0xDCE748", Offset = "0xDCE748", VA = "0xDCE748", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0xDCE790", Offset = "0xDCE790", VA = "0xDCE790", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xDCE320", Offset = "0xDCE320", VA = "0xDCE320")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xDCE49C", Offset = "0xDCE49C", VA = "0xDCE49C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xDCE4A0", Offset = "0xDCE4A0", VA = "0xDCE4A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xDCE750", Offset = "0xDCE750", VA = "0xDCE750", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("This bitmask controls which game object layers will be included in the targeting collision tests.")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x4000222")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xDCE16C", Offset = "0xDCE16C", VA = "0xDCE16C")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xDCE264", Offset = "0xDCE264", VA = "0xDCE264", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xDCE290", Offset = "0xDCE290", VA = "0xDCE290", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xDCE2B8", Offset = "0xDCE2B8", VA = "0xDCE2B8")]
	[IteratorStateMachine(typeof(<TargetAimCoroutine>d__7))]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xDCE348", Offset = "0xDCE348", VA = "0xDCE348", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x600021D")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xDCE360", Offset = "0xDCE360", VA = "0xDCE360", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}
}
[Token(Token = "0x200005D")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xDCE798", Offset = "0xDCE798", VA = "0xDCE798")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xDCE7F8", Offset = "0xDCE7F8", VA = "0xDCE7F8", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xDCE964", Offset = "0xDCE964", VA = "0xDCE964", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xDCEA54", Offset = "0xDCEA54", VA = "0xDCEA54")]
	[Conditional("SHOW_PATH_RESULT")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xDCEA58", Offset = "0xDCEA58", VA = "0xDCEA58")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x200005E")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("When checking line of sight to the destination, add this value to the vertical offset for targeting collision checks.")]
	public float LOSOffset;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Teleport logic will only work with TeleportPoint components that exist in the layers specified by this mask.")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xDCEA64", Offset = "0xDCEA64", VA = "0xDCEA64", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xDCEC64", Offset = "0xDCEC64", VA = "0xDCEC64")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x200005F")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x600022D")]
	[Address(RVA = "0xDCEC70", Offset = "0xDCEC70", VA = "0xDCEC70", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xDCEDDC", Offset = "0xDCEDDC", VA = "0xDCEDDC")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x2000060")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x600022F")]
	[Address(RVA = "0xDCEDE0", Offset = "0xDCEDE0", VA = "0xDCEDE0", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xDCEE68", Offset = "0xDCEE68", VA = "0xDCEE68", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000231")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xDCEEEC", Offset = "0xDCEEEC", VA = "0xDCEEEC")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x2000061")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x1700002D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0xDCF230", Offset = "0xDCF230", VA = "0xDCF230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0xDCF278", Offset = "0xDCF278", VA = "0xDCF278", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xDCEF7C", Offset = "0xDCEF7C", VA = "0xDCEF7C")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xDCF134", Offset = "0xDCF134", VA = "0xDCF134", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xDCF138", Offset = "0xDCF138", VA = "0xDCF138", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xDCF238", Offset = "0xDCF238", VA = "0xDCF238", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("How long the transition takes. Usually this is greater than Teleport Delay.")]
	[Range(0.01f, 2f)]
	public float TransitionDuration;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	[Tooltip("At what percentage of the elapsed transition time does the teleport occur?")]
	public float TeleportDelay;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Fade to black over the duration of the transition")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xDCEEF4", Offset = "0xDCEEF4", VA = "0xDCEEF4", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xDCEF14", Offset = "0xDCEF14", VA = "0xDCEF14")]
	[IteratorStateMachine(typeof(<BlinkCoroutine>d__4))]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xDCEFA4", Offset = "0xDCEFA4", VA = "0xDCEFA4")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x2000063")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x600023C")]
	[Address(RVA = "0xDCF280", Offset = "0xDCF280", VA = "0xDCF280", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xDCF29C", Offset = "0xDCF29C", VA = "0xDCF29C")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x2000064")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0xDCF4A8", Offset = "0xDCF4A8", VA = "0xDCF4A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0xDCF4F0", Offset = "0xDCF4F0", VA = "0xDCF4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xDCF32C", Offset = "0xDCF32C", VA = "0xDCF32C")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xDCF390", Offset = "0xDCF390", VA = "0xDCF390", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xDCF394", Offset = "0xDCF394", VA = "0xDCF394", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xDCF4B0", Offset = "0xDCF4B0", VA = "0xDCF4B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0.01f, 1f)]
	[Tooltip("How much time the warp transition takes to complete.")]
	public float TransitionDuration;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xDCF2A4", Offset = "0xDCF2A4", VA = "0xDCF2A4", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xDCF2C4", Offset = "0xDCF2C4", VA = "0xDCF2C4")]
	[IteratorStateMachine(typeof(<DoWarp>d__3))]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xDCF354", Offset = "0xDCF354", VA = "0xDCF354")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x2000066")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x2000067")]
	public enum PlabackState
	{
		[Token(Token = "0x4000252")]
		Idle = 1,
		[Token(Token = "0x4000253")]
		Preparing,
		[Token(Token = "0x4000254")]
		Buffering,
		[Token(Token = "0x4000255")]
		Ready,
		[Token(Token = "0x4000256")]
		Ended
	}

	[Token(Token = "0x2000068")]
	public enum StereoMode
	{
		[Token(Token = "0x4000258")]
		Unknown = -1,
		[Token(Token = "0x4000259")]
		Mono,
		[Token(Token = "0x400025A")]
		TopBottom,
		[Token(Token = "0x400025B")]
		LeftRight,
		[Token(Token = "0x400025C")]
		Mesh
	}

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getCurrentPlaybackStateMethodId;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x17000031")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x6000247")]
		[Address(RVA = "0xDCF4F8", Offset = "0xDCF4F8", VA = "0xDCF4F8")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000032")]
	private static IntPtr Activity
	{
		[Token(Token = "0x6000248")]
		[Address(RVA = "0xDCF7E8", Offset = "0xDCF7E8", VA = "0xDCF7E8")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000033")]
	public static bool IsAvailable
	{
		[Token(Token = "0x6000249")]
		[Address(RVA = "0xDCFA68", Offset = "0xDCFA68", VA = "0xDCFA68")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000034")]
	public static bool IsPlaying
	{
		[Token(Token = "0x600024A")]
		[Address(RVA = "0xDCFADC", Offset = "0xDCFADC", VA = "0xDCFADC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000035")]
	public static PlabackState CurrentPlaybackState
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0xDCFBE0", Offset = "0xDCFBE0", VA = "0xDCFBE0")]
		get
		{
			return default(PlabackState);
		}
	}

	[Token(Token = "0x17000036")]
	public static long Duration
	{
		[Token(Token = "0x600024C")]
		[Address(RVA = "0xDCFCE8", Offset = "0xDCFCE8", VA = "0xDCFCE8")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000037")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x600024D")]
		[Address(RVA = "0xDCFDF0", Offset = "0xDCFDF0", VA = "0xDCFDF0")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x17000038")]
	public static int VideoWidth
	{
		[Token(Token = "0x600024E")]
		[Address(RVA = "0xDCFEF8", Offset = "0xDCFEF8", VA = "0xDCFEF8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000039")]
	public static int VideoHeight
	{
		[Token(Token = "0x600024F")]
		[Address(RVA = "0xDD0000", Offset = "0xDD0000", VA = "0xDD0000")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003A")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x6000250")]
		[Address(RVA = "0xDD0108", Offset = "0xDD0108", VA = "0xDD0108")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000251")]
		[Address(RVA = "0xDD0210", Offset = "0xDD0210", VA = "0xDD0210")]
		set
		{
		}
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xDD0370", Offset = "0xDD0370", VA = "0xDD0370")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xDD057C", Offset = "0xDD057C", VA = "0xDD057C")]
	public static void Stop()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xDD0684", Offset = "0xDD0684", VA = "0xDD0684")]
	public static void Play()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xDD078C", Offset = "0xDD078C", VA = "0xDD078C")]
	public static void Pause()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xDD0894", Offset = "0xDD0894", VA = "0xDD0894")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xDD09FC", Offset = "0xDD09FC", VA = "0xDD09FC")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xDD0B60", Offset = "0xDD0B60", VA = "0xDD0B60")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x2000069")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x1400000F")]
	public event Action onButtonDown
	{
		[Token(Token = "0x600025A")]
		[Address(RVA = "0xDD0DA4", Offset = "0xDD0DA4", VA = "0xDD0DA4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600025B")]
		[Address(RVA = "0xDD0E40", Offset = "0xDD0E40", VA = "0xDD0E40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xDD0EDC", Offset = "0xDD0EDC", VA = "0xDD0EDC", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xDD0EF8", Offset = "0xDD0EF8", VA = "0xDD0EF8")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x200006A")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x200006B")]
	public enum ButtonType
	{
		[Token(Token = "0x4000260")]
		Play,
		[Token(Token = "0x4000261")]
		Pause,
		[Token(Token = "0x4000262")]
		FastForward,
		[Token(Token = "0x4000263")]
		Rewind,
		[Token(Token = "0x4000264")]
		SkipForward,
		[Token(Token = "0x4000265")]
		SkipBack,
		[Token(Token = "0x4000266")]
		Stop
	}

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x1700003B")]
	public ButtonType buttonType
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0xDD0F00", Offset = "0xDD0F00", VA = "0xDD0F00")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x600025F")]
		[Address(RVA = "0xDD0F08", Offset = "0xDD0F08", VA = "0xDD0F08")]
		set
		{
		}
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xDD0F2C", Offset = "0xDD0F2C", VA = "0xDD0F2C", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xDD1D80", Offset = "0xDD1D80", VA = "0xDD1D80")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x200006C")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x200006D")]
	public enum VideoShape
	{
		[Token(Token = "0x400027B")]
		_360,
		[Token(Token = "0x400027C")]
		_180,
		[Token(Token = "0x400027D")]
		Quad
	}

	[Token(Token = "0x200006E")]
	public enum VideoStereo
	{
		[Token(Token = "0x400027F")]
		Mono,
		[Token(Token = "0x4000280")]
		TopBottom,
		[Token(Token = "0x4000281")]
		LeftRight,
		[Token(Token = "0x4000282")]
		BottomTop
	}

	[Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x1700003F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0xDD3218", Offset = "0xDD3218", VA = "0xDD3218", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0xDD3260", Offset = "0xDD3260", VA = "0xDD3260", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xDD2424", Offset = "0xDD2424", VA = "0xDD2424")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xDD3078", Offset = "0xDD3078", VA = "0xDD3078", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xDD307C", Offset = "0xDD307C", VA = "0xDD307C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xDD3220", Offset = "0xDD3220", VA = "0xDD3220", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x1700003C")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000262")]
		[Address(RVA = "0xDD1DD8", Offset = "0xDD1DD8", VA = "0xDD1DD8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000263")]
		[Address(RVA = "0xDD1DE0", Offset = "0xDD1DE0", VA = "0xDD1DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public long Duration
	{
		[Token(Token = "0x6000264")]
		[Address(RVA = "0xDD1DEC", Offset = "0xDD1DEC", VA = "0xDD1DEC")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000265")]
		[Address(RVA = "0xDD1DF4", Offset = "0xDD1DF4", VA = "0xDD1DF4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public long PlaybackPosition
	{
		[Token(Token = "0x6000266")]
		[Address(RVA = "0xDD1DFC", Offset = "0xDD1DFC", VA = "0xDD1DFC")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000267")]
		[Address(RVA = "0xDD1E04", Offset = "0xDD1E04", VA = "0xDD1E04")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xDD1E0C", Offset = "0xDD1E0C", VA = "0xDD1E0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xDD205C", Offset = "0xDD205C", VA = "0xDD205C")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xDD20BC", Offset = "0xDD20BC", VA = "0xDD20BC")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xDD23BC", Offset = "0xDD23BC", VA = "0xDD23BC")]
	[IteratorStateMachine(typeof(<Start>d__33))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xDD244C", Offset = "0xDD244C", VA = "0xDD244C")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xDD26EC", Offset = "0xDD26EC", VA = "0xDD26EC")]
	public void Play()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xDD2770", Offset = "0xDD2770", VA = "0xDD2770")]
	public void Pause()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0xDD27F0", Offset = "0xDD27F0", VA = "0xDD27F0")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xDD28DC", Offset = "0xDD28DC", VA = "0xDD28DC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xDD2E6C", Offset = "0xDD2E6C", VA = "0xDD2E6C")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xDD2F08", Offset = "0xDD2F08", VA = "0xDD2F08")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xDD2F88", Offset = "0xDD2F88", VA = "0xDD2F88")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0xDD3068", Offset = "0xDD3068", VA = "0xDD3068")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x2000071")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x2000072")]
	private enum PlaybackState
	{
		[Token(Token = "0x400029F")]
		Playing,
		[Token(Token = "0x40002A0")]
		Paused,
		[Token(Token = "0x40002A1")]
		Rewinding,
		[Token(Token = "0x40002A2")]
		FastForwarding
	}

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xDD333C", Offset = "0xDD333C", VA = "0xDD333C")]
	private void Start()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xDD3668", Offset = "0xDD3668", VA = "0xDD3668")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xDD3838", Offset = "0xDD3838", VA = "0xDD3838")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0xDD395C", Offset = "0xDD395C", VA = "0xDD395C")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0xDD3A58", Offset = "0xDD3A58", VA = "0xDD3A58")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0xDD3930", Offset = "0xDD3930", VA = "0xDD3930")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0xDD3AB8", Offset = "0xDD3AB8", VA = "0xDD3AB8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0xDD3568", Offset = "0xDD3568", VA = "0xDD3568")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0xDD3DC4", Offset = "0xDD3DC4", VA = "0xDD3DC4")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x2000073")]
public static class VectorUtil
{
	[Token(Token = "0x6000286")]
	[Address(RVA = "0xDD2DF4", Offset = "0xDD2DF4", VA = "0xDD2DF4")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x2000074")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x40002A3")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x40002A4")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xDD3DD4", Offset = "0xDD3DD4", VA = "0xDD3DD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xDD43C4", Offset = "0xDD43C4", VA = "0xDD43C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xDD4620", Offset = "0xDD4620", VA = "0xDD4620")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xDD4784", Offset = "0xDD4784", VA = "0xDD4784")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xDD48EC", Offset = "0xDD48EC", VA = "0xDD48EC")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xDD4A70", Offset = "0xDD4A70", VA = "0xDD4A70")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x2000075")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x40002AD")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xDD4A80", Offset = "0xDD4A80", VA = "0xDD4A80")]
	private void Awake()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xDD4ACC", Offset = "0xDD4ACC", VA = "0xDD4ACC")]
	private void Start()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0xDD4AD0", Offset = "0xDD4AD0", VA = "0xDD4AD0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xDD4184", Offset = "0xDD4184", VA = "0xDD4184")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xDD4AD4", Offset = "0xDD4AD4", VA = "0xDD4AD4")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0xDD4CF0", Offset = "0xDD4CF0", VA = "0xDD4CF0")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x2000076")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x6000293")]
	[Address(RVA = "0xDD4CF8", Offset = "0xDD4CF8", VA = "0xDD4CF8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xDD5248", Offset = "0xDD5248", VA = "0xDD5248")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0xDD52F4", Offset = "0xDD52F4", VA = "0xDD52F4")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xDD550C", Offset = "0xDD550C", VA = "0xDD550C")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xDD55E0", Offset = "0xDD55E0", VA = "0xDD55E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xDD56B8", Offset = "0xDD56B8", VA = "0xDD56B8")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xDD5720", Offset = "0xDD5720", VA = "0xDD5720")]
	public DebugUISample()
	{
	}
}
[Token(Token = "0x2000077")]
public class AnalyticsUI : MonoBehaviour
{
	[Token(Token = "0x600029E")]
	[Address(RVA = "0xDD58C8", Offset = "0xDD58C8", VA = "0xDD58C8")]
	public AnalyticsUI()
	{
	}
}
[Token(Token = "0x2000078")]
public class SampleUI : MonoBehaviour
{
	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform collectionButton;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform inputText;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform valueText;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool inMenu;

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xDD58D0", Offset = "0xDD58D0", VA = "0xDD58D0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xDD5968", Offset = "0xDD5968", VA = "0xDD5968")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xDD5A40", Offset = "0xDD5A40", VA = "0xDD5A40")]
	private string GetText()
	{
		return null;
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xDD5A9C", Offset = "0xDD5A9C", VA = "0xDD5A9C")]
	public SampleUI()
	{
	}
}
[Token(Token = "0x2000079")]
public class StartCrashlytics : MonoBehaviour
{
	[Token(Token = "0x60002A3")]
	[Address(RVA = "0xDD5AA4", Offset = "0xDD5AA4", VA = "0xDD5AA4")]
	public StartCrashlytics()
	{
	}
}
[Token(Token = "0x200007A")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0xDD5E70", Offset = "0xDD5E70", VA = "0xDD5E70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xDD5EB8", Offset = "0xDD5EB8", VA = "0xDD5EB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xDD5D38", Offset = "0xDD5D38", VA = "0xDD5D38")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xDD5D68", Offset = "0xDD5D68", VA = "0xDD5D68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xDD5D6C", Offset = "0xDD5D6C", VA = "0xDD5D6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xDD5E78", Offset = "0xDD5E78", VA = "0xDD5E78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xDD5AAC", Offset = "0xDD5AAC", VA = "0xDD5AAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xDD5BA0", Offset = "0xDD5BA0", VA = "0xDD5BA0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xDD5B38", Offset = "0xDD5B38", VA = "0xDD5B38")]
	[IteratorStateMachine(typeof(<GetCenterEye>d__6))]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xDD5D60", Offset = "0xDD5D60", VA = "0xDD5D60")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x200007C")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(4f, 32f)]
	public int SubdivisionsU;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(4f, 32f)]
	public int SubdivisionsV;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xDD5EC0", Offset = "0xDD5EC0", VA = "0xDD5EC0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xDD782C", Offset = "0xDD782C", VA = "0xDD782C")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x200007D")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x17000043")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xDD7834", Offset = "0xDD7834", VA = "0xDD7834")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xDD7884", Offset = "0xDD7884", VA = "0xDD7884")]
	public void Start()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xDD7CB0", Offset = "0xDD7CB0", VA = "0xDD7CB0")]
	public void Update()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xDD7D88", Offset = "0xDD7D88", VA = "0xDD7D88")]
	[Conditional("DEBUG_LOCOMOTION_PANEL")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x60002B4")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x60002B5")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x60002B6")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x60002B7")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x60002B8")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x60002B9")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x60002BA")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x60002BB")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xDD7DE0", Offset = "0xDD7DE0", VA = "0xDD7DE0")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xDD7E20", Offset = "0xDD7E20", VA = "0xDD7E20")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xDD7E8C", Offset = "0xDD7E8C", VA = "0xDD7E8C")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xDD7FD8", Offset = "0xDD7FD8", VA = "0xDD7FD8")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xDD80A8", Offset = "0xDD80A8", VA = "0xDD80A8")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xDD7B8C", Offset = "0xDD7B8C", VA = "0xDD7B8C")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xDD8178", Offset = "0xDD8178", VA = "0xDD8178")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xDD81C4", Offset = "0xDD81C4", VA = "0xDD81C4")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xDD82D4", Offset = "0xDD82D4", VA = "0xDD82D4")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x200007E")]
[RequireComponent(typeof(Canvas))]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x200007F")]
	public enum DrawMode
	{
		[Token(Token = "0x40002DC")]
		Opaque,
		[Token(Token = "0x40002DD")]
		OpaqueWithClip,
		[Token(Token = "0x40002DE")]
		TransparentDefaultAlpha,
		[Token(Token = "0x40002DF")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private Shader _transparentShader;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	private Shader _opaqueShader;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x17000044")]
	public bool overlayEnabled
	{
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xDD9830", Offset = "0xDD9830", VA = "0xDD9830")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xDD98B4", Offset = "0xDD98B4", VA = "0xDD98B4")]
		set
		{
		}
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xDD82DC", Offset = "0xDD82DC", VA = "0xDD82DC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xDD8EB8", Offset = "0xDD8EB8", VA = "0xDD8EB8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xDD8F2C", Offset = "0xDD8F2C", VA = "0xDD8F2C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xDD8FFC", Offset = "0xDD8FFC", VA = "0xDD8FFC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0xDD90CC", Offset = "0xDD90CC", VA = "0xDD90CC", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0xDD92D0", Offset = "0xDD92D0", VA = "0xDD92D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xDD9970", Offset = "0xDD9970", VA = "0xDD9970")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x2000080")]
public class AugmentedObject : MonoBehaviour
{
	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform shadow;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool groundShadow;

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xDD9A20", Offset = "0xDD9A20", VA = "0xDD9A20")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xDD9BF4", Offset = "0xDD9BF4", VA = "0xDD9BF4")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xDD9D88", Offset = "0xDD9D88", VA = "0xDD9D88")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xDD9D90", Offset = "0xDD9D90", VA = "0xDD9D90")]
	public void Release()
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xDD9D78", Offset = "0xDD9D78", VA = "0xDD9D78")]
	private void ToggleShadowType()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xDD9D98", Offset = "0xDD9D98", VA = "0xDD9D98")]
	public AugmentedObject()
	{
	}
}
[Token(Token = "0x2000081")]
public class BrushController : MonoBehaviour
{
	[Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class <FadeCameraClearColor>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeTime;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color newColor;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timer>5__2;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000045")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xDDA454", Offset = "0xDDA454", VA = "0xDDA454", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xDDA49C", Offset = "0xDDA49C", VA = "0xDDA49C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xDDA310", Offset = "0xDDA310", VA = "0xDDA310")]
		[DebuggerHidden]
		public <FadeCameraClearColor>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xDDA368", Offset = "0xDDA368", VA = "0xDDA368", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xDDA36C", Offset = "0xDDA36C", VA = "0xDDA36C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xDDA45C", Offset = "0xDDA45C", VA = "0xDDA45C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class <FadeSphere>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushController <>4__this;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool disableOnFinish;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xDDA614", Offset = "0xDDA614", VA = "0xDDA614", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xDDA65C", Offset = "0xDDA65C", VA = "0xDDA65C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xDDA338", Offset = "0xDDA338", VA = "0xDDA338")]
		[DebuggerHidden]
		public <FadeSphere>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xDDA4A4", Offset = "0xDDA4A4", VA = "0xDDA4A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xDDA4A8", Offset = "0xDDA4A8", VA = "0xDDA4A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xDDA61C", Offset = "0xDDA61C", VA = "0xDDA61C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PassthroughBrush brush;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer backgroundSphere;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator grabRoutine;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator releaseRoutine;

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xDD9DA0", Offset = "0xDD9DA0", VA = "0xDD9DA0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xDDA048", Offset = "0xDDA048", VA = "0xDDA048")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xDDA098", Offset = "0xDDA098", VA = "0xDDA098")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xDDA1EC", Offset = "0xDDA1EC", VA = "0xDDA1EC")]
	public void Release()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xDDA278", Offset = "0xDDA278", VA = "0xDDA278")]
	[IteratorStateMachine(typeof(<FadeCameraClearColor>d__8))]
	private IEnumerator FadeCameraClearColor(Color newColor, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xDDA138", Offset = "0xDDA138", VA = "0xDDA138")]
	[IteratorStateMachine(typeof(<FadeSphere>d__9))]
	private IEnumerator FadeSphere(Color newColor, float fadeTime, bool disableOnFinish = false)
	{
		return null;
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xDDA360", Offset = "0xDDA360", VA = "0xDDA360")]
	public BrushController()
	{
	}
}
[Token(Token = "0x2000084")]
public class EnableUnpremultipliedAlpha : MonoBehaviour
{
	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xDDA664", Offset = "0xDDA664", VA = "0xDDA664")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xDDA6B8", Offset = "0xDDA6B8", VA = "0xDDA6B8")]
	public EnableUnpremultipliedAlpha()
	{
	}
}
[Token(Token = "0x2000085")]
public class Flashlight : MonoBehaviour
{
	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lightVolume;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light spotlight;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bulbGlow;

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xDDA6C0", Offset = "0xDDA6C0", VA = "0xDDA6C0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xDDA894", Offset = "0xDDA894", VA = "0xDDA894")]
	public void ToggleFlashlight()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0xDDA924", Offset = "0xDDA924", VA = "0xDDA924")]
	public void EnableFlashlight(bool doEnable)
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xDDA980", Offset = "0xDDA980", VA = "0xDDA980")]
	public Flashlight()
	{
	}
}
[Token(Token = "0x2000086")]
public class FlashlightController : MonoBehaviour
{
	[Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class <FadeLighting>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlashlightController <>4__this;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sceneLightIntensity;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <currentLight>5__4;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0xDDBACC", Offset = "0xDDBACC", VA = "0xDDBACC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xDDBB14", Offset = "0xDDBB14", VA = "0xDDBB14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xDDB840", Offset = "0xDDB840", VA = "0xDDB840")]
		[DebuggerHidden]
		public <FadeLighting>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xDDB908", Offset = "0xDDB908", VA = "0xDDB908", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xDDB90C", Offset = "0xDDB90C", VA = "0xDDB90C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xDDBAD4", Offset = "0xDDBAD4", VA = "0xDDBAD4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light sceneLight;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform flashlightRoot;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 localPosition;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion localRotation;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh infoText;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrabObject externalController;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private OVRSkeleton[] skeletons;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand[] hands;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int handIndex;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool pinching;

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xDDA988", Offset = "0xDDA988", VA = "0xDDA988")]
	private void Start()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xDDAC2C", Offset = "0xDDAC2C", VA = "0xDDAC2C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xDDAF18", Offset = "0xDDAF18", VA = "0xDDAF18")]
	private void FindHands()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xDDB210", Offset = "0xDDB210", VA = "0xDDB210")]
	private void AlignWithHand(OVRHand hand, OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xDDB4E8", Offset = "0xDDB4E8", VA = "0xDDB4E8")]
	private void AlignWithController(OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xDDB5D0", Offset = "0xDDB5D0", VA = "0xDDB5D0")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xDDB75C", Offset = "0xDDB75C", VA = "0xDDB75C")]
	public void Release()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xDDB6B8", Offset = "0xDDB6B8", VA = "0xDDB6B8")]
	[IteratorStateMachine(typeof(<FadeLighting>d__17))]
	private IEnumerator FadeLighting(Color newColor, float sceneLightIntensity, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xDDB868", Offset = "0xDDB868", VA = "0xDDB868")]
	public FlashlightController()
	{
	}
}
[Token(Token = "0x2000088")]
public class GrabObject : MonoBehaviour
{
	[Token(Token = "0x2000089")]
	public enum ManipulationType
	{
		[Token(Token = "0x4000314")]
		Default,
		[Token(Token = "0x4000315")]
		ForcedHand,
		[Token(Token = "0x4000316")]
		DollyHand,
		[Token(Token = "0x4000317")]
		DollyAttached,
		[Token(Token = "0x4000318")]
		HorizontalScaled,
		[Token(Token = "0x4000319")]
		VerticalScaled,
		[Token(Token = "0x400031A")]
		Menu
	}

	[Token(Token = "0x200008A")]
	public delegate void GrabbedObject(OVRInput.Controller grabHand);

	[Token(Token = "0x200008B")]
	public delegate void ReleasedObject();

	[Token(Token = "0x200008C")]
	public delegate void SetCursorPosition(Vector3 cursorPosition);

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[TextArea]
	public string ObjectName;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[TextArea]
	public string ObjectInstructions;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ManipulationType objectManipulationType;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool showLaserWhileGrabbed;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Quaternion grabbedRotation;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabbedObject GrabbedObjectDelegate;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ReleasedObject ReleasedObjectDelegate;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SetCursorPosition CursorPositionDelegate;

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xDDBB1C", Offset = "0xDDBB1C", VA = "0xDDBB1C")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xDDBB7C", Offset = "0xDDBB7C", VA = "0xDDBB7C")]
	public void Release()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xDDBB98", Offset = "0xDDBB98", VA = "0xDDBB98")]
	public void CursorPos(Vector3 cursorPos)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0xDDBBB4", Offset = "0xDDBBB4", VA = "0xDDBBB4")]
	public GrabObject()
	{
	}
}
[Token(Token = "0x200008D")]
public class HandMeshMask : MonoBehaviour
{
	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSkeleton referenceHand;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material maskMaterial;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The segments around the tip of a finger")]
	public int radialDivisions;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The fade range (finger width is 2x this)")]
	public float borderSize;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Along the fingers, each knuckle scales down by this amount.  Default is zero for uniform width along entire finger.")]
	public float fingerTaper;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("Shorten the last bone of each finger; need this to account for bone structure (end bone is at finger tip instead of center). Default is 1.")]
	public float fingerTipLength;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Move the base of the 4 main fingers towards the tips, to avoid a visible mesh crack between finger webbing. Default is 0.")]
	public float webOffset;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float handScale;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject maskMeshObject;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Mesh maskMesh;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] handVertices;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2[] handUVs;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color32[] handColors;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] handTriangles;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int vertCounter;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int triCounter;

	[Token(Token = "0x600030D")]
	[Address(RVA = "0xDDBFDC", Offset = "0xDDBFDC", VA = "0xDDBFDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0xDDC210", Offset = "0xDDC210", VA = "0xDDC210")]
	private void Update()
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0xDDC3D8", Offset = "0xDDC3D8", VA = "0xDDC3D8")]
	private void CreateHandMesh()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0xDDC9E0", Offset = "0xDDC9E0", VA = "0xDDC9E0")]
	private void AddKnuckleMesh(int knuckleVerts, float point1scale, float point2scale, Vector3 point1, Vector3 point2)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0xDDCF78", Offset = "0xDDCF78", VA = "0xDDCF78")]
	private void AddPalmMesh(int knuckleVerts)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xDDF280", Offset = "0xDDF280", VA = "0xDDF280")]
	private void AddVertex(Vector3 position, Vector2 uv, Color color)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0xDDF5F4", Offset = "0xDDF5F4", VA = "0xDDF5F4")]
	public HandMeshMask()
	{
	}
}
[Token(Token = "0x200008E")]
public class HandMeshUI : MonoBehaviour
{
	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider[] knobs;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh[] readouts;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rightHeldKnob;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int leftHeldKnob;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRSkeleton leftHand;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OVRSkeleton rightHand;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HandMeshMask leftMask;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HandMeshMask rightMask;

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xDDF618", Offset = "0xDDF618", VA = "0xDDF618")]
	private void Start()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xDDF980", Offset = "0xDDF980", VA = "0xDDF980")]
	private void Update()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xDDF6B4", Offset = "0xDDF6B4", VA = "0xDDF6B4")]
	private void SetSliderValue(int sliderID, float value, bool isNormalized)
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xDDFDE8", Offset = "0xDDFDE8", VA = "0xDDFDE8")]
	private void CheckForHands()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0xDE0358", Offset = "0xDE0358", VA = "0xDE0358")]
	public HandMeshUI()
	{
	}
}
[Token(Token = "0x200008F")]
public class ObjectManipulator : MonoBehaviour
{
	[Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class <StartDemo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectManipulator <>4__this;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fadeTime>5__3;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0xDE2B44", Offset = "0xDE2B44", VA = "0xDE2B44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0xDE2B8C", Offset = "0xDE2B8C", VA = "0xDE2B8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xDE2490", Offset = "0xDE2490", VA = "0xDE2490")]
		[DebuggerHidden]
		public <StartDemo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xDE2878", Offset = "0xDE2878", VA = "0xDE2878", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xDE287C", Offset = "0xDE287C", VA = "0xDE287C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xDE2B4C", Offset = "0xDE2B4C", VA = "0xDE2B4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRInput.Controller controller;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject hoverObject;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject grabObject;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float grabTime;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 localGrabOffset;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion localGrabRotation;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 camGrabPosition;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion camGrabRotation;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 handGrabPosition;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion handGrabRotation;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 cursorPosition;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float rotationOffset;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LineRenderer laser;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform objectInfo;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMesh objectNameLabel;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMesh objectInstructionsLabel;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image objectInfoBG;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject demoObjects;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OVRPassthroughLayer passthrough;

	[Token(Token = "0x6000319")]
	[Address(RVA = "0xDE0368", Offset = "0xDE0368", VA = "0xDE0368")]
	private void Start()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xDE0558", Offset = "0xDE0558", VA = "0xDE0558")]
	private void Update()
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0xDE1404", Offset = "0xDE1404", VA = "0xDE1404")]
	private void GrabHoverObject(GameObject grbObj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xDE2198", Offset = "0xDE2198", VA = "0xDE2198")]
	private void ReleaseObject()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xDE04F0", Offset = "0xDE04F0", VA = "0xDE04F0")]
	[IteratorStateMachine(typeof(<StartDemo>d__23))]
	private IEnumerator StartDemo()
	{
		return null;
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xDE07A0", Offset = "0xDE07A0", VA = "0xDE07A0")]
	private void FindHoverObject(Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xDE16F8", Offset = "0xDE16F8", VA = "0xDE16F8")]
	private void ManipulateObject(GameObject obj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xDE24B8", Offset = "0xDE24B8", VA = "0xDE24B8")]
	private void ClampGrabOffset(ref Vector3 localOffset, float thumbY)
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xDE256C", Offset = "0xDE256C", VA = "0xDE256C")]
	private Vector3 ClampScale(Vector3 localScale, Vector2 thumb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xDE259C", Offset = "0xDE259C", VA = "0xDE259C")]
	private void CheckForDominantHand()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0xDE2374", Offset = "0xDE2374", VA = "0xDE2374")]
	private void AssignInstructions(GrabObject targetObject)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xDE268C", Offset = "0xDE268C", VA = "0xDE268C")]
	public ObjectManipulator()
	{
	}
}
[Token(Token = "0x2000091")]
public class OverlayPassthrough : MonoBehaviour
{
	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xDE2B94", Offset = "0xDE2B94", VA = "0xDE2B94")]
	private void Start()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0xDE2CF4", Offset = "0xDE2CF4", VA = "0xDE2CF4")]
	private void Update()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0xDE2DA8", Offset = "0xDE2DA8", VA = "0xDE2DA8")]
	public OverlayPassthrough()
	{
	}
}
[Token(Token = "0x2000092")]
public class PassthroughBrush : MonoBehaviour
{
	[Token(Token = "0x2000093")]
	public enum BrushState
	{
		[Token(Token = "0x4000357")]
		Idle,
		[Token(Token = "0x4000358")]
		Inking
	}

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lineSegmentPrefab;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lineContainer;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool forceActive;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer currentLineSegment;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> inkPositions;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float minInkDist;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float strokeWidth;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float strokeLength;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private BrushState brushStatus;

	[Token(Token = "0x600032E")]
	[Address(RVA = "0xDE2DB0", Offset = "0xDE2DB0", VA = "0xDE2DB0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0xDE2DB8", Offset = "0xDE2DB8", VA = "0xDE2DB8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0xDE3068", Offset = "0xDE3068", VA = "0xDE3068")]
	private void StartLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xDE3288", Offset = "0xDE3288", VA = "0xDE3288")]
	private void UpdateLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0xDE34C8", Offset = "0xDE34C8", VA = "0xDE34C8")]
	public void ClearLines()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xDE2F80", Offset = "0xDE2F80", VA = "0xDE2F80")]
	public void UndoInkLine()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xDE3598", Offset = "0xDE3598", VA = "0xDE3598")]
	public PassthroughBrush()
	{
	}
}
[Token(Token = "0x2000094")]
public class PassthroughController : MonoBehaviour
{
	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x6000335")]
	[Address(RVA = "0xDE3628", Offset = "0xDE3628", VA = "0xDE3628")]
	private void Start()
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0xDE3788", Offset = "0xDE3788", VA = "0xDE3788")]
	private void Update()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0xDE3974", Offset = "0xDE3974", VA = "0xDE3974")]
	public PassthroughController()
	{
	}
}
[Token(Token = "0x2000095")]
public class PassthroughProjectionSurface : MonoBehaviour
{
	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer quadOutline;

	[Token(Token = "0x6000338")]
	[Address(RVA = "0xDE397C", Offset = "0xDE397C", VA = "0xDE397C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0xDE3B44", Offset = "0xDE3B44", VA = "0xDE3B44")]
	private void Update()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xDE3CE4", Offset = "0xDE3CE4", VA = "0xDE3CE4")]
	public PassthroughProjectionSurface()
	{
	}
}
[Token(Token = "0x2000096")]
public class PassthroughStyler : MonoBehaviour
{
	[Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class <FadeToCurrentStyle>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0xDE48C4", Offset = "0xDE48C4", VA = "0xDE48C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0xDE490C", Offset = "0xDE490C", VA = "0xDE490C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xDE4638", Offset = "0xDE4638", VA = "0xDE4638")]
		[DebuggerHidden]
		public <FadeToCurrentStyle>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xDE477C", Offset = "0xDE477C", VA = "0xDE477C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xDE4780", Offset = "0xDE4780", VA = "0xDE4780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xDE48CC", Offset = "0xDE48CC", VA = "0xDE48CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class <FadeToDefaultPassthrough>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0xDE4A74", Offset = "0xDE4A74", VA = "0xDE4A74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0xDE4ABC", Offset = "0xDE4ABC", VA = "0xDE4ABC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xDE4660", Offset = "0xDE4660", VA = "0xDE4660")]
		[DebuggerHidden]
		public <FadeToDefaultPassthrough>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xDE4914", Offset = "0xDE4914", VA = "0xDE4914", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xDE4918", Offset = "0xDE4918", VA = "0xDE4918", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xDE4A7C", Offset = "0xDE4A7C", VA = "0xDE4A7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator fadeIn;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator fadeOut;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform[] menuOptions;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform colorWheel;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D colorTexture;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool settingColor;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color savedColor;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float savedBrightness;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float savedContrast;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public CanvasGroup mainCanvas;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject[] compactObjects;

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xDE3CEC", Offset = "0xDE3CEC", VA = "0xDE3CEC")]
	private void Start()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xDE3FF4", Offset = "0xDE3FF4", VA = "0xDE3FF4")]
	private void Update()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xDE4394", Offset = "0xDE4394", VA = "0xDE4394")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xDE44EC", Offset = "0xDE44EC", VA = "0xDE44EC")]
	public void Release()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xDE4474", Offset = "0xDE4474", VA = "0xDE4474")]
	[IteratorStateMachine(typeof(<FadeToCurrentStyle>d__18))]
	private IEnumerator FadeToCurrentStyle(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xDE45C0", Offset = "0xDE45C0", VA = "0xDE45C0")]
	[IteratorStateMachine(typeof(<FadeToDefaultPassthrough>d__19))]
	private IEnumerator FadeToDefaultPassthrough(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xDE4688", Offset = "0xDE4688", VA = "0xDE4688")]
	public void OnBrightnessChanged(float newValue)
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xDE46A8", Offset = "0xDE46A8", VA = "0xDE46A8")]
	public void OnContrastChanged(float newValue)
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xDE46C8", Offset = "0xDE46C8", VA = "0xDE46C8")]
	public void OnAlphaChanged(float newValue)
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xDE3F8C", Offset = "0xDE3F8C", VA = "0xDE3F8C")]
	private void ShowFullMenu(bool doShow)
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xDE46FC", Offset = "0xDE46FC", VA = "0xDE46FC")]
	public void Cursor(Vector3 cP)
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xDE4708", Offset = "0xDE4708", VA = "0xDE4708")]
	public void DoColorDrag(bool doDrag)
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xDE400C", Offset = "0xDE400C", VA = "0xDE400C")]
	public void GetColorFromWheel()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xDE4714", Offset = "0xDE4714", VA = "0xDE4714")]
	public PassthroughStyler()
	{
	}
}
[Token(Token = "0x2000099")]
public class PassthroughSurface : MonoBehaviour
{
	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x6000355")]
	[Address(RVA = "0xDE4AC4", Offset = "0xDE4AC4", VA = "0xDE4AC4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0xDE4B78", Offset = "0xDE4B78", VA = "0xDE4B78")]
	public PassthroughSurface()
	{
	}
}
[Token(Token = "0x200009A")]
public class SceneSampler : MonoBehaviour
{
	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentSceneIndex;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject displayText;

	[Token(Token = "0x6000357")]
	[Address(RVA = "0xDE4B80", Offset = "0xDE4B80", VA = "0xDE4B80")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0xDE4BEC", Offset = "0xDE4BEC", VA = "0xDE4BEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0xDE4EE0", Offset = "0xDE4EE0", VA = "0xDE4EE0")]
	public SceneSampler()
	{
	}
}
[Token(Token = "0x200009B")]
public class SelectivePassthroughExperience : MonoBehaviour
{
	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftMaskObject;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightMaskObject;

	[Token(Token = "0x600035A")]
	[Address(RVA = "0xDE4EE8", Offset = "0xDE4EE8", VA = "0xDE4EE8")]
	private void Update()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0xDE533C", Offset = "0xDE533C", VA = "0xDE533C")]
	public SelectivePassthroughExperience()
	{
	}
}
[Token(Token = "0x200009C")]
public class SPPquad : MonoBehaviour
{
	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRInput.Controller controllerHand;

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xDE5344", Offset = "0xDE5344", VA = "0xDE5344")]
	private void Start()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xDE5564", Offset = "0xDE5564", VA = "0xDE5564")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xDE55B0", Offset = "0xDE55B0", VA = "0xDE55B0")]
	public void Release()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xDE55F0", Offset = "0xDE55F0", VA = "0xDE55F0")]
	public SPPquad()
	{
	}
}
[Token(Token = "0x200009D")]
public class BouncingBallLogic : MonoBehaviour
{
	[Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class <PlayPopCallback>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float clipLength;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BouncingBallLogic <>4__this;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0xDE5CDC", Offset = "0xDE5CDC", VA = "0xDE5CDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0xDE5D24", Offset = "0xDE5D24", VA = "0xDE5D24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xDE5BB0", Offset = "0xDE5BB0", VA = "0xDE5BB0")]
		[DebuggerHidden]
		public <PlayPopCallback>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xDE5BF0", Offset = "0xDE5BF0", VA = "0xDE5BF0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xDE5BF4", Offset = "0xDE5BF4", VA = "0xDE5BF4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xDE5CE4", Offset = "0xDE5CE4", VA = "0xDE5CE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float TTL;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip pop;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip bounce;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip loadball;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material visibleMat;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Material hiddenMat;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource audioSource;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform centerEyeCamera;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isVisible;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float timer;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isReleased;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool isReadyForDestroy;

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xDE55F8", Offset = "0xDE55F8", VA = "0xDE55F8")]
	private void OnCollisionEnter()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xDE561C", Offset = "0xDE561C", VA = "0xDE561C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xDE570C", Offset = "0xDE570C", VA = "0xDE570C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xDE57B0", Offset = "0xDE57B0", VA = "0xDE57B0")]
	private void UpdateVisibility()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xDE59F8", Offset = "0xDE59F8", VA = "0xDE59F8")]
	private void SetVisible(bool setVisible)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xDE5A9C", Offset = "0xDE5A9C", VA = "0xDE5A9C")]
	public void Release(Vector3 pos, Vector3 vel, Vector3 angVel)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0xDE5980", Offset = "0xDE5980", VA = "0xDE5980")]
	[IteratorStateMachine(typeof(<PlayPopCallback>d__18))]
	private IEnumerator PlayPopCallback(float clipLength)
	{
		return null;
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0xDE5BD8", Offset = "0xDE5BD8", VA = "0xDE5BD8")]
	public BouncingBallLogic()
	{
	}
}
[Token(Token = "0x200009F")]
public class BouncingBallMgr : MonoBehaviour
{
	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform trackingspace;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject rightControllerPivot;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private OVRInput.RawButton actionBtn;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject ball;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject currentBall;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool ballGrabbed;

	[Token(Token = "0x600036E")]
	[Address(RVA = "0xDE5D2C", Offset = "0xDE5D2C", VA = "0xDE5D2C")]
	private void Update()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0xDE6028", Offset = "0xDE6028", VA = "0xDE6028")]
	public BouncingBallMgr()
	{
	}
}
[Token(Token = "0x20000A0")]
[DefaultExecutionOrder(30)]
[RequireComponent(typeof(OVRSceneAnchor))]
public class FurnitureSpawner : MonoBehaviour
{
	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Add a point at ceiling.")]
	public GameObject RoomLightPrefab;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Spawnable> SpawnablePrefabs;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRSceneAnchor _sceneAnchor;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private OVRSemanticClassification _classification;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject _roomLightRef;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _frameCounter;

	[Token(Token = "0x6000370")]
	[Address(RVA = "0xDE6030", Offset = "0xDE6030", VA = "0xDE6030")]
	private void Start()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0xDE6214", Offset = "0xDE6214", VA = "0xDE6214")]
	private void SpawnSpawnable()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0xDE6684", Offset = "0xDE6684", VA = "0xDE6684")]
	private bool FindValidSpawnable(out Spawnable currentSpawnable)
	{
		return default(bool);
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0xDE60B8", Offset = "0xDE60B8", VA = "0xDE60B8")]
	private void AddRoomLight()
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xDE6888", Offset = "0xDE6888", VA = "0xDE6888")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xDE6D74", Offset = "0xDE6D74", VA = "0xDE6D74")]
	public FurnitureSpawner()
	{
	}
}
[Token(Token = "0x20000A1")]
public class MyCustomSceneModelLoader : OVRSceneModelLoader
{
	[Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class <DelayedLoad>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MyCustomSceneModelLoader <>4__this;

		[Token(Token = "0x17000053")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0xDE6F90", Offset = "0xDE6F90", VA = "0xDE6F90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0xDE6FD8", Offset = "0xDE6FD8", VA = "0xDE6FD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xDE6DE4", Offset = "0xDE6DE4", VA = "0xDE6DE4")]
		[DebuggerHidden]
		public <DelayedLoad>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xDE6E9C", Offset = "0xDE6E9C", VA = "0xDE6E9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xDE6EA0", Offset = "0xDE6EA0", VA = "0xDE6EA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xDE6F98", Offset = "0xDE6F98", VA = "0xDE6F98", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xDE6D7C", Offset = "0xDE6D7C", VA = "0xDE6D7C")]
	[IteratorStateMachine(typeof(<DelayedLoad>d__0))]
	private IEnumerator DelayedLoad()
	{
		return null;
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xDE6E0C", Offset = "0xDE6E0C", VA = "0xDE6E0C", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xDE6E2C", Offset = "0xDE6E2C", VA = "0xDE6E2C", Slot = "6")]
	protected override void OnNoSceneModelToLoad()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xDE6E94", Offset = "0xDE6E94", VA = "0xDE6E94")]
	public MyCustomSceneModelLoader()
	{
	}
}
[Token(Token = "0x20000A3")]
[RequireComponent(typeof(OVRManager))]
public class PassthroughPlayInEditor : MonoBehaviour
{
	[Token(Token = "0x6000380")]
	[Address(RVA = "0xDE6FE0", Offset = "0xDE6FE0", VA = "0xDE6FE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xDE6FE4", Offset = "0xDE6FE4", VA = "0xDE6FE4")]
	public PassthroughPlayInEditor()
	{
	}
}
[Token(Token = "0x20000A4")]
public class RequestCaptureFlow : MonoBehaviour
{
	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Button RequestCaptureBtn;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRSceneManager _sceneManager;

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xDE6FEC", Offset = "0xDE6FEC", VA = "0xDE6FEC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xDE705C", Offset = "0xDE705C", VA = "0xDE705C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xDE70E0", Offset = "0xDE70E0", VA = "0xDE70E0")]
	public RequestCaptureFlow()
	{
	}
}
[Token(Token = "0x20000A5")]
[ExecuteInEditMode]
public class SimpleResizable : MonoBehaviour
{
	[Token(Token = "0x20000A6")]
	public enum Method
	{
		[Token(Token = "0x40003B4")]
		Adapt,
		[Token(Token = "0x40003B5")]
		AdaptWithAsymmetricalPadding,
		[Token(Token = "0x40003B6")]
		Scale,
		[Token(Token = "0x40003B7")]
		None
	}

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(15f)]
	public Method ScalingX;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 0.5f)]
	public float PaddingX;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(-0.5f, 0f)]
	public float PaddingXMax;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space(15f)]
	public Method ScalingY;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 0.5f)]
	public float PaddingY;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(-0.5f, 0f)]
	public float PaddingYMax;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space(15f)]
	public Method ScalingZ;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0f, 0.5f)]
	public float PaddingZ;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(-0.5f, 0f)]
	public float PaddingZMax;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Bounds _bounds;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform _pivotTransform;

	[Token(Token = "0x17000055")]
	public Vector3 PivotPosition
	{
		[Token(Token = "0x6000385")]
		[Address(RVA = "0xDE70F0", Offset = "0xDE70F0", VA = "0xDE70F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000056")]
	public Vector3 NewSize
	{
		[Token(Token = "0x6000386")]
		[Address(RVA = "0xDE710C", Offset = "0xDE710C", VA = "0xDE710C")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000387")]
		[Address(RVA = "0xDE7118", Offset = "0xDE7118", VA = "0xDE7118")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000057")]
	public Vector3 DefaultSize
	{
		[Token(Token = "0x6000388")]
		[Address(RVA = "0xDE7124", Offset = "0xDE7124", VA = "0xDE7124")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000389")]
		[Address(RVA = "0xDE7130", Offset = "0xDE7130", VA = "0xDE7130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000058")]
	public Mesh Mesh
	{
		[Token(Token = "0x600038A")]
		[Address(RVA = "0xDE713C", Offset = "0xDE713C", VA = "0xDE713C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600038B")]
		[Address(RVA = "0xDE7144", Offset = "0xDE7144", VA = "0xDE7144")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xDE714C", Offset = "0xDE714C", VA = "0xDE714C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0xDE725C", Offset = "0xDE725C", VA = "0xDE725C")]
	public SimpleResizable()
	{
	}
}
[Token(Token = "0x20000A7")]
public class SimpleResizer
{
	[Token(Token = "0x600038E")]
	[Address(RVA = "0xDE69E0", Offset = "0xDE69E0", VA = "0xDE69E0")]
	public void CreateResizedObject(Vector3 newSize, GameObject parent, SimpleResizable sourcePrefab)
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xDE7264", Offset = "0xDE7264", VA = "0xDE7264")]
	private Mesh ProcessVertices(SimpleResizable resizable, Vector3 newSize)
	{
		return null;
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xDE74E8", Offset = "0xDE74E8", VA = "0xDE74E8")]
	private float CalculateNewVertexPosition(SimpleResizable.Method resizeMethod, float currentPosition, float currentSize, float newSize, float padding, float paddingMax, float pivot)
	{
		return default(float);
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xDE69D8", Offset = "0xDE69D8", VA = "0xDE69D8")]
	public SimpleResizer()
	{
	}
}
[Serializable]
[Token(Token = "0x20000A8")]
public class Spawnable : ISerializationCallbackReceiver
{
	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public SimpleResizable ResizablePrefab;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ClassificationLabel;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _editorClassificationIndex;

	[Token(Token = "0x6000392")]
	[Address(RVA = "0xDE7590", Offset = "0xDE7590", VA = "0xDE7590", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0xDE7594", Offset = "0xDE7594", VA = "0xDE7594", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xDE79FC", Offset = "0xDE79FC", VA = "0xDE79FC")]
	public Spawnable()
	{
	}
}
[Token(Token = "0x20000A9")]
[RequireComponent(typeof(OVRSceneAnchor))]
public class VolumeAndPlaneSwitcher : MonoBehaviour
{
	[Token(Token = "0x20000AA")]
	public enum GeometryType
	{
		[Token(Token = "0x40003BF")]
		Plane,
		[Token(Token = "0x40003C0")]
		Volume
	}

	[Serializable]
	[Token(Token = "0x20000AB")]
	public struct LabelGeometryPair
	{
		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string label;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GeometryType desiredGeometryType;
	}

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSceneAnchor planePrefab;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRSceneAnchor volumePrefab;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<LabelGeometryPair> desiredSwitches;

	[Token(Token = "0x6000396")]
	[Address(RVA = "0xDE7A4C", Offset = "0xDE7A4C", VA = "0xDE7A4C")]
	private void ReplaceAnchor(OVRSceneAnchor prefab, Vector3 position, Quaternion rotation, Vector3 localScale)
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xDE7E78", Offset = "0xDE7E78", VA = "0xDE7E78")]
	private void Start()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xDE87B0", Offset = "0xDE87B0", VA = "0xDE87B0")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xDE8688", Offset = "0xDE8688", VA = "0xDE8688")]
	private void GetTopPlaneFromVolume(Transform volume, Vector3 dimensions, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0xDE8830", Offset = "0xDE8830", VA = "0xDE8830")]
	public VolumeAndPlaneSwitcher()
	{
	}
}
[Token(Token = "0x20000AC")]
[RequireComponent(typeof(OVRSpatialAnchor))]
public class Anchor : MonoBehaviour
{
	[Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class <Start>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Anchor <>4__this;

		[Token(Token = "0x1700005A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xDE9584", Offset = "0xDE9584", VA = "0xDE9584", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xDE95CC", Offset = "0xDE95CC", VA = "0xDE95CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xDE89E8", Offset = "0xDE89E8", VA = "0xDE89E8")]
		[DebuggerHidden]
		public <Start>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xDE9414", Offset = "0xDE9414", VA = "0xDE9414", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xDE9418", Offset = "0xDE9418", VA = "0xDE9418", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xDE958C", Offset = "0xDE958C", VA = "0xDE958C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003C3")]
	public const string NumUuidsPlayerPref = "numUuids";

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("canvas_")]
	[SerializeField]
	private Canvas _canvas;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("pivot_")]
	private Transform _pivot;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("anchorMenu_")]
	private GameObject _anchorMenu;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _isSelected;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool _isHovered;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[FormerlySerializedAs("anchorName_")]
	private TextMeshProUGUI _anchorName;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("saveIcon_")]
	private GameObject _saveIcon;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[FormerlySerializedAs("labelImage_")]
	private Image _labelImage;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	[FormerlySerializedAs("labelBaseColor_")]
	private Color _labelBaseColor;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[FormerlySerializedAs("labelHighlightColor_")]
	[SerializeField]
	private Color _labelHighlightColor;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	[FormerlySerializedAs("labelSelectedColor_")]
	private Color _labelSelectedColor;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	[FormerlySerializedAs("uiManager_")]
	private AnchorUIManager _uiManager;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[FormerlySerializedAs("renderers_")]
	private MeshRenderer[] _renderers;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _menuIndex;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	[FormerlySerializedAs("buttonList_")]
	private List<Button> _buttonList;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Button _selectedButton;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private OVRSpatialAnchor _spatialAnchor;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject _icon;

	[Token(Token = "0x17000059")]
	public bool ShowSaveIcon
	{
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xDE8E94", Offset = "0xDE8E94", VA = "0xDE8E94")]
		set
		{
		}
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xDE8838", Offset = "0xDE8838", VA = "0xDE8838")]
	private void Awake()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xDE8980", Offset = "0xDE8980", VA = "0xDE8980")]
	[IteratorStateMachine(typeof(<Start>d__20))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0xDE8A10", Offset = "0xDE8A10", VA = "0xDE8A10")]
	private void Update()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xDE8C88", Offset = "0xDE8C88", VA = "0xDE8C88")]
	public void OnSaveLocalButtonPressed()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xDE8D58", Offset = "0xDE8D58", VA = "0xDE8D58")]
	public void OnHideButtonPressed()
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0xDE8DC4", Offset = "0xDE8DC4", VA = "0xDE8DC4")]
	public void OnEraseButtonPressed()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0xDE8EB4", Offset = "0xDE8EB4", VA = "0xDE8EB4")]
	public void OnHoverStart()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0xDE8FD0", Offset = "0xDE8FD0", VA = "0xDE8FD0")]
	public void OnHoverEnd()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0xDE90D8", Offset = "0xDE90D8", VA = "0xDE90D8")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0xDE8A60", Offset = "0xDE8A60", VA = "0xDE8A60")]
	private void BillboardPanel(Transform panel)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xDE8B94", Offset = "0xDE8B94", VA = "0xDE8B94")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0xDE9198", Offset = "0xDE9198", VA = "0xDE9198")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xDE92BC", Offset = "0xDE92BC", VA = "0xDE92BC")]
	public Anchor()
	{
	}
}
[Token(Token = "0x20000AE")]
[RequireComponent(typeof(SpatialAnchorLoader))]
public class AnchorUIManager : MonoBehaviour
{
	[Token(Token = "0x20000AF")]
	public enum AnchorMode
	{
		[Token(Token = "0x40003EC")]
		Create,
		[Token(Token = "0x40003ED")]
		Select
	}

	[Token(Token = "0x20000B0")]
	private delegate void PrimaryPressDelegate();

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorUIManager Instance;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[FormerlySerializedAs("createModeButton_")]
	private GameObject _createModeButton;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("selectModeButton_")]
	private GameObject _selectModeButton;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("trackedDevice_")]
	private Transform _trackedDevice;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _raycastOrigin;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _drawRaycast;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("lineRenderer_")]
	[SerializeField]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Anchor _hoveredAnchor;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Anchor _selectedAnchor;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AnchorMode _mode;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[FormerlySerializedAs("buttonList_")]
	private List<Button> _buttonList;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _menuIndex;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Button _selectedButton;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Anchor _anchorPrefab;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[FormerlySerializedAs("placementPreview_")]
	[SerializeField]
	private GameObject _placementPreview;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[FormerlySerializedAs("anchorPlacementTransform_")]
	[SerializeField]
	private Transform _anchorPlacementTransform;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PrimaryPressDelegate _primaryPressDelegate;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool _isFocused;

	[Token(Token = "0x1700005C")]
	public Anchor AnchorPrefab
	{
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xDE95D4", Offset = "0xDE95D4", VA = "0xDE95D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0xDE95DC", Offset = "0xDE95DC", VA = "0xDE95DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0xDE969C", Offset = "0xDE969C", VA = "0xDE969C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0xDE97BC", Offset = "0xDE97BC", VA = "0xDE97BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0xDE9C30", Offset = "0xDE9C30", VA = "0xDE9C30")]
	public void OnCreateModeButtonPressed()
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0xDE9C9C", Offset = "0xDE9C9C", VA = "0xDE9C9C")]
	public void OnLoadAnchorsButtonPressed()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0xDE976C", Offset = "0xDE976C", VA = "0xDE976C")]
	private void ToggleCreateMode()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0xDE9E60", Offset = "0xDE9E60", VA = "0xDE9E60")]
	private void StartPlacementMode()
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0xDE9EE0", Offset = "0xDE9EE0", VA = "0xDE9EE0")]
	private void EndPlacementMode()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xDE9EF8", Offset = "0xDE9EF8", VA = "0xDE9EF8")]
	private void StartSelectMode()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xDE9E48", Offset = "0xDE9E48", VA = "0xDE9E48")]
	private void EndSelectMode()
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xDE9B3C", Offset = "0xDE9B3C", VA = "0xDE9B3C")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0xDEA0E0", Offset = "0xDEA0E0", VA = "0xDEA0E0")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0xDE9F78", Offset = "0xDE9F78", VA = "0xDE9F78")]
	private void ShowAnchorPreview()
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0xDEA054", Offset = "0xDEA054", VA = "0xDEA054")]
	private void HideAnchorPreview()
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0xDEA1CC", Offset = "0xDEA1CC", VA = "0xDEA1CC")]
	private void PlaceAnchor()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0xDEA074", Offset = "0xDEA074", VA = "0xDEA074")]
	private void ShowRaycastLine()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xDEA0AC", Offset = "0xDEA0AC", VA = "0xDEA0AC")]
	private void HideRaycastLine()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0xDE98BC", Offset = "0xDE98BC", VA = "0xDE98BC")]
	private void ControllerRaycast()
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xDEA2B8", Offset = "0xDEA2B8", VA = "0xDEA2B8")]
	private void HoverAnchor(Anchor anchor)
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0xDEA2D4", Offset = "0xDEA2D4", VA = "0xDEA2D4")]
	private void UnhoverAnchor()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0xDEA350", Offset = "0xDEA350", VA = "0xDEA350")]
	private void SelectAnchor()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0xDEA468", Offset = "0xDEA468", VA = "0xDEA468")]
	public AnchorUIManager()
	{
	}
}
[Token(Token = "0x20000B1")]
public class SpatialAnchorLoader : MonoBehaviour
{
	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRSpatialAnchor _anchorPrefab;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly HashSet<ulong> _locateAnchorRequest;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ulong _queryRequestId;

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0xDEA4B8", Offset = "0xDEA4B8", VA = "0xDEA4B8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0xDEA5B8", Offset = "0xDEA5B8", VA = "0xDEA5B8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0xDEA6B8", Offset = "0xDEA6B8", VA = "0xDEA6B8")]
	private void SetComponentEnabled(ulong requestId, bool result, OVRSpace space, Guid uuid, OVRPlugin.SpaceComponentType componentType, bool enabled)
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0xDEA90C", Offset = "0xDEA90C", VA = "0xDEA90C")]
	private void QueryComplete(ulong requestId, bool result)
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0xDEAB18", Offset = "0xDEAB18", VA = "0xDEAB18")]
	private void TryEnableComponent(ulong anchorHandle, OVRPlugin.SpaceComponentType type)
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0xDEAE7C", Offset = "0xDEAE7C", VA = "0xDEAE7C")]
	public void LoadAnchorsByUuid()
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0xDE9CF0", Offset = "0xDE9CF0", VA = "0xDE9CF0")]
	public void LoadAllLocalAnchors()
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0xDEA880", Offset = "0xDEA880", VA = "0xDEA880")]
	private static void Log(string message)
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0xDEB0F0", Offset = "0xDEB0F0", VA = "0xDEB0F0")]
	public SpatialAnchorLoader()
	{
	}
}
[Token(Token = "0x20000B2")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0xDEB16C", Offset = "0xDEB16C", VA = "0xDEB16C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0xDEB370", Offset = "0xDEB370", VA = "0xDEB370")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0xDEB474", Offset = "0xDEB474", VA = "0xDEB474")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x20000B4")]
public class PruebaVibration : MonoBehaviour
{
	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Tween vibrationEffectCombo;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Vibration")]
	private VibrationManager _vibrationManager;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("Vibration Animation")]
	public float delay;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int loops;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float amplitude;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float timeVibration;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("Vibration Combo")]
	public float amplitudeCombo;

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0xDEB498", Offset = "0xDEB498", VA = "0xDEB498")]
	[Inject]
	private void Construct(VibrationManager vibrationManager)
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0xDEB4A0", Offset = "0xDEB4A0", VA = "0xDEB4A0")]
	public void OnVibrationHandLeft()
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0xDEB4A4", Offset = "0xDEB4A4", VA = "0xDEB4A4")]
	public void OnVibrationHandRight()
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0xDEB4A8", Offset = "0xDEB4A8", VA = "0xDEB4A8")]
	public void OFFVibrationHandLeft()
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0xDEB4C8", Offset = "0xDEB4C8", VA = "0xDEB4C8")]
	public void OFFVibrationHandRight()
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0xDEB4E8", Offset = "0xDEB4E8", VA = "0xDEB4E8")]
	public void ActivarCombo()
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0xDEB50C", Offset = "0xDEB50C", VA = "0xDEB50C")]
	public void EffectCombo()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0xDEB5DC", Offset = "0xDEB5DC", VA = "0xDEB5DC")]
	public PruebaVibration()
	{
	}
}
[Token(Token = "0x20000B5")]
public class OddersInputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	[Token(Token = "0x20000B6")]
	public struct OddersHMDActions
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private OddersInputActions m_Wrapper;

		[Token(Token = "0x17000066")]
		public InputAction Position
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0xDEC024", Offset = "0xDEC024", VA = "0xDEC024")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public InputAction Rotation
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0xDEC040", Offset = "0xDEC040", VA = "0xDEC040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public bool enabled
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0xDEC0C0", Offset = "0xDEC0C0", VA = "0xDEC0C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xDEC01C", Offset = "0xDEC01C", VA = "0xDEC01C")]
		public OddersHMDActions(OddersInputActions wrapper)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xDEC05C", Offset = "0xDEC05C", VA = "0xDEC05C")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xDEC078", Offset = "0xDEC078", VA = "0xDEC078")]
		public void Enable()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xDEC09C", Offset = "0xDEC09C", VA = "0xDEC09C")]
		public void Disable()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xDEC0E4", Offset = "0xDEC0E4", VA = "0xDEC0E4")]
		public static implicit operator InputActionMap(OddersHMDActions set)
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xDEC0FC", Offset = "0xDEC0FC", VA = "0xDEC0FC")]
		public void SetCallbacks(IOddersHMDActions instance)
		{
		}
	}

	[Token(Token = "0x20000B7")]
	public struct OddersLeftHandActions
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private OddersInputActions m_Wrapper;

		[Token(Token = "0x17000069")]
		public InputAction Position
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0xDEC888", Offset = "0xDEC888", VA = "0xDEC888")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public InputAction Rotation
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0xDEC8A4", Offset = "0xDEC8A4", VA = "0xDEC8A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public InputAction Grip
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xDEC8C0", Offset = "0xDEC8C0", VA = "0xDEC8C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public InputAction Trigger
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0xDEC8DC", Offset = "0xDEC8DC", VA = "0xDEC8DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public InputAction HapticDevice
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xDEC8F8", Offset = "0xDEC8F8", VA = "0xDEC8F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public InputAction SwapUIRay
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xDEC914", Offset = "0xDEC914", VA = "0xDEC914")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public InputAction ScrollUi
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0xDEC930", Offset = "0xDEC930", VA = "0xDEC930")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public InputAction Menu
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0xDEC94C", Offset = "0xDEC94C", VA = "0xDEC94C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public InputAction PrimaryButton
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0xDEC968", Offset = "0xDEC968", VA = "0xDEC968")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public InputAction SecundaryButton
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0xDEC984", Offset = "0xDEC984", VA = "0xDEC984")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public InputAction Velocity
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0xDEC9A0", Offset = "0xDEC9A0", VA = "0xDEC9A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public InputAction Acceleration
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0xDEC9BC", Offset = "0xDEC9BC", VA = "0xDEC9BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public InputAction AngularAcceleration
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0xDEC9D8", Offset = "0xDEC9D8", VA = "0xDEC9D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public InputAction GrabAction
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0xDEC9F4", Offset = "0xDEC9F4", VA = "0xDEC9F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public InputAction Pause
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0xDECA10", Offset = "0xDECA10", VA = "0xDECA10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public bool enabled
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0xDECA90", Offset = "0xDECA90", VA = "0xDECA90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xDEC880", Offset = "0xDEC880", VA = "0xDEC880")]
		public OddersLeftHandActions(OddersInputActions wrapper)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xDECA2C", Offset = "0xDECA2C", VA = "0xDECA2C")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xDECA48", Offset = "0xDECA48", VA = "0xDECA48")]
		public void Enable()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xDECA6C", Offset = "0xDECA6C", VA = "0xDECA6C")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xDECAB4", Offset = "0xDECAB4", VA = "0xDECAB4")]
		public static implicit operator InputActionMap(OddersLeftHandActions set)
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xDECACC", Offset = "0xDECACC", VA = "0xDECACC")]
		public void SetCallbacks(IOddersLeftHandActions instance)
		{
		}
	}

	[Token(Token = "0x20000B8")]
	public struct OddersRightHandActions
	{
		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private OddersInputActions m_Wrapper;

		[Token(Token = "0x17000079")]
		public InputAction Position
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0xDF10A8", Offset = "0xDF10A8", VA = "0xDF10A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public InputAction Rotation
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0xDF10C4", Offset = "0xDF10C4", VA = "0xDF10C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public InputAction Grip
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0xDF10E0", Offset = "0xDF10E0", VA = "0xDF10E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public InputAction Trigger
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0xDF10FC", Offset = "0xDF10FC", VA = "0xDF10FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public InputAction HapticDevice
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0xDF1118", Offset = "0xDF1118", VA = "0xDF1118")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public InputAction SwapUIRay
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0xDF1134", Offset = "0xDF1134", VA = "0xDF1134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public InputAction ScrollUi
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0xDF1150", Offset = "0xDF1150", VA = "0xDF1150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public InputAction Menu
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0xDF116C", Offset = "0xDF116C", VA = "0xDF116C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public InputAction PrimaryButton
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0xDF1188", Offset = "0xDF1188", VA = "0xDF1188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public InputAction SecundaryButton
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0xDF11A4", Offset = "0xDF11A4", VA = "0xDF11A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public InputAction Velocity
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0xDF11C0", Offset = "0xDF11C0", VA = "0xDF11C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public InputAction Acceleration
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0xDF11DC", Offset = "0xDF11DC", VA = "0xDF11DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public InputAction AngularAcceleration
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0xDF11F8", Offset = "0xDF11F8", VA = "0xDF11F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public InputAction Pause
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0xDF1214", Offset = "0xDF1214", VA = "0xDF1214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public InputAction VoiceActivation
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0xDF1230", Offset = "0xDF1230", VA = "0xDF1230")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		public InputAction ShowFullVersion
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0xDF124C", Offset = "0xDF124C", VA = "0xDF124C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public bool enabled
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0xDF12CC", Offset = "0xDF12CC", VA = "0xDF12CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xDF10A0", Offset = "0xDF10A0", VA = "0xDF10A0")]
		public OddersRightHandActions(OddersInputActions wrapper)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xDF1268", Offset = "0xDF1268", VA = "0xDF1268")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xDF1284", Offset = "0xDF1284", VA = "0xDF1284")]
		public void Enable()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xDF12A8", Offset = "0xDF12A8", VA = "0xDF12A8")]
		public void Disable()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xDF12F0", Offset = "0xDF12F0", VA = "0xDF12F0")]
		public static implicit operator InputActionMap(OddersRightHandActions set)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xDF1308", Offset = "0xDF1308", VA = "0xDF1308")]
		public void SetCallbacks(IOddersRightHandActions instance)
		{
		}
	}

	[Token(Token = "0x20000B9")]
	public interface IOddersHMDActions
	{
		[Token(Token = "0x600042D")]
		void OnPosition(InputAction.CallbackContext context);

		[Token(Token = "0x600042E")]
		void OnRotation(InputAction.CallbackContext context);
	}

	[Token(Token = "0x20000BA")]
	public interface IOddersLeftHandActions
	{
		[Token(Token = "0x600042F")]
		void OnPosition(InputAction.CallbackContext context);

		[Token(Token = "0x6000430")]
		void OnRotation(InputAction.CallbackContext context);

		[Token(Token = "0x6000431")]
		void OnGrip(InputAction.CallbackContext context);

		[Token(Token = "0x6000432")]
		void OnTrigger(InputAction.CallbackContext context);

		[Token(Token = "0x6000433")]
		void OnHapticDevice(InputAction.CallbackContext context);

		[Token(Token = "0x6000434")]
		void OnSwapUIRay(InputAction.CallbackContext context);

		[Token(Token = "0x6000435")]
		void OnScrollUi(InputAction.CallbackContext context);

		[Token(Token = "0x6000436")]
		void OnMenu(InputAction.CallbackContext context);

		[Token(Token = "0x6000437")]
		void OnPrimaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x6000438")]
		void OnSecundaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x6000439")]
		void OnVelocity(InputAction.CallbackContext context);

		[Token(Token = "0x600043A")]
		void OnAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x600043B")]
		void OnAngularAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x600043C")]
		void OnGrabAction(InputAction.CallbackContext context);

		[Token(Token = "0x600043D")]
		void OnPause(InputAction.CallbackContext context);
	}

	[Token(Token = "0x20000BB")]
	public interface IOddersRightHandActions
	{
		[Token(Token = "0x600043E")]
		void OnPosition(InputAction.CallbackContext context);

		[Token(Token = "0x600043F")]
		void OnRotation(InputAction.CallbackContext context);

		[Token(Token = "0x6000440")]
		void OnGrip(InputAction.CallbackContext context);

		[Token(Token = "0x6000441")]
		void OnTrigger(InputAction.CallbackContext context);

		[Token(Token = "0x6000442")]
		void OnHapticDevice(InputAction.CallbackContext context);

		[Token(Token = "0x6000443")]
		void OnSwapUIRay(InputAction.CallbackContext context);

		[Token(Token = "0x6000444")]
		void OnScrollUi(InputAction.CallbackContext context);

		[Token(Token = "0x6000445")]
		void OnMenu(InputAction.CallbackContext context);

		[Token(Token = "0x6000446")]
		void OnPrimaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x6000447")]
		void OnSecundaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x6000448")]
		void OnVelocity(InputAction.CallbackContext context);

		[Token(Token = "0x6000449")]
		void OnAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x600044A")]
		void OnAngularAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x600044B")]
		void OnPause(InputAction.CallbackContext context);

		[Token(Token = "0x600044C")]
		void OnVoiceActivation(InputAction.CallbackContext context);

		[Token(Token = "0x600044D")]
		void OnShowFullVersion(InputAction.CallbackContext context);
	}

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly InputActionMap m_OddersHMD;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private IOddersHMDActions m_OddersHMDActionsCallbackInterface;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputAction m_OddersHMD_Position;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly InputAction m_OddersHMD_Rotation;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly InputActionMap m_OddersLeftHand;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private IOddersLeftHandActions m_OddersLeftHandActionsCallbackInterface;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly InputAction m_OddersLeftHand_Position;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly InputAction m_OddersLeftHand_Rotation;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly InputAction m_OddersLeftHand_Grip;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly InputAction m_OddersLeftHand_Trigger;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly InputAction m_OddersLeftHand_HapticDevice;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly InputAction m_OddersLeftHand_SwapUIRay;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly InputAction m_OddersLeftHand_ScrollUi;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly InputAction m_OddersLeftHand_Menu;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly InputAction m_OddersLeftHand_PrimaryButton;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly InputAction m_OddersLeftHand_SecundaryButton;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly InputAction m_OddersLeftHand_Velocity;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly InputAction m_OddersLeftHand_Acceleration;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly InputAction m_OddersLeftHand_AngularAcceleration;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly InputAction m_OddersLeftHand_GrabAction;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly InputAction m_OddersLeftHand_Pause;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly InputActionMap m_OddersRightHand;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private IOddersRightHandActions m_OddersRightHandActionsCallbackInterface;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly InputAction m_OddersRightHand_Position;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly InputAction m_OddersRightHand_Rotation;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly InputAction m_OddersRightHand_Grip;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly InputAction m_OddersRightHand_Trigger;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly InputAction m_OddersRightHand_HapticDevice;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly InputAction m_OddersRightHand_SwapUIRay;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly InputAction m_OddersRightHand_ScrollUi;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly InputAction m_OddersRightHand_Menu;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly InputAction m_OddersRightHand_PrimaryButton;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly InputAction m_OddersRightHand_SecundaryButton;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly InputAction m_OddersRightHand_Velocity;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly InputAction m_OddersRightHand_Acceleration;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly InputAction m_OddersRightHand_AngularAcceleration;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly InputAction m_OddersRightHand_Pause;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly InputAction m_OddersRightHand_VoiceActivation;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly InputAction m_OddersRightHand_ShowFullVersion;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private int m_GenericXRControllerSchemeIndex;

	[Token(Token = "0x1700005D")]
	public InputActionAsset asset
	{
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xDEB610", Offset = "0xDEB610", VA = "0xDEB610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005E")]
	public InputBinding? bindingMask
	{
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xDEBD0C", Offset = "0xDEBD0C", VA = "0xDEBD0C", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xDEBD34", Offset = "0xDEBD34", VA = "0xDEBD34", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x1700005F")]
	public ReadOnlyArray<InputDevice>? devices
	{
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xDEBD80", Offset = "0xDEBD80", VA = "0xDEBD80", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xDEBDC0", Offset = "0xDEBDC0", VA = "0xDEBDC0", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x17000060")]
	public ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xDEBE0C", Offset = "0xDEBE0C", VA = "0xDEBE0C", Slot = "11")]
		get
		{
			return default(ReadOnlyArray<InputControlScheme>);
		}
	}

	[Token(Token = "0x17000061")]
	public IEnumerable<InputBinding> bindings
	{
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xDEBEB4", Offset = "0xDEBEB4", VA = "0xDEBEB4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000062")]
	public OddersHMDActions OddersHMD
	{
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xDEBF4C", Offset = "0xDEBF4C", VA = "0xDEBF4C")]
		get
		{
			return default(OddersHMDActions);
		}
	}

	[Token(Token = "0x17000063")]
	public OddersLeftHandActions OddersLeftHand
	{
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xDEBF50", Offset = "0xDEBF50", VA = "0xDEBF50")]
		get
		{
			return default(OddersLeftHandActions);
		}
	}

	[Token(Token = "0x17000064")]
	public OddersRightHandActions OddersRightHand
	{
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xDEBF54", Offset = "0xDEBF54", VA = "0xDEBF54")]
		get
		{
			return default(OddersRightHandActions);
		}
	}

	[Token(Token = "0x17000065")]
	public InputControlScheme GenericXRControllerScheme
	{
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xDEBF58", Offset = "0xDEBF58", VA = "0xDEBF58")]
		get
		{
			return default(InputControlScheme);
		}
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0xDEB618", Offset = "0xDEB618", VA = "0xDEB618")]
	public OddersInputActions()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0xDEBCB0", Offset = "0xDEBCB0", VA = "0xDEBCB0", Slot = "17")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0xDEBE28", Offset = "0xDEBE28", VA = "0xDEBE28", Slot = "12")]
	public bool Contains(InputAction action)
	{
		return default(bool);
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0xDEBE44", Offset = "0xDEBE44", VA = "0xDEBE44", Slot = "15")]
	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0xDEBE60", Offset = "0xDEBE60", VA = "0xDEBE60", Slot = "16")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xDEBE7C", Offset = "0xDEBE7C", VA = "0xDEBE7C", Slot = "13")]
	public void Enable()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xDEBE98", Offset = "0xDEBE98", VA = "0xDEBE98", Slot = "14")]
	public void Disable()
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0xDEBED0", Offset = "0xDEBED0", VA = "0xDEBED0", Slot = "5")]
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
	{
		return null;
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0xDEBEF0", Offset = "0xDEBEF0", VA = "0xDEBEF0", Slot = "6")]
	public int FindBinding(InputBinding bindingMask, out InputAction action)
	{
		return default(int);
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x20000BC")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x1700008A")]
		public bool Highlight
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0xDF4C6C", Offset = "0xDF4C6C", VA = "0xDF4C6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0xDF4C74", Offset = "0xDF4C74", VA = "0xDF4C74")]
			set
			{
			}
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xDF4C80", Offset = "0xDF4C80", VA = "0xDF4C80")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xDF4E20", Offset = "0xDF4E20", VA = "0xDF4E20", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xDF4E3C", Offset = "0xDF4E3C", VA = "0xDF4E3C", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xDF4E58", Offset = "0xDF4E58", VA = "0xDF4E58")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xDF4D2C", Offset = "0xDF4D2C", VA = "0xDF4D2C")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xDF50BC", Offset = "0xDF50BC", VA = "0xDF50BC")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x1700008B")]
		public bool InRange
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0xDF5134", Offset = "0xDF5134", VA = "0xDF5134")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000458")]
			[Address(RVA = "0xDF513C", Offset = "0xDF513C", VA = "0xDF513C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public bool Targeted
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0xDF52A8", Offset = "0xDF52A8", VA = "0xDF52A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045A")]
			[Address(RVA = "0xDF52B0", Offset = "0xDF52B0", VA = "0xDF52B0")]
			set
			{
			}
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xDF52BC", Offset = "0xDF52BC", VA = "0xDF52BC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xDF5148", Offset = "0xDF5148", VA = "0xDF5148")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xDF5478", Offset = "0xDF5478", VA = "0xDF5478")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[RequireComponent(typeof(Rigidbody))]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x1700008D")]
		public bool UseSpherecast
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0xDF5480", Offset = "0xDF5480", VA = "0xDF5480")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045F")]
			[Address(RVA = "0xDF5488", Offset = "0xDF5488", VA = "0xDF5488")]
			set
			{
			}
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xDF54A4", Offset = "0xDF54A4", VA = "0xDF54A4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xDF56A8", Offset = "0xDF56A8", VA = "0xDF56A8", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xDF5F3C", Offset = "0xDF5F3C", VA = "0xDF5F3C", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xDF6490", Offset = "0xDF6490", VA = "0xDF6490", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xDF68A0", Offset = "0xDF68A0", VA = "0xDF68A0")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xDF58B0", Offset = "0xDF58B0", VA = "0xDF58B0")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xDF698C", Offset = "0xDF698C", VA = "0xDF698C")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xDF6D2C", Offset = "0xDF6D2C", VA = "0xDF6D2C", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xDF6D44", Offset = "0xDF6D44", VA = "0xDF6D44", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xDF6D4C", Offset = "0xDF6D4C", VA = "0xDF6D4C")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x20000C0")]
		public enum CrosshairState
		{
			[Token(Token = "0x4000447")]
			Disabled,
			[Token(Token = "0x4000448")]
			Enabled,
			[Token(Token = "0x4000449")]
			Targeted
		}

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xDF6D6C", Offset = "0xDF6D6C", VA = "0xDF6D6C")]
		private void Start()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xDF53EC", Offset = "0xDF53EC", VA = "0xDF53EC")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xDF6DCC", Offset = "0xDF6DCC", VA = "0xDF6DCC")]
		private void Update()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xDF6E04", Offset = "0xDF6E04", VA = "0xDF6E04")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xDF6E0C", Offset = "0xDF6E0C", VA = "0xDF6E0C")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xDF6EB8", Offset = "0xDF6EB8", VA = "0xDF6EB8")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xDF6F60", Offset = "0xDF6F60", VA = "0xDF6F60")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x6000471")]
		[Address(RVA = "0xDF6F68", Offset = "0xDF6F68", VA = "0xDF6F68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xDF7054", Offset = "0xDF7054", VA = "0xDF7054")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xDF7060", Offset = "0xDF7060", VA = "0xDF7060")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xDF706C", Offset = "0xDF706C", VA = "0xDF706C")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xDF7074", Offset = "0xDF7074", VA = "0xDF7074")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xDF70C4", Offset = "0xDF70C4", VA = "0xDF70C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xDF748C", Offset = "0xDF748C", VA = "0xDF748C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xDF7578", Offset = "0xDF7578", VA = "0xDF7578")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xDF70C8", Offset = "0xDF70C8", VA = "0xDF70C8")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xDF7664", Offset = "0xDF7664", VA = "0xDF7664")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x20000C5")]
		public enum ContactTest
		{
			[Token(Token = "0x4000460")]
			PerpenTest,
			[Token(Token = "0x4000461")]
			BackwardsPress
		}

		[Token(Token = "0x4000451")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x4000452")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _allowMultipleNearFieldInteraction;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x1700008E")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0xDF7724", Offset = "0xDF7724", VA = "0xDF7724", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008F")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0xDF772C", Offset = "0xDF772C", VA = "0xDF772C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000090")]
		public InteractableState CurrentButtonState
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0xDF7738", Offset = "0xDF7738", VA = "0xDF7738")]
			[CompilerGenerated]
			get
			{
				return default(InteractableState);
			}
			[Token(Token = "0x600047E")]
			[Address(RVA = "0xDF7740", Offset = "0xDF7740", VA = "0xDF7740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xDF7748", Offset = "0xDF7748", VA = "0xDF7748", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xDF7878", Offset = "0xDF7878", VA = "0xDF7878")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xDF7A68", Offset = "0xDF7A68", VA = "0xDF7A68", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xDF802C", Offset = "0xDF802C", VA = "0xDF802C")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xDF8170", Offset = "0xDF8170", VA = "0xDF8170")]
		public void ForceResetButton()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xDF7F50", Offset = "0xDF7F50", VA = "0xDF7F50")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xDF827C", Offset = "0xDF827C", VA = "0xDF827C")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xDF8388", Offset = "0xDF8388", VA = "0xDF8388")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xDF8410", Offset = "0xDF8410", VA = "0xDF8410")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x17000091")]
		public Collider Collider
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0xDF851C", Offset = "0xDF851C", VA = "0xDF851C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0xDF8524", Offset = "0xDF8524", VA = "0xDF8524")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0xDF852C", Offset = "0xDF852C", VA = "0xDF852C", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600048B")]
			[Address(RVA = "0xDF8534", Offset = "0xDF8534", VA = "0xDF8534")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0xDF853C", Offset = "0xDF853C", VA = "0xDF853C", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xDF858C", Offset = "0xDF858C", VA = "0xDF858C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xDF860C", Offset = "0xDF860C", VA = "0xDF860C")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public interface ColliderZone
	{
		[Token(Token = "0x17000094")]
		Collider Collider
		{
			[Token(Token = "0x600048F")]
			get;
		}

		[Token(Token = "0x17000095")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x6000490")]
			get;
		}

		[Token(Token = "0x17000096")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000491")]
			get;
		}
	}
	[Token(Token = "0x20000C8")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xDF79D4", Offset = "0xDF79D4", VA = "0xDF79D4")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public enum InteractionType
	{
		[Token(Token = "0x400046A")]
		Enter,
		[Token(Token = "0x400046B")]
		Stay,
		[Token(Token = "0x400046C")]
		Exit
	}
	[Token(Token = "0x20000CA")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x20000CB")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x400047E")]
			Mesh,
			[Token(Token = "0x400047F")]
			Skeleton,
			[Token(Token = "0x4000480")]
			Both
		}

		[Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x170000A2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004B4")]
				[Address(RVA = "0xDF9968", Offset = "0xDF9968", VA = "0xDF9968", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004B6")]
				[Address(RVA = "0xDF99B0", Offset = "0xDF99B0", VA = "0xDF99B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0xDF8FD4", Offset = "0xDF8FD4", VA = "0xDF8FD4")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0xDF977C", Offset = "0xDF977C", VA = "0xDF977C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0xDF9780", Offset = "0xDF9780", VA = "0xDF9780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0xDF9970", Offset = "0xDF9970", VA = "0xDF9970", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400046D")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x17000097")]
		public OVRHand RightHand
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0xDF8614", Offset = "0xDF8614", VA = "0xDF8614")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000494")]
			[Address(RVA = "0xDF8640", Offset = "0xDF8640", VA = "0xDF8640")]
			private set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0xDF869C", Offset = "0xDF869C", VA = "0xDF869C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000496")]
			[Address(RVA = "0xDF86C8", Offset = "0xDF86C8", VA = "0xDF86C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0xDF8724", Offset = "0xDF8724", VA = "0xDF8724")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000498")]
			[Address(RVA = "0xDF8750", Offset = "0xDF8750", VA = "0xDF8750")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0xDF87AC", Offset = "0xDF87AC", VA = "0xDF87AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049A")]
			[Address(RVA = "0xDF87D8", Offset = "0xDF87D8", VA = "0xDF87D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0xDF8834", Offset = "0xDF8834", VA = "0xDF8834")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049C")]
			[Address(RVA = "0xDF8860", Offset = "0xDF8860", VA = "0xDF8860")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0xDF88BC", Offset = "0xDF88BC", VA = "0xDF88BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049E")]
			[Address(RVA = "0xDF88E4", Offset = "0xDF88E4", VA = "0xDF88E4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0xDF893C", Offset = "0xDF893C", VA = "0xDF893C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xDF8964", Offset = "0xDF8964", VA = "0xDF8964")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xDF89BC", Offset = "0xDF89BC", VA = "0xDF89BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xDF89E4", Offset = "0xDF89E4", VA = "0xDF89E4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xDF8A3C", Offset = "0xDF8A3C", VA = "0xDF8A3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xDF8A64", Offset = "0xDF8A64", VA = "0xDF8A64")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xDF8ABC", Offset = "0xDF8ABC", VA = "0xDF8ABC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xDF8AE4", Offset = "0xDF8AE4", VA = "0xDF8AE4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public static HandsManager Instance
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xDF8B3C", Offset = "0xDF8B3C", VA = "0xDF8B3C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xDF8B84", Offset = "0xDF8B84", VA = "0xDF8B84")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xDF8BD0", Offset = "0xDF8BD0", VA = "0xDF8BD0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xDF8F58", Offset = "0xDF8F58", VA = "0xDF8F58")]
		private void Update()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xDF8EF0", Offset = "0xDF8EF0", VA = "0xDF8EF0")]
		[IteratorStateMachine(typeof(<FindSkeletonVisualGameObjects>d__52))]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xDF8FFC", Offset = "0xDF8FFC", VA = "0xDF8FFC")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xDF90C0", Offset = "0xDF90C0", VA = "0xDF90C0")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xDF9290", Offset = "0xDF9290", VA = "0xDF9290")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xDF94F0", Offset = "0xDF94F0", VA = "0xDF94F0")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xDF9650", Offset = "0xDF9650", VA = "0xDF9650")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CE")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0xDFA000", Offset = "0xDFA000", VA = "0xDFA000")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x170000A4")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0xDF99B8", Offset = "0xDF99B8", VA = "0xDF99B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0xDF99C0", Offset = "0xDF99C0", VA = "0xDF99C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0xDF99C8", Offset = "0xDF99C8", VA = "0xDF99C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0xDF99D0", Offset = "0xDF99D0", VA = "0xDF99D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0xDF99D8", Offset = "0xDF99D8", VA = "0xDF99D8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0xDF9A88", Offset = "0xDF9A88", VA = "0xDF9A88")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0xDF9B54", Offset = "0xDF9B54", VA = "0xDF9B54")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xDF9C04", Offset = "0xDF9C04", VA = "0xDF9C04")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0xDF9CD0", Offset = "0xDF9CD0", VA = "0xDF9CD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xDF9D80", Offset = "0xDF9D80", VA = "0xDF9D80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xDF9B38", Offset = "0xDF9B38", VA = "0xDF9B38", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xDF9CB4", Offset = "0xDF9CB4", VA = "0xDF9CB4", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xDF9E30", Offset = "0xDF9E30", VA = "0xDF9E30", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60004C4")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xDF7824", Offset = "0xDF7824", VA = "0xDF7824", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xDF9EFC", Offset = "0xDF9EFC", VA = "0xDF9EFC", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xDF8514", Offset = "0xDF8514", VA = "0xDF8514")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x400048C")]
		None,
		[Token(Token = "0x400048D")]
		Proximity,
		[Token(Token = "0x400048E")]
		Contact,
		[Token(Token = "0x400048F")]
		Action
	}
	[Token(Token = "0x20000D0")]
	public enum InteractableState
	{
		[Token(Token = "0x4000491")]
		Default,
		[Token(Token = "0x4000492")]
		ProximityState,
		[Token(Token = "0x4000493")]
		ContactState,
		[Token(Token = "0x4000494")]
		ActionState
	}
	[Token(Token = "0x20000D1")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xDF80DC", Offset = "0xDF80DC", VA = "0xDF80DC")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x170000A8")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0xDFA048", Offset = "0xDFA048", VA = "0xDFA048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xDF9E4C", Offset = "0xDF9E4C", VA = "0xDF9E4C")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xDF9F50", Offset = "0xDF9F50", VA = "0xDF9F50")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xDFA0A0", Offset = "0xDFA0A0", VA = "0xDFA0A0")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x170000A9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004D7")]
				[Address(RVA = "0xDFA7B4", Offset = "0xDFA7B4", VA = "0xDFA7B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004D9")]
				[Address(RVA = "0xDFA7FC", Offset = "0xDFA7FC", VA = "0xDFA7FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0xDFA224", Offset = "0xDFA224", VA = "0xDFA224")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xDFA360", Offset = "0xDFA360", VA = "0xDFA360", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xDFA37C", Offset = "0xDFA37C", VA = "0xDFA37C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xDFA764", Offset = "0xDFA764", VA = "0xDFA764")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0xDFA7BC", Offset = "0xDFA7BC", VA = "0xDFA7BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xDFA134", Offset = "0xDFA134", VA = "0xDFA134")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xDFA1A0", Offset = "0xDFA1A0", VA = "0xDFA1A0")]
		[IteratorStateMachine(typeof(<AttachToolsToHands>d__3))]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xDFA24C", Offset = "0xDFA24C", VA = "0xDFA24C")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xDFA358", Offset = "0xDFA358", VA = "0xDFA358")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x170000AB")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xDFA804", Offset = "0xDFA804", VA = "0xDFA804")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xDFA950", Offset = "0xDFA950", VA = "0xDFA950")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xDFA9EC", Offset = "0xDFA9EC", VA = "0xDFA9EC")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xDFAA88", Offset = "0xDFAA88", VA = "0xDFAA88")]
		private void Update()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xDFAD24", Offset = "0xDFAD24", VA = "0xDFAD24")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xDFAD60", Offset = "0xDFAD60", VA = "0xDFAD60")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xDFB01C", Offset = "0xDFB01C", VA = "0xDFB01C")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xDFB224", Offset = "0xDFB224", VA = "0xDFB224")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x20000D7")]
		[CompilerGenerated]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x170000B0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004F3")]
				[Address(RVA = "0xDFC310", Offset = "0xDFC310", VA = "0xDFC310", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004F5")]
				[Address(RVA = "0xDFC358", Offset = "0xDFC358", VA = "0xDFC358", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xDFB468", Offset = "0xDFB468", VA = "0xDFB468")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0xDFBEAC", Offset = "0xDFBEAC", VA = "0xDFBEAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0xDFBEB0", Offset = "0xDFBEB0", VA = "0xDFBEB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0xDFC318", Offset = "0xDFC318", VA = "0xDFC318", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004AD")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x170000AC")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0xDFB2FC", Offset = "0xDFB2FC", VA = "0xDFB2FC", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000AD")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0xDFB304", Offset = "0xDFB304", VA = "0xDFB304", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000AE")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xDFB30C", Offset = "0xDFB30C", VA = "0xDFB30C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AF")]
		public override bool EnableState
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0xDFB314", Offset = "0xDFB314", VA = "0xDFB314", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0xDFB33C", Offset = "0xDFB33C", VA = "0xDFB33C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xDFB36C", Offset = "0xDFB36C", VA = "0xDFB36C", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xDFB400", Offset = "0xDFB400", VA = "0xDFB400")]
		[IteratorStateMachine(typeof(<AttachTriggerLogic>d__21))]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xDFB490", Offset = "0xDFB490", VA = "0xDFB490")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xDFB710", Offset = "0xDFB710", VA = "0xDFB710")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xDFB8CC", Offset = "0xDFB8CC", VA = "0xDFB8CC")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xDFB9B4", Offset = "0xDFB9B4", VA = "0xDFB9B4", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xDFBD30", Offset = "0xDFBD30", VA = "0xDFBD30", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xDFBD34", Offset = "0xDFBD34", VA = "0xDFBD34", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xDFBD38", Offset = "0xDFBD38", VA = "0xDFBD38")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class FingerTipPokeToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x170000B2")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0xDFC360", Offset = "0xDFC360", VA = "0xDFC360", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0xDFC368", Offset = "0xDFC368", VA = "0xDFC368")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public bool EnableState
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0xDFC370", Offset = "0xDFC370", VA = "0xDFC370", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0xDFC38C", Offset = "0xDFC38C", VA = "0xDFC38C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0xDFC3AC", Offset = "0xDFC3AC", VA = "0xDFC3AC", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0xDFC3B4", Offset = "0xDFC3B4", VA = "0xDFC3B4", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public float SphereRadius
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0xDFC3C0", Offset = "0xDFC3C0", VA = "0xDFC3C0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0xDFC3C8", Offset = "0xDFC3C8", VA = "0xDFC3C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xDFC3D0", Offset = "0xDFC3D0", VA = "0xDFC3D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xDFC40C", Offset = "0xDFC40C", VA = "0xDFC40C", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xDFC410", Offset = "0xDFC410", VA = "0xDFC410")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x40004C0")]
		None = 0,
		[Token(Token = "0x40004C1")]
		Ray = 1,
		[Token(Token = "0x40004C2")]
		Poke = 4,
		[Token(Token = "0x40004C3")]
		All = -1
	}
	[Token(Token = "0x20000DA")]
	public enum ToolInputState
	{
		[Token(Token = "0x40004C5")]
		Inactive,
		[Token(Token = "0x40004C6")]
		PrimaryInputDown,
		[Token(Token = "0x40004C7")]
		PrimaryInputDownStay,
		[Token(Token = "0x40004C8")]
		PrimaryInputUp
	}
	[Token(Token = "0x20000DB")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xDFBCF0", Offset = "0xDFBCF0", VA = "0xDFBCF0")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x170000B6")]
		public Transform ToolTransform
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0xDF8408", Offset = "0xDF8408", VA = "0xDF8408")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0xDFC418", Offset = "0xDFC418", VA = "0xDFC418")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000504")]
			[Address(RVA = "0xDFC420", Offset = "0xDFC420", VA = "0xDFC420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000505")]
			get;
		}

		[Token(Token = "0x170000B9")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x6000506")]
			get;
		}

		[Token(Token = "0x170000BA")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x6000507")]
			get;
		}

		[Token(Token = "0x170000BB")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0xDFC42C", Offset = "0xDFC42C", VA = "0xDFC42C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000509")]
			[Address(RVA = "0xDFC438", Offset = "0xDFC438", VA = "0xDFC438")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0xDFC444", Offset = "0xDFC444", VA = "0xDFC444")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600050B")]
			[Address(RVA = "0xDFC450", Offset = "0xDFC450", VA = "0xDFC450")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public abstract bool EnableState
		{
			[Token(Token = "0x6000510")]
			get;
			[Token(Token = "0x6000511")]
			set;
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xDFC45C", Offset = "0xDFC45C", VA = "0xDFC45C")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x600050E")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x600050F")]
		public abstract void DeFocus();

		[Token(Token = "0x6000512")]
		public abstract void Initialize();

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xDFB18C", Offset = "0xDFB18C", VA = "0xDFB18C")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xDFB1D4", Offset = "0xDFB1D4", VA = "0xDFB1D4")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xDFC464", Offset = "0xDFC464", VA = "0xDFC464", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xDFC710", Offset = "0xDFC710", VA = "0xDFC710", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xDFBD4C", Offset = "0xDFBD4C", VA = "0xDFBD4C")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public interface InteractableToolView
	{
		[Token(Token = "0x170000BE")]
		InteractableTool InteractableTool
		{
			[Token(Token = "0x6000518")]
			get;
		}

		[Token(Token = "0x170000BF")]
		bool EnableState
		{
			[Token(Token = "0x600051A")]
			get;
			[Token(Token = "0x600051B")]
			set;
		}

		[Token(Token = "0x170000C0")]
		bool ToolActivateState
		{
			[Token(Token = "0x600051C")]
			get;
			[Token(Token = "0x600051D")]
			set;
		}

		[Token(Token = "0x6000519")]
		void SetFocusedInteractable(Interactable interactable);
	}
	[Token(Token = "0x20000DE")]
	public class PinchStateModule
	{
		[Token(Token = "0x20000DF")]
		private enum PinchState
		{
			[Token(Token = "0x40004D9")]
			None,
			[Token(Token = "0x40004DA")]
			PinchDown,
			[Token(Token = "0x40004DB")]
			PinchStay,
			[Token(Token = "0x40004DC")]
			PinchUp
		}

		[Token(Token = "0x40004D5")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x170000C1")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0xDFCF58", Offset = "0xDFCF58", VA = "0xDFCF58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C2")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0xDFCFD4", Offset = "0xDFCFD4", VA = "0xDFCFD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C3")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0xDFD050", Offset = "0xDFD050", VA = "0xDFD050")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xDFD0CC", Offset = "0xDFD0CC", VA = "0xDFD0CC")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xDFD0EC", Offset = "0xDFD0EC", VA = "0xDFD0EC")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x40004DD")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x40004DE")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x40004DF")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x40004E0")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x40004E1")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Range(0f, 45f)]
		private float _coneAngleDegrees;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x170000C4")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0xDFD238", Offset = "0xDFD238", VA = "0xDFD238", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000C5")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0xDFD240", Offset = "0xDFD240", VA = "0xDFD240", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000C6")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0xDFD29C", Offset = "0xDFD29C", VA = "0xDFD29C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C7")]
		public override bool EnableState
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0xDFD2A4", Offset = "0xDFD2A4", VA = "0xDFD2A4", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000527")]
			[Address(RVA = "0xDFD2E4", Offset = "0xDFD2E4", VA = "0xDFD2E4", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xDFD354", Offset = "0xDFD354", VA = "0xDFD354", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xDFD3A0", Offset = "0xDFD3A0", VA = "0xDFD3A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xDFD42C", Offset = "0xDFD42C", VA = "0xDFD42C")]
		private void Update()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xDFD6D0", Offset = "0xDFD6D0", VA = "0xDFD6D0")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xDFD74C", Offset = "0xDFD74C", VA = "0xDFD74C", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xDFDB10", Offset = "0xDFDB10", VA = "0xDFDB10")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xDFDCAC", Offset = "0xDFDCAC", VA = "0xDFDCAC")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xDFDDC4", Offset = "0xDFDDC4", VA = "0xDFDDC4")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xDFE0E8", Offset = "0xDFE0E8", VA = "0xDFE0E8")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xDFE464", Offset = "0xDFE464", VA = "0xDFE464", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xDFE524", Offset = "0xDFE524", VA = "0xDFE524", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xDFE54C", Offset = "0xDFE54C", VA = "0xDFE54C")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class RayToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x40004ED")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x40004EE")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x170000C8")]
		public bool EnableState
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0xDFD2C8", Offset = "0xDFD2C8", VA = "0xDFD2C8", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000535")]
			[Address(RVA = "0xDFD300", Offset = "0xDFD300", VA = "0xDFD300", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public bool ToolActivateState
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0xDFE624", Offset = "0xDFE624", VA = "0xDFE624", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000537")]
			[Address(RVA = "0xDFD694", Offset = "0xDFD694", VA = "0xDFD694", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0xDFE82C", Offset = "0xDFE82C", VA = "0xDFE82C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600053A")]
			[Address(RVA = "0xDFE834", Offset = "0xDFE834", VA = "0xDFE834")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xDFE62C", Offset = "0xDFE62C", VA = "0xDFE62C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xDFE494", Offset = "0xDFE494", VA = "0xDFE494", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xDFE83C", Offset = "0xDFE83C", VA = "0xDFE83C")]
		private void Update()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xDFEAE8", Offset = "0xDFEAE8", VA = "0xDFEAE8")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xDFEB90", Offset = "0xDFEB90", VA = "0xDFEB90")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x170000CB")]
		public bool UseSpherecast
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0xDFEBE8", Offset = "0xDFEBE8", VA = "0xDFEBE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000540")]
			[Address(RVA = "0xDFEBF0", Offset = "0xDFEBF0", VA = "0xDFEBF0")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0xDFEC6C", Offset = "0xDFEC6C", VA = "0xDFEC6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000542")]
			[Address(RVA = "0xDFEC74", Offset = "0xDFEC74", VA = "0xDFEC74")]
			set
			{
			}
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xDFECD0", Offset = "0xDFECD0", VA = "0xDFECD0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xDFEF70", Offset = "0xDFEF70", VA = "0xDFEF70")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xDFEF80", Offset = "0xDFEF80", VA = "0xDFEF80")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xDFEF90", Offset = "0xDFEF90", VA = "0xDFEF90")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xDFEF98", Offset = "0xDFEF98", VA = "0xDFEF98")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xDFEF9C", Offset = "0xDFEF9C", VA = "0xDFEF9C")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xDFF008", Offset = "0xDFF008", VA = "0xDFF008")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xDFF098", Offset = "0xDFF098", VA = "0xDFF098")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xDFF128", Offset = "0xDFF128", VA = "0xDFF128")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xDFF1D4", Offset = "0xDFF1D4", VA = "0xDFF1D4")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xDFF2B0", Offset = "0xDFF2B0", VA = "0xDFF2B0")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xDFF2F4", Offset = "0xDFF2F4", VA = "0xDFF2F4")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xDFF354", Offset = "0xDFF354", VA = "0xDFF354")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xDFF3B4", Offset = "0xDFF3B4", VA = "0xDFF3B4")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xDFF3BC", Offset = "0xDFF3BC", VA = "0xDFF3BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xDFF3C0", Offset = "0xDFF3C0", VA = "0xDFF3C0")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xDFF384", Offset = "0xDFF384", VA = "0xDFF384")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xDFF3F4", Offset = "0xDFF3F4", VA = "0xDFF3F4")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x20000E6")]
		[CompilerGenerated]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x170000CD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600055D")]
				[Address(RVA = "0xDFFA3C", Offset = "0xDFFA3C", VA = "0xDFFA3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600055F")]
				[Address(RVA = "0xDFFA84", Offset = "0xDFFA84", VA = "0xDFFA84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0xDFF7C4", Offset = "0xDFF7C4", VA = "0xDFF7C4")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600055B")]
			[Address(RVA = "0xDFF88C", Offset = "0xDFF88C", VA = "0xDFF88C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0xDFF890", Offset = "0xDFF890", VA = "0xDFF890", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600055E")]
			[Address(RVA = "0xDFFA44", Offset = "0xDFFA44", VA = "0xDFFA44", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004FE")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x40004FF")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xDFF3FC", Offset = "0xDFF3FC", VA = "0xDFF3FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xDFF490", Offset = "0xDFF490", VA = "0xDFF490")]
		private void Update()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xDFF784", Offset = "0xDFF784", VA = "0xDFF784")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xDFF71C", Offset = "0xDFF71C", VA = "0xDFF71C")]
		[IteratorStateMachine(typeof(<LerpToHMD>d__13))]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xDFF7EC", Offset = "0xDFF7EC", VA = "0xDFF7EC")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x20000E8")]
		public enum SelectionState
		{
			[Token(Token = "0x4000515")]
			Off,
			[Token(Token = "0x4000516")]
			Selected,
			[Token(Token = "0x4000517")]
			Highlighted
		}

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x170000CF")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xDFFA8C", Offset = "0xDFFA8C", VA = "0xDFFA8C")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x6000561")]
			[Address(RVA = "0xDFFA94", Offset = "0xDFFA94", VA = "0xDFFA94")]
			set
			{
			}
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xDFFBE8", Offset = "0xDFFBE8", VA = "0xDFFBE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xDFFD70", Offset = "0xDFFD70", VA = "0xDFFD70")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xDFFB08", Offset = "0xDFFB08", VA = "0xDFFB08")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xDFFE38", Offset = "0xDFFE38", VA = "0xDFFE38")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x20000EA")]
		public enum SegmentType
		{
			[Token(Token = "0x4000526")]
			Straight,
			[Token(Token = "0x4000527")]
			LeftTurn,
			[Token(Token = "0x4000528")]
			RightTurn,
			[Token(Token = "0x4000529")]
			Switch
		}

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x400051E")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x400051F")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x170000D0")]
		public float StartDistance
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0xDFFEA8", Offset = "0xDFFEA8", VA = "0xDFFEA8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000568")]
			[Address(RVA = "0xDFFEB0", Offset = "0xDFFEB0", VA = "0xDFFEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public float GridSize
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0xDFFEB8", Offset = "0xDFFEB8", VA = "0xDFFEB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600056A")]
			[Address(RVA = "0xDFFEC0", Offset = "0xDFFEC0", VA = "0xDFFEC0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public int SubDivCount
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0xDFFEC8", Offset = "0xDFFEC8", VA = "0xDFFEC8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600056C")]
			[Address(RVA = "0xDFFED0", Offset = "0xDFFED0", VA = "0xDFFED0")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public SegmentType Type
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0xDFFED8", Offset = "0xDFFED8", VA = "0xDFFED8")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x170000D4")]
		public Pose EndPose
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0xDFFEE0", Offset = "0xDFFEE0", VA = "0xDFFEE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		public float Radius
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0xE002B4", Offset = "0xE002B4", VA = "0xE002B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D6")]
		public float SegmentLength
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0xDFFF3C", Offset = "0xDFFF3C", VA = "0xDFFF3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xE002C4", Offset = "0xE002C4", VA = "0xE002C4")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xE002DC", Offset = "0xE002DC", VA = "0xE002DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xDFFF7C", Offset = "0xDFFF7C", VA = "0xDFFF7C")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xE002E0", Offset = "0xE002E0", VA = "0xE002E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xE002E4", Offset = "0xE002E4", VA = "0xE002E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xE00340", Offset = "0xE00340", VA = "0xE00340")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xE00C74", Offset = "0xE00C74", VA = "0xE00C74")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xE00ECC", Offset = "0xE00ECC", VA = "0xE00ECC")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x20000EC")]
		[CompilerGenerated]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x170000D7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000587")]
				[Address(RVA = "0xE01984", Offset = "0xE01984", VA = "0xE01984", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000589")]
				[Address(RVA = "0xE019CC", Offset = "0xE019CC", VA = "0xE019CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0xE017C8", Offset = "0xE017C8", VA = "0xE017C8")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0xE01818", Offset = "0xE01818", VA = "0xE01818", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0xE0181C", Offset = "0xE0181C", VA = "0xE0181C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0xE0198C", Offset = "0xE0198C", VA = "0xE0198C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400052A")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x400052B")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xE01008", Offset = "0xE01008", VA = "0xE01008")]
		private void Awake()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xE010AC", Offset = "0xE010AC", VA = "0xE010AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xE0113C", Offset = "0xE0113C", VA = "0xE0113C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xE01284", Offset = "0xE01284", VA = "0xE01284")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xE01410", Offset = "0xE01410", VA = "0xE01410")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xE01520", Offset = "0xE01520", VA = "0xE01520")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xE0170C", Offset = "0xE0170C", VA = "0xE0170C")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xE01630", Offset = "0xE01630", VA = "0xE01630")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xE01644", Offset = "0xE01644", VA = "0xE01644")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xE01760", Offset = "0xE01760", VA = "0xE01760")]
		[IteratorStateMachine(typeof(<ResetPosition>d__26))]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xE017F0", Offset = "0xE017F0", VA = "0xE017F0")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x170000D9")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0xE019D4", Offset = "0xE019D4", VA = "0xE019D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xE019E4", Offset = "0xE019E4", VA = "0xE019E4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xE019EC", Offset = "0xE019EC", VA = "0xE019EC", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xE01D1C", Offset = "0xE01D1C", VA = "0xE01D1C")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x4000543")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x4000544")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x170000DA")]
		public float Distance
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0xE01E00", Offset = "0xE01E00", VA = "0xE01E00")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0xE01E08", Offset = "0xE01E08", VA = "0xE01E08")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public float Scale
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0xE01E10", Offset = "0xE01E10", VA = "0xE01E10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0xE01E18", Offset = "0xE01E18", VA = "0xE01E18")]
			set
			{
			}
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xE019E8", Offset = "0xE019E8", VA = "0xE019E8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xE01E20", Offset = "0xE01E20", VA = "0xE01E20")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xE01A28", Offset = "0xE01A28", VA = "0xE01A28")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xE01C38", Offset = "0xE01C38", VA = "0xE01C38")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x6000596")]
		public abstract void UpdatePosition();

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xE01D7C", Offset = "0xE01D7C", VA = "0xE01D7C")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x20000F0")]
		[CompilerGenerated]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x170000DC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005A5")]
				[Address(RVA = "0xE02668", Offset = "0xE02668", VA = "0xE02668", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005A7")]
				[Address(RVA = "0xE026B0", Offset = "0xE026B0", VA = "0xE026B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xE0232C", Offset = "0xE0232C", VA = "0xE0232C")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0xE024A0", Offset = "0xE024A0", VA = "0xE024A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0xE024A4", Offset = "0xE024A4", VA = "0xE024A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xE02670", Offset = "0xE02670", VA = "0xE02670", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xE01F90", Offset = "0xE01F90", VA = "0xE01F90")]
		private void Awake()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xE01FD0", Offset = "0xE01FD0", VA = "0xE01FD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xE020A8", Offset = "0xE020A8", VA = "0xE020A8")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xE021EC", Offset = "0xE021EC", VA = "0xE021EC")]
		private void Update()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xE02100", Offset = "0xE02100", VA = "0xE02100")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xE022B4", Offset = "0xE022B4", VA = "0xE022B4")]
		[IteratorStateMachine(typeof(<AnimateCrossing>d__15))]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xE02354", Offset = "0xE02354", VA = "0xE02354")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xE023EC", Offset = "0xE023EC", VA = "0xE023EC")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xE02448", Offset = "0xE02448", VA = "0xE02448")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x20000F2")]
		private enum EngineSoundState
		{
			[Token(Token = "0x4000581")]
			Start,
			[Token(Token = "0x4000582")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x4000583")]
			Stop
		}

		[Token(Token = "0x20000F3")]
		[CompilerGenerated]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005BA")]
				[Address(RVA = "0xE02F14", Offset = "0xE02F14", VA = "0xE02F14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0xE02F5C", Offset = "0xE02F5C", VA = "0xE02F5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xE02940", Offset = "0xE02940", VA = "0xE02940")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xE02D08", Offset = "0xE02D08", VA = "0xE02D08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xE02D0C", Offset = "0xE02D0C", VA = "0xE02D0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xE02F1C", Offset = "0xE02F1C", VA = "0xE02F1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000563")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x4000564")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x4000565")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x4000566")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Range(0.2f, 2.7f)]
		protected float _initialSpeed;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xE026B8", Offset = "0xE026B8", VA = "0xE026B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xE027FC", Offset = "0xE027FC", VA = "0xE027FC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xE02808", Offset = "0xE02808", VA = "0xE02808", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xDFEFCC", Offset = "0xDFEFCC", VA = "0xDFEFCC")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xE02780", Offset = "0xE02780", VA = "0xE02780")]
		[IteratorStateMachine(typeof(<StartStopTrain>d__34))]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xE02968", Offset = "0xE02968", VA = "0xE02968")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xE028E0", Offset = "0xE028E0", VA = "0xE028E0")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xDFF038", Offset = "0xDFF038", VA = "0xDFF038")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xDFF0C8", Offset = "0xDFF0C8", VA = "0xDFF0C8")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xE02B7C", Offset = "0xE02B7C", VA = "0xE02B7C")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xE02C70", Offset = "0xE02C70", VA = "0xE02C70")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xDFF158", Offset = "0xDFF158", VA = "0xDFF158")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xDFF204", Offset = "0xDFF204", VA = "0xDFF204")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xDFF2E4", Offset = "0xDFF2E4", VA = "0xDFF2E4")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xE02CAC", Offset = "0xE02CAC", VA = "0xE02CAC")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x170000E0")]
		public float TrackLength
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xE02F64", Offset = "0xE02F64", VA = "0xE02F64")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0xE02F6C", Offset = "0xE02F6C", VA = "0xE02F6C")]
			private set
			{
			}
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xE02F74", Offset = "0xE02F74", VA = "0xE02F74")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xE01E88", Offset = "0xE01E88", VA = "0xE01E88")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xE02F78", Offset = "0xE02F78", VA = "0xE02F78")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xE03164", Offset = "0xE03164", VA = "0xE03164")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xE03244", Offset = "0xE03244", VA = "0xE03244")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class Pose
	{
		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xE00F70", Offset = "0xE00F70", VA = "0xE00F70")]
		public Pose()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xE03260", Offset = "0xE03260", VA = "0xE03260")]
		public Pose(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x20000F7")]
		[CompilerGenerated]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x170000E2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005D2")]
				[Address(RVA = "0xE037EC", Offset = "0xE037EC", VA = "0xE037EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005D4")]
				[Address(RVA = "0xE03834", Offset = "0xE03834", VA = "0xE03834", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xE0351C", Offset = "0xE0351C", VA = "0xE0351C")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xE03668", Offset = "0xE03668", VA = "0xE03668", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xE0366C", Offset = "0xE0366C", VA = "0xE0366C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0xE037F4", Offset = "0xE037F4", VA = "0xE037F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F8")]
		[CompilerGenerated]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x170000E4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0xE03904", Offset = "0xE03904", VA = "0xE03904", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005DA")]
				[Address(RVA = "0xE0394C", Offset = "0xE0394C", VA = "0xE0394C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xE035D0", Offset = "0xE035D0", VA = "0xE035D0")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0xE0383C", Offset = "0xE0383C", VA = "0xE0383C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xE03840", Offset = "0xE03840", VA = "0xE03840", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xE0390C", Offset = "0xE0390C", VA = "0xE0390C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000596")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x170000E1")]
		public bool IsMoving
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xE032C4", Offset = "0xE032C4", VA = "0xE032C4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xE032CC", Offset = "0xE032CC", VA = "0xE032CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xE032D8", Offset = "0xE032D8", VA = "0xE032D8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xE03308", Offset = "0xE03308", VA = "0xE03308")]
		private void Update()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xE03448", Offset = "0xE03448", VA = "0xE03448")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xE034A4", Offset = "0xE034A4", VA = "0xE034A4")]
		[IteratorStateMachine(typeof(<LerpToSpeed>d__17))]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xE03544", Offset = "0xE03544", VA = "0xE03544")]
		[IteratorStateMachine(typeof(<PlaySoundDelayed>d__18))]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xE035F8", Offset = "0xE035F8", VA = "0xE035F8")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xE03660", Offset = "0xE03660", VA = "0xE03660")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xE03954", Offset = "0xE03954", VA = "0xE03954")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xE039B4", Offset = "0xE039B4", VA = "0xE039B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xE03A7C", Offset = "0xE03A7C", VA = "0xE03A7C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xE03B8C", Offset = "0xE03B8C", VA = "0xE03B8C")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xE03C04", Offset = "0xE03C04", VA = "0xE03C04")]
		private void Update()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xE03CCC", Offset = "0xE03CCC", VA = "0xE03CCC")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public enum EUiDisplayType
	{
		[Token(Token = "0x40005B3")]
		EUDT_WorldGeoQuad,
		[Token(Token = "0x40005B4")]
		EUDT_OverlayQuad,
		[Token(Token = "0x40005B5")]
		EUDT_None,
		[Token(Token = "0x40005B6")]
		EUDT_MaxDislayTypes
	}
	[Token(Token = "0x20000FB")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x20000FC")]
		[CompilerGenerated]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x170000E6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005F4")]
				[Address(RVA = "0xE052D0", Offset = "0xE052D0", VA = "0xE052D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0xE05318", Offset = "0xE05318", VA = "0xE05318", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xE04994", Offset = "0xE04994", VA = "0xE04994")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xE050F0", Offset = "0xE050F0", VA = "0xE050F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xE050F4", Offset = "0xE050F4", VA = "0xE050F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xE052D8", Offset = "0xE052D8", VA = "0xE052D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x40005B8")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x40005B9")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x40005BA")]
		private const string noneID = "NoneID";

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("App vs Compositor Comparison Settings")]
		public GameObject mainCamera;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Level Loading Sim Settings")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xE03CDC", Offset = "0xE03CDC", VA = "0xE03CDC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xE044F8", Offset = "0xE044F8", VA = "0xE044F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xE04620", Offset = "0xE04620", VA = "0xE04620")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xE0473C", Offset = "0xE0473C", VA = "0xE0473C")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xE04858", Offset = "0xE04858", VA = "0xE04858")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xE04600", Offset = "0xE04600", VA = "0xE04600")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xE0492C", Offset = "0xE0492C", VA = "0xE0492C")]
		[IteratorStateMachine(typeof(<WaitforOVROverlay>d__30))]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xE049BC", Offset = "0xE049BC", VA = "0xE049BC")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xE04134", Offset = "0xE04134", VA = "0xE04134")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xE04B04", Offset = "0xE04B04", VA = "0xE04B04")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xE049E4", Offset = "0xE049E4", VA = "0xE049E4")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xE04E80", Offset = "0xE04E80", VA = "0xE04E80")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xE04F6C", Offset = "0xE04F6C", VA = "0xE04F6C")]
		public OVROverlaySample()
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x20000FD")]
	[RequireComponent(typeof(OVRGrabber))]
	public class Hand : MonoBehaviour
	{
		[Token(Token = "0x40005D2")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x40005D3")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x40005D4")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x40005D5")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x40005D6")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x40005D7")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x40005D8")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x40005D9")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x40005DA")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x40005DB")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x40005DC")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xE05320", Offset = "0xE05320", VA = "0xE05320")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xE05370", Offset = "0xE05370", VA = "0xE05370")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xE057A0", Offset = "0xE057A0", VA = "0xE057A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xE0588C", Offset = "0xE0588C", VA = "0xE0588C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xE059F0", Offset = "0xE059F0", VA = "0xE059F0")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xE05CC0", Offset = "0xE05CC0", VA = "0xE05CC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xE05DA4", Offset = "0xE05DA4", VA = "0xE05DA4")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xE05F4C", Offset = "0xE05F4C", VA = "0xE05F4C")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xE05A7C", Offset = "0xE05A7C", VA = "0xE05A7C")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xE05AD0", Offset = "0xE05AD0", VA = "0xE05AD0")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xE05660", Offset = "0xE05660", VA = "0xE05660")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xE06070", Offset = "0xE06070", VA = "0xE06070")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public enum HandPoseId
	{
		[Token(Token = "0x40005F1")]
		Default,
		[Token(Token = "0x40005F2")]
		Generic,
		[Token(Token = "0x40005F3")]
		PingPongBall,
		[Token(Token = "0x40005F4")]
		Controller
	}
	[Token(Token = "0x2000100")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x170000E8")]
		public bool AllowPointing
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0xE0611C", Offset = "0xE0611C", VA = "0xE0611C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E9")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0xE06124", Offset = "0xE06124", VA = "0xE06124")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EA")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0xE0612C", Offset = "0xE0612C", VA = "0xE0612C")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xE06134", Offset = "0xE06134", VA = "0xE06134")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xE0613C", Offset = "0xE0613C", VA = "0xE0613C")]
		private void Update()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xE06408", Offset = "0xE06408", VA = "0xE06408")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xE06458", Offset = "0xE06458", VA = "0xE06458")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xE06490", Offset = "0xE06490", VA = "0xE06490")]
		public TouchController()
		{
		}
	}
}
namespace PathCreation.Examples
{
	[Token(Token = "0x2000102")]
	[RequireComponent(typeof(PathCreator))]
	public class GeneratePathExample : MonoBehaviour
	{
		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool closedLoop;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform[] waypoints;

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xE06498", Offset = "0xE06498", VA = "0xE06498")]
		private void Start()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xE0655C", Offset = "0xE0655C", VA = "0xE0655C")]
		public GeneratePathExample()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class PathFollower : MonoBehaviour
	{
		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PathCreator pathCreator;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EndOfPathInstruction endOfPathInstruction;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float distanceTravelled;

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xE0656C", Offset = "0xE0656C", VA = "0xE0656C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xE06640", Offset = "0xE06640", VA = "0xE06640")]
		private void Update()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xE06768", Offset = "0xE06768", VA = "0xE06768")]
		private void OnPathChanged()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xE067C4", Offset = "0xE067C4", VA = "0xE067C4")]
		public PathFollower()
		{
		}
	}
	[Token(Token = "0x2000104")]
	[ExecuteInEditMode]
	public class PathPlacer : PathSceneTool
	{
		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject prefab;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject holder;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float spacing;

		[Token(Token = "0x4000604")]
		private const float minSpacing = 0.1f;

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xE067D4", Offset = "0xE067D4", VA = "0xE067D4")]
		private void Generate()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xE069C8", Offset = "0xE069C8", VA = "0xE069C8")]
		private void DestroyObjects()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xE06A94", Offset = "0xE06A94", VA = "0xE06A94", Slot = "5")]
		protected override void PathUpdated()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xE06B0C", Offset = "0xE06B0C", VA = "0xE06B0C")]
		public PathPlacer()
		{
		}
	}
	[Token(Token = "0x2000105")]
	[ExecuteInEditMode]
	public abstract class PathSceneTool : MonoBehaviour
	{
		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PathCreator pathCreator;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoUpdate;

		[Token(Token = "0x170000EB")]
		protected VertexPath path
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0xE06C6C", Offset = "0xE06C6C", VA = "0xE06C6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000013")]
		public event Action onDestroyed
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0xE06B34", Offset = "0xE06B34", VA = "0xE06B34")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000619")]
			[Address(RVA = "0xE06BD0", Offset = "0xE06BD0", VA = "0xE06BD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xE06C88", Offset = "0xE06C88", VA = "0xE06C88")]
		public void TriggerUpdate()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xE06C94", Offset = "0xE06C94", VA = "0xE06C94", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600061D")]
		protected abstract void PathUpdated();

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xE06B24", Offset = "0xE06B24", VA = "0xE06B24")]
		protected PathSceneTool()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class PathSpawner : MonoBehaviour
	{
		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PathCreator pathPrefab;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PathFollower followerPrefab;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform[] spawnPoints;

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xE06CB0", Offset = "0xE06CB0", VA = "0xE06CB0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xE06E40", Offset = "0xE06E40", VA = "0xE06E40")]
		public PathSpawner()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class RoadMeshCreator : PathSceneTool
	{
		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Header("Road settings")]
		public float roadWidth;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 0.5f)]
		public float thickness;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool flattenSurface;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Material settings")]
		public Material roadMaterial;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Material undersideMaterial;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float textureTiling;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private GameObject meshHolder;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshFilter meshFilter;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshRenderer meshRenderer;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Mesh mesh;

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xE06E48", Offset = "0xE06E48", VA = "0xE06E48", Slot = "5")]
		protected override void PathUpdated()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xE073E8", Offset = "0xE073E8", VA = "0xE073E8")]
		private void CreateRoadMesh()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xE06ED0", Offset = "0xE06ED0", VA = "0xE06ED0")]
		private void AssignMeshComponents()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xE0723C", Offset = "0xE0723C", VA = "0xE0723C")]
		private void AssignMaterials()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xE07D4C", Offset = "0xE07D4C", VA = "0xE07D4C")]
		public RoadMeshCreator()
		{
		}
	}
}
namespace Michsky.UI.Shift
{
	[Token(Token = "0x2000108")]
	public class ChapterButton : MonoBehaviour
	{
		[Token(Token = "0x2000109")]
		public enum StatusItem
		{
			[Token(Token = "0x4000622")]
			NONE,
			[Token(Token = "0x4000623")]
			LOCKED,
			[Token(Token = "0x4000624")]
			COMPLETED
		}

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public Sprite backgroundImage;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string buttonTitle;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[TextArea]
		public string buttonDescription;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("SETTINGS")]
		public bool useCustomResources;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[Header("STATUS")]
		public bool enableStatus;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public StatusItem statusItem;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Image backgroundImageObj;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI titleObj;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI descriptionObj;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform statusNone;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform statusLocked;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform statusCompleted;

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xE07D70", Offset = "0xE07D70", VA = "0xE07D70")]
		private void Start()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xE0811C", Offset = "0xE0811C", VA = "0xE0811C")]
		public ChapterButton()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class FavoriteButton : MonoBehaviour
	{
		[Token(Token = "0x200010B")]
		public enum FavoriteItem
		{
			[Token(Token = "0x400062A")]
			FALSE,
			[Token(Token = "0x400062B")]
			TRUE
		}

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("SETTINGS")]
		public FavoriteItem isFavorite;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Image iconObj;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Image iconFilledObj;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Button mainButton;

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xE08190", Offset = "0xE08190", VA = "0xE08190")]
		private void Start()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xE083EC", Offset = "0xE083EC", VA = "0xE083EC")]
		public void ClickEvents()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xE08364", Offset = "0xE08364", VA = "0xE08364")]
		public void UpdateUI()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xE08400", Offset = "0xE08400", VA = "0xE08400")]
		public FavoriteButton()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class MainButton : MonoBehaviour
	{
		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("SETTINGS")]
		public string buttonText;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useCustomText;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProUGUI normalText;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI highlightedText;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI pressedText;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xE08408", Offset = "0xE08408", VA = "0xE08408")]
		private void Start()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xE08598", Offset = "0xE08598", VA = "0xE08598")]
		public MainButton()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class MainPanelButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("TEXT")]
		public bool useCustomText;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string buttonText;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("ICON")]
		public bool hasIcon;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Sprite iconSprite;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator buttonAnimator;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI normalText;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI highlightedText;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI pressedText;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image normalIcon;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image highlightedIcon;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image pressedIcon;

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xE085E8", Offset = "0xE085E8", VA = "0xE085E8")]
		private void Start()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xE08B00", Offset = "0xE08B00", VA = "0xE08B00", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xE08BC0", Offset = "0xE08BC0", VA = "0xE08BC0", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xE08C80", Offset = "0xE08C80", VA = "0xE08C80")]
		public MainPanelButton()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class QuickMatchButton : MonoBehaviour
	{
		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("TEXTS")]
		public bool useCustomText;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string buttonTitle;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("IMAGES")]
		public bool useCustomImage;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Sprite backgroundImage;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI titleText;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image image1;

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xE08CD0", Offset = "0xE08CD0", VA = "0xE08CD0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xE08E00", Offset = "0xE08E00", VA = "0xE08E00")]
		public QuickMatchButton()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class SettingsButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public Image detailImage;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image detailIcon;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image detailBackground;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI detailTitle;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI detailDescription;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI buttonTitleObj;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("CONTENT")]
		public string buttonTitle;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("PREVIEW")]
		public string title;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[TextArea]
		public string description;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool enableIconPreview;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Sprite imageSprite;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Sprite iconSprite;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Sprite iconBackground;

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xE08E50", Offset = "0xE08E50", VA = "0xE08E50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xE08E7C", Offset = "0xE08E7C", VA = "0xE08E7C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xE08FBC", Offset = "0xE08FBC", VA = "0xE08FBC", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xE08FC0", Offset = "0xE08FC0", VA = "0xE08FC0")]
		public SettingsButton()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class ShortcutButton : MonoBehaviour
	{
		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public string keyText;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string buttonText;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("SETTINGS")]
		public bool useCustomText;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isGamepad;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI normalText;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI highlightedText;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI normalKeyText;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI highlightedKeyText;

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xE08FC8", Offset = "0xE08FC8", VA = "0xE08FC8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xE0921C", Offset = "0xE0921C", VA = "0xE0921C")]
		public ShortcutButton()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class SpotlightButton : MonoBehaviour
	{
		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("TEXTS")]
		public bool useCustomText;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string buttonTitle;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string buttonDescription;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("IMAGES")]
		public bool useCustomImage;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Sprite firstImage;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Sprite secondImage;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI titleText;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI descriptionText;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image image1;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image image2;

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xE09290", Offset = "0xE09290", VA = "0xE09290")]
		private void Start()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xE09498", Offset = "0xE09498", VA = "0xE09498")]
		public SpotlightButton()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class HoldKeyEvent : MonoBehaviour
	{
		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("KEY")]
		[SerializeField]
		public KeyCode hotkey;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("KEY ACTION")]
		[SerializeField]
		public UnityEvent holdAction;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public UnityEvent releaseAction;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isOn;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isHolding;

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xE0950C", Offset = "0xE0950C", VA = "0xE0950C")]
		private void Update()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xE09570", Offset = "0xE09570", VA = "0xE09570")]
		public HoldKeyEvent()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class PointerEnterEvents : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("EVENTS")]
		public UnityEvent enterEvent;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent exitEvent;

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xE09578", Offset = "0xE09578", VA = "0xE09578", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xE09594", Offset = "0xE09594", VA = "0xE09594", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xE095B0", Offset = "0xE095B0", VA = "0xE095B0")]
		public PointerEnterEvents()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class PressKeyEvent : MonoBehaviour
	{
		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("KEY")]
		[SerializeField]
		public KeyCode hotkey;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool pressAnyKey;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool invokeAtStart;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("KEY ACTION")]
		[SerializeField]
		public UnityEvent pressAction;

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xE095B8", Offset = "0xE095B8", VA = "0xE095B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xE095E4", Offset = "0xE095E4", VA = "0xE095E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xE09630", Offset = "0xE09630", VA = "0xE09630")]
		public PressKeyEvent()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class TimedEvent : MonoBehaviour
	{
		[Token(Token = "0x2000116")]
		[CompilerGenerated]
		private sealed class <TimedEventStart>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TimedEvent <>4__this;

			[Token(Token = "0x170000EC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600064C")]
				[Address(RVA = "0xE09890", Offset = "0xE09890", VA = "0xE09890", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000ED")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600064E")]
				[Address(RVA = "0xE098D8", Offset = "0xE098D8", VA = "0xE098D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0xE09700", Offset = "0xE09700", VA = "0xE09700")]
			[DebuggerHidden]
			public <TimedEventStart>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0xE097D0", Offset = "0xE097D0", VA = "0xE097D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0xE097D4", Offset = "0xE097D4", VA = "0xE097D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0xE09898", Offset = "0xE09898", VA = "0xE09898", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("TIMING (SECONDS)")]
		public float timer;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool enableAtStart;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("TIMER EVENT")]
		public UnityEvent timerAction;

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xE09638", Offset = "0xE09638", VA = "0xE09638")]
		private void Start()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xE09698", Offset = "0xE09698", VA = "0xE09698")]
		[IteratorStateMachine(typeof(<TimedEventStart>d__4))]
		private IEnumerator TimedEventStart()
		{
			return null;
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xE09728", Offset = "0xE09728", VA = "0xE09728")]
		public void StartIEnumerator()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xE09774", Offset = "0xE09774", VA = "0xE09774")]
		public void StopIEnumerator()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xE097C0", Offset = "0xE097C0", VA = "0xE097C0")]
		public TimedEvent()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class LayoutGroupPositionFix : MonoBehaviour
	{
		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool forceRect;

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xE098E0", Offset = "0xE098E0", VA = "0xE098E0")]
		public void FixPos()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xE09A20", Offset = "0xE09A20", VA = "0xE09A20")]
		public LayoutGroupPositionFix()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class UIElementInFront : MonoBehaviour
	{
		[Token(Token = "0x6000651")]
		[Address(RVA = "0xE09A30", Offset = "0xE09A30", VA = "0xE09A30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xE09A50", Offset = "0xE09A50", VA = "0xE09A50")]
		public UIElementInFront()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class GamepadChecker : MonoBehaviour
	{
		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public VirtualCursor virtualCursor;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject eventSystem;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("OBJECTS")]
		[Tooltip("Objects in this list will be active when gamepad is un-plugged.")]
		public List<GameObject> keyboardObjects;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Objects in this list will be active when gamepad is plugged.")]
		public List<GameObject> gamepadObjects;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Always update input device. If you turn off this feature, you won't able to change the input device after start, but it might increase the performance.")]
		[Header("SETTINGS")]
		public bool alwaysSearch;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GamepadChecker checkerScript;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int gamepadConnected;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 startMousePos;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 startPos;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool gamepadEnabled;

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xE09A58", Offset = "0xE09A58", VA = "0xE09A58")]
		private void Start()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xE0A180", Offset = "0xE0A180", VA = "0xE0A180")]
		private void Update()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xE09EB4", Offset = "0xE09EB4", VA = "0xE09EB4")]
		public void SwitchToController()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xE0A01C", Offset = "0xE0A01C", VA = "0xE0A01C")]
		public void SwitchToKeyboard()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xE0A21C", Offset = "0xE0A21C", VA = "0xE0A21C")]
		public GamepadChecker()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class ScrollGamepadManager : MonoBehaviour
	{
		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("SETTINGS")]
		public float changeValue;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Scrollbar scrollbarObject;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("INPUT")]
		public string inputAxis;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool invertAxis;

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xE0A2C4", Offset = "0xE0A2C4", VA = "0xE0A2C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xE0A3C8", Offset = "0xE0A3C8", VA = "0xE0A3C8")]
		private void Update()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xE0A4CC", Offset = "0xE0A4CC", VA = "0xE0A4CC")]
		public ScrollGamepadManager()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class SliderGamepadManager : MonoBehaviour
	{
		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("SLIDER")]
		public float changeValue;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Slider sliderObject;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("INPUT")]
		public string horizontalAxis;

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xE0A528", Offset = "0xE0A528", VA = "0xE0A528")]
		private void Start()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xE0A62C", Offset = "0xE0A62C", VA = "0xE0A62C")]
		private void Update()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xE0A730", Offset = "0xE0A730", VA = "0xE0A730")]
		public SliderGamepadManager()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class VirtualCursor : PointerInputModule
	{
		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("OBJECTS")]
		public RectTransform border;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject cursorObject;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("INPUT")]
		public EventSystem vEventSystem;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string horizontalAxis;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string verticalAxis;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Header("SETTINGS")]
		[Range(100f, 10000f)]
		public float speed;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private PointerEventData pointer;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Animator cursorAnim;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector2 cursorPos;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RectTransform cursorObj;

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xE0A788", Offset = "0xE0A788", VA = "0xE0A788")]
		public new void Start()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xE0A844", Offset = "0xE0A844", VA = "0xE0A844")]
		public void AnimateCursorIn()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xE0A8C0", Offset = "0xE0A8C0", VA = "0xE0A8C0")]
		public void AnimateCursorOut()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xE0A93C", Offset = "0xE0A93C", VA = "0xE0A93C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xE0AAC0", Offset = "0xE0AAC0", VA = "0xE0AAC0", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xE0AD54", Offset = "0xE0AD54", VA = "0xE0AD54")]
		public VirtualCursor()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class VirtualCursorAnimate : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public VirtualCursor virtualCursor;

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xE0ADD0", Offset = "0xE0ADD0", VA = "0xE0ADD0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xE0AFF8", Offset = "0xE0AFF8", VA = "0xE0AFF8", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xE0B078", Offset = "0xE0B078", VA = "0xE0B078", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xE0B0F8", Offset = "0xE0B0F8", VA = "0xE0B0F8")]
		public VirtualCursorAnimate()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class CanvasManager : MonoBehaviour
	{
		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CanvasScaler canvasScaler;

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xE0B100", Offset = "0xE0B100", VA = "0xE0B100")]
		private void Start()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xE0B19C", Offset = "0xE0B19C", VA = "0xE0B19C")]
		public void ScaleCanvas(int scale = 1080)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xE0B1C0", Offset = "0xE0B1C0", VA = "0xE0B1C0")]
		public CanvasManager()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class ExitToSystem : MonoBehaviour
	{
		[Token(Token = "0x600066B")]
		[Address(RVA = "0xE0B1C8", Offset = "0xE0B1C8", VA = "0xE0B1C8")]
		public void ExitGame()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xE0B238", Offset = "0xE0B238", VA = "0xE0B238")]
		public ExitToSystem()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class LaunchURL : MonoBehaviour
	{
		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string URL;

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xE0B240", Offset = "0xE0B240", VA = "0xE0B240")]
		public void GoToURL()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xE0B24C", Offset = "0xE0B24C", VA = "0xE0B24C")]
		public LaunchURL()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class QualityManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000122")]
		public class DynamicRes : UnityEvent<int>
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0xE0C6A4", Offset = "0xE0C6A4", VA = "0xE0C6A4")]
			public DynamicRes()
			{
			}
		}

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("AUDIO")]
		public AudioMixer mixer;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SliderManager masterSlider;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SliderManager musicSlider;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SliderManager sfxSlider;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("RESOLUTION")]
		public bool preferSelector;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public HorizontalSelector resolutionSelector;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TMP_Dropdown resolutionDropdown;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public DynamicRes clickEvent;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Resolution[] resolutions;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<string> options;

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xE0B254", Offset = "0xE0B254", VA = "0xE0B254")]
		private void Start()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xE0C2B0", Offset = "0xE0C2B0", VA = "0xE0C2B0")]
		public void UpdateResolution()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xE0C30C", Offset = "0xE0C30C", VA = "0xE0C30C")]
		public void SetResolution(int resolutionIndex)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xE0C3A4", Offset = "0xE0C3A4", VA = "0xE0C3A4")]
		public void AnisotrpicFilteringEnable()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xE0C3B0", Offset = "0xE0C3B0", VA = "0xE0C3B0")]
		public void AnisotrpicFilteringDisable()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xE0C3BC", Offset = "0xE0C3BC", VA = "0xE0C3BC")]
		public void AntiAlisasingSet(int index)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xE0C3C8", Offset = "0xE0C3C8", VA = "0xE0C3C8")]
		public void VsyncSet(int index)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xE0C3D4", Offset = "0xE0C3D4", VA = "0xE0C3D4")]
		public void ShadowResolutionSet(int index)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xE0C3EC", Offset = "0xE0C3EC", VA = "0xE0C3EC")]
		public void ShadowsSet(int index)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xE0C40C", Offset = "0xE0C40C", VA = "0xE0C40C")]
		public void ShadowsCascasedSet(int index)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xE0C418", Offset = "0xE0C418", VA = "0xE0C418")]
		public void TextureSet(int index)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xE0C424", Offset = "0xE0C424", VA = "0xE0C424")]
		public void SoftParticleSet(int index)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xE0C448", Offset = "0xE0C448", VA = "0xE0C448")]
		public void ReflectionSet(int index)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xE0C46C", Offset = "0xE0C46C", VA = "0xE0C46C")]
		public void VolumeSetMaster(float volume)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xE0C4E0", Offset = "0xE0C4E0", VA = "0xE0C4E0")]
		public void VolumeSetMusic(float volume)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xE0C554", Offset = "0xE0C554", VA = "0xE0C554")]
		public void VolumeSetSFX(float volume)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xE0C5C8", Offset = "0xE0C5C8", VA = "0xE0C5C8")]
		public void SetOverallQuality(int qualityIndex)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xE0C5D4", Offset = "0xE0C5D4", VA = "0xE0C5D4")]
		public void WindowFullscreen()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xE0C5F4", Offset = "0xE0C5F4", VA = "0xE0C5F4")]
		public void WindowBorderless()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xE0C600", Offset = "0xE0C600", VA = "0xE0C600")]
		public void WindowWindowed()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xE0C620", Offset = "0xE0C620", VA = "0xE0C620")]
		public QualityManager()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class ScrollForMore : MonoBehaviour
	{
		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public Scrollbar listScrollbar;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator SFMAnimator;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("SETTINGS")]
		public float fadeOutValue;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool invertValue;

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xE0C6EC", Offset = "0xE0C6EC", VA = "0xE0C6EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xE0C750", Offset = "0xE0C750", VA = "0xE0C750")]
		public void CheckValue()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xE0C8F8", Offset = "0xE0C8F8", VA = "0xE0C8F8")]
		public ScrollForMore()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class FriendsPanelManager : MonoBehaviour
	{
		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator windowAnimator;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isOn;

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xE0C900", Offset = "0xE0C900", VA = "0xE0C900")]
		private void Start()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xE0C960", Offset = "0xE0C960", VA = "0xE0C960")]
		public void AnimateWindow()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xE0C9E8", Offset = "0xE0C9E8", VA = "0xE0C9E8")]
		public void WindowIn()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xE0CA58", Offset = "0xE0CA58", VA = "0xE0CA58")]
		public void WindowOut()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xE0CAC4", Offset = "0xE0CAC4", VA = "0xE0CAC4")]
		public FriendsPanelManager()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class MainPanelButtonParent : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Animator> mainButtons;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Animator buttonAnimator;

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xE0CACC", Offset = "0xE0CACC", VA = "0xE0CACC")]
		private void Start()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xE0CE70", Offset = "0xE0CE70", VA = "0xE0CE70", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xE0CF94", Offset = "0xE0CF94", VA = "0xE0CF94", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xE0D0B8", Offset = "0xE0D0B8", VA = "0xE0D0B8")]
		public MainPanelButtonParent()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class MainPanelManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000127")]
		public class PanelItem
		{
			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string panelName;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject panelObject;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject buttonObject;

			[Token(Token = "0x6000699")]
			[Address(RVA = "0xE0DC74", Offset = "0xE0DC74", VA = "0xE0DC74")]
			public PanelItem()
			{
			}
		}

		[Token(Token = "0x2000128")]
		[CompilerGenerated]
		private sealed class <DisablePreviousPanel>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MainPanelManager <>4__this;

			[Token(Token = "0x170000EE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600069D")]
				[Address(RVA = "0xE0DD30", Offset = "0xE0DD30", VA = "0xE0DD30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600069F")]
				[Address(RVA = "0xE0DD78", Offset = "0xE0DD78", VA = "0xE0DD78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0xE0DB08", Offset = "0xE0DB08", VA = "0xE0DB08")]
			[DebuggerHidden]
			public <DisablePreviousPanel>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0xE0DC7C", Offset = "0xE0DC7C", VA = "0xE0DC7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0xE0DC80", Offset = "0xE0DC80", VA = "0xE0DC80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0xE0DD38", Offset = "0xE0DD38", VA = "0xE0DD38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("PANEL LIST")]
		public List<PanelItem> panels;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("SETTINGS")]
		public bool settingsHelper;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int currentPanelIndex;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int currentButtonIndex;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int newPanelIndex;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject currentPanel;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject nextPanel;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject currentButton;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject nextButton;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Animator currentPanelAnimator;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animator nextPanelAnimator;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator currentButtonAnimator;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Animator nextButtonAnimator;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string panelFadeIn;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string panelFadeOut;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string panelFadeOutHelper;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string buttonFadeIn;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string buttonFadeOut;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string buttonFadeNormal;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool firstTime;

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xE0D134", Offset = "0xE0D134", VA = "0xE0D134")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xE0D22C", Offset = "0xE0D22C", VA = "0xE0D22C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xE0D368", Offset = "0xE0D368", VA = "0xE0D368")]
		public void OpenFirstTab()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xE0D418", Offset = "0xE0D418", VA = "0xE0D418")]
		public void OpenPanel(string newPanel)
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xE0D67C", Offset = "0xE0D67C", VA = "0xE0D67C")]
		public void NextPage()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xE0D89C", Offset = "0xE0D89C", VA = "0xE0D89C")]
		public void PrevPage()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xE0DAA0", Offset = "0xE0DAA0", VA = "0xE0DAA0")]
		[IteratorStateMachine(typeof(<DisablePreviousPanel>d__27))]
		private IEnumerator DisablePreviousPanel()
		{
			return null;
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xE0DB30", Offset = "0xE0DB30", VA = "0xE0DB30")]
		public MainPanelManager()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class ModalWindowManager : MonoBehaviour
	{
		[Token(Token = "0x200012A")]
		[CompilerGenerated]
		private sealed class <DisableWindow>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ModalWindowManager <>4__this;

			[Token(Token = "0x170000F0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006A8")]
				[Address(RVA = "0xE0E158", Offset = "0xE0E158", VA = "0xE0E158", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006AA")]
				[Address(RVA = "0xE0E1A0", Offset = "0xE0E1A0", VA = "0xE0E1A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xE0E004", Offset = "0xE0E004", VA = "0xE0E004")]
			[DebuggerHidden]
			public <DisableWindow>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xE0E0A0", Offset = "0xE0E0A0", VA = "0xE0E0A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xE0E0A4", Offset = "0xE0E0A4", VA = "0xE0E0A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0xE0E160", Offset = "0xE0E160", VA = "0xE0E160", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public TextMeshProUGUI windowTitle;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI windowDescription;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("SETTINGS")]
		public bool sharpAnimations;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool useCustomTexts;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string titleText;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[TextArea]
		public string descriptionText;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator mWindowAnimator;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool isOn;

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xE0DD80", Offset = "0xE0DD80", VA = "0xE0DD80")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xE0DE38", Offset = "0xE0DE38", VA = "0xE0DE38")]
		public void ModalWindowIn()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xE0DEFC", Offset = "0xE0DEFC", VA = "0xE0DEFC")]
		public void ModalWindowOut()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xE0DF9C", Offset = "0xE0DF9C", VA = "0xE0DF9C")]
		[IteratorStateMachine(typeof(<DisableWindow>d__11))]
		private IEnumerator DisableWindow()
		{
			return null;
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xE0E02C", Offset = "0xE0E02C", VA = "0xE0E02C")]
		public ModalWindowManager()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class ServerBrowserManager : MonoBehaviour
	{
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator mWindowAnimator;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isOn;

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xE0E1A8", Offset = "0xE0E1A8", VA = "0xE0E1A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xE0E208", Offset = "0xE0E208", VA = "0xE0E208")]
		public void ManageServerList()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xE0E298", Offset = "0xE0E298", VA = "0xE0E298")]
		public void ExpandServerList()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xE0E304", Offset = "0xE0E304", VA = "0xE0E304")]
		public void MinimizeServerList()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xE0E374", Offset = "0xE0E374", VA = "0xE0E374")]
		public ServerBrowserManager()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class SplashScreenManager : MonoBehaviour
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public GameObject splashScreen;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject mainPanels;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator splashScreenAnimator;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator mainPanelsAnimator;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TimedEvent ssTimedEvent;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("SETTINGS")]
		public bool disableSplashScreen;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool enablePressAnyKeyScreen;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool enableLoginScreen;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MainPanelManager mpm;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xE0E37C", Offset = "0xE0E37C", VA = "0xE0E37C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xE0E62C", Offset = "0xE0E62C", VA = "0xE0E62C")]
		public void LoginScreenCheck()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xE0E6F8", Offset = "0xE0E6F8", VA = "0xE0E6F8")]
		public SplashScreenManager()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class BlurManager : MonoBehaviour
	{
		[Token(Token = "0x200012E")]
		[CompilerGenerated]
		private sealed class <BlurIn>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BlurManager <>4__this;

			[Token(Token = "0x170000F2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006BD")]
				[Address(RVA = "0xE0EAE0", Offset = "0xE0EAE0", VA = "0xE0EAE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006BF")]
				[Address(RVA = "0xE0EB28", Offset = "0xE0EB28", VA = "0xE0EB28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0xE0E7CC", Offset = "0xE0E7CC", VA = "0xE0E7CC")]
			[DebuggerHidden]
			public <BlurIn>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0xE0E9D8", Offset = "0xE0E9D8", VA = "0xE0E9D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xE0E9DC", Offset = "0xE0E9DC", VA = "0xE0E9DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xE0EAE8", Offset = "0xE0EAE8", VA = "0xE0EAE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200012F")]
		[CompilerGenerated]
		private sealed class <BlurOut>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BlurManager <>4__this;

			[Token(Token = "0x170000F4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006C3")]
				[Address(RVA = "0xE0EC30", Offset = "0xE0EC30", VA = "0xE0EC30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006C5")]
				[Address(RVA = "0xE0EC78", Offset = "0xE0EC78", VA = "0xE0EC78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0xE0E85C", Offset = "0xE0E85C", VA = "0xE0E85C")]
			[DebuggerHidden]
			public <BlurOut>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0xE0EB30", Offset = "0xE0EB30", VA = "0xE0EB30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0xE0EB34", Offset = "0xE0EB34", VA = "0xE0EB34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0xE0EC38", Offset = "0xE0EC38", VA = "0xE0EC38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public Material blurMaterial;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("SETTINGS")]
		[Range(0f, 10f)]
		public float blurValue;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0.1f, 50f)]
		public float animationSpeed;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string customProperty;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float currentBlurValue;

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xE0E700", Offset = "0xE0E700", VA = "0xE0E700")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xE0E764", Offset = "0xE0E764", VA = "0xE0E764")]
		[IteratorStateMachine(typeof(<BlurIn>d__6))]
		private IEnumerator BlurIn()
		{
			return null;
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xE0E7F4", Offset = "0xE0E7F4", VA = "0xE0E7F4")]
		[IteratorStateMachine(typeof(<BlurOut>d__7))]
		private IEnumerator BlurOut()
		{
			return null;
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xE0E884", Offset = "0xE0E884", VA = "0xE0E884")]
		public void BlurInAnim()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xE0E8FC", Offset = "0xE0E8FC", VA = "0xE0E8FC")]
		public void BlurOutAnim()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xE0E974", Offset = "0xE0E974", VA = "0xE0E974")]
		public void SetBlurValue(float cbv)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xE0E97C", Offset = "0xE0E97C", VA = "0xE0E97C")]
		public BlurManager()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class GradientEffect : BaseMeshEffect
	{
		[Token(Token = "0x2000131")]
		public enum Direction
		{
			[Token(Token = "0x40006EB")]
			Horizontal,
			[Token(Token = "0x40006EC")]
			Vertical,
			[Token(Token = "0x40006ED")]
			Angle,
			[Token(Token = "0x40006EE")]
			Diagonal
		}

		[Token(Token = "0x2000132")]
		public enum GradientStyle
		{
			[Token(Token = "0x40006F0")]
			Rect,
			[Token(Token = "0x40006F1")]
			Fit,
			[Token(Token = "0x40006F2")]
			Split
		}

		[Token(Token = "0x2000133")]
		private struct Matrix2x3
		{
			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float m00;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float m01;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float m02;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float m10;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float m11;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float m12;

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0xE0F8C0", Offset = "0xE0F8C0", VA = "0xE0F8C0")]
			public Matrix2x3(Rect rect, float cos, float sin)
			{
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0xE0F9C4", Offset = "0xE0F9C4", VA = "0xE0F9C4")]
			public static Vector2 operator *(Matrix2x3 m, Vector2 v)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Gradient Direction")]
		[Header("GRADIENT STYLE")]
		[SerializeField]
		private Direction m_Direction;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Color1: Top or Left")]
		[SerializeField]
		private Color m_Color1;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Color2: Bottom or Right")]
		[SerializeField]
		private Color m_Color2;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Tooltip("Color3: For diagonal")]
		private Color m_Color3;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("Color4: For diagonal")]
		[SerializeField]
		private Color m_Color4;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		[Range(-180f, 180f)]
		[Tooltip("Gradient rotation")]
		private float m_Rotation;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Tooltip("Gradient offset for Horizontal, Vertical or Angle")]
		[Range(-1f, 1f)]
		private float m_Offset1;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Gradient offset for Diagonal")]
		[SerializeField]
		[Range(-1f, 1f)]
		private float m_Offset2;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("SETTINGS")]
		[Tooltip("Gradient style for Text.")]
		[SerializeField]
		private GradientStyle m_GradientStyle;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("Color space to correct color")]
		[SerializeField]
		private ColorSpace m_ColorSpace;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Ignore aspect ratio")]
		[SerializeField]
		private bool m_IgnoreAspectRatio;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector2[] s_SplitedCharacterPosition;

		[Token(Token = "0x170000F6")]
		public Graphic TargetGraphic
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0xE0EC80", Offset = "0xE0EC80", VA = "0xE0EC80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F7")]
		public Direction DirectionMain
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0xE0EC88", Offset = "0xE0EC88", VA = "0xE0EC88")]
			get
			{
				return default(Direction);
			}
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0xE0EC90", Offset = "0xE0EC90", VA = "0xE0EC90")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public Color Color1
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0xE0ECA4", Offset = "0xE0ECA4", VA = "0xE0ECA4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0xE0ECB0", Offset = "0xE0ECB0", VA = "0xE0ECB0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public Color Color2
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0xE0ED00", Offset = "0xE0ED00", VA = "0xE0ED00")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0xE0ED0C", Offset = "0xE0ED0C", VA = "0xE0ED0C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public Color Color3
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0xE0ED5C", Offset = "0xE0ED5C", VA = "0xE0ED5C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0xE0ED68", Offset = "0xE0ED68", VA = "0xE0ED68")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public Color Color4
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0xE0EDB8", Offset = "0xE0EDB8", VA = "0xE0EDB8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0xE0EDC4", Offset = "0xE0EDC4", VA = "0xE0EDC4")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public float Rotation
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0xE0EE14", Offset = "0xE0EE14", VA = "0xE0EE14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0xE0EE40", Offset = "0xE0EE40", VA = "0xE0EE40")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public float Offset
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0xE0EED8", Offset = "0xE0EED8", VA = "0xE0EED8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0xE0EEE0", Offset = "0xE0EEE0", VA = "0xE0EEE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public Vector2 Offset2
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0xE0EEF4", Offset = "0xE0EEF4", VA = "0xE0EEF4")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0xE0EEFC", Offset = "0xE0EEFC", VA = "0xE0EEFC")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public GradientStyle GradientStyleMain
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0xE0EF1C", Offset = "0xE0EF1C", VA = "0xE0EF1C")]
			get
			{
				return default(GradientStyle);
			}
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0xE0EF24", Offset = "0xE0EF24", VA = "0xE0EF24")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public ColorSpace ColorSpace
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0xE0EF38", Offset = "0xE0EF38", VA = "0xE0EF38")]
			get
			{
				return default(ColorSpace);
			}
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0xE0EF40", Offset = "0xE0EF40", VA = "0xE0EF40")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public bool IgnoreAspectRatio
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0xE0EF54", Offset = "0xE0EF54", VA = "0xE0EF54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0xE0EF5C", Offset = "0xE0EF5C", VA = "0xE0EF5C")]
			set
			{
			}
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xE0EF74", Offset = "0xE0EF74", VA = "0xE0EF74", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xE0F9F4", Offset = "0xE0F9F4", VA = "0xE0F9F4")]
		public GradientEffect()
		{
		}
	}
	[Token(Token = "0x2000134")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(CanvasRenderer))]
	[RequireComponent(typeof(ParticleSystem))]
	public class UIParticleRenderer : MaskableGraphic
	{
		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Tooltip("Having this enabled run the system in LateUpdate rather than in Update making it faster but less precise (more clunky)")]
		public bool fixedTime;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Transform _transform;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ParticleSystem pSystem;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ParticleSystem.Particle[] particles;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private UIVertex[] _quad;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector4 imageUV;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private ParticleSystem.TextureSheetAnimationModule textureSheetAnimation;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int textureSheetAnimationFrames;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector2 textureSheetAnimationFrameSize;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private ParticleSystemRenderer pRenderer;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Material currentMaterial;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Texture currentTexture;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private ParticleSystem.MainModule mainModule;

		[Token(Token = "0x17000102")]
		public override Texture mainTexture
		{
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0xE0FB8C", Offset = "0xE0FB8C", VA = "0xE0FB8C", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xE0FB94", Offset = "0xE0FB94", VA = "0xE0FB94")]
		protected bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xE1000C", Offset = "0xE1000C", VA = "0xE1000C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xE10044", Offset = "0xE10044", VA = "0xE10044", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xE10878", Offset = "0xE10878", VA = "0xE10878")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xE10A60", Offset = "0xE10A60", VA = "0xE10A60")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xE10CB0", Offset = "0xE10CB0", VA = "0xE10CB0")]
		public UIParticleRenderer()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class CustomInputField : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public GameObject fieldTrigger;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_InputField inputText;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator inputFieldAnimator;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isEmpty;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isClicked;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string inAnim;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string outAnim;

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xE10D44", Offset = "0xE10D44", VA = "0xE10D44")]
		private void Start()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xE10E1C", Offset = "0xE10E1C", VA = "0xE10E1C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xE10E84", Offset = "0xE10E84", VA = "0xE10E84")]
		public void Animate()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xE10EC4", Offset = "0xE10EC4", VA = "0xE10EC4")]
		public void FieldTrigger()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xE10F0C", Offset = "0xE10F0C", VA = "0xE10F0C", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xE10F10", Offset = "0xE10F10", VA = "0xE10F10")]
		public CustomInputField()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class HorizontalSelector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000137")]
		public class Item
		{
			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string itemTitle;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UnityEvent onValueChanged;

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xE1208C", Offset = "0xE1208C", VA = "0xE1208C")]
			public Item()
			{
			}
		}

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshProUGUI label;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshProUGUI labeHelper;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator selectorAnimator;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string newItemTitle;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("SETTINGS")]
		public int defaultIndex;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool invokeAtStart;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool invertAnimation;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		public bool loopSelection;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public int index;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Header("SAVING")]
		public bool saveValue;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string selectorTag;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("INDICATORS")]
		public bool enableIndicators;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform indicatorParent;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject indicatorObject;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("ITEMS")]
		public List<Item> itemList;

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xE10F8C", Offset = "0xE10F8C", VA = "0xE10F8C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xE116E8", Offset = "0xE116E8", VA = "0xE116E8")]
		public void PreviousClick()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xE11BBC", Offset = "0xE11BBC", VA = "0xE11BBC")]
		public void ForwardClick()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xE0BC5C", Offset = "0xE0BC5C", VA = "0xE0BC5C")]
		public void CreateNewItem(string title)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xE0BD40", Offset = "0xE0BD40", VA = "0xE0BD40")]
		public void UpdateUI()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xE120DC", Offset = "0xE120DC", VA = "0xE120DC")]
		public HorizontalSelector()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class SliderManager : MonoBehaviour
	{
		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("TEXTS")]
		public TextMeshProUGUI valueText;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("SAVING")]
		public bool enableSaving;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sliderTag;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float defaultValue;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Header("SETTINGS")]
		public bool usePercent;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool showValue;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		public bool useRoundValue;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Slider mainSlider;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float saveValue;

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xE12184", Offset = "0xE12184", VA = "0xE12184")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xE12300", Offset = "0xE12300", VA = "0xE12300")]
		private void Update()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xE12484", Offset = "0xE12484", VA = "0xE12484")]
		public SliderManager()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class SwitchManager : MonoBehaviour
	{
		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("IMPORTANT! EVERY SWITCH MUST HAVE A DIFFERENT TAG")]
		[Header("SETTINGS")]
		public string switchTag;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isOn;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool saveValue;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool invokeAtStart;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent OnEvents;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent OffEvents;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator switchAnimator;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button switchButton;

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xE1255C", Offset = "0xE1255C", VA = "0xE1255C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xE12860", Offset = "0xE12860", VA = "0xE12860")]
		public void AnimateSwitch()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xE12988", Offset = "0xE12988", VA = "0xE12988")]
		public SwitchManager()
		{
		}
	}
	[Token(Token = "0x200013A")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(AudioSource))]
	public class UIElementSound : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler
	{
		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public UIManager UIManagerAsset;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource audioObject;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("SETTINGS")]
		public bool enableHoverSound;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool enableClickSound;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PlayerController _playerManager;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected VibrationManager _vibrationManager;

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xE129E8", Offset = "0xE129E8", VA = "0xE129E8", Slot = "6")]
		[Inject]
		public virtual void Constructor(VibrationManager vibrationManager)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xE129F0", Offset = "0xE129F0", VA = "0xE129F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xE12B30", Offset = "0xE12B30", VA = "0xE12B30")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xE12BCC", Offset = "0xE12BCC", VA = "0xE12BCC", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xE12C1C", Offset = "0xE12C1C", VA = "0xE12C1C", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xE12C70", Offset = "0xE12C70", VA = "0xE12C70")]
		public UIElementSound()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[CreateAssetMenu(fileName = "New UI Manager", menuName = "Shift UI/New UI Manager")]
	public class UIManager : ScriptableObject
	{
		[Token(Token = "0x200013C")]
		public enum ButtonThemeType
		{
			[Token(Token = "0x400074F")]
			BASIC,
			[Token(Token = "0x4000750")]
			CUSTOM
		}

		[Token(Token = "0x200013D")]
		public enum BackgroundType
		{
			[Token(Token = "0x4000752")]
			BASIC,
			[Token(Token = "0x4000753")]
			ADVANCED
		}

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public bool enableDynamicUpdate;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[HideInInspector]
		public bool enableExtendedColorPicker;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[HideInInspector]
		public bool editorHints;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Color backgroundColorTint;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BackgroundType backgroundType;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Sprite backgroundImage;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public VideoClip backgroundVideo;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool backgroundPreserveAspect;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0.1f, 5f)]
		public float backgroundSpeed;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color primaryColor;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Color secondaryColor;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Color primaryReversed;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color negativeColor;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color backgroundColor;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public TMP_FontAsset lightFont;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public TMP_FontAsset regularFont;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public TMP_FontAsset mediumFont;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public TMP_FontAsset semiBoldFont;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TMP_FontAsset boldFont;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Sprite gameLogo;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Color logoColor;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color particleColor;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioClip backgroundMusic;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AudioClip hoverSound;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public AudioClip clickSound;

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xE12C80", Offset = "0xE12C80", VA = "0xE12C80")]
		public UIManager()
		{
		}
	}
	[Token(Token = "0x200013E")]
	[ExecuteInEditMode]
	public class UIManagerBackground : MonoBehaviour
	{
		[Token(Token = "0x200013F")]
		public enum BackgroundType
		{
			[Token(Token = "0x400075C")]
			BASIC,
			[Token(Token = "0x400075D")]
			ADVANCED
		}

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public UIManager UIManagerAsset;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Image backgroundObject;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RawImage backgroundVideoImage;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private VideoPlayer backgroundVideo;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("SETTINGS")]
		public BackgroundType backgroundType;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool enableMobileMode;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool dynamicUpdateEnabled;

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xE12CCC", Offset = "0xE12CCC", VA = "0xE12CCC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xE12E0C", Offset = "0xE12E0C", VA = "0xE12E0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xE132FC", Offset = "0xE132FC", VA = "0xE132FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xE12F68", Offset = "0xE12F68", VA = "0xE12F68")]
		private void UpdateBackground()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xE1338C", Offset = "0xE1338C", VA = "0xE1338C")]
		public UIManagerBackground()
		{
		}
	}
	[Token(Token = "0x2000140")]
	[ExecuteInEditMode]
	public class UIManagerBGMusic : MonoBehaviour
	{
		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public UIManager UIManagerAsset;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource audioObject;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool dynamicUpdateEnabled;

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xE13394", Offset = "0xE13394", VA = "0xE13394")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xE134D4", Offset = "0xE134D4", VA = "0xE134D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xE13634", Offset = "0xE13634", VA = "0xE13634")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xE13590", Offset = "0xE13590", VA = "0xE13590")]
		private void UpdateSource()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xE136C4", Offset = "0xE136C4", VA = "0xE136C4")]
		public UIManagerBGMusic()
		{
		}
	}
	[Token(Token = "0x2000141")]
	[ExecuteInEditMode]
	public class UIManagerGameLogo : MonoBehaviour
	{
		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public UIManager UIManagerAsset;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image logoObject;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("SETTINGS")]
		public bool keepAlphaValue;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool useCustomColor;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool dynamicUpdateEnabled;

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xE136CC", Offset = "0xE136CC", VA = "0xE136CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xE1380C", Offset = "0xE1380C", VA = "0xE1380C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xE13A30", Offset = "0xE13A30", VA = "0xE13A30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xE138C8", Offset = "0xE138C8", VA = "0xE138C8")]
		private void UpdateLogo()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xE13AC0", Offset = "0xE13AC0", VA = "0xE13AC0")]
		public UIManagerGameLogo()
		{
		}
	}
	[Token(Token = "0x2000142")]
	[ExecuteInEditMode]
	public class UIManagerImage : MonoBehaviour
	{
		[Token(Token = "0x2000143")]
		public enum ColorType
		{
			[Token(Token = "0x400076D")]
			PRIMARY,
			[Token(Token = "0x400076E")]
			SECONDARY,
			[Token(Token = "0x400076F")]
			PRIMARY_REVERSED,
			[Token(Token = "0x4000770")]
			NEGATIVE,
			[Token(Token = "0x4000771")]
			BACKGROUND
		}

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public UIManager UIManagerAsset;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image imageObject;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("SETTINGS")]
		public bool keepAlphaValue;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool useCustomColor;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ColorType colorType;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool dynamicUpdateEnabled;

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xE13AC8", Offset = "0xE13AC8", VA = "0xE13AC8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xE13C08", Offset = "0xE13C08", VA = "0xE13C08")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xE140EC", Offset = "0xE140EC", VA = "0xE140EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xE13CC4", Offset = "0xE13CC4", VA = "0xE13CC4")]
		private void UpdateButton()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xE1417C", Offset = "0xE1417C", VA = "0xE1417C")]
		public UIManagerImage()
		{
		}
	}
	[Token(Token = "0x2000144")]
	[ExecuteInEditMode]
	public class UIManagerParticle : MonoBehaviour
	{
		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public UIManager UIManagerAsset;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem particleObject;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool dynamicUpdateEnabled;

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xE14184", Offset = "0xE14184", VA = "0xE14184")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xE142C4", Offset = "0xE142C4", VA = "0xE142C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xE144EC", Offset = "0xE144EC", VA = "0xE144EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xE14380", Offset = "0xE14380", VA = "0xE14380")]
		private void UpdateColor()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xE1457C", Offset = "0xE1457C", VA = "0xE1457C")]
		public UIManagerParticle()
		{
		}
	}
	[Token(Token = "0x2000145")]
	[ExecuteInEditMode]
	public class UIManagerText : MonoBehaviour
	{
		[Token(Token = "0x2000146")]
		public enum ColorType
		{
			[Token(Token = "0x400077D")]
			PRIMARY,
			[Token(Token = "0x400077E")]
			SECONDARY,
			[Token(Token = "0x400077F")]
			PRIMARY_REVERSED,
			[Token(Token = "0x4000780")]
			NEGATIVE,
			[Token(Token = "0x4000781")]
			BACKGROUND
		}

		[Token(Token = "0x2000147")]
		public enum FontType
		{
			[Token(Token = "0x4000783")]
			LIGHT,
			[Token(Token = "0x4000784")]
			REGULAR,
			[Token(Token = "0x4000785")]
			MEDIUM,
			[Token(Token = "0x4000786")]
			SEMIBOLD,
			[Token(Token = "0x4000787")]
			BOLD
		}

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public UIManager UIManagerAsset;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI textObject;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("SETTINGS")]
		public bool keepAlphaValue;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool useCustomColor;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ColorType colorType;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FontType fontType;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool dynamicUpdateEnabled;

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xE14584", Offset = "0xE14584", VA = "0xE14584")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xE146C4", Offset = "0xE146C4", VA = "0xE146C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xE14CC8", Offset = "0xE14CC8", VA = "0xE14CC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xE14780", Offset = "0xE14780", VA = "0xE14780")]
		private void UpdateButton()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xE14D58", Offset = "0xE14D58", VA = "0xE14D58")]
		public UIManagerText()
		{
		}
	}
}
namespace _Trash.Carlos.Plane
{
	[Token(Token = "0x2000148")]
	public class PlaneCombat : MonoBehaviour
	{
		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<SpriteRenderer> lifes;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SpriteRenderer> enemies;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Transform> clouds;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<GameObject> enemyBullets;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform player;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ParticleSystem smoke;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float playerMaxSpeed;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int playerLife;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float enemyBulletsSpeed;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float bulletSpread;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform playerBomb;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve bombDeployCurve;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve enemySpawnRate;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve cloudDeployCurve;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float cloudSpeed;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TextMeshPro scoreText;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float timeToNextEnemy;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public SpriteRenderer explotion;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float refresRate;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _currentSpeed;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _spawnEnemyTimer;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float _invencibleTime;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Tween _playerTween;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float _score;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _lastShootTimer;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _refreshTimer;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float _refreshTime;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xE14D60", Offset = "0xE14D60", VA = "0xE14D60")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xE151E8", Offset = "0xE151E8", VA = "0xE151E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xE151F8", Offset = "0xE151F8", VA = "0xE151F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xE154EC", Offset = "0xE154EC", VA = "0xE154EC")]
		private void CheckBullets()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xE15B94", Offset = "0xE15B94", VA = "0xE15B94")]
		private void EnemyShoot()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xE14D74", Offset = "0xE14D74", VA = "0xE14D74")]
		private void Init()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xE15F98", Offset = "0xE15F98", VA = "0xE15F98")]
		private void CheckSpawn()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xE162C0", Offset = "0xE162C0", VA = "0xE162C0")]
		private void MoveEnemies()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xE1654C", Offset = "0xE1654C", VA = "0xE1654C")]
		private void MoveClouds()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xE16888", Offset = "0xE16888", VA = "0xE16888")]
		public PlaneCombat()
		{
		}
	}
}
