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
using Oculus.Platform;
using Oculus.Platform.Models;
using Odders.ShapeIt.GameFlow;
using Odders.ShapeIt.GameTools;
using Odders.ShapeIt.Menu;
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
	[Address(RVA = "0xD0D298", Offset = "0xD0D298", VA = "0xD0D298")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xD0D334", Offset = "0xD0D334", VA = "0xD0D334")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xD0D3D0", Offset = "0xD0D3D0", VA = "0xD0D3D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xD0D604", Offset = "0xD0D604", VA = "0xD0D604")]
	private void Update()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xD0D714", Offset = "0xD0D714", VA = "0xD0D714")]
	private void SpawnObstacles()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xD0D928", Offset = "0xD0D928", VA = "0xD0D928")]
	private void Gravity()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xD0D6B8", Offset = "0xD0D6B8", VA = "0xD0D6B8")]
	private void Jump(InputAction.CallbackContext obj)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xD0D9E4", Offset = "0xD0D9E4", VA = "0xD0D9E4")]
	private void MoveObstacles()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xD0DB3C", Offset = "0xD0DB3C", VA = "0xD0DB3C")]
	public void AddScore()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xD0DB50", Offset = "0xD0DB50", VA = "0xD0DB50")]
	public void GameOver()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xD0DC04", Offset = "0xD0DC04", VA = "0xD0DC04")]
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
			[Address(RVA = "0xD0DF90", Offset = "0xD0DF90", VA = "0xD0DF90", Slot = "4")]
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
			[Address(RVA = "0xD0DFD8", Offset = "0xD0DFD8", VA = "0xD0DFD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xD0DD68", Offset = "0xD0DD68", VA = "0xD0DD68")]
		[DebuggerHidden]
		public <Activate>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xD0DEC8", Offset = "0xD0DEC8", VA = "0xD0DEC8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xD0DECC", Offset = "0xD0DECC", VA = "0xD0DECC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xD0DF98", Offset = "0xD0DF98", VA = "0xD0DF98", Slot = "8")]
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
	[Address(RVA = "0xD0DC2C", Offset = "0xD0DC2C", VA = "0xD0DC2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xD0DCA8", Offset = "0xD0DCA8", VA = "0xD0DCA8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xD0DD30", Offset = "0xD0DD30", VA = "0xD0DD30")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xD0DCC8", Offset = "0xD0DCC8", VA = "0xD0DCC8")]
	[IteratorStateMachine(typeof(<Activate>d__6))]
	private IEnumerator Activate()
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xD0DD90", Offset = "0xD0DD90", VA = "0xD0DD90")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xD0DE38", Offset = "0xD0DE38", VA = "0xD0DE38")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xD0DEC0", Offset = "0xD0DEC0", VA = "0xD0DEC0")]
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
			[Address(RVA = "0xD0F33C", Offset = "0xD0F33C", VA = "0xD0F33C", Slot = "4")]
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
			[Address(RVA = "0xD0F384", Offset = "0xD0F384", VA = "0xD0F384", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xD0F0B8", Offset = "0xD0F0B8", VA = "0xD0F0B8")]
		[DebuggerHidden]
		public <Reset>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xD0F188", Offset = "0xD0F188", VA = "0xD0F188", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xD0F18C", Offset = "0xD0F18C", VA = "0xD0F18C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xD0F344", Offset = "0xD0F344", VA = "0xD0F344", Slot = "8")]
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
		[Address(RVA = "0xD0DFE0", Offset = "0xD0DFE0", VA = "0xD0DFE0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000004")]
	private bool Bounds
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0xD0E024", Offset = "0xD0E024", VA = "0xD0E024")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xD0E10C", Offset = "0xD0E10C", VA = "0xD0E10C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xD0E114", Offset = "0xD0E114", VA = "0xD0E114")]
	public void RestartGame(bool resetScores = true)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xD0E238", Offset = "0xD0E238", VA = "0xD0E238")]
	private void CleanBlocks()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xD0E328", Offset = "0xD0E328", VA = "0xD0E328")]
	private void GenerateBlocks()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xD0E8F4", Offset = "0xD0E8F4", VA = "0xD0E8F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xD0EFB4", Offset = "0xD0EFB4", VA = "0xD0EFB4")]
	private void Lose()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xD0EEC8", Offset = "0xD0EEC8", VA = "0xD0EEC8")]
	private void Win()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xD0F0A0", Offset = "0xD0F0A0", VA = "0xD0F0A0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xD0ED9C", Offset = "0xD0ED9C", VA = "0xD0ED9C")]
	public void PlayerMovement()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xD0E66C", Offset = "0xD0E66C", VA = "0xD0E66C")]
	[IteratorStateMachine(typeof(<Reset>d__32))]
	private IEnumerator Reset(bool resetScores = true)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xD0F0E0", Offset = "0xD0F0E0", VA = "0xD0F0E0")]
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
	[Address(RVA = "0xD0E6E8", Offset = "0xD0E6E8", VA = "0xD0E6E8")]
	public void Init(Arkanoid controller)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xD0F394", Offset = "0xD0F394", VA = "0xD0F394")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xD0F3A4", Offset = "0xD0F3A4", VA = "0xD0F3A4")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xD0F5C4", Offset = "0xD0F5C4", VA = "0xD0F5C4")]
	private Vector3 Bounce(Vector3 collisionNormal, Rigidbody rb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xD0F770", Offset = "0xD0F770", VA = "0xD0F770")]
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
		[Address(RVA = "0xD0F804", Offset = "0xD0F804", VA = "0xD0F804")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xD0F934", Offset = "0xD0F934", VA = "0xD0F934")]
	private void Update()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xD0F998", Offset = "0xD0F998", VA = "0xD0F998")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xD0FC90", Offset = "0xD0FC90", VA = "0xD0FC90")]
	private Vector3 MapDirection(Vector3 origin)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xD0FDA4", Offset = "0xD0FDA4", VA = "0xD0FDA4")]
	private Vector3 Bounce(Vector3 Normal, Rigidbody rb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xD0FFFC", Offset = "0xD0FFFC", VA = "0xD0FFFC")]
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
		[Address(RVA = "0xD10D30", Offset = "0xD10D30", VA = "0xD10D30")]
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
	[Address(RVA = "0xD10004", Offset = "0xD10004", VA = "0xD10004")]
	private void CheckShow(InputAction.CallbackContext obj)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xD100EC", Offset = "0xD100EC", VA = "0xD100EC")]
	private void Close()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xD101C0", Offset = "0xD101C0", VA = "0xD101C0")]
	private void Open(bool resetIndex = true)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xD10534", Offset = "0xD10534", VA = "0xD10534")]
	private void Start()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xD10744", Offset = "0xD10744", VA = "0xD10744")]
	private void OnChangeState(GameplayWindowsManager.State newstate)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xD1077C", Offset = "0xD1077C", VA = "0xD1077C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xD102AC", Offset = "0xD102AC", VA = "0xD102AC")]
	private void CreateTexts()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xD108F0", Offset = "0xD108F0", VA = "0xD108F0")]
	private void GoDown()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xD108A0", Offset = "0xD108A0", VA = "0xD108A0")]
	private void GoUp()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xD104C0", Offset = "0xD104C0", VA = "0xD104C0")]
	private void RedrawUI()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xD10940", Offset = "0xD10940", VA = "0xD10940")]
	private void Accept(InputAction.CallbackContext obj)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xD10A18", Offset = "0xD10A18", VA = "0xD10A18")]
	private void Back(InputAction.CallbackContext obj)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xD10AA4", Offset = "0xD10AA4", VA = "0xD10AA4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xD10CB4", Offset = "0xD10CB4", VA = "0xD10CB4")]
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
		[Address(RVA = "0xD115F8", Offset = "0xD115F8", VA = "0xD115F8")]
		public Ent(Transform t, float x, float y, int tag = 0, int mode = 0)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xD11B94", Offset = "0xD11B94", VA = "0xD11B94")]
		public void Draw()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xD11B38", Offset = "0xD11B38", VA = "0xD11B38")]
		public Vector3 PosRot()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xD1168C", Offset = "0xD1168C", VA = "0xD1168C")]
		public void SetDir(float rot, float force)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xD11FC4", Offset = "0xD11FC4", VA = "0xD11FC4")]
		public void PhysUpdate()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xD123C0", Offset = "0xD123C0", VA = "0xD123C0")]
		public static Vector2 ToPolar(Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xD11650", Offset = "0xD11650", VA = "0xD11650")]
		public static Vector2 ToCartesian(Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xD12344", Offset = "0xD12344", VA = "0xD12344")]
		private void Warp()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xD12238", Offset = "0xD12238", VA = "0xD12238")]
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
	[Address(RVA = "0xD10D38", Offset = "0xD10D38", VA = "0xD10D38")]
	private Transform Pool(Transform from, List<Transform> list, bool isParticle = false)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xD11244", Offset = "0xD11244", VA = "0xD11244")]
	private void Start()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xD11768", Offset = "0xD11768", VA = "0xD11768")]
	private void Update()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xD11C28", Offset = "0xD11C28", VA = "0xD11C28")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xD11BD8", Offset = "0xD11BD8", VA = "0xD11BD8")]
	private void Explode(float x, float y)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xD12248", Offset = "0xD12248", VA = "0xD12248")]
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
	[Address(RVA = "0xD124C4", Offset = "0xD124C4", VA = "0xD124C4")]
	private void UpdateLevel()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xD12590", Offset = "0xD12590", VA = "0xD12590")]
	private void UpdateScore(int addScore)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xD1264C", Offset = "0xD1264C", VA = "0xD1264C")]
	private void Init()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xD12894", Offset = "0xD12894", VA = "0xD12894")]
	private void Start()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xD12A78", Offset = "0xD12A78", VA = "0xD12A78")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xD12A88", Offset = "0xD12A88", VA = "0xD12A88")]
	private bool Check()
	{
		return default(bool);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xD12704", Offset = "0xD12704", VA = "0xD12704")]
	private void Next()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xD12B20", Offset = "0xD12B20", VA = "0xD12B20")]
	private void Update()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xD131F8", Offset = "0xD131F8", VA = "0xD131F8")]
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
		[Address(RVA = "0xD13490", Offset = "0xD13490", VA = "0xD13490")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000068")]
		[Address(RVA = "0xD134AC", Offset = "0xD134AC", VA = "0xD134AC")]
		set
		{
		}
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xD1330C", Offset = "0xD1330C", VA = "0xD1330C")]
	public void UseKeyBoard(TMP_InputField inputField)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xD13334", Offset = "0xD13334", VA = "0xD13334")]
	private void Start()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xD134C8", Offset = "0xD134C8", VA = "0xD134C8")]
	public void SendBackspace()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xD13624", Offset = "0xD13624", VA = "0xD13624")]
	public void SendEnd()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xD1364C", Offset = "0xD1364C", VA = "0xD1364C")]
	public void SendEnter()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xD13674", Offset = "0xD13674", VA = "0xD13674")]
	public void SendSpace()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xD136E8", Offset = "0xD136E8", VA = "0xD136E8")]
	public void PressKey(GameObject go)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xD13784", Offset = "0xD13784", VA = "0xD13784")]
	public void SendKey(string value)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xD13A34", Offset = "0xD13A34", VA = "0xD13A34")]
	public void PressKey(string key)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xD13A38", Offset = "0xD13A38", VA = "0xD13A38")]
	public void Caps()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xD13DB4", Offset = "0xD13DB4", VA = "0xD13DB4")]
	public void LeftArrow()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xD13DFC", Offset = "0xD13DFC", VA = "0xD13DFC")]
	public void RightArrow()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xD13E44", Offset = "0xD13E44", VA = "0xD13E44")]
	public void SwitchSymbols()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xD1353C", Offset = "0xD1353C", VA = "0xD1353C")]
	private void ProcessEvent(string keyEvent)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xD13ED4", Offset = "0xD13ED4", VA = "0xD13ED4")]
	public KeyBoard()
	{
	}
}
[Token(Token = "0x2000012")]
public class Entrypoint_SceneChange : MonoBehaviour
{
	[Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Entrypoint_SceneChange <>4__this;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0xD14128", Offset = "0xD14128", VA = "0xD14128", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0xD14170", Offset = "0xD14170", VA = "0xD14170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xD13FDC", Offset = "0xD13FDC", VA = "0xD13FDC")]
		[DebuggerHidden]
		public <Start>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xD1400C", Offset = "0xD1400C", VA = "0xD1400C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xD14010", Offset = "0xD14010", VA = "0xD14010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xD14130", Offset = "0xD14130", VA = "0xD14130", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image logo;

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xD13F74", Offset = "0xD13F74", VA = "0xD13F74")]
	[IteratorStateMachine(typeof(<Start>d__1))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xD14004", Offset = "0xD14004", VA = "0xD14004")]
	public Entrypoint_SceneChange()
	{
	}
}
[Token(Token = "0x2000014")]
public class ScrollDeactiveObject : MonoBehaviour
{
	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform topObject;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float topY;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float botY;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform botObject;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform[] childs;

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xD14178", Offset = "0xD14178", VA = "0xD14178")]
	private void Start()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xD141F4", Offset = "0xD141F4", VA = "0xD141F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xD142D8", Offset = "0xD142D8", VA = "0xD142D8")]
	public void ManageObjects(Transform t, bool active)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xD143EC", Offset = "0xD143EC", VA = "0xD143EC")]
	public ScrollDeactiveObject()
	{
	}
}
[Token(Token = "0x2000015")]
public class YmlToBinary : MonoBehaviour
{
	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string filePath;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LevelData song;

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xD143F4", Offset = "0xD143F4", VA = "0xD143F4")]
	public void Serialize()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xD14670", Offset = "0xD14670", VA = "0xD14670")]
	public YmlToBinary()
	{
	}
}
[Token(Token = "0x2000016")]
[RequireComponent(typeof(ParticleSystem))]
public class particleAttractorLinear : MonoBehaviour
{
	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int numParticlesAlive;

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xD146C0", Offset = "0xD146C0", VA = "0xD146C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xD1478C", Offset = "0xD1478C", VA = "0xD1478C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xD14910", Offset = "0xD14910", VA = "0xD14910")]
	public particleAttractorLinear()
	{
	}
}
[Token(Token = "0x2000017")]
[RequireComponent(typeof(ParticleSystem))]
public class particleAttractorMove : MonoBehaviour
{
	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int numParticlesAlive;

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xD14920", Offset = "0xD14920", VA = "0xD14920")]
	private void Start()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xD149EC", Offset = "0xD149EC", VA = "0xD149EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xD14C48", Offset = "0xD14C48", VA = "0xD14C48")]
	public particleAttractorMove()
	{
	}
}
[Token(Token = "0x2000018")]
[RequireComponent(typeof(ParticleSystem))]
public class particleAttractorSelf : MonoBehaviour
{
	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int numParticlesAlive;

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xD14C58", Offset = "0xD14C58", VA = "0xD14C58")]
	private void Start()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xD14D24", Offset = "0xD14D24", VA = "0xD14D24")]
	private void Update()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xD14EC4", Offset = "0xD14EC4", VA = "0xD14EC4")]
	public particleAttractorSelf()
	{
	}
}
[Token(Token = "0x2000019")]
[RequireComponent(typeof(ParticleSystem))]
public class particleAttractorSpherical : MonoBehaviour
{
	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int numParticlesAlive;

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xD14ED4", Offset = "0xD14ED4", VA = "0xD14ED4")]
	private void Start()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xD14FA0", Offset = "0xD14FA0", VA = "0xD14FA0")]
	private void Update()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xD15124", Offset = "0xD15124", VA = "0xD15124")]
	public particleAttractorSpherical()
	{
	}
}
[Token(Token = "0x200001A")]
public class rotation : MonoBehaviour
{
	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float xRotation;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float yRotation;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float zRotation;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xD15134", Offset = "0xD15134", VA = "0xD15134")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xD1518C", Offset = "0xD1518C", VA = "0xD1518C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xD15194", Offset = "0xD15194", VA = "0xD15194")]
	public void clickOn()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xD151EC", Offset = "0xD151EC", VA = "0xD151EC")]
	public void clickOff()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xD151F4", Offset = "0xD151F4", VA = "0xD151F4")]
	private void rotate()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xD15244", Offset = "0xD15244", VA = "0xD15244")]
	public rotation()
	{
	}
}
[Token(Token = "0x200001B")]
public class OvrAvatarTestDriver : OvrAvatarDriver
{
	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 headPos;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion headRot;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xD1524C", Offset = "0xD1524C", VA = "0xD1524C")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xD1538C", Offset = "0xD1538C", VA = "0xD1538C")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xD156BC", Offset = "0xD156BC", VA = "0xD156BC")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xD15854", Offset = "0xD15854", VA = "0xD15854", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xD15880", Offset = "0xD15880", VA = "0xD15880")]
	public OvrAvatarTestDriver()
	{
	}
}
[Token(Token = "0x200001C")]
public class PoseEditHelper : MonoBehaviour
{
	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform poseRoot;

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xD158E8", Offset = "0xD158E8", VA = "0xD158E8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xD15964", Offset = "0xD15964", VA = "0xD15964")]
	private void DrawJoints(Transform joint)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xD15AD4", Offset = "0xD15AD4", VA = "0xD15AD4")]
	public PoseEditHelper()
	{
	}
}
[Token(Token = "0x200001D")]
public class GazeTargetSpawner : MonoBehaviour
{
	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject GazeTargetPrefab;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int NumberOfDummyTargets;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int RadiusMultiplier;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isVisible;

