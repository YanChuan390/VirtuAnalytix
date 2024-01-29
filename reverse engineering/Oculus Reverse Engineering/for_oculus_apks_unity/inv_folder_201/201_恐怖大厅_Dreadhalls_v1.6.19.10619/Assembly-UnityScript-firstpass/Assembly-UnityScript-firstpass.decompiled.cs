using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using UnityEngine;
using UnityScript.Lang;

[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations)]
[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
public class CharacterMotorMovement
{
	public float maxForwardSpeed;

	public float maxSidewaysSpeed;

	public float maxBackwardsSpeed;

	public AnimationCurve slopeSpeedMultiplier;

	public float maxGroundAcceleration;

	public float maxAirAcceleration;

	public float gravity;

	public float maxFallSpeed;

	[NonSerialized]
	public CollisionFlags collisionFlags;

	[NonSerialized]
	public Vector3 velocity;

	[NonSerialized]
	public Vector3 frameVelocity;

	[NonSerialized]
	public Vector3 hitPoint;

	[NonSerialized]
	public Vector3 lastHitPoint;

	public CharacterMotorMovement()
	{
		maxForwardSpeed = 10f;
		maxSidewaysSpeed = 10f;
		maxBackwardsSpeed = 10f;
		slopeSpeedMultiplier = new AnimationCurve(new Keyframe(-90f, 1f), new Keyframe(0f, 1f), new Keyframe(90f, 0f));
		maxGroundAcceleration = 30f;
		maxAirAcceleration = 20f;
		gravity = 10f;
		maxFallSpeed = 20f;
		frameVelocity = Vector3.zero;
		hitPoint = Vector3.zero;
		lastHitPoint = new Vector3(float.PositiveInfinity, 0f, 0f);
	}
}
[Serializable]
public enum MovementTransferOnJump
{
	None,
	InitTransfer,
	PermaTransfer,
	PermaLocked
}
[Serializable]
public class CharacterMotorJumping
{
	public bool enabled;

	public float baseHeight;

	public float extraHeight;

	public float perpAmount;

	public float steepPerpAmount;

	[NonSerialized]
	public bool jumping;

	[NonSerialized]
	public bool holdingJumpButton;

	[NonSerialized]
	public float lastStartTime;

	[NonSerialized]
	public float lastButtonDownTime;

	[NonSerialized]
	public Vector3 jumpDir;

	public CharacterMotorJumping()
	{
		enabled = true;
		baseHeight = 1f;
		extraHeight = 4.1f;
		steepPerpAmount = 0.5f;
		lastButtonDownTime = -100f;
		jumpDir = Vector3.up;
	}
}
[Serializable]
public class CharacterMotorMovingPlatform
{
	public bool enabled;

	public MovementTransferOnJump movementTransfer;

	[NonSerialized]
	public Transform hitPlatform;

	[NonSerialized]
	public Transform activePlatform;

	[NonSerialized]
	public Vector3 activeLocalPoint;

	[NonSerialized]
	public Vector3 activeGlobalPoint;

	[NonSerialized]
	public Quaternion activeLocalRotation;

	[NonSerialized]
	public Quaternion activeGlobalRotation;

	[NonSerialized]
	public Matrix4x4 lastMatrix;

	[NonSerialized]
	public Vector3 platformVelocity;

	[NonSerialized]
	public bool newPlatform;

	public CharacterMotorMovingPlatform()
	{
		enabled = true;
		movementTransfer = MovementTransferOnJump.PermaTransfer;
	}
}
[Serializable]
public class CharacterMotorSliding
{
	public bool enabled;

	public float slidingSpeed;

	public float sidewaysControl;

	public float speedControl;

	public CharacterMotorSliding()
	{
		enabled = true;
		slidingSpeed = 15f;
		sidewaysControl = 1f;
		speedControl = 0.4f;
	}
}
[Serializable]
[AddComponentMenu("Character/Character Motor")]
[RequireComponent(typeof(CharacterController))]
public class CharacterMotor : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class $SubtractNewPlatformVelocity$60 : GenericGenerator<object>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			internal Transform $platform$61;

			internal CharacterMotor $self_$62;

			public $(CharacterMotor self_)
			{
				$self_$62 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if ($self_$62.movingPlatform.enabled && ($self_$62.movingPlatform.movementTransfer == MovementTransferOnJump.InitTransfer || $self_$62.movingPlatform.movementTransfer == MovementTransferOnJump.PermaTransfer))
					{
						if ($self_$62.movingPlatform.newPlatform)
						{
							$platform$61 = $self_$62.movingPlatform.activePlatform;
							result = (Yield(2, new WaitForFixedUpdate()) ? 1 : 0);
							break;
						}
						goto case 4;
					}
					goto IL_0124;
				case 2:
					result = (Yield(3, new WaitForFixedUpdate()) ? 1 : 0);
					break;
				case 3:
					if ($self_$62.grounded && $platform$61 == $self_$62.movingPlatform.activePlatform)
					{
						result = (Yield(4, 1) ? 1 : 0);
						break;
					}
					goto case 4;
				case 4:
					$self_$62.movement.velocity = $self_$62.movement.velocity - $self_$62.movingPlatform.platformVelocity;
					goto IL_0124;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0124:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal CharacterMotor $self_$63;

		public $SubtractNewPlatformVelocity$60(CharacterMotor self_)
		{
			$self_$63 = self_;
		}

		public override IEnumerator<object> GetEnumerator()
		{
			return new $($self_$63);
		}
	}

	public bool canControl;

	public bool useFixedUpdate;

	[NonSerialized]
	public Vector3 inputMoveDirection;

	[NonSerialized]
	public bool inputJump;

	public CharacterMotorMovement movement;

	public CharacterMotorJumping jumping;

	public CharacterMotorMovingPlatform movingPlatform;

	public CharacterMotorSliding sliding;

	[NonSerialized]
	public bool grounded;

	[NonSerialized]
	public Vector3 groundNormal;

	private Vector3 lastGroundNormal;

	private Transform tr;

	private CharacterController controller;

	public CharacterMotor()
	{
		canControl = true;
		useFixedUpdate = true;
		inputMoveDirection = Vector3.zero;
		movement = new CharacterMotorMovement();
		jumping = new CharacterMotorJumping();
		movingPlatform = new CharacterMotorMovingPlatform();
		sliding = new CharacterMotorSliding();
		grounded = true;
		groundNormal = Vector3.zero;
		lastGroundNormal = Vector3.zero;
	}

	public virtual void Awake()
	{
		controller = (CharacterController)GetComponent(typeof(CharacterController));
		tr = transform;
	}

	private void UpdateFunction()
	{
		Vector3 velocity = movement.velocity;
		velocity = ApplyInputVelocityChange(velocity);
		velocity = ApplyGravityAndJumping(velocity);
		Vector3 zero = Vector3.zero;
		if (MoveWithPlatform())
		{
			Vector3 vector = movingPlatform.activePlatform.TransformPoint(movingPlatform.activeLocalPoint);
			zero = vector - movingPlatform.activeGlobalPoint;
			if (zero != Vector3.zero)
			{
				controller.Move(zero);
			}
			Quaternion quaternion = movingPlatform.activePlatform.rotation * movingPlatform.activeLocalRotation;
			float y = (quaternion * Quaternion.Inverse(movingPlatform.activeGlobalRotation)).eulerAngles.y;
			if (y != 0f)
			{
				tr.Rotate(0f, y, 0f);
			}
		}
		Vector3 position = tr.position;
		Vector3 motion = velocity * Time.deltaTime;
		float num = Mathf.Max(controller.stepOffset, new Vector3(motion.x, 0f, motion.z).magnitude);
		if (grounded)
		{
			motion -= num * Vector3.up;
		}
		movingPlatform.hitPlatform = null;
		groundNormal = Vector3.zero;
		movement.collisionFlags = controller.Move(motion);
		movement.lastHitPoint = movement.hitPoint;
		lastGroundNormal = groundNormal;
		if (movingPlatform.enabled && movingPlatform.activePlatform != movingPlatform.hitPlatform && movingPlatform.hitPlatform != null)
		{
			movingPlatform.activePlatform = movingPlatform.hitPlatform;
			movingPlatform.lastMatrix = movingPlatform.hitPlatform.localToWorldMatrix;
			movingPlatform.newPlatform = true;
		}
		Vector3 vector2 = new Vector3(velocity.x, 0f, velocity.z);
		movement.velocity = (tr.position - position) / Time.deltaTime;
		Vector3 lhs = new Vector3(movement.velocity.x, 0f, movement.velocity.z);
		if (vector2 == Vector3.zero)
		{
			movement.velocity = new Vector3(0f, movement.velocity.y, 0f);
		}
		else
		{
			float value = Vector3.Dot(lhs, vector2) / vector2.sqrMagnitude;
			movement.velocity = vector2 * Mathf.Clamp01(value) + movement.velocity.y * Vector3.up;
		}
		if (!(movement.velocity.y >= velocity.y - 0.001f))
		{
			if (!(movement.velocity.y >= 0f))
			{
				movement.velocity.y = velocity.y;
			}
			else
			{
				jumping.holdingJumpButton = false;
			}
		}
		if (grounded && !IsGroundedTest())
		{
			grounded = false;
			if (movingPlatform.enabled && (movingPlatform.movementTransfer == MovementTransferOnJump.InitTransfer || movingPlatform.movementTransfer == MovementTransferOnJump.PermaTransfer))
			{
				movement.frameVelocity = movingPlatform.platformVelocity;
				movement.velocity += movingPlatform.platformVelocity;
			}
			SendMessage("OnFall", SendMessageOptions.DontRequireReceiver);
			tr.position += num * Vector3.up;
		}
		else if (!grounded && IsGroundedTest())
		{
			grounded = true;
			jumping.jumping = false;
			StartCoroutine(SubtractNewPlatformVelocity());
			SendMessage("OnLand", SendMessageOptions.DontRequireReceiver);
		}
		if (MoveWithPlatform())
		{
			movingPlatform.activeGlobalPoint = tr.position + Vector3.up * (controller.center.y - controller.height * 0.5f + controller.radius);
			movingPlatform.activeLocalPoint = movingPlatform.activePlatform.InverseTransformPoint(movingPlatform.activeGlobalPoint);
			movingPlatform.activeGlobalRotation = tr.rotation;
			movingPlatform.activeLocalRotation = Quaternion.Inverse(movingPlatform.activePlatform.rotation) * movingPlatform.activeGlobalRotation;
		}
	}

	public virtual void FixedUpdate()
	{
		if (movingPlatform.enabled)
		{
			if (movingPlatform.activePlatform != null)
			{
				if (!movingPlatform.newPlatform)
				{
					Vector3 platformVelocity = movingPlatform.platformVelocity;
					movingPlatform.platformVelocity = (movingPlatform.activePlatform.localToWorldMatrix.MultiplyPoint3x4(movingPlatform.activeLocalPoint) - movingPlatform.lastMatrix.MultiplyPoint3x4(movingPlatform.activeLocalPoint)) / Time.deltaTime;
				}
				movingPlatform.lastMatrix = movingPlatform.activePlatform.localToWorldMatrix;
				movingPlatform.newPlatform = false;
			}
			else
			{
				movingPlatform.platformVelocity = Vector3.zero;
			}
		}
		if (useFixedUpdate)
		{
			UpdateFunction();
		}
	}

	public virtual void Update()
	{
		if (!useFixedUpdate)
		{
			UpdateFunction();
		}
	}

	private Vector3 ApplyInputVelocityChange(Vector3 velocity)
	{
		if (!canControl)
		{
			inputMoveDirection = Vector3.zero;
		}
		Vector3 vector = default(Vector3);
		if (grounded && TooSteep())
		{
			vector = new Vector3(groundNormal.x, 0f, groundNormal.z).normalized;
			Vector3 vector2 = Vector3.Project(inputMoveDirection, vector);
			vector = vector + vector2 * sliding.speedControl + (inputMoveDirection - vector2) * sliding.sidewaysControl;
			vector *= sliding.slidingSpeed;
		}
		else
		{
			vector = GetDesiredHorizontalVelocity();
		}
		if (movingPlatform.enabled && movingPlatform.movementTransfer == MovementTransferOnJump.PermaTransfer)
		{
			vector += movement.frameVelocity;
			vector.y = 0f;
		}
		if (grounded)
		{
			vector = AdjustGroundVelocityToNormal(vector, groundNormal);
		}
		else
		{
			velocity.y = 0f;
		}
		float num = GetMaxAcceleration(grounded) * Time.deltaTime;
		Vector3 vector3 = vector - velocity;
		if (!(vector3.sqrMagnitude <= num * num))
		{
			vector3 = vector3.normalized * num;
		}
		if (grounded || canControl)
		{
			velocity += vector3;
		}
		if (grounded)
		{
			velocity.y = Mathf.Min(velocity.y, 0f);
		}
		return velocity;
	}

	private Vector3 ApplyGravityAndJumping(Vector3 velocity)
	{
		if (!inputJump || !canControl)
		{
			jumping.holdingJumpButton = false;
			jumping.lastButtonDownTime = -100f;
		}
		if (inputJump && !(jumping.lastButtonDownTime >= 0f) && canControl)
		{
			jumping.lastButtonDownTime = Time.time;
		}
		if (grounded)
		{
			velocity.y = Mathf.Min(0f, velocity.y) - movement.gravity * Time.deltaTime;
		}
		else
		{
			velocity.y = movement.velocity.y - movement.gravity * Time.deltaTime;
			if (jumping.jumping && jumping.holdingJumpButton && !(Time.time >= jumping.lastStartTime + jumping.extraHeight / CalculateJumpVerticalSpeed(jumping.baseHeight)))
			{
				velocity += jumping.jumpDir * movement.gravity * Time.deltaTime;
			}
			velocity.y = Mathf.Max(velocity.y, 0f - movement.maxFallSpeed);
		}
		if (grounded)
		{
			if (jumping.enabled && canControl && !(Time.time - jumping.lastButtonDownTime >= 0.2f))
			{
				grounded = false;
				jumping.jumping = true;
				jumping.lastStartTime = Time.time;
				jumping.lastButtonDownTime = -100f;
				jumping.holdingJumpButton = true;
				if (TooSteep())
				{
					jumping.jumpDir = Vector3.Slerp(Vector3.up, groundNormal, jumping.steepPerpAmount);
				}
				else
				{
					jumping.jumpDir = Vector3.Slerp(Vector3.up, groundNormal, jumping.perpAmount);
				}
				velocity.y = 0f;
				velocity += jumping.jumpDir * CalculateJumpVerticalSpeed(jumping.baseHeight);
				if (movingPlatform.enabled && (movingPlatform.movementTransfer == MovementTransferOnJump.InitTransfer || movingPlatform.movementTransfer == MovementTransferOnJump.PermaTransfer))
				{
					movement.frameVelocity = movingPlatform.platformVelocity;
					velocity += movingPlatform.platformVelocity;
				}
				SendMessage("OnJump", SendMessageOptions.DontRequireReceiver);
			}
			else
			{
				jumping.holdingJumpButton = false;
			}
		}
		return velocity;
	}

	public virtual void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if (!(hit.normal.y <= 0f) && !(hit.normal.y <= groundNormal.y) && !(hit.moveDirection.y >= 0f))
		{
			if ((hit.point - movement.lastHitPoint).sqrMagnitude > 0.001f || lastGroundNormal == Vector3.zero)
			{
				groundNormal = hit.normal;
			}
			else
			{
				groundNormal = lastGroundNormal;
			}
			movingPlatform.hitPlatform = hit.collider.transform;
			movement.hitPoint = hit.point;
			movement.frameVelocity = Vector3.zero;
		}
	}

	private IEnumerator SubtractNewPlatformVelocity()
	{
		return new $SubtractNewPlatformVelocity$60(this).GetEnumerator();
	}

	private bool MoveWithPlatform()
	{
		bool num = movingPlatform.enabled;
		if (num)
		{
			num = grounded;
			if (!num)
			{
				num = movingPlatform.movementTransfer == MovementTransferOnJump.PermaLocked;
			}
		}
		if (num)
		{
			num = movingPlatform.activePlatform != null;
		}
		return num;
	}

	private Vector3 GetDesiredHorizontalVelocity()
	{
		Vector3 vector = tr.InverseTransformDirection(inputMoveDirection);
		float num = MaxSpeedInDirection(vector);
		if (grounded)
		{
			float time = Mathf.Asin(movement.velocity.normalized.y) * 57.29578f;
			num *= movement.slopeSpeedMultiplier.Evaluate(time);
		}
		return tr.TransformDirection(vector * num);
	}

	private Vector3 AdjustGroundVelocityToNormal(Vector3 hVelocity, Vector3 groundNormal)
	{
		Vector3 lhs = Vector3.Cross(Vector3.up, hVelocity);
		return Vector3.Cross(lhs, groundNormal).normalized * hVelocity.magnitude;
	}

	private bool IsGroundedTest()
	{
		return groundNormal.y > 0.01f;
	}

	public virtual float GetMaxAcceleration(bool grounded)
	{
		return (!grounded) ? movement.maxAirAcceleration : movement.maxGroundAcceleration;
	}

	public virtual float CalculateJumpVerticalSpeed(float targetJumpHeight)
	{
		return Mathf.Sqrt(2f * targetJumpHeight * movement.gravity);
	}

	public virtual bool IsJumping()
	{
		return jumping.jumping;
	}

	public virtual bool IsSliding()
	{
		bool num = grounded;
		if (num)
		{
			num = sliding.enabled;
		}
		if (num)
		{
			num = TooSteep();
		}
		return num;
	}

	public virtual bool IsTouchingCeiling()
	{
		return (movement.collisionFlags & CollisionFlags.Above) != 0;
	}

	public virtual bool IsGrounded()
	{
		return grounded;
	}

	public virtual bool TooSteep()
	{
		return !(groundNormal.y > Mathf.Cos(controller.slopeLimit * ((float)Math.PI / 180f)));
	}

	public virtual Vector3 GetDirection()
	{
		return inputMoveDirection;
	}

	public virtual void SetControllable(bool controllable)
	{
		canControl = controllable;
	}

	public virtual float MaxSpeedInDirection(Vector3 desiredMovementDirection)
	{
		float result;
		if (desiredMovementDirection == Vector3.zero)
		{
			result = 0f;
		}
		else
		{
			float num = ((desiredMovementDirection.z <= 0f) ? movement.maxBackwardsSpeed : movement.maxForwardSpeed) / movement.maxSidewaysSpeed;
			Vector3 normalized = new Vector3(desiredMovementDirection.x, 0f, desiredMovementDirection.z / num).normalized;
			float num2 = new Vector3(normalized.x, 0f, normalized.z * num).magnitude * movement.maxSidewaysSpeed;
			result = num2;
		}
		return result;
	}

	public virtual void SetVelocity(Vector3 velocity)
	{
		grounded = false;
		movement.velocity = velocity;
		movement.frameVelocity = Vector3.zero;
		SendMessage("OnExternalVelocity");
	}

	public virtual void Main()
	{
	}
}
[Serializable]
[AddComponentMenu("Character/FPS Input Controller")]
[RequireComponent(typeof(CharacterMotor))]
public class FPSInputController : MonoBehaviour
{
	private CharacterMotor motor;

	public virtual void Awake()
	{
		motor = (CharacterMotor)GetComponent(typeof(CharacterMotor));
	}

	public virtual void Update()
	{
		Vector3 vector = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(1f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		motor.inputMoveDirection = transform.rotation * vector;
		motor.inputJump = Input.GetButton("Jump");
	}

	public virtual void Main()
	{
	}
}
[Serializable]
[AddComponentMenu("Character/Platform Input Controller")]
[RequireComponent(typeof(CharacterMotor))]
public class PlatformInputController : MonoBehaviour
{
	public bool autoRotate;

	public float maxRotationSpeed;

	private CharacterMotor motor;

	public PlatformInputController()
	{
		autoRotate = true;
		maxRotationSpeed = 360f;
	}

	public virtual void Awake()
	{
		motor = (CharacterMotor)GetComponent(typeof(CharacterMotor));
	}

