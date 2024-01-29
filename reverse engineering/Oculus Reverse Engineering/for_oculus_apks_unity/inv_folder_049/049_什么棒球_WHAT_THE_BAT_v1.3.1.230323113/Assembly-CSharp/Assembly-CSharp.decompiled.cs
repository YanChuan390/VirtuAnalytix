using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AK.Wwise;
using DG.Tweening;
using Il2CppDummyDll;
using JetBrains.Annotations;
using NaughtyAttributes;
using TMPro;
using Triband.ColorPipeline.Runtime;
using Triband.Splines;
using Triband.Validation;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Pool;
using UnityEngine.Serialization;
using UnityEngine.UI;
using WTB.Prefabs.Gameplay.CountdownScoreBoard;
using WTB.Runtime;
using WTB.Runtime.Audio;
using WTB.Runtime.GameFlow;
using WTB.Runtime.GameFlow.Configuration;
using WTB.Runtime.GameFlow.LevelGameFlow;
using WTB.Runtime.GameFlow.ReplayGameFlow;
using WTB.Runtime.GameLogic;
using WTB.Runtime.GameLogic.GameObjectFiltering;
using WTB.Runtime.Gameplay;
using WTB.Runtime.Gameplay.AutoAimSystem;
using WTB.Runtime.Gameplay.Bats;
using WTB.Runtime.Gameplay.CookingSystem;
using WTB.Runtime.Gameplay.DogSystem;
using WTB.Runtime.Gameplay.Feedback;
using WTB.Runtime.Gameplay.LaserSystem;
using WTB.Runtime.Gameplay.Music;
using WTB.Runtime.Gameplay.PlayerSystem;
using WTB.Runtime.Gameplay.SelfieSystem.Scripts;
using WTB.Runtime.Gameplay.StepSequencer;
using WTB.Runtime.Graphics.PlantVFXSystem;
using WTB.Runtime.PhysicsBehaviours;
using WTB.Runtime.Utility;
using WTB.Runtime.VFX;
using WTB.Runtime.VFX.ColorRemapEffects;
using WTB.Runtime.VFX.Confetti;
using WTB.Scenes.Levels.Home.VideoGame.Scripts;
using WTB.Scenes.Levels.Island.Merfoxes.Scripts;
using WTB.Scenes.Levels.Space.SpacePhotoOp.Scripts.StepEffectHandlers;

[assembly: AssemblyVersion("0.0.0.0")]
namespace WTB
{
	[Token(Token = "0x2000002")]
	[ExecuteInEditMode]
	public class LimboCrabClawAdjustment : MonoBehaviour
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float zRotAdjustment;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float yPosAdjustment;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool left;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject LeftClaw;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject RightClaw;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool update;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0xE2A344", Offset = "0xE2A344", VA = "0xE2A344")]
		private void Update()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xE2A588", Offset = "0xE2A588", VA = "0xE2A588")]
		public LimboCrabClawAdjustment()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public class LeverRumble : MonoBehaviour
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeReference]
		private GameObjectFilter m_RumberOnEnterTrigger;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Bat m_Bat;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xE2A590", Offset = "0xE2A590", VA = "0xE2A590")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xE2A610", Offset = "0xE2A610", VA = "0xE2A610")]
		private void OnCollisionExit(Collision other)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xE2A618", Offset = "0xE2A618", VA = "0xE2A618")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xE2A6E0", Offset = "0xE2A6E0", VA = "0xE2A6E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xE2A6E4", Offset = "0xE2A6E4", VA = "0xE2A6E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xE2A6E8", Offset = "0xE2A6E8", VA = "0xE2A6E8")]
		public LeverRumble()
		{
		}
	}
}
namespace WTB.Scenes.ReplayGames.Squash
{
	[Token(Token = "0x2000004")]
	public class SquashBall : MonoBehaviour
	{
		[Token(Token = "0x2000005")]
		private class RaycastHitComparer : IComparer<RaycastHit>
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0xE2B458", Offset = "0xE2B458", VA = "0xE2B458", Slot = "4")]
			public int Compare(RaycastHit a, RaycastHit b)
			{
				return default(int);
			}

			[Token(Token = "0x6000013")]
			[Address(RVA = "0xE2AEA4", Offset = "0xE2AEA4", VA = "0xE2AEA4")]
			public RaycastHitComparer()
			{
			}
		}

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SquashReplayGame m_SquashGame;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_Transform;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_ComebackTransform;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float k_AngularVelocityDrag;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float k_IdleAngle;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_Aiming;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool m_WallBounce;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		private bool m_SpeedAdjustment;

		[Token(Token = "0x17000001")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0xE2A6F0", Offset = "0xE2A6F0", VA = "0xE2A6F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xE2A6F8", Offset = "0xE2A6F8", VA = "0xE2A6F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xE2A758", Offset = "0xE2A758", VA = "0xE2A758")]
		private void Start()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xE2A7F0", Offset = "0xE2A7F0", VA = "0xE2A7F0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xE2A8F8", Offset = "0xE2A8F8", VA = "0xE2A8F8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xE2AEAC", Offset = "0xE2AEAC", VA = "0xE2AEAC")]
		private void ApplyAiming(SquashBall ball)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xE2B328", Offset = "0xE2B328", VA = "0xE2B328")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xE2B168", Offset = "0xE2B168", VA = "0xE2B168")]
		private void ApplySpeedAdjustment(SquashBall ball)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xE2B3F4", Offset = "0xE2B3F4", VA = "0xE2B3F4")]
		public SquashBall()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class SquashBlock : MonoBehaviour
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onComplete;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action onFail;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SquashGoal[] m_Goals;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SquashObstacle[] m_Obstacles;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xE2B498", Offset = "0xE2B498", VA = "0xE2B498")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xE2B6CC", Offset = "0xE2B6CC", VA = "0xE2B6CC")]
		private void Complete()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xE2B6E8", Offset = "0xE2B6E8", VA = "0xE2B6E8")]
		private void Fail()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xE2B704", Offset = "0xE2B704", VA = "0xE2B704")]
		public void Show(string s)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xE2B6A8", Offset = "0xE2B6A8", VA = "0xE2B6A8")]
		public void Hide()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xE2B8F0", Offset = "0xE2B8F0", VA = "0xE2B8F0")]
		public SquashBlock()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class SquashBoxWall : MonoBehaviour
	{
		[Token(Token = "0x2000008")]
		public enum WallType
		{
			[Token(Token = "0x4000019")]
			Sides,
			[Token(Token = "0x400001A")]
			Back
		}

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WallType m_WallType;

		[Token(Token = "0x17000002")]
		public WallType wallType
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0xE2B8F8", Offset = "0xE2B8F8", VA = "0xE2B8F8")]
			get
			{
				return default(WallType);
			}
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xE2B900", Offset = "0xE2B900", VA = "0xE2B900")]
		public SquashBoxWall()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class SquashCoin : MonoBehaviour
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0xE2B908", Offset = "0xE2B908", VA = "0xE2B908")]
		public SquashCoin()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class SquashGame : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000B")]
		public class Sequence
		{
			[Token(Token = "0x200000C")]
			public enum Mode
			{
				[Token(Token = "0x4000035")]
				Sequential,
				[Token(Token = "0x4000036")]
				RandomNoRepeat
			}

			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private float m_Speed;

			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			private int m_RepeatCount;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private State m_MusicState;

			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Mode m_Mode;

			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			private SquashBlock[] m_Blocks;

			[Token(Token = "0x17000005")]
			public float speed
			{
				[Token(Token = "0x6000029")]
				[Address(RVA = "0xE2BE14", Offset = "0xE2BE14", VA = "0xE2BE14")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000006")]
			public int repeatCount
			{
				[Token(Token = "0x600002A")]
				[Address(RVA = "0xE2BE1C", Offset = "0xE2BE1C", VA = "0xE2BE1C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000007")]
			public State musicState
			{
				[Token(Token = "0x600002B")]
				[Address(RVA = "0xE2BE24", Offset = "0xE2BE24", VA = "0xE2BE24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000008")]
			public Mode mode
			{
				[Token(Token = "0x600002C")]
				[Address(RVA = "0xE2BE2C", Offset = "0xE2BE2C", VA = "0xE2BE2C")]
				get
				{
					return default(Mode);
				}
			}

			[Token(Token = "0x17000009")]
			public SquashBlock[] blocks
			{
				[Token(Token = "0x600002D")]
				[Address(RVA = "0xE2BE34", Offset = "0xE2BE34", VA = "0xE2BE34")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0xE2BE3C", Offset = "0xE2BE3C", VA = "0xE2BE3C")]
			public Sequence()
			{
			}
		}

		[Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool failed;

			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool completed;

			[Token(Token = "0x600002F")]
			[Address(RVA = "0xE2BE50", Offset = "0xE2BE50", VA = "0xE2BE50")]
			public <>c__DisplayClass28_0()
			{
			}
		}

		[Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class <GameLoop>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SquashGame <>4__this;

			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass28_0 <>8__1;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Sequence[] <>7__wrap1;

			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <>7__wrap2;

			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Sequence <sequence>5__4;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <completedBlocksCount>5__5;

			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private int <totalBlocks>5__6;

			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int <i>5__7;

			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private List<SquashBlock>.Enumerator <>7__wrap7;

			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private SquashBlock <block>5__9;

			[Token(Token = "0x1700000A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000036")]
				[Address(RVA = "0xE2C6C0", Offset = "0xE2C6C0", VA = "0xE2C6C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000038")]
				[Address(RVA = "0xE2C708", Offset = "0xE2C708", VA = "0xE2C708", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000032")]
			[Address(RVA = "0xE2BC34", Offset = "0xE2BC34", VA = "0xE2BC34")]
			[DebuggerHidden]
			public <GameLoop>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x6000033")]
			[Address(RVA = "0xE2BE70", Offset = "0xE2BE70", VA = "0xE2BE70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0xE2BE9C", Offset = "0xE2BE9C", VA = "0xE2BE9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000035")]
			[Address(RVA = "0xE2C670", Offset = "0xE2C670", VA = "0xE2C670")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0xE2C6C8", Offset = "0xE2C6C8", VA = "0xE2C6C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sequence[] m_Sequences;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_BlocksRoot;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve m_AimRatioOverSpeed;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve m_SpeedAdjustmentRatioOverSpeed;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform m_NextBlockSpace;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TMP_Text m_ScoreText;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TMP_Text m_LevelText;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform m_ProgressIndicator;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_Speed;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform m_Transform;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Situation m_Situation;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SquashBlock[] m_Blocks;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int m_Score;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int m_Level;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_IsInNextBlockSpace;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int k_GoalPoints;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int k_WallBouncePenaltyPoints;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int k_MaxWallBouncePenaltyCount;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int m_WallBounces;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Random rng;

		[Token(Token = "0x17000003")]
		private float aimRatio
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0xE2B910", Offset = "0xE2B910", VA = "0xE2B910")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000004")]
		private float speedAdjustmentRatio
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0xE2B934", Offset = "0xE2B934", VA = "0xE2B934")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xE2B958", Offset = "0xE2B958", VA = "0xE2B958")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xE2BAB0", Offset = "0xE2BAB0", VA = "0xE2BAB0")]
		private void UpdateScore()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xE2BB58", Offset = "0xE2BB58", VA = "0xE2BB58")]
		private void UpdateLevel()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xE2BB90", Offset = "0xE2BB90", VA = "0xE2BB90")]
		private void UpdateProgress(float t)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xE2BBCC", Offset = "0xE2BBCC", VA = "0xE2BBCC")]
		[IteratorStateMachine(typeof(<GameLoop>d__28))]
		private IEnumerator GameLoop()
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xE2BC5C", Offset = "0xE2BC5C", VA = "0xE2BC5C")]
		public void Apply(SquashBall ball)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xE2BCF4", Offset = "0xE2BCF4", VA = "0xE2BCF4")]
		public void BackWallBounce()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xE2BD04", Offset = "0xE2BD04", VA = "0xE2BD04")]
		public SquashGame()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class SquashGameWave : ReplayGameWaveBase
	{
		[Token(Token = "0x2000010")]
		public enum Mode
		{
			[Token(Token = "0x4000052")]
			Sequential,
			[Token(Token = "0x4000053")]
			RandomNoRepeat
		}

		[Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool failed;

			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool completed;

			[Token(Token = "0x6000043")]
			[Address(RVA = "0xE2CAF0", Offset = "0xE2CAF0", VA = "0xE2CAF0")]
			public <>c__DisplayClass26_0()
			{
			}
		}

		[Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class <DoWaveCoroutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SquashGameWave <>4__this;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass26_0 <>8__1;

			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <totalBlocks>5__2;

			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <completedBlocksCount>5__3;

			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <i>5__4;

			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<SquashBlock>.Enumerator <>7__wrap4;

			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private SquashBlock <block>5__6;

			[Token(Token = "0x17000011")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600004A")]
				[Address(RVA = "0xE2D37C", Offset = "0xE2D37C", VA = "0xE2D37C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000012")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600004C")]
				[Address(RVA = "0xE2D3C4", Offset = "0xE2D3C4", VA = "0xE2D3C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0xE2C938", Offset = "0xE2C938", VA = "0xE2C938")]
			[DebuggerHidden]
			public <DoWaveCoroutine>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000047")]
			[Address(RVA = "0xE2CB10", Offset = "0xE2CB10", VA = "0xE2CB10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000048")]
			[Address(RVA = "0xE2CB3C", Offset = "0xE2CB3C", VA = "0xE2CB3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000049")]
			[Address(RVA = "0xE2D32C", Offset = "0xE2D32C", VA = "0xE2D32C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600004B")]
			[Address(RVA = "0xE2D384", Offset = "0xE2D384", VA = "0xE2D384", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_RepeatCount;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private State m_MusicState;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Mode m_Mode;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SquashBlock[] m_Blocks;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SquashReplayGame m_SquashGame;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_WallBounces;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string[] Credits;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int k_GoalPoints;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int k_WallBouncePenaltyPoints;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int k_MaxWallBouncePenaltyCount;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool m_IsDone;

		[Token(Token = "0x1700000C")]
		public override bool canContinueToNextWave
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xE2C710", Offset = "0xE2C710", VA = "0xE2C710", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		public Mode mode
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0xE2C718", Offset = "0xE2C718", VA = "0xE2C718")]
			get
			{
				return default(Mode);
			}
		}

		[Token(Token = "0x1700000E")]
		public State musicState
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0xE2C720", Offset = "0xE2C720", VA = "0xE2C720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public int repeatCount
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xE2C728", Offset = "0xE2C728", VA = "0xE2C728")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000010")]
		public float speed
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xE2C730", Offset = "0xE2C730", VA = "0xE2C730")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xE2C738", Offset = "0xE2C738", VA = "0xE2C738", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xE2C73C", Offset = "0xE2C73C", VA = "0xE2C73C", Slot = "5")]
		public override void StartWave(IReplayGame game)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xE2C934", Offset = "0xE2C934", VA = "0xE2C934", Slot = "7")]
		public override void EndWave()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xE2C8CC", Offset = "0xE2C8CC", VA = "0xE2C8CC")]
		[IteratorStateMachine(typeof(<DoWaveCoroutine>d__26))]
		private IEnumerator DoWaveCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xE2C960", Offset = "0xE2C960", VA = "0xE2C960")]
		public SquashGameWave()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class SquashGoal : MonoBehaviour
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Event m_Event;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_Root;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_HitEffect;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_Trophy;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshPro m_String;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action onHit;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_DoScaleUp;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xE2D3CC", Offset = "0xE2D3CC", VA = "0xE2D3CC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xE2B7CC", Offset = "0xE2B7CC", VA = "0xE2B7CC")]
		public void Show(string s)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xE2D584", Offset = "0xE2D584", VA = "0xE2D584")]
		private void Update()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xE2D630", Offset = "0xE2D630", VA = "0xE2D630")]
		public SquashGoal()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class SquashHeart : MonoBehaviour
	{
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onHit;

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xE2D6C4", Offset = "0xE2D6C4", VA = "0xE2D6C4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xE2D70C", Offset = "0xE2D70C", VA = "0xE2D70C")]
		public void Show()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xE2D730", Offset = "0xE2D730", VA = "0xE2D730")]
		public SquashHeart()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class SquashObstacle : MonoBehaviour
	{
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onHit;

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xE2D738", Offset = "0xE2D738", VA = "0xE2D738")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xE2B8CC", Offset = "0xE2B8CC", VA = "0xE2B8CC")]
		public void Show()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xE2D780", Offset = "0xE2D780", VA = "0xE2D780")]
		public SquashObstacle()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class SquashReplayGame : ReplayGame<SquashGameWave>, IGameModeBehaviour
	{
		[Token(Token = "0x4000068")]
		private const int k_GoalPoints = 1000;

		[Token(Token = "0x4000069")]
		private const int k_WallBouncePenaltyPoints = 10;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject m_BlocksRoot;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationCurve m_AimRatioOverSpeed;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AnimationCurve m_SpeedAdjustmentRatioOverSpeed;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform m_NextBlockSpace;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TMP_Text m_LevelText;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform m_ProgressIndicator;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Spawner m_BallSpawner;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private SquashBlock[] m_Blocks;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float angularVelocityDrag;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int k_MaxWallBouncePenaltyCount;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int m_WallBounces;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int m_WaveDisplayNumber;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public int numBlocksHit;

		[Token(Token = "0x17000013")]
		public float aimRatio
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xE2B300", Offset = "0xE2B300", VA = "0xE2B300")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000014")]
		public bool isInNextBlockSpace
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0xE2D298", Offset = "0xE2D298", VA = "0xE2D298")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		protected override bool playerHasLives
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xE2D788", Offset = "0xE2D788", VA = "0xE2D788", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public override ReplayGameType replayGameType
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xE2D790", Offset = "0xE2D790", VA = "0xE2D790", Slot = "27")]
			get
			{
				return default(ReplayGameType);
			}
		}

		[Token(Token = "0x17000017")]
		public float speed
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xE2B3B0", Offset = "0xE2B3B0", VA = "0xE2B3B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000018")]
		public float speedAdjustmentRatio
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0xE2B3CC", Offset = "0xE2B3CC", VA = "0xE2B3CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000019")]
		public SquashBall ball
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0xE2D798", Offset = "0xE2D798", VA = "0xE2D798")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0xE2D7A0", Offset = "0xE2D7A0", VA = "0xE2D7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Transform ballAimTarget
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0xE2D7A8", Offset = "0xE2D7A8", VA = "0xE2D7A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000061")]
			[Address(RVA = "0xE2D7B0", Offset = "0xE2D7B0", VA = "0xE2D7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xE2D7B8", Offset = "0xE2D7B8", VA = "0xE2D7B8", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xE2D89C", Offset = "0xE2D89C", VA = "0xE2D89C", Slot = "14")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xE2C850", Offset = "0xE2C850", VA = "0xE2C850")]
		public void IncrementWaveNumber()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xE2C890", Offset = "0xE2C890", VA = "0xE2C890")]
		public void UpdateProgress(float t)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xE2A8E8", Offset = "0xE2A8E8", VA = "0xE2A8E8")]
		public void BackWallBounce()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xE2D98C", Offset = "0xE2D98C", VA = "0xE2D98C", Slot = "25")]
		protected override void ReplayGameStart()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xE2D990", Offset = "0xE2D990", VA = "0xE2D990", Slot = "26")]
		protected override void ReplayGameLost()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xE2D994", Offset = "0xE2D994", VA = "0xE2D994")]
		public SquashReplayGame()
		{
		}
	}
}
namespace WTB.Scenes.ReplayGames.Batting
{
	[Token(Token = "0x2000017")]
	public class BattingReplayGame : ReplayGame<BattingWave>
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject m_TrophyPrefab;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BattingReplayGameBarrel m_BarrelPrefab;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Event m_LostSFX;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ReplayGameScoreHandler m_ReplayGameScoreHandler;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject m_TempFailObject;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ReplayGameTrophySpawner[] m_SpawnPoints;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BattingReplayGamePointPopup m_ScorePopupText;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int m_CurrentDifficulty;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float m_NextSpawn;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float m_NextDifficultyIncrease;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float m_CurrentSpawnCooldown;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float m_CurrentTrophyLifetime;

		[Token(Token = "0x1700001B")]
		protected override bool playerHasLives
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xE2DA2C", Offset = "0xE2DA2C", VA = "0xE2DA2C", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		public override ReplayGameType replayGameType
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0xE2DA34", Offset = "0xE2DA34", VA = "0xE2DA34", Slot = "27")]
			get
			{
				return default(ReplayGameType);
			}
		}

		[Token(Token = "0x1700001D")]
		public BattingReplayGamePointPopup scorePopupText
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0xE2DA3C", Offset = "0xE2DA3C", VA = "0xE2DA3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xE2DA44", Offset = "0xE2DA44", VA = "0xE2DA44", Slot = "25")]
		protected override void ReplayGameStart()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xE2DAB4", Offset = "0xE2DAB4", VA = "0xE2DAB4", Slot = "26")]
		protected override void ReplayGameLost()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xE2DB44", Offset = "0xE2DB44", VA = "0xE2DB44", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xE2DBBC", Offset = "0xE2DBBC", VA = "0xE2DBBC", Slot = "13")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xE2DC64", Offset = "0xE2DC64", VA = "0xE2DC64")]
		public void ActivateAllPedestals()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xE2DD34", Offset = "0xE2DD34", VA = "0xE2DD34")]
		public void ActivatePedestals(List<ReplayGameTrophySpawner> activePedestals)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xE2DFC0", Offset = "0xE2DFC0", VA = "0xE2DFC0")]
		public void TrySpawnObjects(int spawnCount, float lifetime, float barrelSpawnChance, out List<GameObject> spawnedObjects)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xE2E50C", Offset = "0xE2E50C", VA = "0xE2E50C")]
		public BattingReplayGame()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class BattingReplayGameBarrel : MonoBehaviour, IHasLifetime
	{
		[Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class <DelayedDespawn>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000090")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000091")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000092")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BattingReplayGameBarrel <>4__this;

			[Token(Token = "0x1700001E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000084")]
				[Address(RVA = "0xE2E9BC", Offset = "0xE2E9BC", VA = "0xE2E9BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000086")]
				[Address(RVA = "0xE2EA04", Offset = "0xE2EA04", VA = "0xE2EA04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000081")]
			[Address(RVA = "0xE2E890", Offset = "0xE2E890", VA = "0xE2E890")]
			[DebuggerHidden]
			public <DelayedDespawn>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000082")]
			[Address(RVA = "0xE2E8F4", Offset = "0xE2E8F4", VA = "0xE2E8F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000083")]
			[Address(RVA = "0xE2E8F8", Offset = "0xE2E8F8", VA = "0xE2E8F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000085")]
			[Address(RVA = "0xE2E9C4", Offset = "0xE2E9C4", VA = "0xE2E9C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class <Lifetime>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000093")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000094")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float lifetime;

			[Token(Token = "0x4000096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattingReplayGameBarrel <>4__this;

			[Token(Token = "0x17000020")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600008A")]
				[Address(RVA = "0xE2EAD8", Offset = "0xE2EAD8", VA = "0xE2EAD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000021")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600008C")]
				[Address(RVA = "0xE2EB20", Offset = "0xE2EB20", VA = "0xE2EB20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000087")]
			[Address(RVA = "0xE2E8B8", Offset = "0xE2E8B8", VA = "0xE2E8B8")]
			[DebuggerHidden]
			public <Lifetime>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000088")]
			[Address(RVA = "0xE2EA0C", Offset = "0xE2EA0C", VA = "0xE2EA0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000089")]
			[Address(RVA = "0xE2EA10", Offset = "0xE2EA10", VA = "0xE2EA10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600008B")]
			[Address(RVA = "0xE2EAE0", Offset = "0xE2EAE0", VA = "0xE2EAE0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_LifetimeMultiplier;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly float m_DespawnDelay;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ReplayGameTrophySpawner m_SpawnPos;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_Despawning;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_AcceptCollisions;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BattingReplayGame m_ReplayGame;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ReplayGameScoreHandler m_ReplayGameScoreHandler;

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xE2E668", Offset = "0xE2E668", VA = "0xE2E668")]
		private void Start()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xE2E720", Offset = "0xE2E720", VA = "0xE2E720")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xE2E7F8", Offset = "0xE2E7F8", VA = "0xE2E7F8", Slot = "4")]
		public void SetLifetime(float lifetime)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xE2E790", Offset = "0xE2E790", VA = "0xE2E790")]
		[IteratorStateMachine(typeof(<DelayedDespawn>d__10))]
		private IEnumerator DelayedDespawn()
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xE2E818", Offset = "0xE2E818", VA = "0xE2E818")]
		[IteratorStateMachine(typeof(<Lifetime>d__11))]
		private IEnumerator Lifetime(float lifetime)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xE2E8E0", Offset = "0xE2E8E0", VA = "0xE2E8E0")]
		public BattingReplayGameBarrel()
		{
		}
	}
	[Token(Token = "0x200001D")]
	internal interface IHasLifetime
	{
		[Token(Token = "0x600008D")]
		void SetLifetime(float lifetime);
	}
	[Token(Token = "0x200001E")]
	public class BattingReplayGamePointPopup : MonoBehaviour
	{
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Color> m_ColorPerPoints;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> m_TextPerPoints;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshPro m_Text;

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xE2EB28", Offset = "0xE2EB28", VA = "0xE2EB28")]
		public void Setup(int points, Vector3 trophyPosition)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xE2ED58", Offset = "0xE2ED58", VA = "0xE2ED58")]
		public BattingReplayGamePointPopup()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class BattingReplayGameTrophy : MonoBehaviour
	{
		[Token(Token = "0x2000020")]
		private enum LifetimeIndicator
		{
			[Token(Token = "0x40000B6")]
			Blinking,
			[Token(Token = "0x40000B7")]
			Greyscale,
			[Token(Token = "0x40000B8")]
			Scaling,
			[Token(Token = "0x40000B9")]
			None
		}

		[Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class <DelayedDespawn>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BattingReplayGameTrophy <>4__this;

			[Token(Token = "0x17000022")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000A3")]
				[Address(RVA = "0xE2FAD4", Offset = "0xE2FAD4", VA = "0xE2FAD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000023")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000A5")]
				[Address(RVA = "0xE2FB1C", Offset = "0xE2FB1C", VA = "0xE2FB1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000A0")]
			[Address(RVA = "0xE2F6E8", Offset = "0xE2F6E8", VA = "0xE2F6E8")]
			[DebuggerHidden]
			public <DelayedDespawn>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60000A1")]
			[Address(RVA = "0xE2FA0C", Offset = "0xE2FA0C", VA = "0xE2FA0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0xE2FA10", Offset = "0xE2FA10", VA = "0xE2FA10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000A4")]
			[Address(RVA = "0xE2FADC", Offset = "0xE2FADC", VA = "0xE2FADC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class <BlinkLifetime>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float lifetime;

			[Token(Token = "0x40000C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattingReplayGameTrophy <>4__this;

			[Token(Token = "0x17000024")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000A9")]
				[Address(RVA = "0xE2FC8C", Offset = "0xE2FC8C", VA = "0xE2FC8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000025")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000AB")]
				[Address(RVA = "0xE2FCD4", Offset = "0xE2FCD4", VA = "0xE2FCD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0xE2F710", Offset = "0xE2F710", VA = "0xE2F710")]
			[DebuggerHidden]
			public <BlinkLifetime>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x60000A7")]
			[Address(RVA = "0xE2FB24", Offset = "0xE2FB24", VA = "0xE2FB24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0xE2FB28", Offset = "0xE2FB28", VA = "0xE2FB28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xE2FC94", Offset = "0xE2FC94", VA = "0xE2FC94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class <GreyScaleLifetime>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float lifetime;

			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattingReplayGameTrophy <>4__this;

			[Token(Token = "0x17000026")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000AF")]
				[Address(RVA = "0xE2FE6C", Offset = "0xE2FE6C", VA = "0xE2FE6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000027")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000B1")]
				[Address(RVA = "0xE2FEB4", Offset = "0xE2FEB4", VA = "0xE2FEB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xE2F738", Offset = "0xE2F738", VA = "0xE2F738")]
			[DebuggerHidden]
			public <GreyScaleLifetime>d__35(int <>1__state)
			{
			}

			[Token(Token = "0x60000AD")]
			[Address(RVA = "0xE2FCDC", Offset = "0xE2FCDC", VA = "0xE2FCDC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0xE2FCE0", Offset = "0xE2FCE0", VA = "0xE2FCE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0xE2FE74", Offset = "0xE2FE74", VA = "0xE2FE74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class <ScalingLifetime>d__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float lifetime;

			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattingReplayGameTrophy <>4__this;

			[Token(Token = "0x17000028")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000B5")]
				[Address(RVA = "0xE2FFFC", Offset = "0xE2FFFC", VA = "0xE2FFFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000029")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000B7")]
				[Address(RVA = "0xE30044", Offset = "0xE30044", VA = "0xE30044", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0xE2F760", Offset = "0xE2F760", VA = "0xE2F760")]
			[DebuggerHidden]
			public <ScalingLifetime>d__36(int <>1__state)
			{
			}

			[Token(Token = "0x60000B3")]
			[Address(RVA = "0xE2FEBC", Offset = "0xE2FEBC", VA = "0xE2FEBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xE2FEC0", Offset = "0xE2FEC0", VA = "0xE2FEC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B6")]
			[Address(RVA = "0xE30004", Offset = "0xE30004", VA = "0xE30004", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int GrayHeightID;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LifetimeIndicator m_LifetimeIndicator;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_DespawnDelay;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_BlinkTime;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer m_Mesh;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_BrokenHeart;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform m_HeartSpawnPos;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Event m_LostLifeSFX;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Shader m_GrayScaleShader;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_ExponentialGreying;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ReplayGameScoreHandler m_ReplayGameScoreHandler;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly float m_BlinkState1BlinkCD;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private readonly float m_BlinkState2BlinkCD;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly Vector3 m_ScaleTarget;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private readonly float m_MinimumScaleDuration;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_Despawning;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int m_BlinkState;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_LastBlinkIn;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float m_LastBlinkOut;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MaterialPropertyBlock m_PropertyBlock;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_Greying;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float m_GreyingEnd;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float m_GreyingTime;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float m_GreyStart;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float m_SpawnTime;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float m_TrophyLifetime;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BattingReplayGame m_ReplayGame;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xE2ED60", Offset = "0xE2ED60", VA = "0xE2ED60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xE2EFA4", Offset = "0xE2EFA4", VA = "0xE2EFA4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xE2F2BC", Offset = "0xE2F2BC", VA = "0xE2F2BC")]
		public void OnTipped()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xE2F388", Offset = "0xE2F388", VA = "0xE2F388")]
		public void DespawnTrophy(bool awardPoints, float lifetime)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xE2F4F8", Offset = "0xE2F4F8", VA = "0xE2F4F8")]
		public void SetLifetime(float lifetime)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xE2F320", Offset = "0xE2F320", VA = "0xE2F320")]
		[IteratorStateMachine(typeof(<DelayedDespawn>d__33))]
		private IEnumerator DelayedDespawn()
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xE2F580", Offset = "0xE2F580", VA = "0xE2F580")]
		[IteratorStateMachine(typeof(<BlinkLifetime>d__34))]
		private IEnumerator BlinkLifetime(float lifetime)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xE2F5F8", Offset = "0xE2F5F8", VA = "0xE2F5F8")]
		[IteratorStateMachine(typeof(<GreyScaleLifetime>d__35))]
		private IEnumerator GreyScaleLifetime(float lifetime)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xE2F670", Offset = "0xE2F670", VA = "0xE2F670")]
		[IteratorStateMachine(typeof(<ScalingLifetime>d__36))]
		private IEnumerator ScalingLifetime(float lifetime)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xE2F788", Offset = "0xE2F788", VA = "0xE2F788")]
		private void TimeRanOut()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xE2EE94", Offset = "0xE2EE94", VA = "0xE2EE94")]
		private void UpdateGreyscaleHeight(float fillAmount)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xE2F268", Offset = "0xE2F268", VA = "0xE2F268")]
		private void Blink(bool blinkOut)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xE2F3BC", Offset = "0xE2F3BC", VA = "0xE2F3BC")]
		private void AwardPoints(float lifetimeLeft)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xE2F900", Offset = "0xE2F900", VA = "0xE2F900")]
		private int GetScoreForTrophyHit(float lifetimeLeft)
		{
			return default(int);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xE2F970", Offset = "0xE2F970", VA = "0xE2F970")]
		public BattingReplayGameTrophy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000025")]
	public class BattingWave : ReplayGameWaveBase
	{
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<ReplayGameTrophySpawner> m_ActiveSpawnPositions;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_SpawnInterval;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int[] m_SpawnCounts;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_TrophyLifetime;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent m_OnWaveStart;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_BarrelSpawningChance;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BattingReplayGame m_BattingReplayGame;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_TimeToNextSpawn;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_SpawnCount;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<GameObject> m_AliveTrophies;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_IsActive;

		[Token(Token = "0x1700002A")]
		public override bool canContinueToNextWave
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xE3004C", Offset = "0xE3004C", VA = "0xE3004C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xE30150", Offset = "0xE30150", VA = "0xE30150", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xE30238", Offset = "0xE30238", VA = "0xE30238", Slot = "7")]
		public override void EndWave()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xE30240", Offset = "0xE30240", VA = "0xE30240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xE30294", Offset = "0xE30294", VA = "0xE30294", Slot = "5")]
		public override void StartWave(IReplayGame game)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xE303E8", Offset = "0xE303E8", VA = "0xE303E8")]
		public BattingWave()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class ReplayGameTrophySpawner : MonoBehaviour, IRequireValidation
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("m_CooldownBeforeNextTrophy")]
		[SerializeField]
		private float m_CooldownBeforeNextSpawn;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_SpawnPosition;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_HasObject;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject m_CurrentObject;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_NextSpawn;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xE304BC", Offset = "0xE304BC", VA = "0xE304BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xE2E31C", Offset = "0xE2E31C", VA = "0xE2E31C")]
		public GameObject SpawnObject(GameObject prefabToSpawn, float lifetime)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xE2E638", Offset = "0xE2E638", VA = "0xE2E638")]
		public bool CanSpawnTrophy()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xE30544", Offset = "0xE30544", VA = "0xE30544", Slot = "4")]
		public void Validate(ValidationContext context)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xE305C8", Offset = "0xE305C8", VA = "0xE305C8")]
		public ReplayGameTrophySpawner()
		{
		}
	}
}
namespace WTB.Scenes.ReplayGames.BatSaber.Scripts
{
	[Token(Token = "0x2000027")]
	public class BallSequencer : ReplayGameMusicSequencer
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xE305D8", Offset = "0xE305D8", VA = "0xE305D8")]
		public BallSequencer()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class BatSaberReplayGame : ReplayGame<BatSaberWave>
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ReplayGameMusicSequencer m_Sequencer;

		[Token(Token = "0x1700002B")]
		protected override bool playerHasLives
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xE306BC", Offset = "0xE306BC", VA = "0xE306BC", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002C")]
		public override ReplayGameType replayGameType
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xE306C4", Offset = "0xE306C4", VA = "0xE306C4", Slot = "27")]
			get
			{
				return default(ReplayGameType);
			}
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xE306CC", Offset = "0xE306CC", VA = "0xE306CC", Slot = "25")]
		protected override void ReplayGameStart()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xE307D8", Offset = "0xE307D8", VA = "0xE307D8", Slot = "26")]
		protected override void ReplayGameLost()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xE307DC", Offset = "0xE307DC", VA = "0xE307DC")]
		public BatSaberReplayGame()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000029")]
	public class BatSaberWave : ReplayGameWaveBase
	{
		[Token(Token = "0x1700002D")]
		public override bool canContinueToNextWave
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xE30824", Offset = "0xE30824", VA = "0xE30824", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xE3082C", Offset = "0xE3082C", VA = "0xE3082C", Slot = "5")]
		public override void StartWave(IReplayGame game)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xE3086C", Offset = "0xE3086C", VA = "0xE3086C", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xE308AC", Offset = "0xE308AC", VA = "0xE308AC", Slot = "7")]
		public override void EndWave()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xE308EC", Offset = "0xE308EC", VA = "0xE308EC")]
		public BatSaberWave()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class JumpOnBeat : MonoBehaviour
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_WaitForJump;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 m_StartPosition;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xE308F4", Offset = "0xE308F4", VA = "0xE308F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xE30944", Offset = "0xE30944", VA = "0xE30944")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xE30B38", Offset = "0xE30B38", VA = "0xE30B38")]
		public JumpOnBeat()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public abstract class ReplayGameMusicSequencer : MonoBehaviour
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_StopOnDisable;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool m_IsPlaying;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MusicSequencerTrack m_Track;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private uint m_PlayingId;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityEvent<int> m_OnNextBeat;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityEvent<int> m_OnBeat;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_SegmentTime;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int m_AccumulatedBeat;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_Beat;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_LastCompletedBeat;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_SegmentDuration;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly AkSegmentInfo m_SegmentInfo;

		[Token(Token = "0x1700002E")]
		public float beatDuration
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xE310E8", Offset = "0xE310E8", VA = "0xE310E8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xE310F0", Offset = "0xE310F0", VA = "0xE310F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xE306E4", Offset = "0xE306E4", VA = "0xE306E4")]
		public void Play()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xE310F8", Offset = "0xE310F8", VA = "0xE310F8")]
		private void ResetSequencer()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xE31100", Offset = "0xE31100", VA = "0xE31100")]
		private void CallbackFunction(object inCookie, AkCallbackType inType, object inInfo)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xE311BC", Offset = "0xE311BC", VA = "0xE311BC")]
		public void Update()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xE31478", Offset = "0xE31478", VA = "0xE31478")]
		private void OnBeat(int currentBeat)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xE314F4", Offset = "0xE314F4", VA = "0xE314F4")]
		public void Stop()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xE31560", Offset = "0xE31560", VA = "0xE31560")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xE31570", Offset = "0xE31570", VA = "0xE31570")]
		public void RegisterNextBeatCallback(Action<int> onNextBeat)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xE3161C", Offset = "0xE3161C", VA = "0xE3161C")]
		public void CallInNBeats(int numberOfBeats, Action<int> onNextBeat)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xE3170C", Offset = "0xE3170C", VA = "0xE3170C")]
		public void CallEveryBeat(Action<int> action)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xE30A54", Offset = "0xE30A54", VA = "0xE30A54")]
		public void CallEveryNBeat(int n, Action<int> action)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xE305DC", Offset = "0xE305DC", VA = "0xE305DC")]
		protected ReplayGameMusicSequencer()
		{
		}
	}
}
namespace WTB.Scenes.Levels.WhackAMole.WhackAMole
{
	[Token(Token = "0x2000030")]
	public class Mole : MonoBehaviour
	{
		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rigidbody m_HeadRigidbody;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("yCurve")]
		[SerializeField]
		private AnimationCurve m_YCurve;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OnCollisionHandler m_HeadCollisionHandler;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_Transform;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsActive;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool m_HasBeenHit;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		private bool m_HasBeenMissed;

		[Token(Token = "0x14000001")]
		public event Action<Mole> OnHit
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xE31910", Offset = "0xE31910", VA = "0xE31910")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xE319C0", Offset = "0xE319C0", VA = "0xE319C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<Mole> OnMiss
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xE31A70", Offset = "0xE31A70", VA = "0xE31A70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0xE31B20", Offset = "0xE31B20", VA = "0xE31B20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xE31BD0", Offset = "0xE31BD0", VA = "0xE31BD0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xE31CA4", Offset = "0xE31CA4", VA = "0xE31CA4")]
		private void HandleHeadCollision(Collision other)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xE31D34", Offset = "0xE31D34", VA = "0xE31D34")]
		private void Hit()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xE31D98", Offset = "0xE31D98", VA = "0xE31D98")]
		public void Initialize(IMusicEvent musicEvent)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xE31F78", Offset = "0xE31F78", VA = "0xE31F78")]
		private void HandleUpdate(float beat, float time)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xE320D8", Offset = "0xE320D8", VA = "0xE320D8")]
		public Mole()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[RequireComponent(typeof(MusicSequencer))]
	public class WhackAMole : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000033")]
		public class Hole
		{
			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MusicEventPosition m_MusicEventPosition;

			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform m_Transform;

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xE32730", Offset = "0xE32730", VA = "0xE32730")]
			public Hole()
			{
			}
		}

		[Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400010B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400010C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WhackAMole <>4__this;

			[Token(Token = "0x1700002F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000FF")]
				[Address(RVA = "0xE327EC", Offset = "0xE327EC", VA = "0xE327EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000030")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000101")]
				[Address(RVA = "0xE32834", Offset = "0xE32834", VA = "0xE32834", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000FC")]
			[Address(RVA = "0xE32470", Offset = "0xE32470", VA = "0xE32470")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60000FD")]
			[Address(RVA = "0xE32738", Offset = "0xE32738", VA = "0xE32738", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0xE3273C", Offset = "0xE3273C", VA = "0xE3273C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0xE327F4", Offset = "0xE327F4", VA = "0xE327F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MusicSequencer m_Sequencer;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MusicSequencerTrack m_Track;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Mole m_MolePrefab;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Hole[] m_Holes;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Header("Texts")]
		private TMP_Text m_HitCountText;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TMP_Text m_MissCountText;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<MusicEventPosition, Hole> m_HoleByType;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_HitCount;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_MissCount;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xE3222C", Offset = "0xE3222C", VA = "0xE3222C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xE32408", Offset = "0xE32408", VA = "0xE32408")]
		[IteratorStateMachine(typeof(<Start>d__10))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xE32498", Offset = "0xE32498", VA = "0xE32498")]
		private void NewMusicEvent(IMusicEvent musicEvent)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xE32708", Offset = "0xE32708", VA = "0xE32708")]
		private void HandleHit(Mole mole)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xE32718", Offset = "0xE32718", VA = "0xE32718")]
		private void HandleMiss(Mole mole)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xE32398", Offset = "0xE32398", VA = "0xE32398")]
		private void UpdateTexts()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xE32728", Offset = "0xE32728", VA = "0xE32728")]
		public WhackAMole()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.Spaseball.Scripts
{
	[Token(Token = "0x2000035")]
	public class FailBounds : MonoBehaviour
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_OnFailedBall;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Event m_FailSound;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_FailConfetti;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] m_IgnoreObjects;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_StartInvincibility;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xE3283C", Offset = "0xE3283C", VA = "0xE3283C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xE32860", Offset = "0xE32860", VA = "0xE32860")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xE32B28", Offset = "0xE32B28", VA = "0xE32B28")]
		public FailBounds()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class SpaseballBlimp : MonoBehaviour
	{
		[Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class <OutOfThePark>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000117")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000118")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpaseballBlimp <>4__this;

			[Token(Token = "0x17000031")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600010F")]
				[Address(RVA = "0xE33128", Offset = "0xE33128", VA = "0xE33128", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000032")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000111")]
				[Address(RVA = "0xE33170", Offset = "0xE33170", VA = "0xE33170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600010C")]
			[Address(RVA = "0xE32EC0", Offset = "0xE32EC0", VA = "0xE32EC0")]
			[DebuggerHidden]
			public <OutOfThePark>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600010D")]
			[Address(RVA = "0xE32F28", Offset = "0xE32F28", VA = "0xE32F28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600010E")]
			[Address(RVA = "0xE32F2C", Offset = "0xE32F2C", VA = "0xE32F2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000110")]
			[Address(RVA = "0xE33130", Offset = "0xE33130", VA = "0xE33130", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_WelcomeScreen;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_DefaultScreen;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_OutOfThePark;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_GoalIndex;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<SubGoal> m_SubGoals;

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xE32B30", Offset = "0xE32B30", VA = "0xE32B30")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xE32CBC", Offset = "0xE32CBC", VA = "0xE32CBC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xE32D84", Offset = "0xE32D84", VA = "0xE32D84")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xE32C74", Offset = "0xE32C74", VA = "0xE32C74")]
		private void ToggleScreen(bool outOfThePark)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xE32E58", Offset = "0xE32E58", VA = "0xE32E58")]
		[IteratorStateMachine(typeof(<OutOfThePark>d__9))]
		private IEnumerator OutOfThePark()
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xE32EE8", Offset = "0xE32EE8", VA = "0xE32EE8")]
		public SpaseballBlimp()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.SpacePhotoOp.Scripts
{
	[Serializable]
	[Token(Token = "0x2000038")]
	public struct InstrumentDescription
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private GameObject m_Prefab;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private Event m_Event;

		[Token(Token = "0x17000033")]
		public GameObject prefab
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0xE33178", Offset = "0xE33178", VA = "0xE33178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public Event @event
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0xE33180", Offset = "0xE33180", VA = "0xE33180")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000039")]
	public class InstrumentSelection : MonoBehaviour
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ButtonTrigger m_SwapButton;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_InstrumentAnchor;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InstrumentDescription[] m_InstrumentDescriptions;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent<GameObject> m_OnNewSelection;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject m_InstrumentInstance;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_SelectedInstrumentIndex;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_IsSwapping;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private StepSequencerTrack m_Track;

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xE33188", Offset = "0xE33188", VA = "0xE33188")]
		private void Start()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xE332C0", Offset = "0xE332C0", VA = "0xE332C0")]
		private void OnSwap()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xE33224", Offset = "0xE33224", VA = "0xE33224")]
		private void UpdateSelection()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xE332F4", Offset = "0xE332F4", VA = "0xE332F4")]
		private void DestroyCurrentInstance(Action continuation)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xE33398", Offset = "0xE33398", VA = "0xE33398")]
		private void InstantiateSelectedInstrument()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xE3347C", Offset = "0xE3347C", VA = "0xE3347C")]
		public InstrumentSelection()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class InstrumentStepEffectsManager : MonoBehaviour
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SwitchStepSequencerTrack m_SequencerTrack;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InstrumentStepEffectHandler[] m_EffectHandlers;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private StepSequencer m_StepSequencer;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private InstrumentStepEffectHandler m_InstrumentInstanceEffectHandler;

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xE33484", Offset = "0xE33484", VA = "0xE33484")]
		private void Start()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xE33548", Offset = "0xE33548", VA = "0xE33548")]
		private void OnStep()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xE33620", Offset = "0xE33620", VA = "0xE33620")]
		public void OnNewSelection(GameObject instance)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xE3367C", Offset = "0xE3367C", VA = "0xE3367C")]
		public InstrumentStepEffectsManager()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.SpacePhotoOp.Scripts.StepEffectHandlers
{
	[Token(Token = "0x200003B")]
	public class AnimationStateStepEffect : InstrumentStepEffectHandler
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator m_Animator;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_StateName;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xE33684", Offset = "0xE33684", VA = "0xE33684")]
		private void Reset()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xE336D4", Offset = "0xE336D4", VA = "0xE336D4", Slot = "4")]
		public override void OnStep(StepSequencer stepSequencer)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xE33700", Offset = "0xE33700", VA = "0xE33700")]
		public AnimationStateStepEffect()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class ColorRemapStepEffect : InstrumentStepEffectHandler
	{
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ColorRemap m_ColorRemap;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ColorReference]
		private Triband.ColorPipeline.Runtime.SerializableGUID m_OriginalColor;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[ColorReference]
		private Triband.ColorPipeline.Runtime.SerializableGUID m_OffColor;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[ColorReference]
		private Triband.ColorPipeline.Runtime.SerializableGUID m_OnColor;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_ActiveSteps;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xE33710", Offset = "0xE33710", VA = "0xE33710")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xE33760", Offset = "0xE33760", VA = "0xE33760", Slot = "4")]
		public override void OnStep(StepSequencer stepSequencer)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xE33828", Offset = "0xE33828", VA = "0xE33828")]
		private void SetOffColor()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xE3386C", Offset = "0xE3386C", VA = "0xE3386C")]
		public ColorRemapStepEffect()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public abstract class InstrumentStepEffectHandler : MonoBehaviour
	{
		[Token(Token = "0x6000125")]
		public abstract void OnStep(StepSequencer stepSequencer);

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xE33708", Offset = "0xE33708", VA = "0xE33708")]
		protected InstrumentStepEffectHandler()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class ParticleStepEffect : InstrumentStepEffectHandler
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xE33874", Offset = "0xE33874", VA = "0xE33874", Slot = "4")]
		public override void OnStep(StepSequencer _)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xE33890", Offset = "0xE33890", VA = "0xE33890")]
		public ParticleStepEffect()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class PunchTweenStepEffect : InstrumentStepEffectHandler
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_Target;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Scale;

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xE33898", Offset = "0xE33898", VA = "0xE33898", Slot = "4")]
		public override void OnStep(StepSequencer stepSequencer)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xE33920", Offset = "0xE33920", VA = "0xE33920")]
		public PunchTweenStepEffect()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.SpaceFarm.Scripts
{
	[Token(Token = "0x2000040")]
	public class DetachBat : MonoBehaviour
	{
		[Token(Token = "0x600012B")]
		[Address(RVA = "0xE33934", Offset = "0xE33934", VA = "0xE33934")]
		public void Detach(Bat bat)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xE339AC", Offset = "0xE339AC", VA = "0xE339AC")]
		public DetachBat()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.SpaceCannon
{
	[Token(Token = "0x2000041")]
	[RequireComponent(typeof(MoveObjectAlongSpline))]
	public class AddRandomSpeedToMoveObjectOnSpline : MonoBehaviour
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Min;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_Max;

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xE339B4", Offset = "0xE339B4", VA = "0xE339B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xE33A1C", Offset = "0xE33A1C", VA = "0xE33A1C")]
		public AddRandomSpeedToMoveObjectOnSpline()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.SpaceBatting.Scripts
{
	[Token(Token = "0x2000042")]
	public class BallThrower : MonoBehaviour
	{
		[Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class <InitialWaitSate>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BallThrower <>4__this;

			[Token(Token = "0x17000035")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600013A")]
				[Address(RVA = "0xE33F30", Offset = "0xE33F30", VA = "0xE33F30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000036")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600013C")]
				[Address(RVA = "0xE33F78", Offset = "0xE33F78", VA = "0xE33F78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000137")]
			[Address(RVA = "0xE33B6C", Offset = "0xE33B6C", VA = "0xE33B6C")]
			[DebuggerHidden]
			public <InitialWaitSate>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0xE33E5C", Offset = "0xE33E5C", VA = "0xE33E5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000139")]
			[Address(RVA = "0xE33E60", Offset = "0xE33E60", VA = "0xE33E60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600013B")]
			[Address(RVA = "0xE33F38", Offset = "0xE33F38", VA = "0xE33F38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class <ShootState>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BallThrower <>4__this;

			[Token(Token = "0x17000037")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000140")]
				[Address(RVA = "0xE342B0", Offset = "0xE342B0", VA = "0xE342B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000038")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000142")]
				[Address(RVA = "0xE342F8", Offset = "0xE342F8", VA = "0xE342F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600013D")]
			[Address(RVA = "0xE33BFC", Offset = "0xE33BFC", VA = "0xE33BFC")]
			[DebuggerHidden]
			public <ShootState>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x600013E")]
			[Address(RVA = "0xE33F80", Offset = "0xE33F80", VA = "0xE33F80", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600013F")]
			[Address(RVA = "0xE33F84", Offset = "0xE33F84", VA = "0xE33F84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000141")]
			[Address(RVA = "0xE342B8", Offset = "0xE342B8", VA = "0xE342B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class <WaitState>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BallThrower <>4__this;

			[Token(Token = "0x17000039")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000146")]
				[Address(RVA = "0xE34438", Offset = "0xE34438", VA = "0xE34438", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000148")]
				[Address(RVA = "0xE34480", Offset = "0xE34480", VA = "0xE34480", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000143")]
			[Address(RVA = "0xE33C8C", Offset = "0xE33C8C", VA = "0xE33C8C")]
			[DebuggerHidden]
			public <WaitState>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000144")]
			[Address(RVA = "0xE34300", Offset = "0xE34300", VA = "0xE34300", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000145")]
			[Address(RVA = "0xE34304", Offset = "0xE34304", VA = "0xE34304", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000147")]
			[Address(RVA = "0xE34440", Offset = "0xE34440", VA = "0xE34440", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class <PrepareState>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400014B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400014C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BallThrower <>4__this;

			[Token(Token = "0x1700003B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600014C")]
				[Address(RVA = "0xE345A0", Offset = "0xE345A0", VA = "0xE345A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600014E")]
				[Address(RVA = "0xE345E8", Offset = "0xE345E8", VA = "0xE345E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000149")]
			[Address(RVA = "0xE33D1C", Offset = "0xE33D1C", VA = "0xE33D1C")]
			[DebuggerHidden]
			public <PrepareState>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x600014A")]
			[Address(RVA = "0xE34488", Offset = "0xE34488", VA = "0xE34488", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600014B")]
			[Address(RVA = "0xE3448C", Offset = "0xE3448C", VA = "0xE3448C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600014D")]
			[Address(RVA = "0xE345A8", Offset = "0xE345A8", VA = "0xE345A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class <FinishedState>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400014E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BallThrower <>4__this;

			[Token(Token = "0x1700003D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000152")]
				[Address(RVA = "0xE34794", Offset = "0xE34794", VA = "0xE34794", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000154")]
				[Address(RVA = "0xE347DC", Offset = "0xE347DC", VA = "0xE347DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600014F")]
			[Address(RVA = "0xE33DAC", Offset = "0xE33DAC", VA = "0xE33DAC")]
			[DebuggerHidden]
			public <FinishedState>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000150")]
			[Address(RVA = "0xE345F0", Offset = "0xE345F0", VA = "0xE345F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000151")]
			[Address(RVA = "0xE345F4", Offset = "0xE345F4", VA = "0xE345F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000153")]
			[Address(RVA = "0xE3479C", Offset = "0xE3479C", VA = "0xE3479C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_InitialWaitTime;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WaitTime;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Spread;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_Force;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rigidbody m_BallPrefab;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_TrunkTip;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Event m_SFX;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Animator")]
		[SerializeField]
		private string m_ShootAnimatorTrigger;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string m_PrepareShotAnimatorTrigger;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_ShootID;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_PrepareShotID;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animator m_Animator;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<GameObject> m_SpawnedInstances;

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xE33A24", Offset = "0xE33A24", VA = "0xE33A24")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xE33AE4", Offset = "0xE33AE4", VA = "0xE33AE4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xE33B04", Offset = "0xE33B04", VA = "0xE33B04")]
		[IteratorStateMachine(typeof(<InitialWaitSate>d__15))]
		private IEnumerator InitialWaitSate()
		{
			return null;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE33B94", Offset = "0xE33B94", VA = "0xE33B94")]
		[IteratorStateMachine(typeof(<ShootState>d__16))]
		private IEnumerator ShootState()
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xE33C24", Offset = "0xE33C24", VA = "0xE33C24")]
		[IteratorStateMachine(typeof(<WaitState>d__17))]
		private IEnumerator WaitState()
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xE33CB4", Offset = "0xE33CB4", VA = "0xE33CB4")]
		[IteratorStateMachine(typeof(<PrepareState>d__18))]
		private IEnumerator PrepareState()
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xE33D44", Offset = "0xE33D44", VA = "0xE33D44")]
		[IteratorStateMachine(typeof(<FinishedState>d__19))]
		private IEnumerator FinishedState()
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE33DD4", Offset = "0xE33DD4", VA = "0xE33DD4")]
		public BallThrower()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class SpaceBattingBallReflector : MonoBehaviour
	{
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_ReflectionTarget;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_ReflectionSpeed;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_OnReflect;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_FailSituationRadius;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent m_OnReflectedBallLeftRadius;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_DidTrigger;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Rigidbody m_ReflectedRigidbody;

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xE347E4", Offset = "0xE347E4", VA = "0xE347E4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xE349CC", Offset = "0xE349CC", VA = "0xE349CC")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xE34B94", Offset = "0xE34B94", VA = "0xE34B94")]
		private void Update()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xE34CF4", Offset = "0xE34CF4", VA = "0xE34CF4")]
		public SpaceBattingBallReflector()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.SolarSystemModel.Scripts
{
	[Token(Token = "0x2000049")]
	[ExecuteAlways]
	public class SolarSystemModel : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200004A")]
		private struct Mapping
		{
			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			private Transform m_ModelArmTransform;

			[Token(Token = "0x400015B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			private Transform m_ModelTransform;

			[Token(Token = "0x400015C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Transform m_PlanetTransform;

			[Token(Token = "0x400015D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private bool m_IgnoreModelRotation;

			[Token(Token = "0x1700003F")]
			public bool ignoreModelRotation
			{
				[Token(Token = "0x600015E")]
				[Address(RVA = "0xE352D8", Offset = "0xE352D8", VA = "0xE352D8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000040")]
			public Transform modelArmTransform
			{
				[Token(Token = "0x600015F")]
				[Address(RVA = "0xE352E0", Offset = "0xE352E0", VA = "0xE352E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000041")]
			public Transform modelTransform
			{
				[Token(Token = "0x6000160")]
				[Address(RVA = "0xE352E8", Offset = "0xE352E8", VA = "0xE352E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000042")]
			public Transform planetTransform
			{
				[Token(Token = "0x6000161")]
				[Address(RVA = "0xE352F0", Offset = "0xE352F0", VA = "0xE352F0")]
				get
				{
					return null;
				}
			}
		}

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Mapping[] m_Mappings;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MovePlanetsSpeed;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<Transform, float> m_PlanetDistances;

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xE34CFC", Offset = "0xE34CFC", VA = "0xE34CFC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xE34E98", Offset = "0xE34E98", VA = "0xE34E98")]
		private void Update()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xE34D00", Offset = "0xE34D00", VA = "0xE34D00")]
		private void CachePlanetDistances()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xE34F30", Offset = "0xE34F30", VA = "0xE34F30")]
		private void MovePlanet(Mapping mapping)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xE352D0", Offset = "0xE352D0", VA = "0xE352D0")]
		public SolarSystemModel()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.RocketLaunch.Rocket.Scripts
{
	[Token(Token = "0x200004C")]
	public class DisableGravityOnEnable : MonoBehaviour
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody[] m_Rigidbodies;

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xE353F8", Offset = "0xE353F8", VA = "0xE353F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xE354E8", Offset = "0xE354E8", VA = "0xE354E8")]
		public DisableGravityOnEnable()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class RocketButton : MonoBehaviour
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int PushID;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RocketLaunchSequence m_Rls;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_Triggered;

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xE354F0", Offset = "0xE354F0", VA = "0xE354F0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xE35634", Offset = "0xE35634", VA = "0xE35634")]
		public RocketButton()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class RocketDoorButton : MonoBehaviour
	{
		[Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class <DoorOpenRoutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RocketDoorButton <>4__this;

			[Token(Token = "0x17000043")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000173")]
				[Address(RVA = "0xE35A50", Offset = "0xE35A50", VA = "0xE35A50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000044")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000175")]
				[Address(RVA = "0xE35A98", Offset = "0xE35A98", VA = "0xE35A98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000170")]
			[Address(RVA = "0xE35874", Offset = "0xE35874", VA = "0xE35874")]
			[DebuggerHidden]
			public <DoorOpenRoutine>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000171")]
			[Address(RVA = "0xE3596C", Offset = "0xE3596C", VA = "0xE3596C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000172")]
			[Address(RVA = "0xE35970", Offset = "0xE35970", VA = "0xE35970", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000174")]
			[Address(RVA = "0xE35A58", Offset = "0xE35A58", VA = "0xE35A58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int PushID;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int GreenID;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int OpenID;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator m_ButtonAnimator;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool m_CanBeOpened;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Animator m_DoorAnimator;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool m_Triggered;

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xE356A4", Offset = "0xE356A4", VA = "0xE356A4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xE357F8", Offset = "0xE357F8", VA = "0xE357F8")]
		public void Unlock()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xE35790", Offset = "0xE35790", VA = "0xE35790")]
		[IteratorStateMachine(typeof(<DoorOpenRoutine>d__9))]
		private IEnumerator DoorOpenRoutine()
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xE3589C", Offset = "0xE3589C", VA = "0xE3589C")]
		public RocketDoorButton()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class RocketLaunchSequence : MonoBehaviour
	{
		[Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class <RocketLaunchRoutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RocketLaunchSequence <>4__this;

			[Token(Token = "0x17000045")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600017F")]
				[Address(RVA = "0xE3605C", Offset = "0xE3605C", VA = "0xE3605C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000046")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000181")]
				[Address(RVA = "0xE360A4", Offset = "0xE360A4", VA = "0xE360A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600017C")]
			[Address(RVA = "0xE35D84", Offset = "0xE35D84", VA = "0xE35D84")]
			[DebuggerHidden]
			public <RocketLaunchRoutine>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x600017D")]
			[Address(RVA = "0xE35E50", Offset = "0xE35E50", VA = "0xE35E50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600017E")]
			[Address(RVA = "0xE35E54", Offset = "0xE35E54", VA = "0xE35E54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000180")]
			[Address(RVA = "0xE36064", Offset = "0xE36064", VA = "0xE36064", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int LookingID;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int LaunchID;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource m_AmbienceSource;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource m_FirstRocketSource;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ShakeTransform m_Shake;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator m_ElephantAnimator;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject m_ChickenTVObject;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Rigidbody[] m_CabinProps;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool m_Debug;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float m_RocketLaunchDuration;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Animator m_SequenceAnimator;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_Doneness;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool m_RocketLaunched;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool m_RocketReady;

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xE35AA0", Offset = "0xE35AA0", VA = "0xE35AA0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xE355EC", Offset = "0xE355EC", VA = "0xE355EC")]
		public void IncreasePitch()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xE35C74", Offset = "0xE35C74", VA = "0xE35C74")]
		private void LaunchRocket()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xE35D1C", Offset = "0xE35D1C", VA = "0xE35D1C")]
		[IteratorStateMachine(typeof(<RocketLaunchRoutine>d__17))]
		private IEnumerator RocketLaunchRoutine()
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xE35DAC", Offset = "0xE35DAC", VA = "0xE35DAC")]
		public RocketLaunchSequence()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class RocketSteering : MonoBehaviour
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform m_DisplayRocketTransform;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform m_LeverTransform;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RocketDoorButton m_RocketDoorButton;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_RocketSpeed;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_RocketSpeedActual;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_LeverAngle;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Bouncing;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_ArrivedSafely;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xE360AC", Offset = "0xE360AC", VA = "0xE360AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xE3610C", Offset = "0xE3610C", VA = "0xE3610C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xE363C8", Offset = "0xE363C8", VA = "0xE363C8")]
		public void ReachStation()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xE3640C", Offset = "0xE3640C", VA = "0xE3640C")]
		public RocketSteering()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class RocketSwitch : MonoBehaviour
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 m_FlippedUpRotation;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 m_FlippedDownRotation;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RocketLaunchSequence m_Rls;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform m_TransformSwitch;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_ShouldPointUp;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool m_Flipping;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool m_PitchIncreased;

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xE36414", Offset = "0xE36414", VA = "0xE36414")]
		private void Update()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xE365D0", Offset = "0xE365D0", VA = "0xE365D0")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xE36658", Offset = "0xE36658", VA = "0xE36658")]
		public RocketSwitch()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.PlanetSpinning.Scripts
{
	[Token(Token = "0x2000054")]
	public class MultiColliderTrigger : MonoBehaviour
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Collider> m_Colliders;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Collider> m_TouchingColliders;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_OnAllCollidersTouching;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Triggered;

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xE36660", Offset = "0xE36660", VA = "0xE36660")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xE36870", Offset = "0xE36870", VA = "0xE36870")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xE368C8", Offset = "0xE368C8", VA = "0xE368C8")]
		public MultiColliderTrigger()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.MarsRover
{
	[Token(Token = "0x2000055")]
	public class RoverHitRock : MonoBehaviour, IBatHitReceiver
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_OnBreak;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_Triggered;

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xE36944", Offset = "0xE36944", VA = "0xE36944", Slot = "4")]
		public void OnBatHit(Vector3 position, Vector3 velocity, Bat bat)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xE36BC8", Offset = "0xE36BC8", VA = "0xE36BC8")]
		public RoverHitRock()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.MarsRover.Scripts
{
	[Token(Token = "0x2000056")]
	public class LockRotationOnPlanet : MonoBehaviour
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_LerpFactor;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 m_RigidbodyVelocityLerped;

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xE36BD0", Offset = "0xE36BD0", VA = "0xE36BD0")]
		private void Start()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xE36C00", Offset = "0xE36C00", VA = "0xE36C00")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xE36DB4", Offset = "0xE36DB4", VA = "0xE36DB4")]
		public LockRotationOnPlanet()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class PlanetGravity : MonoBehaviour
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Rigidbody> m_AffectedRigidbodies;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Gravity;

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xE36DC4", Offset = "0xE36DC4", VA = "0xE36DC4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xE36ECC", Offset = "0xE36ECC", VA = "0xE36ECC")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xE36F90", Offset = "0xE36F90", VA = "0xE36F90")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xE372D0", Offset = "0xE372D0", VA = "0xE372D0")]
		public PlanetGravity()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class PlanetRotator : MonoBehaviour, IRequireValidation
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_RotationTarget;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RotationSpeed;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xE37358", Offset = "0xE37358", VA = "0xE37358")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xE37524", Offset = "0xE37524", VA = "0xE37524", Slot = "4")]
		public void Validate(ValidationContext context)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xE375FC", Offset = "0xE375FC", VA = "0xE375FC")]
		public PlanetRotator()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class PushDebrisOutwardsAndDespawn : MonoBehaviour
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_PushForce;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_TimeUntilDespawn;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_TimeUntilDespawnRandomOffset;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_DidInitialize;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xE3760C", Offset = "0xE3760C", VA = "0xE3760C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xE3765C", Offset = "0xE3765C", VA = "0xE3765C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xE37858", Offset = "0xE37858", VA = "0xE37858")]
		public PushDebrisOutwardsAndDespawn()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class RemoveSpringJoint : MonoBehaviour
	{
		[Token(Token = "0x600019C")]
		[Address(RVA = "0xE378C0", Offset = "0xE378C0", VA = "0xE378C0")]
		public void Remove()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xE37948", Offset = "0xE37948", VA = "0xE37948")]
		public RemoveSpringJoint()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class RotatePlanetWithJoystick : MonoBehaviour
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Joystick m_Joystick;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 m_Axis;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xE37950", Offset = "0xE37950", VA = "0xE37950")]
		private void Awake()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xE379A0", Offset = "0xE379A0", VA = "0xE379A0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xE37A20", Offset = "0xE37A20", VA = "0xE37A20")]
		public RotatePlanetWithJoystick()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class RotatingPlanetDistanceToGoalRTPC : MonoBehaviour
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_BaseballBat;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_Trophy;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RTPC m_RTPC;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_InitialDirectionToBat;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xE37A84", Offset = "0xE37A84", VA = "0xE37A84")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xE37C10", Offset = "0xE37C10", VA = "0xE37C10")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xE37EE0", Offset = "0xE37EE0", VA = "0xE37EE0")]
		private static float InverseLerp(Vector3 a, Vector3 b, Vector3 value)
		{
			return default(float);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xE37F34", Offset = "0xE37F34", VA = "0xE37F34")]
		public RotatingPlanetDistanceToGoalRTPC()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.RoverLanding.Scripts
{
	[Token(Token = "0x200005D")]
	public class AsteroidSpawner : MonoBehaviour
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rigidbody m_AsteroidPrefab;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_SpawnDistance;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_Triggered;

		[Token(Token = "0x17000047")]
		private Vector3 spawnPosition
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0xE37F3C", Offset = "0xE37F3C", VA = "0xE37F3C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xE37FDC", Offset = "0xE37FDC", VA = "0xE37FDC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xE38200", Offset = "0xE38200", VA = "0xE38200")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xE38218", Offset = "0xE38218", VA = "0xE38218")]
		public AsteroidSpawner()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.LightSaber.Scripts
{
	[Token(Token = "0x200005E")]
	public class BurnObjectOnBatCollision : MonoBehaviour
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem m_BurnParticles;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Event m_OnBurn;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_Burned;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE3822C", Offset = "0xE3822C", VA = "0xE3822C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xE384CC", Offset = "0xE384CC", VA = "0xE384CC")]
		public BurnObjectOnBatCollision()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class LightSaberBallMovement : MonoBehaviour
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_Target;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_BounceSpeed;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_BounceAmplitude;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MoveObjectAlongSpline m_Mover;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_TargetSpeed;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_ActualSpeed;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xE38540", Offset = "0xE38540", VA = "0xE38540")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xE38574", Offset = "0xE38574", VA = "0xE38574")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xE38730", Offset = "0xE38730", VA = "0xE38730")]
		public void SetSpeed(float s)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xE38738", Offset = "0xE38738", VA = "0xE38738")]
		public LightSaberBallMovement()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.LaunchIntoSpace.Scripts
{
	[Token(Token = "0x2000060")]
	public class EvaluateSwitchConfiguration : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000061")]
		public struct SwitchButtonConfiguration
		{
			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SwitchButton m_Button;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public SwitchButton.SwitchButtonState m_CorrectState;
		}

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<SwitchButtonConfiguration> m_Configurations;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_OnAllRightState;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xE38740", Offset = "0xE38740", VA = "0xE38740")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xE387E0", Offset = "0xE387E0", VA = "0xE387E0")]
		private void Check(SwitchButton s)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xE38900", Offset = "0xE38900", VA = "0xE38900")]
		public EvaluateSwitchConfiguration()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class LedLight : MonoBehaviour
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Green;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_Red;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_OnTurnedOn;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent m_OnTurnedOff;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xE38A7C", Offset = "0xE38A7C", VA = "0xE38A7C")]
		public void TurnOn()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xE38B64", Offset = "0xE38B64", VA = "0xE38B64")]
		public void TurnOff()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xE38BAC", Offset = "0xE38BAC", VA = "0xE38BAC")]
		public LedLight()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class LeverButton : MonoBehaviour
	{
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_LeverHandle;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_OnSwitchLeft;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_OnSwitchRight;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_UpTriggered;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool m_DownTriggered;

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xE38BB4", Offset = "0xE38BB4", VA = "0xE38BB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xE38C90", Offset = "0xE38C90", VA = "0xE38C90")]
		public LeverButton()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class MovePlayerOutsideRocket : MonoBehaviour
	{
		[Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class <MoveCR>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MovePlayerOutsideRocket <>4__this;

			[Token(Token = "0x17000048")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001C2")]
				[Address(RVA = "0xE38F68", Offset = "0xE38F68", VA = "0xE38F68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000049")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001C4")]
				[Address(RVA = "0xE38FB0", Offset = "0xE38FB0", VA = "0xE38FB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xE38D00", Offset = "0xE38D00", VA = "0xE38D00")]
			[DebuggerHidden]
			public <MoveCR>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xE38D50", Offset = "0xE38D50", VA = "0xE38D50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xE38D54", Offset = "0xE38D54", VA = "0xE38D54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0xE38F70", Offset = "0xE38F70", VA = "0xE38F70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_ObjectTransform;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[OptionalReference]
		[SerializeField]
		private Transform m_TargetTransform;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_CloseEyesDuration;

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xE38C98", Offset = "0xE38C98", VA = "0xE38C98")]
		[IteratorStateMachine(typeof(<MoveCR>d__3))]
		private IEnumerator MoveCR()
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xE38D28", Offset = "0xE38D28", VA = "0xE38D28")]
		public void Move()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xE38D48", Offset = "0xE38D48", VA = "0xE38D48")]
		public MovePlayerOutsideRocket()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class SpaceShipLaunchSequence : MonoBehaviour
	{
		[Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class <LaunchSequence>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpaceShipLaunchSequence <>4__this;

			[Token(Token = "0x1700004A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0xE392C0", Offset = "0xE392C0", VA = "0xE392C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0xE39308", Offset = "0xE39308", VA = "0xE39308", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xE39098", Offset = "0xE39098", VA = "0xE39098")]
			[DebuggerHidden]
			public <LaunchSequence>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xE390C8", Offset = "0xE390C8", VA = "0xE390C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xE390CC", Offset = "0xE390CC", VA = "0xE390CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xE392C8", Offset = "0xE392C8", VA = "0xE392C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_DelayBeforePlayerIsMovedOut;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_DelayBeforeLaunch;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("References")]
		[SerializeField]
		private TeleportPlayer m_TeleportPlayer;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_RocketInside;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_RocketOutside;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurveMovement m_RocketLaunchAnimation;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Event m_RocketIdleStart;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Event m_RocketIdleStop;

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xE38FB8", Offset = "0xE38FB8", VA = "0xE38FB8")]
		[ContextMenu("Start Sequence")]
		public void StartLaunchSequence()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xE39030", Offset = "0xE39030", VA = "0xE39030")]
		[IteratorStateMachine(typeof(<LaunchSequence>d__9))]
		private IEnumerator LaunchSequence()
		{
			return null;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xE390C0", Offset = "0xE390C0", VA = "0xE390C0")]
		public SpaceShipLaunchSequence()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.KissingSpaceStations.Scripts
{
	[Token(Token = "0x2000069")]
	public class LaserSwitch : MonoBehaviour
	{
		[Token(Token = "0x200006A")]
		private enum Mode
		{
			[Token(Token = "0x40001DD")]
			TriggerOnce,
			[Token(Token = "0x40001DE")]
			Hold
		}

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Mode m_Mode;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_AcceptableLips;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] m_LaserObjects;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<GameObject, FixedJoint> m_FixedJointByGameObject;

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE39310", Offset = "0xE39310", VA = "0xE39310")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE39384", Offset = "0xE39384", VA = "0xE39384")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE395C4", Offset = "0xE395C4", VA = "0xE395C4")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xE3956C", Offset = "0xE3956C", VA = "0xE3956C")]
		private bool IsAcceptable(GameObject other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE39748", Offset = "0xE39748", VA = "0xE39748")]
		public LaserSwitch()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class RotateKissingSpaceStations : MonoBehaviour
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Joystick m_Joystick;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody m_LeftSpaceStation;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rigidbody m_RightSpaceStation;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_LinearSpeed;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Degrees per second.")]
		[SerializeField]
		private float m_AngularSpeed;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_AngularAcceleration;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_CurrentAngularSpeed;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 m_LeftVelocity;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_RightVelocity;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 m_LeftSmoothVelocity;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 m_RightSmoothVelocity;

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xE39750", Offset = "0xE39750", VA = "0xE39750")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xE399EC", Offset = "0xE399EC", VA = "0xE399EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xE399F0", Offset = "0xE399F0", VA = "0xE399F0")]
		private void AlignSpaceShips()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xE39C24", Offset = "0xE39C24", VA = "0xE39C24")]
		public RotateKissingSpaceStations()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.GravityBatting.Scripts
{
	[Token(Token = "0x200006C")]
	[RequireComponent(typeof(Rigidbody))]
	public class HalfOrbitPlanet : MonoBehaviour
	{
		[Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class <ThrowBackAtPlayer>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HalfOrbitPlanet <>4__this;

			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Rigidbody handledRigidbody;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Transform <player>5__2;

			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3 <rotationAxis>5__3;

			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <linearOrbitSpeed>5__4;

			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <orbitCircumference>5__5;

			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float <lastFrameAngle>5__6;

			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private bool <isReturningToPlayer>5__7;

			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float <angle>5__8;

			[Token(Token = "0x1700004C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0xE3A9E0", Offset = "0xE3A9E0", VA = "0xE3A9E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0xE3AA28", Offset = "0xE3AA28", VA = "0xE3AA28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xE39F44", Offset = "0xE39F44", VA = "0xE39F44")]
			[DebuggerHidden]
			public <ThrowBackAtPlayer>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xE39FF4", Offset = "0xE39FF4", VA = "0xE39FF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0xE39FF8", Offset = "0xE39FF8", VA = "0xE39FF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xE3A9E8", Offset = "0xE3A9E8", VA = "0xE3A9E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_SpeedMultiplier;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_MaxOrbitSpeed;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<Rigidbody> m_TrackedRigidbodies;

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xE39C2C", Offset = "0xE39C2C", VA = "0xE39C2C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xE39ED0", Offset = "0xE39ED0", VA = "0xE39ED0")]
		[IteratorStateMachine(typeof(<ThrowBackAtPlayer>d__4))]
		private IEnumerator ThrowBackAtPlayer(Rigidbody handledRigidbody)
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xE39F6C", Offset = "0xE39F6C", VA = "0xE39F6C")]
		public HalfOrbitPlanet()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[RequireComponent(typeof(SubGoal))]
	public class HalfPlanetOrbiter : MonoBehaviour
	{
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_OmBehindPlanet;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> m_Stages;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SubGoal m_SubGoal;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_CurrentStage;

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xE3AA30", Offset = "0xE3AA30", VA = "0xE3AA30")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xE3AA80", Offset = "0xE3AA80", VA = "0xE3AA80")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xE3AB14", Offset = "0xE3AB14", VA = "0xE3AB14")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xE3A940", Offset = "0xE3A940", VA = "0xE3A940")]
		public void OnBehindPlanet()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xE3AB8C", Offset = "0xE3AB8C", VA = "0xE3AB8C")]
		public HalfPlanetOrbiter()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.FARDIS.Scripts
{
	[Token(Token = "0x200006F")]
	public class AimAtTransform : MonoBehaviour
	{
		[Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class <DoFreeze>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float seconds;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AimAtTransform <>4__this;

			[Token(Token = "0x1700004E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0xE3AD74", Offset = "0xE3AD74", VA = "0xE3AD74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001F0")]
				[Address(RVA = "0xE3ADBC", Offset = "0xE3ADBC", VA = "0xE3ADBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xE3AC8C", Offset = "0xE3AC8C", VA = "0xE3AC8C")]
			[DebuggerHidden]
			public <DoFreeze>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xE3ACBC", Offset = "0xE3ACBC", VA = "0xE3ACBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xE3ACC0", Offset = "0xE3ACC0", VA = "0xE3ACC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xE3AD7C", Offset = "0xE3AD7C", VA = "0xE3AD7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_AimAtTarget;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_Target;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_Freeze;

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xE3AB94", Offset = "0xE3AB94", VA = "0xE3AB94")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xE3ABD8", Offset = "0xE3ABD8", VA = "0xE3ABD8")]
		public void StartAiming()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xE3ABE4", Offset = "0xE3ABE4", VA = "0xE3ABE4")]
		public void StopAiming()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xE3ABEC", Offset = "0xE3ABEC", VA = "0xE3ABEC")]
		public void Freeze(float seconds)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xE3AC14", Offset = "0xE3AC14", VA = "0xE3AC14")]
		[IteratorStateMachine(typeof(<DoFreeze>d__7))]
		private IEnumerator DoFreeze(float seconds)
		{
			return null;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xE3ACB4", Offset = "0xE3ACB4", VA = "0xE3ACB4")]
		public AimAtTransform()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class ProjectileCollisionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_OnProjectileImpact;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xE3ADC4", Offset = "0xE3ADC4", VA = "0xE3ADC4")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xE3AE48", Offset = "0xE3AE48", VA = "0xE3AE48")]
		public ProjectileCollisionTrigger()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class ProjectileSpawner : MonoBehaviour
	{
		[Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class <DoFreeze>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ProjectileSpawner <>4__this;

			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float seconds;

			[Token(Token = "0x17000050")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001FE")]
				[Address(RVA = "0xE3B214", Offset = "0xE3B214", VA = "0xE3B214", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000051")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000200")]
				[Address(RVA = "0xE3B25C", Offset = "0xE3B25C", VA = "0xE3B25C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0xE3B10C", Offset = "0xE3B10C", VA = "0xE3B10C")]
			[DebuggerHidden]
			public <DoFreeze>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60001FC")]
			[Address(RVA = "0xE3B13C", Offset = "0xE3B13C", VA = "0xE3B13C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001FD")]
			[Address(RVA = "0xE3B140", Offset = "0xE3B140", VA = "0xE3B140", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xE3B21C", Offset = "0xE3B21C", VA = "0xE3B21C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_ProjectilePrefab;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_SpawnForce;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_SpawnPos;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_SpawnOnPeriod;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_SpawnPeriod;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_TimeStamp;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_TimeTarget;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent m_OnSpawn;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_Freeze;

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xE3AE50", Offset = "0xE3AE50", VA = "0xE3AE50")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xE3AE7C", Offset = "0xE3AE7C", VA = "0xE3AE7C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xE3AEDC", Offset = "0xE3AEDC", VA = "0xE3AEDC")]
		public void Spawn()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xE3B038", Offset = "0xE3B038", VA = "0xE3B038")]
		public void StopSpawningOnPeriod()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xE3B040", Offset = "0xE3B040", VA = "0xE3B040")]
		public void StartSpawningOnPeriod()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xE3B074", Offset = "0xE3B074", VA = "0xE3B074")]
		public void Freeze(float seconds)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xE3B094", Offset = "0xE3B094", VA = "0xE3B094")]
		[IteratorStateMachine(typeof(<DoFreeze>d__15))]
		private IEnumerator DoFreeze(float seconds)
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xE3B134", Offset = "0xE3B134", VA = "0xE3B134")]
		public ProjectileSpawner()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class TriggerTouchMultipleColliders : MonoBehaviour
	{
		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_Tag;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_NumCollidersRequired;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<GameObject> m_CollidersTouching;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("OnAllTouching")]
		private UnityEvent m_OnAllTouching;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xE3B264", Offset = "0xE3B264", VA = "0xE3B264")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xE3B3E8", Offset = "0xE3B3E8", VA = "0xE3B3E8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xE3B37C", Offset = "0xE3B37C", VA = "0xE3B37C")]
		private void CheckColliders()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xE3B4B8", Offset = "0xE3B4B8", VA = "0xE3B4B8")]
		public TriggerTouchMultipleColliders()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class TurnOffGameobjects : MonoBehaviour
	{
		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GameObject> m_Objects;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_StartIndex;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int m_CurIndex;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent<Transform> m_OnTurnOff;

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xE3B534", Offset = "0xE3B534", VA = "0xE3B534")]
		private void Start()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xE3B6CC", Offset = "0xE3B6CC", VA = "0xE3B6CC")]
		public void m_NextObject()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE3B7C8", Offset = "0xE3B7C8", VA = "0xE3B7C8")]
		public TurnOffGameobjects()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.BossFight.Scripts
{
	[Token(Token = "0x2000076")]
	public class AlienElephant : MonoBehaviour
	{
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MultiSubGoal m_MultiSubGoal;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_Dead;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ParticleSystem m_OnDie;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[OptionalReference]
		private ColorRemapEffect m_Effect;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Event m_OnDieEvent;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Event m_OnHitSfx;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeReference]
		private GameObjectFilter m_Filter;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeReference]
		private GameObjectFilter m_HitByJunkFilter;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_Force;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xE3B844", Offset = "0xE3B844", VA = "0xE3B844")]
		public void SetMultiSubGoal(MultiSubGoal m)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xE3B84C", Offset = "0xE3B84C", VA = "0xE3B84C")]
		private void Start()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xE3BA70", Offset = "0xE3BA70", VA = "0xE3BA70")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xE3BC1C", Offset = "0xE3BC1C", VA = "0xE3BC1C")]
		private void Die()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xE3BD30", Offset = "0xE3BD30", VA = "0xE3BD30")]
		public AlienElephant()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class BaddyBoss : MonoBehaviour
	{
		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Stage;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int Defeated;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int Healed;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_Stage;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_LeftBallSpawnPosition;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_RightBallSpawnPosition;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_LeftBlackHole;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform m_RightBlackHole;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform m_BaddyTransform;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform m_HealthBar;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image m_HealthBarImage;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[ColorReference]
		private Triband.ColorPipeline.Runtime.SerializableGUID m_HealingColor;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject m_BallPrefab;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ParticleSystem m_FlashParticles;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ParticleSystem m_SmallHeartsParticles;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float m_BallForceMultiplier;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ColorRemapEffect[] m_HitEffects;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject[] m_JunkPrefabs;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private int[] m_HealthPerStage;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ParticleSystem m_SparksParticles;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Header("SFX")]
		[SerializeField]
		private Event m_OnTeleport;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Event m_OnShootJunk;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Event m_OnHealing;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Event m_OnHitByOwnBall;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Event m_OnFail;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Event m_OnShoot;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Event m_OnStageEnd;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Event m_OnDefeated;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Header("Music")]
		[SerializeField]
		private RTPC m_HealingRTPC;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<GameObject> m_ProjectileInstances;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Animator m_Animator;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int m_Health;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Transform m_Target;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Transform m_NextBallSpawnPosition;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform m_NextJunkSpawnPosition;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private bool m_Invincible;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private List<Rigidbody> m_HitObjects;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xE3BDB4", Offset = "0xE3BDB4", VA = "0xE3BDB4")]
		private void Start()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xE3C118", Offset = "0xE3C118", VA = "0xE3C118")]
		[UsedImplicitly]
		public void PlayStageEndSfx()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xE3C1AC", Offset = "0xE3C1AC", VA = "0xE3C1AC")]
		private void OnFailed()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xE3C4C0", Offset = "0xE3C4C0", VA = "0xE3C4C0")]
		[UsedImplicitly]
		public void ShootSingleBall()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xE3C838", Offset = "0xE3C838", VA = "0xE3C838")]
		[UsedImplicitly]
		public void ShootDoubleBall()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xE3C850", Offset = "0xE3C850", VA = "0xE3C850")]
		[UsedImplicitly]
		public void Teleport()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xE3C918", Offset = "0xE3C918", VA = "0xE3C918")]
		[UsedImplicitly]
		public void ShootJunk()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xE3C5B0", Offset = "0xE3C5B0", VA = "0xE3C5B0")]
		private void ShootAtPlayer(GameObject prefab, Transform spawnPositionTransform)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xE3CA20", Offset = "0xE3CA20", VA = "0xE3CA20")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xE3CB8C", Offset = "0xE3CB8C", VA = "0xE3CB8C")]
		private void HandleHitsWhileFighting()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xE3CED0", Offset = "0xE3CED0", VA = "0xE3CED0")]
		private void HandleHitsWhileHealing(GameObject projectile)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xE3C304", Offset = "0xE3C304", VA = "0xE3C304")]
		private void HandleEndOfStage()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xE3C048", Offset = "0xE3C048", VA = "0xE3C048")]
		private void UpdateHealth(int newValue)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xE3D0C8", Offset = "0xE3D0C8", VA = "0xE3D0C8")]
		public BaddyBoss()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class BaddyBossFightAnimationSounds : MonoBehaviour
	{
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_BaddyTransform;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Event m_OnHatchOpening;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Event m_HeartBeat;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Event m_Breath;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Event m_OnEnter;

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xE3D24C", Offset = "0xE3D24C", VA = "0xE3D24C")]
		[UsedImplicitly]
		public void PlayEnterSfx()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xE3D2CC", Offset = "0xE3D2CC", VA = "0xE3D2CC")]
		[UsedImplicitly]
		public void PlayHatchOpeningSfx()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xE3D34C", Offset = "0xE3D34C", VA = "0xE3D34C")]
		[UsedImplicitly]
		public void PlayBreathSfx()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xE3D3CC", Offset = "0xE3D3CC", VA = "0xE3D3CC")]
		[UsedImplicitly]
		public void PlayHeartbeatSfx()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xE3D44C", Offset = "0xE3D44C", VA = "0xE3D44C")]
		public BaddyBossFightAnimationSounds()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class BaddyProjectile : MonoBehaviour
	{
		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_ExplosionPrefab;

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xE3D454", Offset = "0xE3D454", VA = "0xE3D454")]
		private void Start()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xE3D4F8", Offset = "0xE3D4F8", VA = "0xE3D4F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xE3D59C", Offset = "0xE3D59C", VA = "0xE3D59C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xE3D910", Offset = "0xE3D910", VA = "0xE3D910")]
		public BaddyProjectile()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class BlackHolePortal : MonoBehaviour
	{
		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BlackHolePortal m_ConnectedPortal;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_ShootOutDestination;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_ShootoutForce;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeReference]
		private GameObjectFilter m_Filter;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xE3D918", Offset = "0xE3D918", VA = "0xE3D918")]
		private void Start()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xE3D91C", Offset = "0xE3D91C", VA = "0xE3D91C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xE3D9C4", Offset = "0xE3D9C4", VA = "0xE3D9C4")]
		private void ShootOut(Rigidbody r)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xE3DB74", Offset = "0xE3DB74", VA = "0xE3DB74")]
		public BlackHolePortal()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class BossAnimationSFX : MonoBehaviour
	{
		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Event m_Sad;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Event m_Angry;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Event m_Shoot;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Event m_LaserEyes;

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xE3DC38", Offset = "0xE3DC38", VA = "0xE3DC38")]
		[UsedImplicitly]
		public void PlaySad()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xE3DCC0", Offset = "0xE3DCC0", VA = "0xE3DCC0")]
		[UsedImplicitly]
		public void PlayAngry()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xE3DCC8", Offset = "0xE3DCC8", VA = "0xE3DCC8")]
		[UsedImplicitly]
		public void PlayShoot()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xE3DCD0", Offset = "0xE3DCD0", VA = "0xE3DCD0")]
		[UsedImplicitly]
		public void PlayLaserEyes()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xE3DC40", Offset = "0xE3DC40", VA = "0xE3DC40")]
		private void Play(Event e)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xE3DCD8", Offset = "0xE3DCD8", VA = "0xE3DCD8")]
		public BossAnimationSFX()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class BossCannon : MonoBehaviour
	{
		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_RocketPrefab;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Spline m_Spline;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_TimeOffset;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ParticleSystem m_ShootingParticleSystem;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ParticleSystem m_ExplosionParticles;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeReference]
		private GameObjectFilter m_Filter;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Event m_SfxOnExplode;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent m_OnRocketFired;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<GameObject> m_RocketInstances;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Situation m_Situation;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_TimeToNextRocket;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_IsBeingDestroyed;

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xE3DCE0", Offset = "0xE3DCE0", VA = "0xE3DCE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xE3DD88", Offset = "0xE3DD88", VA = "0xE3DD88")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xE3E078", Offset = "0xE3E078", VA = "0xE3E078")]
		private void Update()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xE3E0C4", Offset = "0xE3E0C4", VA = "0xE3E0C4")]
		private void FireRocket()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xE3E36C", Offset = "0xE3E36C", VA = "0xE3E36C")]
		public BossCannon()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class BossRocketController : MonoBehaviour, IHittable
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Duration;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_OnHit;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve m_Curve;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_Time;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Spline m_Spline;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Situation m_Situation;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsFree;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_SplineLength;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Event m_OnLaunch;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_AutoAimFactor;

		[Token(Token = "0x17000052")]
		public bool allowAutoAim
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0xE3E3D4", Offset = "0xE3E3D4", VA = "0xE3E3D4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public UnityEvent onHit
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0xE3E3DC", Offset = "0xE3E3DC", VA = "0xE3E3DC", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public bool useGravity
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0xE3E3E4", Offset = "0xE3E3E4", VA = "0xE3E3E4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		public bool isFree
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0xE3E3EC", Offset = "0xE3E3EC", VA = "0xE3E3EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xE3E3F4", Offset = "0xE3E3F4", VA = "0xE3E3F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xE3E498", Offset = "0xE3E498", VA = "0xE3E498")]
		private void Update()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xE3E340", Offset = "0xE3E340", VA = "0xE3E340")]
		public void SetSpline(Spline spline)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xE3E780", Offset = "0xE3E780", VA = "0xE3E780", Slot = "8")]
		public void BaseballHit(Vector3 velocity, Vector3 collisionPoint, Bat bat, Collision collision)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xE3E92C", Offset = "0xE3E92C", VA = "0xE3E92C")]
		private void SetCollisionBetweenBatAndHittable(Bat bat, bool enable)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xE3EA3C", Offset = "0xE3EA3C", VA = "0xE3EA3C")]
		public BossRocketController()
		{
		}

		[SpecialName]
		[Token(Token = "0x6000241")]
		[Address(RVA = "0xE3EA44", Offset = "0xE3EA44", VA = "0xE3EA44", Slot = "5")]
		private GameObject WTB.Runtime.GameLogic.IHittable.get_gameObject()
		{
			return null;
		}
	}
	[Token(Token = "0x200007F")]
	public class ElephantLookAtHittable : MonoBehaviour
	{
		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeReference]
		private GameObjectFilter m_Filter;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_LookAtDuration;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve m_Curve;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Event m_AnnoyedElephant;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AxisConstraint m_Constraint;

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xE3EAA8", Offset = "0xE3EAA8", VA = "0xE3EAA8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xE3ECFC", Offset = "0xE3ECFC", VA = "0xE3ECFC")]
		public ElephantLookAtHittable()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class FakePhotoOp : MonoBehaviour
	{
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PolaroidPrinter m_PolaroidPrinter;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PhotoOpData m_PhotoOpData;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xE3ED64", Offset = "0xE3ED64", VA = "0xE3ED64")]
		public void Complete()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xE3EDD8", Offset = "0xE3EDD8", VA = "0xE3EDD8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xE3EE80", Offset = "0xE3EE80", VA = "0xE3EE80")]
		private void SavePicture(RenderTexture renderTexture)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xE3EF70", Offset = "0xE3EF70", VA = "0xE3EF70")]
		public FakePhotoOp()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class MiniElephants : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000084")]
		private struct TrunkAndSpawner
		{
			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Animator m_Animator;

			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform m_Transform;
		}

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<TrunkAndSpawner> m_Spawners;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<AlienElephant> m_MiniElephantPrefab;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Event m_Shoot;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MultiSubGoal m_MultiSubGoal;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_NumSpawned;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Shoot;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<float> m_ElephantSpawnTimes;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<int> m_TrunkIndex;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AnimationClip[] m_ShootClips;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_CurrentTrunk;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float timeSinceShoot;

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xE3F068", Offset = "0xE3F068", VA = "0xE3F068")]
		private void Start()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xE3F224", Offset = "0xE3F224", VA = "0xE3F224")]
		private void Spawn()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xE3F424", Offset = "0xE3F424", VA = "0xE3F424")]
		private void Update()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xE3F450", Offset = "0xE3F450", VA = "0xE3F450")]
		private void ShootAudio()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xE3F4E8", Offset = "0xE3F4E8", VA = "0xE3F4E8")]
		public MiniElephants()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class MoveElephantFromPreviousPosition : MonoBehaviour
	{
		[Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class <MoveX>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MoveElephantFromPreviousPosition <>4__this;

			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000058")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000264")]
				[Address(RVA = "0xE3FB40", Offset = "0xE3FB40", VA = "0xE3FB40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000059")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000266")]
				[Address(RVA = "0xE3FB88", Offset = "0xE3FB88", VA = "0xE3FB88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000261")]
			[Address(RVA = "0xE3F920", Offset = "0xE3F920", VA = "0xE3F920")]
			[DebuggerHidden]
			public <MoveX>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000262")]
			[Address(RVA = "0xE3F9CC", Offset = "0xE3F9CC", VA = "0xE3F9CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0xE3F9D0", Offset = "0xE3F9D0", VA = "0xE3F9D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000265")]
			[Address(RVA = "0xE3FB48", Offset = "0xE3FB48", VA = "0xE3FB48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000088")]
		[CompilerGenerated]
		private sealed class <MoveY>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MoveElephantFromPreviousPosition <>4__this;

			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700005A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600026A")]
				[Address(RVA = "0xE3FD04", Offset = "0xE3FD04", VA = "0xE3FD04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600026C")]
				[Address(RVA = "0xE3FD4C", Offset = "0xE3FD4C", VA = "0xE3FD4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0xE3F948", Offset = "0xE3F948", VA = "0xE3F948")]
			[DebuggerHidden]
			public <MoveY>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000268")]
			[Address(RVA = "0xE3FB90", Offset = "0xE3FB90", VA = "0xE3FB90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000269")]
			[Address(RVA = "0xE3FB94", Offset = "0xE3FB94", VA = "0xE3FB94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600026B")]
			[Address(RVA = "0xE3FD0C", Offset = "0xE3FD0C", VA = "0xE3FD0C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class <MoveZ>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MoveElephantFromPreviousPosition <>4__this;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700005C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000270")]
				[Address(RVA = "0xE3FEC8", Offset = "0xE3FEC8", VA = "0xE3FEC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000272")]
				[Address(RVA = "0xE3FF10", Offset = "0xE3FF10", VA = "0xE3FF10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0xE3F970", Offset = "0xE3F970", VA = "0xE3F970")]
			[DebuggerHidden]
			public <MoveZ>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0xE3FD54", Offset = "0xE3FD54", VA = "0xE3FD54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0xE3FD58", Offset = "0xE3FD58", VA = "0xE3FD58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000271")]
			[Address(RVA = "0xE3FED0", Offset = "0xE3FED0", VA = "0xE3FED0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 m_PreviousPosition;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve m_PositionX;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve m_PositionY;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve m_PositionZ;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_XDuration;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_YDuration;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float m_ZDuration;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_XDelay;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_YDelay;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_ZDelay;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 m_CurrentPosition;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float x;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float y;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float z;

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xE3F700", Offset = "0xE3F700", VA = "0xE3F700")]
		private void Start()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xE3F7E8", Offset = "0xE3F7E8", VA = "0xE3F7E8")]
		[IteratorStateMachine(typeof(<MoveX>d__15))]
		private IEnumerator MoveX()
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xE3F850", Offset = "0xE3F850", VA = "0xE3F850")]
		[IteratorStateMachine(typeof(<MoveY>d__16))]
		private IEnumerator MoveY()
		{
			return null;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xE3F8B8", Offset = "0xE3F8B8", VA = "0xE3F8B8")]
		[IteratorStateMachine(typeof(<MoveZ>d__17))]
		private IEnumerator MoveZ()
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xE3F998", Offset = "0xE3F998", VA = "0xE3F998")]
		private void Update()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xE3F9C4", Offset = "0xE3F9C4", VA = "0xE3F9C4")]
		public MoveElephantFromPreviousPosition()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[RequireComponent(typeof(Spawner))]
	public class RandomAutoSpawn : MonoBehaviour
	{
		[Token(Token = "0x200008B")]
		[CompilerGenerated]
		private sealed class <SpawnAgain>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RandomAutoSpawn <>4__this;

			[Token(Token = "0x1700005E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600027A")]
				[Address(RVA = "0xE40148", Offset = "0xE40148", VA = "0xE40148", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600027C")]
				[Address(RVA = "0xE40190", Offset = "0xE40190", VA = "0xE40190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000277")]
			[Address(RVA = "0xE400B0", Offset = "0xE400B0", VA = "0xE400B0")]
			[DebuggerHidden]
			public <SpawnAgain>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000278")]
			[Address(RVA = "0xE400E0", Offset = "0xE400E0", VA = "0xE400E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000279")]
			[Address(RVA = "0xE400E4", Offset = "0xE400E4", VA = "0xE400E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600027B")]
			[Address(RVA = "0xE40150", Offset = "0xE40150", VA = "0xE40150", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] m_Objects;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Spawner m_Spawner;

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xE3FF18", Offset = "0xE3FF18", VA = "0xE3FF18")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xE3FFD0", Offset = "0xE3FFD0", VA = "0xE3FFD0")]
		private void OnSpawn(GameObject instance)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xE40048", Offset = "0xE40048", VA = "0xE40048")]
		[IteratorStateMachine(typeof(<SpawnAgain>d__4))]
		private IEnumerator SpawnAgain()
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xE400D8", Offset = "0xE400D8", VA = "0xE400D8")]
		public RandomAutoSpawn()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.BigBang
{
	[Token(Token = "0x200008C")]
	public class Balloon : MonoBehaviour
	{
		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_EndPosition;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Duration;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve m_Curve;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_Pop;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_Noise;

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xE40198", Offset = "0xE40198", VA = "0xE40198")]
		private void Start()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xE401A8", Offset = "0xE401A8", VA = "0xE401A8")]
		public void Pop()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xE402D0", Offset = "0xE402D0", VA = "0xE402D0")]
		public Balloon()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class Rocket : MonoBehaviour
	{
		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ButtonTrigger m_LeftButton;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ButtonTrigger m_RightButton;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Thruster m_LeftThruster;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Thruster m_RightThruster;

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xE40480", Offset = "0xE40480", VA = "0xE40480")]
		private void Update()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xE40514", Offset = "0xE40514", VA = "0xE40514")]
		public Rocket()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class Thruster : MonoBehaviour
	{
		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("force")]
		private float m_Force;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_ForcePoint;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 m_Torque;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Switch m_VehicleType;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly AudioEventToggle m_AudioToggle;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_IsOn;

		[Token(Token = "0x17000060")]
		public bool isOn
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0xE40638", Offset = "0xE40638", VA = "0xE40638")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000286")]
			[Address(RVA = "0xE404F8", Offset = "0xE404F8", VA = "0xE404F8")]
			set
			{
			}
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xE4051C", Offset = "0xE4051C", VA = "0xE4051C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xE40640", Offset = "0xE40640", VA = "0xE40640")]
		private void ChangeState(bool on)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xE407A4", Offset = "0xE407A4", VA = "0xE407A4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xE4085C", Offset = "0xE4085C", VA = "0xE4085C")]
		public Thruster()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.BabySpaceWorm.Scripts
{
	[Token(Token = "0x2000090")]
	public class CheckIfAllObjectsAreDestroyed : MonoBehaviour
	{
		[Token(Token = "0x2000091")]
		[CompilerGenerated]
		private sealed class <WaitAndCheck>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CheckIfAllObjectsAreDestroyed <>4__this;

			[Token(Token = "0x17000061")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000290")]
				[Address(RVA = "0xE40C40", Offset = "0xE40C40", VA = "0xE40C40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000062")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000292")]
				[Address(RVA = "0xE40C88", Offset = "0xE40C88", VA = "0xE40C88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0xE4099C", Offset = "0xE4099C", VA = "0xE4099C")]
			[DebuggerHidden]
			public <WaitAndCheck>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0xE40A40", Offset = "0xE40A40", VA = "0xE40A40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0xE40A44", Offset = "0xE40A44", VA = "0xE40A44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0xE40C48", Offset = "0xE40C48", VA = "0xE40C48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GameObject> m_Objects;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_OnAllDestroyed;

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xE40914", Offset = "0xE40914", VA = "0xE40914")]
		public void m_DoCheck()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xE40934", Offset = "0xE40934", VA = "0xE40934")]
		[IteratorStateMachine(typeof(<WaitAndCheck>d__3))]
		private IEnumerator WaitAndCheck()
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xE409C4", Offset = "0xE409C4", VA = "0xE409C4")]
		public CheckIfAllObjectsAreDestroyed()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class TriggerDestroy : MonoBehaviour
	{
		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IgnoreTags;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> m_Tags;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_OnDestroyed;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_HittablesOnly;

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xE40C90", Offset = "0xE40C90", VA = "0xE40C90")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xE40DA4", Offset = "0xE40DA4", VA = "0xE40DA4")]
		public TriggerDestroy()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Space.AngrySpaceFish.Scripts
{
	[Token(Token = "0x2000093")]
	public class PufferPlanet : MonoBehaviour
	{
		[Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform1;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PufferPlanet <>4__this;

			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x600029A")]
			[Address(RVA = "0xE40FF0", Offset = "0xE40FF0", VA = "0xE40FF0")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0xE40FF8", Offset = "0xE40FF8", VA = "0xE40FF8")]
			internal void <Planetize>b__0(float t)
			{
			}
		}

		[Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class <Planetize>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PufferPlanet <>4__this;

			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 position;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private <>c__DisplayClass4_0 <>8__1;

			[Token(Token = "0x17000063")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600029F")]
				[Address(RVA = "0xE415F8", Offset = "0xE415F8", VA = "0xE415F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000064")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002A1")]
				[Address(RVA = "0xE41640", Offset = "0xE41640", VA = "0xE41640", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0xE40EA4", Offset = "0xE40EA4", VA = "0xE40EA4")]
			[DebuggerHidden]
			public <Planetize>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0xE41264", Offset = "0xE41264", VA = "0xE41264", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0xE41268", Offset = "0xE41268", VA = "0xE41268", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002A0")]
			[Address(RVA = "0xE41600", Offset = "0xE41600", VA = "0xE41600", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EyeExpressions m_Eyes;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_PlanetScale;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rb;

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xE40DB4", Offset = "0xE40DB4", VA = "0xE40DB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xE40E18", Offset = "0xE40E18", VA = "0xE40E18")]
		[IteratorStateMachine(typeof(<Planetize>d__4))]
		private IEnumerator Planetize(Vector3 position)
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xE40ECC", Offset = "0xE40ECC", VA = "0xE40ECC")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xE40F10", Offset = "0xE40F10", VA = "0xE40F10")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xE40FE0", Offset = "0xE40FE0", VA = "0xE40FE0")]
		public PufferPlanet()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Onboarding.ToyDrumset.Scripts
{
	[Token(Token = "0x2000096")]
	public class Drum : MonoBehaviour
	{
		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] m_DrumClips;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m_PitchOffset;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource m_Source;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Drumset m_Drumset;

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xE41648", Offset = "0xE41648", VA = "0xE41648")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xE416C4", Offset = "0xE416C4", VA = "0xE416C4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xE41860", Offset = "0xE41860", VA = "0xE41860")]
		public Drum()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class Drumset : MonoBehaviour
	{
		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m_DrummingIntensity;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m_ImpactForceMax;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m_ImpactForceMin;

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xE41870", Offset = "0xE41870", VA = "0xE41870")]
		private void Update()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xE41890", Offset = "0xE41890", VA = "0xE41890")]
		public Drumset()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class FishKnockingBack : MonoBehaviour
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ToydrumsetApple m_ModelAirplane;

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xE41898", Offset = "0xE41898", VA = "0xE41898")]
		public void KnockBack()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xE41938", Offset = "0xE41938", VA = "0xE41938")]
		public FishKnockingBack()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class PhysicsMayhemizer : MonoBehaviour
	{
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_ForceAmountMin;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_ForceAmountMax;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody[] m_Rigidbodies;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Drumset m_Drumset;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int m_CompleteSituationAfterHits;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Situation m_Situation;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_TimesHit;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_Completed;

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xE41940", Offset = "0xE41940", VA = "0xE41940")]
		private void Update()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xE41B28", Offset = "0xE41B28", VA = "0xE41B28")]
		public PhysicsMayhemizer()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class PhysModelAirplane : MonoBehaviour
	{
		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Situation m_Situation;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_TriggerCompleteWhenBelowThisYPosition;

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xE41B30", Offset = "0xE41B30", VA = "0xE41B30")]
		private void Update()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xE41B78", Offset = "0xE41B78", VA = "0xE41B78")]
		public PhysModelAirplane()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class SonicBoomSpeaker : MonoBehaviour
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Collider[] ColliderResultsCache;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool m_Boom;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Drumset m_Drumset;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_ForceAmountMax;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_ForceAmountMin;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BoxCollider m_ForceTrigger;

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xE41B80", Offset = "0xE41B80", VA = "0xE41B80")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xE41BD0", Offset = "0xE41BD0", VA = "0xE41BD0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xE41F28", Offset = "0xE41F28", VA = "0xE41F28")]
		public void SonicBoom()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xE422AC", Offset = "0xE422AC", VA = "0xE422AC")]
		public SonicBoomSpeaker()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class ToydrumsetApple : MonoBehaviour
	{
		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int BlendID;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int MoveBackID;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int KnockBack1ID;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int KnockBack2ID;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int FallDownID;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator m_ChildAnimator;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Confetti m_Confetti;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Drumset m_Drumset;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Animator m_FishAnimator;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Situation m_Situation;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject m_WinText;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator m_Animator;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_ShakeTarget;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_ShakeActual;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_PropFallen;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_HasBeenPushedBack;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_PropCanMove;

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xE4231C", Offset = "0xE4231C", VA = "0xE4231C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xE42388", Offset = "0xE42388", VA = "0xE42388")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xE4249C", Offset = "0xE4249C", VA = "0xE4249C")]
		public void AppleFall()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xE424C8", Offset = "0xE424C8", VA = "0xE424C8")]
		public void CompleteSituation()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xE424F8", Offset = "0xE424F8", VA = "0xE424F8")]
		public void Win()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xE418B0", Offset = "0xE418B0", VA = "0xE418B0")]
		public void MoveBack()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xE424FC", Offset = "0xE424FC", VA = "0xE424FC")]
		public void SetMoveLegal()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xE42508", Offset = "0xE42508", VA = "0xE42508")]
		public void ReachEnd()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xE42618", Offset = "0xE42618", VA = "0xE42618")]
		public ToydrumsetApple()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Onboarding.BeerPong.Scripts
{
	[Token(Token = "0x200009D")]
	public class BeerPongController : MonoBehaviour
	{
		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Situation m_Situation;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BeerPongFish m_Fish;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BeerPongGlass[] m_BeerPongGlasses;

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xE42748", Offset = "0xE42748", VA = "0xE42748")]
		public void Scored(Vector3 position)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xE42838", Offset = "0xE42838", VA = "0xE42838")]
		public void Prepare()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xE4287C", Offset = "0xE4287C", VA = "0xE4287C")]
		public BeerPongController()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class BeerPongFish : MonoBehaviour, IResettable
	{
		[Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class <Jump>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BeerPongFish <>4__this;

			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 glassPosition;

			[Token(Token = "0x17000065")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002CC")]
				[Address(RVA = "0xE42E74", Offset = "0xE42E74", VA = "0xE42E74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002CE")]
				[Address(RVA = "0xE42EBC", Offset = "0xE42EBC", VA = "0xE42EBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0xE42ACC", Offset = "0xE42ACC", VA = "0xE42ACC")]
			[DebuggerHidden]
			public <Jump>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xE42D08", Offset = "0xE42D08", VA = "0xE42D08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0xE42D0C", Offset = "0xE42D0C", VA = "0xE42D0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0xE42E7C", Offset = "0xE42E7C", VA = "0xE42E7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class <ReturnToOriginalPosition>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BeerPongFish <>4__this;

			[Token(Token = "0x17000067")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002D4")]
				[Address(RVA = "0xE43088", Offset = "0xE43088", VA = "0xE43088", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002D6")]
				[Address(RVA = "0xE430D0", Offset = "0xE430D0", VA = "0xE430D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0xE42AF4", Offset = "0xE42AF4", VA = "0xE42AF4")]
			[DebuggerHidden]
			public <ReturnToOriginalPosition>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xE42F4C", Offset = "0xE42F4C", VA = "0xE42F4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xE42F50", Offset = "0xE42F50", VA = "0xE42F50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0xE43090", Offset = "0xE43090", VA = "0xE43090", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int DrinkID;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int SadID;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem m_BeerSplash;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 m_GlassDrinkingAdjustment;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator m_Animator;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_OriginalPos;

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xE42884", Offset = "0xE42884", VA = "0xE42884")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xE42774", Offset = "0xE42774", VA = "0xE42774")]
		public void Drink(Vector3 glassPosition)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xE42984", Offset = "0xE42984", VA = "0xE42984")]
		public void BeSad(bool sad)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xE428F8", Offset = "0xE428F8", VA = "0xE428F8")]
		[IteratorStateMachine(typeof(<Jump>d__9))]
		private IEnumerator Jump(Vector3 glassPosition)
		{
			return null;
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xE42A64", Offset = "0xE42A64", VA = "0xE42A64")]
		[IteratorStateMachine(typeof(<ReturnToOriginalPosition>d__10))]
		private IEnumerator ReturnToOriginalPosition()
		{
			return null;
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xE42B1C", Offset = "0xE42B1C", VA = "0xE42B1C", Slot = "4")]
		public void ResetState()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xE42BCC", Offset = "0xE42BCC", VA = "0xE42BCC")]
		public BeerPongFish()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class BeerPongGlass : MonoBehaviour, IResettable
	{
		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BeerPongController m_Controller;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_Scored;

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xE430D8", Offset = "0xE430D8", VA = "0xE430D8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xE431AC", Offset = "0xE431AC", VA = "0xE431AC")]
		public void SetController(BeerPongController controller)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xE431B4", Offset = "0xE431B4", VA = "0xE431B4", Slot = "4")]
		public void ResetState()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xE431BC", Offset = "0xE431BC", VA = "0xE431BC")]
		public BeerPongGlass()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class BeerPongGlassPin : MonoBehaviour
	{
		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BeerPongSit3Controller m_Controller;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_Tipped;

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xE431C4", Offset = "0xE431C4", VA = "0xE431C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xE43238", Offset = "0xE43238", VA = "0xE43238")]
		private void Tipped()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xE431F0", Offset = "0xE431F0", VA = "0xE431F0")]
		private bool IsTipped()
		{
			return default(bool);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xE43300", Offset = "0xE43300", VA = "0xE43300")]
		public BeerPongGlassPin()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class BeerPongSit3Controller : MonoBehaviour
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BeerPongFish m_Fish;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_GlassPinContainer;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_DrinkingTimePerGlass;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Situation m_Situation;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Spawner m_Spawner;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject m_Ball;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<BeerPongGlassPin> m_Glasses;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_NextDrink;

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xE43308", Offset = "0xE43308", VA = "0xE43308")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xE4348C", Offset = "0xE4348C", VA = "0xE4348C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xE43254", Offset = "0xE43254", VA = "0xE43254")]
		public void GlassTipped(BeerPongGlassPin glass)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xE434C8", Offset = "0xE434C8", VA = "0xE434C8")]
		private void DrinkFromNewGlass()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xE4357C", Offset = "0xE4357C", VA = "0xE4357C")]
		public BeerPongSit3Controller()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class Suction : MonoBehaviour
	{
		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Force;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_SuckInteractablesOnly;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Rigidbody> m_AffectedObjects;

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xE43600", Offset = "0xE43600", VA = "0xE43600")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xE43674", Offset = "0xE43674", VA = "0xE43674")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xE438C0", Offset = "0xE438C0", VA = "0xE438C0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xE43A50", Offset = "0xE43A50", VA = "0xE43A50")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xE43B14", Offset = "0xE43B14", VA = "0xE43B14")]
		public Suction()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Onboarding.Batting_1.Scripts
{
	[Token(Token = "0x20000A7")]
	public class EggAndChicken : MonoBehaviour, IHittable
	{
		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Egg;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_Chicken;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ConstantAcceleration m_ConstantAcceleration;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Event m_OnHitAudio;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Event m_OnStartFlyingAudio;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent m_OnHit;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_HitTime;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool m_IsChicken;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_IsFlying;

		[Token(Token = "0x17000069")]
		public UnityEvent onHit
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xE43F9C", Offset = "0xE43F9C", VA = "0xE43F9C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public bool useGravity
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xE4412C", Offset = "0xE4412C", VA = "0xE4412C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		public bool allowAutoAim
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xE44148", Offset = "0xE44148", VA = "0xE44148", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xE43B24", Offset = "0xE43B24", VA = "0xE43B24")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xE43B74", Offset = "0xE43B74", VA = "0xE43B74")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xE43EE0", Offset = "0xE43EE0", VA = "0xE43EE0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xE43BC0", Offset = "0xE43BC0", VA = "0xE43BC0")]
		private void StartFlying()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xE43FA4", Offset = "0xE43FA4", VA = "0xE43FA4", Slot = "8")]
		private void WTB.Runtime.GameLogic.IHittable.BaseballHit(Vector3 velocity, Vector3 collisionPoint, Bat bat, Collision collision)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xE44150", Offset = "0xE44150", VA = "0xE44150")]
		public EggAndChicken()
		{
		}

		[SpecialName]
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xE44158", Offset = "0xE44158", VA = "0xE44158", Slot = "5")]
		private GameObject WTB.Runtime.GameLogic.IHittable.get_gameObject()
		{
			return null;
		}
	}
	[Token(Token = "0x20000A8")]
	public class MoveRigidbodyOnPath : MonoBehaviour, IRequireValidation
	{
		[Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class <Sequence>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MoveRigidbodyOnPath <>4__this;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700006C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002FF")]
				[Address(RVA = "0xE44708", Offset = "0xE44708", VA = "0xE44708", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000301")]
				[Address(RVA = "0xE44750", Offset = "0xE44750", VA = "0xE44750", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xE44318", Offset = "0xE44318", VA = "0xE44318")]
			[DebuggerHidden]
			public <Sequence>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0xE444B0", Offset = "0xE444B0", VA = "0xE444B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xE444B4", Offset = "0xE444B4", VA = "0xE444B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0xE44710", Offset = "0xE44710", VA = "0xE44710", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform[] m_PathPoints;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_StartOnAwake;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool m_IsMoving;

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xE441CC", Offset = "0xE441CC", VA = "0xE441CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xE4427C", Offset = "0xE4427C", VA = "0xE4427C")]
		public void Go()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xE442B0", Offset = "0xE442B0", VA = "0xE442B0")]
		[IteratorStateMachine(typeof(<Sequence>d__7))]
		private IEnumerator Sequence()
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xE44340", Offset = "0xE44340", VA = "0xE44340", Slot = "4")]
		public void Validate(ValidationContext context)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xE443AC", Offset = "0xE443AC", VA = "0xE443AC")]
		public MoveRigidbodyOnPath()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class MoveTroughPipe : MonoBehaviour
	{
		[Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class <ThroughPipe>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Rigidbody rb;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MoveTroughPipe <>4__this;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <outTime>5__2;

			[Token(Token = "0x1700006E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000309")]
				[Address(RVA = "0xE44AC4", Offset = "0xE44AC4", VA = "0xE44AC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600030B")]
				[Address(RVA = "0xE44B0C", Offset = "0xE44B0C", VA = "0xE44B0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0xE44900", Offset = "0xE44900", VA = "0xE44900")]
			[DebuggerHidden]
			public <ThroughPipe>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0xE4493C", Offset = "0xE4493C", VA = "0xE4493C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0xE44940", Offset = "0xE44940", VA = "0xE44940", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0xE44ACC", Offset = "0xE44ACC", VA = "0xE44ACC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OnTriggerHandler m_PipeInCollider;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_PipeOutTransform;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_DurationInPipe;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_PipeOutSpeed;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_MinOutInterval;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_LastOutTime;

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xE44758", Offset = "0xE44758", VA = "0xE44758")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xE447E4", Offset = "0xE447E4", VA = "0xE447E4")]
		private void HandlePipeInEvent(Collider other)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xE4488C", Offset = "0xE4488C", VA = "0xE4488C")]
		[IteratorStateMachine(typeof(<ThroughPipe>d__8))]
		private IEnumerator ThroughPipe(Rigidbody rb)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xE44928", Offset = "0xE44928", VA = "0xE44928")]
		public MoveTroughPipe()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class ResetButtonTutorial : MonoBehaviour
	{
		[Token(Token = "0x20000AE")]
		[CompilerGenerated]
		private sealed class <TutorialCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ResetButtonTutorial <>4__this;

			[Token(Token = "0x17000070")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000315")]
				[Address(RVA = "0xE45068", Offset = "0xE45068", VA = "0xE45068", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000317")]
				[Address(RVA = "0xE450B0", Offset = "0xE450B0", VA = "0xE450B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0xE44E2C", Offset = "0xE44E2C", VA = "0xE44E2C")]
			[DebuggerHidden]
			public <TutorialCoroutine>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0xE44EA8", Offset = "0xE44EA8", VA = "0xE44EA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0xE44EAC", Offset = "0xE44EAC", VA = "0xE44EAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0xE45070", Offset = "0xE45070", VA = "0xE45070", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_FirstTime;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool s_HasTutorialBeenShown;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_FakeBat;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Collider m_TutorialCollider;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Spawner m_Spawner;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_ShowTutorial;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_Fail;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AutoAimTarget[] m_TargetsToDisable;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AutoAimTarget[] m_TargetsToEnable;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xE44B14", Offset = "0xE44B14", VA = "0xE44B14")]
		private void Start()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xE44D4C", Offset = "0xE44D4C", VA = "0xE44D4C")]
		private void OnCompleted()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xE44DA4", Offset = "0xE44DA4", VA = "0xE44DA4")]
		public void StartTutorial()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xE44DC4", Offset = "0xE44DC4", VA = "0xE44DC4")]
		[IteratorStateMachine(typeof(<TutorialCoroutine>d__13))]
		private IEnumerator TutorialCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xE44E54", Offset = "0xE44E54", VA = "0xE44E54")]
		public ResetButtonTutorial()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class SneakyMove : MonoBehaviour
	{
		[Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class <GoSequence>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SneakyMove <>4__this;

			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<Rigidbody> <rigidbodiesToDisableKinematicOn>5__2;

			[Token(Token = "0x17000072")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000321")]
				[Address(RVA = "0xE45810", Offset = "0xE45810", VA = "0xE45810", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000323")]
				[Address(RVA = "0xE45858", Offset = "0xE45858", VA = "0xE45858", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0xE45160", Offset = "0xE45160", VA = "0xE45160")]
			[DebuggerHidden]
			public <GoSequence>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0xE453B0", Offset = "0xE453B0", VA = "0xE453B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0xE453B4", Offset = "0xE453B4", VA = "0xE453B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0xE45818", Offset = "0xE45818", VA = "0xE45818", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MoveDuration;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] m_Transforms;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform[] m_TargetPositions;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent m_OnFinished;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_OnlyOnce;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool m_Done;

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xE450B8", Offset = "0xE450B8", VA = "0xE450B8")]
		public void Go()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xE450F8", Offset = "0xE450F8", VA = "0xE450F8")]
		[IteratorStateMachine(typeof(<GoSequence>d__7))]
		private IEnumerator GoSequence()
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xE45188", Offset = "0xE45188", VA = "0xE45188")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xE45288", Offset = "0xE45288", VA = "0xE45288")]
		public SneakyMove()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Museum.VR_art
{
	[Token(Token = "0x20000B2")]
	public class Moveable : MonoBehaviour
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeReference]
		private GameObjectFilter m_Filter;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeReference]
		private Transform m_CurrentVRWorld;

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xE45860", Offset = "0xE45860", VA = "0xE45860")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xE45918", Offset = "0xE45918", VA = "0xE45918")]
		private void OnCollisionExit(Collision other)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xE45984", Offset = "0xE45984", VA = "0xE45984")]
		public void SetCurrentVRWorld(Transform t)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xE4598C", Offset = "0xE4598C", VA = "0xE4598C")]
		public Moveable()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[RequireComponent(typeof(Collider))]
	[RequireComponent(typeof(BasicResettable))]
	public class VrTrigger : MonoBehaviour
	{
		[Token(Token = "0x20000B4")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public VrTrigger <>4__this;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isNormal;

			[Token(Token = "0x600032E")]
			[Address(RVA = "0xE4609C", Offset = "0xE4609C", VA = "0xE4609C")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0xE460A4", Offset = "0xE460A4", VA = "0xE460A4")]
			internal void <Transition>b__0()
			{
			}
		}

		[Token(Token = "0x20000B5")]
		[CompilerGenerated]
		private sealed class <Transition>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VrTrigger <>4__this;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isNormal;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass12_0 <>8__1;

			[Token(Token = "0x17000074")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000333")]
				[Address(RVA = "0xE4631C", Offset = "0xE4631C", VA = "0xE4631C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000075")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000335")]
				[Address(RVA = "0xE46364", Offset = "0xE46364", VA = "0xE46364", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000330")]
			[Address(RVA = "0xE4600C", Offset = "0xE4600C", VA = "0xE4600C")]
			[DebuggerHidden]
			public <Transition>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0xE46104", Offset = "0xE46104", VA = "0xE46104", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000332")]
			[Address(RVA = "0xE46108", Offset = "0xE46108", VA = "0xE46108", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000334")]
			[Address(RVA = "0xE46324", Offset = "0xE46324", VA = "0xE46324", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_VrWorld;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_VrNormal;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_MoveThreshold;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent m_OnSwapWorld;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeReference]
		private List<Moveable> m_Movables;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeReference]
		private GameObjectFilter m_Filter;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_GlassesOn;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform m_PlayerCollider;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xE459F4", Offset = "0xE459F4", VA = "0xE459F4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xE45C78", Offset = "0xE45C78", VA = "0xE45C78")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xE45EC8", Offset = "0xE45EC8", VA = "0xE45EC8")]
		[Button("Swap", EButtonEnableMode.Playmode)]
		[UsedImplicitly]
		private void Swap()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xE45FDC", Offset = "0xE45FDC", VA = "0xE45FDC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xE45BFC", Offset = "0xE45BFC", VA = "0xE45BFC")]
		[IteratorStateMachine(typeof(<Transition>d__12))]
		private IEnumerator Transition(bool isNormal)
		{
			return null;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xE46034", Offset = "0xE46034", VA = "0xE46034")]
		public VrTrigger()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Museum.StopTheSeagulls.Scripts
{
	[Token(Token = "0x20000B6")]
	public class ChangeParent : MonoBehaviour
	{
		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_TargetObject;

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xE4636C", Offset = "0xE4636C", VA = "0xE4636C")]
		public void AssignParent(GameObject newParent)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xE463BC", Offset = "0xE463BC", VA = "0xE463BC")]
		public ChangeParent()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class SetPlayerDrawOrder : MonoBehaviour
	{
		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_NewRenderQueue;

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xE463C4", Offset = "0xE463C4", VA = "0xE463C4")]
		public void DoSetDrawOrder()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xE464A8", Offset = "0xE464A8", VA = "0xE464A8")]
		public SetPlayerDrawOrder()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Museum.SkeletonDepartment.Scripts
{
	[Token(Token = "0x20000B8")]
	public class BoneAttachmentPoint : MonoBehaviour
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Transform> m_AttachmentPoints;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_OnAttached;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_IsAttached;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SkeletonHandler m_SkeletonHandler;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Spawner m_Spawner;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Situation m_Situation;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AutoAimTarget m_AimAssist;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Open;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Event m_OnAttachSfx;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xE464B8", Offset = "0xE464B8", VA = "0xE464B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xE46508", Offset = "0xE46508", VA = "0xE46508")]
		private void Start()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xE465D4", Offset = "0xE465D4", VA = "0xE465D4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xE4662C", Offset = "0xE4662C", VA = "0xE4662C")]
		private void AttachBone(Collision collision)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xE46C18", Offset = "0xE46C18", VA = "0xE46C18")]
		private Transform Closets(Vector3 p, List<Transform> bones)
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xE46E8C", Offset = "0xE46E8C", VA = "0xE46E8C")]
		public BoneAttachmentPoint()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class SkeletonHandler : MonoBehaviour
	{
		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Spawner m_Spawner;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_SkeletonParts;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_OnAllPartsUsed;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_NextPart;

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xE46E9C", Offset = "0xE46E9C", VA = "0xE46E9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xE46E14", Offset = "0xE46E14", VA = "0xE46E14")]
		public void NextPart()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xE46EA0", Offset = "0xE46EA0", VA = "0xE46EA0")]
		public SkeletonHandler()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Museum.Selfie.Scripts
{
	[Token(Token = "0x20000BA")]
	public class SelfiePlayerMouthController : MonoBehaviour
	{
		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AutoFocus m_AutoFocus;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SelfieStick m_SelfieStick;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlayerMouthController m_PlayerMouthController;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PlayerMouthController.MouthType m_CurrentMouthType;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_LockCurrentMouthType;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PlayerMouthController.MouthType m_HappyMouth;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private PlayerMouthController.MouthType m_SadMouth;

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xE46EA8", Offset = "0xE46EA8", VA = "0xE46EA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xE46FE0", Offset = "0xE46FE0", VA = "0xE46FE0")]
		private void SuccessfulSelfieWasTaken(ISelfieSubject _)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xE47010", Offset = "0xE47010", VA = "0xE47010")]
		private void Update()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xE4706C", Offset = "0xE4706C", VA = "0xE4706C")]
		public SelfiePlayerMouthController()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Museum.Sculpture
{
	[Token(Token = "0x20000BB")]
	public class SculptureRock : MonoBehaviour, IBatHitReceiver
	{
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<float> m_ForceToKnockOff;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<float> m_ForceToAddDecal;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_DecreaseForceAfterHit;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ParticleSystem m_ParticlesSystem;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent m_OnHit;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_CanReceiveBatHitFromOtherRock;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_HitTransfer;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float m_HitTransferDelay;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<Event> m_BreakSounds;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_IsBroken;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private int m_DecalScale;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Action onBroken;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly List<Vector3> m_Direction;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_IsHitOnce;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private MeshRenderer m_Renderer;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int RotationMatrixX;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int RotationMatrixY;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int RotationDirection;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int Scale;

		[Token(Token = "0x17000076")]
		public UnityEvent onHit
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0xE4707C", Offset = "0xE4707C", VA = "0xE4707C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xE47084", Offset = "0xE47084", VA = "0xE47084")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xE470D4", Offset = "0xE470D4", VA = "0xE470D4")]
		private void Start()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xE474C0", Offset = "0xE474C0", VA = "0xE474C0")]
		private List<SculptureRock> NumRocksAround()
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xE47650", Offset = "0xE47650", VA = "0xE47650")]
		private SculptureRock FindRock(Vector3 d)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xE47758", Offset = "0xE47758", VA = "0xE47758")]
		private void AddDecalToMaterial()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xE47A04", Offset = "0xE47A04", VA = "0xE47A04", Slot = "4")]
		public void OnBatHit(Vector3 position, Vector3 velocity, Bat bat)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xE47E9C", Offset = "0xE47E9C", VA = "0xE47E9C")]
		public SculptureRock()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[RequireComponent(typeof(SubGoal))]
	public class SculptureWin : MonoBehaviour
	{
		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_NumRocks;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_OnRockBreak;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xE485D0", Offset = "0xE485D0", VA = "0xE485D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xE486A8", Offset = "0xE486A8", VA = "0xE486A8")]
		private void OnRockBreak()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xE48730", Offset = "0xE48730", VA = "0xE48730")]
		public SculptureWin()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Museum.PaintingPress.Scripts
{
	[Token(Token = "0x20000BF")]
	[RequireComponent(typeof(Rigidbody))]
	public class PaintingPressObject : MonoBehaviour
	{
		[Token(Token = "0x600035B")]
		[Address(RVA = "0xE48800", Offset = "0xE48800", VA = "0xE48800")]
		public void Stick(Transform parent)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xE48A20", Offset = "0xE48A20", VA = "0xE48A20")]
		public PaintingPressObject()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class PaintingProductionSequence : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C1")]
		private struct Group
		{
			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			private GameObject m_Dispenser;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			private GameObject m_FramePrefab;

			[Token(Token = "0x17000077")]
			public GameObject dispenser
			{
				[Token(Token = "0x6000363")]
				[Address(RVA = "0xE48E80", Offset = "0xE48E80", VA = "0xE48E80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000078")]
			public GameObject framePrefab
			{
				[Token(Token = "0x6000364")]
				[Address(RVA = "0xE48E88", Offset = "0xE48E88", VA = "0xE48E88")]
				get
				{
					return null;
				}
			}
		}

		[Token(Token = "0x20000C2")]
		[CompilerGenerated]
		private sealed class <AdvanceToNextGroupCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PaintingProductionSequence <>4__this;

			[Token(Token = "0x17000079")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000368")]
				[Address(RVA = "0xE48F48", Offset = "0xE48F48", VA = "0xE48F48", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600036A")]
				[Address(RVA = "0xE48F90", Offset = "0xE48F90", VA = "0xE48F90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000365")]
			[Address(RVA = "0xE48AD8", Offset = "0xE48AD8", VA = "0xE48AD8")]
			[DebuggerHidden]
			public <AdvanceToNextGroupCoroutine>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000366")]
			[Address(RVA = "0xE48E90", Offset = "0xE48E90", VA = "0xE48E90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000367")]
			[Address(RVA = "0xE48E94", Offset = "0xE48E94", VA = "0xE48E94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000369")]
			[Address(RVA = "0xE48F50", Offset = "0xE48F50", VA = "0xE48F50", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Group[] m_Groups;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Spawner m_Spawner;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_GroupIndex;

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xE48A28", Offset = "0xE48A28", VA = "0xE48A28")]
		private void Start()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xE48A50", Offset = "0xE48A50", VA = "0xE48A50")]
		public void AdvanceToNextGroup()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xE48A70", Offset = "0xE48A70", VA = "0xE48A70")]
		[IteratorStateMachine(typeof(<AdvanceToNextGroupCoroutine>d__5))]
		private IEnumerator AdvanceToNextGroupCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xE48B00", Offset = "0xE48B00", VA = "0xE48B00")]
		private void DisableActiveGroup()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xE48B4C", Offset = "0xE48B4C", VA = "0xE48B4C")]
		private void EnableActiveGroup()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xE48E78", Offset = "0xE48E78", VA = "0xE48E78")]
		public PaintingProductionSequence()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class PressedPainting : MonoBehaviour
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector2 m_CanvasSize;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_OnPressed;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_ColliderBuffer;

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xE491AC", Offset = "0xE491AC", VA = "0xE491AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xE491FC", Offset = "0xE491FC", VA = "0xE491FC")]
		public void Press()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xE49378", Offset = "0xE49378", VA = "0xE49378")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xE493D0", Offset = "0xE493D0", VA = "0xE493D0")]
		public PressedPainting()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class PrintingPress : MonoBehaviour
	{
		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator m_Animator;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_HeadTransform;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_Chassis;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent<GameObject> m_OnPaintingPressed;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Collider[] m_ColliderBuffer;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_CanPress;

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xE493D8", Offset = "0xE493D8", VA = "0xE493D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xE49428", Offset = "0xE49428", VA = "0xE49428")]
		public void Press()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xE4954C", Offset = "0xE4954C", VA = "0xE4954C")]
		private void PressPainting()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xE49764", Offset = "0xE49764", VA = "0xE49764")]
		public PrintingPress()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class WallWithPaintings : MonoBehaviour
	{
		[Token(Token = "0x20000C8")]
		[CompilerGenerated]
		private sealed class <ActivationCoroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WallWithPaintings <>4__this;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject painting;

			[Token(Token = "0x1700007B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000381")]
				[Address(RVA = "0xE49D50", Offset = "0xE49D50", VA = "0xE49D50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000383")]
				[Address(RVA = "0xE49D98", Offset = "0xE49D98", VA = "0xE49D98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600037E")]
			[Address(RVA = "0xE49814", Offset = "0xE49814", VA = "0xE49814")]
			[DebuggerHidden]
			public <ActivationCoroutine>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600037F")]
			[Address(RVA = "0xE498C4", Offset = "0xE498C4", VA = "0xE498C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0xE498C8", Offset = "0xE498C8", VA = "0xE498C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000382")]
			[Address(RVA = "0xE49D58", Offset = "0xE49D58", VA = "0xE49D58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_DelayBeforeAnimation;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_AnimationDuration;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] m_Targets;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SubGoal[] m_SubGoals;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent m_OnPaintingWasPutOnWall;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_NextPaintingIndex;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<Rigidbody> m_Paintings;

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xE49780", Offset = "0xE49780", VA = "0xE49780")]
		public void ActivateNextPainting(GameObject painting)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xE497A0", Offset = "0xE497A0", VA = "0xE497A0")]
		[IteratorStateMachine(typeof(<ActivationCoroutine>d__8))]
		private IEnumerator ActivationCoroutine(GameObject painting)
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xE4983C", Offset = "0xE4983C", VA = "0xE4983C")]
		public WallWithPaintings()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Museum.LaserObstacles.Scenes
{
	[Token(Token = "0x20000C9")]
	public class RotateLaser : MonoBehaviour
	{
		[Token(Token = "0x6000384")]
		[Address(RVA = "0xE49DA0", Offset = "0xE49DA0", VA = "0xE49DA0")]
		public RotateLaser()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Museum.GolfPaintings.Scripts
{
	[Token(Token = "0x20000CA")]
	public class CarPainting : MonoBehaviour
	{
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 m_JoystickValue;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GolfArrow m_GolfArrow;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_Trophy;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_FrameUnParented;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Joystick m_Joystick;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 m_Velocity;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Rigidbody m_CarRigidbody;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_NextShot;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool m_IsAiming;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 m_InitialTrophyPosition;

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xE49DA8", Offset = "0xE49DA8", VA = "0xE49DA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xE49E28", Offset = "0xE49E28", VA = "0xE49E28")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xE49EA8", Offset = "0xE49EA8", VA = "0xE49EA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xE49ED4", Offset = "0xE49ED4", VA = "0xE49ED4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xE4A114", Offset = "0xE4A114", VA = "0xE4A114")]
		private void FindJoystickAndButton()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xE4A22C", Offset = "0xE4A22C", VA = "0xE4A22C")]
		private void Shoot()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xE4A2B0", Offset = "0xE4A2B0", VA = "0xE4A2B0")]
		public CarPainting()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class Portal : MonoBehaviour
	{
		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Portal m_ConnectedPortal;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_ShootOutDestination;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve m_ShootOutCurve;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_ShootOutDuration;

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xE4A2B8", Offset = "0xE4A2B8", VA = "0xE4A2B8")]
		private void Start()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xE4A330", Offset = "0xE4A330", VA = "0xE4A330")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xE4A3F8", Offset = "0xE4A3F8", VA = "0xE4A3F8")]
		private void ShootOut(Rigidbody r)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xE4A598", Offset = "0xE4A598", VA = "0xE4A598")]
		public Portal()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class PortalObject : MonoBehaviour
	{
		[Token(Token = "0x6000391")]
		[Address(RVA = "0xE4A5FC", Offset = "0xE4A5FC", VA = "0xE4A5FC")]
		public PortalObject()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Museum.GiftShop
{
	[Token(Token = "0x20000CD")]
	public class CopyFace : MonoBehaviour
	{
		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int BaseMap;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RenderTexture m_RenderTexture;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer m_PolaroidRenderer;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture m_PolaroidTexture;

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xE4A604", Offset = "0xE4A604", VA = "0xE4A604")]
		private void Start()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xE4A6DC", Offset = "0xE4A6DC", VA = "0xE4A6DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xE4A738", Offset = "0xE4A738", VA = "0xE4A738")]
		public void CopyTexture()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xE4A79C", Offset = "0xE4A79C", VA = "0xE4A79C")]
		public CopyFace()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class CopyItem : MonoBehaviour
	{
		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_OnHasBeenCopied;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[OptionalReference]
		public CopyItem m_AlternativeCopyItem;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool m_CanBeCopied;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeReference]
		private GameObjectFilter m_Filter;

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xE4A80C", Offset = "0xE4A80C", VA = "0xE4A80C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xE4A858", Offset = "0xE4A858", VA = "0xE4A858")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xE4A8A8", Offset = "0xE4A8A8", VA = "0xE4A8A8")]
		public void HasBeenCopied()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xE4A8BC", Offset = "0xE4A8BC", VA = "0xE4A8BC")]
		public CopyItem()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class CopyMachine : MonoBehaviour
	{
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_CopySpawnPosition;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_CopyExitPosition;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_OnCopied;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_Light;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform m_LightEnd;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve m_LightAnimationCurve;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<CopyItem> m_CurrentItems;

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xE4A92C", Offset = "0xE4A92C", VA = "0xE4A92C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xE4AA84", Offset = "0xE4AA84", VA = "0xE4AA84")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xE4AB94", Offset = "0xE4AB94", VA = "0xE4AB94")]
		public void Copy()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xE4AC24", Offset = "0xE4AC24", VA = "0xE4AC24")]
		private void CopyItem(CopyItem item, int index)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xE4AF28", Offset = "0xE4AF28", VA = "0xE4AF28")]
		public CopyMachine()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Island.Underwater
{
	[Token(Token = "0x20000D1")]
	public class SetSceneGravity : MonoBehaviour
	{
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 m_Gravity;

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xE4AFB4", Offset = "0xE4AFB4", VA = "0xE4AFB4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xE4AFC4", Offset = "0xE4AFC4", VA = "0xE4AFC4")]
		public SetSceneGravity()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class UnderwaterTimer : MonoBehaviour
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_OnOverWater;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_OnUnderWater;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_BubbleAroundHead;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_WaterHeight;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ParticleSystem m_PlayerBubbles;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_Up;

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xE4AFCC", Offset = "0xE4AFCC", VA = "0xE4AFCC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xE4B15C", Offset = "0xE4B15C", VA = "0xE4B15C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xE4B068", Offset = "0xE4B068", VA = "0xE4B068")]
		private void Down()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xE4B0E8", Offset = "0xE4B0E8", VA = "0xE4B0E8")]
		private void Up()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xE4B200", Offset = "0xE4B200", VA = "0xE4B200")]
		public UnderwaterTimer()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Island.Shelter.Scripts
{
	[Token(Token = "0x20000D3")]
	public class PiranhaCutTarget : MonoBehaviour
	{
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_OnTreeCut;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_HasBeenCut;

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xE4B208", Offset = "0xE4B208", VA = "0xE4B208")]
		public void Cut()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xE4B23C", Offset = "0xE4B23C", VA = "0xE4B23C")]
		public PiranhaCutTarget()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class PiranhaTreeCutter : MonoBehaviour
	{
		[Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class <CutCoroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PiranhaTreeCutter <>4__this;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject other;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 pos;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion rot;

			[Token(Token = "0x1700007D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003B4")]
				[Address(RVA = "0xE4B884", Offset = "0xE4B884", VA = "0xE4B884", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B6")]
				[Address(RVA = "0xE4B8CC", Offset = "0xE4B8CC", VA = "0xE4B8CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xE4B43C", Offset = "0xE4B43C", VA = "0xE4B43C")]
			[DebuggerHidden]
			public <CutCoroutine>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60003B2")]
			[Address(RVA = "0xE4B690", Offset = "0xE4B690", VA = "0xE4B690", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xE4B694", Offset = "0xE4B694", VA = "0xE4B694", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0xE4B88C", Offset = "0xE4B88C", VA = "0xE4B88C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_CutTime;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeReference]
		private GameObjectFilter m_GameObjectFilter;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Event m_OnStartCutting;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Event m_OnStopCutting;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ParticleSystem m_EatTreeParticles;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_HasCut;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioEvent m_Audio;

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xE4B244", Offset = "0xE4B244", VA = "0xE4B244")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xE4B37C", Offset = "0xE4B37C", VA = "0xE4B37C")]
		[IteratorStateMachine(typeof(<CutCoroutine>d__8))]
		private IEnumerator CutCoroutine(GameObject other, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xE4B464", Offset = "0xE4B464", VA = "0xE4B464")]
		private void StickToOtherObject(GameObject other, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xE4B5F4", Offset = "0xE4B5F4", VA = "0xE4B5F4")]
		private void StartParticles()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xE4B610", Offset = "0xE4B610", VA = "0xE4B610")]
		private void NotifyTargets(GameObject other)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xE4B680", Offset = "0xE4B680", VA = "0xE4B680")]
		public PiranhaTreeCutter()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Island.RemoteShark.Scripts
{
	[Token(Token = "0x20000D6")]
	[RequireComponent(typeof(ExtraGravity))]
	public class SharkVolleyballBall : MonoBehaviour
	{
		[Token(Token = "0x20000D7")]
		[CompilerGenerated]
		private sealed class <Start>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SharkVolleyballBall <>4__this;

			[Token(Token = "0x1700007F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003C3")]
				[Address(RVA = "0xE4C3DC", Offset = "0xE4C3DC", VA = "0xE4C3DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000080")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003C5")]
				[Address(RVA = "0xE4C424", Offset = "0xE4C424", VA = "0xE4C424", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003C0")]
			[Address(RVA = "0xE4BA38", Offset = "0xE4BA38", VA = "0xE4BA38")]
			[DebuggerHidden]
			public <Start>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60003C1")]
			[Address(RVA = "0xE4C300", Offset = "0xE4C300", VA = "0xE4C300", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003C2")]
			[Address(RVA = "0xE4C304", Offset = "0xE4C304", VA = "0xE4C304", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xE4C3E4", Offset = "0xE4C3E4", VA = "0xE4C3E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_PlayerFieldExtends;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_EnemyFieldExtends;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_FlightDuration;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ParticleSystem m_FishVFX;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject m_TargetDestinationGraphics;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent m_OnBallDeflected;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEvent m_OnPop;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[FormerlySerializedAs("m_PopParticleSystem")]
		private ParticleSystem m_PopParticleSystemPrefab;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Event m_PopAudio;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_DeflectionsBeforePop;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_DeflectionCount;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_LastDeflectTime;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ExtraGravity m_ExtraGravity;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_FiesTowardsPlayer;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Situation m_Situation;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FailSituation m_FailSituation;

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xE4B8D4", Offset = "0xE4B8D4", VA = "0xE4B8D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xE4B9D0", Offset = "0xE4B9D0", VA = "0xE4B9D0")]
		[IteratorStateMachine(typeof(<Start>d__18))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xE4BA60", Offset = "0xE4BA60", VA = "0xE4BA60")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xE4C050", Offset = "0xE4C050", VA = "0xE4C050")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xE4C0C8", Offset = "0xE4C0C8", VA = "0xE4C0C8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xE4C28C", Offset = "0xE4C28C", VA = "0xE4C28C")]
		public Vector3 GetTargetPoint(bool playerArea)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xE4BB18", Offset = "0xE4BB18", VA = "0xE4BB18")]
		private void ThrowBall(bool atPlayer)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xE4C2F0", Offset = "0xE4C2F0", VA = "0xE4C2F0")]
		public SharkVolleyballBall()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class Sub : MonoBehaviour
	{
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_PullForce;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_PullPosition;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Joystick m_Joystick;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_Propeller;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_PropellerMaxSpeed;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xE4C4DC", Offset = "0xE4C4DC", VA = "0xE4C4DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xE4C52C", Offset = "0xE4C52C", VA = "0xE4C52C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xE4C630", Offset = "0xE4C630", VA = "0xE4C630")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xE4C6A0", Offset = "0xE4C6A0", VA = "0xE4C6A0")]
		public Sub()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Island.Sharks.Scripts
{
	[Token(Token = "0x20000DA")]
	public class MoveTowardsHittable : MonoBehaviour
	{
		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Range;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_RotateTowardsTarget;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent<Transform> m_OnTargetAcquired;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_ColliderBuffer;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Target;

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xE4C6B8", Offset = "0xE4C6B8", VA = "0xE4C6B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xE4C708", Offset = "0xE4C708", VA = "0xE4C708")]
		private void Update()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xE4C780", Offset = "0xE4C780", VA = "0xE4C780")]
		private void Search()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xE4C89C", Offset = "0xE4C89C", VA = "0xE4C89C")]
		private void MoveTowardsTarget()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xE4CA58", Offset = "0xE4CA58", VA = "0xE4CA58")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xE4CAA4", Offset = "0xE4CAA4", VA = "0xE4CAA4")]
		public MoveTowardsHittable()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Island.ReelTime.Scripts
{
	[Token(Token = "0x20000DB")]
	public class Clam : MonoBehaviour
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_UpperShell;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_OnShellClose;

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xE4CAAC", Offset = "0xE4CAAC", VA = "0xE4CAAC")]
		public void Close()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xE4CAF4", Offset = "0xE4CAF4", VA = "0xE4CAF4")]
		public void Open()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xE4CB18", Offset = "0xE4CB18", VA = "0xE4CB18")]
		public void Triggered(GameObject obj)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xE4CB84", Offset = "0xE4CB84", VA = "0xE4CB84")]
		public Clam()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class FilmReelTime : MonoBehaviour
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_Timeline;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlayableGraph m_PlayableGraph;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Active;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_TimelineStartSpeed;

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xE4CB8C", Offset = "0xE4CB8C", VA = "0xE4CB8C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xE4CC24", Offset = "0xE4CC24", VA = "0xE4CC24")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xE4CCB8", Offset = "0xE4CCB8", VA = "0xE4CCB8")]
		public void ActivateReelTime()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xE4CCC4", Offset = "0xE4CCC4", VA = "0xE4CCC4")]
		public void DeactivateReelTime()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xE4CCCC", Offset = "0xE4CCCC", VA = "0xE4CCCC")]
		public FilmReelTime()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class SetTimelineSpeed : MonoBehaviour
	{
		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Timeline;

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xE4CCDC", Offset = "0xE4CCDC", VA = "0xE4CCDC")]
		public void SetSpeed(float speed)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xE4CD88", Offset = "0xE4CD88", VA = "0xE4CD88")]
		public SetTimelineSpeed()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Island.Peekaboo.Scripts
{
	[Token(Token = "0x20000DE")]
	public class BreakableCocobuddy : MonoBehaviour
	{
		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Cocobuddy;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_BreakableCoconut;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CocobuddySpawner m_Manager;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TriggerWhenMultipleCollidersTriggered m_PeekTrigger;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent m_OnHiding;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent m_OnMoving;

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xE4CD90", Offset = "0xE4CD90", VA = "0xE4CD90")]
		private void Start()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xE4CDDC", Offset = "0xE4CDDC", VA = "0xE4CDDC")]
		public void Init(CocobuddySpawner manager, TriggerWhenMultipleCollidersTriggered peekTrigger)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xE4CED4", Offset = "0xE4CED4", VA = "0xE4CED4")]
		public void GetHit()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xE4CD94", Offset = "0xE4CD94", VA = "0xE4CD94")]
		public void Hide()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xE4D174", Offset = "0xE4D174", VA = "0xE4D174")]
		public void Reveal()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xE4D1BC", Offset = "0xE4D1BC", VA = "0xE4D1BC")]
		public BreakableCocobuddy()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class CocobuddySpawner : MonoBehaviour
	{
		[Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private sealed class <Spawn>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CocobuddySpawner <>4__this;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <nextTime>5__2;

			[Token(Token = "0x17000081")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003EC")]
				[Address(RVA = "0xE4D4B0", Offset = "0xE4D4B0", VA = "0xE4D4B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000082")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003EE")]
				[Address(RVA = "0xE4D4F8", Offset = "0xE4D4F8", VA = "0xE4D4F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xE4D24C", Offset = "0xE4D24C", VA = "0xE4D24C")]
			[DebuggerHidden]
			public <Spawn>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xE4D3C8", Offset = "0xE4D3C8", VA = "0xE4D3C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0xE4D3CC", Offset = "0xE4D3CC", VA = "0xE4D3CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0xE4D4B8", Offset = "0xE4D4B8", VA = "0xE4D4B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Period;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Spawning;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_StopAfterNHits;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_OnHitAll;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_SpawnPoint;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject m_Prefab;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TriggerWhenMultipleCollidersTriggered m_PeekTrigger;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject m_CurCoco;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_NumHit;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject m_GiantCoco;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform m_GiantCocoSpawnPoint;

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xE4D1C4", Offset = "0xE4D1C4", VA = "0xE4D1C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xE4D1E4", Offset = "0xE4D1E4", VA = "0xE4D1E4")]
		[IteratorStateMachine(typeof(<Spawn>d__12))]
		private IEnumerator Spawn()
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xE4D274", Offset = "0xE4D274", VA = "0xE4D274")]
		private void DoSpawn()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xE4CFD0", Offset = "0xE4CFD0", VA = "0xE4CFD0")]
		public void HitCoco()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xE4D3B8", Offset = "0xE4D3B8", VA = "0xE4D3B8")]
		public CocobuddySpawner()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class PeekabooSensor : MonoBehaviour
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_OnBothEyesCovered;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_OnBothEyesUncovered;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_LeftBatLeftEye;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool m_RightBatRightEye;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool m_LeftBatRightEye;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		private bool m_RightBatLeftEye;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xE4D500", Offset = "0xE4D500", VA = "0xE4D500")]
		public void LeftEyeCovered(GameObject obj)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xE4D658", Offset = "0xE4D658", VA = "0xE4D658")]
		public void LeftEyeUncovered(GameObject obj)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xE4D740", Offset = "0xE4D740", VA = "0xE4D740")]
		public void RightEyeCovered(GameObject obj)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xE4D82C", Offset = "0xE4D82C", VA = "0xE4D82C")]
		public void RightEyeUncovered(GameObject obj)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xE4D5EC", Offset = "0xE4D5EC", VA = "0xE4D5EC")]
		private void CheckBothCovered()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xE4D914", Offset = "0xE4D914", VA = "0xE4D914")]
		public PeekabooSensor()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class TriggerWhenMultipleCollidersTriggered : MonoBehaviour
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GameObject> m_Colliders;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("The minimum delay between all colliders are triggered and not all colliders are triggered.")]
		private float m_DelayBetweenEvents;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent m_OnAllCollidersTriggered;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("m_OnAllCollidersUntriggered")]
		public UnityEvent m_OnAllCollidersNotTriggered;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<GameObject> m_TriggeredColliders;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_AllCollidersAreTriggered;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_TimeOut;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xE4D91C", Offset = "0xE4D91C", VA = "0xE4D91C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xE4D990", Offset = "0xE4D990", VA = "0xE4D990")]
		public void OnEnterCollider(GameObject obj)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xE4D9E8", Offset = "0xE4D9E8", VA = "0xE4D9E8")]
		public void OnExitCollider(GameObject obj)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xE4DA40", Offset = "0xE4DA40", VA = "0xE4DA40")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xE4DAD8", Offset = "0xE4DAD8", VA = "0xE4DAD8")]
		private bool AllCollidersAreTriggered()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xE4DB40", Offset = "0xE4DB40", VA = "0xE4DB40")]
		public TriggerWhenMultipleCollidersTriggered()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Island.Merfoxes.Scripts
{
	[Token(Token = "0x20000E3")]
	public class DiggableFetchingObject : MonoBehaviour, IFetchable
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_DiggingMound;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem m_DigginParticles;

		[Token(Token = "0x17000083")]
		public bool isGrabbed
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xE4DBC0", Offset = "0xE4DBC0", VA = "0xE4DBC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0xE4DBC8", Offset = "0xE4DBC8", VA = "0xE4DBC8", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool isDelivered
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0xE4DBD4", Offset = "0xE4DBD4", VA = "0xE4DBD4", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0xE4DBDC", Offset = "0xE4DBDC", VA = "0xE4DBDC", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xE4DB50", Offset = "0xE4DB50", VA = "0xE4DB50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xE4DBE8", Offset = "0xE4DBE8", VA = "0xE4DBE8", Slot = "9")]
		public void Delivered()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xE4DBF4", Offset = "0xE4DBF4", VA = "0xE4DBF4", Slot = "8")]
		public void Grabbed()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xE4DC8C", Offset = "0xE4DC8C", VA = "0xE4DC8C")]
		public DiggableFetchingObject()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class FeedTheMerfoxesController : MonoBehaviour
	{
		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Spawner m_Spawner;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_SpawnCooldown;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_NextSpawn;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject m_Meat;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_MeatBatted;

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xE4DC94", Offset = "0xE4DC94", VA = "0xE4DC94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xE4DCB8", Offset = "0xE4DCB8", VA = "0xE4DCB8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xE4DE44", Offset = "0xE4DE44", VA = "0xE4DE44")]
		private void SpawnMeat()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xE4DEB4", Offset = "0xE4DEB4", VA = "0xE4DEB4")]
		public FeedTheMerfoxesController()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class Fetchable : MonoBehaviour, IFetchable
	{
		[Token(Token = "0x17000085")]
		public bool isGrabbed
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0xE4DECC", Offset = "0xE4DECC", VA = "0xE4DECC", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000408")]
			[Address(RVA = "0xE4DED4", Offset = "0xE4DED4", VA = "0xE4DED4", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public bool isDelivered
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0xE4DEE0", Offset = "0xE4DEE0", VA = "0xE4DEE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600040A")]
			[Address(RVA = "0xE4DEE8", Offset = "0xE4DEE8", VA = "0xE4DEE8", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xE4DEF4", Offset = "0xE4DEF4", VA = "0xE4DEF4", Slot = "9")]
		public void Delivered()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xE4DF00", Offset = "0xE4DF00", VA = "0xE4DF00", Slot = "8")]
		public void Grabbed()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xE4DF0C", Offset = "0xE4DF0C", VA = "0xE4DF0C")]
		public Fetchable()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class FetchingDog : MonoBehaviour
	{
		[Token(Token = "0x20000E7")]
		[CompilerGenerated]
		private sealed class <PickUpObject>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FetchingDog <>4__this;

			[Token(Token = "0x17000087")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600041F")]
				[Address(RVA = "0xE4ED00", Offset = "0xE4ED00", VA = "0xE4ED00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000088")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000421")]
				[Address(RVA = "0xE4ED48", Offset = "0xE4ED48", VA = "0xE4ED48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600041C")]
			[Address(RVA = "0xE4E640", Offset = "0xE4E640", VA = "0xE4E640")]
			[DebuggerHidden]
			public <PickUpObject>d__25(int <>1__state)
			{
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0xE4EBA8", Offset = "0xE4EBA8", VA = "0xE4EBA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0xE4EBAC", Offset = "0xE4EBAC", VA = "0xE4EBAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0xE4ED08", Offset = "0xE4ED08", VA = "0xE4ED08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class <DeliverObject>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FetchingDog <>4__this;

			[Token(Token = "0x17000089")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000425")]
				[Address(RVA = "0xE4EE14", Offset = "0xE4EE14", VA = "0xE4EE14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000427")]
				[Address(RVA = "0xE4EE5C", Offset = "0xE4EE5C", VA = "0xE4EE5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0xE4E668", Offset = "0xE4E668", VA = "0xE4E668")]
			[DebuggerHidden]
			public <DeliverObject>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0xE4ED50", Offset = "0xE4ED50", VA = "0xE4ED50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0xE4ED54", Offset = "0xE4ED54", VA = "0xE4ED54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0xE4EE1C", Offset = "0xE4EE1C", VA = "0xE4EE1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int RunningID;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeToPickup;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_FetchingTransform;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_DeliverFloatingObjectTransform;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_PlaceObjectPosition;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_MovementSpeed;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_RotationSpeed;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_FetchPickupDistance;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool m_FetchedObjectFloatsOnDelivery;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator m_Animator;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody m_Rb;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_Fetching;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_Returning;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool m_Arrived;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool m_CarryingObject;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject m_ObjectToFetch;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private IFetchable m_Fetchable;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform m_FetchedObjectsOriginalParent;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 m_ReturnPosition;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Rigidbody[] m_ObjectRigidbodies;

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xE4DF14", Offset = "0xE4DF14", VA = "0xE4DF14")]
		private void Start()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xE4DF90", Offset = "0xE4DF90", VA = "0xE4DF90")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xE4E3FC", Offset = "0xE4E3FC", VA = "0xE4E3FC")]
		public void Fetch(GameObject objectToFetch)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xE4E55C", Offset = "0xE4E55C", VA = "0xE4E55C")]
		public void Fetch(GameObject objectToFetch, Vector3 returnPosition)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xE4E038", Offset = "0xE4E038", VA = "0xE4E038")]
		private void Run(Vector3 runToPosition, bool fetching = false)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xE4E32C", Offset = "0xE4E32C", VA = "0xE4E32C")]
		[IteratorStateMachine(typeof(<PickUpObject>d__25))]
		private IEnumerator PickUpObject()
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xE4E394", Offset = "0xE4E394", VA = "0xE4E394")]
		[IteratorStateMachine(typeof(<DeliverObject>d__26))]
		private IEnumerator DeliverObject()
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xE4E690", Offset = "0xE4E690", VA = "0xE4E690")]
		private void GrabObject()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xE4E844", Offset = "0xE4E844", VA = "0xE4E844")]
		private void Deliver()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xE4E9C8", Offset = "0xE4E9C8", VA = "0xE4E9C8")]
		private void DropObject()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xE4E2B0", Offset = "0xE4E2B0", VA = "0xE4E2B0")]
		private void StopRunning()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xE4E4DC", Offset = "0xE4E4DC", VA = "0xE4E4DC")]
		private void ResetFetchingState()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xE4EB18", Offset = "0xE4EB18", VA = "0xE4EB18")]
		public FetchingDog()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public interface IFetchable
	{
		[Token(Token = "0x1700008B")]
		bool isDelivered
		{
			[Token(Token = "0x6000428")]
			get;
			[Token(Token = "0x6000429")]
			set;
		}

		[Token(Token = "0x1700008C")]
		bool isGrabbed
		{
			[Token(Token = "0x600042A")]
			get;
			[Token(Token = "0x600042B")]
			set;
		}

		[Token(Token = "0x600042C")]
		void Grabbed();

		[Token(Token = "0x600042D")]
		void Delivered();
	}
	[Token(Token = "0x20000EA")]
	public class Merfox : MonoBehaviour
	{
		[Token(Token = "0x20000EC")]
		[CompilerGenerated]
		private sealed class <JumpForFood>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Merfox <>4__this;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 position;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600043F")]
				[Address(RVA = "0xE4F984", Offset = "0xE4F984", VA = "0xE4F984", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000441")]
				[Address(RVA = "0xE4F9CC", Offset = "0xE4F9CC", VA = "0xE4F9CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0xE4F24C", Offset = "0xE4F24C", VA = "0xE4F24C")]
			[DebuggerHidden]
			public <JumpForFood>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0xE4F810", Offset = "0xE4F810", VA = "0xE4F810", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0xE4F814", Offset = "0xE4F814", VA = "0xE4F814", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0xE4F98C", Offset = "0xE4F98C", VA = "0xE4F98C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000ED")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Merfox <>4__this;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 currentPosition;

			[Token(Token = "0x6000442")]
			[Address(RVA = "0xE4F9D4", Offset = "0xE4F9D4", VA = "0xE4F9D4")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0xE4F9DC", Offset = "0xE4F9DC", VA = "0xE4F9DC")]
			internal void <DelayedReturn>b__0(float t)
			{
			}
		}

		[Token(Token = "0x20000EE")]
		[CompilerGenerated]
		private sealed class <DelayedReturn>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Merfox <>4__this;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass20_0 <>8__1;

			[Token(Token = "0x1700008F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000447")]
				[Address(RVA = "0xE4FD18", Offset = "0xE4FD18", VA = "0xE4FD18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000449")]
				[Address(RVA = "0xE4FD60", Offset = "0xE4FD60", VA = "0xE4FD60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0xE4F274", Offset = "0xE4F274", VA = "0xE4F274")]
			[DebuggerHidden]
			public <DelayedReturn>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0xE4FA5C", Offset = "0xE4FA5C", VA = "0xE4FA5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000446")]
			[Address(RVA = "0xE4FA60", Offset = "0xE4FA60", VA = "0xE4FA60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0xE4FD20", Offset = "0xE4FD20", VA = "0xE4FD20", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private sealed class <Win>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Merfox <>4__this;

			[Token(Token = "0x17000091")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0xE4FE34", Offset = "0xE4FE34", VA = "0xE4FE34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0xE4FE7C", Offset = "0xE4FE7C", VA = "0xE4FE7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0xE4F70C", Offset = "0xE4F70C", VA = "0xE4F70C")]
			[DebuggerHidden]
			public <Win>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0xE4FD68", Offset = "0xE4FD68", VA = "0xE4FD68", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0xE4FD6C", Offset = "0xE4FD6C", VA = "0xE4FD6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0xE4FE3C", Offset = "0xE4FE3C", VA = "0xE4FE3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F0")]
		[CompilerGenerated]
		private sealed class <SpawnHearts>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Merfox <>4__this;

			[Token(Token = "0x17000093")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000453")]
				[Address(RVA = "0xE50124", Offset = "0xE50124", VA = "0xE50124", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000455")]
				[Address(RVA = "0xE5016C", Offset = "0xE5016C", VA = "0xE5016C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0xE4F734", Offset = "0xE4F734", VA = "0xE4F734")]
			[DebuggerHidden]
			public <SpawnHearts>d__25(int <>1__state)
			{
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0xE4FE84", Offset = "0xE4FE84", VA = "0xE4FE84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000452")]
			[Address(RVA = "0xE4FE88", Offset = "0xE4FE88", VA = "0xE4FE88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0xE5012C", Offset = "0xE5012C", VA = "0xE5012C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 m_EatPositionAdjustment;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip m_MerfoxSound;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip m_EatSound;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int m_AmountToEat;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Situation m_Situation;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject m_Heart;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Quaternion m_HeartRotation;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform m_HatPosition;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform m_GlassesPosition;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly float m_JumpTime;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_NextAudio;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 m_OriginalPos;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float m_NextEat;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private GameObject m_Food;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int m_AmountEaten;

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xE4EE64", Offset = "0xE4EE64", VA = "0xE4EE64")]
		private void Start()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xE4EF08", Offset = "0xE4EF08", VA = "0xE4EF08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xE4EF84", Offset = "0xE4EF84", VA = "0xE4EF84")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xE4F158", Offset = "0xE4F158", VA = "0xE4F158")]
		[IteratorStateMachine(typeof(<JumpForFood>d__19))]
		private IEnumerator JumpForFood(Vector3 position)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xE4F1E4", Offset = "0xE4F1E4", VA = "0xE4F1E4")]
		[IteratorStateMachine(typeof(<DelayedReturn>d__20))]
		private IEnumerator DelayedReturn()
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xE4F29C", Offset = "0xE4F29C", VA = "0xE4F29C")]
		private void Eat()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xE4F47C", Offset = "0xE4F47C", VA = "0xE4F47C")]
		private void WearHat()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xE4F5C4", Offset = "0xE4F5C4", VA = "0xE4F5C4")]
		private void WearGlasses()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xE4F414", Offset = "0xE4F414", VA = "0xE4F414")]
		[IteratorStateMachine(typeof(<Win>d__24))]
		private IEnumerator Win()
		{
			return null;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xE4F3AC", Offset = "0xE4F3AC", VA = "0xE4F3AC")]
		[IteratorStateMachine(typeof(<SpawnHearts>d__25))]
		private IEnumerator SpawnHearts()
		{
			return null;
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xE4F094", Offset = "0xE4F094", VA = "0xE4F094")]
		private GameObject FindTopLevelWithTag(GameObject obj, string requiredTag)
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xE4F75C", Offset = "0xE4F75C", VA = "0xE4F75C")]
		public Merfox()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class MerfoxMeat : MonoBehaviour
	{
		[Token(Token = "0x6000456")]
		[Address(RVA = "0xE50174", Offset = "0xE50174", VA = "0xE50174")]
		public MerfoxMeat()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class RavenousMerfoxController : MonoBehaviour
	{
		[Token(Token = "0x20000F3")]
		[CompilerGenerated]
		private sealed class <ThrowPlate>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RavenousMerfoxController <>4__this;

			[Token(Token = "0x17000095")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000461")]
				[Address(RVA = "0xE50858", Offset = "0xE50858", VA = "0xE50858", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000463")]
				[Address(RVA = "0xE508A0", Offset = "0xE508A0", VA = "0xE508A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0xE5055C", Offset = "0xE5055C", VA = "0xE5055C")]
			[DebuggerHidden]
			public <ThrowPlate>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0xE5072C", Offset = "0xE5072C", VA = "0xE5072C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0xE50730", Offset = "0xE50730", VA = "0xE50730", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0xE50860", Offset = "0xE50860", VA = "0xE50860", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int ThrowID;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FetchingDog m_Dog;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_DogReturnPoint;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_DogFloatingFetchPosition;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] m_Fetchables;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_SpawnCooldown;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Animator m_ElephantAnimator;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Rigidbody m_Plate;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform m_PlateTarget;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_NextFetch;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_NextFetchable;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject m_Fetchable;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private IFetchable m_IFetchable;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_FetchableBatted;

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xE5017C", Offset = "0xE5017C", VA = "0xE5017C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xE501A0", Offset = "0xE501A0", VA = "0xE501A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xE50484", Offset = "0xE50484", VA = "0xE50484")]
		private void Fetch()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xE5041C", Offset = "0xE5041C", VA = "0xE5041C")]
		[IteratorStateMachine(typeof(<ThrowPlate>d__17))]
		private IEnumerator ThrowPlate()
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xE50584", Offset = "0xE50584", VA = "0xE50584")]
		public RavenousMerfoxController()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Island.Looting.Scripts
{
	[Token(Token = "0x20000F4")]
	public class ElephantBox : MonoBehaviour
	{
		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int OpenID;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioSource m_AlarmSource;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Animator m_Animator;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool m_Open;

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xE508A8", Offset = "0xE508A8", VA = "0xE508A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xE50938", Offset = "0xE50938", VA = "0xE50938")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xE509E4", Offset = "0xE509E4", VA = "0xE509E4")]
		public ElephantBox()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class ManySmallBoxesBox : MonoBehaviour
	{
		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_ID;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool m_Test;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ManySmallBoxesSequence m_Sequence;

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xE50A54", Offset = "0xE50A54", VA = "0xE50A54")]
		private void Update()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xE50B1C", Offset = "0xE50B1C", VA = "0xE50B1C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xE50B6C", Offset = "0xE50B6C", VA = "0xE50B6C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xE50BB0", Offset = "0xE50BB0", VA = "0xE50BB0")]
		public ManySmallBoxesBox()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class ManySmallBoxesSequence : MonoBehaviour
	{
		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int OpenBoxID;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m_LastBoxScale;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform m_LastBoxTransform;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject m_SandBoxPrefab;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_WantedID;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator m_Animator;

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xE50BB8", Offset = "0xE50BB8", VA = "0xE50BB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xE50A88", Offset = "0xE50A88", VA = "0xE50A88")]
		public void HitBox(int boxID)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xE50C10", Offset = "0xE50C10", VA = "0xE50C10")]
		public void SpawnLastBox()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xE50D34", Offset = "0xE50D34", VA = "0xE50D34")]
		public ManySmallBoxesSequence()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Island.FishingRodLevel.Scenes.Scripts
{
	[Token(Token = "0x20000F7")]
	public class FishableRock : MonoBehaviour
	{
		[Token(Token = "0x20000F8")]
		[CompilerGenerated]
		private sealed class <DetachAfterDelay>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FishableRock <>4__this;

			[Token(Token = "0x17000097")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000478")]
				[Address(RVA = "0xE51150", Offset = "0xE51150", VA = "0xE51150", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600047A")]
				[Address(RVA = "0xE51198", Offset = "0xE51198", VA = "0xE51198", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0xE5106C", Offset = "0xE5106C", VA = "0xE5106C")]
			[DebuggerHidden]
			public <DetachAfterDelay>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0xE510A4", Offset = "0xE510A4", VA = "0xE510A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0xE510A8", Offset = "0xE510A8", VA = "0xE510A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000479")]
			[Address(RVA = "0xE51158", Offset = "0xE51158", VA = "0xE51158", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_ToActivate;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Delay;

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xE50DA4", Offset = "0xE50DA4", VA = "0xE50DA4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xE50E68", Offset = "0xE50E68", VA = "0xE50E68")]
		private void Fished()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xE51004", Offset = "0xE51004", VA = "0xE51004")]
		[IteratorStateMachine(typeof(<DetachAfterDelay>d__4))]
		private IEnumerator DetachAfterDelay()
		{
			return null;
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xE51094", Offset = "0xE51094", VA = "0xE51094")]
		public FishableRock()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Island.Sos.Scripts
{
	[Token(Token = "0x20000F9")]
	public class Letter : MonoBehaviour
	{
		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<ColorRemap> m_ColorRemap;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ColorReference]
		[SerializeField]
		private Triband.ColorPipeline.Runtime.SerializableGUID[] m_OnColors;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Event m_FireIgnite;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Event m_FireStartLoop;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ParticleSystem[] m_ParticlesSystems;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TriggerAfterNCalls m_Counter;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsOn;

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xE511A0", Offset = "0xE511A0", VA = "0xE511A0")]
		private void Start()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xE511F0", Offset = "0xE511F0", VA = "0xE511F0")]
		public void TurnOff()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xE51650", Offset = "0xE51650", VA = "0xE51650")]
		public void TurnOn()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xE5122C", Offset = "0xE5122C", VA = "0xE5122C")]
		private void ResetColor()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xE51778", Offset = "0xE51778", VA = "0xE51778")]
		private void SetColors()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xE51A40", Offset = "0xE51A40", VA = "0xE51A40")]
		public Letter()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Island.Build_Raft.Scripts
{
	[Token(Token = "0x20000FA")]
	public class ChopWoodWinTrigger : MonoBehaviour
	{
		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Situation m_Situation;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_PalmPlanks;

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xE51A48", Offset = "0xE51A48", VA = "0xE51A48")]
		public void Win()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xE51A98", Offset = "0xE51A98", VA = "0xE51A98")]
		public ChopWoodWinTrigger()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class ConstantOppositeForce : MonoBehaviour
	{
		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Force;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody m_Rb;

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xE51AA0", Offset = "0xE51AA0", VA = "0xE51AA0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xE51AF0", Offset = "0xE51AF0", VA = "0xE51AF0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xE51B40", Offset = "0xE51B40", VA = "0xE51B40")]
		public ConstantOppositeForce()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class MerfoxWoodEater : MonoBehaviour
	{
		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovementSpeed;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_MovementSpeedDecay;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MovementSpeedIncreaseSpeed;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_TargetPosition;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator m_Animator;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rb;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_AnimationSpeed;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_Direction;

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xE51B50", Offset = "0xE51B50", VA = "0xE51B50")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xE51CE8", Offset = "0xE51CE8", VA = "0xE51CE8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xE51DF8", Offset = "0xE51DF8", VA = "0xE51DF8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xE51DBC", Offset = "0xE51DBC", VA = "0xE51DBC")]
		private void AnimationSpeedDecay()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xE51EA8", Offset = "0xE51EA8", VA = "0xE51EA8")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xE51EC4", Offset = "0xE51EC4", VA = "0xE51EC4")]
		private void Watered()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xE51EE0", Offset = "0xE51EE0", VA = "0xE51EE0")]
		public MerfoxWoodEater()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Island.BugFriend.Scripts
{
	[Token(Token = "0x20000FD")]
	public class AntPathFinder : MonoBehaviour
	{
		[Token(Token = "0x20000FE")]
		private struct AntData
		{
			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int nextCornerIndex;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float timeOut;
		}

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_StartTransform;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_EndTransform;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_AntPrefab;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent m_OnReachedEnd;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private NavMeshPath m_Path;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private NavMeshQueryFilter m_QueryFilter;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Transform> m_AntTransforms;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<AntData> m_AntData;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_HasReachedEnd;

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xE51EFC", Offset = "0xE51EFC", VA = "0xE51EFC")]
		private void Start()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xE51F98", Offset = "0xE51F98", VA = "0xE51F98")]
		private void Update()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xE52034", Offset = "0xE52034", VA = "0xE52034")]
		private void MoveAnts()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xE52704", Offset = "0xE52704", VA = "0xE52704")]
		public AntPathFinder()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class SnailController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000100")]
		private struct GroundCheckSettings
		{
			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			private float m_Radius;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[SerializeField]
			private Vector3 m_CastOffset;

			[Token(Token = "0x17000099")]
			public float radius
			{
				[Token(Token = "0x600049B")]
				[Address(RVA = "0xE54A38", Offset = "0xE54A38", VA = "0xE54A38")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700009A")]
			public Vector3 castOffset
			{
				[Token(Token = "0x600049C")]
				[Address(RVA = "0xE54A40", Offset = "0xE54A40", VA = "0xE54A40")]
				get
				{
					return default(Vector3);
				}
			}
		}

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_ModelTransform;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationCurve m_SpeedCurve;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_SpeedMultiplier;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MoveDuration;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GroundCheckSettings m_GroundCheckSettings;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_SpeedCurveTime;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Collider[] m_ColliderBuffer;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_InterpolationTime;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_InterpolationDistance;

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xE5270C", Offset = "0xE5270C", VA = "0xE5270C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xE52808", Offset = "0xE52808", VA = "0xE52808")]
		private void Update()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xE5282C", Offset = "0xE5282C", VA = "0xE5282C")]
		private bool CheckForGround()
		{
			return default(bool);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xE53294", Offset = "0xE53294", VA = "0xE53294")]
		private static Vector3 FindTargetForward(Collider collider, Vector3 position, Vector3 forward)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xE53680", Offset = "0xE53680", VA = "0xE53680")]
		private static Vector3 FindTargetPosition(Collider collider, Vector3 position, Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xE52F70", Offset = "0xE52F70", VA = "0xE52F70")]
		private Collider FindBestCollider(int colliderCount)
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xE52A70", Offset = "0xE52A70", VA = "0xE52A70")]
		private void MoveAnchor()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xE52B64", Offset = "0xE52B64", VA = "0xE52B64")]
		private void MoveModel()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xE53960", Offset = "0xE53960", VA = "0xE53960")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xE53A30", Offset = "0xE53A30", VA = "0xE53A30")]
		public SnailController()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home.WicketDefending.Scripts
{
	[Token(Token = "0x2000101")]
	public class CricketBat : MonoBehaviour
	{
		[Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class <DoSwing>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CricketBat <>4__this;

			[Token(Token = "0x1700009B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004A4")]
				[Address(RVA = "0xE54CC8", Offset = "0xE54CC8", VA = "0xE54CC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004A6")]
				[Address(RVA = "0xE54D10", Offset = "0xE54D10", VA = "0xE54D10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xE54B28", Offset = "0xE54B28", VA = "0xE54B28")]
			[DebuggerHidden]
			public <DoSwing>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xE54B58", Offset = "0xE54B58", VA = "0xE54B58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xE54B5C", Offset = "0xE54B5C", VA = "0xE54B5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xE54CD0", Offset = "0xE54CD0", VA = "0xE54CD0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 m_SwungRotation;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_Duration;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_DefaultRotation;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_StartTime;

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xE54A4C", Offset = "0xE54A4C", VA = "0xE54A4C")]
		private void Start()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xE54AA0", Offset = "0xE54AA0", VA = "0xE54AA0")]
		public void SwingBat()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xE54AC0", Offset = "0xE54AC0", VA = "0xE54AC0")]
		[IteratorStateMachine(typeof(<DoSwing>d__6))]
		private IEnumerator DoSwing()
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xE54B50", Offset = "0xE54B50", VA = "0xE54B50")]
		public CricketBat()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class StopSplineMovementOnCollision : MonoBehaviour
	{
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xE54D18", Offset = "0xE54D18", VA = "0xE54D18")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xE54DE4", Offset = "0xE54DE4", VA = "0xE54DE4")]
		public StopSplineMovementOnCollision()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000104")]
	public struct ThrowBallData
	{
		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m_Delay;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GameObject m_BallPrefab;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform m_Target;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m_Force;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 m_Error;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Spline m_Spline;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_SplineSpeed;
	}
	[Token(Token = "0x2000105")]
	public class ThrowBalls : MonoBehaviour
	{
		[Token(Token = "0x2000106")]
		[CompilerGenerated]
		private sealed class <DoThrow>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ThrowBalls <>4__this;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<ThrowBallData>.Enumerator <>7__wrap1;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private ThrowBallData <ballData>5__3;

			[Token(Token = "0x1700009D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004B3")]
				[Address(RVA = "0xE55554", Offset = "0xE55554", VA = "0xE55554", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004B5")]
				[Address(RVA = "0xE5559C", Offset = "0xE5559C", VA = "0xE5559C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0xE54E94", Offset = "0xE54E94", VA = "0xE54E94")]
			[DebuggerHidden]
			public <DoThrow>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0xE54EE8", Offset = "0xE54EE8", VA = "0xE54EE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0xE54F04", Offset = "0xE54F04", VA = "0xE54F04", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0xE55504", Offset = "0xE55504", VA = "0xE55504")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0xE5555C", Offset = "0xE5555C", VA = "0xE5555C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<ThrowBallData> m_BallsToThrow;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_SpawnPoint;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_OnLastBallThrown;

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xE54DEC", Offset = "0xE54DEC", VA = "0xE54DEC")]
		public void Throw()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xE54E74", Offset = "0xE54E74", VA = "0xE54E74")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xE54E0C", Offset = "0xE54E0C", VA = "0xE54E0C")]
		[IteratorStateMachine(typeof(<DoThrow>d__5))]
		private IEnumerator DoThrow()
		{
			return null;
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xE54EBC", Offset = "0xE54EBC", VA = "0xE54EBC")]
		private void CheckWin()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xE54ED8", Offset = "0xE54ED8", VA = "0xE54ED8")]
		public void StopThrowing()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xE54EE0", Offset = "0xE54EE0", VA = "0xE54EE0")]
		public ThrowBalls()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class Wicket : MonoBehaviour
	{
		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool m_WicketIsStruck;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_OnWicketStruck;

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xE555A4", Offset = "0xE555A4", VA = "0xE555A4")]
		public void WicketStruck()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xE555D8", Offset = "0xE555D8", VA = "0xE555D8")]
		public Wicket()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home.HomeRun.Scripts
{
	[Token(Token = "0x2000108")]
	public class DescendUponCall : MonoBehaviour
	{
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_NumCalls;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int m_CallsCalled;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_UpPos;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_DownPos;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_TargetPos;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent m_OnLastCall;

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xE555E0", Offset = "0xE555E0", VA = "0xE555E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xE5560C", Offset = "0xE5560C", VA = "0xE5560C")]
		public void Call()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xE556EC", Offset = "0xE556EC", VA = "0xE556EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xE557B0", Offset = "0xE557B0", VA = "0xE557B0")]
		public DescendUponCall()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class HomeRunner : MonoBehaviour
	{
		[Token(Token = "0x200010A")]
		[CompilerGenerated]
		private sealed class <MoveOnSpline>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HomeRunner <>4__this;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <nextStep>5__3;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <boostStart>5__4;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <boostEnd>5__5;

			[Token(Token = "0x1700009F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004C3")]
				[Address(RVA = "0xE55AB8", Offset = "0xE55AB8", VA = "0xE55AB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004C5")]
				[Address(RVA = "0xE55B00", Offset = "0xE55B00", VA = "0xE55B00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004C0")]
			[Address(RVA = "0xE55848", Offset = "0xE55848", VA = "0xE55848")]
			[DebuggerHidden]
			public <MoveOnSpline>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60004C1")]
			[Address(RVA = "0xE55880", Offset = "0xE55880", VA = "0xE55880", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xE55884", Offset = "0xE55884", VA = "0xE55884", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xE55AC0", Offset = "0xE55AC0", VA = "0xE55AC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_Target;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Spline m_Spline;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StepPeriod;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent m_OnStep;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_BoostOnStart;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_BoostDuration;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_Moving;

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xE557B8", Offset = "0xE557B8", VA = "0xE557B8")]
		public void StartRunning()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xE557E0", Offset = "0xE557E0", VA = "0xE557E0")]
		[IteratorStateMachine(typeof(<MoveOnSpline>d__9))]
		private IEnumerator MoveOnSpline()
		{
			return null;
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xE55870", Offset = "0xE55870", VA = "0xE55870")]
		public void StopMoving()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xE55878", Offset = "0xE55878", VA = "0xE55878")]
		public HomeRunner()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class HomeRunnerJoystick : MonoBehaviour
	{
		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Joystick m_Joystick;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_Character;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_Ground;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GroundSpeed;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_SidewaysSpeed;

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xE55B08", Offset = "0xE55B08", VA = "0xE55B08")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xE55DB8", Offset = "0xE55DB8", VA = "0xE55DB8")]
		public HomeRunnerJoystick()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home.Bathtub.Scripts
{
	[Token(Token = "0x200010C")]
	public class BathtubRubberDuck : MonoBehaviour, ITriggerable
	{
		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_WaterHeight;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Event m_Quack;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rb;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private LookAt m_LookAt;

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xE55DC0", Offset = "0xE55DC0", VA = "0xE55DC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xE55E58", Offset = "0xE55E58", VA = "0xE55E58", Slot = "4")]
		public void Trigger()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xE55FB8", Offset = "0xE55FB8", VA = "0xE55FB8")]
		public BathtubRubberDuck()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class TransformableRubberDuck : MonoBehaviour
	{
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Trophy;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_3DGlasses;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_RubberDuckModel;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_PowerPuff;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SubGoal m_SubGoal;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_PowerPuffEasterEggPossible;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int m_PowerPuffIngredientsAdded;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_PowerPuffIngredientsRequired;

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xE55FC0", Offset = "0xE55FC0", VA = "0xE55FC0")]
		public void TrophyTrigger()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xE5600C", Offset = "0xE5600C", VA = "0xE5600C")]
		public void GlassesTrigger()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xE56034", Offset = "0xE56034", VA = "0xE56034")]
		public void PowerPuffIngredient()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xE5607C", Offset = "0xE5607C", VA = "0xE5607C")]
		public TransformableRubberDuck()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home.Baseball.Scenes
{
	[Token(Token = "0x200010E")]
	public class BaseBallToBase : MonoBehaviour
	{
		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Prefab;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xE56094", Offset = "0xE56094", VA = "0xE56094")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xE56460", Offset = "0xE56460", VA = "0xE56460")]
		public BaseBallToBase()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class ElephantTag : MonoBehaviour
	{
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xE56468", Offset = "0xE56468", VA = "0xE56468")]
		public ElephantTag()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class SpawnNewWhenClear : MonoBehaviour
	{
		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Prefab;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_Current;

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xE56470", Offset = "0xE56470", VA = "0xE56470")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xE5666C", Offset = "0xE5666C", VA = "0xE5666C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xE564E8", Offset = "0xE564E8", VA = "0xE564E8")]
		public void Spawn()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xE56770", Offset = "0xE56770", VA = "0xE56770")]
		public SpawnNewWhenClear()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home__Young_.PiggyBankChores.Scripts
{
	[Token(Token = "0x2000111")]
	public class AddVelocityAwayFromCenter : MonoBehaviour
	{
		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_Center;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Force;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_ForceRandomVariance;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_RandomDirectionOffsetRadius;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ForceMode m_ForceMode;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_OnStart;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Transform;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xE56778", Offset = "0xE56778", VA = "0xE56778")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xE567D8", Offset = "0xE567D8", VA = "0xE567D8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xE567E8", Offset = "0xE567E8", VA = "0xE567E8")]
		public void AddVelocity()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xE56960", Offset = "0xE56960", VA = "0xE56960")]
		public AddVelocityAwayFromCenter()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class PiggyBank : MonoBehaviour
	{
		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeReference]
		private GameObjectFilter m_CanDestroyFilter;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeReference]
		private GameObjectFilter m_CoinFilter;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_MinVelocityToSmash;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Event m_OnSmash;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Event m_OnCoinAdded;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject m_OnWhenSmashed;

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xE56980", Offset = "0xE56980", VA = "0xE56980")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xE56C2C", Offset = "0xE56C2C", VA = "0xE56C2C")]
		public PiggyBank()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class Roomba : MonoBehaviour
	{
		[Token(Token = "0x2000114")]
		private class Target
		{
			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 direction;

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0xE56E20", Offset = "0xE56E20", VA = "0xE56E20")]
			public Target()
			{
			}
		}

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Target m_Target;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform m_Transform;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xE56C34", Offset = "0xE56C34", VA = "0xE56C34")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xE56C94", Offset = "0xE56C94", VA = "0xE56C94")]
		public void Goto(GameObject obj)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xE56CC8", Offset = "0xE56CC8", VA = "0xE56CC8")]
		public void Goto(Vector3 target)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xE56E28", Offset = "0xE56E28", VA = "0xE56E28")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xE56E70", Offset = "0xE56E70", VA = "0xE56E70")]
		public Roomba()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class RoombaFloor : MonoBehaviour
	{
		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Roomba m_Roomba;

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xE56E80", Offset = "0xE56E80", VA = "0xE56E80")]
		public void Hit(GameObject hitGameObject)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xE56EB8", Offset = "0xE56EB8", VA = "0xE56EB8")]
		public RoombaFloor()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class TriggerWhenSeenByPlayer : MonoBehaviour
	{
		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_SphereCastRadius;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_SphereCastRange;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Camera m_Camera;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_TargetObject;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_Activated;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool m_OnlyTriggerOnce;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent m_OnSeenByPlayer;

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xE56EC0", Offset = "0xE56EC0", VA = "0xE56EC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xE56F24", Offset = "0xE56F24", VA = "0xE56F24")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xE56F34", Offset = "0xE56F34", VA = "0xE56F34")]
		private void Cast()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xE571D8", Offset = "0xE571D8", VA = "0xE571D8")]
		private void Trigger()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xE57208", Offset = "0xE57208", VA = "0xE57208")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xE57210", Offset = "0xE57210", VA = "0xE57210")]
		public TriggerWhenSeenByPlayer()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home__Young_.MorningRoutineYoung.Scripts
{
	[Token(Token = "0x2000117")]
	public class StickToBatOnCollitionEnter : MonoBehaviour
	{
		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_LeftBatCollider;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_RightBatCollider;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject m_MirrorInstance;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_IsOnBat;

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xE57220", Offset = "0xE57220", VA = "0xE57220")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xE572AC", Offset = "0xE572AC", VA = "0xE572AC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xE57684", Offset = "0xE57684", VA = "0xE57684")]
		public StickToBatOnCollitionEnter()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class ToothBrushingController : MonoBehaviour
	{
		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_BrushTimeBeforeCompletion;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeReference]
		private GameObjectFilter m_OpenMouthGameObjectFilter;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeReference]
		private GameObjectFilter m_BrushGameObjectFilter;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RTPC m_ToothBrushMusicRTPC;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("References")]
		[SerializeField]
		private GameObject m_OpenMouth;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject m_CloseMouth;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SubGoal m_SubGoal;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ParticleSystem[] m_BrushParticleSystems;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Space]
		private UnityEvent m_OnOpenMouth;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UnityEvent m_OnCloseMouth;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Event m_ToothBrushing;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_IsBrushing;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float m_Timer;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PlayerMouthController m_PlayerMouthController;

		[Token(Token = "0x170000A1")]
		public float normalizedTime
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0xE5768C", Offset = "0xE5768C", VA = "0xE5768C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xE576B8", Offset = "0xE576B8", VA = "0xE576B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xE57834", Offset = "0xE57834", VA = "0xE57834")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xE579E8", Offset = "0xE579E8", VA = "0xE579E8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xE57A74", Offset = "0xE57A74", VA = "0xE57A74")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xE578C0", Offset = "0xE578C0", VA = "0xE578C0")]
		private void OpenMouth()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xE57734", Offset = "0xE57734", VA = "0xE57734")]
		private void CloseMouth()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xE578FC", Offset = "0xE578FC", VA = "0xE578FC")]
		private void StartBrushing()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xE57770", Offset = "0xE57770", VA = "0xE57770")]
		private void StopBrushing()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xE57AC4", Offset = "0xE57AC4", VA = "0xE57AC4")]
		private void Complete()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xE57AF0", Offset = "0xE57AF0", VA = "0xE57AF0")]
		public ToothBrushingController()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class ToothBrushTimer : MonoBehaviour
	{
		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_StartAngle;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("References")]
		private Transform m_MinuteHandTransform;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_AlarmClock;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ToothBrushingController m_ToothBrushingController;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Destructible m_Destructible;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_AlarmClockIsVisible;

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xE57AF8", Offset = "0xE57AF8", VA = "0xE57AF8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xE57B58", Offset = "0xE57B58", VA = "0xE57B58")]
		private void Update()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xE57CE8", Offset = "0xE57CE8", VA = "0xE57CE8")]
		public ToothBrushTimer()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class ToothPasteTag : MonoBehaviour
	{
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xE57CF0", Offset = "0xE57CF0", VA = "0xE57CF0")]
		public ToothPasteTag()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home__Young_.Fence.Scripts
{
	[Token(Token = "0x200011B")]
	public class DefensiveFencePiece : MonoBehaviour
	{
		[Token(Token = "0x400054E")]
		private const float kLineLength = 20f;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_JumpHeight;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_JumpDuration;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_WaitTimeInAir;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Ease m_Ease;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_DistanceThreshold;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Transform> m_TrackedSpawnedInstances;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_StartHeight;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_IsJumping;

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xE57CF8", Offset = "0xE57CF8", VA = "0xE57CF8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xE57E14", Offset = "0xE57E14", VA = "0xE57E14")]
		private void Update()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xE58280", Offset = "0xE58280", VA = "0xE58280")]
		private void StartTrackingSpawnedInstance(GameObject instance)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xE580F8", Offset = "0xE580F8", VA = "0xE580F8")]
		private void Jump()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xE5833C", Offset = "0xE5833C", VA = "0xE5833C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xE5847C", Offset = "0xE5847C", VA = "0xE5847C")]
		public DefensiveFencePiece()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class FenceRotationEvaluator : MonoBehaviour
	{
		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Rigidbody> m_Fences;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 m_TargetDirection;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_RotationThreshold;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_MaxAngularVelocity;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent m_OnCorrectRotation;

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xE5848C", Offset = "0xE5848C", VA = "0xE5848C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xE58554", Offset = "0xE58554", VA = "0xE58554")]
		private bool CheckFenceRotation(Rigidbody fenceRigidBody)
		{
			return default(bool);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xE58694", Offset = "0xE58694", VA = "0xE58694")]
		public FenceRotationEvaluator()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home__Childhood_.WireToyThing
{
	[Token(Token = "0x200011D")]
	public class TrophyWireSphere : MonoBehaviour
	{
		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ObjectSwapper m_Swapper;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ColorRemapEffect m_ColorRemapper;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeReference]
		private GameObjectFilter m_GameObjectFilter;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_CollisionTimeStay;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrophyWireWin m_TrophyWireWin;

		[Token(Token = "0x170000A2")]
		public bool isOn
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0xE5869C", Offset = "0xE5869C", VA = "0xE5869C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000507")]
			[Address(RVA = "0xE586A4", Offset = "0xE586A4", VA = "0xE586A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xE586B0", Offset = "0xE586B0", VA = "0xE586B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xE58700", Offset = "0xE58700", VA = "0xE58700")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xE588AC", Offset = "0xE588AC", VA = "0xE588AC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xE58980", Offset = "0xE58980", VA = "0xE58980")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xE58B2C", Offset = "0xE58B2C", VA = "0xE58B2C")]
		private void OnCollisionExit(Collision other)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xE58A4C", Offset = "0xE58A4C", VA = "0xE58A4C")]
		public void Fail()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xE58B70", Offset = "0xE58B70", VA = "0xE58B70")]
		public void TurnOff()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xE58B9C", Offset = "0xE58B9C", VA = "0xE58B9C")]
		public void TurnOn()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xE58BD4", Offset = "0xE58BD4", VA = "0xE58BD4")]
		public TrophyWireSphere()
		{
		}
	}
	[Token(Token = "0x200011E")]
	[RequireComponent(typeof(SubGoal))]
	public class TrophyWireWin : MonoBehaviour
	{
		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<TrophyWireSphere> m_Spheres;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TrophyWireSphere m_First;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool up;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int lastInt;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool started;

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xE58BDC", Offset = "0xE58BDC", VA = "0xE58BDC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xE58760", Offset = "0xE58760", VA = "0xE58760")]
		public void OnActive(TrophyWireSphere sphere)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xE58C50", Offset = "0xE58C50", VA = "0xE58C50")]
		public TrophyWireWin()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home__Childhood_.ShapeBox.Scripts
{
	[Token(Token = "0x2000120")]
	public class AlarmThrower : MonoBehaviour
	{
		[Token(Token = "0x2000121")]
		[CompilerGenerated]
		private sealed class <ThrowBurst>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AlarmThrower <>4__this;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<GameObject>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000A3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000525")]
				[Address(RVA = "0xE59794", Offset = "0xE59794", VA = "0xE59794", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000527")]
				[Address(RVA = "0xE597DC", Offset = "0xE597DC", VA = "0xE597DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000521")]
			[Address(RVA = "0xE59100", Offset = "0xE59100", VA = "0xE59100")]
			[DebuggerHidden]
			public <ThrowBurst>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000522")]
			[Address(RVA = "0xE59438", Offset = "0xE59438", VA = "0xE59438", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000523")]
			[Address(RVA = "0xE59454", Offset = "0xE59454", VA = "0xE59454", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0xE59744", Offset = "0xE59744", VA = "0xE59744")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0xE5979C", Offset = "0xE5979C", VA = "0xE5979C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_AlarmClock;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int[] m_AmountToSpawnPerBurst;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_ThrowTarget;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_ThrowForce;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Randomly deviate from the throw direction up to this amount")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_ThrowRandomFactor;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_StartDelay;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_ThrowBurstDelay;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_ThrowDelayInBurst;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Situation m_Situation;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly List<GameObject> m_AlarmClocksToThrow;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_NextBurst;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float m_NextThrow;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_ClocksDestroyed;

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xE58CDC", Offset = "0xE58CDC", VA = "0xE58CDC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xE58F2C", Offset = "0xE58F2C", VA = "0xE58F2C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xE58FD8", Offset = "0xE58FD8", VA = "0xE58FD8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xE59054", Offset = "0xE59054", VA = "0xE59054")]
		public void ClockDestroyed()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xE58F70", Offset = "0xE58F70", VA = "0xE58F70")]
		[IteratorStateMachine(typeof(<ThrowBurst>d__17))]
		private IEnumerator ThrowBurst()
		{
			return null;
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xE59128", Offset = "0xE59128", VA = "0xE59128")]
		private void Throw(Rigidbody alarmClock)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xE58D04", Offset = "0xE58D04", VA = "0xE58D04")]
		private void PopulateAlarmClockList()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xE590A8", Offset = "0xE590A8", VA = "0xE590A8")]
		private void AllClocksDestroyed()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xE59330", Offset = "0xE59330", VA = "0xE59330")]
		private int CoinFlip()
		{
			return default(int);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xE59354", Offset = "0xE59354", VA = "0xE59354")]
		public AlarmThrower()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class BeatingHeart : MonoBehaviour
	{
		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Event m_HeartBeat;

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xE597E4", Offset = "0xE597E4", VA = "0xE597E4")]
		public void HeartBeat()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xE5985C", Offset = "0xE5985C", VA = "0xE5985C")]
		public BeatingHeart()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class BlockThrower : MonoBehaviour, IShapeSorterController
	{
		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rigidbody[] m_ThrowList;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_StartDelay;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_ThrowDelay;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_ThrowTarget;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_ThrowForce;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_NextObject;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_NextThrow;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xE59864", Offset = "0xE59864", VA = "0xE59864")]
		private void Awake()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xE598BC", Offset = "0xE598BC", VA = "0xE598BC")]
		private void Start()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xE598E0", Offset = "0xE598E0", VA = "0xE598E0")]
		private void Update()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xE59BE8", Offset = "0xE59BE8", VA = "0xE59BE8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xE59914", Offset = "0xE59914", VA = "0xE59914")]
		private void Throw()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xE59C5C", Offset = "0xE59C5C", VA = "0xE59C5C")]
		private void PrepareNextThrow()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xE59C80", Offset = "0xE59C80", VA = "0xE59C80", Slot = "4")]
		public void ShapeSorted(GameObject shape)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xE59D78", Offset = "0xE59D78", VA = "0xE59D78")]
		public BlockThrower()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class ClockKeeper : MonoBehaviour
	{
		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Situation m_Situation;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_ClocksToDestroy;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int m_ClocksDestroyed;

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xE59D9C", Offset = "0xE59D9C", VA = "0xE59D9C")]
		public void ClockDestroyed()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xE59DD4", Offset = "0xE59DD4", VA = "0xE59DD4")]
		private void AllClocksDestroyed()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xE59DF0", Offset = "0xE59DF0", VA = "0xE59DF0")]
		public ClockKeeper()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class FlyingAlarmsController : MonoBehaviour
	{
		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MovingAlarmClock[] m_MovingAlarmClocks;

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xE59DF8", Offset = "0xE59DF8", VA = "0xE59DF8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xE59E8C", Offset = "0xE59E8C", VA = "0xE59E8C")]
		public FlyingAlarmsController()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public interface IShapeSorterController
	{
		[Token(Token = "0x6000537")]
		void ShapeSorted(GameObject shape);
	}
	[Token(Token = "0x2000127")]
	public class MovingAlarmClock : AlarmClock
	{
		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform m_CirclingTarget;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float m_CirclingDistance;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float m_CirclingHeight;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float m_MovementSpeed;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Transform m_Spring;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float m_CirclingRandomFactor;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AlarmThrower m_Thrower;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ClockKeeper m_Keeper;

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xE59E94", Offset = "0xE59E94", VA = "0xE59E94")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xE59F88", Offset = "0xE59F88", VA = "0xE59F88")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xE5A390", Offset = "0xE5A390", VA = "0xE5A390")]
		public void SetCirclingTarget(Transform target)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xE5A398", Offset = "0xE5A398", VA = "0xE5A398")]
		public void SetThrower(AlarmThrower thrower)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xE5A3A0", Offset = "0xE5A3A0", VA = "0xE5A3A0", Slot = "9")]
		public override void BreakClock(float force)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xE59F64", Offset = "0xE59F64", VA = "0xE59F64")]
		private int CoinFlip()
		{
			return default(int);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xE5A464", Offset = "0xE5A464", VA = "0xE5A464")]
		public MovingAlarmClock()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class ShapeSorterLivesController : MonoBehaviour
	{
		[Token(Token = "0x2000129")]
		[CompilerGenerated]
		private sealed class <CreateLife>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject heart;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShapeSorterLivesController <>4__this;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GameObject[] <>7__wrap1;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <>7__wrap2;

			[Token(Token = "0x170000A5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000549")]
				[Address(RVA = "0xE5AF1C", Offset = "0xE5AF1C", VA = "0xE5AF1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600054B")]
				[Address(RVA = "0xE5AF64", Offset = "0xE5AF64", VA = "0xE5AF64", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0xE5A678", Offset = "0xE5A678", VA = "0xE5A678")]
			[DebuggerHidden]
			public <CreateLife>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000547")]
			[Address(RVA = "0xE5AB28", Offset = "0xE5AB28", VA = "0xE5AB28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0xE5AB2C", Offset = "0xE5AB2C", VA = "0xE5AB2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0xE5AF24", Offset = "0xE5AF24", VA = "0xE5AF24", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int BeatFast;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EyeExpressions m_Eyes;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_Eye1;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_Eye2;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_SpawnPoint;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] m_ShapesToPuke;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject m_Trophy;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform m_ConfettiPosition;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Situation m_Situation;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_PukeForce;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform m_PukeTarget;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject m_Lid;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Collider[] m_LidColliders;

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xE5A4D8", Offset = "0xE5A4D8", VA = "0xE5A4D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xE5A5E4", Offset = "0xE5A5E4", VA = "0xE5A5E4")]
		public void Live(GameObject heart)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xE5A604", Offset = "0xE5A604", VA = "0xE5A604")]
		[IteratorStateMachine(typeof(<CreateLife>d__15))]
		private IEnumerator CreateLife(GameObject heart)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xE5A6A0", Offset = "0xE5A6A0", VA = "0xE5A6A0")]
		private void Puke(GameObject shape)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xE5A8D4", Offset = "0xE5A8D4", VA = "0xE5A8D4")]
		private void DisableCollision(Transform other)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xE5AAB0", Offset = "0xE5AAB0", VA = "0xE5AAB0")]
		public ShapeSorterLivesController()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home__Childhood_.SandboxTrophy
{
	[Token(Token = "0x200012B")]
	public class SandboxBucket : MonoBehaviour, IBatHitReceiver
	{
		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_AngleThreshold;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_StaticObject;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_DynamicObject;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent m_OnSwap;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_InitialUpVector;

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xE5B000", Offset = "0xE5B000", VA = "0xE5B000")]
		private void Start()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xE5B054", Offset = "0xE5B054", VA = "0xE5B054")]
		private void SwapContentsOfBucket()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xE5B0AC", Offset = "0xE5B0AC", VA = "0xE5B0AC")]
		private bool IsTippedOver()
		{
			return default(bool);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xE5B1EC", Offset = "0xE5B1EC", VA = "0xE5B1EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xE5B210", Offset = "0xE5B210", VA = "0xE5B210", Slot = "4")]
		public void OnBatHit(Vector3 position, Vector3 velocity, Bat bat)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xE5B30C", Offset = "0xE5B30C", VA = "0xE5B30C")]
		public SandboxBucket()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class SandFiller : MonoBehaviour
	{
		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_FillDuration;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_OnFilled;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_SandTransform;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_MaxHeight;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_StartRadius;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_EndRadius;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Filling;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_Filled;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_NormalizedFillAmount;

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xE5B314", Offset = "0xE5B314", VA = "0xE5B314")]
		private void Start()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xE5B374", Offset = "0xE5B374", VA = "0xE5B374")]
		private void Update()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xE5B478", Offset = "0xE5B478", VA = "0xE5B478")]
		public void FillSand()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xE5B484", Offset = "0xE5B484", VA = "0xE5B484")]
		public void StopFillingSand()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xE5B48C", Offset = "0xE5B48C", VA = "0xE5B48C")]
		public SandFiller()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home__Childhood_.RagdollTeddy.Scripts
{
	[Token(Token = "0x200012D")]
	public class TransferMomentum : MonoBehaviour
	{
		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_HitCooldown;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_NextLegalHit;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_Power;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_Center;

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xE5B494", Offset = "0xE5B494", VA = "0xE5B494")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xE5B5EC", Offset = "0xE5B5EC", VA = "0xE5B5EC")]
		public TransferMomentum()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home__Childhood_.FoamMaking.Scripts
{
	[Token(Token = "0x200012E")]
	public class FoamParticleController : MonoBehaviour
	{
		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_ProgressPerHit;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationCurve m_FoamGrowthCurve;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve m_EmissionCurve;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("References")]
		[SerializeField]
		private ParticleSystem[] m_Particles;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform m_WaterBox;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform m_TrophyTransform;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Bounds m_WaterBounds;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Situation m_Situation;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_Progress;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_OffsetMaxLength;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform m_TriggerTransform;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Event m_StartFoam;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RTPC m_FoamRtcp;

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xE5B5FC", Offset = "0xE5B5FC", VA = "0xE5B5FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xE5B72C", Offset = "0xE5B72C", VA = "0xE5B72C")]
		private float CalculateMaxLength()
		{
			return default(float);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xE5B790", Offset = "0xE5B790", VA = "0xE5B790")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xE5B7CC", Offset = "0xE5B7CC", VA = "0xE5B7CC")]
		private void IncreaseProgress()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xE5B880", Offset = "0xE5B880", VA = "0xE5B880")]
		private void UpdateParticles()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xE5BA34", Offset = "0xE5BA34", VA = "0xE5BA34")]
		public FoamParticleController()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class ObjectInBubble : MonoBehaviour
	{
		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_DynamicObject;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_StaticObject;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeReference]
		private GameObjectFilter m_TriggerFilter;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SubGoal m_SubGoal;

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xE5BA48", Offset = "0xE5BA48", VA = "0xE5BA48")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xE5BA80", Offset = "0xE5BA80", VA = "0xE5BA80")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xE5BAD8", Offset = "0xE5BAD8", VA = "0xE5BAD8")]
		[ContextMenu("Bubble")]
		private void EncloseInBubble()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xE5BBB0", Offset = "0xE5BBB0", VA = "0xE5BBB0")]
		public ObjectInBubble()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home__Childhood_.BatDay.Scripts
{
	[Token(Token = "0x2000130")]
	public class BatDaySequence : MonoBehaviour
	{
		[Token(Token = "0x2000131")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BatDaySequence <>4__this;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 lookTargetStart;

			[Token(Token = "0x600056C")]
			[Address(RVA = "0xE5BFCC", Offset = "0xE5BFCC", VA = "0xE5BFCC")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0xE5BFD4", Offset = "0xE5BFD4", VA = "0xE5BFD4")]
			internal void <Sequence>b__0(float t)
			{
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0xE5C0A4", Offset = "0xE5C0A4", VA = "0xE5C0A4")]
			internal bool <Sequence>b__1()
			{
				return default(bool);
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0xE5C0D8", Offset = "0xE5C0D8", VA = "0xE5C0D8")]
			internal void <Sequence>b__2(float t)
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0xE5C168", Offset = "0xE5C168", VA = "0xE5C168")]
			internal bool <Sequence>b__3()
			{
				return default(bool);
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0xE5C234", Offset = "0xE5C234", VA = "0xE5C234")]
			internal bool <Sequence>b__4()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000132")]
		[CompilerGenerated]
		private sealed class <Sequence>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BatDaySequence <>4__this;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass20_0 <>8__1;

			[Token(Token = "0x170000A7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000575")]
				[Address(RVA = "0xE5C9B8", Offset = "0xE5C9B8", VA = "0xE5C9B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000577")]
				[Address(RVA = "0xE5CA00", Offset = "0xE5CA00", VA = "0xE5CA00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0xE5BD80", Offset = "0xE5BD80", VA = "0xE5BD80")]
			[DebuggerHidden]
			public <Sequence>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0xE5C250", Offset = "0xE5C250", VA = "0xE5C250", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0xE5C254", Offset = "0xE5C254", VA = "0xE5C254", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0xE5C9C0", Offset = "0xE5C9C0", VA = "0xE5C9C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_LookTarget;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_LookTargetAtYou;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_LookTargetInAir;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve m_LookUpAnimationCurve;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform m_LookTargetOnBox;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Animator m_FallAnimator;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject m_SpeechBubble;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TMP_Text m_Text;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CollisionEvent m_ButtonTouch;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject m_FallingBox;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject m_BoxOnTable;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HingeJoint m_BoxLidJoint;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BatSetup m_BaseballBats;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private PlayerRigSetup m_PlayerRigSetup;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Header("Audio")]
		private SetWwiseState m_BoxAppearsState;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SetWwiseState m_BoxOpensState;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform m_CameraTransform;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Situation m_Situation;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool m_ButtonTouched;

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xE5BBB8", Offset = "0xE5BBB8", VA = "0xE5BBB8")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xE5BD18", Offset = "0xE5BD18", VA = "0xE5BD18")]
		[IteratorStateMachine(typeof(<Sequence>d__20))]
		private IEnumerator Sequence()
		{
			return null;
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xE5BDA8", Offset = "0xE5BDA8", VA = "0xE5BDA8")]
		private bool IsPlayerLookingAtPoint(Vector3 position, float fovAngles)
		{
			return default(bool);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xE5BF08", Offset = "0xE5BF08", VA = "0xE5BF08")]
		public BatDaySequence()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home__Childhood_.BallBath
{
	[Token(Token = "0x2000133")]
	public class BallBathBall : MonoBehaviour
	{
		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[ColorReference]
		[SerializeField]
		private List<Triband.ColorPipeline.Runtime.SerializableGUID> m_Colors;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ColorRemap m_Remap;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Collider m_IcoSphere;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[ColorReference]
		private Triband.ColorPipeline.Runtime.SerializableGUID m_OrgColor;

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xE5CA08", Offset = "0xE5CA08", VA = "0xE5CA08")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xE5CB34", Offset = "0xE5CB34", VA = "0xE5CB34")]
		private void Start()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xE5CC04", Offset = "0xE5CC04", VA = "0xE5CC04")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xE5CCC4", Offset = "0xE5CCC4", VA = "0xE5CCC4")]
		private void OnCollisionExit(Collision other)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xE5CD84", Offset = "0xE5CD84", VA = "0xE5CD84")]
		public BallBathBall()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home__Adult_.TVSignal.Scripts
{
	[Token(Token = "0x2000134")]
	public class AntennaTuning : MonoBehaviour
	{
		[Token(Token = "0x2000135")]
		private struct SmoothDampValue
		{
			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float m_Target;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private float m_Current;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private float m_Velocity;

			[Token(Token = "0x6000580")]
			[Address(RVA = "0xE5CF54", Offset = "0xE5CF54", VA = "0xE5CF54")]
			public float Evaluate(float target)
			{
				return default(float);
			}
		}

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_LeftAntenna;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_RightAntenna;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_LeftAngleTarget;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_RightAngleTarget;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_MaxDifference;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_AngleThreshold;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TelevisionTuner m_TelevisionTuner;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SmoothDampValue m_LeftValue;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private SmoothDampValue m_RightValue;

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xE5CD8C", Offset = "0xE5CD8C", VA = "0xE5CD8C")]
		private void Update()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xE5CE80", Offset = "0xE5CE80", VA = "0xE5CE80")]
		private float CalculateNormalizedDifference(Transform antenna, float target)
		{
			return default(float);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xE5CFB8", Offset = "0xE5CFB8", VA = "0xE5CFB8")]
		public AntennaTuning()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class BestSignalTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000137")]
		private class FloatUnityEvent : UnityEvent<float>
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0xE5D110", Offset = "0xE5D110", VA = "0xE5D110")]
			public FloatUnityEvent()
			{
			}
		}

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Target")]
		private bool m_UseTransform;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[HideIf("m_UseTransform")]
		private Vector3 m_Target;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[ShowIf("m_UseTransform")]
		private Transform m_TargetTransform;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Limits")]
		[SerializeField]
		private float m_DistanceThreshold;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_MaxDistance;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("References")]
		[SerializeField]
		private TelevisionTuner m_TelevisionTuner;

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xE5CFC0", Offset = "0xE5CFC0", VA = "0xE5CFC0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xE5D0D4", Offset = "0xE5D0D4", VA = "0xE5D0D4")]
		private Vector3 GetTargetPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xE5D108", Offset = "0xE5D108", VA = "0xE5D108")]
		public BestSignalTarget()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class DisableResetButton : MonoBehaviour
	{
		[Token(Token = "0x6000585")]
		[Address(RVA = "0xE5D158", Offset = "0xE5D158", VA = "0xE5D158")]
		public void DisableButton()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xE5D1FC", Offset = "0xE5D1FC", VA = "0xE5D1FC")]
		public DisableResetButton()
		{
		}
	}
	[Token(Token = "0x2000139")]
	[RequireComponent(typeof(RotationConstraint))]
	public class SetBatAsRotationConstraint : MonoBehaviour
	{
		[Token(Token = "0x200013A")]
		private enum Bat
		{
			[Token(Token = "0x40005F8")]
			Left,
			[Token(Token = "0x40005F9")]
			Right
		}

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Bat m_Bat;

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xE5D204", Offset = "0xE5D204", VA = "0xE5D204")]
		private void Start()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xE5D300", Offset = "0xE5D300", VA = "0xE5D300")]
		public SetBatAsRotationConstraint()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class TvHittable : MonoBehaviour, IBatHitReceiver
	{
		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TelevisionTuner m_Signal;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Collider m_ScreenCollider;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve m_VelToSignalCurve;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_RequiredHitVelocity;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent m_OnHit;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_SignalStrengthTarget;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_SignalStrengthSmoothingVelocity;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Sequence m_Sequence;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_CanHitTv;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_Hits;

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xE5D308", Offset = "0xE5D308", VA = "0xE5D308")]
		private void Start()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xE5D400", Offset = "0xE5D400", VA = "0xE5D400")]
		private void PlayerLookAtScreenHandler()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xE5D578", Offset = "0xE5D578", VA = "0xE5D578")]
		private void Update()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xE5D62C", Offset = "0xE5D62C", VA = "0xE5D62C", Slot = "4")]
		public void OnBatHit(Vector3 position, Vector3 velocity, Bat bat)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xE5D76C", Offset = "0xE5D76C", VA = "0xE5D76C")]
		public TvHittable()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home__Adult_.MorningRoutineAdult.Scripts
{
	[Token(Token = "0x200013C")]
	public class SeagullThief : MonoBehaviour
	{
		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int SwoopInID;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int Flying;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int PickUpObject;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_AttachTransform;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ToasterHandle m_Toaster;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Event m_ChickenScream;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Event m_ChickenPickUpToastSFX;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BreadController m_BreadController;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Animator m_SeagullController;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform m_Beak;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent m_OnToastPickedUp;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private MoveObjectAlongSpline m_MoveObjectSpline;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody m_Rb;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject m_Toast;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_CanGrabToast;

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xE5D788", Offset = "0xE5D788", VA = "0xE5D788")]
		private void Start()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xE5D844", Offset = "0xE5D844", VA = "0xE5D844")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xE5DA88", Offset = "0xE5DA88", VA = "0xE5DA88")]
		public void OnHit()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xE5DC78", Offset = "0xE5DC78", VA = "0xE5DC78")]
		public void PickUpAnimation()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xE5DCE8", Offset = "0xE5DCE8", VA = "0xE5DCE8")]
		public void CommenceSwooping()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xE5DD04", Offset = "0xE5DD04", VA = "0xE5DD04")]
		public void ToastingComplete()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xE5DC44", Offset = "0xE5DC44", VA = "0xE5DC44")]
		private void StopScreaming()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xE5DB7C", Offset = "0xE5DB7C", VA = "0xE5DB7C")]
		private void ReleaseToast()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xE5DD20", Offset = "0xE5DD20", VA = "0xE5DD20")]
		public SeagullThief()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Home__Adult_.Breakfast.Scripts
{
	[Token(Token = "0x200013D")]
	public class EggBomber : MonoBehaviour
	{
		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Egg;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_SpawnPos;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_SpawnCooldown;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("Randomly change the cooldown by this amount in percentage.")]
		private float m_CooldownRandomFactor;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AnimationSpeed;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_NextSpawn;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xE5DDF8", Offset = "0xE5DDF8", VA = "0xE5DDF8")]
		private void Start()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xE5DE84", Offset = "0xE5DE84", VA = "0xE5DE84")]
		private void Update()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xE5DEFC", Offset = "0xE5DEFC", VA = "0xE5DEFC")]
		private void SpawnEgg()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xE5E034", Offset = "0xE5E034", VA = "0xE5E034")]
		public EggBomber()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class FryingPoint : MonoBehaviour
	{
		[Token(Token = "0x600059D")]
		[Address(RVA = "0xE5E050", Offset = "0xE5E050", VA = "0xE5E050")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xE5E128", Offset = "0xE5E128", VA = "0xE5E128")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xE5E200", Offset = "0xE5E200", VA = "0xE5E200")]
		public FryingPoint()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.TractorPullingAndCropCircles.Scripts
{
	[Token(Token = "0x200013F")]
	public class AttractorBeam : MonoBehaviour
	{
		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_InterpolationSpeed;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_TargetDistanceFromBody;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeReference]
		private GameObjectFilter m_GameObjectFilter;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_ApplyForceOnDisconnect;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[ShowIf("m_ApplyForceOnDisconnect")]
		private Vector3 m_ForceMin;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[ShowIf("m_ApplyForceOnDisconnect")]
		[SerializeField]
		private Vector3 m_ForceMax;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[ShowIf("m_ApplyForceOnDisconnect")]
		private float m_TorqueAmount;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RaycastHit[] m_RaycastHitBuffer;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody m_CurrentAttractedRigidbody;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform m_ParentBody;

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xE5E208", Offset = "0xE5E208", VA = "0xE5E208")]
		private void AddForce()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xE5E2C0", Offset = "0xE5E2C0", VA = "0xE5E2C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xE5E34C", Offset = "0xE5E34C", VA = "0xE5E34C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xE5E3E4", Offset = "0xE5E3E4", VA = "0xE5E3E4")]
		private void Update()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xE5E988", Offset = "0xE5E988", VA = "0xE5E988")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xE5E6B8", Offset = "0xE5E6B8", VA = "0xE5E6B8")]
		private void UpdateAttractedObjectPosition()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xE5E350", Offset = "0xE5E350", VA = "0xE5E350")]
		public void DisconnectAttractedObject()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xE5EBAC", Offset = "0xE5EBAC", VA = "0xE5EBAC")]
		public AttractorBeam()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class BeamAnimator : MonoBehaviour
	{
		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[MinMaxSlider(0.25f, 1f)]
		private Vector2 m_ConeRadius;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_AnimationSpeed;

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xE5EBB4", Offset = "0xE5EBB4", VA = "0xE5EBB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xE5EC4C", Offset = "0xE5EC4C", VA = "0xE5EC4C")]
		public BeamAnimator()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class BeamAttractor : MonoBehaviour
	{
		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] m_Prefabs;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float[] m_Scales;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_DistanceBetweenObjects;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_Confetti;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_LoopObjects;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int m_NextObjectIndex;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_Distance;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_LastPosition;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Situation m_Situation;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_IsAttracting;

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xE5EC54", Offset = "0xE5EC54", VA = "0xE5EC54")]
		private void Start()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xE5ECC8", Offset = "0xE5ECC8", VA = "0xE5ECC8")]
		private void Update()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xE5F12C", Offset = "0xE5F12C", VA = "0xE5F12C")]
		private void StopAttracting()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xE5EDD0", Offset = "0xE5EDD0", VA = "0xE5EDD0")]
		private void AttractObject()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xE5F1B4", Offset = "0xE5F1B4", VA = "0xE5F1B4")]
		public BeamAttractor()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class BeamAttractorSelectedObject : MonoBehaviour
	{
		[Token(Token = "0x2000144")]
		[CompilerGenerated]
		private sealed class <WaitAndImplement>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BeamAttractorSelectedObject <>4__this;

			[Token(Token = "0x170000A9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005B8")]
				[Address(RVA = "0xE5F5AC", Offset = "0xE5F5AC", VA = "0xE5F5AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005BA")]
				[Address(RVA = "0xE5F5F4", Offset = "0xE5F5F4", VA = "0xE5F5F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xE5F3F0", Offset = "0xE5F3F0", VA = "0xE5F3F0")]
			[DebuggerHidden]
			public <WaitAndImplement>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0xE5F420", Offset = "0xE5F420", VA = "0xE5F420", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xE5F424", Offset = "0xE5F424", VA = "0xE5F424", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xE5F5B4", Offset = "0xE5F5B4", VA = "0xE5F5B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_TargetObject;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_AttractDuration;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_OnObjectEaten;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Event m_StartAttractingSFX;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Event m_StopAttractingSFX;

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xE5F2F8", Offset = "0xE5F2F8", VA = "0xE5F2F8")]
		public void Attract()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xE5F388", Offset = "0xE5F388", VA = "0xE5F388")]
		[IteratorStateMachine(typeof(<WaitAndImplement>d__6))]
		private IEnumerator WaitAndImplement()
		{
			return null;
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xE5F418", Offset = "0xE5F418", VA = "0xE5F418")]
		public BeamAttractorSelectedObject()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class BeamPullOut : MonoBehaviour
	{
		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_PullForce;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_TorqueMultiplier;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_Target;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_TargetFound;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Event m_PullSFX;

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xE5F5FC", Offset = "0xE5F5FC", VA = "0xE5F5FC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xE5F7DC", Offset = "0xE5F7DC", VA = "0xE5F7DC")]
		public BeamPullOut()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public class CropCircleCutter : MonoBehaviour
	{
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xE5F7E4", Offset = "0xE5F7E4", VA = "0xE5F7E4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xE5F864", Offset = "0xE5F864", VA = "0xE5F864")]
		public CropCircleCutter()
		{
		}
	}
	[Token(Token = "0x2000147")]
	public class ScaleByVFXParticleCount : MonoBehaviour, IRequireValidation
	{
		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_TargetSelf;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[OptionalReference]
		[HideIf("m_TargetSelf")]
		[SerializeField]
		private Transform m_Target;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PlantVFXInstance m_VisualEffect;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_MinParticles;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_MaxParticles;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_MinScale;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_MaxScale;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_SmoothScaling;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_SmoothingAmount;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve m_Curve;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent m_OnScaleChanged;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UnityEvent m_OnMaxScale;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_TargetScale;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_LastScale;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_MaxScaleCallbackInvoked;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool m_VisualEffectIsReady;

		[Token(Token = "0x170000AB")]
		private Transform target
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xE5F86C", Offset = "0xE5F86C", VA = "0xE5F86C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xE5F884", Offset = "0xE5F884", VA = "0xE5F884")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xE5FB6C", Offset = "0xE5FB6C", VA = "0xE5FB6C", Slot = "4")]
		public void Validate(ValidationContext context)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xE5FBDC", Offset = "0xE5FBDC", VA = "0xE5FBDC")]
		public ScaleByVFXParticleCount()
		{
		}
	}
	[Token(Token = "0x2000148")]
	public class StopBeamAttractor : MonoBehaviour
	{
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xE5FC04", Offset = "0xE5FC04", VA = "0xE5FC04")]
		public void StopBeanAttractor()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xE5FC20", Offset = "0xE5FC20", VA = "0xE5FC20")]
		public StopBeamAttractor()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.TornadoSeason.Scripts
{
	[Token(Token = "0x2000149")]
	public class Tornado : MonoBehaviour
	{
		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("How much force is applied to objects inside the tornado.")]
		private float m_Force;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("The speed at which the tornado moves.")]
		private float m_Speed;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObjectFilter m_ObjectShouldMakeSoundFilter;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Event m_SfxOnPickup;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Laser m_Laser;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly HashSet<GameObject> m_HasMakeSwoosh;

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xE5FC28", Offset = "0xE5FC28", VA = "0xE5FC28")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xE5FC78", Offset = "0xE5FC78", VA = "0xE5FC78")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xE5FF04", Offset = "0xE5FF04", VA = "0xE5FF04")]
		public Tornado()
		{
		}
	}
	[Token(Token = "0x200014A")]
	public class TornadoWaterEvaporator : MonoBehaviour
	{
		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Units per second that this object will move down while evaporating.")]
		private float m_EvaporationUnitsPerSecond;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("The position on the y axis at which this body of water is empty.")]
		private float m_EmptyLevel;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("The cloud that should be formed.")]
		private Transform m_Cloud;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Particle system that runs while the body of water is being evaporated.")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_WaterTransform;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent m_OnFullCloud;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_InitialLevel;

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xE5FFB0", Offset = "0xE5FFB0", VA = "0xE5FFB0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xE6002C", Offset = "0xE6002C", VA = "0xE6002C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xE600D8", Offset = "0xE600D8", VA = "0xE600D8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xE6018C", Offset = "0xE6018C", VA = "0xE6018C")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xE60230", Offset = "0xE60230", VA = "0xE60230")]
		private void Evaporate()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xE60380", Offset = "0xE60380", VA = "0xE60380")]
		public TornadoWaterEvaporator()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.SquareDance.Scenes.Scripts
{
	[Token(Token = "0x200014B")]
	public class Pad : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014C")]
		public class Visualization
		{
			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private MusicEventCondition m_Condition;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject[] m_CountDownObjects;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject m_ActiveObject;

			[Token(Token = "0x170000AD")]
			public MusicEventCondition condition
			{
				[Token(Token = "0x60005D5")]
				[Address(RVA = "0xE60A6C", Offset = "0xE60A6C", VA = "0xE60A6C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			public GameObject[] countDownObjects
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0xE60A74", Offset = "0xE60A74", VA = "0xE60A74")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			public GameObject activeObject
			{
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0xE60A7C", Offset = "0xE60A7C", VA = "0xE60A7C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0xE6043C", Offset = "0xE6043C", VA = "0xE6043C")]
			public void HideAllObjects()
			{
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xE60A84", Offset = "0xE60A84", VA = "0xE60A84")]
			public Visualization()
			{
			}
		}

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[OptionalReference]
		public MusicEventPosition m_Position;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_Inactive;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Visualization[] m_Visualizations;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InsideTrigger m_InsideTrigger;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onFailHit;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action onSuccessHit;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly Dictionary<MusicEventCondition, Visualization> m_VisualizationsByCondition;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IMusicEvent m_MusicEvent;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Visualization m_ActiveVisualization;

		[Token(Token = "0x170000AC")]
		public MusicEventPosition position
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xE60388", Offset = "0xE60388", VA = "0xE60388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xE60390", Offset = "0xE60390", VA = "0xE60390")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xE604B4", Offset = "0xE604B4", VA = "0xE604B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xE604B8", Offset = "0xE604B8", VA = "0xE604B8")]
		private void BackToInactive()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xE604D8", Offset = "0xE604D8", VA = "0xE604D8")]
		public void Connect(IMusicEvent musicEvent)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xE6076C", Offset = "0xE6076C", VA = "0xE6076C")]
		private void HandleOnUpdate(float relativeBeat, float relativeTime)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xE609F0", Offset = "0xE609F0", VA = "0xE609F0")]
		public Pad()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public class RiverDanceController : MonoBehaviour
	{
		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GameObject> m_PadPrefabs;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Transform> m_StartPositions;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MusicSequencer m_Sequencer;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MusicSequencerTrack m_Track;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int m_NumSuccessHits;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int m_NumAllowedFails;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent m_OnHit;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_NumFails;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_NumHits;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_NumEvents;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SubGoal m_SubGoal;

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xE60BA8", Offset = "0xE60BA8", VA = "0xE60BA8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xE60C7C", Offset = "0xE60C7C", VA = "0xE60C7C")]
		private void OnSuccessHit()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xE60CD0", Offset = "0xE60CD0", VA = "0xE60CD0")]
		private void OnFailHit()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xE60CE0", Offset = "0xE60CE0", VA = "0xE60CE0")]
		private void SequencerOnOnNewMusicEvent(IMusicEvent musicEvent)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xE610D0", Offset = "0xE610D0", VA = "0xE610D0")]
		public RiverDanceController()
		{
		}
	}
	[Token(Token = "0x2000150")]
	public class SquareDanceController : MonoBehaviour
	{
		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MusicSequencer m_Sequencer;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MusicSequencerTrack m_Track;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Pad> m_Pads;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int m_NumSuccessHits;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int m_NumAllowedFails;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent m_OnHit;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_NumFails;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int m_NumHits;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SubGoal m_SubGoal;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Dictionary<MusicEventPosition, Pad> m_PadsByPosition;

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xE61134", Offset = "0xE61134", VA = "0xE61134")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xE612B0", Offset = "0xE612B0", VA = "0xE612B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xE6144C", Offset = "0xE6144C", VA = "0xE6144C")]
		private void OnSuccessHit()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xE614A0", Offset = "0xE614A0", VA = "0xE614A0")]
		private void OnFailHit()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xE614B0", Offset = "0xE614B0", VA = "0xE614B0")]
		private void SequencerOnOnNewMusicEvent(IMusicEvent musicEvent)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xE615A4", Offset = "0xE615A4", VA = "0xE615A4")]
		public SquareDanceController()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.SheepHerding.Scripts
{
	[Token(Token = "0x2000151")]
	public class JoystickAntenna : MonoBehaviour
	{
		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_FindFirstJoystickInSituation;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideIf("m_FindFirstJoystickInSituation")]
		[SerializeField]
		[OptionalReference]
		private Joystick m_Joystick;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_TargetTransform;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_TargetScale;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_JoystickHasBeenRevealed;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[SerializeField]
		private bool m_StartAutomatically;

		[Token(Token = "0x170000B0")]
		private Joystick joystick
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xE617B0", Offset = "0xE617B0", VA = "0xE617B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xE617B8", Offset = "0xE617B8", VA = "0xE617B8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xE617C0", Offset = "0xE617C0", VA = "0xE617C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xE6184C", Offset = "0xE6184C", VA = "0xE6184C")]
		public void ShowAntenna()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xE6185C", Offset = "0xE6185C", VA = "0xE6185C")]
		private void ShowAntennaInternal()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xE61944", Offset = "0xE61944", VA = "0xE61944")]
		private void Update()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xE61AF8", Offset = "0xE61AF8", VA = "0xE61AF8")]
		public JoystickAntenna()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.SeagullCinema.Scenes.Scripts
{
	[Token(Token = "0x2000152")]
	public class FailWhenPopcornIsEmpty : MonoBehaviour, IRequireValidation
	{
		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Radius;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Situation m_Situation;

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xE61B08", Offset = "0xE61B08", VA = "0xE61B08")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xE61B58", Offset = "0xE61B58", VA = "0xE61B58")]
		private void Update()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xE61CA4", Offset = "0xE61CA4", VA = "0xE61CA4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xE61CD4", Offset = "0xE61CD4", VA = "0xE61CD4", Slot = "4")]
		public void Validate(ValidationContext context)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xE61D5C", Offset = "0xE61D5C", VA = "0xE61D5C")]
		public FailWhenPopcornIsEmpty()
		{
		}
	}
	[Token(Token = "0x2000154")]
	public class ScreenToWorldSpawner : MonoBehaviour
	{
		[Token(Token = "0x2000155")]
		[CompilerGenerated]
		private sealed class <DelayTrigger>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ScreenToWorldSpawner <>4__this;

			[Token(Token = "0x170000B1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000600")]
				[Address(RVA = "0xE622EC", Offset = "0xE622EC", VA = "0xE622EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000602")]
				[Address(RVA = "0xE62334", Offset = "0xE62334", VA = "0xE62334", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xE621E4", Offset = "0xE621E4", VA = "0xE621E4")]
			[DebuggerHidden]
			public <DelayTrigger>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xE6222C", Offset = "0xE6222C", VA = "0xE6222C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xE62230", Offset = "0xE62230", VA = "0xE62230", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0xE622F4", Offset = "0xE622F4", VA = "0xE622F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public UnityEvent<GameObject> m_OnObjectSpawned;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_OnEnoughPopcornSpawned;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Camera m_Camera;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_SpawnDistanceFromCamera;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_VelocityMultiplier;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int m_PopcornCountToWin;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_AfterWinDelay;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_DidWin;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int m_PopcornTeleported;

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xE61E58", Offset = "0xE61E58", VA = "0xE61E58")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xE6217C", Offset = "0xE6217C", VA = "0xE6217C")]
		[IteratorStateMachine(typeof(<DelayTrigger>d__10))]
		private IEnumerator DelayTrigger()
		{
			return null;
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xE6220C", Offset = "0xE6220C", VA = "0xE6220C")]
		public ScreenToWorldSpawner()
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class SeagullFollowExhaustBatObject : MonoBehaviour
	{
		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ExhaustBat m_ExhaustBat;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LookAt m_LookAtScript;

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xE6233C", Offset = "0xE6233C", VA = "0xE6233C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xE623AC", Offset = "0xE623AC", VA = "0xE623AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xE624E0", Offset = "0xE624E0", VA = "0xE624E0")]
		public SeagullFollowExhaustBatObject()
		{
		}
	}
	[Token(Token = "0x2000157")]
	public class SeagullFollowSpawnedScreenObjects : MonoBehaviour
	{
		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScreenToWorldSpawner m_Spawner;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LookAt m_LookAtScript;

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xE624E8", Offset = "0xE624E8", VA = "0xE624E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xE62590", Offset = "0xE62590", VA = "0xE62590")]
		private void LookAtObject(GameObject obj)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xE625AC", Offset = "0xE625AC", VA = "0xE625AC")]
		public SeagullFollowSpawnedScreenObjects()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class ToggleKinematic : MonoBehaviour
	{
		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody[] m_Rigidbodies;

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xE625B4", Offset = "0xE625B4", VA = "0xE625B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xE62608", Offset = "0xE62608", VA = "0xE62608")]
		public void TurnKinematicOff()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xE626B4", Offset = "0xE626B4", VA = "0xE626B4")]
		public ToggleKinematic()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.Rain
{
	[Token(Token = "0x2000159")]
	public class HowRainWorks : MonoBehaviour
	{
		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UmbrellaBatExtension m_Umbrella;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_UmbrellaTransform;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_RainAngle;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ParticleSystem.EmissionModule m_EmissionModule;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_EmissionRate;

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xE626BC", Offset = "0xE626BC", VA = "0xE626BC")]
		private void Start()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xE6284C", Offset = "0xE6284C", VA = "0xE6284C")]
		private void Update()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xE629DC", Offset = "0xE629DC", VA = "0xE629DC")]
		public HowRainWorks()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.ProtectSheep.Scripts
{
	[Token(Token = "0x200015A")]
	[RequireComponent(typeof(MoveObjectAlongSpline))]
	public class WolfInCostume : MonoBehaviour
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Delay;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The force used when removing the costume.")]
		[SerializeField]
		private float m_CostumeRemovalForce;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody m_CostumeRigidbody;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeReference]
		private GameObjectFilter m_ObjectFilter;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MoveObjectAlongSpline m_MoveObjectAlongSpline;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_HasLostCostume;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent m_OnDespawn;

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xE629F4", Offset = "0xE629F4", VA = "0xE629F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xE62ABC", Offset = "0xE62ABC", VA = "0xE62ABC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xE62B88", Offset = "0xE62B88", VA = "0xE62B88")]
		private void LoseCostume()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xE62B3C", Offset = "0xE62B3C", VA = "0xE62B3C")]
		private void Despawn()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xE62D3C", Offset = "0xE62D3C", VA = "0xE62D3C")]
		public WolfInCostume()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.Popcorn.Scenes.Scripts
{
	[Token(Token = "0x200015B")]
	public class CheckCornPopped : MonoBehaviour
	{
		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ExhaustBat m_ExhaustBat;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TriggerAfterNCalls m_Trigger;

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xE62D44", Offset = "0xE62D44", VA = "0xE62D44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xE62E2C", Offset = "0xE62E2C", VA = "0xE62E2C")]
		private void OnCornPopped(GameObject obj)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xE62E48", Offset = "0xE62E48", VA = "0xE62E48")]
		public CheckCornPopped()
		{
		}
	}
	[Token(Token = "0x200015C")]
	public class CornEar : MonoBehaviour
	{
		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_OnAllCornPopped;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_SpawnObjectOnLastCornPopped;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[ShowIf("m_SpawnObjectOnLastCornPopped")]
		[RequiredIf("m_SpawnObjectOnLastCornPopped")]
		private GameObject m_SpawnOnFinished;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_CornsLeft;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_DidFire;

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xE62E50", Offset = "0xE62E50", VA = "0xE62E50")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xE62F78", Offset = "0xE62F78", VA = "0xE62F78")]
		private void OnCornPopped(PopCorn popCorn)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xE630D0", Offset = "0xE630D0", VA = "0xE630D0")]
		public CornEar()
		{
		}
	}
	[Token(Token = "0x200015D")]
	public class PopCorn : MonoBehaviour
	{
		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Popped;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_NotPopped;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent<PopCorn> m_OnPopped;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Event m_PopSound;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PlayerElectricityNode m_PlayerRigElectricityNode;

		[Token(Token = "0x170000B3")]
		public UnityEvent<PopCorn> onPopped
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0xE630D8", Offset = "0xE630D8", VA = "0xE630D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xE630E0", Offset = "0xE630E0", VA = "0xE630E0")]
		private void Start()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xE63150", Offset = "0xE63150", VA = "0xE63150")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xE633E8", Offset = "0xE633E8", VA = "0xE633E8")]
		public PopCorn()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.MakeSheep.Scripts
{
	[Token(Token = "0x200015E")]
	public class AttachPrefabViaJoint : MonoBehaviour
	{
		[Token(Token = "0x600061E")]
		[Address(RVA = "0xE633F0", Offset = "0xE633F0", VA = "0xE633F0")]
		public void DoAttach(GameObject target)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xE6347C", Offset = "0xE6347C", VA = "0xE6347C")]
		public AttachPrefabViaJoint()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public class SheepMaker : MonoBehaviour
	{
		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeReference]
		private GameObjectFilter m_ObjectFilter;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_NumberOfHitsRequired;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] m_ObjectsToEnable;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent m_OnFullyDisguised;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_HitIndex;

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xE63484", Offset = "0xE63484", VA = "0xE63484")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xE63704", Offset = "0xE63704", VA = "0xE63704")]
		public SheepMaker()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.HiddenTrophy.Scripts
{
	[Token(Token = "0x2000160")]
	[RequireComponent(typeof(Rigidbody))]
	public class PluggableCarrot : MonoBehaviour
	{
		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_PullOutHeight;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[OptionalReference]
		private Transform m_DecoyTrophy;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[OptionalReference]
		[SerializeField]
		private Rigidbody m_TrophyRigidbody;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent m_OnPulled;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_StartHeight;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_DecoyTrophyStartPosition;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_IsPulledOut;

		[Token(Token = "0x170000B4")]
		private float currentHeightOffset
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0xE6370C", Offset = "0xE6370C", VA = "0xE6370C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xE6373C", Offset = "0xE6373C", VA = "0xE6373C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xE637E0", Offset = "0xE637E0", VA = "0xE637E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xE63830", Offset = "0xE63830", VA = "0xE63830")]
		private void Start()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xE63880", Offset = "0xE63880", VA = "0xE63880")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xE63A1C", Offset = "0xE63A1C", VA = "0xE63A1C")]
		public PluggableCarrot()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.FishingWithDynamite.Scripts
{
	[Token(Token = "0x2000161")]
	public class CraneController : MonoBehaviour
	{
		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ContinuousLever m_Lever;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ConfigurableJoint m_HookJoint;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_CogTransform;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_CogRotationSpeed;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_MaxLimit;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_TimeBetweenRumble;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_RumbleStrengthMultiplier;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_PreviousLineLength;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_CraneIsOn;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_TimeToNextRumbleImpact;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Bat m_CurrentBat;

		[Token(Token = "0x170000B5")]
		public GameObject hook
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0xE63A2C", Offset = "0xE63A2C", VA = "0xE63A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		public float lineLength
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0xE63A48", Offset = "0xE63A48", VA = "0xE63A48")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xE63A8C", Offset = "0xE63A8C", VA = "0xE63A8C")]
		public void SetCurrentBat(GameObject b)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xE63AE8", Offset = "0xE63AE8", VA = "0xE63AE8")]
		private void Update()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xE63DE4", Offset = "0xE63DE4", VA = "0xE63DE4")]
		public void SetLineLength(float length)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xE63D4C", Offset = "0xE63D4C", VA = "0xE63D4C")]
		private void SetRumble(float strength)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xE63E68", Offset = "0xE63E68", VA = "0xE63E68")]
		public CraneController()
		{
		}
	}
	[Token(Token = "0x2000162")]
	public class EmptyLakeSequence : MonoBehaviour
	{
		[Token(Token = "0x2000163")]
		[CompilerGenerated]
		private sealed class <SequenceCoroutine>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EmptyLakeSequence <>4__this;

			[Token(Token = "0x170000B7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000640")]
				[Address(RVA = "0xE646D4", Offset = "0xE646D4", VA = "0xE646D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000642")]
				[Address(RVA = "0xE6471C", Offset = "0xE6471C", VA = "0xE6471C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0xE64130", Offset = "0xE64130", VA = "0xE64130")]
			[DebuggerHidden]
			public <SequenceCoroutine>d__25(int <>1__state)
			{
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0xE64578", Offset = "0xE64578", VA = "0xE64578", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0xE6457C", Offset = "0xE6457C", VA = "0xE6457C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0xE646DC", Offset = "0xE646DC", VA = "0xE646DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000164")]
		[CompilerGenerated]
		private sealed class <WaitForHookUnderWater>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EmptyLakeSequence <>4__this;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000646")]
				[Address(RVA = "0xE64784", Offset = "0xE64784", VA = "0xE64784", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000648")]
				[Address(RVA = "0xE647CC", Offset = "0xE647CC", VA = "0xE647CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0xE641C0", Offset = "0xE641C0", VA = "0xE641C0")]
			[DebuggerHidden]
			public <WaitForHookUnderWater>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0xE64724", Offset = "0xE64724", VA = "0xE64724", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0xE64728", Offset = "0xE64728", VA = "0xE64728", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0xE6478C", Offset = "0xE6478C", VA = "0xE6478C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000165")]
		[CompilerGenerated]
		private sealed class <WaitForPlayerTryingToLiftHook>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EmptyLakeSequence <>4__this;

			[Token(Token = "0x170000BB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600064C")]
				[Address(RVA = "0xE64904", Offset = "0xE64904", VA = "0xE64904", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600064E")]
				[Address(RVA = "0xE6494C", Offset = "0xE6494C", VA = "0xE6494C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0xE64250", Offset = "0xE64250", VA = "0xE64250")]
			[DebuggerHidden]
			public <WaitForPlayerTryingToLiftHook>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0xE647D4", Offset = "0xE647D4", VA = "0xE647D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0xE647D8", Offset = "0xE647D8", VA = "0xE647D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0xE6490C", Offset = "0xE6490C", VA = "0xE6490C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000166")]
		[CompilerGenerated]
		private sealed class <LiftDrainStopOutOfLake>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EmptyLakeSequence <>4__this;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <timeToLift>5__2;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <t>5__3;

			[Token(Token = "0x170000BD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000652")]
				[Address(RVA = "0xE64B70", Offset = "0xE64B70", VA = "0xE64B70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000654")]
				[Address(RVA = "0xE64BB8", Offset = "0xE64BB8", VA = "0xE64BB8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0xE642E0", Offset = "0xE642E0", VA = "0xE642E0")]
			[DebuggerHidden]
			public <LiftDrainStopOutOfLake>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0xE64954", Offset = "0xE64954", VA = "0xE64954", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0xE64958", Offset = "0xE64958", VA = "0xE64958", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0xE64B78", Offset = "0xE64B78", VA = "0xE64B78", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000167")]
		[CompilerGenerated]
		private sealed class <EmptyTheLake>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EmptyLakeSequence <>4__this;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <timeToEmpty>5__2;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000658")]
				[Address(RVA = "0xE64E10", Offset = "0xE64E10", VA = "0xE64E10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600065A")]
				[Address(RVA = "0xE64E58", Offset = "0xE64E58", VA = "0xE64E58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0xE64370", Offset = "0xE64370", VA = "0xE64370")]
			[DebuggerHidden]
			public <EmptyTheLake>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0xE64BC0", Offset = "0xE64BC0", VA = "0xE64BC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0xE64BC4", Offset = "0xE64BC4", VA = "0xE64BC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0xE64E18", Offset = "0xE64E18", VA = "0xE64E18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CraneController m_Crane;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ContinuousLever m_Lever;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_DrainStop;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer m_WaterPlaneMeshRenderer;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ParticleSystem m_ExitWaterParticleSystem;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ParticleSystem[] m_SmokeParticleSystems;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Parameters")]
		[SerializeField]
		private float m_CraneShakeStrength;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_ShakeSpeed;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_EmptyTheLakeTime;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_EmptyLakeDistance;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Header("Curves")]
		private AnimationCurve m_EmptyLakeCurve;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("SFX")]
		[SerializeField]
		private Event m_CraneBreakStart;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Event m_CraneBreakStop;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Event m_DrainWaterStart;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Event m_DrainWaterStop;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Event m_OnPlugPulledSfx;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RTPC m_WaterDrainRTPC;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material m_WaterMaterial;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float m_RotationSpeed;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float m_Rotation;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Bat m_CurrentBat;

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xE63E7C", Offset = "0xE63E7C", VA = "0xE63E7C")]
		public void SetCurrentBat(GameObject b)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xE63ED8", Offset = "0xE63ED8", VA = "0xE63ED8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xE63FF0", Offset = "0xE63FF0", VA = "0xE63FF0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xE63F00", Offset = "0xE63F00", VA = "0xE63F00")]
		private void InitializeSequence()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xE63F88", Offset = "0xE63F88", VA = "0xE63F88")]
		[IteratorStateMachine(typeof(<SequenceCoroutine>d__25))]
		private IEnumerator SequenceCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xE64158", Offset = "0xE64158", VA = "0xE64158")]
		[IteratorStateMachine(typeof(<WaitForHookUnderWater>d__26))]
		private IEnumerator WaitForHookUnderWater()
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xE641E8", Offset = "0xE641E8", VA = "0xE641E8")]
		[IteratorStateMachine(typeof(<WaitForPlayerTryingToLiftHook>d__27))]
		private IEnumerator WaitForPlayerTryingToLiftHook()
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xE64278", Offset = "0xE64278", VA = "0xE64278")]
		[IteratorStateMachine(typeof(<LiftDrainStopOutOfLake>d__28))]
		private IEnumerator LiftDrainStopOutOfLake()
		{
			return null;
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xE64308", Offset = "0xE64308", VA = "0xE64308")]
		[IteratorStateMachine(typeof(<EmptyTheLake>d__29))]
		private IEnumerator EmptyTheLake()
		{
			return null;
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xE64398", Offset = "0xE64398", VA = "0xE64398")]
		private void ShakeCrane(float strength)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xE6406C", Offset = "0xE6406C", VA = "0xE6406C")]
		private void SetSmokeStrength(float strength)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xE644B0", Offset = "0xE644B0", VA = "0xE644B0")]
		private void SetRumble(float strength)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xE64548", Offset = "0xE64548", VA = "0xE64548")]
		private static float Map(float value, float fromLow, float fromHigh, float toLow, float toHigh)
		{
			return default(float);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xE64564", Offset = "0xE64564", VA = "0xE64564")]
		public EmptyLakeSequence()
		{
		}
	}
	[Token(Token = "0x2000168")]
	[RequireComponent(typeof(MoveObjectAlongSpline))]
	[RequireComponent(typeof(SubGoal))]
	public class FishOnPath : MonoBehaviour
	{
		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeReference]
		private GameObjectFilter[] m_GameObjectFilters;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_Animator;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent m_OnCaught;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ObjectSwapper m_FishEyeSwapper;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MoveObjectAlongSpline m_MoveObjectAlongSpline;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SubGoal m_SubGoal;

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xE64E60", Offset = "0xE64E60", VA = "0xE64E60")]
		private void Awake()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xE64EDC", Offset = "0xE64EDC", VA = "0xE64EDC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xE64F30", Offset = "0xE64F30", VA = "0xE64F30")]
		private void Catch()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xE65028", Offset = "0xE65028", VA = "0xE65028")]
		public FishOnPath()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public class SplashTrigger : MonoBehaviour
	{
		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem m_SplashVFX;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Event m_SplashSFX;

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xE65050", Offset = "0xE65050", VA = "0xE65050")]
		public void Trigger(GameObject target)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xE6510C", Offset = "0xE6510C", VA = "0xE6510C")]
		public SplashTrigger()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.Fertilizer.Scripts
{
	[Token(Token = "0x200016A")]
	public class GrowableTag : MonoBehaviour
	{
		[Token(Token = "0x6000662")]
		[Address(RVA = "0xE65114", Offset = "0xE65114", VA = "0xE65114")]
		public GrowableTag()
		{
		}
	}
	[Token(Token = "0x200016B")]
	public class PumpkinSizeCompetition : MonoBehaviour
	{
		[Token(Token = "0x200016C")]
		[CompilerGenerated]
		private sealed class <SwapWinnersAndCompleteSituation>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PumpkinSizeCompetition <>4__this;

			[Token(Token = "0x170000C1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600066B")]
				[Address(RVA = "0xE65440", Offset = "0xE65440", VA = "0xE65440", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600066D")]
				[Address(RVA = "0xE65488", Offset = "0xE65488", VA = "0xE65488", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0xE652C4", Offset = "0xE652C4", VA = "0xE652C4")]
			[DebuggerHidden]
			public <SwapWinnersAndCompleteSituation>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0xE652F4", Offset = "0xE652F4", VA = "0xE652F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0xE652F8", Offset = "0xE652F8", VA = "0xE652F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0xE65448", Offset = "0xE65448", VA = "0xE65448", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_PlayersPumpkin;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_OpponentsPumpkin;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] m_PlayersTrophyObjects;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] m_OpponentsTrophyObjects;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject m_DespawnEffect;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_PlayerHasBiggestPumpkin;

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xE6511C", Offset = "0xE6511C", VA = "0xE6511C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xE651C0", Offset = "0xE651C0", VA = "0xE651C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xE6525C", Offset = "0xE6525C", VA = "0xE6525C")]
		[IteratorStateMachine(typeof(<SwapWinnersAndCompleteSituation>d__8))]
		private IEnumerator SwapWinnersAndCompleteSituation()
		{
			return null;
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xE65158", Offset = "0xE65158", VA = "0xE65158")]
		private static void SetActiveTrophyObjects(GameObject[] trophyObjects, bool state)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xE652EC", Offset = "0xE652EC", VA = "0xE652EC")]
		public PumpkinSizeCompetition()
		{
		}
	}
	[Token(Token = "0x200016D")]
	public class SetLauncherBatPrefab : MonoBehaviour
	{
		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Prefab;

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xE65490", Offset = "0xE65490", VA = "0xE65490")]
		private void Start()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xE65540", Offset = "0xE65540", VA = "0xE65540")]
		public SetLauncherBatPrefab()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.ApplePicking.Scripts
{
	[Token(Token = "0x200016E")]
	public class MoveAppleOnBranchWithLever : MonoBehaviour
	{
		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 m_Axis;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_StartOffset;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_EndOffset;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Tooltip("Meters pr. second.")]
		private float m_Speed;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ContinuousLever m_Lever;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPosition;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_EndPosition;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_NormalizedPosition;

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xE655C4", Offset = "0xE655C4", VA = "0xE655C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xE65664", Offset = "0xE65664", VA = "0xE65664")]
		private Vector3 CalculateLocalPosition(float offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xE656B8", Offset = "0xE656B8", VA = "0xE656B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xE65768", Offset = "0xE65768", VA = "0xE65768")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xE658C0", Offset = "0xE658C0", VA = "0xE658C0")]
		public MoveAppleOnBranchWithLever()
		{
		}
	}
	[Token(Token = "0x200016F")]
	public class PickableApple : MonoBehaviour
	{
		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_HitGround;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_HitUniversal;

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xE658C8", Offset = "0xE658C8", VA = "0xE658C8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xE65A1C", Offset = "0xE65A1C", VA = "0xE65A1C")]
		public PickableApple()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public class StickRigidbody : MonoBehaviour
	{
		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeReference]
		private GameObjectFilter m_Filter;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_SetKinematicTo;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool m_CanCollide;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_IgnoreTime;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_UseTrigger;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioEvent m_AudioEvent;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MultiSubGoal m_MultiSubGoal;

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xE65A24", Offset = "0xE65A24", VA = "0xE65A24")]
		private void Start()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xE65ABC", Offset = "0xE65ABC", VA = "0xE65ABC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xE65B00", Offset = "0xE65B00", VA = "0xE65B00")]
		private void HandleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xE65CFC", Offset = "0xE65CFC", VA = "0xE65CFC")]
		public StickRigidbody()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.FarmingFarming.Scripts
{
	[Token(Token = "0x2000171")]
	public class GrowTree : MonoBehaviour
	{
		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Game Objects")]
		private GameObject m_Sprout;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_Tree;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("Animation")]
		private Animator m_Animator;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_AnimatorIntName;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_GrowCoolDown;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Header("Misc")]
		private MultiSubGoal m_Goal;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeReference]
		private GameObjectFilter m_CollisionFilter;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent m_OnGrowing;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_Step;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float m_TimeSinceLastGrown;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ColorRemapEffect[] m_TreeRemapEffects;

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xE65D1C", Offset = "0xE65D1C", VA = "0xE65D1C")]
		private void Start()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xE65DA0", Offset = "0xE65DA0", VA = "0xE65DA0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xE65E18", Offset = "0xE65E18", VA = "0xE65E18")]
		public void Grow()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xE65F2C", Offset = "0xE65F2C", VA = "0xE65F2C")]
		public GrowTree()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.CowTipping
{
	[Token(Token = "0x2000172")]
	public class TippableCow : MonoBehaviour
	{
		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[OptionalReference]
		[SerializeField]
		private MoveObjectAlongSpline m_ObjectMover;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody m_Rb;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Collider> m_LegCollidersOfCow;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_Force;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool m_Left;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool m_Move;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool tipped;

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xE65F3C", Offset = "0xE65F3C", VA = "0xE65F3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xE65FD4", Offset = "0xE65FD4", VA = "0xE65FD4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xE660D8", Offset = "0xE660D8", VA = "0xE660D8")]
		private void StopMoving()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xE66104", Offset = "0xE66104", VA = "0xE66104")]
		private void Tip()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xE66368", Offset = "0xE66368", VA = "0xE66368")]
		public TippableCow()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.CountingSheep.Scripts
{
	[Token(Token = "0x2000173")]
	public class CountingSheep : MonoBehaviour
	{
		[Token(Token = "0x2000174")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Sheep sheep;

			[Token(Token = "0x600068C")]
			[Address(RVA = "0xE664E0", Offset = "0xE664E0", VA = "0xE664E0")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0xE664E8", Offset = "0xE664E8", VA = "0xE664E8")]
			internal void <Start>b__2()
			{
			}
		}

		[Token(Token = "0x2000175")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_1
		{
			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool sheepArrived;

			[Token(Token = "0x600068E")]
			[Address(RVA = "0xE66504", Offset = "0xE66504", VA = "0xE66504")]
			public <>c__DisplayClass7_1()
			{
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0xE6650C", Offset = "0xE6650C", VA = "0xE6650C")]
			internal void <Start>b__1()
			{
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0xE66518", Offset = "0xE66518", VA = "0xE66518")]
			internal bool <Start>b__3()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000176")]
		[CompilerGenerated]
		private sealed class <Start>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CountingSheep <>4__this;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass7_1 <>8__1;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass7_0 <>8__2;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Sheep[] <>7__wrap1;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <>7__wrap2;

			[Token(Token = "0x170000C3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000694")]
				[Address(RVA = "0xE668A8", Offset = "0xE668A8", VA = "0xE668A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000696")]
				[Address(RVA = "0xE668F0", Offset = "0xE668F0", VA = "0xE668F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0xE6649C", Offset = "0xE6649C", VA = "0xE6649C")]
			[DebuggerHidden]
			public <Start>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0xE66520", Offset = "0xE66520", VA = "0xE66520", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0xE66524", Offset = "0xE66524", VA = "0xE66524", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0xE668B0", Offset = "0xE668B0", VA = "0xE668B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_SheepEndPosition;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sheep[] m_Sheep;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonTrigger m_NextSheepButton;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ButtonTrigger m_JumpButton;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_ButtonPressed;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Situation m_Situation;

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xE66370", Offset = "0xE66370", VA = "0xE66370")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xE66434", Offset = "0xE66434", VA = "0xE66434")]
		[IteratorStateMachine(typeof(<Start>d__7))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xE664C4", Offset = "0xE664C4", VA = "0xE664C4")]
		public CountingSheep()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.CollectEggs.Scripts
{
	[Token(Token = "0x2000177")]
	public class SpriteColourChanger : MonoBehaviour
	{
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpriteRenderer[] m_SpriteRenderers;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color m_ColourToChangeTo;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_NextItem;

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xE668F8", Offset = "0xE668F8", VA = "0xE668F8")]
		public void ChangeColour()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xE66958", Offset = "0xE66958", VA = "0xE66958")]
		public SpriteColourChanger()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Farming.CollectEggs.Scenes
{
	[Token(Token = "0x2000178")]
	public class ChickenTransformer : MonoBehaviour
	{
		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClockCounter m_Counter;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> m_GameObjects;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_StartOffset;

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xE66960", Offset = "0xE66960", VA = "0xE66960")]
		private void Start()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xE66B3C", Offset = "0xE66B3C", VA = "0xE66B3C")]
		private void OnClockUpdatedAction(int obj)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xE66CCC", Offset = "0xE66CCC", VA = "0xE66CCC")]
		public ChickenTransformer()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class ClockCounter : MonoBehaviour
	{
		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_Arm;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_PAngle;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CAngle;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_OnClockUpdated;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<int> onClockUpdatedAction;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int m_Counter;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int m_Min;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int m_Max;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_IsInitialized;

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xE66D80", Offset = "0xE66D80", VA = "0xE66D80")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xE66DF0", Offset = "0xE66DF0", VA = "0xE66DF0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xE66EB8", Offset = "0xE66EB8", VA = "0xE66EB8")]
		public void OnArmEnter()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xE67024", Offset = "0xE67024", VA = "0xE67024")]
		public ClockCounter()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Fantasy.UnicornRider.Scripts
{
	[Token(Token = "0x200017B")]
	public class AssignObjectToLookAt : MonoBehaviour
	{
		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LookAt m_LookAtScript;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_Obj;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_AssignOnStart;

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xE6702C", Offset = "0xE6702C", VA = "0xE6702C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xE67060", Offset = "0xE67060", VA = "0xE67060")]
		public AssignObjectToLookAt()
		{
		}
	}
	[Token(Token = "0x200017C")]
	public class AssignObjectToMoveTowards : MonoBehaviour
	{
		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MoveTowardsConstantSpeed m_MoveTo;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_ObjName;

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xE67068", Offset = "0xE67068", VA = "0xE67068")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xE6709C", Offset = "0xE6709C", VA = "0xE6709C")]
		public AssignObjectToMoveTowards()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Fantasy.UnicornFactory.Scripts
{
	[Token(Token = "0x200017D")]
	public class FactoryController : MonoBehaviour
	{
		[Token(Token = "0x200017E")]
		[CompilerGenerated]
		private sealed class <StartBelt>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FactoryController <>4__this;

			[Token(Token = "0x170000C5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006B3")]
				[Address(RVA = "0xE675F8", Offset = "0xE675F8", VA = "0xE675F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006B5")]
				[Address(RVA = "0xE67640", Offset = "0xE67640", VA = "0xE67640", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xE67504", Offset = "0xE67504", VA = "0xE67504")]
			[DebuggerHidden]
			public <StartBelt>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xE6753C", Offset = "0xE6753C", VA = "0xE6753C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0xE67540", Offset = "0xE67540", VA = "0xE67540", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0xE67600", Offset = "0xE67600", VA = "0xE67600", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_ConveyerBelt;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_Trophy;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_UnkinematicObjects;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_BeltMoving;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool m_TrophyArrived;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<GameObject> m_FactoryObjects;

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xE670A4", Offset = "0xE670A4", VA = "0xE670A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xE67118", Offset = "0xE67118", VA = "0xE67118")]
		private void Update()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xE67200", Offset = "0xE67200", VA = "0xE67200")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xE673E4", Offset = "0xE673E4", VA = "0xE673E4")]
		public void SetMoveSpeed(float moveSpeed)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xE673EC", Offset = "0xE673EC", VA = "0xE673EC")]
		public void SendNextObject(float delay = 0f)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xE67494", Offset = "0xE67494", VA = "0xE67494")]
		public void ClearSavedObjects()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xE6741C", Offset = "0xE6741C", VA = "0xE6741C")]
		[IteratorStateMachine(typeof(<StartBelt>d__13))]
		private IEnumerator StartBelt(float delay)
		{
			return null;
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xE6752C", Offset = "0xE6752C", VA = "0xE6752C")]
		public FactoryController()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public class UnhornedUnicorn : MonoBehaviour
	{
		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[OptionalReference]
		private SubGoal m_SubGoal;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_OnHorned;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<GameObject> m_Horns;

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xE67648", Offset = "0xE67648", VA = "0xE67648")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xE67950", Offset = "0xE67950", VA = "0xE67950")]
		public UnhornedUnicorn()
		{
		}
	}
	[Token(Token = "0x2000180")]
	public class UnicornFactorySit1 : MonoBehaviour
	{
		[Token(Token = "0x2000181")]
		[CompilerGenerated]
		private sealed class <DelayedStart>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UnicornFactorySit1 <>4__this;

			[Token(Token = "0x170000C7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006BE")]
				[Address(RVA = "0xE67B64", Offset = "0xE67B64", VA = "0xE67B64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006C0")]
				[Address(RVA = "0xE67BAC", Offset = "0xE67BAC", VA = "0xE67BAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0xE67A78", Offset = "0xE67A78", VA = "0xE67A78")]
			[DebuggerHidden]
			public <DelayedStart>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xE67AA8", Offset = "0xE67AA8", VA = "0xE67AA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0xE67AAC", Offset = "0xE67AAC", VA = "0xE67AAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0xE67B6C", Offset = "0xE67B6C", VA = "0xE67B6C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_OnDelayEnd;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_DelayStarted;

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xE679CC", Offset = "0xE679CC", VA = "0xE679CC")]
		public void ButtonPressed(float delay)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xE67A00", Offset = "0xE67A00", VA = "0xE67A00")]
		[IteratorStateMachine(typeof(<DelayedStart>d__3))]
		private IEnumerator DelayedStart(float delay)
		{
			return null;
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xE67AA0", Offset = "0xE67AA0", VA = "0xE67AA0")]
		public UnicornFactorySit1()
		{
		}
	}
	[Token(Token = "0x2000182")]
	public class UnicornFactorySit2 : MonoBehaviour
	{
		[Token(Token = "0x2000183")]
		[CompilerGenerated]
		private sealed class <DelayedInvoke>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnicornFactorySit2 <>4__this;

			[Token(Token = "0x170000C9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006C7")]
				[Address(RVA = "0xE67F60", Offset = "0xE67F60", VA = "0xE67F60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006C9")]
				[Address(RVA = "0xE67FA8", Offset = "0xE67FA8", VA = "0xE67FA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0xE67E68", Offset = "0xE67E68", VA = "0xE67E68")]
			[DebuggerHidden]
			public <DelayedInvoke>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0xE67EB0", Offset = "0xE67EB0", VA = "0xE67EB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0xE67EB4", Offset = "0xE67EB4", VA = "0xE67EB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0xE67F68", Offset = "0xE67F68", VA = "0xE67F68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Elephant;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_Interactable;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_RespawnPos;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FactoryController m_FactoryController;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ParticleSystem[] m_SmokeParticles;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Event m_ExplosionSFX;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEvent m_OnExplosion;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly float m_MoveSpeedThreshold;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private readonly int m_CyclesToDo;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_BeltMoveSpeed;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float m_MoveSpeedIncrease;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_ElephantCycles;

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xE67BB4", Offset = "0xE67BB4", VA = "0xE67BB4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xE67E00", Offset = "0xE67E00", VA = "0xE67E00")]
		[IteratorStateMachine(typeof(<DelayedInvoke>d__13))]
		private IEnumerator DelayedInvoke()
		{
			return null;
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xE67E90", Offset = "0xE67E90", VA = "0xE67E90")]
		public UnicornFactorySit2()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Fantasy.Smithing.Scripts
{
	[Token(Token = "0x2000184")]
	public class SmithableBat : MonoBehaviour
	{
		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_RawBlock;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_OneHitBlock;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_TwoHitBlock;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_SmithCooldown;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ParticleSystem m_SmithParticles;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public UnityEvent m_OnSmithed;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_NextSmithing;

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xE67FB0", Offset = "0xE67FB0", VA = "0xE67FB0")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xE68108", Offset = "0xE68108", VA = "0xE68108")]
		private void PlayParticles()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xE6818C", Offset = "0xE6818C", VA = "0xE6818C")]
		public SmithableBat()
		{
		}
	}
	[Token(Token = "0x2000185")]
	public class SmithYourself : MonoBehaviour
	{
		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_OnSelfSmithed;

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xE6819C", Offset = "0xE6819C", VA = "0xE6819C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xE68290", Offset = "0xE68290", VA = "0xE68290")]
		private void OnSmithed()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xE682AC", Offset = "0xE682AC", VA = "0xE682AC")]
		public SmithYourself()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Fantasy.MagicWandAmericanFootball.Scripts
{
	[Token(Token = "0x2000186")]
	public class AmericanFootball : MonoBehaviour
	{
		[Token(Token = "0x2000187")]
		[CompilerGenerated]
		private sealed class <DelayedRespawn>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AmericanFootball <>4__this;

			[Token(Token = "0x170000CB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006D9")]
				[Address(RVA = "0xE68770", Offset = "0xE68770", VA = "0xE68770", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006DB")]
				[Address(RVA = "0xE687B8", Offset = "0xE687B8", VA = "0xE687B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0xE685D4", Offset = "0xE685D4", VA = "0xE685D4")]
			[DebuggerHidden]
			public <DelayedRespawn>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0xE68604", Offset = "0xE68604", VA = "0xE68604", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0xE68608", Offset = "0xE68608", VA = "0xE68608", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0xE68778", Offset = "0xE68778", VA = "0xE68778", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_OnThrown;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 m_OriginalPosition;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody m_Rb;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_Thrown;

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xE682B4", Offset = "0xE682B4", VA = "0xE682B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xE68340", Offset = "0xE68340", VA = "0xE68340")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xE684E0", Offset = "0xE684E0", VA = "0xE684E0")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xE68578", Offset = "0xE68578", VA = "0xE68578")]
		private void OnThrow(GameObject obj)
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xE68510", Offset = "0xE68510", VA = "0xE68510")]
		[IteratorStateMachine(typeof(<DelayedRespawn>d__9))]
		private IEnumerator DelayedRespawn()
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xE685FC", Offset = "0xE685FC", VA = "0xE685FC")]
		public AmericanFootball()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Fantasy.DragonFight.Scripts
{
	[Token(Token = "0x2000188")]
	public class Fireball : MonoBehaviour
	{
		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MaxBounceForce;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_BounceForceSpeed;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_BounceForce;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_ForceIncreasing;

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xE697C0", Offset = "0xE697C0", VA = "0xE697C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xE69808", Offset = "0xE69808", VA = "0xE69808")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xE6980C", Offset = "0xE6980C", VA = "0xE6980C")]
		private void Bouncing()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xE698D0", Offset = "0xE698D0", VA = "0xE698D0")]
		public Fireball()
		{
		}
	}
	[Token(Token = "0x2000189")]
	public class FireDragon : MonoBehaviour
	{
		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Fireball;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_ShootForce;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_ShootCooldown;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_FirstShotDelay;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_FireballSpawnPosition;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Event m_FireballShootSFX;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform[] m_Targets;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 m_SpawnPos;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_NextShoot;

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xE698E8", Offset = "0xE698E8", VA = "0xE698E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xE69914", Offset = "0xE69914", VA = "0xE69914")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xE69938", Offset = "0xE69938", VA = "0xE69938")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xE69980", Offset = "0xE69980", VA = "0xE69980")]
		private void ShootFireball()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xE69B48", Offset = "0xE69B48", VA = "0xE69B48")]
		private Vector3 GetDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xE69C80", Offset = "0xE69C80", VA = "0xE69C80")]
		public FireDragon()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.WhatsGotTalent.Scripts
{
	[Token(Token = "0x200018A")]
	public interface IWGTPerformance
	{
		[Token(Token = "0x60006E6")]
		void StartPerformance();

		[Token(Token = "0x60006E7")]
		void StopPerformance(bool goldenBuzzer);
	}
	[Token(Token = "0x200018B")]
	public class SeagullDrummer : MonoBehaviour
	{
		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Playing;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int Count;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("container")]
		[SerializeField]
		private SeagullDrummers m_Container;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Event m_AudioEvent;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator m_Animator;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Playing;

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xE69C9C", Offset = "0xE69C9C", VA = "0xE69C9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xE69CEC", Offset = "0xE69CEC", VA = "0xE69CEC")]
		public void PlaySound()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xE69DBC", Offset = "0xE69DBC", VA = "0xE69DBC")]
		public void StartPlaying()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xE69E38", Offset = "0xE69E38", VA = "0xE69E38")]
		public void StopPlaying()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xE69EB0", Offset = "0xE69EB0", VA = "0xE69EB0")]
		public void StartCount()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xE69F34", Offset = "0xE69F34", VA = "0xE69F34")]
		public void EndCount()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xE69D80", Offset = "0xE69D80", VA = "0xE69D80")]
		private void ChangePlaySpeed()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xE69F68", Offset = "0xE69F68", VA = "0xE69F68")]
		public SeagullDrummer()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public class SeagullDrummers : MonoBehaviour, IWGTPerformance
	{
		[Token(Token = "0x200018D")]
		[CompilerGenerated]
		private sealed class <PerformanceDuration>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float seconds;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SeagullDrummers <>4__this;

			[Token(Token = "0x170000CD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0xE6A354", Offset = "0xE6A354", VA = "0xE6A354", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006FC")]
				[Address(RVA = "0xE6A39C", Offset = "0xE6A39C", VA = "0xE6A39C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0xE6A0FC", Offset = "0xE6A0FC", VA = "0xE6A0FC")]
			[DebuggerHidden]
			public <PerformanceDuration>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xE6A1A0", Offset = "0xE6A1A0", VA = "0xE6A1A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xE6A1A4", Offset = "0xE6A1A4", VA = "0xE6A1A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0xE6A35C", Offset = "0xE6A35C", VA = "0xE6A35C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SeagullDrummer[] m_SeagullDrummers;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SeagullDrummer m_LeadDrummer;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WGTController m_Controller;

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xE69F64", Offset = "0xE69F64", VA = "0xE69F64")]
		public void CountDone()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xE6A00C", Offset = "0xE6A00C", VA = "0xE6A00C")]
		private void EveryonePlay()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xE6A084", Offset = "0xE6A084", VA = "0xE6A084")]
		[IteratorStateMachine(typeof(<PerformanceDuration>d__5))]
		private IEnumerator PerformanceDuration(float seconds)
		{
			return null;
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xE6A124", Offset = "0xE6A124", VA = "0xE6A124", Slot = "4")]
		public void StartPerformance()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xE6A13C", Offset = "0xE6A13C", VA = "0xE6A13C", Slot = "5")]
		public void StopPerformance(bool goldenBuzzer)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xE6A198", Offset = "0xE6A198", VA = "0xE6A198")]
		public SeagullDrummers()
		{
		}
	}
	[Token(Token = "0x200018E")]
	public class SimpleSpawnEffect : MonoBehaviour
	{
		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_ObjectSpawnEffectPrefab;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("This will play the effect on start. Good for testing the scale and position")]
		private bool m_PlayOnStart;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_SpawnEffectScale;

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xE6A3A4", Offset = "0xE6A3A4", VA = "0xE6A3A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xE6A3B4", Offset = "0xE6A3B4", VA = "0xE6A3B4")]
		public void SpawnObject()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xE6A510", Offset = "0xE6A510", VA = "0xE6A510")]
		public SimpleSpawnEffect()
		{
		}
	}
	[Token(Token = "0x200018F")]
	public class SingingFish : MonoBehaviour, IWGTPerformance
	{
		[Token(Token = "0x2000190")]
		[CompilerGenerated]
		private sealed class <DelayedSinging>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SingingFish <>4__this;

			[Token(Token = "0x170000CF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600070E")]
				[Address(RVA = "0xE6AAC8", Offset = "0xE6AAC8", VA = "0xE6AAC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000710")]
				[Address(RVA = "0xE6AB10", Offset = "0xE6AB10", VA = "0xE6AB10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0xE6A860", Offset = "0xE6A860", VA = "0xE6A860")]
			[DebuggerHidden]
			public <DelayedSinging>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0xE6A9E0", Offset = "0xE6A9E0", VA = "0xE6A9E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0xE6A9E4", Offset = "0xE6A9E4", VA = "0xE6A9E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0xE6AAD0", Offset = "0xE6AAD0", VA = "0xE6AAD0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000191")]
		[CompilerGenerated]
		private sealed class <StopSinging>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SingingFish <>4__this;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool goldenBuzzer;

			[Token(Token = "0x170000D1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000714")]
				[Address(RVA = "0xE6AC60", Offset = "0xE6AC60", VA = "0xE6AC60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000716")]
				[Address(RVA = "0xE6ACA8", Offset = "0xE6ACA8", VA = "0xE6ACA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0xE6A904", Offset = "0xE6A904", VA = "0xE6A904")]
			[DebuggerHidden]
			public <StopSinging>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0xE6AB18", Offset = "0xE6AB18", VA = "0xE6AB18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0xE6AB1C", Offset = "0xE6AB1C", VA = "0xE6AB1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0xE6AC68", Offset = "0xE6AC68", VA = "0xE6AC68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007A4")]
		private const int kSongLoopsToDo = 2;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Singing;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Event[] m_ChickenSounds;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WGTController m_WGTController;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator m_Animator;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody[] m_Rbs;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_SongLoopsDone;

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xE6A520", Offset = "0xE6A520", VA = "0xE6A520")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xE6A59C", Offset = "0xE6A59C", VA = "0xE6A59C")]
		public void PlayLowNote()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xE6A62C", Offset = "0xE6A62C", VA = "0xE6A62C")]
		public void PlayMidNote()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xE6A6C0", Offset = "0xE6A6C0", VA = "0xE6A6C0")]
		public void PlayHighNote()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xE6A754", Offset = "0xE6A754", VA = "0xE6A754")]
		public void SongLoopDone()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xE6A7F8", Offset = "0xE6A7F8", VA = "0xE6A7F8")]
		[IteratorStateMachine(typeof(<DelayedSinging>d__12))]
		private IEnumerator DelayedSinging()
		{
			return null;
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xE6A888", Offset = "0xE6A888", VA = "0xE6A888")]
		[IteratorStateMachine(typeof(<StopSinging>d__13))]
		private IEnumerator StopSinging(bool goldenBuzzer)
		{
			return null;
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xE6A92C", Offset = "0xE6A92C", VA = "0xE6A92C", Slot = "4")]
		public void StartPerformance()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xE6A94C", Offset = "0xE6A94C", VA = "0xE6A94C", Slot = "5")]
		public void StopPerformance(bool goldenBuzzer)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xE6A970", Offset = "0xE6A970", VA = "0xE6A970")]
		public SingingFish()
		{
		}
	}
	[Token(Token = "0x2000192")]
	public class WGTBat : MonoBehaviour
	{
		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_NextAudio;

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xE6ACB0", Offset = "0xE6ACB0", VA = "0xE6ACB0")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xE6AD68", Offset = "0xE6AD68", VA = "0xE6AD68")]
		public WGTBat()
		{
		}
	}
	[Token(Token = "0x2000193")]
	public class WGTButton : MonoBehaviour
	{
		[Token(Token = "0x2000194")]
		[CompilerGenerated]
		private sealed class <DelayedDeactivation>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WGTButton <>4__this;

			[Token(Token = "0x170000D3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000721")]
				[Address(RVA = "0xE6B088", Offset = "0xE6B088", VA = "0xE6B088", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000723")]
				[Address(RVA = "0xE6B0D0", Offset = "0xE6B0D0", VA = "0xE6B0D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0xE6AF4C", Offset = "0xE6AF4C", VA = "0xE6AF4C")]
			[DebuggerHidden]
			public <DelayedDeactivation>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0xE6AF84", Offset = "0xE6AF84", VA = "0xE6AF84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0xE6AF88", Offset = "0xE6AF88", VA = "0xE6AF88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0xE6B090", Offset = "0xE6B090", VA = "0xE6B090", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[OptionalReference]
		private SimpleSpawnEffect m_SpawnEffect;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Event m_Sound;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_FirstTurnOff;

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xE6AD70", Offset = "0xE6AD70", VA = "0xE6AD70")]
		private void Awake()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xE6AE6C", Offset = "0xE6AE6C", VA = "0xE6AE6C")]
		public void Buzz()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xE6AD78", Offset = "0xE6AD78", VA = "0xE6AD78")]
		public void TurnOnButton(bool on)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xE6AEE4", Offset = "0xE6AEE4", VA = "0xE6AEE4")]
		[IteratorStateMachine(typeof(<DelayedDeactivation>d__6))]
		private IEnumerator DelayedDeactivation()
		{
			return null;
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xE6AF74", Offset = "0xE6AF74", VA = "0xE6AF74")]
		public WGTButton()
		{
		}
	}
	[Token(Token = "0x2000195")]
	public class WGTController : MonoBehaviour
	{
		[Token(Token = "0x2000196")]
		[CompilerGenerated]
		private sealed class <ButtonIFrames>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WGTController <>4__this;

			[Token(Token = "0x170000D5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000736")]
				[Address(RVA = "0xE6BBE8", Offset = "0xE6BBE8", VA = "0xE6BBE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000738")]
				[Address(RVA = "0xE6BC30", Offset = "0xE6BC30", VA = "0xE6BC30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0xE6B678", Offset = "0xE6B678", VA = "0xE6B678")]
			[DebuggerHidden]
			public <ButtonIFrames>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0xE6BB34", Offset = "0xE6BB34", VA = "0xE6BB34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0xE6BB38", Offset = "0xE6BB38", VA = "0xE6BB38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0xE6BBF0", Offset = "0xE6BBF0", VA = "0xE6BBF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000197")]
		[CompilerGenerated]
		private sealed class <OpenCurtains>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public WGTController <>4__this;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool open;

			[Token(Token = "0x170000D7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600073C")]
				[Address(RVA = "0xE6BCFC", Offset = "0xE6BCFC", VA = "0xE6BCFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600073E")]
				[Address(RVA = "0xE6BD44", Offset = "0xE6BD44", VA = "0xE6BD44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0xE6B6A0", Offset = "0xE6B6A0", VA = "0xE6B6A0")]
			[DebuggerHidden]
			public <OpenCurtains>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0xE6BC38", Offset = "0xE6BC38", VA = "0xE6BC38", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0xE6BC3C", Offset = "0xE6BC3C", VA = "0xE6BC3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0xE6BD04", Offset = "0xE6BD04", VA = "0xE6BD04", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007B9")]
		private const float kCurtainOpenScale = 0.7f;

		[Token(Token = "0x40007BA")]
		private const float kCurtainClosedScale = 2.72f;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_CurtainScalerRight;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_CurtainScalerLeft;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_CurtainOpenSpeed;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private WGTButton m_Button;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private WGTButton m_GoldenButton;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private WGTButton m_GoldenButton2;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject m_Bat;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource m_Claps;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject[] m_Performances;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform[] m_ConfettiPositions;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion m_BatRotation;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 m_OriginalElephantPos;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion m_OriginalElephantRot;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Rigidbody m_Rb;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int m_NextPerformance;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool m_CurtainOpen;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		private bool m_CurtainScaling;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
		private bool m_PerformanceStoppable;

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xE6B0D8", Offset = "0xE6B0D8", VA = "0xE6B0D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xE6B188", Offset = "0xE6B188", VA = "0xE6B188")]
		private void Start()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xE6B23C", Offset = "0xE6B23C", VA = "0xE6B23C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xE6A2A4", Offset = "0xE6A2A4", VA = "0xE6A2A4")]
		public void PerformanceStoppable()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xE6B354", Offset = "0xE6B354", VA = "0xE6B354")]
		public void Buzzer()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xE6B540", Offset = "0xE6B540", VA = "0xE6B540")]
		public void GoldenBuzzer()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xE6B2EC", Offset = "0xE6B2EC", VA = "0xE6B2EC")]
		[IteratorStateMachine(typeof(<ButtonIFrames>d__26))]
		private IEnumerator ButtonIFrames()
		{
			return null;
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xE6B400", Offset = "0xE6B400", VA = "0xE6B400")]
		private void EndPerformance(bool goldenBuzzer)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xE6B1B0", Offset = "0xE6B1B0", VA = "0xE6B1B0")]
		[IteratorStateMachine(typeof(<OpenCurtains>d__28))]
		private IEnumerator OpenCurtains(bool open, float delay = 0f)
		{
			return null;
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xE6B24C", Offset = "0xE6B24C", VA = "0xE6B24C")]
		private void ScaleCurtains()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xE6B6C8", Offset = "0xE6B6C8", VA = "0xE6B6C8")]
		private void CheckDoneScalingCurtains()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xE6B940", Offset = "0xE6B940", VA = "0xE6B940")]
		private void CurtainsClosed()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xE6B7F8", Offset = "0xE6B7F8", VA = "0xE6B7F8")]
		private void CurtainsOpened()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xE6B768", Offset = "0xE6B768", VA = "0xE6B768")]
		private void SetCurtains(bool open)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xE6BB24", Offset = "0xE6BB24", VA = "0xE6BB24")]
		public WGTController()
		{
		}
	}
	[Token(Token = "0x2000198")]
	public class WGTTrophy : MonoBehaviour, IWGTPerformance
	{
		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WGTController m_Controller;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody m_Bat;

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xE6BD4C", Offset = "0xE6BD4C", VA = "0xE6BD4C", Slot = "4")]
		public void StartPerformance()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xE6BD64", Offset = "0xE6BD64", VA = "0xE6BD64", Slot = "5")]
		public void StopPerformance(bool goldenBuzzer)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xE6BD84", Offset = "0xE6BD84", VA = "0xE6BD84")]
		public WGTTrophy()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.SmashFactory.Scripts
{
	[Token(Token = "0x2000199")]
	public class BatEnterTrigger : MonoBehaviour
	{
		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BatTriggerManager m_Manager;

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xE6BD8C", Offset = "0xE6BD8C", VA = "0xE6BD8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xE6BDFC", Offset = "0xE6BDFC", VA = "0xE6BDFC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xE6C030", Offset = "0xE6C030", VA = "0xE6C030")]
		public BatEnterTrigger()
		{
		}
	}
	[Token(Token = "0x200019A")]
	public class BatExitTrigger : MonoBehaviour
	{
		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BatTriggerManager m_Manager;

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xE6C038", Offset = "0xE6C038", VA = "0xE6C038")]
		private void Start()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xE6C0A8", Offset = "0xE6C0A8", VA = "0xE6C0A8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xE6C2D8", Offset = "0xE6C2D8", VA = "0xE6C2D8")]
		public BatExitTrigger()
		{
		}
	}
	[Token(Token = "0x200019B")]
	public class BatTriggerManager : MonoBehaviour
	{
		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool m_BatOneIn;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool m_BatTwoIn;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent m_BatEnter;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent m_BatExit;

		[Token(Token = "0x170000D9")]
		public List<Bat> bats
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0xE6C2E0", Offset = "0xE6C2E0", VA = "0xE6C2E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000749")]
			[Address(RVA = "0xE6C2E8", Offset = "0xE6C2E8", VA = "0xE6C2E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xE6C2F0", Offset = "0xE6C2F0", VA = "0xE6C2F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xE6BFB0", Offset = "0xE6BFB0", VA = "0xE6BFB0")]
		public void DoBatEnter()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xE6C258", Offset = "0xE6C258", VA = "0xE6C258")]
		public void DoBatExit()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xE6C3E8", Offset = "0xE6C3E8", VA = "0xE6C3E8")]
		public BatTriggerManager()
		{
		}
	}
	[Token(Token = "0x200019C")]
	public class ConveyorBelt : MonoBehaviour
	{
		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("belt")]
		public GameObject m_Belt;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("speed")]
		public float m_Speed;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("speedMultiplier")]
		public float m_SpeedMultiplier;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_SpeedMod;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_Moving;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		private bool m_Forward;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		[FormerlySerializedAs("moveOnStart")]
		public bool m_MoveOnStart;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
		private bool m_MoveBackToSpot;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_BackSpot;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent m_OnMoveBackComplete;

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xE6C3F0", Offset = "0xE6C3F0", VA = "0xE6C3F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xE6C410", Offset = "0xE6C410", VA = "0xE6C410")]
		private void Update()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xE6C404", Offset = "0xE6C404", VA = "0xE6C404")]
		public void MoveForward()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xE6C5F0", Offset = "0xE6C5F0", VA = "0xE6C5F0")]
		public void MoveBackward()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xE6C5E4", Offset = "0xE6C5E4", VA = "0xE6C5E4")]
		public void StopMoving()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xE6C668", Offset = "0xE6C668", VA = "0xE6C668")]
		public void MoveFast()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xE6C674", Offset = "0xE6C674", VA = "0xE6C674")]
		public void MoveNormal()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xE6C680", Offset = "0xE6C680", VA = "0xE6C680")]
		public void MoveBackTo(float spot)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xE6C694", Offset = "0xE6C694", VA = "0xE6C694")]
		public ConveyorBelt()
		{
		}
	}
	[Token(Token = "0x200019D")]
	public class ConveyorBeltSensor : MonoBehaviour
	{
		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("belt")]
		public ConveyorBelt m_Belt;

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xE6C6A4", Offset = "0xE6C6A4", VA = "0xE6C6A4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xE6C6E4", Offset = "0xE6C6E4", VA = "0xE6C6E4")]
		public ConveyorBeltSensor()
		{
		}
	}
	[Token(Token = "0x200019E")]
	public class ConveyorBeltSensorNormal : MonoBehaviour
	{
		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("belt")]
		public ConveyorBelt m_Belt;

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xE6C6EC", Offset = "0xE6C6EC", VA = "0xE6C6EC")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xE6C78C", Offset = "0xE6C78C", VA = "0xE6C78C")]
		public ConveyorBeltSensorNormal()
		{
		}
	}
	[Token(Token = "0x200019F")]
	public class PlateDisplay : MonoBehaviour
	{
		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject m_Error;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject m_Smashed;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject m_Unsmashed;

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xE6C794", Offset = "0xE6C794", VA = "0xE6C794")]
		public void do_smash()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xE6C7CC", Offset = "0xE6C7CC", VA = "0xE6C7CC")]
		public void do_error()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xE6C804", Offset = "0xE6C804", VA = "0xE6C804")]
		public PlateDisplay()
		{
		}
	}
	[Token(Token = "0x20001A0")]
	public class PlateScanner : MonoBehaviour
	{
		[Token(Token = "0x20001A1")]
		[CompilerGenerated]
		private sealed class <WaitAndAlert>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlateScanner <>4__this;

			[Token(Token = "0x170000DA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000765")]
				[Address(RVA = "0xE6CCD4", Offset = "0xE6CCD4", VA = "0xE6CCD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000767")]
				[Address(RVA = "0xE6CD1C", Offset = "0xE6CD1C", VA = "0xE6CD1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0xE6CBF4", Offset = "0xE6CBF4", VA = "0xE6CBF4")]
			[DebuggerHidden]
			public <WaitAndAlert>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0xE6CC24", Offset = "0xE6CC24", VA = "0xE6CC24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0xE6CC28", Offset = "0xE6CC28", VA = "0xE6CC28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0xE6CCDC", Offset = "0xE6CCDC", VA = "0xE6CCDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("lightSwitch")]
		public RedLightGreenLight m_LightSwitch;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("SmashedPlateFound")]
		public UnityEvent m_SmashedPlateFound;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("WholePlateFound")]
		public UnityEvent m_WholePlateFound;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("Fail")]
		public UnityEvent m_Fail;

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xE6C80C", Offset = "0xE6C80C", VA = "0xE6C80C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xE6C92C", Offset = "0xE6C92C", VA = "0xE6C92C")]
		private void PlateFound()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xE6CB8C", Offset = "0xE6CB8C", VA = "0xE6CB8C")]
		[IteratorStateMachine(typeof(<WaitAndAlert>d__6))]
		private IEnumerator WaitAndAlert()
		{
			return null;
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xE6CC1C", Offset = "0xE6CC1C", VA = "0xE6CC1C")]
		public PlateScanner()
		{
		}
	}
	[Token(Token = "0x20001A2")]
	public class RedLightGreenLight : MonoBehaviour
	{
		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("reds")]
		public List<GameObject> m_Reds;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("greens")]
		public List<GameObject> m_Greens;

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xE6C970", Offset = "0xE6C970", VA = "0xE6C970")]
		public void RedLight()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xE6CD24", Offset = "0xE6CD24", VA = "0xE6CD24")]
		public void GreenLight()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xE6CF40", Offset = "0xE6CF40", VA = "0xE6CF40")]
		public RedLightGreenLight()
		{
		}
	}
	[Token(Token = "0x20001A3")]
	public class SmashDisplay : MonoBehaviour
	{
		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<PlateDisplay> m_ListPlates;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_I;

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xE6CF48", Offset = "0xE6CF48", VA = "0xE6CF48")]
		private void Start()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xE6CF50", Offset = "0xE6CF50", VA = "0xE6CF50")]
		public void SmashPlate()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xE6CFBC", Offset = "0xE6CFBC", VA = "0xE6CFBC")]
		public void SmashMiss()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xE6D028", Offset = "0xE6D028", VA = "0xE6D028")]
		public SmashDisplay()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	public class SmashPlate : MonoBehaviour
	{
		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("numPiecesMin")]
		public int m_NumPiecesMin;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("numPiecesMax")]
		public int m_NumPiecesMax;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("pieces")]
		public GameObject m_Pieces;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioEvent m_AudioEvent;

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xE6D030", Offset = "0xE6D030", VA = "0xE6D030")]
		private void Start()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xE6D080", Offset = "0xE6D080", VA = "0xE6D080")]
		public void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xE6D0A4", Offset = "0xE6D0A4", VA = "0xE6D0A4")]
		public void Smash()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xE6D634", Offset = "0xE6D634", VA = "0xE6D634")]
		public SmashPlate()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.SleepingDog.Scripts
{
	[Token(Token = "0x20001A5")]
	public class EnableAlarmClockTrigger : MonoBehaviour
	{
		[Token(Token = "0x6000773")]
		[Address(RVA = "0xE6D63C", Offset = "0xE6D63C", VA = "0xE6D63C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xE6D6F0", Offset = "0xE6D6F0", VA = "0xE6D6F0")]
		public EnableAlarmClockTrigger()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.SeagullChess.Scripts
{
	[Token(Token = "0x20001A6")]
	public class ChessSheepTrophy : MonoBehaviour
	{
		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_OnBatted;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_TurnOffKinematic;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xE6D6F8", Offset = "0xE6D6F8", VA = "0xE6D6F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xE6D748", Offset = "0xE6D748", VA = "0xE6D748")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xE6D820", Offset = "0xE6D820", VA = "0xE6D820")]
		public ChessSheepTrophy()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	public class SeagullChessMaster : MonoBehaviour
	{
		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int MakeMove;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_Dog;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator m_Animator;

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xE6D830", Offset = "0xE6D830", VA = "0xE6D830")]
		private void Start()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xE6D880", Offset = "0xE6D880", VA = "0xE6D880")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xE6D954", Offset = "0xE6D954", VA = "0xE6D954")]
		public void StartAnimation()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xE6D9C4", Offset = "0xE6D9C4", VA = "0xE6D9C4")]
		public SeagullChessMaster()
		{
		}
	}
	[Token(Token = "0x20001A8")]
	public class SeagullChessSit2Controller : MonoBehaviour
	{
		[Token(Token = "0x20001A9")]
		[CompilerGenerated]
		private sealed class <DelayedSeagullMove>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SeagullChessSit2Controller <>4__this;

			[Token(Token = "0x170000DC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000783")]
				[Address(RVA = "0xE6DB98", Offset = "0xE6DB98", VA = "0xE6DB98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000785")]
				[Address(RVA = "0xE6DBE0", Offset = "0xE6DBE0", VA = "0xE6DBE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000780")]
			[Address(RVA = "0xE6DABC", Offset = "0xE6DABC", VA = "0xE6DABC")]
			[DebuggerHidden]
			public <DelayedSeagullMove>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000781")]
			[Address(RVA = "0xE6DAEC", Offset = "0xE6DAEC", VA = "0xE6DAEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0xE6DAF0", Offset = "0xE6DAF0", VA = "0xE6DAF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0xE6DBA0", Offset = "0xE6DBA0", VA = "0xE6DBA0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SeagullChessMaster m_Seagull;

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xE6DA34", Offset = "0xE6DA34", VA = "0xE6DA34")]
		private void Start()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xE6DA54", Offset = "0xE6DA54", VA = "0xE6DA54")]
		[IteratorStateMachine(typeof(<DelayedSeagullMove>d__2))]
		private IEnumerator DelayedSeagullMove()
		{
			return null;
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xE6DAE4", Offset = "0xE6DAE4", VA = "0xE6DAE4")]
		public SeagullChessSit2Controller()
		{
		}
	}
	[Token(Token = "0x20001AA")]
	public class SeagullChessSit3 : MonoBehaviour
	{
		[Token(Token = "0x20001AB")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SeagullChessSit3 <>4__this;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 bigChessBoardCurrentPosition;

			[Token(Token = "0x600078B")]
			[Address(RVA = "0xE6DDC0", Offset = "0xE6DDC0", VA = "0xE6DDC0")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0xE6DDC8", Offset = "0xE6DDC8", VA = "0xE6DDC8")]
			internal void <TurnWorldToChess>b__0(float t)
			{
			}
		}

		[Token(Token = "0x20001AC")]
		[CompilerGenerated]
		private sealed class <TurnWorldToChess>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SeagullChessSit3 <>4__this;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass8_0 <>8__1;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000790")]
				[Address(RVA = "0xE6E0D4", Offset = "0xE6E0D4", VA = "0xE6E0D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000792")]
				[Address(RVA = "0xE6E11C", Offset = "0xE6E11C", VA = "0xE6E11C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600078D")]
			[Address(RVA = "0xE6DC70", Offset = "0xE6DC70", VA = "0xE6DC70")]
			[DebuggerHidden]
			public <TurnWorldToChess>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0xE6DE58", Offset = "0xE6DE58", VA = "0xE6DE58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0xE6DE5C", Offset = "0xE6DE5C", VA = "0xE6DE5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0xE6E0DC", Offset = "0xE6E0DC", VA = "0xE6E0DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001AE")]
		[CompilerGenerated]
		private sealed class <DescendChessBoard>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SeagullChessSit3 <>4__this;

			[Token(Token = "0x170000E0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000798")]
				[Address(RVA = "0xE6E2EC", Offset = "0xE6E2EC", VA = "0xE6E2EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600079A")]
				[Address(RVA = "0xE6E334", Offset = "0xE6E334", VA = "0xE6E334", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0xE6DD00", Offset = "0xE6DD00", VA = "0xE6DD00")]
			[DebuggerHidden]
			public <DescendChessBoard>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0xE6E1BC", Offset = "0xE6E1BC", VA = "0xE6E1BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0xE6E1C0", Offset = "0xE6E1C0", VA = "0xE6E1C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0xE6E2F4", Offset = "0xE6E2F4", VA = "0xE6E2F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001AF")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SeagullChessSit3 <>4__this;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 trophyCurrentPosition;

			[Token(Token = "0x600079B")]
			[Address(RVA = "0xE6E33C", Offset = "0xE6E33C", VA = "0xE6E33C")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0xE6E344", Offset = "0xE6E344", VA = "0xE6E344")]
			internal void <DescendTrophy>b__0(float t)
			{
			}
		}

		[Token(Token = "0x20001B0")]
		[CompilerGenerated]
		private sealed class <DescendTrophy>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SeagullChessSit3 <>4__this;

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass10_0 <>8__1;

			[Token(Token = "0x170000E2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007A0")]
				[Address(RVA = "0xE6E574", Offset = "0xE6E574", VA = "0xE6E574", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007A2")]
				[Address(RVA = "0xE6E5BC", Offset = "0xE6E5BC", VA = "0xE6E5BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0xE6DD90", Offset = "0xE6DD90", VA = "0xE6DD90")]
			[DebuggerHidden]
			public <DescendTrophy>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0xE6E3D4", Offset = "0xE6E3D4", VA = "0xE6E3D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0xE6E3D8", Offset = "0xE6E3D8", VA = "0xE6E3D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0xE6E57C", Offset = "0xE6E57C", VA = "0xE6E57C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_ChessBoard;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_ChessBoardTargetPosition;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rigidbody[] m_ChessBoardPieces;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_BigChessBoard;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform m_BigChessBoardTargetPosition;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TrophySheep m_TrophySheep;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Rigidbody m_Trophy;

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xE6DBE8", Offset = "0xE6DBE8", VA = "0xE6DBE8")]
		public void InitiateTheChessening()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xE6DC08", Offset = "0xE6DC08", VA = "0xE6DC08")]
		[IteratorStateMachine(typeof(<TurnWorldToChess>d__8))]
		private IEnumerator TurnWorldToChess()
		{
			return null;
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xE6DC98", Offset = "0xE6DC98", VA = "0xE6DC98")]
		[IteratorStateMachine(typeof(<DescendChessBoard>d__9))]
		private IEnumerator DescendChessBoard()
		{
			return null;
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xE6DD28", Offset = "0xE6DD28", VA = "0xE6DD28")]
		[IteratorStateMachine(typeof(<DescendTrophy>d__10))]
		private IEnumerator DescendTrophy()
		{
			return null;
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xE6DDB8", Offset = "0xE6DDB8", VA = "0xE6DDB8")]
		public SeagullChessSit3()
		{
		}
	}
	[Token(Token = "0x20001B1")]
	public class TrophySheep : MonoBehaviour
	{
		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Trophy;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_TongueAnimator;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator m_Animator;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_DoneMoving;

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xE6E5C4", Offset = "0xE6E5C4", VA = "0xE6E5C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xE6E614", Offset = "0xE6E614", VA = "0xE6E614")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xE6E0B4", Offset = "0xE6E0B4", VA = "0xE6E0B4")]
		public void Move()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xE6E6F0", Offset = "0xE6E6F0", VA = "0xE6E6F0")]
		public void DoneMoving()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xE6E6FC", Offset = "0xE6E6FC", VA = "0xE6E6FC")]
		public TrophySheep()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.RemoteControlledBats.Scripts
{
	[Token(Token = "0x20001B2")]
	public class RemoteControlledBat : MonoBehaviour
	{
		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_RightHand;

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xE6E704", Offset = "0xE6E704", VA = "0xE6E704")]
		public void Update()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xE6E944", Offset = "0xE6E944", VA = "0xE6E944")]
		public RemoteControlledBat()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.Property_Damage.Scripts
{
	[Token(Token = "0x20001B3")]
	public class DamageValueText : MonoBehaviour
	{
		[Token(Token = "0x20001B4")]
		[CompilerGenerated]
		private sealed class <StartLiving>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DamageValueText <>4__this;

			[Token(Token = "0x170000E4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007B2")]
				[Address(RVA = "0xE6ECC0", Offset = "0xE6ECC0", VA = "0xE6ECC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007B4")]
				[Address(RVA = "0xE6ED08", Offset = "0xE6ED08", VA = "0xE6ED08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0xE6EBD4", Offset = "0xE6EBD4", VA = "0xE6EBD4")]
			[DebuggerHidden]
			public <StartLiving>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0xE6EC04", Offset = "0xE6EC04", VA = "0xE6EC04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xE6EC08", Offset = "0xE6EC08", VA = "0xE6EC08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xE6ECC8", Offset = "0xE6ECC8", VA = "0xE6ECC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_Text;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_PlayerTransform;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform m_Transform;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Visible;

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xE6E94C", Offset = "0xE6E94C", VA = "0xE6E94C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xE6E9D8", Offset = "0xE6E9D8", VA = "0xE6E9D8")]
		public void Initialize(float value, Transform playerTransform)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xE6EAC0", Offset = "0xE6EAC0", VA = "0xE6EAC0")]
		public void Appear()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xE6EB6C", Offset = "0xE6EB6C", VA = "0xE6EB6C")]
		[IteratorStateMachine(typeof(<StartLiving>d__7))]
		private IEnumerator StartLiving()
		{
			return null;
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xE6EBFC", Offset = "0xE6EBFC", VA = "0xE6EBFC")]
		public DamageValueText()
		{
		}
	}
	[Token(Token = "0x20001B5")]
	public class DestructibleProperty : MonoBehaviour
	{
		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Value;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DestroyOnBatted;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ShowIf("m_DestroyOnBatted")]
		[SerializeField]
		private float m_MinimumBreakForce;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[ShowIf("m_DestroyOnBatted")]
		public GameObject[] m_ShatterObjects;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[ShowIf("m_DestroyOnBatted")]
		public GameObject[] m_WholeObjects;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_DamageOnMoved;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[ShowIf("m_DamageOnMoved")]
		[SerializeField]
		private float m_DistanceToDamage;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject m_FloatingText;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PropertyController m_Controller;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject m_TextGo;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DamageValueText m_DamageValueText;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_Destroyed;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_Damaged;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 m_OriginalForward;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 m_OriginalPosition;

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xE6ED10", Offset = "0xE6ED10", VA = "0xE6ED10")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xE6EE74", Offset = "0xE6EE74", VA = "0xE6EE74")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xE6EEC4", Offset = "0xE6EEC4", VA = "0xE6EEC4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xE6F18C", Offset = "0xE6F18C", VA = "0xE6F18C")]
		public void Initialize(PropertyController controller, GameObject floatingText, Transform playerTransform)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xE6EE20", Offset = "0xE6EE20", VA = "0xE6EE20")]
		private void DestroyProperty(float breakForce)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xE6F0CC", Offset = "0xE6F0CC", VA = "0xE6F0CC")]
		private void Damage()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xE6F480", Offset = "0xE6F480", VA = "0xE6F480")]
		private void Break(float breakForce)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xE6F6DC", Offset = "0xE6F6DC", VA = "0xE6F6DC")]
		public DestructibleProperty()
		{
		}
	}
	[Token(Token = "0x20001B6")]
	public class PropertyController : MonoBehaviour
	{
		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_FloatingText;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_DestroyThisMuchToWin;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Situation m_Situation;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DestructibleProperty[] m_DestructibleProperty;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_TotalDestroyedValue;

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xE6F2E4", Offset = "0xE6F2E4", VA = "0xE6F2E4")]
		public void PropertyDestroyed(float value)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xE6F6FC", Offset = "0xE6F6FC", VA = "0xE6F6FC")]
		public void Prepare()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xE6F7BC", Offset = "0xE6F7BC", VA = "0xE6F7BC")]
		public PropertyController()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.PotionMaking.Scripts
{
	[Token(Token = "0x20001B7")]
	public class Cauldron : MonoBehaviour
	{
		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TrippOverAngle;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem m_SpillParticleSystem;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_OnSpilled;

		[Token(Token = "0x170000E6")]
		public UnityEvent onSpilled
		{
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0xE6F7CC", Offset = "0xE6F7CC", VA = "0xE6F7CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E7")]
		public bool isSpilled
		{
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0xE6F7D4", Offset = "0xE6F7D4", VA = "0xE6F7D4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0xE6F7DC", Offset = "0xE6F7DC", VA = "0xE6F7DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xE6F7E8", Offset = "0xE6F7E8", VA = "0xE6F7E8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xE6FAF8", Offset = "0xE6FAF8", VA = "0xE6FAF8")]
		public Cauldron()
		{
		}
	}
	[Token(Token = "0x20001B8")]
	public class CauldronIngredientConsumer : MonoBehaviour, IRequireValidation
	{
		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent<Rigidbody> m_OnConsumeIngredient;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem m_SplashesParticlePrefab;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_ConsumeRigidbodies;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Cauldron m_Cauldron;

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xE6FB08", Offset = "0xE6FB08", VA = "0xE6FB08")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xE6FB58", Offset = "0xE6FB58", VA = "0xE6FB58")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xE6FBEC", Offset = "0xE6FBEC", VA = "0xE6FBEC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xE6FE44", Offset = "0xE6FE44", VA = "0xE6FE44")]
		private void OnSpilled()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xE6FE68", Offset = "0xE6FE68", VA = "0xE6FE68", Slot = "4")]
		public void Validate(ValidationContext context)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xE6FEEC", Offset = "0xE6FEEC", VA = "0xE6FEEC")]
		public CauldronIngredientConsumer()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.PettingFactory.Scripts
{
	[Token(Token = "0x20001B9")]
	public class Pettable : MonoBehaviour
	{
		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Heart;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_HeartSpawnPosition;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PettingFactorySit1Controller m_Controller;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly float m_PetCooldown;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly float m_PetMinDistance;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_PettingStarted;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_NextLegalPet;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_NextLoveReport;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int m_HeartsSpawned;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 m_LastPettedSpotLeft;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 m_LastPettedSpotRight;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UnityEvent m_OnPettingStarted;

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xE6FEF4", Offset = "0xE6FEF4", VA = "0xE6FEF4")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xE7026C", Offset = "0xE7026C", VA = "0xE7026C")]
		private void OnCollisionExit(Collision other)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xE70348", Offset = "0xE70348", VA = "0xE70348")]
		private void Update()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xE70464", Offset = "0xE70464", VA = "0xE70464")]
		private void OnCollisionStay(Collision other)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xE706F0", Offset = "0xE706F0", VA = "0xE706F0")]
		public void InitiatePetting()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xE706FC", Offset = "0xE706FC", VA = "0xE706FC")]
		public void EndPetting()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xE70014", Offset = "0xE70014", VA = "0xE70014")]
		private void SpawnHeart()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xE70704", Offset = "0xE70704", VA = "0xE70704")]
		public Pettable()
		{
		}
	}
	[Token(Token = "0x20001BA")]
	public class PettingFactorySit1Controller : MonoBehaviour
	{
		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_ConveyerBelt;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_Graph;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform[] m_GraphPoints;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GraphTimeStepLength;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int m_MaxTimeStepsPerDog;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject m_Trophy;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_Count;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int m_GraphTimeStepCount;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_DrawingInitialGraph;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool m_BeltMoving;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		private bool m_TrophyArrived;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Pettable> m_Dogs;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_MinimumGraphPoint;

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xE70718", Offset = "0xE70718", VA = "0xE70718")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xE70828", Offset = "0xE70828", VA = "0xE70828")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xE70918", Offset = "0xE70918", VA = "0xE70918")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xE70ADC", Offset = "0xE70ADC", VA = "0xE70ADC")]
		public void SendInTheNextDog()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xE703A0", Offset = "0xE703A0", VA = "0xE703A0")]
		public void LoveReport(int heartsSpawned)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xE70790", Offset = "0xE70790", VA = "0xE70790")]
		private void DrawInitialGraph()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xE70C0C", Offset = "0xE70C0C", VA = "0xE70C0C")]
		public PettingFactorySit1Controller()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.Mewschief.Scripts
{
	[Token(Token = "0x20001BB")]
	public class BatTouchStatus : MonoBehaviour
	{
		[Token(Token = "0x170000E8")]
		public bool batTouching
		{
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0xE70C2C", Offset = "0xE70C2C", VA = "0xE70C2C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0xE70C34", Offset = "0xE70C34", VA = "0xE70C34")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xE70C40", Offset = "0xE70C40", VA = "0xE70C40")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xE70CD4", Offset = "0xE70CD4", VA = "0xE70CD4")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xE70D64", Offset = "0xE70D64", VA = "0xE70D64")]
		public BatTouchStatus()
		{
		}
	}
	[Token(Token = "0x20001BC")]
	public class ChangeRigidbodyConstraints : MonoBehaviour
	{
		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("rigidbody")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("newConstraints")]
		[SerializeField]
		private RigidbodyConstraints m_NewConstraints;

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xE70D6C", Offset = "0xE70D6C", VA = "0xE70D6C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xE70E24", Offset = "0xE70E24", VA = "0xE70E24")]
		public ChangeRigidbodyConstraints()
		{
		}
	}
	[Token(Token = "0x20001BD")]
	public class MewschiefElephant : MonoBehaviour
	{
		[Token(Token = "0x20001BE")]
		[CompilerGenerated]
		private sealed class <FailRoutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MewschiefElephant <>4__this;

			[Token(Token = "0x170000E9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E8")]
				[Address(RVA = "0xE711B8", Offset = "0xE711B8", VA = "0xE711B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007EA")]
				[Address(RVA = "0xE71200", Offset = "0xE71200", VA = "0xE71200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0xE710D8", Offset = "0xE710D8", VA = "0xE710D8")]
			[DebuggerHidden]
			public <FailRoutine>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0xE71108", Offset = "0xE71108", VA = "0xE71108", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0xE7110C", Offset = "0xE7110C", VA = "0xE7110C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0xE711C0", Offset = "0xE711C0", VA = "0xE711C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("rotY_lookAway")]
		private float m_RotYLookAway;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[FormerlySerializedAs("rotY_lookAt")]
		private float m_RotYLookAt;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("lookAtPeriod")]
		[SerializeField]
		private float m_LookAtPeriod;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("lookAwayPeriod")]
		[SerializeField]
		private float m_LookAwayPeriod;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("lookingAt")]
		private bool m_LookingAt;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[FormerlySerializedAs("moveDuration")]
		[SerializeField]
		private float m_MoveDuration;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("batTouchStatus")]
		private BatTouchStatus m_BatTouchStatus;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("situation")]
		[SerializeField]
		private Situation m_Situation;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("failPos")]
		[SerializeField]
		private Transform m_FailPos;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_TimeStamp;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool m_Moving;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 m_StartRot;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 m_EndRot;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_Failed;

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xE70E2C", Offset = "0xE70E2C", VA = "0xE70E2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xE70E4C", Offset = "0xE70E4C", VA = "0xE70E4C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xE71070", Offset = "0xE71070", VA = "0xE71070")]
		[IteratorStateMachine(typeof(<FailRoutine>d__16))]
		private IEnumerator FailRoutine()
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xE71100", Offset = "0xE71100", VA = "0xE71100")]
		public MewschiefElephant()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.Materializer.Scripts
{
	[Token(Token = "0x20001BF")]
	public class MaterializerSpawner : MonoBehaviour
	{
		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GameObject> m_ObjectsToSpawn;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurObjIndex;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool m_SkipDisabling;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int m_SkipDisableIndex;

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xE71208", Offset = "0xE71208", VA = "0xE71208")]
		private void Start()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xE7135C", Offset = "0xE7135C", VA = "0xE7135C")]
		[UsedImplicitly]
		public void ButtonPress()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xE71360", Offset = "0xE71360", VA = "0xE71360")]
		private void SpawnNext()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xE71448", Offset = "0xE71448", VA = "0xE71448")]
		public MaterializerSpawner()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.LaserRings.Scripts
{
	[Token(Token = "0x20001C0")]
	public class LaserOpenedBox : MonoBehaviour
	{
		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LaserRing[] m_LaserRingIndicators;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody m_TrophyBoxBottom;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<LaserRing> m_RingTargetsActivated;

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xE71450", Offset = "0xE71450", VA = "0xE71450")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xE714C4", Offset = "0xE714C4", VA = "0xE714C4")]
		public void RingActivated(LaserRing ring)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xE7180C", Offset = "0xE7180C", VA = "0xE7180C")]
		public void RingDeactivated(LaserRing ring)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xE7156C", Offset = "0xE7156C", VA = "0xE7156C")]
		private void CheckList()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xE7186C", Offset = "0xE7186C", VA = "0xE7186C")]
		private void DeactivateIndicators()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xE71B84", Offset = "0xE71B84", VA = "0xE71B84")]
		private void OpenHatch()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xE71BC8", Offset = "0xE71BC8", VA = "0xE71BC8")]
		public LaserOpenedBox()
		{
		}
	}
	[Token(Token = "0x20001C1")]
	public class LaserRing : MonoBehaviour
	{
		[Token(Token = "0x20001C2")]
		private enum RingColour
		{
			[Token(Token = "0x400087F")]
			Yellow,
			[Token(Token = "0x4000880")]
			Red,
			[Token(Token = "0x4000881")]
			Pink
		}

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RingColour m_Colour;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material m_ActivatedMaterial;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Renderer m_Renderer;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material m_DeactivatedMaterial;

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xE71BD0", Offset = "0xE71BD0", VA = "0xE71BD0")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xE71AF8", Offset = "0xE71AF8", VA = "0xE71AF8")]
		public string Colour()
		{
			return null;
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xE71B60", Offset = "0xE71B60", VA = "0xE71B60")]
		public void Activate()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xE71BA4", Offset = "0xE71BA4", VA = "0xE71BA4")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xE71C34", Offset = "0xE71C34", VA = "0xE71C34")]
		public LaserRing()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.Golf.Scripts
{
	[Token(Token = "0x20001C3")]
	public class BouncyWall : MonoBehaviour
	{
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xE71C3C", Offset = "0xE71C3C", VA = "0xE71C3C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xE71D50", Offset = "0xE71D50", VA = "0xE71D50")]
		public BouncyWall()
		{
		}
	}
	[Token(Token = "0x20001C4")]
	public class FakeGolfBall : MonoBehaviour
	{
		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Golfable;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_GolfFlag;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody[] m_Rigidbodies;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_HitCooldown;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_NextLegalHit;

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xE71D58", Offset = "0xE71D58", VA = "0xE71D58")]
		private void Start()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xE71DB0", Offset = "0xE71DB0", VA = "0xE71DB0")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xE72078", Offset = "0xE72078", VA = "0xE72078")]
		public FakeGolfBall()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.Fly.Scripts
{
	[Token(Token = "0x20001C5")]
	public class Fly : MonoBehaviour
	{
		[Token(Token = "0x20001C6")]
		[CompilerGenerated]
		private sealed class <ErraticFlying>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Fly <>4__this;

			[Token(Token = "0x170000EB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600080E")]
				[Address(RVA = "0xE72CA4", Offset = "0xE72CA4", VA = "0xE72CA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000810")]
				[Address(RVA = "0xE72CEC", Offset = "0xE72CEC", VA = "0xE72CEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600080B")]
			[Address(RVA = "0xE72A08", Offset = "0xE72A08", VA = "0xE72A08")]
			[DebuggerHidden]
			public <ErraticFlying>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0xE72B1C", Offset = "0xE72B1C", VA = "0xE72B1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600080D")]
			[Address(RVA = "0xE72B20", Offset = "0xE72B20", VA = "0xE72B20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600080F")]
			[Address(RVA = "0xE72CAC", Offset = "0xE72CAC", VA = "0xE72CAC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovementSpeed;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_RotationSpeed;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FlyLandingSpot[] m_LandingSpots;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Situation m_Situation;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly float m_MovementSpeedDecay;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PlayerRig m_Player;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 m_FlyToPosition;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_NextLandingSpot;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 m_FlyTarget;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody m_Rb;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_Flying;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_OriginalMovementSpeed;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_ReadyForBonking;

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xE72088", Offset = "0xE72088", VA = "0xE72088")]
		private void Start()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xE7224C", Offset = "0xE7224C", VA = "0xE7224C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xE725A8", Offset = "0xE725A8", VA = "0xE725A8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xE725DC", Offset = "0xE725DC", VA = "0xE725DC")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xE72628", Offset = "0xE72628", VA = "0xE72628")]
		public void SetPlayer()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xE722C0", Offset = "0xE722C0", VA = "0xE722C0")]
		private void FlyToPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xE724BC", Offset = "0xE724BC", VA = "0xE724BC")]
		private void RotateTowardsPlayer()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xE720E4", Offset = "0xE720E4", VA = "0xE720E4")]
		private void NewLandingSpot()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xE729A0", Offset = "0xE729A0", VA = "0xE729A0")]
		[IteratorStateMachine(typeof(<ErraticFlying>d__21))]
		private IEnumerator ErraticFlying()
		{
			return null;
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xE72A30", Offset = "0xE72A30", VA = "0xE72A30")]
		private Vector3 NewTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xE72B00", Offset = "0xE72B00", VA = "0xE72B00")]
		public Fly()
		{
		}
	}
	[Token(Token = "0x20001C7")]
	public class FlyLandingSpot : MonoBehaviour
	{
		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_LandingSpot;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_PositionTolerance;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 m_OriginalPosition;

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xE72CF4", Offset = "0xE72CF4", VA = "0xE72CF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xE72650", Offset = "0xE72650", VA = "0xE72650")]
		public Vector3 GetLandingSpot()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xE72D24", Offset = "0xE72D24", VA = "0xE72D24")]
		public FlyLandingSpot()
		{
		}
	}
	[Token(Token = "0x20001C8")]
	public class TempDestructibleOnBatting : MonoBehaviour
	{
		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Destructible m_Destructible;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Breakforce;

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xE72D38", Offset = "0xE72D38", VA = "0xE72D38")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xE72EB0", Offset = "0xE72EB0", VA = "0xE72EB0")]
		public TempDestructibleOnBatting()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.Elevator.Scripts
{
	[Token(Token = "0x20001C9")]
	public class ElevatorDoors : MonoBehaviour
	{
		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_Opening;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool m_Closing;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject m_DoorOne;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject m_DoorTwo;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_DoorOneClosePos;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float m_DoorOneOpenPos;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m_Speed;

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xE72EC0", Offset = "0xE72EC0", VA = "0xE72EC0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xE73164", Offset = "0xE73164", VA = "0xE73164")]
		public void m_OpenDoor()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xE73170", Offset = "0xE73170", VA = "0xE73170")]
		public void m_CloseDoor()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xE7317C", Offset = "0xE7317C", VA = "0xE7317C")]
		public ElevatorDoors()
		{
		}
	}
	[Token(Token = "0x20001CA")]
	public class ElevatorFloorIndicator : MonoBehaviour
	{
		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject m_Dark;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject m_Green;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject m_Red;

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xE73184", Offset = "0xE73184", VA = "0xE73184")]
		public void m_TurnDark()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xE731D0", Offset = "0xE731D0", VA = "0xE731D0")]
		public void m_TurnGreen()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xE7321C", Offset = "0xE7321C", VA = "0xE7321C")]
		public void m_TurnRed()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xE73268", Offset = "0xE73268", VA = "0xE73268")]
		public ElevatorFloorIndicator()
		{
		}
	}
	[Token(Token = "0x20001CB")]
	public class ElevatorFloorMovement : MonoBehaviour
	{
		[Token(Token = "0x20001CC")]
		[CompilerGenerated]
		private sealed class <m_DoCloseDoor>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ElevatorFloorMovement <>4__this;

			[Token(Token = "0x170000ED")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600082D")]
				[Address(RVA = "0xE73B40", Offset = "0xE73B40", VA = "0xE73B40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600082F")]
				[Address(RVA = "0xE73B88", Offset = "0xE73B88", VA = "0xE73B88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600082A")]
			[Address(RVA = "0xE73854", Offset = "0xE73854", VA = "0xE73854")]
			[DebuggerHidden]
			public <m_DoCloseDoor>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0xE739F8", Offset = "0xE739F8", VA = "0xE739F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0xE739FC", Offset = "0xE739FC", VA = "0xE739FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600082E")]
			[Address(RVA = "0xE73B48", Offset = "0xE73B48", VA = "0xE73B48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001CD")]
		[CompilerGenerated]
		private sealed class <m_DoOpenDoor>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ElevatorFloorMovement <>4__this;

			[Token(Token = "0x170000EF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000833")]
				[Address(RVA = "0xE73C48", Offset = "0xE73C48", VA = "0xE73C48", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000835")]
				[Address(RVA = "0xE73C90", Offset = "0xE73C90", VA = "0xE73C90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0xE738E4", Offset = "0xE738E4", VA = "0xE738E4")]
			[DebuggerHidden]
			public <m_DoOpenDoor>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0xE73B90", Offset = "0xE73B90", VA = "0xE73B90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000832")]
			[Address(RVA = "0xE73B94", Offset = "0xE73B94", VA = "0xE73B94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000834")]
			[Address(RVA = "0xE73C50", Offset = "0xE73C50", VA = "0xE73C50", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m_MovementSpeed;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Moving;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool m_MovingUp;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Game m_GameScript;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_MaxHeight;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_MinHeight;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ElevatorDoors m_Doors;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Transform> m_Floors;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<ElevatorFloorIndicator> m_FloorIndicators;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int m_CurFloor;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_TargetFloor;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Queue<int> m_FloorQueue;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UnityEvent m_OnStartMoving;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UnityEvent m_OnStopMoving;

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xE73270", Offset = "0xE73270", VA = "0xE73270")]
		private void Start()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xE73374", Offset = "0xE73374", VA = "0xE73374")]
		private void Update()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xE736C4", Offset = "0xE736C4", VA = "0xE736C4")]
		public void m_MoveUp()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xE736EC", Offset = "0xE736EC", VA = "0xE736EC")]
		public void m_MoveDown()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xE73710", Offset = "0xE73710", VA = "0xE73710")]
		public void m_MoveStop()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xE73734", Offset = "0xE73734", VA = "0xE73734")]
		public void m_ButtonPressed(int floor)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xE737EC", Offset = "0xE737EC", VA = "0xE737EC")]
		[IteratorStateMachine(typeof(<m_DoCloseDoor>d__20))]
		private IEnumerator m_DoCloseDoor()
		{
			return null;
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xE7387C", Offset = "0xE7387C", VA = "0xE7387C")]
		[IteratorStateMachine(typeof(<m_DoOpenDoor>d__21))]
		private IEnumerator m_DoOpenDoor()
		{
			return null;
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xE7390C", Offset = "0xE7390C", VA = "0xE7390C")]
		private void m_CheckMovement()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xE73930", Offset = "0xE73930", VA = "0xE73930")]
		private void m_StartMoving()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xE73618", Offset = "0xE73618", VA = "0xE73618")]
		private void m_StopMoving()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xE7397C", Offset = "0xE7397C", VA = "0xE7397C")]
		public ElevatorFloorMovement()
		{
		}
	}
	[Token(Token = "0x20001CE")]
	public class ElevatorMovement : MonoBehaviour
	{
		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m_MovementSpeed;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Moving;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool m_MovingUp;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Game m_GameScript;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_MaxHeight;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_MinHeight;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ElevatorDoors m_Doors;

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xE73C98", Offset = "0xE73C98", VA = "0xE73C98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xE73D68", Offset = "0xE73D68", VA = "0xE73D68")]
		private void Update()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xE73F14", Offset = "0xE73F14", VA = "0xE73F14")]
		public void m_MoveUp()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xE73F3C", Offset = "0xE73F3C", VA = "0xE73F3C")]
		public void m_MoveDown()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xE73F60", Offset = "0xE73F60", VA = "0xE73F60")]
		public void m_MoveStop()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xE73F84", Offset = "0xE73F84", VA = "0xE73F84")]
		public ElevatorMovement()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.Elephant_Simon.Scripts
{
	[Token(Token = "0x20001CF")]
	public class BatHitTracker : MonoBehaviour
	{
		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_BatsFound;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("elephantSimon")]
		[SerializeField]
		private ElephantSimon m_ElephantSimon;

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xE73F8C", Offset = "0xE73F8C", VA = "0xE73F8C")]
		private void Update()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xE74088", Offset = "0xE74088", VA = "0xE74088")]
		public void BatImpact()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xE742E4", Offset = "0xE742E4", VA = "0xE742E4")]
		public BatHitTracker()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001D0")]
	public struct ElephantSimonSequence
	{
		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[FormerlySerializedAs("beats")]
		private float[] m_Beats;

		[Token(Token = "0x170000F1")]
		public float[] beats
		{
			[Token(Token = "0x600083F")]
			[Address(RVA = "0xE742EC", Offset = "0xE742EC", VA = "0xE742EC")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x20001D1")]
	public class ElephantSimon : MonoBehaviour
	{
		[Token(Token = "0x20001D2")]
		[CompilerGenerated]
		private sealed class <SimonSays>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ElephantSimon <>4__this;

			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x170000F2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600084F")]
				[Address(RVA = "0xE748B8", Offset = "0xE748B8", VA = "0xE748B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000851")]
				[Address(RVA = "0xE74900", Offset = "0xE74900", VA = "0xE74900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600084C")]
			[Address(RVA = "0xE745CC", Offset = "0xE745CC", VA = "0xE745CC")]
			[DebuggerHidden]
			public <SimonSays>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600084D")]
			[Address(RVA = "0xE74754", Offset = "0xE74754", VA = "0xE74754", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600084E")]
			[Address(RVA = "0xE74758", Offset = "0xE74758", VA = "0xE74758", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000850")]
			[Address(RVA = "0xE748C0", Offset = "0xE748C0", VA = "0xE748C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("sequence")]
		[SerializeField]
		private ElephantSimonSequence m_Sequence;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("trophy")]
		[SerializeField]
		private GameObject m_Trophy;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioEvent m_ElephantTrumpetEvent;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioEvent m_RestartSimonEvent;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("oneHitWin")]
		public bool m_OneHitWin;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_LastHitTimeStamp;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_SeqIndex;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_Started;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly float m_RotLeft;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private readonly float m_RotRight;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_TurnedLeft;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool m_Finished;

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xE742F4", Offset = "0xE742F4", VA = "0xE742F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xE7438C", Offset = "0xE7438C", VA = "0xE7438C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xE74104", Offset = "0xE74104", VA = "0xE74104")]
		public void Hit()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xE74324", Offset = "0xE74324", VA = "0xE74324")]
		[IteratorStateMachine(typeof(<SimonSays>d__15))]
		private IEnumerator SimonSays()
		{
			return null;
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xE74574", Offset = "0xE74574", VA = "0xE74574")]
		private void UpCount()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xE743D8", Offset = "0xE743D8", VA = "0xE743D8")]
		private void ResetCount()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xE74464", Offset = "0xE74464", VA = "0xE74464")]
		private void Finish()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xE745F4", Offset = "0xE745F4", VA = "0xE745F4")]
		private void Flip()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xE746D0", Offset = "0xE746D0", VA = "0xE746D0")]
		private void Left()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xE74664", Offset = "0xE74664", VA = "0xE74664")]
		private void Right()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xE74604", Offset = "0xE74604", VA = "0xE74604")]
		private void Straight()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xE74740", Offset = "0xE74740", VA = "0xE74740")]
		public ElephantSimon()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.Bowling.Scripts
{
	[Token(Token = "0x20001D3")]
	public class BigBowlingBall : MonoBehaviour
	{
		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MaxTimeBetweenHits;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_DoubleKickMultiplier;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject m_RecentlyHitBy;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_LastHit;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_NextKick;

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xE74908", Offset = "0xE74908", VA = "0xE74908")]
		private void Start()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xE74958", Offset = "0xE74958", VA = "0xE74958")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xE74AD8", Offset = "0xE74AD8", VA = "0xE74AD8")]
		public BigBowlingBall()
		{
		}
	}
	[Token(Token = "0x20001D4")]
	public class DogPins : MonoBehaviour
	{
		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xE74AEC", Offset = "0xE74AEC", VA = "0xE74AEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xE74B4C", Offset = "0xE74B4C", VA = "0xE74B4C")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xE74C6C", Offset = "0xE74C6C", VA = "0xE74C6C")]
		public DogPins()
		{
		}
	}
	[Token(Token = "0x20001D5")]
	public class TeleportationBall : MonoBehaviour
	{
		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RequiredDistanceTraversed;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_MinimumSqrVelocity;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_SpawnPosition;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_InMotion;

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xE74C74", Offset = "0xE74C74", VA = "0xE74C74")]
		private void Start()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xE74CA4", Offset = "0xE74CA4", VA = "0xE74CA4")]
		private void Update()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xE74DC8", Offset = "0xE74DC8", VA = "0xE74DC8")]
		private void Teleport()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xE74E74", Offset = "0xE74E74", VA = "0xE74E74")]
		public TeleportationBall()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Experiments.BatTetris.Scripts
{
	[Token(Token = "0x20001D6")]
	public class BatTetrisController : MonoBehaviour
	{
		[Token(Token = "0x20001D7")]
		[CompilerGenerated]
		private sealed class <TestWaves>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BatTetrisController <>4__this;

			[Token(Token = "0x170000F4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000864")]
				[Address(RVA = "0xE753CC", Offset = "0xE753CC", VA = "0xE753CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000866")]
				[Address(RVA = "0xE75414", Offset = "0xE75414", VA = "0xE75414", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0xE75184", Offset = "0xE75184", VA = "0xE75184")]
			[DebuggerHidden]
			public <TestWaves>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000862")]
			[Address(RVA = "0xE751B4", Offset = "0xE751B4", VA = "0xE751B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000863")]
			[Address(RVA = "0xE751B8", Offset = "0xE751B8", VA = "0xE751B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000865")]
			[Address(RVA = "0xE753D4", Offset = "0xE753D4", VA = "0xE753D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BatTetrisWavePositions[] m_Waves;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_WavesSpawnPosition;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ReplayGameScoreboard m_Scoreboard;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_BatTetrisWavePrefab;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_NextWave;

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xE74E88", Offset = "0xE74E88", VA = "0xE74E88")]
		private void Start()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xE74F10", Offset = "0xE74F10", VA = "0xE74F10")]
		private void SpawnWave(int waveNumber)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xE75144", Offset = "0xE75144", VA = "0xE75144")]
		private void SpawnNextWave()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xE74EA8", Offset = "0xE74EA8", VA = "0xE74EA8")]
		[IteratorStateMachine(typeof(<TestWaves>d__8))]
		private IEnumerator TestWaves()
		{
			return null;
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xE751AC", Offset = "0xE751AC", VA = "0xE751AC")]
		public BatTetrisController()
		{
		}
	}
	[Token(Token = "0x20001D8")]
	public class BatTetrisOutline : MonoBehaviour
	{
		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Transform m_Top;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Transform m_Bottom;

		[Token(Token = "0x170000F6")]
		public bool awardedPoints
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0xE7541C", Offset = "0xE7541C", VA = "0xE7541C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000868")]
			[Address(RVA = "0xE75424", Offset = "0xE75424", VA = "0xE75424")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xE75430", Offset = "0xE75430", VA = "0xE75430")]
		public BatTetrisOutline()
		{
		}
	}
	[Token(Token = "0x20001D9")]
	public class BatTetrisWave : MonoBehaviour
	{
		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BatTetrisOutline m_RightBatOutline;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BatTetrisOutline m_LeftBatOutline;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ReplayGameScoreboard m_Scoreboard;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject m_TriggeredBat;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_BothBatsTriggered;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Points;

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xE75438", Offset = "0xE75438", VA = "0xE75438")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xE75084", Offset = "0xE75084", VA = "0xE75084")]
		public void SetPositions(Transform rightBat, Transform leftBat)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xE758D4", Offset = "0xE758D4", VA = "0xE758D4")]
		public void SetScoreboard(ReplayGameScoreboard scoreboard)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xE755BC", Offset = "0xE755BC", VA = "0xE755BC")]
		private void CalculateScore(TetrisBatExtension extension)
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xE758DC", Offset = "0xE758DC", VA = "0xE758DC")]
		private void Score(float points)
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xE75A3C", Offset = "0xE75A3C", VA = "0xE75A3C")]
		public BatTetrisWave()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001DA")]
	public class BatTetrisWavePositions
	{
		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform m_LeftBatOutline;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform m_RightBatOutline;

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xE75A44", Offset = "0xE75A44", VA = "0xE75A44")]
		public BatTetrisWavePositions(Transform rightBatOutline, Transform leftBatOutline)
		{
		}
	}
	[Token(Token = "0x20001DB")]
	public class TechnoWall : MonoBehaviour
	{
		[Token(Token = "0x20001DC")]
		[CompilerGenerated]
		private sealed class <SequentialMonoColour>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TechnoWall <>4__this;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Material exceptThisMaterial;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Material <mat>5__2;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Renderer[] <>7__wrap2;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <>7__wrap3;

			[Token(Token = "0x170000F7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600087C")]
				[Address(RVA = "0xE75F1C", Offset = "0xE75F1C", VA = "0xE75F1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600087E")]
				[Address(RVA = "0xE75F64", Offset = "0xE75F64", VA = "0xE75F64", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0xE75D7C", Offset = "0xE75D7C", VA = "0xE75D7C")]
			[DebuggerHidden]
			public <SequentialMonoColour>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600087A")]
			[Address(RVA = "0xE75DDC", Offset = "0xE75DDC", VA = "0xE75DDC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0xE75DE0", Offset = "0xE75DE0", VA = "0xE75DE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600087D")]
			[Address(RVA = "0xE75F24", Offset = "0xE75F24", VA = "0xE75F24", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001DD")]
		[CompilerGenerated]
		private sealed class <SequentialMonoColourReverse>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TechnoWall <>4__this;

			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Material exceptThisMaterial;

			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Material <mat>5__2;

			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <i>5__3;

			[Token(Token = "0x170000F9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000882")]
				[Address(RVA = "0xE760A4", Offset = "0xE760A4", VA = "0xE760A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000884")]
				[Address(RVA = "0xE760EC", Offset = "0xE760EC", VA = "0xE760EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0xE75DA4", Offset = "0xE75DA4", VA = "0xE75DA4")]
			[DebuggerHidden]
			public <SequentialMonoColourReverse>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0xE75F6C", Offset = "0xE75F6C", VA = "0xE75F6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0xE75F70", Offset = "0xE75F70", VA = "0xE75F70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0xE760AC", Offset = "0xE760AC", VA = "0xE760AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Renderer[] m_WallSegments;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material[] m_Materials;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_ColourChangeCooldown;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_NextAction;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material m_WallMat;

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xE75A70", Offset = "0xE75A70", VA = "0xE75A70")]
		private void Start()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xE75BA4", Offset = "0xE75BA4", VA = "0xE75BA4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xE75BE0", Offset = "0xE75BE0", VA = "0xE75BE0")]
		private void ColourAction()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xE75CC4", Offset = "0xE75CC4", VA = "0xE75CC4")]
		private Material GetRandomMaterial([Optional] Material exceptThisMaterial)
		{
			return null;
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xE75C50", Offset = "0xE75C50", VA = "0xE75C50")]
		[IteratorStateMachine(typeof(<SequentialMonoColour>d__9))]
		private IEnumerator SequentialMonoColour([Optional] Material exceptThisMaterial)
		{
			return null;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xE75B30", Offset = "0xE75B30", VA = "0xE75B30")]
		[IteratorStateMachine(typeof(<SequentialMonoColourReverse>d__10))]
		private IEnumerator SequentialMonoColourReverse([Optional] Material exceptThisMaterial)
		{
			return null;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xE75A9C", Offset = "0xE75A9C", VA = "0xE75A9C")]
		private void AllRandomColours()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xE75DCC", Offset = "0xE75DCC", VA = "0xE75DCC")]
		public TechnoWall()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Ending.Credits
{
	[Token(Token = "0x20001DE")]
	public class HideBasedOnProgression : MonoBehaviour
	{
		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LevelData m_LevelData;

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xE760F4", Offset = "0xE760F4", VA = "0xE760F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xE761C4", Offset = "0xE761C4", VA = "0xE761C4")]
		public HideBasedOnProgression()
		{
		}
	}
	[Token(Token = "0x20001DF")]
	public class OpenMainMenu : MonoBehaviour
	{
		[Token(Token = "0x6000888")]
		[Address(RVA = "0xE76250", Offset = "0xE76250", VA = "0xE76250")]
		public void OpenMenuFromCredits()
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xE762A8", Offset = "0xE762A8", VA = "0xE762A8")]
		public OpenMainMenu()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Downtown__Young_.Pinball.Scripts
{
	[Token(Token = "0x20001E0")]
	public class Flipper : MonoBehaviour
	{
		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HingeJoint m_HingeJoint;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StateButton m_Button;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_ButtonDownTargetPosition;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_ButtonUpTargetPosition;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Event m_OnFlipSfx;

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xE762B0", Offset = "0xE762B0", VA = "0xE762B0")]
		private void Start()
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xE7638C", Offset = "0xE7638C", VA = "0xE7638C")]
		private void OnStateChange(bool obj)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xE76440", Offset = "0xE76440", VA = "0xE76440")]
		public Flipper()
		{
		}
	}
	[Token(Token = "0x20001E1")]
	public class LaserProjectileOutOfBounds : MonoBehaviour
	{
		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_EffectPrefab;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ObjectPool<GameObject> m_EffectPool;

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xE76448", Offset = "0xE76448", VA = "0xE76448")]
		private void Awake()
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xE7652C", Offset = "0xE7652C", VA = "0xE7652C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xE7672C", Offset = "0xE7672C", VA = "0xE7672C")]
		public LaserProjectileOutOfBounds()
		{
		}
	}
	[Token(Token = "0x20001E3")]
	public class PinballBumper : MonoBehaviour
	{
		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_RepelImpulseStrength;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_RandomImpulse;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Event m_AudioEvent;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_Model;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent m_OnHit;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_InitialScale;

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xE76800", Offset = "0xE76800", VA = "0xE76800")]
		private void Start()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xE76830", Offset = "0xE76830", VA = "0xE76830")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xE76AC0", Offset = "0xE76AC0", VA = "0xE76AC0")]
		public PinballBumper()
		{
		}
	}
	[Token(Token = "0x20001E4")]
	[RequireComponent(typeof(SubGoal))]
	public class RubberDuckInvader : MonoBehaviour
	{
		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_DestructionEffectPrefab;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_DestructionEffectScaleMultiplier;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Event m_DestructionSFX;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SubGoal m_SubGoal;

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xE76AD4", Offset = "0xE76AD4", VA = "0xE76AD4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xE76B24", Offset = "0xE76B24", VA = "0xE76B24")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xE76DCC", Offset = "0xE76DCC", VA = "0xE76DCC")]
		public RubberDuckInvader()
		{
		}
	}
	[Token(Token = "0x20001E5")]
	public class SpaceInvadersGame : MonoBehaviour
	{
		[Token(Token = "0x20001E6")]
		[CompilerGenerated]
		private sealed class <Start>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400092C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400092D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpaceInvadersGame <>4__this;

			[Token(Token = "0x170000FB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A3")]
				[Address(RVA = "0xE77680", Offset = "0xE77680", VA = "0xE77680", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A5")]
				[Address(RVA = "0xE776C8", Offset = "0xE776C8", VA = "0xE776C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xE77020", Offset = "0xE77020", VA = "0xE77020")]
			[DebuggerHidden]
			public <Start>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0xE77608", Offset = "0xE77608", VA = "0xE77608", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0xE7760C", Offset = "0xE7760C", VA = "0xE7760C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0xE77688", Offset = "0xE77688", VA = "0xE77688", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] m_AlienLine;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_SpeedInitial;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_SpeedMax;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_MoveDistance;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_VerticalMoveDistance;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_MaxAlienX;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform m_MinAlienX;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform m_AlienWinsZPosition;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[OptionalReference]
		[SerializeField]
		private CountdownScoreboard m_Scoreboard;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[OptionalReference]
		private TrophyFillScoreBoard m_TrophyScoreboard;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[][] m_AlienTransforms;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_SpeedIncrement;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_NextMove;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int m_LineToMove;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int m_FixedStepsBetweenEachLineMove;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int m_FixedStepsSinceLastMove;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_StartCount;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int m_Direction;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool m_MoveDown;

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xE76DDC", Offset = "0xE76DDC", VA = "0xE76DDC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xE76FB8", Offset = "0xE76FB8", VA = "0xE76FB8")]
		[IteratorStateMachine(typeof(<Start>d__20))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xE77048", Offset = "0xE77048", VA = "0xE77048")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xE7734C", Offset = "0xE7734C", VA = "0xE7734C")]
		private int GetCurrentCount()
		{
			return default(int);
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xE77114", Offset = "0xE77114", VA = "0xE77114")]
		private void Move()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xE7740C", Offset = "0xE7740C", VA = "0xE7740C")]
		private void CheckEdge()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xE775E4", Offset = "0xE775E4", VA = "0xE775E4")]
		public SpaceInvadersGame()
		{
		}
	}
	[Token(Token = "0x20001E7")]
	public class SpawnDirectionalEffectOnCollision : MonoBehaviour
	{
		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SpawnDirectionalEffectOnCollision s_PoolOwner;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_EffectPrefab;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ObjectPool<GameObject> m_EffectPool;

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xE776D0", Offset = "0xE776D0", VA = "0xE776D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xE77824", Offset = "0xE77824", VA = "0xE77824")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xE77908", Offset = "0xE77908", VA = "0xE77908")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xE77B68", Offset = "0xE77B68", VA = "0xE77B68")]
		public SpawnDirectionalEffectOnCollision()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Downtown__Young_.DowntownYoungPhotoOp
{
	[Token(Token = "0x20001E9")]
	public class BasketBallGameController : MonoBehaviour
	{
		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly GameObjectFilter m_GroundFilter;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly GameObjectFilter m_UniversalTag;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CountUpScoreBoard m_ScoreBoard;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_ShootCooldown;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_FirstShotDelay;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve m_DifficultyCurve;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_MaxScore;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_MinShootDelay;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 m_SpeedRange;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform m_TrunkEndTransform;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Rigidbody m_RigidBodyPrefab;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector2 m_Height;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Space]
		private static readonly int Shoot;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int PrepareShot;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Event m_ShootSound;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Animator m_Animator;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector3 m_PunchScale;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Event m_FailSFX;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private List<ColorRemapEffect> m_ColorRemappers;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float m_NextShoot;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool m_IsPlaying;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float m_Score;

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xE77C58", Offset = "0xE77C58", VA = "0xE77C58")]
		private void Start()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xE77CF8", Offset = "0xE77CF8", VA = "0xE77CF8")]
		private void UpdateScore()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xE77D68", Offset = "0xE77D68", VA = "0xE77D68")]
		public void GameOver()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xE77F20", Offset = "0xE77F20", VA = "0xE77F20")]
		public void Reset()
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xE78084", Offset = "0xE78084", VA = "0xE78084")]
		private void ShootBall()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xE784FC", Offset = "0xE784FC", VA = "0xE784FC")]
		private void CollisionOnOnTriggerEnterEvent(Collider other, GameObject basketBall)
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xE78670", Offset = "0xE78670", VA = "0xE78670")]
		private void CollisionOnOnCollisionEnterEvent(Collision other, GameObject basketBall)
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xE78760", Offset = "0xE78760", VA = "0xE78760")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xE78294", Offset = "0xE78294", VA = "0xE78294")]
		private void ThrowBack(Rigidbody rb)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xE787B8", Offset = "0xE787B8", VA = "0xE787B8")]
		public void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xE789A0", Offset = "0xE789A0", VA = "0xE789A0")]
		private void AddForceToRb(Rigidbody rb)
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xE78890", Offset = "0xE78890", VA = "0xE78890")]
		private Vector3 GetThrowVelocity(bool averageSpeed = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xE78AE4", Offset = "0xE78AE4", VA = "0xE78AE4")]
		private static Vector3 GetTarget(float shootHeight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xE78D00", Offset = "0xE78D00", VA = "0xE78D00")]
		public BasketBallGameController()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Downtown__Young_.Dog.Scripts
{
	[Token(Token = "0x20001ED")]
	public class BushWithThing : MonoBehaviour
	{
		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Thing;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_IsFetched;

		[Token(Token = "0x170000FD")]
		public bool isFetched
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0xE79084", Offset = "0xE79084", VA = "0xE79084")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xE7908C", Offset = "0xE7908C", VA = "0xE7908C")]
		public void DeactivateThing()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xE790BC", Offset = "0xE790BC", VA = "0xE790BC")]
		public BushWithThing()
		{
		}
	}
	[Token(Token = "0x20001EE")]
	public class DogFetch : MonoBehaviour
	{
		[Token(Token = "0x20001EF")]
		private enum State
		{
			[Token(Token = "0x400095F")]
			Idle,
			[Token(Token = "0x4000960")]
			Fetching,
			[Token(Token = "0x4000961")]
			Returning,
			[Token(Token = "0x4000962")]
			FetchingInBush,
			[Token(Token = "0x4000963")]
			ReturningFromBush
		}

		[Token(Token = "0x4000950")]
		private const float k_MinDistToTarget = 0.4f;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private NavMeshAgent m_Agent;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_HeadTransform;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> m_Items;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Event m_OnFound;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Event m_OnSpitOut;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Event m_OnStart;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private State m_State;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_StartingPosition;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_Index;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 m_Destination;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 m_DestinationInBush;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private BushWithThing m_BushWithThing;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody m_NormalStick;

		[Token(Token = "0x170000FE")]
		private bool atDestination
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xE790C4", Offset = "0xE790C4", VA = "0xE790C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FF")]
		private bool canNotFetch
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0xE7919C", Offset = "0xE7919C", VA = "0xE7919C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xE791C0", Offset = "0xE791C0", VA = "0xE791C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xE791F0", Offset = "0xE791F0", VA = "0xE791F0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xE79298", Offset = "0xE79298", VA = "0xE79298")]
		private void ReachedNormalStick()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xE794BC", Offset = "0xE794BC", VA = "0xE794BC")]
		private void ReachedBush()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xE795A0", Offset = "0xE795A0", VA = "0xE795A0")]
		private void ReturnedFromBush()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xE79394", Offset = "0xE79394", VA = "0xE79394")]
		private void DropNormalStick()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xE7978C", Offset = "0xE7978C", VA = "0xE7978C")]
		public bool FetchWithNavMesh(GameObject stick)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xE79898", Offset = "0xE79898", VA = "0xE79898")]
		public bool FetchInBush(BushWithThing bush, Vector3 position)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xE799A0", Offset = "0xE799A0", VA = "0xE799A0")]
		public DogFetch()
		{
		}
	}
	[Token(Token = "0x20001F0")]
	public class Stick : MonoBehaviour
	{
		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rigidbody m_Rb;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeReference]
		private GameObjectFilter m_BushFilter;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DogFetch m_Dog;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly GameObjectFilter m_GroundFilter;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_IsBeingFetched;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool m_IsBeingDespawned;

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xE799A8", Offset = "0xE799A8", VA = "0xE799A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xE79A4C", Offset = "0xE79A4C", VA = "0xE79A4C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xE79B70", Offset = "0xE79B70", VA = "0xE79B70")]
		private void OnCollisionStay(Collision collisionInfo)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xE79D00", Offset = "0xE79D00", VA = "0xE79D00")]
		public Stick()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Downtown__Adult_.FruitNinja.Code
{
	[Token(Token = "0x20001F1")]
	public class SlowMotionThrow : MonoBehaviour
	{
		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationCurve m_SlowdownCurve;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_StartThrowOnEnable;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_StartSpeed;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("m_OnCollisionEnter")]
		[SerializeField]
		private UnityEvent m_OnGroundCollision;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_Velocity;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_InitialUpwardsSpeed;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsActive;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Animator m_Animator;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform m_SpawnPosition;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector3 m_SpawnOffset;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Shoot;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_IsDespawning;

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xE79D98", Offset = "0xE79D98", VA = "0xE79D98")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xE79DE8", Offset = "0xE79DE8", VA = "0xE79DE8")]
		private void Start()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xE79E98", Offset = "0xE79E98", VA = "0xE79E98")]
		private void Update()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xE7A05C", Offset = "0xE7A05C", VA = "0xE7A05C")]
		public void StartThrow(Vector3 velocity)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xE79E00", Offset = "0xE79E00", VA = "0xE79E00")]
		public void StartThrowForward()
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xE7A194", Offset = "0xE7A194", VA = "0xE7A194")]
		public SlowMotionThrow()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Downtown._OnHold.SwingDoor.Scripts
{
	[Token(Token = "0x20001F3")]
	public class ObjectTransformer : MonoBehaviour
	{
		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_ToActivate;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_ToDeactivate;

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xE7A2C4", Offset = "0xE7A2C4", VA = "0xE7A2C4")]
		public void Swap()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xE7A2FC", Offset = "0xE7A2FC", VA = "0xE7A2FC")]
		public ObjectTransformer()
		{
		}
	}
	[Token(Token = "0x20001F4")]
	public class SwingDoor : MonoBehaviour
	{
		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rigidbody m_Pole;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_VelMultiplyAboveThreshold;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("OnAbove")]
		[SerializeField]
		private UnityEvent m_OnAbove;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_EnabletrophyHeight;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Rigidbody> m_ObjectsInCarousel;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_StartY;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool m_Lower;

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xE7A304", Offset = "0xE7A304", VA = "0xE7A304")]
		private void Start()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xE7A37C", Offset = "0xE7A37C", VA = "0xE7A37C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xE7A618", Offset = "0xE7A618", VA = "0xE7A618")]
		public void LowerAngularDrag()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xE7A610", Offset = "0xE7A610", VA = "0xE7A610")]
		private Vector3 FlatY(Vector3 v, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xE7A624", Offset = "0xE7A624", VA = "0xE7A624")]
		public SwingDoor()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Downtown._OnHold.SeagullRobbery.Scripts
{
	[Token(Token = "0x20001F5")]
	public class SeagullRobbery : MonoBehaviour
	{
		[Token(Token = "0x20001F6")]
		[CompilerGenerated]
		private sealed class <SpawnSeagull>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SeagullRobbery <>4__this;

			[Token(Token = "0x17000100")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008EF")]
				[Address(RVA = "0xE7A910", Offset = "0xE7A910", VA = "0xE7A910", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000101")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008F1")]
				[Address(RVA = "0xE7A958", Offset = "0xE7A958", VA = "0xE7A958", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008EC")]
			[Address(RVA = "0xE7A73C", Offset = "0xE7A73C", VA = "0xE7A73C")]
			[DebuggerHidden]
			public <SpawnSeagull>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60008ED")]
			[Address(RVA = "0xE7A76C", Offset = "0xE7A76C", VA = "0xE7A76C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0xE7A770", Offset = "0xE7A770", VA = "0xE7A770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0xE7A918", Offset = "0xE7A918", VA = "0xE7A918", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_TrophyHit;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_Period;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_SeagullWithTrophy;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Transform> m_WindowPositions;

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xE7A6B4", Offset = "0xE7A6B4", VA = "0xE7A6B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xE7A6D4", Offset = "0xE7A6D4", VA = "0xE7A6D4")]
		[IteratorStateMachine(typeof(<SpawnSeagull>d__5))]
		private IEnumerator SpawnSeagull()
		{
			return null;
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xE7A764", Offset = "0xE7A764", VA = "0xE7A764")]
		public SeagullRobbery()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Downtown._OnHold.RoadFetch.Scripts
{
	[Token(Token = "0x20001F7")]
	public class FetchBallOnSpawn : MonoBehaviour
	{
		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FetchingDog m_FetchingDog;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DefaultHittable m_Hittable;

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0xE7A960", Offset = "0xE7A960", VA = "0xE7A960")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0xE7AAB8", Offset = "0xE7AAB8", VA = "0xE7AAB8")]
		private void DoFetch()
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0xE7AAE4", Offset = "0xE7AAE4", VA = "0xE7AAE4")]
		public FetchBallOnSpawn()
		{
		}
	}
	[Token(Token = "0x20001F8")]
	public class FlyPoopLogic : MonoBehaviour
	{
		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Dog m_Dog;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MoveObject m_MoveObject;

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0xE7AAEC", Offset = "0xE7AAEC", VA = "0xE7AAEC")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0xE7AB94", Offset = "0xE7AB94", VA = "0xE7AB94")]
		private void CheckInteraction(DogInteraction interaction)
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0xE7AD0C", Offset = "0xE7AD0C", VA = "0xE7AD0C")]
		private void CheckPoop(GameObject poop)
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xE7ADB0", Offset = "0xE7ADB0", VA = "0xE7ADB0")]
		public FlyPoopLogic()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Downtown.Shop.Scripts
{
	[Token(Token = "0x20001F9")]
	public class Zebra : MonoBehaviour
	{
		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Mesh m_HorseMesh;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_ZebraStripePrefab;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_OnFullyPainted;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MeshRenderer[] m_MeshRenderers;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_NumPainted;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int m_ThresHold;

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0xE7ADB8", Offset = "0xE7ADB8", VA = "0xE7ADB8")]
		private void Start()
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0xE7B1D0", Offset = "0xE7B1D0", VA = "0xE7B1D0")]
		private void OnHitAction(Collider other, GameObject g)
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xE7B35C", Offset = "0xE7B35C", VA = "0xE7B35C")]
		public Zebra()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Downtown.Pinball.Scripts
{
	[Token(Token = "0x20001FB")]
	public class AlienLine : MonoBehaviour
	{
		[Token(Token = "0x20001FD")]
		[CompilerGenerated]
		private sealed class <Start>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AlienLine <>4__this;

			[Token(Token = "0x17000102")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000908")]
				[Address(RVA = "0xE7B9C0", Offset = "0xE7B9C0", VA = "0xE7B9C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000103")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600090A")]
				[Address(RVA = "0xE7BA08", Offset = "0xE7BA08", VA = "0xE7BA08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000905")]
			[Address(RVA = "0xE7B458", Offset = "0xE7B458", VA = "0xE7B458")]
			[DebuggerHidden]
			public <Start>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000906")]
			[Address(RVA = "0xE7B800", Offset = "0xE7B800", VA = "0xE7B800", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000907")]
			[Address(RVA = "0xE7B804", Offset = "0xE7B804", VA = "0xE7B804", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0xE7B9C8", Offset = "0xE7B9C8", VA = "0xE7B9C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001FE")]
		[CompilerGenerated]
		private sealed class <StartShooting>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AlienLine <>4__this;

			[Token(Token = "0x17000104")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600090E")]
				[Address(RVA = "0xE7BCE0", Offset = "0xE7BCE0", VA = "0xE7BCE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000105")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000910")]
				[Address(RVA = "0xE7BD28", Offset = "0xE7BD28", VA = "0xE7BD28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600090B")]
			[Address(RVA = "0xE7B4E8", Offset = "0xE7B4E8", VA = "0xE7B4E8")]
			[DebuggerHidden]
			public <StartShooting>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600090C")]
			[Address(RVA = "0xE7BA10", Offset = "0xE7BA10", VA = "0xE7BA10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600090D")]
			[Address(RVA = "0xE7BA14", Offset = "0xE7BA14", VA = "0xE7BA14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600090F")]
			[Address(RVA = "0xE7BCE8", Offset = "0xE7BCE8", VA = "0xE7BCE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_LaserPrefab;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Transform> m_Chickens;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_ShootInterval;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_ShootStartDelay;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 m_ShootOffset;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<ParticleSystem> m_ShootVFX;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_AlienIndex;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool m_IsFailed;

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xE7B3F0", Offset = "0xE7B3F0", VA = "0xE7B3F0")]
		[IteratorStateMachine(typeof(<Start>d__8))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xE7B480", Offset = "0xE7B480", VA = "0xE7B480")]
		[IteratorStateMachine(typeof(<StartShooting>d__9))]
		private IEnumerator StartShooting()
		{
			return null;
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xE7B510", Offset = "0xE7B510", VA = "0xE7B510")]
		public void GameOver()
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xE7B73C", Offset = "0xE7B73C", VA = "0xE7B73C")]
		public AlienLine()
		{
		}
	}
	[Token(Token = "0x20001FF")]
	public class BreakoutBlock : MonoBehaviour
	{
		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static BreakoutBlock[] s_Instances;

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int s_TweenId;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_Model;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Event m_BreakSFX;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ParticleSystem m_BreakEffect;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TrophyFillScoreBoard m_TrophyFillScoreBoard;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_HasBeenHit;

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xE7BD30", Offset = "0xE7BD30", VA = "0xE7BD30")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xE7BEF4", Offset = "0xE7BEF4", VA = "0xE7BEF4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xE7BFE8", Offset = "0xE7BFE8", VA = "0xE7BFE8")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xE7C0B0", Offset = "0xE7C0B0", VA = "0xE7C0B0")]
		private void Hit()
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xE7C224", Offset = "0xE7C224", VA = "0xE7C224")]
		private static void ShakeOthers(BreakoutBlock origin)
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xE7C610", Offset = "0xE7C610", VA = "0xE7C610")]
		public BreakoutBlock()
		{
		}
	}
	[Token(Token = "0x2000200")]
	[RequireComponent(typeof(Rigidbody))]
	public class ConstantMoveKinematicRigidbody : MonoBehaviour
	{
		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector3 m_Direction;

		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xE7C618", Offset = "0xE7C618", VA = "0xE7C618")]
		private void Start()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xE7C668", Offset = "0xE7C668", VA = "0xE7C668")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xE7C7D4", Offset = "0xE7C7D4", VA = "0xE7C7D4")]
		public ConstantMoveKinematicRigidbody()
		{
		}
	}
	[Token(Token = "0x2000201")]
	public class SpaceInvadersShip : MonoBehaviour
	{
		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StateButton m_ButtonLeft;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StateButton m_ButtonRight;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StateButton m_ShootButton;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_ShootCooldown;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_MinimumX;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_MaxX;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject m_ShootPrefab;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform m_ShootSpawnPosition;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent m_OnTouchAlien;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Collider m_NoseCollider;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Collider m_HullCollider;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Event m_ShootSFX;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FailSituation m_FailSituation;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_ShootButtonDown;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float m_NextShot;

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xE7C7E4", Offset = "0xE7C7E4", VA = "0xE7C7E4")]
		private void Start()
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xE7C834", Offset = "0xE7C834", VA = "0xE7C834")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xE7CB20", Offset = "0xE7CB20", VA = "0xE7CB20")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xE7C98C", Offset = "0xE7C98C", VA = "0xE7C98C")]
		private void Shoot()
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xE7CBCC", Offset = "0xE7CBCC", VA = "0xE7CBCC")]
		public SpaceInvadersShip()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Downtown.MallElevator.Scenes
{
	[Token(Token = "0x2000202")]
	public class Elevator : MonoBehaviour
	{
		[Token(Token = "0x2000203")]
		[CompilerGenerated]
		private sealed class <CloseAndOpen>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Elevator <>4__this;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int i;

			[Token(Token = "0x17000106")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600092A")]
				[Address(RVA = "0xE7D238", Offset = "0xE7D238", VA = "0xE7D238", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000107")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600092C")]
				[Address(RVA = "0xE7D280", Offset = "0xE7D280", VA = "0xE7D280", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000927")]
			[Address(RVA = "0xE7D0D4", Offset = "0xE7D0D4", VA = "0xE7D0D4")]
			[DebuggerHidden]
			public <CloseAndOpen>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0xE7D104", Offset = "0xE7D104", VA = "0xE7D104", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000929")]
			[Address(RVA = "0xE7D108", Offset = "0xE7D108", VA = "0xE7D108", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0xE7D240", Offset = "0xE7D240", VA = "0xE7D240", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_LeftDoor;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_RightDoor;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_LeftDoorOpen;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_RightDoorOpen;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> m_Floors;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 m_LeftClosed;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_RightClosed;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 m_LeftOpen;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 m_RightOpen;

		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject m_CurrentFloor;

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xE7CBE8", Offset = "0xE7CBE8", VA = "0xE7CBE8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xE7CCAC", Offset = "0xE7CCAC", VA = "0xE7CCAC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xE7CDE4", Offset = "0xE7CDE4", VA = "0xE7CDE4")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xE7CC8C", Offset = "0xE7CC8C", VA = "0xE7CC8C")]
		public void OnButtonPush(int i)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xE7CFA4", Offset = "0xE7CFA4", VA = "0xE7CFA4")]
		private void CloseDoor()
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xE7D03C", Offset = "0xE7D03C", VA = "0xE7D03C")]
		private void OpenDoor()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xE7CF2C", Offset = "0xE7CF2C", VA = "0xE7CF2C")]
		[IteratorStateMachine(typeof(<CloseAndOpen>d__16))]
		private IEnumerator CloseAndOpen(int i)
		{
			return null;
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xE7D0FC", Offset = "0xE7D0FC", VA = "0xE7D0FC")]
		public Elevator()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Downtown.CityPeople.Scripts
{
	[Token(Token = "0x2000204")]
	public class AddUniversalTagOnObject : MonoBehaviour
	{
		[Token(Token = "0x600092D")]
		[Address(RVA = "0xE7D288", Offset = "0xE7D288", VA = "0xE7D288")]
		public void AddTag(GameObject obj)
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xE7D2D8", Offset = "0xE7D2D8", VA = "0xE7D2D8")]
		public AddUniversalTagOnObject()
		{
		}
	}
	[Token(Token = "0x2000205")]
	public class BatXTag : MonoBehaviour
	{
		[Token(Token = "0x600092F")]
		[Address(RVA = "0xE7D2E0", Offset = "0xE7D2E0", VA = "0xE7D2E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xE7D2E4", Offset = "0xE7D2E4", VA = "0xE7D2E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xE7D2E8", Offset = "0xE7D2E8", VA = "0xE7D2E8")]
		public BatXTag()
		{
		}
	}
	[Token(Token = "0x2000206")]
	public class PrisonCatTag : MonoBehaviour
	{
		[Token(Token = "0x6000932")]
		[Address(RVA = "0xE7D2F0", Offset = "0xE7D2F0", VA = "0xE7D2F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xE7D2F4", Offset = "0xE7D2F4", VA = "0xE7D2F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xE7D2F8", Offset = "0xE7D2F8", VA = "0xE7D2F8")]
		public PrisonCatTag()
		{
		}
	}
	[Token(Token = "0x2000207")]
	public class TheTag : MonoBehaviour
	{
		[Token(Token = "0x6000935")]
		[Address(RVA = "0xE7D300", Offset = "0xE7D300", VA = "0xE7D300")]
		private void Start()
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xE7D304", Offset = "0xE7D304", VA = "0xE7D304")]
		private void Update()
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xE7D308", Offset = "0xE7D308", VA = "0xE7D308")]
		public TheTag()
		{
		}
	}
	[Token(Token = "0x2000208")]
	public class WhatTag : MonoBehaviour
	{
		[Token(Token = "0x6000938")]
		[Address(RVA = "0xE7D310", Offset = "0xE7D310", VA = "0xE7D310")]
		private void Start()
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0xE7D314", Offset = "0xE7D314", VA = "0xE7D314")]
		private void Update()
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0xE7D318", Offset = "0xE7D318", VA = "0xE7D318")]
		public WhatTag()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Downtown.Cafe
{
	[Token(Token = "0x2000209")]
	public class CoffeeAndMilk : MonoBehaviour
	{
		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeReference]
		private GameObjectFilter m_MilkFilter;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeReference]
		private GameObjectFilter m_CoffeeFilter;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_Milk;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_Coffee;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject m_Both;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Event m_OnEnterCup;

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_HasMilk;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool m_HasCoffee;

		[Token(Token = "0x600093B")]
		[Address(RVA = "0xE7D320", Offset = "0xE7D320", VA = "0xE7D320")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0xE7D538", Offset = "0xE7D538", VA = "0xE7D538")]
		private void EnableBoth()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0xE7D644", Offset = "0xE7D644", VA = "0xE7D644")]
		public CoffeeAndMilk()
		{
		}
	}
	[Token(Token = "0x200020A")]
	public class Milk : MonoBehaviour
	{
		[Token(Token = "0x600093E")]
		[Address(RVA = "0xE7D64C", Offset = "0xE7D64C", VA = "0xE7D64C")]
		public Milk()
		{
		}
	}
	[Token(Token = "0x200020B")]
	public class Plate : MonoBehaviour
	{
		[Token(Token = "0x600093F")]
		[Address(RVA = "0xE7D654", Offset = "0xE7D654", VA = "0xE7D654")]
		private void Start()
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0xE7D658", Offset = "0xE7D658", VA = "0xE7D658")]
		private void Update()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0xE7D65C", Offset = "0xE7D65C", VA = "0xE7D65C")]
		public Plate()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Downtown.GraffitiPhotoOp.Scripts
{
	[Token(Token = "0x200020C")]
	[SelectionBase]
	public class LiftController : MonoBehaviour
	{
		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_LiftTransform;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_BoxTransform;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ContinuousLever[] m_HorizontalLevers;

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ContinuousLever[] m_VerticalLevers;

		[Token(Token = "0x40009DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_HorizontalSpeed;

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_VerticalSpeed;

		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_MaxHeight;

		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_Span;

		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 m_LiftStartPosition;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_MinHeight;

		[Token(Token = "0x6000942")]
		[Address(RVA = "0xE7D664", Offset = "0xE7D664", VA = "0xE7D664")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0xE7D69C", Offset = "0xE7D69C", VA = "0xE7D69C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0xE7D854", Offset = "0xE7D854", VA = "0xE7D854")]
		private void MoveLift(float amount)
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xE7D9F0", Offset = "0xE7D9F0", VA = "0xE7D9F0")]
		private void MoveBox(float amount)
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xE7DA74", Offset = "0xE7DA74", VA = "0xE7DA74")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xE7DC64", Offset = "0xE7DC64", VA = "0xE7DC64")]
		public LiftController()
		{
		}
	}
}
namespace WTB.Scenes.Levels.Downtown.ControlTraffic.Scripts
{
	[Token(Token = "0x200020E")]
	public class BomTag : MonoBehaviour
	{
		[Token(Token = "0x600094C")]
		[Address(RVA = "0xE7DD08", Offset = "0xE7DD08", VA = "0xE7DD08")]
		public BomTag()
		{
		}
	}
	[Token(Token = "0x200020F")]
	[RequireComponent(typeof(VehicleAudio))]
	[RequireComponent(typeof(SubGoal))]
	[RequireComponent(typeof(ConstantForce))]
	[RequireComponent(typeof(ApplyForce))]
	public class CarForSpringBoard : MonoBehaviour
	{
		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[OptionalReference]
		[SerializeField]
		private CarForSpringBoard m_NextCar;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_IsFirstCar;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VehicleAudio m_VehicleAudio;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Event m_CrashIntoCatsSfx;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_MoveBackDistOnHitCat;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve m_MoveBackCurve;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_HasHitSpringBoard;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool m_HasHitCat;

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xE7DD10", Offset = "0xE7DD10", VA = "0xE7DD10")]
		private void Awake()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xE7DE2C", Offset = "0xE7DE2C", VA = "0xE7DE2C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xE7DFD8", Offset = "0xE7DFD8", VA = "0xE7DFD8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xE7DDBC", Offset = "0xE7DDBC", VA = "0xE7DDBC")]
		private void StartCar()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xE7E2F0", Offset = "0xE7E2F0", VA = "0xE7E2F0")]
		public CarForSpringBoard()
		{
		}
	}
	[Token(Token = "0x2000210")]
	public class CityCar : MonoBehaviour
	{
		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MoveObjectAlongSpline m_MoveObjectAlongSpline;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SubGoal m_SubGoal;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VehicleAudio m_VehicleAudio;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent m_OnNeutralize;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent m_OnHitTarget;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_HasBeenNeutralized;

		[Token(Token = "0x17000108")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0xE7E3C0", Offset = "0xE7E3C0", VA = "0xE7E3C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000109")]
		public bool hasBeenNeutralized
		{
			[Token(Token = "0x6000954")]
			[Address(RVA = "0xE7E3C8", Offset = "0xE7E3C8", VA = "0xE7E3C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0xE7E3D0", Offset = "0xE7E3D0", VA = "0xE7E3D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0xE7E4B8", Offset = "0xE7E4B8", VA = "0xE7E4B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0xE7E4D8", Offset = "0xE7E4D8", VA = "0xE7E4D8")]
		public void Neutralize()
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0xE7E55C", Offset = "0xE7E55C", VA = "0xE7E55C")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0xE7E594", Offset = "0xE7E594", VA = "0xE7E594")]
		private void HandleOnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0xE7E69C", Offset = "0xE7E69C", VA = "0xE7E69C")]
		public CityCar()
		{
		}
	}
	[Token(Token = "0x2000211")]
	public class CityCarSpringBoard : MonoBehaviour
	{
		[Token(Token = "0x40009F4")]
		private const float k_ActiveDistance = 0.05f;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rigidbody m_LidRigidbody;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_OpenLidForce;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 m_AffectDirection;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AffectRandomSpread;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_AffectVelocity;

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_AffectAngularSpeed;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent m_OnSpring;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEvent m_OnLidDown;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform m_Transform;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_WasLidOpen;

		[Token(Token = "0x1700010A")]
		private bool isLidOpen
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0xE7E6A4", Offset = "0xE7E6A4", VA = "0xE7E6A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0xE7E774", Offset = "0xE7E774", VA = "0xE7E774")]
		private void Awake()
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0xE7E790", Offset = "0xE7E790", VA = "0xE7E790")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0xE7E914", Offset = "0xE7E914", VA = "0xE7E914")]
		private void Update()
		{
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0xE7E954", Offset = "0xE7E954", VA = "0xE7E954")]
		public void ActivateSpring()
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0xE7E9E8", Offset = "0xE7E9E8", VA = "0xE7E9E8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0xE7EC84", Offset = "0xE7EC84", VA = "0xE7EC84")]
		public CityCarSpringBoard()
		{
		}
	}
	[Token(Token = "0x2000213")]
	public class CityCarTarget : MonoBehaviour
	{
		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_OnHit;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_WasHit;

		[Token(Token = "0x1700010B")]
		public bool wasHit
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0xE7F004", Offset = "0xE7F004", VA = "0xE7F004")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xE7E674", Offset = "0xE7E674", VA = "0xE7E674")]
		public void Hit()
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xE7F00C", Offset = "0xE7F00C", VA = "0xE7F00C")]
		public CityCarTarget()
		{
		}
	}
	[Token(Token = "0x2000214")]
	[RequireComponent(typeof(FailSituation))]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(VehicleAudio))]
	public class ControlTrafficCarLane : MonoBehaviour
	{
		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[OptionalReference]
		private List<ControlTrafficCarLane> m_NextCars;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_IsFirstCar;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StartDelay;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AccelerationSpeed;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_DeAccelerationSpeed;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Event m_CrashIntoCatsSfx;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody m_Car;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_StopMoving;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_ActualSpeed;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private VehicleAudio m_VehicleAudio;

		[Token(Token = "0x6000968")]
		[Address(RVA = "0xE7F014", Offset = "0xE7F014", VA = "0xE7F014")]
		private void Start()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xE7F160", Offset = "0xE7F160", VA = "0xE7F160")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0xE7F25C", Offset = "0xE7F25C", VA = "0xE7F25C")]
		private void EnterBomTrigger()
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0xE7F268", Offset = "0xE7F268", VA = "0xE7F268")]
		private void EnterWinTrigger(MultiSubGoal multiSubGoal)
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0xE7F3E8", Offset = "0xE7F3E8", VA = "0xE7F3E8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0xE7F520", Offset = "0xE7F520", VA = "0xE7F520")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xE7F5C4", Offset = "0xE7F5C4", VA = "0xE7F5C4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0xE7F0C8", Offset = "0xE7F0C8", VA = "0xE7F0C8")]
		private void StartCar()
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0xE7F754", Offset = "0xE7F754", VA = "0xE7F754")]
		public ControlTrafficCarLane()
		{
		}
	}
	[Token(Token = "0x2000215")]
	public class HitTheCarsSituation : MonoBehaviour
	{
		[Token(Token = "0x2000216")]
		[CompilerGenerated]
		private sealed class <DelayedStop>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HitTheCarsSituation <>4__this;

			[Token(Token = "0x1700010C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600097B")]
				[Address(RVA = "0xE7FAD4", Offset = "0xE7FAD4", VA = "0xE7FAD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600097D")]
				[Address(RVA = "0xE7FB1C", Offset = "0xE7FB1C", VA = "0xE7FB1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0xE7F8E8", Offset = "0xE7F8E8", VA = "0xE7F8E8")]
			[DebuggerHidden]
			public <DelayedStop>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0xE7F9F0", Offset = "0xE7F9F0", VA = "0xE7F9F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0xE7F9F4", Offset = "0xE7F9F4", VA = "0xE7F9F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600097C")]
			[Address(RVA = "0xE7FADC", Offset = "0xE7FADC", VA = "0xE7FADC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000217")]
		[CompilerGenerated]
		private sealed class <Sequence>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HitTheCarsSituation <>4__this;

			[Token(Token = "0x4000A17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private CityCar[] <>7__wrap1;

			[Token(Token = "0x4000A18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <>7__wrap2;

			[Token(Token = "0x1700010E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000981")]
				[Address(RVA = "0xE7FC44", Offset = "0xE7FC44", VA = "0xE7FC44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000983")]
				[Address(RVA = "0xE7FC8C", Offset = "0xE7FC8C", VA = "0xE7FC8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600097E")]
			[Address(RVA = "0xE7F978", Offset = "0xE7F978", VA = "0xE7F978")]
			[DebuggerHidden]
			public <Sequence>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600097F")]
			[Address(RVA = "0xE7FB24", Offset = "0xE7FB24", VA = "0xE7FB24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000980")]
			[Address(RVA = "0xE7FB28", Offset = "0xE7FB28", VA = "0xE7FB28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000982")]
			[Address(RVA = "0xE7FC4C", Offset = "0xE7FC4C", VA = "0xE7FC4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CityCar[] m_CityCars;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_StartIntervalBetweenCars;

		[Token(Token = "0x6000972")]
		[Address(RVA = "0xE7F778", Offset = "0xE7F778", VA = "0xE7F778")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0xE7F880", Offset = "0xE7F880", VA = "0xE7F880")]
		[IteratorStateMachine(typeof(<DelayedStop>d__3))]
		private IEnumerator DelayedStop()
		{
			return null;
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0xE7F910", Offset = "0xE7F910", VA = "0xE7F910")]
		[IteratorStateMachine(typeof(<Sequence>d__4))]
		private IEnumerator Sequence()
		{
			return null;
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0xE7F9A0", Offset = "0xE7F9A0", VA = "0xE7F9A0")]
		public HitTheCarsSituation()
		{
		}
	}
}
namespace WTB.Scenes.Hub.Scripts
{
	[Token(Token = "0x2000218")]
	public class ChapterItem : MonoBehaviour
	{
		[Token(Token = "0x2000219")]
		[CompilerGenerated]
		private sealed class <Reveal>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ChapterItem <>4__this;

			[Token(Token = "0x17000110")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600098F")]
				[Address(RVA = "0xE804C4", Offset = "0xE804C4", VA = "0xE804C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000111")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000991")]
				[Address(RVA = "0xE8050C", Offset = "0xE8050C", VA = "0xE8050C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600098C")]
			[Address(RVA = "0xE8012C", Offset = "0xE8012C", VA = "0xE8012C")]
			[DebuggerHidden]
			public <Reveal>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0xE8015C", Offset = "0xE8015C", VA = "0xE8015C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600098E")]
			[Address(RVA = "0xE80160", Offset = "0xE80160", VA = "0xE80160", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000990")]
			[Address(RVA = "0xE804CC", Offset = "0xE804CC", VA = "0xE804CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ChapterData m_UnlockAfterChapter;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_CameraTransform;

		[Token(Token = "0x6000984")]
		[Address(RVA = "0xE7FC94", Offset = "0xE7FC94", VA = "0xE7FC94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0xE7FCE8", Offset = "0xE7FCE8", VA = "0xE7FCE8")]
		private bool HasBeenUnlocked()
		{
			return default(bool);
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0xE7FE6C", Offset = "0xE7FE6C", VA = "0xE7FE6C")]
		private bool HasBeenRevealed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0xE7FF48", Offset = "0xE7FF48", VA = "0xE7FF48")]
		private bool CanBeSeenByPlayer()
		{
			return default(bool);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0xE800A8", Offset = "0xE800A8", VA = "0xE800A8")]
		private void SaveRevealStatus()
		{
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0xE7FDDC", Offset = "0xE7FDDC", VA = "0xE7FDDC")]
		private void SetChildrenActive(bool active)
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0xE7FEE0", Offset = "0xE7FEE0", VA = "0xE7FEE0")]
		[IteratorStateMachine(typeof(<Reveal>d__8))]
		private IEnumerator Reveal()
		{
			return null;
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xE80154", Offset = "0xE80154", VA = "0xE80154")]
		public ChapterItem()
		{
		}
	}
	[Token(Token = "0x200021A")]
	public class RevealEffectsManager : MonoBehaviour
	{
		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_ObjectSpawnEffectPrefab;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_ConfettiPrefab;

		[Token(Token = "0x6000992")]
		[Address(RVA = "0xE80384", Offset = "0xE80384", VA = "0xE80384")]
		public void ShowSpawnEffect(Vector3 position)
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0xE80514", Offset = "0xE80514", VA = "0xE80514")]
		public RevealEffectsManager()
		{
		}
	}
	[Token(Token = "0x200021B")]
	public class UIPrompt : MonoBehaviour
	{
		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Collider m_ObjectCollider;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Canvas m_Canvas;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_HoldAction;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_AlwaysFacePlayer;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Mask")]
		[SerializeField]
		private RectTransform m_MaskTransform;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[ColorReference]
		[Header("Hold Timer")]
		private Triband.ColorPipeline.Runtime.SerializableGUID m_HoldTimerColor;

		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image m_HoldTimerImage;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("How much time the hold timer needs to be held down.")]
		private float m_HoldTimerDuration;

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AnimationCurve m_HoldTimerCurve;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform m_CameraTransform;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private CanvasGroup m_CanvasGroup;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float m_HoldTimer;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float m_Width;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_Ready;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool m_Enabled;

		[Token(Token = "0x6000994")]
		[Address(RVA = "0xE8051C", Offset = "0xE8051C", VA = "0xE8051C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0xE80708", Offset = "0xE80708", VA = "0xE80708")]
		private void PlayerStartedLookingAtObject()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0xE807BC", Offset = "0xE807BC", VA = "0xE807BC")]
		private void PlayerStoppedLookingAtObject()
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0xE808BC", Offset = "0xE808BC", VA = "0xE808BC")]
		private void InvokeHoldAction()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xE80778", Offset = "0xE80778", VA = "0xE80778")]
		private void ToggleCanvas(bool state)
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xE80AB8", Offset = "0xE80AB8", VA = "0xE80AB8")]
		private void Update()
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xE80B34", Offset = "0xE80B34", VA = "0xE80B34")]
		private void TryToInitialize()
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xE80E10", Offset = "0xE80E10", VA = "0xE80E10")]
		private void UpdateHoldTimerValue()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xE80654", Offset = "0xE80654", VA = "0xE80654")]
		private void UpdateHoldTimerVisual()
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xE80D5C", Offset = "0xE80D5C", VA = "0xE80D5C")]
		private void FacePlayer()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xE80FD0", Offset = "0xE80FD0", VA = "0xE80FD0")]
		public UIPrompt()
		{
		}
	}
}
namespace WTB.Prefabs.Gameplay.Creatures.Chicken
{
	[Token(Token = "0x200021C")]
	public class Chicken : MonoBehaviour
	{
		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Flying;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator m_Animator;

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0xE80FE0", Offset = "0xE80FE0", VA = "0xE80FE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xE81070", Offset = "0xE81070", VA = "0xE81070")]
		public void SetFlying(bool flying)
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xE810F0", Offset = "0xE810F0", VA = "0xE810F0")]
		public Chicken()
		{
		}
	}
}
namespace WTB.Prefabs.Gameplay.CountdownScoreBoard
{
	[Token(Token = "0x200021D")]
	public class CountdownScoreboard : MonoBehaviour
	{
		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_ShowTrophySpriteOn0;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_PopConfettiOn0;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_On0;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_TrophySprite;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshPro m_Text;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_UseSceneSubGoals;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int m_Count;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_CurrentCount;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int m_TotalSubGoals;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Situation m_Situation;

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xE81160", Offset = "0xE81160", VA = "0xE81160")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xE81178", Offset = "0xE81178", VA = "0xE81178")]
		private void Start()
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xE8131C", Offset = "0xE8131C", VA = "0xE8131C")]
		private void OnSituationUpdateSubGoals(int completedSubGoals)
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xE81554", Offset = "0xE81554", VA = "0xE81554")]
		public void CountDown(int value = 1)
		{
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xE8162C", Offset = "0xE8162C", VA = "0xE8162C")]
		public int GetCurrentCount()
		{
			return default(int);
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xE813FC", Offset = "0xE813FC", VA = "0xE813FC")]
		private void On0()
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xE81634", Offset = "0xE81634", VA = "0xE81634")]
		public CountdownScoreboard()
		{
		}
	}
}
namespace WTB.Prefabs.Gameplay.Bats.DetachableBat
{
	[Token(Token = "0x200021E")]
	public class DetatchableBat : BatExtension
	{
		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Event m_OnDetach;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeReference]
		private GameObjectFilter m_TargetGameObjectFilter;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody m_BatSelfRigidbody;

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xE8164C", Offset = "0xE8164C", VA = "0xE8164C", Slot = "9")]
		public override bool TryConsumeCollision(Collision collision, Vector3 swingEstimate, bool isOnCollisionEnter)
		{
			return default(bool);
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xE81A84", Offset = "0xE81A84", VA = "0xE81A84")]
		private void FallbackWinAllSubGoals()
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xE81B88", Offset = "0xE81B88", VA = "0xE81B88")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xE81C14", Offset = "0xE81C14", VA = "0xE81C14")]
		public DetatchableBat()
		{
		}
	}
}
namespace WTB.Marketing.Announcement_Trailer.End_Logo_Animation
{
	[Token(Token = "0x2000220")]
	public class EndLogoAnimation : MonoBehaviour
	{
		[Token(Token = "0x2000221")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EndLogoAnimation <>4__this;

			[Token(Token = "0x17000112")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009B7")]
				[Address(RVA = "0xE81F28", Offset = "0xE81F28", VA = "0xE81F28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000113")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009B9")]
				[Address(RVA = "0xE81F70", Offset = "0xE81F70", VA = "0xE81F70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0xE81DAC", Offset = "0xE81DAC", VA = "0xE81DAC")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0xE81DE4", Offset = "0xE81DE4", VA = "0xE81DE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0xE81DE8", Offset = "0xE81DE8", VA = "0xE81DE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009B8")]
			[Address(RVA = "0xE81F30", Offset = "0xE81F30", VA = "0xE81F30", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rigidbody[] m_Rigidbodies;

		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_GameObjects;

		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_Delay;

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xE81CE0", Offset = "0xE81CE0", VA = "0xE81CE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xE81D44", Offset = "0xE81D44", VA = "0xE81D44")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xE81DD4", Offset = "0xE81DD4", VA = "0xE81DD4")]
		public EndLogoAnimation()
		{
		}
	}
	[Token(Token = "0x2000222")]
	public class OnEnableVelocity : MonoBehaviour
	{
		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_Angle;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Vector3 m_PrimaryAxis;

		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private readonly Vector3 m_SecondaryAxis;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_WasHit;

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xE81F78", Offset = "0xE81F78", VA = "0xE81F78")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xE81FC8", Offset = "0xE81FC8", VA = "0xE81FC8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xE820AC", Offset = "0xE820AC", VA = "0xE820AC")]
		private Vector3 GetDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xE82118", Offset = "0xE82118", VA = "0xE82118")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xE82238", Offset = "0xE82238", VA = "0xE82238")]
		public OnEnableVelocity()
		{
		}
	}
}
