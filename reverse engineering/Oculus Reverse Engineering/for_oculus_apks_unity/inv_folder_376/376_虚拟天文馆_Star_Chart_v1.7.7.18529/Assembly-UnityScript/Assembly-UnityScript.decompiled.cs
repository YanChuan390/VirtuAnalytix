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
	[Address(RVA = "0xB091D0", Offset = "0xB091D0", VA = "0xB091D0")]
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
	[Address(RVA = "0xB09458", Offset = "0xB09458", VA = "0xB09458")]
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
	[Address(RVA = "0xB09530", Offset = "0xB09530", VA = "0xB09530")]
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
	[Address(RVA = "0xB09558", Offset = "0xB09558", VA = "0xB09558")]
	public CharacterMotorSliding()
	{
	}
}
[Serializable]
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC331F0", Offset = "0xC331F0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC331F0", Offset = "0xC331F0")]
public class CharacterMotor : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC33290", Offset = "0xC33290")]
	internal sealed class $SubtractNewPlatformVelocity$3 : GenericGenerator<object>
	{
		[Serializable]
		[Token(Token = "0x2000009")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC332A0", Offset = "0xC332A0")]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			[Token(Token = "0x400003A")]
			[FieldOffset(Offset = "0x10")]
			internal Transform $platform$4;

			[Token(Token = "0x400003B")]
			[FieldOffset(Offset = "0x14")]
			internal CharacterMotor $self_$5;

			[Token(Token = "0x6000020")]
			[Address(RVA = "0xB0CA70", Offset = "0xB0CA70", VA = "0xB0CA70")]
			public $(CharacterMotor self_)
			{
			}

			[Token(Token = "0x6000021")]
			[Address(RVA = "0xB0CADC", Offset = "0xB0CADC", VA = "0xB0CADC", Slot = "10")]
			public override bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x8")]
		internal CharacterMotor $self_$6;

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xB0C40C", Offset = "0xB0C40C", VA = "0xB0C40C")]
		public $SubtractNewPlatformVelocity$3(CharacterMotor self_)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xB0C478", Offset = "0xB0C478", VA = "0xB0C478", Slot = "6")]
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
	[Address(RVA = "0xB09024", Offset = "0xB09024", VA = "0xB09024")]
	public CharacterMotor()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xB09594", Offset = "0xB09594", VA = "0xB09594", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xB096C0", Offset = "0xB096C0", VA = "0xB096C0")]
	private void UpdateFunction()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xB0B99C", Offset = "0xB0B99C", VA = "0xB0B99C", Slot = "5")]
	public virtual void FixedUpdate()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xB0BD68", Offset = "0xB0BD68", VA = "0xB0BD68", Slot = "6")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xB0A968", Offset = "0xB0A968", VA = "0xB0A968")]
	private Vector3 ApplyInputVelocityChange(Vector3 velocity)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xB0AFC0", Offset = "0xB0AFC0", VA = "0xB0AFC0")]
	private Vector3 ApplyGravityAndJumping(Vector3 velocity)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xB0C0CC", Offset = "0xB0C0CC", VA = "0xB0C0CC", Slot = "7")]
	public virtual void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xB0B91C", Offset = "0xB0B91C", VA = "0xB0B91C")]
	private IEnumerator SubtractNewPlatformVelocity()
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xB0B80C", Offset = "0xB0B80C", VA = "0xB0B80C")]
	private bool MoveWithPlatform()
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xB0BD78", Offset = "0xB0BD78", VA = "0xB0BD78")]
	private Vector3 GetDesiredHorizontalVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xB0BF70", Offset = "0xB0BF70", VA = "0xB0BF70")]
	private Vector3 AdjustGroundVelocityToNormal(Vector3 hVelocity, Vector3 groundNormal)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xB0B8FC", Offset = "0xB0B8FC", VA = "0xB0B8FC")]
	private bool IsGroundedTest()
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xB0C4EC", Offset = "0xB0C4EC", VA = "0xB0C4EC", Slot = "8")]
	public virtual float GetMaxAcceleration(bool grounded)
	{
		return default(float);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xB0C51C", Offset = "0xB0C51C", VA = "0xB0C51C", Slot = "9")]
	public virtual float CalculateJumpVerticalSpeed(float targetJumpHeight)
	{
		return default(float);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xB0C5E0", Offset = "0xB0C5E0", VA = "0xB0C5E0", Slot = "10")]
	public virtual bool IsJumping()
	{
		return default(bool);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xB0C600", Offset = "0xB0C600", VA = "0xB0C600", Slot = "11")]
	public virtual bool IsSliding()
	{
		return default(bool);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xB0C658", Offset = "0xB0C658", VA = "0xB0C658", Slot = "12")]
	public virtual bool IsTouchingCeiling()
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xB0C680", Offset = "0xB0C680", VA = "0xB0C680", Slot = "13")]
	public virtual bool IsGrounded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xB0C688", Offset = "0xB0C688", VA = "0xB0C688", Slot = "14")]
	public virtual bool TooSteep()
	{
		return default(bool);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xB0C75C", Offset = "0xB0C75C", VA = "0xB0C75C", Slot = "15")]
	public virtual Vector3 GetDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xB0C76C", Offset = "0xB0C76C", VA = "0xB0C76C", Slot = "16")]
	public virtual void SetControllable(bool controllable)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xB0C774", Offset = "0xB0C774", VA = "0xB0C774", Slot = "17")]
	public virtual float MaxSpeedInDirection(Vector3 desiredMovementDirection)
	{
		return default(float);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xB0C974", Offset = "0xB0C974", VA = "0xB0C974", Slot = "18")]
	public virtual void SetVelocity(Vector3 velocity)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xB0CA6C", Offset = "0xB0CA6C", VA = "0xB0CA6C", Slot = "19")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC332B0", Offset = "0xC332B0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC332B0", Offset = "0xC332B0")]
public class FPSInputController : MonoBehaviour
{
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0xC")]
	private CharacterMotor motor;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xB0CED0", Offset = "0xB0CED0", VA = "0xB0CED0")]
	public FPSInputController()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xB0CED8", Offset = "0xB0CED8", VA = "0xB0CED8", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xB0D010", Offset = "0xB0D010", VA = "0xB0D010", Slot = "5")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xB0D3AC", Offset = "0xB0D3AC", VA = "0xB0D3AC", Slot = "6")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC33350", Offset = "0xC33350")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC33350", Offset = "0xC33350")]
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
	[Address(RVA = "0xB0D3B0", Offset = "0xB0D3B0", VA = "0xB0D3B0")]
	public PlatformInputController()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xB0D3DC", Offset = "0xB0D3DC", VA = "0xB0D3DC", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xB0D514", Offset = "0xB0D514", VA = "0xB0D514", Slot = "5")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xB0DBF8", Offset = "0xB0DBF8", VA = "0xB0DBF8", Slot = "6")]
	public virtual Vector3 ProjectOntoPlane(Vector3 v, Vector3 normal)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xB0DCE4", Offset = "0xB0DCE4", VA = "0xB0DCE4", Slot = "7")]
	public virtual Vector3 ConstantSlerp(Vector3 from, Vector3 to, float angle)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xB0DE28", Offset = "0xB0DE28", VA = "0xB0DE28", Slot = "8")]
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
	[Address(RVA = "0xB0DE2C", Offset = "0xB0DE2C", VA = "0xB0DE2C")]
	public ThirdPersonCamera()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xB0DF58", Offset = "0xB0DF58", VA = "0xB0DF58", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xB0E51C", Offset = "0xB0E51C", VA = "0xB0E51C", Slot = "5")]
	public virtual void DebugDrawStuff()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xB0E668", Offset = "0xB0E668", VA = "0xB0E668", Slot = "6")]
	public virtual float AngleDistance(float a, float b)
	{
		return default(float);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xB0E730", Offset = "0xB0E730", VA = "0xB0E730", Slot = "7")]
	public virtual void Apply(Transform dummyTarget, Vector3 dummyCenter)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xB0EE3C", Offset = "0xB0EE3C", VA = "0xB0EE3C", Slot = "8")]
	public virtual void LateUpdate()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xB0EF08", Offset = "0xB0EF08", VA = "0xB0EF08", Slot = "9")]
	public virtual void Cut(Transform dummyTarget, Vector3 dummyCenter)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xB0F010", Offset = "0xB0F010", VA = "0xB0F010", Slot = "10")]
	public virtual void SetUpRotation(Vector3 centerPos, Vector3 headPos)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xB0F550", Offset = "0xB0F550", VA = "0xB0F550", Slot = "11")]
	public virtual Vector3 GetCenterOffset()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xB0F560", Offset = "0xB0F560", VA = "0xB0F560", Slot = "12")]
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
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC333F0", Offset = "0xC333F0")]
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
	[Address(RVA = "0xB0F564", Offset = "0xB0F564", VA = "0xB0F564")]
	public ThirdPersonController()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xB0F6F0", Offset = "0xB0F6F0", VA = "0xB0F6F0", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xB0FB8C", Offset = "0xB0FB8C", VA = "0xB0FB8C", Slot = "5")]
	public virtual void UpdateSmoothedMovementDirection()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xB103B0", Offset = "0xB103B0", VA = "0xB103B0", Slot = "6")]
	public virtual void ApplyJumping()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xB104C0", Offset = "0xB104C0", VA = "0xB104C0", Slot = "7")]
	public virtual void ApplyGravity()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xB10600", Offset = "0xB10600", VA = "0xB10600", Slot = "8")]
	public virtual float CalculateJumpVerticalSpeed(float targetJumpHeight)
	{
		return default(float);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xB106B4", Offset = "0xB106B4", VA = "0xB106B4", Slot = "9")]
	public virtual void DidJump()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xB1072C", Offset = "0xB1072C", VA = "0xB1072C", Slot = "10")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xB11150", Offset = "0xB11150", VA = "0xB11150", Slot = "11")]
	public virtual void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xB11184", Offset = "0xB11184", VA = "0xB11184", Slot = "12")]
	public virtual float GetSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xB1118C", Offset = "0xB1118C", VA = "0xB1118C", Slot = "13")]
	public virtual bool IsJumping()
	{
		return default(bool);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xB11194", Offset = "0xB11194", VA = "0xB11194", Slot = "14")]
	public virtual bool IsGrounded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xB111A4", Offset = "0xB111A4", VA = "0xB111A4", Slot = "15")]
	public virtual Vector3 GetDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xB111B4", Offset = "0xB111B4", VA = "0xB111B4", Slot = "16")]
	public virtual bool IsMovingBackwards()
	{
		return default(bool);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xB111BC", Offset = "0xB111BC", VA = "0xB111BC", Slot = "17")]
	public virtual float GetLockCameraTimer()
	{
		return default(float);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xB111C4", Offset = "0xB111C4", VA = "0xB111C4", Slot = "18")]
	public virtual bool IsMoving()
	{
		return default(bool);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xB112D8", Offset = "0xB112D8", VA = "0xB112D8", Slot = "19")]
	public virtual bool HasJumpReachedApex()
	{
		return default(bool);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xB112E0", Offset = "0xB112E0", VA = "0xB112E0", Slot = "20")]
	public virtual bool IsGroundedWithTimeout()
	{
		return default(bool);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xB11324", Offset = "0xB11324", VA = "0xB11324", Slot = "21")]
	public virtual void Reset()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xB113A8", Offset = "0xB113A8", VA = "0xB113A8", Slot = "22")]
	public virtual void Main()
	{
	}
}