	public virtual void Update()
	{
		Vector3 vector = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(1f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		vector = Camera.main.transform.rotation * vector;
		Quaternion quaternion = Quaternion.FromToRotation(-Camera.main.transform.forward, transform.up);
		vector = quaternion * vector;
		motor.inputMoveDirection = vector;
		motor.inputJump = Input.GetButton("Jump");
		if (autoRotate && !(vector.sqrMagnitude <= 0.01f))
		{
			Vector3 v = ConstantSlerp(transform.forward, vector, maxRotationSpeed * Time.deltaTime);
			v = ProjectOntoPlane(v, transform.up);
			transform.rotation = Quaternion.LookRotation(v, transform.up);
		}
	}

	public virtual Vector3 ProjectOntoPlane(Vector3 v, Vector3 normal)
	{
		return v - Vector3.Project(v, normal);
	}

	public virtual Vector3 ConstantSlerp(Vector3 from, Vector3 to, float angle)
	{
		float t = Mathf.Min(1f, angle / Vector3.Angle(from, to));
		return Vector3.Slerp(from, to, t);
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public class ThirdPersonCamera : MonoBehaviour
{
	public Transform cameraTransform;

	private Transform _target;

	public float distance;

	public float height;

	public float angularSmoothLag;

	public float angularMaxSpeed;

	public float heightSmoothLag;

	public float snapSmoothLag;

	public float snapMaxSpeed;

	public float clampHeadPositionScreenSpace;

	public float lockCameraTimeout;

	private Vector3 headOffset;

	private Vector3 centerOffset;

	private float heightVelocity;

	private float angleVelocity;

	private bool snap;

	private ThirdPersonController controller;

	private float targetHeight;

	public ThirdPersonCamera()
	{
		distance = 7f;
		height = 3f;
		angularSmoothLag = 0.3f;
		angularMaxSpeed = 15f;
		heightSmoothLag = 0.3f;
		snapSmoothLag = 0.2f;
		snapMaxSpeed = 720f;
		clampHeadPositionScreenSpace = 0.75f;
		lockCameraTimeout = 0.2f;
		headOffset = Vector3.zero;
		centerOffset = Vector3.zero;
		targetHeight = 100000f;
	}

	public virtual void Awake()
	{
		if (!cameraTransform && (bool)Camera.main)
		{
			cameraTransform = Camera.main.transform;
		}
		if (!cameraTransform)
		{
			Debug.Log("Please assign a camera to the ThirdPersonCamera script.");
			enabled = false;
		}
		_target = transform;
		if ((bool)_target)
		{
			controller = (ThirdPersonController)_target.GetComponent(typeof(ThirdPersonController));
		}
		if ((bool)controller)
		{
			CharacterController characterController = (CharacterController)_target.GetComponent<Collider>();
			centerOffset = characterController.bounds.center - _target.position;
			headOffset = centerOffset;
			headOffset.y = characterController.bounds.max.y - _target.position.y;
		}
		else
		{
			Debug.Log("Please assign a target to the camera that has a ThirdPersonController script attached.");
		}
		Cut(_target, centerOffset);
	}

	public virtual void DebugDrawStuff()
	{
		Debug.DrawLine(_target.position, _target.position + headOffset);
	}

	public virtual float AngleDistance(float a, float b)
	{
		a = Mathf.Repeat(a, 360f);
		b = Mathf.Repeat(b, 360f);
		return Mathf.Abs(b - a);
	}

	public virtual void Apply(Transform dummyTarget, Vector3 dummyCenter)
	{
		if (!controller)
		{
			return;
		}
		Vector3 vector = _target.position + centerOffset;
		Vector3 headPos = _target.position + headOffset;
		float y = _target.eulerAngles.y;
		float y2 = cameraTransform.eulerAngles.y;
		float num = y;
		if (Input.GetButton("Fire2"))
		{
			snap = true;
		}
		if (snap)
		{
			if (!(AngleDistance(y2, y) >= 3f))
			{
				snap = false;
			}
			y2 = Mathf.SmoothDampAngle(y2, num, ref angleVelocity, snapSmoothLag, snapMaxSpeed);
		}
		else
		{
			if (!(controller.GetLockCameraTimer() >= lockCameraTimeout))
			{
				num = y2;
			}
			if (!(AngleDistance(y2, num) <= 160f) && controller.IsMovingBackwards())
			{
				num += 180f;
			}
			y2 = Mathf.SmoothDampAngle(y2, num, ref angleVelocity, angularSmoothLag, angularMaxSpeed);
		}
		if (controller.IsJumping())
		{
			float num2 = vector.y + height;
			if (num2 < targetHeight || !(num2 - targetHeight <= 5f))
			{
				targetHeight = vector.y + height;
			}
		}
		else
		{
			targetHeight = vector.y + height;
		}
		float y3 = cameraTransform.position.y;
		y3 = Mathf.SmoothDamp(y3, targetHeight, ref heightVelocity, heightSmoothLag);
		Quaternion quaternion = Quaternion.Euler(0f, y2, 0f);
		cameraTransform.position = vector;
		cameraTransform.position += quaternion * Vector3.back * distance;
		float y4 = y3;
		Vector3 position = cameraTransform.position;
		float num3 = (position.y = y4);
		Vector3 vector3 = (cameraTransform.position = position);
		SetUpRotation(vector, headPos);
	}

	public virtual void LateUpdate()
	{
		Apply(transform, Vector3.zero);
	}

	public virtual void Cut(Transform dummyTarget, Vector3 dummyCenter)
	{
		float num = heightSmoothLag;
		float num2 = snapMaxSpeed;
		float num3 = snapSmoothLag;
		snapMaxSpeed = 10000f;
		snapSmoothLag = 0.001f;
		heightSmoothLag = 0.001f;
		snap = true;
		Apply(transform, Vector3.zero);
		heightSmoothLag = num;
		snapMaxSpeed = num2;
		snapSmoothLag = num3;
	}

	public virtual void SetUpRotation(Vector3 centerPos, Vector3 headPos)
	{
		Vector3 position = cameraTransform.position;
		Vector3 vector = centerPos - position;
		Quaternion quaternion = Quaternion.LookRotation(new Vector3(vector.x, 0f, vector.z));
		Vector3 forward = Vector3.forward * distance + Vector3.down * height;
		cameraTransform.rotation = quaternion * Quaternion.LookRotation(forward);
		Ray ray = cameraTransform.GetComponent<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 1f));
		Ray ray2 = cameraTransform.GetComponent<Camera>().ViewportPointToRay(new Vector3(0.5f, clampHeadPositionScreenSpace, 1f));
		Vector3 point = ray.GetPoint(distance);
		Vector3 point2 = ray2.GetPoint(distance);
		float num = Vector3.Angle(ray.direction, ray2.direction);
		float num2 = num / (point.y - point2.y);
		float num3 = num2 * (point.y - centerPos.y);
		if (!(num3 >= num))
		{
			num3 = 0f;
			return;
		}
		num3 -= num;
		cameraTransform.rotation *= Quaternion.Euler(0f - num3, 0f, 0f);
	}

	public virtual Vector3 GetCenterOffset()
	{
		return centerOffset;
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public enum CharacterState
{
	Idle,
	Walking,
	Trotting,
	Running,
	Jumping
}
[Serializable]
[RequireComponent(typeof(CharacterController))]
public class ThirdPersonController : MonoBehaviour
{
	public AnimationClip idleAnimation;

	public AnimationClip walkAnimation;

	public AnimationClip runAnimation;

	public AnimationClip jumpPoseAnimation;

	public float walkMaxAnimationSpeed;

	public float trotMaxAnimationSpeed;

	public float runMaxAnimationSpeed;

	public float jumpAnimationSpeed;

	public float landAnimationSpeed;

	private Animation _animation;

	private CharacterState _characterState;

	public float walkSpeed;

	public float trotSpeed;

	public float runSpeed;

	public float inAirControlAcceleration;

	public float jumpHeight;

	public float gravity;

	public float speedSmoothing;

	public float rotateSpeed;

	public float trotAfterSeconds;

	public bool canJump;

	private float jumpRepeatTime;

	private float jumpTimeout;

	private float groundedTimeout;

	private float lockCameraTimer;

	private Vector3 moveDirection;

	private float verticalSpeed;

	private float moveSpeed;

	private CollisionFlags collisionFlags;

	private bool jumping;

	private bool jumpingReachedApex;

	private bool movingBack;

	private bool isMoving;

	private float walkTimeStart;

	private float lastJumpButtonTime;

	private float lastJumpTime;

	private float lastJumpStartHeight;

	private Vector3 inAirVelocity;

	private float lastGroundedTime;

	private bool isControllable;

	public ThirdPersonController()
	{
		walkMaxAnimationSpeed = 0.75f;
		trotMaxAnimationSpeed = 1f;
		runMaxAnimationSpeed = 1f;
		jumpAnimationSpeed = 1.15f;
		landAnimationSpeed = 1f;
		walkSpeed = 2f;
		trotSpeed = 4f;
		runSpeed = 6f;
		inAirControlAcceleration = 3f;
		jumpHeight = 0.5f;
		gravity = 20f;
		speedSmoothing = 10f;
		rotateSpeed = 500f;
		trotAfterSeconds = 3f;
		canJump = true;
		jumpRepeatTime = 0.05f;
		jumpTimeout = 0.15f;
		groundedTimeout = 0.25f;
		moveDirection = Vector3.zero;
		lastJumpButtonTime = -10f;
		lastJumpTime = -1f;
		inAirVelocity = Vector3.zero;
		isControllable = true;
	}

	public virtual void Awake()
	{
		moveDirection = transform.TransformDirection(Vector3.forward);
		_animation = (Animation)GetComponent(typeof(Animation));
		if (!_animation)
		{
			Debug.Log("The character you would like to control doesn't have animations. Moving her might look weird.");
		}
		if (!idleAnimation)
		{
			_animation = null;
			Debug.Log("No idle animation found. Turning off animations.");
		}
		if (!walkAnimation)
		{
			_animation = null;
			Debug.Log("No walk animation found. Turning off animations.");
		}
		if (!runAnimation)
		{
			_animation = null;
			Debug.Log("No run animation found. Turning off animations.");
		}
		if (!jumpPoseAnimation && canJump)
		{
			_animation = null;
			Debug.Log("No jump animation found and the character has canJump enabled. Turning off animations.");
		}
	}

	public virtual void UpdateSmoothedMovementDirection()
	{
		Transform transform = Camera.main.transform;
		bool flag = IsGrounded();
		Vector3 vector = transform.TransformDirection(Vector3.forward);
		vector.y = 0f;
		vector = vector.normalized;
		Vector3 vector2 = new Vector3(vector.z, 0f, 0f - vector.x);
		float axisRaw = Input.GetAxisRaw("Vertical");
		float axisRaw2 = Input.GetAxisRaw("Horizontal");
		if (!(axisRaw >= -0.2f))
		{
			movingBack = true;
		}
		else
		{
			movingBack = false;
		}
		bool flag2 = isMoving;
		bool num = Mathf.Abs(axisRaw2) > 0.1f;
		if (!num)
		{
			num = Mathf.Abs(axisRaw) > 0.1f;
		}
		isMoving = num;
		Vector3 vector3 = axisRaw2 * vector2 + axisRaw * vector;
		if (flag)
		{
			lockCameraTimer += Time.deltaTime;
			if (isMoving != flag2)
			{
				lockCameraTimer = 0f;
			}
			if (vector3 != Vector3.zero)
			{
				if (!(moveSpeed >= walkSpeed * 0.9f) && flag)
				{
					moveDirection = vector3.normalized;
				}
				else
				{
					moveDirection = Vector3.RotateTowards(moveDirection, vector3, rotateSpeed * ((float)Math.PI / 180f) * Time.deltaTime, 1000f);
					moveDirection = moveDirection.normalized;
				}
			}
			float t = speedSmoothing * Time.deltaTime;
			float num2 = Mathf.Min(vector3.magnitude, 1f);
			_characterState = CharacterState.Idle;
			if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
			{
				num2 *= runSpeed;
				_characterState = CharacterState.Running;
			}
			else if (!(Time.time - trotAfterSeconds <= walkTimeStart))
			{
				num2 *= trotSpeed;
				_characterState = CharacterState.Trotting;
			}
			else
			{
				num2 *= walkSpeed;
				_characterState = CharacterState.Walking;
			}
			moveSpeed = Mathf.Lerp(moveSpeed, num2, t);
			if (!(moveSpeed >= walkSpeed * 0.3f))
			{
				walkTimeStart = Time.time;
			}
		}
		else
		{
			if (jumping)
			{
				lockCameraTimer = 0f;
			}
			if (isMoving)
			{
				inAirVelocity += vector3.normalized * Time.deltaTime * inAirControlAcceleration;
			}
		}
	}

	public virtual void ApplyJumping()
	{
		if (lastJumpTime + jumpRepeatTime <= Time.time && IsGrounded() && canJump && !(Time.time >= lastJumpButtonTime + jumpTimeout))
		{
			verticalSpeed = CalculateJumpVerticalSpeed(jumpHeight);
			SendMessage("DidJump", SendMessageOptions.DontRequireReceiver);
		}
	}

	public virtual void ApplyGravity()
	{
		if (isControllable)
		{
			bool button = Input.GetButton("Jump");
			if (jumping && !jumpingReachedApex && !(verticalSpeed > 0f))
			{
				jumpingReachedApex = true;
				SendMessage("DidJumpReachApex", SendMessageOptions.DontRequireReceiver);
			}
			if (IsGrounded())
			{
				verticalSpeed = 0f;
			}
			else
			{
				verticalSpeed -= gravity * Time.deltaTime;
			}
		}
	}

	public virtual float CalculateJumpVerticalSpeed(float targetJumpHeight)
	{
		return Mathf.Sqrt(2f * targetJumpHeight * gravity);
	}

	public virtual void DidJump()
	{
		jumping = true;
		jumpingReachedApex = false;
		lastJumpTime = Time.time;
		lastJumpStartHeight = transform.position.y;
		lastJumpButtonTime = -10f;
		_characterState = CharacterState.Jumping;
	}

	public virtual void Update()
	{
		if (!isControllable)
		{
			Input.ResetInputAxes();
		}
		if (Input.GetButtonDown("Jump"))
		{
			lastJumpButtonTime = Time.time;
		}
		UpdateSmoothedMovementDirection();
		ApplyGravity();
		ApplyJumping();
		Vector3 vector = moveDirection * moveSpeed + new Vector3(0f, verticalSpeed, 0f) + inAirVelocity;
		vector *= Time.deltaTime;
		CharacterController characterController = (CharacterController)GetComponent(typeof(CharacterController));
		collisionFlags = characterController.Move(vector);
		if ((bool)_animation)
		{
			if (_characterState == CharacterState.Jumping)
			{
				if (!jumpingReachedApex)
				{
					_animation[jumpPoseAnimation.name].speed = jumpAnimationSpeed;
					_animation[jumpPoseAnimation.name].wrapMode = WrapMode.ClampForever;
					_animation.CrossFade(jumpPoseAnimation.name);
				}
				else
				{
					_animation[jumpPoseAnimation.name].speed = 0f - landAnimationSpeed;
					_animation[jumpPoseAnimation.name].wrapMode = WrapMode.ClampForever;
					_animation.CrossFade(jumpPoseAnimation.name);
				}
			}
			else if (!(characterController.velocity.sqrMagnitude >= 0.1f))
			{
				_animation.CrossFade(idleAnimation.name);
			}
			else if (_characterState == CharacterState.Running)
			{
				_animation[runAnimation.name].speed = Mathf.Clamp(characterController.velocity.magnitude, 0f, runMaxAnimationSpeed);
				_animation.CrossFade(runAnimation.name);
			}
			else if (_characterState == CharacterState.Trotting)
			{
				_animation[walkAnimation.name].speed = Mathf.Clamp(characterController.velocity.magnitude, 0f, trotMaxAnimationSpeed);
				_animation.CrossFade(walkAnimation.name);
			}
			else if (_characterState == CharacterState.Walking)
			{
				_animation[walkAnimation.name].speed = Mathf.Clamp(characterController.velocity.magnitude, 0f, walkMaxAnimationSpeed);
				_animation.CrossFade(walkAnimation.name);
			}
		}
		if (IsGrounded())
		{
			transform.rotation = Quaternion.LookRotation(moveDirection);
		}
		else
		{
			Vector3 forward = vector;
			forward.y = 0f;
			if (!(forward.sqrMagnitude <= 0.001f))
			{
				transform.rotation = Quaternion.LookRotation(forward);
			}
		}
		if (IsGrounded())
		{
			lastGroundedTime = Time.time;
			inAirVelocity = Vector3.zero;
			if (jumping)
			{
				jumping = false;
				SendMessage("DidLand", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	public virtual void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if (hit.moveDirection.y <= 0.01f)
		{
		}
	}

	public virtual float GetSpeed()
	{
		return moveSpeed;
	}

	public virtual bool IsJumping()
	{
		return jumping;
	}

	public virtual bool IsGrounded()
	{
		return (collisionFlags & CollisionFlags.Below) != 0;
	}

	public virtual Vector3 GetDirection()
	{
		return moveDirection;
	}

	public virtual bool IsMovingBackwards()
	{
		return movingBack;
	}

	public virtual float GetLockCameraTimer()
	{
		return lockCameraTimer;
	}

	public virtual bool IsMoving()
	{
		return Mathf.Abs(Input.GetAxisRaw("Vertical")) + Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0.5f;
	}

	public virtual bool HasJumpReachedApex()
	{
		return jumpingReachedApex;
	}

	public virtual bool IsGroundedWithTimeout()
	{
		return lastGroundedTime + groundedTimeout > Time.time;
	}

	public virtual void Reset()
	{
		gameObject.tag = "Player";
	}

	public virtual void Main()
	{
	}
}
[Serializable]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
public class AmbientObscurance : PostEffectsBase
{
	[Range(0f, 3f)]
	public float intensity;

	[Range(0.1f, 3f)]
	public float radius;

	[Range(0f, 3f)]
	public int blurIterations;

	[Range(0f, 5f)]
	public float blurFilterDistance;

	[Range(0f, 1f)]
	public int downsample;

	public Texture2D rand;

	public Shader aoShader;

	private Material aoMaterial;

	public AmbientObscurance()
	{
		intensity = 0.5f;
		radius = 0.2f;
		blurIterations = 1;
		blurFilterDistance = 1.25f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: true);
		aoMaterial = CheckShaderAndCreateMaterial(aoShader, aoMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnDisable()
	{
		if ((bool)aoMaterial)
		{
			UnityEngine.Object.DestroyImmediate(aoMaterial);
		}
		aoMaterial = null;
	}

	[ImageEffectOpaque]
	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		Matrix4x4 projectionMatrix = GetComponent<Camera>().projectionMatrix;
		Matrix4x4 inverse = projectionMatrix.inverse;
		Vector4 value = new Vector4(-2f / ((float)Screen.width * projectionMatrix[0]), -2f / ((float)Screen.height * projectionMatrix[5]), (1f - projectionMatrix[2]) / projectionMatrix[0], (1f + projectionMatrix[6]) / projectionMatrix[5]);
		aoMaterial.SetVector("_ProjInfo", value);
		aoMaterial.SetMatrix("_ProjectionInv", inverse);
		aoMaterial.SetTexture("_Rand", rand);
		aoMaterial.SetFloat("_Radius", radius);
		aoMaterial.SetFloat("_Radius2", radius * radius);
		aoMaterial.SetFloat("_Intensity", intensity);
		aoMaterial.SetFloat("_BlurFilterDistance", blurFilterDistance);
		int width = source.width;
		int height = source.height;
		RenderTexture renderTexture = RenderTexture.GetTemporary(width >> downsample, height >> downsample);
		RenderTexture renderTexture2 = null;
		Graphics.Blit(source, renderTexture, aoMaterial, 0);
		if (downsample > 0)
		{
			renderTexture2 = RenderTexture.GetTemporary(width, height);
			Graphics.Blit(renderTexture, renderTexture2, aoMaterial, 4);
			RenderTexture.ReleaseTemporary(renderTexture);
			renderTexture = renderTexture2;
		}
		for (int i = 0; i < blurIterations; i++)
		{
			aoMaterial.SetVector("_Axis", new Vector2(1f, 0f));
			renderTexture2 = RenderTexture.GetTemporary(width, height);
			Graphics.Blit(renderTexture, renderTexture2, aoMaterial, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			aoMaterial.SetVector("_Axis", new Vector2(0f, 1f));
			renderTexture = RenderTexture.GetTemporary(width, height);
			Graphics.Blit(renderTexture2, renderTexture, aoMaterial, 1);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}
		aoMaterial.SetTexture("_AOTex", renderTexture);
		Graphics.Blit(source, destination, aoMaterial, 2);
		RenderTexture.ReleaseTemporary(renderTexture);
	}

	public override void Main()
	{
	}
}
[Serializable]
public enum AAMode
{
	FXAA2,
	FXAA3Console,
	FXAA1PresetA,
	FXAA1PresetB,
	NFAA,
	SSAA,
	DLAA
}
[Serializable]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Antialiasing (Fullscreen)")]
public class AntialiasingAsPostEffect : PostEffectsBase
{
	public AAMode mode;

	public bool showGeneratedNormals;

	public float offsetScale;

	public float blurRadius;

	public float edgeThresholdMin;

	public float edgeThreshold;

	public float edgeSharpness;

	public bool dlaaSharp;

	public Shader ssaaShader;

	private Material ssaa;

	public Shader dlaaShader;

	private Material dlaa;

	public Shader nfaaShader;

	private Material nfaa;

	public Shader shaderFXAAPreset2;

	private Material materialFXAAPreset2;

	public Shader shaderFXAAPreset3;

	private Material materialFXAAPreset3;

	public Shader shaderFXAAII;

	private Material materialFXAAII;

	public Shader shaderFXAAIII;

	private Material materialFXAAIII;

	public AntialiasingAsPostEffect()
	{
		mode = AAMode.FXAA3Console;
		offsetScale = 0.2f;
		blurRadius = 18f;
		edgeThresholdMin = 0.05f;
		edgeThreshold = 0.2f;
		edgeSharpness = 4f;
	}

	public virtual Material CurrentAAMaterial()
	{
		Material material = null;
		return mode switch
		{
			AAMode.FXAA3Console => materialFXAAIII, 
			AAMode.FXAA2 => materialFXAAII, 
			AAMode.FXAA1PresetA => materialFXAAPreset2, 
			AAMode.FXAA1PresetB => materialFXAAPreset3, 
			AAMode.NFAA => nfaa, 
			AAMode.SSAA => ssaa, 
			AAMode.DLAA => dlaa, 
			_ => null, 
		};
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false);
		materialFXAAPreset2 = CreateMaterial(shaderFXAAPreset2, materialFXAAPreset2);
		materialFXAAPreset3 = CreateMaterial(shaderFXAAPreset3, materialFXAAPreset3);
		materialFXAAII = CreateMaterial(shaderFXAAII, materialFXAAII);
		materialFXAAIII = CreateMaterial(shaderFXAAIII, materialFXAAIII);
		nfaa = CreateMaterial(nfaaShader, nfaa);
		ssaa = CreateMaterial(ssaaShader, ssaa);
		dlaa = CreateMaterial(dlaaShader, dlaa);
		if (!ssaaShader.isSupported)
		{
			NotSupported();
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
		}
		else if (mode == AAMode.FXAA3Console && materialFXAAIII != null)
		{
			materialFXAAIII.SetFloat("_EdgeThresholdMin", edgeThresholdMin);
			materialFXAAIII.SetFloat("_EdgeThreshold", edgeThreshold);
			materialFXAAIII.SetFloat("_EdgeSharpness", edgeSharpness);
			Graphics.Blit(source, destination, materialFXAAIII);
		}
		else if (mode == AAMode.FXAA1PresetB && materialFXAAPreset3 != null)
		{
			Graphics.Blit(source, destination, materialFXAAPreset3);
		}
		else if (mode == AAMode.FXAA1PresetA && materialFXAAPreset2 != null)
		{
			source.anisoLevel = 4;
			Graphics.Blit(source, destination, materialFXAAPreset2);
			source.anisoLevel = 0;
		}
		else if (mode == AAMode.FXAA2 && materialFXAAII != null)
		{
			Graphics.Blit(source, destination, materialFXAAII);
		}
		else if (mode == AAMode.SSAA && ssaa != null)
		{
			Graphics.Blit(source, destination, ssaa);
		}
		else if (mode == AAMode.DLAA && dlaa != null)
		{
			source.anisoLevel = 0;
			RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height);
			Graphics.Blit(source, temporary, dlaa, 0);
			Graphics.Blit(temporary, destination, dlaa, (!dlaaSharp) ? 1 : 2);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else if (mode == AAMode.NFAA && nfaa != null)
		{
			source.anisoLevel = 0;
			nfaa.SetFloat("_OffsetScale", offsetScale);
			nfaa.SetFloat("_BlurRadius", blurRadius);
			Graphics.Blit(source, destination, nfaa, showGeneratedNormals ? 1 : 0);
		}
		else
		{
			Graphics.Blit(source, destination);
		}
	}

	public override void Main()
	{
	}
}
[Serializable]
[AddComponentMenu("Image Effects/Bloom (4.0, HDR, Lens Flares)")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class Bloom : PostEffectsBase
{
	[Serializable]
	public enum LensFlareStyle
	{
		Ghosting,
		Anamorphic,
		Combined
	}

	[Serializable]
	public enum TweakMode
	{
		Basic,
		Complex
	}

	[Serializable]
	public enum HDRBloomMode
	{
		Auto,
		On,
		Off
	}

	[Serializable]
	public enum BloomScreenBlendMode
	{
		Screen,
		Add
	}

	[Serializable]
	public enum BloomQuality
	{
		Cheap,
		High
	}

	public TweakMode tweakMode;

	public BloomScreenBlendMode screenBlendMode;

	public HDRBloomMode hdr;

	private bool doHdr;

	public float sepBlurSpread;

	public BloomQuality quality;

	public float bloomIntensity;

	public float bloomThreshhold;

	public Color bloomThreshholdColor;

	public int bloomBlurIterations;

	public int hollywoodFlareBlurIterations;

	public float flareRotation;

	public LensFlareStyle lensflareMode;

	public float hollyStretchWidth;

	public float lensflareIntensity;

	public float lensflareThreshhold;

	public float lensFlareSaturation;

	public Color flareColorA;

	public Color flareColorB;

	public Color flareColorC;

	public Color flareColorD;

	public float blurWidth;

	public Texture2D lensFlareVignetteMask;

	public Shader lensFlareShader;

	private Material lensFlareMaterial;

	public Shader screenBlendShader;

	private Material screenBlend;

	public Shader blurAndFlaresShader;

	private Material blurAndFlaresMaterial;

	public Shader brightPassFilterShader;

	private Material brightPassFilterMaterial;

	public Bloom()
	{
		screenBlendMode = BloomScreenBlendMode.Add;
		hdr = HDRBloomMode.Auto;
		sepBlurSpread = 2.5f;
		quality = BloomQuality.High;
		bloomIntensity = 0.5f;
		bloomThreshhold = 0.5f;
		bloomThreshholdColor = Color.white;
		bloomBlurIterations = 2;
		hollywoodFlareBlurIterations = 2;
		lensflareMode = LensFlareStyle.Anamorphic;
		hollyStretchWidth = 2.5f;
		lensflareThreshhold = 0.3f;
		lensFlareSaturation = 0.75f;
		flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);
		flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);
		flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);
		flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);
		blurWidth = 1f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false);
		screenBlend = CheckShaderAndCreateMaterial(screenBlendShader, screenBlend);
		lensFlareMaterial = CheckShaderAndCreateMaterial(lensFlareShader, lensFlareMaterial);
		blurAndFlaresMaterial = CheckShaderAndCreateMaterial(blurAndFlaresShader, blurAndFlaresMaterial);
		brightPassFilterMaterial = CheckShaderAndCreateMaterial(brightPassFilterShader, brightPassFilterMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		doHdr = false;
		if (hdr == HDRBloomMode.Auto)
		{
			bool num = source.format == RenderTextureFormat.ARGBHalf;
			if (num)
			{
				num = GetComponent<Camera>().hdr;
			}
			doHdr = num;
		}
		else
		{
			doHdr = hdr == HDRBloomMode.On;
		}
		bool num2 = doHdr;
		if (num2)
		{
			num2 = supportHDRTextures;
		}
		doHdr = num2;
		BloomScreenBlendMode bloomScreenBlendMode = screenBlendMode;
		if (doHdr)
		{
			bloomScreenBlendMode = BloomScreenBlendMode.Add;
		}
		RenderTextureFormat format = ((!doHdr) ? RenderTextureFormat.Default : RenderTextureFormat.ARGBHalf);
		RenderTexture temporary = RenderTexture.GetTemporary(source.width / 2, source.height / 2, 0, format);
		RenderTexture temporary2 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
		RenderTexture temporary3 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
		RenderTexture temporary4 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
		float num3 = 1f * (float)source.width / (1f * (float)source.height);
		float num4 = 0.001953125f;
		if (quality > BloomQuality.Cheap)
		{
			Graphics.Blit(source, temporary, screenBlend, 2);
			Graphics.Blit(temporary, temporary3, screenBlend, 2);
			Graphics.Blit(temporary3, temporary2, screenBlend, 6);
		}
		else
		{
			Graphics.Blit(source, temporary);
			Graphics.Blit(temporary, temporary2, screenBlend, 6);
		}
		BrightFilter(bloomThreshhold * bloomThreshholdColor, temporary2, temporary3);
		if (bloomBlurIterations < 1)
		{
			bloomBlurIterations = 1;
		}
		else if (bloomBlurIterations > 10)
		{
			bloomBlurIterations = 10;
		}
		for (int i = 0; i < bloomBlurIterations; i++)
		{
			float num5 = (1f + (float)i * 0.25f) * sepBlurSpread;
			blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, num5 * num4, 0f, 0f));
			Graphics.Blit(temporary3, temporary4, blurAndFlaresMaterial, 4);
			if (quality > BloomQuality.Cheap)
			{
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num5 / num3 * num4, 0f, 0f, 0f));
				Graphics.Blit(temporary4, temporary3, blurAndFlaresMaterial, 4);
				if (i == 0)
				{
					Graphics.Blit(temporary3, temporary2);
				}
				else
				{
					Graphics.Blit(temporary3, temporary2, screenBlend, 10);
				}
			}
			else
			{
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num5 / num3 * num4, 0f, 0f, 0f));
				Graphics.Blit(temporary4, temporary3, blurAndFlaresMaterial, 4);
			}
		}
		if (quality > BloomQuality.Cheap)
		{
			Graphics.Blit(temporary2, temporary3, screenBlend, 6);
		}
		if (!(lensflareIntensity <= Mathf.Epsilon))
		{
			if (lensflareMode == LensFlareStyle.Ghosting)
			{
				BrightFilter(lensflareThreshhold, temporary3, temporary4);
				if (quality > BloomQuality.Cheap)
				{
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f / (1f * (float)temporary2.height), 0f, 0f));
					Graphics.Blit(temporary4, temporary2, blurAndFlaresMaterial, 4);
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(1.5f / (1f * (float)temporary2.width), 0f, 0f, 0f));
					Graphics.Blit(temporary2, temporary4, blurAndFlaresMaterial, 4);
				}
				Vignette(0.975f, temporary4, temporary4);
				BlendFlares(temporary4, temporary3);
			}
			else
			{
				float num6 = 1f * Mathf.Cos(flareRotation);
				float num7 = 1f * Mathf.Sin(flareRotation);
				float num8 = hollyStretchWidth * 1f / num3 * num4;
				float num9 = hollyStretchWidth * num4;
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6, num7, 0f, 0f));
				blurAndFlaresMaterial.SetVector("_Threshhold", new Vector4(lensflareThreshhold, 1f, 0f, 0f));
				blurAndFlaresMaterial.SetVector("_TintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
				blurAndFlaresMaterial.SetFloat("_Saturation", lensFlareSaturation);
				Graphics.Blit(temporary4, temporary2, blurAndFlaresMaterial, 2);
				Graphics.Blit(temporary2, temporary4, blurAndFlaresMaterial, 3);
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6 * num8, num7 * num8, 0f, 0f));
				blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth);
				Graphics.Blit(temporary4, temporary2, blurAndFlaresMaterial, 1);
				blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 2f);
				Graphics.Blit(temporary2, temporary4, blurAndFlaresMaterial, 1);
				blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 4f);
				Graphics.Blit(temporary4, temporary2, blurAndFlaresMaterial, 1);
				for (int i = 0; i < hollywoodFlareBlurIterations; i++)
				{
					num8 = hollyStretchWidth * 2f / num3 * num4;
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num8 * num6, num8 * num7, 0f, 0f));
					Graphics.Blit(temporary2, temporary4, blurAndFlaresMaterial, 4);
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num8 * num6, num8 * num7, 0f, 0f));
					Graphics.Blit(temporary4, temporary2, blurAndFlaresMaterial, 4);
				}
				if (lensflareMode == LensFlareStyle.Anamorphic)
				{
					AddTo(1f, temporary2, temporary3);
				}
				else
				{
					Vignette(1f, temporary2, temporary4);
					BlendFlares(temporary4, temporary2);
					AddTo(1f, temporary2, temporary3);
				}
			}
		}
		int pass = (int)bloomScreenBlendMode;
		screenBlend.SetFloat("_Intensity", bloomIntensity);
		screenBlend.SetTexture("_ColorBuffer", source);
		if (quality > BloomQuality.Cheap)
		{
			Graphics.Blit(temporary3, temporary);
			Graphics.Blit(temporary, destination, screenBlend, pass);
		}
		else
		{
			Graphics.Blit(temporary3, destination, screenBlend, pass);
		}
		RenderTexture.ReleaseTemporary(temporary);
		RenderTexture.ReleaseTemporary(temporary2);
		RenderTexture.ReleaseTemporary(temporary3);
		RenderTexture.ReleaseTemporary(temporary4);
	}

	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
		screenBlend.SetFloat("_Intensity", intensity_);
		Graphics.Blit(from, to, screenBlend, 9);
	}

	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
		lensFlareMaterial.SetVector("colorA", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * lensflareIntensity);
		lensFlareMaterial.SetVector("colorB", new Vector4(flareColorB.r, flareColorB.g, flareColorB.b, flareColorB.a) * lensflareIntensity);
		lensFlareMaterial.SetVector("colorC", new Vector4(flareColorC.r, flareColorC.g, flareColorC.b, flareColorC.a) * lensflareIntensity);
		lensFlareMaterial.SetVector("colorD", new Vector4(flareColorD.r, flareColorD.g, flareColorD.b, flareColorD.a) * lensflareIntensity);
		Graphics.Blit(from, to, lensFlareMaterial);
	}

	private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
	{
		brightPassFilterMaterial.SetVector("_Threshhold", new Vector4(thresh, thresh, thresh, thresh));
		Graphics.Blit(from, to, brightPassFilterMaterial, 0);
	}

	private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
	{
		brightPassFilterMaterial.SetVector("_Threshhold", threshColor);
		Graphics.Blit(from, to, brightPassFilterMaterial, 1);
	}

	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
		if ((bool)lensFlareVignetteMask)
		{
			screenBlend.SetTexture("_ColorBuffer", lensFlareVignetteMask);
			Graphics.Blit((!(from == to)) ? from : null, to, screenBlend, (!(from == to)) ? 3 : 7);
		}
		else if (from != to)
		{
			Graphics.Blit(from, to);
		}
	}

	public override void Main()
	{
	}
}
[Serializable]
public enum LensflareStyle34
{
	Ghosting,
	Anamorphic,
	Combined
}
[Serializable]
public enum TweakMode34
{
	Basic,
	Complex
}
[Serializable]
public enum HDRBloomMode
{
	Auto,
	On,
	Off
}
[Serializable]
public enum BloomScreenBlendMode
{
	Screen,
	Add
}
[Serializable]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/BloomAndFlares (3.5, Deprecated)")]
[ExecuteInEditMode]
public class BloomAndLensFlares : PostEffectsBase
{
	public TweakMode34 tweakMode;

