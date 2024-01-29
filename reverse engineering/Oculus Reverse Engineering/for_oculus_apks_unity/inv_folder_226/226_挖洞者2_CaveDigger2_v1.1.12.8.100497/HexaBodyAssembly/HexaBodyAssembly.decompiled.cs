using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using HexabodyVR.PlayerController;
using HexabodyVR.SampleScene;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

[assembly: AssemblyVersion("0.0.0.0")]
namespace HexabodyVR.SampleScene
{
	[Token(Token = "0x2000002")]
	[RequireComponent(typeof(Rigidbody))]
	public class MovingPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x20")]
		public Transform End;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x28")]
		public float Speed;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x2C")]
		public float Delay;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x30")]
		public float TimeToMaxSpeed;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 _target;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x40")]
		private float _speed;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x44")]
		private float _timer;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x48")]
		private bool _waiting;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 _start;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x58")]
		private bool _endTarget;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x5C")]
		private float _elapsed;

		[Token(Token = "0x17000001")]
		public Rigidbody Rigidbody
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x25966FC", Offset = "0x25966FC", VA = "0x25966FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x2596704", Offset = "0x2596704", VA = "0x2596704")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x259670C", Offset = "0x259670C", VA = "0x259670C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x25967B0", Offset = "0x25967B0", VA = "0x25967B0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2596A64", Offset = "0x2596A64", VA = "0x2596A64")]
		public MovingPlatform()
		{
		}
	}
	[Token(Token = "0x2000003")]
	[RequireComponent(typeof(LineRenderer))]
	public class SpiderHands : MonoBehaviour
	{
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x18")]
		public float Distance;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x1C")]
		public float PullSpeed;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x20")]
		public LayerMask GrabLayer;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x28")]
		public HexaXRInputs Controller;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x30")]
		public bool Grabbing;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x38")]
		public Transform Anchor;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x40")]
		public Rigidbody Body;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x48")]
		public float Spring;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x4C")]
		public float Damper;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x50")]
		public float CrossHairMaxScale;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Crosshair;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x60")]
		public ConfigurableJoint Joint;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x68")]
		public BasicGrabber BasicGrabber;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x70")]
		public LineRenderer LineRenderer;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 _hitPoint;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x84")]
		private float _distance;

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2596A80", Offset = "0x2596A80", VA = "0x2596A80")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2596B10", Offset = "0x2596B10", VA = "0x2596B10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2596B3C", Offset = "0x2596B3C", VA = "0x2596B3C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2596BAC", Offset = "0x2596BAC", VA = "0x2596BAC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2596DBC", Offset = "0x2596DBC", VA = "0x2596DBC")]
		private void Aim()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2597308", Offset = "0x2597308", VA = "0x2597308")]
		public SpiderHands()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[RequireComponent(typeof(Rigidbody))]
	public class SpinningElevator : MonoBehaviour
	{
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x18")]
		public Rigidbody Rigidbody;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x20")]
		public float AnglesPerSecond;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2597330", Offset = "0x2597330", VA = "0x2597330")]
		private void Start()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2597398", Offset = "0x2597398", VA = "0x2597398")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x259749C", Offset = "0x259749C", VA = "0x259749C")]
		public SpinningElevator()
		{
		}
	}
}
namespace HexabodyVR.PlayerController
{
	[Token(Token = "0x2000005")]
	[RequireComponent(typeof(Rigidbody))]
	public class BasicGrabber : MonoBehaviour
	{
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x18")]
		public float Radius;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x1C")]
		public LayerMask GrabLayer;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x20")]
		public HexaXRInputs Controller;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x28")]
		public bool Grabbing;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x30")]
		public Transform Anchor;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x38")]
		private readonly Collider[] _colliders;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x40")]
		public SpiderHands SpiderHands;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x48")]
		public ConfigurableJoint Joint;

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x25974AC", Offset = "0x25974AC", VA = "0x25974AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2597504", Offset = "0x2597504", VA = "0x2597504")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2597930", Offset = "0x2597930", VA = "0x2597930")]
		public BasicGrabber()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class HexaBodyInputWrapper : MonoBehaviour
	{
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x18")]
		public HexaXRInputs LeftController;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x20")]
		public HexaXRInputs RightController;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x28")]
		public float CrouchThreshold;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x2C")]
		public float StandThreshold;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x30")]
		public HexaBodyPlayerInputs PlayerInputs;

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x25979A0", Offset = "0x25979A0", VA = "0x25979A0")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2597C78", Offset = "0x2597C78", VA = "0x2597C78", Slot = "4")]
		protected virtual bool GetSprinting()
		{
			return default(bool);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2597B74", Offset = "0x2597B74", VA = "0x2597B74")]
		protected bool GetCrouch()
		{
			return default(bool);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2597BC4", Offset = "0x2597BC4", VA = "0x2597BC4")]
		protected bool GetStand()
		{
			return default(bool);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2597C10", Offset = "0x2597C10", VA = "0x2597C10")]
		protected bool GetJump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2597CD8", Offset = "0x2597CD8", VA = "0x2597CD8")]
		public HexaBodyInputWrapper()
		{
		}
	}
	[Token(Token = "0x2000007")]
	[RequireComponent(typeof(HexaBodyPlayerInputs))]
	public class HexaBodyPlayer : MonoBehaviour
	{
		[Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class <Jumping>d__142 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400009A")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400009B")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400009C")]
			[FieldOffset(Offset = "0x20")]
			public HexaBodyPlayer <>4__this;

			[Token(Token = "0x400009D")]
			[FieldOffset(Offset = "0x28")]
			private float <crouchPercent>5__2;

			[Token(Token = "0x1700000A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000042")]
				[Address(RVA = "0x259A5F8", Offset = "0x259A5F8", VA = "0x259A5F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000044")]
				[Address(RVA = "0x259A640", Offset = "0x259A640", VA = "0x259A640", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600003F")]
			[Address(RVA = "0x25997E8", Offset = "0x25997E8", VA = "0x25997E8")]
			[DebuggerHidden]
			public <Jumping>d__142(int <>1__state)
			{
			}

			[Token(Token = "0x6000040")]
			[Address(RVA = "0x259A36C", Offset = "0x259A36C", VA = "0x259A36C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000041")]
			[Address(RVA = "0x259A370", Offset = "0x259A370", VA = "0x259A370", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000043")]
			[Address(RVA = "0x259A600", Offset = "0x259A600", VA = "0x259A600", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class <JumpRetract>d__143 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400009E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400009F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000A0")]
			[FieldOffset(Offset = "0x20")]
			public HexaBodyPlayer <>4__this;

			[Token(Token = "0x40000A1")]
			[FieldOffset(Offset = "0x28")]
			public float crouchPercent;

			[Token(Token = "0x40000A2")]
			[FieldOffset(Offset = "0x2C")]
			private float <start>5__2;

			[Token(Token = "0x40000A3")]
			[FieldOffset(Offset = "0x30")]
			private float <elapsed>5__3;

			[Token(Token = "0x40000A4")]
			[FieldOffset(Offset = "0x34")]
			private float <time>5__4;

			[Token(Token = "0x40000A5")]
			[FieldOffset(Offset = "0x38")]
			private bool <jumped>5__5;

			[Token(Token = "0x1700000C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000048")]
				[Address(RVA = "0x259AC6C", Offset = "0x259AC6C", VA = "0x259AC6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600004A")]
				[Address(RVA = "0x259ACB4", Offset = "0x259ACB4", VA = "0x259ACB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000045")]
			[Address(RVA = "0x2599894", Offset = "0x2599894", VA = "0x2599894")]
			[DebuggerHidden]
			public <JumpRetract>d__143(int <>1__state)
			{
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x259A648", Offset = "0x259A648", VA = "0x259A648", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000047")]
			[Address(RVA = "0x259A64C", Offset = "0x259A64C", VA = "0x259A64C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000049")]
			[Address(RVA = "0x259AC74", Offset = "0x259AC74", VA = "0x259AC74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Acceleration of the locosphere")]
		[Header("Locomotion")]
		public float Acceleration;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("Deaccelleration of locosphere")]
		public float Deacelleration;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("RunAcceleration of the locosphere")]
		public float RunAcceleration;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Force mode for torquing the locosphere")]
		public ForceMode RollMode;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Target linear walking speed")]
		public float WalkSpeed;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Target Linear sprinting speed")]
		public float RunSpeed;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Crouch max speed curve adjust by crouch amount")]
		public AnimationCurve CrouchSpeedCurve;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Crouch acceleration curve adjust by crouch amount")]
		public AnimationCurve CrouchAccelerationCurve;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Movement speed modification based on grounded angle")]
		public AnimationCurve SlopeCurve;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Camera deadzone for moving the player")]
		public float CameraMoveThreshold;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Double click timeout for sprinting,(vive controllers).")]
		public float SprintDoubleClickThreshold;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Height of the virtual player")]
		[Header("Body Adjustment")]
		public float PlayerHeight;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("Percent of player height for determining crouching")]
		public float LegPercent;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("length of the neck for looking down")]
		public float NeckFactor;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("How far above the locosphere the bumper sits")]
		public float BumperOffset;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Sitting or standing mode")]
		public SitStand SitStanding;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x64")]
		[Header("Turning")]
		public bool SmoothTurn;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x68")]
		public float SmoothTurnSpeed;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x6C")]
		public float SmoothTurnThreshold;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x70")]
		[Header("Ground Checking")]
		[Tooltip("If on a slope below this angle then lock the locosphere")]
		public float SlopeAngle;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x74")]
		[Tooltip("How far down to check for ground")]
		public float GroundedRayLength;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x78")]
		public LayerMask GroundedLayerMask;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x7C")]
		[Tooltip("Force of the spring keeping the player standing")]
		[Header("Standing")]
		public float StandingForce;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("Damper for standing, should aim for a critical damped ratio")]
		public float StandingDamper;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x84")]
		[Header("Jumping")]
		[Tooltip("Max for to push off the ground with")]
		public float JumpForce;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x88")]
		[Tooltip("Curve adjustment against JumpForce based on the crouch amount, less force is needed the more the player is crouched")]
		public AnimationCurve JumpCurve;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x90")]
		[Tooltip("Curve to determine the ball retraction speed when jumping")]
		public AnimationCurve JumpRetractCurve;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x98")]
		[Tooltip("Force applied to lift the ball when jumping")]
		public float RetractForce;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x9C")]
		[Tooltip("Force to stand the player back up after landing a jump")]
		public float LandingForce;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0xA0")]
		[Tooltip("Spring damper to stand the player back up after landing a jump")]
		public float LandingDamper;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0xA4")]
		[Tooltip("Max speed to retract the ball when jumping")]
		public float RetractSpeed;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0xA8")]
		[Tooltip("Max speed to push down on the ball when landing a jump")]
		public float LandingSpeed;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0xAC")]
		[Tooltip("The ball becomes this mass when jumping")]
		public float BallJumpMass;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("If you don't leave the ground after this amount of time when jumping the jump is reset")]
		public float JumpTimeout;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0xB4")]
		[Header("Crouching")]
		public float LevelOneHeight;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0xB8")]
		public float LevelTwoHeight;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0xBC")]
		public float LevelThreeHeight;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0xC0")]
		[Tooltip("How far the camera has to go down before the player starts crouching")]
		public float CrouchThreshold;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0xC4")]
		[Tooltip("Lerp speed when fake crouching")]
		public float CrouchSpeed;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0xC8")]
		[Tooltip("If the crouch or stand button is held for this long crouching will continue")]
		public float ContinueCrouchThreshold;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0xD0")]
		[Header("Required Transforms")]
		public HexaCameraRig CameraRig;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0xD8")]
		public Transform Camera;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0xE0")]
		public Transform CameraScale;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0xE8")]
		public Transform Neck;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0xF0")]
		public Transform UpperBody;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0xF8")]
		public Transform NeckAnchor;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x100")]
		public Transform Bumper;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x108")]
		public Transform MantleCheck;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x110")]
		[Header("RigidBodies")]
		public Rigidbody LocoBall;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x118")]
		public Rigidbody Torso;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x120")]
		public Rigidbody Knee;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x128")]
		public Rigidbody HeadRigidbody;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x130")]
		[Header("Colliders")]
		public CapsuleCollider LegsCapsule;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x138")]
		public CapsuleCollider CapsuleTorso;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x140")]
		public SphereCollider LocoSphere;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x148")]
		public SphereCollider BumperSphere;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x150")]
		public CapsuleCollider NeckCapsule;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x158")]
		[Header("Joints")]
		public ConfigurableJoint JointLegTorso;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x160")]
		public ConfigurableJoint JointLegBall;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x168")]
		public ConfigurableJoint JointHead;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x170")]
		[Header("Hands")]
		public Transform LeftController;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x178")]
		public Transform RightController;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x180")]
		[Space(30f)]
		[Header("------Debug-----")]
		[Header("Height Stuff")]
		public float CalibratedHeight;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x184")]
		public float SittingOffset;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x188")]
		public float FloorOffsetAdjustment;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x18C")]
		public float VirtualWaistHeight;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x190")]
		public float WaistHeight;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x194")]
		public float WaistToBallHeight;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x198")]
		public float CrouchOffset;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x19C")]
		public float TargetCrouchOffset;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x1A0")]
		public float TargetLegHeight;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x1A4")]
		public float LegHeight;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x1A8")]
		public float FakeCrouchAmount;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x1AC")]
		public float RealCrouchOffset;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x1B0")]
		[Header("Camera Offsets")]
		public float PelvisHeightOffset;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x1B4")]
		public float RealCrouchHeightOffset;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x1B8")]
		public float NeckBendOffset;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x1BC")]
		public float MinCameraHeightOffset;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x1C0")]
		public float MaxCameraHeightOffset;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x1C4")]
		public float HeadOffset;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x1C8")]
		public float MinCameraHeight;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x1CC")]
		public Vector3 CameraRigPosition;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x1D8")]
		public Vector3 PreviousCameraRigPosition;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x1E4")]
		[SerializeField]
		private float _jumpSpring;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private float _groundAngle;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x1EC")]
		[SerializeField]
		private CrouchLevel _crouchLevel;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private float _jumpTime;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x1F4")]
		[SerializeField]
		private LegStage _legStage;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private Vector3 _lastCameraDirection;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x204")]
		[SerializeField]
		private Vector3 _previousPosition;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		private float _actualSpeed;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x214")]
		private float _originalLocoRadius;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x218")]
		private float _originalBumperRadius;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x21C")]
		private float _ballMass;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x220")]
		private bool _jump;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x224")]
		private float _crouchTimer;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x228")]
		private float _crouchPercent;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x22C")]
		private float _scale;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x230")]
		private Vector3 _neckDirection;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x23C")]
		private float _timeSinceLastPress;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x240")]
		private bool _awaitingSecondClick;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x248")]
		private Coroutine _retractRoutine;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x250")]
		private Coroutine _jumpRoutine;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x294")]
		private Vector3 _previousAnchor;

		[Token(Token = "0x17000002")]
		public bool Sprinting
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2597CF0", Offset = "0x2597CF0", VA = "0x2597CF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x2597CF8", Offset = "0x2597CF8", VA = "0x2597CF8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public Quaternion GroundRotation
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2597D04", Offset = "0x2597D04", VA = "0x2597D04")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x2597D18", Offset = "0x2597D18", VA = "0x2597D18")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public HexaBodyPlayerInputs Inputs
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x2597D2C", Offset = "0x2597D2C", VA = "0x2597D2C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x2597D34", Offset = "0x2597D34", VA = "0x2597D34")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public Vector3 Forward
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x2597D44", Offset = "0x2597D44", VA = "0x2597D44")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x2597D54", Offset = "0x2597D54", VA = "0x2597D54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public Vector3 Right
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x2597D64", Offset = "0x2597D64", VA = "0x2597D64")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2597D74", Offset = "0x2597D74", VA = "0x2597D74")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool IsGrounded
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x2597D84", Offset = "0x2597D84", VA = "0x2597D84")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x2597D8C", Offset = "0x2597D8C", VA = "0x2597D8C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public float CameraHeight
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x2597D98", Offset = "0x2597D98", VA = "0x2597D98")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000009")]
		public float EyeLevel
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2597DDC", Offset = "0x2597DDC", VA = "0x2597DDC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2597DEC", Offset = "0x2597DEC", VA = "0x2597DEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2597E94", Offset = "0x2597E94", VA = "0x2597E94")]
		public void CalibrateHeight(float height)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2597EEC", Offset = "0x2597EEC", VA = "0x2597EEC")]
		[SerializeField]
		private void Update()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x259829C", Offset = "0x259829C", VA = "0x259829C")]
		private void UpdateCrouch()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x25988F4", Offset = "0x25988F4", VA = "0x25988F4")]
		private void ForceCrouchHeight(CrouchLevel level)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2598864", Offset = "0x2598864", VA = "0x2598864")]
		private void SetLegHeight(float offset)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x25987FC", Offset = "0x25987FC", VA = "0x25987FC")]
		private void SetCrouchLevel(CrouchLevel level)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2598670", Offset = "0x2598670", VA = "0x2598670")]
		public void ApplyCameraOffsets()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2598918", Offset = "0x2598918", VA = "0x2598918")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x25990D0", Offset = "0x25990D0", VA = "0x25990D0")]
		private void Jump()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2599774", Offset = "0x2599774", VA = "0x2599774")]
		[IteratorStateMachine(typeof(<Jumping>d__142))]
		private IEnumerator Jumping()
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2599810", Offset = "0x2599810", VA = "0x2599810")]
		[IteratorStateMachine(typeof(<JumpRetract>d__143))]
		private IEnumerator JumpRetract(float crouchPercent)
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x25998BC", Offset = "0x25998BC", VA = "0x25998BC")]
		private void ScaleBalls(bool shrink)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2598774", Offset = "0x2598774", VA = "0x2598774")]
		private void CheckInputs()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2599950", Offset = "0x2599950", VA = "0x2599950")]
		private bool HandleHMDMovement()
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2599EDC", Offset = "0x2599EDC", VA = "0x2599EDC")]
		private void HandleHMDRotation()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2599120", Offset = "0x2599120", VA = "0x2599120")]
		private void Move()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x259A0CC", Offset = "0x259A0CC", VA = "0x259A0CC")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x259A098", Offset = "0x259A098", VA = "0x259A098")]
		private void ZeroXZ(Rigidbody rigid)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2598DE0", Offset = "0x2598DE0", VA = "0x2598DE0")]
		private void CheckGrounded()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x259A014", Offset = "0x259A014", VA = "0x259A014")]
		private Vector2 CheckWASD()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x259A150", Offset = "0x259A150", VA = "0x259A150", Slot = "4")]
		protected virtual void CheckSprinting()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x259A27C", Offset = "0x259A27C", VA = "0x259A27C")]
		public void SetSitStandMode(bool sitting)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2598270", Offset = "0x2598270", VA = "0x2598270")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x259A29C", Offset = "0x259A29C", VA = "0x259A29C")]
		public HexaBodyPlayer()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public enum CrouchLevel
	{
		[Token(Token = "0x40000A7")]
		Standing,
		[Token(Token = "0x40000A8")]
		KneeBent,
		[Token(Token = "0x40000A9")]
		Squat,
		[Token(Token = "0x40000AA")]
		SuperSquat,
		[Token(Token = "0x40000AB")]
		ButtOnTheFloor
	}
	[Token(Token = "0x200000B")]
	public enum LegStage
	{
		[Token(Token = "0x40000AD")]
		Standing,
		[Token(Token = "0x40000AE")]
		Jumping,
		[Token(Token = "0x40000AF")]
		JumpRetract,
		[Token(Token = "0x40000B0")]
		Landing
	}
	[Token(Token = "0x200000C")]
	public enum SitStand
	{
		[Token(Token = "0x40000B2")]
		Sitting,
		[Token(Token = "0x40000B3")]
		Standing
	}
	[Token(Token = "0x200000D")]
	[RequireComponent(typeof(HexaBodyPlayerInputs))]
	public class HexaBodyPlayer2 : MonoBehaviour
	{
		[Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class <SnapTurn>d__152 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000129")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400012A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400012B")]
			[FieldOffset(Offset = "0x20")]
			public HexaBodyPlayer2 <>4__this;

			[Token(Token = "0x400012C")]
			[FieldOffset(Offset = "0x28")]
			public float sign;

			[Token(Token = "0x400012D")]
			[FieldOffset(Offset = "0x2C")]
			private Quaternion <finish>5__2;

			[Token(Token = "0x400012E")]
			[FieldOffset(Offset = "0x3C")]
			private float <elapsed>5__3;

			[Token(Token = "0x400012F")]
			[FieldOffset(Offset = "0x40")]
			private float <time>5__4;

			[Token(Token = "0x17000017")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600007C")]
				[Address(RVA = "0x259D820", Offset = "0x259D820", VA = "0x259D820", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000018")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600007E")]
				[Address(RVA = "0x259D868", Offset = "0x259D868", VA = "0x259D868", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0x259C9DC", Offset = "0x259C9DC", VA = "0x259C9DC")]
			[DebuggerHidden]
			public <SnapTurn>d__152(int <>1__state)
			{
			}

			[Token(Token = "0x600007A")]
			[Address(RVA = "0x259D548", Offset = "0x259D548", VA = "0x259D548", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600007B")]
			[Address(RVA = "0x259D54C", Offset = "0x259D54C", VA = "0x259D54C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600007D")]
			[Address(RVA = "0x259D828", Offset = "0x259D828", VA = "0x259D828", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class <Jumping>d__156 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000130")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000131")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000132")]
			[FieldOffset(Offset = "0x20")]
			public HexaBodyPlayer2 <>4__this;

			[Token(Token = "0x17000019")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000082")]
				[Address(RVA = "0x259DAF4", Offset = "0x259DAF4", VA = "0x259DAF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000084")]
				[Address(RVA = "0x259DB3C", Offset = "0x259DB3C", VA = "0x259DB3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0x259CAFC", Offset = "0x259CAFC", VA = "0x259CAFC")]
			[DebuggerHidden]
			public <Jumping>d__156(int <>1__state)
			{
			}

			[Token(Token = "0x6000080")]
			[Address(RVA = "0x259D870", Offset = "0x259D870", VA = "0x259D870", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000081")]
			[Address(RVA = "0x259D874", Offset = "0x259D874", VA = "0x259D874", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000083")]
			[Address(RVA = "0x259DAFC", Offset = "0x259DAFC", VA = "0x259DAFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class <JumpRetract>d__158 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000133")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000134")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000135")]
			[FieldOffset(Offset = "0x20")]
			public HexaBodyPlayer2 <>4__this;

			[Token(Token = "0x4000136")]
			[FieldOffset(Offset = "0x28")]
			private float <time>5__2;

			[Token(Token = "0x4000137")]
			[FieldOffset(Offset = "0x2C")]
			private float <start>5__3;

			[Token(Token = "0x4000138")]
			[FieldOffset(Offset = "0x30")]
			private float <target>5__4;

			[Token(Token = "0x4000139")]
			[FieldOffset(Offset = "0x34")]
			private float <elapsed>5__5;

			[Token(Token = "0x400013A")]
			[FieldOffset(Offset = "0x38")]
			private float <velocity>5__6;

			[Token(Token = "0x400013B")]
			[FieldOffset(Offset = "0x3C")]
			private bool <jumped>5__7;

			[Token(Token = "0x1700001B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000088")]
				[Address(RVA = "0x259E188", Offset = "0x259E188", VA = "0x259E188", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600008A")]
				[Address(RVA = "0x259E1D0", Offset = "0x259E1D0", VA = "0x259E1D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000085")]
			[Address(RVA = "0x259CBD0", Offset = "0x259CBD0", VA = "0x259CBD0")]
			[DebuggerHidden]
			public <JumpRetract>d__158(int <>1__state)
			{
			}

			[Token(Token = "0x6000086")]
			[Address(RVA = "0x259DB44", Offset = "0x259DB44", VA = "0x259DB44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000087")]
			[Address(RVA = "0x259DB48", Offset = "0x259DB48", VA = "0x259DB48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000089")]
			[Address(RVA = "0x259E190", Offset = "0x259E190", VA = "0x259E190", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x18")]
		[Header("Locomotion")]
		[Tooltip("Air Acceleration")]
		public float AirAcceleration;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("Angular Velocity Acceleration of the locosphere")]
		public float Acceleration;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Deacelleration of locosphere")]
		public float Deacelleration;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("RunAcceleration of the locosphere")]
		public float RunAcceleration;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Target linear walking speed")]
		public float WalkSpeed;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Target Linear sprinting speed")]
		public float RunSpeed;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Crouch max speed curve adjust by crouch amount")]
		public AnimationCurve CrouchSpeedCurve;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Crouch acceleration curve adjust by crouch amount")]
		public AnimationCurve CrouchAccelerationCurve;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Movement acceleration modification based on grounded angle")]
		public AnimationCurve SlopeCurve;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Movement speed modification based on grounded angle")]
		public AnimationCurve SlopeSpeedCurve;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Camera deadzone for moving the player")]
		public float CameraMoveThreshold;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("Double click timeout for sprinting,(vive controllers).")]
		public float SprintDoubleClickThreshold;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Height of the virtual player")]
		[Header("Body Adjustment")]
		public float PlayerHeight;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("Percent of player height for determining crouching")]
		public float LegPercent;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("length of the neck for looking down and offsetting real life crouch")]
		public float NeckFactor;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("How far above the locosphere the bumper sits")]
		public float BumperOffset;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Sitting or standing mode")]
		public SitStand SitStanding;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x6C")]
		[Tooltip("How far above the players head can the RL camera go before capping out?")]
		public float CameraCeilingOffset;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x70")]
		[Header("Turning")]
		public bool SmoothTurn;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x74")]
		public float SmoothTurnSpeed;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x78")]
		public float SmoothTurnThreshold;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x7C")]
		public float SnapTurnSpeed;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x80")]
		public float SnapAmount;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x84")]
		[Tooltip("Axis threshold to be considered valid for snap turning.")]
		public float SnapThreshold;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x88")]
		[Tooltip("If on a slope below this angle then lock the locosphere")]
		[Header("Ground Checking")]
		public float SlopeAngle;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x8C")]
		[Tooltip("How far down to check for ground")]
		public float GroundedRayLength;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x90")]
		public LayerMask GroundedLayerMask;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x94")]
		[Header("Standing")]
		[Tooltip("Force of the spring keeping the player standing")]
		public float StandingForce;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x98")]
		[Tooltip("Damper for standing, should aim for a critical damped ratio")]
		public float StandingDamper;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x9C")]
		public float StandingMaxForce;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0xA0")]
		[Header("Jumping")]
		[Tooltip("Max for to push off the ground with")]
		public float JumpForce;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0xA8")]
		[Tooltip("Curve adjustment against JumpForce based on the crouch amount, less force is needed the more the player is crouched")]
		public AnimationCurve JumpCurve;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("The ball becomes this mass when jumping")]
		public float BallJumpMass;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0xB4")]
		[Tooltip("If you don't leave the ground after this amount of time when jumping the jump is reset")]
		public float JumpTimeout;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0xB8")]
		public CrouchLevel RetractLevel;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0xBC")]
		[Header("Crouching")]
		public float LevelOneHeight;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0xC0")]
		public float LevelTwoHeight;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0xC4")]
		public float LevelThreeHeight;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0xC8")]
		[Tooltip("How far the camera has to go down before the player starts crouching")]
		public float CrouchThreshold;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0xCC")]
		[Tooltip("Crouch speed")]
		public float CrouchSpeed;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0xD0")]
		[Tooltip("If the crouch or stand button is held for this long crouching will continue")]
		public float ContinueCrouchThreshold;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0xD4")]
		public float JumpCrouchSpeed;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0xD8")]
		[Header("Required Transforms")]
		public HexaCameraRig CameraRig;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0xE0")]
		public Transform Camera;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0xE8")]
		public Transform NeckPivot;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0xF0")]
		public Transform CameraScale;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0xF8")]
		public Transform Neck;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x100")]
		public Transform UpperBody;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x108")]
		public Transform NeckAnchor;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x110")]
		public Transform Bumper;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x118")]
		public Transform MantleCheck;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x120")]
		[Header("RigidBodies")]
		public Rigidbody LocoBall;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x128")]
		public Rigidbody Torso;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x130")]
		public Rigidbody Knee;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x138")]
		public Rigidbody HeadRigidbody;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x140")]
		[Header("Colliders")]
		public CapsuleCollider LegsCapsule;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x148")]
		public CapsuleCollider CapsuleTorso;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x150")]
		public SphereCollider LocoSphere;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x158")]
		public SphereCollider BumperSphere;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x160")]
		public CapsuleCollider NeckCapsule;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x168")]
		[Header("Joints")]
		public ConfigurableJoint JointLegTorso;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x170")]
		public ConfigurableJoint JointLegBall;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x178")]
		public ConfigurableJoint JointHead;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x180")]
		[Header("Hands")]
		public Transform LeftController;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x188")]
		public Transform RightController;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x190")]
		[Space(30f)]
		[Header("------Debug-----")]
		[Header("Height Stuff")]
		public float CalibratedHeight;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x194")]
		public float SittingOffset;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x198")]
		public float FloorOffsetAdjustment;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x19C")]
		public float VirtualWaistHeight;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x1A0")]
		public float WaistHeight;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x1A4")]
		public float WaistToBallHeight;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x1A8")]
		public float CrouchOffset;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x1AC")]
		public float TargetCrouchOffset;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x1B0")]
		public float LegHeight;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x1B4")]
		public float FakeCrouchAmount;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x1B8")]
		public float RealCrouchOffset;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x1BC")]
		public float NeckBendOffset;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x1C0")]
		[Header("Camera Offsets")]
		public float PelvisHeightOffset;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x1C4")]
		public float RealCrouchHeightOffset;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x1C8")]
		public float MinCameraHeightOffset;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x1CC")]
		public float MaxCameraHeightOffset;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x1D0")]
		public float HeadOffset;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x1D4")]
		public float MinCameraHeight;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x1D8")]
		public Vector3 CameraRigPosition;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x1E4")]
		public Vector3 PreviousCameraRigPosition;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		[Header("Misc")]
		private float _jumpForce;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x1F4")]
		[SerializeField]
		private float _groundAngle;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private CrouchLevel _crouchLevel;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x1FC")]
		[SerializeField]
		private float _jumpTime;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		private LegStage _legStage;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x204")]
		[SerializeField]
		private float _actualSpeed;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		private float _crouchPercent;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x20C")]
		[Header("Velocities")]
		[SerializeField]
		private float _verticalSpeed;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		private float _locoAngularVelocity;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x214")]
		[SerializeField]
		private float _targetAngularVelocity;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		private float _modifiedTargetSpeed;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x21C")]
		[SerializeField]
		private float _modifiedTargetAcceleration;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x220")]
		private float _originalLocoRadius;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x224")]
		private float _originalBumperRadius;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x228")]
		private float _ballMass;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x22C")]
		private float _kneeMass;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x230")]
		private bool _jump;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x234")]
		private float _crouchTimer;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x238")]
		private float _scale;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x23C")]
		private float _timeSinceLastPress;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x240")]
		private bool _awaitingSecondClick;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x244")]
		private Vector3 _previousCamera;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x250")]
		private Vector3 _crouchVelocity;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x25C")]
		private Vector3 _jumpVelocity;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x2A4")]
		private float _previousTurnAxis;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x2A8")]
		private bool _turning;

		[Token(Token = "0x1700000E")]
		public bool Sprinting
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x259ACBC", Offset = "0x259ACBC", VA = "0x259ACBC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x259ACC4", Offset = "0x259ACC4", VA = "0x259ACC4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public Quaternion GroundRotation
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x259ACD0", Offset = "0x259ACD0", VA = "0x259ACD0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x259ACE4", Offset = "0x259ACE4", VA = "0x259ACE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public HexaBodyPlayerInputs Inputs
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x259ACF8", Offset = "0x259ACF8", VA = "0x259ACF8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x259AD00", Offset = "0x259AD00", VA = "0x259AD00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public Vector3 Forward
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x259AD10", Offset = "0x259AD10", VA = "0x259AD10")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x259AD20", Offset = "0x259AD20", VA = "0x259AD20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Vector3 Right
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x259AD30", Offset = "0x259AD30", VA = "0x259AD30")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x259AD40", Offset = "0x259AD40", VA = "0x259AD40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public bool IsGrounded
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x259AD50", Offset = "0x259AD50", VA = "0x259AD50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x259AD58", Offset = "0x259AD58", VA = "0x259AD58")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public float CameraHeight
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x259AD64", Offset = "0x259AD64", VA = "0x259AD64")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000015")]
		public float EyeLevel
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x259ADA8", Offset = "0x259ADA8", VA = "0x259ADA8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000016")]
		private float Mass
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x259CA04", Offset = "0x259CA04", VA = "0x259CA04")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x259ADB0", Offset = "0x259ADB0", VA = "0x259ADB0")]
		private void Start()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x259AE70", Offset = "0x259AE70", VA = "0x259AE70")]
		public void CalibrateHeight(float height)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x259AEC8", Offset = "0x259AEC8", VA = "0x259AEC8")]
		[SerializeField]
		private void Update()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x259B2A4", Offset = "0x259B2A4", VA = "0x259B2A4")]
		private void UpdateCrouch()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x259B7F4", Offset = "0x259B7F4", VA = "0x259B7F4")]
		private void ForceCrouchHeight(CrouchLevel level)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x259B720", Offset = "0x259B720", VA = "0x259B720")]
		private void SetLegHeight(float offset)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x259B704", Offset = "0x259B704", VA = "0x259B704")]
		private void SetCrouchLevel(CrouchLevel level)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x259B814", Offset = "0x259B814", VA = "0x259B814")]
		private float GetCrouchOffset(CrouchLevel level)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x259B5BC", Offset = "0x259B5BC", VA = "0x259B5BC")]
		public void ApplyCameraOffsets()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x259B870", Offset = "0x259B870", VA = "0x259B870")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x259C75C", Offset = "0x259C75C", VA = "0x259C75C")]
		private void UpdateHead()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x259B94C", Offset = "0x259B94C", VA = "0x259B94C")]
		private void UpdateLegs()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x259C5E4", Offset = "0x259C5E4", VA = "0x259C5E4")]
		private void Turn()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x259C958", Offset = "0x259C958", VA = "0x259C958")]
		[IteratorStateMachine(typeof(<SnapTurn>d__152))]
		private IEnumerator SnapTurn(float sign)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x259BFFC", Offset = "0x259BFFC", VA = "0x259BFFC")]
		private void Jump()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x259CA88", Offset = "0x259CA88", VA = "0x259CA88")]
		[IteratorStateMachine(typeof(<Jumping>d__156))]
		private IEnumerator Jumping()
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x259CB24", Offset = "0x259CB24", VA = "0x259CB24")]
		private void ResetLegs()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x259CB5C", Offset = "0x259CB5C", VA = "0x259CB5C")]
		[IteratorStateMachine(typeof(<JumpRetract>d__158))]
		private IEnumerator JumpRetract()
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x259CBF8", Offset = "0x259CBF8", VA = "0x259CBF8")]
		private void ScaleBalls(bool shrink)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x259B68C", Offset = "0x259B68C", VA = "0x259B68C")]
		private void CheckInputs()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x259CC8C", Offset = "0x259CC8C", VA = "0x259CC8C")]
		private bool HandleHMDMovement()
		{
			return default(bool);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x259D058", Offset = "0x259D058", VA = "0x259D058")]
		private void HandleHMDRotation()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x259D190", Offset = "0x259D190", VA = "0x259D190")]
		private void AirMove(Vector3 direction)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x259D208", Offset = "0x259D208", VA = "0x259D208")]
		private void AirAccelerate(Rigidbody rb, Vector3 direction)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x259C03C", Offset = "0x259C03C", VA = "0x259C03C")]
		private void Move()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x259BD0C", Offset = "0x259BD0C", VA = "0x259BD0C")]
		private void CheckGrounded()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x259D2A0", Offset = "0x259D2A0", VA = "0x259D2A0")]
		private Vector2 CheckWASD()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x259D324", Offset = "0x259D324", VA = "0x259D324", Slot = "4")]
		protected virtual void CheckSprinting()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x259D450", Offset = "0x259D450", VA = "0x259D450")]
		public void SetSitStandMode(bool sitting)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x259B278", Offset = "0x259B278", VA = "0x259B278")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x259D470", Offset = "0x259D470", VA = "0x259D470")]
		public HexaBodyPlayer2()
		{
		}
	}
	[Token(Token = "0x2000011")]
	[RequireComponent(typeof(HexaBodyPlayerInputs))]
	public class HexaBodyPlayer3 : MonoBehaviour
	{
		[Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class <CalibrateHeight>d__158 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001C7")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001C8")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001C9")]
			[FieldOffset(Offset = "0x20")]
			public HexaBodyPlayer3 <>4__this;

			[Token(Token = "0x17000026")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000CA")]
				[Address(RVA = "0x25A2590", Offset = "0x25A2590", VA = "0x25A2590", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000027")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000CC")]
				[Address(RVA = "0x25A25D8", Offset = "0x25A25D8", VA = "0x25A25D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x259EA14", Offset = "0x259EA14", VA = "0x259EA14")]
			[DebuggerHidden]
			public <CalibrateHeight>d__158(int <>1__state)
			{
			}

			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x25A23EC", Offset = "0x25A23EC", VA = "0x25A23EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x25A23F0", Offset = "0x25A23F0", VA = "0x25A23F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x25A2598", Offset = "0x25A2598", VA = "0x25A2598", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class <SnapTurn>d__179 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001CA")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001CB")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001CC")]
			[FieldOffset(Offset = "0x20")]
			public HexaBodyPlayer3 <>4__this;

			[Token(Token = "0x40001CD")]
			[FieldOffset(Offset = "0x28")]
			public float sign;

			[Token(Token = "0x40001CE")]
			[FieldOffset(Offset = "0x2C")]
			private Quaternion <finish>5__2;

			[Token(Token = "0x40001CF")]
			[FieldOffset(Offset = "0x3C")]
			private float <elapsed>5__3;

			[Token(Token = "0x40001D0")]
			[FieldOffset(Offset = "0x40")]
			private float <time>5__4;

			[Token(Token = "0x17000028")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000D0")]
				[Address(RVA = "0x25A28D0", Offset = "0x25A28D0", VA = "0x25A28D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000029")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000D2")]
				[Address(RVA = "0x25A2918", Offset = "0x25A2918", VA = "0x25A2918", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x25A0B28", Offset = "0x25A0B28", VA = "0x25A0B28")]
			[DebuggerHidden]
			public <SnapTurn>d__179(int <>1__state)
			{
			}

			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x25A25E0", Offset = "0x25A25E0", VA = "0x25A25E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x25A25E4", Offset = "0x25A25E4", VA = "0x25A25E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x25A28D8", Offset = "0x25A28D8", VA = "0x25A28D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class <Jumping>d__183 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001D1")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001D2")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001D3")]
			[FieldOffset(Offset = "0x20")]
			public HexaBodyPlayer3 <>4__this;

			[Token(Token = "0x1700002A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000D6")]
				[Address(RVA = "0x25A2BA4", Offset = "0x25A2BA4", VA = "0x25A2BA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000D8")]
				[Address(RVA = "0x25A2BEC", Offset = "0x25A2BEC", VA = "0x25A2BEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x25A0C88", Offset = "0x25A0C88", VA = "0x25A0C88")]
			[DebuggerHidden]
			public <Jumping>d__183(int <>1__state)
			{
			}

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x25A2920", Offset = "0x25A2920", VA = "0x25A2920", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x25A2924", Offset = "0x25A2924", VA = "0x25A2924", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x25A2BAC", Offset = "0x25A2BAC", VA = "0x25A2BAC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class <JumpRetract>d__185 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001D4")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001D5")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001D6")]
			[FieldOffset(Offset = "0x20")]
			public HexaBodyPlayer3 <>4__this;

			[Token(Token = "0x40001D7")]
			[FieldOffset(Offset = "0x28")]
			private float <time>5__2;

			[Token(Token = "0x40001D8")]
			[FieldOffset(Offset = "0x2C")]
			private float <start>5__3;

			[Token(Token = "0x40001D9")]
			[FieldOffset(Offset = "0x30")]
			private float <target>5__4;

			[Token(Token = "0x40001DA")]
			[FieldOffset(Offset = "0x34")]
			private float <elapsed>5__5;

			[Token(Token = "0x40001DB")]
			[FieldOffset(Offset = "0x38")]
			private float <velocity>5__6;

			[Token(Token = "0x40001DC")]
			[FieldOffset(Offset = "0x3C")]
			private bool <jumped>5__7;

			[Token(Token = "0x1700002C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000DC")]
				[Address(RVA = "0x25A3238", Offset = "0x25A3238", VA = "0x25A3238", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000DE")]
				[Address(RVA = "0x25A3280", Offset = "0x25A3280", VA = "0x25A3280", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x25A0D5C", Offset = "0x25A0D5C", VA = "0x25A0D5C")]
			[DebuggerHidden]
			public <JumpRetract>d__185(int <>1__state)
			{
			}

			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x25A2BF4", Offset = "0x25A2BF4", VA = "0x25A2BF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x25A2BF8", Offset = "0x25A2BF8", VA = "0x25A2BF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x25A3240", Offset = "0x25A3240", VA = "0x25A3240", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class <After>d__189 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001DD")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001DE")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001DF")]
			[FieldOffset(Offset = "0x20")]
			public HexaBodyPlayer3 <>4__this;

			[Token(Token = "0x1700002E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000E2")]
				[Address(RVA = "0x25A36C8", Offset = "0x25A36C8", VA = "0x25A36C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000E4")]
				[Address(RVA = "0x25A3710", Offset = "0x25A3710", VA = "0x25A3710", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x25A1254", Offset = "0x25A1254", VA = "0x25A1254")]
			[DebuggerHidden]
			public <After>d__189(int <>1__state)
			{
			}

			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x25A3288", Offset = "0x25A3288", VA = "0x25A3288", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x25A328C", Offset = "0x25A328C", VA = "0x25A328C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x25A36D0", Offset = "0x25A36D0", VA = "0x25A36D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Air Acceleration")]
		[Header("Locomotion")]
		public float AirAcceleration;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("Angular Velocity Acceleration of the locosphere")]
		public float Acceleration;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Deacelleration of locosphere")]
		public float Deacelleration;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("RunAcceleration of the locosphere")]
		public float RunAcceleration;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Target linear walking speed")]
		public float WalkSpeed;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Target Linear sprinting speed")]
		public float RunSpeed;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Crouch max speed curve adjust by crouch amount")]
		public AnimationCurve CrouchSpeedCurve;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Crouch acceleration curve adjust by crouch amount")]
		public AnimationCurve CrouchAccelerationCurve;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Movement acceleration modification based on grounded angle")]
		public AnimationCurve SlopeCurve;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Movement speed modification based on grounded angle")]
		public AnimationCurve SlopeSpeedCurve;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Camera deadzone for moving the player")]
		public float CameraMoveThreshold;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Material applied to the locoball collider when EnableSlipper is called.")]
		public PhysicMaterial SlipperyMaterial;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Double click timeout for sprinting,(vive controllers).")]
		public float SprintDoubleClickThreshold;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x64")]
		[Header("Body Adjustment")]
		[Tooltip("Height of the virtual player")]
		public float PlayerHeight;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Percent of player height for determining crouching")]
		public float LegPercent;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x6C")]
		[Tooltip("How far above the locosphere the bumper sits")]
		public float BumperOffset;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("Sitting or standing mode")]
		public SitStand SitStanding;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x74")]
		[Tooltip("How far above the players head can the RL camera go before capping out?")]
		public float CameraCeilingOffset;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x78")]
		public float PelvisMaxOffset;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x80")]
		public AnimationCurve PelvisOffset;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x88")]
		public float DefaultArmLength;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x8C")]
		[Header("Turning")]
		public bool SmoothTurn;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x90")]
		public float SmoothTurnSpeed;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x94")]
		public float SmoothTurnThreshold;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x98")]
		public float SnapTurnSpeed;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x9C")]
		public float SnapAmount;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0xA0")]
		[Tooltip("Axis threshold to be considered valid for snap turning.")]
		public float SnapThreshold;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0xA4")]
		[Header("Ground Checking")]
		[Tooltip("If on a slope below this angle then lock the locosphere")]
		public float SlopeAngle;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0xA8")]
		[Tooltip("How far down to check for ground")]
		public float GroundedRayLength;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0xAC")]
		public LayerMask GroundedLayerMask;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("Force of the spring keeping the player standing")]
		[Header("Standing")]
		public float StandingForce;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0xB4")]
		[Tooltip("Damper for standing, should aim for a critical damped ratio")]
		public float StandingDamper;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0xB8")]
		public float StandingMaxForce;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0xBC")]
		[Tooltip("Max for to push off the ground with")]
		[Header("Jumping")]
		public float JumpForce;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0xC0")]
		[Tooltip("Curve adjustment against JumpForce based on the crouch amount, less force is needed the more the player is crouched")]
		public AnimationCurve JumpCurve;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0xC8")]
		[Tooltip("The ball becomes this mass when jumping")]
		public float BallJumpMass;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0xCC")]
		[Tooltip("If you don't leave the ground after this amount of time when jumping the jump is reset")]
		public float JumpTimeout;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0xD0")]
		public CrouchLevel RetractLevel;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0xD4")]
		[Header("Crouching")]
		public float LevelOneHeight;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0xD8")]
		public float LevelTwoHeight;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0xDC")]
		public float LevelThreeHeight;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0xE0")]
		[Tooltip("How far the camera has to go down before the player starts crouching")]
		public float CrouchThreshold;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0xE4")]
		[Tooltip("Crouch speed")]
		public float CrouchSpeed;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0xE8")]
		[Tooltip("If the crouch or stand button is held for this long crouching will continue")]
		public float ContinueCrouchThreshold;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0xEC")]
		public float JumpCrouchSpeed;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0xF0")]
		[Header("Required Transforms")]
		public HexaCameraRig CameraRig;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0xF8")]
		public Transform Camera;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x100")]
		public Transform NeckPivot;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x108")]
		public Transform CameraScale;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x110")]
		public Transform Neck;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x118")]
		public Transform Bumper;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x120")]
		public Transform Legs;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x128")]
		public Transform Chest;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x130")]
		public Transform ChestAnchor;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x138")]
		public Transform LeftShoulder;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x140")]
		public Transform RightShoulder;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x148")]
		[Header("Debug Shapes")]
		public bool ShowShapes;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x150")]
		public Transform ChestCapsule;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x158")]
		public Transform KneeCapsule;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x160")]
		public Transform PelvisCapsule;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x168")]
		public Transform LocoSphere;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x170")]
		public Transform FenderSphere;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x178")]
		[Header("RigidBodies")]
		public Rigidbody LocoBall;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x180")]
		public Rigidbody Torso;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x188")]
		public Rigidbody Knee;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x190")]
		public Rigidbody HeadRigidbody;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x198")]
		public Rigidbody LeftHandRigidBody;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x1A0")]
		public Rigidbody RightHandRigidBody;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x1A8")]
		[Header("Colliders")]
		public CapsuleCollider KneeCollider;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x1B0")]
		public CapsuleCollider ChestCollider;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x1B8")]
		public SphereCollider LocoCollider;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x1C0")]
		public SphereCollider FenderCollider;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x1C8")]
		public CapsuleCollider NeckCollider;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x1D0")]
		public CapsuleCollider PelvisCollider;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x1D8")]
		[Header("Joints")]
		public ConfigurableJoint JointLegTorso;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x1E0")]
		public ConfigurableJoint JointLegBall;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x1E8")]
		public ConfigurableJoint JointHead;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x1F0")]
		[Header("Tracking")]
		public Transform LeftController;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x1F8")]
		public Transform RightController;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x200")]
		[Header("Debug Settings")]
		public bool CalibrateHeightOnStart;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x204")]
		[Space(30f)]
		[Header("------Debug-----")]
		[Header("Height Stuff")]
		public float CalibratedHeight;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x208")]
		public float SittingOffset;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x20C")]
		public float FloorOffsetAdjustment;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x210")]
		public float WaistHeight;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x214")]
		public float WaistToBallHeight;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x218")]
		public float CrouchOffset;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x21C")]
		public float TargetCrouchOffset;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x220")]
		public float LegHeight;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x224")]
		public float FakeCrouchAmount;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x228")]
		public float RealCrouchOffset;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x22C")]
		public float NeckBendOffset;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x230")]
		[Header("Camera Offsets")]
		public float PelvisHeightOffset;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x234")]
		public float RealCrouchHeightOffset;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x238")]
		public float MinCameraHeightOffset;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x23C")]
		public float MaxCameraHeightOffset;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x240")]
		public float HeadOffset;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x244")]
		public float MinCameraHeight;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x248")]
		public Vector3 CameraRigPosition;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x254")]
		public Vector3 PreviousCameraRigPosition;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x260")]
		[Header("Misc")]
		[SerializeField]
		protected float _jumpForce;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x264")]
		[SerializeField]
		protected float _groundAngle;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		protected CrouchLevel _crouchLevel;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x26C")]
		[SerializeField]
		protected float _jumpTime;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		protected LegStage _legStage;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x274")]
		[SerializeField]
		protected float _actualSpeed;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x278")]
		[SerializeField]
		protected float _standingPercent;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x27C")]
		[Header("Velocities")]
		[SerializeField]
		protected float _verticalSpeed;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x280")]
		[SerializeField]
		protected float _locoAngularVelocity;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x284")]
		[SerializeField]
		protected float _targetAngularVelocity;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x288")]
		[SerializeField]
		protected float _modifiedTargetSpeed;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x28C")]
		[SerializeField]
		protected float _modifiedTargetAcceleration;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x290")]
		protected float _originalLocoRadius;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x294")]
		protected float _originalBumperRadius;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x298")]
		protected float _ballMass;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x29C")]
		protected float _kneeMass;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x2A0")]
		protected bool _jump;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x2A4")]
		protected float _crouchTimer;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x2A8")]
		protected float _scale;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x2AC")]
		protected float _timeSinceLastPress;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x2B0")]
		protected bool _awaitingSecondClick;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x2B4")]
		protected Vector3 _previousCamera;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x2C0")]
		protected Vector3 _crouchVelocity;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x2CC")]
		protected Vector3 _jumpVelocity;

		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x2D8")]
		protected bool _previousShowShapes;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x2DC")]
		protected float _previousSlopeAngle;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x2E0")]
		protected PhysicMaterial _previousLocoMaterial;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x2E8")]
		protected bool _slippery;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x324")]
		public float PelvisSpeed;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x328")]
		private float _previousTurnAxis;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x32C")]
		protected bool _turning;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x330")]
		public float snapTotal;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x338")]
		private ConfigurableJoint _leftArmJoint;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x340")]
		private ConfigurableJoint _rightArmJoint;

		[Token(Token = "0x1700001D")]
		public bool Sprinting
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x259E1D8", Offset = "0x259E1D8", VA = "0x259E1D8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x259E1E0", Offset = "0x259E1E0", VA = "0x259E1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public Quaternion GroundRotation
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x259E1EC", Offset = "0x259E1EC", VA = "0x259E1EC")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x259E200", Offset = "0x259E200", VA = "0x259E200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public HexaBodyPlayerInputs Inputs
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x259E214", Offset = "0x259E214", VA = "0x259E214")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x259E21C", Offset = "0x259E21C", VA = "0x259E21C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 Forward
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x259E22C", Offset = "0x259E22C", VA = "0x259E22C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x259E23C", Offset = "0x259E23C", VA = "0x259E23C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Vector3 Right
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x259E24C", Offset = "0x259E24C", VA = "0x259E24C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x259E25C", Offset = "0x259E25C", VA = "0x259E25C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public bool IsGrounded
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x259E26C", Offset = "0x259E26C", VA = "0x259E26C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x259E274", Offset = "0x259E274", VA = "0x259E274")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public float CameraHeight
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x259E280", Offset = "0x259E280", VA = "0x259E280")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000024")]
		public float EyeLevel
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x259E2C4", Offset = "0x259E2C4", VA = "0x259E2C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000025")]
		private float Mass
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x25A0B50", Offset = "0x25A0B50", VA = "0x25A0B50")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x259E2CC", Offset = "0x259E2CC", VA = "0x259E2CC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x259E8DC", Offset = "0x259E8DC", VA = "0x259E8DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x259E980", Offset = "0x259E980", VA = "0x259E980")]
		private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x259E9A0", Offset = "0x259E9A0", VA = "0x259E9A0")]
		[IteratorStateMachine(typeof(<CalibrateHeight>d__158))]
		private IEnumerator CalibrateHeight()
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x259EA3C", Offset = "0x259EA3C", VA = "0x259EA3C", Slot = "5")]
		public virtual void CalibrateHeight(float height)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x259EA94", Offset = "0x259EA94", VA = "0x259EA94")]
		public void EnableSlippery()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x259EB00", Offset = "0x259EB00", VA = "0x259EB00")]
		public void DisableSlippery()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x259EB40", Offset = "0x259EB40", VA = "0x259EB40", Slot = "6")]
		[SerializeField]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x259EF54", Offset = "0x259EF54", VA = "0x259EF54", Slot = "7")]
		protected virtual void UpdateCrouch()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x259F35C", Offset = "0x259F35C", VA = "0x259F35C")]
		protected void ForceCrouchHeight(CrouchLevel level)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x259F288", Offset = "0x259F288", VA = "0x259F288")]
		protected void SetLegHeight(float offset)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x259F26C", Offset = "0x259F26C", VA = "0x259F26C")]
		protected void SetCrouchLevel(CrouchLevel level)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x259F37C", Offset = "0x259F37C", VA = "0x259F37C")]
		private float GetCrouchOffset(CrouchLevel level)
		{
			return default(float);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x259F3D8", Offset = "0x259F3D8", VA = "0x259F3D8", Slot = "8")]
		public virtual void ApplyCameraOffsets()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x259F4AC", Offset = "0x259F4AC", VA = "0x259F4AC", Slot = "9")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x25A096C", Offset = "0x25A096C", VA = "0x25A096C")]
		private void UpdateShoulderAnchors()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x259FF08", Offset = "0x259FF08", VA = "0x259FF08")]
		private void UpdateBody()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x259FD0C", Offset = "0x259FD0C", VA = "0x259FD0C")]
		private void UpdateHead()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x259F5A8", Offset = "0x259F5A8", VA = "0x259F5A8")]
		private void UpdateLegs()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x259FB8C", Offset = "0x259FB8C", VA = "0x259FB8C")]
		private void Turn()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x25A0AA4", Offset = "0x25A0AA4", VA = "0x25A0AA4", Slot = "10")]
		[IteratorStateMachine(typeof(<SnapTurn>d__179))]
		public virtual IEnumerator SnapTurn(float sign)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x25A0BD4", Offset = "0x25A0BD4", VA = "0x25A0BD4", Slot = "11")]
		protected virtual void Jump()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x25A0C14", Offset = "0x25A0C14", VA = "0x25A0C14")]
		[IteratorStateMachine(typeof(<Jumping>d__183))]
		protected IEnumerator Jumping()
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x25A0CB0", Offset = "0x25A0CB0", VA = "0x25A0CB0")]
		private void ResetLegs()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x25A0CE8", Offset = "0x25A0CE8", VA = "0x25A0CE8")]
		[IteratorStateMachine(typeof(<JumpRetract>d__185))]
		private IEnumerator JumpRetract()
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x25A0D84", Offset = "0x25A0D84", VA = "0x25A0D84")]
		private void ScaleBalls(bool shrink)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x259EC9C", Offset = "0x259EC9C", VA = "0x259EC9C")]
		private void CheckInputs()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x25A0E18", Offset = "0x25A0E18", VA = "0x25A0E18")]
		protected bool HandleHMDMovement()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x25A11E0", Offset = "0x25A11E0", VA = "0x25A11E0")]
		[IteratorStateMachine(typeof(<After>d__189))]
		private IEnumerator After()
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x25A127C", Offset = "0x25A127C", VA = "0x25A127C")]
		protected void AirMove(Vector3 direction)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x25A12F4", Offset = "0x25A12F4", VA = "0x25A12F4")]
		private void AirAccelerate(Rigidbody rb, Vector3 direction)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x25A138C", Offset = "0x25A138C", VA = "0x25A138C", Slot = "12")]
		protected virtual void Move()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x259F89C", Offset = "0x259F89C", VA = "0x259F89C")]
		private void CheckGrounded()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x25A19C0", Offset = "0x25A19C0", VA = "0x25A19C0")]
		private Vector2 CheckWASD()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x25A1A44", Offset = "0x25A1A44", VA = "0x25A1A44", Slot = "13")]
		protected virtual void CheckSprinting()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x25A1B70", Offset = "0x25A1B70", VA = "0x25A1B70")]
		public void SetSitStandMode(bool sitting)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x25A1B9C", Offset = "0x25A1B9C", VA = "0x25A1B9C", Slot = "14")]
		public virtual void Calibrate()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x259E4EC", Offset = "0x259E4EC", VA = "0x259E4EC")]
		public void SetArmLength(float armLength)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x25A1BE4", Offset = "0x25A1BE4", VA = "0x25A1BE4")]
		private void CheckShapes()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x259ED18", Offset = "0x259ED18", VA = "0x259ED18")]
		private void UpdateShapes()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x259E43C", Offset = "0x259E43C", VA = "0x259E43C")]
		private void SetupShapes()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x25A1C10", Offset = "0x25A1C10", VA = "0x25A1C10", Slot = "15")]
		public virtual void MoveToPosition(Vector3 locoBallBottom)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x25A2164", Offset = "0x25A2164", VA = "0x25A2164")]
		public void FaceDirection(Vector3 forward)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x25A203C", Offset = "0x25A203C", VA = "0x25A203C")]
		public void Stop()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x25A22FC", Offset = "0x25A22FC", VA = "0x25A22FC")]
		public HexaBodyPlayer3()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class HexaBodyPlayerInputs : MonoBehaviour
	{
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x18")]
		[Header("Debugging")]
		public bool KeyboardDebug;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x1C")]
		public KeyCode CrouchKey;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x20")]
		public KeyCode StandKey;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x24")]
		public KeyCode JumpKey;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 MovementAxis;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 TurnAxis;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x38")]
		public bool SprintRequiresDoubleClick;

		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x39")]
		public bool SprintingPressed;

		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x3A")]
		public bool RecalibratePressed;

		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x3B")]
		public bool JumpPressed;

		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x3C")]
		public bool CrouchPressed;

		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x3D")]
		public bool StandPressed;

		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x40")]
		public PlayerInputState JumpState;

		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x48")]
		public PlayerInputState CrouchState;

		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x50")]
		public PlayerInputState StandState;

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x25A3718", Offset = "0x25A3718", VA = "0x25A3718")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x25A383C", Offset = "0x25A383C", VA = "0x25A383C")]
		protected void ResetState(ref PlayerInputState buttonState)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x25A3848", Offset = "0x25A3848", VA = "0x25A3848")]
		protected void SetState(ref PlayerInputState buttonState, bool pressed)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x25A3874", Offset = "0x25A3874", VA = "0x25A3874")]
		public HexaBodyPlayerInputs()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public struct PlayerInputState
	{
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x0")]
		public bool Active;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x1")]
		public bool JustActivated;

		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x2")]
		public bool JustDeactivated;

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x4")]
		public float Value;
	}
	[Token(Token = "0x2000019")]
	public class HexaCameraRig : MonoBehaviour
	{
		[Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class <UpdateTrackingOrigin>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001F9")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001FA")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000031")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000F4")]
				[Address(RVA = "0x25A4A0C", Offset = "0x25A4A0C", VA = "0x25A4A0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000032")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000F6")]
				[Address(RVA = "0x25A4A54", Offset = "0x25A4A54", VA = "0x25A4A54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x25A4990", Offset = "0x25A4990", VA = "0x25A4990")]
			[DebuggerHidden]
			public <UpdateTrackingOrigin>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x25A49B8", Offset = "0x25A49B8", VA = "0x25A49B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x25A49BC", Offset = "0x25A49BC", VA = "0x25A49BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x25A4A14", Offset = "0x25A4A14", VA = "0x25A4A14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x18")]
		[Header("Transforms")]
		public Transform Camera;

		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x20")]
		public Transform FloorOffsetTransform;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x28")]
		public float CameraYOffset;

		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x2C")]
		public TrackingOriginModeFlags TrackingSpace;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x30")]
		private TrackingOriginModeFlags _previousTrackingSpace;

		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _floorOffset;

		[Token(Token = "0x17000030")]
		public float FloorOffset
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x25A3890", Offset = "0x25A3890", VA = "0x25A3890")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x2598910", Offset = "0x2598910", VA = "0x2598910")]
			set
			{
			}
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x25A38CC", Offset = "0x25A38CC", VA = "0x25A38CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x25A3898", Offset = "0x25A3898", VA = "0x25A3898")]
		public void UpdateFloorOffset()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x25A3900", Offset = "0x25A3900", VA = "0x25A3900")]
		private void Update()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x25A38D8", Offset = "0x25A38D8", VA = "0x25A38D8")]
		private void Setup()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x25A3928", Offset = "0x25A3928", VA = "0x25A3928")]
		[IteratorStateMachine(typeof(<UpdateTrackingOrigin>d__13))]
		private IEnumerator UpdateTrackingOrigin(TrackingOriginModeFlags originFlags)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x25A3988", Offset = "0x25A3988", VA = "0x25A3988")]
		public HexaCameraRig()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[RequireComponent(typeof(Rigidbody))]
	public class HexaHands : MonoBehaviour
	{
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x18")]
		public Rigidbody ParentRigidBody;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Target transform for position and rotation tracking")]
		public Transform Target;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x28")]
		public Transform Camera;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x30")]
		public Transform Shoulder;

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x38")]
		public float MaxDistance;

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x3C")]
		[Header("Joint Settings")]
		public float Spring;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x40")]
		public float Damper;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x44")]
		public float MaxForce;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x48")]
		public float SlerpSpring;

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x4C")]
		public float SlerpDamper;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x50")]
		public float SlerpMaxForce;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x54")]
		private Quaternion _startingRotation;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 _previousCamera;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 _previousControllerPosition;

		[Token(Token = "0x17000033")]
		public Rigidbody RigidBody
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x25A4A5C", Offset = "0x25A4A5C", VA = "0x25A4A5C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x25A4A64", Offset = "0x25A4A64", VA = "0x25A4A64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public ConfigurableJoint Joint
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x25A4A6C", Offset = "0x25A4A6C", VA = "0x25A4A6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x25A4A74", Offset = "0x25A4A74", VA = "0x25A4A74")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x25A4A7C", Offset = "0x25A4A7C", VA = "0x25A4A7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x25A4D5C", Offset = "0x25A4D5C", VA = "0x25A4D5C")]
		public void Start()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x25A4D60", Offset = "0x25A4D60", VA = "0x25A4D60")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x25A4ADC", Offset = "0x25A4ADC", VA = "0x25A4ADC")]
		public void SetupJoint()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x25A5258", Offset = "0x25A5258", VA = "0x25A5258")]
		private void UpdateJoint()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x25A4D88", Offset = "0x25A4D88", VA = "0x25A4D88")]
		protected void UpdateJointAnchors()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x25A5174", Offset = "0x25A5174", VA = "0x25A5174")]
		protected void UpdateJointRotation()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x25A5038", Offset = "0x25A5038", VA = "0x25A5038")]
		public void UpdateTargetVelocity()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x25A539C", Offset = "0x25A539C", VA = "0x25A539C")]
		public HexaHands()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class HexaXRInputs : MonoBehaviour
	{
		[Token(Token = "0x200001D")]
		private enum ButtonReadType
		{
			[Token(Token = "0x4000247")]
			None,
			[Token(Token = "0x4000248")]
			Binary,
			[Token(Token = "0x4000249")]
			Axis1D,
			[Token(Token = "0x400024A")]
			Axis2DUp,
			[Token(Token = "0x400024B")]
			Axis2DDown,
			[Token(Token = "0x400024C")]
			Axis2DLeft,
			[Token(Token = "0x400024D")]
			Axis2DRight
		}

		[Token(Token = "0x200001E")]
		private struct ButtonInfo
		{
			[Token(Token = "0x400024E")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x400024F")]
			[FieldOffset(Offset = "0x8")]
			public ButtonReadType type;

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x25A67C8", Offset = "0x25A67C8", VA = "0x25A67C8")]
			public ButtonInfo(string name, ButtonReadType type)
			{
			}
		}

		[Token(Token = "0x400020B")]
		public const string OpenVR = "openvr";

		[Token(Token = "0x400020C")]
		public const string WindowsMR = "windowsmr";

		[Token(Token = "0x400020D")]
		public const string Vive = "vive";

		[Token(Token = "0x400020E")]
		public const string Cosmos = "cosmos";

		[Token(Token = "0x400020F")]
		public const string Oculus = "oculus";

		[Token(Token = "0x4000210")]
		public const string Knuckles = "knuckles";

		[Token(Token = "0x4000211")]
		public const string WMRController = "spatial";

		[Token(Token = "0x4000212")]
		public const string HTC = "htc";

		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x18")]
		public Transform ControllerOffset;

		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x20")]
		public bool IsLeft;

		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 ThumbstickDeadZone;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x2C")]
		public float GripThreshold;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x30")]
		public float TriggerThreshold;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x34")]
		public float Axis2DUpThreshold;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x38")]
		public float Axis2DDownThreshold;

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x3C")]
		public float Axis2DLeftThreshold;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x40")]
		public float Axis2DRightThreshold;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 OpenVRPositionOffset;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 OpenVRRotationOffset;

		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x5C")]
		[Header("Visuals Only")]
		public PlayerInputState GripButtonState;

		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x64")]
		public PlayerInputState TriggerButtonState;

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x6C")]
		public PlayerInputState PrimaryButtonState;

		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x74")]
		public PlayerInputState SecondaryButtonState;

		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x7C")]
		public PlayerInputState MenuButtonState;

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x84")]
		public PlayerInputState JoystickButtonState;

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x8C")]
		public PlayerInputState TrackpadButtonState;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x94")]
		public PlayerInputState TrackPadUp;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x9C")]
		public PlayerInputState TrackPadLeft;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0xA4")]
		public PlayerInputState TrackPadRight;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0xAC")]
		public PlayerInputState TrackPadDown;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0xB4")]
		public Vector2 JoystickAxis;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0xBC")]
		public Vector2 TrackpadAxis;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0xC4")]
		public bool PrimaryButton;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0xC5")]
		public bool SecondaryButton;

		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0xC6")]
		public bool JoystickClicked;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0xC7")]
		public bool TrackPadClicked;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0xC8")]
		public bool MenuButton;

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0xCC")]
		public float Grip;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0xD0")]
		public bool GripButton;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0xD4")]
		public float Trigger;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0xD8")]
		public Vector3 Velocity;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0xE4")]
		public Vector3 AngularVelocity;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0xF4")]
		public XRNode XRNode;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0xF8")]
		public bool IsWindowsMR;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0xF9")]
		public bool IsOpenVR;

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0xFA")]
		public bool IsVive;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0xFB")]
		public bool IsKnuckles;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0xFC")]
		public bool IsOculus;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0xFD")]
		public bool IsCosmos;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0xFE")]
		public bool HasTrackPad;

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0xFF")]
		public bool IsXRInputs;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x100")]
		private InputDevice _device;

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x0")]
		private static bool _steamInit;

		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x110")]
		protected InputFeatureUsage<Vector2> JoystickAxisFeature;

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x118")]
		protected InputFeatureUsage<Vector2> TrackPadAxisFeature;

		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x120")]
		public HexaXRInputFeatures JoystickFeature;

		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x124")]
		public HexaXRInputFeatures TrackpadFeature;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x8")]
		private static ButtonInfo[] s_ButtonData;

		[Token(Token = "0x17000035")]
		public bool IsActive
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x25A53CC", Offset = "0x25A53CC", VA = "0x25A53CC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x25A53D4", Offset = "0x25A53D4", VA = "0x25A53D4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public bool WindowsWithTrackPad
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x25A53E0", Offset = "0x25A53E0", VA = "0x25A53E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		public InputDevice Device
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x25A5400", Offset = "0x25A5400", VA = "0x25A5400")]
			get
			{
				return default(InputDevice);
			}
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x25A5438", Offset = "0x25A5438", VA = "0x25A5438")]
		private void Start()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x25A5444", Offset = "0x25A5444", VA = "0x25A5444")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x25A5448", Offset = "0x25A5448", VA = "0x25A5448")]
		private void Update()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x25A544C", Offset = "0x25A544C", VA = "0x25A544C")]
		private void UpdateInputs()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x25A5544", Offset = "0x25A5544", VA = "0x25A5544")]
		private void UpdateDevice()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x25A5DF0", Offset = "0x25A5DF0", VA = "0x25A5DF0")]
		private void UpdateControllerOffset()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x25A5760", Offset = "0x25A5760", VA = "0x25A5760")]
		protected void UpdateInput()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x25A57B4", Offset = "0x25A57B4", VA = "0x25A57B4")]
		private void CorrectDeadzone()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x25A57E8", Offset = "0x25A57E8", VA = "0x25A57E8")]
		protected void CheckButtonState(HexaButtons button, ref PlayerInputState buttonState)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x25A5F38", Offset = "0x25A5F38", VA = "0x25A5F38")]
		protected void ResetButton(ref PlayerInputState buttonState)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x25A5F44", Offset = "0x25A5F44", VA = "0x25A5F44")]
		protected void SetButtonState(ref PlayerInputState buttonState, bool pressed)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x25A5F70", Offset = "0x25A5F70", VA = "0x25A5F70")]
		public bool IsPressed(InputDevice device, HexaXRInputFeatures inputFeature, float threshold = 0f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x25A5BF4", Offset = "0x25A5BF4", VA = "0x25A5BF4")]
		private void CheckControllerType(string manufacturer, string controllerName)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x25A60D0", Offset = "0x25A60D0", VA = "0x25A60D0")]
		public HexaXRInputs()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public enum HexaButtons
	{
		[Token(Token = "0x4000251")]
		Grip,
		[Token(Token = "0x4000252")]
		Trigger,
		[Token(Token = "0x4000253")]
		Primary,
		[Token(Token = "0x4000254")]
		PrimaryTouch,
		[Token(Token = "0x4000255")]
		Secondary,
		[Token(Token = "0x4000256")]
		SecondaryTouch,
		[Token(Token = "0x4000257")]
		Menu,
		[Token(Token = "0x4000258")]
		JoystickButton,
		[Token(Token = "0x4000259")]
		TrackPadButton,
		[Token(Token = "0x400025A")]
		JoystickTouch,
		[Token(Token = "0x400025B")]
		TriggerTouch,
		[Token(Token = "0x400025C")]
		ThumbTouch,
		[Token(Token = "0x400025D")]
		TriggerNearTouch,
		[Token(Token = "0x400025E")]
		ThumbNearTouch,
		[Token(Token = "0x400025F")]
		TrackPadLeft,
		[Token(Token = "0x4000260")]
		TrackPadRight,
		[Token(Token = "0x4000261")]
		TrackPadUp,
		[Token(Token = "0x4000262")]
		TrackPadDown
	}
	[Token(Token = "0x2000020")]
	public enum HexaXRInputFeatures
	{
		[Token(Token = "0x4000264")]
		None,
		[Token(Token = "0x4000265")]
		MenuButton,
		[Token(Token = "0x4000266")]
		Trigger,
		[Token(Token = "0x4000267")]
		Grip,
		[Token(Token = "0x4000268")]
		TriggerPressed,
		[Token(Token = "0x4000269")]
		GripPressed,
		[Token(Token = "0x400026A")]
		PrimaryButton,
		[Token(Token = "0x400026B")]
		PrimaryTouch,
		[Token(Token = "0x400026C")]
		SecondaryButton,
		[Token(Token = "0x400026D")]
		SecondaryTouch,
		[Token(Token = "0x400026E")]
		Primary2DAxisTouch,
		[Token(Token = "0x400026F")]
		Primary2DAxisClick,
		[Token(Token = "0x4000270")]
		Secondary2DAxisTouch,
		[Token(Token = "0x4000271")]
		Secondary2DAxisClick,
		[Token(Token = "0x4000272")]
		PrimaryAxis2DUp,
		[Token(Token = "0x4000273")]
		PrimaryAxis2DDown,
		[Token(Token = "0x4000274")]
		PrimaryAxis2DLeft,
		[Token(Token = "0x4000275")]
		PrimaryAxis2DRight,
		[Token(Token = "0x4000276")]
		SecondaryAxis2DUp,
		[Token(Token = "0x4000277")]
		SecondaryAxis2DDown,
		[Token(Token = "0x4000278")]
		SecondaryAxis2DLeft,
		[Token(Token = "0x4000279")]
		SecondaryAxis2DRight
	}
	[Token(Token = "0x2000021")]
	public class ObjectCollisionDisabler : MonoBehaviour
	{
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x18")]
		public bool TriggersOnly;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x19")]
		public bool IncludeTriggers;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x20")]
		public List<Transform> Transforms;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x25A67F0", Offset = "0x25A67F0", VA = "0x25A67F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x25A7214", Offset = "0x25A7214", VA = "0x25A7214")]
		public ObjectCollisionDisabler()
		{
		}
	}
}