	[Token(Token = "0x1700000B")]
	public bool IsVisible
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0xD15ADC", Offset = "0xD15ADC", VA = "0xD15ADC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600009F")]
		[Address(RVA = "0xD15AE4", Offset = "0xD15AE4", VA = "0xD15AE4")]
		set
		{
		}
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xD15C08", Offset = "0xD15C08", VA = "0xD15C08")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xD15DF8", Offset = "0xD15DF8", VA = "0xD15DF8")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xD15E00", Offset = "0xD15E00", VA = "0xD15E00")]
	public GazeTargetSpawner()
	{
	}
}
[Token(Token = "0x200001E")]
public class RemoteLoopbackManager : MonoBehaviour
{
	[Token(Token = "0x200001F")]
	private class PacketLatencyPair
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] PacketData;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FakeLatency;

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xD169F0", Offset = "0xD169F0", VA = "0xD169F0")]
		public PacketLatencyPair()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000020")]
	public class SimulatedLatencySettings
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 0.5f)]
		public float FakeLatencyMax;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 0.5f)]
		public float FakeLatencyMin;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float LatencyWeight;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 10f)]
		public int MaxSamples;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal float AverageWindow;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float LatencySum;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal LinkedList<float> LatencyValues;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xD169F8", Offset = "0xD169F8", VA = "0xD169F8")]
		public float NextValue()
		{
			return default(float);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xD16BD4", Offset = "0xD16BD4", VA = "0xD16BD4")]
		public SimulatedLatencySettings()
		{
		}
	}

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OvrAvatar LocalAvatar;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar LoopbackAvatar;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimulatedLatencySettings LatencySettings;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int PacketSequence;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LinkedList<PacketLatencyPair> packetQueue;

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xD15E14", Offset = "0xD15E14", VA = "0xD15E14")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xD15F58", Offset = "0xD15F58", VA = "0xD15F58")]
	private void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xD16348", Offset = "0xD16348", VA = "0xD16348")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xD162A8", Offset = "0xD162A8", VA = "0xD162A8")]
	private void SendPacketData(byte[] data)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xD166D4", Offset = "0xD166D4", VA = "0xD166D4")]
	private void ReceivePacketData(byte[] data)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xD16B2C", Offset = "0xD16B2C", VA = "0xD16B2C")]
	public RemoteLoopbackManager()
	{
	}
}
[Token(Token = "0x2000021")]
public class P2PManager
{
	[Token(Token = "0x2000022")]
	private enum MessageType : byte
	{
		[Token(Token = "0x40000CD")]
		Update = 1
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xD16C68", Offset = "0xD16C68", VA = "0xD16C68")]
	public P2PManager()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xD16D34", Offset = "0xD16D34", VA = "0xD16D34")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xD16F74", Offset = "0xD16F74", VA = "0xD16F74")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xD170BC", Offset = "0xD170BC", VA = "0xD170BC")]
	private void PeerConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xD1720C", Offset = "0xD1720C", VA = "0xD1720C")]
	private void ConnectionStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xD173F8", Offset = "0xD173F8", VA = "0xD173F8")]
	public void SendAvatarUpdate(ulong userID, Transform rootTransform, uint sequence, byte[] avatarPacket)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xD177B0", Offset = "0xD177B0", VA = "0xD177B0")]
	public void GetRemotePackets()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xD17A38", Offset = "0xD17A38", VA = "0xD17A38")]
	public void processAvatarPacket(RemotePlayer remote, ref byte[] packet, ref int offset)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xD175BC", Offset = "0xD175BC", VA = "0xD175BC")]
	private void PackByte(byte b, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xD17984", Offset = "0xD17984", VA = "0xD17984")]
	private byte ReadByte(byte[] buf, ref int offset)
	{
		return default(byte);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xD17688", Offset = "0xD17688", VA = "0xD17688")]
	private void PackFloat(float f, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xD17C60", Offset = "0xD17C60", VA = "0xD17C60")]
	private float ReadFloat(byte[] buf, ref int offset)
	{
		return default(float);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xD175F8", Offset = "0xD175F8", VA = "0xD175F8")]
	private void PackULong(ulong u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xD179BC", Offset = "0xD179BC", VA = "0xD179BC")]
	private ulong ReadULong(byte[] buf, ref int offset)
	{
		return default(ulong);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xD17720", Offset = "0xD17720", VA = "0xD17720")]
	private void PackUInt32(uint u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xD17CDC", Offset = "0xD17CDC", VA = "0xD17CDC")]
	private uint ReadUInt32(byte[] buf, ref int offset)
	{
		return default(uint);
	}
}
[Token(Token = "0x2000023")]
public class PlayerController : SocialPlatformManager
{
	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Camera spyCamera;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject cameraRig;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool showUI;

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xD17D58", Offset = "0xD17D58", VA = "0xD17D58", Slot = "5")]
	public override void Awake()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xD180D8", Offset = "0xD180D8", VA = "0xD180D8", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xD180FC", Offset = "0xD180FC", VA = "0xD180FC", Slot = "4")]
	public override void Update()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xD1849C", Offset = "0xD1849C", VA = "0xD1849C")]
	private void checkInput()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xD185FC", Offset = "0xD185FC", VA = "0xD185FC")]
	private void ToggleCamera()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xD18678", Offset = "0xD18678", VA = "0xD18678")]
	private void ToggleUI()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xD186C0", Offset = "0xD186C0", VA = "0xD186C0")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x2000024")]
public class RemotePlayer
{
	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong remoteUserID;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool stillInRoom;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public PeerConnectionState p2pConnectionState;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PeerConnectionState voipConnectionState;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar RemoteAvatar;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 receivedRootPosition;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 receivedRootPositionPrior;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Quaternion receivedRootRotation;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Quaternion receivedRootRotationPrior;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public VoipAudioSourceHiLevel voipSource;

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xD18798", Offset = "0xD18798", VA = "0xD18798")]
	public RemotePlayer()
	{
	}
}
[Token(Token = "0x2000025")]
public class RoomManager
{
	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong roomID;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong invitedRoomID;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool amIServer;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool startupDone;

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xD187A0", Offset = "0xD187A0", VA = "0xD187A0")]
	public RoomManager()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xD18884", Offset = "0xD18884", VA = "0xD18884")]
	private void AcceptingInviteCallback(Message<string> msg)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xD18A84", Offset = "0xD18A84", VA = "0xD18A84")]
	public bool CheckForInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xD18B9C", Offset = "0xD18B9C", VA = "0xD18B9C")]
	public void CreateRoom()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xD18C54", Offset = "0xD18C54", VA = "0xD18C54")]
	private void CreateAndJoinPrivateRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xD19040", Offset = "0xD19040", VA = "0xD19040")]
	private void OnLaunchInviteWorkflowComplete(Message msg)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xD18AB0", Offset = "0xD18AB0", VA = "0xD18AB0")]
	public void JoinExistingRoom(ulong roomID)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xD190B8", Offset = "0xD190B8", VA = "0xD190B8")]
	private void JoinRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xD197D0", Offset = "0xD197D0", VA = "0xD197D0")]
	private void RoomUpdateCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xD19AA4", Offset = "0xD19AA4", VA = "0xD19AA4")]
	public void LeaveCurrentRoom()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xD19380", Offset = "0xD19380", VA = "0xD19380")]
	private void ProcessRoomData(Message<Room> msg)
	{
	}
}
[Token(Token = "0x2000026")]
public class SocialPlatformManager : MonoBehaviour
{
	[Token(Token = "0x2000027")]
	public enum State
	{
		[Token(Token = "0x4000105")]
		INITIALIZING,
		[Token(Token = "0x4000106")]
		CHECKING_LAUNCH_STATE,
		[Token(Token = "0x4000107")]
		CREATING_A_ROOM,
		[Token(Token = "0x4000108")]
		WAITING_IN_A_ROOM,
		[Token(Token = "0x4000109")]
		JOINING_A_ROOM,
		[Token(Token = "0x400010A")]
		CONNECTED_IN_A_ROOM,
		[Token(Token = "0x400010B")]
		LEAVING_A_ROOM,
		[Token(Token = "0x400010C")]
		SHUTDOWN
	}

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 START_ROTATION_ONE;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly Vector3 START_POSITION_ONE;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 START_ROTATION_TWO;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly Vector3 START_POSITION_TWO;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Vector3 START_ROTATION_THREE;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly Vector3 START_POSITION_THREE;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly Vector3 START_ROTATION_FOUR;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static readonly Vector3 START_POSITION_FOUR;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly Color BLACK;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static readonly Color WHITE;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static readonly Color CYAN;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static readonly Color BLUE;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static readonly Color GREEN;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float voiceCurrent;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private uint packetSequence;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar localAvatarPrefab;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar remoteAvatarPrefab;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject helpPanel;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected MeshRenderer helpMesh;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material riftMaterial;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material gearMaterial;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected OvrAvatar localAvatar;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected GameObject localTrackingSpace;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject localPlayerHead;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Dictionary<ulong, RemotePlayer> remoteUsers;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject roomSphere;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected MeshRenderer sphereMesh;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject roomFloor;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected MeshRenderer floorMesh;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected State currentState;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected static SocialPlatformManager s_instance;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected RoomManager roomManager;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected P2PManager p2pManager;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected VoipManager voipManager;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected ulong myID;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected string myOculusID;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public static readonly float VOIP_SCALE;

	[Token(Token = "0x1700000C")]
	public static State CurrentState
	{
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xD1B7F0", Offset = "0xD1B7F0", VA = "0xD1B7F0")]
		get
		{
			return default(State);
		}
	}

	[Token(Token = "0x1700000D")]
	public static ulong MyID
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xD16DFC", Offset = "0xD16DFC", VA = "0xD16DFC")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700000E")]
	public static string MyOculusID
	{
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xD1B854", Offset = "0xD1B854", VA = "0xD1B854")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xD18114", Offset = "0xD18114", VA = "0xD18114", Slot = "4")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xD17D84", Offset = "0xD17D84", VA = "0xD17D84", Slot = "5")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xD1A530", Offset = "0xD1A530", VA = "0xD1A530")]
	private void InitCallback(Message<PlatformInitialize> msg)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xD180F8", Offset = "0xD180F8", VA = "0xD180F8", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xD1A6B8", Offset = "0xD1A6B8", VA = "0xD1A6B8")]
	private void IsEntitledCallback(Message msg)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xD1A7B0", Offset = "0xD1A7B0", VA = "0xD1A7B0")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xD1AF40", Offset = "0xD1AF40", VA = "0xD1AF40")]
	private void GetLoggedInUserFriendsAndRoomsCallback(Message<UserAndRoomList> msg)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xD1B358", Offset = "0xD1B358", VA = "0xD1B358")]
	public void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xD1B57C", Offset = "0xD1B57C", VA = "0xD1B57C")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xD1B788", Offset = "0xD1B788", VA = "0xD1B788")]
	public void AddUser(ulong userID, ref RemotePlayer remoteUser)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xD1A3BC", Offset = "0xD1A3BC", VA = "0xD1A3BC")]
	public void LogOutputLine(string line)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xD189D8", Offset = "0xD189D8", VA = "0xD189D8")]
	public static void TerminateWithError(Message msg)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xD18D40", Offset = "0xD18D40", VA = "0xD18D40")]
	public static void TransitionToState(State newState)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xD1B958", Offset = "0xD1B958", VA = "0xD1B958")]
	private static void SetSphereColorForState()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xD18F80", Offset = "0xD18F80", VA = "0xD18F80")]
	public static void SetFloorColorForState(bool host)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xD19B0C", Offset = "0xD19B0C", VA = "0xD19B0C")]
	public static void MarkAllRemoteUsersAsNotInRoom()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xD19EE8", Offset = "0xD19EE8", VA = "0xD19EE8")]
	public static void MarkRemoteUserInRoom(ulong userID)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xD19FC8", Offset = "0xD19FC8", VA = "0xD19FC8")]
	public static void ForgetRemoteUsersNotInRoom()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xD16EC0", Offset = "0xD16EC0", VA = "0xD16EC0")]
	public static void LogOutput(string line)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xD19C90", Offset = "0xD19C90", VA = "0xD19C90")]
	public static bool IsUserInRoom(ulong userID)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xD19D18", Offset = "0xD19D18", VA = "0xD19D18")]
	public static void AddRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xD1BADC", Offset = "0xD1BADC", VA = "0xD1BADC")]
	public static void RemoveRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xD1BDA0", Offset = "0xD1BDA0", VA = "0xD1BDA0")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xD1A344", Offset = "0xD1A344", VA = "0xD1A344")]
	[MonoPInvokeCallback(typeof(CAPI.FilterCallback))]
	public static void MicFilter(short[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xD16FE4", Offset = "0xD16FE4", VA = "0xD16FE4")]
	public static RemotePlayer GetRemoteUser(ulong userID)
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xD1871C", Offset = "0xD1871C", VA = "0xD1871C")]
	public SocialPlatformManager()
	{
	}
}
[Token(Token = "0x2000028")]
public class VoipManager
{
	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xD1A464", Offset = "0xD1A464", VA = "0xD1A464")]
	public VoipManager()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xD1BCD8", Offset = "0xD1BCD8", VA = "0xD1BCD8")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xD1B718", Offset = "0xD1B718", VA = "0xD1B718")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xD1C008", Offset = "0xD1C008", VA = "0xD1C008")]
	private void VoipConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xD1C158", Offset = "0xD1C158", VA = "0xD1C158")]
	private void VoipStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}
}
[Token(Token = "0x2000029")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x200002A")]
	public delegate void OnClick();

	[Token(Token = "0x200002B")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x200002C")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x200002D")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x400010D")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x400010E")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x400010F")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform[] additionalButtonPrefab;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool[] reEnable;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float elementSpacing;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float marginH;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float marginV;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2[] insertPositions;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 menuOffset;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private OVRCameraRig rig;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private LaserPointer lp;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private LineRenderer lr;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool isHorizontal;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	public bool usePanelCentricRelayout;

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xD1C344", Offset = "0xD1C344", VA = "0xD1C344")]
	public void Awake()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xD1C838", Offset = "0xD1C838", VA = "0xD1C838")]
	public void Show()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xD1CBA0", Offset = "0xD1CBA0", VA = "0xD1CBA0")]
	public void Hide()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xD1CD1C", Offset = "0xD1CD1C", VA = "0xD1CD1C")]
	private void StackedRelayout()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xD1CF34", Offset = "0xD1CF34", VA = "0xD1CF34")]
	private void PanelCentricRelayout()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xD1CB90", Offset = "0xD1CB90", VA = "0xD1CB90")]
	private void Relayout()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xD1D228", Offset = "0xD1D228", VA = "0xD1D228")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xD1D52C", Offset = "0xD1D52C", VA = "0xD1D52C")]
	public RectTransform AddButton(string label, [Optional] OnClick handler, int buttonIndex = -1, int targetCanvas = 0, bool highResolutionText = false)
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xD1D8C4", Offset = "0xD1D8C4", VA = "0xD1D8C4")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xD1D9BC", Offset = "0xD1D9BC", VA = "0xD1D9BC")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xD1DB80", Offset = "0xD1DB80", VA = "0xD1DB80")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xD1DC18", Offset = "0xD1DC18", VA = "0xD1DC18")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xD1DDD4", Offset = "0xD1DDD4", VA = "0xD1DDD4")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xD1DFB0", Offset = "0xD1DFB0", VA = "0xD1DFB0")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xD1E28C", Offset = "0xD1E28C", VA = "0xD1E28C")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xD1E37C", Offset = "0xD1E37C", VA = "0xD1E37C")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xD1E410", Offset = "0xD1E410", VA = "0xD1E410")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x2000033")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xD1EA44", Offset = "0xD1EA44", VA = "0xD1EA44")]
	private void Start()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xD1EAD4", Offset = "0xD1EAD4", VA = "0xD1EAD4")]
	private void Update()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xD1EB70", Offset = "0xD1EB70", VA = "0xD1EB70")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xD1EBA8", Offset = "0xD1EBA8", VA = "0xD1EBA8")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x2000034")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x2000035")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x400013F")]
		On,
		[Token(Token = "0x4000140")]
		Off,
		[Token(Token = "0x4000141")]
		OnWhenHitTarget
	}

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x1700000F")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x6000122")]
		[Address(RVA = "0xD1EBB0", Offset = "0xD1EBB0", VA = "0xD1EBB0")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x6000121")]
		[Address(RVA = "0xD1C7F8", Offset = "0xD1C7F8", VA = "0xD1C7F8")]
		set
		{
		}
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xD1EBB8", Offset = "0xD1EBB8", VA = "0xD1EBB8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xD1EC08", Offset = "0xD1EC08", VA = "0xD1EC08")]
	private void Start()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xD1ED40", Offset = "0xD1ED40", VA = "0xD1ED40", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xD1ED5C", Offset = "0xD1ED5C", VA = "0xD1ED5C", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xD1EDAC", Offset = "0xD1EDAC", VA = "0xD1EDAC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xD1EF4C", Offset = "0xD1EF4C", VA = "0xD1EF4C")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xD1F05C", Offset = "0xD1F05C", VA = "0xD1F05C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xD1F0E0", Offset = "0xD1F0E0", VA = "0xD1F0E0")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xD1F1A0", Offset = "0xD1F1A0", VA = "0xD1F1A0")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xD1F248", Offset = "0xD1F248", VA = "0xD1F248")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xD1F334", Offset = "0xD1F334", VA = "0xD1F334")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x2000036")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x4000142")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x4000143")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x4000144")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("This should be a reference to the OVRCameraRig that is usually a child of the PlayerController.")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Collision layers to be used for the purposes of fading out the screen when the HMD is inside world geometry and adjusting the capsule height.")]
	public LayerMask CollideLayers;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Offset is added to camera's real world height, effectively treating it as though the player was taller/standing higher.")]
	public float HeightOffset;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Minimum height that the character capsule can shrink to.  To disable, set to capsule's height.")]
	public float MinimumHeight;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("Maximum height that the character capsule can grow to.  To disable, set to capsule's height.")]
	public float MaximumHeight;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xD1F344", Offset = "0xD1F344", VA = "0xD1F344")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xD1F34C", Offset = "0xD1F34C", VA = "0xD1F34C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xD1F3C8", Offset = "0xD1F3C8", VA = "0xD1F3C8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xD1F454", Offset = "0xD1F454", VA = "0xD1F454")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xD1F4E0", Offset = "0xD1F4E0", VA = "0xD1F4E0")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xD1F800", Offset = "0xD1F800", VA = "0xD1F800")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xD1FA60", Offset = "0xD1FA60", VA = "0xD1FA60")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000037")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xD201B8", Offset = "0xD201B8", VA = "0xD201B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xD20250", Offset = "0xD20250", VA = "0xD20250")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x2000038")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x2000039")]
	public enum States
	{
		[Token(Token = "0x4000172")]
		Ready,
		[Token(Token = "0x4000173")]
		Aim,
		[Token(Token = "0x4000174")]
		CancelAim,
		[Token(Token = "0x4000175")]
		PreTeleport,
		[Token(Token = "0x4000176")]
		CancelTeleport,
		[Token(Token = "0x4000177")]
		Teleporting,
		[Token(Token = "0x4000178")]
		PostTeleport
	}

	[Token(Token = "0x200003A")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x400017A")]
		None,
		[Token(Token = "0x400017B")]
		Aim,
		[Token(Token = "0x400017C")]
		PreTeleport,
		[Token(Token = "0x400017D")]
		Teleport
	}

	[Token(Token = "0x200003B")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x400017F")]
		Point,
		[Token(Token = "0x4000180")]
		Sphere,
		[Token(Token = "0x4000181")]
		Capsule
	}

	[Token(Token = "0x200003C")]
	public class AimData
	{
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x17000013")]
		public List<Vector3> Points
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0xD21DC8", Offset = "0xD21DC8", VA = "0xD21DC8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0xD21DD0", Offset = "0xD21DD0", VA = "0xD21DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xD21D48", Offset = "0xD21D48", VA = "0xD21D48")]
		public AimData()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xD21DD8", Offset = "0xD21DD8", VA = "0xD21DD8")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000014")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xD21F50", Offset = "0xD21F50", VA = "0xD21F50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xD21F98", Offset = "0xD21F98", VA = "0xD21F98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xD21E30", Offset = "0xD21E30", VA = "0xD21E30")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xD21E58", Offset = "0xD21E58", VA = "0xD21E58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xD21E5C", Offset = "0xD21E5C", VA = "0xD21E5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xD21F58", Offset = "0xD21F58", VA = "0xD21F58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0xD22118", Offset = "0xD22118", VA = "0xD22118", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0xD22160", Offset = "0xD22160", VA = "0xD22160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xD21FA0", Offset = "0xD21FA0", VA = "0xD21FA0")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xD21FC8", Offset = "0xD21FC8", VA = "0xD21FC8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xD21FCC", Offset = "0xD21FCC", VA = "0xD21FCC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xD22120", Offset = "0xD22120", VA = "0xD22120", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xD22238", Offset = "0xD22238", VA = "0xD22238", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0xD22280", Offset = "0xD22280", VA = "0xD22280", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xD22168", Offset = "0xD22168", VA = "0xD22168")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xD22190", Offset = "0xD22190", VA = "0xD22190", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xD22194", Offset = "0xD22194", VA = "0xD22194", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xD22240", Offset = "0xD22240", VA = "0xD22240", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0xD22398", Offset = "0xD22398", VA = "0xD22398", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0xD223E0", Offset = "0xD223E0", VA = "0xD223E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xD22288", Offset = "0xD22288", VA = "0xD22288")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xD222B0", Offset = "0xD222B0", VA = "0xD222B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xD222B4", Offset = "0xD222B4", VA = "0xD222B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xD223A0", Offset = "0xD223A0", VA = "0xD223A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xD224B8", Offset = "0xD224B8", VA = "0xD224B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xD22500", Offset = "0xD22500", VA = "0xD22500", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xD223E8", Offset = "0xD223E8", VA = "0xD223E8")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xD22410", Offset = "0xD22410", VA = "0xD22410", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xD22414", Offset = "0xD22414", VA = "0xD22414", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xD224C0", Offset = "0xD224C0", VA = "0xD224C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0xD22610", Offset = "0xD22610", VA = "0xD22610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0xD22658", Offset = "0xD22658", VA = "0xD22658", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xD22508", Offset = "0xD22508", VA = "0xD22508")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xD22530", Offset = "0xD22530", VA = "0xD22530", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xD22534", Offset = "0xD22534", VA = "0xD22534", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xD22618", Offset = "0xD22618", VA = "0xD22618", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0xD22778", Offset = "0xD22778", VA = "0xD22778", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0xD227C0", Offset = "0xD227C0", VA = "0xD227C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xD22660", Offset = "0xD22660", VA = "0xD22660")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xD22688", Offset = "0xD22688", VA = "0xD22688", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xD2268C", Offset = "0xD2268C", VA = "0xD2268C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xD22780", Offset = "0xD22780", VA = "0xD22780", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Allow linear movement prior to the teleport system being activated.")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Tooltip("Allow linear movement while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[Tooltip("Allow linear movement while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[Tooltip("Allow linear movement after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("Allow rotation prior to the teleport system being activated.")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[Tooltip("Allow rotation while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[Tooltip("Allow rotation while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[Tooltip("Allow rotation after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableRotationDuringPostTeleport;

	[NonSerialized]
	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("This prefab will be instantiated as needed and updated to match the current aim target.")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("TeleportDestinationPrefab will be instantiated into this layer.")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Tooltip("When aiming at possible destinations, the aim collision type determines which shape to use for collision tests.")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Tooltip("Use the character collision radius/height/skinwidth for sphere/capsule collision tests.")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Tooltip("Radius of the sphere or capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionRadius;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Tooltip("Height of the capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionHeight;

	[Token(Token = "0x17000010")]
	public States CurrentState
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0xD202A0", Offset = "0xD202A0", VA = "0xD202A0")]
		[CompilerGenerated]
		get
		{
			return default(States);
		}
		[Token(Token = "0x600013A")]
		[Address(RVA = "0xD202A8", Offset = "0xD202A8", VA = "0xD202A8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0xD20478", Offset = "0xD20478", VA = "0xD20478")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x17000012")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0xD2049C", Offset = "0xD2049C", VA = "0xD2049C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000140")]
		[Address(RVA = "0xD204A4", Offset = "0xD204A4", VA = "0xD204A4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0xD202B0", Offset = "0xD202B0", VA = "0xD202B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600013C")]
		[Address(RVA = "0xD20360", Offset = "0xD20360", VA = "0xD20360")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0xD20AC4", Offset = "0xD20AC4", VA = "0xD20AC4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600014B")]
		[Address(RVA = "0xD20B60", Offset = "0xD20B60", VA = "0xD20B60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x600014D")]
		[Address(RVA = "0xD20BFC", Offset = "0xD20BFC", VA = "0xD20BFC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600014E")]
		[Address(RVA = "0xD20C98", Offset = "0xD20C98", VA = "0xD20C98")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0xD20D34", Offset = "0xD20D34", VA = "0xD20D34")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000150")]
		[Address(RVA = "0xD20DE4", Offset = "0xD20DE4", VA = "0xD20DE4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0xD20EB0", Offset = "0xD20EB0", VA = "0xD20EB0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000153")]
		[Address(RVA = "0xD20F4C", Offset = "0xD20F4C", VA = "0xD20F4C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x6000155")]
		[Address(RVA = "0xD21050", Offset = "0xD21050", VA = "0xD21050")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000156")]
		[Address(RVA = "0xD210EC", Offset = "0xD210EC", VA = "0xD210EC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0xD211F0", Offset = "0xD211F0", VA = "0xD211F0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000159")]
		[Address(RVA = "0xD2128C", Offset = "0xD2128C", VA = "0xD2128C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x600015B")]
		[Address(RVA = "0xD21390", Offset = "0xD21390", VA = "0xD21390")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600015C")]
		[Address(RVA = "0xD2142C", Offset = "0xD2142C", VA = "0xD2142C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x600015E")]
		[Address(RVA = "0xD21530", Offset = "0xD21530", VA = "0xD21530")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600015F")]
		[Address(RVA = "0xD215CC", Offset = "0xD215CC", VA = "0xD215CC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0xD216D0", Offset = "0xD216D0", VA = "0xD216D0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000162")]
		[Address(RVA = "0xD2176C", Offset = "0xD2176C", VA = "0xD2176C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x6000164")]
		[Address(RVA = "0xD21870", Offset = "0xD21870", VA = "0xD21870")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000165")]
		[Address(RVA = "0xD21920", Offset = "0xD21920", VA = "0xD21920")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xD20258", Offset = "0xD20258", VA = "0xD20258")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xD2027C", Offset = "0xD2027C", VA = "0xD2027C")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xD20410", Offset = "0xD20410", VA = "0xD20410")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xD204AC", Offset = "0xD204AC", VA = "0xD204AC")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xD20774", Offset = "0xD20774", VA = "0xD20774")]
	[Conditional("DEBUG_TELEPORT_STATES")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xD2081C", Offset = "0xD2081C", VA = "0xD2081C")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xD208E0", Offset = "0xD208E0", VA = "0xD208E0")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xD208FC", Offset = "0xD208FC", VA = "0xD208FC")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xD209AC", Offset = "0xD209AC", VA = "0xD209AC")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xD209DC", Offset = "0xD209DC", VA = "0xD209DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xD20A30", Offset = "0xD20A30", VA = "0xD20A30", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xD20ABC", Offset = "0xD20ABC", VA = "0xD20ABC", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xD20A54", Offset = "0xD20A54", VA = "0xD20A54")]
	[IteratorStateMachine(typeof(<ReadyStateCoroutine>d__52))]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xD20E94", Offset = "0xD20E94", VA = "0xD20E94")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xD20FE8", Offset = "0xD20FE8", VA = "0xD20FE8")]
	[IteratorStateMachine(typeof(<AimStateCoroutine>d__64))]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xD21188", Offset = "0xD21188", VA = "0xD21188")]
	[IteratorStateMachine(typeof(<CancelAimStateCoroutine>d__68))]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xD21328", Offset = "0xD21328", VA = "0xD21328")]
	[IteratorStateMachine(typeof(<PreTeleportStateCoroutine>d__72))]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xD214C8", Offset = "0xD214C8", VA = "0xD214C8")]
	[IteratorStateMachine(typeof(<CancelTeleportStateCoroutine>d__76))]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xD21668", Offset = "0xD21668", VA = "0xD21668")]
	[IteratorStateMachine(typeof(<TeleportingStateCoroutine>d__80))]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xD21808", Offset = "0xD21808", VA = "0xD21808")]
	[IteratorStateMachine(typeof(<PostTeleportStateCoroutine>d__84))]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xD219D0", Offset = "0xD219D0", VA = "0xD219D0")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xD21AE4", Offset = "0xD21AE4", VA = "0xD21AE4")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xD21B14", Offset = "0xD21B14", VA = "0xD21B14")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xD21C50", Offset = "0xD21C50", VA = "0xD21C50")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xD21D38", Offset = "0xD21D38", VA = "0xD21D38")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x2000044")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000C")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x6000199")]
		[Address(RVA = "0xD227C8", Offset = "0xD227C8", VA = "0xD227C8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600019A")]
		[Address(RVA = "0xD22864", Offset = "0xD22864", VA = "0xD22864")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x600019B")]
		[Address(RVA = "0xD22900", Offset = "0xD22900", VA = "0xD22900")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600019C")]
		[Address(RVA = "0xD2299C", Offset = "0xD2299C", VA = "0xD2299C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xD22A38", Offset = "0xD22A38", VA = "0xD22A38")]
	private void Awake()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xD22AF0", Offset = "0xD22AF0", VA = "0xD22AF0")]
	private void Start()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xD22AF4", Offset = "0xD22AF4", VA = "0xD22AF4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xD22B68", Offset = "0xD22B68", VA = "0xD22B68")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xD22C8C", Offset = "0xD22C8C", VA = "0xD22C8C")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xD22F04", Offset = "0xD22F04", VA = "0xD22F04")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xD23124", Offset = "0xD23124", VA = "0xD23124")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x2000045")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xD23144", Offset = "0xD23144", VA = "0xD23144", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xD231C4", Offset = "0xD231C4", VA = "0xD231C4", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60001A6")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xD23278", Offset = "0xD23278", VA = "0xD23278")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x2000046")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xD23288", Offset = "0xD23288", VA = "0xD23288", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xD23418", Offset = "0xD23418", VA = "0xD23418")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x2000047")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The MinimumElevation is relative to the AimPosition.")]
	public float MinimumElevation;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The Gravity is used in conjunction with AimVelocity and the aim direction to simulate a projectile.")]
	public float Gravity;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("The AimVelocity is the initial speed of the faked projectile.")]
	[Range(0.001f, 50f)]
	public float AimVelocity;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("The AimStep is the how much to subdivide the iteration.")]
	[Range(0.001f, 1f)]
	public float AimStep;

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xD23428", Offset = "0xD23428", VA = "0xD23428", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xD235FC", Offset = "0xD235FC", VA = "0xD235FC")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x2000048")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This prefab will be instantiated when the aim visual is awakened, and will be set active when the user is aiming, and deactivated when they are done aiming.")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xD23610", Offset = "0xD23610", VA = "0xD23610")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xD2371C", Offset = "0xD2371C", VA = "0xD2371C")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xD23748", Offset = "0xD23748", VA = "0xD23748")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xD23774", Offset = "0xD23774", VA = "0xD23774")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xD23810", Offset = "0xD23810", VA = "0xD23810", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xD23870", Offset = "0xD23870", VA = "0xD23870", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xD238CC", Offset = "0xD238CC", VA = "0xD238CC")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x2000049")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("If the target handler provides a target position, this transform will be moved to that position and it's game object enabled. A target position being provided does not mean the position is valid, only that the aim handler found something to test as a destination.")]
	public Transform PositionIndicator;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This transform will be rotated to match the rotation of the aiming target. Simple teleport destinations should assign this to the object containing this component. More complex teleport destinations might assign this to a sub-object that is used to indicate the landing orientation independently from the rest of the destination indicator, such as when world space effects are required. This will typically be a child of the PositionIndicator.")]
	public Transform OrientationIndicator;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("After the player teleports, the character controller will have it's rotation set to this value. It is different from the OrientationIndicator transform.rotation in order to support both head-relative and forward-facing teleport modes (See TeleportOrientationHandlerThumbstick.cs).")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x17000022")]
	public bool IsValidDestination
	{
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xD239C8", Offset = "0xD239C8", VA = "0xD239C8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xD239D0", Offset = "0xD239D0", VA = "0xD239D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xD23B58", Offset = "0xD23B58", VA = "0xD23B58")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xD23C08", Offset = "0xD23C08", VA = "0xD23C08")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xD239DC", Offset = "0xD239DC", VA = "0xD239DC")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xD23A58", Offset = "0xD23A58", VA = "0xD23A58")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xD23B20", Offset = "0xD23B20", VA = "0xD23B20")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xD23B54", Offset = "0xD23B54", VA = "0xD23B54")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xD23CB8", Offset = "0xD23CB8", VA = "0xD23CB8")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xD23CDC", Offset = "0xD23CDC", VA = "0xD23CDC")]
	public void Recycle()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xD23CFC", Offset = "0xD23CFC", VA = "0xD23CFC", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x200004A")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xD24288", Offset = "0xD24288", VA = "0xD24288", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xD242D0", Offset = "0xD242D0", VA = "0xD242D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xD2410C", Offset = "0xD2410C", VA = "0xD2410C")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xD24204", Offset = "0xD24204", VA = "0xD24204", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xD24208", Offset = "0xD24208", VA = "0xD24208", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xD24290", Offset = "0xD24290", VA = "0xD24290", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0xD24368", Offset = "0xD24368", VA = "0xD24368", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0xD243B0", Offset = "0xD243B0", VA = "0xD243B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xD2419C", Offset = "0xD2419C", VA = "0xD2419C")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xD242D8", Offset = "0xD242D8", VA = "0xD242D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xD242DC", Offset = "0xD242DC", VA = "0xD242DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xD24370", Offset = "0xD24370", VA = "0xD24370", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xD23EF0", Offset = "0xD23EF0", VA = "0xD23EF0")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xD23FB0", Offset = "0xD23FB0", VA = "0xD23FB0", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xD23FF4", Offset = "0xD23FF4", VA = "0xD23FF4", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xD240A4", Offset = "0xD240A4", VA = "0xD240A4")]
	[IteratorStateMachine(typeof(<TeleportReadyCoroutine>d__5))]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xD24134", Offset = "0xD24134", VA = "0xD24134")]
	[IteratorStateMachine(typeof(<TeleportAimCoroutine>d__6))]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001C3")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x60001C4")]
	public abstract void GetAimData(out Ray aimRay);
}
[Token(Token = "0x200004D")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("The button used to begin aiming for a teleport.")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("The button used to trigger the teleport after aiming. It can be the same button as the AimButton, however you cannot abort a teleport if it is.")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("When true, the system will not use the PreTeleport intention which will allow a teleport to occur on a button downpress. When false, the button downpress will trigger the PreTeleport intention and the Teleport intention when the button is released.")]
	public bool FastTeleport;

	[Token(Token = "0x17000027")]
	public Transform Pointer
	{
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xD243B8", Offset = "0xD243B8", VA = "0xD243B8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xD243C0", Offset = "0xD243C0", VA = "0xD243C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xD243C8", Offset = "0xD243C8", VA = "0xD243C8", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xD244F4", Offset = "0xD244F4", VA = "0xD244F4", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xD245A8", Offset = "0xD245A8", VA = "0xD245A8")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x200004E")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x200004F")]
	public enum InputModes
	{
		[Token(Token = "0x40001D2")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x40001D3")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x40001D4")]
		ThumbstickTeleport,
		[Token(Token = "0x40001D5")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x2000050")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x40001D7")]
		A,
		[Token(Token = "0x40001D8")]
		B,
		[Token(Token = "0x40001D9")]
		LeftTrigger,
		[Token(Token = "0x40001DA")]
		LeftThumbstick,
		[Token(Token = "0x40001DB")]
		RightTrigger,
		[Token(Token = "0x40001DC")]
		RightThumbstick,
		[Token(Token = "0x40001DD")]
		X,
		[Token(Token = "0x40001DE")]
		Y
	}

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Tooltip("CapacitiveButtonForAimAndTeleport=Activate aiming via cap touch detection, press the same button to teleport.\nSeparateButtonsForAimAndTeleport=Use one button to begin aiming, and another to trigger the teleport.\nThumbstickTeleport=Push a thumbstick to begin aiming, release to teleport.")]
	public InputModes InputMode;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Tooltip("Select the controller to be used for aiming. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Tooltip("Select the button to use for triggering aim and teleport when InputMode==CapacitiveButtonForAimAndTeleport")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[Tooltip("The thumbstick magnitude required to trigger aiming and teleports when InputMode==InputModes.ThumbstickTeleport")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xD245AC", Offset = "0xD245AC", VA = "0xD245AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xD245B0", Offset = "0xD245B0", VA = "0xD245B0", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xD249E4", Offset = "0xD249E4", VA = "0xD249E4", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xD24AA0", Offset = "0xD24AA0", VA = "0xD24AA0")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x2000051")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x2000052")]
	public enum OrientationModes
	{
		[Token(Token = "0x40001E3")]
		HeadRelative,
		[Token(Token = "0x40001E4")]
		ForwardFacing
	}

	[Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xD24F1C", Offset = "0xD24F1C", VA = "0xD24F1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xD24F64", Offset = "0xD24F64", VA = "0xD24F64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xD24D38", Offset = "0xD24D38", VA = "0xD24D38")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xD24E78", Offset = "0xD24E78", VA = "0xD24E78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xD24E7C", Offset = "0xD24E7C", VA = "0xD24E7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xD24F24", Offset = "0xD24F24", VA = "0xD24F24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xD24B78", Offset = "0xD24B78", VA = "0xD24B78")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xD24C4C", Offset = "0xD24C4C", VA = "0xD24C4C")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xD24C54", Offset = "0xD24C54", VA = "0xD24C54", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xD24C94", Offset = "0xD24C94", VA = "0xD24C94", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xD24CD0", Offset = "0xD24CD0", VA = "0xD24CD0")]
	[IteratorStateMachine(typeof(<UpdateOrientationCoroutine>d__7))]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x60001E2")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xD24D60", Offset = "0xD24D60", VA = "0xD24D60")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}
}
[Token(Token = "0x2000054")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xD24F6C", Offset = "0xD24F6C", VA = "0xD24F6C", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xD24F70", Offset = "0xD24F70", VA = "0xD24F70", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xD24FE8", Offset = "0xD24FE8", VA = "0xD24FE8")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x2000055")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Should the destination orientation be updated during the aim state in addition to the PreTeleport state?")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("How far from the destination must the HMD be pointing before using it for orientation")]
	public float AimDistanceThreshold;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[Tooltip("How far from the destination must the HMD be pointing before rejecting the teleport")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xD24FEC", Offset = "0xD24FEC", VA = "0xD24FEC", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xD2503C", Offset = "0xD2503C", VA = "0xD2503C", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xD254B8", Offset = "0xD254B8", VA = "0xD254B8")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x2000056")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Which thumbstick is to be used for adjusting the teleport orientation. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("The orientation will only change if the thumbstick magnitude is above this value. This will usually be larger than the TeleportInputHandlerTouch.ThumbstickTeleportThreshold.")]
	public float RotateStickThreshold;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xD254BC", Offset = "0xD254BC", VA = "0xD254BC", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xD254F4", Offset = "0xD254F4", VA = "0xD254F4", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xD259CC", Offset = "0xD259CC", VA = "0xD259CC")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x2000057")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xD259DC", Offset = "0xD259DC", VA = "0xD259DC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xD259E0", Offset = "0xD259E0", VA = "0xD259E0")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xD259E8", Offset = "0xD259E8", VA = "0xD259E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xD25AD4", Offset = "0xD25AD4", VA = "0xD25AD4")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xD25AF0", Offset = "0xD25AF0", VA = "0xD25AF0")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x2000058")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x1700002A")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xD25B08", Offset = "0xD25B08", VA = "0xD25B08")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xD25B10", Offset = "0xD25B10", VA = "0xD25B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xD23168", Offset = "0xD23168", VA = "0xD23168", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xD23258", Offset = "0xD23258", VA = "0xD23258", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xD25B18", Offset = "0xD25B18", VA = "0xD25B18")]
	[Conditional("DEBUG_TELEPORT_EVENT_HANDLERS")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xD23864", Offset = "0xD23864", VA = "0xD23864", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xD238C4", Offset = "0xD238C4", VA = "0xD238C4", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xD23280", Offset = "0xD23280", VA = "0xD23280")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x2000059")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0xD261C4", Offset = "0xD261C4", VA = "0xD261C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0xD2620C", Offset = "0xD2620C", VA = "0xD2620C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xD25D9C", Offset = "0xD25D9C", VA = "0xD25D9C")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xD25F18", Offset = "0xD25F18", VA = "0xD25F18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xD25F1C", Offset = "0xD25F1C", VA = "0xD25F1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xD261CC", Offset = "0xD261CC", VA = "0xD261CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("This bitmask controls which game object layers will be included in the targeting collision tests.")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x40001FE")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xD25BE8", Offset = "0xD25BE8", VA = "0xD25BE8")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xD25CE0", Offset = "0xD25CE0", VA = "0xD25CE0", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xD25D0C", Offset = "0xD25D0C", VA = "0xD25D0C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xD25D34", Offset = "0xD25D34", VA = "0xD25D34")]
	[IteratorStateMachine(typeof(<TargetAimCoroutine>d__7))]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xD25DC4", Offset = "0xD25DC4", VA = "0xD25DC4", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x6000206")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xD25DDC", Offset = "0xD25DDC", VA = "0xD25DDC", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}
}
[Token(Token = "0x200005B")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xD26214", Offset = "0xD26214", VA = "0xD26214")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xD26274", Offset = "0xD26274", VA = "0xD26274", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xD263E0", Offset = "0xD263E0", VA = "0xD263E0", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xD264D0", Offset = "0xD264D0", VA = "0xD264D0")]
	[Conditional("SHOW_PATH_RESULT")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xD264D4", Offset = "0xD264D4", VA = "0xD264D4")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x200005C")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("When checking line of sight to the destination, add this value to the vertical offset for targeting collision checks.")]
	public float LOSOffset;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Teleport logic will only work with TeleportPoint components that exist in the layers specified by this mask.")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xD264E0", Offset = "0xD264E0", VA = "0xD264E0", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xD266E0", Offset = "0xD266E0", VA = "0xD266E0")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x200005D")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x6000216")]
	[Address(RVA = "0xD266EC", Offset = "0xD266EC", VA = "0xD266EC", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xD26858", Offset = "0xD26858", VA = "0xD26858")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x200005E")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x6000218")]
	[Address(RVA = "0xD2685C", Offset = "0xD2685C", VA = "0xD2685C", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xD268E4", Offset = "0xD268E4", VA = "0xD268E4", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600021A")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xD26968", Offset = "0xD26968", VA = "0xD26968")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x200005F")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x1700002D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0xD26CAC", Offset = "0xD26CAC", VA = "0xD26CAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0xD26CF4", Offset = "0xD26CF4", VA = "0xD26CF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xD269F8", Offset = "0xD269F8", VA = "0xD269F8")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xD26BB0", Offset = "0xD26BB0", VA = "0xD26BB0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xD26BB4", Offset = "0xD26BB4", VA = "0xD26BB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xD26CB4", Offset = "0xD26CB4", VA = "0xD26CB4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("How long the transition takes. Usually this is greater than Teleport Delay.")]
	[Range(0.01f, 2f)]
	public float TransitionDuration;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("At what percentage of the elapsed transition time does the teleport occur?")]
	[Range(0f, 1f)]
	public float TeleportDelay;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Fade to black over the duration of the transition")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xD26970", Offset = "0xD26970", VA = "0xD26970", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xD26990", Offset = "0xD26990", VA = "0xD26990")]
	[IteratorStateMachine(typeof(<BlinkCoroutine>d__4))]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xD26A20", Offset = "0xD26A20", VA = "0xD26A20")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x2000061")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x6000225")]
	[Address(RVA = "0xD26CFC", Offset = "0xD26CFC", VA = "0xD26CFC", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xD26D18", Offset = "0xD26D18", VA = "0xD26D18")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x2000062")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0xD26F24", Offset = "0xD26F24", VA = "0xD26F24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0xD26F6C", Offset = "0xD26F6C", VA = "0xD26F6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xD26DA8", Offset = "0xD26DA8", VA = "0xD26DA8")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xD26E0C", Offset = "0xD26E0C", VA = "0xD26E0C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xD26E10", Offset = "0xD26E10", VA = "0xD26E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xD26F2C", Offset = "0xD26F2C", VA = "0xD26F2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0.01f, 1f)]
	[Tooltip("How much time the warp transition takes to complete.")]
	public float TransitionDuration;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xD26D20", Offset = "0xD26D20", VA = "0xD26D20", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xD26D40", Offset = "0xD26D40", VA = "0xD26D40")]
	[IteratorStateMachine(typeof(<DoWarp>d__3))]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xD26DD0", Offset = "0xD26DD0", VA = "0xD26DD0")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x2000064")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x2000065")]
	public enum PlabackState
	{
		[Token(Token = "0x400022E")]
		Idle = 1,
		[Token(Token = "0x400022F")]
		Preparing,
		[Token(Token = "0x4000230")]
		Buffering,
		[Token(Token = "0x4000231")]
		Ready,
		[Token(Token = "0x4000232")]
		Ended
	}

	[Token(Token = "0x2000066")]
	public enum StereoMode
	{
		[Token(Token = "0x4000234")]
		Unknown = -1,
		[Token(Token = "0x4000235")]
		Mono,
		[Token(Token = "0x4000236")]
		TopBottom,
		[Token(Token = "0x4000237")]
		LeftRight,
		[Token(Token = "0x4000238")]
		Mesh
	}

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getCurrentPlaybackStateMethodId;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x17000031")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x6000230")]
		[Address(RVA = "0xD26F74", Offset = "0xD26F74", VA = "0xD26F74")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000032")]
	private static IntPtr Activity
	{
		[Token(Token = "0x6000231")]
		[Address(RVA = "0xD27264", Offset = "0xD27264", VA = "0xD27264")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000033")]
	public static bool IsAvailable
	{
		[Token(Token = "0x6000232")]
		[Address(RVA = "0xD274E4", Offset = "0xD274E4", VA = "0xD274E4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000034")]
	public static bool IsPlaying
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0xD27558", Offset = "0xD27558", VA = "0xD27558")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000035")]
	public static PlabackState CurrentPlaybackState
	{
		[Token(Token = "0x6000234")]
		[Address(RVA = "0xD2765C", Offset = "0xD2765C", VA = "0xD2765C")]
		get
		{
			return default(PlabackState);
		}
	}

	[Token(Token = "0x17000036")]
	public static long Duration
	{
		[Token(Token = "0x6000235")]
		[Address(RVA = "0xD27764", Offset = "0xD27764", VA = "0xD27764")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000037")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x6000236")]
		[Address(RVA = "0xD2786C", Offset = "0xD2786C", VA = "0xD2786C")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x17000038")]
	public static int VideoWidth
	{
		[Token(Token = "0x6000237")]
		[Address(RVA = "0xD27974", Offset = "0xD27974", VA = "0xD27974")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000039")]
	public static int VideoHeight
	{
		[Token(Token = "0x6000238")]
		[Address(RVA = "0xD27A7C", Offset = "0xD27A7C", VA = "0xD27A7C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003A")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x6000239")]
		[Address(RVA = "0xD27B84", Offset = "0xD27B84", VA = "0xD27B84")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600023A")]
		[Address(RVA = "0xD27C8C", Offset = "0xD27C8C", VA = "0xD27C8C")]
		set
		{
		}
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xD27DEC", Offset = "0xD27DEC", VA = "0xD27DEC")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xD27FF8", Offset = "0xD27FF8", VA = "0xD27FF8")]
	public static void Stop()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xD28100", Offset = "0xD28100", VA = "0xD28100")]
	public static void Play()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xD28208", Offset = "0xD28208", VA = "0xD28208")]
	public static void Pause()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xD28310", Offset = "0xD28310", VA = "0xD28310")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xD28478", Offset = "0xD28478", VA = "0xD28478")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xD285DC", Offset = "0xD285DC", VA = "0xD285DC")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x2000067")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x1400000F")]
	public event Action onButtonDown
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0xD28820", Offset = "0xD28820", VA = "0xD28820")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000244")]
		[Address(RVA = "0xD288BC", Offset = "0xD288BC", VA = "0xD288BC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xD28958", Offset = "0xD28958", VA = "0xD28958", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xD28974", Offset = "0xD28974", VA = "0xD28974")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x2000068")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x2000069")]
	public enum ButtonType
	{
		[Token(Token = "0x400023C")]
		Play,
		[Token(Token = "0x400023D")]
		Pause,
		[Token(Token = "0x400023E")]
		FastForward,
		[Token(Token = "0x400023F")]
		Rewind,
		[Token(Token = "0x4000240")]
		SkipForward,
		[Token(Token = "0x4000241")]
		SkipBack,
		[Token(Token = "0x4000242")]
		Stop
	}

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x1700003B")]
	public ButtonType buttonType
	{
		[Token(Token = "0x6000247")]
		[Address(RVA = "0xD2897C", Offset = "0xD2897C", VA = "0xD2897C")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x6000248")]
		[Address(RVA = "0xD28984", Offset = "0xD28984", VA = "0xD28984")]
		set
		{
		}
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xD289A8", Offset = "0xD289A8", VA = "0xD289A8", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xD297FC", Offset = "0xD297FC", VA = "0xD297FC")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x200006A")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x200006B")]
	public enum VideoShape
	{
		[Token(Token = "0x4000257")]
		_360,
		[Token(Token = "0x4000258")]
		_180,
		[Token(Token = "0x4000259")]
		Quad
	}

	[Token(Token = "0x200006C")]
	public enum VideoStereo
	{
		[Token(Token = "0x400025B")]
		Mono,
		[Token(Token = "0x400025C")]
		TopBottom,
		[Token(Token = "0x400025D")]
		LeftRight,
		[Token(Token = "0x400025E")]
		BottomTop
	}

	[Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x1700003F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0xD2AC94", Offset = "0xD2AC94", VA = "0xD2AC94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0xD2ACDC", Offset = "0xD2ACDC", VA = "0xD2ACDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xD29EA0", Offset = "0xD29EA0", VA = "0xD29EA0")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xD2AAF4", Offset = "0xD2AAF4", VA = "0xD2AAF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xD2AAF8", Offset = "0xD2AAF8", VA = "0xD2AAF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xD2AC9C", Offset = "0xD2AC9C", VA = "0xD2AC9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x1700003C")]
	public bool IsPlaying
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0xD29854", Offset = "0xD29854", VA = "0xD29854")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600024C")]
		[Address(RVA = "0xD2985C", Offset = "0xD2985C", VA = "0xD2985C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public long Duration
	{
		[Token(Token = "0x600024D")]
		[Address(RVA = "0xD29868", Offset = "0xD29868", VA = "0xD29868")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600024E")]
		[Address(RVA = "0xD29870", Offset = "0xD29870", VA = "0xD29870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public long PlaybackPosition
	{
		[Token(Token = "0x600024F")]
		[Address(RVA = "0xD29878", Offset = "0xD29878", VA = "0xD29878")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000250")]
		[Address(RVA = "0xD29880", Offset = "0xD29880", VA = "0xD29880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xD29888", Offset = "0xD29888", VA = "0xD29888")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xD29AD8", Offset = "0xD29AD8", VA = "0xD29AD8")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xD29B38", Offset = "0xD29B38", VA = "0xD29B38")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xD29E38", Offset = "0xD29E38", VA = "0xD29E38")]
	[IteratorStateMachine(typeof(<Start>d__33))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xD29EC8", Offset = "0xD29EC8", VA = "0xD29EC8")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xD2A168", Offset = "0xD2A168", VA = "0xD2A168")]
	public void Play()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xD2A1EC", Offset = "0xD2A1EC", VA = "0xD2A1EC")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xD2A26C", Offset = "0xD2A26C", VA = "0xD2A26C")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0xD2A358", Offset = "0xD2A358", VA = "0xD2A358")]
	private void Update()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xD2A8E8", Offset = "0xD2A8E8", VA = "0xD2A8E8")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0xD2A984", Offset = "0xD2A984", VA = "0xD2A984")]
	public void Stop()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xD2AA04", Offset = "0xD2AA04", VA = "0xD2AA04")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xD2AAE4", Offset = "0xD2AAE4", VA = "0xD2AAE4")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x200006F")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x2000070")]
	private enum PlaybackState
	{
		[Token(Token = "0x400027B")]
		Playing,
		[Token(Token = "0x400027C")]
		Paused,
		[Token(Token = "0x400027D")]
		Rewinding,
		[Token(Token = "0x400027E")]
		FastForwarding
	}

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xD2ADB8", Offset = "0xD2ADB8", VA = "0xD2ADB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xD2B0E4", Offset = "0xD2B0E4", VA = "0xD2B0E4")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xD2B2B4", Offset = "0xD2B2B4", VA = "0xD2B2B4")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xD2B3D8", Offset = "0xD2B3D8", VA = "0xD2B3D8")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xD2B4D4", Offset = "0xD2B4D4", VA = "0xD2B4D4")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xD2B3AC", Offset = "0xD2B3AC", VA = "0xD2B3AC")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xD2B534", Offset = "0xD2B534", VA = "0xD2B534")]
	private void Update()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xD2AFE4", Offset = "0xD2AFE4", VA = "0xD2AFE4")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xD2B840", Offset = "0xD2B840", VA = "0xD2B840")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x2000071")]
