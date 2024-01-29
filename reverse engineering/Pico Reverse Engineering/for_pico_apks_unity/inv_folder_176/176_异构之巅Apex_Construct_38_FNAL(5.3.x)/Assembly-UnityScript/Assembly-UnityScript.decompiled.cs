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
public class RandomMaterial : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0xC")]
	public Renderer targetRenderer;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x10")]
	public Material[] materials;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1DBEB60", Offset = "0x1DBEB60", VA = "0x1DBEB60")]
	public RandomMaterial()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1DBEB68", Offset = "0x1DBEB68", VA = "0x1DBEB68", Slot = "4")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1DBEBEC", Offset = "0x1DBEBEC", VA = "0x1DBEBEC", Slot = "5")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x2000003")]
public class CharacterMotorMovement
{
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x8")]
	public float maxForwardSpeed;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0xC")]
	public float maxSidewaysSpeed;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x10")]
	public float maxBackwardsSpeed;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x14")]
	public AnimationCurve slopeSpeedMultiplier;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x18")]
	public float maxGroundAcceleration;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x1C")]
	public float maxAirAcceleration;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x20")]
	public float gravity;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x24")]
	public float maxFallSpeed;

	[NonSerialized]
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x28")]
	public CollisionFlags collisionFlags;

	[NonSerialized]
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 velocity;

	[NonSerialized]
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 frameVelocity;

	[NonSerialized]
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 hitPoint;

	[NonSerialized]
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 lastHitPoint;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1DB9F04", Offset = "0x1DB9F04", VA = "0x1DB9F04")]
	public CharacterMotorMovement()
	{
	}
}
[Serializable]
[Token(Token = "0x2000004")]
public enum MovementTransferOnJump
{
	[Token(Token = "0x4000011")]
	None,
	[Token(Token = "0x4000012")]
	InitTransfer,
	[Token(Token = "0x4000013")]
	PermaTransfer,
	[Token(Token = "0x4000014")]
	PermaLocked
}
[Serializable]
[Token(Token = "0x2000005")]
public class CharacterMotorJumping
{
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x8")]
	public bool enabled;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0xC")]
	public float baseHeight;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x10")]
	public float extraHeight;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x14")]
	public float perpAmount;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x18")]
	public float steepPerpAmount;

	[NonSerialized]
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x1C")]
	public bool jumping;

	[NonSerialized]
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x1D")]
	public bool holdingJumpButton;

	[NonSerialized]
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x20")]
	public float lastStartTime;

	[NonSerialized]
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x24")]
	public float lastButtonDownTime;

	[NonSerialized]
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 jumpDir;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1DBA18C", Offset = "0x1DBA18C", VA = "0x1DBA18C")]
	public CharacterMotorJumping()
	{
	}
}
[Serializable]
[Token(Token = "0x2000006")]
public class CharacterMotorMovingPlatform
{
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x8")]
	public bool enabled;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0xC")]
	public MovementTransferOnJump movementTransfer;

	[NonSerialized]
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x10")]
	public Transform hitPlatform;

	[NonSerialized]
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x14")]
	public Transform activePlatform;

	[NonSerialized]
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 activeLocalPoint;

	[NonSerialized]
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 activeGlobalPoint;

	[NonSerialized]
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x30")]
	public Quaternion activeLocalRotation;

	[NonSerialized]
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x40")]
	public Quaternion activeGlobalRotation;

	[NonSerialized]
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x50")]
	public Matrix4x4 lastMatrix;

	[NonSerialized]
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x90")]
	public Vector3 platformVelocity;

