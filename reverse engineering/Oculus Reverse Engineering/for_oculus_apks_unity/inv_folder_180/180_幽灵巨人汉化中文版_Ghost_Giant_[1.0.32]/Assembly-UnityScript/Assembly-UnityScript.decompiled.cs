using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Boo.Lang;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
[Token(Token = "0x2000002")]
public class CharacterMotorMovement
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x8")]
	public float maxForwardSpeed;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0xC")]
	public float maxSidewaysSpeed;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x10")]
	public float maxBackwardsSpeed;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x14")]
	public AnimationCurve slopeSpeedMultiplier;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x18")]
	public float maxGroundAcceleration;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x1C")]
	public float maxAirAcceleration;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x20")]
	public float gravity;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x24")]
	public float maxFallSpeed;

	[NonSerialized]
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x28")]
	public CollisionFlags collisionFlags;

	[NonSerialized]
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 velocity;

	[NonSerialized]
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 frameVelocity;

	[NonSerialized]
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 hitPoint;

	[NonSerialized]
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 lastHitPoint;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1689600", Offset = "0x1689600", VA = "0x1689600")]
	public CharacterMotorMovement()
	{
	}
}
[Serializable]
[Token(Token = "0x2000003")]
public enum MovementTransferOnJump
{
	[Token(Token = "0x400000F")]
	None,
	[Token(Token = "0x4000010")]
	InitTransfer,
	[Token(Token = "0x4000011")]
	PermaTransfer,
	[Token(Token = "0x4000012")]
	PermaLocked
}
[Serializable]
[Token(Token = "0x2000004")]
public class CharacterMotorJumping
{
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x8")]
	public bool enabled;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0xC")]
	public float baseHeight;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x10")]
	public float extraHeight;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x14")]
	public float perpAmount;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x18")]
	public float steepPerpAmount;

	[NonSerialized]
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x1C")]
	public bool jumping;

	[NonSerialized]
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x1D")]
	public bool holdingJumpButton;

	[NonSerialized]
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x20")]
	public float lastStartTime;

	[NonSerialized]
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x24")]
	public float lastButtonDownTime;

	[NonSerialized]
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 jumpDir;

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1689888", Offset = "0x1689888", VA = "0x1689888")]
	public CharacterMotorJumping()
	{
	}
}
[Serializable]
[Token(Token = "0x2000005")]
public class CharacterMotorMovingPlatform
{
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x8")]
	public bool enabled;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0xC")]
	public MovementTransferOnJump movementTransfer;

	[NonSerialized]
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x10")]
	public Transform hitPlatform;

	[NonSerialized]
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x14")]
	public Transform activePlatform;

	[NonSerialized]
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 activeLocalPoint;

	[NonSerialized]
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 activeGlobalPoint;

	[NonSerialized]
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x30")]
	public Quaternion activeLocalRotation;

	[NonSerialized]
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x40")]
	public Quaternion activeGlobalRotation;

	[NonSerialized]
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x50")]
	public Matrix4x4 lastMatrix;

	[NonSerialized]
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x90")]
	public Vector3 platformVelocity;