	public BloomScreenBlendMode screenBlendMode;

	public HDRBloomMode hdr;

	private bool doHdr;

	public float sepBlurSpread;

	public float useSrcAlphaAsMask;

	public float bloomIntensity;

	public float bloomThreshhold;

	public int bloomBlurIterations;

	public bool lensflares;

	public int hollywoodFlareBlurIterations;

	public LensflareStyle34 lensflareMode;

	public float hollyStretchWidth;

	public float lensflareIntensity;

	public float lensflareThreshhold;

	public Color flareColorA;

	public Color flareColorB;

	public Color flareColorC;

	public Color flareColorD;

	public float blurWidth;

	public Texture2D lensFlareVignetteMask;

	public Shader lensFlareShader;

	private Material lensFlareMaterial;

	public Shader vignetteShader;

	private Material vignetteMaterial;

	public Shader separableBlurShader;

	private Material separableBlurMaterial;

	public Shader addBrightStuffOneOneShader;

	private Material addBrightStuffBlendOneOneMaterial;

	public Shader screenBlendShader;

	private Material screenBlend;

	public Shader hollywoodFlaresShader;

	private Material hollywoodFlaresMaterial;

	public Shader brightPassFilterShader;

	private Material brightPassFilterMaterial;

	public BloomAndLensFlares()
	{
		screenBlendMode = BloomScreenBlendMode.Add;
		hdr = HDRBloomMode.Auto;
		sepBlurSpread = 1.5f;
		useSrcAlphaAsMask = 0.5f;
		bloomIntensity = 1f;
		bloomThreshhold = 0.5f;
		bloomBlurIterations = 2;
		hollywoodFlareBlurIterations = 2;
		lensflareMode = LensflareStyle34.Anamorphic;
		hollyStretchWidth = 3.5f;
		lensflareIntensity = 1f;
		lensflareThreshhold = 0.3f;
		flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);
		flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);
		flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);
		flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);
		blurWidth = 1f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false);
		screenBlend = CheckShaderAndCreateMaterial(screenBlendShader, screenBlend);
		lensFlareMaterial = CheckShaderAndCreateMaterial(lensFlareShader, lensFlareMaterial);
		vignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, vignetteMaterial);
		separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
		addBrightStuffBlendOneOneMaterial = CheckShaderAndCreateMaterial(addBrightStuffOneOneShader, addBrightStuffBlendOneOneMaterial);
		hollywoodFlaresMaterial = CheckShaderAndCreateMaterial(hollywoodFlaresShader, hollywoodFlaresMaterial);
		brightPassFilterMaterial = CheckShaderAndCreateMaterial(brightPassFilterShader, brightPassFilterMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		doHdr = false;
		if (hdr == HDRBloomMode.Auto)
		{
			bool num = source.format == RenderTextureFormat.ARGBHalf;
			if (num)
			{
				num = GetComponent<Camera>().hdr;
			}
			doHdr = num;
		}
		else
		{
			doHdr = hdr == HDRBloomMode.On;
		}
		bool num2 = doHdr;
		if (num2)
		{
			num2 = supportHDRTextures;
		}
		doHdr = num2;
		BloomScreenBlendMode pass = screenBlendMode;
		if (doHdr)
		{
			pass = BloomScreenBlendMode.Add;
		}
		RenderTextureFormat format = ((!doHdr) ? RenderTextureFormat.Default : RenderTextureFormat.ARGBHalf);
		RenderTexture temporary = RenderTexture.GetTemporary(source.width / 2, source.height / 2, 0, format);
		RenderTexture temporary2 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
		RenderTexture temporary3 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
		RenderTexture temporary4 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
		float num3 = 1f * (float)source.width / (1f * (float)source.height);
		float num4 = 0.001953125f;
		Graphics.Blit(source, temporary, screenBlend, 2);
		Graphics.Blit(temporary, temporary2, screenBlend, 2);
		RenderTexture.ReleaseTemporary(temporary);
		BrightFilter(bloomThreshhold, useSrcAlphaAsMask, temporary2, temporary3);
		temporary2.DiscardContents();
		if (bloomBlurIterations < 1)
		{
			bloomBlurIterations = 1;
		}
		for (int i = 0; i < bloomBlurIterations; i++)
		{
			float num5 = (1f + (float)i * 0.5f) * sepBlurSpread;
			separableBlurMaterial.SetVector("offsets", new Vector4(0f, num5 * num4, 0f, 0f));
			RenderTexture renderTexture = ((i != 0) ? temporary2 : temporary3);
			Graphics.Blit(renderTexture, temporary4, separableBlurMaterial);
			renderTexture.DiscardContents();
			separableBlurMaterial.SetVector("offsets", new Vector4(num5 / num3 * num4, 0f, 0f, 0f));
			Graphics.Blit(temporary4, temporary2, separableBlurMaterial);
			temporary4.DiscardContents();
		}
		if (lensflares)
		{
			if (lensflareMode == LensflareStyle34.Ghosting)
			{
				BrightFilter(lensflareThreshhold, 0f, temporary2, temporary4);
				temporary2.DiscardContents();
				Vignette(0.975f, temporary4, temporary3);
				temporary4.DiscardContents();
				BlendFlares(temporary3, temporary2);
				temporary3.DiscardContents();
			}
			else
			{
				hollywoodFlaresMaterial.SetVector("_Threshhold", new Vector4(lensflareThreshhold, 1f / (1f - lensflareThreshhold), 0f, 0f));
				hollywoodFlaresMaterial.SetVector("tintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
				Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 2);
				temporary4.DiscardContents();
				Graphics.Blit(temporary3, temporary4, hollywoodFlaresMaterial, 3);
				temporary3.DiscardContents();
				hollywoodFlaresMaterial.SetVector("offsets", new Vector4(sepBlurSpread * 1f / num3 * num4, 0f, 0f, 0f));
				hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth);
				Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 1);
				temporary4.DiscardContents();
				hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 2f);
				Graphics.Blit(temporary3, temporary4, hollywoodFlaresMaterial, 1);
				temporary3.DiscardContents();
				hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 4f);
				Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 1);
				temporary4.DiscardContents();
				if (lensflareMode == LensflareStyle34.Anamorphic)
				{
					for (int j = 0; j < hollywoodFlareBlurIterations; j++)
					{
						separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num3 * num4, 0f, 0f, 0f));
						Graphics.Blit(temporary3, temporary4, separableBlurMaterial);
						temporary3.DiscardContents();
						separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num3 * num4, 0f, 0f, 0f));
						Graphics.Blit(temporary4, temporary3, separableBlurMaterial);
						temporary4.DiscardContents();
					}
					AddTo(1f, temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					for (int k = 0; k < hollywoodFlareBlurIterations; k++)
					{
						separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num3 * num4, 0f, 0f, 0f));
						Graphics.Blit(temporary3, temporary4, separableBlurMaterial);
						temporary3.DiscardContents();
						separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num3 * num4, 0f, 0f, 0f));
						Graphics.Blit(temporary4, temporary3, separableBlurMaterial);
						temporary4.DiscardContents();
					}
					Vignette(1f, temporary3, temporary4);
					temporary3.DiscardContents();
					BlendFlares(temporary4, temporary3);
					temporary4.DiscardContents();
					AddTo(1f, temporary3, temporary2);
					temporary3.DiscardContents();
				}
			}
		}
		screenBlend.SetFloat("_Intensity", bloomIntensity);
		screenBlend.SetTexture("_ColorBuffer", source);
		Graphics.Blit(temporary2, destination, screenBlend, (int)pass);
		RenderTexture.ReleaseTemporary(temporary2);
		RenderTexture.ReleaseTemporary(temporary3);
		RenderTexture.ReleaseTemporary(temporary4);
	}

	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
		addBrightStuffBlendOneOneMaterial.SetFloat("_Intensity", intensity_);
		Graphics.Blit(from, to, addBrightStuffBlendOneOneMaterial);
	}

	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
		lensFlareMaterial.SetVector("colorA", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * lensflareIntensity);
		lensFlareMaterial.SetVector("colorB", new Vector4(flareColorB.r, flareColorB.g, flareColorB.b, flareColorB.a) * lensflareIntensity);
		lensFlareMaterial.SetVector("colorC", new Vector4(flareColorC.r, flareColorC.g, flareColorC.b, flareColorC.a) * lensflareIntensity);
		lensFlareMaterial.SetVector("colorD", new Vector4(flareColorD.r, flareColorD.g, flareColorD.b, flareColorD.a) * lensflareIntensity);
		Graphics.Blit(from, to, lensFlareMaterial);
	}

	private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
	{
		if (doHdr)
		{
			brightPassFilterMaterial.SetVector("threshhold", new Vector4(thresh, 1f, 0f, 0f));
		}
		else
		{
			brightPassFilterMaterial.SetVector("threshhold", new Vector4(thresh, 1f / (1f - thresh), 0f, 0f));
		}
		brightPassFilterMaterial.SetFloat("useSrcAlphaAsMask", useAlphaAsMask);
		Graphics.Blit(from, to, brightPassFilterMaterial);
	}

	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
		if ((bool)lensFlareVignetteMask)
		{
			screenBlend.SetTexture("_ColorBuffer", lensFlareVignetteMask);
			Graphics.Blit(from, to, screenBlend, 3);
		}
		else
		{
			vignetteMaterial.SetFloat("vignetteIntensity", amount);
			Graphics.Blit(from, to, vignetteMaterial);
		}
	}

	public override void Main()
	{
	}
}
[Serializable]
[AddComponentMenu("Image Effects/Camera Info")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class CameraInfo : MonoBehaviour
{
	public DepthTextureMode currentDepthMode;

	public RenderingPath currentRenderPath;

	public int recognizedPostFxCount;

	public virtual void Main()
	{
	}
}
[Serializable]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Camera Motion Blur")]
[RequireComponent(typeof(Camera))]
public class CameraMotionBlur : PostEffectsBase
{
	[Serializable]
	public enum MotionBlurFilter
	{
		CameraMotion,
		LocalBlur,
		Reconstruction,
		ReconstructionDX11
	}

	[NonSerialized]
	public static int MAX_RADIUS = 10;

	public MotionBlurFilter filterType;

	public bool preview;

	public Vector3 previewScale;

	public float movementScale;

	public float rotationScale;

	public float maxVelocity;

	public int maxNumSamples;

	public float minVelocity;

	public float velocityScale;

	public float softZDistance;

	public int velocityDownsample;

	public LayerMask excludeLayers;

	private GameObject tmpCam;

	public Shader shader;

	public Shader dx11MotionBlurShader;

	public Shader replacementClear;

	private Material motionBlurMaterial;

	private Material dx11MotionBlurMaterial;

	public Texture2D noiseTexture;

	public bool showVelocity;

	public float showVelocityScale;

	private Matrix4x4 currentViewProjMat;

	private Matrix4x4 prevViewProjMat;

	private int prevFrameCount;

	private bool wasActive;

	private Vector3 prevFrameForward;

	private Vector3 prevFrameRight;

	private Vector3 prevFrameUp;

	private Vector3 prevFramePos;

	public CameraMotionBlur()
	{
		filterType = MotionBlurFilter.Reconstruction;
		previewScale = Vector3.one;
		rotationScale = 1f;
		maxVelocity = 8f;
		maxNumSamples = 17;
		minVelocity = 0.1f;
		velocityScale = 0.375f;
		softZDistance = 0.005f;
		velocityDownsample = 1;
		showVelocityScale = 1f;
		prevFrameForward = Vector3.forward;
		prevFrameRight = Vector3.right;
		prevFrameUp = Vector3.up;
		prevFramePos = Vector3.zero;
	}

	private void CalculateViewProjection()
	{
		Matrix4x4 worldToCameraMatrix = GetComponent<Camera>().worldToCameraMatrix;
		Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(GetComponent<Camera>().projectionMatrix, renderIntoTexture: true);
		currentViewProjMat = gPUProjectionMatrix * worldToCameraMatrix;
	}

	public override void Start()
	{
		CheckResources();
		wasActive = gameObject.activeInHierarchy;
		CalculateViewProjection();
		Remember();
		prevFrameCount = -1;
		wasActive = false;
	}

	public override void OnEnable()
	{
		GetComponent<Camera>().depthTextureMode = GetComponent<Camera>().depthTextureMode | DepthTextureMode.Depth;
	}

	public virtual void OnDisable()
	{
		if (null != motionBlurMaterial)
		{
			UnityEngine.Object.DestroyImmediate(motionBlurMaterial);
			motionBlurMaterial = null;
		}
		if (null != dx11MotionBlurMaterial)
		{
			UnityEngine.Object.DestroyImmediate(dx11MotionBlurMaterial);
			dx11MotionBlurMaterial = null;
		}
		if (null != tmpCam)
		{
			UnityEngine.Object.DestroyImmediate(tmpCam);
			tmpCam = null;
		}
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: true, needHdr: true);
		motionBlurMaterial = CheckShaderAndCreateMaterial(shader, motionBlurMaterial);
		if (supportDX11 && filterType == MotionBlurFilter.ReconstructionDX11)
		{
			dx11MotionBlurMaterial = CheckShaderAndCreateMaterial(dx11MotionBlurShader, dx11MotionBlurMaterial);
		}
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		if (filterType == MotionBlurFilter.CameraMotion)
		{
			StartFrame();
		}
		RenderTextureFormat format = ((!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf)) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.RGHalf);
		RenderTexture temporary = RenderTexture.GetTemporary(divRoundUp(source.width, velocityDownsample), divRoundUp(source.height, velocityDownsample), 0, format);
		int num = 1;
		int num2 = 1;
		maxVelocity = Mathf.Max(2f, maxVelocity);
		float num3 = maxVelocity;
		bool flag = false;
		if (filterType == MotionBlurFilter.ReconstructionDX11 && dx11MotionBlurMaterial == null)
		{
			flag = true;
		}
		if (filterType == MotionBlurFilter.Reconstruction || flag)
		{
			maxVelocity = Mathf.Min(maxVelocity, MAX_RADIUS);
			num = divRoundUp(temporary.width, (int)maxVelocity);
			num2 = divRoundUp(temporary.height, (int)maxVelocity);
			num3 = temporary.width / num;
		}
		else
		{
			num = divRoundUp(temporary.width, (int)maxVelocity);
			num2 = divRoundUp(temporary.height, (int)maxVelocity);
			num3 = temporary.width / num;
		}
		RenderTexture temporary2 = RenderTexture.GetTemporary(num, num2, 0, format);
		RenderTexture temporary3 = RenderTexture.GetTemporary(num, num2, 0, format);
		temporary.filterMode = FilterMode.Point;
		temporary2.filterMode = FilterMode.Point;
		temporary3.filterMode = FilterMode.Point;
		if ((bool)noiseTexture)
		{
			noiseTexture.filterMode = FilterMode.Point;
		}
		source.wrapMode = TextureWrapMode.Clamp;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary3.wrapMode = TextureWrapMode.Clamp;
		temporary2.wrapMode = TextureWrapMode.Clamp;
		CalculateViewProjection();
		if (gameObject.activeInHierarchy && !wasActive)
		{
			Remember();
		}
		wasActive = gameObject.activeInHierarchy;
		Matrix4x4 matrix4x = Matrix4x4.Inverse(currentViewProjMat);
		motionBlurMaterial.SetMatrix("_InvViewProj", matrix4x);
		motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
		motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * matrix4x);
		motionBlurMaterial.SetFloat("_MaxVelocity", num3);
		motionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
		motionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
		motionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
		motionBlurMaterial.SetTexture("_NoiseTex", noiseTexture);
		motionBlurMaterial.SetTexture("_VelTex", temporary);
		motionBlurMaterial.SetTexture("_NeighbourMaxTex", temporary3);
		motionBlurMaterial.SetTexture("_TileTexDebug", temporary2);
		if (preview)
		{
			Matrix4x4 worldToCameraMatrix = GetComponent<Camera>().worldToCameraMatrix;
			Matrix4x4 identity = Matrix4x4.identity;
			identity.SetTRS(previewScale * 0.25f, Quaternion.identity, Vector3.one);
			Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(GetComponent<Camera>().projectionMatrix, renderIntoTexture: true);
			prevViewProjMat = gPUProjectionMatrix * identity * worldToCameraMatrix;
			motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
			motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * matrix4x);
		}
		if (filterType == MotionBlurFilter.CameraMotion)
		{
			Vector4 zero = Vector4.zero;
			float num4 = Vector3.Dot(transform.up, Vector3.up);
			Vector3 rhs = prevFramePos - transform.position;
			float magnitude = rhs.magnitude;
			float num5 = 1f;
			num5 = Vector3.Angle(transform.up, prevFrameUp) / GetComponent<Camera>().fieldOfView * ((float)source.width * 0.75f);
			zero.x = rotationScale * num5;
			num5 = Vector3.Angle(transform.forward, prevFrameForward) / GetComponent<Camera>().fieldOfView * ((float)source.width * 0.75f);
			zero.y = rotationScale * num4 * num5;
			num5 = Vector3.Angle(transform.forward, prevFrameForward) / GetComponent<Camera>().fieldOfView * ((float)source.width * 0.75f);
			zero.z = rotationScale * (1f - num4) * num5;
			if (!(magnitude <= Mathf.Epsilon) && !(movementScale <= Mathf.Epsilon))
			{
				zero.w = movementScale * Vector3.Dot(transform.forward, rhs) * ((float)source.width * 0.5f);
				zero.x += movementScale * Vector3.Dot(transform.up, rhs) * ((float)source.width * 0.5f);
				zero.y += movementScale * Vector3.Dot(transform.right, rhs) * ((float)source.width * 0.5f);
			}
			if (preview)
			{
				motionBlurMaterial.SetVector("_BlurDirectionPacked", new Vector4(previewScale.y, previewScale.x, 0f, previewScale.z) * 0.5f * GetComponent<Camera>().fieldOfView);
			}
			else
			{
				motionBlurMaterial.SetVector("_BlurDirectionPacked", zero);
			}
		}
		else
		{
			Graphics.Blit(source, temporary, motionBlurMaterial, 0);
			Camera camera = null;
			if (excludeLayers.value != 0)
			{
				camera = GetTmpCam();
			}
			if ((bool)camera && excludeLayers.value != 0 && (bool)replacementClear && replacementClear.isSupported)
			{
				camera.targetTexture = temporary;
				camera.cullingMask = excludeLayers;
				camera.RenderWithShader(replacementClear, string.Empty);
			}
		}
		if (!preview && Time.frameCount != prevFrameCount)
		{
			prevFrameCount = Time.frameCount;
			Remember();
		}
		source.filterMode = FilterMode.Bilinear;
		if (showVelocity)
		{
			motionBlurMaterial.SetFloat("_DisplayVelocityScale", showVelocityScale);
			Graphics.Blit(temporary, destination, motionBlurMaterial, 1);
		}
		else if (filterType == MotionBlurFilter.ReconstructionDX11 && !flag)
		{
			dx11MotionBlurMaterial.SetFloat("_MaxVelocity", num3);
			dx11MotionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
			dx11MotionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
			dx11MotionBlurMaterial.SetTexture("_NoiseTex", noiseTexture);
			dx11MotionBlurMaterial.SetTexture("_VelTex", temporary);
			dx11MotionBlurMaterial.SetTexture("_NeighbourMaxTex", temporary3);
			dx11MotionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
			dx11MotionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
			maxNumSamples = 2 * (maxNumSamples / 2) + 1;
			dx11MotionBlurMaterial.SetFloat("_SampleCount", (float)maxNumSamples * 1f);
			Graphics.Blit(temporary, temporary2, dx11MotionBlurMaterial, 0);
			Graphics.Blit(temporary2, temporary3, dx11MotionBlurMaterial, 1);
			Graphics.Blit(source, destination, dx11MotionBlurMaterial, 2);
		}
		else if (filterType == MotionBlurFilter.Reconstruction || flag)
		{
			motionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
			Graphics.Blit(temporary, temporary2, motionBlurMaterial, 2);
			Graphics.Blit(temporary2, temporary3, motionBlurMaterial, 3);
			Graphics.Blit(source, destination, motionBlurMaterial, 4);
		}
		else if (filterType == MotionBlurFilter.CameraMotion)
		{
			Graphics.Blit(source, destination, motionBlurMaterial, 6);
		}
		else
		{
			Graphics.Blit(source, destination, motionBlurMaterial, 5);
		}
		RenderTexture.ReleaseTemporary(temporary);
		RenderTexture.ReleaseTemporary(temporary2);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	public virtual void Remember()
	{
		prevViewProjMat = currentViewProjMat;
		prevFrameForward = transform.forward;
		prevFrameRight = transform.right;
		prevFrameUp = transform.up;
		prevFramePos = transform.position;
	}

	public virtual Camera GetTmpCam()
	{
		if (tmpCam == null)
		{
			string text = "_" + GetComponent<Camera>().name + "_MotionBlurTmpCam";
			GameObject gameObject = GameObject.Find(text);
			if (null == gameObject)
			{
				tmpCam = new GameObject(text, typeof(Camera));
			}
			else
			{
				tmpCam = gameObject;
			}
		}
		tmpCam.hideFlags = HideFlags.DontSave;
		tmpCam.transform.position = GetComponent<Camera>().transform.position;
		tmpCam.transform.rotation = GetComponent<Camera>().transform.rotation;
		tmpCam.transform.localScale = GetComponent<Camera>().transform.localScale;
		tmpCam.GetComponent<Camera>().CopyFrom(GetComponent<Camera>());
		tmpCam.GetComponent<Camera>().enabled = false;
		tmpCam.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
		tmpCam.GetComponent<Camera>().clearFlags = CameraClearFlags.Nothing;
		return tmpCam.GetComponent<Camera>();
	}

	public virtual void StartFrame()
	{
		prevFramePos = Vector3.Slerp(prevFramePos, transform.position, 0.75f);
	}

	public virtual int divRoundUp(int x, int d)
	{
		return (x + d - 1) / d;
	}

	public override void Main()
	{
	}
}
[Serializable]
public enum ColorCorrectionMode
{
	Simple,
	Advanced
}
[Serializable]
[AddComponentMenu("Image Effects/Color Correction (Curves, Saturation)")]
[ExecuteInEditMode]
public class ColorCorrectionCurves : PostEffectsBase
{
	public AnimationCurve redChannel;