public static class VectorUtil
{
	[Token(Token = "0x600026F")]
	[Address(RVA = "0xD2A870", Offset = "0xD2A870", VA = "0xD2A870")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x2000072")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x400027F")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x4000280")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xD2B850", Offset = "0xD2B850", VA = "0xD2B850")]
	private void Start()
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xD2BE40", Offset = "0xD2BE40", VA = "0xD2BE40")]
	private void Update()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xD2C09C", Offset = "0xD2C09C", VA = "0xD2C09C")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xD2C200", Offset = "0xD2C200", VA = "0xD2C200")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0xD2C368", Offset = "0xD2C368", VA = "0xD2C368")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0xD2C4EC", Offset = "0xD2C4EC", VA = "0xD2C4EC")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x2000073")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x4000289")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x6000276")]
	[Address(RVA = "0xD2C4FC", Offset = "0xD2C4FC", VA = "0xD2C4FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0xD2C548", Offset = "0xD2C548", VA = "0xD2C548")]
	private void Start()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xD2C54C", Offset = "0xD2C54C", VA = "0xD2C54C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xD2BC00", Offset = "0xD2BC00", VA = "0xD2BC00")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0xD2C550", Offset = "0xD2C550", VA = "0xD2C550")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xD2C76C", Offset = "0xD2C76C", VA = "0xD2C76C")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x2000074")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xD2C774", Offset = "0xD2C774", VA = "0xD2C774")]
	private void Start()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xD2CCC4", Offset = "0xD2CCC4", VA = "0xD2CCC4")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xD2CD70", Offset = "0xD2CD70", VA = "0xD2CD70")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xD2CF88", Offset = "0xD2CF88", VA = "0xD2CF88")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0xD2D05C", Offset = "0xD2D05C", VA = "0xD2D05C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0xD2D134", Offset = "0xD2D134", VA = "0xD2D134")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0xD2D19C", Offset = "0xD2D19C", VA = "0xD2D19C")]
	public DebugUISample()
	{
	}
}
[Token(Token = "0x2000075")]
public class AnalyticsUI : MonoBehaviour
{
	[Token(Token = "0x6000287")]
	[Address(RVA = "0xD2D344", Offset = "0xD2D344", VA = "0xD2D344")]
	public AnalyticsUI()
	{
	}
}
[Token(Token = "0x2000076")]
public class SampleUI : MonoBehaviour
{
	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform collectionButton;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform inputText;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform valueText;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool inMenu;

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xD2D34C", Offset = "0xD2D34C", VA = "0xD2D34C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xD2D3E4", Offset = "0xD2D3E4", VA = "0xD2D3E4")]
	private void Update()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xD2D4BC", Offset = "0xD2D4BC", VA = "0xD2D4BC")]
	private string GetText()
	{
		return null;
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xD2D518", Offset = "0xD2D518", VA = "0xD2D518")]
	public SampleUI()
	{
	}
}
[Token(Token = "0x2000077")]
public class StartCrashlytics : MonoBehaviour
{
	[Token(Token = "0x600028C")]
	[Address(RVA = "0xD2D520", Offset = "0xD2D520", VA = "0xD2D520")]
	public StartCrashlytics()
	{
	}
}
[Token(Token = "0x2000078")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0xD2D8EC", Offset = "0xD2D8EC", VA = "0xD2D8EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0xD2D934", Offset = "0xD2D934", VA = "0xD2D934", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xD2D7B4", Offset = "0xD2D7B4", VA = "0xD2D7B4")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xD2D7E4", Offset = "0xD2D7E4", VA = "0xD2D7E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xD2D7E8", Offset = "0xD2D7E8", VA = "0xD2D7E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xD2D8F4", Offset = "0xD2D8F4", VA = "0xD2D8F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xD2D528", Offset = "0xD2D528", VA = "0xD2D528")]
	private void Awake()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xD2D61C", Offset = "0xD2D61C", VA = "0xD2D61C")]
	private void Update()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0xD2D5B4", Offset = "0xD2D5B4", VA = "0xD2D5B4")]
	[IteratorStateMachine(typeof(<GetCenterEye>d__6))]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xD2D7DC", Offset = "0xD2D7DC", VA = "0xD2D7DC")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x200007A")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(4f, 32f)]
	public int SubdivisionsU;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(4f, 32f)]
	public int SubdivisionsV;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xD2D93C", Offset = "0xD2D93C", VA = "0xD2D93C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xD2F2A8", Offset = "0xD2F2A8", VA = "0xD2F2A8")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x200007B")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x17000043")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x6000299")]
		[Address(RVA = "0xD2F2B0", Offset = "0xD2F2B0", VA = "0xD2F2B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xD2F300", Offset = "0xD2F300", VA = "0xD2F300")]
	public void Start()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xD2F72C", Offset = "0xD2F72C", VA = "0xD2F72C")]
	public void Update()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0xD2F804", Offset = "0xD2F804", VA = "0xD2F804")]
	[Conditional("DEBUG_LOCOMOTION_PANEL")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x600029D")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600029E")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x600029F")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x60002A0")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x60002A1")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x60002A2")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x60002A3")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x60002A4")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xD2F85C", Offset = "0xD2F85C", VA = "0xD2F85C")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xD2F89C", Offset = "0xD2F89C", VA = "0xD2F89C")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xD2F908", Offset = "0xD2F908", VA = "0xD2F908")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xD2FA54", Offset = "0xD2FA54", VA = "0xD2FA54")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xD2FB24", Offset = "0xD2FB24", VA = "0xD2FB24")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xD2F608", Offset = "0xD2F608", VA = "0xD2F608")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xD2FBF4", Offset = "0xD2FBF4", VA = "0xD2FBF4")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xD2FC40", Offset = "0xD2FC40", VA = "0xD2FC40")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xD2FD50", Offset = "0xD2FD50", VA = "0xD2FD50")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x200007C")]
