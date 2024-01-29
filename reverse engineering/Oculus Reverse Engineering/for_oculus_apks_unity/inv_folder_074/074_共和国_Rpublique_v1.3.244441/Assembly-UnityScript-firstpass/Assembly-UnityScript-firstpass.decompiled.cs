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
	[Address(RVA = "0xD8F928", Offset = "0xD8F928", VA = "0xD8F928")]
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
	[Address(RVA = "0xD8FBB0", Offset = "0xD8FBB0", VA = "0xD8FBB0")]
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
	[Address(RVA = "0xD8FC88", Offset = "0xD8FC88", VA = "0xD8FC88")]
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
	[Address(RVA = "0xD8FCB0", Offset = "0xD8FCB0", VA = "0xD8FCB0")]
	public CharacterMotorSliding()
	{
	}
}
[Serializable]
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xEA60B0", Offset = "0xEA60B0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xEA60B0", Offset = "0xEA60B0")]
public class CharacterMotor : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEA6150", Offset = "0xEA6150")]
	internal sealed class $SubtractNewPlatformVelocity$10 : GenericGenerator<object>
	{
		[Serializable]
		[Token(Token = "0x2000009")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEA6160", Offset = "0xEA6160")]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			[Token(Token = "0x400003A")]
			[FieldOffset(Offset = "0x10")]
			internal Transform $platform$11;

			[Token(Token = "0x400003B")]
			[FieldOffset(Offset = "0x14")]
			internal CharacterMotor $self_$12;

			[Token(Token = "0x6000020")]
			[Address(RVA = "0xD931C8", Offset = "0xD931C8", VA = "0xD931C8")]
			public $(CharacterMotor self_)
			{
			}

			[Token(Token = "0x6000021")]
			[Address(RVA = "0xD93234", Offset = "0xD93234", VA = "0xD93234", Slot = "10")]
			public override bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x8")]
		internal CharacterMotor $self_$13;

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xD92B64", Offset = "0xD92B64", VA = "0xD92B64")]
		public $SubtractNewPlatformVelocity$10(CharacterMotor self_)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xD92BD0", Offset = "0xD92BD0", VA = "0xD92BD0", Slot = "6")]
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
	[Address(RVA = "0xD8F77C", Offset = "0xD8F77C", VA = "0xD8F77C")]
	public CharacterMotor()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xD8FCEC", Offset = "0xD8FCEC", VA = "0xD8FCEC", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xD8FE18", Offset = "0xD8FE18", VA = "0xD8FE18")]
	private void UpdateFunction()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xD920F4", Offset = "0xD920F4", VA = "0xD920F4", Slot = "5")]
	public virtual void FixedUpdate()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xD924C0", Offset = "0xD924C0", VA = "0xD924C0", Slot = "6")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xD910C0", Offset = "0xD910C0", VA = "0xD910C0")]
	private Vector3 ApplyInputVelocityChange(Vector3 velocity)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xD91718", Offset = "0xD91718", VA = "0xD91718")]
	private Vector3 ApplyGravityAndJumping(Vector3 velocity)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xD92824", Offset = "0xD92824", VA = "0xD92824", Slot = "7")]
	public virtual void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xD92074", Offset = "0xD92074", VA = "0xD92074")]
	private IEnumerator SubtractNewPlatformVelocity()
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xD91F64", Offset = "0xD91F64", VA = "0xD91F64")]
	private bool MoveWithPlatform()
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xD924D0", Offset = "0xD924D0", VA = "0xD924D0")]
	private Vector3 GetDesiredHorizontalVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xD926C8", Offset = "0xD926C8", VA = "0xD926C8")]
	private Vector3 AdjustGroundVelocityToNormal(Vector3 hVelocity, Vector3 groundNormal)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xD92054", Offset = "0xD92054", VA = "0xD92054")]
	private bool IsGroundedTest()
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xD92C44", Offset = "0xD92C44", VA = "0xD92C44", Slot = "8")]
	public virtual float GetMaxAcceleration(bool grounded)
	{
		return default(float);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xD92C74", Offset = "0xD92C74", VA = "0xD92C74", Slot = "9")]
	public virtual float CalculateJumpVerticalSpeed(float targetJumpHeight)
	{
		return default(float);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xD92D38", Offset = "0xD92D38", VA = "0xD92D38", Slot = "10")]
	public virtual bool IsJumping()
	{
		return default(bool);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xD92D58", Offset = "0xD92D58", VA = "0xD92D58", Slot = "11")]
	public virtual bool IsSliding()
	{
		return default(bool);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xD92DB0", Offset = "0xD92DB0", VA = "0xD92DB0", Slot = "12")]
	public virtual bool IsTouchingCeiling()
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xD92DD8", Offset = "0xD92DD8", VA = "0xD92DD8", Slot = "13")]
	public virtual bool IsGrounded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xD92DE0", Offset = "0xD92DE0", VA = "0xD92DE0", Slot = "14")]
	public virtual bool TooSteep()
	{
		return default(bool);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xD92EB4", Offset = "0xD92EB4", VA = "0xD92EB4", Slot = "15")]
	public virtual Vector3 GetDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xD92EC4", Offset = "0xD92EC4", VA = "0xD92EC4", Slot = "16")]
	public virtual void SetControllable(bool controllable)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xD92ECC", Offset = "0xD92ECC", VA = "0xD92ECC", Slot = "17")]
	public virtual float MaxSpeedInDirection(Vector3 desiredMovementDirection)
	{
		return default(float);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xD930CC", Offset = "0xD930CC", VA = "0xD930CC", Slot = "18")]
	public virtual void SetVelocity(Vector3 velocity)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xD931C4", Offset = "0xD931C4", VA = "0xD931C4", Slot = "19")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xEA6170", Offset = "0xEA6170")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xEA6170", Offset = "0xEA6170")]
public class FPSInputController : MonoBehaviour
{
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0xC")]
	private CharacterMotor motor;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xD93628", Offset = "0xD93628", VA = "0xD93628")]
	public FPSInputController()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xD93630", Offset = "0xD93630", VA = "0xD93630", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xD93768", Offset = "0xD93768", VA = "0xD93768", Slot = "5")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xD93B04", Offset = "0xD93B04", VA = "0xD93B04", Slot = "6")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xEA6210", Offset = "0xEA6210")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xEA6210", Offset = "0xEA6210")]
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
	[Address(RVA = "0xD93B08", Offset = "0xD93B08", VA = "0xD93B08")]
	public PlatformInputController()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xD93B34", Offset = "0xD93B34", VA = "0xD93B34", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xD93C6C", Offset = "0xD93C6C", VA = "0xD93C6C", Slot = "5")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xD94350", Offset = "0xD94350", VA = "0xD94350", Slot = "6")]
	public virtual Vector3 ProjectOntoPlane(Vector3 v, Vector3 normal)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xD9443C", Offset = "0xD9443C", VA = "0xD9443C", Slot = "7")]
	public virtual Vector3 ConstantSlerp(Vector3 from, Vector3 to, float angle)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xD94580", Offset = "0xD94580", VA = "0xD94580", Slot = "8")]
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
	[Address(RVA = "0xD95670", Offset = "0xD95670", VA = "0xD95670")]
	public ThirdPersonCamera()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xD9579C", Offset = "0xD9579C", VA = "0xD9579C", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xD95D60", Offset = "0xD95D60", VA = "0xD95D60", Slot = "5")]
	public virtual void DebugDrawStuff()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xD95EAC", Offset = "0xD95EAC", VA = "0xD95EAC", Slot = "6")]
	public virtual float AngleDistance(float a, float b)
	{
		return default(float);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xD95F74", Offset = "0xD95F74", VA = "0xD95F74", Slot = "7")]
	public virtual void Apply(Transform dummyTarget, Vector3 dummyCenter)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xD96680", Offset = "0xD96680", VA = "0xD96680", Slot = "8")]
	public virtual void LateUpdate()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xD9674C", Offset = "0xD9674C", VA = "0xD9674C", Slot = "9")]
	public virtual void Cut(Transform dummyTarget, Vector3 dummyCenter)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xD96854", Offset = "0xD96854", VA = "0xD96854", Slot = "10")]
	public virtual void SetUpRotation(Vector3 centerPos, Vector3 headPos)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xD96D94", Offset = "0xD96D94", VA = "0xD96D94", Slot = "11")]
	public virtual Vector3 GetCenterOffset()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xD96DA4", Offset = "0xD96DA4", VA = "0xD96DA4", Slot = "12")]
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
[AttributeAttribute(Name = "RequireComponent", RVA = "0xEA62B0", Offset = "0xEA62B0")]
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
	[Address(RVA = "0xD96DA8", Offset = "0xD96DA8", VA = "0xD96DA8")]
	public ThirdPersonController()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xD96F34", Offset = "0xD96F34", VA = "0xD96F34", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xD973D0", Offset = "0xD973D0", VA = "0xD973D0", Slot = "5")]
	public virtual void UpdateSmoothedMovementDirection()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xD97BF4", Offset = "0xD97BF4", VA = "0xD97BF4", Slot = "6")]
	public virtual void ApplyJumping()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xD97D04", Offset = "0xD97D04", VA = "0xD97D04", Slot = "7")]
	public virtual void ApplyGravity()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xD97E44", Offset = "0xD97E44", VA = "0xD97E44", Slot = "8")]
	public virtual float CalculateJumpVerticalSpeed(float targetJumpHeight)
	{
		return default(float);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xD97EF8", Offset = "0xD97EF8", VA = "0xD97EF8", Slot = "9")]
	public virtual void DidJump()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xD97F70", Offset = "0xD97F70", VA = "0xD97F70", Slot = "10")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xD98994", Offset = "0xD98994", VA = "0xD98994", Slot = "11")]
	public virtual void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xD989C8", Offset = "0xD989C8", VA = "0xD989C8", Slot = "12")]
	public virtual float GetSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xD989D0", Offset = "0xD989D0", VA = "0xD989D0", Slot = "13")]
	public virtual bool IsJumping()
	{
		return default(bool);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xD989D8", Offset = "0xD989D8", VA = "0xD989D8", Slot = "14")]
	public virtual bool IsGrounded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xD989E8", Offset = "0xD989E8", VA = "0xD989E8", Slot = "15")]
	public virtual Vector3 GetDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xD989F8", Offset = "0xD989F8", VA = "0xD989F8", Slot = "16")]
	public virtual bool IsMovingBackwards()
	{
		return default(bool);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xD98A00", Offset = "0xD98A00", VA = "0xD98A00", Slot = "17")]
	public virtual float GetLockCameraTimer()
	{
		return default(float);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xD98A08", Offset = "0xD98A08", VA = "0xD98A08", Slot = "18")]
	public virtual bool IsMoving()
	{
		return default(bool);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xD98B1C", Offset = "0xD98B1C", VA = "0xD98B1C", Slot = "19")]
	public virtual bool HasJumpReachedApex()
	{
		return default(bool);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xD98B24", Offset = "0xD98B24", VA = "0xD98B24", Slot = "20")]
	public virtual bool IsGroundedWithTimeout()
	{
		return default(bool);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xD98B68", Offset = "0xD98B68", VA = "0xD98B68", Slot = "21")]
	public virtual void Reset()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xD98BEC", Offset = "0xD98BEC", VA = "0xD98BEC", Slot = "22")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x200000F")]
public enum AAMode
{
	[Token(Token = "0x4000081")]
	FXAA2,
	[Token(Token = "0x4000082")]
	FXAA3Console,
	[Token(Token = "0x4000083")]
	FXAA1PresetA,
	[Token(Token = "0x4000084")]
	FXAA1PresetB,
	[Token(Token = "0x4000085")]
	NFAA,
	[Token(Token = "0x4000086")]
	SSAA,
	[Token(Token = "0x4000087")]
	DLAA
}
[Serializable]
[Token(Token = "0x2000010")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xEA6328", Offset = "0xEA6328")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xEA6328", Offset = "0xEA6328")]
public class AntialiasingAsPostEffect : PostEffectsBase
{
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x10")]
	public AAMode mode;

	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x14")]
	public bool showGeneratedNormals;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x18")]
	public float offsetScale;

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x1C")]
	public float blurRadius;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x20")]
	public float edgeThresholdMin;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x24")]
	public float edgeThreshold;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x28")]
	public float edgeSharpness;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x2C")]
	public bool dlaaSharp;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x30")]
	public Shader ssaaShader;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x34")]
	private Material ssaa;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x38")]
	public Shader dlaaShader;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x3C")]
	private Material dlaa;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x40")]
	public Shader nfaaShader;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x44")]
	private Material nfaa;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x48")]
	public Shader shaderFXAAPreset2;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x4C")]
	private Material materialFXAAPreset2;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x50")]
	public Shader shaderFXAAPreset3;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x54")]
	private Material materialFXAAPreset3;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x58")]
	public Shader shaderFXAAII;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x5C")]
	private Material materialFXAAII;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x60")]
	public Shader shaderFXAAIII;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x64")]
	private Material materialFXAAIII;

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xD8D334", Offset = "0xD8D334", VA = "0xD8D334")]
	public AntialiasingAsPostEffect()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xD8D3AC", Offset = "0xD8D3AC", VA = "0xD8D3AC", Slot = "17")]
	public virtual Material CurrentAAMaterial()
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xD8D424", Offset = "0xD8D424", VA = "0xD8D424", Slot = "8")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xD8D57C", Offset = "0xD8D57C", VA = "0xD8D57C", Slot = "18")]
	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xD8DCD4", Offset = "0xD8DCD4", VA = "0xD8DCD4", Slot = "16")]
	public override void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x2000011")]
public enum LensflareStyle34
{
	[Token(Token = "0x400009F")]
	Ghosting,
	[Token(Token = "0x40000A0")]
	Anamorphic,
	[Token(Token = "0x40000A1")]
	Combined
}
[Serializable]
[Token(Token = "0x2000012")]
public enum TweakMode34
{
	[Token(Token = "0x40000A3")]
	Basic,
	[Token(Token = "0x40000A4")]
	Complex
}
[Serializable]
[Token(Token = "0x2000013")]
public enum HDRBloomMode
{
	[Token(Token = "0x40000A6")]
	Auto,
	[Token(Token = "0x40000A7")]
	On,
	[Token(Token = "0x40000A8")]
	Off
}
[Serializable]
[Token(Token = "0x2000014")]
public enum BloomScreenBlendMode
{
	[Token(Token = "0x40000AA")]
	Screen,
	[Token(Token = "0x40000AB")]
	Add
}
[Serializable]
[Token(Token = "0x2000015")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xEA63D8", Offset = "0xEA63D8")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xEA63D8", Offset = "0xEA63D8")]
[ExecuteInEditMode]
public class BloomAndLensFlares : PostEffectsBase
{
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x10")]
	public TweakMode34 tweakMode;

	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x14")]
	public BloomScreenBlendMode screenBlendMode;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x18")]
	public HDRBloomMode hdr;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x1C")]
	private bool doHdr;

	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x20")]
	public float sepBlurSpread;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x24")]
	public float useSrcAlphaAsMask;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x28")]
	public float bloomIntensity;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x2C")]
	public float bloomThreshhold;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x30")]
	public int bloomBlurIterations;

	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x34")]
	public bool lensflares;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x38")]
	public int hollywoodFlareBlurIterations;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x3C")]
	public LensflareStyle34 lensflareMode;

	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x40")]
	public float hollyStretchWidth;

	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x44")]
	public float lensflareIntensity;

	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x48")]
	public float lensflareThreshhold;

	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x4C")]
	public Color flareColorA;

	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x5C")]
	public Color flareColorB;

	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x6C")]
	public Color flareColorC;

	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x7C")]
	public Color flareColorD;

	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x8C")]
	public float blurWidth;

	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x90")]
	public Texture2D lensFlareVignetteMask;

	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x94")]
	public Shader lensFlareShader;

	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x98")]
	private Material lensFlareMaterial;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x9C")]
	public Shader vignetteShader;

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0xA0")]
	private Material vignetteMaterial;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0xA4")]
	public Shader separableBlurShader;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0xA8")]
	private Material separableBlurMaterial;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0xAC")]
	public Shader addBrightStuffOneOneShader;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0xB0")]
	private Material addBrightStuffBlendOneOneMaterial;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0xB4")]
	public Shader screenBlendShader;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0xB8")]
	private Material screenBlend;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0xBC")]
	public Shader hollywoodFlaresShader;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0xC0")]
	private Material hollywoodFlaresMaterial;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0xC4")]
	public Shader brightPassFilterShader;

	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0xC8")]
	private Material brightPassFilterMaterial;

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xD8DCD8", Offset = "0xD8DCD8", VA = "0xD8DCD8")]
	public BloomAndLensFlares()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xD8DE58", Offset = "0xD8DE58", VA = "0xD8DE58", Slot = "8")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xD8DF8C", Offset = "0xD8DF8C", VA = "0xD8DF8C", Slot = "17")]
	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xD8F69C", Offset = "0xD8F69C", VA = "0xD8F69C")]
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xD8F36C", Offset = "0xD8F36C", VA = "0xD8F36C")]
	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xD8EFF0", Offset = "0xD8EFF0", VA = "0xD8EFF0")]
	private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xD8F1BC", Offset = "0xD8F1BC", VA = "0xD8F1BC")]
	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xD8F778", Offset = "0xD8F778", VA = "0xD8F778", Slot = "16")]
	public override void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x2000016")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xEA6488", Offset = "0xEA6488")]