	public AnimationCurve greenChannel;

	public AnimationCurve blueChannel;

	public bool useDepthCorrection;

	public AnimationCurve zCurve;

	public AnimationCurve depthRedChannel;

	public AnimationCurve depthGreenChannel;

	public AnimationCurve depthBlueChannel;

	private Material ccMaterial;

	private Material ccDepthMaterial;

	private Material selectiveCcMaterial;

	private Texture2D rgbChannelTex;

	private Texture2D rgbDepthChannelTex;

	private Texture2D zCurveTex;

	public float saturation;

	public bool selectiveCc;

	public Color selectiveFromColor;

	public Color selectiveToColor;

	public ColorCorrectionMode mode;

	public bool updateTextures;

	public Shader colorCorrectionCurvesShader;

	public Shader simpleColorCorrectionCurvesShader;

	public Shader colorCorrectionSelectiveShader;

	private bool updateTexturesOnStartup;

	public ColorCorrectionCurves()
	{
		saturation = 1f;
		selectiveFromColor = Color.white;
		selectiveToColor = Color.white;
		updateTextures = true;
		updateTexturesOnStartup = true;
	}

	public override void Start()
	{
		base.Start();
		updateTexturesOnStartup = true;
	}

	public virtual void Awake()
	{
	}

	public override bool CheckResources()
	{
		CheckSupport(mode == ColorCorrectionMode.Advanced);
		ccMaterial = CheckShaderAndCreateMaterial(simpleColorCorrectionCurvesShader, ccMaterial);
		ccDepthMaterial = CheckShaderAndCreateMaterial(colorCorrectionCurvesShader, ccDepthMaterial);
		selectiveCcMaterial = CheckShaderAndCreateMaterial(colorCorrectionSelectiveShader, selectiveCcMaterial);
		if (!rgbChannelTex)
		{
			rgbChannelTex = new Texture2D(256, 4, TextureFormat.ARGB32, mipmap: false, linear: true);
		}
		if (!rgbDepthChannelTex)
		{
			rgbDepthChannelTex = new Texture2D(256, 4, TextureFormat.ARGB32, mipmap: false, linear: true);
		}
		if (!zCurveTex)
		{
			zCurveTex = new Texture2D(256, 1, TextureFormat.ARGB32, mipmap: false, linear: true);
		}
		rgbChannelTex.hideFlags = HideFlags.DontSave;
		rgbDepthChannelTex.hideFlags = HideFlags.DontSave;
		zCurveTex.hideFlags = HideFlags.DontSave;
		rgbChannelTex.wrapMode = TextureWrapMode.Clamp;
		rgbDepthChannelTex.wrapMode = TextureWrapMode.Clamp;
		zCurveTex.wrapMode = TextureWrapMode.Clamp;
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void UpdateParameters()
	{
		if (redChannel != null && greenChannel != null && blueChannel != null)
		{
			for (float num = 0f; num <= 1f; num += 0.003921569f)
			{
				float num2 = Mathf.Clamp(redChannel.Evaluate(num), 0f, 1f);
				float num3 = Mathf.Clamp(greenChannel.Evaluate(num), 0f, 1f);
				float num4 = Mathf.Clamp(blueChannel.Evaluate(num), 0f, 1f);
				rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
				rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
				rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
				float num5 = Mathf.Clamp(zCurve.Evaluate(num), 0f, 1f);
				zCurveTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num5, num5, num5));
				num2 = Mathf.Clamp(depthRedChannel.Evaluate(num), 0f, 1f);
				num3 = Mathf.Clamp(depthGreenChannel.Evaluate(num), 0f, 1f);
				num4 = Mathf.Clamp(depthBlueChannel.Evaluate(num), 0f, 1f);
				rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
				rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
				rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
			}
			rgbChannelTex.Apply();
			rgbDepthChannelTex.Apply();
			zCurveTex.Apply();
		}
	}

	public virtual void UpdateTextures()
	{
		UpdateParameters();
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		if (updateTexturesOnStartup)
		{
			UpdateParameters();
			updateTexturesOnStartup = false;
		}
		if (useDepthCorrection)
		{
			GetComponent<Camera>().depthTextureMode = GetComponent<Camera>().depthTextureMode | DepthTextureMode.Depth;
		}
		RenderTexture renderTexture = destination;
		if (selectiveCc)
		{
			renderTexture = RenderTexture.GetTemporary(source.width, source.height);
		}
		if (useDepthCorrection)
		{
			ccDepthMaterial.SetTexture("_RgbTex", rgbChannelTex);
			ccDepthMaterial.SetTexture("_ZCurve", zCurveTex);
			ccDepthMaterial.SetTexture("_RgbDepthTex", rgbDepthChannelTex);
			ccDepthMaterial.SetFloat("_Saturation", saturation);
			Graphics.Blit(source, renderTexture, ccDepthMaterial);
		}
		else
		{
			ccMaterial.SetTexture("_RgbTex", rgbChannelTex);
			ccMaterial.SetFloat("_Saturation", saturation);
			Graphics.Blit(source, renderTexture, ccMaterial);
		}
		if (selectiveCc)
		{
			selectiveCcMaterial.SetColor("selColor", selectiveFromColor);
			selectiveCcMaterial.SetColor("targetColor", selectiveToColor);
			Graphics.Blit(renderTexture, destination, selectiveCcMaterial);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}

	public override void Main()
	{
	}
}
[Serializable]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Color Correction (3D Lookup Texture)")]
public class ColorCorrectionLut : PostEffectsBase
{
	public Shader shader;

	private Material material;

	public Texture3D converted3DLut;

	public string basedOnTempTex;

	public ColorCorrectionLut()
	{
		basedOnTempTex = string.Empty;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false);
		material = CheckShaderAndCreateMaterial(shader, material);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnDisable()
	{
		if ((bool)material)
		{
			UnityEngine.Object.DestroyImmediate(material);
			material = null;
		}
	}

	public virtual void OnDestroy()
	{
		if ((bool)converted3DLut)
		{
			UnityEngine.Object.DestroyImmediate(converted3DLut);
		}
		converted3DLut = null;
	}