	[NonSerialized]
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x9C")]
	public bool newPlatform;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1689960", Offset = "0x1689960", VA = "0x1689960")]
	public CharacterMotorMovingPlatform()
	{
	}
}
[Serializable]
[Token(Token = "0x2000006")]
public class CharacterMotorSliding
{
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x8")]
	public bool enabled;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0xC")]
	public float slidingSpeed;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x10")]
	public float sidewaysControl;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x14")]
	public float speedControl;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1689988", Offset = "0x1689988", VA = "0x1689988")]
	public CharacterMotorSliding()
	{
	}
}
[Serializable]
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2EE2B4", Offset = "0x2EE2B4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x2EE2B4", Offset = "0x2EE2B4")]
public class CharacterMotor : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2EE354", Offset = "0x2EE354")]
	internal sealed class $SubtractNewPlatformVelocity$3 : GenericGenerator<object>
	{
		[Serializable]
		[Token(Token = "0x2000009")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2EE364", Offset = "0x2EE364")]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			[Token(Token = "0x400003A")]
			[FieldOffset(Offset = "0x10")]
			internal Transform $platform$4;

			[Token(Token = "0x400003B")]
			[FieldOffset(Offset = "0x14")]
			internal CharacterMotor $self_$5;

			[Token(Token = "0x6000020")]
			[Address(RVA = "0x168CEA0", Offset = "0x168CEA0", VA = "0x168CEA0")]
			public $(CharacterMotor self_)
			{
			}

			[Token(Token = "0x6000021")]
			[Address(RVA = "0x168CF0C", Offset = "0x168CF0C", VA = "0x168CF0C", Slot = "10")]
			public override bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x8")]
		internal CharacterMotor $self_$6;

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x168C83C", Offset = "0x168C83C", VA = "0x168C83C")]
		public $SubtractNewPlatformVelocity$3(CharacterMotor self_)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x168C8A8", Offset = "0x168C8A8", VA = "0x168C8A8", Slot = "6")]
		public override IEnumerator<object> GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0xC")]
	public bool canControl;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0xD")]
	public bool useFixedUpdate;

	[NonSerialized]
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 inputMoveDirection;

	[NonSerialized]
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x1C")]
	public bool inputJump;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x20")]
	public CharacterMotorMovement movement;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x24")]
	public CharacterMotorJumping jumping;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x28")]
	public CharacterMotorMovingPlatform movingPlatform;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x2C")]
	public CharacterMotorSliding sliding;

	[NonSerialized]
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x30")]
	public bool grounded;

	[NonSerialized]
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 groundNormal;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 lastGroundNormal;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x4C")]
	private Transform tr;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x50")]
	private CharacterController controller;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1689454", Offset = "0x1689454", VA = "0x1689454")]
	public CharacterMotor()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x16899C4", Offset = "0x16899C4", VA = "0x16899C4", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1689AF0", Offset = "0x1689AF0", VA = "0x1689AF0")]
	private void UpdateFunction()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x168BDCC", Offset = "0x168BDCC", VA = "0x168BDCC", Slot = "5")]
	public virtual void FixedUpdate()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x168C198", Offset = "0x168C198", VA = "0x168C198", Slot = "6")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x168AD98", Offset = "0x168AD98", VA = "0x168AD98")]
	private Vector3 ApplyInputVelocityChange(Vector3 velocity)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x168B3F0", Offset = "0x168B3F0", VA = "0x168B3F0")]
	private Vector3 ApplyGravityAndJumping(Vector3 velocity)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x168C4FC", Offset = "0x168C4FC", VA = "0x168C4FC", Slot = "7")]
	public virtual void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x168BD4C", Offset = "0x168BD4C", VA = "0x168BD4C")]
	private IEnumerator SubtractNewPlatformVelocity()
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x168BC3C", Offset = "0x168BC3C", VA = "0x168BC3C")]
	private bool MoveWithPlatform()
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x168C1A8", Offset = "0x168C1A8", VA = "0x168C1A8")]
	private Vector3 GetDesiredHorizontalVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x168C3A0", Offset = "0x168C3A0", VA = "0x168C3A0")]
	private Vector3 AdjustGroundVelocityToNormal(Vector3 hVelocity, Vector3 groundNormal)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x168BD2C", Offset = "0x168BD2C", VA = "0x168BD2C")]
	private bool IsGroundedTest()
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x168C91C", Offset = "0x168C91C", VA = "0x168C91C", Slot = "8")]
	public virtual float GetMaxAcceleration(bool grounded)
	{
		return default(float);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x168C94C", Offset = "0x168C94C", VA = "0x168C94C", Slot = "9")]
	public virtual float CalculateJumpVerticalSpeed(float targetJumpHeight)
	{
		return default(float);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x168CA10", Offset = "0x168CA10", VA = "0x168CA10", Slot = "10")]
	public virtual bool IsJumping()
	{
		return default(bool);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x168CA30", Offset = "0x168CA30", VA = "0x168CA30", Slot = "11")]
	public virtual bool IsSliding()
	{
		return default(bool);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x168CA88", Offset = "0x168CA88", VA = "0x168CA88", Slot = "12")]
	public virtual bool IsTouchingCeiling()
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x168CAB0", Offset = "0x168CAB0", VA = "0x168CAB0", Slot = "13")]
	public virtual bool IsGrounded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x168CAB8", Offset = "0x168CAB8", VA = "0x168CAB8", Slot = "14")]
	public virtual bool TooSteep()
	{
		return default(bool);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x168CB8C", Offset = "0x168CB8C", VA = "0x168CB8C", Slot = "15")]
	public virtual Vector3 GetDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x168CB9C", Offset = "0x168CB9C", VA = "0x168CB9C", Slot = "16")]
	public virtual void SetControllable(bool controllable)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x168CBA4", Offset = "0x168CBA4", VA = "0x168CBA4", Slot = "17")]
	public virtual float MaxSpeedInDirection(Vector3 desiredMovementDirection)
	{
		return default(float);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x168CDA4", Offset = "0x168CDA4", VA = "0x168CDA4", Slot = "18")]
	public virtual void SetVelocity(Vector3 velocity)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x168CE9C", Offset = "0x168CE9C", VA = "0x168CE9C", Slot = "19")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2EE374", Offset = "0x2EE374")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x2EE374", Offset = "0x2EE374")]
public class FPSInputController : MonoBehaviour
{
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0xC")]
	private CharacterMotor motor;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x168D300", Offset = "0x168D300", VA = "0x168D300")]
	public FPSInputController()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x168D308", Offset = "0x168D308", VA = "0x168D308", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x168D440", Offset = "0x168D440", VA = "0x168D440", Slot = "5")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x168D7DC", Offset = "0x168D7DC", VA = "0x168D7DC", Slot = "6")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2EE414", Offset = "0x2EE414")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x2EE414", Offset = "0x2EE414")]
public class PlatformInputController : MonoBehaviour
{
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0xC")]
	public bool autoRotate;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x10")]
	public float maxRotationSpeed;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x14")]
	private CharacterMotor motor;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x168D7E0", Offset = "0x168D7E0", VA = "0x168D7E0")]
	public PlatformInputController()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x168D80C", Offset = "0x168D80C", VA = "0x168D80C", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x168D944", Offset = "0x168D944", VA = "0x168D944", Slot = "5")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x168E028", Offset = "0x168E028", VA = "0x168E028", Slot = "6")]
	public virtual Vector3 ProjectOntoPlane(Vector3 v, Vector3 normal)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x168E114", Offset = "0x168E114", VA = "0x168E114", Slot = "7")]
	public virtual Vector3 ConstantSlerp(Vector3 from, Vector3 to, float angle)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x168E258", Offset = "0x168E258", VA = "0x168E258", Slot = "8")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x200000C")]
public class ThirdPersonCamera : MonoBehaviour
{
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0xC")]
	public Transform cameraTransform;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x10")]
	private Transform _target;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x14")]
	public float distance;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x18")]
	public float height;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x1C")]
	public float angularSmoothLag;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x20")]
	public float angularMaxSpeed;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x24")]
	public float heightSmoothLag;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x28")]
	public float snapSmoothLag;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x2C")]
	public float snapMaxSpeed;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x30")]
	public float clampHeadPositionScreenSpace;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x34")]
	public float lockCameraTimeout;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 headOffset;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 centerOffset;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x50")]
	private float heightVelocity;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x54")]
	private float angleVelocity;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x58")]
	private bool snap;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x5C")]
	private ThirdPersonController controller;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x60")]
	private float targetHeight;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x168E25C", Offset = "0x168E25C", VA = "0x168E25C")]
	public ThirdPersonCamera()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x168E388", Offset = "0x168E388", VA = "0x168E388", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x168E94C", Offset = "0x168E94C", VA = "0x168E94C", Slot = "5")]
	public virtual void DebugDrawStuff()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x168EA98", Offset = "0x168EA98", VA = "0x168EA98", Slot = "6")]
	public virtual float AngleDistance(float a, float b)
	{
		return default(float);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x168EB60", Offset = "0x168EB60", VA = "0x168EB60", Slot = "7")]
	public virtual void Apply(Transform dummyTarget, Vector3 dummyCenter)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x168F26C", Offset = "0x168F26C", VA = "0x168F26C", Slot = "8")]
	public virtual void LateUpdate()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x168F338", Offset = "0x168F338", VA = "0x168F338", Slot = "9")]
	public virtual void Cut(Transform dummyTarget, Vector3 dummyCenter)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x168F440", Offset = "0x168F440", VA = "0x168F440", Slot = "10")]
	public virtual void SetUpRotation(Vector3 centerPos, Vector3 headPos)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x168F980", Offset = "0x168F980", VA = "0x168F980", Slot = "11")]
	public virtual Vector3 GetCenterOffset()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x168F990", Offset = "0x168F990", VA = "0x168F990", Slot = "12")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x200000D")]