[RequireComponent(typeof(Canvas))]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x200007D")]
	public enum DrawMode
	{
		[Token(Token = "0x40002B8")]
		Opaque,
		[Token(Token = "0x40002B9")]
		OpaqueWithClip,
		[Token(Token = "0x40002BA")]
		TransparentDefaultAlpha,
		[Token(Token = "0x40002BB")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private Shader _transparentShader;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	private Shader _opaqueShader;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x17000044")]
	public bool overlayEnabled
	{
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xD312AC", Offset = "0xD312AC", VA = "0xD312AC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xD31330", Offset = "0xD31330", VA = "0xD31330")]
		set
		{
		}
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xD2FD58", Offset = "0xD2FD58", VA = "0xD2FD58")]
	private void Start()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xD30934", Offset = "0xD30934", VA = "0xD30934")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xD309A8", Offset = "0xD309A8", VA = "0xD309A8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xD30A78", Offset = "0xD30A78", VA = "0xD30A78")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xD30B48", Offset = "0xD30B48", VA = "0xD30B48", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xD30D4C", Offset = "0xD30D4C", VA = "0xD30D4C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xD313EC", Offset = "0xD313EC", VA = "0xD313EC")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x200007E")]
public class AugmentedObject : MonoBehaviour
{
	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform shadow;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool groundShadow;

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xD3149C", Offset = "0xD3149C", VA = "0xD3149C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xD31670", Offset = "0xD31670", VA = "0xD31670")]
	private void Update()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xD31804", Offset = "0xD31804", VA = "0xD31804")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xD3180C", Offset = "0xD3180C", VA = "0xD3180C")]
	public void Release()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xD317F4", Offset = "0xD317F4", VA = "0xD317F4")]
	private void ToggleShadowType()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xD31814", Offset = "0xD31814", VA = "0xD31814")]
	public AugmentedObject()
	{
	}
}
[Token(Token = "0x200007F")]
public class BrushController : MonoBehaviour
{
	[Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class <FadeCameraClearColor>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeTime;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color newColor;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timer>5__2;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000045")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0xD31ED0", Offset = "0xD31ED0", VA = "0xD31ED0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xD31F18", Offset = "0xD31F18", VA = "0xD31F18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xD31D8C", Offset = "0xD31D8C", VA = "0xD31D8C")]
		[DebuggerHidden]
		public <FadeCameraClearColor>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xD31DE4", Offset = "0xD31DE4", VA = "0xD31DE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xD31DE8", Offset = "0xD31DE8", VA = "0xD31DE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xD31ED8", Offset = "0xD31ED8", VA = "0xD31ED8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class <FadeSphere>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushController <>4__this;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool disableOnFinish;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0xD32090", Offset = "0xD32090", VA = "0xD32090", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0xD320D8", Offset = "0xD320D8", VA = "0xD320D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xD31DB4", Offset = "0xD31DB4", VA = "0xD31DB4")]
		[DebuggerHidden]
		public <FadeSphere>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xD31F20", Offset = "0xD31F20", VA = "0xD31F20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xD31F24", Offset = "0xD31F24", VA = "0xD31F24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xD32098", Offset = "0xD32098", VA = "0xD32098", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PassthroughBrush brush;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer backgroundSphere;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator grabRoutine;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator releaseRoutine;

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xD3181C", Offset = "0xD3181C", VA = "0xD3181C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xD31AC4", Offset = "0xD31AC4", VA = "0xD31AC4")]
	private void Update()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xD31B14", Offset = "0xD31B14", VA = "0xD31B14")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xD31C68", Offset = "0xD31C68", VA = "0xD31C68")]
	public void Release()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xD31CF4", Offset = "0xD31CF4", VA = "0xD31CF4")]
	[IteratorStateMachine(typeof(<FadeCameraClearColor>d__8))]
	private IEnumerator FadeCameraClearColor(Color newColor, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xD31BB4", Offset = "0xD31BB4", VA = "0xD31BB4")]
	[IteratorStateMachine(typeof(<FadeSphere>d__9))]
	private IEnumerator FadeSphere(Color newColor, float fadeTime, bool disableOnFinish = false)
	{
		return null;
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xD31DDC", Offset = "0xD31DDC", VA = "0xD31DDC")]
	public BrushController()
	{
	}
}
[Token(Token = "0x2000082")]
public class EnableUnpremultipliedAlpha : MonoBehaviour
{
	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xD320E0", Offset = "0xD320E0", VA = "0xD320E0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xD32134", Offset = "0xD32134", VA = "0xD32134")]
	public EnableUnpremultipliedAlpha()
	{
	}
}
[Token(Token = "0x2000083")]
public class Flashlight : MonoBehaviour
{
	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lightVolume;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light spotlight;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bulbGlow;

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xD3213C", Offset = "0xD3213C", VA = "0xD3213C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xD32310", Offset = "0xD32310", VA = "0xD32310")]
	public void ToggleFlashlight()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xD323A0", Offset = "0xD323A0", VA = "0xD323A0")]
	public void EnableFlashlight(bool doEnable)
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xD323FC", Offset = "0xD323FC", VA = "0xD323FC")]
	public Flashlight()
	{
	}
}
[Token(Token = "0x2000084")]
public class FlashlightController : MonoBehaviour
{
	[Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class <FadeLighting>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlashlightController <>4__this;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sceneLightIntensity;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <currentLight>5__4;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xD33548", Offset = "0xD33548", VA = "0xD33548", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xD33590", Offset = "0xD33590", VA = "0xD33590", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xD332BC", Offset = "0xD332BC", VA = "0xD332BC")]
		[DebuggerHidden]
		public <FadeLighting>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xD33384", Offset = "0xD33384", VA = "0xD33384", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xD33388", Offset = "0xD33388", VA = "0xD33388", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xD33550", Offset = "0xD33550", VA = "0xD33550", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light sceneLight;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform flashlightRoot;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 localPosition;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion localRotation;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh infoText;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrabObject externalController;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private OVRSkeleton[] skeletons;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand[] hands;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int handIndex;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool pinching;

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xD32404", Offset = "0xD32404", VA = "0xD32404")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xD326A8", Offset = "0xD326A8", VA = "0xD326A8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xD32994", Offset = "0xD32994", VA = "0xD32994")]
	private void FindHands()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xD32C8C", Offset = "0xD32C8C", VA = "0xD32C8C")]
	private void AlignWithHand(OVRHand hand, OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xD32F64", Offset = "0xD32F64", VA = "0xD32F64")]
	private void AlignWithController(OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xD3304C", Offset = "0xD3304C", VA = "0xD3304C")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xD331D8", Offset = "0xD331D8", VA = "0xD331D8")]
	public void Release()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xD33134", Offset = "0xD33134", VA = "0xD33134")]
	[IteratorStateMachine(typeof(<FadeLighting>d__17))]
	private IEnumerator FadeLighting(Color newColor, float sceneLightIntensity, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xD332E4", Offset = "0xD332E4", VA = "0xD332E4")]
	public FlashlightController()
	{
	}
}
[Token(Token = "0x2000086")]
public class GrabObject : MonoBehaviour
{
	[Token(Token = "0x2000087")]
	public enum ManipulationType
	{
		[Token(Token = "0x40002F0")]
		Default,
		[Token(Token = "0x40002F1")]
		ForcedHand,
		[Token(Token = "0x40002F2")]
		DollyHand,
		[Token(Token = "0x40002F3")]
		DollyAttached,
		[Token(Token = "0x40002F4")]
		HorizontalScaled,
		[Token(Token = "0x40002F5")]
		VerticalScaled,
		[Token(Token = "0x40002F6")]
		Menu
	}

	[Token(Token = "0x2000088")]
	public delegate void GrabbedObject(OVRInput.Controller grabHand);

	[Token(Token = "0x2000089")]
	public delegate void ReleasedObject();

	[Token(Token = "0x200008A")]
	public delegate void SetCursorPosition(Vector3 cursorPosition);

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[TextArea]
	public string ObjectName;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[TextArea]
	public string ObjectInstructions;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ManipulationType objectManipulationType;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool showLaserWhileGrabbed;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Quaternion grabbedRotation;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabbedObject GrabbedObjectDelegate;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ReleasedObject ReleasedObjectDelegate;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SetCursorPosition CursorPositionDelegate;

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xD33598", Offset = "0xD33598", VA = "0xD33598")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xD335F8", Offset = "0xD335F8", VA = "0xD335F8")]
	public void Release()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xD33614", Offset = "0xD33614", VA = "0xD33614")]
	public void CursorPos(Vector3 cursorPos)
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xD33630", Offset = "0xD33630", VA = "0xD33630")]
	public GrabObject()
	{
	}
}
[Token(Token = "0x200008B")]
public class HandMeshMask : MonoBehaviour
{
	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSkeleton referenceHand;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material maskMaterial;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The segments around the tip of a finger")]
	public int radialDivisions;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The fade range (finger width is 2x this)")]
	public float borderSize;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Along the fingers, each knuckle scales down by this amount.  Default is zero for uniform width along entire finger.")]
	public float fingerTaper;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("Shorten the last bone of each finger; need this to account for bone structure (end bone is at finger tip instead of center). Default is 1.")]
	public float fingerTipLength;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Move the base of the 4 main fingers towards the tips, to avoid a visible mesh crack between finger webbing. Default is 0.")]
	public float webOffset;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float handScale;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject maskMeshObject;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Mesh maskMesh;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] handVertices;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2[] handUVs;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color32[] handColors;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] handTriangles;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int vertCounter;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int triCounter;

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xD33A58", Offset = "0xD33A58", VA = "0xD33A58")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xD33C8C", Offset = "0xD33C8C", VA = "0xD33C8C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xD33E54", Offset = "0xD33E54", VA = "0xD33E54")]
	private void CreateHandMesh()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xD3445C", Offset = "0xD3445C", VA = "0xD3445C")]
	private void AddKnuckleMesh(int knuckleVerts, float point1scale, float point2scale, Vector3 point1, Vector3 point2)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xD349F4", Offset = "0xD349F4", VA = "0xD349F4")]
	private void AddPalmMesh(int knuckleVerts)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xD36CFC", Offset = "0xD36CFC", VA = "0xD36CFC")]
	private void AddVertex(Vector3 position, Vector2 uv, Color color)
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xD37070", Offset = "0xD37070", VA = "0xD37070")]
	public HandMeshMask()
	{
	}
}
[Token(Token = "0x200008C")]
public class HandMeshUI : MonoBehaviour
{
	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider[] knobs;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh[] readouts;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rightHeldKnob;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int leftHeldKnob;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRSkeleton leftHand;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OVRSkeleton rightHand;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HandMeshMask leftMask;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HandMeshMask rightMask;

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xD37094", Offset = "0xD37094", VA = "0xD37094")]
	private void Start()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xD373FC", Offset = "0xD373FC", VA = "0xD373FC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xD37130", Offset = "0xD37130", VA = "0xD37130")]
	private void SetSliderValue(int sliderID, float value, bool isNormalized)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0xD37864", Offset = "0xD37864", VA = "0xD37864")]
	private void CheckForHands()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0xD37DD4", Offset = "0xD37DD4", VA = "0xD37DD4")]
	public HandMeshUI()
	{
	}
}
[Token(Token = "0x200008D")]
public class ObjectManipulator : MonoBehaviour
{
	[Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class <StartDemo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectManipulator <>4__this;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fadeTime>5__3;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0xD3A5C0", Offset = "0xD3A5C0", VA = "0xD3A5C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0xD3A608", Offset = "0xD3A608", VA = "0xD3A608", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xD39F0C", Offset = "0xD39F0C", VA = "0xD39F0C")]
		[DebuggerHidden]
		public <StartDemo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xD3A2F4", Offset = "0xD3A2F4", VA = "0xD3A2F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xD3A2F8", Offset = "0xD3A2F8", VA = "0xD3A2F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xD3A5C8", Offset = "0xD3A5C8", VA = "0xD3A5C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRInput.Controller controller;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject hoverObject;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject grabObject;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float grabTime;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 localGrabOffset;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion localGrabRotation;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 camGrabPosition;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion camGrabRotation;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 handGrabPosition;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion handGrabRotation;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 cursorPosition;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float rotationOffset;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LineRenderer laser;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform objectInfo;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMesh objectNameLabel;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMesh objectInstructionsLabel;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image objectInfoBG;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject demoObjects;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OVRPassthroughLayer passthrough;

	[Token(Token = "0x6000302")]
	[Address(RVA = "0xD37DE4", Offset = "0xD37DE4", VA = "0xD37DE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0xD37FD4", Offset = "0xD37FD4", VA = "0xD37FD4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0xD38E80", Offset = "0xD38E80", VA = "0xD38E80")]
	private void GrabHoverObject(GameObject grbObj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xD39C14", Offset = "0xD39C14", VA = "0xD39C14")]
	private void ReleaseObject()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xD37F6C", Offset = "0xD37F6C", VA = "0xD37F6C")]
	[IteratorStateMachine(typeof(<StartDemo>d__23))]
	private IEnumerator StartDemo()
	{
		return null;
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xD3821C", Offset = "0xD3821C", VA = "0xD3821C")]
	private void FindHoverObject(Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xD39174", Offset = "0xD39174", VA = "0xD39174")]
	private void ManipulateObject(GameObject obj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0xD39F34", Offset = "0xD39F34", VA = "0xD39F34")]
	private void ClampGrabOffset(ref Vector3 localOffset, float thumbY)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0xD39FE8", Offset = "0xD39FE8", VA = "0xD39FE8")]
	private Vector3 ClampScale(Vector3 localScale, Vector2 thumb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0xD3A018", Offset = "0xD3A018", VA = "0xD3A018")]
	private void CheckForDominantHand()
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0xD39DF0", Offset = "0xD39DF0", VA = "0xD39DF0")]
	private void AssignInstructions(GrabObject targetObject)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0xD3A108", Offset = "0xD3A108", VA = "0xD3A108")]
	public ObjectManipulator()
	{
	}
}
[Token(Token = "0x200008F")]
public class OverlayPassthrough : MonoBehaviour
{
	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xD3A610", Offset = "0xD3A610", VA = "0xD3A610")]
	private void Start()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xD3A770", Offset = "0xD3A770", VA = "0xD3A770")]
	private void Update()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xD3A824", Offset = "0xD3A824", VA = "0xD3A824")]
	public OverlayPassthrough()
	{
	}
}
[Token(Token = "0x2000090")]
public class PassthroughBrush : MonoBehaviour
{
	[Token(Token = "0x2000091")]
	public enum BrushState
	{
		[Token(Token = "0x4000333")]
		Idle,
		[Token(Token = "0x4000334")]
		Inking
	}

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lineSegmentPrefab;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lineContainer;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool forceActive;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer currentLineSegment;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> inkPositions;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float minInkDist;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float strokeWidth;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float strokeLength;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private BrushState brushStatus;

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xD3A82C", Offset = "0xD3A82C", VA = "0xD3A82C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0xD3A834", Offset = "0xD3A834", VA = "0xD3A834")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0xD3AAE4", Offset = "0xD3AAE4", VA = "0xD3AAE4")]
	private void StartLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xD3AD04", Offset = "0xD3AD04", VA = "0xD3AD04")]
	private void UpdateLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0xD3AF44", Offset = "0xD3AF44", VA = "0xD3AF44")]
	public void ClearLines()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xD3A9FC", Offset = "0xD3A9FC", VA = "0xD3A9FC")]
	public void UndoInkLine()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xD3B014", Offset = "0xD3B014", VA = "0xD3B014")]
	public PassthroughBrush()
	{
	}
}
[Token(Token = "0x2000092")]
public class PassthroughController : MonoBehaviour
{
	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xD3B0A4", Offset = "0xD3B0A4", VA = "0xD3B0A4")]
	private void Start()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xD3B204", Offset = "0xD3B204", VA = "0xD3B204")]
	private void Update()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xD3B3F0", Offset = "0xD3B3F0", VA = "0xD3B3F0")]
	public PassthroughController()
	{
	}
}
[Token(Token = "0x2000093")]
public class PassthroughProjectionSurface : MonoBehaviour
{
	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer quadOutline;

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xD3B3F8", Offset = "0xD3B3F8", VA = "0xD3B3F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xD3B5C0", Offset = "0xD3B5C0", VA = "0xD3B5C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0xD3B760", Offset = "0xD3B760", VA = "0xD3B760")]
	public PassthroughProjectionSurface()
	{
	}
}
[Token(Token = "0x2000094")]
public class PassthroughStyler : MonoBehaviour
{
	[Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class <FadeToCurrentStyle>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0xD3C340", Offset = "0xD3C340", VA = "0xD3C340", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0xD3C388", Offset = "0xD3C388", VA = "0xD3C388", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xD3C0B4", Offset = "0xD3C0B4", VA = "0xD3C0B4")]
		[DebuggerHidden]
		public <FadeToCurrentStyle>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xD3C1F8", Offset = "0xD3C1F8", VA = "0xD3C1F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xD3C1FC", Offset = "0xD3C1FC", VA = "0xD3C1FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xD3C348", Offset = "0xD3C348", VA = "0xD3C348", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class <FadeToDefaultPassthrough>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0xD3C4F0", Offset = "0xD3C4F0", VA = "0xD3C4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0xD3C538", Offset = "0xD3C538", VA = "0xD3C538", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xD3C0DC", Offset = "0xD3C0DC", VA = "0xD3C0DC")]
		[DebuggerHidden]
		public <FadeToDefaultPassthrough>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xD3C390", Offset = "0xD3C390", VA = "0xD3C390", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xD3C394", Offset = "0xD3C394", VA = "0xD3C394", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xD3C4F8", Offset = "0xD3C4F8", VA = "0xD3C4F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator fadeIn;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator fadeOut;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform[] menuOptions;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform colorWheel;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D colorTexture;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool settingColor;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color savedColor;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float savedBrightness;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float savedContrast;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public CanvasGroup mainCanvas;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject[] compactObjects;

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xD3B768", Offset = "0xD3B768", VA = "0xD3B768")]
	private void Start()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0xD3BA70", Offset = "0xD3BA70", VA = "0xD3BA70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0xD3BE10", Offset = "0xD3BE10", VA = "0xD3BE10")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0xD3BF68", Offset = "0xD3BF68", VA = "0xD3BF68")]
	public void Release()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0xD3BEF0", Offset = "0xD3BEF0", VA = "0xD3BEF0")]
	[IteratorStateMachine(typeof(<FadeToCurrentStyle>d__18))]
	private IEnumerator FadeToCurrentStyle(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xD3C03C", Offset = "0xD3C03C", VA = "0xD3C03C")]
	[IteratorStateMachine(typeof(<FadeToDefaultPassthrough>d__19))]
	private IEnumerator FadeToDefaultPassthrough(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xD3C104", Offset = "0xD3C104", VA = "0xD3C104")]
	public void OnBrightnessChanged(float newValue)
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xD3C124", Offset = "0xD3C124", VA = "0xD3C124")]
	public void OnContrastChanged(float newValue)
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0xD3C144", Offset = "0xD3C144", VA = "0xD3C144")]
	public void OnAlphaChanged(float newValue)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0xD3BA08", Offset = "0xD3BA08", VA = "0xD3BA08")]
	private void ShowFullMenu(bool doShow)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0xD3C178", Offset = "0xD3C178", VA = "0xD3C178")]
	public void Cursor(Vector3 cP)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0xD3C184", Offset = "0xD3C184", VA = "0xD3C184")]
	public void DoColorDrag(bool doDrag)
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0xD3BA88", Offset = "0xD3BA88", VA = "0xD3BA88")]
	public void GetColorFromWheel()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xD3C190", Offset = "0xD3C190", VA = "0xD3C190")]
	public PassthroughStyler()
	{
	}
}
[Token(Token = "0x2000097")]
public class PassthroughSurface : MonoBehaviour
{
	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xD3C540", Offset = "0xD3C540", VA = "0xD3C540")]
	private void Start()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xD3C5F4", Offset = "0xD3C5F4", VA = "0xD3C5F4")]
	public PassthroughSurface()
	{
	}
}
[Token(Token = "0x2000098")]
public class SceneSampler : MonoBehaviour
{
	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentSceneIndex;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject displayText;

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xD3C5FC", Offset = "0xD3C5FC", VA = "0xD3C5FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xD3C668", Offset = "0xD3C668", VA = "0xD3C668")]
	private void Update()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xD3C95C", Offset = "0xD3C95C", VA = "0xD3C95C")]
	public SceneSampler()
	{
	}
}
[Token(Token = "0x2000099")]
public class SelectivePassthroughExperience : MonoBehaviour
{
	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftMaskObject;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightMaskObject;

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xD3C964", Offset = "0xD3C964", VA = "0xD3C964")]
	private void Update()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xD3CDB8", Offset = "0xD3CDB8", VA = "0xD3CDB8")]
	public SelectivePassthroughExperience()
	{
	}
}
[Token(Token = "0x200009A")]
public class SPPquad : MonoBehaviour
{
	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRInput.Controller controllerHand;

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xD3CDC0", Offset = "0xD3CDC0", VA = "0xD3CDC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xD3CFE0", Offset = "0xD3CFE0", VA = "0xD3CFE0")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xD3D02C", Offset = "0xD3D02C", VA = "0xD3D02C")]
	public void Release()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xD3D06C", Offset = "0xD3D06C", VA = "0xD3D06C")]
	public SPPquad()
	{
	}
}
[Token(Token = "0x200009B")]
public class BouncingBallLogic : MonoBehaviour
{
	[Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class <PlayPopCallback>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float clipLength;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BouncingBallLogic <>4__this;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0xD3D758", Offset = "0xD3D758", VA = "0xD3D758", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0xD3D7A0", Offset = "0xD3D7A0", VA = "0xD3D7A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xD3D62C", Offset = "0xD3D62C", VA = "0xD3D62C")]
		[DebuggerHidden]
		public <PlayPopCallback>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xD3D66C", Offset = "0xD3D66C", VA = "0xD3D66C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xD3D670", Offset = "0xD3D670", VA = "0xD3D670", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xD3D760", Offset = "0xD3D760", VA = "0xD3D760", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float TTL;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip pop;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip bounce;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip loadball;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material visibleMat;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Material hiddenMat;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource audioSource;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform centerEyeCamera;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isVisible;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float timer;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isReleased;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool isReadyForDestroy;

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xD3D074", Offset = "0xD3D074", VA = "0xD3D074")]
	private void OnCollisionEnter()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0xD3D098", Offset = "0xD3D098", VA = "0xD3D098")]
	private void Start()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xD3D188", Offset = "0xD3D188", VA = "0xD3D188")]
	private void Update()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xD3D22C", Offset = "0xD3D22C", VA = "0xD3D22C")]
	private void UpdateVisibility()
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xD3D474", Offset = "0xD3D474", VA = "0xD3D474")]
	private void SetVisible(bool setVisible)
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0xD3D518", Offset = "0xD3D518", VA = "0xD3D518")]
	public void Release(Vector3 pos, Vector3 vel, Vector3 angVel)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xD3D3FC", Offset = "0xD3D3FC", VA = "0xD3D3FC")]
	[IteratorStateMachine(typeof(<PlayPopCallback>d__18))]
	private IEnumerator PlayPopCallback(float clipLength)
	{
		return null;
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xD3D654", Offset = "0xD3D654", VA = "0xD3D654")]
	public BouncingBallLogic()
	{
	}
}
[Token(Token = "0x200009D")]
public class BouncingBallMgr : MonoBehaviour
{
	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform trackingspace;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject rightControllerPivot;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private OVRInput.RawButton actionBtn;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject ball;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject currentBall;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool ballGrabbed;

	[Token(Token = "0x6000357")]
	[Address(RVA = "0xD3D7A8", Offset = "0xD3D7A8", VA = "0xD3D7A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0xD3DAA4", Offset = "0xD3DAA4", VA = "0xD3DAA4")]
	public BouncingBallMgr()
	{
	}
}
[Token(Token = "0x200009E")]
[DefaultExecutionOrder(30)]
[RequireComponent(typeof(OVRSceneAnchor))]
public class FurnitureSpawner : MonoBehaviour
{
	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Add a point at ceiling.")]
	public GameObject RoomLightPrefab;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Spawnable> SpawnablePrefabs;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRSceneAnchor _sceneAnchor;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private OVRSemanticClassification _classification;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject _roomLightRef;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _frameCounter;

	[Token(Token = "0x6000359")]
	[Address(RVA = "0xD3DAAC", Offset = "0xD3DAAC", VA = "0xD3DAAC")]
	private void Start()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0xD3DC90", Offset = "0xD3DC90", VA = "0xD3DC90")]
	private void SpawnSpawnable()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0xD3E100", Offset = "0xD3E100", VA = "0xD3E100")]
	private bool FindValidSpawnable(out Spawnable currentSpawnable)
	{
		return default(bool);
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xD3DB34", Offset = "0xD3DB34", VA = "0xD3DB34")]
	private void AddRoomLight()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xD3E304", Offset = "0xD3E304", VA = "0xD3E304")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xD3E7F0", Offset = "0xD3E7F0", VA = "0xD3E7F0")]
	public FurnitureSpawner()
	{
	}
}
[Token(Token = "0x200009F")]
public class MyCustomSceneModelLoader : OVRSceneModelLoader
{
	[Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class <DelayedLoad>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MyCustomSceneModelLoader <>4__this;

		[Token(Token = "0x17000053")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0xD3EA0C", Offset = "0xD3EA0C", VA = "0xD3EA0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0xD3EA54", Offset = "0xD3EA54", VA = "0xD3EA54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xD3E860", Offset = "0xD3E860", VA = "0xD3E860")]
		[DebuggerHidden]
		public <DelayedLoad>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xD3E918", Offset = "0xD3E918", VA = "0xD3E918", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xD3E91C", Offset = "0xD3E91C", VA = "0xD3E91C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xD3EA14", Offset = "0xD3EA14", VA = "0xD3EA14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xD3E7F8", Offset = "0xD3E7F8", VA = "0xD3E7F8")]
	[IteratorStateMachine(typeof(<DelayedLoad>d__0))]
	private IEnumerator DelayedLoad()
	{
		return null;
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xD3E888", Offset = "0xD3E888", VA = "0xD3E888", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xD3E8A8", Offset = "0xD3E8A8", VA = "0xD3E8A8", Slot = "6")]
	protected override void OnNoSceneModelToLoad()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xD3E910", Offset = "0xD3E910", VA = "0xD3E910")]
	public MyCustomSceneModelLoader()
	{
	}
}
[Token(Token = "0x20000A1")]
[RequireComponent(typeof(OVRManager))]
public class PassthroughPlayInEditor : MonoBehaviour
{
	[Token(Token = "0x6000369")]
	[Address(RVA = "0xD3EA5C", Offset = "0xD3EA5C", VA = "0xD3EA5C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0xD3EA60", Offset = "0xD3EA60", VA = "0xD3EA60")]
	public PassthroughPlayInEditor()
	{
	}
}
[Token(Token = "0x20000A2")]
public class RequestCaptureFlow : MonoBehaviour
{
	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Button RequestCaptureBtn;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRSceneManager _sceneManager;

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xD3EA68", Offset = "0xD3EA68", VA = "0xD3EA68")]
	private void Start()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0xD3EAD8", Offset = "0xD3EAD8", VA = "0xD3EAD8")]
	private void Update()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xD3EB5C", Offset = "0xD3EB5C", VA = "0xD3EB5C")]
	public RequestCaptureFlow()
	{
	}
}
[Token(Token = "0x20000A3")]
[ExecuteInEditMode]
public class SimpleResizable : MonoBehaviour
{
	[Token(Token = "0x20000A4")]
	public enum Method
	{
		[Token(Token = "0x4000390")]
		Adapt,
		[Token(Token = "0x4000391")]
		AdaptWithAsymmetricalPadding,
		[Token(Token = "0x4000392")]
		Scale,
		[Token(Token = "0x4000393")]
		None
	}

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(15f)]
	public Method ScalingX;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 0.5f)]
	public float PaddingX;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(-0.5f, 0f)]
	public float PaddingXMax;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space(15f)]
	public Method ScalingY;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 0.5f)]
	public float PaddingY;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(-0.5f, 0f)]
	public float PaddingYMax;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space(15f)]
	public Method ScalingZ;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0f, 0.5f)]
	public float PaddingZ;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(-0.5f, 0f)]
	public float PaddingZMax;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Bounds _bounds;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform _pivotTransform;

	[Token(Token = "0x17000055")]
	public Vector3 PivotPosition
	{
		[Token(Token = "0x600036E")]
		[Address(RVA = "0xD3EB6C", Offset = "0xD3EB6C", VA = "0xD3EB6C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000056")]
	public Vector3 NewSize
	{
		[Token(Token = "0x600036F")]
		[Address(RVA = "0xD3EB88", Offset = "0xD3EB88", VA = "0xD3EB88")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000370")]
		[Address(RVA = "0xD3EB94", Offset = "0xD3EB94", VA = "0xD3EB94")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000057")]
	public Vector3 DefaultSize
	{
		[Token(Token = "0x6000371")]
		[Address(RVA = "0xD3EBA0", Offset = "0xD3EBA0", VA = "0xD3EBA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000372")]
		[Address(RVA = "0xD3EBAC", Offset = "0xD3EBAC", VA = "0xD3EBAC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000058")]
	public Mesh Mesh
	{
		[Token(Token = "0x6000373")]
		[Address(RVA = "0xD3EBB8", Offset = "0xD3EBB8", VA = "0xD3EBB8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000374")]
		[Address(RVA = "0xD3EBC0", Offset = "0xD3EBC0", VA = "0xD3EBC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xD3EBC8", Offset = "0xD3EBC8", VA = "0xD3EBC8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xD3ECD8", Offset = "0xD3ECD8", VA = "0xD3ECD8")]
	public SimpleResizable()
	{
	}
}
[Token(Token = "0x20000A5")]
public class SimpleResizer
{
	[Token(Token = "0x6000377")]
	[Address(RVA = "0xD3E45C", Offset = "0xD3E45C", VA = "0xD3E45C")]
	public void CreateResizedObject(Vector3 newSize, GameObject parent, SimpleResizable sourcePrefab)
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xD3ECE0", Offset = "0xD3ECE0", VA = "0xD3ECE0")]
	private Mesh ProcessVertices(SimpleResizable resizable, Vector3 newSize)
	{
		return null;
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xD3EF64", Offset = "0xD3EF64", VA = "0xD3EF64")]
	private float CalculateNewVertexPosition(SimpleResizable.Method resizeMethod, float currentPosition, float currentSize, float newSize, float padding, float paddingMax, float pivot)
	{
		return default(float);
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0xD3E454", Offset = "0xD3E454", VA = "0xD3E454")]
	public SimpleResizer()
	{
	}
}
[Serializable]
[Token(Token = "0x20000A6")]
public class Spawnable : ISerializationCallbackReceiver
{
	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public SimpleResizable ResizablePrefab;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ClassificationLabel;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _editorClassificationIndex;

	[Token(Token = "0x600037B")]
	[Address(RVA = "0xD3F00C", Offset = "0xD3F00C", VA = "0xD3F00C", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0xD3F010", Offset = "0xD3F010", VA = "0xD3F010", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0xD3F478", Offset = "0xD3F478", VA = "0xD3F478")]
	public Spawnable()
	{
	}
}
[Token(Token = "0x20000A7")]
[RequireComponent(typeof(OVRSceneAnchor))]
public class VolumeAndPlaneSwitcher : MonoBehaviour
{
	[Token(Token = "0x20000A8")]
	public enum GeometryType
	{
		[Token(Token = "0x400039B")]
		Plane,
		[Token(Token = "0x400039C")]
		Volume
	}

	[Serializable]
	[Token(Token = "0x20000A9")]
	public struct LabelGeometryPair
	{
		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string label;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GeometryType desiredGeometryType;
	}

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSceneAnchor planePrefab;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRSceneAnchor volumePrefab;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<LabelGeometryPair> desiredSwitches;

	[Token(Token = "0x600037F")]
	[Address(RVA = "0xD3F4C8", Offset = "0xD3F4C8", VA = "0xD3F4C8")]
	private void ReplaceAnchor(OVRSceneAnchor prefab, Vector3 position, Quaternion rotation, Vector3 localScale)
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0xD3F8F4", Offset = "0xD3F8F4", VA = "0xD3F8F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xD4022C", Offset = "0xD4022C", VA = "0xD4022C")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xD40104", Offset = "0xD40104", VA = "0xD40104")]
	private void GetTopPlaneFromVolume(Transform volume, Vector3 dimensions, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xD402AC", Offset = "0xD402AC", VA = "0xD402AC")]
	public VolumeAndPlaneSwitcher()
	{
	}
}
[Token(Token = "0x20000AA")]
[RequireComponent(typeof(OVRSpatialAnchor))]
public class Anchor : MonoBehaviour
{
	[Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class <Start>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Anchor <>4__this;

		[Token(Token = "0x1700005A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0xD41000", Offset = "0xD41000", VA = "0xD41000", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0xD41048", Offset = "0xD41048", VA = "0xD41048", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xD40464", Offset = "0xD40464", VA = "0xD40464")]
		[DebuggerHidden]
		public <Start>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xD40E90", Offset = "0xD40E90", VA = "0xD40E90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xD40E94", Offset = "0xD40E94", VA = "0xD40E94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xD41008", Offset = "0xD41008", VA = "0xD41008", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400039F")]
	public const string NumUuidsPlayerPref = "numUuids";

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("canvas_")]
	[SerializeField]
	private Canvas _canvas;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("pivot_")]
	[SerializeField]
	private Transform _pivot;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("anchorMenu_")]
	private GameObject _anchorMenu;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _isSelected;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool _isHovered;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[FormerlySerializedAs("anchorName_")]
	private TextMeshProUGUI _anchorName;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("saveIcon_")]
	private GameObject _saveIcon;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("labelImage_")]
	[SerializeField]
	private Image _labelImage;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[FormerlySerializedAs("labelBaseColor_")]
	[SerializeField]
	private Color _labelBaseColor;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[FormerlySerializedAs("labelHighlightColor_")]
	private Color _labelHighlightColor;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	[FormerlySerializedAs("labelSelectedColor_")]
	private Color _labelSelectedColor;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	[FormerlySerializedAs("uiManager_")]
	private AnchorUIManager _uiManager;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[FormerlySerializedAs("renderers_")]
	private MeshRenderer[] _renderers;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _menuIndex;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	[FormerlySerializedAs("buttonList_")]
	private List<Button> _buttonList;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Button _selectedButton;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private OVRSpatialAnchor _spatialAnchor;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject _icon;

	[Token(Token = "0x17000059")]
	public bool ShowSaveIcon
	{
		[Token(Token = "0x600038A")]
		[Address(RVA = "0xD40910", Offset = "0xD40910", VA = "0xD40910")]
		set
		{
		}
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xD402B4", Offset = "0xD402B4", VA = "0xD402B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xD403FC", Offset = "0xD403FC", VA = "0xD403FC")]
	[IteratorStateMachine(typeof(<Start>d__20))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0xD4048C", Offset = "0xD4048C", VA = "0xD4048C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0xD40704", Offset = "0xD40704", VA = "0xD40704")]
	public void OnSaveLocalButtonPressed()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xD407D4", Offset = "0xD407D4", VA = "0xD407D4")]
	public void OnHideButtonPressed()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xD40840", Offset = "0xD40840", VA = "0xD40840")]
	public void OnEraseButtonPressed()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0xD40930", Offset = "0xD40930", VA = "0xD40930")]
	public void OnHoverStart()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xD40A4C", Offset = "0xD40A4C", VA = "0xD40A4C")]
	public void OnHoverEnd()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0xD40B54", Offset = "0xD40B54", VA = "0xD40B54")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0xD404DC", Offset = "0xD404DC", VA = "0xD404DC")]
	private void BillboardPanel(Transform panel)
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xD40610", Offset = "0xD40610", VA = "0xD40610")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xD40C14", Offset = "0xD40C14", VA = "0xD40C14")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xD40D38", Offset = "0xD40D38", VA = "0xD40D38")]
	public Anchor()
	{
	}
}
[Token(Token = "0x20000AC")]
[RequireComponent(typeof(SpatialAnchorLoader))]
public class AnchorUIManager : MonoBehaviour
{
	[Token(Token = "0x20000AD")]
	public enum AnchorMode
	{
		[Token(Token = "0x40003C8")]
		Create,
		[Token(Token = "0x40003C9")]
		Select
	}