	public virtual void SetIdentityLut()
	{
		int num = 16;
		Color[] array = new Color[num * num * num];
		float num2 = 1f / (1f * (float)num - 1f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1f * num2, (float)j * 1f * num2, (float)k * 1f * num2, 1f);
				}
			}
		}
		if ((bool)converted3DLut)
		{
			UnityEngine.Object.DestroyImmediate(converted3DLut);
		}
		converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, mipmap: false);
		converted3DLut.SetPixels(array);
		converted3DLut.Apply();
		basedOnTempTex = string.Empty;
	}

	public virtual bool ValidDimensions(Texture2D tex2d)
	{
		int result;
		if (!tex2d)
		{
			result = 0;
		}
		else
		{
			int height = tex2d.height;
			result = ((height == Mathf.FloorToInt(Mathf.Sqrt(tex2d.width))) ? 1 : 0);
		}
		return (byte)result != 0;
	}

	public virtual void Convert(Texture2D temp2DTex, string path)
	{
		if ((bool)temp2DTex)
		{
			int num = temp2DTex.width * temp2DTex.height;
			num = temp2DTex.height;
			if (!ValidDimensions(temp2DTex))
			{
				Debug.LogWarning("The given 2D texture " + temp2DTex.name + " cannot be used as a 3D LUT.");
				basedOnTempTex = string.Empty;
				return;
			}
			Color[] pixels = temp2DTex.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if ((bool)converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(converted3DLut);
			}
			converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, mipmap: false);
			converted3DLut.SetPixels(array);
			converted3DLut.Apply();
			basedOnTempTex = path;
		}
		else
		{
			Debug.LogError("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
		}
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		if (converted3DLut == null)
		{
			SetIdentityLut();
		}
		int width = converted3DLut.width;
		converted3DLut.wrapMode = TextureWrapMode.Clamp;
		material.SetFloat("_Scale", (float)(width - 1) / (1f * (float)width));
		material.SetFloat("_Offset", 1f / (2f * (float)width));
		material.SetTexture("_ClutTex", converted3DLut);
		Graphics.Blit(source, destination, material, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
	}

	public override void Main()
	{
	}
}
[Serializable]
[AddComponentMenu("Image Effects/Contrast Enhance (Unsharp Mask)")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class ContrastEnhance : PostEffectsBase
{
	public float intensity;

	public float threshhold;

	private Material separableBlurMaterial;

	private Material contrastCompositeMaterial;

	public float blurSpread;

	public Shader separableBlurShader;

	public Shader contrastCompositeShader;

	public ContrastEnhance()
	{
		intensity = 0.5f;
		blurSpread = 1f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false);
		contrastCompositeMaterial = CheckShaderAndCreateMaterial(contrastCompositeShader, contrastCompositeMaterial);
		separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		RenderTexture temporary = RenderTexture.GetTemporary((int)((float)source.width / 2f), (int)((float)source.height / 2f), 0);
		RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)source.width / 4f), (int)((float)source.height / 4f), 0);
		RenderTexture temporary3 = RenderTexture.GetTemporary((int)((float)source.width / 4f), (int)((float)source.height / 4f), 0);
		Graphics.Blit(source, temporary);
		Graphics.Blit(temporary, temporary2);
		separableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * 1f / (float)temporary2.height, 0f, 0f));
		Graphics.Blit(temporary2, temporary3, separableBlurMaterial);
		separableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * 1f / (float)temporary2.width, 0f, 0f, 0f));
		Graphics.Blit(temporary3, temporary2, separableBlurMaterial);
		contrastCompositeMaterial.SetTexture("_MainTexBlurred", temporary2);
		contrastCompositeMaterial.SetFloat("intensity", intensity);
		contrastCompositeMaterial.SetFloat("threshhold", threshhold);
		Graphics.Blit(source, destination, contrastCompositeMaterial);
		RenderTexture.ReleaseTemporary(temporary);
		RenderTexture.ReleaseTemporary(temporary2);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	public override void Main()
	{
	}
}
[Serializable]
[AddComponentMenu("Image Effects/Crease")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class Crease : PostEffectsBase
{
	public float intensity;

	public int softness;

	public float spread;

	public Shader blurShader;

	private Material blurMaterial;

	public Shader depthFetchShader;

	private Material depthFetchMaterial;

	public Shader creaseApplyShader;

	private Material creaseApplyMaterial;

	public Crease()
	{
		intensity = 0.5f;
		softness = 1;
		spread = 1f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: true);
		blurMaterial = CheckShaderAndCreateMaterial(blurShader, blurMaterial);
		depthFetchMaterial = CheckShaderAndCreateMaterial(depthFetchShader, depthFetchMaterial);
		creaseApplyMaterial = CheckShaderAndCreateMaterial(creaseApplyShader, creaseApplyMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		float num = 1f * (float)source.width / (1f * (float)source.height);
		float num2 = 0.001953125f;
		RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0);
		RenderTexture temporary2 = RenderTexture.GetTemporary(source.width / 2, source.height / 2, 0);
		RenderTexture temporary3 = RenderTexture.GetTemporary(source.width / 2, source.height / 2, 0);
		Graphics.Blit(source, temporary, depthFetchMaterial);
		Graphics.Blit(temporary, temporary2);
		for (int i = 0; i < softness; i++)
		{
			blurMaterial.SetVector("offsets", new Vector4(0f, spread * num2, 0f, 0f));
			Graphics.Blit(temporary2, temporary3, blurMaterial);
			blurMaterial.SetVector("offsets", new Vector4(spread * num2 / num, 0f, 0f, 0f));
			Graphics.Blit(temporary3, temporary2, blurMaterial);
		}
		creaseApplyMaterial.SetTexture("_HrDepthTex", temporary);
		creaseApplyMaterial.SetTexture("_LrDepthTex", temporary2);
		creaseApplyMaterial.SetFloat("intensity", intensity);
		Graphics.Blit(source, destination, creaseApplyMaterial);
		RenderTexture.ReleaseTemporary(temporary);
		RenderTexture.ReleaseTemporary(temporary2);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	public override void Main()
	{
	}
}
[Serializable]
public enum Dof34QualitySetting
{
	OnlyBackground = 1,
	BackgroundAndForeground
}
[Serializable]
public enum DofResolution
{
	High = 2,
	Medium,
	Low
}
[Serializable]
public enum DofBlurriness
{
	Low = 1,
	High = 2,
	VeryHigh = 4
}
[Serializable]
public enum BokehDestination
{
	Background = 1,
	Foreground,
	BackgroundAndForeground
}
[Serializable]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Depth of Field (3.4)")]
[RequireComponent(typeof(Camera))]
public class DepthOfField34 : PostEffectsBase
{
	[NonSerialized]
	private static int SMOOTH_DOWNSAMPLE_PASS = 6;

	[NonSerialized]
	private static float BOKEH_EXTRA_BLUR = 2f;

	public Dof34QualitySetting quality;

	public DofResolution resolution;

	public bool simpleTweakMode;

	public float focalPoint;

	public float smoothness;

	public float focalZDistance;

	public float focalZStartCurve;

	public float focalZEndCurve;

	private float focalStartCurve;

	private float focalEndCurve;

	private float focalDistance01;

	public Transform objectFocus;

	public float focalSize;

	public DofBlurriness bluriness;

	public float maxBlurSpread;

	public float foregroundBlurExtrude;

	public Shader dofBlurShader;

	private Material dofBlurMaterial;

	public Shader dofShader;

	private Material dofMaterial;

	public bool visualize;

	public BokehDestination bokehDestination;

	private float widthOverHeight;

	private float oneOverBaseSize;

	public bool bokeh;

	public bool bokehSupport;

	public Shader bokehShader;

	public Texture2D bokehTexture;

	public float bokehScale;

	public float bokehIntensity;

	public float bokehThreshholdContrast;

	public float bokehThreshholdLuminance;

	public int bokehDownsample;

	private Material bokehMaterial;

	private RenderTexture foregroundTexture;

	private RenderTexture mediumRezWorkTexture;

	private RenderTexture finalDefocus;

	private RenderTexture lowRezWorkTexture;

	private RenderTexture bokehSource;

	private RenderTexture bokehSource2;

	public DepthOfField34()
	{
		quality = Dof34QualitySetting.OnlyBackground;
		resolution = DofResolution.Low;
		simpleTweakMode = true;
		focalPoint = 1f;
		smoothness = 0.5f;
		focalZStartCurve = 1f;
		focalZEndCurve = 1f;
		focalStartCurve = 2f;
		focalEndCurve = 2f;
		focalDistance01 = 0.1f;
		bluriness = DofBlurriness.High;
		maxBlurSpread = 1.75f;
		foregroundBlurExtrude = 1.15f;
		bokehDestination = BokehDestination.Background;
		widthOverHeight = 1.25f;
		oneOverBaseSize = 0.001953125f;
		bokehSupport = true;
		bokehScale = 2.4f;
		bokehIntensity = 0.15f;
		bokehThreshholdContrast = 0.1f;
		bokehThreshholdLuminance = 0.55f;
		bokehDownsample = 1;
	}

	public virtual void CreateMaterials()
	{
		dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
		dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
		bokehSupport = bokehShader.isSupported;
		if (bokeh && bokehSupport && (bool)bokehShader)
		{
			bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
		}
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: true);
		dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
		dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
		bokehSupport = bokehShader.isSupported;
		if (bokeh && bokehSupport && (bool)bokehShader)
		{
			bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
		}
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnDisable()
	{
		Quads.Cleanup();
	}

	public override void OnEnable()
	{
		GetComponent<Camera>().depthTextureMode = GetComponent<Camera>().depthTextureMode | DepthTextureMode.Depth;
	}

	public virtual float FocalDistance01(float worldDist)
	{
		return GetComponent<Camera>().WorldToViewportPoint((worldDist - GetComponent<Camera>().nearClipPlane) * GetComponent<Camera>().transform.forward + GetComponent<Camera>().transform.position).z / (GetComponent<Camera>().farClipPlane - GetComponent<Camera>().nearClipPlane);
	}

	public virtual int GetDividerBasedOnQuality()
	{
		int result = 1;
		if (resolution == DofResolution.Medium)
		{
			result = 2;
		}
		else if (resolution == DofResolution.Low)
		{
			result = 2;
		}
		return result;
	}

	public virtual int GetLowResolutionDividerBasedOnQuality(int baseDivider)
	{
		int num = baseDivider;
		if (resolution == DofResolution.High)
		{
			num *= 2;
		}
		if (resolution == DofResolution.Low)
		{
			num *= 2;
		}
		return num;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		if (!(smoothness >= 0.1f))
		{
			smoothness = 0.1f;
		}
		bool num = bokeh;
		if (num)
		{
			num = bokehSupport;
		}
		bokeh = num;
		float num2 = ((!bokeh) ? 1f : BOKEH_EXTRA_BLUR);
		bool flag = quality > Dof34QualitySetting.OnlyBackground;
		float num3 = focalSize / (GetComponent<Camera>().farClipPlane - GetComponent<Camera>().nearClipPlane);
		if (simpleTweakMode)
		{
			focalDistance01 = ((!objectFocus) ? FocalDistance01(focalPoint) : (GetComponent<Camera>().WorldToViewportPoint(objectFocus.position).z / GetComponent<Camera>().farClipPlane));
			focalStartCurve = focalDistance01 * smoothness;
			focalEndCurve = focalStartCurve;
			bool num4 = flag;
			if (num4)
			{
				num4 = focalPoint > GetComponent<Camera>().nearClipPlane + Mathf.Epsilon;
			}
			flag = num4;
		}
		else
		{
			if ((bool)objectFocus)
			{
				Vector3 vector = GetComponent<Camera>().WorldToViewportPoint(objectFocus.position);
				vector.z /= GetComponent<Camera>().farClipPlane;
				focalDistance01 = vector.z;
			}
			else
			{
				focalDistance01 = FocalDistance01(focalZDistance);
			}
			focalStartCurve = focalZStartCurve;
			focalEndCurve = focalZEndCurve;
			bool num5 = flag;
			if (num5)
			{
				num5 = focalPoint > GetComponent<Camera>().nearClipPlane + Mathf.Epsilon;
			}
			flag = num5;
		}
		widthOverHeight = 1f * (float)source.width / (1f * (float)source.height);
		oneOverBaseSize = 0.001953125f;
		dofMaterial.SetFloat("_ForegroundBlurExtrude", foregroundBlurExtrude);
		dofMaterial.SetVector("_CurveParams", new Vector4((!simpleTweakMode) ? focalStartCurve : (1f / focalStartCurve), (!simpleTweakMode) ? focalEndCurve : (1f / focalEndCurve), num3 * 0.5f, focalDistance01));
		dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), 0f, 0f));
		int dividerBasedOnQuality = GetDividerBasedOnQuality();
		int lowResolutionDividerBasedOnQuality = GetLowResolutionDividerBasedOnQuality(dividerBasedOnQuality);
		AllocateTextures(flag, source, dividerBasedOnQuality, lowResolutionDividerBasedOnQuality);
		Graphics.Blit(source, source, dofMaterial, 3);
		Downsample(source, mediumRezWorkTexture);
		Blur(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 4, maxBlurSpread);
		if (bokeh && (bokehDestination & BokehDestination.Background) != 0)
		{
			dofMaterial.SetVector("_Threshhold", new Vector4(bokehThreshholdContrast, bokehThreshholdLuminance, 0.95f, 0f));
			Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
			Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
			Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread * num2);
		}
		else
		{
			Downsample(mediumRezWorkTexture, lowRezWorkTexture);
			Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread);
		}
		dofBlurMaterial.SetTexture("_TapLow", lowRezWorkTexture);
		dofBlurMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
		Graphics.Blit(null, finalDefocus, dofBlurMaterial, 3);
		if (bokeh && (bokehDestination & BokehDestination.Background) != 0)
		{
			AddBokeh(bokehSource2, bokehSource, finalDefocus);
		}
		dofMaterial.SetTexture("_TapLowBackground", finalDefocus);
		dofMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
		Graphics.Blit(source, (!flag) ? destination : foregroundTexture, dofMaterial, visualize ? 2 : 0);
		if (flag)
		{
			Graphics.Blit(foregroundTexture, source, dofMaterial, 5);
			Downsample(source, mediumRezWorkTexture);
			BlurFg(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 2, maxBlurSpread);
			if (bokeh && (bokehDestination & BokehDestination.Foreground) != 0)
			{
				dofMaterial.SetVector("_Threshhold", new Vector4(bokehThreshholdContrast * 0.5f, bokehThreshholdLuminance, 0f, 0f));
				Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
				Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
				BlurFg(lowRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread * num2);
			}
			else
			{
				BlurFg(mediumRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread);
			}
			Graphics.Blit(lowRezWorkTexture, finalDefocus);
			dofMaterial.SetTexture("_TapLowForeground", finalDefocus);
			Graphics.Blit(source, destination, dofMaterial, visualize ? 1 : 4);
			if (bokeh && (bokehDestination & BokehDestination.Foreground) != 0)
			{
				AddBokeh(bokehSource2, bokehSource, destination);
			}
		}
		ReleaseTextures();
	}

	public virtual void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
		if (iterations > DofBlurriness.Low)
		{
			BlurHex(from, to, blurPass, spread, temporary);
			if (iterations > DofBlurriness.High)
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
		}
		else
		{
			dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
			Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	public virtual void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
		dofBlurMaterial.SetTexture("_TapHigh", from);
		RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
		if (iterations > DofBlurriness.Low)
		{
			BlurHex(from, to, blurPass, spread, temporary);
			if (iterations > DofBlurriness.High)
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
		}
		else
		{
			dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
			Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	public virtual void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
	{
		dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
		Graphics.Blit(from, tmp, dofBlurMaterial, blurPass);
		dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
		Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
		dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, spread * oneOverBaseSize, 0f, 0f));
		Graphics.Blit(to, tmp, dofBlurMaterial, blurPass);
		dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, (0f - spread) * oneOverBaseSize, 0f, 0f));
		Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
	}

	public virtual void Downsample(RenderTexture from, RenderTexture to)
	{
		dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)to.width), 1f / (1f * (float)to.height), 0f, 0f));
		Graphics.Blit(from, to, dofMaterial, SMOOTH_DOWNSAMPLE_PASS);
	}

	public virtual void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
	{
		if (!bokehMaterial)
		{
			return;
		}
		Mesh[] meshes = Quads.GetMeshes(tempTex.width, tempTex.height);
		RenderTexture.active = tempTex;
		GL.Clear(clearDepth: false, clearColor: true, new Color(0f, 0f, 0f, 0f));
		GL.PushMatrix();
		GL.LoadIdentity();
		bokehInfo.filterMode = FilterMode.Point;
		float num = (float)bokehInfo.width * 1f / ((float)bokehInfo.height * 1f);
		float num2 = 2f / (1f * (float)bokehInfo.width);
		num2 += bokehScale * maxBlurSpread * BOKEH_EXTRA_BLUR * oneOverBaseSize;
		bokehMaterial.SetTexture("_Source", bokehInfo);
		bokehMaterial.SetTexture("_MainTex", bokehTexture);
		bokehMaterial.SetVector("_ArScale", new Vector4(num2, num2 * num, 0.5f, 0.5f * num));
		bokehMaterial.SetFloat("_Intensity", bokehIntensity);
		bokehMaterial.SetPass(0);
		int i = 0;
		Mesh[] array = meshes;
		for (int length = array.Length; i < length; i++)
		{
			if ((bool)array[i])
			{
				Graphics.DrawMeshNow(array[i], Matrix4x4.identity);
			}
		}
		GL.PopMatrix();
		Graphics.Blit(tempTex, finalTarget, dofMaterial, 8);
		bokehInfo.filterMode = FilterMode.Bilinear;
	}

	public virtual void ReleaseTextures()
	{
		if ((bool)foregroundTexture)
		{
			RenderTexture.ReleaseTemporary(foregroundTexture);
		}
		if ((bool)finalDefocus)
		{
			RenderTexture.ReleaseTemporary(finalDefocus);
		}
		if ((bool)mediumRezWorkTexture)
		{
			RenderTexture.ReleaseTemporary(mediumRezWorkTexture);
		}
		if ((bool)lowRezWorkTexture)
		{
			RenderTexture.ReleaseTemporary(lowRezWorkTexture);
		}
		if ((bool)bokehSource)
		{
			RenderTexture.ReleaseTemporary(bokehSource);
		}
		if ((bool)bokehSource2)
		{
			RenderTexture.ReleaseTemporary(bokehSource2);
		}
	}

	public virtual void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
	{
		foregroundTexture = null;
		if (blurForeground)
		{
			foregroundTexture = RenderTexture.GetTemporary(source.width, source.height, 0);
		}
		mediumRezWorkTexture = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
		finalDefocus = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
		lowRezWorkTexture = RenderTexture.GetTemporary(source.width / lowTexDivider, source.height / lowTexDivider, 0);
		bokehSource = null;
		bokehSource2 = null;
		if (bokeh)
		{
			bokehSource = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
			bokehSource2 = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
			bokehSource.filterMode = FilterMode.Bilinear;
			bokehSource2.filterMode = FilterMode.Bilinear;
			RenderTexture.active = bokehSource2;
			GL.Clear(clearDepth: false, clearColor: true, new Color(0f, 0f, 0f, 0f));
		}
		source.filterMode = FilterMode.Bilinear;
		finalDefocus.filterMode = FilterMode.Bilinear;
		mediumRezWorkTexture.filterMode = FilterMode.Bilinear;
		lowRezWorkTexture.filterMode = FilterMode.Bilinear;
		if ((bool)foregroundTexture)
		{
			foregroundTexture.filterMode = FilterMode.Bilinear;
		}
	}

	public override void Main()
	{
	}
}
[Serializable]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Depth of Field (Lens Blur, Scatter, DX11)")]
public class DepthOfFieldScatter : PostEffectsBase
{
	[Serializable]
	public enum BlurType
	{
		DiscBlur,
		DX11
	}

	[Serializable]
	public enum BlurSampleCount
	{
		Low,
		Medium,
		High
	}

	public bool visualizeFocus;

	public float focalLength;

	public float focalSize;

	public float aperture;

	public Transform focalTransform;

	public float maxBlurSize;

	public bool highResolution;

	public BlurType blurType;

	public BlurSampleCount blurSampleCount;

	public bool nearBlur;

	public float foregroundOverlap;

	public Shader dofHdrShader;

	private Material dofHdrMaterial;

	public Shader dx11BokehShader;

	private Material dx11bokehMaterial;

	public float dx11BokehThreshhold;

	public float dx11SpawnHeuristic;

	public Texture2D dx11BokehTexture;

	public float dx11BokehScale;

	public float dx11BokehIntensity;

	private float focalDistance01;

	private ComputeBuffer cbDrawArgs;

	private ComputeBuffer cbPoints;

	private float internalBlurWidth;

	public DepthOfFieldScatter()
	{
		focalLength = 10f;
		focalSize = 0.05f;
		aperture = 11.5f;
		maxBlurSize = 2f;
		blurType = BlurType.DiscBlur;
		blurSampleCount = BlurSampleCount.High;
		foregroundOverlap = 1f;
		dx11BokehThreshhold = 0.5f;
		dx11SpawnHeuristic = 0.0875f;
		dx11BokehScale = 1.2f;
		dx11BokehIntensity = 2.5f;
		focalDistance01 = 10f;
		internalBlurWidth = 1f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: true);
		dofHdrMaterial = CheckShaderAndCreateMaterial(dofHdrShader, dofHdrMaterial);
		if (supportDX11 && blurType == BlurType.DX11)
		{
			dx11bokehMaterial = CheckShaderAndCreateMaterial(dx11BokehShader, dx11bokehMaterial);
			CreateComputeResources();
		}
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public override void OnEnable()
	{
		GetComponent<Camera>().depthTextureMode = GetComponent<Camera>().depthTextureMode | DepthTextureMode.Depth;
	}

	public virtual void OnDisable()
	{
		ReleaseComputeResources();
		if ((bool)dofHdrMaterial)
		{
			UnityEngine.Object.DestroyImmediate(dofHdrMaterial);
		}
		dofHdrMaterial = null;
		if ((bool)dx11bokehMaterial)
		{
			UnityEngine.Object.DestroyImmediate(dx11bokehMaterial);
		}
		dx11bokehMaterial = null;
	}

	public virtual void ReleaseComputeResources()
	{
		if (cbDrawArgs != null)
		{
			cbDrawArgs.Release();
		}
		cbDrawArgs = null;
		if (cbPoints != null)
		{
			cbPoints.Release();
		}
		cbPoints = null;
	}

	public virtual void CreateComputeResources()
	{
		if (RuntimeServices.EqualityOperator(cbDrawArgs, null))
		{
			cbDrawArgs = new ComputeBuffer(1, 16, ComputeBufferType.DrawIndirect);
			int[] data = new int[4] { 0, 1, 0, 0 };
			cbDrawArgs.SetData(data);
		}
		if (RuntimeServices.EqualityOperator(cbPoints, null))
		{
			cbPoints = new ComputeBuffer(90000, 28, ComputeBufferType.Append);
		}
	}

	public virtual float FocalDistance01(float worldDist)
	{
		return GetComponent<Camera>().WorldToViewportPoint((worldDist - GetComponent<Camera>().nearClipPlane) * GetComponent<Camera>().transform.forward + GetComponent<Camera>().transform.position).z / (GetComponent<Camera>().farClipPlane - GetComponent<Camera>().nearClipPlane);
	}