public enum CharacterState
{
	[Token(Token = "0x4000053")]
	Idle,
	[Token(Token = "0x4000054")]
	Walking,
	[Token(Token = "0x4000055")]
	Trotting,
	[Token(Token = "0x4000056")]
	Running,
	[Token(Token = "0x4000057")]
	Jumping
}
[Serializable]
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x2EE4B4", Offset = "0x2EE4B4")]
public class ThirdPersonController : MonoBehaviour
{
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0xC")]
	public AnimationClip idleAnimation;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x10")]
	public AnimationClip walkAnimation;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x14")]
	public AnimationClip runAnimation;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x18")]
	public AnimationClip jumpPoseAnimation;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x1C")]
	public float walkMaxAnimationSpeed;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x20")]
	public float trotMaxAnimationSpeed;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x24")]
	public float runMaxAnimationSpeed;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x28")]
	public float jumpAnimationSpeed;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x2C")]
	public float landAnimationSpeed;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x30")]
	private Animation _animation;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x34")]
	private CharacterState _characterState;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x38")]
	public float walkSpeed;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x3C")]
	public float trotSpeed;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x40")]
	public float runSpeed;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x44")]
	public float inAirControlAcceleration;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x48")]
	public float jumpHeight;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x4C")]
	public float gravity;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x50")]
	public float speedSmoothing;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x54")]
	public float rotateSpeed;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x58")]
	public float trotAfterSeconds;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x5C")]
	public bool canJump;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x60")]
	private float jumpRepeatTime;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x64")]
	private float jumpTimeout;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x68")]
	private float groundedTimeout;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x6C")]
	private float lockCameraTimer;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 moveDirection;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x7C")]
	private float verticalSpeed;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x80")]
	private float moveSpeed;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x84")]
	private CollisionFlags collisionFlags;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x88")]
	private bool jumping;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x89")]
	private bool jumpingReachedApex;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x8A")]
	private bool movingBack;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x8B")]
	private bool isMoving;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x8C")]
	private float walkTimeStart;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x90")]
	private float lastJumpButtonTime;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x94")]
	private float lastJumpTime;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x98")]
	private float lastJumpStartHeight;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x9C")]
	private Vector3 inAirVelocity;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0xA8")]
	private float lastGroundedTime;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0xAC")]
	private bool isControllable;

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x168F994", Offset = "0x168F994", VA = "0x168F994")]
	public ThirdPersonController()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x168FB20", Offset = "0x168FB20", VA = "0x168FB20", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x168FFBC", Offset = "0x168FFBC", VA = "0x168FFBC", Slot = "5")]
	public virtual void UpdateSmoothedMovementDirection()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x16907E0", Offset = "0x16907E0", VA = "0x16907E0", Slot = "6")]
	public virtual void ApplyJumping()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x16908F0", Offset = "0x16908F0", VA = "0x16908F0", Slot = "7")]
	public virtual void ApplyGravity()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1690A30", Offset = "0x1690A30", VA = "0x1690A30", Slot = "8")]
	public virtual float CalculateJumpVerticalSpeed(float targetJumpHeight)
	{
		return default(float);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1690AE4", Offset = "0x1690AE4", VA = "0x1690AE4", Slot = "9")]
	public virtual void DidJump()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1690B5C", Offset = "0x1690B5C", VA = "0x1690B5C", Slot = "10")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1691580", Offset = "0x1691580", VA = "0x1691580", Slot = "11")]
	public virtual void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x16915B4", Offset = "0x16915B4", VA = "0x16915B4", Slot = "12")]
	public virtual float GetSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x16915BC", Offset = "0x16915BC", VA = "0x16915BC", Slot = "13")]
	public virtual bool IsJumping()
	{
		return default(bool);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x16915C4", Offset = "0x16915C4", VA = "0x16915C4", Slot = "14")]
	public virtual bool IsGrounded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x16915D4", Offset = "0x16915D4", VA = "0x16915D4", Slot = "15")]
	public virtual Vector3 GetDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x16915E4", Offset = "0x16915E4", VA = "0x16915E4", Slot = "16")]
	public virtual bool IsMovingBackwards()
	{
		return default(bool);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x16915EC", Offset = "0x16915EC", VA = "0x16915EC", Slot = "17")]
	public virtual float GetLockCameraTimer()
	{
		return default(float);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x16915F4", Offset = "0x16915F4", VA = "0x16915F4", Slot = "18")]
	public virtual bool IsMoving()
	{
		return default(bool);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1691708", Offset = "0x1691708", VA = "0x1691708", Slot = "19")]
	public virtual bool HasJumpReachedApex()
	{
		return default(bool);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1691710", Offset = "0x1691710", VA = "0x1691710", Slot = "20")]
	public virtual bool IsGroundedWithTimeout()
	{
		return default(bool);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1691754", Offset = "0x1691754", VA = "0x1691754", Slot = "21")]
	public virtual void Reset()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x16917D8", Offset = "0x16917D8", VA = "0x16917D8", Slot = "22")]
	public virtual void Main()
	{
	}
}