	[NonSerialized]
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x9C")]
	public bool newPlatform;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1DBA264", Offset = "0x1DBA264", VA = "0x1DBA264")]
	public CharacterMotorMovingPlatform()
	{
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public class CharacterMotorSliding
{
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x8")]
	public bool enabled;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0xC")]
	public float slidingSpeed;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x10")]
	public float sidewaysControl;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x14")]
	public float speedControl;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1DBA28C", Offset = "0x1DBA28C", VA = "0x1DBA28C")]
	public CharacterMotorSliding()
	{
	}
}
[Serializable]
[Token(Token = "0x2000008")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4523A0", Offset = "0x4523A0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x4523A0", Offset = "0x4523A0")]
public class CharacterMotor : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x452440", Offset = "0x452440")]
	internal sealed class $SubtractNewPlatformVelocity$3 : GenericGenerator<object>
	{
		[Serializable]
		[Token(Token = "0x200000A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x452450", Offset = "0x452450")]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			[Token(Token = "0x400003C")]
			[FieldOffset(Offset = "0x10")]
			internal Transform $platform$4;

			[Token(Token = "0x400003D")]
			[FieldOffset(Offset = "0x14")]
			internal CharacterMotor $self_$5;

			[Token(Token = "0x6000023")]
			[Address(RVA = "0x1DBD7A4", Offset = "0x1DBD7A4", VA = "0x1DBD7A4")]
			public $(CharacterMotor self_)
			{
			}

			[Token(Token = "0x6000024")]
			[Address(RVA = "0x1DBD810", Offset = "0x1DBD810", VA = "0x1DBD810", Slot = "10")]
			public override bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x8")]
		internal CharacterMotor $self_$6;

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1DBD140", Offset = "0x1DBD140", VA = "0x1DBD140")]
		public $SubtractNewPlatformVelocity$3(CharacterMotor self_)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1DBD1AC", Offset = "0x1DBD1AC", VA = "0x1DBD1AC", Slot = "6")]
		public override IEnumerator<object> GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0xC")]
	public bool canControl;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0xD")]
	public bool useFixedUpdate;

	[NonSerialized]
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 inputMoveDirection;

	[NonSerialized]
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x1C")]
	public bool inputJump;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x20")]
	public CharacterMotorMovement movement;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x24")]
	public CharacterMotorJumping jumping;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x28")]
	public CharacterMotorMovingPlatform movingPlatform;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x2C")]
	public CharacterMotorSliding sliding;

	[NonSerialized]
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x30")]
	public bool grounded;

	[NonSerialized]
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 groundNormal;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 lastGroundNormal;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x4C")]
	private Transform tr;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x50")]
	private CharacterController controller;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1DB9D58", Offset = "0x1DB9D58", VA = "0x1DB9D58")]
	public CharacterMotor()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1DBA2C8", Offset = "0x1DBA2C8", VA = "0x1DBA2C8", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1DBA3F4", Offset = "0x1DBA3F4", VA = "0x1DBA3F4")]
	private void UpdateFunction()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1DBC6D0", Offset = "0x1DBC6D0", VA = "0x1DBC6D0", Slot = "5")]
	public virtual void FixedUpdate()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1DBCA9C", Offset = "0x1DBCA9C", VA = "0x1DBCA9C", Slot = "6")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1DBB69C", Offset = "0x1DBB69C", VA = "0x1DBB69C")]
	private Vector3 ApplyInputVelocityChange(Vector3 velocity)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1DBBCF4", Offset = "0x1DBBCF4", VA = "0x1DBBCF4")]
	private Vector3 ApplyGravityAndJumping(Vector3 velocity)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1DBCE00", Offset = "0x1DBCE00", VA = "0x1DBCE00", Slot = "7")]
	public virtual void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1DBC650", Offset = "0x1DBC650", VA = "0x1DBC650")]
	private IEnumerator SubtractNewPlatformVelocity()
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1DBC540", Offset = "0x1DBC540", VA = "0x1DBC540")]
	private bool MoveWithPlatform()
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1DBCAAC", Offset = "0x1DBCAAC", VA = "0x1DBCAAC")]
	private Vector3 GetDesiredHorizontalVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1DBCCA4", Offset = "0x1DBCCA4", VA = "0x1DBCCA4")]
	private Vector3 AdjustGroundVelocityToNormal(Vector3 hVelocity, Vector3 groundNormal)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1DBC630", Offset = "0x1DBC630", VA = "0x1DBC630")]
	private bool IsGroundedTest()
	{
		return default(bool);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1DBD220", Offset = "0x1DBD220", VA = "0x1DBD220", Slot = "8")]
	public virtual float GetMaxAcceleration(bool grounded)
	{
		return default(float);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1DBD250", Offset = "0x1DBD250", VA = "0x1DBD250", Slot = "9")]
	public virtual float CalculateJumpVerticalSpeed(float targetJumpHeight)
	{
		return default(float);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1DBD314", Offset = "0x1DBD314", VA = "0x1DBD314", Slot = "10")]
	public virtual bool IsJumping()
	{
		return default(bool);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1DBD334", Offset = "0x1DBD334", VA = "0x1DBD334", Slot = "11")]
	public virtual bool IsSliding()
	{
		return default(bool);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1DBD38C", Offset = "0x1DBD38C", VA = "0x1DBD38C", Slot = "12")]
	public virtual bool IsTouchingCeiling()
	{
		return default(bool);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1DBD3B4", Offset = "0x1DBD3B4", VA = "0x1DBD3B4", Slot = "13")]
	public virtual bool IsGrounded()
	{
		return default(bool);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1DBD3BC", Offset = "0x1DBD3BC", VA = "0x1DBD3BC", Slot = "14")]
	public virtual bool TooSteep()
	{
		return default(bool);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1DBD490", Offset = "0x1DBD490", VA = "0x1DBD490", Slot = "15")]
	public virtual Vector3 GetDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1DBD4A0", Offset = "0x1DBD4A0", VA = "0x1DBD4A0", Slot = "16")]
	public virtual void SetControllable(bool controllable)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1DBD4A8", Offset = "0x1DBD4A8", VA = "0x1DBD4A8", Slot = "17")]
	public virtual float MaxSpeedInDirection(Vector3 desiredMovementDirection)
	{
		return default(float);
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1DBD6A8", Offset = "0x1DBD6A8", VA = "0x1DBD6A8", Slot = "18")]
	public virtual void SetVelocity(Vector3 velocity)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1DBD7A0", Offset = "0x1DBD7A0", VA = "0x1DBD7A0", Slot = "19")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x452460", Offset = "0x452460")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x452460", Offset = "0x452460")]
public class FPSInputController : MonoBehaviour
{
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0xC")]
	private CharacterMotor motor;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1DBDC04", Offset = "0x1DBDC04", VA = "0x1DBDC04")]
	public FPSInputController()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1DBDC0C", Offset = "0x1DBDC0C", VA = "0x1DBDC0C", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1DBDD44", Offset = "0x1DBDD44", VA = "0x1DBDD44", Slot = "5")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1DBE0E0", Offset = "0x1DBE0E0", VA = "0x1DBE0E0", Slot = "6")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x200000C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x452500", Offset = "0x452500")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x452500", Offset = "0x452500")]
public class PlatformInputController : MonoBehaviour
{
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0xC")]
	public bool autoRotate;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x10")]
	public float maxRotationSpeed;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x14")]
	private CharacterMotor motor;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1DBE0E4", Offset = "0x1DBE0E4", VA = "0x1DBE0E4")]
	public PlatformInputController()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1DBE110", Offset = "0x1DBE110", VA = "0x1DBE110", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1DBE248", Offset = "0x1DBE248", VA = "0x1DBE248", Slot = "5")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1DBE92C", Offset = "0x1DBE92C", VA = "0x1DBE92C", Slot = "6")]
	public virtual Vector3 ProjectOntoPlane(Vector3 v, Vector3 normal)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1DBEA18", Offset = "0x1DBEA18", VA = "0x1DBEA18", Slot = "7")]
	public virtual Vector3 ConstantSlerp(Vector3 from, Vector3 to, float angle)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1DBEB5C", Offset = "0x1DBEB5C", VA = "0x1DBEB5C", Slot = "8")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x200000D")]
public class ThirdPersonCamera : MonoBehaviour
{
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0xC")]
	public Transform cameraTransform;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x10")]
	private Transform _target;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x14")]
	public float distance;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x18")]
	public float height;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x1C")]
	public float angularSmoothLag;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x20")]
	public float angularMaxSpeed;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x24")]
	public float heightSmoothLag;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x28")]
	public float snapSmoothLag;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x2C")]
	public float snapMaxSpeed;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x30")]
	public float clampHeadPositionScreenSpace;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x34")]
	public float lockCameraTimeout;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 headOffset;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 centerOffset;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x50")]
	private float heightVelocity;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x54")]
	private float angleVelocity;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x58")]
	private bool snap;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x5C")]
	private ThirdPersonController controller;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x60")]
	private float targetHeight;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1DBEBF0", Offset = "0x1DBEBF0", VA = "0x1DBEBF0")]
	public ThirdPersonCamera()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1DBED1C", Offset = "0x1DBED1C", VA = "0x1DBED1C", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1DBF2E0", Offset = "0x1DBF2E0", VA = "0x1DBF2E0", Slot = "5")]
	public virtual void DebugDrawStuff()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1DBF42C", Offset = "0x1DBF42C", VA = "0x1DBF42C", Slot = "6")]
	public virtual float AngleDistance(float a, float b)
	{
		return default(float);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1DBF4F4", Offset = "0x1DBF4F4", VA = "0x1DBF4F4", Slot = "7")]
	public virtual void Apply(Transform dummyTarget, Vector3 dummyCenter)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1DBFC00", Offset = "0x1DBFC00", VA = "0x1DBFC00", Slot = "8")]
	public virtual void LateUpdate()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1DBFCCC", Offset = "0x1DBFCCC", VA = "0x1DBFCCC", Slot = "9")]
	public virtual void Cut(Transform dummyTarget, Vector3 dummyCenter)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1DBFDD4", Offset = "0x1DBFDD4", VA = "0x1DBFDD4", Slot = "10")]
	public virtual void SetUpRotation(Vector3 centerPos, Vector3 headPos)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1DC0314", Offset = "0x1DC0314", VA = "0x1DC0314", Slot = "11")]
	public virtual Vector3 GetCenterOffset()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1DC0324", Offset = "0x1DC0324", VA = "0x1DC0324", Slot = "12")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x200000E")]
public enum CharacterState
{
	[Token(Token = "0x4000055")]
	Idle,
	[Token(Token = "0x4000056")]
	Walking,
	[Token(Token = "0x4000057")]
	Trotting,
	[Token(Token = "0x4000058")]
	Running,
	[Token(Token = "0x4000059")]
	Jumping
}
[Serializable]
[Token(Token = "0x200000F")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x4525A0", Offset = "0x4525A0")]
public class ThirdPersonController : MonoBehaviour
{
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0xC")]
	public AnimationClip idleAnimation;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x10")]
	public AnimationClip walkAnimation;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x14")]
	public AnimationClip runAnimation;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x18")]
	public AnimationClip jumpPoseAnimation;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x1C")]
	public float walkMaxAnimationSpeed;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x20")]
	public float trotMaxAnimationSpeed;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x24")]
	public float runMaxAnimationSpeed;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x28")]
	public float jumpAnimationSpeed;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x2C")]
	public float landAnimationSpeed;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x30")]
	private Animation _animation;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x34")]
	private CharacterState _characterState;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x38")]
	public float walkSpeed;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x3C")]
	public float trotSpeed;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x40")]
	public float runSpeed;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x44")]
	public float inAirControlAcceleration;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x48")]
	public float jumpHeight;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x4C")]
	public float gravity;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x50")]
	public float speedSmoothing;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x54")]
	public float rotateSpeed;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x58")]
	public float trotAfterSeconds;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x5C")]
	public bool canJump;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x60")]
	private float jumpRepeatTime;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x64")]
	private float jumpTimeout;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x68")]
	private float groundedTimeout;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x6C")]
	private float lockCameraTimer;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 moveDirection;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x7C")]
	private float verticalSpeed;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x80")]
	private float moveSpeed;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x84")]
	private CollisionFlags collisionFlags;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x88")]
	private bool jumping;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x89")]
	private bool jumpingReachedApex;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x8A")]
	private bool movingBack;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x8B")]
	private bool isMoving;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x8C")]
	private float walkTimeStart;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x90")]
	private float lastJumpButtonTime;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x94")]
	private float lastJumpTime;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x98")]
	private float lastJumpStartHeight;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x9C")]
	private Vector3 inAirVelocity;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0xA8")]
	private float lastGroundedTime;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0xAC")]
	private bool isControllable;

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1DC0328", Offset = "0x1DC0328", VA = "0x1DC0328")]
	public ThirdPersonController()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1DC04B4", Offset = "0x1DC04B4", VA = "0x1DC04B4", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1DC0950", Offset = "0x1DC0950", VA = "0x1DC0950", Slot = "5")]
	public virtual void UpdateSmoothedMovementDirection()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1DC1174", Offset = "0x1DC1174", VA = "0x1DC1174", Slot = "6")]
	public virtual void ApplyJumping()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1DC1284", Offset = "0x1DC1284", VA = "0x1DC1284", Slot = "7")]
	public virtual void ApplyGravity()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1DC13C4", Offset = "0x1DC13C4", VA = "0x1DC13C4", Slot = "8")]
	public virtual float CalculateJumpVerticalSpeed(float targetJumpHeight)
	{
		return default(float);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1DC1478", Offset = "0x1DC1478", VA = "0x1DC1478", Slot = "9")]
	public virtual void DidJump()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1DC14F0", Offset = "0x1DC14F0", VA = "0x1DC14F0", Slot = "10")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1DC1F14", Offset = "0x1DC1F14", VA = "0x1DC1F14", Slot = "11")]
	public virtual void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1DC1F48", Offset = "0x1DC1F48", VA = "0x1DC1F48", Slot = "12")]
	public virtual float GetSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1DC1F50", Offset = "0x1DC1F50", VA = "0x1DC1F50", Slot = "13")]
	public virtual bool IsJumping()
	{
		return default(bool);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1DC1F58", Offset = "0x1DC1F58", VA = "0x1DC1F58", Slot = "14")]
	public virtual bool IsGrounded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1DC1F68", Offset = "0x1DC1F68", VA = "0x1DC1F68", Slot = "15")]
	public virtual Vector3 GetDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1DC1F78", Offset = "0x1DC1F78", VA = "0x1DC1F78", Slot = "16")]
	public virtual bool IsMovingBackwards()
	{
		return default(bool);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1DC1F80", Offset = "0x1DC1F80", VA = "0x1DC1F80", Slot = "17")]
	public virtual float GetLockCameraTimer()
	{
		return default(float);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1DC1F88", Offset = "0x1DC1F88", VA = "0x1DC1F88", Slot = "18")]
	public virtual bool IsMoving()
	{
		return default(bool);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1DC209C", Offset = "0x1DC209C", VA = "0x1DC209C", Slot = "19")]
	public virtual bool HasJumpReachedApex()
	{
		return default(bool);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1DC20A4", Offset = "0x1DC20A4", VA = "0x1DC20A4", Slot = "20")]
	public virtual bool IsGroundedWithTimeout()
	{
		return default(bool);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1DC20E8", Offset = "0x1DC20E8", VA = "0x1DC20E8", Slot = "21")]
	public virtual void Reset()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1DC216C", Offset = "0x1DC216C", VA = "0x1DC216C", Slot = "22")]
	public virtual void Main()
	{
	}
}