	private void WriteCoc(RenderTexture fromTo, RenderTexture temp1, RenderTexture temp2, bool fgDilate)
	{
		dofHdrMaterial.SetTexture("_FgOverlap", null);
		if (nearBlur && fgDilate)
		{
			Graphics.Blit(fromTo, temp2, dofHdrMaterial, 4);
			float num = internalBlurWidth * foregroundOverlap;
			dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
			Graphics.Blit(temp2, temp1, dofHdrMaterial, 2);
			dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
			Graphics.Blit(temp1, temp2, dofHdrMaterial, 2);
			dofHdrMaterial.SetTexture("_FgOverlap", temp2);
			Graphics.Blit(fromTo, fromTo, dofHdrMaterial, 13);
		}
		else
		{
			Graphics.Blit(fromTo, fromTo, dofHdrMaterial, 0);
		}
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		if (!(aperture >= 0f))
		{
			aperture = 0f;
		}
		if (!(maxBlurSize >= 0.1f))
		{
			maxBlurSize = 0.1f;
		}
		focalSize = Mathf.Clamp(focalSize, 0f, 2f);
		internalBlurWidth = Mathf.Max(maxBlurSize, 0f);
		focalDistance01 = ((!focalTransform) ? FocalDistance01(focalLength) : (GetComponent<Camera>().WorldToViewportPoint(focalTransform.position).z / GetComponent<Camera>().farClipPlane));
		dofHdrMaterial.SetVector("_CurveParams", new Vector4(1f, focalSize, aperture / 10f, focalDistance01));
		RenderTexture renderTexture = null;
		RenderTexture renderTexture2 = null;
		RenderTexture renderTexture3 = null;
		RenderTexture renderTexture4 = null;
		float num = internalBlurWidth * foregroundOverlap;
		if (visualizeFocus)
		{
			renderTexture = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
			renderTexture2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
			WriteCoc(source, renderTexture, renderTexture2, fgDilate: true);
			Graphics.Blit(source, destination, dofHdrMaterial, 16);
		}
		else if (blurType == BlurType.DX11 && (bool)dx11bokehMaterial)
		{
			if (highResolution)
			{
				internalBlurWidth = ((internalBlurWidth >= 0.1f) ? internalBlurWidth : 0.1f);
				num = internalBlurWidth * foregroundOverlap;
				renderTexture = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
				RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
				WriteCoc(source, null, null, fgDilate: false);
				renderTexture3 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				renderTexture4 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				Graphics.Blit(source, renderTexture3, dofHdrMaterial, 15);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
				Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 19);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
				Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 19);
				if (nearBlur)
				{
					Graphics.Blit(source, renderTexture4, dofHdrMaterial, 4);
				}
				dx11bokehMaterial.SetTexture("_BlurredColor", renderTexture3);
				dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
				dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshhold, 0.005f, 4f), internalBlurWidth));
				dx11bokehMaterial.SetTexture("_FgCocMask", (!nearBlur) ? null : renderTexture4);
				Graphics.SetRandomWriteTarget(1, cbPoints);
				Graphics.Blit(source, renderTexture, dx11bokehMaterial, 0);
				Graphics.ClearRandomWriteTargets();
				if (nearBlur)
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
					Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 2);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
					Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 2);
					Graphics.Blit(renderTexture4, renderTexture, dofHdrMaterial, 3);
				}
				Graphics.Blit(renderTexture, temporary, dofHdrMaterial, 20);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
				Graphics.Blit(renderTexture, source, dofHdrMaterial, 5);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
				Graphics.Blit(source, temporary, dofHdrMaterial, 21);
				Graphics.SetRenderTarget(temporary);
				ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
				dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
				dx11bokehMaterial.SetTexture("_MainTex", dx11BokehTexture);
				dx11bokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), internalBlurWidth));
				dx11bokehMaterial.SetPass(2);
				Graphics.DrawProceduralIndirect(MeshTopology.Points, cbDrawArgs, 0);
				Graphics.Blit(temporary, destination);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(renderTexture3);
				RenderTexture.ReleaseTemporary(renderTexture4);
			}
			else
			{
				renderTexture = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				renderTexture2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				num = internalBlurWidth * foregroundOverlap;
				WriteCoc(source, null, null, fgDilate: false);
				source.filterMode = FilterMode.Bilinear;
				Graphics.Blit(source, renderTexture, dofHdrMaterial, 6);
				renderTexture3 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
				renderTexture4 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
				Graphics.Blit(renderTexture, renderTexture3, dofHdrMaterial, 15);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
				Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 19);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
				Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 19);
				RenderTexture renderTexture5 = null;
				if (nearBlur)
				{
					renderTexture5 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					Graphics.Blit(source, renderTexture5, dofHdrMaterial, 4);
				}
				dx11bokehMaterial.SetTexture("_BlurredColor", renderTexture3);
				dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
				dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshhold, 0.005f, 4f), internalBlurWidth));
				dx11bokehMaterial.SetTexture("_FgCocMask", renderTexture5);
				Graphics.SetRandomWriteTarget(1, cbPoints);
				Graphics.Blit(renderTexture, renderTexture2, dx11bokehMaterial, 0);
				Graphics.ClearRandomWriteTargets();
				RenderTexture.ReleaseTemporary(renderTexture3);
				RenderTexture.ReleaseTemporary(renderTexture4);
				if (nearBlur)
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
					Graphics.Blit(renderTexture5, renderTexture, dofHdrMaterial, 2);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
					Graphics.Blit(renderTexture, renderTexture5, dofHdrMaterial, 2);
					Graphics.Blit(renderTexture5, renderTexture2, dofHdrMaterial, 3);
				}
				dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
				Graphics.Blit(renderTexture2, renderTexture, dofHdrMaterial, 5);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
				Graphics.Blit(renderTexture, renderTexture2, dofHdrMaterial, 5);
				Graphics.SetRenderTarget(renderTexture2);
				ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
				dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
				dx11bokehMaterial.SetTexture("_MainTex", dx11BokehTexture);
				dx11bokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)renderTexture2.width), 1f / (1f * (float)renderTexture2.height), internalBlurWidth));
				dx11bokehMaterial.SetPass(1);
				Graphics.DrawProceduralIndirect(MeshTopology.Points, cbDrawArgs, 0);
				dofHdrMaterial.SetTexture("_LowRez", renderTexture2);
				dofHdrMaterial.SetTexture("_FgOverlap", renderTexture5);
				dofHdrMaterial.SetVector("_Offsets", 1f * (float)source.width / (1f * (float)renderTexture2.width) * internalBlurWidth * Vector4.one);
				Graphics.Blit(source, destination, dofHdrMaterial, 9);
				if ((bool)renderTexture5)
				{
					RenderTexture.ReleaseTemporary(renderTexture5);
				}
			}
		}
		else
		{
			renderTexture = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
			renderTexture2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
			source.filterMode = FilterMode.Bilinear;
			if (highResolution)
			{
				internalBlurWidth *= 2f;
			}
			WriteCoc(source, renderTexture, renderTexture2, fgDilate: true);
			int pass = ((blurSampleCount != BlurSampleCount.High && blurSampleCount != BlurSampleCount.Medium) ? 11 : 17);
			if (highResolution)
			{
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.025f, internalBlurWidth));
				Graphics.Blit(source, destination, dofHdrMaterial, pass);
			}
			else
			{
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.1f, internalBlurWidth));
				Graphics.Blit(source, renderTexture, dofHdrMaterial, 6);
				Graphics.Blit(renderTexture, renderTexture2, dofHdrMaterial, pass);
				dofHdrMaterial.SetTexture("_LowRez", renderTexture2);
				dofHdrMaterial.SetTexture("_FgOverlap", null);
				dofHdrMaterial.SetVector("_Offsets", Vector4.one * (1f * (float)source.width / (1f * (float)renderTexture2.width)) * internalBlurWidth);
				Graphics.Blit(source, destination, dofHdrMaterial, (blurSampleCount != BlurSampleCount.High) ? 12 : 18);
			}
		}
		if ((bool)renderTexture)
		{
			RenderTexture.ReleaseTemporary(renderTexture);
		}
		if ((bool)renderTexture2)
		{
			RenderTexture.ReleaseTemporary(renderTexture2);
		}
	}

	public override void Main()
	{
	}
}
[Serializable]
public enum EdgeDetectMode
{
	TriangleDepthNormals,
	RobertsCrossDepthNormals,
	SobelDepth,
	SobelDepthThin
}
[Serializable]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Edge Detection (Geometry)")]
public class EdgeDetectEffectNormals : PostEffectsBase
{
	public EdgeDetectMode mode;

	public float sensitivityDepth;

	public float sensitivityNormals;

	public float edgeExp;

	public float sampleDist;

	public float edgesOnly;

	public Color edgesOnlyBgColor;

	public Shader edgeDetectShader;

	private Material edgeDetectMaterial;

	private EdgeDetectMode oldMode;

	public EdgeDetectEffectNormals()
	{
		mode = EdgeDetectMode.SobelDepthThin;
		sensitivityDepth = 1f;
		sensitivityNormals = 1f;
		edgeExp = 1f;
		sampleDist = 1f;
		edgesOnlyBgColor = Color.white;
		oldMode = EdgeDetectMode.SobelDepthThin;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: true);
		edgeDetectMaterial = CheckShaderAndCreateMaterial(edgeDetectShader, edgeDetectMaterial);
		if (mode != oldMode)
		{
			SetCameraFlag();
		}
		oldMode = mode;
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public override void Start()
	{
		oldMode = mode;
	}

	public virtual void SetCameraFlag()
	{
		if (mode > EdgeDetectMode.RobertsCrossDepthNormals)
		{
			GetComponent<Camera>().depthTextureMode = GetComponent<Camera>().depthTextureMode | DepthTextureMode.Depth;
		}
		else
		{
			GetComponent<Camera>().depthTextureMode = GetComponent<Camera>().depthTextureMode | DepthTextureMode.DepthNormals;
		}
	}

	public override void OnEnable()
	{
		SetCameraFlag();
	}

	[ImageEffectOpaque]
	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		Vector2 vector = new Vector2(sensitivityDepth, sensitivityNormals);
		edgeDetectMaterial.SetVector("_Sensitivity", new Vector4(vector.x, vector.y, 1f, vector.y));
		edgeDetectMaterial.SetFloat("_BgFade", edgesOnly);
		edgeDetectMaterial.SetFloat("_SampleDistance", sampleDist);
		edgeDetectMaterial.SetVector("_BgColor", edgesOnlyBgColor);
		edgeDetectMaterial.SetFloat("_Exponent", edgeExp);
		Graphics.Blit(source, destination, edgeDetectMaterial, (int)mode);
	}

	public override void Main()
	{
	}
}
[Serializable]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Fisheye")]
[ExecuteInEditMode]
public class Fisheye : PostEffectsBase
{
	public float strengthX;

	public float strengthY;

	public Shader fishEyeShader;

	private Material fisheyeMaterial;

	public Fisheye()
	{
		strengthX = 0.05f;
		strengthY = 0.05f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false);
		fisheyeMaterial = CheckShaderAndCreateMaterial(fishEyeShader, fisheyeMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		float num = 5f / 32f;
		float num2 = (float)source.width * 1f / ((float)source.height * 1f);
		fisheyeMaterial.SetVector("intensity", new Vector4(strengthX * num2 * num, strengthY * num, strengthX * num2 * num, strengthY * num));
		Graphics.Blit(source, destination, fisheyeMaterial);
	}

