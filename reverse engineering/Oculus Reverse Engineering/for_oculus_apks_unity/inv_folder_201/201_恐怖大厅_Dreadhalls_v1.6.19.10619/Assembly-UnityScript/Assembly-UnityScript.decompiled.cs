using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations)]
[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
public class AnimatedTextureUV : MonoBehaviour
{
	public int uvAnimationTileX;

	public int uvAnimationTileY;

	public float framesPerSecond;

	public AnimatedTextureUV()
	{
		uvAnimationTileX = 5;
		uvAnimationTileY = 12;
		framesPerSecond = 10f;
	}

	public virtual void Update()
	{
		int num = (int)(Time.time * framesPerSecond);
		num %= uvAnimationTileX * uvAnimationTileY;
		Vector2 value = new Vector2(1f / (float)uvAnimationTileX, 1f / (float)uvAnimationTileY);
		int num2 = num % uvAnimationTileX;
		int num3 = num / uvAnimationTileX;
		Vector2 value2 = new Vector2((float)num2 * value.x, 1f - value.y - (float)num3 * value.y);
		GetComponent<Renderer>().material.SetTextureOffset("_MainTex", value2);
		GetComponent<Renderer>().material.SetTextureScale("_MainTex", value);
	}

	public virtual void Main()
	{
	}
}
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
	internal sealed class $SubtractNewPlatformVelocity$12 : GenericGenerator<object>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			internal Transform $platform$13;

			internal CharacterMotor $self_$14;

			public $(CharacterMotor self_)
			{
				$self_$14 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if ($self_$14.movingPlatform.enabled && ($self_$14.movingPlatform.movementTransfer == MovementTransferOnJump.InitTransfer || $self_$14.movingPlatform.movementTransfer == MovementTransferOnJump.PermaTransfer))
					{
						if ($self_$14.movingPlatform.newPlatform)
						{
							$platform$13 = $self_$14.movingPlatform.activePlatform;
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
					if ($self_$14.grounded && $platform$13 == $self_$14.movingPlatform.activePlatform)
					{
						result = (Yield(4, 1) ? 1 : 0);
						break;
					}
					goto case 4;
				case 4:
					$self_$14.movement.velocity = $self_$14.movement.velocity - $self_$14.movingPlatform.platformVelocity;
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

		internal CharacterMotor $self_$15;

		public $SubtractNewPlatformVelocity$12(CharacterMotor self_)
		{
			$self_$15 = self_;
		}

		public override IEnumerator<object> GetEnumerator()
		{
			return new $($self_$15);
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
		return new $SubtractNewPlatformVelocity$12(this).GetEnumerator();
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
[RequireComponent(typeof(CharacterMotor))]
[AddComponentMenu("Character/Platform Input Controller")]
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
public class ClickToPlay : MonoBehaviour
{
	public virtual void OnMouseDown()
	{
		GetComponent<AudioSource>().Play();
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public class DemoUI : MonoBehaviour
{
	private string[] choices;

	public Response choice;

	public GameObject[] characters;

	public DemoUI()
	{
		choices = new string[5] { "Very Fast", "Fast", "Normal", "Slow", "Very Slow" };
		choice = Response.Normal;
	}

	public virtual void OnGUI()
	{
		GUI.Label(new Rect(30f, 5f, 100f, 100f), "Responsiveness");
		Response response = choice;
		choice = (Response)GUI.SelectionGrid(new Rect(25f, 25f, 100f, 100f), (int)choice, choices, 1);
		if (choice != response)
		{
			int i = 0;
			GameObject[] array = characters;
			for (int length = array.Length; i < length; i++)
			{
				array[i].BroadcastMessage("SetResponse", choice);
			}
		}
	}

	public virtual void Main()
	{
	}
}
[Serializable]
[RequireComponent(typeof(SimpleSyncVolume))]
public class SimpleSyncMove : MonoBehaviour
{
	public Transform mouth;

	public float motionScale;

	public Vector3 rangeMinimum;

	public Vector3 rangeMaximum;

	private SimpleSyncVolume ssVolume;

	public SimpleSyncMove()
	{
		motionScale = 10f;
		rangeMinimum = new Vector3(0f, 0f, 0f);
		rangeMaximum = new Vector3(0f, -1f, 0f);
	}

	public virtual void Start()
	{
		ssVolume = (SimpleSyncVolume)GetComponent(typeof(SimpleSyncVolume));
		if (!mouth)
		{
			mouth = transform;
		}
	}

	public virtual void Update()
	{
		Vector3 vector = default(Vector3);
		Vector3 vector2 = rangeMaximum - rangeMinimum;
		vector = vector2 * ssVolume.intensity * motionScale + rangeMinimum;
		vector = vector2 * ssVolume.intensity * motionScale + rangeMinimum;
		mouth.localPosition = vector;
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public enum JawAxis
{
	X,
	Y,
	Z
}
[Serializable]
[RequireComponent(typeof(SimpleSyncVolume))]
[ExecuteInEditMode]
public class SimpleSyncRotation : MonoBehaviour
{
	public Transform mouth;

	public float motionScale;

	public float rangeMinimum;

	public float rangeMaximum;

	public Vector3 origRot;

	public JawAxis jawAxis;

	private SimpleSyncVolume ssVolume;

	public SimpleSyncRotation()
	{
		motionScale = 10f;
		rangeMaximum = 1f;
		jawAxis = JawAxis.X;
	}

	public virtual void Start()
	{
		origRot = transform.localEulerAngles;
		ssVolume = (SimpleSyncVolume)GetComponent(typeof(SimpleSyncVolume));
		if (!mouth)
		{
			mouth = transform;
		}
	}

	public virtual void Update()
	{
		float num = default(float);
		float num2 = rangeMaximum - rangeMinimum;
		num = num2 * ssVolume.intensity * motionScale + rangeMinimum;
		switch (jawAxis)
		{
		case JawAxis.X:
			num += origRot.x;
			mouth.localEulerAngles = new Vector3(num, mouth.localEulerAngles.y, mouth.localEulerAngles.z);
			break;
		case JawAxis.Y:
			num += origRot.y;
			mouth.localEulerAngles = new Vector3(mouth.localEulerAngles.x, num, mouth.localEulerAngles.z);
			break;
		case JawAxis.Z:
			num += origRot.z;
			mouth.localEulerAngles = new Vector3(mouth.localEulerAngles.x, mouth.localEulerAngles.y, num);
			break;
		}
	}

	public virtual void Main()
	{
	}
}
[Serializable]
[RequireComponent(typeof(SimpleSyncVolume))]
public class SimpleSyncScale : MonoBehaviour
{
	public Transform mouth;

	public float motionScale;

	public Vector3 rangeMinimum;

	public Vector3 rangeMaximum;

	private SimpleSyncVolume ssVolume;

	public SimpleSyncScale()
	{
		motionScale = 10f;
		rangeMinimum = new Vector3(1f, 0.01f, 1f);
		rangeMaximum = Vector3.one;
	}

	public virtual void Start()
	{
		ssVolume = (SimpleSyncVolume)GetComponent(typeof(SimpleSyncVolume));
		if (!mouth)
		{
			mouth = transform;
		}
	}

	public virtual void Update()
	{
		Vector3 vector = default(Vector3);
		Vector3 vector2 = rangeMaximum - rangeMinimum;
		vector = vector2 * ssVolume.intensity * motionScale + rangeMinimum;
		mouth.localScale = vector;
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public enum Response
{
	VeryFast,
	Fast,
	Normal,
	Slow,
	VerySlow
}
[Serializable]
[RequireComponent(typeof(AudioSource))]
public class SimpleSyncVolume : MonoBehaviour
{
	[HideInInspector]
	public float intensity;

	public Response response;

	public int micSampleRate;

	public int delay;

	private int winWidth;

	private float[] samples;

	public SimpleSyncVolume()
	{
		response = Response.Normal;
		micSampleRate = 44100;
		delay = 1;
		winWidth = 8192;
	}

	public virtual void Start()
	{
		SetResponse(response);
	}

	public virtual void SetResponse(Response r)
	{
		response = r;
		switch (r)
		{
		case Response.VeryFast:
			winWidth = 1024;
			break;
		case Response.Fast:
			winWidth = 2048;
			break;
		case Response.Normal:
			winWidth = 4096;
			break;
		case Response.Slow:
			winWidth = 8192;
			break;
		case Response.VerySlow:
			winWidth = 16384;
			break;
		}
		samples = new float[winWidth];
	}

	public virtual void Update()
	{
		if (!GetComponent<AudioSource>().isPlaying)
		{
			intensity = 0f;
			return;
		}
		float num = 10000000f;
		float num2 = -10000000f;
		GetComponent<AudioSource>().GetOutputData(samples, 0);
		float num3 = 0f;
		for (int i = 0; i < winWidth; i++)
		{
			float num4 = Mathf.Abs(samples[i]);
			if (!(num4 >= num))
			{
				num = num4;
			}
			if (!(num4 <= num2))
			{
				num2 = num4;
			}
			num3 += num4;
		}
		num3 /= (float)winWidth;
		intensity = num3;
	}

	public virtual void Main()
	{
	}
}