	[Token(Token = "0x20000AE")]
	private delegate void PrimaryPressDelegate();

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorUIManager Instance;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("createModeButton_")]
	[SerializeField]
	private GameObject _createModeButton;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("selectModeButton_")]
	private GameObject _selectModeButton;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("trackedDevice_")]
	private Transform _trackedDevice;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _raycastOrigin;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _drawRaycast;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("lineRenderer_")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Anchor _hoveredAnchor;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Anchor _selectedAnchor;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AnchorMode _mode;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[FormerlySerializedAs("buttonList_")]
	private List<Button> _buttonList;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _menuIndex;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Button _selectedButton;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Anchor _anchorPrefab;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	[FormerlySerializedAs("placementPreview_")]
	private GameObject _placementPreview;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[FormerlySerializedAs("anchorPlacementTransform_")]
	private Transform _anchorPlacementTransform;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PrimaryPressDelegate _primaryPressDelegate;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool _isFocused;

	[Token(Token = "0x1700005C")]
	public Anchor AnchorPrefab
	{
		[Token(Token = "0x600039A")]
		[Address(RVA = "0xD41050", Offset = "0xD41050", VA = "0xD41050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xD41058", Offset = "0xD41058", VA = "0xD41058")]
	private void Awake()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xD41118", Offset = "0xD41118", VA = "0xD41118")]
	private void Start()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0xD41238", Offset = "0xD41238", VA = "0xD41238")]
	private void Update()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xD416AC", Offset = "0xD416AC", VA = "0xD416AC")]
	public void OnCreateModeButtonPressed()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xD41718", Offset = "0xD41718", VA = "0xD41718")]
	public void OnLoadAnchorsButtonPressed()
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0xD411E8", Offset = "0xD411E8", VA = "0xD411E8")]
	private void ToggleCreateMode()
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0xD418DC", Offset = "0xD418DC", VA = "0xD418DC")]
	private void StartPlacementMode()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0xD4195C", Offset = "0xD4195C", VA = "0xD4195C")]
	private void EndPlacementMode()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0xD41974", Offset = "0xD41974", VA = "0xD41974")]
	private void StartSelectMode()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0xD418C4", Offset = "0xD418C4", VA = "0xD418C4")]
	private void EndSelectMode()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0xD415B8", Offset = "0xD415B8", VA = "0xD415B8")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xD41B5C", Offset = "0xD41B5C", VA = "0xD41B5C")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0xD419F4", Offset = "0xD419F4", VA = "0xD419F4")]
	private void ShowAnchorPreview()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xD41AD0", Offset = "0xD41AD0", VA = "0xD41AD0")]
	private void HideAnchorPreview()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0xD41C48", Offset = "0xD41C48", VA = "0xD41C48")]
	private void PlaceAnchor()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0xD41AF0", Offset = "0xD41AF0", VA = "0xD41AF0")]
	private void ShowRaycastLine()
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0xD41B28", Offset = "0xD41B28", VA = "0xD41B28")]
	private void HideRaycastLine()
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0xD41338", Offset = "0xD41338", VA = "0xD41338")]
	private void ControllerRaycast()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xD41D34", Offset = "0xD41D34", VA = "0xD41D34")]
	private void HoverAnchor(Anchor anchor)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0xD41D50", Offset = "0xD41D50", VA = "0xD41D50")]
	private void UnhoverAnchor()
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0xD41DCC", Offset = "0xD41DCC", VA = "0xD41DCC")]
	private void SelectAnchor()
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0xD41EE4", Offset = "0xD41EE4", VA = "0xD41EE4")]
	public AnchorUIManager()
	{
	}
}
[Token(Token = "0x20000AF")]
public class SpatialAnchorLoader : MonoBehaviour
{
	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRSpatialAnchor _anchorPrefab;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly HashSet<ulong> _locateAnchorRequest;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ulong _queryRequestId;

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0xD41F34", Offset = "0xD41F34", VA = "0xD41F34")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0xD42034", Offset = "0xD42034", VA = "0xD42034")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0xD42134", Offset = "0xD42134", VA = "0xD42134")]
	private void SetComponentEnabled(ulong requestId, bool result, OVRSpace space, Guid uuid, OVRPlugin.SpaceComponentType componentType, bool enabled)
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0xD42388", Offset = "0xD42388", VA = "0xD42388")]
	private void QueryComplete(ulong requestId, bool result)
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0xD42594", Offset = "0xD42594", VA = "0xD42594")]
	private void TryEnableComponent(ulong anchorHandle, OVRPlugin.SpaceComponentType type)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xD428F8", Offset = "0xD428F8", VA = "0xD428F8")]
	public void LoadAnchorsByUuid()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xD4176C", Offset = "0xD4176C", VA = "0xD4176C")]
	public void LoadAllLocalAnchors()
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xD422FC", Offset = "0xD422FC", VA = "0xD422FC")]
	private static void Log(string message)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0xD42B6C", Offset = "0xD42B6C", VA = "0xD42B6C")]
	public SpatialAnchorLoader()
	{
	}
}
[Token(Token = "0x20000B0")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0xD42BE8", Offset = "0xD42BE8", VA = "0xD42BE8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0xD42DEC", Offset = "0xD42DEC", VA = "0xD42DEC")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0xD42EF0", Offset = "0xD42EF0", VA = "0xD42EF0")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x20000B2")]
public class PruebaVibration : MonoBehaviour
{
	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Tween vibrationEffectCombo;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Vibration")]
	private VibrationManager _vibrationManager;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("Vibration Animation")]
	public float delay;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int loops;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float amplitude;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float timeVibration;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("Vibration Combo")]
	public float amplitudeCombo;

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0xD42F14", Offset = "0xD42F14", VA = "0xD42F14")]
	[Inject]
	private void Construct(VibrationManager vibrationManager)
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xD42F1C", Offset = "0xD42F1C", VA = "0xD42F1C")]
	public void OnVibrationHandLeft()
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0xD42F20", Offset = "0xD42F20", VA = "0xD42F20")]
	public void OnVibrationHandRight()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0xD42F24", Offset = "0xD42F24", VA = "0xD42F24")]
	public void OFFVibrationHandLeft()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0xD42F44", Offset = "0xD42F44", VA = "0xD42F44")]
	public void OFFVibrationHandRight()
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0xD42F64", Offset = "0xD42F64", VA = "0xD42F64")]
	public void ActivarCombo()
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0xD42F88", Offset = "0xD42F88", VA = "0xD42F88")]
	public void EffectCombo()
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0xD43058", Offset = "0xD43058", VA = "0xD43058")]
	public PruebaVibration()
	{
	}
}
[Token(Token = "0x20000B3")]
public class OddersInputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	[Token(Token = "0x20000B4")]
	public struct OddersHMDActions
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private OddersInputActions m_Wrapper;

		[Token(Token = "0x17000066")]
		public InputAction Position
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0xD43AA0", Offset = "0xD43AA0", VA = "0xD43AA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public InputAction Rotation
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0xD43ABC", Offset = "0xD43ABC", VA = "0xD43ABC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public bool enabled
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0xD43B3C", Offset = "0xD43B3C", VA = "0xD43B3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xD43A98", Offset = "0xD43A98", VA = "0xD43A98")]
		public OddersHMDActions(OddersInputActions wrapper)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xD43AD8", Offset = "0xD43AD8", VA = "0xD43AD8")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xD43AF4", Offset = "0xD43AF4", VA = "0xD43AF4")]
		public void Enable()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xD43B18", Offset = "0xD43B18", VA = "0xD43B18")]
		public void Disable()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xD43B60", Offset = "0xD43B60", VA = "0xD43B60")]
		public static implicit operator InputActionMap(OddersHMDActions set)
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xD43B78", Offset = "0xD43B78", VA = "0xD43B78")]
		public void SetCallbacks(IOddersHMDActions instance)
		{
		}
	}

	[Token(Token = "0x20000B5")]
	public struct OddersLeftHandActions
	{
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private OddersInputActions m_Wrapper;

		[Token(Token = "0x17000069")]
		public InputAction Position
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xD44304", Offset = "0xD44304", VA = "0xD44304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public InputAction Rotation
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0xD44320", Offset = "0xD44320", VA = "0xD44320")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public InputAction Grip
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0xD4433C", Offset = "0xD4433C", VA = "0xD4433C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public InputAction Trigger
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0xD44358", Offset = "0xD44358", VA = "0xD44358")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public InputAction HapticDevice
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0xD44374", Offset = "0xD44374", VA = "0xD44374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public InputAction SwapUIRay
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0xD44390", Offset = "0xD44390", VA = "0xD44390")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public InputAction ScrollUi
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0xD443AC", Offset = "0xD443AC", VA = "0xD443AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public InputAction Menu
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0xD443C8", Offset = "0xD443C8", VA = "0xD443C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public InputAction PrimaryButton
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0xD443E4", Offset = "0xD443E4", VA = "0xD443E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public InputAction SecundaryButton
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0xD44400", Offset = "0xD44400", VA = "0xD44400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public InputAction Velocity
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0xD4441C", Offset = "0xD4441C", VA = "0xD4441C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public InputAction Acceleration
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xD44438", Offset = "0xD44438", VA = "0xD44438")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public InputAction AngularAcceleration
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xD44454", Offset = "0xD44454", VA = "0xD44454")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public InputAction GrabAction
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0xD44470", Offset = "0xD44470", VA = "0xD44470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public InputAction Pause
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0xD4448C", Offset = "0xD4448C", VA = "0xD4448C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public bool enabled
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xD4450C", Offset = "0xD4450C", VA = "0xD4450C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xD442FC", Offset = "0xD442FC", VA = "0xD442FC")]
		public OddersLeftHandActions(OddersInputActions wrapper)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xD444A8", Offset = "0xD444A8", VA = "0xD444A8")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xD444C4", Offset = "0xD444C4", VA = "0xD444C4")]
		public void Enable()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xD444E8", Offset = "0xD444E8", VA = "0xD444E8")]
		public void Disable()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xD44530", Offset = "0xD44530", VA = "0xD44530")]
		public static implicit operator InputActionMap(OddersLeftHandActions set)
		{
			return null;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xD44548", Offset = "0xD44548", VA = "0xD44548")]
		public void SetCallbacks(IOddersLeftHandActions instance)
		{
		}
	}

	[Token(Token = "0x20000B6")]
	public struct OddersRightHandActions
	{
		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private OddersInputActions m_Wrapper;

		[Token(Token = "0x17000079")]
		public InputAction Position
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0xD47B24", Offset = "0xD47B24", VA = "0xD47B24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public InputAction Rotation
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0xD47B40", Offset = "0xD47B40", VA = "0xD47B40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public InputAction Grip
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0xD47B5C", Offset = "0xD47B5C", VA = "0xD47B5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public InputAction Trigger
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xD47B78", Offset = "0xD47B78", VA = "0xD47B78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public InputAction HapticDevice
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0xD47B94", Offset = "0xD47B94", VA = "0xD47B94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public InputAction SwapUIRay
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xD47BB0", Offset = "0xD47BB0", VA = "0xD47BB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public InputAction ScrollUi
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xD47BCC", Offset = "0xD47BCC", VA = "0xD47BCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public InputAction Menu
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0xD47BE8", Offset = "0xD47BE8", VA = "0xD47BE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public InputAction PrimaryButton
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0xD47C04", Offset = "0xD47C04", VA = "0xD47C04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public InputAction SecundaryButton
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0xD47C20", Offset = "0xD47C20", VA = "0xD47C20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public InputAction Velocity
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0xD47C3C", Offset = "0xD47C3C", VA = "0xD47C3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public InputAction Acceleration
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0xD47C58", Offset = "0xD47C58", VA = "0xD47C58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public InputAction AngularAcceleration
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0xD47C74", Offset = "0xD47C74", VA = "0xD47C74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public InputAction Pause
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0xD47C90", Offset = "0xD47C90", VA = "0xD47C90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public InputAction VoiceActivation
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0xD47CAC", Offset = "0xD47CAC", VA = "0xD47CAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		public InputAction ShowFullVersion
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0xD47CC8", Offset = "0xD47CC8", VA = "0xD47CC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public bool enabled
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0xD47D48", Offset = "0xD47D48", VA = "0xD47D48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xD47B1C", Offset = "0xD47B1C", VA = "0xD47B1C")]
		public OddersRightHandActions(OddersInputActions wrapper)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xD47CE4", Offset = "0xD47CE4", VA = "0xD47CE4")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xD47D00", Offset = "0xD47D00", VA = "0xD47D00")]
		public void Enable()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xD47D24", Offset = "0xD47D24", VA = "0xD47D24")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xD47D6C", Offset = "0xD47D6C", VA = "0xD47D6C")]
		public static implicit operator InputActionMap(OddersRightHandActions set)
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xD47D84", Offset = "0xD47D84", VA = "0xD47D84")]
		public void SetCallbacks(IOddersRightHandActions instance)
		{
		}
	}

	[Token(Token = "0x20000B7")]
	public interface IOddersHMDActions
	{
		[Token(Token = "0x6000416")]
		void OnPosition(InputAction.CallbackContext context);

		[Token(Token = "0x6000417")]
		void OnRotation(InputAction.CallbackContext context);
	}

	[Token(Token = "0x20000B8")]
	public interface IOddersLeftHandActions
	{
		[Token(Token = "0x6000418")]
		void OnPosition(InputAction.CallbackContext context);

		[Token(Token = "0x6000419")]
		void OnRotation(InputAction.CallbackContext context);

		[Token(Token = "0x600041A")]
		void OnGrip(InputAction.CallbackContext context);

		[Token(Token = "0x600041B")]
		void OnTrigger(InputAction.CallbackContext context);

		[Token(Token = "0x600041C")]
		void OnHapticDevice(InputAction.CallbackContext context);

		[Token(Token = "0x600041D")]
		void OnSwapUIRay(InputAction.CallbackContext context);

		[Token(Token = "0x600041E")]
		void OnScrollUi(InputAction.CallbackContext context);

		[Token(Token = "0x600041F")]
		void OnMenu(InputAction.CallbackContext context);

		[Token(Token = "0x6000420")]
		void OnPrimaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x6000421")]
		void OnSecundaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x6000422")]
		void OnVelocity(InputAction.CallbackContext context);

		[Token(Token = "0x6000423")]
		void OnAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x6000424")]
		void OnAngularAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x6000425")]
		void OnGrabAction(InputAction.CallbackContext context);

		[Token(Token = "0x6000426")]
		void OnPause(InputAction.CallbackContext context);
	}

	[Token(Token = "0x20000B9")]
	public interface IOddersRightHandActions
	{
		[Token(Token = "0x6000427")]
		void OnPosition(InputAction.CallbackContext context);

		[Token(Token = "0x6000428")]
		void OnRotation(InputAction.CallbackContext context);

		[Token(Token = "0x6000429")]
		void OnGrip(InputAction.CallbackContext context);

		[Token(Token = "0x600042A")]
		void OnTrigger(InputAction.CallbackContext context);

		[Token(Token = "0x600042B")]
		void OnHapticDevice(InputAction.CallbackContext context);

		[Token(Token = "0x600042C")]
		void OnSwapUIRay(InputAction.CallbackContext context);

		[Token(Token = "0x600042D")]
		void OnScrollUi(InputAction.CallbackContext context);

		[Token(Token = "0x600042E")]
		void OnMenu(InputAction.CallbackContext context);

		[Token(Token = "0x600042F")]
		void OnPrimaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x6000430")]
		void OnSecundaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x6000431")]
		void OnVelocity(InputAction.CallbackContext context);

		[Token(Token = "0x6000432")]
		void OnAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x6000433")]
		void OnAngularAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x6000434")]
		void OnPause(InputAction.CallbackContext context);

		[Token(Token = "0x6000435")]
		void OnVoiceActivation(InputAction.CallbackContext context);

		[Token(Token = "0x6000436")]
		void OnShowFullVersion(InputAction.CallbackContext context);
	}

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly InputActionMap m_OddersHMD;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private IOddersHMDActions m_OddersHMDActionsCallbackInterface;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputAction m_OddersHMD_Position;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly InputAction m_OddersHMD_Rotation;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly InputActionMap m_OddersLeftHand;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private IOddersLeftHandActions m_OddersLeftHandActionsCallbackInterface;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly InputAction m_OddersLeftHand_Position;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly InputAction m_OddersLeftHand_Rotation;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly InputAction m_OddersLeftHand_Grip;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly InputAction m_OddersLeftHand_Trigger;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly InputAction m_OddersLeftHand_HapticDevice;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly InputAction m_OddersLeftHand_SwapUIRay;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly InputAction m_OddersLeftHand_ScrollUi;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly InputAction m_OddersLeftHand_Menu;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly InputAction m_OddersLeftHand_PrimaryButton;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly InputAction m_OddersLeftHand_SecundaryButton;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly InputAction m_OddersLeftHand_Velocity;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly InputAction m_OddersLeftHand_Acceleration;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly InputAction m_OddersLeftHand_AngularAcceleration;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly InputAction m_OddersLeftHand_GrabAction;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly InputAction m_OddersLeftHand_Pause;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly InputActionMap m_OddersRightHand;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private IOddersRightHandActions m_OddersRightHandActionsCallbackInterface;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly InputAction m_OddersRightHand_Position;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly InputAction m_OddersRightHand_Rotation;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly InputAction m_OddersRightHand_Grip;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly InputAction m_OddersRightHand_Trigger;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly InputAction m_OddersRightHand_HapticDevice;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly InputAction m_OddersRightHand_SwapUIRay;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly InputAction m_OddersRightHand_ScrollUi;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly InputAction m_OddersRightHand_Menu;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly InputAction m_OddersRightHand_PrimaryButton;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly InputAction m_OddersRightHand_SecundaryButton;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly InputAction m_OddersRightHand_Velocity;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly InputAction m_OddersRightHand_Acceleration;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly InputAction m_OddersRightHand_AngularAcceleration;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly InputAction m_OddersRightHand_Pause;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly InputAction m_OddersRightHand_VoiceActivation;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly InputAction m_OddersRightHand_ShowFullVersion;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private int m_GenericXRControllerSchemeIndex;

	[Token(Token = "0x1700005D")]
	public InputActionAsset asset
	{
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xD4308C", Offset = "0xD4308C", VA = "0xD4308C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005E")]
	public InputBinding? bindingMask
	{
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xD43788", Offset = "0xD43788", VA = "0xD43788", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xD437B0", Offset = "0xD437B0", VA = "0xD437B0", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x1700005F")]
	public ReadOnlyArray<InputDevice>? devices
	{
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xD437FC", Offset = "0xD437FC", VA = "0xD437FC", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xD4383C", Offset = "0xD4383C", VA = "0xD4383C", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x17000060")]
	public ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xD43888", Offset = "0xD43888", VA = "0xD43888", Slot = "11")]
		get
		{
			return default(ReadOnlyArray<InputControlScheme>);
		}
	}

	[Token(Token = "0x17000061")]
	public IEnumerable<InputBinding> bindings
	{
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xD43930", Offset = "0xD43930", VA = "0xD43930", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000062")]
	public OddersHMDActions OddersHMD
	{
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xD439C8", Offset = "0xD439C8", VA = "0xD439C8")]
		get
		{
			return default(OddersHMDActions);
		}
	}

	[Token(Token = "0x17000063")]
	public OddersLeftHandActions OddersLeftHand
	{
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xD439CC", Offset = "0xD439CC", VA = "0xD439CC")]
		get
		{
			return default(OddersLeftHandActions);
		}
	}

	[Token(Token = "0x17000064")]
	public OddersRightHandActions OddersRightHand
	{
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xD439D0", Offset = "0xD439D0", VA = "0xD439D0")]
		get
		{
			return default(OddersRightHandActions);
		}
	}

	[Token(Token = "0x17000065")]
	public InputControlScheme GenericXRControllerScheme
	{
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xD439D4", Offset = "0xD439D4", VA = "0xD439D4")]
		get
		{
			return default(InputControlScheme);
		}
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0xD43094", Offset = "0xD43094", VA = "0xD43094")]
	public OddersInputActions()
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0xD4372C", Offset = "0xD4372C", VA = "0xD4372C", Slot = "17")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0xD438A4", Offset = "0xD438A4", VA = "0xD438A4", Slot = "12")]
	public bool Contains(InputAction action)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0xD438C0", Offset = "0xD438C0", VA = "0xD438C0", Slot = "15")]
	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0xD438DC", Offset = "0xD438DC", VA = "0xD438DC", Slot = "16")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0xD438F8", Offset = "0xD438F8", VA = "0xD438F8", Slot = "13")]
	public void Enable()
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0xD43914", Offset = "0xD43914", VA = "0xD43914", Slot = "14")]
	public void Disable()
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0xD4394C", Offset = "0xD4394C", VA = "0xD4394C", Slot = "5")]
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
	{
		return null;
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0xD4396C", Offset = "0xD4396C", VA = "0xD4396C", Slot = "6")]
	public int FindBinding(InputBinding bindingMask, out InputAction action)
	{
		return default(int);
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x20000BA")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x1700008A")]
		public bool Highlight
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0xD4B6E8", Offset = "0xD4B6E8", VA = "0xD4B6E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000438")]
			[Address(RVA = "0xD4B6F0", Offset = "0xD4B6F0", VA = "0xD4B6F0")]
			set
			{
			}
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xD4B6FC", Offset = "0xD4B6FC", VA = "0xD4B6FC")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xD4B89C", Offset = "0xD4B89C", VA = "0xD4B89C", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xD4B8B8", Offset = "0xD4B8B8", VA = "0xD4B8B8", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xD4B8D4", Offset = "0xD4B8D4", VA = "0xD4B8D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xD4B7A8", Offset = "0xD4B7A8", VA = "0xD4B7A8")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xD4BB38", Offset = "0xD4BB38", VA = "0xD4BB38")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x1700008B")]
		public bool InRange
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0xD4BBB0", Offset = "0xD4BBB0", VA = "0xD4BBB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000441")]
			[Address(RVA = "0xD4BBB8", Offset = "0xD4BBB8", VA = "0xD4BBB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public bool Targeted
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0xD4BD24", Offset = "0xD4BD24", VA = "0xD4BD24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000443")]
			[Address(RVA = "0xD4BD2C", Offset = "0xD4BD2C", VA = "0xD4BD2C")]
			set
			{
			}
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xD4BD38", Offset = "0xD4BD38", VA = "0xD4BD38", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xD4BBC4", Offset = "0xD4BBC4", VA = "0xD4BBC4")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xD4BEF4", Offset = "0xD4BEF4", VA = "0xD4BEF4")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[RequireComponent(typeof(Rigidbody))]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x1700008D")]
		public bool UseSpherecast
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0xD4BEFC", Offset = "0xD4BEFC", VA = "0xD4BEFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0xD4BF04", Offset = "0xD4BF04", VA = "0xD4BF04")]
			set
			{
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xD4BF20", Offset = "0xD4BF20", VA = "0xD4BF20", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xD4C124", Offset = "0xD4C124", VA = "0xD4C124", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xD4C9B8", Offset = "0xD4C9B8", VA = "0xD4C9B8", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xD4CF0C", Offset = "0xD4CF0C", VA = "0xD4CF0C", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xD4D31C", Offset = "0xD4D31C", VA = "0xD4D31C")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xD4C32C", Offset = "0xD4C32C", VA = "0xD4C32C")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xD4D408", Offset = "0xD4D408", VA = "0xD4D408")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xD4D7A8", Offset = "0xD4D7A8", VA = "0xD4D7A8", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xD4D7C0", Offset = "0xD4D7C0", VA = "0xD4D7C0", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xD4D7C8", Offset = "0xD4D7C8", VA = "0xD4D7C8")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x20000BE")]
		public enum CrosshairState
		{
			[Token(Token = "0x4000423")]
			Disabled,
			[Token(Token = "0x4000424")]
			Enabled,
			[Token(Token = "0x4000425")]
			Targeted
		}

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xD4D7E8", Offset = "0xD4D7E8", VA = "0xD4D7E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xD4BE68", Offset = "0xD4BE68", VA = "0xD4BE68")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xD4D848", Offset = "0xD4D848", VA = "0xD4D848")]
		private void Update()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xD4D880", Offset = "0xD4D880", VA = "0xD4D880")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xD4D888", Offset = "0xD4D888", VA = "0xD4D888")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xD4D934", Offset = "0xD4D934", VA = "0xD4D934")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xD4D9DC", Offset = "0xD4D9DC", VA = "0xD4D9DC")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x600045A")]
		[Address(RVA = "0xD4D9E4", Offset = "0xD4D9E4", VA = "0xD4D9E4")]
		private void Start()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xD4DAD0", Offset = "0xD4DAD0", VA = "0xD4DAD0")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xD4DADC", Offset = "0xD4DADC", VA = "0xD4DADC")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xD4DAE8", Offset = "0xD4DAE8", VA = "0xD4DAE8")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xD4DAF0", Offset = "0xD4DAF0", VA = "0xD4DAF0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xD4DB40", Offset = "0xD4DB40", VA = "0xD4DB40")]
		private void Update()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xD4DF08", Offset = "0xD4DF08", VA = "0xD4DF08")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xD4DFF4", Offset = "0xD4DFF4", VA = "0xD4DFF4")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xD4DB44", Offset = "0xD4DB44", VA = "0xD4DB44")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xD4E0E0", Offset = "0xD4E0E0", VA = "0xD4E0E0")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x20000C3")]
		public enum ContactTest
		{
			[Token(Token = "0x400043C")]
			PerpenTest,
			[Token(Token = "0x400043D")]
			BackwardsPress
		}

		[Token(Token = "0x400042D")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x400042E")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _allowMultipleNearFieldInteraction;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x1700008E")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0xD4E1A0", Offset = "0xD4E1A0", VA = "0xD4E1A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008F")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0xD4E1A8", Offset = "0xD4E1A8", VA = "0xD4E1A8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000090")]
		public InteractableState CurrentButtonState
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0xD4E1B4", Offset = "0xD4E1B4", VA = "0xD4E1B4")]
			[CompilerGenerated]
			get
			{
				return default(InteractableState);
			}
			[Token(Token = "0x6000467")]
			[Address(RVA = "0xD4E1BC", Offset = "0xD4E1BC", VA = "0xD4E1BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xD4E1C4", Offset = "0xD4E1C4", VA = "0xD4E1C4", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xD4E2F4", Offset = "0xD4E2F4", VA = "0xD4E2F4")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xD4E4E4", Offset = "0xD4E4E4", VA = "0xD4E4E4", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xD4EAA8", Offset = "0xD4EAA8", VA = "0xD4EAA8")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xD4EBEC", Offset = "0xD4EBEC", VA = "0xD4EBEC")]
		public void ForceResetButton()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xD4E9CC", Offset = "0xD4E9CC", VA = "0xD4E9CC")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xD4ECF8", Offset = "0xD4ECF8", VA = "0xD4ECF8")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xD4EE04", Offset = "0xD4EE04", VA = "0xD4EE04")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xD4EE8C", Offset = "0xD4EE8C", VA = "0xD4EE8C")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x17000091")]
		public Collider Collider
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0xD4EF98", Offset = "0xD4EF98", VA = "0xD4EF98", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000472")]
			[Address(RVA = "0xD4EFA0", Offset = "0xD4EFA0", VA = "0xD4EFA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0xD4EFA8", Offset = "0xD4EFA8", VA = "0xD4EFA8", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000474")]
			[Address(RVA = "0xD4EFB0", Offset = "0xD4EFB0", VA = "0xD4EFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0xD4EFB8", Offset = "0xD4EFB8", VA = "0xD4EFB8", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xD4F008", Offset = "0xD4F008", VA = "0xD4F008")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xD4F088", Offset = "0xD4F088", VA = "0xD4F088")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public interface ColliderZone
	{
		[Token(Token = "0x17000094")]
		Collider Collider
		{
			[Token(Token = "0x6000478")]
			get;
		}

		[Token(Token = "0x17000095")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x6000479")]
			get;
		}

		[Token(Token = "0x17000096")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x600047A")]
			get;
		}
	}
	[Token(Token = "0x20000C6")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xD4E450", Offset = "0xD4E450", VA = "0xD4E450")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public enum InteractionType
	{
		[Token(Token = "0x4000446")]
		Enter,
		[Token(Token = "0x4000447")]
		Stay,
		[Token(Token = "0x4000448")]
		Exit
	}
	[Token(Token = "0x20000C8")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x20000C9")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x400045A")]
			Mesh,
			[Token(Token = "0x400045B")]
			Skeleton,
			[Token(Token = "0x400045C")]
			Both
		}

		[Token(Token = "0x20000CA")]
		[CompilerGenerated]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x170000A2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600049D")]
				[Address(RVA = "0xD503E4", Offset = "0xD503E4", VA = "0xD503E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600049F")]
				[Address(RVA = "0xD5042C", Offset = "0xD5042C", VA = "0xD5042C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0xD4FA50", Offset = "0xD4FA50", VA = "0xD4FA50")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0xD501F8", Offset = "0xD501F8", VA = "0xD501F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0xD501FC", Offset = "0xD501FC", VA = "0xD501FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0xD503EC", Offset = "0xD503EC", VA = "0xD503EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000449")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x17000097")]
		public OVRHand RightHand
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0xD4F090", Offset = "0xD4F090", VA = "0xD4F090")]
			get
			{
				return null;
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0xD4F0BC", Offset = "0xD4F0BC", VA = "0xD4F0BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0xD4F118", Offset = "0xD4F118", VA = "0xD4F118")]
			get
			{
				return null;
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0xD4F144", Offset = "0xD4F144", VA = "0xD4F144")]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0xD4F1A0", Offset = "0xD4F1A0", VA = "0xD4F1A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000481")]
			[Address(RVA = "0xD4F1CC", Offset = "0xD4F1CC", VA = "0xD4F1CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0xD4F228", Offset = "0xD4F228", VA = "0xD4F228")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000483")]
			[Address(RVA = "0xD4F254", Offset = "0xD4F254", VA = "0xD4F254")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0xD4F2B0", Offset = "0xD4F2B0", VA = "0xD4F2B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000485")]
			[Address(RVA = "0xD4F2DC", Offset = "0xD4F2DC", VA = "0xD4F2DC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0xD4F338", Offset = "0xD4F338", VA = "0xD4F338")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000487")]
			[Address(RVA = "0xD4F360", Offset = "0xD4F360", VA = "0xD4F360")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0xD4F3B8", Offset = "0xD4F3B8", VA = "0xD4F3B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0xD4F3E0", Offset = "0xD4F3E0", VA = "0xD4F3E0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0xD4F438", Offset = "0xD4F438", VA = "0xD4F438")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048B")]
			[Address(RVA = "0xD4F460", Offset = "0xD4F460", VA = "0xD4F460")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0xD4F4B8", Offset = "0xD4F4B8", VA = "0xD4F4B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048D")]
			[Address(RVA = "0xD4F4E0", Offset = "0xD4F4E0", VA = "0xD4F4E0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0xD4F538", Offset = "0xD4F538", VA = "0xD4F538")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0xD4F560", Offset = "0xD4F560", VA = "0xD4F560")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public static HandsManager Instance
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0xD4F5B8", Offset = "0xD4F5B8", VA = "0xD4F5B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000491")]
			[Address(RVA = "0xD4F600", Offset = "0xD4F600", VA = "0xD4F600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xD4F64C", Offset = "0xD4F64C", VA = "0xD4F64C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xD4F9D4", Offset = "0xD4F9D4", VA = "0xD4F9D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xD4F96C", Offset = "0xD4F96C", VA = "0xD4F96C")]
		[IteratorStateMachine(typeof(<FindSkeletonVisualGameObjects>d__52))]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xD4FA78", Offset = "0xD4FA78", VA = "0xD4FA78")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xD4FB3C", Offset = "0xD4FB3C", VA = "0xD4FB3C")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xD4FD0C", Offset = "0xD4FD0C", VA = "0xD4FD0C")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xD4FF6C", Offset = "0xD4FF6C", VA = "0xD4FF6C")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xD500CC", Offset = "0xD500CC", VA = "0xD500CC")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CC")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0xD50A7C", Offset = "0xD50A7C", VA = "0xD50A7C")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x170000A4")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xD50434", Offset = "0xD50434", VA = "0xD50434")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xD5043C", Offset = "0xD5043C", VA = "0xD5043C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xD50444", Offset = "0xD50444", VA = "0xD50444")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xD5044C", Offset = "0xD5044C", VA = "0xD5044C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xD50454", Offset = "0xD50454", VA = "0xD50454")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xD50504", Offset = "0xD50504", VA = "0xD50504")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xD505D0", Offset = "0xD505D0", VA = "0xD505D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xD50680", Offset = "0xD50680", VA = "0xD50680")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0xD5074C", Offset = "0xD5074C", VA = "0xD5074C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0xD507FC", Offset = "0xD507FC", VA = "0xD507FC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xD505B4", Offset = "0xD505B4", VA = "0xD505B4", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xD50730", Offset = "0xD50730", VA = "0xD50730", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xD508AC", Offset = "0xD508AC", VA = "0xD508AC", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60004AD")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xD4E2A0", Offset = "0xD4E2A0", VA = "0xD4E2A0", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xD50978", Offset = "0xD50978", VA = "0xD50978", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xD4EF90", Offset = "0xD4EF90", VA = "0xD4EF90")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x4000468")]
		None,
		[Token(Token = "0x4000469")]
		Proximity,
		[Token(Token = "0x400046A")]
		Contact,
		[Token(Token = "0x400046B")]
		Action
	}
	[Token(Token = "0x20000CE")]
	public enum InteractableState
	{
		[Token(Token = "0x400046D")]
		Default,
		[Token(Token = "0x400046E")]
		ProximityState,
		[Token(Token = "0x400046F")]
		ContactState,
		[Token(Token = "0x4000470")]
		ActionState
	}
	[Token(Token = "0x20000CF")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xD4EB58", Offset = "0xD4EB58", VA = "0xD4EB58")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x170000A8")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0xD50AC4", Offset = "0xD50AC4", VA = "0xD50AC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xD508C8", Offset = "0xD508C8", VA = "0xD508C8")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xD509CC", Offset = "0xD509CC", VA = "0xD509CC")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xD50B1C", Offset = "0xD50B1C", VA = "0xD50B1C")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x170000A9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004C0")]
				[Address(RVA = "0xD51230", Offset = "0xD51230", VA = "0xD51230", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004C2")]
				[Address(RVA = "0xD51278", Offset = "0xD51278", VA = "0xD51278", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0xD50CA0", Offset = "0xD50CA0", VA = "0xD50CA0")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0xD50DDC", Offset = "0xD50DDC", VA = "0xD50DDC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0xD50DF8", Offset = "0xD50DF8", VA = "0xD50DF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xD511E0", Offset = "0xD511E0", VA = "0xD511E0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60004C1")]
			[Address(RVA = "0xD51238", Offset = "0xD51238", VA = "0xD51238", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xD50BB0", Offset = "0xD50BB0", VA = "0xD50BB0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xD50C1C", Offset = "0xD50C1C", VA = "0xD50C1C")]
		[IteratorStateMachine(typeof(<AttachToolsToHands>d__3))]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xD50CC8", Offset = "0xD50CC8", VA = "0xD50CC8")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xD50DD4", Offset = "0xD50DD4", VA = "0xD50DD4")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x170000AB")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0xD51280", Offset = "0xD51280", VA = "0xD51280")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xD513CC", Offset = "0xD513CC", VA = "0xD513CC")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xD51468", Offset = "0xD51468", VA = "0xD51468")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xD51504", Offset = "0xD51504", VA = "0xD51504")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xD517A0", Offset = "0xD517A0", VA = "0xD517A0")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xD517DC", Offset = "0xD517DC", VA = "0xD517DC")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xD51A98", Offset = "0xD51A98", VA = "0xD51A98")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xD51CA0", Offset = "0xD51CA0", VA = "0xD51CA0")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x170000B0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004DC")]
				[Address(RVA = "0xD52D8C", Offset = "0xD52D8C", VA = "0xD52D8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004DE")]
				[Address(RVA = "0xD52DD4", Offset = "0xD52DD4", VA = "0xD52DD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xD51EE4", Offset = "0xD51EE4", VA = "0xD51EE4")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xD52928", Offset = "0xD52928", VA = "0xD52928", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xD5292C", Offset = "0xD5292C", VA = "0xD5292C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xD52D94", Offset = "0xD52D94", VA = "0xD52D94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000489")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x170000AC")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xD51D78", Offset = "0xD51D78", VA = "0xD51D78", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000AD")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0xD51D80", Offset = "0xD51D80", VA = "0xD51D80", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000AE")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0xD51D88", Offset = "0xD51D88", VA = "0xD51D88", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AF")]
		public override bool EnableState
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0xD51D90", Offset = "0xD51D90", VA = "0xD51D90", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0xD51DB8", Offset = "0xD51DB8", VA = "0xD51DB8", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xD51DE8", Offset = "0xD51DE8", VA = "0xD51DE8", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xD51E7C", Offset = "0xD51E7C", VA = "0xD51E7C")]
		[IteratorStateMachine(typeof(<AttachTriggerLogic>d__21))]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xD51F0C", Offset = "0xD51F0C", VA = "0xD51F0C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xD5218C", Offset = "0xD5218C", VA = "0xD5218C")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xD52348", Offset = "0xD52348", VA = "0xD52348")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xD52430", Offset = "0xD52430", VA = "0xD52430", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xD527AC", Offset = "0xD527AC", VA = "0xD527AC", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xD527B0", Offset = "0xD527B0", VA = "0xD527B0", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xD527B4", Offset = "0xD527B4", VA = "0xD527B4")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class FingerTipPokeToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x170000B2")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xD52DDC", Offset = "0xD52DDC", VA = "0xD52DDC", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0xD52DE4", Offset = "0xD52DE4", VA = "0xD52DE4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public bool EnableState
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0xD52DEC", Offset = "0xD52DEC", VA = "0xD52DEC", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0xD52E08", Offset = "0xD52E08", VA = "0xD52E08", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0xD52E28", Offset = "0xD52E28", VA = "0xD52E28", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xD52E30", Offset = "0xD52E30", VA = "0xD52E30", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public float SphereRadius
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0xD52E3C", Offset = "0xD52E3C", VA = "0xD52E3C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0xD52E44", Offset = "0xD52E44", VA = "0xD52E44")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xD52E4C", Offset = "0xD52E4C", VA = "0xD52E4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xD52E88", Offset = "0xD52E88", VA = "0xD52E88", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xD52E8C", Offset = "0xD52E8C", VA = "0xD52E8C")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x400049C")]
		None = 0,
		[Token(Token = "0x400049D")]
		Ray = 1,
		[Token(Token = "0x400049E")]
		Poke = 4,
		[Token(Token = "0x400049F")]
		All = -1
	}
	[Token(Token = "0x20000D8")]
	public enum ToolInputState
	{
		[Token(Token = "0x40004A1")]
		Inactive,
		[Token(Token = "0x40004A2")]
		PrimaryInputDown,
		[Token(Token = "0x40004A3")]
		PrimaryInputDownStay,
		[Token(Token = "0x40004A4")]
		PrimaryInputUp
	}
	[Token(Token = "0x20000D9")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xD5276C", Offset = "0xD5276C", VA = "0xD5276C")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x170000B6")]
		public Transform ToolTransform
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0xD4EE84", Offset = "0xD4EE84", VA = "0xD4EE84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0xD52E94", Offset = "0xD52E94", VA = "0xD52E94")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0xD52E9C", Offset = "0xD52E9C", VA = "0xD52E9C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x60004EE")]
			get;
		}

		[Token(Token = "0x170000B9")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x60004EF")]
			get;
		}

		[Token(Token = "0x170000BA")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x60004F0")]
			get;
		}

		[Token(Token = "0x170000BB")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0xD52EA8", Offset = "0xD52EA8", VA = "0xD52EA8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0xD52EB4", Offset = "0xD52EB4", VA = "0xD52EB4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0xD52EC0", Offset = "0xD52EC0", VA = "0xD52EC0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0xD52ECC", Offset = "0xD52ECC", VA = "0xD52ECC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public abstract bool EnableState
		{
			[Token(Token = "0x60004F9")]
			get;
			[Token(Token = "0x60004FA")]
			set;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xD52ED8", Offset = "0xD52ED8", VA = "0xD52ED8")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x60004F7")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x60004F8")]
		public abstract void DeFocus();

		[Token(Token = "0x60004FB")]
		public abstract void Initialize();

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xD51C08", Offset = "0xD51C08", VA = "0xD51C08")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xD51C50", Offset = "0xD51C50", VA = "0xD51C50")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xD52EE0", Offset = "0xD52EE0", VA = "0xD52EE0", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xD5318C", Offset = "0xD5318C", VA = "0xD5318C", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xD527C8", Offset = "0xD527C8", VA = "0xD527C8")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public interface InteractableToolView
	{
		[Token(Token = "0x170000BE")]
		InteractableTool InteractableTool
		{
			[Token(Token = "0x6000501")]
			get;
		}

		[Token(Token = "0x170000BF")]
		bool EnableState
		{
			[Token(Token = "0x6000503")]
			get;
			[Token(Token = "0x6000504")]
			set;
		}

		[Token(Token = "0x170000C0")]
		bool ToolActivateState
		{
			[Token(Token = "0x6000505")]
			get;
			[Token(Token = "0x6000506")]
			set;
		}

		[Token(Token = "0x6000502")]
		void SetFocusedInteractable(Interactable interactable);
	}
	[Token(Token = "0x20000DC")]
	public class PinchStateModule
	{
		[Token(Token = "0x20000DD")]
		private enum PinchState
		{
			[Token(Token = "0x40004B5")]
			None,
			[Token(Token = "0x40004B6")]
			PinchDown,
			[Token(Token = "0x40004B7")]
			PinchStay,
			[Token(Token = "0x40004B8")]
			PinchUp
		}

		[Token(Token = "0x40004B1")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x170000C1")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0xD539D4", Offset = "0xD539D4", VA = "0xD539D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C2")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0xD53A50", Offset = "0xD53A50", VA = "0xD53A50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C3")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0xD53ACC", Offset = "0xD53ACC", VA = "0xD53ACC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xD53B48", Offset = "0xD53B48", VA = "0xD53B48")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xD53B68", Offset = "0xD53B68", VA = "0xD53B68")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x40004B9")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x40004BA")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x40004BB")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x40004BC")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x40004BD")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 45f)]
		[SerializeField]
		private float _coneAngleDegrees;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x170000C4")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0xD53CB4", Offset = "0xD53CB4", VA = "0xD53CB4", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000C5")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0xD53CBC", Offset = "0xD53CBC", VA = "0xD53CBC", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000C6")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0xD53D18", Offset = "0xD53D18", VA = "0xD53D18", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C7")]
		public override bool EnableState
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0xD53D20", Offset = "0xD53D20", VA = "0xD53D20", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000510")]
			[Address(RVA = "0xD53D60", Offset = "0xD53D60", VA = "0xD53D60", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xD53DD0", Offset = "0xD53DD0", VA = "0xD53DD0", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xD53E1C", Offset = "0xD53E1C", VA = "0xD53E1C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xD53EA8", Offset = "0xD53EA8", VA = "0xD53EA8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xD5414C", Offset = "0xD5414C", VA = "0xD5414C")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xD541C8", Offset = "0xD541C8", VA = "0xD541C8", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xD5458C", Offset = "0xD5458C", VA = "0xD5458C")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xD54728", Offset = "0xD54728", VA = "0xD54728")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xD54840", Offset = "0xD54840", VA = "0xD54840")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xD54B64", Offset = "0xD54B64", VA = "0xD54B64")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xD54EE0", Offset = "0xD54EE0", VA = "0xD54EE0", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xD54FA0", Offset = "0xD54FA0", VA = "0xD54FA0", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xD54FC8", Offset = "0xD54FC8", VA = "0xD54FC8")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class RayToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x40004C9")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x40004CA")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x170000C8")]
		public bool EnableState
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0xD53D44", Offset = "0xD53D44", VA = "0xD53D44", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600051E")]
			[Address(RVA = "0xD53D7C", Offset = "0xD53D7C", VA = "0xD53D7C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public bool ToolActivateState
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0xD550A0", Offset = "0xD550A0", VA = "0xD550A0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000520")]
			[Address(RVA = "0xD54110", Offset = "0xD54110", VA = "0xD54110", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0xD552A8", Offset = "0xD552A8", VA = "0xD552A8", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000523")]
			[Address(RVA = "0xD552B0", Offset = "0xD552B0", VA = "0xD552B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xD550A8", Offset = "0xD550A8", VA = "0xD550A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xD54F10", Offset = "0xD54F10", VA = "0xD54F10", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xD552B8", Offset = "0xD552B8", VA = "0xD552B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xD55564", Offset = "0xD55564", VA = "0xD55564")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xD5560C", Offset = "0xD5560C", VA = "0xD5560C")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x170000CB")]
		public bool UseSpherecast
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0xD55664", Offset = "0xD55664", VA = "0xD55664")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000529")]
			[Address(RVA = "0xD5566C", Offset = "0xD5566C", VA = "0xD5566C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0xD556E8", Offset = "0xD556E8", VA = "0xD556E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600052B")]
			[Address(RVA = "0xD556F0", Offset = "0xD556F0", VA = "0xD556F0")]
			set
			{
			}
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xD5574C", Offset = "0xD5574C", VA = "0xD5574C")]
		private void Start()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xD559EC", Offset = "0xD559EC", VA = "0xD559EC")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xD559FC", Offset = "0xD559FC", VA = "0xD559FC")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xD55A0C", Offset = "0xD55A0C", VA = "0xD55A0C")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xD55A14", Offset = "0xD55A14", VA = "0xD55A14")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xD55A18", Offset = "0xD55A18", VA = "0xD55A18")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xD55A84", Offset = "0xD55A84", VA = "0xD55A84")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xD55B14", Offset = "0xD55B14", VA = "0xD55B14")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xD55BA4", Offset = "0xD55BA4", VA = "0xD55BA4")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xD55C50", Offset = "0xD55C50", VA = "0xD55C50")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xD55D2C", Offset = "0xD55D2C", VA = "0xD55D2C")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xD55D70", Offset = "0xD55D70", VA = "0xD55D70")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xD55DD0", Offset = "0xD55DD0", VA = "0xD55DD0")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xD55E30", Offset = "0xD55E30", VA = "0xD55E30")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xD55E38", Offset = "0xD55E38", VA = "0xD55E38")]
		private void Start()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xD55E3C", Offset = "0xD55E3C", VA = "0xD55E3C")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xD55E00", Offset = "0xD55E00", VA = "0xD55E00")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xD55E70", Offset = "0xD55E70", VA = "0xD55E70")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x170000CD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000546")]
				[Address(RVA = "0xD564B8", Offset = "0xD564B8", VA = "0xD564B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000548")]
				[Address(RVA = "0xD56500", Offset = "0xD56500", VA = "0xD56500", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000543")]
			[Address(RVA = "0xD56240", Offset = "0xD56240", VA = "0xD56240")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0xD56308", Offset = "0xD56308", VA = "0xD56308", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0xD5630C", Offset = "0xD5630C", VA = "0xD5630C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000547")]
			[Address(RVA = "0xD564C0", Offset = "0xD564C0", VA = "0xD564C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004DA")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x40004DB")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xD55E78", Offset = "0xD55E78", VA = "0xD55E78")]
		private void Awake()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xD55F0C", Offset = "0xD55F0C", VA = "0xD55F0C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xD56200", Offset = "0xD56200", VA = "0xD56200")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xD56198", Offset = "0xD56198", VA = "0xD56198")]
		[IteratorStateMachine(typeof(<LerpToHMD>d__13))]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xD56268", Offset = "0xD56268", VA = "0xD56268")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x20000E6")]
		public enum SelectionState
		{
			[Token(Token = "0x40004F1")]
			Off,
			[Token(Token = "0x40004F2")]
			Selected,
			[Token(Token = "0x40004F3")]
			Highlighted
		}

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x170000CF")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0xD56508", Offset = "0xD56508", VA = "0xD56508")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x600054A")]
			[Address(RVA = "0xD56510", Offset = "0xD56510", VA = "0xD56510")]
			set
			{
			}
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xD56664", Offset = "0xD56664", VA = "0xD56664")]
		private void Awake()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xD567EC", Offset = "0xD567EC", VA = "0xD567EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xD56584", Offset = "0xD56584", VA = "0xD56584")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xD568B4", Offset = "0xD568B4", VA = "0xD568B4")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x20000E8")]
		public enum SegmentType
		{
			[Token(Token = "0x4000502")]
			Straight,
			[Token(Token = "0x4000503")]
			LeftTurn,
			[Token(Token = "0x4000504")]
			RightTurn,
			[Token(Token = "0x4000505")]
			Switch
		}

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x40004FA")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x40004FB")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x170000D0")]
		public float StartDistance
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0xD56924", Offset = "0xD56924", VA = "0xD56924")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000551")]
			[Address(RVA = "0xD5692C", Offset = "0xD5692C", VA = "0xD5692C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public float GridSize
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0xD56934", Offset = "0xD56934", VA = "0xD56934")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000553")]
			[Address(RVA = "0xD5693C", Offset = "0xD5693C", VA = "0xD5693C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public int SubDivCount
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0xD56944", Offset = "0xD56944", VA = "0xD56944")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000555")]
			[Address(RVA = "0xD5694C", Offset = "0xD5694C", VA = "0xD5694C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public SegmentType Type
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0xD56954", Offset = "0xD56954", VA = "0xD56954")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x170000D4")]
		public Pose EndPose
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0xD5695C", Offset = "0xD5695C", VA = "0xD5695C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		public float Radius
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0xD56D30", Offset = "0xD56D30", VA = "0xD56D30")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D6")]
		public float SegmentLength
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0xD569B8", Offset = "0xD569B8", VA = "0xD569B8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xD56D40", Offset = "0xD56D40", VA = "0xD56D40")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xD56D58", Offset = "0xD56D58", VA = "0xD56D58")]
		private void Awake()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xD569F8", Offset = "0xD569F8", VA = "0xD569F8")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xD56D5C", Offset = "0xD56D5C", VA = "0xD56D5C")]
		private void Update()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xD56D60", Offset = "0xD56D60", VA = "0xD56D60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xD56DBC", Offset = "0xD56DBC", VA = "0xD56DBC")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xD576F0", Offset = "0xD576F0", VA = "0xD576F0")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xD57948", Offset = "0xD57948", VA = "0xD57948")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x170000D7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000570")]
				[Address(RVA = "0xD58400", Offset = "0xD58400", VA = "0xD58400", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000572")]
				[Address(RVA = "0xD58448", Offset = "0xD58448", VA = "0xD58448", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0xD58244", Offset = "0xD58244", VA = "0xD58244")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0xD58294", Offset = "0xD58294", VA = "0xD58294", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0xD58298", Offset = "0xD58298", VA = "0xD58298", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0xD58408", Offset = "0xD58408", VA = "0xD58408", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000506")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x4000507")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xD57A84", Offset = "0xD57A84", VA = "0xD57A84")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xD57B28", Offset = "0xD57B28", VA = "0xD57B28")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xD57BB8", Offset = "0xD57BB8", VA = "0xD57BB8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xD57D00", Offset = "0xD57D00", VA = "0xD57D00")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xD57E8C", Offset = "0xD57E8C", VA = "0xD57E8C")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xD57F9C", Offset = "0xD57F9C", VA = "0xD57F9C")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xD58188", Offset = "0xD58188", VA = "0xD58188")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xD580AC", Offset = "0xD580AC", VA = "0xD580AC")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xD580C0", Offset = "0xD580C0", VA = "0xD580C0")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xD581DC", Offset = "0xD581DC", VA = "0xD581DC")]
		[IteratorStateMachine(typeof(<ResetPosition>d__26))]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xD5826C", Offset = "0xD5826C", VA = "0xD5826C")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x170000D9")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0xD58450", Offset = "0xD58450", VA = "0xD58450")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xD58460", Offset = "0xD58460", VA = "0xD58460", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xD58468", Offset = "0xD58468", VA = "0xD58468", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xD58798", Offset = "0xD58798", VA = "0xD58798")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x400051F")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x4000520")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x170000DA")]
		public float Distance
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0xD5887C", Offset = "0xD5887C", VA = "0xD5887C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000578")]
			[Address(RVA = "0xD58884", Offset = "0xD58884", VA = "0xD58884")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public float Scale
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0xD5888C", Offset = "0xD5888C", VA = "0xD5888C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600057A")]
			[Address(RVA = "0xD58894", Offset = "0xD58894", VA = "0xD58894")]
			set
			{
			}
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xD58464", Offset = "0xD58464", VA = "0xD58464", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xD5889C", Offset = "0xD5889C", VA = "0xD5889C")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xD584A4", Offset = "0xD584A4", VA = "0xD584A4")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xD586B4", Offset = "0xD586B4", VA = "0xD586B4")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x600057F")]
		public abstract void UpdatePosition();

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xD587F8", Offset = "0xD587F8", VA = "0xD587F8")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x20000EE")]
		[CompilerGenerated]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x170000DC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600058E")]
				[Address(RVA = "0xD590E4", Offset = "0xD590E4", VA = "0xD590E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000590")]
				[Address(RVA = "0xD5912C", Offset = "0xD5912C", VA = "0xD5912C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0xD58DA8", Offset = "0xD58DA8", VA = "0xD58DA8")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600058C")]
			[Address(RVA = "0xD58F1C", Offset = "0xD58F1C", VA = "0xD58F1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600058D")]
			[Address(RVA = "0xD58F20", Offset = "0xD58F20", VA = "0xD58F20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0xD590EC", Offset = "0xD590EC", VA = "0xD590EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xD58A0C", Offset = "0xD58A0C", VA = "0xD58A0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xD58A4C", Offset = "0xD58A4C", VA = "0xD58A4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xD58B24", Offset = "0xD58B24", VA = "0xD58B24")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xD58C68", Offset = "0xD58C68", VA = "0xD58C68")]
		private void Update()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xD58B7C", Offset = "0xD58B7C", VA = "0xD58B7C")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xD58D30", Offset = "0xD58D30", VA = "0xD58D30")]
		[IteratorStateMachine(typeof(<AnimateCrossing>d__15))]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xD58DD0", Offset = "0xD58DD0", VA = "0xD58DD0")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xD58E68", Offset = "0xD58E68", VA = "0xD58E68")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xD58EC4", Offset = "0xD58EC4", VA = "0xD58EC4")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x20000F0")]
		private enum EngineSoundState
		{
			[Token(Token = "0x400055D")]
			Start,
			[Token(Token = "0x400055E")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x400055F")]
			Stop
		}

		[Token(Token = "0x20000F1")]
		[CompilerGenerated]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005A3")]
				[Address(RVA = "0xD59990", Offset = "0xD59990", VA = "0xD59990", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005A5")]
				[Address(RVA = "0xD599D8", Offset = "0xD599D8", VA = "0xD599D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0xD593BC", Offset = "0xD593BC", VA = "0xD593BC")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0xD59784", Offset = "0xD59784", VA = "0xD59784", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xD59788", Offset = "0xD59788", VA = "0xD59788", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0xD59998", Offset = "0xD59998", VA = "0xD59998", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400053F")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x4000540")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x4000541")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x4000542")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0.2f, 2.7f)]
		[SerializeField]
		protected float _initialSpeed;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xD59134", Offset = "0xD59134", VA = "0xD59134")]
		private void Start()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xD59278", Offset = "0xD59278", VA = "0xD59278")]
		private void Update()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xD59284", Offset = "0xD59284", VA = "0xD59284", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xD55A48", Offset = "0xD55A48", VA = "0xD55A48")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xD591FC", Offset = "0xD591FC", VA = "0xD591FC")]
		[IteratorStateMachine(typeof(<StartStopTrain>d__34))]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xD593E4", Offset = "0xD593E4", VA = "0xD593E4")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xD5935C", Offset = "0xD5935C", VA = "0xD5935C")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xD55AB4", Offset = "0xD55AB4", VA = "0xD55AB4")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xD55B44", Offset = "0xD55B44", VA = "0xD55B44")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xD595F8", Offset = "0xD595F8", VA = "0xD595F8")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xD596EC", Offset = "0xD596EC", VA = "0xD596EC")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xD55BD4", Offset = "0xD55BD4", VA = "0xD55BD4")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xD55C80", Offset = "0xD55C80", VA = "0xD55C80")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xD55D60", Offset = "0xD55D60", VA = "0xD55D60")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xD59728", Offset = "0xD59728", VA = "0xD59728")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x170000E0")]
		public float TrackLength
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xD599E0", Offset = "0xD599E0", VA = "0xD599E0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xD599E8", Offset = "0xD599E8", VA = "0xD599E8")]
			private set
			{
			}
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xD599F0", Offset = "0xD599F0", VA = "0xD599F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xD58904", Offset = "0xD58904", VA = "0xD58904")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xD599F4", Offset = "0xD599F4", VA = "0xD599F4")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xD59BE0", Offset = "0xD59BE0", VA = "0xD59BE0")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xD59CC0", Offset = "0xD59CC0", VA = "0xD59CC0")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class Pose
	{
		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xD579EC", Offset = "0xD579EC", VA = "0xD579EC")]
		public Pose()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xD59CDC", Offset = "0xD59CDC", VA = "0xD59CDC")]
		public Pose(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x20000F5")]
		[CompilerGenerated]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x170000E2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005BB")]
				[Address(RVA = "0xD5A268", Offset = "0xD5A268", VA = "0xD5A268", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0xD5A2B0", Offset = "0xD5A2B0", VA = "0xD5A2B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xD59F98", Offset = "0xD59F98", VA = "0xD59F98")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xD5A0E4", Offset = "0xD5A0E4", VA = "0xD5A0E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xD5A0E8", Offset = "0xD5A0E8", VA = "0xD5A0E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xD5A270", Offset = "0xD5A270", VA = "0xD5A270", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F6")]
		[CompilerGenerated]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x170000E4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0xD5A380", Offset = "0xD5A380", VA = "0xD5A380", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005C3")]
				[Address(RVA = "0xD5A3C8", Offset = "0xD5A3C8", VA = "0xD5A3C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0xD5A04C", Offset = "0xD5A04C", VA = "0xD5A04C")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xD5A2B8", Offset = "0xD5A2B8", VA = "0xD5A2B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xD5A2BC", Offset = "0xD5A2BC", VA = "0xD5A2BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xD5A388", Offset = "0xD5A388", VA = "0xD5A388", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000572")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x170000E1")]
		public bool IsMoving
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xD59D40", Offset = "0xD59D40", VA = "0xD59D40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0xD59D48", Offset = "0xD59D48", VA = "0xD59D48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xD59D54", Offset = "0xD59D54", VA = "0xD59D54")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xD59D84", Offset = "0xD59D84", VA = "0xD59D84")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xD59EC4", Offset = "0xD59EC4", VA = "0xD59EC4")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xD59F20", Offset = "0xD59F20", VA = "0xD59F20")]
		[IteratorStateMachine(typeof(<LerpToSpeed>d__17))]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xD59FC0", Offset = "0xD59FC0", VA = "0xD59FC0")]
		[IteratorStateMachine(typeof(<PlaySoundDelayed>d__18))]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xD5A074", Offset = "0xD5A074", VA = "0xD5A074")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xD5A0DC", Offset = "0xD5A0DC", VA = "0xD5A0DC")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xD5A3D0", Offset = "0xD5A3D0", VA = "0xD5A3D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xD5A430", Offset = "0xD5A430", VA = "0xD5A430")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xD5A4F8", Offset = "0xD5A4F8", VA = "0xD5A4F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xD5A608", Offset = "0xD5A608", VA = "0xD5A608")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xD5A680", Offset = "0xD5A680", VA = "0xD5A680")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xD5A748", Offset = "0xD5A748", VA = "0xD5A748")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public enum EUiDisplayType
	{
		[Token(Token = "0x400058F")]
		EUDT_WorldGeoQuad,
		[Token(Token = "0x4000590")]
		EUDT_OverlayQuad,
		[Token(Token = "0x4000591")]
		EUDT_None,
		[Token(Token = "0x4000592")]
		EUDT_MaxDislayTypes
	}
	[Token(Token = "0x20000F9")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x20000FA")]
		[CompilerGenerated]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x170000E6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0xD5BD4C", Offset = "0xD5BD4C", VA = "0xD5BD4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005DF")]
				[Address(RVA = "0xD5BD94", Offset = "0xD5BD94", VA = "0xD5BD94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0xD5B410", Offset = "0xD5B410", VA = "0xD5B410")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0xD5BB6C", Offset = "0xD5BB6C", VA = "0xD5BB6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0xD5BB70", Offset = "0xD5BB70", VA = "0xD5BB70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0xD5BD54", Offset = "0xD5BD54", VA = "0xD5BD54", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x4000594")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x4000595")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x4000596")]
		private const string noneID = "NoneID";

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("App vs Compositor Comparison Settings")]
		public GameObject mainCamera;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Level Loading Sim Settings")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xD5A758", Offset = "0xD5A758", VA = "0xD5A758")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xD5AF74", Offset = "0xD5AF74", VA = "0xD5AF74")]
		private void Update()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xD5B09C", Offset = "0xD5B09C", VA = "0xD5B09C")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xD5B1B8", Offset = "0xD5B1B8", VA = "0xD5B1B8")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xD5B2D4", Offset = "0xD5B2D4", VA = "0xD5B2D4")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xD5B07C", Offset = "0xD5B07C", VA = "0xD5B07C")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xD5B3A8", Offset = "0xD5B3A8", VA = "0xD5B3A8")]
		[IteratorStateMachine(typeof(<WaitforOVROverlay>d__30))]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xD5B438", Offset = "0xD5B438", VA = "0xD5B438")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xD5ABB0", Offset = "0xD5ABB0", VA = "0xD5ABB0")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xD5B580", Offset = "0xD5B580", VA = "0xD5B580")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xD5B460", Offset = "0xD5B460", VA = "0xD5B460")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xD5B8FC", Offset = "0xD5B8FC", VA = "0xD5B8FC")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xD5B9E8", Offset = "0xD5B9E8", VA = "0xD5B9E8")]
		public OVROverlaySample()
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x20000FB")]
	[RequireComponent(typeof(OVRGrabber))]
	public class Hand : MonoBehaviour
	{
		[Token(Token = "0x40005AE")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x40005AF")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x40005B0")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x40005B1")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x40005B2")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x40005B3")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x40005B4")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x40005B5")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x40005B6")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x40005B7")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x40005B8")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xD5BD9C", Offset = "0xD5BD9C", VA = "0xD5BD9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xD5BDEC", Offset = "0xD5BDEC", VA = "0xD5BDEC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xD5C21C", Offset = "0xD5C21C", VA = "0xD5C21C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xD5C308", Offset = "0xD5C308", VA = "0xD5C308")]
		private void Update()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xD5C46C", Offset = "0xD5C46C", VA = "0xD5C46C")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xD5C73C", Offset = "0xD5C73C", VA = "0xD5C73C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xD5C820", Offset = "0xD5C820", VA = "0xD5C820")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xD5C9C8", Offset = "0xD5C9C8", VA = "0xD5C9C8")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xD5C4F8", Offset = "0xD5C4F8", VA = "0xD5C4F8")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xD5C54C", Offset = "0xD5C54C", VA = "0xD5C54C")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xD5C0DC", Offset = "0xD5C0DC", VA = "0xD5C0DC")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xD5CAEC", Offset = "0xD5CAEC", VA = "0xD5CAEC")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public enum HandPoseId
	{
		[Token(Token = "0x40005CD")]
		Default,
		[Token(Token = "0x40005CE")]
		Generic,
		[Token(Token = "0x40005CF")]
		PingPongBall,
		[Token(Token = "0x40005D0")]
		Controller
	}
	[Token(Token = "0x20000FE")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x170000E8")]
		public bool AllowPointing
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xD5DB98", Offset = "0xD5DB98", VA = "0xD5DB98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E9")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xD5DBA0", Offset = "0xD5DBA0", VA = "0xD5DBA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EA")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xD5DBA8", Offset = "0xD5DBA8", VA = "0xD5DBA8")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xD5DBB0", Offset = "0xD5DBB0", VA = "0xD5DBB0")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xD5DBB8", Offset = "0xD5DBB8", VA = "0xD5DBB8")]
		private void Update()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xD5DE84", Offset = "0xD5DE84", VA = "0xD5DE84")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xD5DED4", Offset = "0xD5DED4", VA = "0xD5DED4")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xD5DF0C", Offset = "0xD5DF0C", VA = "0xD5DF0C")]
		public TouchController()
		{
		}
	}
}
namespace PathCreation.Examples
{
	[Token(Token = "0x2000100")]
	[RequireComponent(typeof(PathCreator))]
	public class GeneratePathExample : MonoBehaviour
	{
		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool closedLoop;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform[] waypoints;

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xD5DF14", Offset = "0xD5DF14", VA = "0xD5DF14")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xD5DFD8", Offset = "0xD5DFD8", VA = "0xD5DFD8")]
		public GeneratePathExample()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class PathFollower : MonoBehaviour
	{
		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PathCreator pathCreator;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EndOfPathInstruction endOfPathInstruction;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float distanceTravelled;

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xD5DFE8", Offset = "0xD5DFE8", VA = "0xD5DFE8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xD5E0BC", Offset = "0xD5E0BC", VA = "0xD5E0BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xD5E1E4", Offset = "0xD5E1E4", VA = "0xD5E1E4")]
		private void OnPathChanged()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xD5E240", Offset = "0xD5E240", VA = "0xD5E240")]
		public PathFollower()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[ExecuteInEditMode]
	public class PathPlacer : PathSceneTool
	{
		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject prefab;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject holder;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float spacing;

		[Token(Token = "0x40005E0")]
		private const float minSpacing = 0.1f;

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xD5E250", Offset = "0xD5E250", VA = "0xD5E250")]
		private void Generate()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xD5E444", Offset = "0xD5E444", VA = "0xD5E444")]
		private void DestroyObjects()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xD5E510", Offset = "0xD5E510", VA = "0xD5E510", Slot = "5")]
		protected override void PathUpdated()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xD5E588", Offset = "0xD5E588", VA = "0xD5E588")]
		public PathPlacer()
		{
		}
	}
	[Token(Token = "0x2000103")]
	[ExecuteInEditMode]
	public abstract class PathSceneTool : MonoBehaviour
	{
		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PathCreator pathCreator;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoUpdate;

		[Token(Token = "0x170000EB")]
		protected VertexPath path
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0xD5E6E8", Offset = "0xD5E6E8", VA = "0xD5E6E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000013")]
		public event Action onDestroyed
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0xD5E5B0", Offset = "0xD5E5B0", VA = "0xD5E5B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000602")]
			[Address(RVA = "0xD5E64C", Offset = "0xD5E64C", VA = "0xD5E64C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xD5E704", Offset = "0xD5E704", VA = "0xD5E704")]
		public void TriggerUpdate()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xD5E710", Offset = "0xD5E710", VA = "0xD5E710", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000606")]
		protected abstract void PathUpdated();

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xD5E5A0", Offset = "0xD5E5A0", VA = "0xD5E5A0")]
		protected PathSceneTool()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class PathSpawner : MonoBehaviour
	{
		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PathCreator pathPrefab;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PathFollower followerPrefab;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform[] spawnPoints;

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xD5E72C", Offset = "0xD5E72C", VA = "0xD5E72C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xD5E8BC", Offset = "0xD5E8BC", VA = "0xD5E8BC")]
		public PathSpawner()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class RoadMeshCreator : PathSceneTool
	{
		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Header("Road settings")]
		public float roadWidth;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 0.5f)]
		public float thickness;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool flattenSurface;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Material settings")]
		public Material roadMaterial;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Material undersideMaterial;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float textureTiling;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		private GameObject meshHolder;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshFilter meshFilter;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshRenderer meshRenderer;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Mesh mesh;

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xD5E8C4", Offset = "0xD5E8C4", VA = "0xD5E8C4", Slot = "5")]
		protected override void PathUpdated()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xD5EE64", Offset = "0xD5EE64", VA = "0xD5EE64")]
		private void CreateRoadMesh()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xD5E94C", Offset = "0xD5E94C", VA = "0xD5E94C")]
		private void AssignMeshComponents()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xD5ECB8", Offset = "0xD5ECB8", VA = "0xD5ECB8")]
		private void AssignMaterials()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xD5F7C8", Offset = "0xD5F7C8", VA = "0xD5F7C8")]
		public RoadMeshCreator()
		{
		}
	}
}
namespace Michsky.UI.Shift
{
	[Token(Token = "0x2000106")]
	public class ChapterButton : MonoBehaviour
	{
		[Token(Token = "0x2000107")]
		public enum StatusItem
		{
			[Token(Token = "0x40005FE")]
			NONE,
			[Token(Token = "0x40005FF")]
			LOCKED,
			[Token(Token = "0x4000600")]
			COMPLETED
		}

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public Sprite backgroundImage;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string buttonTitle;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[TextArea]
		public string buttonDescription;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("SETTINGS")]
		public bool useCustomResources;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[Header("STATUS")]
		public bool enableStatus;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public StatusItem statusItem;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Image backgroundImageObj;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI titleObj;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI descriptionObj;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform statusNone;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform statusLocked;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform statusCompleted;

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xD5F7EC", Offset = "0xD5F7EC", VA = "0xD5F7EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xD5FB98", Offset = "0xD5FB98", VA = "0xD5FB98")]
		public ChapterButton()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class FavoriteButton : MonoBehaviour
	{
		[Token(Token = "0x2000109")]
		public enum FavoriteItem
		{
			[Token(Token = "0x4000606")]
			FALSE,
			[Token(Token = "0x4000607")]
			TRUE
		}

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("SETTINGS")]
		public FavoriteItem isFavorite;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Image iconObj;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Image iconFilledObj;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Button mainButton;

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xD5FC0C", Offset = "0xD5FC0C", VA = "0xD5FC0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xD5FE68", Offset = "0xD5FE68", VA = "0xD5FE68")]
		public void ClickEvents()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xD5FDE0", Offset = "0xD5FDE0", VA = "0xD5FDE0")]
		public void UpdateUI()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xD5FE7C", Offset = "0xD5FE7C", VA = "0xD5FE7C")]
		public FavoriteButton()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class MainButton : MonoBehaviour
	{
		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("SETTINGS")]
		public string buttonText;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useCustomText;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProUGUI normalText;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI highlightedText;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI pressedText;

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xD5FE84", Offset = "0xD5FE84", VA = "0xD5FE84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xD60014", Offset = "0xD60014", VA = "0xD60014")]
		public MainButton()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class MainPanelButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("TEXT")]
		public bool useCustomText;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string buttonText;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("ICON")]
		public bool hasIcon;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Sprite iconSprite;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator buttonAnimator;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI normalText;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI highlightedText;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI pressedText;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image normalIcon;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image highlightedIcon;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image pressedIcon;

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xD60064", Offset = "0xD60064", VA = "0xD60064")]
		private void Start()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xD6057C", Offset = "0xD6057C", VA = "0xD6057C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xD6063C", Offset = "0xD6063C", VA = "0xD6063C", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xD606FC", Offset = "0xD606FC", VA = "0xD606FC")]
		public MainPanelButton()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class QuickMatchButton : MonoBehaviour
	{
		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("TEXTS")]
		public bool useCustomText;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string buttonTitle;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("IMAGES")]
		public bool useCustomImage;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Sprite backgroundImage;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI titleText;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image image1;

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xD6074C", Offset = "0xD6074C", VA = "0xD6074C")]
		private void Start()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xD6087C", Offset = "0xD6087C", VA = "0xD6087C")]
		public QuickMatchButton()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class SettingsButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public Image detailImage;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image detailIcon;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image detailBackground;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI detailTitle;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI detailDescription;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI buttonTitleObj;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("CONTENT")]
		public string buttonTitle;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("PREVIEW")]
		public string title;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[TextArea]
		public string description;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool enableIconPreview;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Sprite imageSprite;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Sprite iconSprite;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Sprite iconBackground;

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xD608CC", Offset = "0xD608CC", VA = "0xD608CC")]
		private void Start()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xD608F8", Offset = "0xD608F8", VA = "0xD608F8", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xD60A38", Offset = "0xD60A38", VA = "0xD60A38", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xD60A3C", Offset = "0xD60A3C", VA = "0xD60A3C")]
		public SettingsButton()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class ShortcutButton : MonoBehaviour
	{
		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public string keyText;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string buttonText;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("SETTINGS")]
		public bool useCustomText;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isGamepad;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI normalText;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI highlightedText;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI normalKeyText;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI highlightedKeyText;

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xD60A44", Offset = "0xD60A44", VA = "0xD60A44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xD60C98", Offset = "0xD60C98", VA = "0xD60C98")]
		public ShortcutButton()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class SpotlightButton : MonoBehaviour
	{
		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("TEXTS")]
		public bool useCustomText;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string buttonTitle;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string buttonDescription;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("IMAGES")]
		public bool useCustomImage;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Sprite firstImage;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Sprite secondImage;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI titleText;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI descriptionText;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image image1;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image image2;

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xD60D0C", Offset = "0xD60D0C", VA = "0xD60D0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xD60F14", Offset = "0xD60F14", VA = "0xD60F14")]
		public SpotlightButton()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class HoldKeyEvent : MonoBehaviour
	{
		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("KEY")]
		public KeyCode hotkey;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("KEY ACTION")]
		[SerializeField]
		public UnityEvent holdAction;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public UnityEvent releaseAction;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isOn;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isHolding;

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xD60F88", Offset = "0xD60F88", VA = "0xD60F88")]
		private void Update()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xD60FEC", Offset = "0xD60FEC", VA = "0xD60FEC")]
		public HoldKeyEvent()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class PointerEnterEvents : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("EVENTS")]
		public UnityEvent enterEvent;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent exitEvent;

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xD60FF4", Offset = "0xD60FF4", VA = "0xD60FF4", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xD61010", Offset = "0xD61010", VA = "0xD61010", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xD6102C", Offset = "0xD6102C", VA = "0xD6102C")]
		public PointerEnterEvents()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class PressKeyEvent : MonoBehaviour
	{
		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("KEY")]
		[SerializeField]
		public KeyCode hotkey;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool pressAnyKey;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool invokeAtStart;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("KEY ACTION")]
		public UnityEvent pressAction;

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xD61034", Offset = "0xD61034", VA = "0xD61034")]
		private void Start()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xD61060", Offset = "0xD61060", VA = "0xD61060")]
		private void Update()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xD610AC", Offset = "0xD610AC", VA = "0xD610AC")]
		public PressKeyEvent()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class TimedEvent : MonoBehaviour
	{
		[Token(Token = "0x2000114")]
		[CompilerGenerated]
		private sealed class <TimedEventStart>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TimedEvent <>4__this;

			[Token(Token = "0x170000EC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000635")]
				[Address(RVA = "0xD6130C", Offset = "0xD6130C", VA = "0xD6130C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000ED")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000637")]
				[Address(RVA = "0xD61354", Offset = "0xD61354", VA = "0xD61354", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0xD6117C", Offset = "0xD6117C", VA = "0xD6117C")]
			[DebuggerHidden]
			public <TimedEventStart>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0xD6124C", Offset = "0xD6124C", VA = "0xD6124C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0xD61250", Offset = "0xD61250", VA = "0xD61250", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0xD61314", Offset = "0xD61314", VA = "0xD61314", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("TIMING (SECONDS)")]
		public float timer;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool enableAtStart;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("TIMER EVENT")]
		public UnityEvent timerAction;

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xD610B4", Offset = "0xD610B4", VA = "0xD610B4")]
		private void Start()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xD61114", Offset = "0xD61114", VA = "0xD61114")]
		[IteratorStateMachine(typeof(<TimedEventStart>d__4))]
		private IEnumerator TimedEventStart()
		{
			return null;
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xD611A4", Offset = "0xD611A4", VA = "0xD611A4")]
		public void StartIEnumerator()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xD611F0", Offset = "0xD611F0", VA = "0xD611F0")]
		public void StopIEnumerator()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xD6123C", Offset = "0xD6123C", VA = "0xD6123C")]
		public TimedEvent()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class LayoutGroupPositionFix : MonoBehaviour
	{
		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool forceRect;

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xD6135C", Offset = "0xD6135C", VA = "0xD6135C")]
		public void FixPos()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xD6149C", Offset = "0xD6149C", VA = "0xD6149C")]
		public LayoutGroupPositionFix()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class UIElementInFront : MonoBehaviour
	{
		[Token(Token = "0x600063A")]
		[Address(RVA = "0xD614AC", Offset = "0xD614AC", VA = "0xD614AC")]
		private void Start()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xD614CC", Offset = "0xD614CC", VA = "0xD614CC")]
		public UIElementInFront()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class GamepadChecker : MonoBehaviour
	{
		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public VirtualCursor virtualCursor;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject eventSystem;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Objects in this list will be active when gamepad is un-plugged.")]
		[Header("OBJECTS")]
		public List<GameObject> keyboardObjects;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Objects in this list will be active when gamepad is plugged.")]
		public List<GameObject> gamepadObjects;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("SETTINGS")]
		[Tooltip("Always update input device. If you turn off this feature, you won't able to change the input device after start, but it might increase the performance.")]
		public bool alwaysSearch;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GamepadChecker checkerScript;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int gamepadConnected;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 startMousePos;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 startPos;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool gamepadEnabled;

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xD614D4", Offset = "0xD614D4", VA = "0xD614D4")]
		private void Start()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xD61BFC", Offset = "0xD61BFC", VA = "0xD61BFC")]
		private void Update()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xD61930", Offset = "0xD61930", VA = "0xD61930")]
		public void SwitchToController()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xD61A98", Offset = "0xD61A98", VA = "0xD61A98")]
		public void SwitchToKeyboard()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xD61C98", Offset = "0xD61C98", VA = "0xD61C98")]
		public GamepadChecker()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class ScrollGamepadManager : MonoBehaviour
	{
		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("SETTINGS")]
		public float changeValue;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Scrollbar scrollbarObject;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("INPUT")]
		public string inputAxis;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool invertAxis;

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xD61D40", Offset = "0xD61D40", VA = "0xD61D40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xD61E44", Offset = "0xD61E44", VA = "0xD61E44")]
		private void Update()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xD61F48", Offset = "0xD61F48", VA = "0xD61F48")]
		public ScrollGamepadManager()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class SliderGamepadManager : MonoBehaviour
	{
		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("SLIDER")]
		public float changeValue;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Slider sliderObject;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("INPUT")]
		public string horizontalAxis;

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xD61FA4", Offset = "0xD61FA4", VA = "0xD61FA4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xD620A8", Offset = "0xD620A8", VA = "0xD620A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xD621AC", Offset = "0xD621AC", VA = "0xD621AC")]
		public SliderGamepadManager()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class VirtualCursor : PointerInputModule
	{
		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("OBJECTS")]
		public RectTransform border;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject cursorObject;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("INPUT")]
		public EventSystem vEventSystem;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string horizontalAxis;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string verticalAxis;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Header("SETTINGS")]
		[Range(100f, 10000f)]
		public float speed;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private PointerEventData pointer;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Animator cursorAnim;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector2 cursorPos;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RectTransform cursorObj;

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xD62204", Offset = "0xD62204", VA = "0xD62204")]
		public new void Start()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xD622C0", Offset = "0xD622C0", VA = "0xD622C0")]
		public void AnimateCursorIn()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xD6233C", Offset = "0xD6233C", VA = "0xD6233C")]
		public void AnimateCursorOut()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xD623B8", Offset = "0xD623B8", VA = "0xD623B8")]
		private void Update()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xD6253C", Offset = "0xD6253C", VA = "0xD6253C", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xD627D0", Offset = "0xD627D0", VA = "0xD627D0")]
		public VirtualCursor()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class VirtualCursorAnimate : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public VirtualCursor virtualCursor;

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xD6284C", Offset = "0xD6284C", VA = "0xD6284C")]
		private void Start()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xD62A74", Offset = "0xD62A74", VA = "0xD62A74", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xD62AF4", Offset = "0xD62AF4", VA = "0xD62AF4", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xD62B74", Offset = "0xD62B74", VA = "0xD62B74")]
		public VirtualCursorAnimate()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class CanvasManager : MonoBehaviour
	{
		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CanvasScaler canvasScaler;

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xD62B7C", Offset = "0xD62B7C", VA = "0xD62B7C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xD62C18", Offset = "0xD62C18", VA = "0xD62C18")]
		public void ScaleCanvas(int scale = 1080)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xD62C3C", Offset = "0xD62C3C", VA = "0xD62C3C")]
		public CanvasManager()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class ExitToSystem : MonoBehaviour
	{
		[Token(Token = "0x6000654")]
		[Address(RVA = "0xD62C44", Offset = "0xD62C44", VA = "0xD62C44")]
		public void ExitGame()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xD62CB4", Offset = "0xD62CB4", VA = "0xD62CB4")]
		public ExitToSystem()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class LaunchURL : MonoBehaviour
	{
		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string URL;

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xD62CBC", Offset = "0xD62CBC", VA = "0xD62CBC")]
		public void GoToURL()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xD62CC8", Offset = "0xD62CC8", VA = "0xD62CC8")]
		public LaunchURL()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class QualityManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000120")]
		public class DynamicRes : UnityEvent<int>
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0xD64120", Offset = "0xD64120", VA = "0xD64120")]
			public DynamicRes()
			{
			}
		}

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("AUDIO")]
		public AudioMixer mixer;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SliderManager masterSlider;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SliderManager musicSlider;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SliderManager sfxSlider;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("RESOLUTION")]
		public bool preferSelector;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public HorizontalSelector resolutionSelector;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TMP_Dropdown resolutionDropdown;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public DynamicRes clickEvent;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Resolution[] resolutions;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<string> options;

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xD62CD0", Offset = "0xD62CD0", VA = "0xD62CD0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xD63D2C", Offset = "0xD63D2C", VA = "0xD63D2C")]
		public void UpdateResolution()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xD63D88", Offset = "0xD63D88", VA = "0xD63D88")]
		public void SetResolution(int resolutionIndex)
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xD63E20", Offset = "0xD63E20", VA = "0xD63E20")]
		public void AnisotrpicFilteringEnable()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xD63E2C", Offset = "0xD63E2C", VA = "0xD63E2C")]
		public void AnisotrpicFilteringDisable()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xD63E38", Offset = "0xD63E38", VA = "0xD63E38")]
		public void AntiAlisasingSet(int index)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xD63E44", Offset = "0xD63E44", VA = "0xD63E44")]
		public void VsyncSet(int index)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xD63E50", Offset = "0xD63E50", VA = "0xD63E50")]
		public void ShadowResolutionSet(int index)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xD63E68", Offset = "0xD63E68", VA = "0xD63E68")]
		public void ShadowsSet(int index)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xD63E88", Offset = "0xD63E88", VA = "0xD63E88")]
		public void ShadowsCascasedSet(int index)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xD63E94", Offset = "0xD63E94", VA = "0xD63E94")]
		public void TextureSet(int index)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xD63EA0", Offset = "0xD63EA0", VA = "0xD63EA0")]
		public void SoftParticleSet(int index)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xD63EC4", Offset = "0xD63EC4", VA = "0xD63EC4")]
		public void ReflectionSet(int index)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xD63EE8", Offset = "0xD63EE8", VA = "0xD63EE8")]
		public void VolumeSetMaster(float volume)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xD63F5C", Offset = "0xD63F5C", VA = "0xD63F5C")]
		public void VolumeSetMusic(float volume)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xD63FD0", Offset = "0xD63FD0", VA = "0xD63FD0")]
		public void VolumeSetSFX(float volume)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xD64044", Offset = "0xD64044", VA = "0xD64044")]
		public void SetOverallQuality(int qualityIndex)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xD64050", Offset = "0xD64050", VA = "0xD64050")]
		public void WindowFullscreen()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xD64070", Offset = "0xD64070", VA = "0xD64070")]
		public void WindowBorderless()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xD6407C", Offset = "0xD6407C", VA = "0xD6407C")]
		public void WindowWindowed()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xD6409C", Offset = "0xD6409C", VA = "0xD6409C")]
		public QualityManager()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class ScrollForMore : MonoBehaviour
	{
		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public Scrollbar listScrollbar;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator SFMAnimator;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("SETTINGS")]
		public float fadeOutValue;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool invertValue;

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xD64168", Offset = "0xD64168", VA = "0xD64168")]
		private void Start()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xD641CC", Offset = "0xD641CC", VA = "0xD641CC")]
		public void CheckValue()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xD64374", Offset = "0xD64374", VA = "0xD64374")]
		public ScrollForMore()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class FriendsPanelManager : MonoBehaviour
	{
		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator windowAnimator;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isOn;

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xD6437C", Offset = "0xD6437C", VA = "0xD6437C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xD643DC", Offset = "0xD643DC", VA = "0xD643DC")]
		public void AnimateWindow()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xD64464", Offset = "0xD64464", VA = "0xD64464")]
		public void WindowIn()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xD644D4", Offset = "0xD644D4", VA = "0xD644D4")]
		public void WindowOut()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xD64540", Offset = "0xD64540", VA = "0xD64540")]
		public FriendsPanelManager()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class MainPanelButtonParent : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Animator> mainButtons;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Animator buttonAnimator;

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xD64548", Offset = "0xD64548", VA = "0xD64548")]
		private void Start()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xD648EC", Offset = "0xD648EC", VA = "0xD648EC", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xD64A10", Offset = "0xD64A10", VA = "0xD64A10", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xD64B34", Offset = "0xD64B34", VA = "0xD64B34")]
		public MainPanelButtonParent()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class MainPanelManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000125")]
		public class PanelItem
		{
			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string panelName;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject panelObject;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject buttonObject;

			[Token(Token = "0x6000682")]
			[Address(RVA = "0xD656F0", Offset = "0xD656F0", VA = "0xD656F0")]
			public PanelItem()
			{
			}
		}

		[Token(Token = "0x2000126")]
		[CompilerGenerated]
		private sealed class <DisablePreviousPanel>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MainPanelManager <>4__this;

			[Token(Token = "0x170000EE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000686")]
				[Address(RVA = "0xD657AC", Offset = "0xD657AC", VA = "0xD657AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000688")]
				[Address(RVA = "0xD657F4", Offset = "0xD657F4", VA = "0xD657F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0xD65584", Offset = "0xD65584", VA = "0xD65584")]
			[DebuggerHidden]
			public <DisablePreviousPanel>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0xD656F8", Offset = "0xD656F8", VA = "0xD656F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0xD656FC", Offset = "0xD656FC", VA = "0xD656FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0xD657B4", Offset = "0xD657B4", VA = "0xD657B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("PANEL LIST")]
		public List<PanelItem> panels;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("SETTINGS")]
		public bool settingsHelper;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int currentPanelIndex;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int currentButtonIndex;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int newPanelIndex;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject currentPanel;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject nextPanel;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject currentButton;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject nextButton;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Animator currentPanelAnimator;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animator nextPanelAnimator;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator currentButtonAnimator;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Animator nextButtonAnimator;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string panelFadeIn;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string panelFadeOut;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string panelFadeOutHelper;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string buttonFadeIn;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string buttonFadeOut;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string buttonFadeNormal;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool firstTime;

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xD64BB0", Offset = "0xD64BB0", VA = "0xD64BB0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xD64CA8", Offset = "0xD64CA8", VA = "0xD64CA8")]
		private void Start()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xD64DE4", Offset = "0xD64DE4", VA = "0xD64DE4")]
		public void OpenFirstTab()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xD64E94", Offset = "0xD64E94", VA = "0xD64E94")]
		public void OpenPanel(string newPanel)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xD650F8", Offset = "0xD650F8", VA = "0xD650F8")]
		public void NextPage()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xD65318", Offset = "0xD65318", VA = "0xD65318")]
		public void PrevPage()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xD6551C", Offset = "0xD6551C", VA = "0xD6551C")]
		[IteratorStateMachine(typeof(<DisablePreviousPanel>d__27))]
		private IEnumerator DisablePreviousPanel()
		{
			return null;
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xD655AC", Offset = "0xD655AC", VA = "0xD655AC")]
		public MainPanelManager()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class ModalWindowManager : MonoBehaviour
	{
		[Token(Token = "0x2000128")]
		[CompilerGenerated]
		private sealed class <DisableWindow>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ModalWindowManager <>4__this;

			[Token(Token = "0x170000F0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000691")]
				[Address(RVA = "0xD65BD4", Offset = "0xD65BD4", VA = "0xD65BD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000693")]
				[Address(RVA = "0xD65C1C", Offset = "0xD65C1C", VA = "0xD65C1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0xD65A80", Offset = "0xD65A80", VA = "0xD65A80")]
			[DebuggerHidden]
			public <DisableWindow>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0xD65B1C", Offset = "0xD65B1C", VA = "0xD65B1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0xD65B20", Offset = "0xD65B20", VA = "0xD65B20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0xD65BDC", Offset = "0xD65BDC", VA = "0xD65BDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public TextMeshProUGUI windowTitle;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI windowDescription;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("SETTINGS")]
		public bool sharpAnimations;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool useCustomTexts;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string titleText;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[TextArea]
		public string descriptionText;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator mWindowAnimator;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool isOn;

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xD657FC", Offset = "0xD657FC", VA = "0xD657FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xD658B4", Offset = "0xD658B4", VA = "0xD658B4")]
		public void ModalWindowIn()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xD65978", Offset = "0xD65978", VA = "0xD65978")]
		public void ModalWindowOut()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xD65A18", Offset = "0xD65A18", VA = "0xD65A18")]
		[IteratorStateMachine(typeof(<DisableWindow>d__11))]
		private IEnumerator DisableWindow()
		{
			return null;
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xD65AA8", Offset = "0xD65AA8", VA = "0xD65AA8")]
		public ModalWindowManager()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class ServerBrowserManager : MonoBehaviour
	{
		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator mWindowAnimator;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isOn;

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xD65C24", Offset = "0xD65C24", VA = "0xD65C24")]
		private void Start()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xD65C84", Offset = "0xD65C84", VA = "0xD65C84")]
		public void ManageServerList()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xD65D14", Offset = "0xD65D14", VA = "0xD65D14")]
		public void ExpandServerList()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xD65D80", Offset = "0xD65D80", VA = "0xD65D80")]
		public void MinimizeServerList()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xD65DF0", Offset = "0xD65DF0", VA = "0xD65DF0")]
		public ServerBrowserManager()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class SplashScreenManager : MonoBehaviour
	{
		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public GameObject splashScreen;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject mainPanels;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator splashScreenAnimator;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator mainPanelsAnimator;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TimedEvent ssTimedEvent;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("SETTINGS")]
		public bool disableSplashScreen;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool enablePressAnyKeyScreen;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool enableLoginScreen;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MainPanelManager mpm;

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xD65DF8", Offset = "0xD65DF8", VA = "0xD65DF8")]
		private void Start()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xD660A8", Offset = "0xD660A8", VA = "0xD660A8")]
		public void LoginScreenCheck()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xD66174", Offset = "0xD66174", VA = "0xD66174")]
		public SplashScreenManager()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class BlurManager : MonoBehaviour
	{
		[Token(Token = "0x200012C")]
		[CompilerGenerated]
		private sealed class <BlurIn>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BlurManager <>4__this;

			[Token(Token = "0x170000F2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006A6")]
				[Address(RVA = "0xD6655C", Offset = "0xD6655C", VA = "0xD6655C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006A8")]
				[Address(RVA = "0xD665A4", Offset = "0xD665A4", VA = "0xD665A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xD66248", Offset = "0xD66248", VA = "0xD66248")]
			[DebuggerHidden]
			public <BlurIn>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xD66454", Offset = "0xD66454", VA = "0xD66454", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xD66458", Offset = "0xD66458", VA = "0xD66458", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xD66564", Offset = "0xD66564", VA = "0xD66564", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200012D")]
		[CompilerGenerated]
		private sealed class <BlurOut>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BlurManager <>4__this;

			[Token(Token = "0x170000F4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006AC")]
				[Address(RVA = "0xD666AC", Offset = "0xD666AC", VA = "0xD666AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006AE")]
				[Address(RVA = "0xD666F4", Offset = "0xD666F4", VA = "0xD666F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0xD662D8", Offset = "0xD662D8", VA = "0xD662D8")]
			[DebuggerHidden]
			public <BlurOut>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xD665AC", Offset = "0xD665AC", VA = "0xD665AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0xD665B0", Offset = "0xD665B0", VA = "0xD665B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0xD666B4", Offset = "0xD666B4", VA = "0xD666B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public Material blurMaterial;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("SETTINGS")]
		[Range(0f, 10f)]
		public float blurValue;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0.1f, 50f)]
		public float animationSpeed;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string customProperty;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float currentBlurValue;

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xD6617C", Offset = "0xD6617C", VA = "0xD6617C")]
		private void Start()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xD661E0", Offset = "0xD661E0", VA = "0xD661E0")]
		[IteratorStateMachine(typeof(<BlurIn>d__6))]
		private IEnumerator BlurIn()
		{
			return null;
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xD66270", Offset = "0xD66270", VA = "0xD66270")]
		[IteratorStateMachine(typeof(<BlurOut>d__7))]
		private IEnumerator BlurOut()
		{
			return null;
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xD66300", Offset = "0xD66300", VA = "0xD66300")]
		public void BlurInAnim()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xD66378", Offset = "0xD66378", VA = "0xD66378")]
		public void BlurOutAnim()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xD663F0", Offset = "0xD663F0", VA = "0xD663F0")]
		public void SetBlurValue(float cbv)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xD663F8", Offset = "0xD663F8", VA = "0xD663F8")]
		public BlurManager()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class GradientEffect : BaseMeshEffect
	{
		[Token(Token = "0x200012F")]
		public enum Direction
		{
			[Token(Token = "0x40006C7")]
			Horizontal,
			[Token(Token = "0x40006C8")]
			Vertical,
			[Token(Token = "0x40006C9")]
			Angle,
			[Token(Token = "0x40006CA")]
			Diagonal
		}

		[Token(Token = "0x2000130")]
		public enum GradientStyle
		{
			[Token(Token = "0x40006CC")]
			Rect,
			[Token(Token = "0x40006CD")]
			Fit,
			[Token(Token = "0x40006CE")]
			Split
		}

		[Token(Token = "0x2000131")]
		private struct Matrix2x3
		{
			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float m00;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float m01;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float m02;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float m10;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float m11;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float m12;

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0xD6733C", Offset = "0xD6733C", VA = "0xD6733C")]
			public Matrix2x3(Rect rect, float cos, float sin)
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0xD67440", Offset = "0xD67440", VA = "0xD67440")]
			public static Vector2 operator *(Matrix2x3 m, Vector2 v)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Gradient Direction")]
		[Header("GRADIENT STYLE")]
		private Direction m_Direction;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Color1: Top or Left")]
		[SerializeField]
		private Color m_Color1;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Tooltip("Color2: Bottom or Right")]
		private Color m_Color2;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Tooltip("Color3: For diagonal")]
		private Color m_Color3;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[Tooltip("Color4: For diagonal")]
		private Color m_Color4;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Gradient rotation")]
		[Range(-180f, 180f)]
		[SerializeField]
		private float m_Rotation;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Gradient offset for Horizontal, Vertical or Angle")]
		[SerializeField]
		[Range(-1f, 1f)]
		private float m_Offset1;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Gradient offset for Diagonal")]
		[SerializeField]
		[Range(-1f, 1f)]
		private float m_Offset2;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("SETTINGS")]
		[Tooltip("Gradient style for Text.")]
		[SerializeField]
		private GradientStyle m_GradientStyle;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("Color space to correct color")]
		[SerializeField]
		private ColorSpace m_ColorSpace;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Ignore aspect ratio")]
		[SerializeField]
		private bool m_IgnoreAspectRatio;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector2[] s_SplitedCharacterPosition;

		[Token(Token = "0x170000F6")]
		public Graphic TargetGraphic
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0xD666FC", Offset = "0xD666FC", VA = "0xD666FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F7")]
		public Direction DirectionMain
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xD66704", Offset = "0xD66704", VA = "0xD66704")]
			get
			{
				return default(Direction);
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xD6670C", Offset = "0xD6670C", VA = "0xD6670C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public Color Color1
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0xD66720", Offset = "0xD66720", VA = "0xD66720")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0xD6672C", Offset = "0xD6672C", VA = "0xD6672C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public Color Color2
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0xD6677C", Offset = "0xD6677C", VA = "0xD6677C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0xD66788", Offset = "0xD66788", VA = "0xD66788")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public Color Color3
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xD667D8", Offset = "0xD667D8", VA = "0xD667D8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xD667E4", Offset = "0xD667E4", VA = "0xD667E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public Color Color4
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0xD66834", Offset = "0xD66834", VA = "0xD66834")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0xD66840", Offset = "0xD66840", VA = "0xD66840")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public float Rotation
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0xD66890", Offset = "0xD66890", VA = "0xD66890")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0xD668BC", Offset = "0xD668BC", VA = "0xD668BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public float Offset
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xD66954", Offset = "0xD66954", VA = "0xD66954")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0xD6695C", Offset = "0xD6695C", VA = "0xD6695C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public Vector2 Offset2
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xD66970", Offset = "0xD66970", VA = "0xD66970")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0xD66978", Offset = "0xD66978", VA = "0xD66978")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public GradientStyle GradientStyleMain
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0xD66998", Offset = "0xD66998", VA = "0xD66998")]
			get
			{
				return default(GradientStyle);
			}
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0xD669A0", Offset = "0xD669A0", VA = "0xD669A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public ColorSpace ColorSpace
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0xD669B4", Offset = "0xD669B4", VA = "0xD669B4")]
			get
			{
				return default(ColorSpace);
			}
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0xD669BC", Offset = "0xD669BC", VA = "0xD669BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public bool IgnoreAspectRatio
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0xD669D0", Offset = "0xD669D0", VA = "0xD669D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0xD669D8", Offset = "0xD669D8", VA = "0xD669D8")]
			set
			{
			}
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xD669F0", Offset = "0xD669F0", VA = "0xD669F0", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xD67470", Offset = "0xD67470", VA = "0xD67470")]
		public GradientEffect()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[RequireComponent(typeof(ParticleSystem))]
	[ExecuteInEditMode]
	[RequireComponent(typeof(CanvasRenderer))]
	public class UIParticleRenderer : MaskableGraphic
	{
		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Tooltip("Having this enabled run the system in LateUpdate rather than in Update making it faster but less precise (more clunky)")]
		public bool fixedTime;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Transform _transform;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ParticleSystem pSystem;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ParticleSystem.Particle[] particles;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private UIVertex[] _quad;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector4 imageUV;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private ParticleSystem.TextureSheetAnimationModule textureSheetAnimation;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int textureSheetAnimationFrames;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector2 textureSheetAnimationFrameSize;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private ParticleSystemRenderer pRenderer;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Material currentMaterial;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Texture currentTexture;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private ParticleSystem.MainModule mainModule;

		[Token(Token = "0x17000102")]
		public override Texture mainTexture
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0xD67608", Offset = "0xD67608", VA = "0xD67608", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xD67610", Offset = "0xD67610", VA = "0xD67610")]
		protected bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xD67A88", Offset = "0xD67A88", VA = "0xD67A88", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xD67AC0", Offset = "0xD67AC0", VA = "0xD67AC0", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xD682F4", Offset = "0xD682F4", VA = "0xD682F4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xD684DC", Offset = "0xD684DC", VA = "0xD684DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xD6872C", Offset = "0xD6872C", VA = "0xD6872C")]
		public UIParticleRenderer()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class CustomInputField : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public GameObject fieldTrigger;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_InputField inputText;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator inputFieldAnimator;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isEmpty;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isClicked;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string inAnim;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string outAnim;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xD687C0", Offset = "0xD687C0", VA = "0xD687C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xD68898", Offset = "0xD68898", VA = "0xD68898")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xD68900", Offset = "0xD68900", VA = "0xD68900")]
		public void Animate()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xD68940", Offset = "0xD68940", VA = "0xD68940")]
		public void FieldTrigger()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xD68988", Offset = "0xD68988", VA = "0xD68988", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xD6898C", Offset = "0xD6898C", VA = "0xD6898C")]
		public CustomInputField()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class HorizontalSelector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000135")]
		public class Item
		{
			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string itemTitle;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UnityEvent onValueChanged;

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0xD69B08", Offset = "0xD69B08", VA = "0xD69B08")]
			public Item()
			{
			}
		}

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshProUGUI label;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshProUGUI labeHelper;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator selectorAnimator;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string newItemTitle;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("SETTINGS")]
		public int defaultIndex;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool invokeAtStart;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool invertAnimation;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		public bool loopSelection;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public int index;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Header("SAVING")]
		public bool saveValue;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string selectorTag;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("INDICATORS")]
		public bool enableIndicators;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform indicatorParent;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject indicatorObject;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("ITEMS")]
		public List<Item> itemList;

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xD68A08", Offset = "0xD68A08", VA = "0xD68A08")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xD69164", Offset = "0xD69164", VA = "0xD69164")]
		public void PreviousClick()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xD69638", Offset = "0xD69638", VA = "0xD69638")]
		public void ForwardClick()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xD636D8", Offset = "0xD636D8", VA = "0xD636D8")]
		public void CreateNewItem(string title)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xD637BC", Offset = "0xD637BC", VA = "0xD637BC")]
		public void UpdateUI()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xD69B58", Offset = "0xD69B58", VA = "0xD69B58")]
		public HorizontalSelector()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class SliderManager : MonoBehaviour
	{
		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("TEXTS")]
		public TextMeshProUGUI valueText;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("SAVING")]
		public bool enableSaving;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sliderTag;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float defaultValue;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Header("SETTINGS")]
		public bool usePercent;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool showValue;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		public bool useRoundValue;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Slider mainSlider;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float saveValue;

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xD69C00", Offset = "0xD69C00", VA = "0xD69C00")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xD69D7C", Offset = "0xD69D7C", VA = "0xD69D7C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xD69F00", Offset = "0xD69F00", VA = "0xD69F00")]
		public SliderManager()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class SwitchManager : MonoBehaviour
	{
		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("IMPORTANT! EVERY SWITCH MUST HAVE A DIFFERENT TAG")]
		[Header("SETTINGS")]
		public string switchTag;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isOn;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool saveValue;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool invokeAtStart;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent OnEvents;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent OffEvents;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator switchAnimator;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button switchButton;

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xD69FD8", Offset = "0xD69FD8", VA = "0xD69FD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xD6A2DC", Offset = "0xD6A2DC", VA = "0xD6A2DC")]
		public void AnimateSwitch()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xD6A404", Offset = "0xD6A404", VA = "0xD6A404")]
		public SwitchManager()
		{
		}
	}
	[Token(Token = "0x2000138")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(AudioSource))]
	public class UIElementSound : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler
	{
		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public UIManager UIManagerAsset;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource audioObject;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("SETTINGS")]
		public bool enableHoverSound;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool enableClickSound;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PlayerController _playerManager;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected VibrationManager _vibrationManager;

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xD6A464", Offset = "0xD6A464", VA = "0xD6A464", Slot = "6")]
		[Inject]
		public virtual void Constructor(VibrationManager vibrationManager)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xD6A46C", Offset = "0xD6A46C", VA = "0xD6A46C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xD6A5AC", Offset = "0xD6A5AC", VA = "0xD6A5AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xD6A648", Offset = "0xD6A648", VA = "0xD6A648", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xD6A698", Offset = "0xD6A698", VA = "0xD6A698", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xD6A6EC", Offset = "0xD6A6EC", VA = "0xD6A6EC")]
		public UIElementSound()
		{
		}
	}
	[Token(Token = "0x2000139")]
	[CreateAssetMenu(fileName = "New UI Manager", menuName = "Shift UI/New UI Manager")]
	public class UIManager : ScriptableObject
	{
		[Token(Token = "0x200013A")]
		public enum ButtonThemeType
		{
			[Token(Token = "0x400072B")]
			BASIC,
			[Token(Token = "0x400072C")]
			CUSTOM
		}

		[Token(Token = "0x200013B")]
		public enum BackgroundType
		{
			[Token(Token = "0x400072E")]
			BASIC,
			[Token(Token = "0x400072F")]
			ADVANCED
		}

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public bool enableDynamicUpdate;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[HideInInspector]
		public bool enableExtendedColorPicker;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[HideInInspector]
		public bool editorHints;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Color backgroundColorTint;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BackgroundType backgroundType;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Sprite backgroundImage;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public VideoClip backgroundVideo;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool backgroundPreserveAspect;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0.1f, 5f)]
		public float backgroundSpeed;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color primaryColor;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Color secondaryColor;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Color primaryReversed;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color negativeColor;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color backgroundColor;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public TMP_FontAsset lightFont;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public TMP_FontAsset regularFont;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public TMP_FontAsset mediumFont;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public TMP_FontAsset semiBoldFont;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TMP_FontAsset boldFont;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Sprite gameLogo;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Color logoColor;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color particleColor;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioClip backgroundMusic;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AudioClip hoverSound;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public AudioClip clickSound;

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xD6A6FC", Offset = "0xD6A6FC", VA = "0xD6A6FC")]
		public UIManager()
		{
		}
	}
	[Token(Token = "0x200013C")]
	[ExecuteInEditMode]
	public class UIManagerBackground : MonoBehaviour
	{
		[Token(Token = "0x200013D")]
		public enum BackgroundType
		{
			[Token(Token = "0x4000738")]
			BASIC,
			[Token(Token = "0x4000739")]
			ADVANCED
		}

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public UIManager UIManagerAsset;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Image backgroundObject;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RawImage backgroundVideoImage;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private VideoPlayer backgroundVideo;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("SETTINGS")]
		public BackgroundType backgroundType;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool enableMobileMode;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool dynamicUpdateEnabled;

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xD6A748", Offset = "0xD6A748", VA = "0xD6A748")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xD6A888", Offset = "0xD6A888", VA = "0xD6A888")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xD6AD78", Offset = "0xD6AD78", VA = "0xD6AD78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xD6A9E4", Offset = "0xD6A9E4", VA = "0xD6A9E4")]
		private void UpdateBackground()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xD6AE08", Offset = "0xD6AE08", VA = "0xD6AE08")]
		public UIManagerBackground()
		{
		}
	}
	[Token(Token = "0x200013E")]
	[ExecuteInEditMode]
	public class UIManagerBGMusic : MonoBehaviour
	{
		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public UIManager UIManagerAsset;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource audioObject;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool dynamicUpdateEnabled;

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xD6AE10", Offset = "0xD6AE10", VA = "0xD6AE10")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xD6AF50", Offset = "0xD6AF50", VA = "0xD6AF50")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xD6B0B0", Offset = "0xD6B0B0", VA = "0xD6B0B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xD6B00C", Offset = "0xD6B00C", VA = "0xD6B00C")]
		private void UpdateSource()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xD6B140", Offset = "0xD6B140", VA = "0xD6B140")]
		public UIManagerBGMusic()
		{
		}
	}
	[Token(Token = "0x200013F")]
	[ExecuteInEditMode]
	public class UIManagerGameLogo : MonoBehaviour
	{
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public UIManager UIManagerAsset;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image logoObject;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("SETTINGS")]
		public bool keepAlphaValue;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool useCustomColor;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool dynamicUpdateEnabled;

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xD6B148", Offset = "0xD6B148", VA = "0xD6B148")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xD6B288", Offset = "0xD6B288", VA = "0xD6B288")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xD6B4AC", Offset = "0xD6B4AC", VA = "0xD6B4AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xD6B344", Offset = "0xD6B344", VA = "0xD6B344")]
		private void UpdateLogo()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xD6B53C", Offset = "0xD6B53C", VA = "0xD6B53C")]
		public UIManagerGameLogo()
		{
		}
	}
	[Token(Token = "0x2000140")]
	[ExecuteInEditMode]
	public class UIManagerImage : MonoBehaviour
	{
		[Token(Token = "0x2000141")]
		public enum ColorType
		{
			[Token(Token = "0x4000749")]
			PRIMARY,
			[Token(Token = "0x400074A")]
			SECONDARY,
			[Token(Token = "0x400074B")]
			PRIMARY_REVERSED,
			[Token(Token = "0x400074C")]
			NEGATIVE,
			[Token(Token = "0x400074D")]
			BACKGROUND
		}

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public UIManager UIManagerAsset;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image imageObject;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("SETTINGS")]
		public bool keepAlphaValue;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool useCustomColor;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ColorType colorType;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool dynamicUpdateEnabled;

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xD6B544", Offset = "0xD6B544", VA = "0xD6B544")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xD6B684", Offset = "0xD6B684", VA = "0xD6B684")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xD6BB68", Offset = "0xD6BB68", VA = "0xD6BB68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xD6B740", Offset = "0xD6B740", VA = "0xD6B740")]
		private void UpdateButton()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xD6BBF8", Offset = "0xD6BBF8", VA = "0xD6BBF8")]
		public UIManagerImage()
		{
		}
	}
	[Token(Token = "0x2000142")]
	[ExecuteInEditMode]
	public class UIManagerParticle : MonoBehaviour
	{
		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public UIManager UIManagerAsset;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem particleObject;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool dynamicUpdateEnabled;

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xD6BC00", Offset = "0xD6BC00", VA = "0xD6BC00")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xD6BD40", Offset = "0xD6BD40", VA = "0xD6BD40")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xD6BF68", Offset = "0xD6BF68", VA = "0xD6BF68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xD6BDFC", Offset = "0xD6BDFC", VA = "0xD6BDFC")]
		private void UpdateColor()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xD6BFF8", Offset = "0xD6BFF8", VA = "0xD6BFF8")]
		public UIManagerParticle()
		{
		}
	}
	[Token(Token = "0x2000143")]
	[ExecuteInEditMode]
	public class UIManagerText : MonoBehaviour
	{
		[Token(Token = "0x2000144")]
		public enum ColorType
		{
			[Token(Token = "0x4000759")]
			PRIMARY,
			[Token(Token = "0x400075A")]
			SECONDARY,
			[Token(Token = "0x400075B")]
			PRIMARY_REVERSED,
			[Token(Token = "0x400075C")]
			NEGATIVE,
			[Token(Token = "0x400075D")]
			BACKGROUND
		}

		[Token(Token = "0x2000145")]
		public enum FontType
		{
			[Token(Token = "0x400075F")]
			LIGHT,
			[Token(Token = "0x4000760")]
			REGULAR,
			[Token(Token = "0x4000761")]
			MEDIUM,
			[Token(Token = "0x4000762")]
			SEMIBOLD,
			[Token(Token = "0x4000763")]
			BOLD
		}

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("RESOURCES")]
		public UIManager UIManagerAsset;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI textObject;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("SETTINGS")]
		public bool keepAlphaValue;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool useCustomColor;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ColorType colorType;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FontType fontType;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool dynamicUpdateEnabled;

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xD6C000", Offset = "0xD6C000", VA = "0xD6C000")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xD6C140", Offset = "0xD6C140", VA = "0xD6C140")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xD6C744", Offset = "0xD6C744", VA = "0xD6C744")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xD6C1FC", Offset = "0xD6C1FC", VA = "0xD6C1FC")]
		private void UpdateButton()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xD6C7D4", Offset = "0xD6C7D4", VA = "0xD6C7D4")]
		public UIManagerText()
		{
		}
	}
}
namespace _Trash.Carlos.Plane
{
	[Token(Token = "0x2000146")]
	public class PlaneCombat : MonoBehaviour
	{
		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<SpriteRenderer> lifes;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SpriteRenderer> enemies;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Transform> clouds;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<GameObject> enemyBullets;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform player;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ParticleSystem smoke;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float playerMaxSpeed;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int playerLife;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float enemyBulletsSpeed;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float bulletSpread;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform playerBomb;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve bombDeployCurve;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve enemySpawnRate;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve cloudDeployCurve;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float cloudSpeed;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TextMeshPro scoreText;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float timeToNextEnemy;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public SpriteRenderer explotion;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float refresRate;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _currentSpeed;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _spawnEnemyTimer;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float _invencibleTime;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Tween _playerTween;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float _score;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _lastShootTimer;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _refreshTimer;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float _refreshTime;

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xD6C7DC", Offset = "0xD6C7DC", VA = "0xD6C7DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xD6CC64", Offset = "0xD6CC64", VA = "0xD6CC64")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xD6CC74", Offset = "0xD6CC74", VA = "0xD6CC74")]
		private void Update()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xD6CF68", Offset = "0xD6CF68", VA = "0xD6CF68")]
		private void CheckBullets()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xD6D610", Offset = "0xD6D610", VA = "0xD6D610")]
		private void EnemyShoot()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xD6C7F0", Offset = "0xD6C7F0", VA = "0xD6C7F0")]
		private void Init()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xD6DA14", Offset = "0xD6DA14", VA = "0xD6DA14")]
		private void CheckSpawn()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xD6DD3C", Offset = "0xD6DD3C", VA = "0xD6DD3C")]
		private void MoveEnemies()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xD6DFC8", Offset = "0xD6DFC8", VA = "0xD6DFC8")]
		private void MoveClouds()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xD6E304", Offset = "0xD6E304", VA = "0xD6E304")]
		public PlaneCombat()
		{
		}
	}
}