	public override void Main()
	{
	}
}
[Serializable]
[AddComponentMenu("Image Effects/Global Fog")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class GlobalFog : PostEffectsBase
{
	[Serializable]
	public enum FogMode
	{
		AbsoluteYAndDistance,
		AbsoluteY,
		Distance,
		RelativeYAndDistance
	}

	public FogMode fogMode;

	private float CAMERA_NEAR;

	private float CAMERA_FAR;

	private float CAMERA_FOV;

	private float CAMERA_ASPECT_RATIO;

	public float startDistance;

	public float globalDensity;

	public float heightScale;

	public float height;

	public Color globalFogColor;

	public Shader fogShader;

	private Material fogMaterial;

	public GlobalFog()
	{
		fogMode = FogMode.AbsoluteYAndDistance;
		CAMERA_NEAR = 0.5f;
		CAMERA_FAR = 50f;
		CAMERA_FOV = 60f;
		CAMERA_ASPECT_RATIO = 1.333333f;
		startDistance = 200f;
		globalDensity = 1f;
		heightScale = 100f;
		globalFogColor = Color.grey;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: true);
		fogMaterial = CheckShaderAndCreateMaterial(fogShader, fogMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		CAMERA_NEAR = GetComponent<Camera>().nearClipPlane;
		CAMERA_FAR = GetComponent<Camera>().farClipPlane;
		CAMERA_FOV = GetComponent<Camera>().fieldOfView;
		CAMERA_ASPECT_RATIO = GetComponent<Camera>().aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		Vector4 vector = default(Vector4);
		Vector3 vector2 = default(Vector3);
		float num = CAMERA_FOV * 0.5f;
		Vector3 vector3 = GetComponent<Camera>().transform.right * CAMERA_NEAR * Mathf.Tan(num * ((float)Math.PI / 180f)) * CAMERA_ASPECT_RATIO;
		Vector3 vector4 = GetComponent<Camera>().transform.up * CAMERA_NEAR * Mathf.Tan(num * ((float)Math.PI / 180f));
		Vector3 vector5 = GetComponent<Camera>().transform.forward * CAMERA_NEAR - vector3 + vector4;
		float num2 = vector5.magnitude * CAMERA_FAR / CAMERA_NEAR;
		vector5.Normalize();
		vector5 *= num2;
		Vector3 vector6 = GetComponent<Camera>().transform.forward * CAMERA_NEAR + vector3 + vector4;
		vector6.Normalize();
		vector6 *= num2;
		Vector3 vector7 = GetComponent<Camera>().transform.forward * CAMERA_NEAR + vector3 - vector4;
		vector7.Normalize();
		vector7 *= num2;
		Vector3 vector8 = GetComponent<Camera>().transform.forward * CAMERA_NEAR - vector3 - vector4;
		vector8.Normalize();
		vector8 *= num2;
		identity.SetRow(0, vector5);
		identity.SetRow(1, vector6);
		identity.SetRow(2, vector7);
		identity.SetRow(3, vector8);
		fogMaterial.SetMatrix("_FrustumCornersWS", identity);
		fogMaterial.SetVector("_CameraWS", GetComponent<Camera>().transform.position);
		fogMaterial.SetVector("_StartDistance", new Vector4(1f / startDistance, num2 - startDistance));
		fogMaterial.SetVector("_Y", new Vector4(height, 1f / heightScale));
		fogMaterial.SetFloat("_GlobalDensity", globalDensity * 0.01f);
		fogMaterial.SetColor("_FogColor", globalFogColor);
		CustomGraphicsBlit(source, destination, fogMaterial, (int)fogMode);
	}

	public static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
	{
		RenderTexture.active = dest;
		fxMaterial.SetTexture("_MainTex", source);
		GL.PushMatrix();
		GL.LoadOrtho();
		fxMaterial.SetPass(passNr);
		GL.Begin(7);
		GL.MultiTexCoord2(0, 0f, 0f);
		GL.Vertex3(0f, 0f, 3f);
		GL.MultiTexCoord2(0, 1f, 0f);
		GL.Vertex3(1f, 0f, 2f);
		GL.MultiTexCoord2(0, 1f, 1f);
		GL.Vertex3(1f, 1f, 1f);
		GL.MultiTexCoord2(0, 0f, 1f);
		GL.Vertex3(0f, 1f, 0f);
		GL.End();
		GL.PopMatrix();
	}

	public override void Main()
	{
	}
}
[Serializable]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Noise And Grain (Overlay, DX11)")]
[ExecuteInEditMode]
public class NoiseAndGrain : PostEffectsBase
{
	public float intensityMultiplier;

	public float generalIntensity;

	public float blackIntensity;

	public float whiteIntensity;

	public float midGrey;

	public bool dx11Grain;

	public float softness;

	public bool monochrome;

	public Vector3 intensities;

	public Vector3 tiling;

	public float monochromeTiling;

	public FilterMode filterMode;

	public Texture2D noiseTexture;

	public Shader noiseShader;

	private Material noiseMaterial;

	public Shader dx11NoiseShader;

	private Material dx11NoiseMaterial;

	[NonSerialized]
	private static float TILE_AMOUNT = 64f;

	public NoiseAndGrain()
	{
		intensityMultiplier = 0.25f;
		generalIntensity = 0.5f;
		blackIntensity = 1f;
		whiteIntensity = 1f;
		midGrey = 0.2f;
		intensities = new Vector3(1f, 1f, 1f);
		tiling = new Vector3(64f, 64f, 64f);
		monochromeTiling = 64f;
		filterMode = FilterMode.Bilinear;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false);
		noiseMaterial = CheckShaderAndCreateMaterial(noiseShader, noiseMaterial);
		if (dx11Grain && supportDX11)
		{
			dx11NoiseMaterial = CheckShaderAndCreateMaterial(dx11NoiseShader, dx11NoiseMaterial);
		}
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources() || null == noiseTexture)
		{
			Graphics.Blit(source, destination);
			if (null == noiseTexture)
			{
				Debug.LogWarning("Noise & Grain effect failing as noise texture is not assigned. please assign.", transform);
			}
			return;
		}
		softness = Mathf.Clamp(softness, 0f, 0.99f);
		if (dx11Grain && supportDX11)
		{
			dx11NoiseMaterial.SetFloat("_DX11NoiseTime", Time.frameCount);
			dx11NoiseMaterial.SetTexture("_NoiseTex", noiseTexture);
			dx11NoiseMaterial.SetVector("_NoisePerChannel", (!monochrome) ? intensities : Vector3.one);
			dx11NoiseMaterial.SetVector("_MidGrey", new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey));
			dx11NoiseMaterial.SetVector("_NoiseAmount", new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier);
			if (!(softness <= Mathf.Epsilon))
			{
				RenderTexture temporary = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
				DrawNoiseQuadGrid(source, temporary, dx11NoiseMaterial, noiseTexture, (!monochrome) ? 2 : 3);
				dx11NoiseMaterial.SetTexture("_NoiseTex", temporary);
				Graphics.Blit(source, destination, dx11NoiseMaterial, 4);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				DrawNoiseQuadGrid(source, destination, dx11NoiseMaterial, noiseTexture, monochrome ? 1 : 0);
			}
			return;
		}
		if ((bool)noiseTexture)
		{
			noiseTexture.wrapMode = TextureWrapMode.Repeat;
			noiseTexture.filterMode = filterMode;
		}
		noiseMaterial.SetTexture("_NoiseTex", noiseTexture);
		noiseMaterial.SetVector("_NoisePerChannel", (!monochrome) ? intensities : Vector3.one);
		noiseMaterial.SetVector("_NoiseTilingPerChannel", (!monochrome) ? tiling : (Vector3.one * monochromeTiling));
		noiseMaterial.SetVector("_MidGrey", new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey));
		noiseMaterial.SetVector("_NoiseAmount", new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier);
		if (!(softness <= Mathf.Epsilon))
		{
			RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
			DrawNoiseQuadGrid(source, temporary2, noiseMaterial, noiseTexture, 2);
			noiseMaterial.SetTexture("_NoiseTex", temporary2);
			Graphics.Blit(source, destination, noiseMaterial, 1);
			RenderTexture.ReleaseTemporary(temporary2);
		}
		else
		{
			DrawNoiseQuadGrid(source, destination, noiseMaterial, noiseTexture, 0);
		}
	}

	public static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
	{
		RenderTexture.active = dest;
		float num = (float)noise.width * 1f;
		float num2 = 1f * (float)source.width / TILE_AMOUNT;
		fxMaterial.SetTexture("_MainTex", source);
		GL.PushMatrix();
		GL.LoadOrtho();
		float num3 = 1f * (float)source.width / (1f * (float)source.height);
		float num4 = 1f / num2;
		float num5 = num4 * num3;
		float num6 = num / ((float)noise.width * 1f);
		fxMaterial.SetPass(passNr);
		GL.Begin(7);
		for (float num7 = 0f; num7 < 1f; num7 += num4)
		{
			for (float num8 = 0f; num8 < 1f; num8 += num5)
			{
				float num9 = UnityEngine.Random.Range(0f, 1f);
				float num10 = UnityEngine.Random.Range(0f, 1f);
				num9 = Mathf.Floor(num9 * num) / num;
				num10 = Mathf.Floor(num10 * num) / num;
				float num11 = 1f / num;
				GL.MultiTexCoord2(0, num9, num10);
				GL.MultiTexCoord2(1, 0f, 0f);
				GL.Vertex3(num7, num8, 0.1f);
				GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
				GL.MultiTexCoord2(1, 1f, 0f);
				GL.Vertex3(num7 + num4, num8, 0.1f);
				GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
				GL.MultiTexCoord2(1, 1f, 1f);
				GL.Vertex3(num7 + num4, num8 + num5, 0.1f);
				GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
				GL.MultiTexCoord2(1, 0f, 1f);
				GL.Vertex3(num7, num8 + num5, 0.1f);
			}
		}
		GL.End();
		GL.PopMatrix();
	}

	public override void Main()
	{
	}
}
[Serializable]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class PostEffectsBase : MonoBehaviour
{
	protected bool supportHDRTextures;

	protected bool supportDX11;

	protected bool isSupported;

	public PostEffectsBase()
	{
		supportHDRTextures = true;
		isSupported = true;
	}

	public virtual Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		object result;
		if (!s)
		{
			Debug.Log("Missing shader in " + ToString());
			enabled = false;
			result = null;
		}
		else if (s.isSupported && (bool)m2Create && m2Create.shader == s)
		{
			result = m2Create;
		}
		else if (!s.isSupported)
		{
			NotSupported();
			Debug.Log("The shader " + s.ToString() + " on effect " + ToString() + " is not supported on this platform!");
			result = null;
		}
		else
		{
			m2Create = new Material(s);
			m2Create.hideFlags = HideFlags.DontSave;
			result = ((!m2Create) ? null : m2Create);
		}
		return (Material)result;
	}

	public virtual Material CreateMaterial(Shader s, Material m2Create)
	{
		object result;
		if (!s)
		{
			Debug.Log("Missing shader in " + ToString());
			result = null;
		}
		else if ((bool)m2Create && m2Create.shader == s && s.isSupported)
		{
			result = m2Create;
		}
		else if (!s.isSupported)
		{
			result = null;
		}
		else
		{
			m2Create = new Material(s);
			m2Create.hideFlags = HideFlags.DontSave;
			result = ((!m2Create) ? null : m2Create);
		}
		return (Material)result;
	}

	public virtual void OnEnable()
	{
		isSupported = true;
	}

	public virtual bool CheckSupport()
	{
		return CheckSupport(needDepth: false);
	}

	public virtual bool CheckResources()
	{
		Debug.LogWarning("CheckResources () for " + ToString() + " should be overwritten.");
		return isSupported;
	}

	public virtual void Start()
	{
		CheckResources();
	}

	public virtual bool CheckSupport(bool needDepth)
	{
		isSupported = true;
		supportHDRTextures = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
		bool num = SystemInfo.graphicsShaderLevel >= 50;
		if (num)
		{
			num = SystemInfo.supportsComputeShaders;
		}
		supportDX11 = num;
		int result;
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
		{
			NotSupported();
			result = 0;
		}
		else if (needDepth && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			NotSupported();
			result = 0;
		}
		else
		{
			if (needDepth)
			{
				GetComponent<Camera>().depthTextureMode = GetComponent<Camera>().depthTextureMode | DepthTextureMode.Depth;
			}
			result = 1;
		}
		return (byte)result != 0;
	}

	public virtual bool CheckSupport(bool needDepth, bool needHdr)
	{
		int result;
		if (!CheckSupport(needDepth))
		{
			result = 0;
		}
		else if (needHdr && !supportHDRTextures)
		{
			NotSupported();
			result = 0;
		}
		else
		{
			result = 1;
		}
		return (byte)result != 0;
	}

	public virtual bool Dx11Support()
	{
		return supportDX11;
	}

	public virtual void ReportAutoDisable()
	{
		Debug.LogWarning("The image effect " + ToString() + " has been disabled as it's not supported on the current platform.");
	}

	public virtual bool CheckShader(Shader s)
	{
		Debug.Log("The shader " + s.ToString() + " on effect " + ToString() + " is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.");
		int result;
		if (!s.isSupported)
		{
			NotSupported();
			result = 0;
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	public virtual void NotSupported()
	{
		enabled = false;
		isSupported = false;
	}

	public virtual void DrawBorder(RenderTexture dest, Material material)
	{
		float num = default(float);
		float num2 = default(float);
		float num3 = default(float);
		float num4 = default(float);
		RenderTexture.active = dest;
		bool flag = true;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 0; i < material.passCount; i++)
		{
			material.SetPass(i);
			float num5 = default(float);
			float num6 = default(float);
			if (flag)
			{
				num5 = 1f;
				num6 = 0f;
			}
			else
			{
				num5 = 0f;
				num6 = 1f;
			}
			num = 0f;
			num2 = 0f + 1f / ((float)dest.width * 1f);
			num3 = 0f;
			num4 = 1f;
			GL.Begin(7);
			GL.TexCoord2(0f, num5);
			GL.Vertex3(num, num3, 0.1f);
			GL.TexCoord2(1f, num5);
			GL.Vertex3(num2, num3, 0.1f);
			GL.TexCoord2(1f, num6);
			GL.Vertex3(num2, num4, 0.1f);
			GL.TexCoord2(0f, num6);
			GL.Vertex3(num, num4, 0.1f);
			num = 1f - 1f / ((float)dest.width * 1f);
			num2 = 1f;
			num3 = 0f;
			num4 = 1f;
			GL.TexCoord2(0f, num5);
			GL.Vertex3(num, num3, 0.1f);
			GL.TexCoord2(1f, num5);
			GL.Vertex3(num2, num3, 0.1f);
			GL.TexCoord2(1f, num6);
			GL.Vertex3(num2, num4, 0.1f);
			GL.TexCoord2(0f, num6);
			GL.Vertex3(num, num4, 0.1f);
			num = 0f;
			num2 = 1f;
			num3 = 0f;
			num4 = 0f + 1f / ((float)dest.height * 1f);
			GL.TexCoord2(0f, num5);
			GL.Vertex3(num, num3, 0.1f);
			GL.TexCoord2(1f, num5);
			GL.Vertex3(num2, num3, 0.1f);
			GL.TexCoord2(1f, num6);
			GL.Vertex3(num2, num4, 0.1f);
			GL.TexCoord2(0f, num6);
			GL.Vertex3(num, num4, 0.1f);
			num = 0f;
			num2 = 1f;
			num3 = 1f - 1f / ((float)dest.height * 1f);
			num4 = 1f;
			GL.TexCoord2(0f, num5);
			GL.Vertex3(num, num3, 0.1f);
			GL.TexCoord2(1f, num5);
			GL.Vertex3(num2, num3, 0.1f);
			GL.TexCoord2(1f, num6);
			GL.Vertex3(num2, num4, 0.1f);
			GL.TexCoord2(0f, num6);
			GL.Vertex3(num, num4, 0.1f);
			GL.End();
		}
		GL.PopMatrix();
	}

	public virtual void Main()
	{
	}
}
[Serializable]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class PostEffectsHelper : MonoBehaviour
{
	public virtual void Start()
	{
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		Debug.Log("OnRenderImage in Helper called ...");
	}

	public static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
	{
		RenderTexture.active = dest;
		material.SetTexture("_MainTex", source);
		bool flag = true;
		GL.PushMatrix();
		GL.LoadIdentity();
		GL.LoadProjectionMatrix(cameraForProjectionMatrix.projectionMatrix);
		float f = cameraForProjectionMatrix.fieldOfView * 0.5f * ((float)Math.PI / 180f);
		float num = Mathf.Cos(f) / Mathf.Sin(f);
		float aspect = cameraForProjectionMatrix.aspect;
		float num2 = aspect / (0f - num);
		float num3 = aspect / num;
		float num4 = 1f / (0f - num);
		float num5 = 1f / num;
		float num6 = 1f;
		num2 *= dist * num6;
		num3 *= dist * num6;
		num4 *= dist * num6;
		num5 *= dist * num6;
		float z = 0f - dist;
		for (int i = 0; i < material.passCount; i++)
		{
			material.SetPass(i);
			GL.Begin(7);
			float num7 = default(float);
			float num8 = default(float);
			if (flag)
			{
				num7 = 1f;
				num8 = 0f;
			}
			else
			{
				num7 = 0f;
				num8 = 1f;
			}
			GL.TexCoord2(0f, num7);
			GL.Vertex3(num2, num4, z);
			GL.TexCoord2(1f, num7);
			GL.Vertex3(num3, num4, z);
			GL.TexCoord2(1f, num8);
			GL.Vertex3(num3, num5, z);
			GL.TexCoord2(0f, num8);
			GL.Vertex3(num2, num5, z);
			GL.End();
		}
		GL.PopMatrix();
	}

	public static void DrawBorder(RenderTexture dest, Material material)
	{
		float num = default(float);
		float num2 = default(float);
		float num3 = default(float);
		float num4 = default(float);
		RenderTexture.active = dest;
		bool flag = true;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 0; i < material.passCount; i++)
		{
			material.SetPass(i);
			float num5 = default(float);
			float num6 = default(float);
			if (flag)
			{
				num5 = 1f;
				num6 = 0f;
			}
			else
			{
				num5 = 0f;
				num6 = 1f;
			}
			num = 0f;
			num2 = 0f + 1f / ((float)dest.width * 1f);
			num3 = 0f;
			num4 = 1f;
			GL.Begin(7);
			GL.TexCoord2(0f, num5);
			GL.Vertex3(num, num3, 0.1f);
			GL.TexCoord2(1f, num5);
			GL.Vertex3(num2, num3, 0.1f);
			GL.TexCoord2(1f, num6);
			GL.Vertex3(num2, num4, 0.1f);
			GL.TexCoord2(0f, num6);
			GL.Vertex3(num, num4, 0.1f);
			num = 1f - 1f / ((float)dest.width * 1f);
			num2 = 1f;
			num3 = 0f;
			num4 = 1f;
			GL.TexCoord2(0f, num5);
			GL.Vertex3(num, num3, 0.1f);
			GL.TexCoord2(1f, num5);
			GL.Vertex3(num2, num3, 0.1f);
			GL.TexCoord2(1f, num6);
			GL.Vertex3(num2, num4, 0.1f);
			GL.TexCoord2(0f, num6);
			GL.Vertex3(num, num4, 0.1f);
			num = 0f;
			num2 = 1f;
			num3 = 0f;
			num4 = 0f + 1f / ((float)dest.height * 1f);
			GL.TexCoord2(0f, num5);
			GL.Vertex3(num, num3, 0.1f);
			GL.TexCoord2(1f, num5);
			GL.Vertex3(num2, num3, 0.1f);
			GL.TexCoord2(1f, num6);
			GL.Vertex3(num2, num4, 0.1f);
			GL.TexCoord2(0f, num6);
			GL.Vertex3(num, num4, 0.1f);
			num = 0f;
			num2 = 1f;
			num3 = 1f - 1f / ((float)dest.height * 1f);
			num4 = 1f;
			GL.TexCoord2(0f, num5);
			GL.Vertex3(num, num3, 0.1f);
			GL.TexCoord2(1f, num5);
			GL.Vertex3(num2, num3, 0.1f);
			GL.TexCoord2(1f, num6);
			GL.Vertex3(num2, num4, 0.1f);
			GL.TexCoord2(0f, num6);
			GL.Vertex3(num, num4, 0.1f);
			GL.End();
		}
		GL.PopMatrix();
	}

	public static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
	{
		RenderTexture.active = dest;
		material.SetTexture("_MainTex", source);
		bool flag = true;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 0; i < material.passCount; i++)
		{
			material.SetPass(i);
			GL.Begin(7);
			float num = default(float);
			float num2 = default(float);
			if (flag)
			{
				num = 1f;
				num2 = 0f;
			}
			else
			{
				num = 0f;
				num2 = 1f;
			}
			GL.TexCoord2(0f, num);
			GL.Vertex3(x1, y1, 0.1f);
			GL.TexCoord2(1f, num);
			GL.Vertex3(x2, y1, 0.1f);
			GL.TexCoord2(1f, num2);
			GL.Vertex3(x2, y2, 0.1f);
			GL.TexCoord2(0f, num2);
			GL.Vertex3(x1, y2, 0.1f);
			GL.End();
		}
		GL.PopMatrix();
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public class Quads : MonoBehaviour
{
	[NonSerialized]
	public static Mesh[] meshes;

	[NonSerialized]
	public static int currentQuads;

	public static bool HasMeshes()
	{
		int result;
		if (meshes == null)
		{
			result = 0;
		}
		else
		{
			int num = 0;
			Mesh[] array = meshes;
			int length = array.Length;
			while (true)
			{
				if (num < length)
				{
					if (null == array[num])
					{
						result = 0;
						break;
					}
					num++;
					continue;
				}
				result = 1;
				break;
			}
		}
		return (byte)result != 0;
	}

	public static void Cleanup()
	{
		if (meshes == null)
		{
			return;
		}
		int i = 0;
		Mesh[] array = meshes;
		for (int length = array.Length; i < length; i++)
		{
			if (null != array[i])
			{
				UnityEngine.Object.DestroyImmediate(array[i]);
				array[i] = null;
			}
		}
		meshes = null;
	}

	public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
	{
		Mesh[] result;
		if (HasMeshes() && currentQuads == totalWidth * totalHeight)
		{
			result = meshes;
		}
		else
		{
			int num = 10833;
			int num2 = (currentQuads = totalWidth * totalHeight);
			int num3 = Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num));
			meshes = new Mesh[num3];
			int num4 = 0;
			int num5 = 0;
			for (num4 = 0; num4 < num2; num4 += num)
			{
				int triCount = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
				meshes[num5] = GetMesh(triCount, num4, totalWidth, totalHeight);
				num5++;
			}
			result = meshes;
		}
		return result;
	}

	public static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSave;
		Vector3[] array = new Vector3[triCount * 4];
		Vector2[] array2 = new Vector2[triCount * 4];
		Vector2[] array3 = new Vector2[triCount * 4];
		int[] array4 = new int[triCount * 6];
		float num = 0.0075f;
		for (int i = 0; i < triCount; i++)
		{
			int num2 = i * 4;
			int num3 = i * 6;
			int num4 = triOffset + i;
			float num5 = Mathf.Floor(num4 % totalWidth) / (float)totalWidth;
			float num6 = Mathf.Floor(num4 / totalWidth) / (float)totalHeight;
			Vector3 vector = new Vector3(num5 * 2f - 1f, num6 * 2f - 1f, 1f);
			array[num2 + 0] = vector;
			array[num2 + 1] = vector;
			array[num2 + 2] = vector;
			array[num2 + 3] = vector;
			ref Vector2 reference = ref array2[num2 + 0];
			reference = new Vector2(0f, 0f);
			ref Vector2 reference2 = ref array2[num2 + 1];
			reference2 = new Vector2(1f, 0f);
			ref Vector2 reference3 = ref array2[num2 + 2];
			reference3 = new Vector2(0f, 1f);
			ref Vector2 reference4 = ref array2[num2 + 3];
			reference4 = new Vector2(1f, 1f);
			ref Vector2 reference5 = ref array3[num2 + 0];
			reference5 = new Vector2(num5, num6);
			ref Vector2 reference6 = ref array3[num2 + 1];
			reference6 = new Vector2(num5, num6);
			ref Vector2 reference7 = ref array3[num2 + 2];
			reference7 = new Vector2(num5, num6);
			ref Vector2 reference8 = ref array3[num2 + 3];
			reference8 = new Vector2(num5, num6);
			array4[num3 + 0] = num2 + 0;
			array4[num3 + 1] = num2 + 1;
			array4[num3 + 2] = num2 + 2;
			array4[num3 + 3] = num2 + 1;
			array4[num3 + 4] = num2 + 2;
			array4[num3 + 5] = num2 + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public virtual void Main()
	{
	}
}
[Serializable]
[AddComponentMenu("Image Effects/Screen Overlay")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class ScreenOverlay : PostEffectsBase
{
	[Serializable]
	public enum OverlayBlendMode
	{
		Additive,
		ScreenBlend,
		Multiply,
		Overlay,
		AlphaBlend
	}

	public OverlayBlendMode blendMode;

	public float intensity;

	public Texture2D texture;

	public Shader overlayShader;

	private Material overlayMaterial;

	public ScreenOverlay()
	{
		blendMode = OverlayBlendMode.Overlay;
		intensity = 1f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false);
		overlayMaterial = CheckShaderAndCreateMaterial(overlayShader, overlayMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		overlayMaterial.SetFloat("_Intensity", intensity);
		overlayMaterial.SetTexture("_Overlay", texture);
		Graphics.Blit(source, destination, overlayMaterial, (int)blendMode);
	}

	public override void Main()
	{
	}
}
[Serializable]
public enum SunShaftsResolution
{
	Low,
	Normal,
	High
}
[Serializable]
public enum ShaftsScreenBlendMode
{
	Screen,
	Add
}
[Serializable]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Sun Shafts")]
[ExecuteInEditMode]
public class SunShafts : PostEffectsBase
{
	public SunShaftsResolution resolution;

	public ShaftsScreenBlendMode screenBlendMode;

	public Transform sunTransform;

	public int radialBlurIterations;

	public Color sunColor;

	public float sunShaftBlurRadius;

	public float sunShaftIntensity;

	public float useSkyBoxAlpha;

	public float maxRadius;

	public bool useDepthTexture;

	public Shader sunShaftsShader;

	private Material sunShaftsMaterial;

	public Shader simpleClearShader;

	private Material simpleClearMaterial;

	public SunShafts()
	{
		resolution = SunShaftsResolution.Normal;
		screenBlendMode = ShaftsScreenBlendMode.Screen;
		radialBlurIterations = 2;
		sunColor = Color.white;
		sunShaftBlurRadius = 2.5f;
		sunShaftIntensity = 1.15f;
		useSkyBoxAlpha = 0.75f;
		maxRadius = 0.75f;
		useDepthTexture = true;
	}

	public override bool CheckResources()
	{
		CheckSupport(useDepthTexture);
		sunShaftsMaterial = CheckShaderAndCreateMaterial(sunShaftsShader, sunShaftsMaterial);
		simpleClearMaterial = CheckShaderAndCreateMaterial(simpleClearShader, simpleClearMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		if (useDepthTexture)
		{
			GetComponent<Camera>().depthTextureMode = GetComponent<Camera>().depthTextureMode | DepthTextureMode.Depth;
		}
		float num = 4f;
		if (resolution == SunShaftsResolution.Normal)
		{
			num = 2f;
		}
		else if (resolution == SunShaftsResolution.High)
		{
			num = 1f;
		}
		Vector3 vector = Vector3.one * 0.5f;
		vector = ((!sunTransform) ? new Vector3(0.5f, 0.5f, 0f) : GetComponent<Camera>().WorldToViewportPoint(sunTransform.position));
		RenderTexture temporary = RenderTexture.GetTemporary((int)((float)source.width / num), (int)((float)source.height / num), 0);
		RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)source.width / num), (int)((float)source.height / num), 0);
		sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(1f, 1f, 0f, 0f) * sunShaftBlurRadius);
		sunShaftsMaterial.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, maxRadius));
		sunShaftsMaterial.SetFloat("_NoSkyBoxMask", 1f - useSkyBoxAlpha);
		if (!useDepthTexture)
		{
			RenderTexture renderTexture = (RenderTexture.active = RenderTexture.GetTemporary(source.width, source.height, 0));
			GL.ClearWithSkybox(clearDepth: false, GetComponent<Camera>());
			sunShaftsMaterial.SetTexture("_Skybox", renderTexture);
			Graphics.Blit(source, temporary2, sunShaftsMaterial, 3);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
		else
		{
			Graphics.Blit(source, temporary2, sunShaftsMaterial, 2);
		}
		DrawBorder(temporary2, simpleClearMaterial);
		radialBlurIterations = ClampBlurIterationsToSomethingThatMakesSense(radialBlurIterations);
		float num2 = sunShaftBlurRadius * 0.0013020834f;
		sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
		sunShaftsMaterial.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, maxRadius));
		for (int i = 0; i < radialBlurIterations; i++)
		{
			Graphics.Blit(temporary2, temporary, sunShaftsMaterial, 1);
			num2 = sunShaftBlurRadius * (((float)i * 2f + 1f) * 6f) / 768f;
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			Graphics.Blit(temporary, temporary2, sunShaftsMaterial, 1);
			num2 = sunShaftBlurRadius * (((float)i * 2f + 2f) * 6f) / 768f;
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
		}
		if (!(vector.z < 0f))
		{
			sunShaftsMaterial.SetVector("_SunColor", new Vector4(sunColor.r, sunColor.g, sunColor.b, sunColor.a) * sunShaftIntensity);
		}
		else
		{
			sunShaftsMaterial.SetVector("_SunColor", Vector4.zero);
		}
		sunShaftsMaterial.SetTexture("_ColorBuffer", temporary2);
		Graphics.Blit(source, destination, sunShaftsMaterial, (screenBlendMode != 0) ? 4 : 0);
		RenderTexture.ReleaseTemporary(temporary2);
		RenderTexture.ReleaseTemporary(temporary);
	}

	private int ClampBlurIterationsToSomethingThatMakesSense(int its)
	{
		return (its < 1) ? 1 : ((its <= 4) ? its : 4);
	}

	public override void Main()
	{
	}
}
[Serializable]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Tilt shift")]
[ExecuteInEditMode]
public class TiltShift : PostEffectsBase
{
	public Shader tiltShiftShader;

	private Material tiltShiftMaterial;

	public int renderTextureDivider;

	public int blurIterations;

	public bool enableForegroundBlur;

	public int foregroundBlurIterations;

	public float maxBlurSpread;

	public float focalPoint;

	public float smoothness;

	public bool visualizeCoc;

	private float start01;

	private float distance01;

	private float end01;

	private float curve;