[ExecuteInEditMode]
public class PostEffectsBase : MonoBehaviour
{
	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0xC")]
	protected bool supportHDRTextures;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0xD")]
	protected bool isSupported;

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xD8D38C", Offset = "0xD8D38C", VA = "0xD8D38C")]
	public PostEffectsBase()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xD94584", Offset = "0xD94584", VA = "0xD94584", Slot = "4")]
	public virtual Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xD94980", Offset = "0xD94980", VA = "0xD94980", Slot = "5")]
	public virtual Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xD94C38", Offset = "0xD94C38", VA = "0xD94C38", Slot = "6")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xD94C44", Offset = "0xD94C44", VA = "0xD94C44", Slot = "7")]
	public virtual bool CheckSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xD94C58", Offset = "0xD94C58", VA = "0xD94C58", Slot = "8")]
	public virtual bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xD94D6C", Offset = "0xD94D6C", VA = "0xD94D6C", Slot = "9")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xD94D7C", Offset = "0xD94D7C", VA = "0xD94D7C", Slot = "10")]
	public virtual bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xD94EC0", Offset = "0xD94EC0", VA = "0xD94EC0", Slot = "11")]
	public virtual bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xD94F1C", Offset = "0xD94F1C", VA = "0xD94F1C", Slot = "12")]
	public virtual void ReportAutoDisable()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xD9502C", Offset = "0xD9502C", VA = "0xD9502C", Slot = "13")]
	public virtual bool CheckShader(Shader s)
	{
		return default(bool);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xD951D0", Offset = "0xD951D0", VA = "0xD951D0", Slot = "14")]
	public virtual void NotSupported()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xD951F4", Offset = "0xD951F4", VA = "0xD951F4", Slot = "15")]
	public virtual void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xD9566C", Offset = "0xD9566C", VA = "0xD9566C", Slot = "16")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x2000017")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xEA6510", Offset = "0xEA6510")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xEA6510", Offset = "0xEA6510")]
[ExecuteInEditMode]
public class Vignetting : PostEffectsBase
{
	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x10")]
	public float intensity;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x14")]
	public float chromaticAberration;

	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x18")]
	public float blur;

	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x1C")]
	public float blurSpread;

	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x20")]
	public Shader vignetteShader;

	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x24")]
	private Material vignetteMaterial;

	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x28")]
	public Shader separableBlurShader;

	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x2C")]
	private Material separableBlurMaterial;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x30")]
	public Shader chromAberrationShader;

	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x34")]
	private Material chromAberrationMaterial;

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xD98BF0", Offset = "0xD98BF0", VA = "0xD98BF0")]
	public Vignetting()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xD98C34", Offset = "0xD98C34", VA = "0xD98C34", Slot = "8")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xD98CE8", Offset = "0xD98CE8", VA = "0xD98CE8", Slot = "17")]
	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xD99384", Offset = "0xD99384", VA = "0xD99384", Slot = "16")]
	public override void Main()
	{
	}
}