	public TiltShift()
	{
		renderTextureDivider = 2;
		blurIterations = 2;
		enableForegroundBlur = true;
		foregroundBlurIterations = 2;
		maxBlurSpread = 1.5f;
		focalPoint = 30f;
		smoothness = 1.65f;
		distance01 = 0.2f;
		end01 = 1f;
		curve = 1f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: true);
		tiltShiftMaterial = CheckShaderAndCreateMaterial(tiltShiftShader, tiltShiftMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		float num = 1f * (float)source.width / (1f * (float)source.height);
		float num2 = 0.001953125f;
		renderTextureDivider = ((renderTextureDivider < 1) ? 1 : renderTextureDivider);
		renderTextureDivider = ((renderTextureDivider <= 4) ? renderTextureDivider : 4);
		blurIterations = ((blurIterations >= 1) ? blurIterations : 0);
		blurIterations = ((blurIterations <= 4) ? blurIterations : 4);
		float num3 = (distance01 = GetComponent<Camera>().WorldToViewportPoint(focalPoint * GetComponent<Camera>().transform.forward + GetComponent<Camera>().transform.position).z / GetComponent<Camera>().farClipPlane);
		start01 = 0f;
		end01 = 1f;
		start01 = Mathf.Min(num3 - Mathf.Epsilon, start01);
		end01 = Mathf.Max(num3 + Mathf.Epsilon, end01);
		curve = smoothness * distance01;
		RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0);
		RenderTexture temporary2 = RenderTexture.GetTemporary(source.width, source.height, 0);
		RenderTexture temporary3 = RenderTexture.GetTemporary(source.width / renderTextureDivider, source.height / renderTextureDivider, 0);
		RenderTexture temporary4 = RenderTexture.GetTemporary(source.width / renderTextureDivider, source.height / renderTextureDivider, 0);
		tiltShiftMaterial.SetVector("_SimpleDofParams", new Vector4(start01, distance01, end01, curve));
		tiltShiftMaterial.SetTexture("_Coc", temporary);
		if (enableForegroundBlur)
		{
			Graphics.Blit(source, temporary, tiltShiftMaterial, 0);
			Graphics.Blit(temporary, temporary3);
			for (int i = 0; i < foregroundBlurIterations; i++)
			{
				tiltShiftMaterial.SetVector("offsets", new Vector4(0f, maxBlurSpread * 0.75f * num2, 0f, 0f));
				Graphics.Blit(temporary3, temporary4, tiltShiftMaterial, 3);
				tiltShiftMaterial.SetVector("offsets", new Vector4(maxBlurSpread * 0.75f / num * num2, 0f, 0f, 0f));
				Graphics.Blit(temporary4, temporary3, tiltShiftMaterial, 3);
			}
			Graphics.Blit(temporary3, temporary2, tiltShiftMaterial, 7);
			tiltShiftMaterial.SetTexture("_Coc", temporary2);
		}
		else
		{
			RenderTexture.active = temporary;
			GL.Clear(clearDepth: false, clearColor: true, Color.black);
		}
		Graphics.Blit(source, temporary, tiltShiftMaterial, 5);
		tiltShiftMaterial.SetTexture("_Coc", temporary);
		Graphics.Blit(source, temporary4);
		for (int j = 0; j < blurIterations; j++)
		{
			tiltShiftMaterial.SetVector("offsets", new Vector4(0f, maxBlurSpread * 1f * num2, 0f, 0f));
			Graphics.Blit(temporary4, temporary3, tiltShiftMaterial, 6);
			tiltShiftMaterial.SetVector("offsets", new Vector4(maxBlurSpread * 1f / num * num2, 0f, 0f, 0f));
			Graphics.Blit(temporary3, temporary4, tiltShiftMaterial, 6);
		}
		tiltShiftMaterial.SetTexture("_Blurred", temporary4);
		Graphics.Blit(source, destination, tiltShiftMaterial, (!visualizeCoc) ? 1 : 4);
		RenderTexture.ReleaseTemporary(temporary);
		RenderTexture.ReleaseTemporary(temporary2);
		RenderTexture.ReleaseTemporary(temporary3);
		RenderTexture.ReleaseTemporary(temporary4);
	}

	public override void Main()
	{
	}
}
[Serializable]
[AddComponentMenu("Image Effects/Tonemapping")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class Tonemapping : PostEffectsBase
{
	[Serializable]
	public enum TonemapperType
	{
		SimpleReinhard,
		UserCurve,
		Hable,
		Photographic,
		OptimizedHejiDawson,
		AdaptiveReinhard,
		AdaptiveReinhardAutoWhite
	}

	[Serializable]
	public enum AdaptiveTexSize
	{
		Square16 = 0x10,
		Square32 = 0x20,
		Square64 = 0x40,
		Square128 = 0x80,
		Square256 = 0x100,
		Square512 = 0x200,
		Square1024 = 0x400
	}

	public TonemapperType type;

	public AdaptiveTexSize adaptiveTextureSize;

	public AnimationCurve remapCurve;

	private Texture2D curveTex;

	public float exposureAdjustment;

	public float middleGrey;

	public float white;

	public float adaptionSpeed;

	public Shader tonemapper;

	public bool validRenderTextureFormat;

	private Material tonemapMaterial;

	private RenderTexture rt;

	private RenderTextureFormat rtFormat;

	public Tonemapping()
	{
		type = TonemapperType.Photographic;
		adaptiveTextureSize = AdaptiveTexSize.Square256;
		exposureAdjustment = 1.5f;
		middleGrey = 0.4f;
		white = 2f;
		adaptionSpeed = 1.5f;
		validRenderTextureFormat = true;
		rtFormat = RenderTextureFormat.ARGBHalf;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false, needHdr: true);
		tonemapMaterial = CheckShaderAndCreateMaterial(tonemapper, tonemapMaterial);
		if (!curveTex && type == TonemapperType.UserCurve)
		{
			curveTex = new Texture2D(256, 1, TextureFormat.ARGB32, mipmap: false, linear: true);
			curveTex.filterMode = FilterMode.Bilinear;
			curveTex.wrapMode = TextureWrapMode.Clamp;
			curveTex.hideFlags = HideFlags.DontSave;
		}
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual float UpdateCurve()
	{
		float num = 1f;
		if (Extensions.get_length((Array)remapCurve.keys) < 1)
		{
			remapCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(2f, 1f));
		}
		if (remapCurve != null)
		{
			if (remapCurve.length != 0)
			{
				num = remapCurve[remapCurve.length - 1].time;
			}
			for (float num2 = 0f; num2 <= 1f; num2 += 0.003921569f)
			{
				float num3 = remapCurve.Evaluate(num2 * 1f * num);
				curveTex.SetPixel((int)Mathf.Floor(num2 * 255f), 0, new Color(num3, num3, num3));
			}
			curveTex.Apply();
		}
		return 1f / num;
	}

	public virtual void OnDisable()
	{
		if ((bool)rt)
		{
			UnityEngine.Object.DestroyImmediate(rt);
			rt = null;
		}
		if ((bool)tonemapMaterial)
		{
			UnityEngine.Object.DestroyImmediate(tonemapMaterial);
			tonemapMaterial = null;
		}
		if ((bool)curveTex)
		{
			UnityEngine.Object.DestroyImmediate(curveTex);
			curveTex = null;
		}
	}

	public virtual bool CreateInternalRenderTexture()
	{
		int result;
		if ((bool)rt)
		{
			result = 0;
		}
		else
		{
			rtFormat = ((!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf)) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.RGHalf);
			rt = new RenderTexture(1, 1, 0, rtFormat);
			rt.hideFlags = HideFlags.DontSave;
			result = 1;
		}
		return (byte)result != 0;
	}

	[ImageEffectTransformsToLDR]
	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		exposureAdjustment = ((exposureAdjustment >= 0.001f) ? exposureAdjustment : 0.001f);
		if (type == TonemapperType.UserCurve)
		{
			float value = UpdateCurve();
			tonemapMaterial.SetFloat("_RangeScale", value);
			tonemapMaterial.SetTexture("_Curve", curveTex);
			Graphics.Blit(source, destination, tonemapMaterial, 4);
			return;
		}
		if (type == TonemapperType.SimpleReinhard)
		{
			tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
			Graphics.Blit(source, destination, tonemapMaterial, 6);
			return;
		}
		if (type == TonemapperType.Hable)
		{
			tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
			Graphics.Blit(source, destination, tonemapMaterial, 5);
			return;
		}
		if (type == TonemapperType.Photographic)
		{
			tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
			Graphics.Blit(source, destination, tonemapMaterial, 8);
			return;
		}
		if (type == TonemapperType.OptimizedHejiDawson)
		{
			tonemapMaterial.SetFloat("_ExposureAdjustment", 0.5f * exposureAdjustment);
			Graphics.Blit(source, destination, tonemapMaterial, 7);
			return;
		}
		bool flag = CreateInternalRenderTexture();
		RenderTexture temporary = RenderTexture.GetTemporary((int)adaptiveTextureSize, (int)adaptiveTextureSize, 0, rtFormat);
		Graphics.Blit(source, temporary);
		int num = (int)Mathf.Log((float)temporary.width * 1f, 2f);
		int num2 = 2;
		RenderTexture[] array = new RenderTexture[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, rtFormat);
			num2 *= 2;
		}
		float num3 = (float)source.width * 1f / ((float)source.height * 1f);
		RenderTexture source2 = array[num - 1];
		Graphics.Blit(temporary, array[0], tonemapMaterial, 1);
		if (type == TonemapperType.AdaptiveReinhardAutoWhite)
		{
			for (int i = 0; i < num - 1; i++)
			{
				Graphics.Blit(array[i], array[i + 1], tonemapMaterial, 9);
				source2 = array[i + 1];
			}
		}
		else if (type == TonemapperType.AdaptiveReinhard)
		{
			for (int i = 0; i < num - 1; i++)
			{
				Graphics.Blit(array[i], array[i + 1]);
				source2 = array[i + 1];
			}
		}
		adaptionSpeed = ((adaptionSpeed >= 0.001f) ? adaptionSpeed : 0.001f);
		tonemapMaterial.SetFloat("_AdaptionSpeed", adaptionSpeed);
		Graphics.Blit(source2, rt, tonemapMaterial, (!flag) ? 2 : 3);
		middleGrey = ((middleGrey >= 0.001f) ? middleGrey : 0.001f);
		tonemapMaterial.SetVector("_HdrParams", new Vector4(middleGrey, middleGrey, middleGrey, white * white));
		tonemapMaterial.SetTexture("_SmallTex", rt);
		if (type == TonemapperType.AdaptiveReinhard)
		{
			Graphics.Blit(source, destination, tonemapMaterial, 0);
		}
		else if (type == TonemapperType.AdaptiveReinhardAutoWhite)
		{
			Graphics.Blit(source, destination, tonemapMaterial, 10);
		}
		else
		{
			Debug.LogError("No valid adaptive tonemapper type found!");
			Graphics.Blit(source, destination);
		}
		for (int i = 0; i < num; i++)
		{
			RenderTexture.ReleaseTemporary(array[i]);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	public override void Main()
	{
	}
}
[Serializable]
public class Triangles : MonoBehaviour
{
	[NonSerialized]
	public static Mesh[] meshes;

	[NonSerialized]
	public static int currentTris;

	public static bool HasMeshes()
	{
		int result;
		if (meshes == null)
		{
			result = 0;
		}
		else
		{
			int num = 0;
			Mesh[] array = meshes;
			int length = array.Length;
			while (true)
			{
				if (num < length)
				{
					if (null == array[num])
					{
						result = 0;
						break;
					}
					num++;
					continue;
				}
				result = 1;
				break;
			}
		}
		return (byte)result != 0;
	}

	public static void Cleanup()
	{
		if (meshes == null)
		{
			return;
		}
		int i = 0;
		Mesh[] array = meshes;
		for (int length = array.Length; i < length; i++)
		{
			if (null != array[i])
			{
				UnityEngine.Object.DestroyImmediate(array[i]);
				array[i] = null;
			}
		}
		meshes = null;
	}

	public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
	{
		Mesh[] result;
		if (HasMeshes() && currentTris == totalWidth * totalHeight)
		{
			result = meshes;
		}
		else
		{
			int num = 21666;
			int num2 = (currentTris = totalWidth * totalHeight);
			int num3 = Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num));
			meshes = new Mesh[num3];
			int num4 = 0;
			int num5 = 0;
			for (num4 = 0; num4 < num2; num4 += num)
			{
				int triCount = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
				meshes[num5] = GetMesh(triCount, num4, totalWidth, totalHeight);
				num5++;
			}
			result = meshes;
		}
		return result;
	}

	public static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSave;
		Vector3[] array = new Vector3[triCount * 3];
		Vector2[] array2 = new Vector2[triCount * 3];
		Vector2[] array3 = new Vector2[triCount * 3];
		int[] array4 = new int[triCount * 3];
		float num = 0.0075f;
		for (int i = 0; i < triCount; i++)
		{
			int num2 = i * 3;
			int num3 = triOffset + i;
			float num4 = Mathf.Floor(num3 % totalWidth) / (float)totalWidth;
			float num5 = Mathf.Floor(num3 / totalWidth) / (float)totalHeight;
			Vector3 vector = new Vector3(num4 * 2f - 1f, num5 * 2f - 1f, 1f);
			array[num2 + 0] = vector;
			array[num2 + 1] = vector;
			array[num2 + 2] = vector;
			ref Vector2 reference = ref array2[num2 + 0];
			reference = new Vector2(0f, 0f);
			ref Vector2 reference2 = ref array2[num2 + 1];
			reference2 = new Vector2(1f, 0f);
			ref Vector2 reference3 = ref array2[num2 + 2];
			reference3 = new Vector2(0f, 1f);
			ref Vector2 reference4 = ref array3[num2 + 0];
			reference4 = new Vector2(num4, num5);
			ref Vector2 reference5 = ref array3[num2 + 1];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num2 + 2];
			reference6 = new Vector2(num4, num5);
			array4[num2 + 0] = num2 + 0;
			array4[num2 + 1] = num2 + 1;
			array4[num2 + 2] = num2 + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public virtual void Main()
	{
	}
}
[Serializable]
[AddComponentMenu("Image Effects/Vignette and Chromatic Aberration")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class Vignetting : PostEffectsBase
{
	[Serializable]
	public enum AberrationMode
	{
		Simple,
		Advanced
	}

	public AberrationMode mode;

	public float intensity;

	public float chromaticAberration;

	public float axialAberration;

	public float blur;

	public float blurSpread;

	public float luminanceDependency;

	public Shader vignetteShader;

	private Material vignetteMaterial;

	public Shader separableBlurShader;

	private Material separableBlurMaterial;

	public Shader chromAberrationShader;

	private Material chromAberrationMaterial;

	public Vignetting()
	{
		mode = AberrationMode.Simple;
		intensity = 0.375f;
		chromaticAberration = 0.2f;
		axialAberration = 0.5f;
		blurSpread = 0.75f;
		luminanceDependency = 0.25f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false);
		vignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, vignetteMaterial);
		separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
		chromAberrationMaterial = CheckShaderAndCreateMaterial(chromAberrationShader, chromAberrationMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		bool num = Mathf.Abs(blur) > 0f;
		if (!num)
		{
			num = Mathf.Abs(intensity) > 0f;
		}
		bool flag = num;
		float num2 = 1f * (float)source.width / (1f * (float)source.height);
		float num3 = 0.001953125f;
		RenderTexture renderTexture = null;
		RenderTexture renderTexture2 = null;
		RenderTexture renderTexture3 = null;
		if (flag)
		{
			renderTexture = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
			if (!(Mathf.Abs(blur) <= 0f))
			{
				renderTexture2 = RenderTexture.GetTemporary((int)((float)source.width / 2f), (int)((float)source.height / 2f), 0, source.format);
				renderTexture3 = RenderTexture.GetTemporary((int)((float)source.width / 2f), (int)((float)source.height / 2f), 0, source.format);
				Graphics.Blit(source, renderTexture2, chromAberrationMaterial, 0);
				for (int i = 0; i < 2; i++)
				{
					separableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * num3, 0f, 0f));
					Graphics.Blit(renderTexture2, renderTexture3, separableBlurMaterial);
					separableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * num3 / num2, 0f, 0f, 0f));
					Graphics.Blit(renderTexture3, renderTexture2, separableBlurMaterial);
				}
			}
			vignetteMaterial.SetFloat("_Intensity", intensity);
			vignetteMaterial.SetFloat("_Blur", blur);
			vignetteMaterial.SetTexture("_VignetteTex", renderTexture2);
			Graphics.Blit(source, renderTexture, vignetteMaterial, 0);
		}
		chromAberrationMaterial.SetFloat("_ChromaticAberration", chromaticAberration);
		chromAberrationMaterial.SetFloat("_AxialAberration", axialAberration);
		chromAberrationMaterial.SetFloat("_Luminance", 1f / (Mathf.Epsilon + luminanceDependency));
		if (flag)
		{
			renderTexture.wrapMode = TextureWrapMode.Clamp;
		}
		else
		{
			source.wrapMode = TextureWrapMode.Clamp;
		}
		Graphics.Blit((!flag) ? source : renderTexture, destination, chromAberrationMaterial, (mode != AberrationMode.Advanced) ? 1 : 2);
		if ((bool)renderTexture)
		{
			RenderTexture.ReleaseTemporary(renderTexture);
		}
		if ((bool)renderTexture2)
		{
			RenderTexture.ReleaseTemporary(renderTexture2);
		}
		if ((bool)renderTexture3)
		{
			RenderTexture.ReleaseTemporary(renderTexture3);
		}
	}

	public override void Main()
	{
	}
}
[Serializable]
public class TimedObjectDestructor : MonoBehaviour
{
	public float timeOut;

	public bool detachChildren;

	public TimedObjectDestructor()
	{
		timeOut = 1f;
	}

	public virtual void Awake()
	{
		Invoke("DestroyNow", timeOut);
	}

	public virtual void DestroyNow()
	{
		if (detachChildren)
		{
			transform.DetachChildren();
		}
		UnityEngine.Object.DestroyObject(gameObject);
	}

	public virtual void Main()
	{
	}
}
[Serializable]
[AddComponentMenu("Camera-Control/Mouse Orbit")]
public class MouseOrbit : MonoBehaviour
{
	public Transform target;

	public float distance;

	public float xSpeed;

	public float ySpeed;

	public int yMinLimit;

	public int yMaxLimit;

	private float x;

	private float y;

	public MouseOrbit()
	{
		distance = 10f;
		xSpeed = 250f;
		ySpeed = 120f;
		yMinLimit = -20;
		yMaxLimit = 80;
	}

	public virtual void Start()
	{
		Vector3 eulerAngles = transform.eulerAngles;
		x = eulerAngles.y;
		y = eulerAngles.x;
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	public virtual void LateUpdate()
	{
		if ((bool)target)
		{
			x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
			y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
			y = ClampAngle(y, yMinLimit, yMaxLimit);
			Quaternion quaternion = Quaternion.Euler(y, x, 0f);
			Vector3 position = quaternion * new Vector3(0f, 0f, 0f - distance) + target.position;
			transform.rotation = quaternion;
			transform.position = position;
		}
	}

	public static float ClampAngle(float angle, float min, float max)
	{
		if (!(angle >= -360f))
		{
			angle += 360f;
		}
		if (!(angle <= 360f))
		{
			angle -= 360f;
		}
		return Mathf.Clamp(angle, min, max);
	}

	public virtual void Main()
	{
	}
}
[Serializable]
[AddComponentMenu("Camera-Control/Smooth Follow")]
public class SmoothFollow : MonoBehaviour
{
	public Transform target;

	public float distance;

	public float height;

	public float heightDamping;

	public float rotationDamping;

	public SmoothFollow()
	{
		distance = 10f;
		height = 5f;
		heightDamping = 2f;
		rotationDamping = 3f;
	}

	public virtual void LateUpdate()
	{
		if ((bool)target)
		{
			float y = target.eulerAngles.y;
			float b = target.position.y + height;
			float y2 = transform.eulerAngles.y;
			float y3 = transform.position.y;
			y2 = Mathf.LerpAngle(y2, y, rotationDamping * Time.deltaTime);
			y3 = Mathf.Lerp(y3, b, heightDamping * Time.deltaTime);
			Quaternion quaternion = Quaternion.Euler(0f, y2, 0f);
			transform.position = target.position;
			transform.position -= quaternion * Vector3.forward * distance;
			float y4 = y3;
			Vector3 position = transform.position;
			float num = (position.y = y4);
			Vector3 vector2 = (transform.position = position);
			transform.LookAt(target);
		}
	}

	public virtual void Main()
	{
	}
}
[Serializable]
[AddComponentMenu("Camera-Control/Smooth Look At")]
public class SmoothLookAt : MonoBehaviour
{
	public Transform target;

	public float damping;

	public bool smooth;

	public SmoothLookAt()
	{
		damping = 6f;
		smooth = true;
	}

	public virtual void LateUpdate()
	{
		if ((bool)target)
		{
			if (smooth)
			{
				Quaternion b = Quaternion.LookRotation(target.position - transform.position);
				transform.rotation = Quaternion.Slerp(transform.rotation, b, Time.deltaTime * damping);
			}
			else
			{
				transform.LookAt(target);
			}
		}
	}

	public virtual void Start()
	{
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public class DragRigidbody : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class $DragObject$64 : GenericGenerator<object>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			internal float $oldDrag$65;

			internal float $oldAngularDrag$66;

			internal Camera $mainCamera$67;

			internal Ray $ray$68;

			internal float $distance$69;

			internal DragRigidbody $self_$70;

			public $(float distance, DragRigidbody self_)
			{
				$distance$69 = distance;
				$self_$70 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					$oldDrag$65 = $self_$70.springJoint.connectedBody.drag;
					$oldAngularDrag$66 = $self_$70.springJoint.connectedBody.angularDrag;
					$self_$70.springJoint.connectedBody.drag = $self_$70.drag;
					$self_$70.springJoint.connectedBody.angularDrag = $self_$70.angularDrag;
					$mainCamera$67 = $self_$70.FindCamera();
					goto case 2;
				case 2:
					if (Input.GetMouseButton(0))
					{
						$ray$68 = $mainCamera$67.ScreenPointToRay(Input.mousePosition);
						$self_$70.springJoint.transform.position = $ray$68.GetPoint($distance$69);
						result = (YieldDefault(2) ? 1 : 0);
						break;
					}
					if ((bool)$self_$70.springJoint.connectedBody)
					{
						$self_$70.springJoint.connectedBody.drag = $oldDrag$65;
						$self_$70.springJoint.connectedBody.angularDrag = $oldAngularDrag$66;
						$self_$70.springJoint.connectedBody = null;
					}
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal float $distance$71;

		internal DragRigidbody $self_$72;

		public $DragObject$64(float distance, DragRigidbody self_)
		{
			$distance$71 = distance;
			$self_$72 = self_;
		}

		public override IEnumerator<object> GetEnumerator()
		{
			return new $($distance$71, $self_$72);
		}
	}

	public float spring;

	public float damper;

	public float drag;

	public float angularDrag;

	public float distance;

	public bool attachToCenterOfMass;

	private SpringJoint springJoint;

	public DragRigidbody()
	{
		spring = 50f;
		damper = 5f;
		drag = 10f;
		angularDrag = 5f;
		distance = 0.2f;
	}

	public virtual void Update()
	{
		if (!Input.GetMouseButtonDown(0))
		{
			return;
		}
		Camera camera = FindCamera();
		RaycastHit hitInfo = default(RaycastHit);
		if (Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out hitInfo, 100f) && (bool)hitInfo.rigidbody && !hitInfo.rigidbody.isKinematic)
		{
			if (!springJoint)
			{
				GameObject gameObject = new GameObject("Rigidbody dragger");
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>() as Rigidbody;
				springJoint = gameObject.AddComponent<SpringJoint>();
				rigidbody.isKinematic = true;
			}
			springJoint.transform.position = hitInfo.point;
			if (attachToCenterOfMass)
			{
				Vector3 position = transform.TransformDirection(hitInfo.rigidbody.centerOfMass) + hitInfo.rigidbody.transform.position;
				position = springJoint.transform.InverseTransformPoint(position);
				springJoint.anchor = position;
			}
			else
			{
				springJoint.anchor = Vector3.zero;
			}
			springJoint.spring = spring;
			springJoint.damper = damper;
			springJoint.maxDistance = distance;
			springJoint.connectedBody = hitInfo.rigidbody;
			StartCoroutine("DragObject", hitInfo.distance);
		}
	}

	public virtual IEnumerator DragObject(float distance)
	{
		return new $DragObject$64(distance, this).GetEnumerator();
	}

	public virtual Camera FindCamera()
	{
		return (!GetComponent<Camera>()) ? Camera.main : GetComponent<Camera>();
	}

	public virtual void Main()
	{
	}
}
